namespace Cosmatic_Shop_Management.Forms
{
    partial class ManageAdministratorAccessForm
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
            lblFormTitle = new Label();
            lblSubtitle = new Label();
            btnInviteAdmin = new Button();
            btnSaveChanges = new Button();
            lblPendingWorkflowTitle = new Label();
            lblNewBadge = new Label();
            pnlPendingCard1 = new Panel();
            btnReject1 = new Button();
            btnApprove1 = new Button();
            lblPendingRole1 = new Label();
            lblPendingName1 = new Label();
            lblTimeAgo1 = new Label();
            picPendingUser1 = new PictureBox();
            panel1 = new Panel();
            btnReject2 = new Button();
            btnApprove2 = new Button();
            lblPendingRole2 = new Label();
            lblPendingName2 = new Label();
            lblTimeAgo2 = new Label();
            picPendingUser2 = new PictureBox();
            pnlSecurityOverview = new Panel();
            lblSecurityFooter = new Label();
            lblApprovalTimeValue = new Label();
            lblApprovalTimeText = new Label();
            lblActiveAdminsValue = new Label();
            lblActiveAdminsText = new Label();
            lblSecurityOverviewTitle = new Label();
            lblSecuritySystemHealth = new Label();
            pnlAdminDirectory = new Panel();
            dgvAdmins = new DataGridView();
            txtSearchAdmins = new TextBox();
            lblAdminDirectoryTitle = new Label();
            btnBack = new Button();
            pnlPendingCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPendingUser1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPendingUser2).BeginInit();
            pnlSecurityOverview.SuspendLayout();
            pnlAdminDirectory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAdmins).BeginInit();
            SuspendLayout();
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormTitle.ForeColor = Color.FromArgb(74, 20, 140);
            lblFormTitle.Location = new Point(12, 18);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(586, 54);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = "Manage Administrator Access";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.ForeColor = Color.DimGray;
            lblSubtitle.Location = new Point(20, 81);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(462, 25);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Review pending requests and manage store permissions.";
            // 
            // btnInviteAdmin
            // 
            btnInviteAdmin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnInviteAdmin.BackColor = Color.Thistle;
            btnInviteAdmin.Cursor = Cursors.Hand;
            btnInviteAdmin.FlatAppearance.BorderSize = 0;
            btnInviteAdmin.FlatStyle = FlatStyle.Flat;
            btnInviteAdmin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInviteAdmin.ForeColor = Color.FromArgb(74, 20, 140);
            btnInviteAdmin.Location = new Point(663, 81);
            btnInviteAdmin.Name = "btnInviteAdmin";
            btnInviteAdmin.Size = new Size(147, 34);
            btnInviteAdmin.TabIndex = 2;
            btnInviteAdmin.Text = "+Invite Admin";
            btnInviteAdmin.UseVisualStyleBackColor = false;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSaveChanges.BackColor = Color.Coral;
            btnSaveChanges.Cursor = Cursors.Hand;
            btnSaveChanges.FlatAppearance.BorderSize = 0;
            btnSaveChanges.FlatStyle = FlatStyle.Flat;
            btnSaveChanges.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveChanges.ForeColor = Color.White;
            btnSaveChanges.Location = new Point(663, 127);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(147, 34);
            btnSaveChanges.TabIndex = 3;
            btnSaveChanges.Text = "💾Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = false;
            // 
            // lblPendingWorkflowTitle
            // 
            lblPendingWorkflowTitle.AutoSize = true;
            lblPendingWorkflowTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPendingWorkflowTitle.ForeColor = Color.Black;
            lblPendingWorkflowTitle.Location = new Point(20, 126);
            lblPendingWorkflowTitle.Name = "lblPendingWorkflowTitle";
            lblPendingWorkflowTitle.Size = new Size(338, 32);
            lblPendingWorkflowTitle.TabIndex = 4;
            lblPendingWorkflowTitle.Text = "Pending Approval Workflow";
            // 
            // lblNewBadge
            // 
            lblNewBadge.AutoSize = true;
            lblNewBadge.BackColor = Color.Transparent;
            lblNewBadge.FlatStyle = FlatStyle.Flat;
            lblNewBadge.Font = new Font("Segoe UI", 6F);
            lblNewBadge.ForeColor = Color.Red;
            lblNewBadge.Location = new Point(361, 126);
            lblNewBadge.Margin = new Padding(0);
            lblNewBadge.Name = "lblNewBadge";
            lblNewBadge.Size = new Size(42, 15);
            lblNewBadge.TabIndex = 5;
            lblNewBadge.Text = "0 NEW";
            // 
            // pnlPendingCard1
            // 
            pnlPendingCard1.BackColor = Color.Beige;
            pnlPendingCard1.BorderStyle = BorderStyle.FixedSingle;
            pnlPendingCard1.Controls.Add(btnReject1);
            pnlPendingCard1.Controls.Add(btnApprove1);
            pnlPendingCard1.Controls.Add(lblPendingRole1);
            pnlPendingCard1.Controls.Add(lblPendingName1);
            pnlPendingCard1.Controls.Add(lblTimeAgo1);
            pnlPendingCard1.Controls.Add(picPendingUser1);
            pnlPendingCard1.Location = new Point(20, 183);
            pnlPendingCard1.Name = "pnlPendingCard1";
            pnlPendingCard1.Size = new Size(245, 212);
            pnlPendingCard1.TabIndex = 6;
            // 
            // btnReject1
            // 
            btnReject1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReject1.BackColor = Color.White;
            btnReject1.Cursor = Cursors.Hand;
            btnReject1.FlatAppearance.BorderColor = Color.Firebrick;
            btnReject1.FlatAppearance.BorderSize = 2;
            btnReject1.FlatStyle = FlatStyle.Flat;
            btnReject1.Font = new Font("Segoe UI Emoji", 6F, FontStyle.Bold);
            btnReject1.ForeColor = Color.Firebrick;
            btnReject1.Location = new Point(108, 137);
            btnReject1.Name = "btnReject1";
            btnReject1.Size = new Size(90, 43);
            btnReject1.TabIndex = 12;
            btnReject1.Text = "⛔Reject";
            btnReject1.UseVisualStyleBackColor = false;
            // 
            // btnApprove1
            // 
            btnApprove1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnApprove1.BackColor = Color.White;
            btnApprove1.Cursor = Cursors.Hand;
            btnApprove1.FlatAppearance.BorderColor = Color.DarkGreen;
            btnApprove1.FlatStyle = FlatStyle.Flat;
            btnApprove1.Font = new Font("Segoe UI Emoji", 6F, FontStyle.Bold);
            btnApprove1.ForeColor = Color.DarkGreen;
            btnApprove1.Location = new Point(12, 137);
            btnApprove1.Name = "btnApprove1";
            btnApprove1.Size = new Size(90, 43);
            btnApprove1.TabIndex = 11;
            btnApprove1.Text = "✅Approve";
            btnApprove1.UseVisualStyleBackColor = false;
            // 
            // lblPendingRole1
            // 
            lblPendingRole1.AutoSize = true;
            lblPendingRole1.Font = new Font("Segoe UI", 8F);
            lblPendingRole1.ForeColor = Color.FromArgb(74, 20, 140);
            lblPendingRole1.Location = new Point(12, 78);
            lblPendingRole1.Name = "lblPendingRole1";
            lblPendingRole1.Size = new Size(91, 21);
            lblPendingRole1.TabIndex = 8;
            lblPendingRole1.Text = "Requesting:";
            // 
            // lblPendingName1
            // 
            lblPendingName1.AutoSize = true;
            lblPendingName1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPendingName1.ForeColor = Color.Black;
            lblPendingName1.Location = new Point(12, 55);
            lblPendingName1.Name = "lblPendingName1";
            lblPendingName1.Size = new Size(118, 28);
            lblPendingName1.TabIndex = 7;
            lblPendingName1.Text = "Elena Rossi";
            // 
            // lblTimeAgo1
            // 
            lblTimeAgo1.AutoSize = true;
            lblTimeAgo1.Font = new Font("Segoe UI", 6F);
            lblTimeAgo1.ForeColor = Color.Red;
            lblTimeAgo1.Location = new Point(150, 18);
            lblTimeAgo1.Name = "lblTimeAgo1";
            lblTimeAgo1.Size = new Size(83, 15);
            lblTimeAgo1.TabIndex = 7;
            lblTimeAgo1.Text = "0 HOURS AGO";
            // 
            // picPendingUser1
            // 
            picPendingUser1.BackColor = Color.Lavender;
            picPendingUser1.BorderStyle = BorderStyle.FixedSingle;
            picPendingUser1.Location = new Point(12, 12);
            picPendingUser1.Name = "picPendingUser1";
            picPendingUser1.Size = new Size(32, 32);
            picPendingUser1.TabIndex = 0;
            picPendingUser1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Beige;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnReject2);
            panel1.Controls.Add(btnApprove2);
            panel1.Controls.Add(lblPendingRole2);
            panel1.Controls.Add(lblPendingName2);
            panel1.Controls.Add(lblTimeAgo2);
            panel1.Controls.Add(picPendingUser2);
            panel1.Location = new Point(285, 183);
            panel1.Name = "panel1";
            panel1.Size = new Size(245, 212);
            panel1.TabIndex = 13;
            // 
            // btnReject2
            // 
            btnReject2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReject2.BackColor = Color.White;
            btnReject2.Cursor = Cursors.Hand;
            btnReject2.FlatAppearance.BorderColor = Color.Firebrick;
            btnReject2.FlatAppearance.BorderSize = 2;
            btnReject2.FlatStyle = FlatStyle.Flat;
            btnReject2.Font = new Font("Segoe UI Emoji", 6F, FontStyle.Bold);
            btnReject2.ForeColor = Color.Firebrick;
            btnReject2.Location = new Point(110, 137);
            btnReject2.Name = "btnReject2";
            btnReject2.Size = new Size(90, 43);
            btnReject2.TabIndex = 12;
            btnReject2.Text = "⛔Reject";
            btnReject2.UseVisualStyleBackColor = false;
            // 
            // btnApprove2
            // 
            btnApprove2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnApprove2.BackColor = Color.White;
            btnApprove2.Cursor = Cursors.Hand;
            btnApprove2.FlatAppearance.BorderColor = Color.DarkGreen;
            btnApprove2.FlatStyle = FlatStyle.Flat;
            btnApprove2.Font = new Font("Segoe UI Emoji", 6F, FontStyle.Bold);
            btnApprove2.ForeColor = Color.DarkGreen;
            btnApprove2.Location = new Point(12, 137);
            btnApprove2.Name = "btnApprove2";
            btnApprove2.Size = new Size(90, 43);
            btnApprove2.TabIndex = 11;
            btnApprove2.Text = "✅Approve";
            btnApprove2.UseVisualStyleBackColor = false;
            // 
            // lblPendingRole2
            // 
            lblPendingRole2.AutoSize = true;
            lblPendingRole2.Font = new Font("Segoe UI", 8F);
            lblPendingRole2.ForeColor = Color.FromArgb(74, 20, 140);
            lblPendingRole2.Location = new Point(12, 78);
            lblPendingRole2.Name = "lblPendingRole2";
            lblPendingRole2.Size = new Size(91, 21);
            lblPendingRole2.TabIndex = 8;
            lblPendingRole2.Text = "Requesting:";
            // 
            // lblPendingName2
            // 
            lblPendingName2.AutoSize = true;
            lblPendingName2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPendingName2.ForeColor = Color.Black;
            lblPendingName2.Location = new Point(12, 55);
            lblPendingName2.Name = "lblPendingName2";
            lblPendingName2.Size = new Size(118, 28);
            lblPendingName2.TabIndex = 7;
            lblPendingName2.Text = "Elena Rossi";
            // 
            // lblTimeAgo2
            // 
            lblTimeAgo2.AutoSize = true;
            lblTimeAgo2.Font = new Font("Segoe UI", 6F);
            lblTimeAgo2.ForeColor = Color.Red;
            lblTimeAgo2.Location = new Point(150, 18);
            lblTimeAgo2.Name = "lblTimeAgo2";
            lblTimeAgo2.Size = new Size(83, 15);
            lblTimeAgo2.TabIndex = 7;
            lblTimeAgo2.Text = "0 HOURS AGO";
            // 
            // picPendingUser2
            // 
            picPendingUser2.BackColor = Color.Lavender;
            picPendingUser2.BorderStyle = BorderStyle.FixedSingle;
            picPendingUser2.Location = new Point(12, 12);
            picPendingUser2.Name = "picPendingUser2";
            picPendingUser2.Size = new Size(32, 32);
            picPendingUser2.TabIndex = 0;
            picPendingUser2.TabStop = false;
            // 
            // pnlSecurityOverview
            // 
            pnlSecurityOverview.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlSecurityOverview.BackColor = Color.FromArgb(74, 20, 140);
            pnlSecurityOverview.BorderStyle = BorderStyle.FixedSingle;
            pnlSecurityOverview.Controls.Add(lblSecurityFooter);
            pnlSecurityOverview.Controls.Add(lblApprovalTimeValue);
            pnlSecurityOverview.Controls.Add(lblApprovalTimeText);
            pnlSecurityOverview.Controls.Add(lblActiveAdminsValue);
            pnlSecurityOverview.Controls.Add(lblActiveAdminsText);
            pnlSecurityOverview.Controls.Add(lblSecurityOverviewTitle);
            pnlSecurityOverview.Controls.Add(lblSecuritySystemHealth);
            pnlSecurityOverview.Location = new Point(550, 183);
            pnlSecurityOverview.Name = "pnlSecurityOverview";
            pnlSecurityOverview.Size = new Size(260, 212);
            pnlSecurityOverview.TabIndex = 14;
            // 
            // lblSecurityFooter
            // 
            lblSecurityFooter.AutoSize = true;
            lblSecurityFooter.Font = new Font("Segoe UI", 7F);
            lblSecurityFooter.ForeColor = Color.Gainsboro;
            lblSecurityFooter.Location = new Point(2, 161);
            lblSecurityFooter.Name = "lblSecurityFooter";
            lblSecurityFooter.Size = new Size(234, 19);
            lblSecurityFooter.TabIndex = 6;
            lblSecurityFooter.Text = "85% of requests processed this week";
            // 
            // lblApprovalTimeValue
            // 
            lblApprovalTimeValue.AutoSize = true;
            lblApprovalTimeValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApprovalTimeValue.ForeColor = Color.White;
            lblApprovalTimeValue.Location = new Point(205, 121);
            lblApprovalTimeValue.Name = "lblApprovalTimeValue";
            lblApprovalTimeValue.Size = new Size(32, 25);
            lblApprovalTimeValue.TabIndex = 5;
            lblApprovalTimeValue.Text = "00";
            // 
            // lblApprovalTimeText
            // 
            lblApprovalTimeText.AutoSize = true;
            lblApprovalTimeText.Font = new Font("Segoe UI", 9F);
            lblApprovalTimeText.ForeColor = Color.Gainsboro;
            lblApprovalTimeText.Location = new Point(14, 121);
            lblApprovalTimeText.Name = "lblApprovalTimeText";
            lblApprovalTimeText.Size = new Size(169, 25);
            lblApprovalTimeText.TabIndex = 4;
            lblApprovalTimeText.Text = "Avg. Approval Time";
            // 
            // lblActiveAdminsValue
            // 
            lblActiveAdminsValue.AutoSize = true;
            lblActiveAdminsValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblActiveAdminsValue.ForeColor = Color.White;
            lblActiveAdminsValue.Location = new Point(204, 87);
            lblActiveAdminsValue.Name = "lblActiveAdminsValue";
            lblActiveAdminsValue.Size = new Size(32, 25);
            lblActiveAdminsValue.TabIndex = 3;
            lblActiveAdminsValue.Text = "00";
            // 
            // lblActiveAdminsText
            // 
            lblActiveAdminsText.AutoSize = true;
            lblActiveAdminsText.Font = new Font("Segoe UI", 9F);
            lblActiveAdminsText.ForeColor = Color.Gainsboro;
            lblActiveAdminsText.Location = new Point(14, 87);
            lblActiveAdminsText.Name = "lblActiveAdminsText";
            lblActiveAdminsText.Size = new Size(126, 25);
            lblActiveAdminsText.TabIndex = 2;
            lblActiveAdminsText.Text = "Active Admins";
            // 
            // lblSecurityOverviewTitle
            // 
            lblSecurityOverviewTitle.AutoSize = true;
            lblSecurityOverviewTitle.Font = new Font("Segoe UI", 14F);
            lblSecurityOverviewTitle.ForeColor = Color.White;
            lblSecurityOverviewTitle.Location = new Point(14, 36);
            lblSecurityOverviewTitle.Name = "lblSecurityOverviewTitle";
            lblSecurityOverviewTitle.Size = new Size(238, 38);
            lblSecurityOverviewTitle.TabIndex = 1;
            lblSecurityOverviewTitle.Text = "Security Overview";
            // 
            // lblSecuritySystemHealth
            // 
            lblSecuritySystemHealth.AutoSize = true;
            lblSecuritySystemHealth.Font = new Font("Segoe UI", 7F);
            lblSecuritySystemHealth.ForeColor = Color.Silver;
            lblSecuritySystemHealth.Location = new Point(14, 16);
            lblSecuritySystemHealth.Name = "lblSecuritySystemHealth";
            lblSecuritySystemHealth.Size = new Size(111, 19);
            lblSecuritySystemHealth.TabIndex = 0;
            lblSecuritySystemHealth.Text = "SYSTEM HEALTH";
            // 
            // pnlAdminDirectory
            // 
            pnlAdminDirectory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlAdminDirectory.BackColor = Color.Beige;
            pnlAdminDirectory.BorderStyle = BorderStyle.FixedSingle;
            pnlAdminDirectory.Controls.Add(dgvAdmins);
            pnlAdminDirectory.Controls.Add(txtSearchAdmins);
            pnlAdminDirectory.Controls.Add(lblAdminDirectoryTitle);
            pnlAdminDirectory.Location = new Point(20, 417);
            pnlAdminDirectory.Name = "pnlAdminDirectory";
            pnlAdminDirectory.Size = new Size(790, 330);
            pnlAdminDirectory.TabIndex = 15;
            // 
            // dgvAdmins
            // 
            dgvAdmins.AllowUserToAddRows = false;
            dgvAdmins.AllowUserToDeleteRows = false;
            dgvAdmins.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAdmins.BackgroundColor = Color.White;
            dgvAdmins.BorderStyle = BorderStyle.None;
            dgvAdmins.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdmins.Location = new Point(16, 55);
            dgvAdmins.MultiSelect = false;
            dgvAdmins.Name = "dgvAdmins";
            dgvAdmins.ReadOnly = true;
            dgvAdmins.RowHeadersVisible = false;
            dgvAdmins.RowHeadersWidth = 62;
            dgvAdmins.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAdmins.Size = new Size(750, 245);
            dgvAdmins.TabIndex = 18;
            // 
            // txtSearchAdmins
            // 
            txtSearchAdmins.BorderStyle = BorderStyle.None;
            txtSearchAdmins.Location = new Point(500, 14);
            txtSearchAdmins.Name = "txtSearchAdmins";
            txtSearchAdmins.PlaceholderText = " Search...";
            txtSearchAdmins.Size = new Size(210, 24);
            txtSearchAdmins.TabIndex = 17;
            txtSearchAdmins.Visible = false;
            // 
            // lblAdminDirectoryTitle
            // 
            lblAdminDirectoryTitle.AutoSize = true;
            lblAdminDirectoryTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAdminDirectoryTitle.ForeColor = Color.Black;
            lblAdminDirectoryTitle.Location = new Point(16, 16);
            lblAdminDirectoryTitle.Name = "lblAdminDirectoryTitle";
            lblAdminDirectoryTitle.Size = new Size(338, 32);
            lblAdminDirectoryTitle.TabIndex = 16;
            lblAdminDirectoryTitle.Text = "Pending Approval Workflow";
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBack.BackColor = Color.FromArgb(248, 221, 232);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.Crimson;
            btnBack.Location = new Point(722, 18);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(88, 48);
            btnBack.TabIndex = 13;
            btnBack.Text = "← Back";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // ManageAdministratorAccessForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(877, 768);
            Controls.Add(btnBack);
            Controls.Add(pnlAdminDirectory);
            Controls.Add(pnlSecurityOverview);
            Controls.Add(panel1);
            Controls.Add(pnlPendingCard1);
            Controls.Add(lblNewBadge);
            Controls.Add(lblPendingWorkflowTitle);
            Controls.Add(btnSaveChanges);
            Controls.Add(btnInviteAdmin);
            Controls.Add(lblSubtitle);
            Controls.Add(lblFormTitle);
            Name = "ManageAdministratorAccessForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageAdministratorAccessForm";
            WindowState = FormWindowState.Maximized;
            Load += ManageAdministratorAccessForm_Load;
            pnlPendingCard1.ResumeLayout(false);
            pnlPendingCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picPendingUser1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picPendingUser2).EndInit();
            pnlSecurityOverview.ResumeLayout(false);
            pnlSecurityOverview.PerformLayout();
            pnlAdminDirectory.ResumeLayout(false);
            pnlAdminDirectory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAdmins).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFormTitle;
        private Label lblSubtitle;
        private Button btnInviteAdmin;
        private Button btnSaveChanges;
        private Label lblPendingWorkflowTitle;
        private Label lblNewBadge;
        private Panel pnlPendingCard1;
        private PictureBox picPendingUser1;
        private Label lblPendingRole1;
        private Label lblPendingName1;
        private Label lblTimeAgo1;
        private Button btnApprove1;
        private Button btnReject1;
        private Panel panel1;
        private Button btnReject2;
        private Button btnApprove2;
        private Label lblPendingRole2;
        private Label lblPendingName2;
        private Label lblTimeAgo2;
        private PictureBox picPendingUser2;
        private Panel pnlSecurityOverview;
        private Label lblSecurityOverviewTitle;
        private Label lblSecuritySystemHealth;
        private Label lblApprovalTimeValue;
        private Label lblApprovalTimeText;
        private Label lblActiveAdminsValue;
        private Label lblActiveAdminsText;
        private Label lblSecurityFooter;
        private Panel pnlAdminDirectory;
        private Label lblAdminDirectoryTitle;
        private DataGridView dgvAdmins;
        private TextBox txtSearchAdmins;
        private Button btnBack;
    }
}