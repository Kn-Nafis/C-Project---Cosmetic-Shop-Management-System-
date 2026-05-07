namespace Cosmatic_Shop_Management.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pnlLoginBox = new Panel();
            picLogo = new PictureBox();
            lnkCreateAccount = new LinkLabel();
            lblNoAccount = new Label();
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            lblPassward = new Label();
            lblEmail = new Label();
            lblSubtitle = new Label();
            lblTitle = new Label();
            pnlLoginBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlLoginBox
            // 
            pnlLoginBox.Anchor = AnchorStyles.None;
            pnlLoginBox.AutoSize = true;
            pnlLoginBox.BackColor = Color.FromArgb(251, 244, 247);
            pnlLoginBox.Controls.Add(picLogo);
            pnlLoginBox.Controls.Add(lnkCreateAccount);
            pnlLoginBox.Controls.Add(lblNoAccount);
            pnlLoginBox.Controls.Add(btnLogin);
            pnlLoginBox.Controls.Add(txtPassword);
            pnlLoginBox.Controls.Add(txtEmail);
            pnlLoginBox.Controls.Add(lblPassward);
            pnlLoginBox.Controls.Add(lblEmail);
            pnlLoginBox.Controls.Add(lblSubtitle);
            pnlLoginBox.Controls.Add(lblTitle);
            pnlLoginBox.Location = new Point(215, 90);
            pnlLoginBox.Name = "pnlLoginBox";
            pnlLoginBox.Size = new Size(443, 759);
            pnlLoginBox.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(146, 77);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(126, 90);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 9;
            picLogo.TabStop = false;
            // 
            // lnkCreateAccount
            // 
            lnkCreateAccount.ActiveLinkColor = Color.FromArgb(74, 20, 140);
            lnkCreateAccount.AutoSize = true;
            lnkCreateAccount.Cursor = Cursors.Hand;
            lnkCreateAccount.LinkColor = Color.FromArgb(74, 20, 140);
            lnkCreateAccount.Location = new Point(265, 593);
            lnkCreateAccount.Name = "lnkCreateAccount";
            lnkCreateAccount.Size = new Size(117, 25);
            lnkCreateAccount.TabIndex = 8;
            lnkCreateAccount.TabStop = true;
            lnkCreateAccount.Text = "Register Now";
            // 
            // lblNoAccount
            // 
            lblNoAccount.AutoSize = true;
            lblNoAccount.Location = new Point(58, 593);
            lblNoAccount.Name = "lblNoAccount";
            lblNoAccount.Size = new Size(200, 25);
            lblNoAccount.TabIndex = 7;
            lblNoAccount.Text = "Don't Have an account?";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Coral;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Location = new Point(34, 547);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(378, 43);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login To Console";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(34, 469);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Enter your password";
            txtPassword.Size = new Size(378, 31);
            txtPassword.TabIndex = 5;
            txtPassword.Tag = "*";
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Cascadia Code Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(34, 360);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Enter your Email";
            txtEmail.Size = new Size(378, 28);
            txtEmail.TabIndex = 4;
            // 
            // lblPassward
            // 
            lblPassward.AutoSize = true;
            lblPassward.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassward.Location = new Point(34, 429);
            lblPassward.Name = "lblPassward";
            lblPassward.Size = new Size(92, 25);
            lblPassward.TabIndex = 3;
            lblPassward.Text = "Password";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(34, 311);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(58, 25);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.Location = new Point(104, 246);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(220, 24);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Shop Management System";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Vivaldi", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(74, 20, 140);
            lblTitle.Location = new Point(34, 177);
            lblTitle.Margin = new Padding(0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(383, 57);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Shine With Glow";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(898, 991);
            Controls.Add(pnlLoginBox);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            pnlLoginBox.ResumeLayout(false);
            pnlLoginBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlLoginBox;
        private Label lblSubtitle;
        private Label lblTitle;
        private Label lblPassward;
        private Label lblEmail;
        private Button btnLogin;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label lblNoAccount;
        private LinkLabel lnkCreateAccount;
        private PictureBox picLogo;
    }
}