using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Cosmatic_Shop_Management.DAL;
using Cosmatic_Shop_Management.Helpers;

namespace Cosmatic_Shop_Management.Forms
{
    public partial class SuperAdminDashboardForm : Form
    {
        private int selectedTopShopId = 0;

        public SuperAdminDashboardForm()
        {
            InitializeComponent();
            InitializeDashboardEvents();
        }

        private void InitializeDashboardEvents()
        {
            this.Load -= SuperAdminDashboardForm_Load;
            this.Load += SuperAdminDashboardForm_Load;

            btnManageUsers.Click -= btnManageUsers_Click;
            btnManageUsers.Click += btnManageUsers_Click;

            btnLogout.Click -= btnLogout_Click;
            btnLogout.Click += btnLogout_Click;

            btnViewShopDetails.Click -= btnViewShopDetails_Click;
            btnViewShopDetails.Click += btnViewShopDetails_Click;

            btnFilterTransactions.Click -= btnFilterTransactions_Click;
            btnFilterTransactions.Click += btnFilterTransactions_Click;
        }

        private void SuperAdminDashboardForm_Load(object sender, EventArgs e)
        {
            SetupStaticUI();
            LoadAdminProfile();
            LoadSummaryCards();
            LoadRecentTransactions();
            LoadTopSellingShop();
        }

        private void SetupStaticUI()
        {
            this.Text = "Super Admin Dashboard";

            if (ControlExists("lblPlatformTitle"))
                lblPlatformTitle.Text = "Platform Overview";

            if (ControlExists("lblPlatformSubtitle"))
                lblPlatformSubtitle.Text = "Real-time metrics for cosmetic marketplace";

            if (ControlExists("lblTotalUsersText"))
                lblTotalUsersText.Text = "TOTAL USERS";

            if (ControlExists("lblActiveShopsText"))
                lblActiveShopsText.Text = "ACTIVE SHOPS";

            if (ControlExists("lblProductsText"))
                lblProductsText.Text = "PRODUCTS";

            if (ControlExists("lblGrossIncomeText"))
                lblGrossIncomeText.Text = "GROSS INCOME";

            if (ControlExists("lblCommissionsText"))
                lblCommissionsText.Text = "COMMISSIONS";

            if (ControlExists("lblRecentTransactionsTitle"))
                lblRecentTransactionsTitle.Text = "Recent Transactions";

            if (ControlExists("lblTopSellingShopTitle"))
                lblTopSellingShopTitle.Text = "Top-Selling Shop";

            if (ControlExists("lblMonthlyVolumeText"))
                lblMonthlyVolumeText.Text = "MONTHLY VOLUME";

            dgvRecentTransactions.AutoGenerateColumns = true;
            dgvRecentTransactions.ReadOnly = true;
            dgvRecentTransactions.AllowUserToAddRows = false;
            dgvRecentTransactions.AllowUserToDeleteRows = false;
            dgvRecentTransactions.AllowUserToResizeRows = false;
            dgvRecentTransactions.RowHeadersVisible = false;
            dgvRecentTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecentTransactions.MultiSelect = false;
            dgvRecentTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            progressMonthlyVolume.Minimum = 0;
            progressMonthlyVolume.Maximum = 100;
            progressMonthlyVolume.Value = 0;
        }

        private void LoadAdminProfile()
        {
            try
            {
                if (SessionManager.UserId <= 0)
                {
                    lblAdminName.Text = "--";
                    lblAdminProfileText.Text = "--";
                    return;
                }

                string query = @"
                    SELECT FullName
                    FROM Users
                    WHERE UserId = @UserId
                ";

                SqlParameter[] parameters =
                {
                    new SqlParameter("@UserId", SessionManager.UserId)
                };

                DataTable dt = DatabaseHelper.GetDataTable(query, parameters);

                if (dt.Rows.Count > 0)
                {
                    string fullName = dt.Rows[0]["FullName"].ToString() ?? "--";
                    lblAdminName.Text = fullName;
                    lblAdminProfileText.Text = "ADMIN PROFILE";
                }
                else
                {
                    lblAdminName.Text = "--";
                    lblAdminProfileText.Text = "ADMIN PROFILE";
                }

                picAdminProfile.BackColor = Color.Purple;
            }
            catch
            {
                lblAdminName.Text = "--";
                lblAdminProfileText.Text = "ADMIN PROFILE";
            }
        }

        private void LoadSummaryCards()
        {
            try
            {
                string totalUsersQuery = "SELECT COUNT(*) FROM Users";

                string activeShopsQuery = "SELECT COUNT(*) FROM Shops WHERE IsActive = 1";

                string productsQuery = "SELECT COUNT(*) FROM Products WHERE IsActive = 1";

                string grossIncomeQuery = @"
                    SELECT ISNULL(SUM(TotalAmount), 0)
                    FROM Orders
                    WHERE OrderStatus <> 'Cancelled'
                ";

                string commissionsQuery = @"
                    SELECT ISNULL(SUM(CommissionAmount), 0)
                    FROM PlatformCommission
                ";

                object totalUsers = DatabaseHelper.ExecuteScalar(totalUsersQuery);
                object activeShops = DatabaseHelper.ExecuteScalar(activeShopsQuery);
                object totalProducts = DatabaseHelper.ExecuteScalar(productsQuery);
                object grossIncome = DatabaseHelper.ExecuteScalar(grossIncomeQuery);
                object commissions = DatabaseHelper.ExecuteScalar(commissionsQuery);

                lblTotalUsers.Text = Convert.ToInt32(totalUsers).ToString();
                lblActiveShops.Text = Convert.ToInt32(activeShops).ToString();
                lblProducts.Text = Convert.ToInt32(totalProducts).ToString();
                lblGrossIncome.Text = Convert.ToDecimal(grossIncome).ToString("0.00") + " Tk";
                lblCommissions.Text = Convert.ToDecimal(commissions).ToString("0.00") + " Tk";

                if (ControlExists("lblTotalUsersChange")) lblTotalUsersChange.Text = "--";
                if (ControlExists("lblActiveShopsChange")) lblActiveShopsChange.Text = "--";
                if (ControlExists("lblProductsChange")) lblProductsChange.Text = "--";
                if (ControlExists("lblGrossIncomeChange")) lblGrossIncomeChange.Text = "--";
                if (ControlExists("lblCommissionsChange")) lblCommissionsChange.Text = "--";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Summary load error: " + ex.Message);
            }
        }

        private void LoadRecentTransactions()
        {
            try
            {
                string query = @"
                    SELECT TOP 10
                        O.OrderId AS [Order ID],
                        S.ShopName AS [Shop],
                        U.FullName AS [Customer],
                        O.OrderStatus AS [Status],
                        O.TotalAmount AS [Amount],
                        O.OrderDate AS [Date]
                    FROM Orders O
                    INNER JOIN Users U ON O.CustomerUserId = U.UserId
                    INNER JOIN OrderItems OI ON O.OrderId = OI.OrderId
                    INNER JOIN Shops S ON OI.ShopId = S.ShopId
                    ORDER BY O.OrderDate DESC, O.OrderId DESC
                ";

                DataTable dt = DatabaseHelper.GetDataTable(query);
                dgvRecentTransactions.DataSource = dt;

                if (dgvRecentTransactions.Columns.Contains("Amount"))
                    dgvRecentTransactions.Columns["Amount"].DefaultCellStyle.Format = "0.00";

                if (dgvRecentTransactions.Columns.Contains("Date"))
                    dgvRecentTransactions.Columns["Date"].DefaultCellStyle.Format = "dd-MMM-yyyy";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Recent transactions load error: " + ex.Message);
            }
        }

        private void LoadTopSellingShop()
        {
            try
            {
                string query = @"
                    SELECT TOP 1
                        S.ShopId,
                        S.ShopName,
                        U.FullName AS OwnerName,
                        S.LogoPath,
                        ISNULL(SUM(OI.LineTotal), 0) AS MonthlyVolume
                    FROM Shops S
                    LEFT JOIN Users U ON S.OwnerUserId = U.UserId
                    LEFT JOIN OrderItems OI ON S.ShopId = OI.ShopId
                    LEFT JOIN Orders O ON OI.OrderId = O.OrderId
                    WHERE S.IsActive = 1
                      AND (
                            O.OrderDate IS NULL OR
                            (MONTH(O.OrderDate) = MONTH(GETDATE()) AND YEAR(O.OrderDate) = YEAR(GETDATE()))
                          )
                    GROUP BY S.ShopId, S.ShopName, U.FullName, S.LogoPath
                    ORDER BY MonthlyVolume DESC, S.ShopId DESC
                ";

                DataTable dt = DatabaseHelper.GetDataTable(query);

                if (dt.Rows.Count == 0)
                {
                    selectedTopShopId = 0;
                    lblTopShopName.Text = "--";
                    lblTopShopOwner.Text = "Managed by --";
                    lblMonthlyVolume.Text = "0 Tk";
                    progressMonthlyVolume.Value = 0;
                    picTopShop.Image = null;
                    return;
                }

                DataRow row = dt.Rows[0];

                selectedTopShopId = Convert.ToInt32(row["ShopId"]);
                lblTopShopName.Text = row["ShopName"].ToString() ?? "--";
                lblTopShopOwner.Text = "Managed by " + (row["OwnerName"].ToString() ?? "--");

                decimal monthlyVolume = Convert.ToDecimal(row["MonthlyVolume"]);
                lblMonthlyVolume.Text = monthlyVolume.ToString("0.00") + " Tk";

                int progressValue = 0;
                if (monthlyVolume > 0)
                {
                    decimal capped = monthlyVolume > 100000 ? 100000 : monthlyVolume;
                    progressValue = (int)((capped / 100000m) * 100m);
                }

                if (progressValue < 0) progressValue = 0;
                if (progressValue > 100) progressValue = 100;
                progressMonthlyVolume.Value = progressValue;

                string logoPath = row["LogoPath"].ToString() ?? "";
                LoadTopShopImage(logoPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Top-selling shop load error: " + ex.Message);
            }
        }

        private void LoadTopShopImage(string imagePath)
        {
            try
            {
                if (picTopShop.Image != null)
                {
                    picTopShop.Image.Dispose();
                    picTopShop.Image = null;
                }

                if (!string.IsNullOrWhiteSpace(imagePath) && File.Exists(imagePath))
                {
                    byte[] bytes = File.ReadAllBytes(imagePath);
                    using (MemoryStream ms = new MemoryStream(bytes))
                    using (Image temp = Image.FromStream(ms))
                    {
                        picTopShop.Image = new Bitmap(temp);
                    }

                    picTopShop.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    picTopShop.Image = null;
                    picTopShop.BackColor = Color.LavenderBlush;
                }
            }
            catch
            {
                picTopShop.Image = null;
            }
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            try
            {
                ManageUsersForm form = new ManageUsersForm();
                form.ShowDialog();
                LoadSummaryCards();
                LoadRecentTransactions();
                LoadTopSellingShop();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Open manage users error: " + ex.Message);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            SessionManager.Clear();
            LoginForm form = new LoginForm();
            form.Show();
            this.Close();
        }

        private void btnViewShopDetails_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedTopShopId <= 0)
                {
                    MessageBox.Show("No shop selected.");
                    return;
                }

                ManageShopForm form = new ManageShopForm(selectedTopShopId);
                form.ShowDialog();

                LoadSummaryCards();
                LoadRecentTransactions();
                LoadTopSellingShop();
            }
            catch
            {
                MessageBox.Show("Shop details form is not connected yet.");
            }
        }

        private void btnFilterTransactions_Click(object sender, EventArgs e)
        {
            LoadRecentTransactions();
        }

        private bool ControlExists(string controlName)
        {
            return FindControlRecursive(this, controlName) != null;
        }

        private Control? FindControlRecursive(Control parent, string controlName)
        {
            foreach (Control control in parent.Controls)
            {
                if (control.Name == controlName)
                    return control;

                Control? child = FindControlRecursive(control, controlName);
                if (child != null)
                    return child;
            }

            return null;
        }
    }
}