namespace Cosmatic_Shop_Management.Forms
{
    partial class ReviewForm
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
            lblReviewTitle = new Label();
            pnlReviewProduct = new Panel();
            lblProductName = new Label();
            picReviewProduct = new PictureBox();
            lblRatingTitle = new Label();
            cmbRating = new ComboBox();
            lblReviewTextTitle = new Label();
            txtReviewText = new TextBox();
            chkPublish = new CheckBox();
            chkVerifiedPurchase = new CheckBox();
            btnCancel = new Button();
            btnSubmitReview = new Button();
            pnlReviewProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picReviewProduct).BeginInit();
            SuspendLayout();
            // 
            // lblReviewTitle
            // 
            lblReviewTitle.AutoSize = true;
            lblReviewTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReviewTitle.ForeColor = Color.FromArgb(74, 20, 140);
            lblReviewTitle.Location = new Point(12, 9);
            lblReviewTitle.Name = "lblReviewTitle";
            lblReviewTitle.Size = new Size(289, 45);
            lblReviewTitle.TabIndex = 0;
            lblReviewTitle.Text = "Product Feedback";
            // 
            // pnlReviewProduct
            // 
            pnlReviewProduct.BackColor = Color.Beige;
            pnlReviewProduct.BorderStyle = BorderStyle.FixedSingle;
            pnlReviewProduct.Controls.Add(lblProductName);
            pnlReviewProduct.Controls.Add(picReviewProduct);
            pnlReviewProduct.Location = new Point(26, 76);
            pnlReviewProduct.Name = "pnlReviewProduct";
            pnlReviewProduct.Size = new Size(743, 243);
            pnlReviewProduct.TabIndex = 1;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductName.ForeColor = Color.FromArgb(74, 20, 140);
            lblProductName.Location = new Point(241, 27);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(96, 30);
            lblProductName.TabIndex = 1;
            lblProductName.Text = "Product";
            // 
            // picReviewProduct
            // 
            picReviewProduct.BorderStyle = BorderStyle.FixedSingle;
            picReviewProduct.Location = new Point(23, 21);
            picReviewProduct.Name = "picReviewProduct";
            picReviewProduct.Size = new Size(190, 199);
            picReviewProduct.SizeMode = PictureBoxSizeMode.StretchImage;
            picReviewProduct.TabIndex = 0;
            picReviewProduct.TabStop = false;
            // 
            // lblRatingTitle
            // 
            lblRatingTitle.AutoSize = true;
            lblRatingTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRatingTitle.ForeColor = Color.FromArgb(74, 20, 140);
            lblRatingTitle.Location = new Point(26, 331);
            lblRatingTitle.Name = "lblRatingTitle";
            lblRatingTitle.Size = new Size(68, 25);
            lblRatingTitle.TabIndex = 2;
            lblRatingTitle.Text = "Rating";
            // 
            // cmbRating
            // 
            cmbRating.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRating.FlatStyle = FlatStyle.Flat;
            cmbRating.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbRating.FormattingEnabled = true;
            cmbRating.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cmbRating.Location = new Point(26, 359);
            cmbRating.Name = "cmbRating";
            cmbRating.Size = new Size(182, 29);
            cmbRating.TabIndex = 3;
            // 
            // lblReviewTextTitle
            // 
            lblReviewTextTitle.AutoSize = true;
            lblReviewTextTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReviewTextTitle.ForeColor = Color.FromArgb(74, 20, 140);
            lblReviewTextTitle.Location = new Point(34, 407);
            lblReviewTextTitle.Name = "lblReviewTextTitle";
            lblReviewTextTitle.Size = new Size(134, 25);
            lblReviewTextTitle.TabIndex = 4;
            lblReviewTextTitle.Text = "Review details";
            // 
            // txtReviewText
            // 
            txtReviewText.BackColor = Color.Beige;
            txtReviewText.BorderStyle = BorderStyle.FixedSingle;
            txtReviewText.Location = new Point(26, 435);
            txtReviewText.Multiline = true;
            txtReviewText.Name = "txtReviewText";
            txtReviewText.ScrollBars = ScrollBars.Vertical;
            txtReviewText.Size = new Size(743, 94);
            txtReviewText.TabIndex = 5;
            // 
            // chkPublish
            // 
            chkPublish.AutoSize = true;
            chkPublish.ForeColor = Color.FromArgb(74, 20, 140);
            chkPublish.Location = new Point(20, 535);
            chkPublish.Name = "chkPublish";
            chkPublish.Size = new Size(156, 29);
            chkPublish.TabIndex = 6;
            chkPublish.Text = "Publish to App";
            chkPublish.UseVisualStyleBackColor = true;
            // 
            // chkVerifiedPurchase
            // 
            chkVerifiedPurchase.AutoSize = true;
            chkVerifiedPurchase.ForeColor = Color.FromArgb(74, 20, 140);
            chkVerifiedPurchase.Location = new Point(20, 570);
            chkVerifiedPurchase.Name = "chkVerifiedPurchase";
            chkVerifiedPurchase.Size = new Size(197, 29);
            chkVerifiedPurchase.TabIndex = 7;
            chkVerifiedPurchase.Text = "Verified As Purchase";
            chkVerifiedPurchase.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(74, 20, 140);
            btnCancel.FlatAppearance.BorderSize = 2;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.FromArgb(74, 20, 140);
            btnCancel.Location = new Point(503, 544);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 55);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSubmitReview
            // 
            btnSubmitReview.BackColor = Color.Coral;
            btnSubmitReview.FlatAppearance.BorderSize = 0;
            btnSubmitReview.FlatStyle = FlatStyle.Flat;
            btnSubmitReview.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmitReview.ForeColor = SystemColors.ActiveCaptionText;
            btnSubmitReview.Location = new Point(621, 544);
            btnSubmitReview.Name = "btnSubmitReview";
            btnSubmitReview.Size = new Size(148, 55);
            btnSubmitReview.TabIndex = 9;
            btnSubmitReview.Text = "Submit Review";
            btnSubmitReview.UseVisualStyleBackColor = false;
            // 
            // ReviewForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 611);
            Controls.Add(btnSubmitReview);
            Controls.Add(btnCancel);
            Controls.Add(chkVerifiedPurchase);
            Controls.Add(chkPublish);
            Controls.Add(txtReviewText);
            Controls.Add(lblReviewTextTitle);
            Controls.Add(cmbRating);
            Controls.Add(lblRatingTitle);
            Controls.Add(pnlReviewProduct);
            Controls.Add(lblReviewTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "ReviewForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReviewForm";
            pnlReviewProduct.ResumeLayout(false);
            pnlReviewProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picReviewProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblReviewTitle;
        private Panel pnlReviewProduct;
        private PictureBox picReviewProduct;
        private Label lblProductName;
        private Label lblRatingTitle;
        private ComboBox cmbRating;
        private Label lblReviewTextTitle;
        private TextBox txtReviewText;
        private CheckBox chkPublish;
        private CheckBox chkVerifiedPurchase;
        private Button btnCancel;
        private Button btnSubmitReview;
    }
}