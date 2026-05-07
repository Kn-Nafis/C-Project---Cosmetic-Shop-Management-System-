using System;
using System.Windows.Forms;

namespace Cosmatic_Shop_Management.Forms
{
    public partial class ProductSearchResultForm : Form
    {
        private string searchText;

        public ProductSearchResultForm()
        {
            InitializeComponent();
        }

        public ProductSearchResultForm(string searchText)
        {
            InitializeComponent();
            this.searchText = searchText;
        }

        private void ProductSearchResultForm_Load(object sender, EventArgs e)
        {
            // temporary empty load method
        }
    }
}