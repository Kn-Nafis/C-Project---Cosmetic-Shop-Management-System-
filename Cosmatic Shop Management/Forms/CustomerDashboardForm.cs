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
    public partial class CustomerDashboardForm : Form
    {
        public CustomerDashboardForm()
        {
            InitializeComponent();

            this.Load += CustomerDashboardForm_Load;

            txtSearchProducts.TextChanged -= txtSearchProducts_TextChanged;
            txtSearchProducts.TextChanged += txtSearchProducts_TextChanged;

            btnCart.Click -= btnCart_Click;
            btnCart.Click += btnCart_Click;

            btnLogout.Click -= btnLogout_Click;
            btnLogout.Click += btnLogout_Click;

            btnShopCollection.Click -= btnShopCollection_Click;
            btnShopCollection.Click += btnShopCollection_Click;

            btnProfile.Click -= btnProfile_Click;
            btnProfile.Click += btnProfile_Click;

            pnlMaleSection.Click -= pnlMaleSection_Click;
            pnlMaleSection.Click += pnlMaleSection_Click;

            pnlFemaleSection.Click -= pnlFemaleSection_Click;
            pnlFemaleSection.Click += pnlFemaleSection_Click;
        }

        private void CustomerDashboardForm_Load(object? sender, EventArgs e)
        {
            SetupStaticUI();
            AttachSectionClicks();
            LoadHighlightedProducts();
        }

        private void SetupStaticUI()
        {
            this.Text = "Customer Dashboard";

            if (ControlExists("lblBrandText"))
                lblBrandText.Text = "Glow & Co.";

            if (ControlExists("lblHeroTitle"))
                lblHeroTitle.Text = "Luminous Bloom: New Arrivals 2024";

            if (ControlExists("lblHighlightedProductsTitle"))
                lblHighlightedProductsTitle.Text = "Highlighted Products";

            if (ControlExists("lblHighlightedProductsSubtitle"))
                lblHighlightedProductsSubtitle.Text = "Our most coveted items for this month.";

            if (ControlExists("lblMaleTitle"))
                lblMaleTitle.Text = "Male";

            if (ControlExists("lblFemaleTitle"))
                lblFemaleTitle.Text = "Female";
        }

        private void AttachSectionClicks()
        {
            AttachClickToAllChildren(pnlMaleSection, pnlMaleSection_Click);
            AttachClickToAllChildren(pnlFemaleSection, pnlFemaleSection_Click);
        }

        private void AttachClickToAllChildren(Control parent, EventHandler clickHandler)
        {
            foreach (Control control in parent.Controls)
            {
                control.Click -= clickHandler;
                control.Click += clickHandler;

                if (control.HasChildren)
                {
                    AttachClickToAllChildren(control, clickHandler);
                }
            }
        }

        private void LoadHighlightedProducts(string searchText = "")
        {
            try
            {
                flpHighlightedProducts.Controls.Clear();

                string query = @"
                    SELECT TOP 20
                        P.ProductId,
                        P.ProductName,
                        P.Price,
                        P.ImagePath,
                        P.StockQty,
                        ISNULL(AVG(CAST(R.Rating AS FLOAT)), 0) AS AvgRating
                    FROM Products P
                    LEFT JOIN Reviews R ON P.ProductId = R.ProductId
                    WHERE P.IsActive = 1
                      AND P.IsHighlighted = 1
                ";

                SqlParameter[]? parameters = null;

                if (!string.IsNullOrWhiteSpace(searchText))
                {
                    query += " AND P.ProductName LIKE @SearchText";
                    parameters = new SqlParameter[]
                    {
                        new SqlParameter("@SearchText", "%" + searchText.Trim() + "%")
                    };
                }

                query += @"
                    GROUP BY
                        P.ProductId,
                        P.ProductName,
                        P.Price,
                        P.ImagePath,
                        P.StockQty
                    ORDER BY P.ProductId DESC
                ";

                DataTable dt = DatabaseHelper.GetDataTable(query, parameters);

                foreach (DataRow row in dt.Rows)
                {
                    int productId = Convert.ToInt32(row["ProductId"]);
                    string productName = row["ProductName"].ToString() ?? "";
                    decimal price = Convert.ToDecimal(row["Price"]);
                    string imagePath = row["ImagePath"].ToString() ?? "";
                    int stockQty = Convert.ToInt32(row["StockQty"]);
                    double rating = Convert.ToDouble(row["AvgRating"]);

                    Panel card = new Panel();
                    card.Width = 240;
                    card.Height = 315;
                    card.BorderStyle = BorderStyle.FixedSingle;
                    card.BackColor = Color.White;
                    card.Margin = new Padding(10);
                    card.Cursor = Cursors.Hand;
                    card.Tag = productId;

                    PictureBox pic = new PictureBox();
                    pic.Left = 10;
                    pic.Top = 10;
                    pic.Width = 218;
                    pic.Height = 170;
                    pic.BorderStyle = BorderStyle.FixedSingle;
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic.BackColor = Color.WhiteSmoke;
                    pic.Tag = productId;

                    try
                    {
                        if (!string.IsNullOrWhiteSpace(imagePath) && File.Exists(imagePath))
                        {
                            byte[] bytes = File.ReadAllBytes(imagePath);
                            using (MemoryStream ms = new MemoryStream(bytes))
                            using (Image img = Image.FromStream(ms))
                            {
                                pic.Image = new Bitmap(img);
                            }
                        }
                    }
                    catch
                    {
                        pic.Image = null;
                    }

                    Label lblName = new Label();
                    lblName.Left = 10;
                    lblName.Top = 190;
                    lblName.Width = 218;
                    lblName.Height = 45;
                    lblName.Text = productName;
                    lblName.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                    lblName.ForeColor = Color.Black;
                    lblName.Tag = productId;

                    Label lblPrice = new Label();
                    lblPrice.Left = 10;
                    lblPrice.Top = 240;
                    lblPrice.Width = 120;
                    lblPrice.Text = price.ToString("0.00") + " Tk";
                    lblPrice.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                    lblPrice.ForeColor = Color.Purple;
                    lblPrice.Tag = productId;

                    Label lblStock = new Label();
                    lblStock.Left = 135;
                    lblStock.Top = 242;
                    lblStock.Width = 90;
                    lblStock.Text = stockQty > 0 ? "In Stock" : "Out";
                    lblStock.Font = new Font("Segoe UI", 9, FontStyle.Regular);
                    lblStock.ForeColor = stockQty > 0 ? Color.Green : Color.Red;
                    lblStock.Tag = productId;

                    Label lblRating = new Label();
                    lblRating.Left = 10;
                    lblRating.Top = 270;
                    lblRating.Width = 150;
                    lblRating.Text = "Rating: " + rating.ToString("0.0");
                    lblRating.Font = new Font("Segoe UI", 9, FontStyle.Regular);
                    lblRating.ForeColor = Color.DimGray;
                    lblRating.Tag = productId;

                    Button btnView = new Button();
                    btnView.Left = 130;
                    btnView.Top = 265;
                    btnView.Width = 95;
                    btnView.Height = 30;
                    btnView.Text = "View";
                    btnView.BackColor = Color.Coral;
                    btnView.ForeColor = Color.White;
                    btnView.FlatStyle = FlatStyle.Flat;
                    btnView.FlatAppearance.BorderSize = 0;
                    btnView.Tag = productId;
                    btnView.Click += ProductOpen_Click;

                    card.Click += ProductOpen_Click;
                    pic.Click += ProductOpen_Click;
                    lblName.Click += ProductOpen_Click;
                    lblPrice.Click += ProductOpen_Click;
                    lblStock.Click += ProductOpen_Click;
                    lblRating.Click += ProductOpen_Click;

                    card.Controls.Add(pic);
                    card.Controls.Add(lblName);
                    card.Controls.Add(lblPrice);
                    card.Controls.Add(lblStock);
                    card.Controls.Add(lblRating);
                    card.Controls.Add(btnView);

                    flpHighlightedProducts.Controls.Add(card);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Highlighted products load error: " + ex.Message);
            }
        }

        private void ProductOpen_Click(object? sender, EventArgs e)
        {
            try
            {
                Control? clickedControl = sender as Control;
                if (clickedControl == null || clickedControl.Tag == null)
                    return;

                int productId = Convert.ToInt32(clickedControl.Tag);

                ProductDetailsForm form = new ProductDetailsForm(productId);
                form.ShowDialog();

                LoadHighlightedProducts(txtSearchProducts.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Open product error: " + ex.Message);
            }
        }

        private void txtSearchProducts_TextChanged(object? sender, EventArgs e)
        {
            LoadHighlightedProducts(txtSearchProducts.Text.Trim());
        }

        private void btnCart_Click(object? sender, EventArgs e)
        {
            CartForm form = new CartForm();
            form.ShowDialog();
            LoadHighlightedProducts(txtSearchProducts.Text.Trim());
        }

        private void btnLogout_Click(object? sender, EventArgs e)
        {
            SessionManager.Clear();

            LoginForm form = new LoginForm();
            form.Show();
            this.Close();
        }

        private void btnShopCollection_Click(object? sender, EventArgs e)
        {
            LoadHighlightedProducts();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            MyOrdersForm form = new MyOrdersForm();
            form.ShowDialog();
            LoadHighlightedProducts(txtSearchProducts.Text.Trim());
        }

        private void pnlMaleSection_Click(object? sender, EventArgs e)
        {
            MaleProductsForm form = new MaleProductsForm();
            form.ShowDialog();
            LoadHighlightedProducts(txtSearchProducts.Text.Trim());
        }

        private void pnlFemaleSection_Click(object? sender, EventArgs e)
        {
            FemaleProductsForm form = new FemaleProductsForm();
            form.ShowDialog();
            LoadHighlightedProducts(txtSearchProducts.Text.Trim());
        }

        private bool ControlExists(string controlName)
        {
            return FindControlRecursive(this, controlName) != null;
        }

        private Control? FindControlRecursive(Control parent, string controlName)
        {
            foreach (Control control in parent.Controls)
            {
                if (control.Name == controlName)
                    return control;

                Control? child = FindControlRecursive(control, controlName);
                if (child != null)
                    return child;
            }

            return null;
        }

        private void picFemaleSection_Click(object sender, EventArgs e)
        {
        }

        private void pnlFemaleSection_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pnlMaleSection_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}