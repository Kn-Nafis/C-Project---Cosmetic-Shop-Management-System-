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
            lblCartTitle = new Label();
            btnContinueShopping = new Button();
            dgvCartItems = new DataGridView();
            lblTotalAmount = new Label();
            btnCheckout = new Button();
            btnRemoveSelected = new Button();
            btnUpdateQuantity = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCartItems).BeginInit();
            SuspendLayout();
            // 
            // lblCartTitle
            // 
            lblCartTitle.AutoSize = true;
            lblCartTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCartTitle.ForeColor = Color.FromArgb(74, 20, 140);
            lblCartTitle.Location = new Point(28, 28);
            lblCartTitle.Name = "lblCartTitle";
            lblCartTitle.Size = new Size(262, 48);
            lblCartTitle.TabIndex = 0;
            lblCartTitle.Text = "Shopping Cart";
            // 
            // btnContinueShopping
            // 
            btnContinueShopping.FlatAppearance.BorderColor = Color.FromArgb(74, 20, 140);
            btnContinueShopping.FlatAppearance.BorderSize = 8;
            btnContinueShopping.ForeColor = Color.FromArgb(74, 20, 140);
            btnContinueShopping.Location = new Point(959, 42);
            btnContinueShopping.Name = "btnContinueShopping";
            btnContinueShopping.Size = new Size(178, 34);
            btnContinueShopping.TabIndex = 1;
            btnContinueShopping.Text = "Continue Shopping";
            btnContinueShopping.UseVisualStyleBackColor = true;
            // 
            // dgvCartItems
            // 
            dgvCartItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCartItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCartItems.Location = new Point(83, 128);
            dgvCartItems.MultiSelect = false;
            dgvCartItems.Name = "dgvCartItems";
            dgvCartItems.RowHeadersWidth = 62;
            dgvCartItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCartItems.Size = new Size(848, 353);
            dgvCartItems.TabIndex = 2;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalAmount.ForeColor = Color.FromArgb(74, 20, 140);
            lblTotalAmount.Location = new Point(86, 503);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(153, 30);
            lblTotalAmount.TabIndex = 3;
            lblTotalAmount.Text = "Total Amount";
            // 
            // btnCheckout
            // 
            btnCheckout.BackColor = Color.Coral;
            btnCheckout.FlatStyle = FlatStyle.Flat;
            btnCheckout.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckout.ForeColor = Color.Black;
            btnCheckout.Location = new Point(707, 494);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(224, 49);
            btnCheckout.TabIndex = 4;
            btnCheckout.Text = "Proceed to Checkout";
            btnCheckout.UseVisualStyleBackColor = false;
            // 
            // btnRemoveSelected
            // 
            btnRemoveSelected.BackColor = Color.Red;
            btnRemoveSelected.FlatAppearance.BorderSize = 0;
            btnRemoveSelected.FlatStyle = FlatStyle.Flat;
            btnRemoveSelected.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoveSelected.Location = new Point(959, 174);
            btnRemoveSelected.Name = "btnRemoveSelected";
            btnRemoveSelected.Size = new Size(185, 42);
            btnRemoveSelected.TabIndex = 5;
            btnRemoveSelected.Text = "Remove Selected";
            btnRemoveSelected.UseVisualStyleBackColor = false;
            btnRemoveSelected.Click += button1_Click;
            // 
            // btnUpdateQuantity
            // 
            btnUpdateQuantity.BackColor = Color.FromArgb(74, 20, 140);
            btnUpdateQuantity.FlatAppearance.BorderSize = 0;
            btnUpdateQuantity.FlatStyle = FlatStyle.Flat;
            btnUpdateQuantity.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateQuantity.ForeColor = SystemColors.ButtonFace;
            btnUpdateQuantity.Location = new Point(959, 234);
            btnUpdateQuantity.Name = "btnUpdateQuantity";
            btnUpdateQuantity.Size = new Size(185, 46);
            btnUpdateQuantity.TabIndex = 6;
            btnUpdateQuantity.Text = "Update Quantity";
            btnUpdateQuantity.UseVisualStyleBackColor = false;
            // 
            // CartForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1179, 769);
            Controls.Add(btnUpdateQuantity);
            Controls.Add(btnRemoveSelected);
            Controls.Add(btnCheckout);
            Controls.Add(lblTotalAmount);
            Controls.Add(dgvCartItems);
            Controls.Add(btnContinueShopping);
            Controls.Add(lblCartTitle);
            Name = "CartForm";
            Text = "CartForm";
            ((System.ComponentModel.ISupportInitialize)dgvCartItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCartTitle;
        private Button btnContinueShopping;
        private DataGridView dgvCartItems;
        private Label lblTotalAmount;
        private Button btnCheckout;
        private Button btnRemoveSelected;
        private Button btnUpdateQuantity;
    }
}