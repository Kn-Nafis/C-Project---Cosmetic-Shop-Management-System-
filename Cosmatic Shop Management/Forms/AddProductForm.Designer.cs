namespace Cosmatic_Shop_Management.Forms
{
    partial class AddProductForm
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
            pnlHeader = new Panel();
            lblHeaderTitle = new Label();
            lblPreviewTitle = new Label();
            picProductPreview = new PictureBox();
            lblImageHint = new Label();
            btnBrowseImage = new Button();
            lblProductNameTitle = new Label();
            txtProductName = new TextBox();
            lblCategoryTitle = new Label();
            lblProductNameHint = new Label();
            cmbCategory = new ComboBox();
            lblGenderTitle = new Label();
            cmbGender = new ComboBox();
            lblPriceTitle = new Label();
            txtUnitPrice = new TextBox();
            lblInitialStockTitle = new Label();
            txtInitialStock = new TextBox();
            lblDescriptionTitle = new Label();
            txtDescription = new TextBox();
            pnlStatus = new Panel();
            rdoDiscontinued = new RadioButton();
            rdoActive = new RadioButton();
            lblStatusTitle = new Label();
            btnResetForm = new Button();
            btnSaveProduct = new Button();
            btnCancel = new Button();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProductPreview).BeginInit();
            pnlStatus.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(74, 20, 140);
            pnlHeader.Controls.Add(lblHeaderTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(938, 48);
            pnlHeader.TabIndex = 0;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.BackColor = Color.Transparent;
            lblHeaderTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeaderTitle.ForeColor = Color.White;
            lblHeaderTitle.Location = new Point(34, 5);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(411, 30);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "Add New Product — Catalog Manager";
            // 
            // lblPreviewTitle
            // 
            lblPreviewTitle.AutoSize = true;
            lblPreviewTitle.BackColor = Color.Transparent;
            lblPreviewTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPreviewTitle.ForeColor = Color.DimGray;
            lblPreviewTitle.Location = new Point(21, 68);
            lblPreviewTitle.Name = "lblPreviewTitle";
            lblPreviewTitle.Size = new Size(219, 30);
            lblPreviewTitle.TabIndex = 1;
            lblPreviewTitle.Text = "PRODUCT PREVIEW";
            // 
            // picProductPreview
            // 
            picProductPreview.BackColor = Color.WhiteSmoke;
            picProductPreview.BorderStyle = BorderStyle.FixedSingle;
            picProductPreview.Location = new Point(21, 110);
            picProductPreview.Name = "picProductPreview";
            picProductPreview.Size = new Size(250, 250);
            picProductPreview.SizeMode = PictureBoxSizeMode.StretchImage;
            picProductPreview.TabIndex = 2;
            picProductPreview.TabStop = false;
            // 
            // lblImageHint
            // 
            lblImageHint.AutoSize = true;
            lblImageHint.BackColor = Color.Transparent;
            lblImageHint.Font = new Font("Segoe UI", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblImageHint.ForeColor = Color.DarkGray;
            lblImageHint.Location = new Point(21, 388);
            lblImageHint.Name = "lblImageHint";
            lblImageHint.Size = new Size(347, 21);
            lblImageHint.TabIndex = 3;
            lblImageHint.Text = "Allowed formats: JPG, PNG, WEBP. Max size 2MB.";
            // 
            // btnBrowseImage
            // 
            btnBrowseImage.Cursor = Cursors.Hand;
            btnBrowseImage.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBrowseImage.ForeColor = Color.Black;
            btnBrowseImage.Location = new Point(21, 412);
            btnBrowseImage.Name = "btnBrowseImage";
            btnBrowseImage.Size = new Size(164, 48);
            btnBrowseImage.TabIndex = 4;
            btnBrowseImage.Text = "Browse Files";
            btnBrowseImage.UseVisualStyleBackColor = true;
            // 
            // lblProductNameTitle
            // 
            lblProductNameTitle.AutoSize = true;
            lblProductNameTitle.BackColor = Color.Transparent;
            lblProductNameTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductNameTitle.ForeColor = Color.DimGray;
            lblProductNameTitle.Location = new Point(406, 80);
            lblProductNameTitle.Name = "lblProductNameTitle";
            lblProductNameTitle.Size = new Size(204, 30);
            lblProductNameTitle.TabIndex = 5;
            lblProductNameTitle.Text = "PRODUCT NAME *";
            // 
            // txtProductName
            // 
            txtProductName.BackColor = Color.White;
            txtProductName.BorderStyle = BorderStyle.FixedSingle;
            txtProductName.Font = new Font("Segoe UI", 12F);
            txtProductName.Location = new Point(406, 113);
            txtProductName.Name = "txtProductName";
            txtProductName.PlaceholderText = "  e.g Velvet Matte  Lipstic";
            txtProductName.Size = new Size(520, 39);
            txtProductName.TabIndex = 6;
            // 
            // lblCategoryTitle
            // 
            lblCategoryTitle.AutoSize = true;
            lblCategoryTitle.BackColor = Color.Transparent;
            lblCategoryTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoryTitle.ForeColor = Color.DimGray;
            lblCategoryTitle.Location = new Point(406, 191);
            lblCategoryTitle.Name = "lblCategoryTitle";
            lblCategoryTitle.Size = new Size(125, 30);
            lblCategoryTitle.TabIndex = 7;
            lblCategoryTitle.Text = "CATEGORY";
            // 
            // lblProductNameHint
            // 
            lblProductNameHint.AutoSize = true;
            lblProductNameHint.BackColor = Color.Transparent;
            lblProductNameHint.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductNameHint.ForeColor = Color.Firebrick;
            lblProductNameHint.Location = new Point(409, 156);
            lblProductNameHint.Name = "lblProductNameHint";
            lblProductNameHint.Size = new Size(264, 19);
            lblProductNameHint.TabIndex = 8;
            lblProductNameHint.Text = "Name is required and must be unique.";
            // 
            // cmbCategory
            // 
            cmbCategory.BackColor = Color.White;
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Font = new Font("Segoe UI", 11F);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(406, 224);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(182, 38);
            cmbCategory.TabIndex = 9;
            // 
            // lblGenderTitle
            // 
            lblGenderTitle.AutoSize = true;
            lblGenderTitle.BackColor = Color.Transparent;
            lblGenderTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGenderTitle.ForeColor = Color.DimGray;
            lblGenderTitle.Location = new Point(665, 191);
            lblGenderTitle.Name = "lblGenderTitle";
            lblGenderTitle.Size = new Size(187, 30);
            lblGenderTitle.TabIndex = 10;
            lblGenderTitle.Text = "TARGET GENDER";
            // 
            // cmbGender
            // 
            cmbGender.BackColor = Color.White;
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.Font = new Font("Segoe UI", 11F);
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female", "Unisex" });
            cmbGender.Location = new Point(665, 224);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(182, 38);
            cmbGender.TabIndex = 11;
            // 
            // lblPriceTitle
            // 
            lblPriceTitle.AutoSize = true;
            lblPriceTitle.BackColor = Color.Transparent;
            lblPriceTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPriceTitle.ForeColor = Color.DimGray;
            lblPriceTitle.Location = new Point(409, 282);
            lblPriceTitle.Name = "lblPriceTitle";
            lblPriceTitle.Size = new Size(184, 30);
            lblPriceTitle.TabIndex = 12;
            lblPriceTitle.Text = "UNIT PRICE ($) *";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.BackColor = Color.White;
            txtUnitPrice.BorderStyle = BorderStyle.FixedSingle;
            txtUnitPrice.Font = new Font("Segoe UI", 12F);
            txtUnitPrice.Location = new Point(409, 315);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.PlaceholderText = "  e.g 999";
            txtUnitPrice.Size = new Size(182, 39);
            txtUnitPrice.TabIndex = 13;
            // 
            // lblInitialStockTitle
            // 
            lblInitialStockTitle.AutoSize = true;
            lblInitialStockTitle.BackColor = Color.Transparent;
            lblInitialStockTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInitialStockTitle.ForeColor = Color.DimGray;
            lblInitialStockTitle.Location = new Point(665, 282);
            lblInitialStockTitle.Name = "lblInitialStockTitle";
            lblInitialStockTitle.Size = new Size(165, 30);
            lblInitialStockTitle.TabIndex = 14;
            lblInitialStockTitle.Text = "INITIAL STOCK";
            // 
            // txtInitialStock
            // 
            txtInitialStock.BackColor = Color.White;
            txtInitialStock.BorderStyle = BorderStyle.FixedSingle;
            txtInitialStock.Font = new Font("Segoe UI", 12F);
            txtInitialStock.Location = new Point(665, 321);
            txtInitialStock.Name = "txtInitialStock";
            txtInitialStock.PlaceholderText = "  e.g 999";
            txtInitialStock.Size = new Size(182, 39);
            txtInitialStock.TabIndex = 15;
            // 
            // lblDescriptionTitle
            // 
            lblDescriptionTitle.AutoSize = true;
            lblDescriptionTitle.BackColor = Color.Transparent;
            lblDescriptionTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescriptionTitle.ForeColor = Color.DimGray;
            lblDescriptionTitle.Location = new Point(409, 379);
            lblDescriptionTitle.Name = "lblDescriptionTitle";
            lblDescriptionTitle.Size = new Size(156, 30);
            lblDescriptionTitle.TabIndex = 16;
            lblDescriptionTitle.Text = "DESCRIPTION";
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.White;
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Font = new Font("Segoe UI", 12F);
            txtDescription.Location = new Point(406, 412);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "  e.g Velvet Matte  Lipstic";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(520, 103);
            txtDescription.TabIndex = 17;
            // 
            // pnlStatus
            // 
            pnlStatus.BackColor = Color.Cornsilk;
            pnlStatus.BorderStyle = BorderStyle.FixedSingle;
            pnlStatus.Controls.Add(rdoDiscontinued);
            pnlStatus.Controls.Add(rdoActive);
            pnlStatus.Controls.Add(lblStatusTitle);
            pnlStatus.Location = new Point(409, 537);
            pnlStatus.Name = "pnlStatus";
            pnlStatus.Size = new Size(517, 56);
            pnlStatus.TabIndex = 18;
            // 
            // rdoDiscontinued
            // 
            rdoDiscontinued.AutoSize = true;
            rdoDiscontinued.BackColor = Color.Transparent;
            rdoDiscontinued.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdoDiscontinued.ForeColor = Color.DimGray;
            rdoDiscontinued.Location = new Point(336, 10);
            rdoDiscontinued.Name = "rdoDiscontinued";
            rdoDiscontinued.Size = new Size(174, 34);
            rdoDiscontinued.TabIndex = 2;
            rdoDiscontinued.Text = "Discontinued";
            rdoDiscontinued.UseVisualStyleBackColor = false;
            // 
            // rdoActive
            // 
            rdoActive.AutoSize = true;
            rdoActive.BackColor = Color.Transparent;
            rdoActive.Checked = true;
            rdoActive.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdoActive.ForeColor = Color.Black;
            rdoActive.Location = new Point(160, 10);
            rdoActive.Name = "rdoActive";
            rdoActive.Size = new Size(103, 34);
            rdoActive.TabIndex = 1;
            rdoActive.TabStop = true;
            rdoActive.Text = "Active";
            rdoActive.UseVisualStyleBackColor = false;
            // 
            // lblStatusTitle
            // 
            lblStatusTitle.AutoSize = true;
            lblStatusTitle.BackColor = Color.Transparent;
            lblStatusTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatusTitle.ForeColor = Color.DimGray;
            lblStatusTitle.Location = new Point(3, 12);
            lblStatusTitle.Name = "lblStatusTitle";
            lblStatusTitle.Size = new Size(96, 30);
            lblStatusTitle.TabIndex = 0;
            lblStatusTitle.Text = "STATUS:";
            // 
            // btnResetForm
            // 
            btnResetForm.BackColor = Color.White;
            btnResetForm.Cursor = Cursors.Hand;
            btnResetForm.FlatAppearance.BorderColor = Color.Silver;
            btnResetForm.FlatStyle = FlatStyle.Flat;
            btnResetForm.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResetForm.ForeColor = Color.FromArgb(74, 20, 140);
            btnResetForm.Location = new Point(409, 599);
            btnResetForm.Name = "btnResetForm";
            btnResetForm.Size = new Size(156, 43);
            btnResetForm.TabIndex = 19;
            btnResetForm.Text = "RESET FORM";
            btnResetForm.UseVisualStyleBackColor = false;
            // 
            // btnSaveProduct
            // 
            btnSaveProduct.BackColor = Color.Coral;
            btnSaveProduct.Cursor = Cursors.Hand;
            btnSaveProduct.FlatAppearance.BorderColor = Color.Silver;
            btnSaveProduct.FlatAppearance.BorderSize = 0;
            btnSaveProduct.FlatStyle = FlatStyle.Flat;
            btnSaveProduct.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveProduct.ForeColor = Color.White;
            btnSaveProduct.Location = new Point(591, 599);
            btnSaveProduct.Name = "btnSaveProduct";
            btnSaveProduct.Size = new Size(192, 43);
            btnSaveProduct.TabIndex = 20;
            btnSaveProduct.Text = "SAVE PRODUCT";
            btnSaveProduct.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(74, 20, 140);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.FromArgb(74, 20, 140);
            btnCancel.Location = new Point(812, 599);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 43);
            btnCancel.TabIndex = 21;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(938, 651);
            Controls.Add(btnCancel);
            Controls.Add(btnSaveProduct);
            Controls.Add(btnResetForm);
            Controls.Add(pnlStatus);
            Controls.Add(txtDescription);
            Controls.Add(lblDescriptionTitle);
            Controls.Add(txtInitialStock);
            Controls.Add(lblInitialStockTitle);
            Controls.Add(txtUnitPrice);
            Controls.Add(lblPriceTitle);
            Controls.Add(cmbGender);
            Controls.Add(lblGenderTitle);
            Controls.Add(cmbCategory);
            Controls.Add(lblProductNameHint);
            Controls.Add(lblCategoryTitle);
            Controls.Add(txtProductName);
            Controls.Add(lblProductNameTitle);
            Controls.Add(btnBrowseImage);
            Controls.Add(lblImageHint);
            Controls.Add(picProductPreview);
            Controls.Add(lblPreviewTitle);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddProductForm";
            Load += AddProductForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picProductPreview).EndInit();
            pnlStatus.ResumeLayout(false);
            pnlStatus.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblHeaderTitle;
        private Label lblPreviewTitle;
        private PictureBox picProductPreview;
        private Label lblImageHint;
        private Button btnBrowseImage;
        private Label lblProductNameTitle;
        private TextBox txtProductName;
        private Label lblCategoryTitle;
        private Label lblProductNameHint;
        private ComboBox cmbCategory;
        private Label lblGenderTitle;
        private ComboBox cmbGender;
        private Label lblPriceTitle;
        private TextBox txtUnitPrice;
        private Label lblInitialStockTitle;
        private TextBox txtInitialStock;
        private Label lblDescriptionTitle;
        private TextBox txtDescription;
        private Panel pnlStatus;
        private RadioButton rdoDiscontinued;
        private RadioButton rdoActive;
        private Label lblStatusTitle;
        private Button btnResetForm;
        private Button btnSaveProduct;
        private Button btnCancel;
    }
}