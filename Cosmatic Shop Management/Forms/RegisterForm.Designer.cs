namespace Cosmatic_Shop_Management.Forms
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            pnlRegisterBox = new Panel();
            btnBackToLogin = new Button();
            btnRegister = new Button();
            txtEmail = new TextBox();
            txtConfirmPassword = new TextBox();
            txtPassword = new TextBox();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            txtFullName = new TextBox();
            lblPhone = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            lblEmail = new Label();
            lnlFullName = new Label();
            blRegisterSubtitle = new Label();
            lblRegisterTitle = new Label();
            picLeftBanner = new PictureBox();
            chkRegisterAsCustomer = new CheckBox();
            chkRegisterAsAdmin = new CheckBox();
            pnlRegisterBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLeftBanner).BeginInit();
            SuspendLayout();
            // 
            // pnlRegisterBox
            // 
            pnlRegisterBox.BackColor = SystemColors.ButtonHighlight;
            pnlRegisterBox.Controls.Add(chkRegisterAsAdmin);
            pnlRegisterBox.Controls.Add(chkRegisterAsCustomer);
            pnlRegisterBox.Controls.Add(btnBackToLogin);
            pnlRegisterBox.Controls.Add(btnRegister);
            pnlRegisterBox.Controls.Add(txtEmail);
            pnlRegisterBox.Controls.Add(txtConfirmPassword);
            pnlRegisterBox.Controls.Add(txtPassword);
            pnlRegisterBox.Controls.Add(txtAddress);
            pnlRegisterBox.Controls.Add(txtPhone);
            pnlRegisterBox.Controls.Add(txtFullName);
            pnlRegisterBox.Controls.Add(lblPhone);
            pnlRegisterBox.Controls.Add(label7);
            pnlRegisterBox.Controls.Add(label6);
            pnlRegisterBox.Controls.Add(label5);
            pnlRegisterBox.Controls.Add(lblEmail);
            pnlRegisterBox.Controls.Add(lnlFullName);
            pnlRegisterBox.Controls.Add(blRegisterSubtitle);
            pnlRegisterBox.Controls.Add(lblRegisterTitle);
            pnlRegisterBox.Location = new Point(544, 44);
            pnlRegisterBox.Name = "pnlRegisterBox";
            pnlRegisterBox.Size = new Size(487, 670);
            pnlRegisterBox.TabIndex = 1;
            // 
            // btnBackToLogin
            // 
            btnBackToLogin.ForeColor = Color.FromArgb(74, 20, 140);
            btnBackToLogin.Location = new Point(24, 585);
            btnBackToLogin.Name = "btnBackToLogin";
            btnBackToLogin.Size = new Size(429, 51);
            btnBackToLogin.TabIndex = 17;
            btnBackToLogin.Text = "Back To Login";
            btnBackToLogin.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Coral;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = SystemColors.ButtonHighlight;
            btnRegister.Location = new Point(24, 528);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(429, 51);
            btnRegister.TabIndex = 16;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Cascadia Code Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(30, 263);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "nafis@example.com";
            txtEmail.Size = new Size(205, 28);
            txtEmail.TabIndex = 1;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(244, 426);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PlaceholderText = "*******";
            txtConfirmPassword.Size = new Size(209, 31);
            txtConfirmPassword.TabIndex = 14;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(30, 426);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "*******";
            txtPassword.Size = new Size(205, 31);
            txtPassword.TabIndex = 13;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Cascadia Code Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(30, 340);
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "Stree,Address,city";
            txtAddress.Size = new Size(423, 28);
            txtAddress.TabIndex = 12;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Cascadia Code Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(244, 263);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "+880 12 3456 7456";
            txtPhone.Size = new Size(209, 28);
            txtPhone.TabIndex = 2;
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Cascadia Code Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFullName.Location = new Point(30, 186);
            txtFullName.Name = "txtFullName";
            txtFullName.PlaceholderText = "e.g Nusrat Toma";
            txtFullName.Size = new Size(423, 28);
            txtFullName.TabIndex = 0;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhone.ForeColor = Color.FromArgb(74, 20, 140);
            lblPhone.Location = new Point(244, 230);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(66, 25);
            lblPhone.TabIndex = 8;
            lblPhone.Text = "Phone";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(74, 20, 140);
            label7.Location = new Point(30, 389);
            label7.Name = "label7";
            label7.Size = new Size(92, 25);
            label7.TabIndex = 6;
            label7.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(74, 20, 140);
            label6.Location = new Point(244, 389);
            label6.Name = "label6";
            label6.Size = new Size(165, 25);
            label6.TabIndex = 5;
            label6.Text = "Confirm Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(74, 20, 140);
            label5.Location = new Point(30, 312);
            label5.Name = "label5";
            label5.Size = new Size(80, 25);
            label5.TabIndex = 4;
            label5.Text = "Address";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.FromArgb(74, 20, 140);
            lblEmail.Location = new Point(30, 230);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(58, 25);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // lnlFullName
            // 
            lnlFullName.AutoSize = true;
            lnlFullName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lnlFullName.ForeColor = Color.FromArgb(74, 20, 140);
            lnlFullName.Location = new Point(30, 151);
            lnlFullName.Name = "lnlFullName";
            lnlFullName.Size = new Size(97, 25);
            lnlFullName.TabIndex = 2;
            lnlFullName.Text = "Full Name";
            // 
            // blRegisterSubtitle
            // 
            blRegisterSubtitle.AutoSize = true;
            blRegisterSubtitle.Location = new Point(30, 109);
            blRegisterSubtitle.Name = "blRegisterSubtitle";
            blRegisterSubtitle.Size = new Size(352, 25);
            blRegisterSubtitle.TabIndex = 1;
            blRegisterSubtitle.Text = "Fill in the deails to register a new customer.";
            // 
            // lblRegisterTitle
            // 
            lblRegisterTitle.AutoSize = true;
            lblRegisterTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegisterTitle.ForeColor = Color.FromArgb(74, 20, 140);
            lblRegisterTitle.Location = new Point(24, 55);
            lblRegisterTitle.Name = "lblRegisterTitle";
            lblRegisterTitle.Size = new Size(274, 54);
            lblRegisterTitle.TabIndex = 0;
            lblRegisterTitle.Text = "New Account";
            // 
            // picLeftBanner
            // 
            picLeftBanner.Image = (Image)resources.GetObject("picLeftBanner.Image");
            picLeftBanner.Location = new Point(123, 44);
            picLeftBanner.Name = "picLeftBanner";
            picLeftBanner.Size = new Size(424, 670);
            picLeftBanner.SizeMode = PictureBoxSizeMode.StretchImage;
            picLeftBanner.TabIndex = 2;
            picLeftBanner.TabStop = false;
            // 
            // chkRegisterAsCustomer
            // 
            chkRegisterAsCustomer.AutoSize = true;
            chkRegisterAsCustomer.ForeColor = Color.FromArgb(74, 20, 140);
            chkRegisterAsCustomer.Location = new Point(33, 475);
            chkRegisterAsCustomer.Name = "chkRegisterAsCustomer";
            chkRegisterAsCustomer.Size = new Size(208, 29);
            chkRegisterAsCustomer.TabIndex = 18;
            chkRegisterAsCustomer.Text = "Register As Customer";
            chkRegisterAsCustomer.UseVisualStyleBackColor = true;
            // 
            // chkRegisterAsAdmin
            // 
            chkRegisterAsAdmin.AutoSize = true;
            chkRegisterAsAdmin.ForeColor = Color.FromArgb(74, 20, 140);
            chkRegisterAsAdmin.Location = new Point(269, 475);
            chkRegisterAsAdmin.Name = "chkRegisterAsAdmin";
            chkRegisterAsAdmin.Size = new Size(184, 29);
            chkRegisterAsAdmin.TabIndex = 19;
            chkRegisterAsAdmin.Text = "Register As Admin";
            chkRegisterAsAdmin.UseVisualStyleBackColor = true;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(1184, 752);
            Controls.Add(picLeftBanner);
            Controls.Add(pnlRegisterBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            pnlRegisterBox.ResumeLayout(false);
            pnlRegisterBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLeftBanner).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlRegisterBox;
        private PictureBox picLeftBanner;
        private Label lblRegisterTitle;
        private Label lblPhone;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label lblEmail;
        private Label lnlFullName;
        private Label blRegisterSubtitle;
        private TextBox txtEmail;
        private TextBox txtConfirmPassword;
        private TextBox txtPassword;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private TextBox txtFullName;
        private Button btnBackToLogin;
        private Button btnRegister;
        private CheckBox chkRegisterAsAdmin;
        private CheckBox chkRegisterAsCustomer;
    }
}