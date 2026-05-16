namespace Cosmatic_Shop_Management.Forms
{
    partial class MaleProductsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaleProductsForm));
            btnNextPage = new Button();
            btnPage3 = new Button();
            btnPage2 = new Button();
            btnPage1 = new Button();
            btnPrevPage = new Button();
            flpFemaleProducts = new FlowLayoutPanel();
            btnSortNewest = new Button();
            pnlFilters = new Panel();
            btnApplyFilters = new Button();
            lblMaxPrice = new Label();
            lblMinPrice = new Label();
            trkPriceRange = new TrackBar();
            lblPriceRangeTitle = new Label();
            rdoOutOfStock = new RadioButton();
            rdoLowStock = new RadioButton();
            rdoInStock = new RadioButton();
            lblStockStatusTitle = new Label();
            chkHairCare = new CheckBox();
            chkFragrance = new CheckBox();
            chkBeardGrooming = new CheckBox();
            chkSkincare = new CheckBox();
            lblCategoryTitle = new Label();
            lblFilterTitle = new Label();
            btnGoBack = new Button();
            lblFormTitle = new Label();
            txtSearchProducts = new TextBox();
            btnNotification = new Button();
            btnProfile = new Button();
            panel1 = new Panel();
            pnlFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trkPriceRange).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnNextPage
            // 
            btnNextPage.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNextPage.BackColor = Color.White;
            btnNextPage.FlatAppearance.BorderSize = 0;
            btnNextPage.FlatStyle = FlatStyle.Flat;
            btnNextPage.Location = new Point(1298, 823);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(40, 36);
            btnNextPage.TabIndex = 26;
            btnNextPage.Text = ">";
            btnNextPage.UseVisualStyleBackColor = false;
            // 
            // btnPage3
            // 
            btnPage3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPage3.BackColor = Color.White;
            btnPage3.FlatAppearance.BorderSize = 0;
            btnPage3.FlatStyle = FlatStyle.Flat;
            btnPage3.Location = new Point(1253, 823);
            btnPage3.Name = "btnPage3";
            btnPage3.Size = new Size(40, 36);
            btnPage3.TabIndex = 25;
            btnPage3.Text = "3";
            btnPage3.UseVisualStyleBackColor = false;
            // 
            // btnPage2
            // 
            btnPage2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPage2.BackColor = Color.White;
            btnPage2.FlatAppearance.BorderSize = 0;
            btnPage2.FlatStyle = FlatStyle.Flat;
            btnPage2.Location = new Point(1208, 823);
            btnPage2.Name = "btnPage2";
            btnPage2.Size = new Size(40, 36);
            btnPage2.TabIndex = 24;
            btnPage2.Text = "2";
            btnPage2.UseVisualStyleBackColor = false;
            // 
            // btnPage1
            // 
            btnPage1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPage1.BackColor = Color.White;
            btnPage1.FlatAppearance.BorderSize = 0;
            btnPage1.FlatStyle = FlatStyle.Flat;
            btnPage1.Location = new Point(1163, 823);
            btnPage1.Name = "btnPage1";
            btnPage1.Size = new Size(40, 36);
            btnPage1.TabIndex = 23;
            btnPage1.Text = "1";
            btnPage1.UseVisualStyleBackColor = false;
            // 
            // btnPrevPage
            // 
            btnPrevPage.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPrevPage.BackColor = Color.White;
            btnPrevPage.FlatAppearance.BorderSize = 0;
            btnPrevPage.FlatStyle = FlatStyle.Flat;
            btnPrevPage.Location = new Point(1118, 823);
            btnPrevPage.Name = "btnPrevPage";
            btnPrevPage.Size = new Size(40, 36);
            btnPrevPage.TabIndex = 22;
            btnPrevPage.Text = "<";
            btnPrevPage.UseVisualStyleBackColor = false;
            // 
            // flpFemaleProducts
            // 
            flpFemaleProducts.AutoScroll = true;
            flpFemaleProducts.Location = new Point(305, 170);
            flpFemaleProducts.Name = "flpFemaleProducts";
            flpFemaleProducts.Size = new Size(1030, 640);
            flpFemaleProducts.TabIndex = 21;
            // 
            // btnSortNewest
            // 
            btnSortNewest.BackColor = Color.White;
            btnSortNewest.Cursor = Cursors.Hand;
            btnSortNewest.FlatAppearance.BorderSize = 0;
            btnSortNewest.FlatStyle = FlatStyle.Flat;
            btnSortNewest.Font = new Font("Segoe UI Emoji", 11F);
            btnSortNewest.ForeColor = Color.Black;
            btnSortNewest.Location = new Point(310, 105);
            btnSortNewest.Name = "btnSortNewest";
            btnSortNewest.Size = new Size(160, 40);
            btnSortNewest.TabIndex = 20;
            btnSortNewest.Text = "⇅ Sort: Newest";
            btnSortNewest.UseVisualStyleBackColor = false;
            // 
            // pnlFilters
            // 
            pnlFilters.BackColor = Color.PowderBlue;
            pnlFilters.BorderStyle = BorderStyle.FixedSingle;
            pnlFilters.Controls.Add(btnApplyFilters);
            pnlFilters.Controls.Add(lblMaxPrice);
            pnlFilters.Controls.Add(lblMinPrice);
            pnlFilters.Controls.Add(trkPriceRange);
            pnlFilters.Controls.Add(lblPriceRangeTitle);
            pnlFilters.Controls.Add(rdoOutOfStock);
            pnlFilters.Controls.Add(rdoLowStock);
            pnlFilters.Controls.Add(rdoInStock);
            pnlFilters.Controls.Add(lblStockStatusTitle);
            pnlFilters.Controls.Add(chkHairCare);
            pnlFilters.Controls.Add(chkFragrance);
            pnlFilters.Controls.Add(chkBeardGrooming);
            pnlFilters.Controls.Add(chkSkincare);
            pnlFilters.Controls.Add(lblCategoryTitle);
            pnlFilters.Controls.Add(lblFilterTitle);
            pnlFilters.Dock = DockStyle.Left;
            pnlFilters.Location = new Point(0, 80);
            pnlFilters.Name = "pnlFilters";
            pnlFilters.Size = new Size(300, 779);
            pnlFilters.TabIndex = 19;
            // 
            // btnApplyFilters
            // 
            btnApplyFilters.BackColor = Color.FromArgb(74, 20, 140);
            btnApplyFilters.Cursor = Cursors.Hand;
            btnApplyFilters.FlatAppearance.BorderSize = 0;
            btnApplyFilters.FlatStyle = FlatStyle.Flat;
            btnApplyFilters.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApplyFilters.ForeColor = Color.White;
            btnApplyFilters.Location = new Point(20, 575);
            btnApplyFilters.Name = "btnApplyFilters";
            btnApplyFilters.Size = new Size(225, 46);
            btnApplyFilters.TabIndex = 14;
            btnApplyFilters.Text = "⟲ Apply Filters";
            btnApplyFilters.UseVisualStyleBackColor = false;
            // 
            // lblMaxPrice
            // 
            lblMaxPrice.AutoSize = true;
            lblMaxPrice.BackColor = Color.Transparent;
            lblMaxPrice.ForeColor = Color.Gray;
            lblMaxPrice.Location = new Point(205, 530);
            lblMaxPrice.Name = "lblMaxPrice";
            lblMaxPrice.Size = new Size(64, 25);
            lblMaxPrice.TabIndex = 13;
            lblMaxPrice.Text = "$500+";
            // 
            // lblMinPrice
            // 
            lblMinPrice.AutoSize = true;
            lblMinPrice.BackColor = Color.Transparent;
            lblMinPrice.ForeColor = Color.Gray;
            lblMinPrice.Location = new Point(20, 530);
            lblMinPrice.Name = "lblMinPrice";
            lblMinPrice.Size = new Size(32, 25);
            lblMinPrice.TabIndex = 12;
            lblMinPrice.Text = "$0";
            // 
            // trkPriceRange
            // 
            trkPriceRange.BackColor = Color.PowderBlue;
            trkPriceRange.Location = new Point(27, 485);
            trkPriceRange.Maximum = 10000;
            trkPriceRange.Name = "trkPriceRange";
            trkPriceRange.Size = new Size(230, 69);
            trkPriceRange.TabIndex = 11;
            trkPriceRange.TickFrequency = 50;
            trkPriceRange.Value = 250;
            // 
            // lblPriceRangeTitle
            // 
            lblPriceRangeTitle.AutoSize = true;
            lblPriceRangeTitle.BackColor = Color.Transparent;
            lblPriceRangeTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPriceRangeTitle.ForeColor = Color.FromArgb(74, 20, 140);
            lblPriceRangeTitle.Location = new Point(20, 450);
            lblPriceRangeTitle.Name = "lblPriceRangeTitle";
            lblPriceRangeTitle.Size = new Size(124, 28);
            lblPriceRangeTitle.TabIndex = 10;
            lblPriceRangeTitle.Text = "Price Range";
            // 
            // rdoOutOfStock
            // 
            rdoOutOfStock.AutoSize = true;
            rdoOutOfStock.Location = new Point(20, 380);
            rdoOutOfStock.Name = "rdoOutOfStock";
            rdoOutOfStock.Size = new Size(137, 29);
            rdoOutOfStock.TabIndex = 9;
            rdoOutOfStock.TabStop = true;
            rdoOutOfStock.Text = "Out of Stock";
            rdoOutOfStock.UseVisualStyleBackColor = true;
            // 
            // rdoLowStock
            // 
            rdoLowStock.AutoSize = true;
            rdoLowStock.Location = new Point(20, 345);
            rdoLowStock.Name = "rdoLowStock";
            rdoLowStock.Size = new Size(117, 29);
            rdoLowStock.TabIndex = 8;
            rdoLowStock.TabStop = true;
            rdoLowStock.Text = "Low Stock";
            rdoLowStock.UseVisualStyleBackColor = true;
            // 
            // rdoInStock
            // 
            rdoInStock.AutoSize = true;
            rdoInStock.Location = new Point(20, 310);
            rdoInStock.Name = "rdoInStock";
            rdoInStock.Size = new Size(100, 29);
            rdoInStock.TabIndex = 7;
            rdoInStock.TabStop = true;
            rdoInStock.Text = "In Stock";
            rdoInStock.UseVisualStyleBackColor = true;
            // 
            // lblStockStatusTitle
            // 
            lblStockStatusTitle.AutoSize = true;
            lblStockStatusTitle.BackColor = Color.Transparent;
            lblStockStatusTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStockStatusTitle.ForeColor = Color.FromArgb(74, 20, 140);
            lblStockStatusTitle.Location = new Point(20, 279);
            lblStockStatusTitle.Name = "lblStockStatusTitle";
            lblStockStatusTitle.Size = new Size(129, 28);
            lblStockStatusTitle.TabIndex = 6;
            lblStockStatusTitle.Text = "Stock Status";
            // 
            // chkHairCare
            // 
            chkHairCare.AutoSize = true;
            chkHairCare.Location = new Point(20, 205);
            chkHairCare.Name = "chkHairCare";
            chkHairCare.Size = new Size(110, 29);
            chkHairCare.TabIndex = 5;
            chkHairCare.Text = "Hair Care";
            chkHairCare.UseVisualStyleBackColor = true;
            // 
            // chkFragrance
            // 
            chkFragrance.AutoSize = true;
            chkFragrance.Location = new Point(20, 170);
            chkFragrance.Name = "chkFragrance";
            chkFragrance.Size = new Size(115, 29);
            chkFragrance.TabIndex = 4;
            chkFragrance.Text = "Fragrance";
            chkFragrance.UseVisualStyleBackColor = true;
            // 
            // chkBeardGrooming
            // 
            chkBeardGrooming.AutoSize = true;
            chkBeardGrooming.Location = new Point(20, 135);
            chkBeardGrooming.Name = "chkBeardGrooming";
            chkBeardGrooming.Size = new Size(88, 29);
            chkBeardGrooming.TabIndex = 3;
            chkBeardGrooming.Text = "Beard ";
            chkBeardGrooming.UseVisualStyleBackColor = true;
            // 
            // chkSkincare
            // 
            chkSkincare.AutoSize = true;
            chkSkincare.Location = new Point(20, 100);
            chkSkincare.Name = "chkSkincare";
            chkSkincare.Size = new Size(103, 29);
            chkSkincare.TabIndex = 2;
            chkSkincare.Text = "Skincare";
            chkSkincare.UseVisualStyleBackColor = true;
            // 
            // lblCategoryTitle
            // 
            lblCategoryTitle.AutoSize = true;
            lblCategoryTitle.BackColor = Color.Transparent;
            lblCategoryTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoryTitle.ForeColor = Color.FromArgb(74, 20, 140);
            lblCategoryTitle.Location = new Point(20, 65);
            lblCategoryTitle.Name = "lblCategoryTitle";
            lblCategoryTitle.Size = new Size(98, 28);
            lblCategoryTitle.TabIndex = 1;
            lblCategoryTitle.Text = "Category";
            // 
            // lblFilterTitle
            // 
            lblFilterTitle.AutoSize = true;
            lblFilterTitle.BackColor = Color.Transparent;
            lblFilterTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblFilterTitle.ForeColor = Color.FromArgb(74, 20, 140);
            lblFilterTitle.Location = new Point(20, 25);
            lblFilterTitle.Name = "lblFilterTitle";
            lblFilterTitle.Size = new Size(202, 30);
            lblFilterTitle.TabIndex = 0;
            lblFilterTitle.Text = "PRODUCT FILTERS";
            // 
            // btnGoBack
            // 
            btnGoBack.Cursor = Cursors.Hand;
            btnGoBack.FlatAppearance.BorderSize = 0;
            btnGoBack.FlatStyle = FlatStyle.Flat;
            btnGoBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGoBack.ForeColor = Color.FromArgb(74, 20, 140);
            btnGoBack.Location = new Point(20, 20);
            btnGoBack.Name = "btnGoBack";
            btnGoBack.Size = new Size(210, 40);
            btnGoBack.TabIndex = 0;
            btnGoBack.Text = "← Back to Dashboard";
            btnGoBack.UseVisualStyleBackColor = true;
            // 
            // lblFormTitle
            // 
            lblFormTitle.Anchor = AnchorStyles.Top;
            lblFormTitle.AutoSize = true;
            lblFormTitle.BackColor = Color.Transparent;
            lblFormTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblFormTitle.Location = new Point(236, 15);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(393, 45);
            lblFormTitle.TabIndex = 1;
            lblFormTitle.Text = "Men's Cosmetic Products";
            // 
            // txtSearchProducts
            // 
            txtSearchProducts.Anchor = AnchorStyles.None;
            txtSearchProducts.BackColor = Color.Beige;
            txtSearchProducts.BorderStyle = BorderStyle.FixedSingle;
            txtSearchProducts.Font = new Font("Segoe UI", 12F);
            txtSearchProducts.Location = new Point(686, 21);
            txtSearchProducts.Name = "txtSearchProducts";
            txtSearchProducts.PlaceholderText = "🔎︎ Search Inventory ";
            txtSearchProducts.Size = new Size(493, 39);
            txtSearchProducts.TabIndex = 2;
            // 
            // btnNotification
            // 
            btnNotification.Anchor = AnchorStyles.Right;
            btnNotification.Cursor = Cursors.Hand;
            btnNotification.FlatAppearance.BorderSize = 0;
            btnNotification.FlatStyle = FlatStyle.Flat;
            btnNotification.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNotification.ForeColor = Color.FromArgb(74, 20, 140);
            btnNotification.Location = new Point(1207, 14);
            btnNotification.Name = "btnNotification";
            btnNotification.Size = new Size(40, 55);
            btnNotification.TabIndex = 3;
            btnNotification.Text = "🔔";
            btnNotification.UseVisualStyleBackColor = true;
            // 
            // btnProfile
            // 
            btnProfile.Anchor = AnchorStyles.Right;
            btnProfile.BackColor = Color.White;
            btnProfile.Cursor = Cursors.Hand;
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProfile.ForeColor = Color.Black;
            btnProfile.Image = (Image)resources.GetObject("btnProfile.Image");
            btnProfile.Location = new Point(1252, 9);
            btnProfile.Margin = new Padding(0);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(60, 60);
            btnProfile.TabIndex = 10;
            btnProfile.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnProfile);
            panel1.Controls.Add(btnNotification);
            panel1.Controls.Add(txtSearchProducts);
            panel1.Controls.Add(lblFormTitle);
            panel1.Controls.Add(btnGoBack);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1403, 80);
            panel1.TabIndex = 18;
            // 
            // MaleProductsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1403, 859);
            Controls.Add(btnNextPage);
            Controls.Add(btnPage3);
            Controls.Add(btnPage2);
            Controls.Add(btnPage1);
            Controls.Add(btnPrevPage);
            Controls.Add(flpFemaleProducts);
            Controls.Add(btnSortNewest);
            Controls.Add(pnlFilters);
            Controls.Add(panel1);
            Name = "MaleProductsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MaleProductsForm";
            WindowState = FormWindowState.Maximized;
            Load += MaleProductsForm_Load;
            pnlFilters.ResumeLayout(false);
            pnlFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trkPriceRange).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnNextPage;
        private Button btnPage3;
        private Button btnPage2;
        private Button btnPage1;
        private Button btnPrevPage;
        private FlowLayoutPanel flpFemaleProducts;
        private Button btnSortNewest;
        private Panel pnlFilters;
        private Button btnApplyFilters;
        private Label lblMaxPrice;
        private Label lblMinPrice;
        private TrackBar trkPriceRange;
        private Label lblPriceRangeTitle;
        private RadioButton rdoOutOfStock;
        private RadioButton rdoLowStock;
        private RadioButton rdoInStock;
        private Label lblStockStatusTitle;
        private CheckBox chkHairCare;
        private CheckBox chkFragrance;
        private CheckBox chkBeardGrooming;
        private CheckBox chkSkincare;
        private Label lblCategoryTitle;
        private Label lblFilterTitle;
        private Button btnGoBack;
        private Label lblFormTitle;
        private TextBox txtSearchProducts;
        private Button btnNotification;
        private Button btnProfile;
        private Panel panel1;
    }
}