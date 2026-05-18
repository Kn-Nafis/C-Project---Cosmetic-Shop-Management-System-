using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Cosmatic_Shop_Management.DAL;
using Cosmatic_Shop_Management.Helpers;

namespace Cosmatic_Shop_Management.Forms
{
    public partial class AdminDashboardForm : Form
    {
        private int myShopId = 0;

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

            myShopId = GetMyShopId();

            if (myShopId <= 0)
            {
                MessageBox.Show("No shop found for this admin.");
                lblTotalProducts.Text = "0";
                lblTotalOrders.Text = "0";
                lblGrossSales.Text = "0.00 Tk";
                lblNetIncome.Text = "0.00 Tk";
                lblLowStock.Text = "0";
                dgvRecentOrders.DataSource = null;
                return;
            }

            LoadDashboardStats();
            LoadRecentOrders();
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

        private void LoadDashboardStats()
        {
            try
            {
                string totalProductsQuery = @"
                    SELECT COUNT(*)
                    FROM Products
                    WHERE IsActive = 1
                      AND ShopId = @ShopId
                ";

                string totalOrdersQuery = @"
                    SELECT COUNT(DISTINCT O.OrderId)
                    FROM Orders O
                    INNER JOIN OrderItems OI ON O.OrderId = OI.OrderId
                    WHERE OI.ShopId = @ShopId
                ";

                string grossSalesQuery = @"
                    SELECT ISNULL(SUM(OI.LineTotal), 0)
                    FROM OrderItems OI
                    INNER JOIN Orders O ON OI.OrderId = O.OrderId
                    WHERE OI.ShopId = @ShopId
                      AND O.OrderStatus <> 'Cancelled'
                ";

                string netIncomeQuery = @"
                    SELECT ISNULL(SUM(OI.ShopIncome), 0)
                    FROM OrderItems OI
                    INNER JOIN Orders O ON OI.OrderId = O.OrderId
                    WHERE OI.ShopId = @ShopId
                      AND O.OrderStatus <> 'Cancelled'
                ";

                string lowStockQuery = @"
                    SELECT COUNT(*)
                    FROM Products
                    WHERE StockQty < 10
                      AND IsActive = 1
                      AND ShopId = @ShopId
                ";

                SqlParameter[] parameters1 =
                {
                    new SqlParameter("@ShopId", myShopId)
                };

                SqlParameter[] parameters2 =
                {
                    new SqlParameter("@ShopId", myShopId)
                };

                SqlParameter[] parameters3 =
                {
                    new SqlParameter("@ShopId", myShopId)
                };

                SqlParameter[] parameters4 =
                {
                    new SqlParameter("@ShopId", myShopId)
                };

                SqlParameter[] parameters5 =
                {
                    new SqlParameter("@ShopId", myShopId)
                };

                object totalProducts = DatabaseHelper.ExecuteScalar(totalProductsQuery, parameters1);
                object totalOrders = DatabaseHelper.ExecuteScalar(totalOrdersQuery, parameters2);
                object grossSales = DatabaseHelper.ExecuteScalar(grossSalesQuery, parameters3);
                object netIncome = DatabaseHelper.ExecuteScalar(netIncomeQuery, parameters4);
                object lowStock = DatabaseHelper.ExecuteScalar(lowStockQuery, parameters5);

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
                        OI.LineTotal AS [Amount]
                    FROM Orders O
                    INNER JOIN Users U ON O.CustomerUserId = U.UserId
                    INNER JOIN OrderItems OI ON O.OrderId = OI.OrderId
                    WHERE OI.ShopId = @ShopId
                    ORDER BY O.OrderId DESC
                ";

                SqlParameter[] parameters =
                {
                    new SqlParameter("@ShopId", myShopId)
                };

                DataTable dt = DatabaseHelper.GetDataTable(query, parameters);
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
            form.ShowDialog();

            myShopId = GetMyShopId();
            LoadDashboardStats();
            LoadRecentOrders();
        }

        private void btnManageProducts_Click(object sender, EventArgs e)
        {
            ManageProductsForm form = new ManageProductsForm();
            form.ShowDialog();

            LoadDashboardStats();
            LoadRecentOrders();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            AdminOrdersForm form = new AdminOrdersForm();
            form.ShowDialog();

            LoadDashboardStats();
            LoadRecentOrders();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            AnalyticsForm form = new AnalyticsForm();
            form.ShowDialog();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            ManageUsersForm form = new ManageUsersForm();
            form.ShowDialog();
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