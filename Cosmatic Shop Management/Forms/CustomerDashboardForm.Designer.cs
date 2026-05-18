namespace Cosmatic_Shop_Management.Forms
{
    partial class CustomerDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDashboardForm));
            lblBrandText = new Label();
            btnCart = new Button();
            txtSearchProducts = new TextBox();
            pnlTopHeader = new Panel();
            btnLogout = new Button();
            btnProfile = new Button();
            btnWishlist = new Button();
            lnkBoutique = new LinkLabel();
            lnkBestSellers = new LinkLabel();
            lnkNewArrivals = new LinkLabel();
            lnkCollections = new LinkLabel();
            pnlHeroBanner = new Panel();
            btnShopCollection = new Button();
            lblHeroTitle = new Label();
            blHeroTag = new Label();
            lnkMaleBrowse = new LinkLabel();
            lblMaleSubtitle = new Label();
            lblMaleTitle = new Label();
            lnkFemaleBrowse = new LinkLabel();
            lblFemaleSubtitle = new Label();
            lblFemaleTitle = new Label();
            lblHighlightedProductsTitle = new Label();
            lblHighlightedProductsSubtitle = new Label();
            btnFilterView = new Button();
            btnGridView = new Button();
            flpHighlightedProducts = new FlowLayoutPanel();
            pnlMaleSection = new Panel();
            pnlFemaleSection = new Panel();
            pnlTopHeader.SuspendLayout();
            pnlHeroBanner.SuspendLayout();
            pnlMaleSection.SuspendLayout();
            pnlFemaleSection.SuspendLayout();
            SuspendLayout();
            // 
            // lblBrandText
            // 
            lblBrandText.AutoSize = true;
            lblBrandText.BackColor = Color.Transparent;
            lblBrandText.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblBrandText.ForeColor = Color.Black;
            lblBrandText.Location = new Point(77, 26);
            lblBrandText.Name = "lblBrandText";
            lblBrandText.Size = new Size(230, 45);
            lblBrandText.TabIndex = 0;
            lblBrandText.Text = "Glow and  Co.";
            // 
            // btnCart
            // 
            btnCart.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCart.BackColor = Color.White;
            btnCart.Cursor = Cursors.Hand;
            btnCart.FlatAppearance.BorderSize = 0;
            btnCart.FlatStyle = FlatStyle.Flat;
            btnCart.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCart.ForeColor = Color.Black;
            btnCart.Image = (Image)resources.GetObject("btnCart.Image");
            btnCart.Location = new Point(1094, 23);
            btnCart.Margin = new Padding(0);
            btnCart.Name = "btnCart";
            btnCart.Size = new Size(60, 60);
            btnCart.TabIndex = 1;
            btnCart.UseVisualStyleBackColor = false;
            // 
            // txtSearchProducts
            // 
            txtSearchProducts.Anchor = AnchorStyles.Top;
            txtSearchProducts.BackColor = Color.WhiteSmoke;
            txtSearchProducts.BorderStyle = BorderStyle.FixedSingle;
            txtSearchProducts.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchProducts.ForeColor = Color.DimGray;
            txtSearchProducts.Location = new Point(294, 21);
            txtSearchProducts.Multiline = true;
            txtSearchProducts.Name = "txtSearchProducts";
            txtSearchProducts.PlaceholderText = "  🔍︎Search products";
            txtSearchProducts.Size = new Size(319, 46);
            txtSearchProducts.TabIndex = 3;
            // 
            // pnlTopHeader
            // 
            pnlTopHeader.BackColor = Color.White;
            pnlTopHeader.BorderStyle = BorderStyle.FixedSingle;
            pnlTopHeader.Controls.Add(btnLogout);
            pnlTopHeader.Controls.Add(btnProfile);
            pnlTopHeader.Controls.Add(btnWishlist);
            pnlTopHeader.Controls.Add(lnkBoutique);
            pnlTopHeader.Controls.Add(lnkBestSellers);
            pnlTopHeader.Controls.Add(lnkNewArrivals);
            pnlTopHeader.Controls.Add(lnkCollections);
            pnlTopHeader.Controls.Add(lblBrandText);
            pnlTopHeader.Controls.Add(txtSearchProducts);
            pnlTopHeader.Controls.Add(btnCart);
            pnlTopHeader.Dock = DockStyle.Top;
            pnlTopHeader.Location = new Point(0, 0);
            pnlTopHeader.Margin = new Padding(0);
            pnlTopHeader.Name = "pnlTopHeader";
            pnlTopHeader.Size = new Size(1400, 93);
            pnlTopHeader.TabIndex = 9;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogout.BackColor = Color.White;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.Black;
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.Location = new Point(1291, 23);
            btnLogout.Margin = new Padding(0);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(60, 60);
            btnLogout.TabIndex = 10;
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnProfile
            // 
            btnProfile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnProfile.BackColor = Color.White;
            btnProfile.Cursor = Cursors.Hand;
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProfile.ForeColor = Color.Black;
            btnProfile.Image = (Image)resources.GetObject("btnProfile.Image");
            btnProfile.Location = new Point(1169, 21);
            btnProfile.Margin = new Padding(0);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(60, 60);
            btnProfile.TabIndex = 9;
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnWishlist
            // 
            btnWishlist.Anchor = AnchorStyles.Top;
            btnWishlist.BackColor = Color.White;
            btnWishlist.Cursor = Cursors.Hand;
            btnWishlist.FlatAppearance.BorderSize = 0;
            btnWishlist.FlatStyle = FlatStyle.Flat;
            btnWishlist.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnWishlist.ForeColor = Color.Black;
            btnWishlist.Image = (Image)resources.GetObject("btnWishlist.Image");
            btnWishlist.Location = new Point(1169, 22);
            btnWishlist.Margin = new Padding(0);
            btnWishlist.Name = "btnWishlist";
            btnWishlist.Size = new Size(60, 60);
            btnWishlist.TabIndex = 8;
            btnWishlist.UseVisualStyleBackColor = false;
            btnWishlist.Visible = false;
            // 
            // lnkBoutique
            // 
            lnkBoutique.ActiveLinkColor = Color.Purple;
            lnkBoutique.AutoSize = true;
            lnkBoutique.BackColor = Color.Transparent;
            lnkBoutique.Font = new Font("Segoe UI", 9F);
            lnkBoutique.LinkColor = Color.DarkGray;
            lnkBoutique.Location = new Point(972, 43);
            lnkBoutique.Name = "lnkBoutique";
            lnkBoutique.Size = new Size(83, 25);
            lnkBoutique.TabIndex = 7;
            lnkBoutique.TabStop = true;
            lnkBoutique.Text = "Boutique";
            lnkBoutique.Visible = false;
            lnkBoutique.VisitedLinkColor = Color.LightGray;
            // 
            // lnkBestSellers
            // 
            lnkBestSellers.ActiveLinkColor = Color.Purple;
            lnkBestSellers.AutoSize = true;
            lnkBestSellers.BackColor = Color.Transparent;
            lnkBestSellers.Font = new Font("Segoe UI", 9F);
            lnkBestSellers.LinkColor = Color.DarkGray;
            lnkBestSellers.Location = new Point(866, 43);
            lnkBestSellers.Name = "lnkBestSellers";
            lnkBestSellers.Size = new Size(100, 25);
            lnkBestSellers.TabIndex = 6;
            lnkBestSellers.TabStop = true;
            lnkBestSellers.Text = "Best Sellers";
            lnkBestSellers.Visible = false;
            lnkBestSellers.VisitedLinkColor = Color.LightGray;
            // 
            // lnkNewArrivals
            // 
            lnkNewArrivals.ActiveLinkColor = Color.Purple;
            lnkNewArrivals.AutoSize = true;
            lnkNewArrivals.BackColor = Color.Transparent;
            lnkNewArrivals.Font = new Font("Segoe UI", 9F);
            lnkNewArrivals.LinkColor = Color.DarkGray;
            lnkNewArrivals.Location = new Point(750, 43);
            lnkNewArrivals.Name = "lnkNewArrivals";
            lnkNewArrivals.Size = new Size(110, 25);
            lnkNewArrivals.TabIndex = 5;
            lnkNewArrivals.TabStop = true;
            lnkNewArrivals.Text = "New Arrivals";
            lnkNewArrivals.Visible = false;
            lnkNewArrivals.VisitedLinkColor = Color.LightGray;
            // 
            // lnkCollections
            // 
            lnkCollections.ActiveLinkColor = Color.Purple;
            lnkCollections.AutoSize = true;
            lnkCollections.BackColor = Color.Transparent;
            lnkCollections.Font = new Font("Segoe UI", 9F);
            lnkCollections.LinkColor = Color.DarkGray;
            lnkCollections.Location = new Point(646, 42);
            lnkCollections.Name = "lnkCollections";
            lnkCollections.Size = new Size(98, 25);
            lnkCollections.TabIndex = 4;
            lnkCollections.TabStop = true;
            lnkCollections.Text = "Collections";
            lnkCollections.Visible = false;
            lnkCollections.VisitedLinkColor = Color.LightGray;
            // 
            // pnlHeroBanner
            // 
            pnlHeroBanner.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlHeroBanner.BackColor = Color.FromArgb(1, 22, 39);
            pnlHeroBanner.BorderStyle = BorderStyle.FixedSingle;
            pnlHeroBanner.Controls.Add(btnShopCollection);
            pnlHeroBanner.Controls.Add(lblHeroTitle);
            pnlHeroBanner.Controls.Add(blHeroTag);
            pnlHeroBanner.Location = new Point(85, 118);
            pnlHeroBanner.Name = "pnlHeroBanner";
            pnlHeroBanner.Size = new Size(1232, 333);
            pnlHeroBanner.TabIndex = 10;
            // 
            // btnShopCollection
            // 
            btnShopCollection.BackColor = Color.Coral;
            btnShopCollection.Cursor = Cursors.Hand;
            btnShopCollection.FlatAppearance.BorderSize = 0;
            btnShopCollection.FlatStyle = FlatStyle.Flat;
            btnShopCollection.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShopCollection.ForeColor = Color.White;
            btnShopCollection.Location = new Point(26, 218);
            btnShopCollection.Name = "btnShopCollection";
            btnShopCollection.Size = new Size(222, 40);
            btnShopCollection.TabIndex = 2;
            btnShopCollection.Text = "Shop Collection";
            btnShopCollection.UseVisualStyleBackColor = false;
            // 
            // lblHeroTitle
            // 
            lblHeroTitle.AutoSize = true;
            lblHeroTitle.BackColor = Color.Transparent;
            lblHeroTitle.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeroTitle.ForeColor = Color.White;
            lblHeroTitle.Location = new Point(23, 128);
            lblHeroTitle.Name = "lblHeroTitle";
            lblHeroTitle.Size = new Size(782, 74);
            lblHeroTitle.TabIndex = 1;
            lblHeroTitle.Text = "Luminous Bloom: New Arrivals";
            // 
            // blHeroTag
            // 
            blHeroTag.AutoSize = true;
            blHeroTag.BackColor = Color.DimGray;
            blHeroTag.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            blHeroTag.ForeColor = Color.White;
            blHeroTag.Location = new Point(26, 100);
            blHeroTag.Name = "blHeroTag";
            blHeroTag.Size = new Size(175, 28);
            blHeroTag.TabIndex = 0;
            blHeroTag.Text = "SEASONAL DROP";
            // 
            // lnkMaleBrowse
            // 
            lnkMaleBrowse.ActiveLinkColor = Color.Silver;
            lnkMaleBrowse.AutoSize = true;
            lnkMaleBrowse.BackColor = Color.Transparent;
            lnkMaleBrowse.ForeColor = SystemColors.ButtonFace;
            lnkMaleBrowse.LinkColor = Color.Black;
            lnkMaleBrowse.Location = new Point(78, 149);
            lnkMaleBrowse.Name = "lnkMaleBrowse";
            lnkMaleBrowse.Size = new Size(112, 25);
            lnkMaleBrowse.TabIndex = 3;
            lnkMaleBrowse.TabStop = true;
            lnkMaleBrowse.Text = "Male Browse";
            // 
            // lblMaleSubtitle
            // 
            lblMaleSubtitle.AutoSize = true;
            lblMaleSubtitle.BackColor = Color.Transparent;
            lblMaleSubtitle.Font = new Font("Segoe UI", 14F);
            lblMaleSubtitle.ForeColor = Color.Black;
            lblMaleSubtitle.Location = new Point(64, 64);
            lblMaleSubtitle.Name = "lblMaleSubtitle";
            lblMaleSubtitle.Size = new Size(258, 38);
            lblMaleSubtitle.TabIndex = 2;
            lblMaleSubtitle.Text = "Modern Gentleman";
            // 
            // lblMaleTitle
            // 
            lblMaleTitle.AutoSize = true;
            lblMaleTitle.BackColor = Color.Transparent;
            lblMaleTitle.Font = new Font("Segoe UI", 10F);
            lblMaleTitle.ForeColor = Color.Black;
            lblMaleTitle.Location = new Point(78, 102);
            lblMaleTitle.Name = "lblMaleTitle";
            lblMaleTitle.Size = new Size(0, 28);
            lblMaleTitle.TabIndex = 1;
            // 
            // lnkFemaleBrowse
            // 
            lnkFemaleBrowse.ActiveLinkColor = Color.Black;
            lnkFemaleBrowse.AutoSize = true;
            lnkFemaleBrowse.BackColor = Color.Transparent;
            lnkFemaleBrowse.ForeColor = SystemColors.ButtonFace;
            lnkFemaleBrowse.LinkColor = Color.Black;
            lnkFemaleBrowse.Location = new Point(98, 149);
            lnkFemaleBrowse.Name = "lnkFemaleBrowse";
            lnkFemaleBrowse.Size = new Size(130, 25);
            lnkFemaleBrowse.TabIndex = 3;
            lnkFemaleBrowse.TabStop = true;
            lnkFemaleBrowse.Text = "Female Browse";
            lnkFemaleBrowse.VisitedLinkColor = Color.DimGray;
            // 
            // lblFemaleSubtitle
            // 
            lblFemaleSubtitle.AutoSize = true;
            lblFemaleSubtitle.BackColor = Color.Transparent;
            lblFemaleSubtitle.Font = new Font("Segoe UI", 14F);
            lblFemaleSubtitle.ForeColor = Color.Black;
            lblFemaleSubtitle.Location = new Point(85, 64);
            lblFemaleSubtitle.Name = "lblFemaleSubtitle";
            lblFemaleSubtitle.Size = new Size(177, 38);
            lblFemaleSubtitle.TabIndex = 2;
            lblFemaleSubtitle.Text = "Radiant Rose";
            // 
            // lblFemaleTitle
            // 
            lblFemaleTitle.AutoSize = true;
            lblFemaleTitle.BackColor = Color.Transparent;
            lblFemaleTitle.Font = new Font("Segoe UI", 10F);
            lblFemaleTitle.ForeColor = Color.Black;
            lblFemaleTitle.Location = new Point(98, 102);
            lblFemaleTitle.Name = "lblFemaleTitle";
            lblFemaleTitle.Size = new Size(0, 28);
            lblFemaleTitle.TabIndex = 1;
            // 
            // lblHighlightedProductsTitle
            // 
            lblHighlightedProductsTitle.AutoSize = true;
            lblHighlightedProductsTitle.BackColor = Color.Transparent;
            lblHighlightedProductsTitle.Font = new Font("Segoe UI", 16F);
            lblHighlightedProductsTitle.ForeColor = Color.Black;
            lblHighlightedProductsTitle.Location = new Point(85, 865);
            lblHighlightedProductsTitle.Name = "lblHighlightedProductsTitle";
            lblHighlightedProductsTitle.Size = new Size(154, 45);
            lblHighlightedProductsTitle.TabIndex = 13;
            lblHighlightedProductsTitle.Text = " Products";
            // 
            // lblHighlightedProductsSubtitle
            // 
            lblHighlightedProductsSubtitle.AutoSize = true;
            lblHighlightedProductsSubtitle.BackColor = Color.Transparent;
            lblHighlightedProductsSubtitle.Font = new Font("Segoe UI", 11F);
            lblHighlightedProductsSubtitle.ForeColor = Color.DimGray;
            lblHighlightedProductsSubtitle.Location = new Point(334, 887);
            lblHighlightedProductsSubtitle.Name = "lblHighlightedProductsSubtitle";
            lblHighlightedProductsSubtitle.Size = new Size(0, 30);
            lblHighlightedProductsSubtitle.TabIndex = 14;
            // 
            // btnFilterView
            // 
            btnFilterView.Anchor = AnchorStyles.None;
            btnFilterView.BackColor = Color.White;
            btnFilterView.Cursor = Cursors.Hand;
            btnFilterView.FlatAppearance.BorderSize = 0;
            btnFilterView.FlatStyle = FlatStyle.Flat;
            btnFilterView.Image = (Image)resources.GetObject("btnFilterView.Image");
            btnFilterView.Location = new Point(1231, 907);
            btnFilterView.Name = "btnFilterView";
            btnFilterView.Size = new Size(40, 40);
            btnFilterView.TabIndex = 15;
            btnFilterView.UseVisualStyleBackColor = false;
            btnFilterView.Visible = false;
            // 
            // btnGridView
            // 
            btnGridView.Anchor = AnchorStyles.None;
            btnGridView.BackColor = Color.White;
            btnGridView.Cursor = Cursors.Hand;
            btnGridView.FlatAppearance.BorderSize = 0;
            btnGridView.FlatStyle = FlatStyle.Flat;
            btnGridView.Image = (Image)resources.GetObject("btnGridView.Image");
            btnGridView.Location = new Point(1277, 903);
            btnGridView.Name = "btnGridView";
            btnGridView.Size = new Size(40, 40);
            btnGridView.TabIndex = 16;
            btnGridView.UseVisualStyleBackColor = false;
            btnGridView.Visible = false;
            // 
            // flpHighlightedProducts
            // 
            flpHighlightedProducts.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flpHighlightedProducts.AutoScroll = true;
            flpHighlightedProducts.BackColor = Color.White;
            flpHighlightedProducts.Location = new Point(102, 934);
            flpHighlightedProducts.Name = "flpHighlightedProducts";
            flpHighlightedProducts.Size = new Size(1169, 236);
            flpHighlightedProducts.TabIndex = 17;
            // 
            // pnlMaleSection
            // 
            pnlMaleSection.Anchor = AnchorStyles.None;
            pnlMaleSection.BackgroundImage = (Image)resources.GetObject("pnlMaleSection.BackgroundImage");
            pnlMaleSection.BackgroundImageLayout = ImageLayout.Zoom;
            pnlMaleSection.Controls.Add(lnkMaleBrowse);
            pnlMaleSection.Controls.Add(lblMaleTitle);
            pnlMaleSection.Controls.Add(lblMaleSubtitle);
            pnlMaleSection.Location = new Point(85, 457);
            pnlMaleSection.Name = "pnlMaleSection";
            pnlMaleSection.Size = new Size(600, 400);
            pnlMaleSection.TabIndex = 18;
            // 
            // pnlFemaleSection
            // 
            pnlFemaleSection.Anchor = AnchorStyles.None;
            pnlFemaleSection.BackgroundImage = (Image)resources.GetObject("pnlFemaleSection.BackgroundImage");
            pnlFemaleSection.BackgroundImageLayout = ImageLayout.Zoom;
            pnlFemaleSection.Controls.Add(lnkFemaleBrowse);
            pnlFemaleSection.Controls.Add(lblFemaleTitle);
            pnlFemaleSection.Controls.Add(lblFemaleSubtitle);
            pnlFemaleSection.Location = new Point(717, 457);
            pnlFemaleSection.Name = "pnlFemaleSection";
            pnlFemaleSection.Size = new Size(600, 400);
            pnlFemaleSection.TabIndex = 19;
            // 
            // CustomerDashboardForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(1400, 1170);
            Controls.Add(pnlFemaleSection);
            Controls.Add(pnlMaleSection);
            Controls.Add(flpHighlightedProducts);
            Controls.Add(btnGridView);
            Controls.Add(btnFilterView);
            Controls.Add(lblHighlightedProductsSubtitle);
            Controls.Add(lblHighlightedProductsTitle);
            Controls.Add(pnlHeroBanner);
            Controls.Add(pnlTopHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "CustomerDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerDashboardForm";
            WindowState = FormWindowState.Maximized;
            Load += CustomerDashboardForm_Load;
            pnlTopHeader.ResumeLayout(false);
            pnlTopHeader.PerformLayout();
            pnlHeroBanner.ResumeLayout(false);
            pnlHeroBanner.PerformLayout();
            pnlMaleSection.ResumeLayout(false);
            pnlMaleSection.PerformLayout();
            pnlFemaleSection.ResumeLayout(false);
            pnlFemaleSection.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBrandText;
        private Button btnCart;
        private TextBox txtSearchProducts;
        private Panel pnlTopHeader;
        private LinkLabel lnkBoutique;
        private LinkLabel lnkBestSellers;
        private LinkLabel lnkNewArrivals;
        private LinkLabel lnkCollections;
        private Button btnWishlist;
        private Button btnProfile;
        private Button btnLogout;
        private Panel pnlHeroBanner;
        private Label blHeroTag;
        private Button btnShopCollection;
        private Label lblHeroTitle;
        private Label lblMaleTitle;
        private LinkLabel lnkMaleBrowse;
        private Label lblMaleSubtitle;
        private LinkLabel lnkFemaleBrowse;
        private Label lblFemaleSubtitle;
        private Label lblFemaleTitle;
        private Label lblHighlightedProductsTitle;
        private Label lblHighlightedProductsSubtitle;
        private Button btnFilterView;
        private Button btnGridView;
        private FlowLayoutPanel flpHighlightedProducts;
        private Panel pnlMaleSection;
        private Panel pnlFemaleSection;
    }
}