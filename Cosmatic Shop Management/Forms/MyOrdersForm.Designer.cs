namespace Cosmatic_Shop_Management.Forms
{
    partial class MyOrdersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyOrdersForm));
            pnlTopHeader = new Panel();
            btnCart = new Button();
            btnWishlist = new Button();
            txtSearchOrders = new TextBox();
            lnkCompleted = new LinkLabel();
            lnkShipped = new LinkLabel();
            lnkPending = new LinkLabel();
            lnkAllOrders = new LinkLabel();
            lblFormTitle = new Label();
            pnlOrderFilters = new Panel();
            btnGoBack = new Button();
            btnClearFilters = new Button();
            btnApplyFilters = new Button();
            dtpEndDate = new DateTimePicker();
            lblEndDateTitle = new Label();
            dtpStartDate = new DateTimePicker();
            lblStartDateTitle = new Label();
            cmbOrderStatus = new ComboBox();
            lblFilterStatusTitle = new Label();
            dgvMyOrders = new DataGridView();
            pnlOrderDetails = new Panel();
            btnReview = new Button();
            btnCancelOrder = new Button();
            btnReorder = new Button();
            lblTotalAmountValue = new Label();
            lblTotalAmountTitle = new Label();
            lblTaxValue = new Label();
            lblTaxTitle = new Label();
            lblShippingValue = new Label();
            lblShippingTitle = new Label();
            lblSubtotalValue = new Label();
            lblSubtotalTitle = new Label();
            flpOrderItems = new FlowLayoutPanel();
            lblOrderItemsTitle = new Label();
            lblStatusValue = new Label();
            lblStatusTitle = new Label();
            lblShippingAddressValue = new Label();
            lblShippingAddressTitle = new Label();
            lblCustomerInfoValue = new Label();
            lblCustomerInfoTitle = new Label();
            lblOrderIdValue = new Label();
            lblOrderIdTitle = new Label();
            btnOrderMail = new Button();
            btnViewInvoice = new Button();
            lblOrderDetailsTitle = new Label();
            btnNextPage = new Button();
            btnPage3 = new Button();
            btnPage2 = new Button();
            btnPage1 = new Button();
            btnPrevPage = new Button();
            pnlTopHeader.SuspendLayout();
            pnlOrderFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMyOrders).BeginInit();
            pnlOrderDetails.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTopHeader
            // 
            pnlTopHeader.BackColor = Color.White;
            pnlTopHeader.BorderStyle = BorderStyle.FixedSingle;
            pnlTopHeader.Controls.Add(btnCart);
            pnlTopHeader.Controls.Add(btnWishlist);
            pnlTopHeader.Controls.Add(txtSearchOrders);
            pnlTopHeader.Controls.Add(lnkCompleted);
            pnlTopHeader.Controls.Add(lnkShipped);
            pnlTopHeader.Controls.Add(lnkPending);
            pnlTopHeader.Controls.Add(lnkAllOrders);
            pnlTopHeader.Controls.Add(lblFormTitle);
            pnlTopHeader.Dock = DockStyle.Top;
            pnlTopHeader.Location = new Point(0, 0);
            pnlTopHeader.Name = "pnlTopHeader";
            pnlTopHeader.Size = new Size(1358, 80);
            pnlTopHeader.TabIndex = 0;
            pnlTopHeader.Paint += pnlTopHeader_Paint;
            // 
            // btnCart
            // 
            btnCart.Anchor = AnchorStyles.Right;
            btnCart.BackColor = Color.White;
            btnCart.Cursor = Cursors.Hand;
            btnCart.FlatAppearance.BorderSize = 0;
            btnCart.FlatStyle = FlatStyle.Flat;
            btnCart.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCart.ForeColor = Color.FromArgb(74, 20, 140);
            btnCart.Image = (Image)resources.GetObject("btnCart.Image");
            btnCart.Location = new Point(1275, 19);
            btnCart.Margin = new Padding(0);
            btnCart.Name = "btnCart";
            btnCart.Size = new Size(55, 55);
            btnCart.TabIndex = 6;
            btnCart.UseVisualStyleBackColor = false;
            // 
            // btnWishlist
            // 
            btnWishlist.Anchor = AnchorStyles.Right;
            btnWishlist.Cursor = Cursors.Hand;
            btnWishlist.FlatAppearance.BorderSize = 0;
            btnWishlist.FlatStyle = FlatStyle.Flat;
            btnWishlist.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnWishlist.ForeColor = Color.FromArgb(74, 20, 140);
            btnWishlist.Image = (Image)resources.GetObject("btnWishlist.Image");
            btnWishlist.Location = new Point(1192, 20);
            btnWishlist.Margin = new Padding(0);
            btnWishlist.Name = "btnWishlist";
            btnWishlist.Size = new Size(55, 55);
            btnWishlist.TabIndex = 4;
            btnWishlist.UseVisualStyleBackColor = true;
            // 
            // txtSearchOrders
            // 
            txtSearchOrders.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearchOrders.BackColor = Color.White;
            txtSearchOrders.BorderStyle = BorderStyle.FixedSingle;
            txtSearchOrders.Font = new Font("Segoe UI", 11F);
            txtSearchOrders.Location = new Point(709, 30);
            txtSearchOrders.Name = "txtSearchOrders";
            txtSearchOrders.PlaceholderText = "🔎︎ Search ...";
            txtSearchOrders.Size = new Size(468, 37);
            txtSearchOrders.TabIndex = 5;
            // 
            // lnkCompleted
            // 
            lnkCompleted.ActiveLinkColor = Color.FromArgb(74, 20, 140);
            lnkCompleted.AutoSize = true;
            lnkCompleted.BackColor = Color.Transparent;
            lnkCompleted.Font = new Font("Segoe UI", 9F);
            lnkCompleted.LinkColor = Color.DimGray;
            lnkCompleted.Location = new Point(664, 36);
            lnkCompleted.Name = "lnkCompleted";
            lnkCompleted.Size = new Size(100, 25);
            lnkCompleted.TabIndex = 4;
            lnkCompleted.TabStop = true;
            lnkCompleted.Text = "Completed";
            lnkCompleted.VisitedLinkColor = Color.DimGray;
            // 
            // lnkShipped
            // 
            lnkShipped.ActiveLinkColor = Color.FromArgb(74, 20, 140);
            lnkShipped.AutoSize = true;
            lnkShipped.BackColor = Color.Transparent;
            lnkShipped.Font = new Font("Segoe UI", 9F);
            lnkShipped.LinkColor = Color.DimGray;
            lnkShipped.Location = new Point(569, 36);
            lnkShipped.Name = "lnkShipped";
            lnkShipped.Size = new Size(78, 25);
            lnkShipped.TabIndex = 3;
            lnkShipped.TabStop = true;
            lnkShipped.Text = "Shipped";
            lnkShipped.VisitedLinkColor = Color.DimGray;
            // 
            // lnkPending
            // 
            lnkPending.ActiveLinkColor = Color.FromArgb(74, 20, 140);
            lnkPending.AutoSize = true;
            lnkPending.BackColor = Color.Transparent;
            lnkPending.Font = new Font("Segoe UI", 9F);
            lnkPending.LinkColor = Color.DimGray;
            lnkPending.Location = new Point(465, 36);
            lnkPending.Name = "lnkPending";
            lnkPending.Size = new Size(76, 25);
            lnkPending.TabIndex = 2;
            lnkPending.TabStop = true;
            lnkPending.Text = "Pending";
            lnkPending.VisitedLinkColor = Color.DimGray;
            // 
            // lnkAllOrders
            // 
            lnkAllOrders.ActiveLinkColor = Color.FromArgb(74, 20, 140);
            lnkAllOrders.AutoSize = true;
            lnkAllOrders.BackColor = Color.Transparent;
            lnkAllOrders.Font = new Font("Segoe UI", 9F);
            lnkAllOrders.LinkColor = Color.DimGray;
            lnkAllOrders.Location = new Point(348, 36);
            lnkAllOrders.Name = "lnkAllOrders";
            lnkAllOrders.Size = new Size(91, 25);
            lnkAllOrders.TabIndex = 1;
            lnkAllOrders.TabStop = true;
            lnkAllOrders.Text = "All Orders";
            lnkAllOrders.VisitedLinkColor = Color.DimGray;
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.BackColor = Color.Transparent;
            lblFormTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormTitle.ForeColor = Color.Black;
            lblFormTitle.Location = new Point(30, 20);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(205, 48);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = " My Orders";
            // 
            // pnlOrderFilters
            // 
            pnlOrderFilters.Anchor = AnchorStyles.Top;
            pnlOrderFilters.BackColor = Color.FloralWhite;
            pnlOrderFilters.BorderStyle = BorderStyle.FixedSingle;
            pnlOrderFilters.Controls.Add(btnGoBack);
            pnlOrderFilters.Controls.Add(btnClearFilters);
            pnlOrderFilters.Controls.Add(btnApplyFilters);
            pnlOrderFilters.Controls.Add(dtpEndDate);
            pnlOrderFilters.Controls.Add(lblEndDateTitle);
            pnlOrderFilters.Controls.Add(dtpStartDate);
            pnlOrderFilters.Controls.Add(lblStartDateTitle);
            pnlOrderFilters.Controls.Add(cmbOrderStatus);
            pnlOrderFilters.Controls.Add(lblFilterStatusTitle);
            pnlOrderFilters.Location = new Point(20, 100);
            pnlOrderFilters.Name = "pnlOrderFilters";
            pnlOrderFilters.Size = new Size(1320, 95);
            pnlOrderFilters.TabIndex = 1;
            // 
            // btnGoBack
            // 
            btnGoBack.Anchor = AnchorStyles.Right;
            btnGoBack.Cursor = Cursors.Hand;
            btnGoBack.FlatAppearance.BorderSize = 0;
            btnGoBack.FlatStyle = FlatStyle.Flat;
            btnGoBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGoBack.ForeColor = Color.FromArgb(74, 20, 140);
            btnGoBack.Location = new Point(1076, 32);
            btnGoBack.Name = "btnGoBack";
            btnGoBack.Size = new Size(210, 40);
            btnGoBack.TabIndex = 7;
            btnGoBack.Text = "← Back to Dashboard";
            btnGoBack.UseVisualStyleBackColor = true;
            // 
            // btnClearFilters
            // 
            btnClearFilters.BackColor = Color.Transparent;
            btnClearFilters.Cursor = Cursors.Hand;
            btnClearFilters.FlatAppearance.BorderSize = 0;
            btnClearFilters.FlatStyle = FlatStyle.Flat;
            btnClearFilters.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClearFilters.ForeColor = Color.Gray;
            btnClearFilters.Location = new Point(779, 32);
            btnClearFilters.Name = "btnClearFilters";
            btnClearFilters.Size = new Size(77, 48);
            btnClearFilters.TabIndex = 16;
            btnClearFilters.Text = "Clear";
            btnClearFilters.UseVisualStyleBackColor = false;
            // 
            // btnApplyFilters
            // 
            btnApplyFilters.BackColor = Color.Thistle;
            btnApplyFilters.Cursor = Cursors.Hand;
            btnApplyFilters.FlatAppearance.BorderSize = 0;
            btnApplyFilters.FlatStyle = FlatStyle.Flat;
            btnApplyFilters.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApplyFilters.ForeColor = Color.FromArgb(74, 20, 140);
            btnApplyFilters.Location = new Point(610, 32);
            btnApplyFilters.Name = "btnApplyFilters";
            btnApplyFilters.Size = new Size(150, 46);
            btnApplyFilters.TabIndex = 15;
            btnApplyFilters.Text = "☰ Apply Filters";
            btnApplyFilters.UseVisualStyleBackColor = false;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Font = new Font("Segoe UI", 11F);
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Location = new Point(410, 40);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(170, 37);
            dtpEndDate.TabIndex = 5;
            // 
            // lblEndDateTitle
            // 
            lblEndDateTitle.AutoSize = true;
            lblEndDateTitle.BackColor = Color.Transparent;
            lblEndDateTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEndDateTitle.ForeColor = Color.Gray;
            lblEndDateTitle.Location = new Point(410, 9);
            lblEndDateTitle.Name = "lblEndDateTitle";
            lblEndDateTitle.Size = new Size(111, 28);
            lblEndDateTitle.TabIndex = 4;
            lblEndDateTitle.Text = "END DATE";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Font = new Font("Segoe UI", 11F);
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(220, 40);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(170, 37);
            dtpStartDate.TabIndex = 3;
            // 
            // lblStartDateTitle
            // 
            lblStartDateTitle.AutoSize = true;
            lblStartDateTitle.BackColor = Color.Transparent;
            lblStartDateTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStartDateTitle.ForeColor = Color.Gray;
            lblStartDateTitle.Location = new Point(220, 9);
            lblStartDateTitle.Name = "lblStartDateTitle";
            lblStartDateTitle.Size = new Size(130, 28);
            lblStartDateTitle.TabIndex = 2;
            lblStartDateTitle.Text = "START DATE";
            // 
            // cmbOrderStatus
            // 
            cmbOrderStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOrderStatus.Font = new Font("Segoe UI", 11F);
            cmbOrderStatus.FormattingEnabled = true;
            cmbOrderStatus.Location = new Point(10, 42);
            cmbOrderStatus.Name = "cmbOrderStatus";
            cmbOrderStatus.Size = new Size(170, 38);
            cmbOrderStatus.TabIndex = 1;
            // 
            // lblFilterStatusTitle
            // 
            lblFilterStatusTitle.AutoSize = true;
            lblFilterStatusTitle.BackColor = Color.Transparent;
            lblFilterStatusTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFilterStatusTitle.ForeColor = Color.Gray;
            lblFilterStatusTitle.Location = new Point(20, 9);
            lblFilterStatusTitle.Name = "lblFilterStatusTitle";
            lblFilterStatusTitle.Size = new Size(151, 28);
            lblFilterStatusTitle.TabIndex = 0;
            lblFilterStatusTitle.Text = "FILTER STATUS\n";
            // 
            // dgvMyOrders
            // 
            dgvMyOrders.AllowUserToAddRows = false;
            dgvMyOrders.AllowUserToDeleteRows = false;
            dgvMyOrders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dgvMyOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMyOrders.BackgroundColor = Color.White;
            dgvMyOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMyOrders.Location = new Point(20, 220);
            dgvMyOrders.MultiSelect = false;
            dgvMyOrders.Name = "dgvMyOrders";
            dgvMyOrders.ReadOnly = true;
            dgvMyOrders.RowHeadersVisible = false;
            dgvMyOrders.RowHeadersWidth = 62;
            dgvMyOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMyOrders.Size = new Size(820, 703);
            dgvMyOrders.TabIndex = 2;
            // 
            // pnlOrderDetails
            // 
            pnlOrderDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pnlOrderDetails.BackColor = Color.White;
            pnlOrderDetails.BorderStyle = BorderStyle.FixedSingle;
            pnlOrderDetails.Controls.Add(btnCancelOrder);
            pnlOrderDetails.Controls.Add(btnReorder);
            pnlOrderDetails.Controls.Add(lblTotalAmountValue);
            pnlOrderDetails.Controls.Add(lblTotalAmountTitle);
            pnlOrderDetails.Controls.Add(lblTaxValue);
            pnlOrderDetails.Controls.Add(lblTaxTitle);
            pnlOrderDetails.Controls.Add(lblShippingValue);
            pnlOrderDetails.Controls.Add(lblShippingTitle);
            pnlOrderDetails.Controls.Add(lblSubtotalValue);
            pnlOrderDetails.Controls.Add(lblSubtotalTitle);
            pnlOrderDetails.Controls.Add(flpOrderItems);
            pnlOrderDetails.Controls.Add(lblOrderItemsTitle);
            pnlOrderDetails.Controls.Add(lblStatusValue);
            pnlOrderDetails.Controls.Add(lblStatusTitle);
            pnlOrderDetails.Controls.Add(lblShippingAddressValue);
            pnlOrderDetails.Controls.Add(lblShippingAddressTitle);
            pnlOrderDetails.Controls.Add(lblCustomerInfoValue);
            pnlOrderDetails.Controls.Add(lblCustomerInfoTitle);
            pnlOrderDetails.Controls.Add(lblOrderIdValue);
            pnlOrderDetails.Controls.Add(lblOrderIdTitle);
            pnlOrderDetails.Controls.Add(btnOrderMail);
            pnlOrderDetails.Controls.Add(btnViewInvoice);
            pnlOrderDetails.Controls.Add(lblOrderDetailsTitle);
            pnlOrderDetails.Location = new Point(865, 220);
            pnlOrderDetails.Name = "pnlOrderDetails";
            pnlOrderDetails.Size = new Size(475, 817);
            pnlOrderDetails.TabIndex = 3;
            // 
            // btnReview
            // 
            btnReview.BackColor = Color.Coral;
            btnReview.FlatAppearance.BorderSize = 0;
            btnReview.FlatStyle = FlatStyle.Flat;
            btnReview.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReview.Location = new Point(20, 942);
            btnReview.Name = "btnReview";
            btnReview.Size = new Size(160, 34);
            btnReview.TabIndex = 38;
            btnReview.Text = "Give Review";
            btnReview.UseVisualStyleBackColor = false;
            // 
            // btnCancelOrder
            // 
            btnCancelOrder.BackColor = Color.White;
            btnCancelOrder.Cursor = Cursors.Hand;
            btnCancelOrder.FlatAppearance.BorderSize = 0;
            btnCancelOrder.FlatStyle = FlatStyle.Flat;
            btnCancelOrder.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelOrder.ForeColor = Color.FromArgb(74, 20, 140);
            btnCancelOrder.Location = new Point(275, 666);
            btnCancelOrder.Name = "btnCancelOrder";
            btnCancelOrder.Size = new Size(190, 52);
            btnCancelOrder.TabIndex = 37;
            btnCancelOrder.Text = "Cancel Order";
            btnCancelOrder.UseVisualStyleBackColor = false;
            // 
            // btnReorder
            // 
            btnReorder.BackColor = Color.FromArgb(74, 20, 140);
            btnReorder.Cursor = Cursors.Hand;
            btnReorder.FlatAppearance.BorderSize = 0;
            btnReorder.FlatStyle = FlatStyle.Flat;
            btnReorder.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReorder.ForeColor = Color.White;
            btnReorder.Location = new Point(3, 666);
            btnReorder.Name = "btnReorder";
            btnReorder.Size = new Size(190, 52);
            btnReorder.TabIndex = 15;
            btnReorder.Text = "Reorder";
            btnReorder.UseVisualStyleBackColor = false;
            // 
            // lblTotalAmountValue
            // 
            lblTotalAmountValue.AutoSize = true;
            lblTotalAmountValue.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalAmountValue.ForeColor = Color.Black;
            lblTotalAmountValue.Location = new Point(210, 603);
            lblTotalAmountValue.Name = "lblTotalAmountValue";
            lblTotalAmountValue.Size = new Size(0, 30);
            lblTotalAmountValue.TabIndex = 36;
            lblTotalAmountValue.Click += label1_Click;
            // 
            // lblTotalAmountTitle
            // 
            lblTotalAmountTitle.AutoSize = true;
            lblTotalAmountTitle.ForeColor = Color.Gray;
            lblTotalAmountTitle.Location = new Point(11, 608);
            lblTotalAmountTitle.Name = "lblTotalAmountTitle";
            lblTotalAmountTitle.Size = new Size(124, 25);
            lblTotalAmountTitle.TabIndex = 35;
            lblTotalAmountTitle.Text = " Total Amount";
            lblTotalAmountTitle.Click += label2_Click;
            // 
            // lblTaxValue
            // 
            lblTaxValue.AutoSize = true;
            lblTaxValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTaxValue.ForeColor = Color.Black;
            lblTaxValue.Location = new Point(330, 543);
            lblTaxValue.Name = "lblTaxValue";
            lblTaxValue.Size = new Size(0, 25);
            lblTaxValue.TabIndex = 34;
            // 
            // lblTaxTitle
            // 
            lblTaxTitle.AutoSize = true;
            lblTaxTitle.Font = new Font("Segoe UI", 9F);
            lblTaxTitle.ForeColor = Color.Gray;
            lblTaxTitle.Location = new Point(11, 558);
            lblTaxTitle.Name = "lblTaxTitle";
            lblTaxTitle.Size = new Size(36, 25);
            lblTaxTitle.TabIndex = 33;
            lblTaxTitle.Text = "Tax";
            // 
            // lblShippingValue
            // 
            lblShippingValue.AutoSize = true;
            lblShippingValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblShippingValue.ForeColor = Color.Black;
            lblShippingValue.Location = new Point(328, 514);
            lblShippingValue.Name = "lblShippingValue";
            lblShippingValue.Size = new Size(0, 25);
            lblShippingValue.TabIndex = 32;
            // 
            // lblShippingTitle
            // 
            lblShippingTitle.AutoSize = true;
            lblShippingTitle.Font = new Font("Segoe UI", 9F);
            lblShippingTitle.ForeColor = Color.Gray;
            lblShippingTitle.Location = new Point(11, 514);
            lblShippingTitle.Name = "lblShippingTitle";
            lblShippingTitle.Size = new Size(83, 25);
            lblShippingTitle.TabIndex = 31;
            lblShippingTitle.Text = "Shipping";
            // 
            // lblSubtotalValue
            // 
            lblSubtotalValue.AutoSize = true;
            lblSubtotalValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSubtotalValue.ForeColor = Color.Black;
            lblSubtotalValue.Location = new Point(328, 472);
            lblSubtotalValue.Name = "lblSubtotalValue";
            lblSubtotalValue.Size = new Size(0, 25);
            lblSubtotalValue.TabIndex = 30;
            // 
            // lblSubtotalTitle
            // 
            lblSubtotalTitle.AutoSize = true;
            lblSubtotalTitle.Font = new Font("Segoe UI", 9F);
            lblSubtotalTitle.ForeColor = Color.Gray;
            lblSubtotalTitle.Location = new Point(9, 472);
            lblSubtotalTitle.Name = "lblSubtotalTitle";
            lblSubtotalTitle.Size = new Size(79, 25);
            lblSubtotalTitle.TabIndex = 29;
            lblSubtotalTitle.Text = "Subtotal";
            // 
            // flpOrderItems
            // 
            flpOrderItems.AutoScroll = true;
            flpOrderItems.BackColor = Color.White;
            flpOrderItems.FlowDirection = FlowDirection.TopDown;
            flpOrderItems.Location = new Point(11, 306);
            flpOrderItems.Name = "flpOrderItems";
            flpOrderItems.Size = new Size(450, 145);
            flpOrderItems.TabIndex = 28;
            flpOrderItems.WrapContents = false;
            // 
            // lblOrderItemsTitle
            // 
            lblOrderItemsTitle.AutoSize = true;
            lblOrderItemsTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderItemsTitle.ForeColor = Color.Gray;
            lblOrderItemsTitle.Location = new Point(3, 252);
            lblOrderItemsTitle.Name = "lblOrderItemsTitle";
            lblOrderItemsTitle.Size = new Size(132, 25);
            lblOrderItemsTitle.TabIndex = 27;
            lblOrderItemsTitle.Text = "ORDER ITEMS";
            // 
            // lblStatusValue
            // 
            lblStatusValue.AutoSize = true;
            lblStatusValue.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblStatusValue.ForeColor = Color.Black;
            lblStatusValue.Location = new Point(309, 73);
            lblStatusValue.Name = "lblStatusValue";
            lblStatusValue.Size = new Size(74, 21);
            lblStatusValue.TabIndex = 26;
            lblStatusValue.Text = "Pending";
            // 
            // lblStatusTitle
            // 
            lblStatusTitle.AutoSize = true;
            lblStatusTitle.Font = new Font("Segoe UI", 7F);
            lblStatusTitle.ForeColor = Color.Gray;
            lblStatusTitle.Location = new Point(309, 53);
            lblStatusTitle.Name = "lblStatusTitle";
            lblStatusTitle.Size = new Size(54, 19);
            lblStatusTitle.TabIndex = 25;
            lblStatusTitle.Text = "STATUS";
            // 
            // lblShippingAddressValue
            // 
            lblShippingAddressValue.AutoSize = true;
            lblShippingAddressValue.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblShippingAddressValue.ForeColor = Color.Black;
            lblShippingAddressValue.Location = new Point(309, 122);
            lblShippingAddressValue.Name = "lblShippingAddressValue";
            lblShippingAddressValue.Size = new Size(104, 21);
            lblShippingAddressValue.TabIndex = 24;
            lblShippingAddressValue.Text = "Address text";
            // 
            // lblShippingAddressTitle
            // 
            lblShippingAddressTitle.AutoSize = true;
            lblShippingAddressTitle.Font = new Font("Segoe UI", 7F);
            lblShippingAddressTitle.ForeColor = Color.Gray;
            lblShippingAddressTitle.Location = new Point(309, 103);
            lblShippingAddressTitle.Name = "lblShippingAddressTitle";
            lblShippingAddressTitle.Size = new Size(132, 19);
            lblShippingAddressTitle.TabIndex = 23;
            lblShippingAddressTitle.Text = "SHIPPING ADDRESS";
            // 
            // lblCustomerInfoValue
            // 
            lblCustomerInfoValue.AutoSize = true;
            lblCustomerInfoValue.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblCustomerInfoValue.ForeColor = Color.Black;
            lblCustomerInfoValue.Location = new Point(3, 122);
            lblCustomerInfoValue.Name = "lblCustomerInfoValue";
            lblCustomerInfoValue.Size = new Size(229, 21);
            lblCustomerInfoValue.TabIndex = 22;
            lblCustomerInfoValue.Text = "Text = Name / Email / Phone";
            // 
            // lblCustomerInfoTitle
            // 
            lblCustomerInfoTitle.AutoSize = true;
            lblCustomerInfoTitle.Font = new Font("Segoe UI", 7F);
            lblCustomerInfoTitle.ForeColor = Color.Gray;
            lblCustomerInfoTitle.Location = new Point(3, 103);
            lblCustomerInfoTitle.Name = "lblCustomerInfoTitle";
            lblCustomerInfoTitle.Size = new Size(116, 19);
            lblCustomerInfoTitle.TabIndex = 21;
            lblCustomerInfoTitle.Text = "CUSTOMER INFO";
            // 
            // lblOrderIdValue
            // 
            lblOrderIdValue.AutoSize = true;
            lblOrderIdValue.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderIdValue.ForeColor = Color.Black;
            lblOrderIdValue.Location = new Point(4, 73);
            lblOrderIdValue.Name = "lblOrderIdValue";
            lblOrderIdValue.Size = new Size(206, 30);
            lblOrderIdValue.TabIndex = 20;
            lblOrderIdValue.Text = "Text = #ORD-0000";
            // 
            // lblOrderIdTitle
            // 
            lblOrderIdTitle.AutoSize = true;
            lblOrderIdTitle.ForeColor = Color.Gray;
            lblOrderIdTitle.Location = new Point(3, 48);
            lblOrderIdTitle.Name = "lblOrderIdTitle";
            lblOrderIdTitle.Size = new Size(93, 25);
            lblOrderIdTitle.TabIndex = 19;
            lblOrderIdTitle.Text = "ORDER ID";
            // 
            // btnOrderMail
            // 
            btnOrderMail.BackColor = Color.White;
            btnOrderMail.Cursor = Cursors.Hand;
            btnOrderMail.FlatAppearance.BorderSize = 0;
            btnOrderMail.FlatStyle = FlatStyle.Flat;
            btnOrderMail.Font = new Font("Segoe UI Emoji", 10F);
            btnOrderMail.ForeColor = Color.FromArgb(74, 20, 140);
            btnOrderMail.Location = new Point(410, 3);
            btnOrderMail.Name = "btnOrderMail";
            btnOrderMail.Size = new Size(51, 50);
            btnOrderMail.TabIndex = 18;
            btnOrderMail.Text = "✉︎";
            btnOrderMail.UseVisualStyleBackColor = false;
            // 
            // btnViewInvoice
            // 
            btnViewInvoice.BackColor = Color.Coral;
            btnViewInvoice.Cursor = Cursors.Hand;
            btnViewInvoice.FlatAppearance.BorderSize = 0;
            btnViewInvoice.FlatStyle = FlatStyle.Flat;
            btnViewInvoice.Font = new Font("Segoe UI Emoji", 10F);
            btnViewInvoice.ForeColor = Color.White;
            btnViewInvoice.Location = new Point(354, 0);
            btnViewInvoice.Name = "btnViewInvoice";
            btnViewInvoice.Size = new Size(50, 50);
            btnViewInvoice.TabIndex = 17;
            btnViewInvoice.Text = "\U0001f9fe";
            btnViewInvoice.UseVisualStyleBackColor = false;
            // 
            // lblOrderDetailsTitle
            // 
            lblOrderDetailsTitle.AutoSize = true;
            lblOrderDetailsTitle.BackColor = Color.Transparent;
            lblOrderDetailsTitle.Font = new Font("Segoe UI", 18F);
            lblOrderDetailsTitle.ForeColor = Color.FromArgb(74, 20, 140);
            lblOrderDetailsTitle.Location = new Point(3, 0);
            lblOrderDetailsTitle.Name = "lblOrderDetailsTitle";
            lblOrderDetailsTitle.Size = new Size(230, 48);
            lblOrderDetailsTitle.TabIndex = 0;
            lblOrderDetailsTitle.Text = "Order Details";
            // 
            // btnNextPage
            // 
            btnNextPage.Anchor = AnchorStyles.Bottom;
            btnNextPage.BackColor = Color.White;
            btnNextPage.FlatAppearance.BorderSize = 0;
            btnNextPage.FlatStyle = FlatStyle.Flat;
            btnNextPage.Location = new Point(800, 940);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(40, 36);
            btnNextPage.TabIndex = 42;
            btnNextPage.Text = ">";
            btnNextPage.UseVisualStyleBackColor = false;
            // 
            // btnPage3
            // 
            btnPage3.Anchor = AnchorStyles.Bottom;
            btnPage3.BackColor = Color.White;
            btnPage3.FlatAppearance.BorderSize = 0;
            btnPage3.FlatStyle = FlatStyle.Flat;
            btnPage3.Location = new Point(755, 940);
            btnPage3.Name = "btnPage3";
            btnPage3.Size = new Size(40, 36);
            btnPage3.TabIndex = 41;
            btnPage3.Text = "3";
            btnPage3.UseVisualStyleBackColor = false;
            // 
            // btnPage2
            // 
            btnPage2.Anchor = AnchorStyles.Bottom;
            btnPage2.BackColor = Color.White;
            btnPage2.FlatAppearance.BorderSize = 0;
            btnPage2.FlatStyle = FlatStyle.Flat;
            btnPage2.Location = new Point(710, 940);
            btnPage2.Name = "btnPage2";
            btnPage2.Size = new Size(40, 36);
            btnPage2.TabIndex = 40;
            btnPage2.Text = "2";
            btnPage2.UseVisualStyleBackColor = false;
            // 
            // btnPage1
            // 
            btnPage1.Anchor = AnchorStyles.Bottom;
            btnPage1.BackColor = Color.White;
            btnPage1.FlatAppearance.BorderSize = 0;
            btnPage1.FlatStyle = FlatStyle.Flat;
            btnPage1.Location = new Point(665, 940);
            btnPage1.Name = "btnPage1";
            btnPage1.Size = new Size(40, 36);
            btnPage1.TabIndex = 39;
            btnPage1.Text = "1";
            btnPage1.UseVisualStyleBackColor = false;
            // 
            // btnPrevPage
            // 
            btnPrevPage.Anchor = AnchorStyles.Bottom;
            btnPrevPage.BackColor = Color.White;
            btnPrevPage.FlatAppearance.BorderSize = 0;
            btnPrevPage.FlatStyle = FlatStyle.Flat;
            btnPrevPage.Location = new Point(620, 940);
            btnPrevPage.Name = "btnPrevPage";
            btnPrevPage.Size = new Size(40, 36);
            btnPrevPage.TabIndex = 38;
            btnPrevPage.Text = "<";
            btnPrevPage.UseVisualStyleBackColor = false;
            // 
            // MyOrdersForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Beige;
            ClientSize = new Size(1358, 1043);
            Controls.Add(btnReview);
            Controls.Add(btnNextPage);
            Controls.Add(pnlOrderDetails);
            Controls.Add(btnPage3);
            Controls.Add(dgvMyOrders);
            Controls.Add(btnPage2);
            Controls.Add(pnlOrderFilters);
            Controls.Add(btnPage1);
            Controls.Add(pnlTopHeader);
            Controls.Add(btnPrevPage);
            Name = "MyOrdersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyOrdersForm";
            WindowState = FormWindowState.Maximized;
            Load += MyOrdersForm_Load_1;
            pnlTopHeader.ResumeLayout(false);
            pnlTopHeader.PerformLayout();
            pnlOrderFilters.ResumeLayout(false);
            pnlOrderFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMyOrders).EndInit();
            pnlOrderDetails.ResumeLayout(false);
            pnlOrderDetails.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTopHeader;
        private LinkLabel lnkCompleted;
        private LinkLabel lnkShipped;
        private LinkLabel lnkPending;
        private LinkLabel lnkAllOrders;
        private Label lblFormTitle;
        private TextBox txtSearchOrders;
        private Button btnCart;
        private Button btnWishlist;
        private Panel pnlOrderFilters;
        private Label lblFilterStatusTitle;
        private DateTimePicker dtpStartDate;
        private Label lblStartDateTitle;
        private ComboBox cmbOrderStatus;
        private DateTimePicker dtpEndDate;
        private Label lblEndDateTitle;
        private Button btnClearFilters;
        private Button btnApplyFilters;
        private DataGridView dgvMyOrders;
        private Panel pnlOrderDetails;
        private Label lblOrderDetailsTitle;
        private Button btnOrderMail;
        private Button btnViewInvoice;
        private Label lblOrderIdValue;
        private Label lblOrderIdTitle;
        private Label lblShippingAddressValue;
        private Label lblShippingAddressTitle;
        private Label lblCustomerInfoValue;
        private Label lblCustomerInfoTitle;
        private FlowLayoutPanel flpOrderItems;
        private Label lblOrderItemsTitle;
        private Label lblStatusValue;
        private Label lblStatusTitle;
        private Label lblShippingValue;
        private Label lblShippingTitle;
        private Label lblSubtotalValue;
        private Label lblSubtotalTitle;
        private Label lblTaxValue;
        private Label lblTaxTitle;
        private Label lblTotalAmountValue;
        private Label lblTotalAmountTitle;
        private Button btnCancelOrder;
        private Button btnReorder;
        private Button btnNextPage;
        private Button btnPage3;
        private Button btnPage2;
        private Button btnPage1;
        private Button btnPrevPage;
        private Button btnGoBack;
        private Button btnReview;
    }
}