using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Cosmatic_Shop_Management.DAL;
using Cosmatic_Shop_Management.Helpers;

namespace Cosmatic_Shop_Management.Forms
{
    public partial class ManageShopForm : Form
    {
        private string selectedLogoPath = "";
        private int shopId = 0;
        public ManageShopForm(int shopId)
        {
            InitializeComponent();
            this.shopId = shopId;
        }
        public ManageShopForm()
        {
            InitializeComponent();

            this.Load += ManageShopForm_Load;

            btnBrowseLogo.Click -= btnBrowseLogo_Click;
            btnBrowseLogo.Click += btnBrowseLogo_Click;

            btnSaveChanges.Click -= btnSaveChanges_Click;
            btnSaveChanges.Click += btnSaveChanges_Click;

            btnClearForm.Click -= btnClearForm_Click;
            btnClearForm.Click += btnClearForm_Click;

            btnGoBack.Click -= btnGoBack_Click;
            btnGoBack.Click += btnGoBack_Click;
        }

        private void ManageShopForm_Load(object sender, EventArgs e)
        {
            LoadShopInfo();
        }

        private void LoadShopInfo()
        {
            try
            {
                string query = @"
                    SELECT TOP 1
                        ShopId,
                        ShopName,
                        ShopDescription,
                        OwnerUserId,
                        IsActive,
                        CreatedAt,
                        BrandAffiliation,
                        ContactPhone,
                        EmailAddress,
                        PhysicalAddress,
                        LogoPath
                    FROM Shops
                    WHERE OwnerUserId = @OwnerUserId
                    ORDER BY ShopId DESC
                ";

                SqlParameter[] parameters =
                {
                    new SqlParameter("@OwnerUserId", SessionManager.UserId)
                };

                DataTable dt = DatabaseHelper.GetDataTable(query, parameters);

                if (dt.Rows.Count == 0)
                    return;

                DataRow row = dt.Rows[0];

                txtShopName.Text = row["ShopName"].ToString();
                txtBrandAffiliation.Text = row["BrandAffiliation"].ToString();
                txtDescription.Text = row["ShopDescription"].ToString();
                txtContactPhone.Text = row["ContactPhone"].ToString();
                txtEmailAddress.Text = row["EmailAddress"].ToString();
                txtPhysicalAddress.Text = row["PhysicalAddress"].ToString();
                chkShopActive.Checked = Convert.ToBoolean(row["IsActive"]);

                selectedLogoPath = row["LogoPath"].ToString();

                if (!string.IsNullOrWhiteSpace(selectedLogoPath) && System.IO.File.Exists(selectedLogoPath))
                {
                    picShopLogo.Image = Image.FromFile(selectedLogoPath);
                    picShopLogo.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    picShopLogo.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Shop info load error: " + ex.Message);
            }
        }

        private void btnBrowseLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                selectedLogoPath = ofd.FileName;
                picShopLogo.Image = Image.FromFile(selectedLogoPath);
                picShopLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (txtShopName.Text.Trim() == "")
            {
                MessageBox.Show("Shop name is required.");
                return;
            }

            try
            {
                string checkQuery = @"
                    SELECT COUNT(*)
                    FROM Shops
                    WHERE OwnerUserId = @OwnerUserId
                ";

                SqlParameter[] checkParams =
                {
                    new SqlParameter("@OwnerUserId", SessionManager.UserId)
                };

                int count = Convert.ToInt32(DatabaseHelper.ExecuteScalar(checkQuery, checkParams));

                if (count == 0)
                {
                    string insertQuery = @"
                        INSERT INTO Shops
                        (
                            ShopName,
                            ShopDescription,
                            OwnerUserId,
                            IsActive,
                            CreatedAt,
                            BrandAffiliation,
                            ContactPhone,
                            EmailAddress,
                            PhysicalAddress,
                            LogoPath
                        )
                        VALUES
                        (
                            @ShopName,
                            @ShopDescription,
                            @OwnerUserId,
                            @IsActive,
                            GETDATE(),
                            @BrandAffiliation,
                            @ContactPhone,
                            @EmailAddress,
                            @PhysicalAddress,
                            @LogoPath
                        )
                    ";

                    SqlParameter[] insertParams =
                    {
                        new SqlParameter("@ShopName", txtShopName.Text.Trim()),
                        new SqlParameter("@ShopDescription", txtDescription.Text.Trim()),
                        new SqlParameter("@OwnerUserId", SessionManager.UserId),
                        new SqlParameter("@IsActive", chkShopActive.Checked),
                        new SqlParameter("@BrandAffiliation", txtBrandAffiliation.Text.Trim()),
                        new SqlParameter("@ContactPhone", txtContactPhone.Text.Trim()),
                        new SqlParameter("@EmailAddress", txtEmailAddress.Text.Trim()),
                        new SqlParameter("@PhysicalAddress", txtPhysicalAddress.Text.Trim()),
                        new SqlParameter("@LogoPath", selectedLogoPath)
                    };

                    DatabaseHelper.ExecuteNonQuery(insertQuery, insertParams);
                }
                else
                {
                    string updateQuery = @"
                        UPDATE Shops
                        SET
                            ShopName = @ShopName,
                            ShopDescription = @ShopDescription,
                            IsActive = @IsActive,
                            BrandAffiliation = @BrandAffiliation,
                            ContactPhone = @ContactPhone,
                            EmailAddress = @EmailAddress,
                            PhysicalAddress = @PhysicalAddress,
                            LogoPath = @LogoPath
                        WHERE OwnerUserId = @OwnerUserId
                    ";

                    SqlParameter[] updateParams =
                    {
                        new SqlParameter("@ShopName", txtShopName.Text.Trim()),
                        new SqlParameter("@ShopDescription", txtDescription.Text.Trim()),
                        new SqlParameter("@IsActive", chkShopActive.Checked),
                        new SqlParameter("@BrandAffiliation", txtBrandAffiliation.Text.Trim()),
                        new SqlParameter("@ContactPhone", txtContactPhone.Text.Trim()),
                        new SqlParameter("@EmailAddress", txtEmailAddress.Text.Trim()),
                        new SqlParameter("@PhysicalAddress", txtPhysicalAddress.Text.Trim()),
                        new SqlParameter("@LogoPath", selectedLogoPath),
                        new SqlParameter("@OwnerUserId", SessionManager.UserId)
                    };

                    DatabaseHelper.ExecuteNonQuery(updateQuery, updateParams);
                }

                MessageBox.Show("Shop information saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save shop error: " + ex.Message);
            }
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            txtShopName.Clear();
            txtBrandAffiliation.Clear();
            txtDescription.Clear();
            txtContactPhone.Clear();
            txtEmailAddress.Clear();
            txtPhysicalAddress.Clear();
            chkShopActive.Checked = false;
            picShopLogo.Image = null;
            selectedLogoPath = "";
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}