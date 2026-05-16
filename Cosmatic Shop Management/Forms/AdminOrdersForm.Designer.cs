namespace Cosmatic_Shop_Management.Forms
{
    partial class AdminOrdersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminOrdersForm));
            pnlTopHeader = new Panel();
            btnGoBack = new Button();
            btnLogout = new Button();
            btnFilters = new Button();
            txtSearchOrders = new TextBox();
            pnlOrdersList = new Panel();
            dgvOrders = new DataGridView();
            pnlOrderDetails = new Panel();
            btnPrintInvoice = new Button();
            btnUpdateStatus = new Button();
            txtAdminNotes = new TextBox();
            lblAdminNotes = new Label();
            cmbOrderStatus = new ComboBox();
            lblUpdateStatusTitle = new Label();
            pnlTotalPayable = new Panel();
            lblTotalPayableValue = new Label();
            lblTotalPayableTitle = new Label();
            pnlTax = new Panel();
            lblTaxValue = new Label();
            lblTaxTitle = new Label();
            pnlShipping = new Panel();
            lblShippingCostValue = new Label();
            lblShippingCostTitle = new Label();
            pnlSubtotal = new Panel();
            lblSubtotalValue = new Label();
            lblSubtotalTitle = new Label();
            pnlOrderCard = new Panel();
            lblShippingAddress = new Label();
            lblShippingTitle = new Label();
            lblCustomerName = new Label();
            lblCustomerTitle = new Label();
            lblProductPrice = new Label();
            lblProductName = new Label();
            lblOrderNo = new Label();
            picOrderProduct = new PictureBox();
            lblCloseDetail = new Label();
            lblOrderDetailTitle = new Label();
            pnlTopHeader.SuspendLayout();
            pnlOrdersList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            pnlOrderDetails.SuspendLayout();
            pnlTotalPayable.SuspendLayout();
            pnlTax.SuspendLayout();
            pnlShipping.SuspendLayout();
            pnlSubtotal.SuspendLayout();
            pnlOrderCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picOrderProduct).BeginInit();
            SuspendLayout();
            // 
            // pnlTopHeader
            // 
            pnlTopHeader.BackColor = Color.White;
            pnlTopHeader.BorderStyle = BorderStyle.FixedSingle;
            pnlTopHeader.Controls.Add(btnGoBack);
            pnlTopHeader.Controls.Add(btnLogout);
            pnlTopHeader.Controls.Add(btnFilters);
            pnlTopHeader.Controls.Add(txtSearchOrders);
            pnlTopHeader.Dock = DockStyle.Top;
            pnlTopHeader.Location = new Point(0, 0);
            pnlTopHeader.Name = "pnlTopHeader";
            pnlTopHeader.Size = new Size(1378, 70);
            pnlTopHeader.TabIndex = 0;
            pnlTopHeader.Paint += pnlTopHeader_Paint;
            // 
            // btnGoBack
            // 
            btnGoBack.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGoBack.Cursor = Cursors.Hand;
            btnGoBack.FlatAppearance.BorderSize = 0;
            btnGoBack.FlatStyle = FlatStyle.Flat;
            btnGoBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGoBack.ForeColor = Color.FromArgb(74, 20, 140);
            btnGoBack.Location = new Point(1094, 18);
            btnGoBack.Name = "btnGoBack";
            btnGoBack.Size = new Size(210, 40);
            btnGoBack.TabIndex = 4;
            btnGoBack.Text = "← Back to Dashboard";
            btnGoBack.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.Location = new Point(1310, 13);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(45, 45);
            btnLogout.TabIndex = 2;
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnFilters
            // 
            btnFilters.Cursor = Cursors.Hand;
            btnFilters.FlatAppearance.BorderSize = 0;
            btnFilters.FlatStyle = FlatStyle.Flat;
            btnFilters.Font = new Font("Segoe UI Emoji", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFilters.Location = new Point(452, 13);
            btnFilters.Margin = new Padding(0);
            btnFilters.Name = "btnFilters";
            btnFilters.Size = new Size(45, 45);
            btnFilters.TabIndex = 1;
            btnFilters.Text = "☰";
            btnFilters.UseVisualStyleBackColor = true;
            // 
            // txtSearchOrders
            // 
            txtSearchOrders.BorderStyle = BorderStyle.FixedSingle;
            txtSearchOrders.Font = new Font("Segoe UI", 11F);
            txtSearchOrders.Location = new Point(20, 18);
            txtSearchOrders.Name = "txtSearchOrders";
            txtSearchOrders.PlaceholderText = "  Search orders by ID, customer or product...";
            txtSearchOrders.Size = new Size(420, 37);
            txtSearchOrders.TabIndex = 0;
            // 
            // pnlOrdersList
            // 
            pnlOrdersList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlOrdersList.BorderStyle = BorderStyle.FixedSingle;
            pnlOrdersList.Controls.Add(dgvOrders);
            pnlOrdersList.Location = new Point(20, 90);
            pnlOrdersList.Name = "pnlOrdersList";
            pnlOrdersList.Size = new Size(780, 762);
            pnlOrdersList.TabIndex = 1;
            // 
            // dgvOrders
            // 
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.AllowUserToDeleteRows = false;
            dgvOrders.AllowUserToResizeRows = false;
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrders.BackgroundColor = Color.White;
            dgvOrders.BorderStyle = BorderStyle.None;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Dock = DockStyle.Fill;
            dgvOrders.Location = new Point(0, 0);
            dgvOrders.MultiSelect = false;
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.RowHeadersWidth = 62;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.Size = new Size(778, 760);
            dgvOrders.TabIndex = 0;
            // 
            // pnlOrderDetails
            // 
            pnlOrderDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pnlOrderDetails.BackColor = Color.Beige;
            pnlOrderDetails.BorderStyle = BorderStyle.FixedSingle;
            pnlOrderDetails.Controls.Add(btnPrintInvoice);
            pnlOrderDetails.Controls.Add(btnUpdateStatus);
            pnlOrderDetails.Controls.Add(txtAdminNotes);
            pnlOrderDetails.Controls.Add(lblAdminNotes);
            pnlOrderDetails.Controls.Add(cmbOrderStatus);
            pnlOrderDetails.Controls.Add(lblUpdateStatusTitle);
            pnlOrderDetails.Controls.Add(pnlTotalPayable);
            pnlOrderDetails.Controls.Add(pnlTax);
            pnlOrderDetails.Controls.Add(pnlShipping);
            pnlOrderDetails.Controls.Add(pnlSubtotal);
            pnlOrderDetails.Controls.Add(pnlOrderCard);
            pnlOrderDetails.Controls.Add(lblCloseDetail);
            pnlOrderDetails.Controls.Add(lblOrderDetailTitle);
            pnlOrderDetails.Location = new Point(820, 90);
            pnlOrderDetails.Name = "pnlOrderDetails";
            pnlOrderDetails.Size = new Size(500, 762);
            pnlOrderDetails.TabIndex = 2;
            // 
            // btnPrintInvoice
            // 
            btnPrintInvoice.BackColor = Color.White;
            btnPrintInvoice.FlatAppearance.BorderColor = Color.FromArgb(74, 20, 140);
            btnPrintInvoice.FlatAppearance.BorderSize = 3;
            btnPrintInvoice.FlatStyle = FlatStyle.Flat;
            btnPrintInvoice.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrintInvoice.ForeColor = Color.FromArgb(74, 20, 140);
            btnPrintInvoice.Location = new Point(20, 696);
            btnPrintInvoice.Margin = new Padding(0);
            btnPrintInvoice.Name = "btnPrintInvoice";
            btnPrintInvoice.Size = new Size(450, 53);
            btnPrintInvoice.TabIndex = 17;
            btnPrintInvoice.Text = "Print Invoice";
            btnPrintInvoice.UseVisualStyleBackColor = false;
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.BackColor = Color.Coral;
            btnUpdateStatus.Cursor = Cursors.Hand;
            btnUpdateStatus.FlatAppearance.BorderSize = 0;
            btnUpdateStatus.FlatStyle = FlatStyle.Flat;
            btnUpdateStatus.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateStatus.ForeColor = Color.White;
            btnUpdateStatus.Location = new Point(20, 640);
            btnUpdateStatus.Margin = new Padding(0);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(450, 42);
            btnUpdateStatus.TabIndex = 16;
            btnUpdateStatus.Text = "Update Status";
            btnUpdateStatus.UseVisualStyleBackColor = false;
            // 
            // txtAdminNotes
            // 
            txtAdminNotes.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAdminNotes.Location = new Point(20, 540);
            txtAdminNotes.Multiline = true;
            txtAdminNotes.Name = "txtAdminNotes";
            txtAdminNotes.ScrollBars = ScrollBars.Vertical;
            txtAdminNotes.Size = new Size(450, 75);
            txtAdminNotes.TabIndex = 15;
            // 
            // lblAdminNotes
            // 
            lblAdminNotes.AutoSize = true;
            lblAdminNotes.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdminNotes.ForeColor = Color.DimGray;
            lblAdminNotes.Location = new Point(20, 500);
            lblAdminNotes.Name = "lblAdminNotes";
            lblAdminNotes.Size = new Size(152, 28);
            lblAdminNotes.TabIndex = 14;
            lblAdminNotes.Text = "ADMIN NOTES";
            // 
            // cmbOrderStatus
            // 
            cmbOrderStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOrderStatus.Font = new Font("Segoe UI", 11F);
            cmbOrderStatus.FormattingEnabled = true;
            cmbOrderStatus.Items.AddRange(new object[] { "Pending", "", "Processing", "", "Shipped", "", "Delivered", "", "Cancelled" });
            cmbOrderStatus.Location = new Point(20, 453);
            cmbOrderStatus.Name = "cmbOrderStatus";
            cmbOrderStatus.Size = new Size(450, 38);
            cmbOrderStatus.TabIndex = 13;
            // 
            // lblUpdateStatusTitle
            // 
            lblUpdateStatusTitle.AutoSize = true;
            lblUpdateStatusTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUpdateStatusTitle.ForeColor = Color.DimGray;
            lblUpdateStatusTitle.Location = new Point(20, 422);
            lblUpdateStatusTitle.Name = "lblUpdateStatusTitle";
            lblUpdateStatusTitle.Size = new Size(240, 28);
            lblUpdateStatusTitle.TabIndex = 8;
            lblUpdateStatusTitle.Text = "UPDATE ORDER STATUS";
            // 
            // pnlTotalPayable
            // 
            pnlTotalPayable.BackColor = Color.FromArgb(252, 228, 236);
            pnlTotalPayable.BorderStyle = BorderStyle.FixedSingle;
            pnlTotalPayable.Controls.Add(lblTotalPayableValue);
            pnlTotalPayable.Controls.Add(lblTotalPayableTitle);
            pnlTotalPayable.Location = new Point(20, 364);
            pnlTotalPayable.Name = "pnlTotalPayable";
            pnlTotalPayable.Size = new Size(450, 55);
            pnlTotalPayable.TabIndex = 12;
            // 
            // lblTotalPayableValue
            // 
            lblTotalPayableValue.AutoSize = true;
            lblTotalPayableValue.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPayableValue.ForeColor = Color.FromArgb(74, 20, 140);
            lblTotalPayableValue.Location = new Point(340, 13);
            lblTotalPayableValue.Name = "lblTotalPayableValue";
            lblTotalPayableValue.Size = new Size(89, 38);
            lblTotalPayableValue.TabIndex = 9;
            lblTotalPayableValue.Text = "96.66";
            // 
            // lblTotalPayableTitle
            // 
            lblTotalPayableTitle.AutoSize = true;
            lblTotalPayableTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPayableTitle.ForeColor = Color.FromArgb(74, 20, 140);
            lblTotalPayableTitle.Location = new Point(15, 15);
            lblTotalPayableTitle.Name = "lblTotalPayableTitle";
            lblTotalPayableTitle.Size = new Size(165, 32);
            lblTotalPayableTitle.TabIndex = 8;
            lblTotalPayableTitle.Text = "Total Payable";
            // 
            // pnlTax
            // 
            pnlTax.BackColor = Color.White;
            pnlTax.BorderStyle = BorderStyle.FixedSingle;
            pnlTax.Controls.Add(lblTaxValue);
            pnlTax.Controls.Add(lblTaxTitle);
            pnlTax.Location = new Point(20, 313);
            pnlTax.Name = "pnlTax";
            pnlTax.Size = new Size(450, 45);
            pnlTax.TabIndex = 11;
            // 
            // lblTaxValue
            // 
            lblTaxValue.AutoSize = true;
            lblTaxValue.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTaxValue.ForeColor = Color.Gray;
            lblTaxValue.Location = new Point(360, 8);
            lblTaxValue.Name = "lblTaxValue";
            lblTaxValue.Size = new Size(58, 30);
            lblTaxValue.TabIndex = 9;
            lblTaxValue.Text = "7.16";
            // 
            // lblTaxTitle
            // 
            lblTaxTitle.AutoSize = true;
            lblTaxTitle.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTaxTitle.ForeColor = Color.Gray;
            lblTaxTitle.Location = new Point(15, 8);
            lblTaxTitle.Name = "lblTaxTitle";
            lblTaxTitle.Size = new Size(94, 30);
            lblTaxTitle.TabIndex = 8;
            lblTaxTitle.Text = "Tax (8%)";
            // 
            // pnlShipping
            // 
            pnlShipping.BackColor = Color.White;
            pnlShipping.BorderStyle = BorderStyle.FixedSingle;
            pnlShipping.Controls.Add(lblShippingCostValue);
            pnlShipping.Controls.Add(lblShippingCostTitle);
            pnlShipping.Location = new Point(20, 262);
            pnlShipping.Name = "pnlShipping";
            pnlShipping.Size = new Size(450, 45);
            pnlShipping.TabIndex = 10;
            // 
            // lblShippingCostValue
            // 
            lblShippingCostValue.AutoSize = true;
            lblShippingCostValue.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblShippingCostValue.ForeColor = Color.Gray;
            lblShippingCostValue.Location = new Point(360, 8);
            lblShippingCostValue.Name = "lblShippingCostValue";
            lblShippingCostValue.Size = new Size(58, 30);
            lblShippingCostValue.TabIndex = 9;
            lblShippingCostValue.Text = "0.00";
            // 
            // lblShippingCostTitle
            // 
            lblShippingCostTitle.AutoSize = true;
            lblShippingCostTitle.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblShippingCostTitle.ForeColor = Color.Gray;
            lblShippingCostTitle.Location = new Point(15, 8);
            lblShippingCostTitle.Name = "lblShippingCostTitle";
            lblShippingCostTitle.Size = new Size(98, 30);
            lblShippingCostTitle.TabIndex = 8;
            lblShippingCostTitle.Text = "Shipping";
            // 
            // pnlSubtotal
            // 
            pnlSubtotal.BackColor = Color.White;
            pnlSubtotal.BorderStyle = BorderStyle.FixedSingle;
            pnlSubtotal.Controls.Add(lblSubtotalValue);
            pnlSubtotal.Controls.Add(lblSubtotalTitle);
            pnlSubtotal.Location = new Point(20, 211);
            pnlSubtotal.Name = "pnlSubtotal";
            pnlSubtotal.Size = new Size(450, 45);
            pnlSubtotal.TabIndex = 3;
            // 
            // lblSubtotalValue
            // 
            lblSubtotalValue.AutoSize = true;
            lblSubtotalValue.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtotalValue.ForeColor = Color.Gray;
            lblSubtotalValue.Location = new Point(360, 8);
            lblSubtotalValue.Name = "lblSubtotalValue";
            lblSubtotalValue.Size = new Size(71, 30);
            lblSubtotalValue.TabIndex = 9;
            lblSubtotalValue.Text = "89.50\n";
            // 
            // lblSubtotalTitle
            // 
            lblSubtotalTitle.AutoSize = true;
            lblSubtotalTitle.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtotalTitle.ForeColor = Color.Gray;
            lblSubtotalTitle.Location = new Point(15, 8);
            lblSubtotalTitle.Name = "lblSubtotalTitle";
            lblSubtotalTitle.Size = new Size(93, 30);
            lblSubtotalTitle.TabIndex = 8;
            lblSubtotalTitle.Text = "Subtotal";
            // 
            // pnlOrderCard
            // 
            pnlOrderCard.BackColor = Color.White;
            pnlOrderCard.BorderStyle = BorderStyle.FixedSingle;
            pnlOrderCard.Controls.Add(lblShippingAddress);
            pnlOrderCard.Controls.Add(lblShippingTitle);
            pnlOrderCard.Controls.Add(lblCustomerName);
            pnlOrderCard.Controls.Add(lblCustomerTitle);
            pnlOrderCard.Controls.Add(lblProductPrice);
            pnlOrderCard.Controls.Add(lblProductName);
            pnlOrderCard.Controls.Add(lblOrderNo);
            pnlOrderCard.Controls.Add(picOrderProduct);
            pnlOrderCard.Location = new Point(20, 51);
            pnlOrderCard.Name = "pnlOrderCard";
            pnlOrderCard.Size = new Size(450, 154);
            pnlOrderCard.TabIndex = 2;
            // 
            // lblShippingAddress
            // 
            lblShippingAddress.AutoSize = true;
            lblShippingAddress.BackColor = Color.Transparent;
            lblShippingAddress.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblShippingAddress.ForeColor = Color.Black;
            lblShippingAddress.Location = new Point(250, 120);
            lblShippingAddress.Name = "lblShippingAddress";
            lblShippingAddress.Size = new Size(142, 28);
            lblShippingAddress.TabIndex = 7;
            lblShippingAddress.Text = "2104 Maple St.";
            // 
            // lblShippingTitle
            // 
            lblShippingTitle.AutoSize = true;
            lblShippingTitle.BackColor = Color.Transparent;
            lblShippingTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblShippingTitle.ForeColor = Color.Gray;
            lblShippingTitle.Location = new Point(250, 95);
            lblShippingTitle.Name = "lblShippingTitle";
            lblShippingTitle.Size = new Size(126, 25);
            lblShippingTitle.TabIndex = 6;
            lblShippingTitle.Text = "SHIPPING TO";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCustomerName.ForeColor = Color.Black;
            lblCustomerName.Location = new Point(15, 120);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(144, 28);
            lblCustomerName.TabIndex = 5;
            lblCustomerName.Text = "Bonnie Bennett";
            // 
            // lblCustomerTitle
            // 
            lblCustomerTitle.AutoSize = true;
            lblCustomerTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerTitle.ForeColor = Color.Gray;
            lblCustomerTitle.Location = new Point(15, 95);
            lblCustomerTitle.Name = "lblCustomerTitle";
            lblCustomerTitle.Size = new Size(109, 25);
            lblCustomerTitle.TabIndex = 4;
            lblCustomerTitle.Text = "CUSTOMER";
            // 
            // lblProductPrice
            // 
            lblProductPrice.AutoSize = true;
            lblProductPrice.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProductPrice.ForeColor = Color.Black;
            lblProductPrice.Location = new Point(105, 65);
            lblProductPrice.Name = "lblProductPrice";
            lblProductPrice.Size = new Size(66, 30);
            lblProductPrice.TabIndex = 3;
            lblProductPrice.Text = "89.50";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductName.ForeColor = Color.FromArgb(74, 20, 140);
            lblProductName.Location = new Point(105, 35);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(313, 38);
            lblProductName.TabIndex = 2;
            lblProductName.Text = "Midnight Glow Palette";
            // 
            // lblOrderNo
            // 
            lblOrderNo.AutoSize = true;
            lblOrderNo.ForeColor = Color.Gray;
            lblOrderNo.Location = new Point(105, 15);
            lblOrderNo.Name = "lblOrderNo";
            lblOrderNo.Size = new Size(136, 25);
            lblOrderNo.TabIndex = 1;
            lblOrderNo.Text = "ORDER #77822";
            // 
            // picOrderProduct
            // 
            picOrderProduct.BorderStyle = BorderStyle.FixedSingle;
            picOrderProduct.Location = new Point(15, 15);
            picOrderProduct.Name = "picOrderProduct";
            picOrderProduct.Size = new Size(75, 75);
            picOrderProduct.SizeMode = PictureBoxSizeMode.StretchImage;
            picOrderProduct.TabIndex = 0;
            picOrderProduct.TabStop = false;
            // 
            // lblCloseDetail
            // 
            lblCloseDetail.AutoSize = true;
            lblCloseDetail.BackColor = Color.Transparent;
            lblCloseDetail.Cursor = Cursors.Hand;
            lblCloseDetail.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCloseDetail.ForeColor = Color.Gray;
            lblCloseDetail.Location = new Point(451, 0);
            lblCloseDetail.Name = "lblCloseDetail";
            lblCloseDetail.Size = new Size(35, 38);
            lblCloseDetail.TabIndex = 1;
            lblCloseDetail.Text = "X";
            // 
            // lblOrderDetailTitle
            // 
            lblOrderDetailTitle.AutoSize = true;
            lblOrderDetailTitle.BackColor = Color.Transparent;
            lblOrderDetailTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderDetailTitle.ForeColor = Color.FromArgb(74, 20, 140);
            lblOrderDetailTitle.Location = new Point(3, 0);
            lblOrderDetailTitle.Name = "lblOrderDetailTitle";
            lblOrderDetailTitle.Size = new Size(225, 48);
            lblOrderDetailTitle.TabIndex = 0;
            lblOrderDetailTitle.Text = "Order Detail";
            // 
            // AdminOrdersForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1378, 906);
            Controls.Add(pnlOrderDetails);
            Controls.Add(pnlOrdersList);
            Controls.Add(pnlTopHeader);
            Name = "AdminOrdersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminOrdersForm";
            WindowState = FormWindowState.Maximized;
            pnlTopHeader.ResumeLayout(false);
            pnlTopHeader.PerformLayout();
            pnlOrdersList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            pnlOrderDetails.ResumeLayout(false);
            pnlOrderDetails.PerformLayout();
            pnlTotalPayable.ResumeLayout(false);
            pnlTotalPayable.PerformLayout();
            pnlTax.ResumeLayout(false);
            pnlTax.PerformLayout();
            pnlShipping.ResumeLayout(false);
            pnlShipping.PerformLayout();
            pnlSubtotal.ResumeLayout(false);
            pnlSubtotal.PerformLayout();
            pnlOrderCard.ResumeLayout(false);
            pnlOrderCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picOrderProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTopHeader;
        private Button btnFilters;
        private TextBox txtSearchOrders;
        private Button btnLogout;
        private Panel pnlOrdersList;
        private DataGridView dgvOrders;
        private Panel pnlOrderDetails;
        private Label lblCloseDetail;
        private Label lblOrderDetailTitle;
        private Panel pnlOrderCard;
        private Label lblOrderNo;
        private PictureBox picOrderProduct;
        private Label lblProductName;
        private Label lblCustomerTitle;
        private Label lblProductPrice;
        private Panel pnlSubtotal;
        private Label lblShippingAddress;
        private Label lblShippingTitle;
        private Label lblCustomerName;
        private Panel pnlShipping;
        private Label lblShippingCostValue;
        private Label lblShippingCostTitle;
        private Label lblSubtotalValue;
        private Label lblSubtotalTitle;
        private Panel pnlTotalPayable;
        private Label lblTotalPayableValue;
        private Label lblTotalPayableTitle;
        private Panel pnlTax;
        private Label lblTaxValue;
        private Label lblTaxTitle;
        private Label lblUpdateStatusTitle;
        private ComboBox cmbOrderStatus;
        private Button btnUpdateStatus;
        private TextBox txtAdminNotes;
        private Label lblAdminNotes;
        private Button btnPrintInvoice;
        private Button btnGoBack;
    }
}