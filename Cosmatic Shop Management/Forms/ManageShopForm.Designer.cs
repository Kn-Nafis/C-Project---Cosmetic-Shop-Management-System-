namespace Cosmatic_Shop_Management.Forms
{
    partial class ManageShopForm
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
            lblManageShopTitle = new Label();
            pnlShopProfile = new Panel();
            btnSaveChanges = new Button();
            btnClearForm = new Button();
            chkShopActive = new CheckBox();
            txtEmailAddress = new TextBox();
            txtPhysicalAddress = new TextBox();
            txtContactPhone = new TextBox();
            txtDescription = new TextBox();
            txtBrandAffiliation = new TextBox();
            txtShopName = new TextBox();
            lblPhysicalAddressTitle = new Label();
            lblEmailAddressTitle = new Label();
            lblContactPhoneTitle = new Label();
            lblDescriptionTitle = new Label();
            lblBrandAffiliationTitle = new Label();
            lblShopNameTitle = new Label();
            lblShopProfileTitle = new Label();
            pnlShopLogo = new Panel();
            btnBrowseLogo = new Button();
            picShopLogo = new PictureBox();
            lblShopLogoTitle = new Label();
            btnGoBack = new Button();
            pnlShopProfile.SuspendLayout();
            pnlShopLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picShopLogo).BeginInit();
            SuspendLayout();
            // 
            // lblManageShopTitle
            // 
            lblManageShopTitle.AutoSize = true;
            lblManageShopTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblManageShopTitle.ForeColor = Color.FromArgb(74, 20, 140);
            lblManageShopTitle.Location = new Point(12, 9);
            lblManageShopTitle.Name = "lblManageShopTitle";
            lblManageShopTitle.Size = new Size(251, 48);
            lblManageShopTitle.TabIndex = 0;
            lblManageShopTitle.Text = "Manage Shop";
            // 
            // pnlShopProfile
            // 
            pnlShopProfile.BackColor = Color.WhiteSmoke;
            pnlShopProfile.BorderStyle = BorderStyle.FixedSingle;
            pnlShopProfile.Controls.Add(btnSaveChanges);
            pnlShopProfile.Controls.Add(btnClearForm);
            pnlShopProfile.Controls.Add(chkShopActive);
            pnlShopProfile.Controls.Add(txtEmailAddress);
            pnlShopProfile.Controls.Add(txtPhysicalAddress);
            pnlShopProfile.Controls.Add(txtContactPhone);
            pnlShopProfile.Controls.Add(txtDescription);
            pnlShopProfile.Controls.Add(txtBrandAffiliation);
            pnlShopProfile.Controls.Add(txtShopName);
            pnlShopProfile.Controls.Add(lblPhysicalAddressTitle);
            pnlShopProfile.Controls.Add(lblEmailAddressTitle);
            pnlShopProfile.Controls.Add(lblContactPhoneTitle);
            pnlShopProfile.Controls.Add(lblDescriptionTitle);
            pnlShopProfile.Controls.Add(lblBrandAffiliationTitle);
            pnlShopProfile.Controls.Add(lblShopNameTitle);
            pnlShopProfile.Controls.Add(lblShopProfileTitle);
            pnlShopProfile.Location = new Point(39, 96);
            pnlShopProfile.Name = "pnlShopProfile";
            pnlShopProfile.Size = new Size(756, 627);
            pnlShopProfile.TabIndex = 1;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.BackColor = Color.Coral;
            btnSaveChanges.Cursor = Cursors.Hand;
            btnSaveChanges.FlatAppearance.BorderSize = 0;
            btnSaveChanges.FlatStyle = FlatStyle.Flat;
            btnSaveChanges.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveChanges.Location = new Point(518, 551);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(202, 46);
            btnSaveChanges.TabIndex = 15;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = false;
            // 
            // btnClearForm
            // 
            btnClearForm.Cursor = Cursors.Hand;
            btnClearForm.FlatAppearance.BorderColor = Color.FromArgb(74, 20, 140);
            btnClearForm.FlatAppearance.BorderSize = 2;
            btnClearForm.FlatStyle = FlatStyle.Flat;
            btnClearForm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearForm.ForeColor = Color.FromArgb(74, 20, 140);
            btnClearForm.Location = new Point(403, 551);
            btnClearForm.Name = "btnClearForm";
            btnClearForm.Size = new Size(112, 46);
            btnClearForm.TabIndex = 14;
            btnClearForm.Text = "Clear Form";
            btnClearForm.UseVisualStyleBackColor = true;
            // 
            // chkShopActive
            // 
            chkShopActive.AutoSize = true;
            chkShopActive.BackColor = Color.FromArgb(212, 175, 55);
            chkShopActive.FlatAppearance.BorderSize = 0;
            chkShopActive.FlatStyle = FlatStyle.Flat;
            chkShopActive.ForeColor = Color.Black;
            chkShopActive.Location = new Point(24, 456);
            chkShopActive.Name = "chkShopActive";
            chkShopActive.Size = new Size(691, 29);
            chkShopActive.TabIndex = 13;
            chkShopActive.Text = "                                                                                                      Active Shop Status";
            chkShopActive.UseVisualStyleBackColor = false;
            // 
            // txtEmailAddress
            // 
            txtEmailAddress.BorderStyle = BorderStyle.FixedSingle;
            txtEmailAddress.Cursor = Cursors.IBeam;
            txtEmailAddress.Location = new Point(362, 321);
            txtEmailAddress.Name = "txtEmailAddress";
            txtEmailAddress.PlaceholderText = "nafis@gmail.com";
            txtEmailAddress.Size = new Size(358, 31);
            txtEmailAddress.TabIndex = 12;
            // 
            // txtPhysicalAddress
            // 
            txtPhysicalAddress.BorderStyle = BorderStyle.FixedSingle;
            txtPhysicalAddress.Cursor = Cursors.IBeam;
            txtPhysicalAddress.Location = new Point(23, 400);
            txtPhysicalAddress.Name = "txtPhysicalAddress";
            txtPhysicalAddress.PlaceholderText = "Street , City , Country";
            txtPhysicalAddress.Size = new Size(697, 31);
            txtPhysicalAddress.TabIndex = 11;
            // 
            // txtContactPhone
            // 
            txtContactPhone.BorderStyle = BorderStyle.FixedSingle;
            txtContactPhone.Cursor = Cursors.IBeam;
            txtContactPhone.Location = new Point(23, 321);
            txtContactPhone.Name = "txtContactPhone";
            txtContactPhone.PlaceholderText = "+880 12 3456 7890";
            txtContactPhone.Size = new Size(333, 31);
            txtContactPhone.TabIndex = 10;
            // 
            // txtDescription
            // 
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Cursor = Cursors.IBeam;
            txtDescription.Location = new Point(23, 221);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "e.g ....";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(697, 69);
            txtDescription.TabIndex = 9;
            // 
            // txtBrandAffiliation
            // 
            txtBrandAffiliation.BorderStyle = BorderStyle.FixedSingle;
            txtBrandAffiliation.Cursor = Cursors.IBeam;
            txtBrandAffiliation.Location = new Point(362, 143);
            txtBrandAffiliation.Name = "txtBrandAffiliation";
            txtBrandAffiliation.PlaceholderText = "e.g Primium organic";
            txtBrandAffiliation.Size = new Size(358, 31);
            txtBrandAffiliation.TabIndex = 8;
            // 
            // txtShopName
            // 
            txtShopName.BorderStyle = BorderStyle.FixedSingle;
            txtShopName.Cursor = Cursors.IBeam;
            txtShopName.Location = new Point(23, 143);
            txtShopName.Name = "txtShopName";
            txtShopName.PlaceholderText = "e.g MAC";
            txtShopName.Size = new Size(333, 31);
            txtShopName.TabIndex = 7;
            // 
            // lblPhysicalAddressTitle
            // 
            lblPhysicalAddressTitle.AutoSize = true;
            lblPhysicalAddressTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhysicalAddressTitle.ForeColor = Color.FromArgb(74, 20, 140);
            lblPhysicalAddressTitle.Location = new Point(23, 372);
            lblPhysicalAddressTitle.Name = "lblPhysicalAddressTitle";
            lblPhysicalAddressTitle.Size = new Size(183, 25);
            lblPhysicalAddressTitle.TabIndex = 6;
            lblPhysicalAddressTitle.Text = "PHYSICAL ADDRESS";
            // 
            // lblEmailAddressTitle
            // 
            lblEmailAddressTitle.AutoSize = true;
            lblEmailAddressTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmailAddressTitle.ForeColor = Color.FromArgb(74, 20, 140);
            lblEmailAddressTitle.Location = new Point(362, 293);
            lblEmailAddressTitle.Name = "lblEmailAddressTitle";
            lblEmailAddressTitle.Size = new Size(153, 25);
            lblEmailAddressTitle.TabIndex = 5;
            lblEmailAddressTitle.Text = "EMAIL ADDRESS";
            // 
            // lblContactPhoneTitle
            // 
            lblContactPhoneTitle.AutoSize = true;
            lblContactPhoneTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContactPhoneTitle.ForeColor = Color.FromArgb(74, 20, 140);
            lblContactPhoneTitle.Location = new Point(23, 293);
            lblContactPhoneTitle.Name = "lblContactPhoneTitle";
            lblContactPhoneTitle.Size = new Size(164, 25);
            lblContactPhoneTitle.TabIndex = 4;
            lblContactPhoneTitle.Text = "CONTACT PHONE";
            // 
            // lblDescriptionTitle
            // 
            lblDescriptionTitle.AutoSize = true;
            lblDescriptionTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescriptionTitle.ForeColor = Color.FromArgb(74, 20, 140);
            lblDescriptionTitle.Location = new Point(23, 193);
            lblDescriptionTitle.Name = "lblDescriptionTitle";
            lblDescriptionTitle.Size = new Size(126, 25);
            lblDescriptionTitle.TabIndex = 3;
            lblDescriptionTitle.Text = "DISCRIPTION";
            // 
            // lblBrandAffiliationTitle
            // 
            lblBrandAffiliationTitle.AutoSize = true;
            lblBrandAffiliationTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBrandAffiliationTitle.ForeColor = Color.FromArgb(74, 20, 140);
            lblBrandAffiliationTitle.Location = new Point(362, 115);
            lblBrandAffiliationTitle.Name = "lblBrandAffiliationTitle";
            lblBrandAffiliationTitle.Size = new Size(190, 25);
            lblBrandAffiliationTitle.TabIndex = 2;
            lblBrandAffiliationTitle.Text = "BRAND AFFILIATION";
            // 
            // lblShopNameTitle
            // 
            lblShopNameTitle.AutoSize = true;
            lblShopNameTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblShopNameTitle.ForeColor = Color.FromArgb(74, 20, 140);
            lblShopNameTitle.Location = new Point(23, 115);
            lblShopNameTitle.Name = "lblShopNameTitle";
            lblShopNameTitle.Size = new Size(120, 25);
            lblShopNameTitle.TabIndex = 1;
            lblShopNameTitle.Text = "SHOP NAME";
            // 
            // lblShopProfileTitle
            // 
            lblShopProfileTitle.AutoSize = true;
            lblShopProfileTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblShopProfileTitle.ForeColor = Color.FromArgb(74, 20, 140);
            lblShopProfileTitle.Location = new Point(23, 29);
            lblShopProfileTitle.Name = "lblShopProfileTitle";
            lblShopProfileTitle.Size = new Size(299, 32);
            lblShopProfileTitle.TabIndex = 0;
            lblShopProfileTitle.Text = "Shop Profile Information";
            // 
            // pnlShopLogo
            // 
            pnlShopLogo.BackColor = Color.WhiteSmoke;
            pnlShopLogo.BorderStyle = BorderStyle.FixedSingle;
            pnlShopLogo.Controls.Add(btnBrowseLogo);
            pnlShopLogo.Controls.Add(picShopLogo);
            pnlShopLogo.Controls.Add(lblShopLogoTitle);
            pnlShopLogo.Location = new Point(837, 97);
            pnlShopLogo.Name = "pnlShopLogo";
            pnlShopLogo.Size = new Size(425, 431);
            pnlShopLogo.TabIndex = 2;
            // 
            // btnBrowseLogo
            // 
            btnBrowseLogo.BackColor = Color.Coral;
            btnBrowseLogo.Cursor = Cursors.Hand;
            btnBrowseLogo.FlatAppearance.BorderSize = 0;
            btnBrowseLogo.FlatStyle = FlatStyle.Flat;
            btnBrowseLogo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBrowseLogo.Location = new Point(151, 362);
            btnBrowseLogo.Name = "btnBrowseLogo";
            btnBrowseLogo.Size = new Size(104, 34);
            btnBrowseLogo.TabIndex = 16;
            btnBrowseLogo.Text = "Browse";
            btnBrowseLogo.UseVisualStyleBackColor = false;
            // 
            // picShopLogo
            // 
            picShopLogo.BorderStyle = BorderStyle.FixedSingle;
            picShopLogo.Location = new Point(47, 66);
            picShopLogo.Name = "picShopLogo";
            picShopLogo.Size = new Size(338, 285);
            picShopLogo.TabIndex = 1;
            picShopLogo.TabStop = false;
            // 
            // lblShopLogoTitle
            // 
            lblShopLogoTitle.AutoSize = true;
            lblShopLogoTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblShopLogoTitle.ForeColor = Color.FromArgb(74, 20, 140);
            lblShopLogoTitle.Location = new Point(21, 23);
            lblShopLogoTitle.Name = "lblShopLogoTitle";
            lblShopLogoTitle.Size = new Size(111, 28);
            lblShopLogoTitle.TabIndex = 0;
            lblShopLogoTitle.Text = "Shop Logo";
            // 
            // btnGoBack
            // 
            btnGoBack.BackColor = Color.Coral;
            btnGoBack.Cursor = Cursors.Hand;
            btnGoBack.FlatAppearance.BorderSize = 0;
            btnGoBack.FlatStyle = FlatStyle.Flat;
            btnGoBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGoBack.Location = new Point(1158, 23);
            btnGoBack.Name = "btnGoBack";
            btnGoBack.Size = new Size(104, 34);
            btnGoBack.TabIndex = 17;
            btnGoBack.Text = "Go Back";
            btnGoBack.UseVisualStyleBackColor = false;
            // 
            // ManageShopForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(1274, 770);
            Controls.Add(btnGoBack);
            Controls.Add(pnlShopLogo);
            Controls.Add(pnlShopProfile);
            Controls.Add(lblManageShopTitle);
            MaximizeBox = false;
            Name = "ManageShopForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageShopForm";
            Load += ManageShopForm_Load;
            pnlShopProfile.ResumeLayout(false);
            pnlShopProfile.PerformLayout();
            pnlShopLogo.ResumeLayout(false);
            pnlShopLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picShopLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblManageShopTitle;
        private Panel pnlShopProfile;
        private Label lblShopProfileTitle;
        private Label lblPhysicalAddressTitle;
        private Label lblEmailAddressTitle;
        private Label lblContactPhoneTitle;
        private Label lblDescriptionTitle;
        private Label lblBrandAffiliationTitle;
        private Label lblShopNameTitle;
        private TextBox txtEmailAddress;
        private TextBox txtPhysicalAddress;
        private TextBox txtContactPhone;
        private TextBox txtDescription;
        private TextBox txtBrandAffiliation;
        private TextBox txtShopName;
        private Button btnSaveChanges;
        private Button btnClearForm;
        private CheckBox chkShopActive;
        private Panel pnlShopLogo;
        private Button btnBrowseLogo;
        private PictureBox picShopLogo;
        private Label lblShopLogoTitle;
        private Button btnGoBack;
    }
}