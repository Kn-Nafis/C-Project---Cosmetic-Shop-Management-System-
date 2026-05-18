namespace Cosmatic_Shop_Management.Forms
{
    partial class SuperviseShopsForm
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
            pnlMain = new Panel();
            pnlActions = new Panel();
            btnViewOrders = new Button();
            btnViewProducts = new Button();
            btnDeactivateShop = new Button();
            btnActivateShop = new Button();
            pnlShopDetails = new Panel();
            lblCreatedAt = new Label();
            lblStatus = new Label();
            lblCreatedAtText = new Label();
            lblStatusText = new Label();
            lblAddress = new Label();
            lblEmail = new Label();
            lblPhone = new Label();
            lblOwnerName = new Label();
            lblShopName = new Label();
            lblAddressText = new Label();
            lblEmailText = new Label();
            lblPhoneText = new Label();
            lblOwnerNameText = new Label();
            lblShopNameText = new Label();
            lblShopLogoPlaceholder = new Label();
            picShopLogo = new PictureBox();
            lblShopDetailsTitle = new Label();
            pnlShopList = new Panel();
            dgvShops = new DataGridView();
            lblShopListTitle = new Label();
            pnlFilter = new Panel();
            btnApplyFilters = new Button();
            cmbOwnerFilter = new ComboBox();
            lblOwnerFilter = new Label();
            cmbStatusFilter = new ComboBox();
            lblStatusFilter = new Label();
            btnBack = new Button();
            btnRefresh = new Button();
            txtSearchShop = new TextBox();
            lblSubtitle = new Label();
            lblTitle = new Label();
            pnlMain.SuspendLayout();
            pnlActions.SuspendLayout();
            pnlShopDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picShopLogo).BeginInit();
            pnlShopList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvShops).BeginInit();
            pnlFilter.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.Beige;
            pnlMain.Controls.Add(pnlActions);
            pnlMain.Controls.Add(pnlShopDetails);
            pnlMain.Controls.Add(pnlShopList);
            pnlMain.Controls.Add(pnlFilter);
            pnlMain.Controls.Add(btnBack);
            pnlMain.Controls.Add(btnRefresh);
            pnlMain.Controls.Add(txtSearchShop);
            pnlMain.Controls.Add(lblSubtitle);
            pnlMain.Controls.Add(lblTitle);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Padding = new Padding(25);
            pnlMain.Size = new Size(1307, 802);
            pnlMain.TabIndex = 1;
            // 
            // pnlActions
            // 
            pnlActions.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlActions.BackColor = Color.White;
            pnlActions.BorderStyle = BorderStyle.FixedSingle;
            pnlActions.Controls.Add(btnViewOrders);
            pnlActions.Controls.Add(btnViewProducts);
            pnlActions.Controls.Add(btnDeactivateShop);
            pnlActions.Controls.Add(btnActivateShop);
            pnlActions.Location = new Point(30, 650);
            pnlActions.Name = "pnlActions";
            pnlActions.Size = new Size(1120, 95);
            pnlActions.TabIndex = 8;
            // 
            // btnViewOrders
            // 
            btnViewOrders.BackColor = Color.FromArgb(126, 87, 194);
            btnViewOrders.FlatAppearance.BorderSize = 0;
            btnViewOrders.FlatStyle = FlatStyle.Flat;
            btnViewOrders.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewOrders.ForeColor = Color.White;
            btnViewOrders.Location = new Point(835, 17);
            btnViewOrders.Name = "btnViewOrders";
            btnViewOrders.Size = new Size(220, 51);
            btnViewOrders.TabIndex = 3;
            btnViewOrders.Text = "\U0001f6d2 View Orders";
            btnViewOrders.UseVisualStyleBackColor = false;
            btnViewOrders.Visible = false;
            // 
            // btnViewProducts
            // 
            btnViewProducts.BackColor = Color.FromArgb(14, 165, 233);
            btnViewProducts.FlatAppearance.BorderSize = 0;
            btnViewProducts.FlatStyle = FlatStyle.Flat;
            btnViewProducts.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewProducts.ForeColor = Color.White;
            btnViewProducts.Location = new Point(590, 17);
            btnViewProducts.Name = "btnViewProducts";
            btnViewProducts.Size = new Size(220, 51);
            btnViewProducts.TabIndex = 2;
            btnViewProducts.Text = "□ View Products";
            btnViewProducts.UseVisualStyleBackColor = false;
            btnViewProducts.Visible = false;
            // 
            // btnDeactivateShop
            // 
            btnDeactivateShop.BackColor = Color.FromArgb(220, 38, 38);
            btnDeactivateShop.FlatAppearance.BorderSize = 0;
            btnDeactivateShop.FlatStyle = FlatStyle.Flat;
            btnDeactivateShop.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeactivateShop.ForeColor = Color.White;
            btnDeactivateShop.Location = new Point(325, 17);
            btnDeactivateShop.Name = "btnDeactivateShop";
            btnDeactivateShop.Size = new Size(240, 51);
            btnDeactivateShop.TabIndex = 1;
            btnDeactivateShop.Text = "⏸ Deactivate Shop";
            btnDeactivateShop.UseVisualStyleBackColor = false;
            // 
            // btnActivateShop
            // 
            btnActivateShop.BackColor = Color.FromArgb(34, 197, 94);
            btnActivateShop.FlatAppearance.BorderSize = 0;
            btnActivateShop.FlatStyle = FlatStyle.Flat;
            btnActivateShop.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActivateShop.ForeColor = Color.White;
            btnActivateShop.Location = new Point(80, 17);
            btnActivateShop.Name = "btnActivateShop";
            btnActivateShop.Size = new Size(220, 51);
            btnActivateShop.TabIndex = 0;
            btnActivateShop.Text = "✓ Activate Shop";
            btnActivateShop.UseVisualStyleBackColor = false;
            // 
            // pnlShopDetails
            // 
            pnlShopDetails.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlShopDetails.BackColor = Color.White;
            pnlShopDetails.BorderStyle = BorderStyle.FixedSingle;
            pnlShopDetails.Controls.Add(lblCreatedAt);
            pnlShopDetails.Controls.Add(lblStatus);
            pnlShopDetails.Controls.Add(lblCreatedAtText);
            pnlShopDetails.Controls.Add(lblStatusText);
            pnlShopDetails.Controls.Add(lblAddress);
            pnlShopDetails.Controls.Add(lblEmail);
            pnlShopDetails.Controls.Add(lblPhone);
            pnlShopDetails.Controls.Add(lblOwnerName);
            pnlShopDetails.Controls.Add(lblShopName);
            pnlShopDetails.Controls.Add(lblAddressText);
            pnlShopDetails.Controls.Add(lblEmailText);
            pnlShopDetails.Controls.Add(lblPhoneText);
            pnlShopDetails.Controls.Add(lblOwnerNameText);
            pnlShopDetails.Controls.Add(lblShopNameText);
            pnlShopDetails.Controls.Add(lblShopLogoPlaceholder);
            pnlShopDetails.Controls.Add(picShopLogo);
            pnlShopDetails.Controls.Add(lblShopDetailsTitle);
            pnlShopDetails.Location = new Point(770, 200);
            pnlShopDetails.Name = "pnlShopDetails";
            pnlShopDetails.Size = new Size(380, 434);
            pnlShopDetails.TabIndex = 7;
            // 
            // lblCreatedAt
            // 
            lblCreatedAt.Location = new Point(146, 390);
            lblCreatedAt.Name = "lblCreatedAt";
            lblCreatedAt.Size = new Size(210, 22);
            lblCreatedAt.TabIndex = 16;
            lblCreatedAt.Text = "--";
            lblCreatedAt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            lblStatus.Location = new Point(146, 368);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(210, 22);
            lblStatus.TabIndex = 15;
            lblStatus.Text = "--";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCreatedAtText
            // 
            lblCreatedAtText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreatedAtText.ForeColor = Color.FromArgb(51, 51, 51);
            lblCreatedAtText.Location = new Point(30, 384);
            lblCreatedAtText.Name = "lblCreatedAtText";
            lblCreatedAtText.Size = new Size(110, 22);
            lblCreatedAtText.TabIndex = 14;
            lblCreatedAtText.Text = "Created At :";
            // 
            // lblStatusText
            // 
            lblStatusText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatusText.ForeColor = Color.FromArgb(51, 51, 51);
            lblStatusText.Location = new Point(30, 357);
            lblStatusText.Name = "lblStatusText";
            lblStatusText.Size = new Size(110, 22);
            lblStatusText.TabIndex = 13;
            lblStatusText.Text = "Status :";
            // 
            // lblAddress
            // 
            lblAddress.ForeColor = Color.Black;
            lblAddress.Location = new Point(145, 335);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(210, 22);
            lblAddress.TabIndex = 12;
            lblAddress.Text = "--";
            lblAddress.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            lblEmail.ForeColor = Color.Black;
            lblEmail.Location = new Point(145, 305);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(210, 22);
            lblEmail.TabIndex = 11;
            lblEmail.Text = "--";
            lblEmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPhone
            // 
            lblPhone.ForeColor = Color.Black;
            lblPhone.Location = new Point(145, 275);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(210, 22);
            lblPhone.TabIndex = 10;
            lblPhone.Text = "--";
            lblPhone.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOwnerName
            // 
            lblOwnerName.ForeColor = Color.Black;
            lblOwnerName.Location = new Point(145, 245);
            lblOwnerName.Name = "lblOwnerName";
            lblOwnerName.Size = new Size(210, 22);
            lblOwnerName.TabIndex = 9;
            lblOwnerName.Text = "--";
            lblOwnerName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblShopName
            // 
            lblShopName.ForeColor = Color.Black;
            lblShopName.Location = new Point(145, 215);
            lblShopName.Name = "lblShopName";
            lblShopName.Size = new Size(210, 22);
            lblShopName.TabIndex = 8;
            lblShopName.Text = "--";
            lblShopName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAddressText
            // 
            lblAddressText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddressText.ForeColor = Color.FromArgb(51, 51, 51);
            lblAddressText.Location = new Point(30, 327);
            lblAddressText.Name = "lblAddressText";
            lblAddressText.Size = new Size(110, 22);
            lblAddressText.TabIndex = 7;
            lblAddressText.Text = "Address :";
            // 
            // lblEmailText
            // 
            lblEmailText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmailText.ForeColor = Color.FromArgb(51, 51, 51);
            lblEmailText.Location = new Point(30, 305);
            lblEmailText.Name = "lblEmailText";
            lblEmailText.Size = new Size(110, 22);
            lblEmailText.TabIndex = 6;
            lblEmailText.Text = "Email :";
            // 
            // lblPhoneText
            // 
            lblPhoneText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhoneText.ForeColor = Color.FromArgb(51, 51, 51);
            lblPhoneText.Location = new Point(30, 275);
            lblPhoneText.Name = "lblPhoneText";
            lblPhoneText.Size = new Size(110, 22);
            lblPhoneText.TabIndex = 5;
            lblPhoneText.Text = "Phone :";
            // 
            // lblOwnerNameText
            // 
            lblOwnerNameText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOwnerNameText.ForeColor = Color.FromArgb(51, 51, 51);
            lblOwnerNameText.Location = new Point(30, 245);
            lblOwnerNameText.Name = "lblOwnerNameText";
            lblOwnerNameText.Size = new Size(139, 22);
            lblOwnerNameText.TabIndex = 4;
            lblOwnerNameText.Text = "Owner Name :";
            // 
            // lblShopNameText
            // 
            lblShopNameText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblShopNameText.ForeColor = Color.FromArgb(51, 51, 51);
            lblShopNameText.Location = new Point(30, 215);
            lblShopNameText.Name = "lblShopNameText";
            lblShopNameText.Size = new Size(129, 22);
            lblShopNameText.TabIndex = 3;
            lblShopNameText.Text = "Shop Name :";
            // 
            // lblShopLogoPlaceholder
            // 
            lblShopLogoPlaceholder.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblShopLogoPlaceholder.ForeColor = Color.Gray;
            lblShopLogoPlaceholder.Location = new Point(140, 97);
            lblShopLogoPlaceholder.Name = "lblShopLogoPlaceholder";
            lblShopLogoPlaceholder.Size = new Size(100, 20);
            lblShopLogoPlaceholder.TabIndex = 2;
            lblShopLogoPlaceholder.Text = "Shop Logo";
            lblShopLogoPlaceholder.Visible = false;
            // 
            // picShopLogo
            // 
            picShopLogo.BackColor = Color.FromArgb(248, 242, 250);
            picShopLogo.BorderStyle = BorderStyle.FixedSingle;
            picShopLogo.Location = new Point(115, 55);
            picShopLogo.Name = "picShopLogo";
            picShopLogo.Size = new Size(150, 120);
            picShopLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picShopLogo.TabIndex = 1;
            picShopLogo.TabStop = false;
            // 
            // lblShopDetailsTitle
            // 
            lblShopDetailsTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblShopDetailsTitle.ForeColor = Color.FromArgb(59, 0, 102);
            lblShopDetailsTitle.Location = new Point(20, 15);
            lblShopDetailsTitle.Name = "lblShopDetailsTitle";
            lblShopDetailsTitle.Size = new Size(180, 30);
            lblShopDetailsTitle.TabIndex = 0;
            lblShopDetailsTitle.Text = "SHOP DETAILS";
            // 
            // pnlShopList
            // 
            pnlShopList.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlShopList.BackColor = Color.White;
            pnlShopList.BorderStyle = BorderStyle.FixedSingle;
            pnlShopList.Controls.Add(dgvShops);
            pnlShopList.Controls.Add(lblShopListTitle);
            pnlShopList.Location = new Point(30, 200);
            pnlShopList.Name = "pnlShopList";
            pnlShopList.Size = new Size(720, 434);
            pnlShopList.TabIndex = 6;
            // 
            // dgvShops
            // 
            dgvShops.AllowUserToAddRows = false;
            dgvShops.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvShops.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvShops.BackgroundColor = Color.White;
            dgvShops.BorderStyle = BorderStyle.None;
            dgvShops.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShops.EnableHeadersVisualStyles = false;
            dgvShops.Location = new Point(20, 55);
            dgvShops.MultiSelect = false;
            dgvShops.Name = "dgvShops";
            dgvShops.ReadOnly = true;
            dgvShops.RowHeadersWidth = 62;
            dgvShops.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvShops.Size = new Size(680, 310);
            dgvShops.TabIndex = 1;
            // 
            // lblShopListTitle
            // 
            lblShopListTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblShopListTitle.ForeColor = Color.FromArgb(59, 0, 102);
            lblShopListTitle.Location = new Point(20, 15);
            lblShopListTitle.Name = "lblShopListTitle";
            lblShopListTitle.Size = new Size(150, 30);
            lblShopListTitle.TabIndex = 0;
            lblShopListTitle.Text = "SHOP LIST";
            // 
            // pnlFilter
            // 
            pnlFilter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlFilter.BackColor = Color.White;
            pnlFilter.BorderStyle = BorderStyle.FixedSingle;
            pnlFilter.Controls.Add(btnApplyFilters);
            pnlFilter.Controls.Add(cmbOwnerFilter);
            pnlFilter.Controls.Add(lblOwnerFilter);
            pnlFilter.Controls.Add(cmbStatusFilter);
            pnlFilter.Controls.Add(lblStatusFilter);
            pnlFilter.Location = new Point(30, 105);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Size = new Size(1120, 75);
            pnlFilter.TabIndex = 5;
            // 
            // btnApplyFilters
            // 
            btnApplyFilters.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnApplyFilters.BackColor = Color.Indigo;
            btnApplyFilters.FlatAppearance.BorderSize = 0;
            btnApplyFilters.FlatStyle = FlatStyle.Flat;
            btnApplyFilters.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApplyFilters.ForeColor = Color.White;
            btnApplyFilters.Location = new Point(880, 18);
            btnApplyFilters.Name = "btnApplyFilters";
            btnApplyFilters.Size = new Size(180, 52);
            btnApplyFilters.TabIndex = 4;
            btnApplyFilters.Text = "Apply Filters";
            btnApplyFilters.UseVisualStyleBackColor = false;
            // 
            // cmbOwnerFilter
            // 
            cmbOwnerFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOwnerFilter.FormattingEnabled = true;
            cmbOwnerFilter.Items.AddRange(new object[] { "All owners" });
            cmbOwnerFilter.Location = new Point(508, 22);
            cmbOwnerFilter.Name = "cmbOwnerFilter";
            cmbOwnerFilter.Size = new Size(237, 33);
            cmbOwnerFilter.TabIndex = 3;
            // 
            // lblOwnerFilter
            // 
            lblOwnerFilter.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOwnerFilter.ForeColor = Color.Black;
            lblOwnerFilter.Location = new Point(390, 25);
            lblOwnerFilter.Name = "lblOwnerFilter";
            lblOwnerFilter.Size = new Size(122, 25);
            lblOwnerFilter.TabIndex = 2;
            lblOwnerFilter.Text = "Owner Filter:";
            // 
            // cmbStatusFilter
            // 
            cmbStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatusFilter.FormattingEnabled = true;
            cmbStatusFilter.Items.AddRange(new object[] { "All", "Active", "Inactive", "Pending" });
            cmbStatusFilter.Location = new Point(139, 22);
            cmbStatusFilter.Name = "cmbStatusFilter";
            cmbStatusFilter.Size = new Size(210, 33);
            cmbStatusFilter.TabIndex = 1;
            // 
            // lblStatusFilter
            // 
            lblStatusFilter.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatusFilter.ForeColor = Color.Black;
            lblStatusFilter.Location = new Point(25, 25);
            lblStatusFilter.Name = "lblStatusFilter";
            lblStatusFilter.Size = new Size(122, 25);
            lblStatusFilter.TabIndex = 0;
            lblStatusFilter.Text = "Status Filter:";
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBack.BackColor = Color.FromArgb(248, 221, 232);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.Crimson;
            btnBack.Location = new Point(1070, 38);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(88, 48);
            btnBack.TabIndex = 4;
            btnBack.Text = "← Back";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.BackColor = Color.FromArgb(232, 199, 240);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.FromArgb(59, 0, 102);
            btnRefresh.Location = new Point(955, 38);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(112, 48);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "⟳ Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // txtSearchShop
            // 
            txtSearchShop.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchShop.Location = new Point(720, 40);
            txtSearchShop.Name = "txtSearchShop";
            txtSearchShop.PlaceholderText = "Search shop. . . ";
            txtSearchShop.Size = new Size(220, 34);
            txtSearchShop.TabIndex = 2;
            // 
            // lblSubtitle
            // 
            lblSubtitle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.FromArgb(51, 51, 51);
            lblSubtitle.Location = new Point(30, 76);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(450, 25);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Monitor all shops, owners, and activation status";
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(59, 0, 102);
            lblTitle.Location = new Point(30, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(350, 51);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Supervise Shops";
            // 
            // SuperviseShopsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1307, 802);
            Controls.Add(pnlMain);
            Name = "SuperviseShopsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SuperviseShopsForm";
            WindowState = FormWindowState.Maximized;
            Load += SuperviseShopsForm_Load;
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            pnlActions.ResumeLayout(false);
            pnlShopDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picShopLogo).EndInit();
            pnlShopList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvShops).EndInit();
            pnlFilter.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private Panel pnlActions;
        private Button btnViewOrders;
        private Button btnViewProducts;
        private Button btnDeactivateShop;
        private Button btnActivateShop;
        private Panel pnlShopDetails;
        private Label lblCreatedAt;
        private Label lblStatus;
        private Label lblCreatedAtText;
        private Label lblStatusText;
        private Label lblAddress;
        private Label lblEmail;
        private Label lblPhone;
        private Label lblOwnerName;
        private Label lblShopName;
        private Label lblAddressText;
        private Label lblEmailText;
        private Label lblPhoneText;
        private Label lblOwnerNameText;
        private Label lblShopNameText;
        private Label lblShopLogoPlaceholder;
        private PictureBox picShopLogo;
        private Label lblShopDetailsTitle;
        private Panel pnlShopList;
        private DataGridView dgvShops;
        private Label lblShopListTitle;
        private Panel pnlFilter;
        private Button btnApplyFilters;
        private ComboBox cmbOwnerFilter;
        private Label lblOwnerFilter;
        private ComboBox cmbStatusFilter;
        private Label lblStatusFilter;
        private Button btnBack;
        private Button btnRefresh;
        private TextBox txtSearchShop;
        private Label lblSubtitle;
        private Label lblTitle;
    }
}