namespace Store_Rental_Management_Systems
{
    partial class FrmImport
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
            pnlRightSide = new Panel();
            gbImportDetails = new GroupBox();
            btnUpdateImportItem = new Button();
            btnInsertImportItem = new Button();
            txtUnit = new TextBox();
            lblUnit = new Label();
            txtImportQty = new TextBox();
            lblItemDescription = new Label();
            txtItemDescription = new TextBox();
            txtItemID = new TextBox();
            lblImportQty = new Label();
            lblItemID = new Label();
            lblUnitPrice = new Label();
            txtCategory = new TextBox();
            txtUnitPrice = new TextBox();
            lblCategory = new Label();
            gbImportInformation = new GroupBox();
            lblStaffID = new Label();
            lblSupplierName = new Label();
            lblSupplierID = new Label();
            txtTotalAmount = new TextBox();
            lblTotalAmount = new Label();
            lblImportID = new Label();
            txtStaffPosition = new TextBox();
            lblStaffPosition = new Label();
            txtStaffName = new TextBox();
            lblStaffName = new Label();
            cbStaffID = new ComboBox();
            txtSupplierName = new TextBox();
            cbSupplierID = new ComboBox();
            dtpImportDate = new DateTimePicker();
            lblImportDate = new Label();
            txtImportID = new TextBox();
            pnlImportManipulation = new Panel();
            btnCloseFormImport = new Button();
            btnNewImport = new Button();
            btnUpdateImport = new Button();
            btnInsertImport = new Button();
            pnlLeftSide = new Panel();
            dgvImportItems = new DataGridView();
            lblSearchImport = new Label();
            txtSearchImport = new TextBox();
            lblPaidAmount = new Label();
            txtPaidAmount = new TextBox();
            lblOwedAmount = new Label();
            txtOwedAmount = new TextBox();
            itemIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            DescriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            importQtyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unitPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            AmountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pnlRightSide.SuspendLayout();
            gbImportDetails.SuspendLayout();
            gbImportInformation.SuspendLayout();
            pnlImportManipulation.SuspendLayout();
            pnlLeftSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvImportItems).BeginInit();
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
            lblTitle.Text = "ព័ត៌មានការនាំចូល";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlRightSide
            // 
            pnlRightSide.Controls.Add(gbImportDetails);
            pnlRightSide.Controls.Add(gbImportInformation);
            pnlRightSide.Location = new Point(266, 184);
            pnlRightSide.Name = "pnlRightSide";
            pnlRightSide.Size = new Size(1534, 375);
            pnlRightSide.TabIndex = 4;
            // 
            // gbImportDetails
            // 
            gbImportDetails.Controls.Add(btnUpdateImportItem);
            gbImportDetails.Controls.Add(btnInsertImportItem);
            gbImportDetails.Controls.Add(txtUnit);
            gbImportDetails.Controls.Add(lblUnit);
            gbImportDetails.Controls.Add(txtImportQty);
            gbImportDetails.Controls.Add(lblItemDescription);
            gbImportDetails.Controls.Add(txtItemDescription);
            gbImportDetails.Controls.Add(txtItemID);
            gbImportDetails.Controls.Add(lblImportQty);
            gbImportDetails.Controls.Add(lblItemID);
            gbImportDetails.Controls.Add(lblUnitPrice);
            gbImportDetails.Controls.Add(txtCategory);
            gbImportDetails.Controls.Add(txtUnitPrice);
            gbImportDetails.Controls.Add(lblCategory);
            gbImportDetails.Font = new Font("!Khmer OS Siemreap", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            gbImportDetails.Location = new Point(63, 214);
            gbImportDetails.Name = "gbImportDetails";
            gbImportDetails.Size = new Size(1427, 154);
            gbImportDetails.TabIndex = 26;
            gbImportDetails.TabStop = false;
            gbImportDetails.Text = "សេចក្ដីលម្អិត";
            // 
            // btnUpdateImportItem
            // 
            btnUpdateImportItem.BackColor = Color.FromArgb(0, 28, 87);
            btnUpdateImportItem.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateImportItem.ForeColor = Color.White;
            btnUpdateImportItem.Location = new Point(1281, 93);
            btnUpdateImportItem.Name = "btnUpdateImportItem";
            btnUpdateImportItem.Size = new Size(100, 52);
            btnUpdateImportItem.TabIndex = 4;
            btnUpdateImportItem.Text = "កែប្រែ";
            btnUpdateImportItem.UseVisualStyleBackColor = false;
            // 
            // btnInsertImportItem
            // 
            btnInsertImportItem.BackColor = Color.FromArgb(0, 28, 87);
            btnInsertImportItem.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsertImportItem.ForeColor = Color.White;
            btnInsertImportItem.Location = new Point(1151, 93);
            btnInsertImportItem.Name = "btnInsertImportItem";
            btnInsertImportItem.Size = new Size(102, 52);
            btnInsertImportItem.TabIndex = 28;
            btnInsertImportItem.Text = "បញ្ចូល";
            btnInsertImportItem.UseVisualStyleBackColor = false;
            // 
            // txtUnit
            // 
            txtUnit.Enabled = false;
            txtUnit.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUnit.Location = new Point(1151, 30);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(230, 44);
            txtUnit.TabIndex = 27;
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUnit.Location = new Point(960, 38);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(69, 36);
            lblUnit.TabIndex = 26;
            lblUnit.Text = "ឯកតា:";
            // 
            // txtImportQty
            // 
            txtImportQty.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtImportQty.Location = new Point(858, 98);
            txtImportQty.Name = "txtImportQty";
            txtImportQty.Size = new Size(196, 44);
            txtImportQty.TabIndex = 25;
            // 
            // lblItemDescription
            // 
            lblItemDescription.AutoSize = true;
            lblItemDescription.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblItemDescription.Location = new Point(482, 38);
            lblItemDescription.Name = "lblItemDescription";
            lblItemDescription.Size = new Size(190, 36);
            lblItemDescription.TabIndex = 18;
            lblItemDescription.Text = "ពិព័ណ៌នារបស់សម្ភារៈ:";
            // 
            // txtItemDescription
            // 
            txtItemDescription.Enabled = false;
            txtItemDescription.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtItemDescription.Location = new Point(710, 35);
            txtItemDescription.Name = "txtItemDescription";
            txtItemDescription.Size = new Size(219, 44);
            txtItemDescription.TabIndex = 19;
            // 
            // txtItemID
            // 
            txtItemID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtItemID.Location = new Point(199, 35);
            txtItemID.Name = "txtItemID";
            txtItemID.Size = new Size(245, 44);
            txtItemID.TabIndex = 17;
            // 
            // lblImportQty
            // 
            lblImportQty.AutoSize = true;
            lblImportQty.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblImportQty.Location = new Point(710, 106);
            lblImportQty.Name = "lblImportQty";
            lblImportQty.Size = new Size(142, 36);
            lblImportQty.TabIndex = 24;
            lblImportQty.Text = "បរិមាណនាំចូល:";
            // 
            // lblItemID
            // 
            lblItemID.AutoSize = true;
            lblItemID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblItemID.Location = new Point(18, 38);
            lblItemID.Name = "lblItemID";
            lblItemID.Size = new Size(175, 36);
            lblItemID.TabIndex = 16;
            lblItemID.Text = "លេខសម្គាល់សម្ភារៈ:";
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUnitPrice.Location = new Point(18, 101);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(165, 36);
            lblUnitPrice.TabIndex = 20;
            lblUnitPrice.Text = "តម្លៃក្នុងមួយឯកតា:";
            // 
            // txtCategory
            // 
            txtCategory.Enabled = false;
            txtCategory.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCategory.Location = new Point(482, 98);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(204, 44);
            txtCategory.TabIndex = 23;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Enabled = false;
            txtUnitPrice.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUnitPrice.Location = new Point(199, 98);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(151, 44);
            txtUnitPrice.TabIndex = 21;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCategory.Location = new Point(387, 101);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(75, 36);
            lblCategory.TabIndex = 22;
            lblCategory.Text = "ប្រភេទ:";
            // 
            // gbImportInformation
            // 
            gbImportInformation.Controls.Add(txtOwedAmount);
            gbImportInformation.Controls.Add(lblOwedAmount);
            gbImportInformation.Controls.Add(txtPaidAmount);
            gbImportInformation.Controls.Add(lblPaidAmount);
            gbImportInformation.Controls.Add(lblStaffID);
            gbImportInformation.Controls.Add(lblSupplierName);
            gbImportInformation.Controls.Add(lblSupplierID);
            gbImportInformation.Controls.Add(txtTotalAmount);
            gbImportInformation.Controls.Add(lblTotalAmount);
            gbImportInformation.Controls.Add(lblImportID);
            gbImportInformation.Controls.Add(txtStaffPosition);
            gbImportInformation.Controls.Add(lblStaffPosition);
            gbImportInformation.Controls.Add(txtStaffName);
            gbImportInformation.Controls.Add(lblStaffName);
            gbImportInformation.Controls.Add(cbStaffID);
            gbImportInformation.Controls.Add(txtSupplierName);
            gbImportInformation.Controls.Add(cbSupplierID);
            gbImportInformation.Controls.Add(dtpImportDate);
            gbImportInformation.Controls.Add(lblImportDate);
            gbImportInformation.Controls.Add(txtImportID);
            gbImportInformation.Font = new Font("!Khmer OS Siemreap", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            gbImportInformation.Location = new Point(63, 19);
            gbImportInformation.Name = "gbImportInformation";
            gbImportInformation.Size = new Size(1427, 194);
            gbImportInformation.TabIndex = 25;
            gbImportInformation.TabStop = false;
            gbImportInformation.Text = "ព័ត៌មានការនាំចូល";
            // 
            // lblStaffID
            // 
            lblStaffID.AutoSize = true;
            lblStaffID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffID.Location = new Point(361, 148);
            lblStaffID.Name = "lblStaffID";
            lblStaffID.Size = new Size(183, 36);
            lblStaffID.TabIndex = 39;
            lblStaffID.Text = "លេខសម្គាល់បុគ្គលិក:";
            // 
            // lblSupplierName
            // 
            lblSupplierName.AutoSize = true;
            lblSupplierName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSupplierName.Location = new Point(18, 143);
            lblSupplierName.Name = "lblSupplierName";
            lblSupplierName.Size = new Size(152, 36);
            lblSupplierName.TabIndex = 38;
            lblSupplierName.Text = "ឈ្មោះអ្នកផ្គត់ផ្គង់:";
            // 
            // lblSupplierID
            // 
            lblSupplierID.AutoSize = true;
            lblSupplierID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSupplierID.Location = new Point(928, 93);
            lblSupplierID.Name = "lblSupplierID";
            lblSupplierID.Size = new Size(205, 36);
            lblSupplierID.TabIndex = 37;
            lblSupplierID.Text = "លេខសម្គាល់អ្នកផ្គត់ផ្គង់:";
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotalAmount.Location = new Point(1151, 33);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.Size = new Size(230, 44);
            txtTotalAmount.TabIndex = 36;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalAmount.Location = new Point(928, 36);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(171, 36);
            lblTotalAmount.TabIndex = 35;
            lblTotalAmount.Text = "ចំនួនទឹកប្រាក់សរុប:";
            // 
            // lblImportID
            // 
            lblImportID.AutoSize = true;
            lblImportID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblImportID.Location = new Point(18, 41);
            lblImportID.Name = "lblImportID";
            lblImportID.Size = new Size(201, 36);
            lblImportID.TabIndex = 34;
            lblImportID.Text = "លេខសម្គាល់ការនាំចូល:";
            // 
            // txtStaffPosition
            // 
            txtStaffPosition.Enabled = false;
            txtStaffPosition.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffPosition.Location = new Point(1195, 140);
            txtStaffPosition.Name = "txtStaffPosition";
            txtStaffPosition.Size = new Size(186, 44);
            txtStaffPosition.TabIndex = 33;
            // 
            // lblStaffPosition
            // 
            lblStaffPosition.AutoSize = true;
            lblStaffPosition.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffPosition.Location = new Point(1047, 148);
            lblStaffPosition.Name = "lblStaffPosition";
            lblStaffPosition.Size = new Size(131, 36);
            lblStaffPosition.TabIndex = 32;
            lblStaffPosition.Text = "តួនាទីបុគ្គលិក:";
            // 
            // txtStaffName
            // 
            txtStaffName.Enabled = false;
            txtStaffName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffName.Location = new Point(858, 140);
            txtStaffName.Name = "txtStaffName";
            txtStaffName.Size = new Size(171, 44);
            txtStaffName.TabIndex = 31;
            // 
            // lblStaffName
            // 
            lblStaffName.AutoSize = true;
            lblStaffName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffName.Location = new Point(722, 148);
            lblStaffName.Name = "lblStaffName";
            lblStaffName.Size = new Size(130, 36);
            lblStaffName.TabIndex = 30;
            lblStaffName.Text = "ឈ្មោះបុគ្គលិក:";
            // 
            // cbStaffID
            // 
            cbStaffID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbStaffID.FormattingEnabled = true;
            cbStaffID.Items.AddRange(new object[] { "ភ្នំពេញ", "តាកែវ" });
            cbStaffID.Location = new Point(550, 140);
            cbStaffID.Name = "cbStaffID";
            cbStaffID.Size = new Size(166, 44);
            cbStaffID.TabIndex = 29;
            // 
            // txtSupplierName
            // 
            txtSupplierName.Enabled = false;
            txtSupplierName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSupplierName.Location = new Point(182, 140);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(168, 44);
            txtSupplierName.TabIndex = 28;
            // 
            // cbSupplierID
            // 
            cbSupplierID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbSupplierID.FormattingEnabled = true;
            cbSupplierID.Items.AddRange(new object[] { "ភ្នំពេញ", "តាកែវ" });
            cbSupplierID.Location = new Point(1151, 85);
            cbSupplierID.Name = "cbSupplierID";
            cbSupplierID.Size = new Size(230, 44);
            cbSupplierID.TabIndex = 27;
            // 
            // dtpImportDate
            // 
            dtpImportDate.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpImportDate.Format = DateTimePickerFormat.Short;
            dtpImportDate.Location = new Point(670, 35);
            dtpImportDate.Name = "dtpImportDate";
            dtpImportDate.Size = new Size(237, 44);
            dtpImportDate.TabIndex = 20;
            // 
            // lblImportDate
            // 
            lblImportDate.AutoSize = true;
            lblImportDate.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblImportDate.Location = new Point(482, 41);
            lblImportDate.Name = "lblImportDate";
            lblImportDate.Size = new Size(169, 36);
            lblImportDate.TabIndex = 19;
            lblImportDate.Text = "កាលបរិច្ឆេទនាំចូល:";
            // 
            // txtImportID
            // 
            txtImportID.Enabled = false;
            txtImportID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtImportID.Location = new Point(227, 33);
            txtImportID.Name = "txtImportID";
            txtImportID.Size = new Size(235, 44);
            txtImportID.TabIndex = 3;
            // 
            // pnlImportManipulation
            // 
            pnlImportManipulation.Controls.Add(btnCloseFormImport);
            pnlImportManipulation.Controls.Add(btnNewImport);
            pnlImportManipulation.Controls.Add(btnUpdateImport);
            pnlImportManipulation.Controls.Add(btnInsertImport);
            pnlImportManipulation.Location = new Point(329, 563);
            pnlImportManipulation.Name = "pnlImportManipulation";
            pnlImportManipulation.Size = new Size(1427, 62);
            pnlImportManipulation.TabIndex = 5;
            // 
            // btnCloseFormImport
            // 
            btnCloseFormImport.BackColor = Color.FromArgb(0, 28, 87);
            btnCloseFormImport.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCloseFormImport.ForeColor = Color.White;
            btnCloseFormImport.Location = new Point(1231, 7);
            btnCloseFormImport.Name = "btnCloseFormImport";
            btnCloseFormImport.Size = new Size(134, 52);
            btnCloseFormImport.TabIndex = 3;
            btnCloseFormImport.Text = "បិទ";
            btnCloseFormImport.UseVisualStyleBackColor = false;
            // 
            // btnNewImport
            // 
            btnNewImport.BackColor = Color.FromArgb(0, 28, 87);
            btnNewImport.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNewImport.ForeColor = Color.White;
            btnNewImport.Location = new Point(843, 7);
            btnNewImport.Name = "btnNewImport";
            btnNewImport.Size = new Size(152, 52);
            btnNewImport.TabIndex = 2;
            btnNewImport.Text = "បង្កើតថ្មី";
            btnNewImport.UseVisualStyleBackColor = false;
            // 
            // btnUpdateImport
            // 
            btnUpdateImport.BackColor = Color.FromArgb(0, 28, 87);
            btnUpdateImport.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateImport.ForeColor = Color.White;
            btnUpdateImport.Location = new Point(455, 7);
            btnUpdateImport.Name = "btnUpdateImport";
            btnUpdateImport.Size = new Size(152, 52);
            btnUpdateImport.TabIndex = 1;
            btnUpdateImport.Text = "កែប្រែ";
            btnUpdateImport.UseVisualStyleBackColor = false;
            // 
            // btnInsertImport
            // 
            btnInsertImport.BackColor = Color.FromArgb(0, 28, 87);
            btnInsertImport.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsertImport.ForeColor = Color.White;
            btnInsertImport.Location = new Point(67, 7);
            btnInsertImport.Name = "btnInsertImport";
            btnInsertImport.Size = new Size(152, 52);
            btnInsertImport.TabIndex = 0;
            btnInsertImport.Text = "បញ្ចូល";
            btnInsertImport.UseVisualStyleBackColor = false;
            // 
            // pnlLeftSide
            // 
            pnlLeftSide.Controls.Add(dgvImportItems);
            pnlLeftSide.Controls.Add(lblSearchImport);
            pnlLeftSide.Controls.Add(txtSearchImport);
            pnlLeftSide.Location = new Point(266, 643);
            pnlLeftSide.Name = "pnlLeftSide";
            pnlLeftSide.Size = new Size(1800, 354);
            pnlLeftSide.TabIndex = 6;
            // 
            // dgvImportItems
            // 
            dgvImportItems.AllowUserToAddRows = false;
            dgvImportItems.AllowUserToDeleteRows = false;
            dgvImportItems.AutoGenerateColumns = false;
            dgvImportItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvImportItems.Columns.AddRange(new DataGridViewColumn[] { itemIDDataGridViewTextBoxColumn, DescriptionDataGridViewTextBoxColumn, importQtyDataGridViewTextBoxColumn, unitPriceDataGridViewTextBoxColumn, AmountDataGridViewTextBoxColumn });
            dgvImportItems.Location = new Point(63, 74);
            dgvImportItems.Name = "dgvImportItems";
            dgvImportItems.ReadOnly = true;
            dgvImportItems.RowHeadersWidth = 51;
            dgvImportItems.RowTemplate.Height = 29;
            dgvImportItems.Size = new Size(1427, 238);
            dgvImportItems.TabIndex = 3;
            // 
            // lblSearchImport
            // 
            lblSearchImport.AutoSize = true;
            lblSearchImport.Location = new Point(64, 17);
            lblSearchImport.Name = "lblSearchImport";
            lblSearchImport.Size = new Size(289, 36);
            lblSearchImport.TabIndex = 1;
            lblSearchImport.Text = "ស្វែងរក (លេខសម្គាល់ការនាំចូល):";
            // 
            // txtSearchImport
            // 
            txtSearchImport.Location = new Point(372, 11);
            txtSearchImport.Name = "txtSearchImport";
            txtSearchImport.Size = new Size(543, 44);
            txtSearchImport.TabIndex = 2;
            // 
            // lblPaidAmount
            // 
            lblPaidAmount.AutoSize = true;
            lblPaidAmount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPaidAmount.Location = new Point(18, 88);
            lblPaidAmount.Name = "lblPaidAmount";
            lblPaidAmount.Size = new Size(193, 36);
            lblPaidAmount.TabIndex = 40;
            lblPaidAmount.Text = "ចំនួនទឹកប្រាក់បានបង់:";
            // 
            // txtPaidAmount
            // 
            txtPaidAmount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPaidAmount.Location = new Point(227, 85);
            txtPaidAmount.Name = "txtPaidAmount";
            txtPaidAmount.Size = new Size(235, 44);
            txtPaidAmount.TabIndex = 41;
            // 
            // lblOwedAmount
            // 
            lblOwedAmount.AutoSize = true;
            lblOwedAmount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblOwedAmount.Location = new Point(482, 88);
            lblOwedAmount.Name = "lblOwedAmount";
            lblOwedAmount.Size = new Size(179, 36);
            lblOwedAmount.TabIndex = 42;
            lblOwedAmount.Text = "ចំនួនទឹកប្រាក់ជំពាក់:";
            // 
            // txtOwedAmount
            // 
            txtOwedAmount.Enabled = false;
            txtOwedAmount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtOwedAmount.Location = new Point(670, 85);
            txtOwedAmount.Name = "txtOwedAmount";
            txtOwedAmount.Size = new Size(237, 44);
            txtOwedAmount.TabIndex = 43;
            // 
            // itemIDDataGridViewTextBoxColumn
            // 
            itemIDDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            itemIDDataGridViewTextBoxColumn.DataPropertyName = "ItemID";
            itemIDDataGridViewTextBoxColumn.HeaderText = "លេខសម្គាល់សម្ភារៈ";
            itemIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            itemIDDataGridViewTextBoxColumn.Name = "itemIDDataGridViewTextBoxColumn";
            itemIDDataGridViewTextBoxColumn.ReadOnly = true;
            itemIDDataGridViewTextBoxColumn.Width = 198;
            // 
            // DescriptionDataGridViewTextBoxColumn
            // 
            DescriptionDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DescriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            DescriptionDataGridViewTextBoxColumn.HeaderText = "ពិព័ណ៌នារបស់សម្ភារៈ";
            DescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn";
            DescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // importQtyDataGridViewTextBoxColumn
            // 
            importQtyDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            importQtyDataGridViewTextBoxColumn.DataPropertyName = "ImportQty";
            importQtyDataGridViewTextBoxColumn.HeaderText = "បរិមាណនាំចូល";
            importQtyDataGridViewTextBoxColumn.MinimumWidth = 6;
            importQtyDataGridViewTextBoxColumn.Name = "importQtyDataGridViewTextBoxColumn";
            importQtyDataGridViewTextBoxColumn.ReadOnly = true;
            importQtyDataGridViewTextBoxColumn.Width = 165;
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            unitPriceDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            unitPriceDataGridViewTextBoxColumn.HeaderText = "តម្លៃក្នុងមួយឯកតា";
            unitPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            unitPriceDataGridViewTextBoxColumn.ReadOnly = true;
            unitPriceDataGridViewTextBoxColumn.Width = 188;
            // 
            // AmountDataGridViewTextBoxColumn
            // 
            AmountDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            AmountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            AmountDataGridViewTextBoxColumn.HeaderText = "តម្លៃ";
            AmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            AmountDataGridViewTextBoxColumn.Name = "AmountDataGridViewTextBoxColumn";
            AmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmImport
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1800, 1000);
            ControlBox = true;
            Controls.Add(pnlLeftSide);
            Controls.Add(pnlImportManipulation);
            Controls.Add(pnlRightSide);
            Controls.Add(lblTitle);
            Name = "FrmImport";
            Text = "ព័ត៌មានបុគ្គលិក";
            Controls.SetChildIndex(lblTitle, 0);
            Controls.SetChildIndex(pnlRightSide, 0);
            Controls.SetChildIndex(pnlImportManipulation, 0);
            Controls.SetChildIndex(pnlLeftSide, 0);
            pnlRightSide.ResumeLayout(false);
            gbImportDetails.ResumeLayout(false);
            gbImportDetails.PerformLayout();
            gbImportInformation.ResumeLayout(false);
            gbImportInformation.PerformLayout();
            pnlImportManipulation.ResumeLayout(false);
            pnlLeftSide.ResumeLayout(false);
            pnlLeftSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvImportItems).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Panel pnlRightSide;
        private TextBox txtImportID;
        private TextBox txtItemDescription;
        private Label lblItemDescription;
        private TextBox txtItemID;
        private Label lblItemID;
        private Label lblImportQty;
        private Label lblCategory;
        private TextBox txtUnitPrice;
        private Label lblUnitPrice;
        private TextBox txtCategory;
        private GroupBox gbImportInformation;
        private GroupBox gbImportDetails;
        private DateTimePicker dtpImportDate;
        private Label lblImportDate;
        private Panel pnlImportManipulation;
        private Button btnInsertImport;
        private Button btnCloseFormImport;
        private Button btnNewImport;
        private Button btnUpdateImport;
        private ComboBox cbSupplierID;
        private TextBox txtSupplierName;
        private ComboBox cbStaffID;
        private TextBox txtStaffName;
        private Label lblStaffName;
        private TextBox txtStaffPosition;
        private Label lblStaffPosition;
        private Label lblImportID;
        private TextBox txtUnit;
        private Label lblUnit;
        private TextBox txtImportQty;
        private Button btnUpdateImportItem;
        private Button btnInsertImportItem;
        private Panel pnlLeftSide;
        private DataGridView dgvImportItems;
        private Label lblSearchImport;
        private TextBox txtSearchImport;
        private Label lblSupplierName;
        private Label lblSupplierID;
        private TextBox txtTotalAmount;
        private Label lblTotalAmount;
        private Label lblStaffID;
        private Label lblPaidAmount;
        private TextBox txtPaidAmount;
        private Label lblOwedAmount;
        private TextBox txtOwedAmount;
        private DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn DescriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn importQtyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn AmountDataGridViewTextBoxColumn;
    }
}