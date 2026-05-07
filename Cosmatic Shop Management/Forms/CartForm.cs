using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Cosmatic_Shop_Management.DAL;
using Cosmatic_Shop_Management.Helpers;

namespace Cosmatic_Shop_Management.Forms
{
    public partial class CartForm : Form
    {
        private int cartId = 0;

        public CartForm()
        {
            InitializeComponent();

            this.Load += CartForm_Load;

            btnContinueShopping.Click -= btnContinueShopping_Click;
            btnContinueShopping.Click += btnContinueShopping_Click;

            btnRemoveSelected.Click -= btnRemoveSelected_Click;
            btnRemoveSelected.Click += btnRemoveSelected_Click;

            btnUpdateQuantity.Click -= btnUpdateQuantity_Click;
            btnUpdateQuantity.Click += btnUpdateQuantity_Click;

            btnCheckout.Click -= btnCheckout_Click;
            btnCheckout.Click += btnCheckout_Click;
        }

        private void CartForm_Load(object sender, EventArgs e)
        {
            lblCartTitle.Text = "Shopping Cart";
            LoadCart();
        }

        private void LoadCart()
        {
            try
            {
                string findCartQuery = @"
                    SELECT TOP 1 CartId
                    FROM Cart
                    WHERE CustomerUserId = @CustomerUserId
                    ORDER BY CartId DESC
                ";

                SqlParameter[] cartParams =
                {
                    new SqlParameter("@CustomerUserId", SessionManager.UserId)
                };

                object cartResult = DatabaseHelper.ExecuteScalar(findCartQuery, cartParams);

                if (cartResult == null || cartResult == DBNull.Value)
                {
                    cartId = 0;
                    dgvCartItems.DataSource = null;
                    lblTotalAmount.Text = "Total Amount: 0 Tk";
                    return;
                }

                cartId = Convert.ToInt32(cartResult);

                string query = @"
                    SELECT
                        CI.CartItemId,
                        P.ProductId,
                        P.ProductName AS [Product Name],
                        P.Price AS [Unit Price],
                        CI.Quantity,
                        (P.Price * CI.Quantity) AS [Subtotal]
                    FROM CartItems CI
                    INNER JOIN Products P ON CI.ProductId = P.ProductId
                    WHERE CI.CartId = @CartId
                ";

                SqlParameter[] parameters =
                {
                    new SqlParameter("@CartId", cartId)
                };

                DataTable dt = DatabaseHelper.GetDataTable(query, parameters);
                dgvCartItems.DataSource = dt;

                if (dgvCartItems.Columns.Contains("CartItemId"))
                    dgvCartItems.Columns["CartItemId"].Visible = false;

                if (dgvCartItems.Columns.Contains("ProductId"))
                    dgvCartItems.Columns["ProductId"].Visible = false;

                decimal total = 0;
                foreach (DataRow row in dt.Rows)
                {
                    total += Convert.ToDecimal(row["Subtotal"]);
                }

                lblTotalAmount.Text = "Total Amount: " + total.ToString("0.00") + " Tk";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cart load error: " + ex.Message);
            }
        }

        private int GetSelectedCartItemId()
        {
            if (dgvCartItems.CurrentRow == null)
            {
                MessageBox.Show("Please select an item.");
                return 0;
            }

            return Convert.ToInt32(dgvCartItems.CurrentRow.Cells["CartItemId"].Value);
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            try
            {
                int cartItemId = GetSelectedCartItemId();
                if (cartItemId == 0)
                    return;

                string query = "DELETE FROM CartItems WHERE CartItemId = @CartItemId";

                SqlParameter[] parameters =
                {
                    new SqlParameter("@CartItemId", cartItemId)
                };

                DatabaseHelper.ExecuteNonQuery(query, parameters);

                MessageBox.Show("Selected item removed from cart.");
                LoadCart();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Remove error: " + ex.Message);
            }
        }

        private void btnUpdateQuantity_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCartItems.CurrentRow == null)
                {
                    MessageBox.Show("Please select an item.");
                    return;
                }

                int cartItemId = Convert.ToInt32(dgvCartItems.CurrentRow.Cells["CartItemId"].Value);
                int currentQty = Convert.ToInt32(dgvCartItems.CurrentRow.Cells["Quantity"].Value);

                string input = Microsoft.VisualBasic.Interaction.InputBox(
                    "Enter new quantity:",
                    "Update Quantity",
                    currentQty.ToString());

                if (string.IsNullOrWhiteSpace(input))
                    return;

                if (!int.TryParse(input, out int newQty) || newQty <= 0)
                {
                    MessageBox.Show("Please enter a valid quantity.");
                    return;
                }

                string query = @"
                    UPDATE CartItems
                    SET Quantity = @Quantity
                    WHERE CartItemId = @CartItemId
                ";

                SqlParameter[] parameters =
                {
                    new SqlParameter("@Quantity", newQty),
                    new SqlParameter("@CartItemId", cartItemId)
                };

                DatabaseHelper.ExecuteNonQuery(query, parameters);

                MessageBox.Show("Quantity updated successfully.");
                LoadCart();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update error: " + ex.Message);
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (cartId == 0)
            {
                MessageBox.Show("Your cart is empty.");
                return;
            }

            CheckoutForm form = new CheckoutForm(cartId);
            form.Show();
        }

        private void btnContinueShopping_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}