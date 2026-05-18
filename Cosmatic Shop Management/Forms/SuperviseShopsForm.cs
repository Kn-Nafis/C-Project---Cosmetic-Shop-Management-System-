using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Cosmatic_Shop_Management.DAL;

namespace Cosmatic_Shop_Management.Forms
{
    public partial class SuperviseShopsForm : Form
    {
        private DataTable allShops = new DataTable();
        private int selectedShopId = 0;

        public SuperviseShopsForm()
        {
            InitializeComponent();
            InitializeEvents();
        }

        private void InitializeEvents()
        {
            this.Load -= SuperviseShopsForm_Load;
            this.Load += SuperviseShopsForm_Load;

            btnApplyFilters.Click -= btnApplyFilters_Click;
            btnApplyFilters.Click += btnApplyFilters_Click;

            btnRefresh.Click -= btnRefresh_Click;
            btnRefresh.Click += btnRefresh_Click;

            btnBack.Click -= btnBack_Click;
            btnBack.Click += btnBack_Click;

            txtSearchShop.TextChanged -= txtSearchShop_TextChanged;
            txtSearchShop.TextChanged += txtSearchShop_TextChanged;

            dgvShops.SelectionChanged -= dgvShops_SelectionChanged;
            dgvShops.SelectionChanged += dgvShops_SelectionChanged;

            btnActivateShop.Click -= btnActivateShop_Click;
            btnActivateShop.Click += btnActivateShop_Click;

            btnDeactivateShop.Click -= btnDeactivateShop_Click;
            btnDeactivateShop.Click += btnDeactivateShop_Click;

            btnViewProducts.Click -= btnViewProducts_Click;
            btnViewProducts.Click += btnViewProducts_Click;

            btnViewOrders.Click -= btnViewOrders_Click;
            btnViewOrders.Click += btnViewOrders_Click;
        }

        private void SuperviseShopsForm_Load(object sender, EventArgs e)
        {
            SetupUI();
            LoadStatusFilter();
            LoadOwnerFilter();
            LoadShops();
            ApplyFiltersAndBind();
        }

        private void SetupUI()
        {
            this.Text = "Supervise Shops";

            lblTitle.Text = "Supervise Shops";
            lblSubtitle.Text = "Monitor all shops, owners, and activation status";
            lblShopListTitle.Text = "SHOP LIST";
            lblShopDetailsTitle.Text = "SHOP DETAILS";

            dgvShops.AutoGenerateColumns = true;
            dgvShops.ReadOnly = true;
            dgvShops.AllowUserToAddRows = false;
            dgvShops.AllowUserToDeleteRows = false;
            dgvShops.AllowUserToResizeRows = false;
            dgvShops.MultiSelect = false;
            dgvShops.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvShops.RowHeadersVisible = false;
            dgvShops.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvShops.BackgroundColor = Color.White;
            dgvShops.BorderStyle = BorderStyle.FixedSingle;

            ClearShopDetails();
        }

        private void LoadStatusFilter()
        {
            cmbStatusFilter.Items.Clear();
            cmbStatusFilter.Items.Add("All");
            cmbStatusFilter.Items.Add("Active");
            cmbStatusFilter.Items.Add("Inactive");
            cmbStatusFilter.SelectedIndex = 0;
        }

        private void LoadOwnerFilter()
        {
            try
            {
                cmbOwnerFilter.Items.Clear();
                cmbOwnerFilter.Items.Add("All Owners");

                string query = @"
                    SELECT DISTINCT U.FullName
                    FROM Shops S
                    INNER JOIN Users U ON S.OwnerUserId = U.UserId
                    ORDER BY U.FullName
                ";

                DataTable dt = DatabaseHelper.GetDataTable(query);

                foreach (DataRow row in dt.Rows)
                {
                    cmbOwnerFilter.Items.Add(row["FullName"].ToString());
                }

                cmbOwnerFilter.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Owner filter load error: " + ex.Message);
            }
        }

        private void LoadShops()
        {
            try
            {
                string query = @"
                    SELECT
                        S.ShopId,
                        S.ShopName,
                        S.ShopDescription,
                        U.FullName AS OwnerName,
                        S.BrandAffiliation,
                        S.ContactPhone,
                        S.EmailAddress,
                        S.PhysicalAddress,
                        S.LogoPath,
                        CASE WHEN S.IsActive = 1 THEN 'Active' ELSE 'Inactive' END AS ShopStatus,
                        S.CreatedAt
                    FROM Shops S
                    LEFT JOIN Users U ON S.OwnerUserId = U.UserId
                    ORDER BY S.ShopId DESC
                ";

                allShops = DatabaseHelper.GetDataTable(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Shop load error: " + ex.Message);
            }
        }

        private void ApplyFiltersAndBind()
        {
            try
            {
                if (allShops == null || allShops.Rows.Count == 0)
                {
                    dgvShops.DataSource = null;
                    ClearShopDetails();
                    return;
                }

                var rows = allShops.AsEnumerable();

                string search = txtSearchShop.Text.Trim().ToLower();
                if (!string.IsNullOrWhiteSpace(search) &&
                    !search.Equals("Search shop...", StringComparison.OrdinalIgnoreCase) &&
                    !search.Equals("Search shop...", StringComparison.OrdinalIgnoreCase) &&
                    !search.Equals("Search shop. . .", StringComparison.OrdinalIgnoreCase) &&
                    !search.Equals("Search shop...", StringComparison.OrdinalIgnoreCase))
                {
                    rows = rows.Where(r =>
                        (r["ShopName"].ToString() ?? "").ToLower().Contains(search) ||
                        (r["OwnerName"].ToString() ?? "").ToLower().Contains(search) ||
                        (r["BrandAffiliation"].ToString() ?? "").ToLower().Contains(search) ||
                        (r["ContactPhone"].ToString() ?? "").ToLower().Contains(search) ||
                        (r["EmailAddress"].ToString() ?? "").ToLower().Contains(search));
                }

                string selectedStatus = cmbStatusFilter.Text.Trim();
                if (selectedStatus == "Active")
                {
                    rows = rows.Where(r => (r["ShopStatus"].ToString() ?? "") == "Active");
                }
                else if (selectedStatus == "Inactive")
                {
                    rows = rows.Where(r => (r["ShopStatus"].ToString() ?? "") == "Inactive");
                }

                string selectedOwner = cmbOwnerFilter.Text.Trim();
                if (!string.IsNullOrWhiteSpace(selectedOwner) && selectedOwner != "All Owners")
                {
                    rows = rows.Where(r =>
                        (r["OwnerName"].ToString() ?? "").Equals(selectedOwner, StringComparison.OrdinalIgnoreCase));
                }

                DataTable filteredTable = rows.Any() ? rows.CopyToDataTable() : allShops.Clone();

                dgvShops.DataSource = filteredTable;
                FormatGrid();

                if (dgvShops.Rows.Count > 0)
                {
                    dgvShops.Rows[0].Selected = true;
                    LoadSelectedShopDetails();
                }
                else
                {
                    ClearShopDetails();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Filter error: " + ex.Message);
            }
        }

        private void FormatGrid()
        {
            if (dgvShops.Columns.Contains("ShopDescription"))
                dgvShops.Columns["ShopDescription"].Visible = false;

            if (dgvShops.Columns.Contains("PhysicalAddress"))
                dgvShops.Columns["PhysicalAddress"].Visible = false;

            if (dgvShops.Columns.Contains("LogoPath"))
                dgvShops.Columns["LogoPath"].Visible = false;

            if (dgvShops.Columns.Contains("CreatedAt"))
                dgvShops.Columns["CreatedAt"].DefaultCellStyle.Format = "dd-MMM-yyyy";
        }

        private void dgvShops_SelectionChanged(object sender, EventArgs e)
        {
            LoadSelectedShopDetails();
        }

        private void LoadSelectedShopDetails()
        {
            try
            {
                if (dgvShops.CurrentRow == null || dgvShops.CurrentRow.Cells["ShopId"].Value == null)
                {
                    ClearShopDetails();
                    return;
                }

                selectedShopId = Convert.ToInt32(dgvShops.CurrentRow.Cells["ShopId"].Value);

                DataRowView rowView = dgvShops.CurrentRow.DataBoundItem as DataRowView;
                if (rowView == null)
                {
                    ClearShopDetails();
                    return;
                }

                DataRow row = rowView.Row;

                lblShopName.Text = row["ShopName"].ToString() ?? "--";
                lblOwnerName.Text = row["OwnerName"].ToString() ?? "--";
                lblPhone.Text = row["ContactPhone"].ToString() ?? "--";
                lblEmail.Text = row["EmailAddress"].ToString() ?? "--";
                lblAddress.Text = row["PhysicalAddress"].ToString() ?? "--";
                lblStatus.Text = row["ShopStatus"].ToString() ?? "--";
                lblCreatedAt.Text = Convert.ToDateTime(row["CreatedAt"]).ToString("dd MMM yyyy");

                string logoPath = row["LogoPath"].ToString() ?? "";
                LoadShopLogo(logoPath);

                bool isActive = (row["ShopStatus"].ToString() ?? "") == "Active";
                btnActivateShop.Enabled = !isActive;
                btnDeactivateShop.Enabled = isActive;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Shop detail load error: " + ex.Message);
            }
        }

        private void LoadShopLogo(string logoPath)
        {
            try
            {
                if (picShopLogo.Image != null)
                {
                    picShopLogo.Image.Dispose();
                    picShopLogo.Image = null;
                }

                if (!string.IsNullOrWhiteSpace(logoPath) && File.Exists(logoPath))
                {
                    byte[] bytes = File.ReadAllBytes(logoPath);
                    using (MemoryStream ms = new MemoryStream(bytes))
                    using (Image temp = Image.FromStream(ms))
                    {
                        picShopLogo.Image = new Bitmap(temp);
                    }

                    picShopLogo.SizeMode = PictureBoxSizeMode.StretchImage;
                    lblShopLogoPlaceholder.Visible = false;
                }
                else
                {
                    picShopLogo.Image = null;
                    lblShopLogoPlaceholder.Visible = true;
                }
            }
            catch
            {
                picShopLogo.Image = null;
                lblShopLogoPlaceholder.Visible = true;
            }
        }

        private void ClearShopDetails()
        {
            selectedShopId = 0;

            lblShopName.Text = "--";
            lblOwnerName.Text = "--";
            lblPhone.Text = "--";
            lblEmail.Text = "--";
            lblAddress.Text = "--";
            lblStatus.Text = "--";
            lblCreatedAt.Text = "--";

            if (picShopLogo.Image != null)
            {
                picShopLogo.Image.Dispose();
                picShopLogo.Image = null;
            }

            lblShopLogoPlaceholder.Visible = true;

            btnActivateShop.Enabled = false;
            btnDeactivateShop.Enabled = false;
        }

        private void UpdateShopStatus(bool isActive)
        {
            try
            {
                if (selectedShopId <= 0)
                {
                    MessageBox.Show("Please select a shop first.");
                    return;
                }

                string query = @"
                    UPDATE Shops
                    SET IsActive = @IsActive
                    WHERE ShopId = @ShopId
                ";

                SqlParameter[] parameters =
                {
                    new SqlParameter("@IsActive", isActive),
                    new SqlParameter("@ShopId", selectedShopId)
                };

                DatabaseHelper.ExecuteNonQuery(query, parameters);

                MessageBox.Show(isActive ? "Shop activated successfully." : "Shop deactivated successfully.");

                LoadShops();
                ApplyFiltersAndBind();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Status update error: " + ex.Message);
            }
        }

        private void btnActivateShop_Click(object sender, EventArgs e)
        {
            UpdateShopStatus(true);
        }

        private void btnDeactivateShop_Click(object sender, EventArgs e)
        {
            UpdateShopStatus(false);
        }

        private void btnViewProducts_Click(object sender, EventArgs e)
        {
            if (selectedShopId <= 0)
            {
                MessageBox.Show("Please select a shop first.");
                return;
            }

            MessageBox.Show("View Products for Shop ID: " + selectedShopId);
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            if (selectedShopId <= 0)
            {
                MessageBox.Show("Please select a shop first.");
                return;
            }

            MessageBox.Show("View Orders for Shop ID: " + selectedShopId);
        }

        private void btnApplyFilters_Click(object sender, EventArgs e)
        {
            ApplyFiltersAndBind();
        }

        private void txtSearchShop_TextChanged(object sender, EventArgs e)
        {
            ApplyFiltersAndBind();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearchShop.Clear();
            cmbStatusFilter.SelectedIndex = 0;
            cmbOwnerFilter.SelectedIndex = 0;
            LoadShops();
            ApplyFiltersAndBind();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}