using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Cosmatic_Shop_Management.DAL;

namespace Cosmatic_Shop_Management.Forms
{
    public partial class MaleProductsForm : Form
    {
        private DataTable allProducts = new DataTable();
        private int currentPage = 1;
        private int pageSize = 6;
        private string currentSort = "Newest";

        public MaleProductsForm()
        {
            InitializeComponent();

            this.Load += MaleProductsForm_Load;

            btnGoBack.Click -= btnGoBack_Click;
            btnGoBack.Click += btnGoBack_Click;

            btnApplyFilters.Click -= btnApplyFilters_Click;
            btnApplyFilters.Click += btnApplyFilters_Click;

            btnSortNewest.Click -= btnSortNewest_Click;
            btnSortNewest.Click += btnSortNewest_Click;

            btnPrevPage.Click -= btnPrevPage_Click;
            btnPrevPage.Click += btnPrevPage_Click;

            btnNextPage.Click -= btnNextPage_Click;
            btnNextPage.Click += btnNextPage_Click;

            btnPage1.Click -= btnPage1_Click;
            btnPage1.Click += btnPage1_Click;

            btnPage2.Click -= btnPage2_Click;
            btnPage2.Click += btnPage2_Click;

            btnPage3.Click -= btnPage3_Click;
            btnPage3.Click += btnPage3_Click;

            btnNotification.Click -= btnNotification_Click;
            btnNotification.Click += btnNotification_Click;

            btnProfile.Click -= btnProfile_Click;
            btnProfile.Click += btnProfile_Click;

            txtSearchProducts.TextChanged -= txtSearchProducts_TextChanged;
            txtSearchProducts.TextChanged += txtSearchProducts_TextChanged;

            chkSkincare.CheckedChanged -= FilterControl_Changed;
            chkSkincare.CheckedChanged += FilterControl_Changed;

            chkBeardGrooming.CheckedChanged -= FilterControl_Changed;
            chkBeardGrooming.CheckedChanged += FilterControl_Changed;

            chkFragrance.CheckedChanged -= FilterControl_Changed;
            chkFragrance.CheckedChanged += FilterControl_Changed;

            chkHairCare.CheckedChanged -= FilterControl_Changed;
            chkHairCare.CheckedChanged += FilterControl_Changed;

            rdoInStock.CheckedChanged -= FilterControl_Changed;
            rdoInStock.CheckedChanged += FilterControl_Changed;

            rdoLowStock.CheckedChanged -= FilterControl_Changed;
            rdoLowStock.CheckedChanged += FilterControl_Changed;

            rdoOutOfStock.CheckedChanged -= FilterControl_Changed;
            rdoOutOfStock.CheckedChanged += FilterControl_Changed;

            trkPriceRange.Scroll -= trkPriceRange_Scroll;
            trkPriceRange.Scroll += trkPriceRange_Scroll;
        }

        private void MaleProductsForm_Load(object? sender, EventArgs e)
        {
            SetupUI();
            LoadProductsFromDatabase();
            ApplyFiltersAndRender();
        }

        private void SetupUI()
        {
            this.Text = "Men's Cosmetic Products";

            lblFormTitle.Text = "Men's Cosmetic Products";
            lblFilterTitle.Text = "PRODUCT FILTERS";
            lblCategoryTitle.Text = "Category";
            lblStockStatusTitle.Text = "Stock Status";
            lblPriceRangeTitle.Text = "Price Range";

            chkSkincare.Text = "Skin Care";
            chkBeardGrooming.Text = "Beard Grooming";
            chkFragrance.Text = "Fragrance";
            chkHairCare.Text = "Hair Care";

            rdoInStock.Text = "In Stock";
            rdoLowStock.Text = "Low Stock";
            rdoOutOfStock.Text = "Out Of Stock";

            flpFemaleProducts.AutoScroll = true;
            flpFemaleProducts.WrapContents = true;
            flpFemaleProducts.FlowDirection = FlowDirection.LeftToRight;

            trkPriceRange.Minimum = 0;
            trkPriceRange.Maximum = 10000;
            trkPriceRange.SmallChange = 10;
            trkPriceRange.LargeChange = 25;
            trkPriceRange.TickFrequency = 100;
            trkPriceRange.Value = 10000;

            lblMinPrice.Text = "0Tk";
            lblMaxPrice.Text = "10000+Tk";

            currentSort = "Newest";
            btnSortNewest.Text = "↕ Sort: Newest";

            HighlightCurrentPageButton();
        }

        private void LoadProductsFromDatabase()
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
                        P.GenderSection,
                        P.ImagePath,
                        P.IsHighlighted,
                        P.IsActive,
                        P.CreatedAt,
                        C.CategoryName
                    FROM Products P
                    INNER JOIN Categories C ON P.CategoryId = C.CategoryId
                    WHERE P.GenderSection = 'Male' AND P.IsActive = 1
                ";

                allProducts = DatabaseHelper.GetDataTable(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Product load error: " + ex.Message);
            }
        }

        private void ApplyFiltersAndRender()
        {
            try
            {
                if (allProducts == null || allProducts.Rows.Count == 0)
                {
                    flpFemaleProducts.Controls.Clear();
                    return;
                }

                var rows = allProducts.AsEnumerable();

                string search = txtSearchProducts.Text.Trim().ToLower();

                if (!string.IsNullOrWhiteSpace(search) &&
                    !search.Equals("Search Inventory", StringComparison.OrdinalIgnoreCase))
                {
                    rows = rows.Where(r =>
                        (r["ProductName"].ToString() ?? "").ToLower().Contains(search) ||
                        (r["CategoryName"].ToString() ?? "").ToLower().Contains(search) ||
                        (r["Description"].ToString() ?? "").ToLower().Contains(search));
                }

                string[] selectedCategories = GetSelectedCategories();
                if (selectedCategories.Length > 0)
                {
                    rows = rows.Where(r =>
                        selectedCategories.Contains(r["CategoryName"].ToString() ?? ""));
                }

                int maxPrice = trkPriceRange.Value;
                rows = rows.Where(r => Convert.ToDecimal(r["Price"]) <= maxPrice);

                if (rdoInStock.Checked)
                {
                    rows = rows.Where(r => Convert.ToInt32(r["StockQty"]) > 10);
                }
                else if (rdoLowStock.Checked)
                {
                    rows = rows.Where(r =>
                    {
                        int stock = Convert.ToInt32(r["StockQty"]);
                        return stock > 0 && stock <= 10;
                    });
                }
                else if (rdoOutOfStock.Checked)
                {
                    rows = rows.Where(r => Convert.ToInt32(r["StockQty"]) <= 0);
                }

                DataTable filtered = rows.Any() ? rows.CopyToDataTable() : allProducts.Clone();

                if (filtered.Rows.Count > 0)
                {
                    if (currentSort == "Newest")
                    {
                        filtered = filtered.AsEnumerable()
                            .OrderByDescending(r => Convert.ToDateTime(r["CreatedAt"]))
                            .CopyToDataTable();
                    }
                    else if (currentSort == "PriceLowHigh")
                    {
                        filtered = filtered.AsEnumerable()
                            .OrderBy(r => Convert.ToDecimal(r["Price"]))
                            .CopyToDataTable();
                    }
                    else if (currentSort == "PriceHighLow")
                    {
                        filtered = filtered.AsEnumerable()
                            .OrderByDescending(r => Convert.ToDecimal(r["Price"]))
                            .CopyToDataTable();
                    }
                }

                RenderPagedProducts(filtered);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Filter error: " + ex.Message);
            }
        }

        private void RenderPagedProducts(DataTable filtered)
        {
            flpFemaleProducts.Controls.Clear();

            int totalRows = filtered.Rows.Count;
            int totalPages = (int)Math.Ceiling(totalRows / (double)pageSize);

            if (totalPages == 0)
                totalPages = 1;

            if (currentPage < 1)
                currentPage = 1;

            if (currentPage > totalPages)
                currentPage = totalPages;

            int start = (currentPage - 1) * pageSize;
            int end = Math.Min(start + pageSize, totalRows);

            for (int i = start; i < end; i++)
            {
                DataRow row = filtered.Rows[i];
                Panel card = CreateProductCard(row);
                flpFemaleProducts.Controls.Add(card);
            }

            btnPrevPage.Enabled = currentPage > 1;
            btnNextPage.Enabled = currentPage < totalPages;

            btnPage1.Visible = totalPages >= 1;
            btnPage2.Visible = totalPages >= 2;
            btnPage3.Visible = totalPages >= 3;

            HighlightCurrentPageButton();
        }

        private Panel CreateProductCard(DataRow row)
        {
            int productId = Convert.ToInt32(row["ProductId"]);
            string productName = row["ProductName"].ToString() ?? "";
            string category = row["CategoryName"].ToString() ?? "";
            decimal price = Convert.ToDecimal(row["Price"]);
            int stockQty = Convert.ToInt32(row["StockQty"]);
            string imagePath = row["ImagePath"].ToString() ?? "";

            Panel card = new Panel();
            card.Width = 270;
            card.Height = 260;
            card.BorderStyle = BorderStyle.FixedSingle;
            card.BackColor = Color.White;
            card.Margin = new Padding(10);
            card.Cursor = Cursors.Hand;
            card.Tag = productId;
            card.Click += ProductCard_Click;

            PictureBox pic = new PictureBox();
            pic.Left = 15;
            pic.Top = 15;
            pic.Width = 238;
            pic.Height = 140;
            pic.BorderStyle = BorderStyle.FixedSingle;
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.BackColor = Color.WhiteSmoke;
            pic.Tag = productId;
            pic.Click += ProductCard_Click;
            LoadImage(pic, imagePath);

            Label lblName = new Label();
            lblName.Left = 15;
            lblName.Top = 165;
            lblName.Width = 238;
            lblName.Height = 25;
            lblName.Text = productName;
            lblName.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lblName.ForeColor = Color.FromArgb(75, 0, 130);
            lblName.Tag = productId;
            lblName.Click += ProductCard_Click;

            Label lblCategory = new Label();
            lblCategory.Left = 15;
            lblCategory.Top = 192;
            lblCategory.Width = 160;
            lblCategory.Height = 22;
            lblCategory.Text = category;
            lblCategory.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            lblCategory.ForeColor = Color.DimGray;
            lblCategory.Tag = productId;
            lblCategory.Click += ProductCard_Click;

            Label lblPrice = new Label();
            lblPrice.Left = 15;
            lblPrice.Top = 220;
            lblPrice.Width = 90;
            lblPrice.Height = 25;
            lblPrice.Text = "Tk" + price.ToString("0.00");
            lblPrice.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lblPrice.ForeColor = Color.FromArgb(75, 0, 130);
            lblPrice.Tag = productId;
            lblPrice.Click += ProductCard_Click;

            Label lblStock = new Label();
            lblStock.Left = 145;
            lblStock.Top = 222;
            lblStock.Width = 108;
            lblStock.Height = 22;
            lblStock.Text = GetStockText(stockQty);
            lblStock.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            lblStock.ForeColor = GetStockColor(stockQty);
            lblStock.TextAlign = ContentAlignment.MiddleRight;
            lblStock.Tag = productId;
            lblStock.Click += ProductCard_Click;

            card.Controls.Add(pic);
            card.Controls.Add(lblName);
            card.Controls.Add(lblCategory);
            card.Controls.Add(lblPrice);
            card.Controls.Add(lblStock);

            return card;
        }

        private void LoadImage(PictureBox pic, string imagePath)
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

        private string[] GetSelectedCategories()
        {
            var list = new System.Collections.Generic.List<string>();

            if (chkSkincare.Checked)
                list.Add("Skin Care");

            if (chkBeardGrooming.Checked)
                list.Add("Beard Grooming");

            if (chkFragrance.Checked)
                list.Add("Fragrance");

            if (chkHairCare.Checked)
                list.Add("Hair Care");

            return list.Distinct().ToArray();
        }

        private string GetStockText(int stockQty)
        {
            if (stockQty <= 0)
                return "OUT OF STOCK";

            if (stockQty <= 10)
                return "LOW STOCK";

            return stockQty + " IN STOCK";
        }

        private Color GetStockColor(int stockQty)
        {
            if (stockQty <= 0)
                return Color.Red;

            if (stockQty <= 10)
                return Color.DarkGoldenrod;

            return Color.Green;
        }

        private void ProductCard_Click(object? sender, EventArgs e)
        {
            try
            {
                int productId = -1;

                if (sender is Control ctrl && ctrl.Tag != null)
                    productId = Convert.ToInt32(ctrl.Tag);

                if (productId <= 0)
                    return;

                ProductDetailsForm form = new ProductDetailsForm();

                var prop = form.GetType().GetProperty("ProductId");
                if (prop != null && prop.CanWrite)
                    prop.SetValue(form, productId);

                form.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Open product details error: " + ex.Message);
            }
        }

        private void FilterControl_Changed(object? sender, EventArgs e)
        {
            currentPage = 1;
            ApplyFiltersAndRender();
        }

        private void txtSearchProducts_TextChanged(object? sender, EventArgs e)
        {
            currentPage = 1;
            ApplyFiltersAndRender();
        }

        private void trkPriceRange_Scroll(object? sender, EventArgs e)
        {
            lblMaxPrice.Text = "Tk" + trkPriceRange.Value + (trkPriceRange.Value >= 500 ? "+" : "");
            currentPage = 1;
            ApplyFiltersAndRender();
        }

        private void btnApplyFilters_Click(object? sender, EventArgs e)
        {
            currentPage = 1;
            ApplyFiltersAndRender();
        }

        private void btnSortNewest_Click(object? sender, EventArgs e)
        {
            if (currentSort == "Newest")
                currentSort = "PriceLowHigh";
            else if (currentSort == "PriceLowHigh")
                currentSort = "PriceHighLow";
            else
                currentSort = "Newest";

            if (currentSort == "Newest")
                btnSortNewest.Text = "↕ Sort: Newest";
            else if (currentSort == "PriceLowHigh")
                btnSortNewest.Text = "↕ Sort: Price Low";
            else
                btnSortNewest.Text = "↕ Sort: Price High";

            currentPage = 1;
            ApplyFiltersAndRender();
        }

        private void btnPrevPage_Click(object? sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                ApplyFiltersAndRender();
            }
        }

        private void btnNextPage_Click(object? sender, EventArgs e)
        {
            currentPage++;
            ApplyFiltersAndRender();
        }

        private void btnPage1_Click(object? sender, EventArgs e)
        {
            currentPage = 1;
            ApplyFiltersAndRender();
        }

        private void btnPage2_Click(object? sender, EventArgs e)
        {
            currentPage = 2;
            ApplyFiltersAndRender();
        }

        private void btnPage3_Click(object? sender, EventArgs e)
        {
            currentPage = 3;
            ApplyFiltersAndRender();
        }

        private void HighlightCurrentPageButton()
        {
            ResetPageButton(btnPage1);
            ResetPageButton(btnPage2);
            ResetPageButton(btnPage3);

            if (currentPage == 1)
                SetActivePageButton(btnPage1);
            else if (currentPage == 2)
                SetActivePageButton(btnPage2);
            else if (currentPage == 3)
                SetActivePageButton(btnPage3);
        }

        private void ResetPageButton(Button btn)
        {
            btn.BackColor = Color.White;
            btn.ForeColor = Color.Black;
            btn.FlatStyle = FlatStyle.Flat;
        }

        private void SetActivePageButton(Button btn)
        {
            btn.BackColor = Color.Purple;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
        }

        private void btnGoBack_Click(object? sender, EventArgs e)
        {
            CustomerDashboardForm form = new CustomerDashboardForm();
            form.Show();
            this.Hide();
        }

        private void btnNotification_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Notification feature will be added.");
        }

        private void btnProfile_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Profile feature will be added.");
        }
    }
}