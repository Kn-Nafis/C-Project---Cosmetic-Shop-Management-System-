namespace Cosmatic_Shop_Management.Forms
{
    partial class ProductDetailsForm
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
            pnlImageSection = new Panel();
            picProductImage = new PictureBox();
            label1 = new Label();
            pnlDetailsSection = new Panel();
            flpReviews = new FlowLayoutPanel();
            lblReviewCount = new Label();
            lblAverageRating = new Label();
            btnBuyNow = new Button();
            btnAddToCart = new Button();
            nudQuantity = new NumericUpDown();
            lblDescription = new Label();
            lblStock = new Label();
            lblGender = new Label();
            lblCategory = new Label();
            lblShopName = new Label();
            lblPrice = new Label();
            lblProductName = new Label();
            btnGoBack = new Button();
            pnlImageSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProductImage).BeginInit();
            pnlDetailsSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            SuspendLayout();
            // 
            // pnlImageSection
            // 
            pnlImageSection.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlImageSection.BackColor = Color.Snow;
            pnlImageSection.Controls.Add(picProductImage);
            pnlImageSection.Location = new Point(83, 155);
            pnlImageSection.Name = "pnlImageSection";
            pnlImageSection.Size = new Size(424, 848);
            pnlImageSection.TabIndex = 0;
            // 
            // picProductImage
            // 
            picProductImage.Dock = DockStyle.Fill;
            picProductImage.Location = new Point(0, 0);
            picProductImage.Name = "picProductImage";
            picProductImage.Size = new Size(424, 848);
            picProductImage.TabIndex = 0;
            picProductImage.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(74, 20, 140);
            label1.Location = new Point(172, 12);
            label1.Name = "label1";
            label1.Size = new Size(294, 48);
            label1.TabIndex = 1;
            label1.Text = "Products Details";
            // 
            // pnlDetailsSection
            // 
            pnlDetailsSection.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlDetailsSection.BackColor = Color.Beige;
            pnlDetailsSection.Controls.Add(flpReviews);
            pnlDetailsSection.Controls.Add(lblReviewCount);
            pnlDetailsSection.Controls.Add(lblAverageRating);
            pnlDetailsSection.Controls.Add(btnBuyNow);
            pnlDetailsSection.Controls.Add(btnAddToCart);
            pnlDetailsSection.Controls.Add(nudQuantity);
            pnlDetailsSection.Controls.Add(lblDescription);
            pnlDetailsSection.Controls.Add(lblStock);
            pnlDetailsSection.Controls.Add(lblGender);
            pnlDetailsSection.Controls.Add(lblCategory);
            pnlDetailsSection.Controls.Add(lblShopName);
            pnlDetailsSection.Controls.Add(lblPrice);
            pnlDetailsSection.Controls.Add(lblProductName);
            pnlDetailsSection.Location = new Point(540, 110);
            pnlDetailsSection.Name = "pnlDetailsSection";
            pnlDetailsSection.Size = new Size(837, 893);
            pnlDetailsSection.TabIndex = 1;
            // 
            // flpReviews
            // 
            flpReviews.AutoScroll = true;
            flpReviews.Location = new Point(69, 597);
            flpReviews.Name = "flpReviews";
            flpReviews.Size = new Size(721, 206);
            flpReviews.TabIndex = 12;
            // 
            // lblReviewCount
            // 
            lblReviewCount.AutoSize = true;
            lblReviewCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReviewCount.ForeColor = Color.FromArgb(74, 20, 140);
            lblReviewCount.Location = new Point(52, 538);
            lblReviewCount.Name = "lblReviewCount";
            lblReviewCount.Size = new Size(129, 25);
            lblReviewCount.TabIndex = 11;
            lblReviewCount.Text = "Review Count";
            // 
            // lblAverageRating
            // 
            lblAverageRating.AutoSize = true;
            lblAverageRating.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAverageRating.ForeColor = Color.FromArgb(74, 20, 140);
            lblAverageRating.Location = new Point(580, 538);
            lblAverageRating.Name = "lblAverageRating";
            lblAverageRating.Size = new Size(144, 25);
            lblAverageRating.TabIndex = 10;
            lblAverageRating.Text = "Average Rating";
            // 
            // btnBuyNow
            // 
            btnBuyNow.BackColor = Color.Snow;
            btnBuyNow.FlatAppearance.BorderColor = Color.FromArgb(74, 20, 140);
            btnBuyNow.FlatAppearance.BorderSize = 3;
            btnBuyNow.FlatStyle = FlatStyle.Popup;
            btnBuyNow.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuyNow.ForeColor = Color.FromArgb(74, 20, 140);
            btnBuyNow.Location = new Point(443, 464);
            btnBuyNow.Margin = new Padding(0);
            btnBuyNow.Name = "btnBuyNow";
            btnBuyNow.Size = new Size(167, 46);
            btnBuyNow.TabIndex = 9;
            btnBuyNow.Text = "Buy Now";
            btnBuyNow.UseVisualStyleBackColor = false;
            // 
            // btnAddToCart
            // 
            btnAddToCart.BackColor = Color.Coral;
            btnAddToCart.FlatStyle = FlatStyle.Flat;
            btnAddToCart.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddToCart.ForeColor = Color.FromArgb(74, 20, 140);
            btnAddToCart.Location = new Point(270, 464);
            btnAddToCart.Margin = new Padding(0);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(167, 46);
            btnAddToCart.TabIndex = 8;
            btnAddToCart.Text = "\U0001f6d2Add To Cart";
            btnAddToCart.UseVisualStyleBackColor = false;
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(69, 464);
            nudQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(145, 31);
            nudQuantity.TabIndex = 7;
            nudQuantity.TextAlign = HorizontalAlignment.Center;
            nudQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescription.ForeColor = Color.FromArgb(74, 20, 140);
            lblDescription.Location = new Point(52, 286);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(109, 25);
            lblDescription.TabIndex = 6;
            lblDescription.Text = "Description";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStock.ForeColor = Color.FromArgb(74, 20, 140);
            lblStock.Location = new Point(472, 193);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(181, 28);
            lblStock.TabIndex = 5;
            lblStock.Text = "Current Inventory";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblGender.ForeColor = Color.FromArgb(74, 20, 140);
            lblGender.Location = new Point(472, 143);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(80, 28);
            lblGender.TabIndex = 4;
            lblGender.Text = "Gender";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCategory.ForeColor = Color.FromArgb(74, 20, 140);
            lblCategory.Location = new Point(52, 193);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(98, 28);
            lblCategory.TabIndex = 3;
            lblCategory.Text = "Catagory";
            // 
            // lblShopName
            // 
            lblShopName.AutoSize = true;
            lblShopName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblShopName.ForeColor = Color.FromArgb(74, 20, 140);
            lblShopName.Location = new Point(52, 143);
            lblShopName.Name = "lblShopName";
            lblShopName.Size = new Size(68, 28);
            lblShopName.TabIndex = 2;
            lblShopName.Text = "Brand";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = Color.FromArgb(74, 20, 140);
            lblPrice.Location = new Point(484, 52);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(94, 45);
            lblPrice.TabIndex = 1;
            lblPrice.Text = "Price";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblProductName.ForeColor = Color.FromArgb(74, 20, 140);
            lblProductName.Location = new Point(42, 49);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(119, 48);
            lblProductName.TabIndex = 0;
            lblProductName.Text = "Name";
            lblProductName.Click += label2_Click;
            // 
            // btnGoBack
            // 
            btnGoBack.BackColor = Color.Coral;
            btnGoBack.FlatStyle = FlatStyle.Flat;
            btnGoBack.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGoBack.Location = new Point(12, 12);
            btnGoBack.Name = "btnGoBack";
            btnGoBack.Size = new Size(134, 45);
            btnGoBack.TabIndex = 3;
            btnGoBack.Text = "⇦ Go Back";
            btnGoBack.UseVisualStyleBackColor = false;
            // 
            // ProductDetailsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1427, 1047);
            Controls.Add(btnGoBack);
            Controls.Add(pnlDetailsSection);
            Controls.Add(label1);
            Controls.Add(pnlImageSection);
            Name = "ProductDetailsForm";
            Text = "ProductDetailsForm";
            WindowState = FormWindowState.Maximized;
            Load += ProductDetailsForm_Load_1;
            pnlImageSection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picProductImage).EndInit();
            pnlDetailsSection.ResumeLayout(false);
            pnlDetailsSection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlImageSection;
        private Label label1;
        private PictureBox picProductImage;
        private Panel pnlDetailsSection;
        private Label lblProductName;
        private Label lblShopName;
        private Label lblPrice;
        private Label lblDescription;
        private Label lblStock;
        private Label lblGender;
        private Label lblCategory;
        private Button btnAddToCart;
        private NumericUpDown nudQuantity;
        private Button btnBuyNow;
        private FlowLayoutPanel flpReviews;
        private Label lblReviewCount;
        private Label lblAverageRating;
        private Button btnGoBack;
    }
}