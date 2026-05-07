using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Cosmatic_Shop_Management.DAL;
using Cosmatic_Shop_Management.Helpers;

namespace Cosmatic_Shop_Management.Forms
{
    public partial class ReviewForm : Form
    {
        private int productId;

        public ReviewForm()
        {
            InitializeComponent();
        }

        public ReviewForm(int productId)
        {
            InitializeComponent();
            this.productId = productId;

            this.Load += ReviewForm_Load;

            btnSubmitReview.Click -= btnSubmitReview_Click;
            btnSubmitReview.Click += btnSubmitReview_Click;

            btnCancel.Click -= btnCancel_Click;
            btnCancel.Click += btnCancel_Click;
        }

        private void ReviewForm_Load(object sender, EventArgs e)
        {
            lblReviewTitle.Text = "Product Feedback";
            LoadRatingOptions();
            LoadProductInfo();
        }

        private void LoadRatingOptions()
        {
            cmbRating.Items.Clear();
            cmbRating.Items.Add("1");
            cmbRating.Items.Add("2");
            cmbRating.Items.Add("3");
            cmbRating.Items.Add("4");
            cmbRating.Items.Add("5");
            cmbRating.SelectedIndex = -1;
        }

        private void LoadProductInfo()
        {
            try
            {
                string query = @"
                    SELECT ProductName, ImagePath
                    FROM Products
                    WHERE ProductId = @ProductId
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

                lblProductName.Text = dt.Rows[0]["ProductName"].ToString();

                string imagePath = dt.Rows[0]["ImagePath"].ToString();
                if (!string.IsNullOrWhiteSpace(imagePath) && System.IO.File.Exists(imagePath))
                {
                    picReviewProduct.Image = Image.FromFile(imagePath);
                    picReviewProduct.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    picReviewProduct.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Review product load error: " + ex.Message);
            }
        }

        private void btnSubmitReview_Click(object sender, EventArgs e)
        {
            if (cmbRating.Text.Trim() == "")
            {
                MessageBox.Show("Please select a rating.");
                return;
            }

            if (txtReviewText.Text.Trim() == "")
            {
                MessageBox.Show("Please write a review.");
                return;
            }

            try
            {
                int rating = Convert.ToInt32(cmbRating.Text);

                string query = @"
                    INSERT INTO Reviews
                    (
                        ProductId,
                        CustomerUserId,
                        Rating,
                        ReviewText,
                        CreatedAt
                    )
                    VALUES
                    (
                        @ProductId,
                        @CustomerUserId,
                        @Rating,
                        @ReviewText,
                        GETDATE()
                    )
                ";

                SqlParameter[] parameters =
                {
                    new SqlParameter("@ProductId", productId),
                    new SqlParameter("@CustomerUserId", SessionManager.UserId),
                    new SqlParameter("@Rating", rating),
                    new SqlParameter("@ReviewText", txtReviewText.Text.Trim())
                };

                DatabaseHelper.ExecuteNonQuery(query, parameters);

                MessageBox.Show("Review submitted successfully.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Submit review error: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}