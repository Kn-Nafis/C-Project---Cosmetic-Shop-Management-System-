namespace Cosmatic_Shop_Management.Forms
{
    partial class AnalyticsForm
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
            lblTransactionsTitle = new Label();
            dgvTransactions = new DataGridView();
            pnlTotalRevenue = new Panel();
            lblTotalRevenue = new Label();
            lblTotalRevenueTitle = new Label();
            lblFormTitle = new Label();
            lblSubtitle = new Label();
            pnlFilters = new Panel();
            btnApplyFilter = new Button();
            dtpTo = new DateTimePicker();
            lblDateTo = new Label();
            dtpFrom = new DateTimePicker();
            lblDateFrom = new Label();
            pnlShopIncome = new Panel();
            lblShopIncome = new Label();
            lblShopIncomeTitle = new Label();
            pnlCommissionPaid = new Panel();
            lblCommissionPaid = new Label();
            lblCommissionPaidTitle = new Label();
            pnlTransactions = new Panel();
            lblRecordInfo = new Label();
            btnNextPage = new Button();
            btnPage3 = new Button();
            btnPage2 = new Button();
            btnPrevPage = new Button();
            btnPage1 = new Button();
            pnlCategorySales = new Panel();
            progressCategory3 = new ProgressBar();
            lblCategory3Percent = new Label();
            lblCategory3 = new Label();
            progressCategory2 = new ProgressBar();
            lblCategory2Percent = new Label();
            lblCategory2 = new Label();
            progressCategory1 = new ProgressBar();
            lblCategory1Percent = new Label();
            lblCategorySalesTitle = new Label();
            lblCategory1 = new Label();
            btnGoBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            pnlTotalRevenue.SuspendLayout();
            pnlFilters.SuspendLayout();
            pnlShopIncome.SuspendLayout();
            pnlCommissionPaid.SuspendLayout();
            pnlTransactions.SuspendLayout();
            pnlCategorySales.SuspendLayout();
            SuspendLayout();
            // 
            // lblTransactionsTitle
            // 
            lblTransactionsTitle.AutoSize = true;
            lblTransactionsTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTransactionsTitle.ForeColor = Color.FromArgb(74, 20, 140);
            lblTransactionsTitle.Location = new Point(18, 18);
            lblTransactionsTitle.Name = "lblTransactionsTitle";
            lblTransactionsTitle.Size = new Size(395, 38);
            lblTransactionsTitle.TabIndex = 25;
            lblTransactionsTitle.Text = "Detailed Transaction Records";
            // 
            // dgvTransactions
            // 
            dgvTransactions.AllowUserToAddRows = false;
            dgvTransactions.AllowUserToDeleteRows = false;
            dgvTransactions.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransactions.BackgroundColor = Color.White;
            dgvTransactions.BorderStyle = BorderStyle.None;
            dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransactions.Location = new Point(20, 60);
            dgvTransactions.MultiSelect = false;
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.ReadOnly = true;
            dgvTransactions.RowHeadersVisible = false;
            dgvTransactions.RowHeadersWidth = 62;
            dgvTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransactions.Size = new Size(1195, 260);
            dgvTransactions.TabIndex = 19;
            // 
            // pnlTotalRevenue
            // 
            pnlTotalRevenue.Anchor = AnchorStyles.Top;
            pnlTotalRevenue.BackColor = Color.White;
            pnlTotalRevenue.BorderStyle = BorderStyle.FixedSingle;
            pnlTotalRevenue.Controls.Add(lblTotalRevenue);
            pnlTotalRevenue.Controls.Add(lblTotalRevenueTitle);
            pnlTotalRevenue.Location = new Point(40, 140);
            pnlTotalRevenue.Name = "pnlTotalRevenue";
            pnlTotalRevenue.Size = new Size(250, 150);
            pnlTotalRevenue.TabIndex = 14;
            // 
            // lblTotalRevenue
            // 
            lblTotalRevenue.AutoSize = true;
            lblTotalRevenue.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTotalRevenue.ForeColor = Color.FromArgb(74, 20, 140);
            lblTotalRevenue.Location = new Point(13, 55);
            lblTotalRevenue.Name = "lblTotalRevenue";
            lblTotalRevenue.Size = new Size(159, 54);
            lblTotalRevenue.TabIndex = 1;
            lblTotalRevenue.Text = "0.00 Tk";
            // 
            // lblTotalRevenueTitle
            // 
            lblTotalRevenueTitle.AutoSize = true;
            lblTotalRevenueTitle.ForeColor = Color.DimGray;
            lblTotalRevenueTitle.Location = new Point(20, 20);
            lblTotalRevenueTitle.Name = "lblTotalRevenueTitle";
            lblTotalRevenueTitle.Size = new Size(140, 25);
            lblTotalRevenueTitle.TabIndex = 0;
            lblTotalRevenueTitle.Text = "TOTAL REVENUE";
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblFormTitle.ForeColor = Color.FromArgb(74, 20, 140);
            lblFormTitle.Location = new Point(40, 18);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(474, 60);
            lblFormTitle.TabIndex = 13;
            lblFormTitle.Text = "Sales Revenue Report";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.BackColor = Color.Transparent;
            lblSubtitle.ForeColor = Color.DimGray;
            lblSubtitle.Location = new Point(52, 78);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(378, 25);
            lblSubtitle.TabIndex = 3;
            lblSubtitle.Text = "Financial performance overview for your shop.";
            // 
            // pnlFilters
            // 
            pnlFilters.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlFilters.BackColor = Color.White;
            pnlFilters.BorderStyle = BorderStyle.FixedSingle;
            pnlFilters.Controls.Add(btnApplyFilter);
            pnlFilters.Controls.Add(dtpTo);
            pnlFilters.Controls.Add(lblDateTo);
            pnlFilters.Controls.Add(dtpFrom);
            pnlFilters.Controls.Add(lblDateFrom);
            pnlFilters.Location = new Point(760, 30);
            pnlFilters.Name = "pnlFilters";
            pnlFilters.Size = new Size(520, 80);
            pnlFilters.TabIndex = 26;
            // 
            // btnApplyFilter
            // 
            btnApplyFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnApplyFilter.BackColor = Color.FromArgb(232, 199, 240);
            btnApplyFilter.Cursor = Cursors.Hand;
            btnApplyFilter.FlatAppearance.BorderSize = 0;
            btnApplyFilter.FlatStyle = FlatStyle.Flat;
            btnApplyFilter.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApplyFilter.ForeColor = Color.FromArgb(27, 11, 104);
            btnApplyFilter.Location = new Point(345, 30);
            btnApplyFilter.Name = "btnApplyFilter";
            btnApplyFilter.Size = new Size(120, 32);
            btnApplyFilter.TabIndex = 27;
            btnApplyFilter.Text = "Apply Filter";
            btnApplyFilter.UseVisualStyleBackColor = false;
            // 
            // dtpTo
            // 
            dtpTo.Font = new Font("Segoe UI", 10F);
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(180, 35);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(145, 34);
            dtpTo.TabIndex = 7;
            // 
            // lblDateTo
            // 
            lblDateTo.AutoSize = true;
            lblDateTo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDateTo.ForeColor = Color.DimGray;
            lblDateTo.Location = new Point(180, 12);
            lblDateTo.Name = "lblDateTo";
            lblDateTo.Size = new Size(87, 25);
            lblDateTo.TabIndex = 6;
            lblDateTo.Text = "DATE TO";
            // 
            // dtpFrom
            // 
            dtpFrom.Font = new Font("Segoe UI", 10F);
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(13, 35);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(145, 34);
            dtpFrom.TabIndex = 5;
            // 
            // lblDateFrom
            // 
            lblDateFrom.AutoSize = true;
            lblDateFrom.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDateFrom.ForeColor = Color.DimGray;
            lblDateFrom.Location = new Point(15, 12);
            lblDateFrom.Name = "lblDateFrom";
            lblDateFrom.Size = new Size(115, 25);
            lblDateFrom.TabIndex = 4;
            lblDateFrom.Text = "DATE FROM";
            // 
            // pnlShopIncome
            // 
            pnlShopIncome.Anchor = AnchorStyles.Top;
            pnlShopIncome.BackColor = Color.White;
            pnlShopIncome.BorderStyle = BorderStyle.FixedSingle;
            pnlShopIncome.Controls.Add(lblShopIncome);
            pnlShopIncome.Controls.Add(lblShopIncomeTitle);
            pnlShopIncome.Location = new Point(320, 140);
            pnlShopIncome.Name = "pnlShopIncome";
            pnlShopIncome.Size = new Size(250, 150);
            pnlShopIncome.TabIndex = 15;
            // 
            // lblShopIncome
            // 
            lblShopIncome.AutoSize = true;
            lblShopIncome.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblShopIncome.ForeColor = Color.FromArgb(74, 20, 140);
            lblShopIncome.Location = new Point(12, 55);
            lblShopIncome.Name = "lblShopIncome";
            lblShopIncome.Size = new Size(159, 54);
            lblShopIncome.TabIndex = 1;
            lblShopIncome.Text = "0.00 Tk";
            lblShopIncome.Click += lblShopIncome_Click;
            // 
            // lblShopIncomeTitle
            // 
            lblShopIncomeTitle.AutoSize = true;
            lblShopIncomeTitle.ForeColor = Color.DimGray;
            lblShopIncomeTitle.Location = new Point(20, 20);
            lblShopIncomeTitle.Name = "lblShopIncomeTitle";
            lblShopIncomeTitle.Size = new Size(178, 25);
            lblShopIncomeTitle.TabIndex = 0;
            lblShopIncomeTitle.Text = "SHOP INCOME (NET)";
            // 
            // pnlCommissionPaid
            // 
            pnlCommissionPaid.Anchor = AnchorStyles.Top;
            pnlCommissionPaid.BackColor = Color.White;
            pnlCommissionPaid.BorderStyle = BorderStyle.FixedSingle;
            pnlCommissionPaid.Controls.Add(lblCommissionPaid);
            pnlCommissionPaid.Controls.Add(lblCommissionPaidTitle);
            pnlCommissionPaid.Location = new Point(600, 140);
            pnlCommissionPaid.Name = "pnlCommissionPaid";
            pnlCommissionPaid.Size = new Size(250, 150);
            pnlCommissionPaid.TabIndex = 15;
            // 
            // lblCommissionPaid
            // 
            lblCommissionPaid.AutoSize = true;
            lblCommissionPaid.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblCommissionPaid.ForeColor = Color.FromArgb(74, 20, 140);
            lblCommissionPaid.Location = new Point(12, 55);
            lblCommissionPaid.Name = "lblCommissionPaid";
            lblCommissionPaid.Size = new Size(159, 54);
            lblCommissionPaid.TabIndex = 1;
            lblCommissionPaid.Text = "0.00 Tk";
            // 
            // lblCommissionPaidTitle
            // 
            lblCommissionPaidTitle.AutoSize = true;
            lblCommissionPaidTitle.ForeColor = Color.DimGray;
            lblCommissionPaidTitle.Location = new Point(20, 20);
            lblCommissionPaidTitle.Name = "lblCommissionPaidTitle";
            lblCommissionPaidTitle.Size = new Size(170, 25);
            lblCommissionPaidTitle.TabIndex = 0;
            lblCommissionPaidTitle.Text = "COMMISSION PAID";
            // 
            // pnlTransactions
            // 
            pnlTransactions.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlTransactions.BackColor = Color.White;
            pnlTransactions.BorderStyle = BorderStyle.FixedSingle;
            pnlTransactions.Controls.Add(lblRecordInfo);
            pnlTransactions.Controls.Add(btnNextPage);
            pnlTransactions.Controls.Add(lblTransactionsTitle);
            pnlTransactions.Controls.Add(dgvTransactions);
            pnlTransactions.Controls.Add(btnPage3);
            pnlTransactions.Controls.Add(btnPage2);
            pnlTransactions.Controls.Add(btnPrevPage);
            pnlTransactions.Controls.Add(btnPage1);
            pnlTransactions.Location = new Point(40, 320);
            pnlTransactions.Name = "pnlTransactions";
            pnlTransactions.Size = new Size(1240, 360);
            pnlTransactions.TabIndex = 27;
            // 
            // lblRecordInfo
            // 
            lblRecordInfo.AutoSize = true;
            lblRecordInfo.BackColor = Color.Transparent;
            lblRecordInfo.ForeColor = Color.DimGray;
            lblRecordInfo.Location = new Point(20, 330);
            lblRecordInfo.Name = "lblRecordInfo";
            lblRecordInfo.Size = new Size(145, 25);
            lblRecordInfo.TabIndex = 28;
            lblRecordInfo.Text = "Showing records";
            // 
            // btnNextPage
            // 
            btnNextPage.Anchor = AnchorStyles.Bottom;
            btnNextPage.BackColor = Color.White;
            btnNextPage.FlatAppearance.BorderSize = 0;
            btnNextPage.FlatStyle = FlatStyle.Flat;
            btnNextPage.Location = new Point(1194, 319);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(40, 36);
            btnNextPage.TabIndex = 47;
            btnNextPage.Text = ">";
            btnNextPage.UseVisualStyleBackColor = false;
            // 
            // btnPage3
            // 
            btnPage3.Anchor = AnchorStyles.Bottom;
            btnPage3.BackColor = Color.White;
            btnPage3.FlatAppearance.BorderSize = 0;
            btnPage3.FlatStyle = FlatStyle.Flat;
            btnPage3.Location = new Point(1149, 319);
            btnPage3.Name = "btnPage3";
            btnPage3.Size = new Size(40, 36);
            btnPage3.TabIndex = 46;
            btnPage3.Text = "3";
            btnPage3.UseVisualStyleBackColor = false;
            // 
            // btnPage2
            // 
            btnPage2.Anchor = AnchorStyles.Bottom;
            btnPage2.BackColor = Color.White;
            btnPage2.FlatAppearance.BorderSize = 0;
            btnPage2.FlatStyle = FlatStyle.Flat;
            btnPage2.Location = new Point(1104, 319);
            btnPage2.Name = "btnPage2";
            btnPage2.Size = new Size(40, 36);
            btnPage2.TabIndex = 45;
            btnPage2.Text = "2";
            btnPage2.UseVisualStyleBackColor = false;
            // 
            // btnPrevPage
            // 
            btnPrevPage.Anchor = AnchorStyles.Bottom;
            btnPrevPage.BackColor = Color.White;
            btnPrevPage.FlatAppearance.BorderSize = 0;
            btnPrevPage.FlatStyle = FlatStyle.Flat;
            btnPrevPage.Location = new Point(1014, 319);
            btnPrevPage.Name = "btnPrevPage";
            btnPrevPage.Size = new Size(40, 36);
            btnPrevPage.TabIndex = 43;
            btnPrevPage.Text = "<";
            btnPrevPage.UseVisualStyleBackColor = false;
            // 
            // btnPage1
            // 
            btnPage1.Anchor = AnchorStyles.Bottom;
            btnPage1.BackColor = Color.White;
            btnPage1.FlatAppearance.BorderSize = 0;
            btnPage1.FlatStyle = FlatStyle.Flat;
            btnPage1.Location = new Point(1059, 319);
            btnPage1.Name = "btnPage1";
            btnPage1.Size = new Size(40, 36);
            btnPage1.TabIndex = 44;
            btnPage1.Text = "1";
            btnPage1.UseVisualStyleBackColor = false;
            // 
            // pnlCategorySales
            // 
            pnlCategorySales.BackColor = Color.White;
            pnlCategorySales.BorderStyle = BorderStyle.FixedSingle;
            pnlCategorySales.Controls.Add(progressCategory3);
            pnlCategorySales.Controls.Add(lblCategory3Percent);
            pnlCategorySales.Controls.Add(lblCategory3);
            pnlCategorySales.Controls.Add(progressCategory2);
            pnlCategorySales.Controls.Add(lblCategory2Percent);
            pnlCategorySales.Controls.Add(lblCategory2);
            pnlCategorySales.Controls.Add(progressCategory1);
            pnlCategorySales.Controls.Add(lblCategory1Percent);
            pnlCategorySales.Controls.Add(lblCategorySalesTitle);
            pnlCategorySales.Controls.Add(lblCategory1);
            pnlCategorySales.Location = new Point(40, 710);
            pnlCategorySales.Name = "pnlCategorySales";
            pnlCategorySales.Size = new Size(500, 194);
            pnlCategorySales.TabIndex = 28;
            // 
            // progressCategory3
            // 
            progressCategory3.Location = new Point(18, 163);
            progressCategory3.Name = "progressCategory3";
            progressCategory3.Size = new Size(260, 12);
            progressCategory3.TabIndex = 37;
            // 
            // lblCategory3Percent
            // 
            lblCategory3Percent.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory3Percent.ForeColor = Color.FromArgb(27, 11, 104);
            lblCategory3Percent.Location = new Point(178, 140);
            lblCategory3Percent.Name = "lblCategory3Percent";
            lblCategory3Percent.Size = new Size(100, 20);
            lblCategory3Percent.TabIndex = 36;
            lblCategory3Percent.Text = "0%";
            lblCategory3Percent.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCategory3
            // 
            lblCategory3.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory3.ForeColor = Color.Gray;
            lblCategory3.Location = new Point(18, 140);
            lblCategory3.Name = "lblCategory3";
            lblCategory3.Size = new Size(164, 20);
            lblCategory3.TabIndex = 35;
            lblCategory3.Text = "FRAGRANCE";
            // 
            // progressCategory2
            // 
            progressCategory2.Location = new Point(20, 125);
            progressCategory2.Name = "progressCategory2";
            progressCategory2.Size = new Size(260, 12);
            progressCategory2.TabIndex = 34;
            // 
            // lblCategory2Percent
            // 
            lblCategory2Percent.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory2Percent.ForeColor = Color.FromArgb(27, 11, 104);
            lblCategory2Percent.Location = new Point(180, 102);
            lblCategory2Percent.Name = "lblCategory2Percent";
            lblCategory2Percent.Size = new Size(100, 20);
            lblCategory2Percent.TabIndex = 33;
            lblCategory2Percent.Text = "0%";
            lblCategory2Percent.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCategory2
            // 
            lblCategory2.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory2.ForeColor = Color.Gray;
            lblCategory2.Location = new Point(20, 102);
            lblCategory2.Name = "lblCategory2";
            lblCategory2.Size = new Size(164, 20);
            lblCategory2.TabIndex = 32;
            lblCategory2.Text = "MAKEUP";
            // 
            // progressCategory1
            // 
            progressCategory1.Location = new Point(20, 83);
            progressCategory1.Name = "progressCategory1";
            progressCategory1.Size = new Size(260, 12);
            progressCategory1.TabIndex = 31;
            // 
            // lblCategory1Percent
            // 
            lblCategory1Percent.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory1Percent.ForeColor = Color.FromArgb(27, 11, 104);
            lblCategory1Percent.Location = new Point(180, 60);
            lblCategory1Percent.Name = "lblCategory1Percent";
            lblCategory1Percent.Size = new Size(100, 20);
            lblCategory1Percent.TabIndex = 30;
            lblCategory1Percent.Text = "0%";
            lblCategory1Percent.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCategorySalesTitle
            // 
            lblCategorySalesTitle.AutoSize = true;
            lblCategorySalesTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblCategorySalesTitle.ForeColor = Color.FromArgb(74, 20, 140);
            lblCategorySalesTitle.Location = new Point(20, 18);
            lblCategorySalesTitle.Name = "lblCategorySalesTitle";
            lblCategorySalesTitle.Size = new Size(250, 38);
            lblCategorySalesTitle.TabIndex = 2;
            lblCategorySalesTitle.Text = "Sales by Category";
            // 
            // lblCategory1
            // 
            lblCategory1.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory1.ForeColor = Color.Gray;
            lblCategory1.Location = new Point(20, 60);
            lblCategory1.Name = "lblCategory1";
            lblCategory1.Size = new Size(164, 20);
            lblCategory1.TabIndex = 29;
            lblCategory1.Text = "SKINCARE";
            // 
            // btnGoBack
            // 
            btnGoBack.Anchor = AnchorStyles.Right;
            btnGoBack.Cursor = Cursors.Hand;
            btnGoBack.FlatAppearance.BorderSize = 0;
            btnGoBack.FlatStyle = FlatStyle.Flat;
            btnGoBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGoBack.ForeColor = Color.FromArgb(74, 20, 140);
            btnGoBack.Location = new Point(1070, 864);
            btnGoBack.Name = "btnGoBack";
            btnGoBack.Size = new Size(210, 40);
            btnGoBack.TabIndex = 29;
            btnGoBack.Text = "← Back to Dashboard";
            btnGoBack.UseVisualStyleBackColor = true;
            // 
            // AnalyticsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(1288, 911);
            Controls.Add(btnGoBack);
            Controls.Add(pnlCategorySales);
            Controls.Add(pnlTransactions);
            Controls.Add(pnlCommissionPaid);
            Controls.Add(pnlShopIncome);
            Controls.Add(pnlFilters);
            Controls.Add(lblSubtitle);
            Controls.Add(pnlTotalRevenue);
            Controls.Add(lblFormTitle);
            Name = "AnalyticsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AnalyticsForm";
            WindowState = FormWindowState.Maximized;
            Load += AnalyticsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            pnlTotalRevenue.ResumeLayout(false);
            pnlTotalRevenue.PerformLayout();
            pnlFilters.ResumeLayout(false);
            pnlFilters.PerformLayout();
            pnlShopIncome.ResumeLayout(false);
            pnlShopIncome.PerformLayout();
            pnlCommissionPaid.ResumeLayout(false);
            pnlCommissionPaid.PerformLayout();
            pnlTransactions.ResumeLayout(false);
            pnlTransactions.PerformLayout();
            pnlCategorySales.ResumeLayout(false);
            pnlCategorySales.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTransactionsTitle;
        private DataGridView dgvTransactions;
        private Panel pnlTotalRevenue;
        private Label lblTotalRevenue;
        private Label lblTotalRevenueTitle;
        private Label lblFormTitle;
        private Label lblSubtitle;
        private Panel pnlFilters;
        private DateTimePicker dtpTo;
        private Label lblDateTo;
        private DateTimePicker dtpFrom;
        private Label lblDateFrom;
        private Button btnApplyFilter;
        private Panel pnlShopIncome;
        private Label lblShopIncome;
        private Label lblShopIncomeTitle;
        private Panel pnlCommissionPaid;
        private Label lblCommissionPaid;
        private Label lblCommissionPaidTitle;
        private Panel pnlTransactions;
        private Label lblRecordInfo;
        private Button btnNextPage;
        private Button btnPage3;
        private Button btnPage2;
        private Button btnPrevPage;
        private Button btnPage1;
        private Panel pnlCategorySales;
        private Label lblCategorySalesTitle;
        private ProgressBar progressCategory2;
        private Label lblCategory2Percent;
        private Label lblCategory2;
        private ProgressBar progressCategory1;
        private Label lblCategory1Percent;
        private Label lblCategory1;
        private ProgressBar progressCategory3;
        private Label lblCategory3Percent;
        private Label lblCategory3;
        private Button btnGoBack;
    }
}