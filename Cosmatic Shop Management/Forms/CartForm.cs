using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Cosmatic_Shop_Management.DAL;
using Cosmatic_Shop_Management.Helpers;

namespace Cosmatic_Shop_Management.Forms
{
    public partial class CartForm : Form
    {
        private DataTable cartTable = new DataTable();

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

            chkSelectAll.CheckedChanged -= chkSelectAll_CheckedChanged;
            chkSelectAll.CheckedChanged += chkSelectAll_CheckedChanged;
        }

        private void CartForm_Load(object? sender, EventArgs e)
        {
            SetupCartArea();
            LoadCartItems();
        }

        private void SetupCartArea()
        {
            flowCartItems.Controls.Clear();
            flowCartItems.AutoScroll = true;
            flowCartItems.WrapContents = false;
            flowCartItems.FlowDirection = FlowDirection.TopDown;
        }

        private void LoadCartItems()
        {
            try
            {
                string query = @"
                    SELECT
                        CI.CartItemId,
                        P.ProductId,
                        P.ProductName,
                        P.ImagePath,
                        CAST(P.Price AS decimal(10,2)) AS Price,
                        CI.Quantity,
                        CAST(P.Price * CI.Quantity AS decimal(10,2)) AS Subtotal
                    FROM Cart C
                    INNER JOIN CartItems CI ON C.CartId = CI.CartId
                    INNER JOIN Products P ON CI.ProductId = P.ProductId
                    WHERE C.CustomerUserId = @CustomerUserId
                    ORDER BY CI.CartItemId DESC
                ";

                SqlParameter[] parameters =
                {
                    new SqlParameter("@CustomerUserId", SessionManager.UserId)
                };

                cartTable = DatabaseHelper.GetDataTable(query, parameters);

                RenderCartItems();
                UpdateSummary();
                UpdateSelectedCount();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cart load error: " + ex.Message);
            }
        }

        private void RenderCartItems()
        {
            flowCartItems.Controls.Clear();

            foreach (DataRow row in cartTable.Rows)
            {
                Panel itemPanel = new Panel();
                itemPanel.Width = flowCartItems.ClientSize.Width - 25;
                itemPanel.Height = 90;
                itemPanel.BorderStyle = BorderStyle.FixedSingle;
                itemPanel.BackColor = Color.White;
                itemPanel.Margin = new Padding(0, 0, 0, 5);

                CheckBox chkSelect = new CheckBox();
                chkSelect.Name = "chkSelect";
                chkSelect.Left = 10;
                chkSelect.Top = 34;
                chkSelect.Width = 20;
                chkSelect.Tag = row["CartItemId"];
                chkSelect.CheckedChanged += ItemCheckBox_CheckedChanged;

                PictureBox pic = new PictureBox();
                pic.Name = "picProduct";
                pic.Left = 40;
                pic.Top = 15;
                pic.Width = 55;
                pic.Height = 55;
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.BorderStyle = BorderStyle.FixedSingle;
                LoadImageToPictureBox(pic, row["ImagePath"].ToString() ?? "");

                Label lblProduct = new Label();
                lblProduct.Name = "lblProduct";
                lblProduct.Text = row["ProductName"].ToString();
                lblProduct.Left = 115;
                lblProduct.Top = 18;
                lblProduct.Width = 250;
                lblProduct.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                lblProduct.ForeColor = Color.FromArgb(75, 0, 130);

                Label lblPrice = new Label();
                lblPrice.Name = "lblPrice";
                lblPrice.Text = "$" + Convert.ToDecimal(row["Price"]).ToString("0.00");
                lblPrice.Left = 390;
                lblPrice.Top = 22;
                lblPrice.Width = 80;
                lblPrice.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                lblPrice.ForeColor = Color.Black;

                NumericUpDown nudQty = new NumericUpDown();
                nudQty.Name = "nudQty";
                nudQty.Left = 500;
                nudQty.Top = 18;
                nudQty.Width = 70;
                nudQty.Minimum = 1;
                nudQty.Maximum = 1000;
                nudQty.Value = Convert.ToDecimal(row["Quantity"]);
                nudQty.Tag = row["CartItemId"];

                Label lblSubtotal = new Label();
                lblSubtotal.Name = "lblSubtotal";
                lblSubtotal.Text = "$" + Convert.ToDecimal(row["Subtotal"]).ToString("0.00");
                lblSubtotal.Left = 610;
                lblSubtotal.Top = 22;
                lblSubtotal.Width = 100;
                lblSubtotal.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                lblSubtotal.ForeColor = Color.Black;

                Label lblHiddenCartId = new Label();
                lblHiddenCartId.Name = "lblCartItemId";
                lblHiddenCartId.Text = row["CartItemId"].ToString();
                lblHiddenCartId.Visible = false;

                itemPanel.Controls.Add(chkSelect);
                itemPanel.Controls.Add(pic);
                itemPanel.Controls.Add(lblProduct);
                itemPanel.Controls.Add(lblPrice);
                itemPanel.Controls.Add(nudQty);
                itemPanel.Controls.Add(lblSubtotal);
                itemPanel.Controls.Add(lblHiddenCartId);

                flowCartItems.Controls.Add(itemPanel);
            }
        }

        private void LoadImageToPictureBox(PictureBox pic, string imagePath)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(imagePath) && File.Exists(imagePath))
                {
                    byte[] bytes = File.ReadAllBytes(imagePath);

                    using (MemoryStream ms = new MemoryStream(bytes))
                    using (Image temp = Image.FromStream(ms))
                    {
                        pic.Image = new Bitmap(temp);
                    }
                }
                else
                {
                    pic.Image = null;
                }
            }
            catch
            {
                pic.Image = null;
            }
        }

        private void ItemCheckBox_CheckedChanged(object? sender, EventArgs e)
        {
            UpdateSelectedCount();
            UpdateSelectAllState();
        }

        private void chkSelectAll_CheckedChanged(object? sender, EventArgs e)
        {
            foreach (Control ctrl in flowCartItems.Controls)
            {
                if (ctrl is Panel panel)
                {
                    CheckBox? chk = panel.Controls["chkSelect"] as CheckBox;
                    if (chk != null)
                        chk.Checked = chkSelectAll.Checked;
                }
            }

            UpdateSelectedCount();
        }

        private void UpdateSelectAllState()
        {
            if (flowCartItems.Controls.Count == 0)
            {
                chkSelectAll.Checked = false;
                return;
            }

            bool allChecked = true;

            foreach (Control ctrl in flowCartItems.Controls)
            {
                if (ctrl is Panel panel)
                {
                    CheckBox? chk = panel.Controls["chkSelect"] as CheckBox;
                    if (chk != null && !chk.Checked)
                    {
                        allChecked = false;
                        break;
                    }
                }
            }

            chkSelectAll.CheckedChanged -= chkSelectAll_CheckedChanged;
            chkSelectAll.Checked = allChecked;
            chkSelectAll.CheckedChanged += chkSelectAll_CheckedChanged;
        }

        private void UpdateSelectedCount()
        {
            int count = 0;

            foreach (Control ctrl in flowCartItems.Controls)
            {
                if (ctrl is Panel panel)
                {
                    CheckBox? chk = panel.Controls["chkSelect"] as CheckBox;
                    if (chk != null && chk.Checked)
                        count++;
                }
            }

            lblSelectedItems.Text = "Selected Items: " + count;
        }

        private void UpdateSummary()
        {
            decimal subtotal = 0m;
            decimal discount = 0m;
            decimal shipping = 0m;
            decimal tax = 0m;

            foreach (DataRow row in cartTable.Rows)
            {
                subtotal += Convert.ToDecimal(row["Subtotal"]);
            }

            decimal total = subtotal - discount + shipping + tax;

            lblSubtotal.Text = "$" + subtotal.ToString("0.00");
            lblDiscount.Text = "-$" + discount.ToString("0.00");
            lblShipping.Text = "$" + shipping.ToString("0.00");
            lblTax.Text = "$" + tax.ToString("0.00");
            lblTotalAmount.Text = "$" + total.ToString("0.00");
        }

        private void btnRemoveSelected_Click(object? sender, EventArgs e)
        {
            try
            {
                var selectedPanels = flowCartItems.Controls
                    .OfType<Panel>()
                    .Where(panel =>
                    {
                        CheckBox? chk = panel.Controls["chkSelect"] as CheckBox;
                        return chk != null && chk.Checked;
                    })
                    .ToList();

                if (selectedPanels.Count == 0)
                {
                    MessageBox.Show("Please select cart item(s) to remove.");
                    return;
                }

                DialogResult dr = MessageBox.Show(
                    "Are you sure you want to remove selected item(s)?",
                    "Confirm Remove",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (dr != DialogResult.Yes)
                    return;

                foreach (Panel panel in selectedPanels)
                {
                    Label? lblId = panel.Controls["lblCartItemId"] as Label;
                    if (lblId != null)
                    {
                        int cartItemId = Convert.ToInt32(lblId.Text);

                        string deleteQuery = "DELETE FROM CartItems WHERE CartItemId = @CartItemId";
                        SqlParameter[] parameters =
                        {
                            new SqlParameter("@CartItemId", cartItemId)
                        };

                        DatabaseHelper.ExecuteNonQuery(deleteQuery, parameters);
                    }
                }

                MessageBox.Show("Selected item(s) removed successfully.");
                LoadCartItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Remove error: " + ex.Message);
            }
        }

        private void btnUpdateQuantity_Click(object? sender, EventArgs e)
        {
            try
            {
                var selectedPanels = flowCartItems.Controls
                    .OfType<Panel>()
                    .Where(panel =>
                    {
                        CheckBox? chk = panel.Controls["chkSelect"] as CheckBox;
                        return chk != null && chk.Checked;
                    })
                    .ToList();

                if (selectedPanels.Count == 0)
                {
                    MessageBox.Show("Please select at least one cart item.");
                    return;
                }

                foreach (Panel panel in selectedPanels)
                {
                    Label? lblId = panel.Controls["lblCartItemId"] as Label;
                    NumericUpDown? nudQty = panel.Controls["nudQty"] as NumericUpDown;

                    if (lblId != null && nudQty != null)
                    {
                        int cartItemId = Convert.ToInt32(lblId.Text);
                        int qty = Convert.ToInt32(nudQty.Value);

                        string updateQuery = @"
                            UPDATE CartItems
                            SET Quantity = @Quantity
                            WHERE CartItemId = @CartItemId
                        ";

                        SqlParameter[] parameters =
                        {
                            new SqlParameter("@Quantity", qty),
                            new SqlParameter("@CartItemId", cartItemId)
                        };

                        DatabaseHelper.ExecuteNonQuery(updateQuery, parameters);
                    }
                }

                MessageBox.Show("Quantity updated successfully.");
                LoadCartItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update quantity error: " + ex.Message);
            }
        }

        private void btnCheckout_Click(object? sender, EventArgs e)
        {
            try
            {
                if (cartTable == null || cartTable.Rows.Count == 0)
                {
                    MessageBox.Show("Your cart is empty.");
                    return;
                }

                CheckoutForm form = new CheckoutForm();
                form.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Checkout error: " + ex.Message);
            }
        }

        private void btnContinueShopping_Click(object? sender, EventArgs e)
        {
            CustomerDashboardForm form = new CustomerDashboardForm();
            form.Show();
            this.Hide();
        }
        private void CartForm_Load_1(object sender, EventArgs e)
        {
        }

        private void btnContinueShopping_Click_1(object sender, EventArgs e)
        {

        }
    }
}