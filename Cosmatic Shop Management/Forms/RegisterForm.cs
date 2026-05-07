using Cosmatic_Shop_Management.DAL;
using Cosmatic_Shop_Management.Helpers;
//using CosmeticMarketplace.DAL;
//using CosmeticMarketplace.Helpers;
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

                string roleQuery = "SELECT RoleId FROM Roles WHERE RoleName = 'Customer'";
                int customerRoleId = Convert.ToInt32(DatabaseHelper.ExecuteScalar(roleQuery));

                string insertQuery = @"
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
                        1
                    )
                ";

                SqlParameter[] insertParams =
                {
                    new SqlParameter("@FullName", fullName),
                    new SqlParameter("@Email", email),
                    new SqlParameter("@Phone", phone),
                    new SqlParameter("@Address", address),
                    new SqlParameter("@PasswordHash", passwordHash),
                    new SqlParameter("@PasswordSalt", passwordSalt),
                    new SqlParameter("@RoleId", customerRoleId)
                };

                int rows = DatabaseHelper.ExecuteNonQuery(insertQuery, insertParams);

                if (rows > 0)
                {
                    MessageBox.Show("Account created successfully. You can login now.");

                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Registration failed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Registration error: " + ex.Message);
            }
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}