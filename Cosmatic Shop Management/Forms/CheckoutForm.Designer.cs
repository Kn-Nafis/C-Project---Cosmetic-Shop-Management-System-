namespace Cosmatic_Shop_Management.Forms
{
    partial class CheckoutForm
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
            lblCheckoutTitle = new Label();
            pnlCustomerDetails = new Panel();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            txtFullName = new TextBox();
            lblAddressTitle = new Label();
            lblPhoneTitle = new Label();
            lblFullNameTitle = new Label();
            lblCustomerDetailsTitle = new Label();
            pnlPaymentMethod = new Panel();
            cmbPaymentMethod = new ComboBox();
            lblPaymentMethodTitle = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            btnCancel = new Button();
            btnConfirmPurchase = new Button();
            lblOrderTotal = new Label();
            dgvOrderSummary = new DataGridView();
            pnlCustomerDetails.SuspendLayout();
            pnlPaymentMethod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderSummary).BeginInit();
            SuspendLayout();
            // 
            // lblCheckoutTitle
            // 
            lblCheckoutTitle.AutoSize = true;
            lblCheckoutTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCheckoutTitle.ForeColor = Color.FromArgb(74, 20, 140);
            lblCheckoutTitle.Location = new Point(50, 38);
            lblCheckoutTitle.Name = "lblCheckoutTitle";
            lblCheckoutTitle.Size = new Size(199, 38);
            lblCheckoutTitle.TabIndex = 0;
            lblCheckoutTitle.Text = "Finalize Order";
            // 
            // pnlCustomerDetails
            // 
            pnlCustomerDetails.BackColor = Color.Beige;
            pnlCustomerDetails.BorderStyle = BorderStyle.FixedSingle;
            pnlCustomerDetails.Controls.Add(txtAddress);
            pnlCustomerDetails.Controls.Add(txtPhone);
            pnlCustomerDetails.Controls.Add(txtFullName);
            pnlCustomerDetails.Controls.Add(lblAddressTitle);
            pnlCustomerDetails.Controls.Add(lblPhoneTitle);
            pnlCustomerDetails.Controls.Add(lblFullNameTitle);
            pnlCustomerDetails.Controls.Add(lblCustomerDetailsTitle);
            pnlCustomerDetails.Location = new Point(50, 101);
            pnlCustomerDetails.Name = "pnlCustomerDetails";
            pnlCustomerDetails.Size = new Size(496, 203);
            pnlCustomerDetails.TabIndex = 1;
            // 
            // txtAddress
            // 
            txtAddress.BorderStyle = BorderStyle.None;
            txtAddress.Location = new Point(114, 139);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "Street, Place , City";
            txtAddress.Size = new Size(318, 31);
            txtAddress.TabIndex = 6;
            // 
            // txtPhone
            // 
            txtPhone.BorderStyle = BorderStyle.None;
            txtPhone.Location = new Point(114, 96);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "+880 12 3456 7890";
            txtPhone.Size = new Size(269, 24);
            txtPhone.TabIndex = 5;
            // 
            // txtFullName
            // 
            txtFullName.BorderStyle = BorderStyle.None;
            txtFullName.Location = new Point(114, 54);
            txtFullName.Name = "txtFullName";
            txtFullName.PlaceholderText = "e.g Nusrat Jahan Toma";
            txtFullName.Size = new Size(318, 24);
            txtFullName.TabIndex = 4;
            // 
            // lblAddressTitle
            // 
            lblAddressTitle.AutoSize = true;
            lblAddressTitle.ForeColor = Color.FromArgb(74, 20, 140);
            lblAddressTitle.Location = new Point(14, 139);
            lblAddressTitle.Name = "lblAddressTitle";
            lblAddressTitle.Size = new Size(77, 25);
            lblAddressTitle.TabIndex = 3;
            lblAddressTitle.Text = "Address";
            // 
            // lblPhoneTitle
            // 
            lblPhoneTitle.AutoSize = true;
            lblPhoneTitle.ForeColor = Color.FromArgb(74, 20, 140);
            lblPhoneTitle.Location = new Point(14, 96);
            lblPhoneTitle.Name = "lblPhoneTitle";
            lblPhoneTitle.Size = new Size(95, 25);
            lblPhoneTitle.TabIndex = 2;
            lblPhoneTitle.Text = "Phone No.";
            // 
            // lblFullNameTitle
            // 
            lblFullNameTitle.AutoSize = true;
            lblFullNameTitle.ForeColor = Color.FromArgb(74, 20, 140);
            lblFullNameTitle.Location = new Point(14, 52);
            lblFullNameTitle.Name = "lblFullNameTitle";
            lblFullNameTitle.Size = new Size(91, 25);
            lblFullNameTitle.TabIndex = 1;
            lblFullNameTitle.Text = "Full Name";
            // 
            // lblCustomerDetailsTitle
            // 
            lblCustomerDetailsTitle.AutoSize = true;
            lblCustomerDetailsTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerDetailsTitle.ForeColor = Color.FromArgb(74, 20, 140);
            lblCustomerDetailsTitle.Location = new Point(14, 11);
            lblCustomerDetailsTitle.Name = "lblCustomerDetailsTitle";
            lblCustomerDetailsTitle.Size = new Size(156, 25);
            lblCustomerDetailsTitle.TabIndex = 0;
            lblCustomerDetailsTitle.Text = "Customer Details";
            // 
            // pnlPaymentMethod
            // 
            pnlPaymentMethod.BackColor = Color.Beige;
            pnlPaymentMethod.Controls.Add(cmbPaymentMethod);
            pnlPaymentMethod.Controls.Add(lblPaymentMethodTitle);
            pnlPaymentMethod.Location = new Point(50, 341);
            pnlPaymentMethod.Name = "pnlPaymentMethod";
            pnlPaymentMethod.Size = new Size(496, 132);
            pnlPaymentMethod.TabIndex = 2;
            // 
            // cmbPaymentMethod
            // 
            cmbPaymentMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaymentMethod.FlatStyle = FlatStyle.Flat;
            cmbPaymentMethod.ForeColor = Color.FromArgb(74, 20, 140);
            cmbPaymentMethod.FormattingEnabled = true;
            cmbPaymentMethod.Items.AddRange(new object[] { "Cash On Delivery ", "Bkash", "Nagad", "Card" });
            cmbPaymentMethod.Location = new Point(14, 62);
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Size = new Size(290, 33);
            cmbPaymentMethod.TabIndex = 8;
            // 
            // lblPaymentMethodTitle
            // 
            lblPaymentMethodTitle.AutoSize = true;
            lblPaymentMethodTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPaymentMethodTitle.ForeColor = Color.FromArgb(74, 20, 140);
            lblPaymentMethodTitle.Location = new Point(14, 15);
            lblPaymentMethodTitle.Name = "lblPaymentMethodTitle";
            lblPaymentMethodTitle.Size = new Size(159, 25);
            lblPaymentMethodTitle.TabIndex = 7;
            lblPaymentMethodTitle.Text = "Payment Mathod";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // btnCancel
            // 
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(74, 20, 140);
            btnCancel.FlatAppearance.BorderSize = 2;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.FromArgb(74, 20, 140);
            btnCancel.Location = new Point(50, 493);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(225, 47);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel Transaction";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnConfirmPurchase
            // 
            btnConfirmPurchase.BackColor = Color.Coral;
            btnConfirmPurchase.FlatStyle = FlatStyle.Flat;
            btnConfirmPurchase.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmPurchase.ForeColor = Color.Black;
            btnConfirmPurchase.Location = new Point(300, 493);
            btnConfirmPurchase.Name = "btnConfirmPurchase";
            btnConfirmPurchase.Size = new Size(246, 47);
            btnConfirmPurchase.TabIndex = 4;
            btnConfirmPurchase.Text = "Confirm Purchase";
            btnConfirmPurchase.UseVisualStyleBackColor = false;
            // 
            // lblOrderTotal
            // 
            lblOrderTotal.AutoSize = true;
            lblOrderTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblOrderTotal.Location = new Point(579, 498);
            lblOrderTotal.Name = "lblOrderTotal";
            lblOrderTotal.Size = new Size(157, 32);
            lblOrderTotal.TabIndex = 5;
            lblOrderTotal.Text = "Total Order :";
            // 
            // dgvOrderSummary
            // 
            dgvOrderSummary.AllowUserToDeleteRows = false;
            dgvOrderSummary.AllowUserToResizeRows = false;
            dgvOrderSummary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrderSummary.BackgroundColor = Color.White;
            dgvOrderSummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderSummary.GridColor = SystemColors.InactiveBorder;
            dgvOrderSummary.Location = new Point(570, 101);
            dgvOrderSummary.MultiSelect = false;
            dgvOrderSummary.Name = "dgvOrderSummary";
            dgvOrderSummary.ReadOnly = true;
            dgvOrderSummary.RowHeadersWidth = 62;
            dgvOrderSummary.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrderSummary.Size = new Size(520, 385);
            dgvOrderSummary.TabIndex = 6;
            // 
            // CheckoutForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(1112, 687);
            Controls.Add(dgvOrderSummary);
            Controls.Add(lblOrderTotal);
            Controls.Add(btnConfirmPurchase);
            Controls.Add(btnCancel);
            Controls.Add(pnlPaymentMethod);
            Controls.Add(pnlCustomerDetails);
            Controls.Add(lblCheckoutTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CheckoutForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CheckoutForm";
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            Load += CheckoutForm_Load;
            pnlCustomerDetails.ResumeLayout(false);
            pnlCustomerDetails.PerformLayout();
            pnlPaymentMethod.ResumeLayout(false);
            pnlPaymentMethod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderSummary).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCheckoutTitle;
        private Panel pnlCustomerDetails;
        private Label lblAddressTitle;
        private Label lblPhoneTitle;
        private Label lblFullNameTitle;
        private Label lblCustomerDetailsTitle;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private TextBox txtFullName;
        private Panel pnlPaymentMethod;
        private ComboBox cmbPaymentMethod;
        private Label lblPaymentMethodTitle;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button btnCancel;
        private Button btnConfirmPurchase;
        private Label lblOrderTotal;
        private DataGridView dgvOrderSummary;
    }
}