using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Cosmatic_Shop_Management.DAL;
using Cosmatic_Shop_Management.Helpers;

namespace Cosmatic_Shop_Management.Forms
{
    public partial class MyOrdersForm : Form
    {
        private int currentPage = 1;
        private int pageSize = 5;
        private DataTable allOrders = new DataTable();

        public MyOrdersForm()
        {
            InitializeComponent();

            this.Load += MyOrdersForm_Load;

            btnGoBack.Click -= btnGoBack_Click;
            btnGoBack.Click += btnGoBack_Click;

            btnCart.Click -= btnCart_Click;
            btnCart.Click += btnCart_Click;

            btnWishlist.Click -= btnWishlist_Click;
            btnWishlist.Click += btnWishlist_Click;

            btnApplyFilters.Click -= btnApplyFilters_Click;
            btnApplyFilters.Click += btnApplyFilters_Click;

            btnClearFilters.Click -= btnClearFilters_Click;
            btnClearFilters.Click += btnClearFilters_Click;

            txtSearchOrders.TextChanged -= txtSearchOrders_TextChanged;
            txtSearchOrders.TextChanged += txtSearchOrders_TextChanged;

            dgvMyOrders.SelectionChanged -= dgvMyOrders_SelectionChanged;
            dgvMyOrders.SelectionChanged += dgvMyOrders_SelectionChanged;

            lnkAllOrders.LinkClicked -= lnkAllOrders_LinkClicked;
            lnkAllOrders.LinkClicked += lnkAllOrders_LinkClicked;

            lnkPending.LinkClicked -= lnkPending_LinkClicked;
            lnkPending.LinkClicked += lnkPending_LinkClicked;

            lnkShipped.LinkClicked -= lnkShipped_LinkClicked;
            lnkShipped.LinkClicked += lnkShipped_LinkClicked;

            lnkCompleted.LinkClicked -= lnkCompleted_LinkClicked;
            lnkCompleted.LinkClicked += lnkCompleted_LinkClicked;

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

            btnCancelOrder.Click -= btnCancelOrder_Click;
            btnCancelOrder.Click += btnCancelOrder_Click;

            btnReorder.Click -= btnReorder_Click;
            btnReorder.Click += btnReorder_Click;

            btnViewInvoice.Click -= btnViewInvoice_Click;
            btnViewInvoice.Click += btnViewInvoice_Click;
        }

        private void MyOrdersForm_Load(object? sender, EventArgs e)
        {
            SetupStaticUI();
            LoadOrders();
            ApplyFiltersAndBind();
        }

        private void SetupStaticUI()
        {
            this.Text = "My Orders";
            lblFormTitle.Text = "My Orders";

            cmbOrderStatus.Items.Clear();
            cmbOrderStatus.Items.Add("All Statuses");
            cmbOrderStatus.Items.Add("Pending");
            cmbOrderStatus.Items.Add("Processing");
            cmbOrderStatus.Items.Add("Shipped");
            cmbOrderStatus.Items.Add("Delivered");
            cmbOrderStatus.Items.Add("Cancelled");
            cmbOrderStatus.SelectedIndex = 0;

            dtpStartDate.Value = DateTime.Today.AddMonths(-3);
            dtpEndDate.Value = DateTime.Today;

            dgvMyOrders.AutoGenerateColumns = true;
            dgvMyOrders.ReadOnly = true;
            dgvMyOrders.AllowUserToAddRows = false;
            dgvMyOrders.AllowUserToDeleteRows = false;
            dgvMyOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMyOrders.MultiSelect = false;
            dgvMyOrders.RowHeadersVisible = false;
            dgvMyOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            HighlightTab("ALL");
            HighlightCurrentPageButton();
            ClearOrderDetails();
        }

        private void LoadOrders()
        {
            try
            {
                string query = @"
                    SELECT
                        O.OrderId,
                        O.OrderDate,
                        O.OrderStatus,
                        O.TotalAmount,
                        U.FullName,
                        U.Email,
                        U.Phone,
                        U.Address
                    FROM Orders O
                    INNER JOIN Users U ON O.CustomerUserId = U.UserId
                    WHERE O.CustomerUserId = @CustomerUserId
                    ORDER BY O.OrderDate DESC, O.OrderId DESC
                ";

                SqlParameter[] parameters =
                {
                    new SqlParameter("@CustomerUserId", SessionManager.UserId)
                };

                allOrders = DatabaseHelper.GetDataTable(query, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Orders load error: " + ex.Message);
            }
        }

        private void ApplyFiltersAndBind()
        {
            try
            {
                if (allOrders == null || allOrders.Rows.Count == 0)
                {
                    dgvMyOrders.DataSource = null;
                    ClearOrderDetails();
                    return;
                }

                var filteredRows = allOrders.AsEnumerable();

                string searchText = txtSearchOrders.Text.Trim().ToLower();
                if (!string.IsNullOrWhiteSpace(searchText))
                {
                    filteredRows = filteredRows.Where(row =>
                        row["OrderId"].ToString()!.ToLower().Contains(searchText) ||
                        row["FullName"].ToString()!.ToLower().Contains(searchText) ||
                        row["OrderStatus"].ToString()!.ToLower().Contains(searchText));
                }

                string selectedStatus = cmbOrderStatus.Text.Trim();
                if (!string.IsNullOrWhiteSpace(selectedStatus) && selectedStatus != "All Statuses")
                {
                    filteredRows = filteredRows.Where(row =>
                        row["OrderStatus"].ToString()!.Equals(selectedStatus, StringComparison.OrdinalIgnoreCase));
                }

                DateTime startDate = dtpStartDate.Value.Date;
                DateTime endDate = dtpEndDate.Value.Date;

                filteredRows = filteredRows.Where(row =>
                {
                    DateTime orderDate = Convert.ToDateTime(row["OrderDate"]).Date;
                    return orderDate >= startDate && orderDate <= endDate;
                });

                DataTable filteredTable = filteredRows.Any()
                    ? filteredRows.CopyToDataTable()
                    : allOrders.Clone();

                BindPagedOrders(filteredTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Filter error: " + ex.Message);
            }
        }

        private void BindPagedOrders(DataTable filteredTable)
        {
            int totalRows = filteredTable.Rows.Count;
            int totalPages = (int)Math.Ceiling(totalRows / (double)pageSize);

            if (totalPages == 0) totalPages = 1;
            if (currentPage > totalPages) currentPage = totalPages;
            if (currentPage < 1) currentPage = 1;

            DataTable displayTable = filteredTable.Clone();

            int startIndex = (currentPage - 1) * pageSize;
            int endIndex = Math.Min(startIndex + pageSize, totalRows);

            for (int i = startIndex; i < endIndex; i++)
            {
                displayTable.ImportRow(filteredTable.Rows[i]);
            }

            dgvMyOrders.DataSource = displayTable;

            if (dgvMyOrders.Columns.Contains("Email"))
                dgvMyOrders.Columns["Email"].Visible = false;

            if (dgvMyOrders.Columns.Contains("Phone"))
                dgvMyOrders.Columns["Phone"].Visible = false;

            if (dgvMyOrders.Columns.Contains("Address"))
                dgvMyOrders.Columns["Address"].Visible = false;

            if (dgvMyOrders.Columns.Contains("OrderDate"))
                dgvMyOrders.Columns["OrderDate"].DefaultCellStyle.Format = "dd-MMM-yyyy";

            if (dgvMyOrders.Columns.Contains("TotalAmount"))
                dgvMyOrders.Columns["TotalAmount"].DefaultCellStyle.Format = "0.00";

            btnPrevPage.Enabled = currentPage > 1;
            btnNextPage.Enabled = currentPage < totalPages;

            btnPage1.Visible = totalPages >= 1;
            btnPage2.Visible = totalPages >= 2;
            btnPage3.Visible = totalPages >= 3;

            HighlightCurrentPageButton();

            if (dgvMyOrders.Rows.Count > 0)
            {
                dgvMyOrders.Rows[0].Selected = true;
                LoadSelectedOrderDetails();
            }
            else
            {
                ClearOrderDetails();
            }
        }

        private void dgvMyOrders_SelectionChanged(object? sender, EventArgs e)
        {
            LoadSelectedOrderDetails();
        }

        private void LoadSelectedOrderDetails()
        {
            try
            {
                if (dgvMyOrders.CurrentRow == null || dgvMyOrders.CurrentRow.Cells["OrderId"].Value == null)
                {
                    ClearOrderDetails();
                    return;
                }

                int orderId = Convert.ToInt32(dgvMyOrders.CurrentRow.Cells["OrderId"].Value);

                string orderQuery = @"
                    SELECT
                        O.OrderId,
                        O.OrderStatus,
                        O.TotalAmount,
                        U.FullName,
                        U.Email,
                        U.Phone,
                        U.Address
                    FROM Orders O
                    INNER JOIN Users U ON O.CustomerUserId = U.UserId
                    WHERE O.OrderId = @OrderId
                ";

                SqlParameter[] orderParams =
                {
                    new SqlParameter("@OrderId", orderId)
                };

                DataTable dtOrder = DatabaseHelper.GetDataTable(orderQuery, orderParams);

                if (dtOrder.Rows.Count == 0)
                {
                    ClearOrderDetails();
                    return;
                }

                DataRow row = dtOrder.Rows[0];

                lblOrderIdValue.Text = "#ORD-" + row["OrderId"].ToString();
                lblStatusValue.Text = row["OrderStatus"].ToString();

                lblCustomerInfoValue.Text =
                    (row["FullName"].ToString() ?? "") + Environment.NewLine +
                    (row["Email"].ToString() ?? "") + Environment.NewLine +
                    (row["Phone"].ToString() ?? "");

                lblShippingAddressValue.Text = row["Address"].ToString() ?? "";

                lblSubtotalValue.Text = "0.00 Tk";
                lblShippingValue.Text = "0.00 Tk";
                lblTaxValue.Text = "0.00 Tk";
                lblTotalAmountValue.Text = Convert.ToDecimal(row["TotalAmount"]).ToString("0.00") + " Tk";

                LoadOrderItems(orderId);
                UpdateActionButtons(row["OrderStatus"].ToString() ?? "");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Order details load error: " + ex.Message);
            }
        }

        private void LoadOrderItems(int orderId)
        {
            try
            {
                flpOrderItems.Controls.Clear();

                string query = @"
                    SELECT
                        OI.OrderItemId,
                        OI.ProductId,
                        OI.Quantity,
                        OI.UnitPrice,
                        OI.LineTotal,
                        P.ProductName,
                        P.ImagePath
                    FROM OrderItems OI
                    INNER JOIN Products P ON OI.ProductId = P.ProductId
                    WHERE OI.OrderId = @OrderId
                ";

                SqlParameter[] parameters =
                {
                    new SqlParameter("@OrderId", orderId)
                };

                DataTable dtItems = DatabaseHelper.GetDataTable(query, parameters);

                foreach (DataRow row in dtItems.Rows)
                {
                    Panel itemPanel = new Panel();
                    itemPanel.Width = 400;
                    itemPanel.Height = 60;
                    itemPanel.BackColor = Color.White;
                    itemPanel.Margin = new Padding(3);

                    PictureBox pic = new PictureBox();
                    pic.Left = 5;
                    pic.Top = 5;
                    pic.Width = 50;
                    pic.Height = 50;
                    pic.BorderStyle = BorderStyle.FixedSingle;
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic.BackColor = Color.WhiteSmoke;

                    try
                    {
                        string imagePath = row["ImagePath"].ToString() ?? "";
                        if (!string.IsNullOrWhiteSpace(imagePath) && File.Exists(imagePath))
                        {
                            using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                            {
                                Image img = Image.FromStream(fs);
                                pic.Image = new Bitmap(img);
                            }
                        }
                    }
                    catch
                    {
                        pic.Image = null;
                    }

                    Label lblName = new Label();
                    lblName.Left = 65;
                    lblName.Top = 8;
                    lblName.Width = 210;
                    lblName.Text = row["ProductName"].ToString();
                    lblName.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                    lblName.ForeColor = Color.Black;

                    Label lblQty = new Label();
                    lblQty.Left = 65;
                    lblQty.Top = 32;
                    lblQty.Width = 170;
                    lblQty.Text = "Qty: " + row["Quantity"].ToString() + " × " +
                                  Convert.ToDecimal(row["UnitPrice"]).ToString("0.00") + " Tk";
                    lblQty.Font = new Font("Segoe UI", 9, FontStyle.Regular);
                    lblQty.ForeColor = Color.DimGray;

                    Label lblPrice = new Label();
                    lblPrice.Left = 300;
                    lblPrice.Top = 18;
                    lblPrice.Width = 90;
                    lblPrice.Text = Convert.ToDecimal(row["LineTotal"]).ToString("0.00") + " Tk";
                    lblPrice.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    lblPrice.ForeColor = Color.Black;

                    itemPanel.Controls.Add(pic);
                    itemPanel.Controls.Add(lblName);
                    itemPanel.Controls.Add(lblQty);
                    itemPanel.Controls.Add(lblPrice);

                    flpOrderItems.Controls.Add(itemPanel);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Order items load error: " + ex.Message);
            }
        }

        private void UpdateActionButtons(string status)
        {
            bool canCancel =
                status.Equals("Pending", StringComparison.OrdinalIgnoreCase) ||
                status.Equals("Processing", StringComparison.OrdinalIgnoreCase);

            btnCancelOrder.Enabled = canCancel;
            btnReorder.Enabled = true;
        }

        private void ClearOrderDetails()
        {
            lblOrderIdValue.Text = "-";
            lblStatusValue.Text = "-";
            lblCustomerInfoValue.Text = "-";
            lblShippingAddressValue.Text = "-";
            lblSubtotalValue.Text = "0.00 Tk";
            lblShippingValue.Text = "0.00 Tk";
            lblTaxValue.Text = "0.00 Tk";
            lblTotalAmountValue.Text = "0.00 Tk";
            flpOrderItems.Controls.Clear();
            btnCancelOrder.Enabled = false;
            btnReorder.Enabled = false;
        }

        private void btnGoBack_Click(object? sender, EventArgs e)
        {
            CustomerDashboardForm form = new CustomerDashboardForm();
            form.Show();
            this.Hide();
        }

        private void btnCart_Click(object? sender, EventArgs e)
        {
            CartForm form = new CartForm();
            form.ShowDialog();
        }

        private void btnWishlist_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Wishlist form is not created yet.");
        }

        private void btnApplyFilters_Click(object? sender, EventArgs e)
        {
            currentPage = 1;
            ApplyFiltersAndBind();
        }

        private void btnClearFilters_Click(object? sender, EventArgs e)
        {
            cmbOrderStatus.SelectedIndex = 0;
            txtSearchOrders.Clear();
            dtpStartDate.Value = DateTime.Today.AddMonths(-3);
            dtpEndDate.Value = DateTime.Today;
            currentPage = 1;
            HighlightTab("ALL");
            ApplyFiltersAndBind();
        }

        private void txtSearchOrders_TextChanged(object? sender, EventArgs e)
        {
            currentPage = 1;
            ApplyFiltersAndBind();
        }

        private void lnkAllOrders_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            cmbOrderStatus.SelectedIndex = 0;
            currentPage = 1;
            HighlightTab("ALL");
            ApplyFiltersAndBind();
        }

        private void lnkPending_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            cmbOrderStatus.Text = "Pending";
            currentPage = 1;
            HighlightTab("PENDING");
            ApplyFiltersAndBind();
        }

        private void lnkShipped_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            cmbOrderStatus.Text = "Shipped";
            currentPage = 1;
            HighlightTab("SHIPPED");
            ApplyFiltersAndBind();
        }

        private void lnkCompleted_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            cmbOrderStatus.Text = "Delivered";
            currentPage = 1;
            HighlightTab("COMPLETED");
            ApplyFiltersAndBind();
        }

        private void HighlightTab(string tabName)
        {
            ResetLinkStyle(lnkAllOrders);
            ResetLinkStyle(lnkPending);
            ResetLinkStyle(lnkShipped);
            ResetLinkStyle(lnkCompleted);

            if (tabName == "ALL") SetActiveLinkStyle(lnkAllOrders);
            else if (tabName == "PENDING") SetActiveLinkStyle(lnkPending);
            else if (tabName == "SHIPPED") SetActiveLinkStyle(lnkShipped);
            else if (tabName == "COMPLETED") SetActiveLinkStyle(lnkCompleted);
        }

        private void ResetLinkStyle(LinkLabel link)
        {
            link.LinkColor = Color.DimGray;
            link.Font = new Font("Segoe UI", 11, FontStyle.Regular);
        }

        private void SetActiveLinkStyle(LinkLabel link)
        {
            link.LinkColor = Color.Purple;
            link.Font = new Font("Segoe UI", 11, FontStyle.Bold);
        }

        private void btnPrevPage_Click(object? sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                ApplyFiltersAndBind();
            }
        }

        private void btnNextPage_Click(object? sender, EventArgs e)
        {
            currentPage++;
            ApplyFiltersAndBind();
        }

        private void btnPage1_Click(object? sender, EventArgs e)
        {
            currentPage = 1;
            ApplyFiltersAndBind();
        }

        private void btnPage2_Click(object? sender, EventArgs e)
        {
            currentPage = 2;
            ApplyFiltersAndBind();
        }

        private void btnPage3_Click(object? sender, EventArgs e)
        {
            currentPage = 3;
            ApplyFiltersAndBind();
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
            btn.BackColor = Color.White;
            btn.ForeColor = Color.Black;
            btn.FlatStyle = FlatStyle.Flat;
        }

        private void SetActivePageButton(Button btn)
        {
            btn.BackColor = Color.Purple;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
        }

        private void btnCancelOrder_Click(object? sender, EventArgs e)
        {
            try
            {
                if (dgvMyOrders.CurrentRow == null || dgvMyOrders.CurrentRow.Cells["OrderId"].Value == null)
                    return;

                int orderId = Convert.ToInt32(dgvMyOrders.CurrentRow.Cells["OrderId"].Value);
                string status = lblStatusValue.Text.Trim();

                if (!(status.Equals("Pending", StringComparison.OrdinalIgnoreCase) ||
                      status.Equals("Processing", StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show("Only pending or processing orders can be cancelled.");
                    return;
                }

                DialogResult dr = MessageBox.Show("Are you sure you want to cancel this order?", "Confirm", MessageBoxButtons.YesNo);
                if (dr != DialogResult.Yes)
                    return;

                string query = "UPDATE Orders SET OrderStatus = 'Cancelled' WHERE OrderId = @OrderId";
                SqlParameter[] parameters =
                {
                    new SqlParameter("@OrderId", orderId)
                };

                DatabaseHelper.ExecuteNonQuery(query, parameters);

                MessageBox.Show("Order cancelled successfully.");
                LoadOrders();
                ApplyFiltersAndBind();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cancel order error: " + ex.Message);
            }
        }

        private void btnReorder_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Reorder feature will add these items to cart.");
        }

        private void btnViewInvoice_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Invoice preview feature can be added next.");
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}