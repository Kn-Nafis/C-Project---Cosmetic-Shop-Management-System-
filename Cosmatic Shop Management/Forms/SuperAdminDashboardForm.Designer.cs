namespace Cosmatic_Shop_Management.Forms
{
    partial class SuperAdminDashboardForm
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
            btnLogout = new Button();
            btnManageUsers = new Button();
            pnlTopSellingShop = new Panel();
            btnViewShopDetails = new Button();
            progressMonthlyVolume = new ProgressBar();
            lblMonthlyVolume = new Label();
            lblMonthlyVolumeText = new Label();
            lblTopShopOwner = new Label();
            lblTopShopName = new Label();
            picTopShop = new PictureBox();
            lblTopSellingShopTitle = new Label();
            pnlRecentTransactions = new Panel();
            dgvRecentTransactions = new DataGridView();
            btnFilterTransactions = new Button();
            lblRecentTransactionsTitle = new Label();
            pnlCommissions = new Panel();
            lblCommissions = new Label();
            lblCommissionsText = new Label();
            lblCommissionsChange = new Label();
            lblCommissionsIcon = new Label();
            pnlGrossIncome = new Panel();
            lblGrossIncome = new Label();
            lblGrossIncomeText = new Label();
            lblGrossIncomeChange = new Label();
            lblGrossIncomeIcon = new Label();
            pnlProducts = new Panel();
            lblProducts = new Label();
            lblProductsText = new Label();
            lblProductsChange = new Label();
            lblProductsIcon = new Label();
            pnlActiveShops = new Panel();
            lblActiveShops = new Label();
            lblActiveShopsText = new Label();
            lblActiveShopsChange = new Label();
            lblActiveShopsIcon = new Label();
            pnlTotalUsers = new Panel();
            lblTotalUsers = new Label();
            lblTotalUsersText = new Label();
            lblTotalUsersChange = new Label();
            lblTotalUsersIcon = new Label();
            pnlAdminProfile = new Panel();
            picAdminProfile = new PictureBox();
            lblAdminName = new Label();
            lblAdminProfileText = new Label();
            lblPlatformSubtitle = new Label();
            lblPlatformTitle = new Label();
            pnlMain.SuspendLayout();
            pnlTopSellingShop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picTopShop).BeginInit();
            pnlRecentTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentTransactions).BeginInit();
            pnlCommissions.SuspendLayout();
            pnlGrossIncome.SuspendLayout();
            pnlProducts.SuspendLayout();
            pnlActiveShops.SuspendLayout();
            pnlTotalUsers.SuspendLayout();
            pnlAdminProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAdminProfile).BeginInit();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.Beige;
            pnlMain.Controls.Add(btnLogout);
            pnlMain.Controls.Add(btnManageUsers);
            pnlMain.Controls.Add(pnlTopSellingShop);
            pnlMain.Controls.Add(pnlRecentTransactions);
            pnlMain.Controls.Add(pnlCommissions);
            pnlMain.Controls.Add(pnlGrossIncome);
            pnlMain.Controls.Add(pnlProducts);
            pnlMain.Controls.Add(pnlActiveShops);
            pnlMain.Controls.Add(pnlTotalUsers);
            pnlMain.Controls.Add(pnlAdminProfile);
            pnlMain.Controls.Add(lblPlatformSubtitle);
            pnlMain.Controls.Add(lblPlatformTitle);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1160, 707);
            pnlMain.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogout.BackColor = Color.Firebrick;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(770, 25);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(127, 56);
            btnLogout.TabIndex = 11;
            btnLogout.Text = "⎋Logout";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnManageUsers
            // 
            btnManageUsers.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnManageUsers.BackColor = Color.Indigo;
            btnManageUsers.FlatAppearance.BorderSize = 0;
            btnManageUsers.FlatStyle = FlatStyle.Flat;
            btnManageUsers.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManageUsers.ForeColor = Color.White;
            btnManageUsers.Location = new Point(685, 584);
            btnManageUsers.Name = "btnManageUsers";
            btnManageUsers.Size = new Size(230, 45);
            btnManageUsers.TabIndex = 10;
            btnManageUsers.Text = "Manage Users";
            btnManageUsers.UseVisualStyleBackColor = false;
            // 
            // pnlTopSellingShop
            // 
            pnlTopSellingShop.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlTopSellingShop.BackColor = Color.White;
            pnlTopSellingShop.BorderStyle = BorderStyle.FixedSingle;
            pnlTopSellingShop.Controls.Add(btnViewShopDetails);
            pnlTopSellingShop.Controls.Add(progressMonthlyVolume);
            pnlTopSellingShop.Controls.Add(lblMonthlyVolume);
            pnlTopSellingShop.Controls.Add(lblMonthlyVolumeText);
            pnlTopSellingShop.Controls.Add(lblTopShopOwner);
            pnlTopSellingShop.Controls.Add(lblTopShopName);
            pnlTopSellingShop.Controls.Add(picTopShop);
            pnlTopSellingShop.Controls.Add(lblTopSellingShopTitle);
            pnlTopSellingShop.Location = new Point(650, 260);
            pnlTopSellingShop.Name = "pnlTopSellingShop";
            pnlTopSellingShop.Size = new Size(300, 294);
            pnlTopSellingShop.TabIndex = 9;
            // 
            // btnViewShopDetails
            // 
            btnViewShopDetails.BackColor = Color.FromArgb(59, 0, 102);
            btnViewShopDetails.FlatAppearance.BorderSize = 0;
            btnViewShopDetails.FlatStyle = FlatStyle.Flat;
            btnViewShopDetails.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewShopDetails.ForeColor = Color.White;
            btnViewShopDetails.Location = new Point(20, 241);
            btnViewShopDetails.Name = "btnViewShopDetails";
            btnViewShopDetails.Size = new Size(260, 32);
            btnViewShopDetails.TabIndex = 7;
            btnViewShopDetails.Text = "View Shop Details";
            btnViewShopDetails.UseVisualStyleBackColor = false;
            // 
            // progressMonthlyVolume
            // 
            progressMonthlyVolume.Location = new Point(20, 196);
            progressMonthlyVolume.Name = "progressMonthlyVolume";
            progressMonthlyVolume.Size = new Size(260, 12);
            progressMonthlyVolume.TabIndex = 6;
            // 
            // lblMonthlyVolume
            // 
            lblMonthlyVolume.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMonthlyVolume.ForeColor = Color.FromArgb(27, 11, 104);
            lblMonthlyVolume.Location = new Point(180, 159);
            lblMonthlyVolume.Name = "lblMonthlyVolume";
            lblMonthlyVolume.Size = new Size(100, 20);
            lblMonthlyVolume.TabIndex = 5;
            lblMonthlyVolume.Text = "0 Tk";
            lblMonthlyVolume.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblMonthlyVolumeText
            // 
            lblMonthlyVolumeText.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMonthlyVolumeText.ForeColor = Color.Gray;
            lblMonthlyVolumeText.Location = new Point(20, 160);
            lblMonthlyVolumeText.Name = "lblMonthlyVolumeText";
            lblMonthlyVolumeText.Size = new Size(164, 20);
            lblMonthlyVolumeText.TabIndex = 4;
            lblMonthlyVolumeText.Text = "MONTHLY VOLUME";
            // 
            // lblTopShopOwner
            // 
            lblTopShopOwner.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTopShopOwner.ForeColor = Color.Gray;
            lblTopShopOwner.Location = new Point(95, 85);
            lblTopShopOwner.Name = "lblTopShopOwner";
            lblTopShopOwner.Size = new Size(180, 25);
            lblTopShopOwner.TabIndex = 3;
            lblTopShopOwner.Text = "Managed by --";
            // 
            // lblTopShopName
            // 
            lblTopShopName.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTopShopName.ForeColor = Color.FromArgb(27, 11, 104);
            lblTopShopName.Location = new Point(95, 60);
            lblTopShopName.Name = "lblTopShopName";
            lblTopShopName.Size = new Size(180, 25);
            lblTopShopName.TabIndex = 2;
            lblTopShopName.Text = "--";
            // 
            // picTopShop
            // 
            picTopShop.BackColor = Color.FromArgb(248, 221, 232);
            picTopShop.Location = new Point(20, 60);
            picTopShop.Name = "picTopShop";
            picTopShop.Size = new Size(60, 60);
            picTopShop.SizeMode = PictureBoxSizeMode.StretchImage;
            picTopShop.TabIndex = 1;
            picTopShop.TabStop = false;
            // 
            // lblTopSellingShopTitle
            // 
            lblTopSellingShopTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTopSellingShopTitle.ForeColor = Color.FromArgb(27, 11, 104);
            lblTopSellingShopTitle.Location = new Point(20, 15);
            lblTopSellingShopTitle.Name = "lblTopSellingShopTitle";
            lblTopSellingShopTitle.Size = new Size(226, 39);
            lblTopSellingShopTitle.TabIndex = 0;
            lblTopSellingShopTitle.Text = "Top-Selling Shop";
            // 
            // pnlRecentTransactions
            // 
            pnlRecentTransactions.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlRecentTransactions.AutoSize = true;
            pnlRecentTransactions.BackColor = Color.White;
            pnlRecentTransactions.BorderStyle = BorderStyle.FixedSingle;
            pnlRecentTransactions.Controls.Add(dgvRecentTransactions);
            pnlRecentTransactions.Controls.Add(btnFilterTransactions);
            pnlRecentTransactions.Controls.Add(lblRecentTransactionsTitle);
            pnlRecentTransactions.Location = new Point(30, 260);
            pnlRecentTransactions.Name = "pnlRecentTransactions";
            pnlRecentTransactions.Size = new Size(602, 439);
            pnlRecentTransactions.TabIndex = 8;
            // 
            // dgvRecentTransactions
            // 
            dgvRecentTransactions.AllowUserToAddRows = false;
            dgvRecentTransactions.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvRecentTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecentTransactions.BackgroundColor = Color.White;
            dgvRecentTransactions.BorderStyle = BorderStyle.None;
            dgvRecentTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentTransactions.EnableHeadersVisualStyles = false;
            dgvRecentTransactions.Location = new Point(-1, 85);
            dgvRecentTransactions.Name = "dgvRecentTransactions";
            dgvRecentTransactions.ReadOnly = true;
            dgvRecentTransactions.RowHeadersVisible = false;
            dgvRecentTransactions.RowHeadersWidth = 62;
            dgvRecentTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecentTransactions.Size = new Size(598, 349);
            dgvRecentTransactions.TabIndex = 2;
            // 
            // btnFilterTransactions
            // 
            btnFilterTransactions.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFilterTransactions.BackColor = Color.FromArgb(232, 199, 240);
            btnFilterTransactions.FlatAppearance.BorderSize = 0;
            btnFilterTransactions.FlatStyle = FlatStyle.Flat;
            btnFilterTransactions.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFilterTransactions.ForeColor = Color.FromArgb(27, 11, 104);
            btnFilterTransactions.Location = new Point(510, 15);
            btnFilterTransactions.Name = "btnFilterTransactions";
            btnFilterTransactions.Size = new Size(70, 30);
            btnFilterTransactions.TabIndex = 1;
            btnFilterTransactions.Text = "Filter";
            btnFilterTransactions.UseVisualStyleBackColor = false;
            // 
            // lblRecentTransactionsTitle
            // 
            lblRecentTransactionsTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecentTransactionsTitle.ForeColor = Color.FromArgb(27, 11, 104);
            lblRecentTransactionsTitle.Location = new Point(3, 8);
            lblRecentTransactionsTitle.Name = "lblRecentTransactionsTitle";
            lblRecentTransactionsTitle.Size = new Size(257, 46);
            lblRecentTransactionsTitle.TabIndex = 0;
            lblRecentTransactionsTitle.Text = "Recent Transactions";
            // 
            // pnlCommissions
            // 
            pnlCommissions.BackColor = Color.White;
            pnlCommissions.BorderStyle = BorderStyle.FixedSingle;
            pnlCommissions.Controls.Add(lblCommissions);
            pnlCommissions.Controls.Add(lblCommissionsText);
            pnlCommissions.Controls.Add(lblCommissionsChange);
            pnlCommissions.Controls.Add(lblCommissionsIcon);
            pnlCommissions.Location = new Point(790, 115);
            pnlCommissions.Name = "pnlCommissions";
            pnlCommissions.Size = new Size(170, 138);
            pnlCommissions.TabIndex = 7;
            // 
            // lblCommissions
            // 
            lblCommissions.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCommissions.ForeColor = Color.FromArgb(27, 11, 104);
            lblCommissions.Location = new Point(20, 90);
            lblCommissions.Name = "lblCommissions";
            lblCommissions.Size = new Size(140, 46);
            lblCommissions.TabIndex = 3;
            lblCommissions.Text = "0 Tk";
            // 
            // lblCommissionsText
            // 
            lblCommissionsText.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCommissionsText.ForeColor = Color.Gray;
            lblCommissionsText.Location = new Point(20, 71);
            lblCommissionsText.Name = "lblCommissionsText";
            lblCommissionsText.Size = new Size(130, 18);
            lblCommissionsText.TabIndex = 2;
            lblCommissionsText.Text = "COMMISSIONS";
            lblCommissionsText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCommissionsChange
            // 
            lblCommissionsChange.BackColor = Color.FromArgb(217, 251, 231);
            lblCommissionsChange.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCommissionsChange.ForeColor = Color.Green;
            lblCommissionsChange.Location = new Point(110, 22);
            lblCommissionsChange.Name = "lblCommissionsChange";
            lblCommissionsChange.Size = new Size(50, 20);
            lblCommissionsChange.TabIndex = 1;
            lblCommissionsChange.Text = "--";
            lblCommissionsChange.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCommissionsIcon
            // 
            lblCommissionsIcon.BackColor = Color.FromArgb(248, 221, 232);
            lblCommissionsIcon.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCommissionsIcon.Location = new Point(20, 18);
            lblCommissionsIcon.Name = "lblCommissionsIcon";
            lblCommissionsIcon.Size = new Size(40, 40);
            lblCommissionsIcon.TabIndex = 0;
            lblCommissionsIcon.Text = "💳";
            lblCommissionsIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlGrossIncome
            // 
            pnlGrossIncome.BackColor = Color.White;
            pnlGrossIncome.BorderStyle = BorderStyle.FixedSingle;
            pnlGrossIncome.Controls.Add(lblGrossIncome);
            pnlGrossIncome.Controls.Add(lblGrossIncomeText);
            pnlGrossIncome.Controls.Add(lblGrossIncomeChange);
            pnlGrossIncome.Controls.Add(lblGrossIncomeIcon);
            pnlGrossIncome.Location = new Point(600, 115);
            pnlGrossIncome.Name = "pnlGrossIncome";
            pnlGrossIncome.Size = new Size(170, 139);
            pnlGrossIncome.TabIndex = 6;
            // 
            // lblGrossIncome
            // 
            lblGrossIncome.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGrossIncome.ForeColor = Color.FromArgb(27, 11, 104);
            lblGrossIncome.Location = new Point(20, 90);
            lblGrossIncome.Name = "lblGrossIncome";
            lblGrossIncome.Size = new Size(140, 47);
            lblGrossIncome.TabIndex = 3;
            lblGrossIncome.Text = "0 Tk";
            // 
            // lblGrossIncomeText
            // 
            lblGrossIncomeText.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGrossIncomeText.ForeColor = Color.Gray;
            lblGrossIncomeText.Location = new Point(20, 71);
            lblGrossIncomeText.Name = "lblGrossIncomeText";
            lblGrossIncomeText.Size = new Size(130, 18);
            lblGrossIncomeText.TabIndex = 2;
            lblGrossIncomeText.Text = "GROSS INCOME";
            // 
            // lblGrossIncomeChange
            // 
            lblGrossIncomeChange.BackColor = Color.FromArgb(217, 251, 231);
            lblGrossIncomeChange.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGrossIncomeChange.ForeColor = Color.Green;
            lblGrossIncomeChange.Location = new Point(110, 22);
            lblGrossIncomeChange.Name = "lblGrossIncomeChange";
            lblGrossIncomeChange.Size = new Size(50, 20);
            lblGrossIncomeChange.TabIndex = 1;
            lblGrossIncomeChange.Text = "--";
            lblGrossIncomeChange.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrossIncomeIcon
            // 
            lblGrossIncomeIcon.BackColor = Color.FromArgb(248, 221, 232);
            lblGrossIncomeIcon.Location = new Point(20, 18);
            lblGrossIncomeIcon.Name = "lblGrossIncomeIcon";
            lblGrossIncomeIcon.Size = new Size(40, 40);
            lblGrossIncomeIcon.TabIndex = 0;
            lblGrossIncomeIcon.Text = "💵";
            lblGrossIncomeIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlProducts
            // 
            pnlProducts.BackColor = Color.White;
            pnlProducts.BorderStyle = BorderStyle.FixedSingle;
            pnlProducts.Controls.Add(lblProducts);
            pnlProducts.Controls.Add(lblProductsText);
            pnlProducts.Controls.Add(lblProductsChange);
            pnlProducts.Controls.Add(lblProductsIcon);
            pnlProducts.Location = new Point(410, 115);
            pnlProducts.Name = "pnlProducts";
            pnlProducts.Size = new Size(170, 139);
            pnlProducts.TabIndex = 5;
            // 
            // lblProducts
            // 
            lblProducts.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProducts.ForeColor = Color.FromArgb(27, 11, 104);
            lblProducts.Location = new Point(20, 90);
            lblProducts.Name = "lblProducts";
            lblProducts.Size = new Size(130, 47);
            lblProducts.TabIndex = 3;
            lblProducts.Text = "0";
            // 
            // lblProductsText
            // 
            lblProductsText.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductsText.ForeColor = Color.Gray;
            lblProductsText.Location = new Point(20, 71);
            lblProductsText.Name = "lblProductsText";
            lblProductsText.Size = new Size(130, 18);
            lblProductsText.TabIndex = 2;
            lblProductsText.Text = "PRODUCTS";
            // 
            // lblProductsChange
            // 
            lblProductsChange.BackColor = Color.FromArgb(217, 251, 231);
            lblProductsChange.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductsChange.ForeColor = Color.Green;
            lblProductsChange.Location = new Point(110, 22);
            lblProductsChange.Name = "lblProductsChange";
            lblProductsChange.Size = new Size(50, 20);
            lblProductsChange.TabIndex = 1;
            lblProductsChange.Text = "--";
            lblProductsChange.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblProductsIcon
            // 
            lblProductsIcon.BackColor = Color.FromArgb(248, 221, 232);
            lblProductsIcon.Location = new Point(20, 18);
            lblProductsIcon.Name = "lblProductsIcon";
            lblProductsIcon.Size = new Size(40, 40);
            lblProductsIcon.TabIndex = 0;
            lblProductsIcon.Text = "📦";
            lblProductsIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlActiveShops
            // 
            pnlActiveShops.BackColor = Color.White;
            pnlActiveShops.BorderStyle = BorderStyle.FixedSingle;
            pnlActiveShops.Controls.Add(lblActiveShops);
            pnlActiveShops.Controls.Add(lblActiveShopsText);
            pnlActiveShops.Controls.Add(lblActiveShopsChange);
            pnlActiveShops.Controls.Add(lblActiveShopsIcon);
            pnlActiveShops.Location = new Point(220, 115);
            pnlActiveShops.Name = "pnlActiveShops";
            pnlActiveShops.Size = new Size(170, 139);
            pnlActiveShops.TabIndex = 4;
            // 
            // lblActiveShops
            // 
            lblActiveShops.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblActiveShops.ForeColor = Color.FromArgb(27, 11, 104);
            lblActiveShops.Location = new Point(20, 90);
            lblActiveShops.Name = "lblActiveShops";
            lblActiveShops.Size = new Size(130, 34);
            lblActiveShops.TabIndex = 3;
            lblActiveShops.Text = "0";
            // 
            // lblActiveShopsText
            // 
            lblActiveShopsText.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblActiveShopsText.ForeColor = Color.Gray;
            lblActiveShopsText.Location = new Point(20, 71);
            lblActiveShopsText.Name = "lblActiveShopsText";
            lblActiveShopsText.Size = new Size(130, 18);
            lblActiveShopsText.TabIndex = 2;
            lblActiveShopsText.Text = "ACTIVE SHOPS";
            // 
            // lblActiveShopsChange
            // 
            lblActiveShopsChange.BackColor = Color.FromArgb(217, 251, 231);
            lblActiveShopsChange.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblActiveShopsChange.ForeColor = Color.Green;
            lblActiveShopsChange.Location = new Point(110, 22);
            lblActiveShopsChange.Name = "lblActiveShopsChange";
            lblActiveShopsChange.Size = new Size(50, 20);
            lblActiveShopsChange.TabIndex = 1;
            lblActiveShopsChange.Text = "--";
            lblActiveShopsChange.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblActiveShopsIcon
            // 
            lblActiveShopsIcon.AutoSize = true;
            lblActiveShopsIcon.BackColor = Color.FromArgb(248, 221, 232);
            lblActiveShopsIcon.Location = new Point(20, 18);
            lblActiveShopsIcon.Name = "lblActiveShopsIcon";
            lblActiveShopsIcon.Size = new Size(37, 25);
            lblActiveShopsIcon.TabIndex = 0;
            lblActiveShopsIcon.Text = "🏬";
            lblActiveShopsIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlTotalUsers
            // 
            pnlTotalUsers.BackColor = Color.White;
            pnlTotalUsers.BorderStyle = BorderStyle.FixedSingle;
            pnlTotalUsers.Controls.Add(lblTotalUsers);
            pnlTotalUsers.Controls.Add(lblTotalUsersText);
            pnlTotalUsers.Controls.Add(lblTotalUsersChange);
            pnlTotalUsers.Controls.Add(lblTotalUsersIcon);
            pnlTotalUsers.Location = new Point(30, 115);
            pnlTotalUsers.Name = "pnlTotalUsers";
            pnlTotalUsers.Size = new Size(170, 139);
            pnlTotalUsers.TabIndex = 3;
            // 
            // lblTotalUsers
            // 
            lblTotalUsers.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalUsers.ForeColor = Color.FromArgb(27, 11, 104);
            lblTotalUsers.Location = new Point(20, 90);
            lblTotalUsers.Name = "lblTotalUsers";
            lblTotalUsers.Size = new Size(130, 47);
            lblTotalUsers.TabIndex = 3;
            lblTotalUsers.Text = "0";
            // 
            // lblTotalUsersText
            // 
            lblTotalUsersText.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalUsersText.ForeColor = Color.Gray;
            lblTotalUsersText.Location = new Point(20, 72);
            lblTotalUsersText.Name = "lblTotalUsersText";
            lblTotalUsersText.Size = new Size(130, 18);
            lblTotalUsersText.TabIndex = 2;
            lblTotalUsersText.Text = "TOTAL USERS";
            // 
            // lblTotalUsersChange
            // 
            lblTotalUsersChange.BackColor = Color.FromArgb(217, 251, 231);
            lblTotalUsersChange.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalUsersChange.ForeColor = Color.Green;
            lblTotalUsersChange.Location = new Point(110, 22);
            lblTotalUsersChange.Name = "lblTotalUsersChange";
            lblTotalUsersChange.Size = new Size(50, 20);
            lblTotalUsersChange.TabIndex = 1;
            lblTotalUsersChange.Text = "--";
            lblTotalUsersChange.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalUsersIcon
            // 
            lblTotalUsersIcon.BackColor = Color.FromArgb(248, 221, 232);
            lblTotalUsersIcon.Font = new Font("Segoe UI Emoji", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalUsersIcon.Location = new Point(20, 18);
            lblTotalUsersIcon.Name = "lblTotalUsersIcon";
            lblTotalUsersIcon.Size = new Size(40, 40);
            lblTotalUsersIcon.TabIndex = 0;
            lblTotalUsersIcon.Text = "👤";
            lblTotalUsersIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlAdminProfile
            // 
            pnlAdminProfile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlAdminProfile.AutoScroll = true;
            pnlAdminProfile.BackColor = Color.White;
            pnlAdminProfile.BorderStyle = BorderStyle.FixedSingle;
            pnlAdminProfile.Controls.Add(picAdminProfile);
            pnlAdminProfile.Controls.Add(lblAdminName);
            pnlAdminProfile.Controls.Add(lblAdminProfileText);
            pnlAdminProfile.Location = new Point(900, 25);
            pnlAdminProfile.Name = "pnlAdminProfile";
            pnlAdminProfile.Size = new Size(200, 60);
            pnlAdminProfile.TabIndex = 2;
            // 
            // picAdminProfile
            // 
            picAdminProfile.BackColor = Color.FromArgb(27, 11, 104);
            picAdminProfile.Location = new Point(150, 10);
            picAdminProfile.Name = "picAdminProfile";
            picAdminProfile.Size = new Size(38, 38);
            picAdminProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            picAdminProfile.TabIndex = 2;
            picAdminProfile.TabStop = false;
            // 
            // lblAdminName
            // 
            lblAdminName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdminName.ForeColor = Color.FromArgb(27, 11, 104);
            lblAdminName.Location = new Point(10, 26);
            lblAdminName.Name = "lblAdminName";
            lblAdminName.Size = new Size(120, 22);
            lblAdminName.TabIndex = 1;
            lblAdminName.Text = "--";
            // 
            // lblAdminProfileText
            // 
            lblAdminProfileText.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdminProfileText.ForeColor = Color.Gray;
            lblAdminProfileText.Location = new Point(10, 8);
            lblAdminProfileText.Name = "lblAdminProfileText";
            lblAdminProfileText.Size = new Size(120, 18);
            lblAdminProfileText.TabIndex = 0;
            lblAdminProfileText.Text = "ADMIN PROFILE";
            // 
            // lblPlatformSubtitle
            // 
            lblPlatformSubtitle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPlatformSubtitle.ForeColor = Color.FromArgb(51, 51, 51);
            lblPlatformSubtitle.Location = new Point(30, 77);
            lblPlatformSubtitle.Name = "lblPlatformSubtitle";
            lblPlatformSubtitle.Size = new Size(420, 25);
            lblPlatformSubtitle.TabIndex = 1;
            lblPlatformSubtitle.Text = "Real-time metrics for cosmetic marketplace ecosystem";
            // 
            // lblPlatformTitle
            // 
            lblPlatformTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlatformTitle.ForeColor = Color.FromArgb(27, 11, 104);
            lblPlatformTitle.Location = new Point(30, 25);
            lblPlatformTitle.Name = "lblPlatformTitle";
            lblPlatformTitle.Size = new Size(350, 52);
            lblPlatformTitle.TabIndex = 0;
            lblPlatformTitle.Text = "Platform Overview";
            // 
            // SuperAdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1160, 707);
            Controls.Add(pnlMain);
            Name = "SuperAdminDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SuperAdminDashboardForm";
            WindowState = FormWindowState.Maximized;
            Load += SuperAdminDashboardForm_Load;
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            pnlTopSellingShop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picTopShop).EndInit();
            pnlRecentTransactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRecentTransactions).EndInit();
            pnlCommissions.ResumeLayout(false);
            pnlGrossIncome.ResumeLayout(false);
            pnlProducts.ResumeLayout(false);
            pnlActiveShops.ResumeLayout(false);
            pnlActiveShops.PerformLayout();
            pnlTotalUsers.ResumeLayout(false);
            pnlAdminProfile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picAdminProfile).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private Button btnLogout;
        private Button btnManageUsers;
        private Panel pnlTopSellingShop;
        private Button btnViewShopDetails;
        private ProgressBar progressMonthlyVolume;
        private Label lblMonthlyVolume;
        private Label lblMonthlyVolumeText;
        private Label lblTopShopOwner;
        private Label lblTopShopName;
        private PictureBox picTopShop;
        private Label lblTopSellingShopTitle;
        private Panel pnlRecentTransactions;
        private DataGridView dgvRecentTransactions;
        private Button btnFilterTransactions;
        private Label lblRecentTransactionsTitle;
        private Panel pnlCommissions;
        private Label lblCommissions;
        private Label lblCommissionsText;
        private Label lblCommissionsChange;
        private Label lblCommissionsIcon;
        private Panel pnlGrossIncome;
        private Label lblGrossIncome;
        private Label lblGrossIncomeText;
        private Label lblGrossIncomeChange;
        private Label lblGrossIncomeIcon;
        private Panel pnlProducts;
        private Label lblProducts;
        private Label lblProductsText;
        private Label lblProductsChange;
        private Label lblProductsIcon;
        private Panel pnlActiveShops;
        private Label lblActiveShops;
        private Label lblActiveShopsText;
        private Label lblActiveShopsChange;
        private Label lblActiveShopsIcon;
        private Panel pnlTotalUsers;
        private Label lblTotalUsers;
        private Label lblTotalUsersText;
        private Label lblTotalUsersChange;
        private Label lblTotalUsersIcon;
        private Panel pnlAdminProfile;
        private PictureBox picAdminProfile;
        private Label lblAdminName;
        private Label lblAdminProfileText;
        private Label lblPlatformSubtitle;
        private Label lblPlatformTitle;
    }
}