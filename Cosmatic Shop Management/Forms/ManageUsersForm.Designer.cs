namespace Cosmatic_Shop_Management.Forms
{
    partial class ManageUsersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUsersForm));
            pnlTopHeader = new Panel();
            btnBack = new Button();
            txtSearchUsers = new TextBox();
            lblPageTitle = new Label();
            lblBrand = new Label();
            pnlFilters = new Panel();
            btnRefresh = new Button();
            btnAddUser = new Button();
            btnApplyFilters = new Button();
            cmbStatusFilter = new ComboBox();
            lblStatusFilter = new Label();
            cmbRoleFilter = new ComboBox();
            lblRoleFilter = new Label();
            pnlUsersTable = new Panel();
            lblUserCount = new Label();
            btnNextPage = new Button();
            btnPage3 = new Button();
            btnPage2 = new Button();
            btnPage1 = new Button();
            btnPrevPage = new Button();
            dgvUsers = new DataGridView();
            btnDeactivate = new Button();
            btnActivate = new Button();
            lblTableTitle = new Label();
            pnlPendingApprovals = new Panel();
            lblPendingApprovalsValue = new Label();
            lblPendingApprovalsTitle = new Label();
            pnlActiveUsers = new Panel();
            lblActiveUsersValue = new Label();
            lblActiveUsersTitle = new Label();
            pnlTotalStaff = new Panel();
            lblTotalStaffValue = new Label();
            lblTotalStaffTitle = new Label();
            btnFloatingAdd = new Button();
            pnlTopHeader.SuspendLayout();
            pnlFilters.SuspendLayout();
            pnlUsersTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            pnlPendingApprovals.SuspendLayout();
            pnlActiveUsers.SuspendLayout();
            pnlTotalStaff.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTopHeader
            // 
            pnlTopHeader.BorderStyle = BorderStyle.FixedSingle;
            pnlTopHeader.Controls.Add(btnBack);
            pnlTopHeader.Controls.Add(txtSearchUsers);
            pnlTopHeader.Controls.Add(lblPageTitle);
            pnlTopHeader.Controls.Add(lblBrand);
            pnlTopHeader.Dock = DockStyle.Top;
            pnlTopHeader.Location = new Point(0, 0);
            pnlTopHeader.Name = "pnlTopHeader";
            pnlTopHeader.Size = new Size(1378, 70);
            pnlTopHeader.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBack.BackColor = Color.FromArgb(248, 221, 232);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.Crimson;
            btnBack.Location = new Point(1268, 11);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(88, 48);
            btnBack.TabIndex = 52;
            btnBack.Text = "← Back";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // txtSearchUsers
            // 
            txtSearchUsers.BorderStyle = BorderStyle.FixedSingle;
            txtSearchUsers.Font = new Font("Segoe UI", 10F);
            txtSearchUsers.Location = new Point(427, 25);
            txtSearchUsers.Name = "txtSearchUsers";
            txtSearchUsers.PlaceholderText = "   Search users...";
            txtSearchUsers.Size = new Size(565, 34);
            txtSearchUsers.TabIndex = 2;
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.BackColor = Color.Transparent;
            lblPageTitle.Font = new Font("Segoe UI", 10F);
            lblPageTitle.ForeColor = Color.FromArgb(74, 20, 140);
            lblPageTitle.Location = new Point(203, 25);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(135, 28);
            lblPageTitle.TabIndex = 1;
            lblPageTitle.Text = "Manage Users";
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.BackColor = Color.Transparent;
            lblBrand.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBrand.ForeColor = Color.Black;
            lblBrand.Location = new Point(20, 22);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(177, 32);
            lblBrand.TabIndex = 0;
            lblBrand.Text = "Glow And  Co.";
            // 
            // pnlFilters
            // 
            pnlFilters.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlFilters.BackColor = Color.Beige;
            pnlFilters.BorderStyle = BorderStyle.FixedSingle;
            pnlFilters.Controls.Add(btnRefresh);
            pnlFilters.Controls.Add(btnAddUser);
            pnlFilters.Controls.Add(btnApplyFilters);
            pnlFilters.Controls.Add(cmbStatusFilter);
            pnlFilters.Controls.Add(lblStatusFilter);
            pnlFilters.Controls.Add(cmbRoleFilter);
            pnlFilters.Controls.Add(lblRoleFilter);
            pnlFilters.Location = new Point(20, 90);
            pnlFilters.Name = "pnlFilters";
            pnlFilters.Size = new Size(1270, 89);
            pnlFilters.TabIndex = 1;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.BackColor = Color.White;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(74, 20, 140);
            btnRefresh.FlatAppearance.BorderSize = 2;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.FromArgb(74, 20, 140);
            btnRefresh.Location = new Point(1122, 12);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(143, 54);
            btnRefresh.TabIndex = 9;
            btnRefresh.Text = "🔄Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnAddUser
            // 
            btnAddUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddUser.BackColor = Color.MediumPurple;
            btnAddUser.Cursor = Cursors.Hand;
            btnAddUser.FlatAppearance.BorderSize = 0;
            btnAddUser.FlatStyle = FlatStyle.Flat;
            btnAddUser.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddUser.ForeColor = Color.White;
            btnAddUser.Location = new Point(957, 12);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(163, 54);
            btnAddUser.TabIndex = 8;
            btnAddUser.Text = "+👤Add User";
            btnAddUser.UseVisualStyleBackColor = false;
            // 
            // btnApplyFilters
            // 
            btnApplyFilters.Cursor = Cursors.Hand;
            btnApplyFilters.FlatAppearance.BorderSize = 0;
            btnApplyFilters.FlatStyle = FlatStyle.Flat;
            btnApplyFilters.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApplyFilters.ForeColor = Color.Black;
            btnApplyFilters.Location = new Point(457, 24);
            btnApplyFilters.Name = "btnApplyFilters";
            btnApplyFilters.Size = new Size(145, 46);
            btnApplyFilters.TabIndex = 7;
            btnApplyFilters.Text = "Apply Filters";
            btnApplyFilters.UseVisualStyleBackColor = true;
            // 
            // cmbStatusFilter
            // 
            cmbStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatusFilter.Font = new Font("Segoe UI", 10F);
            cmbStatusFilter.FormattingEnabled = true;
            cmbStatusFilter.Items.AddRange(new object[] { "All Statuses", "", "Active", "", "Inactive" });
            cmbStatusFilter.Location = new Point(245, 35);
            cmbStatusFilter.Name = "cmbStatusFilter";
            cmbStatusFilter.Size = new Size(185, 36);
            cmbStatusFilter.TabIndex = 6;
            // 
            // lblStatusFilter
            // 
            lblStatusFilter.AutoSize = true;
            lblStatusFilter.BackColor = Color.Transparent;
            lblStatusFilter.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatusFilter.ForeColor = Color.DimGray;
            lblStatusFilter.Location = new Point(245, 11);
            lblStatusFilter.Name = "lblStatusFilter";
            lblStatusFilter.Size = new Size(111, 21);
            lblStatusFilter.TabIndex = 5;
            lblStatusFilter.Text = "USER STATUS";
            // 
            // cmbRoleFilter
            // 
            cmbRoleFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoleFilter.Font = new Font("Segoe UI", 10F);
            cmbRoleFilter.FormattingEnabled = true;
            cmbRoleFilter.Items.AddRange(new object[] { "All Roles", "", "Customer", "", "Admin", "", "Employee", "", "Super Admin" });
            cmbRoleFilter.Location = new Point(15, 35);
            cmbRoleFilter.Name = "cmbRoleFilter";
            cmbRoleFilter.Size = new Size(185, 36);
            cmbRoleFilter.TabIndex = 4;
            // 
            // lblRoleFilter
            // 
            lblRoleFilter.AutoSize = true;
            lblRoleFilter.BackColor = Color.Transparent;
            lblRoleFilter.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoleFilter.ForeColor = Color.DimGray;
            lblRoleFilter.Location = new Point(15, 12);
            lblRoleFilter.Name = "lblRoleFilter";
            lblRoleFilter.Size = new Size(125, 21);
            lblRoleFilter.TabIndex = 3;
            lblRoleFilter.Text = "FILTER BY ROLE";
            // 
            // pnlUsersTable
            // 
            pnlUsersTable.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlUsersTable.BackColor = Color.Beige;
            pnlUsersTable.BorderStyle = BorderStyle.FixedSingle;
            pnlUsersTable.Controls.Add(lblUserCount);
            pnlUsersTable.Controls.Add(btnNextPage);
            pnlUsersTable.Controls.Add(btnPage3);
            pnlUsersTable.Controls.Add(btnPage2);
            pnlUsersTable.Controls.Add(btnPage1);
            pnlUsersTable.Controls.Add(btnPrevPage);
            pnlUsersTable.Controls.Add(dgvUsers);
            pnlUsersTable.Controls.Add(btnDeactivate);
            pnlUsersTable.Controls.Add(btnActivate);
            pnlUsersTable.Controls.Add(lblTableTitle);
            pnlUsersTable.Location = new Point(20, 198);
            pnlUsersTable.Name = "pnlUsersTable";
            pnlUsersTable.Size = new Size(1270, 447);
            pnlUsersTable.TabIndex = 2;
            // 
            // lblUserCount
            // 
            lblUserCount.AutoSize = true;
            lblUserCount.BackColor = Color.Transparent;
            lblUserCount.ForeColor = Color.DimGray;
            lblUserCount.Location = new Point(15, 389);
            lblUserCount.Name = "lblUserCount";
            lblUserCount.Size = new Size(199, 25);
            lblUserCount.TabIndex = 48;
            lblUserCount.Text = "Showing 4 of 124 users";
            // 
            // btnNextPage
            // 
            btnNextPage.Anchor = AnchorStyles.Bottom;
            btnNextPage.BackColor = Color.White;
            btnNextPage.FlatAppearance.BorderSize = 0;
            btnNextPage.FlatStyle = FlatStyle.Flat;
            btnNextPage.Location = new Point(1212, 406);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(40, 36);
            btnNextPage.TabIndex = 47;
            btnNextPage.Text = ">";
            btnNextPage.UseVisualStyleBackColor = false;
            // 
            // btnPage3
            // 
            btnPage3.Anchor = AnchorStyles.Bottom;
            btnPage3.BackColor = Color.White;
            btnPage3.FlatAppearance.BorderSize = 0;
            btnPage3.FlatStyle = FlatStyle.Flat;
            btnPage3.Location = new Point(1167, 406);
            btnPage3.Name = "btnPage3";
            btnPage3.Size = new Size(40, 36);
            btnPage3.TabIndex = 46;
            btnPage3.Text = "3";
            btnPage3.UseVisualStyleBackColor = false;
            // 
            // btnPage2
            // 
            btnPage2.Anchor = AnchorStyles.Bottom;
            btnPage2.BackColor = Color.White;
            btnPage2.FlatAppearance.BorderSize = 0;
            btnPage2.FlatStyle = FlatStyle.Flat;
            btnPage2.Location = new Point(1122, 406);
            btnPage2.Name = "btnPage2";
            btnPage2.Size = new Size(40, 36);
            btnPage2.TabIndex = 45;
            btnPage2.Text = "2";
            btnPage2.UseVisualStyleBackColor = false;
            // 
            // btnPage1
            // 
            btnPage1.Anchor = AnchorStyles.Bottom;
            btnPage1.BackColor = Color.White;
            btnPage1.FlatAppearance.BorderSize = 0;
            btnPage1.FlatStyle = FlatStyle.Flat;
            btnPage1.Location = new Point(1077, 406);
            btnPage1.Name = "btnPage1";
            btnPage1.Size = new Size(40, 36);
            btnPage1.TabIndex = 44;
            btnPage1.Text = "1";
            btnPage1.UseVisualStyleBackColor = false;
            // 
            // btnPrevPage
            // 
            btnPrevPage.Anchor = AnchorStyles.Bottom;
            btnPrevPage.BackColor = Color.White;
            btnPrevPage.FlatAppearance.BorderSize = 0;
            btnPrevPage.FlatStyle = FlatStyle.Flat;
            btnPrevPage.Location = new Point(1032, 406);
            btnPrevPage.Name = "btnPrevPage";
            btnPrevPage.Size = new Size(40, 36);
            btnPrevPage.TabIndex = 43;
            btnPrevPage.Text = "<";
            btnPrevPage.UseVisualStyleBackColor = false;
            // 
            // dgvUsers
            // 
            dgvUsers.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.BackgroundColor = Color.White;
            dgvUsers.BorderStyle = BorderStyle.None;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(15, 66);
            dgvUsers.MultiSelect = false;
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.RowHeadersWidth = 62;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(1240, 320);
            dgvUsers.TabIndex = 12;
            // 
            // btnDeactivate
            // 
            btnDeactivate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDeactivate.BackColor = Color.White;
            btnDeactivate.Cursor = Cursors.Hand;
            btnDeactivate.FlatAppearance.BorderColor = Color.Firebrick;
            btnDeactivate.FlatAppearance.BorderSize = 2;
            btnDeactivate.FlatStyle = FlatStyle.Flat;
            btnDeactivate.Font = new Font("Segoe UI Emoji", 8F, FontStyle.Bold);
            btnDeactivate.ForeColor = Color.Firebrick;
            btnDeactivate.Location = new Point(1091, 12);
            btnDeactivate.Name = "btnDeactivate";
            btnDeactivate.Size = new Size(161, 48);
            btnDeactivate.TabIndex = 11;
            btnDeactivate.Text = "⛔DEACTIVATE";
            btnDeactivate.UseVisualStyleBackColor = false;
            // 
            // btnActivate
            // 
            btnActivate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnActivate.BackColor = Color.White;
            btnActivate.Cursor = Cursors.Hand;
            btnActivate.FlatAppearance.BorderColor = Color.DarkGreen;
            btnActivate.FlatAppearance.BorderSize = 2;
            btnActivate.FlatStyle = FlatStyle.Flat;
            btnActivate.Font = new Font("Segoe UI Emoji", 8F, FontStyle.Bold);
            btnActivate.ForeColor = Color.DarkGreen;
            btnActivate.Location = new Point(957, 12);
            btnActivate.Name = "btnActivate";
            btnActivate.Size = new Size(128, 48);
            btnActivate.TabIndex = 10;
            btnActivate.Text = "✅ACTIVATE";
            btnActivate.UseVisualStyleBackColor = false;
            // 
            // lblTableTitle
            // 
            lblTableTitle.AutoSize = true;
            lblTableTitle.BackColor = Color.Transparent;
            lblTableTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTableTitle.ForeColor = Color.FromArgb(74, 20, 140);
            lblTableTitle.Location = new Point(15, 12);
            lblTableTitle.Name = "lblTableTitle";
            lblTableTitle.Size = new Size(160, 28);
            lblTableTitle.TabIndex = 1;
            lblTableTitle.Text = "Global User List";
            // 
            // pnlPendingApprovals
            // 
            pnlPendingApprovals.BackColor = Color.WhiteSmoke;
            pnlPendingApprovals.BorderStyle = BorderStyle.FixedSingle;
            pnlPendingApprovals.Controls.Add(lblPendingApprovalsValue);
            pnlPendingApprovals.Controls.Add(lblPendingApprovalsTitle);
            pnlPendingApprovals.Location = new Point(560, 669);
            pnlPendingApprovals.Name = "pnlPendingApprovals";
            pnlPendingApprovals.Size = new Size(250, 95);
            pnlPendingApprovals.TabIndex = 50;
            // 
            // lblPendingApprovalsValue
            // 
            lblPendingApprovalsValue.AutoSize = true;
            lblPendingApprovalsValue.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPendingApprovalsValue.ForeColor = Color.FromArgb(74, 20, 140);
            lblPendingApprovalsValue.Location = new Point(100, 33);
            lblPendingApprovalsValue.Name = "lblPendingApprovalsValue";
            lblPendingApprovalsValue.Size = new Size(69, 54);
            lblPendingApprovalsValue.TabIndex = 1;
            lblPendingApprovalsValue.Text = "00";
            // 
            // lblPendingApprovalsTitle
            // 
            lblPendingApprovalsTitle.AutoSize = true;
            lblPendingApprovalsTitle.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPendingApprovalsTitle.ForeColor = Color.DimGray;
            lblPendingApprovalsTitle.Location = new Point(33, 12);
            lblPendingApprovalsTitle.Name = "lblPendingApprovalsTitle";
            lblPendingApprovalsTitle.Size = new Size(178, 21);
            lblPendingApprovalsTitle.TabIndex = 0;
            lblPendingApprovalsTitle.Text = "PENDING APPROVALS";
            // 
            // pnlActiveUsers
            // 
            pnlActiveUsers.BackColor = Color.WhiteSmoke;
            pnlActiveUsers.BorderStyle = BorderStyle.FixedSingle;
            pnlActiveUsers.Controls.Add(lblActiveUsersValue);
            pnlActiveUsers.Controls.Add(lblActiveUsersTitle);
            pnlActiveUsers.Location = new Point(288, 669);
            pnlActiveUsers.Name = "pnlActiveUsers";
            pnlActiveUsers.Size = new Size(250, 95);
            pnlActiveUsers.TabIndex = 49;
            // 
            // lblActiveUsersValue
            // 
            lblActiveUsersValue.AutoSize = true;
            lblActiveUsersValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblActiveUsersValue.ForeColor = Color.FromArgb(74, 20, 140);
            lblActiveUsersValue.Location = new Point(77, 39);
            lblActiveUsersValue.Name = "lblActiveUsersValue";
            lblActiveUsersValue.Size = new Size(83, 48);
            lblActiveUsersValue.TabIndex = 1;
            lblActiveUsersValue.Text = "000";
            // 
            // lblActiveUsersTitle
            // 
            lblActiveUsersTitle.AutoSize = true;
            lblActiveUsersTitle.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblActiveUsersTitle.ForeColor = Color.DimGray;
            lblActiveUsersTitle.Location = new Point(57, 12);
            lblActiveUsersTitle.Name = "lblActiveUsersTitle";
            lblActiveUsersTitle.Size = new Size(118, 21);
            lblActiveUsersTitle.TabIndex = 0;
            lblActiveUsersTitle.Text = "ACTIVE USERS\n";
            // 
            // pnlTotalStaff
            // 
            pnlTotalStaff.BackColor = Color.WhiteSmoke;
            pnlTotalStaff.BorderStyle = BorderStyle.FixedSingle;
            pnlTotalStaff.Controls.Add(lblTotalStaffValue);
            pnlTotalStaff.Controls.Add(lblTotalStaffTitle);
            pnlTotalStaff.Location = new Point(20, 669);
            pnlTotalStaff.Name = "pnlTotalStaff";
            pnlTotalStaff.Size = new Size(250, 95);
            pnlTotalStaff.TabIndex = 48;
            // 
            // lblTotalStaffValue
            // 
            lblTotalStaffValue.AutoSize = true;
            lblTotalStaffValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalStaffValue.ForeColor = Color.FromArgb(74, 20, 140);
            lblTotalStaffValue.Location = new Point(67, 39);
            lblTotalStaffValue.Name = "lblTotalStaffValue";
            lblTotalStaffValue.Size = new Size(83, 48);
            lblTotalStaffValue.TabIndex = 1;
            lblTotalStaffValue.Text = "000";
            // 
            // lblTotalStaffTitle
            // 
            lblTotalStaffTitle.AutoSize = true;
            lblTotalStaffTitle.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalStaffTitle.ForeColor = Color.DimGray;
            lblTotalStaffTitle.Location = new Point(50, 12);
            lblTotalStaffTitle.Name = "lblTotalStaffTitle";
            lblTotalStaffTitle.Size = new Size(123, 21);
            lblTotalStaffTitle.TabIndex = 0;
            lblTotalStaffTitle.Text = "👥TOTAL USER";
            // 
            // btnFloatingAdd
            // 
            btnFloatingAdd.BackColor = Color.Transparent;
            btnFloatingAdd.Cursor = Cursors.Hand;
            btnFloatingAdd.FlatAppearance.BorderSize = 0;
            btnFloatingAdd.FlatStyle = FlatStyle.Flat;
            btnFloatingAdd.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFloatingAdd.ForeColor = Color.White;
            btnFloatingAdd.Image = (Image)resources.GetObject("btnFloatingAdd.Image");
            btnFloatingAdd.Location = new Point(816, 669);
            btnFloatingAdd.Name = "btnFloatingAdd";
            btnFloatingAdd.Size = new Size(99, 95);
            btnFloatingAdd.TabIndex = 51;
            btnFloatingAdd.UseVisualStyleBackColor = false;
            btnFloatingAdd.Click += btnFloatingAdd_Click_1;
            // 
            // ManageUsersForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(1378, 794);
            Controls.Add(btnFloatingAdd);
            Controls.Add(pnlPendingApprovals);
            Controls.Add(pnlUsersTable);
            Controls.Add(pnlActiveUsers);
            Controls.Add(pnlFilters);
            Controls.Add(pnlTotalStaff);
            Controls.Add(pnlTopHeader);
            Name = "ManageUsersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageUsersForm";
            WindowState = FormWindowState.Maximized;
            Load += ManageUsersForm_Load;
            pnlTopHeader.ResumeLayout(false);
            pnlTopHeader.PerformLayout();
            pnlFilters.ResumeLayout(false);
            pnlFilters.PerformLayout();
            pnlUsersTable.ResumeLayout(false);
            pnlUsersTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            pnlPendingApprovals.ResumeLayout(false);
            pnlPendingApprovals.PerformLayout();
            pnlActiveUsers.ResumeLayout(false);
            pnlActiveUsers.PerformLayout();
            pnlTotalStaff.ResumeLayout(false);
            pnlTotalStaff.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTopHeader;
        private Label lblPageTitle;
        private Label lblBrand;
        private TextBox txtSearchUsers;
        private Panel pnlFilters;
        private ComboBox cmbStatusFilter;
        private Label lblStatusFilter;
        private ComboBox cmbRoleFilter;
        private Label lblRoleFilter;
        private Button btnApplyFilters;
        private Button btnAddUser;
        private Button btnRefresh;
        private Panel pnlUsersTable;
        private Button btnActivate;
        private Label lblTableTitle;
        private DataGridView dgvUsers;
        private Button btnDeactivate;
        private Button btnNextPage;
        private Button btnPage3;
        private Button btnPage2;
        private Button btnPage1;
        private Button btnPrevPage;
        private Panel pnlPendingApprovals;
        private Label lblPendingApprovalsValue;
        private Label lblPendingApprovalsTitle;
        private Panel pnlActiveUsers;
        private Label lblActiveUsersValue;
        private Label lblActiveUsersTitle;
        private Panel pnlTotalStaff;
        private Label lblTotalStaffValue;
        private Label lblTotalStaffTitle;
        private Button btnFloatingAdd;
        private Label lblUserCount;
        private Button btnBack;
    }
}