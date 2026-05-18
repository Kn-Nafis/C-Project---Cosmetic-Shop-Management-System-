using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Cosmatic_Shop_Management.DAL;
using Cosmatic_Shop_Management.Helpers;

namespace Cosmatic_Shop_Management.Forms
{
    public partial class AnalyticsForm : Form
    {
        private int myShopId = 0;
        private DataTable allTransactions = new DataTable();
        private int currentPage = 1;
        private int pageSize = 5;

        public AnalyticsForm()
        {
            InitializeComponent();

            this.Load += AnalyticsForm_Load;

            btnApplyFilter.Click -= btnApplyFilter_Click;
            btnApplyFilter.Click += btnApplyFilter_Click;

            btnGoBack.Click -= btnGoBack_Click;
            btnGoBack.Click += btnGoBack_Click;

            btnPrevPage.Click -= btnPrevPage_Click;
            btnPrevPage.Click += btnPrevPage_Click;

            btnNextPage.Click -= btnNextPage_Click;
            btnNextPage.Click += btnNextPage_Click;

            btnPage1.Click -= btnPage1_Click;
            btnPage1.Click += btnPage1_Click;

            btnPage2.Click -= btnPage2_Click;
            btnPage2.Click += btnPage2_Click;

            btnPage3.Click -= btnPage3_Click;
            btnPage3.Click += btnPage3_Click;
        }

        private void AnalyticsForm_Load(object sender, EventArgs e)
        {
            myShopId = GetMyShopId();

            if (myShopId <= 0)
            {
                MessageBox.Show("No shop found for this admin.");
                return;
            }

            SetupForm();
            LoadAnalyticsData();
        }

        private void SetupForm()
        {
            this.Text = "Analytics Report";

            lblFormTitle.Text = "Sales Revenue Report";
            lblSubtitle.Text = "Financial performance overview for your shop.";

            dtpFrom.Value = DateTime.Today.AddMonths(-1);
            dtpTo.Value = DateTime.Today;

            dgvTransactions.AutoGenerateColumns = true;
            dgvTransactions.ReadOnly = true;
            dgvTransactions.AllowUserToAddRows = false;
            dgvTransactions.AllowUserToDeleteRows = false;
            dgvTransactions.AllowUserToResizeRows = false;
            dgvTransactions.RowHeadersVisible = false;
            dgvTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransactions.MultiSelect = false;
            dgvTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransactions.BackgroundColor = System.Drawing.Color.White;
            dgvTransactions.BorderStyle = BorderStyle.None;

            lblTotalRevenue.Text = "0.00 Tk";
            lblShopIncome.Text = "0.00 Tk";
            lblCommissionPaid.Text = "0.00 Tk";

            lblCategory1.Text = "SKINCARE";
            lblCategory2.Text = "MAKEUP";
            lblCategory3.Text = "FRAGRANCE";

            lblCategory1Percent.Text = "0%";
            lblCategory2Percent.Text = "0%";
            lblCategory3Percent.Text = "0%";

            progressCategory1.Minimum = 0;
            progressCategory1.Maximum = 100;
            progressCategory1.Value = 0;

            progressCategory2.Minimum = 0;
            progressCategory2.Maximum = 100;
            progressCategory2.Value = 0;

            progressCategory3.Minimum = 0;
            progressCategory3.Maximum = 100;
            progressCategory3.Value = 0;

            HighlightCurrentPageButton();
        }

        private int GetMyShopId()
        {
            try
            {
                string query = @"
                    SELECT TOP 1 ShopId
                    FROM Shops
                    WHERE OwnerUserId = @OwnerUserId
                    ORDER BY ShopId DESC
                ";

                SqlParameter[] parameters =
                {
                    new SqlParameter("@OwnerUserId", SessionManager.UserId)
                };

                object result = DatabaseHelper.ExecuteScalar(query, parameters);

                if (result == null || result == DBNull.Value)
                    return 0;

                return Convert.ToInt32(result);
            }
            catch
            {
                return 0;
            }
        }

        private void LoadAnalyticsData()
        {
            LoadSummaryCards();
            LoadTransactions();
            LoadCategorySales();
        }

        private void LoadSummaryCards()
        {
            try
            {
                string revenueQuery = @"
                    SELECT ISNULL(SUM(OI.LineTotal), 0)
                    FROM OrderItems OI
                    INNER JOIN Orders O ON OI.OrderId = O.OrderId
                    WHERE OI.ShopId = @ShopId
                      AND O.OrderStatus <> 'Cancelled'
                      AND CAST(O.OrderDate AS DATE) BETWEEN @FromDate AND @ToDate
                ";

                string incomeQuery = @"
                    SELECT ISNULL(SUM(OI.ShopIncome), 0)
                    FROM OrderItems OI
                    INNER JOIN Orders O ON OI.OrderId = O.OrderId
                    WHERE OI.ShopId = @ShopId
                      AND O.OrderStatus <> 'Cancelled'
                      AND CAST(O.OrderDate AS DATE) BETWEEN @FromDate AND @ToDate
                ";

                string commissionQuery = @"
                    SELECT ISNULL(SUM(OI.PlatformCommission), 0)
                    FROM OrderItems OI
                    INNER JOIN Orders O ON OI.OrderId = O.OrderId
                    WHERE OI.ShopId = @ShopId
                      AND O.OrderStatus <> 'Cancelled'
                      AND CAST(O.OrderDate AS DATE) BETWEEN @FromDate AND @ToDate
                ";

                SqlParameter[] parameters1 =
                {
                    new SqlParameter("@ShopId", myShopId),
                    new SqlParameter("@FromDate", dtpFrom.Value.Date),
                    new SqlParameter("@ToDate", dtpTo.Value.Date)
                };

                SqlParameter[] parameters2 =
                {
                    new SqlParameter("@ShopId", myShopId),
                    new SqlParameter("@FromDate", dtpFrom.Value.Date),
                    new SqlParameter("@ToDate", dtpTo.Value.Date)
                };

                SqlParameter[] parameters3 =
                {
                    new SqlParameter("@ShopId", myShopId),
                    new SqlParameter("@FromDate", dtpFrom.Value.Date),
                    new SqlParameter("@ToDate", dtpTo.Value.Date)
                };

                decimal totalRevenue = Convert.ToDecimal(DatabaseHelper.ExecuteScalar(revenueQuery, parameters1));
                decimal shopIncome = Convert.ToDecimal(DatabaseHelper.ExecuteScalar(incomeQuery, parameters2));
                decimal commissionPaid = Convert.ToDecimal(DatabaseHelper.ExecuteScalar(commissionQuery, parameters3));

                lblTotalRevenue.Text = totalRevenue.ToString("0.00") + " Tk";
                lblShopIncome.Text = shopIncome.ToString("0.00") + " Tk";
                lblCommissionPaid.Text = commissionPaid.ToString("0.00") + " Tk";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Summary load error: " + ex.Message);
            }
        }

        private void LoadTransactions()
        {
            try
            {
                string query = @"
                    SELECT
                        O.OrderId AS [Transaction ID],
                        O.OrderDate AS [Date & Time],
                        U.FullName AS [Customer Name],
                        C.CategoryName AS [Product Category],
                        CAST(OI.LineTotal AS DECIMAL(10,2)) AS [Order Total],
                        CAST(OI.PlatformCommission AS DECIMAL(10,2)) AS [Commission],
                        O.OrderStatus AS [Status]
                    FROM Orders O
                    INNER JOIN Users U ON O.CustomerUserId = U.UserId
                    INNER JOIN OrderItems OI ON O.OrderId = OI.OrderId
                    INNER JOIN Products P ON OI.ProductId = P.ProductId
                    INNER JOIN Categories C ON P.CategoryId = C.CategoryId
                    WHERE OI.ShopId = @ShopId
                      AND CAST(O.OrderDate AS DATE) BETWEEN @FromDate AND @ToDate
                    ORDER BY O.OrderDate DESC, O.OrderId DESC
                ";

                SqlParameter[] parameters =
                {
                    new SqlParameter("@ShopId", myShopId),
                    new SqlParameter("@FromDate", dtpFrom.Value.Date),
                    new SqlParameter("@ToDate", dtpTo.Value.Date)
                };

                allTransactions = DatabaseHelper.GetDataTable(query, parameters);
                BindPagedTransactions();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Transaction load error: " + ex.Message);
            }
        }

        private void BindPagedTransactions()
        {
            try
            {
                if (allTransactions == null || allTransactions.Rows.Count == 0)
                {
                    dgvTransactions.DataSource = null;
                    lblRecordInfo.Text = "Showing 0 records";
                    return;
                }

                int totalRows = allTransactions.Rows.Count;
                int totalPages = (int)Math.Ceiling(totalRows / (double)pageSize);

                if (totalPages == 0) totalPages = 1;
                if (currentPage > totalPages) currentPage = totalPages;
                if (currentPage < 1) currentPage = 1;

                DataTable displayTable = allTransactions.Clone();

                int startIndex = (currentPage - 1) * pageSize;
                int endIndex = Math.Min(startIndex + pageSize, totalRows);

                for (int i = startIndex; i < endIndex; i++)
                {
                    displayTable.ImportRow(allTransactions.Rows[i]);
                }

                dgvTransactions.DataSource = displayTable;

                if (dgvTransactions.Columns.Contains("Date & Time"))
                    dgvTransactions.Columns["Date & Time"].DefaultCellStyle.Format = "dd-MMM-yyyy HH:mm";

                if (dgvTransactions.Columns.Contains("Order Total"))
                    dgvTransactions.Columns["Order Total"].DefaultCellStyle.Format = "0.00";

                if (dgvTransactions.Columns.Contains("Commission"))
                    dgvTransactions.Columns["Commission"].DefaultCellStyle.Format = "0.00";

                lblRecordInfo.Text = "Showing " + startIndex + 1 + " to " + endIndex + " of " + totalRows + " records";

                btnPrevPage.Enabled = currentPage > 1;
                btnNextPage.Enabled = currentPage < totalPages;

                btnPage1.Visible = totalPages >= 1;
                btnPage2.Visible = totalPages >= 2;
                btnPage3.Visible = totalPages >= 3;

                HighlightCurrentPageButton();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pagination error: " + ex.Message);
            }
        }

        private void LoadCategorySales()
        {
            try
            {
                string query = @"
                    SELECT
                        C.CategoryName,
                        ISNULL(SUM(OI.LineTotal), 0) AS TotalSales
                    FROM OrderItems OI
                    INNER JOIN Orders O ON OI.OrderId = O.OrderId
                    INNER JOIN Products P ON OI.ProductId = P.ProductId
                    INNER JOIN Categories C ON P.CategoryId = C.CategoryId
                    WHERE OI.ShopId = @ShopId
                      AND O.OrderStatus <> 'Cancelled'
                      AND CAST(O.OrderDate AS DATE) BETWEEN @FromDate AND @ToDate
                    GROUP BY C.CategoryName
                    ORDER BY TotalSales DESC
                ";

                SqlParameter[] parameters =
                {
                    new SqlParameter("@ShopId", myShopId),
                    new SqlParameter("@FromDate", dtpFrom.Value.Date),
                    new SqlParameter("@ToDate", dtpTo.Value.Date)
                };

                DataTable dt = DatabaseHelper.GetDataTable(query, parameters);

                decimal totalSales = 0m;
                foreach (DataRow row in dt.Rows)
                {
                    totalSales += Convert.ToDecimal(row["TotalSales"]);
                }

                string[] names = { "SKINCARE", "MAKEUP", "FRAGRANCE" };
                Label[] percentLabels = { lblCategory1Percent, lblCategory2Percent, lblCategory3Percent };
                ProgressBar[] bars = { progressCategory1, progressCategory2, progressCategory3 };

                for (int i = 0; i < percentLabels.Length; i++)
                {
                    percentLabels[i].Text = "0%";
                    bars[i].Value = 0;
                }

                for (int i = 0; i < Math.Min(3, dt.Rows.Count); i++)
                {
                    string categoryName = dt.Rows[i]["CategoryName"].ToString() ?? "";
                    decimal categorySales = Convert.ToDecimal(dt.Rows[i]["TotalSales"]);

                    int percent = 0;
                    if (totalSales > 0)
                        percent = (int)Math.Round((categorySales / totalSales) * 100m);

                    if (i == 0)
                    {
                        lblCategory1.Text = categoryName.ToUpper();
                        lblCategory1Percent.Text = percent + "%";
                        progressCategory1.Value = Math.Max(0, Math.Min(100, percent));
                    }
                    else if (i == 1)
                    {
                        lblCategory2.Text = categoryName.ToUpper();
                        lblCategory2Percent.Text = percent + "%";
                        progressCategory2.Value = Math.Max(0, Math.Min(100, percent));
                    }
                    else if (i == 2)
                    {
                        lblCategory3.Text = categoryName.ToUpper();
                        lblCategory3Percent.Text = percent + "%";
                        progressCategory3.Value = Math.Max(0, Math.Min(100, percent));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Category sales load error: " + ex.Message);
            }
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            if (dtpFrom.Value.Date > dtpTo.Value.Date)
            {
                MessageBox.Show("Date From cannot be greater than Date To.");
                return;
            }

            currentPage = 1;
            LoadAnalyticsData();
        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                BindPagedTransactions();
            }
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            int totalPages = (int)Math.Ceiling(allTransactions.Rows.Count / (double)pageSize);
            if (currentPage < totalPages)
            {
                currentPage++;
                BindPagedTransactions();
            }
        }

        private void btnPage1_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            BindPagedTransactions();
        }

        private void btnPage2_Click(object sender, EventArgs e)
        {
            currentPage = 2;
            BindPagedTransactions();
        }

        private void btnPage3_Click(object sender, EventArgs e)
        {
            currentPage = 3;
            BindPagedTransactions();
        }

        private void HighlightCurrentPageButton()
        {
            ResetPageButton(btnPage1);
            ResetPageButton(btnPage2);
            ResetPageButton(btnPage3);

            if (currentPage == 1) SetActivePageButton(btnPage1);
            else if (currentPage == 2) SetActivePageButton(btnPage2);
            else if (currentPage == 3) SetActivePageButton(btnPage3);
        }

        private void ResetPageButton(Button btn)
        {
            btn.BackColor = System.Drawing.Color.White;
            btn.ForeColor = System.Drawing.Color.Black;
            btn.FlatStyle = FlatStyle.Flat;
        }

        private void SetActivePageButton(Button btn)
        {
            btn.BackColor = System.Drawing.Color.Purple;
            btn.ForeColor = System.Drawing.Color.White;
            btn.FlatStyle = FlatStyle.Flat;
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblShopIncome_Click(object sender, EventArgs e)
        {

        }
    }
}