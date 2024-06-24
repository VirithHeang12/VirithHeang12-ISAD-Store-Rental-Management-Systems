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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblTitle = new Label();
            pnlRightSide = new Panel();
            gbImportDetails = new GroupBox();
            txtAmount = new TextBox();
            lblAmount = new Label();
            cbItemID = new ComboBox();
            btnUpdateImportItem = new Button();
            btnInsertImportItem = new Button();
            txtImportQty = new TextBox();
            lblItemDescription = new Label();
            txtItemDescription = new TextBox();
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
            cbSearchImport = new ComboBox();
            dgvImportItems = new DataGridView();
            ItemID = new DataGridViewTextBoxColumn();
            ImportID = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            UnitPrice = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            lblSearchImport = new Label();
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
            gbImportDetails.Controls.Add(txtAmount);
            gbImportDetails.Controls.Add(lblAmount);
            gbImportDetails.Controls.Add(cbItemID);
            gbImportDetails.Controls.Add(btnUpdateImportItem);
            gbImportDetails.Controls.Add(btnInsertImportItem);
            gbImportDetails.Controls.Add(txtImportQty);
            gbImportDetails.Controls.Add(lblItemDescription);
            gbImportDetails.Controls.Add(txtItemDescription);
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
            // txtAmount
            // 
            txtAmount.Enabled = false;
            txtAmount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAmount.Location = new Point(843, 98);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(280, 51);
            txtAmount.TabIndex = 32;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAmount.Location = new Point(762, 101);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(66, 43);
            lblAmount.TabIndex = 31;
            lblAmount.Text = "តម្លៃ:";
            // 
            // cbItemID
            // 
            cbItemID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbItemID.FormattingEnabled = true;
            cbItemID.Items.AddRange(new object[] { "ភ្នំពេញ", "តាកែវ" });
            cbItemID.Location = new Point(199, 35);
            cbItemID.Name = "cbItemID";
            cbItemID.Size = new Size(263, 51);
            cbItemID.TabIndex = 30;
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
            // txtImportQty
            // 
            txtImportQty.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtImportQty.Location = new Point(482, 98);
            txtImportQty.Name = "txtImportQty";
            txtImportQty.Size = new Size(190, 51);
            txtImportQty.TabIndex = 25;
            // 
            // lblItemDescription
            // 
            lblItemDescription.AutoSize = true;
            lblItemDescription.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblItemDescription.Location = new Point(482, 38);
            lblItemDescription.Name = "lblItemDescription";
            lblItemDescription.Size = new Size(225, 43);
            lblItemDescription.TabIndex = 18;
            lblItemDescription.Text = "ពិព័ណ៌នារបស់សម្ភារៈ:";
            // 
            // txtItemDescription
            // 
            txtItemDescription.Enabled = false;
            txtItemDescription.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtItemDescription.Location = new Point(710, 35);
            txtItemDescription.Name = "txtItemDescription";
            txtItemDescription.Size = new Size(219, 51);
            txtItemDescription.TabIndex = 19;
            // 
            // lblImportQty
            // 
            lblImportQty.AutoSize = true;
            lblImportQty.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblImportQty.Location = new Point(330, 101);
            lblImportQty.Name = "lblImportQty";
            lblImportQty.Size = new Size(169, 43);
            lblImportQty.TabIndex = 24;
            lblImportQty.Text = "បរិមាណនាំចូល:";
            // 
            // lblItemID
            // 
            lblItemID.AutoSize = true;
            lblItemID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblItemID.Location = new Point(18, 38);
            lblItemID.Name = "lblItemID";
            lblItemID.Size = new Size(207, 43);
            lblItemID.TabIndex = 16;
            lblItemID.Text = "លេខសម្គាល់សម្ភារៈ:";
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUnitPrice.Location = new Point(967, 38);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(194, 43);
            lblUnitPrice.TabIndex = 20;
            lblUnitPrice.Text = "តម្លៃក្នុងមួយឯកតា:";
            // 
            // txtCategory
            // 
            txtCategory.Enabled = false;
            txtCategory.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCategory.Location = new Point(126, 98);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(164, 51);
            txtCategory.TabIndex = 23;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Enabled = false;
            txtUnitPrice.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUnitPrice.Location = new Point(1151, 35);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(230, 51);
            txtUnitPrice.TabIndex = 21;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCategory.Location = new Point(18, 101);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(90, 43);
            lblCategory.TabIndex = 22;
            lblCategory.Text = "ប្រភេទ:";
            // 
            // gbImportInformation
            // 
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
            lblStaffID.Location = new Point(18, 143);
            lblStaffID.Name = "lblStaffID";
            lblStaffID.Size = new Size(214, 43);
            lblStaffID.TabIndex = 39;
            lblStaffID.Text = "លេខសម្គាល់បុគ្គលិក:";
            // 
            // lblSupplierName
            // 
            lblSupplierName.AutoSize = true;
            lblSupplierName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSupplierName.Location = new Point(482, 93);
            lblSupplierName.Name = "lblSupplierName";
            lblSupplierName.Size = new Size(180, 43);
            lblSupplierName.TabIndex = 38;
            lblSupplierName.Text = "ឈ្មោះអ្នកផ្គត់ផ្គង់:";
            // 
            // lblSupplierID
            // 
            lblSupplierID.AutoSize = true;
            lblSupplierID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSupplierID.Location = new Point(18, 93);
            lblSupplierID.Name = "lblSupplierID";
            lblSupplierID.Size = new Size(239, 43);
            lblSupplierID.TabIndex = 37;
            lblSupplierID.Text = "លេខសម្គាល់អ្នកផ្គត់ផ្គង់:";
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Enabled = false;
            txtTotalAmount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotalAmount.Location = new Point(1151, 33);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.Size = new Size(230, 51);
            txtTotalAmount.TabIndex = 36;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalAmount.Location = new Point(928, 36);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(201, 43);
            lblTotalAmount.TabIndex = 35;
            lblTotalAmount.Text = "ចំនួនទឹកប្រាក់សរុប:";
            // 
            // lblImportID
            // 
            lblImportID.AutoSize = true;
            lblImportID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblImportID.Location = new Point(18, 41);
            lblImportID.Name = "lblImportID";
            lblImportID.Size = new Size(238, 43);
            lblImportID.TabIndex = 34;
            lblImportID.Text = "លេខសម្គាល់ការនាំចូល:";
            // 
            // txtStaffPosition
            // 
            txtStaffPosition.Enabled = false;
            txtStaffPosition.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffPosition.Location = new Point(1151, 140);
            txtStaffPosition.Name = "txtStaffPosition";
            txtStaffPosition.Size = new Size(230, 51);
            txtStaffPosition.TabIndex = 33;
            // 
            // lblStaffPosition
            // 
            lblStaffPosition.AutoSize = true;
            lblStaffPosition.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffPosition.Location = new Point(928, 143);
            lblStaffPosition.Name = "lblStaffPosition";
            lblStaffPosition.Size = new Size(153, 43);
            lblStaffPosition.TabIndex = 32;
            lblStaffPosition.Text = "តួនាទីបុគ្គលិក:";
            // 
            // txtStaffName
            // 
            txtStaffName.Enabled = false;
            txtStaffName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffName.Location = new Point(670, 145);
            txtStaffName.Name = "txtStaffName";
            txtStaffName.Size = new Size(237, 51);
            txtStaffName.TabIndex = 31;
            // 
            // lblStaffName
            // 
            lblStaffName.AutoSize = true;
            lblStaffName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffName.Location = new Point(482, 143);
            lblStaffName.Name = "lblStaffName";
            lblStaffName.Size = new Size(155, 43);
            lblStaffName.TabIndex = 30;
            lblStaffName.Text = "ឈ្មោះបុគ្គលិក:";
            // 
            // cbStaffID
            // 
            cbStaffID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbStaffID.FormattingEnabled = true;
            cbStaffID.Items.AddRange(new object[] { "ភ្នំពេញ", "តាកែវ" });
            cbStaffID.Location = new Point(227, 135);
            cbStaffID.Name = "cbStaffID";
            cbStaffID.Size = new Size(235, 51);
            cbStaffID.TabIndex = 29;
            // 
            // txtSupplierName
            // 
            txtSupplierName.Enabled = false;
            txtSupplierName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSupplierName.Location = new Point(670, 85);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(711, 51);
            txtSupplierName.TabIndex = 28;
            // 
            // cbSupplierID
            // 
            cbSupplierID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbSupplierID.FormattingEnabled = true;
            cbSupplierID.Items.AddRange(new object[] { "ភ្នំពេញ", "តាកែវ" });
            cbSupplierID.Location = new Point(227, 85);
            cbSupplierID.Name = "cbSupplierID";
            cbSupplierID.Size = new Size(235, 51);
            cbSupplierID.TabIndex = 27;
            // 
            // dtpImportDate
            // 
            dtpImportDate.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpImportDate.Format = DateTimePickerFormat.Short;
            dtpImportDate.Location = new Point(670, 35);
            dtpImportDate.Name = "dtpImportDate";
            dtpImportDate.Size = new Size(237, 51);
            dtpImportDate.TabIndex = 20;
            // 
            // lblImportDate
            // 
            lblImportDate.AutoSize = true;
            lblImportDate.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblImportDate.Location = new Point(482, 41);
            lblImportDate.Name = "lblImportDate";
            lblImportDate.Size = new Size(200, 43);
            lblImportDate.TabIndex = 19;
            lblImportDate.Text = "កាលបរិច្ឆេទនាំចូល:";
            // 
            // txtImportID
            // 
            txtImportID.Enabled = false;
            txtImportID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtImportID.Location = new Point(227, 33);
            txtImportID.Name = "txtImportID";
            txtImportID.Size = new Size(235, 51);
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
            pnlLeftSide.Controls.Add(cbSearchImport);
            pnlLeftSide.Controls.Add(dgvImportItems);
            pnlLeftSide.Controls.Add(lblSearchImport);
            pnlLeftSide.Location = new Point(266, 643);
            pnlLeftSide.Name = "pnlLeftSide";
            pnlLeftSide.Size = new Size(1800, 354);
            pnlLeftSide.TabIndex = 6;
            // 
            // cbSearchImport
            // 
            cbSearchImport.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbSearchImport.FormattingEnabled = true;
            cbSearchImport.Items.AddRange(new object[] { "ភ្នំពេញ", "តាកែវ" });
            cbSearchImport.Location = new Point(393, 9);
            cbSearchImport.Name = "cbSearchImport";
            cbSearchImport.Size = new Size(342, 51);
            cbSearchImport.TabIndex = 40;
            // 
            // dgvImportItems
            // 
            dgvImportItems.AllowUserToAddRows = false;
            dgvImportItems.AllowUserToDeleteRows = false;
            dgvImportItems.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 28, 87);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvImportItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvImportItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvImportItems.Columns.AddRange(new DataGridViewColumn[] { ItemID, ImportID, Description, UnitPrice, Quantity, Amount });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 28, 87);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvImportItems.DefaultCellStyle = dataGridViewCellStyle2;
            dgvImportItems.Location = new Point(63, 74);
            dgvImportItems.Name = "dgvImportItems";
            dgvImportItems.ReadOnly = true;
            dgvImportItems.RowHeadersWidth = 51;
            dgvImportItems.RowTemplate.Height = 29;
            dgvImportItems.Size = new Size(1427, 238);
            dgvImportItems.TabIndex = 3;
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
            // ImportID
            // 
            ImportID.DataPropertyName = "ImportID";
            ImportID.HeaderText = "លេខសម្គាល់ការនាំចូល";
            ImportID.MinimumWidth = 6;
            ImportID.Name = "ImportID";
            ImportID.ReadOnly = true;
            ImportID.Visible = false;
            ImportID.Width = 125;
            // 
            // Description
            // 
            Description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Description.DataPropertyName = "Description";
            Description.HeaderText = "ពិព័ណ៌នារបស់សម្ភារៈ";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            Description.ReadOnly = true;
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
            // Quantity
            // 
            Quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Quantity.DataPropertyName = "ImportQty";
            Quantity.HeaderText = "បរិមាណ";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            Quantity.Width = 125;
            // 
            // Amount
            // 
            Amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Amount.DataPropertyName = "Amount";
            Amount.HeaderText = "តម្លៃ";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            // 
            // lblSearchImport
            // 
            lblSearchImport.AutoSize = true;
            lblSearchImport.Location = new Point(64, 17);
            lblSearchImport.Name = "lblSearchImport";
            lblSearchImport.Size = new Size(342, 43);
            lblSearchImport.TabIndex = 1;
            lblSearchImport.Text = "ស្វែងរក (លេខសម្គាល់ការនាំចូល):";
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
        private TextBox txtImportQty;
        private Button btnUpdateImportItem;
        private Button btnInsertImportItem;
        private Panel pnlLeftSide;
        private DataGridView dgvImportItems;
        private Label lblSearchImport;
        private Label lblSupplierName;
        private Label lblSupplierID;
        private TextBox txtTotalAmount;
        private Label lblTotalAmount;
        private Label lblStaffID;
        private DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn DescriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn importQtyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private ComboBox cbItemID;
        private TextBox txtAmount;
        private Label lblAmount;
        private ComboBox cbSearchImport;
        private DataGridViewTextBoxColumn ItemID;
        private DataGridViewTextBoxColumn ImportID;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn UnitPrice;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Amount;
    }
}