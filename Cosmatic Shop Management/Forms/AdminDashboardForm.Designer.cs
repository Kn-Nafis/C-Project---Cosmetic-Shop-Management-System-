namespace Cosmatic_Shop_Management.Forms
{
    partial class AdminDashboardForm
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
            lblAdminName = new Label();
            pnlTotalProducts = new Panel();
            pnlTotalOrders = new Panel();
            pnlGrossSales = new Panel();
            pnlNetIncome = new Panel();
            lblTotalProductsTitle = new Label();
            lblTotalOrdersTitle = new Label();
            lblGrossSalesTitle = new Label();
            blNetIncomeTitle = new Label();
            lblTotalProducts = new Label();
            lblTotalOrders = new Label();
            lblGrossSales = new Label();
            lblNetIncome = new Label();
            pnlLowStock = new Panel();
            lblLowStock = new Label();
            lblLowStockTitle = new Label();
            dgvRecentOrders = new DataGridView();
            btnManageShop = new Button();
            btnManageProducts = new Button();
            btnOrders = new Button();
            btnReports = new Button();
            btnEmployees = new Button();
            btnLogout = new Button();
            lblRecentOrdersTitle = new Label();
            pnlTotalProducts.SuspendLayout();
            pnlTotalOrders.SuspendLayout();
            pnlGrossSales.SuspendLayout();
            pnlNetIncome.SuspendLayout();
            pnlLowStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentOrders).BeginInit();
            SuspendLayout();
            // 
            // lblAdminName
            // 
            lblAdminName.AutoSize = true;
            lblAdminName.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblAdminName.ForeColor = Color.FromArgb(74, 20, 140);
            lblAdminName.Location = new Point(18, 17);
            lblAdminName.Name = "lblAdminName";
            lblAdminName.Size = new Size(195, 48);
            lblAdminName.TabIndex = 0;
            lblAdminName.Text = "Welcome, ";
            // 
            // pnlTotalProducts
            // 
            pnlTotalProducts.BackColor = Color.White;
            pnlTotalProducts.BorderStyle = BorderStyle.FixedSingle;
            pnlTotalProducts.Controls.Add(lblTotalProducts);
            pnlTotalProducts.Controls.Add(lblTotalProductsTitle);
            pnlTotalProducts.Location = new Point(34, 108);
            pnlTotalProducts.Name = "pnlTotalProducts";
            pnlTotalProducts.Size = new Size(168, 168);
            pnlTotalProducts.TabIndex = 1;
            // 
            // pnlTotalOrders
            // 
            pnlTotalOrders.BackColor = Color.White;
            pnlTotalOrders.BorderStyle = BorderStyle.FixedSingle;
            pnlTotalOrders.Controls.Add(lblTotalOrders);
            pnlTotalOrders.Controls.Add(lblTotalOrdersTitle);
            pnlTotalOrders.Location = new Point(269, 108);
            pnlTotalOrders.Name = "pnlTotalOrders";
            pnlTotalOrders.Size = new Size(168, 168);
            pnlTotalOrders.TabIndex = 2;
            // 
            // pnlGrossSales
            // 
            pnlGrossSales.BackColor = Color.White;
            pnlGrossSales.BorderStyle = BorderStyle.FixedSingle;
            pnlGrossSales.Controls.Add(lblGrossSales);
            pnlGrossSales.Controls.Add(lblGrossSalesTitle);
            pnlGrossSales.Location = new Point(506, 108);
            pnlGrossSales.Name = "pnlGrossSales";
            pnlGrossSales.Size = new Size(168, 168);
            pnlGrossSales.TabIndex = 2;
            // 
            // pnlNetIncome
            // 
            pnlNetIncome.BackColor = Color.White;
            pnlNetIncome.BorderStyle = BorderStyle.FixedSingle;
            pnlNetIncome.Controls.Add(lblNetIncome);
            pnlNetIncome.Controls.Add(blNetIncomeTitle);
            pnlNetIncome.Location = new Point(739, 108);
            pnlNetIncome.Name = "pnlNetIncome";
            pnlNetIncome.Size = new Size(168, 168);
            pnlNetIncome.TabIndex = 2;
            // 
            // lblTotalProductsTitle
            // 
            lblTotalProductsTitle.AutoSize = true;
            lblTotalProductsTitle.Location = new Point(3, 29);
            lblTotalProductsTitle.Name = "lblTotalProductsTitle";
            lblTotalProductsTitle.Size = new Size(124, 25);
            lblTotalProductsTitle.TabIndex = 0;
            lblTotalProductsTitle.Text = "Total Products";
            // 
            // lblTotalOrdersTitle
            // 
            lblTotalOrdersTitle.AutoSize = true;
            lblTotalOrdersTitle.Location = new Point(3, 29);
            lblTotalOrdersTitle.Name = "lblTotalOrdersTitle";
            lblTotalOrdersTitle.Size = new Size(108, 25);
            lblTotalOrdersTitle.TabIndex = 1;
            lblTotalOrdersTitle.Text = "Total Orders";
            // 
            // lblGrossSalesTitle
            // 
            lblGrossSalesTitle.AutoSize = true;
            lblGrossSalesTitle.Location = new Point(3, 29);
            lblGrossSalesTitle.Name = "lblGrossSalesTitle";
            lblGrossSalesTitle.Size = new Size(102, 25);
            lblGrossSalesTitle.TabIndex = 2;
            lblGrossSalesTitle.Text = "Gross Sales";
            // 
            // blNetIncomeTitle
            // 
            blNetIncomeTitle.AutoSize = true;
            blNetIncomeTitle.Location = new Point(3, 29);
            blNetIncomeTitle.Name = "blNetIncomeTitle";
            blNetIncomeTitle.Size = new Size(104, 25);
            blNetIncomeTitle.TabIndex = 3;
            blNetIncomeTitle.Text = "Net Income";
            // 
            // lblTotalProducts
            // 
            lblTotalProducts.AutoSize = true;
            lblTotalProducts.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalProducts.ForeColor = Color.FromArgb(74, 20, 140);
            lblTotalProducts.Location = new Point(3, 72);
            lblTotalProducts.Name = "lblTotalProducts";
            lblTotalProducts.Size = new Size(101, 45);
            lblTotalProducts.TabIndex = 1;
            lblTotalProducts.Text = "Value";
            // 
            // lblTotalOrders
            // 
            lblTotalOrders.AutoSize = true;
            lblTotalOrders.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalOrders.ForeColor = Color.FromArgb(74, 20, 140);
            lblTotalOrders.Location = new Point(3, 83);
            lblTotalOrders.Name = "lblTotalOrders";
            lblTotalOrders.Size = new Size(101, 45);
            lblTotalOrders.TabIndex = 2;
            lblTotalOrders.Text = "Value";
            // 
            // lblGrossSales
            // 
            lblGrossSales.AutoSize = true;
            lblGrossSales.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGrossSales.ForeColor = Color.FromArgb(74, 20, 140);
            lblGrossSales.Location = new Point(4, 83);
            lblGrossSales.Name = "lblGrossSales";
            lblGrossSales.Size = new Size(101, 45);
            lblGrossSales.TabIndex = 3;
            lblGrossSales.Text = "Value";
            // 
            // lblNetIncome
            // 
            lblNetIncome.AutoSize = true;
            lblNetIncome.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNetIncome.ForeColor = Color.FromArgb(74, 20, 140);
            lblNetIncome.Location = new Point(6, 83);
            lblNetIncome.Name = "lblNetIncome";
            lblNetIncome.Size = new Size(101, 45);
            lblNetIncome.TabIndex = 3;
            lblNetIncome.Text = "Value";
            // 
            // pnlLowStock
            // 
            pnlLowStock.BackColor = Color.White;
            pnlLowStock.BorderStyle = BorderStyle.FixedSingle;
            pnlLowStock.Controls.Add(lblLowStock);
            pnlLowStock.Controls.Add(lblLowStockTitle);
            pnlLowStock.Location = new Point(966, 108);
            pnlLowStock.Name = "pnlLowStock";
            pnlLowStock.Size = new Size(168, 168);
            pnlLowStock.TabIndex = 4;
            // 
            // lblLowStock
            // 
            lblLowStock.AutoSize = true;
            lblLowStock.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLowStock.ForeColor = Color.FromArgb(74, 20, 140);
            lblLowStock.Location = new Point(3, 83);
            lblLowStock.Name = "lblLowStock";
            lblLowStock.Size = new Size(101, 45);
            lblLowStock.TabIndex = 3;
            lblLowStock.Text = "Value";
            // 
            // lblLowStockTitle
            // 
            lblLowStockTitle.AutoSize = true;
            lblLowStockTitle.Location = new Point(3, 29);
            lblLowStockTitle.Name = "lblLowStockTitle";
            lblLowStockTitle.Size = new Size(92, 25);
            lblLowStockTitle.TabIndex = 3;
            lblLowStockTitle.Text = "Low Stock";
            // 
            // dgvRecentOrders
            // 
            dgvRecentOrders.AllowUserToAddRows = false;
            dgvRecentOrders.AllowUserToDeleteRows = false;
            dgvRecentOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecentOrders.BackgroundColor = SystemColors.ButtonHighlight;
            dgvRecentOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentOrders.Location = new Point(34, 333);
            dgvRecentOrders.MultiSelect = false;
            dgvRecentOrders.Name = "dgvRecentOrders";
            dgvRecentOrders.ReadOnly = true;
            dgvRecentOrders.RowHeadersWidth = 62;
            dgvRecentOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecentOrders.Size = new Size(728, 486);
            dgvRecentOrders.TabIndex = 5;
            // 
            // btnManageShop
            // 
            btnManageShop.BackColor = Color.Coral;
            btnManageShop.Cursor = Cursors.Hand;
            btnManageShop.FlatAppearance.BorderSize = 0;
            btnManageShop.FlatStyle = FlatStyle.Flat;
            btnManageShop.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManageShop.Location = new Point(850, 371);
            btnManageShop.Name = "btnManageShop";
            btnManageShop.Size = new Size(314, 34);
            btnManageShop.TabIndex = 6;
            btnManageShop.Text = "Manage Shop";
            btnManageShop.UseVisualStyleBackColor = false;
            // 
            // btnManageProducts
            // 
            btnManageProducts.BackColor = Color.Coral;
            btnManageProducts.Cursor = Cursors.Hand;
            btnManageProducts.FlatAppearance.BorderSize = 0;
            btnManageProducts.FlatStyle = FlatStyle.Flat;
            btnManageProducts.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManageProducts.Location = new Point(850, 429);
            btnManageProducts.Name = "btnManageProducts";
            btnManageProducts.Size = new Size(314, 34);
            btnManageProducts.TabIndex = 7;
            btnManageProducts.Text = "Manage Products";
            btnManageProducts.UseVisualStyleBackColor = false;
            // 
            // btnOrders
            // 
            btnOrders.BackColor = Color.Coral;
            btnOrders.Cursor = Cursors.Hand;
            btnOrders.FlatAppearance.BorderSize = 0;
            btnOrders.FlatStyle = FlatStyle.Flat;
            btnOrders.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrders.Location = new Point(850, 487);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(314, 34);
            btnOrders.TabIndex = 8;
            btnOrders.Text = "Orders";
            btnOrders.UseVisualStyleBackColor = false;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.Coral;
            btnReports.Cursor = Cursors.Hand;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReports.Location = new Point(850, 547);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(314, 34);
            btnReports.TabIndex = 9;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = false;
            // 
            // btnEmployees
            // 
            btnEmployees.BackColor = Color.Coral;
            btnEmployees.Cursor = Cursors.Hand;
            btnEmployees.FlatAppearance.BorderSize = 0;
            btnEmployees.FlatStyle = FlatStyle.Flat;
            btnEmployees.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmployees.Location = new Point(850, 608);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(314, 34);
            btnEmployees.TabIndex = 10;
            btnEmployees.Text = "Employees";
            btnEmployees.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Red;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(1029, 785);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(135, 34);
            btnLogout.TabIndex = 11;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // lblRecentOrdersTitle
            // 
            lblRecentOrdersTitle.AutoSize = true;
            lblRecentOrdersTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecentOrdersTitle.ForeColor = Color.FromArgb(74, 20, 140);
            lblRecentOrdersTitle.Location = new Point(36, 296);
            lblRecentOrdersTitle.Name = "lblRecentOrdersTitle";
            lblRecentOrdersTitle.Size = new Size(121, 32);
            lblRecentOrdersTitle.TabIndex = 12;
            lblRecentOrdersTitle.Text = "Data Info";
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(1194, 831);
            Controls.Add(lblRecentOrdersTitle);
            Controls.Add(btnLogout);
            Controls.Add(btnEmployees);
            Controls.Add(btnReports);
            Controls.Add(btnOrders);
            Controls.Add(btnManageProducts);
            Controls.Add(btnManageShop);
            Controls.Add(dgvRecentOrders);
            Controls.Add(pnlLowStock);
            Controls.Add(pnlNetIncome);
            Controls.Add(pnlGrossSales);
            Controls.Add(pnlTotalOrders);
            Controls.Add(pnlTotalProducts);
            Controls.Add(lblAdminName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AdminDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminDashboardForm";
            Load += AdminDashboardForm_Load;
            pnlTotalProducts.ResumeLayout(false);
            pnlTotalProducts.PerformLayout();
            pnlTotalOrders.ResumeLayout(false);
            pnlTotalOrders.PerformLayout();
            pnlGrossSales.ResumeLayout(false);
            pnlGrossSales.PerformLayout();
            pnlNetIncome.ResumeLayout(false);
            pnlNetIncome.PerformLayout();
            pnlLowStock.ResumeLayout(false);
            pnlLowStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAdminName;
        private Panel pnlTotalProducts;
        private Panel pnlTotalOrders;
        private Panel pnlGrossSales;
        private Panel pnlNetIncome;
        private Label lblTotalProducts;
        private Label lblTotalProductsTitle;
        private Label lblTotalOrdersTitle;
        private Label lblGrossSalesTitle;
        private Label blNetIncomeTitle;
        private Label lblTotalOrders;
        private Label lblGrossSales;
        private Label lblNetIncome;
        private Panel pnlLowStock;
        private Label lblLowStock;
        private Label lblLowStockTitle;
        private DataGridView dgvRecentOrders;
        private Button btnManageShop;
        private Button btnManageProducts;
        private Button btnOrders;
        private Button btnReports;
        private Button btnEmployees;
        private Button btnLogout;
        private Label lblRecentOrdersTitle;
    }
}