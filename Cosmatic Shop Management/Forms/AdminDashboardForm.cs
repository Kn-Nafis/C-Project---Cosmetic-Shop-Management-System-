using System;
using System.Data;
using System.Windows.Forms;
using Cosmatic_Shop_Management.DAL;
using Cosmatic_Shop_Management.Helpers;

namespace Cosmatic_Shop_Management.Forms
{
    public partial class AdminDashboardForm : Form
    {
        public AdminDashboardForm()
        {
            InitializeComponent();

            this.Load += AdminDashboardForm_Load;

            btnManageShop.Click -= btnManageShop_Click;
            btnManageShop.Click += btnManageShop_Click;

            btnManageProducts.Click -= btnManageProducts_Click;
            btnManageProducts.Click += btnManageProducts_Click;

            btnOrders.Click -= btnOrders_Click;
            btnOrders.Click += btnOrders_Click;

            btnReports.Click -= btnReports_Click;
            btnReports.Click += btnReports_Click;

            btnEmployees.Click -= btnEmployees_Click;
            btnEmployees.Click += btnEmployees_Click;

            btnLogout.Click -= btnLogout_Click;
            btnLogout.Click += btnLogout_Click;
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            lblAdminName.Text = "Welcome, " + SessionManager.FullName;
            LoadDashboardStats();
            LoadRecentOrders();
        }

        private void LoadDashboardStats()
        {
            try
            {
                string totalProductsQuery = "SELECT COUNT(*) FROM Products WHERE IsActive = 1";
                string totalOrdersQuery = "SELECT COUNT(*) FROM Orders";
                string grossSalesQuery = "SELECT ISNULL(SUM(TotalAmount), 0) FROM Orders";
                string netIncomeQuery = "SELECT ISNULL(SUM(ShopIncome), 0) FROM OrderItems";
                string lowStockQuery = "SELECT COUNT(*) FROM Products WHERE StockQty < 10 AND IsActive = 1";

                object totalProducts = DatabaseHelper.ExecuteScalar(totalProductsQuery);
                object totalOrders = DatabaseHelper.ExecuteScalar(totalOrdersQuery);
                object grossSales = DatabaseHelper.ExecuteScalar(grossSalesQuery);
                object netIncome = DatabaseHelper.ExecuteScalar(netIncomeQuery);
                object lowStock = DatabaseHelper.ExecuteScalar(lowStockQuery);

                lblTotalProducts.Text = Convert.ToString(totalProducts);
                lblTotalOrders.Text = Convert.ToString(totalOrders);
                lblGrossSales.Text = Convert.ToDecimal(grossSales).ToString("0.00") + " Tk";
                lblNetIncome.Text = Convert.ToDecimal(netIncome).ToString("0.00") + " Tk";
                lblLowStock.Text = Convert.ToString(lowStock);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Admin stats load error: " + ex.Message);
            }
        }

        private void LoadRecentOrders()
        {
            try
            {
                string query = @"
                    SELECT TOP 10
                        O.OrderId AS [Order ID],
                        U.FullName AS [Customer],
                        O.OrderStatus AS [Status],
                        O.TotalAmount AS [Amount]
                    FROM Orders O
                    INNER JOIN Users U ON O.CustomerUserId = U.UserId
                    ORDER BY O.OrderId DESC
                ";

                DataTable dt = DatabaseHelper.GetDataTable(query);
                dgvRecentOrders.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Recent orders load error: " + ex.Message);
            }
        }

        private void btnManageShop_Click(object sender, EventArgs e)
        {
            ManageShopForm form = new ManageShopForm();
            form.Show();
        }

        private void btnManageProducts_Click(object sender, EventArgs e)
        {
            ManageProductsForm form = new ManageProductsForm();
            form.Show();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            AdminOrdersForm form = new AdminOrdersForm();
            form.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            AnalyticsForm form = new AnalyticsForm();
            form.Show();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            ManageUsersForm form = new ManageUsersForm();
            form.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            SessionManager.Clear();

            LoginForm form = new LoginForm();
            form.Show();
            this.Close();
        }
    }
}