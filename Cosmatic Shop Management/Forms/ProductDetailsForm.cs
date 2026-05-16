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
    public partial class ProductDetailsForm : Form
    {
        private int productId;

        public ProductDetailsForm()
        {
            InitializeComponent();

            this.Load += ProductDetailsForm_Load;

            btnAddToCart.Click -= btnAddToCart_Click;
            btnAddToCart.Click += btnAddToCart_Click;

            btnBuyNow.Click -= btnBuyNow_Click;
            btnBuyNow.Click += btnBuyNow_Click;

            btnGoBack.Click -= btnGoBack_Click;
            btnGoBack.Click += btnGoBack_Click;

            /*btnLogout.Click -= btnLogout_Click;
            btnLogout.Click += btnLogout_Click;*/
        }

        public ProductDetailsForm(int productId)
        {
            InitializeComponent();
            this.productId = productId;

            this.Load += ProductDetailsForm_Load;

            btnAddToCart.Click -= btnAddToCart_Click;
            btnAddToCart.Click += btnAddToCart_Click;

            btnBuyNow.Click -= btnBuyNow_Click;
            btnBuyNow.Click += btnBuyNow_Click;

            btnGoBack.Click -= btnGoBack_Click;
            btnGoBack.Click += btnGoBack_Click;

            /*btnLogout.Click -= btnLogout_Click;
            btnLogout.Click += btnLogout_Click;*/
        }

        private void ProductDetailsForm_Load(object sender, EventArgs e)
        {
            LoadProductDetails();
            LoadReviews();
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
                        P.SoldQty,
                        P.ImagePath,
                        P.GenderSection,
                        C.CategoryName,
                        S.ShopName,
                        ISNULL(AVG(CAST(R.Rating AS FLOAT)), 0) AS AverageRating,
                        COUNT(R.ReviewId) AS ReviewCount
                    FROM Products P
                    INNER JOIN Categories C ON P.CategoryId = C.CategoryId
                    INNER JOIN Shops S ON P.ShopId = S.ShopId
                    LEFT JOIN Reviews R ON P.ProductId = R.ProductId
                    WHERE P.ProductId = @ProductId
                    GROUP BY
                        P.ProductId,
                        P.ProductName,
                        P.Description,
                        P.Price,
                        P.StockQty,
                        P.SoldQty,
                        P.ImagePath,
                        P.GenderSection,
                        C.CategoryName,
                        S.ShopName
                ";

                SqlParameter[] parameters =
                {
                    new SqlParameter("@ProductId", productId)
                };

                DataTable dt = DatabaseHelper.GetDataTable(query, parameters);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Product not found.");
                    this.Close();
                    return;
                }

                DataRow row = dt.Rows[0];

                lblProductName.Text = row["ProductName"].ToString();
                lblPrice.Text = "Price: " + Convert.ToDecimal(row["Price"]).ToString("0.00") + " Tk";
                lblShopName.Text = "Shop: " + row["ShopName"].ToString();
                lblCategory.Text = "Category: " + row["CategoryName"].ToString();
                lblGender.Text = "Gender: " + row["GenderSection"].ToString();

                int stockQty = Convert.ToInt32(row["StockQty"]);
                lblStock.Text = stockQty > 0 ? "In Stock: " + stockQty : "Out of Stock";

                lblDescription.Text = row["Description"].ToString();
                lblAverageRating.Text = "Rating: " + Convert.ToDouble(row["AverageRating"]).ToString("0.0");
                lblReviewCount.Text = "(" + row["ReviewCount"].ToString() + " reviews)";

                string imagePath = row["ImagePath"].ToString();
                LoadProductImage(imagePath);

                nudQuantity.Minimum = 1;
                nudQuantity.Maximum = stockQty > 0 ? stockQty : 1;
                nudQuantity.Value = 1;

                btnAddToCart.Enabled = stockQty > 0;
                btnBuyNow.Enabled = stockQty > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Product details load error: " + ex.Message);
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

        private void LoadReviews()
        {
            try
            {
                flpReviews.Controls.Clear();

                string query = @"
                    SELECT 
                        U.FullName,
                        R.Rating,
                        R.ReviewText,
                        R.CreatedAt
                    FROM Reviews R
                    INNER JOIN Users U ON R.CustomerUserId = U.UserId
                    WHERE R.ProductId = @ProductId
                    ORDER BY R.CreatedAt DESC
                ";

                SqlParameter[] parameters =
                {
                    new SqlParameter("@ProductId", productId)
                };

                DataTable dt = DatabaseHelper.GetDataTable(query, parameters);

                foreach (DataRow row in dt.Rows)
                {
                    Panel reviewCard = new Panel();
                    reviewCard.Width = 500;
                    reviewCard.Height = 100;
                    reviewCard.BorderStyle = BorderStyle.FixedSingle;
                    reviewCard.Margin = new Padding(8);
                    reviewCard.BackColor = Color.White;

                    Label lblUser = new Label();
                    lblUser.Text = row["FullName"].ToString();
                    lblUser.Left = 10;
                    lblUser.Top = 10;
                    lblUser.Width = 200;
                    lblUser.Font = new Font("Segoe UI", 10, FontStyle.Bold);

                    Label lblRating = new Label();
                    lblRating.Text = "Rating: " + row["Rating"].ToString() + "/5";
                    lblRating.Left = 10;
                    lblRating.Top = 35;
                    lblRating.Width = 120;

                    Label lblText = new Label();
                    lblText.Text = row["ReviewText"].ToString();
                    lblText.Left = 10;
                    lblText.Top = 60;
                    lblText.Width = 460;
                    lblText.Height = 30;

                    reviewCard.Controls.Add(lblUser);
                    reviewCard.Controls.Add(lblRating);
                    reviewCard.Controls.Add(lblText);

                    flpReviews.Controls.Add(reviewCard);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Review load error: " + ex.Message);
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            AddToCart(false);
        }

        private void btnBuyNow_Click(object sender, EventArgs e)
        {
            AddToCart(true);
        }

        private void AddToCart(bool openCheckoutAfterAdd)
        {
            try
            {
                if (SessionManager.UserId <= 0)
                {
                    MessageBox.Show("Please login first.");
                    return;
                }

                int quantity = Convert.ToInt32(nudQuantity.Value);
                int cartId = GetOrCreateCart(SessionManager.UserId);

                string checkQuery = @"
                    SELECT COUNT(*)
                    FROM CartItems
                    WHERE CartId = @CartId AND ProductId = @ProductId
                ";

                SqlParameter[] checkParams =
                {
                    new SqlParameter("@CartId", cartId),
                    new SqlParameter("@ProductId", productId)
                };

                int count = Convert.ToInt32(DatabaseHelper.ExecuteScalar(checkQuery, checkParams));

                if (count > 0)
                {
                    string updateQuery = @"
                        UPDATE CartItems
                        SET Quantity = Quantity + @Quantity
                        WHERE CartId = @CartId AND ProductId = @ProductId
                    ";

                    SqlParameter[] updateParams =
                    {
                        new SqlParameter("@Quantity", quantity),
                        new SqlParameter("@CartId", cartId),
                        new SqlParameter("@ProductId", productId)
                    };

                    DatabaseHelper.ExecuteNonQuery(updateQuery, updateParams);
                }
                else
                {
                    string insertQuery = @"
                        INSERT INTO CartItems (CartId, ProductId, Quantity)
                        VALUES (@CartId, @ProductId, @Quantity)
                    ";

                    SqlParameter[] insertParams =
                    {
                        new SqlParameter("@CartId", cartId),
                        new SqlParameter("@ProductId", productId),
                        new SqlParameter("@Quantity", quantity)
                    };

                    DatabaseHelper.ExecuteNonQuery(insertQuery, insertParams);
                }

                if (openCheckoutAfterAdd)
                {
                    CheckoutForm form = new CheckoutForm();
                    this.Hide();
                    form.FormClosed += (s, args) => this.Close();
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Product added to cart.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cart error: " + ex.Message);
            }
        }

        private int GetOrCreateCart(int customerUserId)
        {
            string findQuery = @"
                SELECT TOP 1 CartId
                FROM Cart
                WHERE CustomerUserId = @CustomerUserId
                ORDER BY CartId DESC
            ";

            SqlParameter[] findParams =
            {
                new SqlParameter("@CustomerUserId", customerUserId)
            };

            object result = DatabaseHelper.ExecuteScalar(findQuery, findParams);

            if (result != null && result != DBNull.Value)
            {
                return Convert.ToInt32(result);
            }

            string insertQuery = @"
                INSERT INTO Cart (CustomerUserId, CreatedAt)
                VALUES (@CustomerUserId, GETDATE());
                SELECT SCOPE_IDENTITY();
            ";

            SqlParameter[] insertParams =
            {
                new SqlParameter("@CustomerUserId", customerUserId)
            };

            object newCartId = DatabaseHelper.ExecuteScalar(insertQuery, insertParams);
            return Convert.ToInt32(newCartId);
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            SessionManager.Clear();

            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void ProductDetailsForm_Load_1(object sender, EventArgs e)
        {
        }
    }
}