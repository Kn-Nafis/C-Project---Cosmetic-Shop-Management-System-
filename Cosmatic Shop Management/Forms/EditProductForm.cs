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
    public partial class EditProductForm : Form
    {
        private int productId;
        private int myShopId = 0;
        private string selectedImagePath = "";

        public EditProductForm()
        {
            InitializeComponent();
            InitializeEvents();
        }

        public EditProductForm(int productId)
        {
            InitializeComponent();
            this.productId = productId;
            InitializeEvents();
        }

        private void InitializeEvents()
        {
            this.Load -= EditProductForm_Load;
            this.Load += EditProductForm_Load;

            btnUpdateProduct.Click -= btnUpdateProduct_Click;
            btnUpdateProduct.Click += btnUpdateProduct_Click;

            btnDeleteProduct.Click -= btnDeleteProduct_Click;
            btnDeleteProduct.Click += btnDeleteProduct_Click;

            btnCancel.Click -= btnCancel_Click;
            btnCancel.Click += btnCancel_Click;

            picProductImage.Click -= picProductImage_Click;
            picProductImage.Click += picProductImage_Click;
        }

        private void EditProductForm_Load(object sender, EventArgs e)
        {
            myShopId = GetMyShopId();

            if (myShopId <= 0)
            {
                MessageBox.Show("No shop found for this admin.");
                this.Close();
                return;
            }

            LoadCategories();
            LoadGenderOptions();

            if (productId > 0)
            {
                LoadProductDetails();
            }
            else
            {
                MessageBox.Show("No product selected.");
                this.Close();
            }
        }

        private int GetMyShopId()
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

        private void LoadCategories()
        {
            try
            {
                string query = "SELECT CategoryId, CategoryName FROM Categories ORDER BY CategoryName";
                DataTable dt = DatabaseHelper.GetDataTable(query);

                cmbCategory.DataSource = dt;
                cmbCategory.DisplayMember = "CategoryName";
                cmbCategory.ValueMember = "CategoryId";
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
        }

        private void LoadProductDetails()
        {
            try
            {
                string query = @"
                    SELECT
                        P.ProductId,
                        P.ProductName,
                        P.Description,
                        P.Price,
                        P.StockQty,
                        P.GenderSection,
                        P.ImagePath,
                        P.IsActive,
                        P.CategoryId,
                        P.CreatedAt
                    FROM Products P
                    INNER JOIN Shops S ON P.ShopId = S.ShopId
                    WHERE P.ProductId = @ProductId
                      AND S.OwnerUserId = @OwnerUserId
                ";

                SqlParameter[] parameters =
                {
                    new SqlParameter("@ProductId", productId),
                    new SqlParameter("@OwnerUserId", SessionManager.UserId)
                };

                DataTable dt = DatabaseHelper.GetDataTable(query, parameters);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Product not found or you do not have permission to edit it.");
                    this.Close();
                    return;
                }

                DataRow row = dt.Rows[0];

                txtProductName.Text = row["ProductName"].ToString();
                txtDescription.Text = row["Description"].ToString();
                txtRetailPrice.Text = Convert.ToDecimal(row["Price"]).ToString("0.00");
                txtStockQty.Text = row["StockQty"].ToString();
                cmbGender.Text = row["GenderSection"].ToString();
                chkIsActive.Checked = Convert.ToBoolean(row["IsActive"]);

                if (cmbCategory.Items.Count > 0)
                {
                    cmbCategory.SelectedValue = Convert.ToInt32(row["CategoryId"]);
                }

                selectedImagePath = row["ImagePath"].ToString() ?? "";

                lblEditorHeader.Text = "PRODUCT RECORD EDITOR — ID: " + productId;
                lblLastUpdated.Text = "Created at: " + Convert.ToDateTime(row["CreatedAt"]).ToString("dd MMM yyyy");
                lblSystemGuid.Text = "Product ID: " + productId;

                UpdateStockAlert(Convert.ToInt32(row["StockQty"]));
                LoadProductImage(selectedImagePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Product load error: " + ex.Message);
            }
        }

        private void LoadProductImage(string imagePath)
        {
            try
            {
                if (picProductImage.Image != null)
                {
                    picProductImage.Image.Dispose();
                    picProductImage.Image = null;
                }

                if (!string.IsNullOrWhiteSpace(imagePath) && File.Exists(imagePath))
                {
                    byte[] bytes = File.ReadAllBytes(imagePath);
                    using (MemoryStream ms = new MemoryStream(bytes))
                    using (Image temp = Image.FromStream(ms))
                    {
                        picProductImage.Image = new Bitmap(temp);
                    }

                    picProductImage.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    picProductImage.Image = null;
                }
            }
            catch
            {
                picProductImage.Image = null;
            }
        }

        private void UpdateStockAlert(int stockQty)
        {
            if (stockQty <= 0)
            {
                lblInventoryAlertText.Text = "Product is out of stock.";
                lblInventoryAlertText.ForeColor = Color.Red;
            }
            else if (stockQty <= 10)
            {
                lblInventoryAlertText.Text = "Stock level is approaching reorder threshold.";
                lblInventoryAlertText.ForeColor = Color.DarkGoldenrod;
            }
            else
            {
                lblInventoryAlertText.Text = "Stock level is healthy.";
                lblInventoryAlertText.ForeColor = Color.Green;
            }
        }

        private void picProductImage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Select Product Image";
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.webp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = ofd.FileName;
                    LoadProductImage(selectedImagePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Image browse error: " + ex.Message);
            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                string productName = txtProductName.Text.Trim();
                string description = txtDescription.Text.Trim();
                string gender = cmbGender.Text.Trim();
                string priceText = txtRetailPrice.Text.Trim();
                string stockText = txtStockQty.Text.Trim();

                if (productName == "" || priceText == "" || stockText == "" || cmbCategory.SelectedIndex < 0 || gender == "")
                {
                    MessageBox.Show("Please fill all required fields.");
                    return;
                }

                if (!decimal.TryParse(priceText, out decimal price) || price < 0)
                {
                    MessageBox.Show("Please enter a valid retail price.");
                    return;
                }

                if (!int.TryParse(stockText, out int stockQty) || stockQty < 0)
                {
                    MessageBox.Show("Please enter a valid stock quantity.");
                    return;
                }

                int categoryId = Convert.ToInt32(cmbCategory.SelectedValue);
                bool isActive = chkIsActive.Checked;

                string query = @"
                    UPDATE P
                    SET
                        P.ProductName = @ProductName,
                        P.Description = @Description,
                        P.Price = @Price,
                        P.StockQty = @StockQty,
                        P.CategoryId = @CategoryId,
                        P.GenderSection = @GenderSection,
                        P.ImagePath = @ImagePath,
                        P.IsActive = @IsActive
                    FROM Products P
                    INNER JOIN Shops S ON P.ShopId = S.ShopId
                    WHERE P.ProductId = @ProductId
                      AND S.OwnerUserId = @OwnerUserId
                ";

                SqlParameter[] parameters =
                {
                    new SqlParameter("@ProductName", productName),
                    new SqlParameter("@Description", description),
                    new SqlParameter("@Price", price),
                    new SqlParameter("@StockQty", stockQty),
                    new SqlParameter("@CategoryId", categoryId),
                    new SqlParameter("@GenderSection", gender),
                    new SqlParameter("@ImagePath", string.IsNullOrWhiteSpace(selectedImagePath) ? (object)DBNull.Value : selectedImagePath),
                    new SqlParameter("@IsActive", isActive),
                    new SqlParameter("@ProductId", productId),
                    new SqlParameter("@OwnerUserId", SessionManager.UserId)
                };

                int rows = DatabaseHelper.ExecuteNonQuery(query, parameters);

                if (rows > 0)
                {
                    MessageBox.Show("Product updated successfully.");
                    UpdateStockAlert(stockQty);
                }
                else
                {
                    MessageBox.Show("No changes were made, or you do not have permission.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update error: " + ex.Message);
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show(
                    "Are you sure you want to deactivate this product?",
                    "Confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (dr != DialogResult.Yes)
                    return;

                string query = @"
                    UPDATE P
                    SET P.IsActive = 0
                    FROM Products P
                    INNER JOIN Shops S ON P.ShopId = S.ShopId
                    WHERE P.ProductId = @ProductId
                      AND S.OwnerUserId = @OwnerUserId
                ";

                SqlParameter[] parameters =
                {
                    new SqlParameter("@ProductId", productId),
                    new SqlParameter("@OwnerUserId", SessionManager.UserId)
                };

                int rows = DatabaseHelper.ExecuteNonQuery(query, parameters);

                if (rows > 0)
                {
                    MessageBox.Show("Product deactivated successfully.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Deactivate failed, or you do not have permission.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete error: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlPriceStock_Paint(object sender, PaintEventArgs e)
        {
        }

        private void lblGenderTitle_Click(object sender, EventArgs e)
        {
        }
    }
}