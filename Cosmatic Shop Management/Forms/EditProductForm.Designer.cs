namespace Cosmatic_Shop_Management.Forms
{
    partial class EditProductForm
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
            lblPageTitle = new Label();
            lblSubtitle = new Label();
            pnlMainEditor = new Panel();
            pnlHeaderStrip = new Panel();
            lblEditorHeader = new Label();
            pnlProductVisual = new Panel();
            lblProductVisualTitle = new Label();
            picProductImage = new PictureBox();
            lblImageInfo = new Label();
            pnlStockStatus = new Panel();
            lblStockStatusPanelTitle = new Label();
            lblCatalogStatus = new Label();
            chkIsActive = new CheckBox();
            lblInventoryAlert = new Label();
            lblInventoryAlertText = new Label();
            txtDescription = new TextBox();
            lblDescriptionTitle = new Label();
            txtStockQty = new TextBox();
            lblQuantityOnHand = new Label();
            txtRetailPrice = new TextBox();
            lblRetailPrice = new Label();
            cmbGender = new ComboBox();
            lblGenderTitle = new Label();
            cmbCategory = new ComboBox();
            lblCategory = new Label();
            txtProductName = new TextBox();
            lblProductNameTitle = new Label();
            pnlPriceStock = new Panel();
            btnDeleteProduct = new Button();
            btnCancel = new Button();
            btnUpdateProduct = new Button();
            lblLastUpdated = new Label();
            lblSystemGuid = new Label();
            pnlMainEditor.SuspendLayout();
            pnlHeaderStrip.SuspendLayout();
            pnlProductVisual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProductImage).BeginInit();
            pnlStockStatus.SuspendLayout();
            pnlPriceStock.SuspendLayout();
            SuspendLayout();
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPageTitle.ForeColor = Color.FromArgb(74, 20, 140);
            lblPageTitle.Location = new Point(28, 25);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(435, 60);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Edit Product Details";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.ForeColor = Color.DarkGray;
            lblSubtitle.Location = new Point(28, 85);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(511, 25);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = " Modify the specific parameters for the selected inventory item.";
            // 
            // pnlMainEditor
            // 
            pnlMainEditor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlMainEditor.BorderStyle = BorderStyle.FixedSingle;
            pnlMainEditor.Controls.Add(lblSystemGuid);
            pnlMainEditor.Controls.Add(lblLastUpdated);
            pnlMainEditor.Controls.Add(btnUpdateProduct);
            pnlMainEditor.Controls.Add(btnCancel);
            pnlMainEditor.Controls.Add(btnDeleteProduct);
            pnlMainEditor.Controls.Add(pnlPriceStock);
            pnlMainEditor.Controls.Add(txtDescription);
            pnlMainEditor.Controls.Add(pnlStockStatus);
            pnlMainEditor.Controls.Add(lblDescriptionTitle);
            pnlMainEditor.Controls.Add(pnlProductVisual);
            pnlMainEditor.Controls.Add(pnlHeaderStrip);
            pnlMainEditor.Controls.Add(txtProductName);
            pnlMainEditor.Controls.Add(lblProductNameTitle);
            pnlMainEditor.Controls.Add(lblCategory);
            pnlMainEditor.Controls.Add(cmbGender);
            pnlMainEditor.Controls.Add(lblGenderTitle);
            pnlMainEditor.Controls.Add(cmbCategory);
            pnlMainEditor.Location = new Point(25, 120);
            pnlMainEditor.Name = "pnlMainEditor";
            pnlMainEditor.Size = new Size(909, 600);
            pnlMainEditor.TabIndex = 2;
            // 
            // pnlHeaderStrip
            // 
            pnlHeaderStrip.BackColor = Color.FromArgb(74, 20, 140);
            pnlHeaderStrip.Controls.Add(lblEditorHeader);
            pnlHeaderStrip.Dock = DockStyle.Top;
            pnlHeaderStrip.Location = new Point(0, 0);
            pnlHeaderStrip.Name = "pnlHeaderStrip";
            pnlHeaderStrip.Size = new Size(907, 35);
            pnlHeaderStrip.TabIndex = 0;
            // 
            // lblEditorHeader
            // 
            lblEditorHeader.AutoSize = true;
            lblEditorHeader.BackColor = Color.Transparent;
            lblEditorHeader.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditorHeader.ForeColor = Color.White;
            lblEditorHeader.Location = new Point(10, 9);
            lblEditorHeader.Name = "lblEditorHeader";
            lblEditorHeader.Size = new Size(417, 25);
            lblEditorHeader.TabIndex = 0;
            lblEditorHeader.Text = "PRODUCT RECORD EDITOR — SKU: GC-7729-RS";
            // 
            // pnlProductVisual
            // 
            pnlProductVisual.BackColor = Color.White;
            pnlProductVisual.BorderStyle = BorderStyle.FixedSingle;
            pnlProductVisual.Controls.Add(lblImageInfo);
            pnlProductVisual.Controls.Add(picProductImage);
            pnlProductVisual.Controls.Add(lblProductVisualTitle);
            pnlProductVisual.Location = new Point(15, 50);
            pnlProductVisual.Name = "pnlProductVisual";
            pnlProductVisual.Size = new Size(206, 265);
            pnlProductVisual.TabIndex = 1;
            // 
            // lblProductVisualTitle
            // 
            lblProductVisualTitle.AutoSize = true;
            lblProductVisualTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductVisualTitle.ForeColor = Color.DimGray;
            lblProductVisualTitle.Location = new Point(3, 0);
            lblProductVisualTitle.Name = "lblProductVisualTitle";
            lblProductVisualTitle.Size = new Size(165, 25);
            lblProductVisualTitle.TabIndex = 2;
            lblProductVisualTitle.Text = "PRODUCT VISUAL";
            // 
            // picProductImage
            // 
            picProductImage.BackColor = Color.WhiteSmoke;
            picProductImage.BorderStyle = BorderStyle.FixedSingle;
            picProductImage.Location = new Point(15, 45);
            picProductImage.Name = "picProductImage";
            picProductImage.Size = new Size(170, 170);
            picProductImage.SizeMode = PictureBoxSizeMode.StretchImage;
            picProductImage.TabIndex = 3;
            picProductImage.TabStop = false;
            // 
            // lblImageInfo
            // 
            lblImageInfo.Font = new Font("Segoe UI", 7F);
            lblImageInfo.Location = new Point(3, 226);
            lblImageInfo.Name = "lblImageInfo";
            lblImageInfo.Size = new Size(205, 38);
            lblImageInfo.TabIndex = 4;
            lblImageInfo.Text = "Accepted: JPG, PNG (Max 5MB)";
            // 
            // pnlStockStatus
            // 
            pnlStockStatus.BackColor = Color.White;
            pnlStockStatus.BorderStyle = BorderStyle.FixedSingle;
            pnlStockStatus.Controls.Add(lblInventoryAlertText);
            pnlStockStatus.Controls.Add(lblInventoryAlert);
            pnlStockStatus.Controls.Add(chkIsActive);
            pnlStockStatus.Controls.Add(lblCatalogStatus);
            pnlStockStatus.Controls.Add(lblStockStatusPanelTitle);
            pnlStockStatus.Location = new Point(10, 332);
            pnlStockStatus.Name = "pnlStockStatus";
            pnlStockStatus.Size = new Size(230, 170);
            pnlStockStatus.TabIndex = 3;
            // 
            // lblStockStatusPanelTitle
            // 
            lblStockStatusPanelTitle.AutoSize = true;
            lblStockStatusPanelTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStockStatusPanelTitle.ForeColor = Color.DimGray;
            lblStockStatusPanelTitle.Location = new Point(12, 12);
            lblStockStatusPanelTitle.Name = "lblStockStatusPanelTitle";
            lblStockStatusPanelTitle.Size = new Size(140, 25);
            lblStockStatusPanelTitle.TabIndex = 0;
            lblStockStatusPanelTitle.Text = "STOCK STATUS";
            // 
            // lblCatalogStatus
            // 
            lblCatalogStatus.BackColor = Color.Beige;
            lblCatalogStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCatalogStatus.ForeColor = Color.Black;
            lblCatalogStatus.Location = new Point(15, 38);
            lblCatalogStatus.Name = "lblCatalogStatus";
            lblCatalogStatus.Size = new Size(158, 35);
            lblCatalogStatus.TabIndex = 1;
            lblCatalogStatus.Text = "Active in Catalog";
            lblCatalogStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Checked = true;
            chkIsActive.CheckState = CheckState.Checked;
            chkIsActive.Location = new Point(175, 42);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(22, 21);
            chkIsActive.TabIndex = 2;
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // lblInventoryAlert
            // 
            lblInventoryAlert.BackColor = Color.Beige;
            lblInventoryAlert.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInventoryAlert.ForeColor = Color.DarkGoldenrod;
            lblInventoryAlert.Location = new Point(15, 78);
            lblInventoryAlert.Name = "lblInventoryAlert";
            lblInventoryAlert.Size = new Size(190, 24);
            lblInventoryAlert.TabIndex = 3;
            lblInventoryAlert.Text = "INVENTORY ALERT";
            lblInventoryAlert.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblInventoryAlertText
            // 
            lblInventoryAlertText.Font = new Font("Segoe UI", 7F);
            lblInventoryAlertText.ForeColor = Color.DarkGoldenrod;
            lblInventoryAlertText.Location = new Point(15, 108);
            lblInventoryAlertText.Name = "lblInventoryAlertText";
            lblInventoryAlertText.Size = new Size(190, 40);
            lblInventoryAlertText.TabIndex = 4;
            lblInventoryAlertText.Text = "Stock level is approaching reorder threshold.";
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.White;
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Font = new Font("Segoe UI", 12F);
            txtDescription.Location = new Point(280, 383);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "  e.g Velvet Matte  Lipstic";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(520, 103);
            txtDescription.TabIndex = 30;
            // 
            // lblDescriptionTitle
            // 
            lblDescriptionTitle.AutoSize = true;
            lblDescriptionTitle.BackColor = Color.Transparent;
            lblDescriptionTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescriptionTitle.ForeColor = Color.DimGray;
            lblDescriptionTitle.Location = new Point(283, 350);
            lblDescriptionTitle.Name = "lblDescriptionTitle";
            lblDescriptionTitle.Size = new Size(156, 30);
            lblDescriptionTitle.TabIndex = 29;
            lblDescriptionTitle.Text = "DESCRIPTION";
            // 
            // txtStockQty
            // 
            txtStockQty.BackColor = Color.White;
            txtStockQty.BorderStyle = BorderStyle.FixedSingle;
            txtStockQty.Font = new Font("Segoe UI", 12F);
            txtStockQty.Location = new Point(284, 35);
            txtStockQty.Name = "txtStockQty";
            txtStockQty.PlaceholderText = "  e.g 999";
            txtStockQty.Size = new Size(182, 39);
            txtStockQty.TabIndex = 28;
            // 
            // lblQuantityOnHand
            // 
            lblQuantityOnHand.AutoSize = true;
            lblQuantityOnHand.BackColor = Color.Transparent;
            lblQuantityOnHand.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantityOnHand.ForeColor = Color.DimGray;
            lblQuantityOnHand.Location = new Point(284, 0);
            lblQuantityOnHand.Name = "lblQuantityOnHand";
            lblQuantityOnHand.Size = new Size(235, 30);
            lblQuantityOnHand.TabIndex = 27;
            lblQuantityOnHand.Text = "QUANTITY ON HAND";
            // 
            // txtRetailPrice
            // 
            txtRetailPrice.BackColor = Color.White;
            txtRetailPrice.BorderStyle = BorderStyle.FixedSingle;
            txtRetailPrice.Font = new Font("Segoe UI", 12F);
            txtRetailPrice.Location = new Point(17, 35);
            txtRetailPrice.Name = "txtRetailPrice";
            txtRetailPrice.PlaceholderText = "  e.g 999";
            txtRetailPrice.Size = new Size(182, 39);
            txtRetailPrice.TabIndex = 26;
            // 
            // lblRetailPrice
            // 
            lblRetailPrice.AutoSize = true;
            lblRetailPrice.BackColor = Color.Transparent;
            lblRetailPrice.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRetailPrice.ForeColor = Color.DimGray;
            lblRetailPrice.Location = new Point(17, 0);
            lblRetailPrice.Name = "lblRetailPrice";
            lblRetailPrice.Size = new Size(199, 30);
            lblRetailPrice.TabIndex = 25;
            lblRetailPrice.Text = "RETAIL PRICE (TK)";
            // 
            // cmbGender
            // 
            cmbGender.BackColor = Color.White;
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.Font = new Font("Segoe UI", 11F);
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female", "Unisex" });
            cmbGender.Location = new Point(550, 159);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(182, 38);
            cmbGender.TabIndex = 24;
            // 
            // lblGenderTitle
            // 
            lblGenderTitle.AutoSize = true;
            lblGenderTitle.BackColor = Color.Transparent;
            lblGenderTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGenderTitle.ForeColor = Color.DimGray;
            lblGenderTitle.Location = new Point(545, 126);
            lblGenderTitle.Name = "lblGenderTitle";
            lblGenderTitle.Size = new Size(187, 30);
            lblGenderTitle.TabIndex = 23;
            lblGenderTitle.Text = "TARGET GENDER";
            lblGenderTitle.Click += lblGenderTitle_Click;
            // 
            // cmbCategory
            // 
            cmbCategory.BackColor = Color.White;
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Font = new Font("Segoe UI", 11F);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(280, 159);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(182, 38);
            cmbCategory.TabIndex = 22;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.BackColor = Color.Transparent;
            lblCategory.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.ForeColor = Color.DimGray;
            lblCategory.Location = new Point(280, 126);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(125, 30);
            lblCategory.TabIndex = 20;
            lblCategory.Text = "CATEGORY";
            // 
            // txtProductName
            // 
            txtProductName.BackColor = Color.White;
            txtProductName.BorderStyle = BorderStyle.FixedSingle;
            txtProductName.Font = new Font("Segoe UI", 12F);
            txtProductName.Location = new Point(280, 84);
            txtProductName.Name = "txtProductName";
            txtProductName.PlaceholderText = "  e.g Velvet Matte  Lipstic";
            txtProductName.Size = new Size(520, 39);
            txtProductName.TabIndex = 19;
            // 
            // lblProductNameTitle
            // 
            lblProductNameTitle.AutoSize = true;
            lblProductNameTitle.BackColor = Color.Transparent;
            lblProductNameTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductNameTitle.ForeColor = Color.DimGray;
            lblProductNameTitle.Location = new Point(280, 51);
            lblProductNameTitle.Name = "lblProductNameTitle";
            lblProductNameTitle.Size = new Size(204, 30);
            lblProductNameTitle.TabIndex = 18;
            lblProductNameTitle.Text = "PRODUCT NAME *";
            // 
            // pnlPriceStock
            // 
            pnlPriceStock.BackColor = Color.Cornsilk;
            pnlPriceStock.BorderStyle = BorderStyle.FixedSingle;
            pnlPriceStock.Controls.Add(lblRetailPrice);
            pnlPriceStock.Controls.Add(txtRetailPrice);
            pnlPriceStock.Controls.Add(lblQuantityOnHand);
            pnlPriceStock.Controls.Add(txtStockQty);
            pnlPriceStock.Location = new Point(265, 210);
            pnlPriceStock.Name = "pnlPriceStock";
            pnlPriceStock.Size = new Size(535, 83);
            pnlPriceStock.TabIndex = 31;
            pnlPriceStock.Paint += pnlPriceStock_Paint;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.BackColor = Color.White;
            btnDeleteProduct.Cursor = Cursors.Hand;
            btnDeleteProduct.FlatAppearance.BorderColor = Color.Red;
            btnDeleteProduct.FlatAppearance.BorderSize = 2;
            btnDeleteProduct.FlatStyle = FlatStyle.Flat;
            btnDeleteProduct.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteProduct.ForeColor = Color.Red;
            btnDeleteProduct.Location = new Point(265, 498);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(214, 38);
            btnDeleteProduct.TabIndex = 32;
            btnDeleteProduct.Text = "🗑DELETE PRODUCT";
            btnDeleteProduct.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Coral;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderColor = Color.Red;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.Black;
            btnCancel.Location = new Point(490, 498);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 38);
            btnCancel.TabIndex = 33;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnUpdateProduct
            // 
            btnUpdateProduct.BackColor = Color.FromArgb(74, 20, 140);
            btnUpdateProduct.Cursor = Cursors.Hand;
            btnUpdateProduct.FlatAppearance.BorderColor = Color.Red;
            btnUpdateProduct.FlatAppearance.BorderSize = 0;
            btnUpdateProduct.FlatStyle = FlatStyle.Flat;
            btnUpdateProduct.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateProduct.ForeColor = Color.White;
            btnUpdateProduct.Location = new Point(601, 498);
            btnUpdateProduct.Name = "btnUpdateProduct";
            btnUpdateProduct.Size = new Size(214, 38);
            btnUpdateProduct.TabIndex = 34;
            btnUpdateProduct.Text = "UPDATE PRODUCT";
            btnUpdateProduct.UseVisualStyleBackColor = false;
            // 
            // lblLastUpdated
            // 
            lblLastUpdated.AutoSize = true;
            lblLastUpdated.Font = new Font("Segoe UI", 8F);
            lblLastUpdated.ForeColor = Color.Gray;
            lblLastUpdated.Location = new Point(20, 560);
            lblLastUpdated.Name = "lblLastUpdated";
            lblLastUpdated.Size = new Size(168, 21);
            lblLastUpdated.TabIndex = 35;
            lblLastUpdated.Text = "Last updated by admin";
            // 
            // lblSystemGuid
            // 
            lblSystemGuid.AutoSize = true;
            lblSystemGuid.Font = new Font("Segoe UI", 8F);
            lblSystemGuid.ForeColor = Color.Gray;
            lblSystemGuid.Location = new Point(671, 560);
            lblSystemGuid.Name = "lblSystemGuid";
            lblSystemGuid.Size = new Size(102, 21);
            lblSystemGuid.TabIndex = 36;
            lblSystemGuid.Text = "System GUID";
            // 
            // EditProductForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Beige;
            ClientSize = new Size(959, 794);
            Controls.Add(pnlMainEditor);
            Controls.Add(lblSubtitle);
            Controls.Add(lblPageTitle);
            Name = "EditProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Product";
            WindowState = FormWindowState.Maximized;
            Load += EditProductForm_Load;
            pnlMainEditor.ResumeLayout(false);
            pnlMainEditor.PerformLayout();
            pnlHeaderStrip.ResumeLayout(false);
            pnlHeaderStrip.PerformLayout();
            pnlProductVisual.ResumeLayout(false);
            pnlProductVisual.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picProductImage).EndInit();
            pnlStockStatus.ResumeLayout(false);
            pnlStockStatus.PerformLayout();
            pnlPriceStock.ResumeLayout(false);
            pnlPriceStock.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPageTitle;
        private Label lblSubtitle;
        private Panel pnlMainEditor;
        private Panel pnlHeaderStrip;
        private Panel pnlProductVisual;
        private Label lblEditorHeader;
        private Label lblProductVisualTitle;
        private Label lblImageInfo;
        private PictureBox picProductImage;
        private Panel pnlStockStatus;
        private Label lblStockStatusPanelTitle;
        private Label lblInventoryAlert;
        private CheckBox chkIsActive;
        private Label lblCatalogStatus;
        private Label lblInventoryAlertText;
        private TextBox txtDescription;
        private Label lblDescriptionTitle;
        private TextBox txtStockQty;
        private Label lblQuantityOnHand;
        private TextBox txtProductName;
        private TextBox txtRetailPrice;
        private Label lblProductNameTitle;
        private Label lblRetailPrice;
        private Label lblCategory;
        private ComboBox cmbGender;
        private Label lblGenderTitle;
        private ComboBox cmbCategory;
        private Panel pnlPriceStock;
        private Button btnDeleteProduct;
        private Button btnCancel;
        private Label lblLastUpdated;
        private Button btnUpdateProduct;
        private Label lblSystemGuid;
    }
}