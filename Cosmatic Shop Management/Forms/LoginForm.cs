using Cosmatic_Shop_Management.DAL;
using Cosmatic_Shop_Management.Helpers;
//using CosmeticMarketplace.DAL;
//using CosmeticMarketplace.Helpers;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Cosmatic_Shop_Management.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            txtPassword.UseSystemPasswordChar = true;

            btnLogin.Click -= btnLogin_Click;
            btnLogin.Click += btnLogin_Click;

            lnkCreateAccount.LinkClicked -= lnkCreateAccount_LinkClicked;
            lnkCreateAccount.LinkClicked += lnkCreateAccount_LinkClicked;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter email and password.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string query = @"
                    SELECT 
                        U.UserId,
                        U.FullName,
                        U.Email,
                        U.PasswordHash,
                        U.PasswordSalt,
                        U.IsActive,
                        R.RoleName
                    FROM Users U
                    INNER JOIN Roles R ON U.RoleId = R.RoleId
                    WHERE U.Email = @Email
                ";

                SqlParameter[] parameters =
                {
                    new SqlParameter("@Email", email)
                };

                DataTable dt = DatabaseHelper.GetDataTable(query, parameters);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataRow row = dt.Rows[0];

                bool isActive = Convert.ToBoolean(row["IsActive"]);
                if (!isActive)
                {
                    MessageBox.Show("Your account is inactive. Contact Super Admin.", "Account Inactive", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string storedHash = row["PasswordHash"].ToString();
                string storedSalt = row["PasswordSalt"].ToString();

                bool isPasswordCorrect = PasswordHasher.VerifyPassword(password, storedHash, storedSalt);

                if (!isPasswordCorrect)
                {
                    MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SessionManager.UserId = Convert.ToInt32(row["UserId"]);
                SessionManager.FullName = row["FullName"].ToString();
                SessionManager.Email = row["Email"].ToString();
                SessionManager.RoleName = row["RoleName"].ToString();

                OpenDashboardByRole();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenDashboardByRole()
        {
            Form nextForm = null;

            if (SessionManager.RoleName == "Super Admin")
            {
                nextForm = new SuperAdminDashboardForm();
            }
            else if (SessionManager.RoleName == "Admin")
            {
                nextForm = new AdminDashboardForm();
            }
            else if (SessionManager.RoleName == "Employee")
            {
                nextForm = new EmployeeDashboardForm();
            }
            else if (SessionManager.RoleName == "Customer")
            {
                nextForm = new CustomerDashboardForm();
            }
            else
            {
                MessageBox.Show("Unknown role found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            nextForm.FormClosed += NextForm_FormClosed;
            nextForm.Show();
            this.Hide();
        }

        private void NextForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void lnkCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }
    }
}