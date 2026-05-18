using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Cosmatic_Shop_Management.DAL;
using Cosmatic_Shop_Management.Helpers;

namespace Cosmatic_Shop_Management.Forms
{
    public partial class ManageAdministratorAccessForm : Form
    {
        private DataTable pendingRequests = new DataTable();
        private DataTable allAdmins = new DataTable();

        private int requestId1 = 0;
        private int requestId2 = 0;

        public ManageAdministratorAccessForm()
        {
            InitializeComponent();
            InitializeEvents();
        }

        private void InitializeEvents()
        {
            this.Load -= ManageAdministratorAccessForm_Load;
            this.Load += ManageAdministratorAccessForm_Load;

            btnApprove1.Click -= btnApprove1_Click;
            btnApprove1.Click += btnApprove1_Click;

            btnApprove2.Click -= btnApprove2_Click;
            btnApprove2.Click += btnApprove2_Click;

            btnReject1.Click -= btnReject1_Click;
            btnReject1.Click += btnReject1_Click;

            btnReject2.Click -= btnReject2_Click;
            btnReject2.Click += btnReject2_Click;

            btnInviteAdmin.Click -= btnInviteAdmin_Click;
            btnInviteAdmin.Click += btnInviteAdmin_Click;

            btnSaveChanges.Click -= btnSaveChanges_Click;
            btnSaveChanges.Click += btnSaveChanges_Click;

            btnBack.Click -= btnBack_Click;
            btnBack.Click += btnBack_Click;

            txtSearchAdmins.TextChanged -= txtSearchAdmins_TextChanged;
            txtSearchAdmins.TextChanged += txtSearchAdmins_TextChanged;
        }

        private void ManageAdministratorAccessForm_Load(object sender, EventArgs e)
        {
            SetupForm();
            LoadPendingRequests();
            LoadAdminsDirectory();
            LoadSecurityOverview();
        }

        private void SetupForm()
        {
            this.Text = "Manage Administrator Access";

            lblFormTitle.Text = "Manage Administrator Access";
            lblSubtitle.Text = "Review pending requests and manage store permissions.";
            lblPendingWorkflowTitle.Text = "Pending Approval Workflow";
            lblAdminDirectoryTitle.Text = "Pending Approval Workflow";
            lblSecurityOverviewTitle.Text = "Security Overview";
            lblSecuritySystemHealth.Text = "SYSTEM HEALTH";
            lblActiveAdminsText.Text = "Active Admins";
            lblApprovalTimeText.Text = "Avg. Approval Time";
            lblNewBadge.Text = "0 NEW";

            dgvAdmins.AutoGenerateColumns = true;
            dgvAdmins.ReadOnly = true;
            dgvAdmins.AllowUserToAddRows = false;
            dgvAdmins.AllowUserToDeleteRows = false;
            dgvAdmins.AllowUserToResizeRows = false;
            dgvAdmins.RowHeadersVisible = false;
            dgvAdmins.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAdmins.MultiSelect = false;
            dgvAdmins.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAdmins.BackgroundColor = System.Drawing.Color.White;
            dgvAdmins.BorderStyle = BorderStyle.None;

            ClearPendingCard1();
            ClearPendingCard2();
        }

        private void LoadPendingRequests()
        {
            try
            {
                string query = @"
                    SELECT
                        A.RequestId,
                        A.UserId,
                        U.FullName,
                        R.RoleName,
                        A.RequestedShopName,
                        A.RequestStatus,
                        A.RequestedAt
                    FROM AdminApprovalRequests A
                    INNER JOIN Users U ON A.UserId = U.UserId
                    INNER JOIN Roles R ON U.RoleId = R.RoleId
                    WHERE A.RequestStatus = 'Pending'
                    ORDER BY A.RequestedAt DESC
                ";

                pendingRequests = DatabaseHelper.GetDataTable(query);

                lblNewBadge.Text = pendingRequests.Rows.Count + " NEW";

                if (pendingRequests.Rows.Count > 0)
                    LoadPendingCard1(pendingRequests.Rows[0]);
                else
                    ClearPendingCard1();

                if (pendingRequests.Rows.Count > 1)
                    LoadPendingCard2(pendingRequests.Rows[1]);
                else
                    ClearPendingCard2();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pending requests load error: " + ex.Message);
            }
        }

        private void LoadPendingCard1(DataRow row)
        {
            requestId1 = Convert.ToInt32(row["RequestId"]);
            lblPendingName1.Text = row["FullName"].ToString() ?? "-";
            lblPendingRole1.Text = "Requesting: " + (row["RoleName"].ToString() ?? "-");
            lblTimeAgo1.Text = GetTimeAgo(Convert.ToDateTime(row["RequestedAt"]));
            picPendingUser1.BackColor = System.Drawing.Color.Lavender;
            btnApprove1.Enabled = true;
            btnReject1.Enabled = true;
        }

        private void LoadPendingCard2(DataRow row)
        {
            requestId2 = Convert.ToInt32(row["RequestId"]);
            lblPendingName2.Text = row["FullName"].ToString() ?? "-";
            lblPendingRole2.Text = "Requesting: " + (row["RoleName"].ToString() ?? "-");
            lblTimeAgo2.Text = GetTimeAgo(Convert.ToDateTime(row["RequestedAt"]));
            picPendingUser2.BackColor = System.Drawing.Color.Lavender;
            btnApprove2.Enabled = true;
            btnReject2.Enabled = true;
        }

        private void ClearPendingCard1()
        {
            requestId1 = 0;
            lblPendingName1.Text = "No pending request";
            lblPendingRole1.Text = "-";
            lblTimeAgo1.Text = "-";
            btnApprove1.Enabled = false;
            btnReject1.Enabled = false;
        }

        private void ClearPendingCard2()
        {
            requestId2 = 0;
            lblPendingName2.Text = "No pending request";
            lblPendingRole2.Text = "-";
            lblTimeAgo2.Text = "-";
            btnApprove2.Enabled = false;
            btnReject2.Enabled = false;
        }

        private string GetTimeAgo(DateTime dt)
        {
            TimeSpan diff = DateTime.Now - dt;

            if (diff.TotalMinutes < 60)
                return ((int)diff.TotalMinutes) + " MIN AGO";

            if (diff.TotalHours < 24)
                return ((int)diff.TotalHours) + " HOURS AGO";

            return ((int)diff.TotalDays) + " DAYS AGO";
        }

        private void LoadAdminsDirectory()
        {
            try
            {
                string query = @"
                    SELECT
                        U.UserId AS [Admin ID],
                        U.FullName AS [Full Name],
                        R.RoleName AS [Role],
                        'Recently Active' AS [Last Login]
                    FROM Users U
                    INNER JOIN Roles R ON U.RoleId = R.RoleId
                    WHERE U.IsActive = 1
                      AND R.RoleName IN ('Admin', 'Super Admin', 'Employee')
                    ORDER BY U.UserId DESC
                ";

                allAdmins = DatabaseHelper.GetDataTable(query);
                dgvAdmins.DataSource = allAdmins;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Admins directory load error: " + ex.Message);
            }
        }

        private void LoadSecurityOverview()
        {
            try
            {
                string activeAdminsQuery = @"
                    SELECT COUNT(*)
                    FROM Users U
                    INNER JOIN Roles R ON U.RoleId = R.RoleId
                    WHERE U.IsActive = 1
                      AND R.RoleName IN ('Admin', 'Super Admin', 'Employee')
                ";

                string avgApprovalQuery = @"
                    SELECT AVG(DATEDIFF(HOUR, RequestedAt, ReviewedAt))
                    FROM AdminApprovalRequests
                    WHERE ReviewedAt IS NOT NULL
                ";

                string processedThisWeekQuery = @"
                    SELECT COUNT(*)
                    FROM AdminApprovalRequests
                    WHERE ReviewedAt IS NOT NULL
                      AND DATEDIFF(DAY, ReviewedAt, GETDATE()) <= 7
                ";

                object activeAdmins = DatabaseHelper.ExecuteScalar(activeAdminsQuery);
                object avgApproval = DatabaseHelper.ExecuteScalar(avgApprovalQuery);
                object processedThisWeek = DatabaseHelper.ExecuteScalar(processedThisWeekQuery);

                lblActiveAdminsValue.Text = Convert.ToString(activeAdmins);

                if (avgApproval == null || avgApproval == DBNull.Value)
                    lblApprovalTimeValue.Text = "0h";
                else
                    lblApprovalTimeValue.Text = Convert.ToDecimal(avgApproval).ToString("0.0") + "h";

                lblSecurityFooter.Text = Convert.ToString(processedThisWeek) + " requests processed this week";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Security overview load error: " + ex.Message);
            }
        }

        private void txtSearchAdmins_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (allAdmins == null || allAdmins.Rows.Count == 0)
                    return;

                string searchText = txtSearchAdmins.Text.Trim().Replace("'", "''");

                if (string.IsNullOrWhiteSpace(searchText))
                {
                    dgvAdmins.DataSource = allAdmins;
                }
                else
                {
                    DataView dv = allAdmins.DefaultView;
                    dv.RowFilter =
                        "[Admin ID] LIKE '%" + searchText + "%' OR " +
                        "[Full Name] LIKE '%" + searchText + "%' OR " +
                        "[Role] LIKE '%" + searchText + "%' OR " +
                        "[Last Login] LIKE '%" + searchText + "%'";

                    dgvAdmins.DataSource = dv.ToTable();
                }
            }
            catch
            {
            }
        }

        private void ProcessRequest(int requestId, string newStatus)
        {
            try
            {
                if (requestId <= 0)
                {
                    MessageBox.Show("No request selected.");
                    return;
                }

                string updateQuery = @"
                    UPDATE AdminApprovalRequests
                    SET
                        RequestStatus = @RequestStatus,
                        ReviewedAt = GETDATE(),
                        ReviewedBySuperAdminId = @ReviewedBySuperAdminId
                    WHERE RequestId = @RequestId
                ";

                SqlParameter[] updateParams =
                {
                    new SqlParameter("@RequestStatus", newStatus),
                    new SqlParameter("@ReviewedBySuperAdminId", SessionManager.UserId),
                    new SqlParameter("@RequestId", requestId)
                };

                DatabaseHelper.ExecuteNonQuery(updateQuery, updateParams);

                if (newStatus == "Approved")
                {
                    string getUserQuery = @"
                        SELECT UserId
                        FROM AdminApprovalRequests
                        WHERE RequestId = @RequestId
                    ";

                    SqlParameter[] getUserParams =
                    {
                        new SqlParameter("@RequestId", requestId)
                    };

                    object userIdObj = DatabaseHelper.ExecuteScalar(getUserQuery, getUserParams);

                    if (userIdObj != null && userIdObj != DBNull.Value)
                    {
                        int userId = Convert.ToInt32(userIdObj);

                        string activateUserQuery = @"
                            UPDATE Users
                            SET IsActive = 1
                            WHERE UserId = @UserId
                        ";

                        SqlParameter[] activateParams =
                        {
                            new SqlParameter("@UserId", userId)
                        };

                        DatabaseHelper.ExecuteNonQuery(activateUserQuery, activateParams);
                    }
                }

                MessageBox.Show("Request " + newStatus.ToLower() + " successfully.");

                LoadPendingRequests();
                LoadAdminsDirectory();
                LoadSecurityOverview();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Request process error: " + ex.Message);
            }
        }

        private void btnApprove1_Click(object sender, EventArgs e)
        {
            ProcessRequest(requestId1, "Approved");
        }

        private void btnApprove2_Click(object sender, EventArgs e)
        {
            ProcessRequest(requestId2, "Approved");
        }

        private void btnReject1_Click(object sender, EventArgs e)
        {
            ProcessRequest(requestId1, "Rejected");
        }

        private void btnReject2_Click(object sender, EventArgs e)
        {
            ProcessRequest(requestId2, "Rejected");
        }

        private void btnInviteAdmin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Invite Admin feature can be connected next.");
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Changes saved successfully.");
            LoadPendingRequests();
            LoadAdminsDirectory();
            LoadSecurityOverview();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}