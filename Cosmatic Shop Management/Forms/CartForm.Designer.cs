namespace Cosmatic_Shop_Management.Forms
{
    partial class CartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlMain = new Panel();
            pnlTableHeader = new Panel();
            chkSelectAll = new CheckBox();
            lblHeaderQuantity = new Label();
            lblHeaderSubtotal = new Label();
            lblHeaderProduct = new Label();
            lblHeaderPrice = new Label();
            pnlOrderSummary = new Panel();
            lblSecureCheckout = new Label();
            btnCheckout = new Button();
            lblTotalAmount = new Label();
            lblTotalText = new Label();
            pnlSeparator = new Panel();
            lblTax = new Label();
            lblTaxText = new Label();
            lblShipping = new Label();
            lblShippingText = new Label();
            lblDiscount = new Label();
            lblDiscountText = new Label();
            lblSubtotal = new Label();
            lblSubtotalText = new Label();
            lblOrderSummaryTitle = new Label();
            pnlCartItems = new Panel();
            pnlCartActions = new Panel();
            lblSelectedItems = new Label();
            btnUpdateQuantity = new Button();
            btnRemoveSelected = new Button();
            flowCartItems = new FlowLayoutPanel();
            btnContinueShopping = new Button();
            lblTitle = new Label();
            pnlMain.SuspendLayout();
            pnlTableHeader.SuspendLayout();
            pnlOrderSummary.SuspendLayout();
            pnlCartItems.SuspendLayout();
            pnlCartActions.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlMain.BackColor = Color.Beige;
            pnlMain.Controls.Add(pnlTableHeader);
            pnlMain.Controls.Add(pnlOrderSummary);
            pnlMain.Controls.Add(pnlCartItems);
            pnlMain.Controls.Add(btnContinueShopping);
            pnlMain.Controls.Add(lblTitle);
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Padding = new Padding(30, 25, 30, 25);
            pnlMain.Size = new Size(1179, 769);
            pnlMain.TabIndex = 1;
            pnlMain.Paint += pnlMain_Paint;
            // 
            // pnlTableHeader
            // 
            pnlTableHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlTableHeader.Controls.Add(chkSelectAll);
            pnlTableHeader.Controls.Add(lblHeaderQuantity);
            pnlTableHeader.Controls.Add(lblHeaderSubtotal);
            pnlTableHeader.Controls.Add(lblHeaderProduct);
            pnlTableHeader.Controls.Add(lblHeaderPrice);
            pnlTableHeader.Location = new Point(33, 132);
            pnlTableHeader.Name = "pnlTableHeader";
            pnlTableHeader.Size = new Size(738, 69);
            pnlTableHeader.TabIndex = 8;
            // 
            // chkSelectAll
            // 
            chkSelectAll.AutoSize = true;
            chkSelectAll.Location = new Point(20, 24);
            chkSelectAll.Name = "chkSelectAll";
            chkSelectAll.Size = new Size(22, 21);
            chkSelectAll.TabIndex = 8;
            chkSelectAll.UseVisualStyleBackColor = true;
            // 
            // lblHeaderQuantity
            // 
            lblHeaderQuantity.AutoSize = true;
            lblHeaderQuantity.CausesValidation = false;
            lblHeaderQuantity.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeaderQuantity.ForeColor = Color.Indigo;
            lblHeaderQuantity.Location = new Point(500, 18);
            lblHeaderQuantity.Name = "lblHeaderQuantity";
            lblHeaderQuantity.Size = new Size(95, 28);
            lblHeaderQuantity.TabIndex = 7;
            lblHeaderQuantity.Text = "Quantity";
            // 
            // lblHeaderSubtotal
            // 
            lblHeaderSubtotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeaderSubtotal.ForeColor = Color.Indigo;
            lblHeaderSubtotal.Location = new Point(630, 18);
            lblHeaderSubtotal.Name = "lblHeaderSubtotal";
            lblHeaderSubtotal.Size = new Size(90, 25);
            lblHeaderSubtotal.TabIndex = 6;
            lblHeaderSubtotal.Text = "SubTotal";
            // 
            // lblHeaderProduct
            // 
            lblHeaderProduct.AutoSize = true;
            lblHeaderProduct.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeaderProduct.ForeColor = Color.Indigo;
            lblHeaderProduct.Location = new Point(70, 18);
            lblHeaderProduct.Name = "lblHeaderProduct";
            lblHeaderProduct.Size = new Size(86, 28);
            lblHeaderProduct.TabIndex = 2;
            lblHeaderProduct.Text = "Product";
            // 
            // lblHeaderPrice
            // 
            lblHeaderPrice.AutoSize = true;
            lblHeaderPrice.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeaderPrice.ForeColor = Color.Indigo;
            lblHeaderPrice.Location = new Point(390, 18);
            lblHeaderPrice.Name = "lblHeaderPrice";
            lblHeaderPrice.Size = new Size(59, 28);
            lblHeaderPrice.TabIndex = 3;
            lblHeaderPrice.Text = "Price";
            // 
            // pnlOrderSummary
            // 
            pnlOrderSummary.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlOrderSummary.BackColor = Color.White;
            pnlOrderSummary.BorderStyle = BorderStyle.FixedSingle;
            pnlOrderSummary.Controls.Add(lblSecureCheckout);
            pnlOrderSummary.Controls.Add(btnCheckout);
            pnlOrderSummary.Controls.Add(lblTotalAmount);
            pnlOrderSummary.Controls.Add(lblTotalText);
            pnlOrderSummary.Controls.Add(pnlSeparator);
            pnlOrderSummary.Controls.Add(lblTax);
            pnlOrderSummary.Controls.Add(lblTaxText);
            pnlOrderSummary.Controls.Add(lblShipping);
            pnlOrderSummary.Controls.Add(lblShippingText);
            pnlOrderSummary.Controls.Add(lblDiscount);
            pnlOrderSummary.Controls.Add(lblDiscountText);
            pnlOrderSummary.Controls.Add(lblSubtotal);
            pnlOrderSummary.Controls.Add(lblSubtotalText);
            pnlOrderSummary.Controls.Add(lblOrderSummaryTitle);
            pnlOrderSummary.Location = new Point(801, 132);
            pnlOrderSummary.Name = "pnlOrderSummary";
            pnlOrderSummary.Size = new Size(300, 500);
            pnlOrderSummary.TabIndex = 3;
            // 
            // lblSecureCheckout
            // 
            lblSecureCheckout.AutoSize = true;
            lblSecureCheckout.ForeColor = Color.Gray;
            lblSecureCheckout.Location = new Point(63, 420);
            lblSecureCheckout.Name = "lblSecureCheckout";
            lblSecureCheckout.Size = new Size(170, 25);
            lblSecureCheckout.TabIndex = 13;
            lblSecureCheckout.Text = "🔒 Secure checkout";
            // 
            // btnCheckout
            // 
            btnCheckout.BackColor = Color.FromArgb(255, 122, 0);
            btnCheckout.FlatAppearance.BorderSize = 0;
            btnCheckout.FlatStyle = FlatStyle.Flat;
            btnCheckout.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckout.ForeColor = Color.White;
            btnCheckout.Location = new Point(25, 350);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(245, 50);
            btnCheckout.TabIndex = 12;
            btnCheckout.Text = "Proceed to Checkout";
            btnCheckout.UseVisualStyleBackColor = false;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalAmount.ForeColor = Color.Indigo;
            lblTotalAmount.Location = new Point(150, 285);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(105, 38);
            lblTotalAmount.TabIndex = 11;
            lblTotalAmount.Text = "0.00 Tk";
            lblTotalAmount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotalText
            // 
            lblTotalText.AutoSize = true;
            lblTotalText.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalText.ForeColor = Color.Indigo;
            lblTotalText.Location = new Point(25, 285);
            lblTotalText.Name = "lblTotalText";
            lblTotalText.Size = new Size(81, 38);
            lblTotalText.TabIndex = 10;
            lblTotalText.Text = "Total";
            // 
            // pnlSeparator
            // 
            pnlSeparator.BackColor = Color.LightGray;
            pnlSeparator.Location = new Point(25, 260);
            pnlSeparator.Name = "pnlSeparator";
            pnlSeparator.Size = new Size(245, 1);
            pnlSeparator.TabIndex = 9;
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Location = new Point(190, 210);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(64, 25);
            lblTax.TabIndex = 8;
            lblTax.Text = "0.00Tk";
            lblTax.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTaxText
            // 
            lblTaxText.AutoSize = true;
            lblTaxText.Location = new Point(25, 210);
            lblTaxText.Name = "lblTaxText";
            lblTaxText.Size = new Size(36, 25);
            lblTaxText.TabIndex = 7;
            lblTaxText.Text = "Tax";
            // 
            // lblShipping
            // 
            lblShipping.AutoSize = true;
            lblShipping.Location = new Point(190, 170);
            lblShipping.Name = "lblShipping";
            lblShipping.Size = new Size(64, 25);
            lblShipping.TabIndex = 6;
            lblShipping.Text = "0.00Tk";
            lblShipping.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblShippingText
            // 
            lblShippingText.AutoSize = true;
            lblShippingText.Location = new Point(25, 170);
            lblShippingText.Name = "lblShippingText";
            lblShippingText.Size = new Size(83, 25);
            lblShippingText.TabIndex = 5;
            lblShippingText.Text = "Shipping";
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.ForeColor = Color.Green;
            lblDiscount.Location = new Point(190, 130);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(71, 25);
            lblDiscount.TabIndex = 4;
            lblDiscount.Text = "-0.00Tk";
            lblDiscount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDiscountText
            // 
            lblDiscountText.AutoSize = true;
            lblDiscountText.Location = new Point(25, 130);
            lblDiscountText.Name = "lblDiscountText";
            lblDiscountText.Size = new Size(82, 25);
            lblDiscountText.TabIndex = 3;
            lblDiscountText.Text = "Discount";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtotal.ForeColor = Color.Black;
            lblSubtotal.Location = new Point(190, 90);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(69, 28);
            lblSubtotal.TabIndex = 2;
            lblSubtotal.Text = "0.00Tk";
            lblSubtotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSubtotalText
            // 
            lblSubtotalText.AutoSize = true;
            lblSubtotalText.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtotalText.ForeColor = Color.Black;
            lblSubtotalText.Location = new Point(25, 90);
            lblSubtotalText.Name = "lblSubtotalText";
            lblSubtotalText.Size = new Size(87, 28);
            lblSubtotalText.TabIndex = 1;
            lblSubtotalText.Text = "Subtotal";
            // 
            // lblOrderSummaryTitle
            // 
            lblOrderSummaryTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderSummaryTitle.ForeColor = Color.Indigo;
            lblOrderSummaryTitle.Location = new Point(25, 30);
            lblOrderSummaryTitle.Name = "lblOrderSummaryTitle";
            lblOrderSummaryTitle.Size = new Size(234, 39);
            lblOrderSummaryTitle.TabIndex = 0;
            lblOrderSummaryTitle.Text = "Order Summary";
            // 
            // pnlCartItems
            // 
            pnlCartItems.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlCartItems.BackColor = Color.White;
            pnlCartItems.BorderStyle = BorderStyle.FixedSingle;
            pnlCartItems.Controls.Add(pnlCartActions);
            pnlCartItems.Controls.Add(flowCartItems);
            pnlCartItems.Location = new Point(33, 206);
            pnlCartItems.Name = "pnlCartItems";
            pnlCartItems.Size = new Size(740, 535);
            pnlCartItems.TabIndex = 2;
            // 
            // pnlCartActions
            // 
            pnlCartActions.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlCartActions.Controls.Add(lblSelectedItems);
            pnlCartActions.Controls.Add(btnUpdateQuantity);
            pnlCartActions.Controls.Add(btnRemoveSelected);
            pnlCartActions.Location = new Point(0, 427);
            pnlCartActions.Name = "pnlCartActions";
            pnlCartActions.Size = new Size(738, 88);
            pnlCartActions.TabIndex = 7;
            // 
            // lblSelectedItems
            // 
            lblSelectedItems.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelectedItems.ForeColor = Color.Indigo;
            lblSelectedItems.Location = new Point(545, 33);
            lblSelectedItems.Name = "lblSelectedItems";
            lblSelectedItems.Size = new Size(175, 25);
            lblSelectedItems.TabIndex = 3;
            lblSelectedItems.Text = "Selected Items: 0";
            // 
            // btnUpdateQuantity
            // 
            btnUpdateQuantity.FlatAppearance.BorderColor = Color.FromArgb(139, 92, 246);
            btnUpdateQuantity.FlatStyle = FlatStyle.Flat;
            btnUpdateQuantity.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateQuantity.ForeColor = Color.Indigo;
            btnUpdateQuantity.Location = new Point(254, 18);
            btnUpdateQuantity.Name = "btnUpdateQuantity";
            btnUpdateQuantity.Size = new Size(216, 47);
            btnUpdateQuantity.TabIndex = 2;
            btnUpdateQuantity.Text = "🔄Update Quantity";
            btnUpdateQuantity.UseVisualStyleBackColor = true;
            // 
            // btnRemoveSelected
            // 
            btnRemoveSelected.FlatAppearance.BorderColor = Color.Red;
            btnRemoveSelected.FlatStyle = FlatStyle.Flat;
            btnRemoveSelected.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoveSelected.ForeColor = Color.Red;
            btnRemoveSelected.Location = new Point(20, 18);
            btnRemoveSelected.Name = "btnRemoveSelected";
            btnRemoveSelected.Size = new Size(212, 47);
            btnRemoveSelected.TabIndex = 1;
            btnRemoveSelected.Text = "🗑️Remove Selected";
            btnRemoveSelected.UseVisualStyleBackColor = true;
            // 
            // flowCartItems
            // 
            flowCartItems.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowCartItems.AutoScroll = true;
            flowCartItems.FlowDirection = FlowDirection.TopDown;
            flowCartItems.Location = new Point(0, 0);
            flowCartItems.Name = "flowCartItems";
            flowCartItems.Size = new Size(738, 533);
            flowCartItems.TabIndex = 6;
            flowCartItems.WrapContents = false;
            // 
            // btnContinueShopping
            // 
            btnContinueShopping.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnContinueShopping.BackColor = Color.White;
            btnContinueShopping.FlatAppearance.BorderColor = Color.FromArgb(139, 92, 246);
            btnContinueShopping.FlatStyle = FlatStyle.Flat;
            btnContinueShopping.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnContinueShopping.ForeColor = Color.Black;
            btnContinueShopping.Location = new Point(850, 42);
            btnContinueShopping.Name = "btnContinueShopping";
            btnContinueShopping.Size = new Size(210, 42);
            btnContinueShopping.TabIndex = 1;
            btnContinueShopping.Text = "Continue Shopping";
            btnContinueShopping.UseVisualStyleBackColor = false;
            btnContinueShopping.Click += btnContinueShopping_Click_1;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Coral;
            lblTitle.Location = new Point(33, 42);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(325, 67);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Shopping Cart";
            // 
            // CartForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1179, 769);
            Controls.Add(pnlMain);
            Name = "CartForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CartForm";
            WindowState = FormWindowState.Maximized;
            Load += CartForm_Load_1;
            pnlMain.ResumeLayout(false);
            pnlTableHeader.ResumeLayout(false);
            pnlTableHeader.PerformLayout();
            pnlOrderSummary.ResumeLayout(false);
            pnlOrderSummary.PerformLayout();
            pnlCartItems.ResumeLayout(false);
            pnlCartActions.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private Panel pnlOrderSummary;
        private Label lblSecureCheckout;
        private Button btnCheckout;
        private Label lblTotalAmount;
        private Label lblTotalText;
        private Panel pnlSeparator;
        private Label lblTax;
        private Label lblTaxText;
        private Label lblShipping;
        private Label lblShippingText;
        private Label lblDiscount;
        private Label lblDiscountText;
        private Label lblSubtotal;
        private Label lblSubtotalText;
        private Label lblOrderSummaryTitle;
        private Panel pnlCartItems;
        private Panel pnlTableHeader;
        private CheckBox chkSelectAll;
        private Label lblHeaderQuantity;
        private Label lblHeaderSubtotal;
        private Label lblHeaderProduct;
        private Label lblHeaderPrice;
        private Panel pnlCartActions;
        private Label lblSelectedItems;
        private Button btnUpdateQuantity;
        private Button btnRemoveSelected;
        private FlowLayoutPanel flowCartItems;
        private Button btnContinueShopping;
        private Label lblTitle;
    }
}