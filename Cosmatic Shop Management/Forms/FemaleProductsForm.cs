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
    public partial class FemaleProductsForm : Form
    {
        private int currentPage = 1;
        private int pageSize = 8;
        private DataTable allProducts = new DataTable();

        public FemaleProductsForm()
        {
            InitializeComponent();

            this.Load += FemaleProductsForm_Load;

            btnGoBack.Click -= btnGoBack_Click;
            btnGoBack.Click += btnGoBack_Click;

            btnApplyFilters.Click -= btnApplyFilters_Click;
            btnApplyFilters.Click += btnApplyFilters_Click;

            btnSortNewest.Click -= btnSortNewest_Click;
            btnSortNewest.Click += btnSortNewest_Click;

            txtSearchProducts.TextChanged -= txtSearchProducts_TextChanged;
            txtSearchProducts.TextChanged += txtSearchProducts_TextChanged;

            trkPriceRange.Scroll -= trkPriceRange_Scroll;
            trkPriceRange.Scroll += trkPriceRange_Scroll;

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
        }

        private void FemaleProductsForm_Load(object? sender, EventArgs e)
        {
            SetupStaticUI();
            LoadAllFemaleProducts();
            ApplyFiltersAndRender();
        }

        private void SetupStaticUI()
        {
            this.Text = "Women's Cosmetic Products";
            lblFormTitle.Text = "Women's Cosmetic Products";

            lblMinPrice.Text = "$0";
            lblMaxPrice.Text = "$500+";

            trkPriceRange.Minimum = 0;
            trkPriceRange.Maximum = 500;
            trkPriceRange.TickFrequency = 50;
            trkPriceRange.Value = 500;

            rdoInStock.Checked = false;
            rdoLowStock.Checked = false;
            rdoOutOfStock.Checked = false;

            HighlightCurrentPageButton();
        }

        private void LoadAllFemaleProducts()
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
                        C.CategoryName,
                        P.CreatedAt,
                        ISNULL(AVG(CAST(R.Rating AS FLOAT)), 0) AS AvgRating
                    FROM Products P
                    INNER JOIN Categories C ON P.CategoryId = C.CategoryId
                    LEFT JOIN Reviews R ON P.ProductId = R.ProductId
                    WHERE P.IsActive = 1
                      AND P.GenderSection = 'Female'
                    GROUP BY
                        P.ProductId,
                        P.ProductName,
                        P.Description,
                        P.Price,
                        P.StockQty,
                        P.SoldQty,
                        P.ImagePath,
                        C.CategoryName,
                        P.CreatedAt
                    ORDER BY P.CreatedAt DESC, P.ProductId DESC
                ";

                allProducts = DatabaseHelper.GetDataTable(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Female products load error: " + ex.Message);
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

                var filteredRows = allProducts.AsEnumerable();

                string searchText = txtSearchProducts.Text.Trim().ToLower();
                if (!string.IsNullOrWhiteSpace(searchText))
                {
                    filteredRows = filteredRows.Where(row =>
                        row["ProductName"].ToString()!.ToLower().Contains(searchText) ||
                        row["CategoryName"].ToString()!.ToLower().Contains(searchText) ||
                        row["Description"].ToString()!.ToLower().Contains(searchText));
                }

                var selectedCategories = new System.Collections.Generic.List<string>();

                if (chkSkincare.Checked) selectedCategories.Add("Skincare");
                if (chkMakeup.Checked) selectedCategories.Add("Makeup");
                if (chkFragrance.Checked) selectedCategories.Add("Fragrance");
                if (chkHairCare.Checked) selectedCategories.Add("Hair Care");

                if (selectedCategories.Count > 0)
                {
                    filteredRows = filteredRows.Where(row =>
                        selectedCategories.Contains(row["CategoryName"].ToString()!));
                }

                if (rdoInStock.Checked)
                {
                    filteredRows = filteredRows.Where(row => Convert.ToInt32(row["StockQty"]) > 10);
                }
                else if (rdoLowStock.Checked)
                {
                    filteredRows = filteredRows.Where(row =>
                    {
                        int stock = Convert.ToInt32(row["StockQty"]);
                        return stock > 0 && stock <= 10;
                    });
                }
                else if (rdoOutOfStock.Checked)
                {
                    filteredRows = filteredRows.Where(row => Convert.ToInt32(row["StockQty"]) == 0);
                }

                int maxPrice = trkPriceRange.Value;
                filteredRows = filteredRows.Where(row => Convert.ToDecimal(row["Price"]) <= maxPrice);

                var filteredTable = filteredRows.Any()
                    ? filteredRows.CopyToDataTable()
                    : allProducts.Clone();

                RenderPage(filteredTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Filter/render error: " + ex.Message);
            }
        }

        private void RenderPage(DataTable filteredTable)
        {
            flpFemaleProducts.Controls.Clear();

            int totalRows = filteredTable.Rows.Count;
            int totalPages = (int)Math.Ceiling(totalRows / (double)pageSize);

            if (totalPages == 0) totalPages = 1;
            if (currentPage > totalPages) currentPage = totalPages;
            if (currentPage < 1) currentPage = 1;

            int startIndex = (currentPage - 1) * pageSize;
            int endIndex = Math.Min(startIndex + pageSize, totalRows);

            for (int i = startIndex; i < endIndex; i++)
            {
                DataRow row = filteredTable.Rows[i];
                Panel card = CreateProductCard(row);
                flpFemaleProducts.Controls.Add(card);
            }

            btnPrevPage.Enabled = currentPage > 1;
            btnNextPage.Enabled = currentPage < totalPages;

            btnPage1.Visible = totalPages >= 1;
            btnPage2.Visible = totalPages >= 2;
            btnPage3.Visible = totalPages >= 3;

            btnPage1.Text = "1";
            btnPage2.Text = "2";
            btnPage3.Text = "3";

            HighlightCurrentPageButton();
        }

        private Panel CreateProductCard(DataRow row)
        {
            int productId = Convert.ToInt32(row["ProductId"]);
            string productName = row["ProductName"].ToString() ?? "";
            string category = row["CategoryName"].ToString() ?? "";
            decimal price = Convert.ToDecimal(row["Price"]);
            int stockQty = Convert.ToInt32(row["StockQty"]);
            double avgRating = Convert.ToDouble(row["AvgRating"]);
            string imagePath = row["ImagePath"].ToString() ?? "";

            Panel card = new Panel();
            card.Width = 230;
            card.Height = 320;
            card.BorderStyle = BorderStyle.FixedSingle;
            card.BackColor = Color.White;
            card.Margin = new Padding(12);
            card.Cursor = Cursors.Hand;
            card.Tag = productId;

            PictureBox pic = new PictureBox();
            pic.Left = 10;
            pic.Top = 10;
            pic.Width = 208;
            pic.Height = 160;
            pic.BorderStyle = BorderStyle.FixedSingle;
            pic.BackColor = Color.WhiteSmoke;
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.Tag = productId;

            try
            {
                if (!string.IsNullOrWhiteSpace(imagePath) && File.Exists(imagePath))
                {
                    using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                    {
                        Image img = Image.FromStream(fs);
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
            lblName.Top = 178;
            lblName.Width = 208;
            lblName.Height = 42;
            lblName.Text = productName;
            lblName.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lblName.ForeColor = Color.Black;
            lblName.Tag = productId;

            Label lblCategory = new Label();
            lblCategory.Left = 10;
            lblCategory.Top = 222;
            lblCategory.Width = 208;
            lblCategory.Text = category;
            lblCategory.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            lblCategory.ForeColor = Color.DimGray;
            lblCategory.Tag = productId;

            Label lblPrice = new Label();
            lblPrice.Left = 10;
            lblPrice.Top = 247;
            lblPrice.Width = 110;
            lblPrice.Text = price.ToString("0.00") + " Tk";
            lblPrice.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblPrice.ForeColor = Color.Purple;
            lblPrice.Tag = productId;

            Label lblStock = new Label();
            lblStock.Left = 125;
            lblStock.Top = 248;
            lblStock.Width = 90;
            lblStock.Text = stockQty > 0 ? "In Stock" : "Out";
            lblStock.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            lblStock.ForeColor = stockQty > 0 ? Color.Green : Color.Red;
            lblStock.Tag = productId;

            Label lblRating = new Label();
            lblRating.Left = 10;
            lblRating.Top = 275;
            lblRating.Width = 115;
            lblRating.Text = "Rating: " + avgRating.ToString("0.0");
            lblRating.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            lblRating.ForeColor = Color.DimGray;
            lblRating.Tag = productId;

            Button btnView = new Button();
            btnView.Left = 130;
            btnView.Top = 270;
            btnView.Width = 88;
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
            lblCategory.Click += ProductOpen_Click;
            lblPrice.Click += ProductOpen_Click;
            lblStock.Click += ProductOpen_Click;
            lblRating.Click += ProductOpen_Click;

            card.Controls.Add(pic);
            card.Controls.Add(lblName);
            card.Controls.Add(lblCategory);
            card.Controls.Add(lblPrice);
            card.Controls.Add(lblStock);
            card.Controls.Add(lblRating);
            card.Controls.Add(btnView);

            return card;
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

                ApplyFiltersAndRender();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Open product error: " + ex.Message);
            }
        }

        private void btnApplyFilters_Click(object? sender, EventArgs e)
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
            lblMaxPrice.Text = "$" + trkPriceRange.Value;
        }

        private void btnSortNewest_Click(object? sender, EventArgs e)
        {
            if (allProducts == null || allProducts.Rows.Count == 0)
                return;

            DataView dv = allProducts.DefaultView;
            dv.Sort = "CreatedAt DESC, ProductId DESC";
            allProducts = dv.ToTable();

            currentPage = 1;
            ApplyFiltersAndRender();
        }

        private void btnGoBack_Click(object? sender, EventArgs e)
        {
            this.Close();
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

            if (currentPage == 1) SetActivePageButton(btnPage1);
            else if (currentPage == 2) SetActivePageButton(btnPage2);
            else if (currentPage == 3) SetActivePageButton(btnPage3);
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
    }
}