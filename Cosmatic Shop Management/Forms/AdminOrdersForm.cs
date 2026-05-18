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
    public partial class AdminOrdersForm : Form
    {
        private DataTable allOrders = new DataTable();
        private int selectedOrderId = -1;
        private int myShopId = 0;

        public AdminOrdersForm()
        {
            InitializeComponent();

            this.Load += AdminOrdersForm_Load;

            btnGoBack.Click -= btnGoBack_Click;
            btnGoBack.Click += btnGoBack_Click;

            btnLogout.Click -= btnLogout_Click;
            btnLogout.Click += btnLogout_Click;

            btnFilters.Click -= btnFilters_Click;
            btnFilters.Click += btnFilters_Click;

            btnUpdateStatus.Click -= btnUpdateStatus_Click;
            btnUpdateStatus.Click += btnUpdateStatus_Click;

            btnPrintInvoice.Click -= btnPrintInvoice_Click;
            btnPrintInvoice.Click += btnPrintInvoice_Click;

            lblCloseDetail.Click -= lblCloseDetail_Click;
            lblCloseDetail.Click += lblCloseDetail_Click;

            txtSearchOrders.TextChanged -= txtSearchOrders_TextChanged;
            txtSearchOrders.TextChanged += txtSearchOrders_TextChanged;

            dgvOrders.SelectionChanged -= dgvOrders_SelectionChanged;
            dgvOrders.SelectionChanged += dgvOrders_SelectionChanged;
        }

        private void AdminOrdersForm_Load(object? sender, EventArgs e)
        {
            myShopId = GetMyShopId();

            if (myShopId <= 0)
            {
                MessageBox.Show("No shop found for this admin.");
                return;
            }

            SetupForm();
            LoadStatusCombo();
            LoadOrdersFromDatabase();
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

        private void SetupForm()
        {
            this.Text = "Admin Orders";

            dgvOrders.AutoGenerateColumns = true;
            dgvOrders.ReadOnly = true;
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.AllowUserToDeleteRows = false;
            dgvOrders.AllowUserToResizeRows = false;
            dgvOrders.RowHeadersVisible = false;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.MultiSelect = false;
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrders.BackgroundColor = Color.White;
            dgvOrders.BorderStyle = BorderStyle.None;

            pnlOrderDetails.Visible = true;

            ClearDetails();
        }

        private void LoadStatusCombo()
        {
            cmbOrderStatus.Items.Clear();
            cmbOrderStatus.Items.Add("Pending");
            cmbOrderStatus.Items.Add("Processing");
            cmbOrderStatus.Items.Add("Shipped");
            cmbOrderStatus.Items.Add("Delivered");
            cmbOrderStatus.Items.Add("Cancelled");
            cmbOrderStatus.SelectedIndex = 0;
        }

        private void LoadOrdersFromDatabase()
        {
            try
            {
                string query = @"
                    SELECT
                        O.OrderId AS [Order ID],
                        U.FullName AS [Customer],
                        P.ProductName AS [Product],
                        OI.Quantity AS [Qty],
                        CAST(OI.LineTotal AS DECIMAL(10,2)) AS [Total],
                        CAST(OI.PlatformCommission AS DECIMAL(10,2)) AS [Comm.],
                        O.OrderStatus AS [Status]
                    FROM Orders O
                    INNER JOIN Users U ON O.CustomerUserId = U.UserId
                    INNER JOIN OrderItems OI ON O.OrderId = OI.OrderId
                    INNER JOIN Products P ON OI.ProductId = P.ProductId
                    WHERE OI.ShopId = @ShopId
                    ORDER BY O.OrderId DESC, OI.OrderItemId DESC
                ";

                SqlParameter[] parameters =
                {
                    new SqlParameter("@ShopId", myShopId)
                };

                allOrders = DatabaseHelper.GetDataTable(query, parameters);

                dgvOrders.DataSource = allOrders;
                FormatGrid();

                if (dgvOrders.Rows.Count > 0)
                {
                    dgvOrders.Rows[0].Selected = true;
                    LoadSelectedOrderDetails();
                }
                else
                {
                    ClearDetails();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Orders load error: " + ex.Message);
            }
        }

        private void FormatGrid()
        {
            if (dgvOrders.Columns.Contains("Total"))
                dgvOrders.Columns["Total"].DefaultCellStyle.Format = "0.00";

            if (dgvOrders.Columns.Contains("Comm."))
                dgvOrders.Columns["Comm."].DefaultCellStyle.Format = "0.00";
        }

        private void txtSearchOrders_TextChanged(object? sender, EventArgs e)
        {
            try
            {
                if (allOrders == null || allOrders.Rows.Count == 0)
                    return;

                string searchText = txtSearchOrders.Text.Trim().Replace("'", "''");

                if (string.IsNullOrWhiteSpace(searchText) ||
                    searchText.Equals("Search orders by ID, customer or product...", StringComparison.OrdinalIgnoreCase))
                {
                    dgvOrders.DataSource = allOrders;
                }
                else
                {
                    DataView dv = allOrders.DefaultView;
                    dv.RowFilter =
                        "[Order ID] LIKE '%" + searchText + "%' OR " +
                        "[Customer] LIKE '%" + searchText + "%' OR " +
                        "[Product] LIKE '%" + searchText + "%' OR " +
                        "[Status] LIKE '%" + searchText + "%'";

                    dgvOrders.DataSource = dv.ToTable();
                }

                FormatGrid();

                if (dgvOrders.Rows.Count > 0)
                {
                    dgvOrders.Rows[0].Selected = true;
                    LoadSelectedOrderDetails();
                }
                else
                {
                    ClearDetails();
                }
            }
            catch
            {
            }
        }

        private void dgvOrders_SelectionChanged(object? sender, EventArgs e)
        {
            LoadSelectedOrderDetails();
        }

        private void LoadSelectedOrderDetails()
        {
            try
            {
                if (dgvOrders.CurrentRow == null || dgvOrders.CurrentRow.Cells["Order ID"].Value == null)
                    return;

                selectedOrderId = Convert.ToInt32(dgvOrders.CurrentRow.Cells["Order ID"].Value);

                string detailQuery = @"
                    SELECT TOP 1
                        O.OrderId,
                        O.OrderStatus,
                        O.TotalAmount,
                        U.FullName,
                        U.Email,
                        U.Phone,
                        U.Address,
                        P.ProductName,
                        P.ImagePath,
                        OI.Quantity,
                        OI.UnitPrice,
                        OI.LineTotal,
                        OI.PlatformCommission
                    FROM Orders O
                    INNER JOIN Users U ON O.CustomerUserId = U.UserId
                    INNER JOIN OrderItems OI ON O.OrderId = OI.OrderId
                    INNER JOIN Products P ON OI.ProductId = P.ProductId
                    WHERE O.OrderId = @OrderId
                      AND OI.ShopId = @ShopId
                    ORDER BY OI.OrderItemId DESC
                ";

                SqlParameter[] parameters =
                {
                    new SqlParameter("@OrderId", selectedOrderId),
                    new SqlParameter("@ShopId", myShopId)
                };

                DataTable dt = DatabaseHelper.GetDataTable(detailQuery, parameters);

                if (dt.Rows.Count == 0)
                {
                    ClearDetails();
                    return;
                }

                DataRow row = dt.Rows[0];

                decimal subtotal = Convert.ToDecimal(row["LineTotal"]);
                decimal shipping = 0m;
                decimal tax = Math.Round(subtotal * 0.08m, 2);
                decimal totalPayable = subtotal + shipping + tax;

                lblOrderNo.Text = "ORDER #" + row["OrderId"].ToString();
                lblProductName.Text = row["ProductName"].ToString() ?? "-";
                lblProductPrice.Text = subtotal.ToString("0.00");
                lblCustomerName.Text = row["FullName"].ToString() ?? "-";
                lblShippingAddress.Text = row["Address"].ToString() ?? "-";

                lblSubtotalValue.Text = subtotal.ToString("0.00");
                lblShippingCostValue.Text = shipping.ToString("0.00");
                lblTaxValue.Text = tax.ToString("0.00");
                lblTotalPayableValue.Text = totalPayable.ToString("0.00");

                string orderStatus = row["OrderStatus"].ToString() ?? "Pending";
                if (cmbOrderStatus.Items.Contains(orderStatus))
                    cmbOrderStatus.SelectedItem = orderStatus;
                else
                    cmbOrderStatus.SelectedIndex = 0;

                txtAdminNotes.Text =
                    "Customer Email: " + (row["Email"].ToString() ?? "") + Environment.NewLine +
                    "Phone: " + (row["Phone"].ToString() ?? "") + Environment.NewLine +
                    "Quantity: " + row["Quantity"].ToString() + Environment.NewLine +
                    "Unit Price: " + Convert.ToDecimal(row["UnitPrice"]).ToString("0.00") + Environment.NewLine +
                    "Line Total: " + Convert.ToDecimal(row["LineTotal"]).ToString("0.00") + Environment.NewLine +
                    "Commission: " + Convert.ToDecimal(row["PlatformCommission"]).ToString("0.00");

                LoadOrderProductImage(row["ImagePath"].ToString() ?? "");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Order detail load error: " + ex.Message);
            }
        }

        private void LoadOrderProductImage(string imagePath)
        {
            try
            {
                if (picOrderProduct.Image != null)
                {
                    picOrderProduct.Image.Dispose();
                    picOrderProduct.Image = null;
                }

                if (!string.IsNullOrWhiteSpace(imagePath) && File.Exists(imagePath))
                {
                    byte[] imageBytes = File.ReadAllBytes(imagePath);

                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    using (Image temp = Image.FromStream(ms))
                    {
                        picOrderProduct.Image = new Bitmap(temp);
                    }
                }
                else
                {
                    picOrderProduct.Image = null;
                }
            }
            catch
            {
                picOrderProduct.Image = null;
            }
        }

        private void ClearDetails()
        {
            selectedOrderId = -1;

            lblOrderNo.Text = "ORDER #";
            lblProductName.Text = "-";
            lblProductPrice.Text = "0.00";
            lblCustomerName.Text = "-";
            lblShippingAddress.Text = "-";

            lblSubtotalValue.Text = "0.00";
            lblShippingCostValue.Text = "0.00";
            lblTaxValue.Text = "0.00";
            lblTotalPayableValue.Text = "0.00";

            txtAdminNotes.Clear();

            if (picOrderProduct.Image != null)
            {
                picOrderProduct.Image.Dispose();
                picOrderProduct.Image = null;
            }
        }

        private void btnFilters_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Filter feature can be added next.");
        }

        private void btnUpdateStatus_Click(object? sender, EventArgs e)
        {
            try
            {
                if (selectedOrderId <= 0)
                {
                    MessageBox.Show("Please select an order first.");
                    return;
                }

                string newStatus = cmbOrderStatus.Text.Trim();

                if (string.IsNullOrWhiteSpace(newStatus))
                {
                    MessageBox.Show("Please select a valid status.");
                    return;
                }

                string updateQuery = @"
                    UPDATE Orders
                    SET OrderStatus = @OrderStatus
                    WHERE OrderId = @OrderId
                      AND EXISTS
                      (
                          SELECT 1
                          FROM OrderItems
                          WHERE OrderItems.OrderId = Orders.OrderId
                            AND OrderItems.ShopId = @ShopId
                      )
                ";

                SqlParameter[] parameters =
                {
                    new SqlParameter("@OrderStatus", newStatus),
                    new SqlParameter("@OrderId", selectedOrderId),
                    new SqlParameter("@ShopId", myShopId)
                };

                DatabaseHelper.ExecuteNonQuery(updateQuery, parameters);

                MessageBox.Show("Order status updated successfully.");
                LoadOrdersFromDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update error: " + ex.Message);
            }
        }

        private void btnPrintInvoice_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Print invoice feature will be added.");
        }

        private void btnLogout_Click(object? sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void btnGoBack_Click(object? sender, EventArgs e)
        {
            AdminDashboardForm form = new AdminDashboardForm();
            form.Show();
            this.Hide();
        }

        private void lblCloseDetail_Click(object? sender, EventArgs e)
        {
            pnlOrderDetails.Visible = false;
        }

        private void pnlTopHeader_Paint(object sender, PaintEventArgs e)
        {
        }

        private void AdminOrdersForm_Load_1(object sender, EventArgs e)
        {
        }
    }
}