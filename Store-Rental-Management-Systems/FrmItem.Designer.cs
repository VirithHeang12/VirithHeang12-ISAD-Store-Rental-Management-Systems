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
            components = new System.ComponentModel.Container();
            lblTitle = new Label();
            lblSearchItem = new Label();
            txtSearchItem = new TextBox();
            pnlLeftSide = new Panel();
            dataItems = new DataGridView();
            itemIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            itemDescriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stockQtyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unitPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            itemBindingSource = new BindingSource(components);
            pnlRightSide = new Panel();
            gbItemInformation = new GroupBox();
            pnlStaffManipulation = new Panel();
            btnCloseFormItem = new Button();
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
            epdStaffFirstName = new ErrorProvider(components);
            epdStaffLastName = new ErrorProvider(components);
            epdStaffIdentityCardNumber = new ErrorProvider(components);
            epdStaffSalary = new ErrorProvider(components);
            epdStaffContactNumber = new ErrorProvider(components);
            epdStaffPersonalNumber = new ErrorProvider(components);
            epdStaffHouseNo = new ErrorProvider(components);
            epdStaffStreetNo = new ErrorProvider(components);
            epdStaffSangkat = new ErrorProvider(components);
            epdStaffKhan = new ErrorProvider(components);
            pnlLeftSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemBindingSource).BeginInit();
            pnlRightSide.SuspendLayout();
            gbItemInformation.SuspendLayout();
            pnlStaffManipulation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)epdStaffFirstName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epdStaffLastName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epdStaffIdentityCardNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epdStaffSalary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epdStaffContactNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epdStaffPersonalNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epdStaffHouseNo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epdStaffStreetNo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epdStaffSangkat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epdStaffKhan).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.DarkBlue;
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
            lblSearchItem.Size = new Size(81, 36);
            lblSearchItem.TabIndex = 1;
            lblSearchItem.Text = "ស្វែងរក:";
            // 
            // txtSearchItem
            // 
            txtSearchItem.Location = new Point(169, 11);
            txtSearchItem.Name = "txtSearchItem";
            txtSearchItem.Size = new Size(1275, 44);
            txtSearchItem.TabIndex = 2;
            // 
            // pnlLeftSide
            // 
            pnlLeftSide.Controls.Add(dataItems);
            pnlLeftSide.Controls.Add(lblSearchItem);
            pnlLeftSide.Controls.Add(txtSearchItem);
            pnlLeftSide.Location = new Point(266, 537);
            pnlLeftSide.Name = "pnlLeftSide";
            pnlLeftSide.Size = new Size(1534, 463);
            pnlLeftSide.TabIndex = 3;
            // 
            // dataItems
            // 
            dataItems.AllowUserToAddRows = false;
            dataItems.AllowUserToDeleteRows = false;
            dataItems.AutoGenerateColumns = false;
            dataItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataItems.Columns.AddRange(new DataGridViewColumn[] { itemIDDataGridViewTextBoxColumn, itemDescriptionDataGridViewTextBoxColumn, stockQtyDataGridViewTextBoxColumn, unitPriceDataGridViewTextBoxColumn, categoryDataGridViewTextBoxColumn, unitDataGridViewTextBoxColumn });
            dataItems.DataSource = itemBindingSource;
            dataItems.Location = new Point(82, 74);
            dataItems.Name = "dataItems";
            dataItems.ReadOnly = true;
            dataItems.RowHeadersWidth = 51;
            dataItems.RowTemplate.Height = 29;
            dataItems.Size = new Size(1362, 337);
            dataItems.TabIndex = 3;
            // 
            // itemIDDataGridViewTextBoxColumn
            // 
            itemIDDataGridViewTextBoxColumn.DataPropertyName = "ItemID";
            itemIDDataGridViewTextBoxColumn.HeaderText = "ItemID";
            itemIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            itemIDDataGridViewTextBoxColumn.Name = "itemIDDataGridViewTextBoxColumn";
            itemIDDataGridViewTextBoxColumn.ReadOnly = true;
            itemIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemDescriptionDataGridViewTextBoxColumn
            // 
            itemDescriptionDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            itemDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ItemDescription";
            itemDescriptionDataGridViewTextBoxColumn.HeaderText = "ItemDescription";
            itemDescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            itemDescriptionDataGridViewTextBoxColumn.Name = "itemDescriptionDataGridViewTextBoxColumn";
            itemDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockQtyDataGridViewTextBoxColumn
            // 
            stockQtyDataGridViewTextBoxColumn.DataPropertyName = "StockQty";
            stockQtyDataGridViewTextBoxColumn.HeaderText = "StockQty";
            stockQtyDataGridViewTextBoxColumn.MinimumWidth = 6;
            stockQtyDataGridViewTextBoxColumn.Name = "stockQtyDataGridViewTextBoxColumn";
            stockQtyDataGridViewTextBoxColumn.ReadOnly = true;
            stockQtyDataGridViewTextBoxColumn.Width = 125;
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
            unitPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            unitPriceDataGridViewTextBoxColumn.ReadOnly = true;
            unitPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            categoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            categoryDataGridViewTextBoxColumn.ReadOnly = true;
            categoryDataGridViewTextBoxColumn.Width = 125;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            unitDataGridViewTextBoxColumn.HeaderText = "Unit";
            unitDataGridViewTextBoxColumn.MinimumWidth = 6;
            unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            unitDataGridViewTextBoxColumn.ReadOnly = true;
            unitDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemBindingSource
            // 
            itemBindingSource.DataSource = typeof(StoreRentalHelper.entities.Item);
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
            gbItemInformation.Controls.Add(pnlStaffManipulation);
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
            gbItemInformation.Font = new Font("!Khmer OS Siemreap", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            gbItemInformation.Location = new Point(82, 12);
            gbItemInformation.Name = "gbItemInformation";
            gbItemInformation.Size = new Size(1362, 335);
            gbItemInformation.TabIndex = 25;
            gbItemInformation.TabStop = false;
            gbItemInformation.Text = "ព័ត៌មានសម្ភារៈ";
            // 
            // pnlStaffManipulation
            // 
            pnlStaffManipulation.Controls.Add(btnCloseFormItem);
            pnlStaffManipulation.Controls.Add(btnNewItem);
            pnlStaffManipulation.Controls.Add(btnUpdateItem);
            pnlStaffManipulation.Controls.Add(btnInsertItem);
            pnlStaffManipulation.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pnlStaffManipulation.Location = new Point(18, 239);
            pnlStaffManipulation.Name = "pnlStaffManipulation";
            pnlStaffManipulation.Size = new Size(1301, 81);
            pnlStaffManipulation.TabIndex = 5;
            // 
            // btnCloseFormItem
            // 
            btnCloseFormItem.Location = new Point(1102, 20);
            btnCloseFormItem.Name = "btnCloseFormItem";
            btnCloseFormItem.Size = new Size(152, 52);
            btnCloseFormItem.TabIndex = 3;
            btnCloseFormItem.Text = "បិទ";
            btnCloseFormItem.UseVisualStyleBackColor = true;
            // 
            // btnNewItem
            // 
            btnNewItem.Location = new Point(774, 20);
            btnNewItem.Name = "btnNewItem";
            btnNewItem.Size = new Size(152, 52);
            btnNewItem.TabIndex = 2;
            btnNewItem.Text = "បង្កើតថ្មី";
            btnNewItem.UseVisualStyleBackColor = true;
            // 
            // btnUpdateItem
            // 
            btnUpdateItem.Location = new Point(411, 20);
            btnUpdateItem.Name = "btnUpdateItem";
            btnUpdateItem.Size = new Size(152, 52);
            btnUpdateItem.TabIndex = 1;
            btnUpdateItem.Text = "កែប្រែ";
            btnUpdateItem.UseVisualStyleBackColor = true;
            // 
            // btnInsertItem
            // 
            btnInsertItem.Location = new Point(20, 20);
            btnInsertItem.Name = "btnInsertItem";
            btnInsertItem.Size = new Size(152, 52);
            btnInsertItem.TabIndex = 0;
            btnInsertItem.Text = "បញ្ចូល";
            btnInsertItem.UseVisualStyleBackColor = true;
            // 
            // txtStockQty
            // 
            txtStockQty.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStockQty.Location = new Point(907, 169);
            txtStockQty.Name = "txtStockQty";
            txtStockQty.Size = new Size(412, 44);
            txtStockQty.TabIndex = 28;
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUnit.Location = new Point(711, 111);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(69, 36);
            lblUnit.TabIndex = 27;
            lblUnit.Text = "ឯកតា:";
            // 
            // cbCategory
            // 
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbCategory.FormattingEnabled = true;
            cbCategory.Items.AddRange(new object[] { "អ្នកគ្រប់គ្រង", "គណនីករ" });
            cbCategory.Location = new Point(209, 103);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(454, 44);
            cbCategory.TabIndex = 15;
            // 
            // lblItemID
            // 
            lblItemID.AutoSize = true;
            lblItemID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblItemID.Location = new Point(18, 41);
            lblItemID.Name = "lblItemID";
            lblItemID.Size = new Size(175, 36);
            lblItemID.TabIndex = 0;
            lblItemID.Text = "លេខសម្គាល់សម្ភារៈ:";
            // 
            // lblStockQty
            // 
            lblStockQty.AutoSize = true;
            lblStockQty.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStockQty.Location = new Point(711, 177);
            lblStockQty.Name = "lblStockQty";
            lblStockQty.Size = new Size(150, 36);
            lblStockQty.TabIndex = 14;
            lblStockQty.Text = "បរិមាណក្នុងស្តុក:";
            // 
            // txtItemDescription
            // 
            txtItemDescription.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtItemDescription.Location = new Point(907, 33);
            txtItemDescription.Name = "txtItemDescription";
            txtItemDescription.Size = new Size(412, 44);
            txtItemDescription.TabIndex = 5;
            // 
            // lblItemDescription
            // 
            lblItemDescription.AutoSize = true;
            lblItemDescription.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblItemDescription.Location = new Point(711, 41);
            lblItemDescription.Name = "lblItemDescription";
            lblItemDescription.Size = new Size(190, 36);
            lblItemDescription.TabIndex = 4;
            lblItemDescription.Text = "ពិពណ៌នារបស់សម្ភារៈ:";
            // 
            // txtItemID
            // 
            txtItemID.Enabled = false;
            txtItemID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtItemID.Location = new Point(209, 33);
            txtItemID.Name = "txtItemID";
            txtItemID.Size = new Size(454, 44);
            txtItemID.TabIndex = 3;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCategory.Location = new Point(18, 111);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(75, 36);
            lblCategory.TabIndex = 6;
            lblCategory.Text = "ប្រភេទ:";
            // 
            // txtUnit
            // 
            txtUnit.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUnit.Location = new Point(907, 103);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(412, 44);
            txtUnit.TabIndex = 7;
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUnitPrice.Location = new Point(18, 177);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(165, 36);
            lblUnitPrice.TabIndex = 12;
            lblUnitPrice.Text = "តម្លៃក្នុងមួយឯកតា:";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUnitPrice.Location = new Point(209, 169);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(454, 44);
            txtUnitPrice.TabIndex = 13;
            // 
            // epdStaffFirstName
            // 
            epdStaffFirstName.ContainerControl = this;
            // 
            // epdStaffLastName
            // 
            epdStaffLastName.ContainerControl = this;
            // 
            // epdStaffIdentityCardNumber
            // 
            epdStaffIdentityCardNumber.ContainerControl = this;
            // 
            // epdStaffSalary
            // 
            epdStaffSalary.ContainerControl = this;
            // 
            // epdStaffContactNumber
            // 
            epdStaffContactNumber.ContainerControl = this;
            // 
            // epdStaffPersonalNumber
            // 
            epdStaffPersonalNumber.ContainerControl = this;
            // 
            // epdStaffHouseNo
            // 
            epdStaffHouseNo.ContainerControl = this;
            // 
            // epdStaffStreetNo
            // 
            epdStaffStreetNo.ContainerControl = this;
            // 
            // epdStaffSangkat
            // 
            epdStaffSangkat.ContainerControl = this;
            // 
            // epdStaffKhan
            // 
            epdStaffKhan.ContainerControl = this;
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
            ((System.ComponentModel.ISupportInitialize)dataItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemBindingSource).EndInit();
            pnlRightSide.ResumeLayout(false);
            gbItemInformation.ResumeLayout(false);
            gbItemInformation.PerformLayout();
            pnlStaffManipulation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)epdStaffFirstName).EndInit();
            ((System.ComponentModel.ISupportInitialize)epdStaffLastName).EndInit();
            ((System.ComponentModel.ISupportInitialize)epdStaffIdentityCardNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)epdStaffSalary).EndInit();
            ((System.ComponentModel.ISupportInitialize)epdStaffContactNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)epdStaffPersonalNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)epdStaffHouseNo).EndInit();
            ((System.ComponentModel.ISupportInitialize)epdStaffStreetNo).EndInit();
            ((System.ComponentModel.ISupportInitialize)epdStaffSangkat).EndInit();
            ((System.ComponentModel.ISupportInitialize)epdStaffKhan).EndInit();
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
        private Panel pnlStaffManipulation;
        private Button btnInsertItem;
        private Button btnCloseFormItem;
        private Button btnNewItem;
        private Button btnUpdateItem;
        private ErrorProvider epdStaffFirstName;
        private ErrorProvider epdStaffLastName;
        private ErrorProvider epdStaffIdentityCardNumber;
        private ErrorProvider epdStaffSalary;
        private ErrorProvider epdStaffContactNumber;
        private ErrorProvider epdStaffPersonalNumber;
        private ErrorProvider epdStaffHouseNo;
        private ErrorProvider epdStaffStreetNo;
        private ErrorProvider epdStaffSangkat;
        private ErrorProvider epdStaffKhan;
        private TextBox txtStockQty;
        private Label lblUnit;
        private DataGridView dataItems;
        private BindingSource itemBindingSource;
        private DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn itemDescriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stockQtyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
    }
}