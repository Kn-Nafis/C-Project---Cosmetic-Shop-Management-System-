using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Cosmatic_Shop_Management.DAL;
using Cosmatic_Shop_Management.Helpers;

namespace Cosmatic_Shop_Management.Forms
{
    public partial class AddProductForm : Form
    {
        private string selectedImagePath = "";

        public AddProductForm()
        {
            InitializeComponent();

            this.Load += AddProductForm_Load;

            btnBrowseImage.Click -= btnBrowseImage_Click;
            btnBrowseImage.Click += btnBrowseImage_Click;

            btnResetForm.Click -= btnResetForm_Click;
            btnResetForm.Click += btnResetForm_Click;

            btnSaveProduct.Click -= btnSaveProduct_Click;
            btnSaveProduct.Click += btnSaveProduct_Click;

            btnCancel.Click -= btnCancel_Click;
            btnCancel.Click += btnCancel_Click;
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadGenderOptions();
            ResetForm();
        }

        private void LoadCategories()
        {
            try
            {
                cmbCategory.Items.Clear();

                string query = "SELECT CategoryName FROM Categories ORDER BY CategoryName";
                DataTable dt = DatabaseHelper.GetDataTable(query);

                foreach (DataRow row in dt.Rows)
                {
                    cmbCategory.Items.Add(row["CategoryName"].ToString());
                }

                cmbCategory.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Category load error: " + ex.Message);
            }
        }

        private void LoadGenderOptions()
        {
            cmbGender.Items.Clear();
            cmbGender.Items.Add("Male");
            cmbGender.Items.Add("Female");
            cmbGender.Items.Add("Unisex");
            cmbGender.SelectedIndex = 2;
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                ofd.Title = "Select Product Image";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = ofd.FileName;
                    LoadPreviewImage(selectedImagePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid image file.\n\n" + ex.Message, "Image Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                selectedImagePath = "";
                picProductPreview.Image = null;
            }
        }

        private void LoadPreviewImage(string imagePath)
        {
            try
            {
                if (picProductPreview.Image != null)
                {
                    picProductPreview.Image.Dispose();
                    picProductPreview.Image = null;
                }

                if (!string.IsNullOrWhiteSpace(imagePath) && File.Exists(imagePath))
                {
                    byte[] bytes = File.ReadAllBytes(imagePath);
                    using (MemoryStream ms = new MemoryStream(bytes))
                    using (Image temp = Image.FromStream(ms))
                    {
                        picProductPreview.Image = new Bitmap(temp);
                    }

                    picProductPreview.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    picProductPreview.Image = null;
                }
            }
            catch
            {
                picProductPreview.Image = null;
            }
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            txtProductName.Clear();
            cmbCategory.SelectedIndex = -1;
            cmbGender.SelectedIndex = 2;
            txtUnitPrice.Text = "";
            txtInitialStock.Text = "0";
            txtDescription.Clear();
            rdoActive.Checked = true;
            rdoDiscontinued.Checked = false;

            if (picProductPreview.Image != null)
            {
                picProductPreview.Image.Dispose();
                picProductPreview.Image = null;
            }

            selectedImagePath = "";
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text.Trim() == "")
            {
                MessageBox.Show("Product name is required.");
                txtProductName.Focus();
                return;
            }

            if (cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category.");
                cmbCategory.Focus();
                return;
            }

            if (cmbGender.SelectedIndex == -1)
            {
                MessageBox.Show("Please select target gender.");
                cmbGender.Focus();
                return;
            }

            if (!decimal.TryParse(txtUnitPrice.Text.Trim(), out decimal price) || price < 0)
            {
                MessageBox.Show("Please enter a valid unit price.");
                txtUnitPrice.Focus();
                return;
            }

            if (!int.TryParse(txtInitialStock.Text.Trim(), out int stockQty) || stockQty < 0)
            {
                MessageBox.Show("Please enter a valid initial stock.");
                txtInitialStock.Focus();
                return;
            }

            try
            {
                int shopId = GetCurrentShopId();
                if (shopId == 0)
                {
                    MessageBox.Show("No shop found for current admin. Please create shop first.");
                    return;
                }

                string checkNameQuery = @"
                    SELECT COUNT(*)
                    FROM Products
                    WHERE ProductName = @ProductName
                      AND ShopId = @ShopId
                ";

                SqlParameter[] checkParams =
                {
                    new SqlParameter("@ProductName", txtProductName.Text.Trim()),
                    new SqlParameter("@ShopId", shopId)
                };

                int nameExists = Convert.ToInt32(DatabaseHelper.ExecuteScalar(checkNameQuery, checkParams));

                if (nameExists > 0)
                {
                    MessageBox.Show("This product name already exists in your shop. Please use a unique name.");
                    txtProductName.Focus();
                    return;
                }

                string categoryIdQuery = "SELECT CategoryId FROM Categories WHERE CategoryName = @CategoryName";

                SqlParameter[] categoryParams =
                {
                    new SqlParameter("@CategoryName", cmbCategory.Text)
                };

                object categoryIdObj = DatabaseHelper.ExecuteScalar(categoryIdQuery, categoryParams);

                if (categoryIdObj == null || categoryIdObj == DBNull.Value)
                {
                    MessageBox.Show("Selected category not found.");
                    return;
                }

                int categoryId = Convert.ToInt32(categoryIdObj);
                bool isActive = rdoActive.Checked;

                string insertQuery = @"
                    INSERT INTO Products
                    (
                        ShopId,
                        CategoryId,
                        ProductName,
                        Description,
                        Price,
                        StockQty,
                        SoldQty,
                        GenderSection,
                        ImagePath,
                        IsHighlighted,
                        IsActive,
                        CreatedAt
                    )
                    VALUES
                    (
                        @ShopId,
                        @CategoryId,
                        @ProductName,
                        @Description,
                        @Price,
                        @StockQty,
                        0,
                        @GenderSection,
                        @ImagePath,
                        0,
                        @IsActive,
                        GETDATE()
                    )
                ";

                SqlParameter[] insertParams =
                {
                    new SqlParameter("@ShopId", shopId),
                    new SqlParameter("@CategoryId", categoryId),
                    new SqlParameter("@ProductName", txtProductName.Text.Trim()),
                    new SqlParameter("@Description", txtDescription.Text.Trim()),
                    new SqlParameter("@Price", price),
                    new SqlParameter("@StockQty", stockQty),
                    new SqlParameter("@GenderSection", cmbGender.Text),
                    new SqlParameter("@ImagePath", string.IsNullOrWhiteSpace(selectedImagePath) ? (object)DBNull.Value : selectedImagePath),
                    new SqlParameter("@IsActive", isActive)
                };

                DatabaseHelper.ExecuteNonQuery(insertQuery, insertParams);

                MessageBox.Show("Product added successfully.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save product error: " + ex.Message);
            }
        }

        private int GetCurrentShopId()
        {
            try
            {
                string query = @"
                    SELECT TOP 1 ShopId
                    FROM Shops
                    WHERE OwnerUserId = @OwnerUserId
                    ORDER BY ShopId DESC
                ";

                SqlParameter[] parameters =
                {
                    new SqlParameter("@OwnerUserId", SessionManager.UserId)
                };

                object result = DatabaseHelper.ExecuteScalar(query, parameters);

                if (result == null || result == DBNull.Value)
                    return 0;

                return Convert.ToInt32(result);
            }
            catch
            {
                return 0;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}