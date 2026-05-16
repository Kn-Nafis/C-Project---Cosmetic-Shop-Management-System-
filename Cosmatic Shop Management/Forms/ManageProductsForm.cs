using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Cosmatic_Shop_Management.DAL;

namespace Cosmatic_Shop_Management.Forms
{
    public partial class ManageProductsForm : Form
    {
        public ManageProductsForm()
        {
            InitializeComponent();

            this.Load += ManageProductsForm_Load;

            btnGoBack.Click -= btnGoBack_Click;
            btnGoBack.Click += btnGoBack_Click;

            btnAddProduct.Click -= btnAddProduct_Click;
            btnAddProduct.Click += btnAddProduct_Click;

            btnEditProduct.Click -= btnEditProduct_Click;
            btnEditProduct.Click += btnEditProduct_Click;

            btnApplyFilters.Click -= btnApplyFilters_Click;
            btnApplyFilters.Click += btnApplyFilters_Click;

            txtSearchProducts.TextChanged -= txtSearchProducts_TextChanged;
            txtSearchProducts.TextChanged += txtSearchProducts_TextChanged;

            lnkViewDetails.LinkClicked -= lnkViewDetails_LinkClicked;
            lnkViewDetails.LinkClicked += lnkViewDetails_LinkClicked;
        }

        private void ManageProductsForm_Load(object sender, EventArgs e)
        {
            LoadCategoryFilter();
            LoadStockStatusFilter();
            LoadProducts();
            LoadSummaryCards();
            LoadLowStockAlert();
        }

        private void LoadCategoryFilter()
        {
            try
            {
                cmbCategoryFilter.Items.Clear();
                cmbCategoryFilter.Items.Add("All Categories");

                string query = "SELECT CategoryName FROM Categories ORDER BY CategoryName";
                DataTable dt = DatabaseHelper.GetDataTable(query);

                foreach (DataRow row in dt.Rows)
                {
                    cmbCategoryFilter.Items.Add(row["CategoryName"].ToString());
                }

                cmbCategoryFilter.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Category filter load error: " + ex.Message);
            }
        }

        private void LoadStockStatusFilter()
        {
            cmbStockStatusFilter.Items.Clear();
            cmbStockStatusFilter.Items.Add("All Items");
            cmbStockStatusFilter.Items.Add("Active");
            cmbStockStatusFilter.Items.Add("Low Stock");
            cmbStockStatusFilter.Items.Add("Out Of Stock");
            cmbStockStatusFilter.SelectedIndex = 0;
        }

        private void LoadProducts()
        {
            try
            {
                string query = @"
                    SELECT
                        P.ProductId AS [ID],
                        P.ProductName AS [Product Name],
                        C.CategoryName AS [Category],
                        P.GenderSection AS [Gender],
                        P.Price AS [Price],
                        P.StockQty AS [Stock],
                        P.SoldQty AS [Sold],
                        CASE
                            WHEN P.StockQty = 0 THEN 'Out Of Stock'
                            WHEN P.StockQty < 10 THEN 'Low Stock'
                            ELSE 'Active'
                        END AS [Status]
                    FROM Products P
                    INNER JOIN Categories C ON P.CategoryId = C.CategoryId
                    WHERE P.IsActive = 1
                    ORDER BY P.ProductId DESC
                ";

                DataTable dt = DatabaseHelper.GetDataTable(query);
                dgvProducts.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Products load error: " + ex.Message);
            }
        }

        private void LoadSummaryCards()
        {
            try
            {
                string totalValueQuery = "SELECT ISNULL(SUM(Price * StockQty), 0) FROM Products WHERE IsActive = 1";

                string topCategoryQuery = @"
                    SELECT TOP 1 C.CategoryName
                    FROM Products P
                    INNER JOIN Categories C ON P.CategoryId = C.CategoryId
                    GROUP BY C.CategoryName
                    ORDER BY SUM(P.SoldQty) DESC
                ";

                string stockHealthQuery = @"
                    SELECT 
                        CASE 
                            WHEN COUNT(*) = 0 THEN 0
                            ELSE CAST((CAST(SUM(CASE WHEN StockQty > 0 THEN 1 ELSE 0 END) AS FLOAT) / COUNT(*)) * 100 AS INT)
                        END
                    FROM Products
                    WHERE IsActive = 1
                ";

                object totalValue = DatabaseHelper.ExecuteScalar(totalValueQuery);
                object topCategory = DatabaseHelper.ExecuteScalar(topCategoryQuery);
                object stockHealth = DatabaseHelper.ExecuteScalar(stockHealthQuery);

                lblInventoryValue.Text = Convert.ToDecimal(totalValue).ToString("0.00") + " Tk";
                lblTopSellingCategory.Text = topCategory == null || topCategory == DBNull.Value ? "N/A" : topCategory.ToString();
                lblStockHealth.Text = Convert.ToString(stockHealth) + "%";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Summary cards load error: " + ex.Message);
            }
        }

        private void LoadLowStockAlert()
        {
            try
            {
                string query = "SELECT COUNT(*) FROM Products WHERE IsActive = 1 AND StockQty < 10";
                int lowStockCount = Convert.ToInt32(DatabaseHelper.ExecuteScalar(query));

                lblLowStockAlert.Text = "Low Stock Alert: " + lowStockCount + " item(s) below threshold.";

                pnlLowStockAlert.Visible = lowStockCount > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Low stock alert load error: " + ex.Message);
            }
        }

        private void ApplyFilters()
        {
            try
            {
                string query = @"
                    SELECT
                        P.ProductId AS [ID],
                        P.ProductName AS [Product Name],
                        C.CategoryName AS [Category],
                        P.GenderSection AS [Gender],
                        P.Price AS [Price],
                        P.StockQty AS [Stock],
                        P.SoldQty AS [Sold],
                        CASE
                            WHEN P.StockQty = 0 THEN 'Out Of Stock'
                            WHEN P.StockQty < 10 THEN 'Low Stock'
                            ELSE 'Active'
                        END AS [Status]
                    FROM Products P
                    INNER JOIN Categories C ON P.CategoryId = C.CategoryId
                    WHERE P.IsActive = 1
                ";

                var parameters = new System.Collections.Generic.List<SqlParameter>();

                if (!string.IsNullOrWhiteSpace(txtSearchProducts.Text) &&
                    txtSearchProducts.Text.Trim() != "Product Name,SKU or brand...")
                {
                    query += " AND P.ProductName LIKE @SearchText";
                    parameters.Add(new SqlParameter("@SearchText", "%" + txtSearchProducts.Text.Trim() + "%"));
                }

                if (cmbCategoryFilter.SelectedIndex > 0)
                {
                    query += " AND C.CategoryName = @CategoryName";
                    parameters.Add(new SqlParameter("@CategoryName", cmbCategoryFilter.Text));
                }

                if (cmbStockStatusFilter.Text == "Active")
                {
                    query += " AND P.StockQty >= 10";
                }
                else if (cmbStockStatusFilter.Text == "Low Stock")
                {
                    query += " AND P.StockQty > 0 AND P.StockQty < 10";
                }
                else if (cmbStockStatusFilter.Text == "Out Of Stock")
                {
                    query += " AND P.StockQty = 0";
                }

                query += " ORDER BY P.ProductId DESC";

                DataTable dt = DatabaseHelper.GetDataTable(query, parameters.Count == 0 ? null : parameters.ToArray());
                dgvProducts.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Filter error: " + ex.Message);
            }
        }

        private void btnApplyFilters_Click(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void txtSearchProducts_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProductForm form = new AddProductForm();
            form.ShowDialog();

            LoadProducts();
            LoadSummaryCards();
            LoadLowStockAlert();
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProducts.CurrentRow == null)
                {
                    MessageBox.Show("Please select a product first.");
                    return;
                }

                if (dgvProducts.CurrentRow.Cells["ID"].Value == null)
                {
                    MessageBox.Show("Invalid product selection.");
                    return;
                }

                int selectedProductId = Convert.ToInt32(dgvProducts.CurrentRow.Cells["ID"].Value);

                EditProductForm form = new EditProductForm(selectedProductId);
                form.ShowDialog();

                LoadProducts();
                LoadSummaryCards();
                LoadLowStockAlert();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Open edit form error: " + ex.Message);
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lnkViewDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Show low stock product details here.");
        }
    }
}