using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Cosmatic_Shop_Management.DAL;
using Cosmatic_Shop_Management.Helpers;

namespace Cosmatic_Shop_Management.Forms
{
    public partial class ManageProductsForm : Form
    {
        private int myShopId = 0;

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
            myShopId = GetMyShopId();

            if (myShopId <= 0)
            {
                MessageBox.Show("No shop found for this admin.");
                dgvProducts.DataSource = null;
                lblInventoryValue.Text = "0.00 Tk";
                lblTopSellingCategory.Text = "N/A";
                lblStockHealth.Text = "0%";
                lblLowStockAlert.Text = "Low Stock Alert: 0 item(s) below threshold.";
                pnlLowStockAlert.Visible = false;
                return;
            }

            LoadCategoryFilter();
            LoadStockStatusFilter();
            LoadProducts();
            LoadSummaryCards();
            LoadLowStockAlert();
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
            catch (Exception ex)
            {
                MessageBox.Show("Shop load error: " + ex.Message);
                return 0;
            }
        }

        private void LoadCategoryFilter()
        {
            try
            {
                cmbCategoryFilter.Items.Clear();
                cmbCategoryFilter.Items.Add("All Categories");

                string query = @"
                    SELECT DISTINCT C.CategoryName
                    FROM Products P
                    INNER JOIN Categories C ON P.CategoryId = C.CategoryId
                    WHERE P.ShopId = @ShopId
                    ORDER BY C.CategoryName
                ";

                SqlParameter[] parameters =
                {
                    new SqlParameter("@ShopId", myShopId)
                };

                DataTable dt = DatabaseHelper.GetDataTable(query, parameters);

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
                      AND P.ShopId = @ShopId
                    ORDER BY P.ProductId DESC
                ";

                SqlParameter[] parameters =
                {
                    new SqlParameter("@ShopId", myShopId)
                };

                DataTable dt = DatabaseHelper.GetDataTable(query, parameters);
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
                string totalValueQuery = @"
                    SELECT ISNULL(SUM(Price * StockQty), 0)
                    FROM Products
                    WHERE IsActive = 1
                      AND ShopId = @ShopId
                ";

                string topCategoryQuery = @"
                    SELECT TOP 1 C.CategoryName
                    FROM Products P
                    INNER JOIN Categories C ON P.CategoryId = C.CategoryId
                    WHERE P.ShopId = @ShopId
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
                      AND ShopId = @ShopId
                ";

                SqlParameter[] p1 =
                {
                    new SqlParameter("@ShopId", myShopId)
                };

                SqlParameter[] p2 =
                {
                    new SqlParameter("@ShopId", myShopId)
                };

                SqlParameter[] p3 =
                {
                    new SqlParameter("@ShopId", myShopId)
                };

                object totalValue = DatabaseHelper.ExecuteScalar(totalValueQuery, p1);
                object topCategory = DatabaseHelper.ExecuteScalar(topCategoryQuery, p2);
                object stockHealth = DatabaseHelper.ExecuteScalar(stockHealthQuery, p3);

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
                string query = @"
                    SELECT COUNT(*)
                    FROM Products
                    WHERE IsActive = 1
                      AND StockQty < 10
                      AND ShopId = @ShopId
                ";

                SqlParameter[] parameters =
                {
                    new SqlParameter("@ShopId", myShopId)
                };

                int lowStockCount = Convert.ToInt32(DatabaseHelper.ExecuteScalar(query, parameters));

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
                      AND P.ShopId = @ShopId
                ";

                var parameters = new System.Collections.Generic.List<SqlParameter>
                {
                    new SqlParameter("@ShopId", myShopId)
                };

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

                DataTable dt = DatabaseHelper.GetDataTable(query, parameters.ToArray());
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