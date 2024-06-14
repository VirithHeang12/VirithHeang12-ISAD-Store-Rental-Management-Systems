namespace Store_Rental_Management_Systems
{
    partial class FrmItem
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
            lblTitle = new Label();
            lblSearchItem = new Label();
            txtSearchItem = new TextBox();
            pnlLeftSide = new Panel();
            dgvItems = new DataGridView();
            ItemID = new DataGridViewTextBoxColumn();
            ItemDescription = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            Unit = new DataGridViewTextBoxColumn();
            UnitPrice = new DataGridViewTextBoxColumn();
            StockQty = new DataGridViewTextBoxColumn();
            pnlRightSide = new Panel();
            gbItemInformation = new GroupBox();
            pnlItemManipulation = new Panel();
            btnCancelItem = new Button();
            btnNewItem = new Button();
            btnUpdateItem = new Button();
            btnInsertItem = new Button();
            txtStockQty = new TextBox();
            lblUnit = new Label();
            cbCategory = new ComboBox();
            lblItemID = new Label();
            lblStockQty = new Label();
            txtItemDescription = new TextBox();
            lblItemDescription = new Label();
            txtItemID = new TextBox();
            lblCategory = new Label();
            txtUnit = new TextBox();
            lblUnitPrice = new Label();
            txtUnitPrice = new TextBox();
            pnlLeftSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            pnlRightSide.SuspendLayout();
            gbItemInformation.SuspendLayout();
            pnlItemManipulation.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.FromArgb(0, 28, 87);
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("!Khmer OS Siemreap", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(266, 80);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1534, 101);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ព័ត៌មានសម្ភារៈ";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSearchItem
            // 
            lblSearchItem.AutoSize = true;
            lblSearchItem.Location = new Point(82, 19);
            lblSearchItem.Name = "lblSearchItem";
            lblSearchItem.Size = new Size(311, 43);
            lblSearchItem.TabIndex = 1;
            lblSearchItem.Text = "ស្វែងរក (លេខសម្គាល់សម្ភារៈ):";
            // 
            // txtSearchItem
            // 
            txtSearchItem.Location = new Point(377, 11);
            txtSearchItem.Name = "txtSearchItem";
            txtSearchItem.Size = new Size(452, 51);
            txtSearchItem.TabIndex = 2;
            // 
            // pnlLeftSide
            // 
            pnlLeftSide.Controls.Add(dgvItems);
            pnlLeftSide.Controls.Add(lblSearchItem);
            pnlLeftSide.Controls.Add(txtSearchItem);
            pnlLeftSide.Location = new Point(266, 537);
            pnlLeftSide.Name = "pnlLeftSide";
            pnlLeftSide.Size = new Size(1800, 1000);
            pnlLeftSide.TabIndex = 3;
            // 
            // dgvItems
            // 
            dgvItems.AllowUserToAddRows = false;
            dgvItems.AllowUserToDeleteRows = false;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Columns.AddRange(new DataGridViewColumn[] { ItemID, ItemDescription, Category, Unit, UnitPrice, StockQty });
            dgvItems.Location = new Point(82, 74);
            dgvItems.Name = "dgvItems";
            dgvItems.ReadOnly = true;
            dgvItems.RowHeadersWidth = 51;
            dgvItems.RowTemplate.Height = 29;
            dgvItems.Size = new Size(1362, 337);
            dgvItems.TabIndex = 3;
            // 
            // ItemID
            // 
            ItemID.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ItemID.DataPropertyName = "ItemID";
            ItemID.HeaderText = "លេខសម្គាល់សម្ភារៈ";
            ItemID.MinimumWidth = 6;
            ItemID.Name = "ItemID";
            ItemID.ReadOnly = true;
            ItemID.Width = 236;
            // 
            // ItemDescription
            // 
            ItemDescription.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ItemDescription.DataPropertyName = "ItemDescription";
            ItemDescription.HeaderText = "ពិព័ណ៌នារបស់សម្ភារៈ";
            ItemDescription.MinimumWidth = 6;
            ItemDescription.Name = "ItemDescription";
            ItemDescription.ReadOnly = true;
            // 
            // Category
            // 
            Category.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Category.DataPropertyName = "Category";
            Category.HeaderText = "ប្រភេទ";
            Category.MinimumWidth = 6;
            Category.Name = "Category";
            Category.ReadOnly = true;
            // 
            // Unit
            // 
            Unit.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Unit.DataPropertyName = "Unit";
            Unit.HeaderText = "ឯកតា";
            Unit.MinimumWidth = 6;
            Unit.Name = "Unit";
            Unit.ReadOnly = true;
            // 
            // UnitPrice
            // 
            UnitPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            UnitPrice.DataPropertyName = "UnitPrice";
            UnitPrice.HeaderText = "តម្លៃក្នុងមួយឯកតា";
            UnitPrice.MinimumWidth = 6;
            UnitPrice.Name = "UnitPrice";
            UnitPrice.ReadOnly = true;
            UnitPrice.Width = 153;
            // 
            // StockQty
            // 
            StockQty.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            StockQty.DataPropertyName = "StockQty";
            StockQty.HeaderText = "បរិមាណក្នុងស្តុក";
            StockQty.MinimumWidth = 6;
            StockQty.Name = "StockQty";
            StockQty.ReadOnly = true;
            StockQty.Width = 139;
            // 
            // pnlRightSide
            // 
            pnlRightSide.Controls.Add(gbItemInformation);
            pnlRightSide.Location = new Point(266, 184);
            pnlRightSide.Name = "pnlRightSide";
            pnlRightSide.Size = new Size(1534, 358);
            pnlRightSide.TabIndex = 4;
            // 
            // gbItemInformation
            // 
            gbItemInformation.Controls.Add(pnlItemManipulation);
            gbItemInformation.Controls.Add(txtStockQty);
            gbItemInformation.Controls.Add(lblUnit);
            gbItemInformation.Controls.Add(cbCategory);
            gbItemInformation.Controls.Add(lblItemID);
            gbItemInformation.Controls.Add(lblStockQty);
            gbItemInformation.Controls.Add(txtItemDescription);
            gbItemInformation.Controls.Add(lblItemDescription);
            gbItemInformation.Controls.Add(txtItemID);
            gbItemInformation.Controls.Add(lblCategory);
            gbItemInformation.Controls.Add(txtUnit);
            gbItemInformation.Controls.Add(lblUnitPrice);
            gbItemInformation.Controls.Add(txtUnitPrice);
            gbItemInformation.Font = new Font("!Khmer OS Siemreap", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            gbItemInformation.Location = new Point(82, 12);
            gbItemInformation.Name = "gbItemInformation";
            gbItemInformation.Size = new Size(1362, 335);
            gbItemInformation.TabIndex = 25;
            gbItemInformation.TabStop = false;
            gbItemInformation.Text = "ព័ត៌មានសម្ភារៈ";
            // 
            // pnlItemManipulation
            // 
            pnlItemManipulation.Controls.Add(btnCancelItem);
            pnlItemManipulation.Controls.Add(btnNewItem);
            pnlItemManipulation.Controls.Add(btnUpdateItem);
            pnlItemManipulation.Controls.Add(btnInsertItem);
            pnlItemManipulation.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pnlItemManipulation.Location = new Point(18, 239);
            pnlItemManipulation.Name = "pnlItemManipulation";
            pnlItemManipulation.Size = new Size(1301, 81);
            pnlItemManipulation.TabIndex = 5;
            // 
            // btnCancelItem
            // 
            btnCancelItem.BackColor = Color.FromArgb(0, 28, 87);
            btnCancelItem.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelItem.ForeColor = Color.White;
            btnCancelItem.Location = new Point(1100, 20);
            btnCancelItem.Name = "btnCancelItem";
            btnCancelItem.Size = new Size(152, 52);
            btnCancelItem.TabIndex = 3;
            btnCancelItem.Text = "បោះបង់";
            btnCancelItem.UseVisualStyleBackColor = false;
            // 
            // btnNewItem
            // 
            btnNewItem.BackColor = Color.FromArgb(0, 28, 87);
            btnNewItem.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNewItem.ForeColor = Color.White;
            btnNewItem.Location = new Point(740, 20);
            btnNewItem.Name = "btnNewItem";
            btnNewItem.Size = new Size(152, 52);
            btnNewItem.TabIndex = 2;
            btnNewItem.Text = "បង្កើតថ្មី";
            btnNewItem.UseVisualStyleBackColor = false;
            // 
            // btnUpdateItem
            // 
            btnUpdateItem.BackColor = Color.FromArgb(0, 28, 87);
            btnUpdateItem.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateItem.ForeColor = Color.White;
            btnUpdateItem.Location = new Point(380, 20);
            btnUpdateItem.Name = "btnUpdateItem";
            btnUpdateItem.Size = new Size(152, 52);
            btnUpdateItem.TabIndex = 1;
            btnUpdateItem.Text = "កែប្រែ";
            btnUpdateItem.UseVisualStyleBackColor = false;
            // 
            // btnInsertItem
            // 
            btnInsertItem.BackColor = Color.FromArgb(0, 28, 87);
            btnInsertItem.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsertItem.ForeColor = Color.White;
            btnInsertItem.Location = new Point(20, 20);
            btnInsertItem.Name = "btnInsertItem";
            btnInsertItem.Size = new Size(152, 52);
            btnInsertItem.TabIndex = 0;
            btnInsertItem.Text = "បញ្ចូល";
            btnInsertItem.UseVisualStyleBackColor = false;
            // 
            // txtStockQty
            // 
            txtStockQty.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStockQty.Location = new Point(907, 169);
            txtStockQty.Name = "txtStockQty";
            txtStockQty.Size = new Size(412, 51);
            txtStockQty.TabIndex = 28;
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUnit.Location = new Point(711, 111);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(82, 43);
            lblUnit.TabIndex = 27;
            lblUnit.Text = "ឯកតា:";
            // 
            // cbCategory
            // 
            cbCategory.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbCategory.FormattingEnabled = true;
            cbCategory.Items.AddRange(new object[] { "សម្ភារៈសំណង់", "គ្រឿងអេឡិចត្រូនិច", "គ្រឿងបន្លាស់" });
            cbCategory.Location = new Point(209, 103);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(454, 51);
            cbCategory.TabIndex = 15;
            // 
            // lblItemID
            // 
            lblItemID.AutoSize = true;
            lblItemID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblItemID.Location = new Point(18, 41);
            lblItemID.Name = "lblItemID";
            lblItemID.Size = new Size(207, 43);
            lblItemID.TabIndex = 0;
            lblItemID.Text = "លេខសម្គាល់សម្ភារៈ:";
            // 
            // lblStockQty
            // 
            lblStockQty.AutoSize = true;
            lblStockQty.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStockQty.Location = new Point(711, 177);
            lblStockQty.Name = "lblStockQty";
            lblStockQty.Size = new Size(177, 43);
            lblStockQty.TabIndex = 14;
            lblStockQty.Text = "បរិមាណក្នុងស្តុក:";
            // 
            // txtItemDescription
            // 
            txtItemDescription.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtItemDescription.Location = new Point(907, 33);
            txtItemDescription.Name = "txtItemDescription";
            txtItemDescription.Size = new Size(412, 51);
            txtItemDescription.TabIndex = 5;
            // 
            // lblItemDescription
            // 
            lblItemDescription.AutoSize = true;
            lblItemDescription.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblItemDescription.Location = new Point(711, 41);
            lblItemDescription.Name = "lblItemDescription";
            lblItemDescription.Size = new Size(225, 43);
            lblItemDescription.TabIndex = 4;
            lblItemDescription.Text = "ពិពណ៌នារបស់សម្ភារៈ:";
            // 
            // txtItemID
            // 
            txtItemID.Enabled = false;
            txtItemID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtItemID.Location = new Point(209, 33);
            txtItemID.Name = "txtItemID";
            txtItemID.Size = new Size(454, 51);
            txtItemID.TabIndex = 3;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCategory.Location = new Point(18, 111);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(90, 43);
            lblCategory.TabIndex = 6;
            lblCategory.Text = "ប្រភេទ:";
            // 
            // txtUnit
            // 
            txtUnit.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUnit.Location = new Point(907, 103);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(412, 51);
            txtUnit.TabIndex = 7;
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUnitPrice.Location = new Point(18, 177);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(194, 43);
            lblUnitPrice.TabIndex = 12;
            lblUnitPrice.Text = "តម្លៃក្នុងមួយឯកតា:";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUnitPrice.Location = new Point(209, 169);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(454, 51);
            txtUnitPrice.TabIndex = 13;
            // 
            // FrmItem
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1800, 1000);
            ControlBox = true;
            Controls.Add(pnlRightSide);
            Controls.Add(pnlLeftSide);
            Controls.Add(lblTitle);
            Name = "FrmItem";
            Text = "ព័ត៌មានបុគ្គលិក";
            Controls.SetChildIndex(lblTitle, 0);
            Controls.SetChildIndex(pnlLeftSide, 0);
            Controls.SetChildIndex(pnlRightSide, 0);
            pnlLeftSide.ResumeLayout(false);
            pnlLeftSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            pnlRightSide.ResumeLayout(false);
            gbItemInformation.ResumeLayout(false);
            gbItemInformation.PerformLayout();
            pnlItemManipulation.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblSearchItem;
        private TextBox txtSearchItem;
        private Panel pnlLeftSide;
        private Panel pnlRightSide;
        private Label lblItemID;
        private TextBox txtUnit;
        private Label lblCategory;
        private TextBox txtItemDescription;
        private Label lblItemDescription;
        private TextBox txtItemID;
        private ComboBox cbCategory;
        private Label lblStockQty;
        private TextBox txtUnitPrice;
        private Label lblUnitPrice;
        private GroupBox gbItemInformation;
        private Panel pnlItemManipulation;
        private Button btnInsertItem;
        private Button btnCancelItem;
        private Button btnNewItem;
        private Button btnUpdateItem;
        private TextBox txtStockQty;
        private Label lblUnit;
        private DataGridView dgvItems;
        private DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn itemDescriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stockQtyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ItemID;
        private DataGridViewTextBoxColumn ItemDescription;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Unit;
        private DataGridViewTextBoxColumn UnitPrice;
        private DataGridViewTextBoxColumn StockQty;
    }
}