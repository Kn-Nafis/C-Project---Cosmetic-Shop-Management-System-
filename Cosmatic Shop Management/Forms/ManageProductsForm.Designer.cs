namespace Cosmatic_Shop_Management.Forms
{
    partial class ManageProductsForm
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
            pnlLowStockAlert = new Panel();
            lnkViewDetails = new LinkLabel();
            lblLowStockAlert = new Label();
            lblManageProductsTitle = new Label();
            lblManageProductsSubtitle = new Label();
            btnAddProduct = new Button();
            pnlFilters = new Panel();
            btnApplyFilters = new Button();
            cmbStockStatusFilter = new ComboBox();
            lblStockStatusFilterTitle = new Label();
            cmbCategoryFilter = new ComboBox();
            lblCategoryFilterTitle = new Label();
            txtSearchProducts = new TextBox();
            lblSearchProductsTitle = new Label();
            dgvProducts = new DataGridView();
            pnlInventoryValue = new Panel();
            lblInventoryValue = new Label();
            lblInventoryValueTitle = new Label();
            pnlTopCategory = new Panel();
            lblTopSellingCategory = new Label();
            lblTopCategoryTitle = new Label();
            pnlStockHealth = new Panel();
            lblStockHealth = new Label();
            lblStockHealthTitle = new Label();
            btnGoBack = new Button();
            btnEditProduct = new Button();
            pnlLowStockAlert.SuspendLayout();
            pnlFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            pnlInventoryValue.SuspendLayout();
            pnlTopCategory.SuspendLayout();
            pnlStockHealth.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLowStockAlert
            // 
            pnlLowStockAlert.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlLowStockAlert.BackColor = Color.MistyRose;
            pnlLowStockAlert.BorderStyle = BorderStyle.FixedSingle;
            pnlLowStockAlert.Controls.Add(lnkViewDetails);
            pnlLowStockAlert.Controls.Add(lblLowStockAlert);
            pnlLowStockAlert.Location = new Point(234, 23);
            pnlLowStockAlert.Name = "pnlLowStockAlert";
            pnlLowStockAlert.Size = new Size(817, 58);
            pnlLowStockAlert.TabIndex = 0;
            // 
            // lnkViewDetails
            // 
            lnkViewDetails.AutoSize = true;
            lnkViewDetails.LinkColor = Color.Firebrick;
            lnkViewDetails.Location = new Point(703, 21);
            lnkViewDetails.Name = "lnkViewDetails";
            lnkViewDetails.Size = new Size(107, 25);
            lnkViewDetails.TabIndex = 1;
            lnkViewDetails.TabStop = true;
            lnkViewDetails.Text = "View Details";
            // 
            // lblLowStockAlert
            // 
            lblLowStockAlert.AutoSize = true;
            lblLowStockAlert.BackColor = Color.Transparent;
            lblLowStockAlert.FlatStyle = FlatStyle.Flat;
            lblLowStockAlert.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLowStockAlert.ForeColor = Color.Firebrick;
            lblLowStockAlert.Location = new Point(28, 16);
            lblLowStockAlert.Name = "lblLowStockAlert";
            lblLowStockAlert.Size = new Size(187, 30);
            lblLowStockAlert.TabIndex = 0;
            lblLowStockAlert.Text = "Low Stock Alert: ";
            // 
            // lblManageProductsTitle
            // 
            lblManageProductsTitle.AutoSize = true;
            lblManageProductsTitle.BackColor = Color.Transparent;
            lblManageProductsTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblManageProductsTitle.ForeColor = Color.Black;
            lblManageProductsTitle.Location = new Point(202, 110);
            lblManageProductsTitle.Name = "lblManageProductsTitle";
            lblManageProductsTitle.Size = new Size(388, 60);
            lblManageProductsTitle.TabIndex = 1;
            lblManageProductsTitle.Text = "Manage Products";
            // 
            // lblManageProductsSubtitle
            // 
            lblManageProductsSubtitle.AutoSize = true;
            lblManageProductsSubtitle.BackColor = Color.Transparent;
            lblManageProductsSubtitle.Font = new Font("Segoe UI", 11F);
            lblManageProductsSubtitle.ForeColor = Color.DimGray;
            lblManageProductsSubtitle.Location = new Point(202, 170);
            lblManageProductsSubtitle.Name = "lblManageProductsSubtitle";
            lblManageProductsSubtitle.Size = new Size(420, 30);
            lblManageProductsSubtitle.TabIndex = 2;
            lblManageProductsSubtitle.Text = "Inventory management and stock tracking";
            // 
            // btnAddProduct
            // 
            btnAddProduct.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddProduct.BackColor = Color.Coral;
            btnAddProduct.Cursor = Cursors.Hand;
            btnAddProduct.FlatAppearance.BorderSize = 0;
            btnAddProduct.FlatStyle = FlatStyle.Flat;
            btnAddProduct.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddProduct.ForeColor = Color.White;
            btnAddProduct.Location = new Point(902, 154);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(183, 46);
            btnAddProduct.TabIndex = 3;
            btnAddProduct.Text = "+ Add Product";
            btnAddProduct.UseVisualStyleBackColor = false;
            // 
            // pnlFilters
            // 
            pnlFilters.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlFilters.BackColor = Color.Cornsilk;
            pnlFilters.BorderStyle = BorderStyle.FixedSingle;
            pnlFilters.Controls.Add(btnApplyFilters);
            pnlFilters.Controls.Add(cmbStockStatusFilter);
            pnlFilters.Controls.Add(lblStockStatusFilterTitle);
            pnlFilters.Controls.Add(cmbCategoryFilter);
            pnlFilters.Controls.Add(lblCategoryFilterTitle);
            pnlFilters.Controls.Add(txtSearchProducts);
            pnlFilters.Controls.Add(lblSearchProductsTitle);
            pnlFilters.Location = new Point(202, 212);
            pnlFilters.Name = "pnlFilters";
            pnlFilters.Size = new Size(883, 84);
            pnlFilters.TabIndex = 4;
            // 
            // btnApplyFilters
            // 
            btnApplyFilters.BackColor = Color.Thistle;
            btnApplyFilters.Cursor = Cursors.Hand;
            btnApplyFilters.FlatAppearance.BorderSize = 0;
            btnApplyFilters.FlatStyle = FlatStyle.Flat;
            btnApplyFilters.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApplyFilters.ForeColor = Color.FromArgb(74, 20, 140);
            btnApplyFilters.Location = new Point(755, 29);
            btnApplyFilters.Name = "btnApplyFilters";
            btnApplyFilters.Size = new Size(112, 46);
            btnApplyFilters.TabIndex = 6;
            btnApplyFilters.Text = "Filters";
            btnApplyFilters.UseVisualStyleBackColor = false;
            // 
            // cmbStockStatusFilter
            // 
            cmbStockStatusFilter.BackColor = Color.White;
            cmbStockStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStockStatusFilter.Font = new Font("Segoe UI", 11F);
            cmbStockStatusFilter.FormattingEnabled = true;
            cmbStockStatusFilter.Items.AddRange(new object[] { "All Items", "Active", "Low Stock", "Out Of Stock" });
            cmbStockStatusFilter.Location = new Point(522, 37);
            cmbStockStatusFilter.Name = "cmbStockStatusFilter";
            cmbStockStatusFilter.Size = new Size(182, 38);
            cmbStockStatusFilter.TabIndex = 5;
            // 
            // lblStockStatusFilterTitle
            // 
            lblStockStatusFilterTitle.AutoSize = true;
            lblStockStatusFilterTitle.BackColor = Color.Transparent;
            lblStockStatusFilterTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStockStatusFilterTitle.ForeColor = Color.Black;
            lblStockStatusFilterTitle.Location = new Point(523, 0);
            lblStockStatusFilterTitle.Name = "lblStockStatusFilterTitle";
            lblStockStatusFilterTitle.Size = new Size(158, 28);
            lblStockStatusFilterTitle.TabIndex = 4;
            lblStockStatusFilterTitle.Text = " STOCK STATUS";
            // 
            // cmbCategoryFilter
            // 
            cmbCategoryFilter.BackColor = Color.White;
            cmbCategoryFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoryFilter.Font = new Font("Segoe UI", 11F);
            cmbCategoryFilter.FormattingEnabled = true;
            cmbCategoryFilter.Location = new Point(334, 38);
            cmbCategoryFilter.Name = "cmbCategoryFilter";
            cmbCategoryFilter.Size = new Size(182, 38);
            cmbCategoryFilter.TabIndex = 3;
            // 
            // lblCategoryFilterTitle
            // 
            lblCategoryFilterTitle.AutoSize = true;
            lblCategoryFilterTitle.BackColor = Color.Transparent;
            lblCategoryFilterTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoryFilterTitle.ForeColor = Color.Black;
            lblCategoryFilterTitle.Location = new Point(334, 0);
            lblCategoryFilterTitle.Name = "lblCategoryFilterTitle";
            lblCategoryFilterTitle.Size = new Size(120, 28);
            lblCategoryFilterTitle.TabIndex = 2;
            lblCategoryFilterTitle.Text = " CATEGORY";
            // 
            // txtSearchProducts
            // 
            txtSearchProducts.BackColor = Color.White;
            txtSearchProducts.BorderStyle = BorderStyle.FixedSingle;
            txtSearchProducts.Font = new Font("Segoe UI", 11F);
            txtSearchProducts.Location = new Point(16, 38);
            txtSearchProducts.Name = "txtSearchProducts";
            txtSearchProducts.PlaceholderText = "  Product Name,SKU or brand...";
            txtSearchProducts.Size = new Size(312, 37);
            txtSearchProducts.TabIndex = 1;
            // 
            // lblSearchProductsTitle
            // 
            lblSearchProductsTitle.AutoSize = true;
            lblSearchProductsTitle.BackColor = Color.Transparent;
            lblSearchProductsTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearchProductsTitle.ForeColor = Color.Black;
            lblSearchProductsTitle.Location = new Point(16, 0);
            lblSearchProductsTitle.Name = "lblSearchProductsTitle";
            lblSearchProductsTitle.Size = new Size(198, 28);
            lblSearchProductsTitle.TabIndex = 0;
            lblSearchProductsTitle.Text = "SEARCH PRODUCTS";
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = Color.Cornsilk;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(202, 322);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.RowHeadersWidth = 62;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(883, 400);
            dgvProducts.TabIndex = 5;
            // 
            // pnlInventoryValue
            // 
            pnlInventoryValue.BackColor = Color.WhiteSmoke;
            pnlInventoryValue.BorderStyle = BorderStyle.FixedSingle;
            pnlInventoryValue.Controls.Add(lblInventoryValue);
            pnlInventoryValue.Controls.Add(lblInventoryValueTitle);
            pnlInventoryValue.Location = new Point(202, 750);
            pnlInventoryValue.Name = "pnlInventoryValue";
            pnlInventoryValue.Size = new Size(305, 169);
            pnlInventoryValue.TabIndex = 6;
            // 
            // lblInventoryValue
            // 
            lblInventoryValue.AutoSize = true;
            lblInventoryValue.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInventoryValue.ForeColor = Color.FromArgb(74, 20, 140);
            lblInventoryValue.Location = new Point(3, 72);
            lblInventoryValue.Name = "lblInventoryValue";
            lblInventoryValue.Size = new Size(102, 54);
            lblInventoryValue.TabIndex = 1;
            lblInventoryValue.Text = "0 Tk";
            // 
            // lblInventoryValueTitle
            // 
            lblInventoryValueTitle.AutoSize = true;
            lblInventoryValueTitle.Font = new Font("Segoe UI", 10F);
            lblInventoryValueTitle.ForeColor = Color.Black;
            lblInventoryValueTitle.Location = new Point(3, 27);
            lblInventoryValueTitle.Name = "lblInventoryValueTitle";
            lblInventoryValueTitle.Size = new Size(237, 28);
            lblInventoryValueTitle.TabIndex = 0;
            lblInventoryValueTitle.Text = "TOTAL INVENTORY VALUE";
            // 
            // pnlTopCategory
            // 
            pnlTopCategory.BackColor = Color.WhiteSmoke;
            pnlTopCategory.BorderStyle = BorderStyle.FixedSingle;
            pnlTopCategory.Controls.Add(lblTopSellingCategory);
            pnlTopCategory.Controls.Add(lblTopCategoryTitle);
            pnlTopCategory.Location = new Point(513, 750);
            pnlTopCategory.Name = "pnlTopCategory";
            pnlTopCategory.Size = new Size(307, 169);
            pnlTopCategory.TabIndex = 7;
            // 
            // lblTopSellingCategory
            // 
            lblTopSellingCategory.AutoSize = true;
            lblTopSellingCategory.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTopSellingCategory.ForeColor = Color.FromArgb(74, 20, 140);
            lblTopSellingCategory.Location = new Point(3, 82);
            lblTopSellingCategory.Name = "lblTopSellingCategory";
            lblTopSellingCategory.Size = new Size(238, 41);
            lblTopSellingCategory.TabIndex = 1;
            lblTopSellingCategory.Text = "Category Name";
            // 
            // lblTopCategoryTitle
            // 
            lblTopCategoryTitle.AutoSize = true;
            lblTopCategoryTitle.Font = new Font("Segoe UI", 10F);
            lblTopCategoryTitle.ForeColor = Color.Black;
            lblTopCategoryTitle.Location = new Point(3, 27);
            lblTopCategoryTitle.Name = "lblTopCategoryTitle";
            lblTopCategoryTitle.Size = new Size(226, 28);
            lblTopCategoryTitle.TabIndex = 0;
            lblTopCategoryTitle.Text = "TOP SELLING CATEGORY";
            // 
            // pnlStockHealth
            // 
            pnlStockHealth.BackColor = Color.WhiteSmoke;
            pnlStockHealth.BorderStyle = BorderStyle.FixedSingle;
            pnlStockHealth.Controls.Add(lblStockHealth);
            pnlStockHealth.Controls.Add(lblStockHealthTitle);
            pnlStockHealth.Location = new Point(826, 750);
            pnlStockHealth.Name = "pnlStockHealth";
            pnlStockHealth.Size = new Size(259, 169);
            pnlStockHealth.TabIndex = 7;
            // 
            // lblStockHealth
            // 
            lblStockHealth.AutoSize = true;
            lblStockHealth.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStockHealth.ForeColor = Color.FromArgb(74, 20, 140);
            lblStockHealth.Location = new Point(3, 72);
            lblStockHealth.Name = "lblStockHealth";
            lblStockHealth.Size = new Size(81, 54);
            lblStockHealth.TabIndex = 1;
            lblStockHealth.Text = "0%";
            // 
            // lblStockHealthTitle
            // 
            lblStockHealthTitle.AutoSize = true;
            lblStockHealthTitle.Font = new Font("Segoe UI", 10F);
            lblStockHealthTitle.ForeColor = Color.Black;
            lblStockHealthTitle.Location = new Point(3, 27);
            lblStockHealthTitle.Name = "lblStockHealthTitle";
            lblStockHealthTitle.Size = new Size(145, 28);
            lblStockHealthTitle.TabIndex = 0;
            lblStockHealthTitle.Text = "STOCK HEALTH";
            // 
            // btnGoBack
            // 
            btnGoBack.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGoBack.BackColor = Color.FromArgb(74, 20, 140);
            btnGoBack.Cursor = Cursors.Hand;
            btnGoBack.FlatAppearance.BorderSize = 0;
            btnGoBack.FlatStyle = FlatStyle.Flat;
            btnGoBack.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGoBack.ForeColor = Color.White;
            btnGoBack.Location = new Point(902, 102);
            btnGoBack.Name = "btnGoBack";
            btnGoBack.Size = new Size(183, 46);
            btnGoBack.TabIndex = 8;
            btnGoBack.Text = "Go Back";
            btnGoBack.UseVisualStyleBackColor = false;
            // 
            // btnEditProduct
            // 
            btnEditProduct.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditProduct.AutoSize = true;
            btnEditProduct.FlatAppearance.BorderSize = 2;
            btnEditProduct.FlatStyle = FlatStyle.Flat;
            btnEditProduct.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEditProduct.Location = new Point(779, 153);
            btnEditProduct.Name = "btnEditProduct";
            btnEditProduct.Size = new Size(105, 46);
            btnEditProduct.TabIndex = 9;
            btnEditProduct.Text = "🖉 Edit";
            btnEditProduct.UseVisualStyleBackColor = true;
            // 
            // ManageProductsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(1298, 1170);
            Controls.Add(btnEditProduct);
            Controls.Add(btnGoBack);
            Controls.Add(pnlStockHealth);
            Controls.Add(pnlTopCategory);
            Controls.Add(pnlInventoryValue);
            Controls.Add(dgvProducts);
            Controls.Add(pnlFilters);
            Controls.Add(btnAddProduct);
            Controls.Add(lblManageProductsSubtitle);
            Controls.Add(lblManageProductsTitle);
            Controls.Add(pnlLowStockAlert);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ManageProductsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageProductsForm";
            WindowState = FormWindowState.Maximized;
            Load += ManageProductsForm_Load;
            pnlLowStockAlert.ResumeLayout(false);
            pnlLowStockAlert.PerformLayout();
            pnlFilters.ResumeLayout(false);
            pnlFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            pnlInventoryValue.ResumeLayout(false);
            pnlInventoryValue.PerformLayout();
            pnlTopCategory.ResumeLayout(false);
            pnlTopCategory.PerformLayout();
            pnlStockHealth.ResumeLayout(false);
            pnlStockHealth.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlLowStockAlert;
        private Label lblLowStockAlert;
        private LinkLabel lnkViewDetails;
        private Label lblManageProductsTitle;
        private Label lblManageProductsSubtitle;
        private Button btnAddProduct;
        private Panel pnlFilters;
        private TextBox txtSearchProducts;
        private Label lblSearchProductsTitle;
        private ComboBox cmbCategoryFilter;
        private Label lblCategoryFilterTitle;
        private Label lblStockStatusFilterTitle;
        private Button btnApplyFilters;
        private ComboBox cmbStockStatusFilter;
        private DataGridView dgvProducts;
        private Panel pnlInventoryValue;
        private Label lblInventoryValue;
        private Label lblInventoryValueTitle;
        private Panel pnlTopCategory;
        private Label lblTopSellingCategory;
        private Label lblTopCategoryTitle;
        private Panel pnlStockHealth;
        private Label lblStockHealth;
        private Label lblStockHealthTitle;
        private Button btnGoBack;
        private Button btnEditProduct;
    }
}