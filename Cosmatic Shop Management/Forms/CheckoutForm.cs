using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Cosmatic_Shop_Management.DAL;
using Cosmatic_Shop_Management.Helpers;

namespace Cosmatic_Shop_Management.Forms
{
    public partial class CheckoutForm : Form
    {
        private int cartId;
        private decimal orderTotal = 0;

        public CheckoutForm()
        {
            InitializeComponent();
            InitializeCheckoutForm();
        }

        public CheckoutForm(int cartId)
        {
            InitializeComponent();
            this.cartId = cartId;
            InitializeCheckoutForm();
        }

        private void InitializeCheckoutForm()
        {
            this.Load -= CheckoutForm_Load;
            this.Load += CheckoutForm_Load;

            btnConfirmPurchase.Click -= btnConfirmPurchase_Click;
            btnConfirmPurchase.Click += btnConfirmPurchase_Click;

            btnCancel.Click -= btnCancel_Click;
            btnCancel.Click += btnCancel_Click;
        }

        private void CheckoutForm_Load(object sender, EventArgs e)
        {
            lblCheckoutTitle.Text = "Finalize Order";

            if (SessionManager.UserId <= 0)
            {
                MessageBox.Show("Please login first.");
                this.Close();
                return;
            }

            if (cartId <= 0)
            {
                cartId = GetOrCreateCart(SessionManager.UserId);
            }

            LoadCustomerInfo();
            LoadOrderSummary();
            LoadPaymentMethods();

            if (dgvOrderSummary.DataSource == null || dgvOrderSummary.Rows.Count == 0)
            {
                MessageBox.Show("Your cart is empty.");
                this.Close();
                return;
            }
        }

        private void LoadPaymentMethods()
        {
            cmbPaymentMethod.Items.Clear();
            cmbPaymentMethod.Items.Add("Cash On Delivery");
            cmbPaymentMethod.Items.Add("Card");
            cmbPaymentMethod.Items.Add("Bkash");
            cmbPaymentMethod.Items.Add("Nagad");
            cmbPaymentMethod.SelectedIndex = -1;
        }

        private void LoadCustomerInfo()
        {
            try
            {
                string query = @"
                    SELECT FullName, Phone, Address
                    FROM Users
                    WHERE UserId = @UserId
                ";

                SqlParameter[] parameters =
                {
                    new SqlParameter("@UserId", SessionManager.UserId)
                };

                DataTable dt = DatabaseHelper.GetDataTable(query, parameters);

                if (dt.Rows.Count > 0)
                {
                    txtFullName.Text = dt.Rows[0]["FullName"].ToString();
                    txtPhone.Text = dt.Rows[0]["Phone"].ToString();
                    txtAddress.Text = dt.Rows[0]["Address"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Customer info load error: " + ex.Message);
            }
        }

        private void LoadOrderSummary()
        {
            try
            {
                string query = @"
                    SELECT
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
                dgvOrderSummary.DataSource = dt;

                decimal total = 0;
                foreach (DataRow row in dt.Rows)
                {
                    total += Convert.ToDecimal(row["Subtotal"]);
                }

                orderTotal = total;
                lblOrderTotal.Text = "Total: " + total.ToString("0.00") + " Tk";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Order summary error: " + ex.Message);
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

        private void btnConfirmPurchase_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text.Trim() == "" || txtPhone.Text.Trim() == "" || txtAddress.Text.Trim() == "")
            {
                MessageBox.Show("Please fill customer information.");
                return;
            }

            if (cmbPaymentMethod.Text.Trim() == "")
            {
                MessageBox.Show("Please select payment method.");
                return;
            }

            try
            {
                string insertOrderQuery = @"
                    INSERT INTO Orders (CustomerUserId, TotalAmount, OrderStatus)
                    VALUES (@CustomerUserId, @TotalAmount, 'Completed');
                    SELECT SCOPE_IDENTITY();
                ";

                SqlParameter[] orderParams =
                {
                    new SqlParameter("@CustomerUserId", SessionManager.UserId),
                    new SqlParameter("@TotalAmount", orderTotal)
                };

                int orderId = Convert.ToInt32(DatabaseHelper.ExecuteScalar(insertOrderQuery, orderParams));

                string cartItemsQuery = @"
                    SELECT
                        CI.ProductId,
                        P.ShopId,
                        P.Price,
                        CI.Quantity,
                        (P.Price * CI.Quantity) AS LineTotal
                    FROM CartItems CI
                    INNER JOIN Products P ON CI.ProductId = P.ProductId
                    WHERE CI.CartId = @CartId
                ";

                SqlParameter[] cartParamsForRead =
                {
                    new SqlParameter("@CartId", cartId)
                };

                DataTable dt = DatabaseHelper.GetDataTable(cartItemsQuery, cartParamsForRead);

                foreach (DataRow row in dt.Rows)
                {
                    int productId = Convert.ToInt32(row["ProductId"]);
                    int shopId = Convert.ToInt32(row["ShopId"]);
                    decimal price = Convert.ToDecimal(row["Price"]);
                    int quantity = Convert.ToInt32(row["Quantity"]);
                    decimal lineTotal = Convert.ToDecimal(row["LineTotal"]);

                    decimal commission = lineTotal * 0.02m;
                    decimal shopIncome = lineTotal - commission;

                    string insertOrderItemQuery = @"
                        INSERT INTO OrderItems
                        (
                            OrderId,
                            ProductId,
                            ShopId,
                            Quantity,
                            UnitPrice,
                            LineTotal,
                            ShopIncome,
                            PlatformCommission
                        )
                        VALUES
                        (
                            @OrderId,
                            @ProductId,
                            @ShopId,
                            @Quantity,
                            @UnitPrice,
                            @LineTotal,
                            @ShopIncome,
                            @PlatformCommission
                        )
                    ";

                    SqlParameter[] itemParams =
                    {
                        new SqlParameter("@OrderId", orderId),
                        new SqlParameter("@ProductId", productId),
                        new SqlParameter("@ShopId", shopId),
                        new SqlParameter("@Quantity", quantity),
                        new SqlParameter("@UnitPrice", price),
                        new SqlParameter("@LineTotal", lineTotal),
                        new SqlParameter("@ShopIncome", shopIncome),
                        new SqlParameter("@PlatformCommission", commission)
                    };

                    DatabaseHelper.ExecuteNonQuery(insertOrderItemQuery, itemParams);

                    string updateProductQuery = @"
                        UPDATE Products
                        SET StockQty = StockQty - @Quantity,
                            SoldQty = SoldQty + @Quantity
                        WHERE ProductId = @ProductId
                    ";

                    SqlParameter[] updateParams =
                    {
                        new SqlParameter("@Quantity", quantity),
                        new SqlParameter("@ProductId", productId)
                    };

                    DatabaseHelper.ExecuteNonQuery(updateProductQuery, updateParams);
                }

                string paymentQuery = @"
                    INSERT INTO Payments (OrderId, PaymentMethod, PaymentStatus, PaidAmount, PaymentDate)
                    VALUES (@OrderId, @PaymentMethod, 'Paid', @PaidAmount, GETDATE())
                ";

                SqlParameter[] paymentParams =
                {
                    new SqlParameter("@OrderId", orderId),
                    new SqlParameter("@PaymentMethod", cmbPaymentMethod.Text),
                    new SqlParameter("@PaidAmount", orderTotal)
                };

                DatabaseHelper.ExecuteNonQuery(paymentQuery, paymentParams);

                string commissionQuery = @"
                    INSERT INTO PlatformCommission (OrderId, TotalOrderAmount, CommissionRate, CommissionAmount)
                    VALUES (@OrderId, @TotalOrderAmount, 2.00, @CommissionAmount)
                ";

                SqlParameter[] commissionParams =
                {
                    new SqlParameter("@OrderId", orderId),
                    new SqlParameter("@TotalOrderAmount", orderTotal),
                    new SqlParameter("@CommissionAmount", orderTotal * 0.02m)
                };

                DatabaseHelper.ExecuteNonQuery(commissionQuery, commissionParams);

                string clearCartQuery = "DELETE FROM CartItems WHERE CartId = @CartId";
                SqlParameter[] clearCartParams =
                {
                    new SqlParameter("@CartId", cartId)
                };

                DatabaseHelper.ExecuteNonQuery(clearCartQuery, clearCartParams);

                MessageBox.Show("Purchase completed successfully.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Checkout error: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}