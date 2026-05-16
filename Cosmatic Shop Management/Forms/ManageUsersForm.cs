using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Cosmatic_Shop_Management.DAL;

namespace Cosmatic_Shop_Management.Forms
{
    public partial class ManageUsersForm : Form
    {
        private DataTable allUsers = new DataTable();
        private int currentPage = 1;
        private int pageSize = 8;

        public ManageUsersForm()
        {
            InitializeComponent();

            this.Load += ManageUsersForm_Load;

            btnApplyFilters.Click -= btnApplyFilters_Click;
            btnApplyFilters.Click += btnApplyFilters_Click;

            btnRefresh.Click -= btnRefresh_Click;
            btnRefresh.Click += btnRefresh_Click;

            btnActivate.Click -= btnActivate_Click;
            btnActivate.Click += btnActivate_Click;

            btnDeactivate.Click -= btnDeactivate_Click;
            btnDeactivate.Click += btnDeactivate_Click;

            btnAddUser.Click -= btnAddUser_Click;
            btnAddUser.Click += btnAddUser_Click;

            btnFloatingAdd.Click -= btnFloatingAdd_Click;
            btnFloatingAdd.Click += btnFloatingAdd_Click;

            txtSearchUsers.TextChanged -= txtSearchUsers_TextChanged;
            txtSearchUsers.TextChanged += txtSearchUsers_TextChanged;

            btnPrevPage.Click -= btnPrevPage_Click;
            btnPrevPage.Click += btnPrevPage_Click;

            btnNextPage.Click -= btnNextPage_Click;
            btnNextPage.Click += btnNextPage_Click;

            btnPage1.Click -= btnPage1_Click;
            btnPage1.Click += btnPage1_Click;

            btnPage2.Click -= btnPage2_Click;
            btnPage2.Click += btnPage2_Click;

            btnPage3.Click -= btnPage3_Click;
            btnPage3.Click += btnPage3_Click;
        }

        private void ManageUsersForm_Load(object? sender, EventArgs e)
        {
            SetupUI();
            LoadRoleFilter();
            LoadUsersFromDatabase();
            LoadStats();
            ApplyFiltersAndBind();
        }

        private void SetupUI()
        {
            this.Text = "Manage Users";

            dgvUsers.AutoGenerateColumns = true;
            dgvUsers.ReadOnly = true;
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.AllowUserToResizeRows = false;
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.MultiSelect = false;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.BackgroundColor = Color.White;
            dgvUsers.BorderStyle = BorderStyle.None;

            cmbStatusFilter.Items.Clear();
            cmbStatusFilter.Items.Add("All Statuses");
            cmbStatusFilter.Items.Add("Active");
            cmbStatusFilter.Items.Add("Inactive");
            cmbStatusFilter.SelectedIndex = 0;

            HighlightCurrentPageButton();
        }

        private void LoadRoleFilter()
        {
            try
            {
                cmbRoleFilter.Items.Clear();
                cmbRoleFilter.Items.Add("All Roles");

                string query = "SELECT RoleName FROM Roles ORDER BY RoleName";
                DataTable dt = DatabaseHelper.GetDataTable(query);

                foreach (DataRow row in dt.Rows)
                {
                    cmbRoleFilter.Items.Add(row["RoleName"].ToString());
                }

                cmbRoleFilter.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Role filter load error: " + ex.Message);
            }
        }

        private void LoadUsersFromDatabase()
        {
            try
            {
                string query = @"
                    SELECT
                        U.UserId,
                        'USR-' + RIGHT('0000' + CAST(U.UserId AS varchar(10)), 4) AS [ID],
                        U.FullName AS [User Identity],
                        R.RoleName AS [Role],
                        CASE WHEN U.IsActive = 1 THEN 'ACTIVE' ELSE 'INACTIVE' END AS [Status],
                        U.Email,
                        U.Phone,
                        U.Address,
                        U.CreatedAt AS [Created Date]
                    FROM Users U
                    INNER JOIN Roles R ON U.RoleId = R.RoleId
                    ORDER BY U.CreatedAt DESC, U.UserId DESC
                ";

                allUsers = DatabaseHelper.GetDataTable(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Users load error: " + ex.Message);
            }
        }

        private void LoadStats()
        {
            try
            {
                string totalUsersQuery = "SELECT COUNT(*) FROM Users";
                string activeUsersQuery = "SELECT COUNT(*) FROM Users WHERE IsActive = 1";
                string pendingApprovalsQuery = @"
                    SELECT COUNT(*) 
                    FROM AdminApprovalRequests
                    WHERE RequestStatus = 'Pending'
                ";

                lblTotalStaffValue.Text = Convert.ToInt32(DatabaseHelper.ExecuteScalar(totalUsersQuery)).ToString();
                lblActiveUsersValue.Text = Convert.ToInt32(DatabaseHelper.ExecuteScalar(activeUsersQuery)).ToString();
                lblPendingApprovalsValue.Text = Convert.ToInt32(DatabaseHelper.ExecuteScalar(pendingApprovalsQuery)).ToString();
            }
            catch
            {
                lblTotalStaffValue.Text = "0";
                lblActiveUsersValue.Text = "0";
                lblPendingApprovalsValue.Text = "0";
            }
        }

        private void ApplyFiltersAndBind()
        {
            try
            {
                if (allUsers == null || allUsers.Rows.Count == 0)
                {
                    dgvUsers.DataSource = null;
                    lblUserCount.Text = "Showing 0 of 0 users";
                    return;
                }

                var rows = allUsers.AsEnumerable();

                string search = txtSearchUsers.Text.Trim().ToLower();
                if (!string.IsNullOrWhiteSpace(search) &&
                    !search.Equals("Search users...", StringComparison.OrdinalIgnoreCase))
                {
                    rows = rows.Where(r =>
                        (r["ID"].ToString() ?? "").ToLower().Contains(search) ||
                        (r["User Identity"].ToString() ?? "").ToLower().Contains(search) ||
                        (r["Role"].ToString() ?? "").ToLower().Contains(search) ||
                        (r["Email"].ToString() ?? "").ToLower().Contains(search) ||
                        (r["Phone"].ToString() ?? "").ToLower().Contains(search));
                }

                string selectedRole = cmbRoleFilter.Text.Trim();
                if (!string.IsNullOrWhiteSpace(selectedRole) && selectedRole != "All Roles")
                {
                    rows = rows.Where(r =>
                        (r["Role"].ToString() ?? "").Equals(selectedRole, StringComparison.OrdinalIgnoreCase));
                }

                string selectedStatus = cmbStatusFilter.Text.Trim();
                if (!string.IsNullOrWhiteSpace(selectedStatus) && selectedStatus != "All Statuses")
                {
                    rows = rows.Where(r =>
                        (r["Status"].ToString() ?? "").Equals(selectedStatus, StringComparison.OrdinalIgnoreCase));
                }

                DataTable filtered = rows.Any() ? rows.CopyToDataTable() : allUsers.Clone();
                BindPagedUsers(filtered);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Filter error: " + ex.Message);
            }
        }

        private void BindPagedUsers(DataTable filtered)
        {
            int totalRows = filtered.Rows.Count;
            int totalPages = (int)Math.Ceiling(totalRows / (double)pageSize);

            if (totalPages == 0)
                totalPages = 1;

            if (currentPage < 1)
                currentPage = 1;

            if (currentPage > totalPages)
                currentPage = totalPages;

            DataTable displayTable = filtered.Clone();

            int startIndex = (currentPage - 1) * pageSize;
            int endIndex = Math.Min(startIndex + pageSize, totalRows);

            for (int i = startIndex; i < endIndex; i++)
            {
                displayTable.ImportRow(filtered.Rows[i]);
            }

            dgvUsers.DataSource = displayTable;
            FormatGrid();

            btnPrevPage.Enabled = currentPage > 1;
            btnNextPage.Enabled = currentPage < totalPages;

            btnPage1.Visible = totalPages >= 1;
            btnPage2.Visible = totalPages >= 2;
            btnPage3.Visible = totalPages >= 3;

            HighlightCurrentPageButton();

            lblUserCount.Text = $"Showing {displayTable.Rows.Count} of {filtered.Rows.Count} users";
        }

        private void FormatGrid()
        {
            if (dgvUsers.Columns.Contains("UserId"))
                dgvUsers.Columns["UserId"].Visible = false;

            if (dgvUsers.Columns.Contains("Email"))
                dgvUsers.Columns["Email"].Visible = false;

            if (dgvUsers.Columns.Contains("Phone"))
                dgvUsers.Columns["Phone"].Visible = false;

            if (dgvUsers.Columns.Contains("Address"))
                dgvUsers.Columns["Address"].Visible = false;

            if (dgvUsers.Columns.Contains("Created Date"))
                dgvUsers.Columns["Created Date"].DefaultCellStyle.Format = "MMM dd, yyyy";
        }

        private int GetSelectedUserId()
        {
            if (dgvUsers.CurrentRow == null || dgvUsers.CurrentRow.Cells["UserId"].Value == null)
                return -1;

            return Convert.ToInt32(dgvUsers.CurrentRow.Cells["UserId"].Value);
        }

        private void btnActivate_Click(object? sender, EventArgs e)
        {
            UpdateUserStatus(true);
        }

        private void btnDeactivate_Click(object? sender, EventArgs e)
        {
            UpdateUserStatus(false);
        }

        private void UpdateUserStatus(bool isActive)
        {
            try
            {
                int userId = GetSelectedUserId();
                if (userId <= 0)
                {
                    MessageBox.Show("Please select a user first.");
                    return;
                }

                string query = @"
                    UPDATE Users
                    SET IsActive = @IsActive
                    WHERE UserId = @UserId
                ";

                SqlParameter[] parameters =
                {
                    new SqlParameter("@IsActive", isActive),
                    new SqlParameter("@UserId", userId)
                };

                DatabaseHelper.ExecuteNonQuery(query, parameters);

                MessageBox.Show(isActive ? "User activated successfully." : "User deactivated successfully.");

                LoadUsersFromDatabase();
                LoadStats();
                ApplyFiltersAndBind();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Status update error: " + ex.Message);
            }
        }

        private void btnApplyFilters_Click(object? sender, EventArgs e)
        {
            currentPage = 1;
            ApplyFiltersAndBind();
        }

        private void btnRefresh_Click(object? sender, EventArgs e)
        {
            txtSearchUsers.Clear();
            cmbRoleFilter.SelectedIndex = 0;
            cmbStatusFilter.SelectedIndex = 0;
            currentPage = 1;

            LoadUsersFromDatabase();
            LoadStats();
            ApplyFiltersAndBind();
        }

        private void txtSearchUsers_TextChanged(object? sender, EventArgs e)
        {
            currentPage = 1;
            ApplyFiltersAndBind();
        }

        private void btnPage1_Click(object? sender, EventArgs e)
        {
            currentPage = 1;
            ApplyFiltersAndBind();
        }

        private void btnPage2_Click(object? sender, EventArgs e)
        {
            currentPage = 2;
            ApplyFiltersAndBind();
        }

        private void btnPage3_Click(object? sender, EventArgs e)
        {
            currentPage = 3;
            ApplyFiltersAndBind();
        }

        private void btnPrevPage_Click(object? sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                ApplyFiltersAndBind();
            }
        }

        private void btnNextPage_Click(object? sender, EventArgs e)
        {
            currentPage++;
            ApplyFiltersAndBind();
        }

        private void HighlightCurrentPageButton()
        {
            ResetPageButton(btnPage1);
            ResetPageButton(btnPage2);
            ResetPageButton(btnPage3);

            if (currentPage == 1) SetActivePageButton(btnPage1);
            else if (currentPage == 2) SetActivePageButton(btnPage2);
            else if (currentPage == 3) SetActivePageButton(btnPage3);
        }

        private void ResetPageButton(Button btn)
        {
            btn.BackColor = Color.White;
            btn.ForeColor = Color.Black;
            btn.FlatStyle = FlatStyle.Flat;
        }

        private void SetActivePageButton(Button btn)
        {
            btn.BackColor = Color.Purple;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
        }

        private void btnAddUser_Click(object? sender, EventArgs e)
        {
            try
            {
                RegisterForm form = new RegisterForm();
                form.Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Register form is not connected yet.");
            }
        }

        private void btnFloatingAdd_Click(object? sender, EventArgs e)
        {
            btnAddUser_Click(sender, e);
        }
    }
}