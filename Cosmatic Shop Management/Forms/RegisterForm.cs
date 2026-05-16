using Cosmatic_Shop_Management.DAL;
using Cosmatic_Shop_Management.Helpers;
using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace Cosmatic_Shop_Management.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            txtPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.UseSystemPasswordChar = true;

            btnRegister.Click -= btnRegister_Click;
            btnRegister.Click += btnRegister_Click;

            btnBackToLogin.Click -= btnBackToLogin_Click;
            btnBackToLogin.Click += btnBackToLogin_Click;

            chkRegisterAsCustomer.CheckedChanged -= chkRegisterAsCustomer_CheckedChanged;
            chkRegisterAsCustomer.CheckedChanged += chkRegisterAsCustomer_CheckedChanged;

            chkRegisterAsAdmin.CheckedChanged -= chkRegisterAsAdmin_CheckedChanged;
            chkRegisterAsAdmin.CheckedChanged += chkRegisterAsAdmin_CheckedChanged;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string address = txtAddress.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            if (fullName == "" || email == "" || password == "" || confirmPassword == "")
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }

            if (!chkRegisterAsCustomer.Checked && !chkRegisterAsAdmin.Checked)
            {
                MessageBox.Show("Please select Customer or Admin registration.");
                return;
            }

            if (chkRegisterAsCustomer.Checked && chkRegisterAsAdmin.Checked)
            {
                MessageBox.Show("Please select only one role.");
                return;
            }

            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Password and confirm password do not match.");
                return;
            }

            try
            {
                string checkEmailQuery = "SELECT COUNT(*) FROM Users WHERE Email = @Email";
                SqlParameter[] checkParams =
                {
                    new SqlParameter("@Email", email)
                };

                int emailExists = Convert.ToInt32(DatabaseHelper.ExecuteScalar(checkEmailQuery, checkParams));

                if (emailExists > 0)
                {
                    MessageBox.Show("This email is already registered.");
                    return;
                }

                PasswordHasher.CreatePasswordHash(password, out string passwordHash, out string passwordSalt);

                string selectedRoleName = chkRegisterAsAdmin.Checked ? "Admin" : "Customer";

                string roleQuery = "SELECT RoleId FROM Roles WHERE RoleName = @RoleName";
                SqlParameter[] roleParams =
                {
                    new SqlParameter("@RoleName", selectedRoleName)
                };

                object roleResult = DatabaseHelper.ExecuteScalar(roleQuery, roleParams);

                if (roleResult == null || roleResult == DBNull.Value)
                {
                    MessageBox.Show(selectedRoleName + " role not found in Roles table.");
                    return;
                }

                int selectedRoleId = Convert.ToInt32(roleResult);

                int isActiveValue = chkRegisterAsAdmin.Checked ? 0 : 1;

                string insertUserQuery = @"
                    INSERT INTO Users
                    (
                        FullName,
                        Email,
                        Phone,
                        Address,
                        PasswordHash,
                        PasswordSalt,
                        RoleId,
                        IsActive
                    )
                    VALUES
                    (
                        @FullName,
                        @Email,
                        @Phone,
                        @Address,
                        @PasswordHash,
                        @PasswordSalt,
                        @RoleId,
                        @IsActive
                    );

                    SELECT SCOPE_IDENTITY();
                ";

                SqlParameter[] insertUserParams =
                {
                    new SqlParameter("@FullName", fullName),
                    new SqlParameter("@Email", email),
                    new SqlParameter("@Phone", phone),
                    new SqlParameter("@Address", address),
                    new SqlParameter("@PasswordHash", passwordHash),
                    new SqlParameter("@PasswordSalt", passwordSalt),
                    new SqlParameter("@RoleId", selectedRoleId),
                    new SqlParameter("@IsActive", isActiveValue)
                };

                object newUserIdObj = DatabaseHelper.ExecuteScalar(insertUserQuery, insertUserParams);

                if (newUserIdObj == null || newUserIdObj == DBNull.Value)
                {
                    MessageBox.Show("Registration failed.");
                    return;
                }

                int newUserId = Convert.ToInt32(newUserIdObj);

                if (chkRegisterAsAdmin.Checked)
                {
                    string requestedShopName = fullName + "'s Shop";

                    string insertApprovalQuery = @"
                        INSERT INTO AdminApprovalRequests
                        (
                            UserId,
                            RequestedShopName,
                            RequestStatus,
                            RequestedAt,
                            ReviewedAt,
                            ReviewedBySuperAdminId
                        )
                        VALUES
                        (
                            @UserId,
                            @RequestedShopName,
                            @RequestStatus,
                            GETDATE(),
                            NULL,
                            NULL
                        )
                    ";

                    SqlParameter[] approvalParams =
                    {
                        new SqlParameter("@UserId", newUserId),
                        new SqlParameter("@RequestedShopName", requestedShopName),
                        new SqlParameter("@RequestStatus", "Pending")
                    };

                    DatabaseHelper.ExecuteNonQuery(insertApprovalQuery, approvalParams);

                    MessageBox.Show("Admin registration request submitted successfully. Please wait for approval.");
                }
                else
                {
                    MessageBox.Show("Customer account created successfully. You can login now.");
                }

                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Registration error: " + ex.Message);
            }
        }

        private void chkRegisterAsCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRegisterAsCustomer.Checked)
            {
                chkRegisterAsAdmin.Checked = false;
            }
        }

        private void chkRegisterAsAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRegisterAsAdmin.Checked)
            {
                chkRegisterAsCustomer.Checked = false;
            }
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
        }
    }
}