namespace Store_Rental_Management_Systems
{
    partial class FrmMaintenance
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
            gbMaintenanceDetails = new GroupBox();
            cbItemID = new ComboBox();
            txtAmount = new TextBox();
            lblAmount = new Label();
            btnUpdateMaintenanceItem = new Button();
            btnInsertMaintenanceItem = new Button();
            txtUnit = new TextBox();
            lblUnit = new Label();
            txtMaintenanceQty = new TextBox();
            lblItemDescription = new Label();
            txtItemDescription = new TextBox();
            lblMaintenanceQty = new Label();
            lblItemID = new Label();
            lblUnitPrice = new Label();
            txtCategory = new TextBox();
            txtUnitPrice = new TextBox();
            lblCategory = new Label();
            gbMaintenanceInformation = new GroupBox();
            txtStoreID = new TextBox();
            cbStaffID = new ComboBox();
            txtStaffName = new TextBox();
            lblStaffName = new Label();
            txtStaffPosition = new TextBox();
            lblStaffPosition = new Label();
            lblStaffID = new Label();
            txtOwedAmount = new TextBox();
            lblContractID = new Label();
            lblPaidAmount = new Label();
            lblOwedAmount = new Label();
            txtTotalAmount = new TextBox();
            lblTotalAmount = new Label();
            lblMaintenanceID = new Label();
            lblStoreID = new Label();
            cbContractID = new ComboBox();
            txtPaidAmount = new TextBox();
            dtpMaintenanceDate = new DateTimePicker();
            lblMaintenanceDate = new Label();
            txtMaintenanceID = new TextBox();
            pnlMaintenanceManipulation = new Panel();
            btnCloseFormMaintenance = new Button();
            btnNewMaintenance = new Button();
            btnUpdateMaintenance = new Button();
            btnInsertMaintenance = new Button();
            pnlLeftSide = new Panel();
            dgvMaintenanceItems = new DataGridView();
            ItemID = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            UnitPrice = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            lblSearchMaintenance = new Label();
            txtSearchMaintenance = new TextBox();
            pnlRightSide.SuspendLayout();
            gbMaintenanceDetails.SuspendLayout();
            gbMaintenanceInformation.SuspendLayout();
            pnlMaintenanceManipulation.SuspendLayout();
            pnlLeftSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMaintenanceItems).BeginInit();
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
            lblTitle.Text = "ព័ត៌មានការថែទាំ";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlRightSide
            // 
            pnlRightSide.Controls.Add(gbMaintenanceDetails);
            pnlRightSide.Controls.Add(gbMaintenanceInformation);
            pnlRightSide.Location = new Point(266, 184);
            pnlRightSide.Name = "pnlRightSide";
            pnlRightSide.Size = new Size(1534, 375);
            pnlRightSide.TabIndex = 4;
            // 
            // gbMaintenanceDetails
            // 
            gbMaintenanceDetails.Controls.Add(cbItemID);
            gbMaintenanceDetails.Controls.Add(txtAmount);
            gbMaintenanceDetails.Controls.Add(lblAmount);
            gbMaintenanceDetails.Controls.Add(btnUpdateMaintenanceItem);
            gbMaintenanceDetails.Controls.Add(btnInsertMaintenanceItem);
            gbMaintenanceDetails.Controls.Add(txtUnit);
            gbMaintenanceDetails.Controls.Add(lblUnit);
            gbMaintenanceDetails.Controls.Add(txtMaintenanceQty);
            gbMaintenanceDetails.Controls.Add(lblItemDescription);
            gbMaintenanceDetails.Controls.Add(txtItemDescription);
            gbMaintenanceDetails.Controls.Add(lblMaintenanceQty);
            gbMaintenanceDetails.Controls.Add(lblItemID);
            gbMaintenanceDetails.Controls.Add(lblUnitPrice);
            gbMaintenanceDetails.Controls.Add(txtCategory);
            gbMaintenanceDetails.Controls.Add(txtUnitPrice);
            gbMaintenanceDetails.Controls.Add(lblCategory);
            gbMaintenanceDetails.Font = new Font("!Khmer OS Siemreap", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            gbMaintenanceDetails.Location = new Point(63, 214);
            gbMaintenanceDetails.Name = "gbMaintenanceDetails";
            gbMaintenanceDetails.Size = new Size(1427, 154);
            gbMaintenanceDetails.TabIndex = 26;
            gbMaintenanceDetails.TabStop = false;
            gbMaintenanceDetails.Text = "សេចក្ដីលម្អិត";
            // 
            // cbItemID
            // 
            cbItemID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbItemID.FormattingEnabled = true;
            cbItemID.Items.AddRange(new object[] { "ភ្នំពេញ", "តាកែវ" });
            cbItemID.Location = new Point(199, 44);
            cbItemID.Name = "cbItemID";
            cbItemID.Size = new Size(161, 51);
            cbItemID.TabIndex = 50;
            // 
            // txtAmount
            // 
            txtAmount.Enabled = false;
            txtAmount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAmount.Location = new Point(888, 98);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(179, 51);
            txtAmount.TabIndex = 30;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAmount.Location = new Point(801, 101);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(66, 43);
            lblAmount.TabIndex = 29;
            lblAmount.Text = "តម្លៃ:";
            // 
            // btnUpdateMaintenanceItem
            // 
            btnUpdateMaintenanceItem.BackColor = Color.FromArgb(0, 28, 87);
            btnUpdateMaintenanceItem.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateMaintenanceItem.ForeColor = Color.White;
            btnUpdateMaintenanceItem.Location = new Point(1298, 93);
            btnUpdateMaintenanceItem.Name = "btnUpdateMaintenanceItem";
            btnUpdateMaintenanceItem.Size = new Size(100, 52);
            btnUpdateMaintenanceItem.TabIndex = 4;
            btnUpdateMaintenanceItem.Text = "កែប្រែ";
            btnUpdateMaintenanceItem.UseVisualStyleBackColor = false;
            // 
            // btnInsertMaintenanceItem
            // 
            btnInsertMaintenanceItem.BackColor = Color.FromArgb(0, 28, 87);
            btnInsertMaintenanceItem.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsertMaintenanceItem.ForeColor = Color.White;
            btnInsertMaintenanceItem.Location = new Point(1177, 93);
            btnInsertMaintenanceItem.Name = "btnInsertMaintenanceItem";
            btnInsertMaintenanceItem.Size = new Size(102, 52);
            btnInsertMaintenanceItem.TabIndex = 28;
            btnInsertMaintenanceItem.Text = "បញ្ចូល";
            btnInsertMaintenanceItem.UseVisualStyleBackColor = false;
            // 
            // txtUnit
            // 
            txtUnit.Enabled = false;
            txtUnit.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUnit.Location = new Point(888, 43);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(179, 51);
            txtUnit.TabIndex = 27;
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUnit.Location = new Point(801, 46);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(82, 43);
            lblUnit.TabIndex = 26;
            lblUnit.Text = "ឯកតា:";
            // 
            // txtMaintenanceQty
            // 
            txtMaintenanceQty.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaintenanceQty.Location = new Point(583, 101);
            txtMaintenanceQty.Name = "txtMaintenanceQty";
            txtMaintenanceQty.Size = new Size(198, 51);
            txtMaintenanceQty.TabIndex = 25;
            // 
            // lblItemDescription
            // 
            lblItemDescription.AutoSize = true;
            lblItemDescription.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblItemDescription.Location = new Point(387, 47);
            lblItemDescription.Name = "lblItemDescription";
            lblItemDescription.Size = new Size(225, 43);
            lblItemDescription.TabIndex = 18;
            lblItemDescription.Text = "ពិព័ណ៌នារបស់សម្ភារៈ:";
            // 
            // txtItemDescription
            // 
            txtItemDescription.Enabled = false;
            txtItemDescription.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtItemDescription.Location = new Point(583, 44);
            txtItemDescription.Name = "txtItemDescription";
            txtItemDescription.Size = new Size(198, 51);
            txtItemDescription.TabIndex = 19;
            // 
            // lblMaintenanceQty
            // 
            lblMaintenanceQty.AutoSize = true;
            lblMaintenanceQty.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMaintenanceQty.Location = new Point(387, 101);
            lblMaintenanceQty.Name = "lblMaintenanceQty";
            lblMaintenanceQty.Size = new Size(193, 43);
            lblMaintenanceQty.TabIndex = 24;
            lblMaintenanceQty.Text = "បរិមាណប្រើប្រាស់:";
            // 
            // lblItemID
            // 
            lblItemID.AutoSize = true;
            lblItemID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblItemID.Location = new Point(18, 46);
            lblItemID.Name = "lblItemID";
            lblItemID.Size = new Size(207, 43);
            lblItemID.TabIndex = 16;
            lblItemID.Text = "លេខសម្គាល់សម្ភារៈ:";
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUnitPrice.Location = new Point(18, 101);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(194, 43);
            lblUnitPrice.TabIndex = 20;
            lblUnitPrice.Text = "តម្លៃក្នុងមួយឯកតា:";
            // 
            // txtCategory
            // 
            txtCategory.Enabled = false;
            txtCategory.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCategory.Location = new Point(1177, 43);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(221, 51);
            txtCategory.TabIndex = 23;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Enabled = false;
            txtUnitPrice.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUnitPrice.Location = new Point(199, 98);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(163, 51);
            txtUnitPrice.TabIndex = 21;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCategory.Location = new Point(1091, 47);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(90, 43);
            lblCategory.TabIndex = 22;
            lblCategory.Text = "ប្រភេទ:";
            // 
            // gbMaintenanceInformation
            // 
            gbMaintenanceInformation.Controls.Add(txtStoreID);
            gbMaintenanceInformation.Controls.Add(cbStaffID);
            gbMaintenanceInformation.Controls.Add(txtStaffName);
            gbMaintenanceInformation.Controls.Add(lblStaffName);
            gbMaintenanceInformation.Controls.Add(txtStaffPosition);
            gbMaintenanceInformation.Controls.Add(lblStaffPosition);
            gbMaintenanceInformation.Controls.Add(lblStaffID);
            gbMaintenanceInformation.Controls.Add(txtOwedAmount);
            gbMaintenanceInformation.Controls.Add(lblContractID);
            gbMaintenanceInformation.Controls.Add(lblPaidAmount);
            gbMaintenanceInformation.Controls.Add(lblOwedAmount);
            gbMaintenanceInformation.Controls.Add(txtTotalAmount);
            gbMaintenanceInformation.Controls.Add(lblTotalAmount);
            gbMaintenanceInformation.Controls.Add(lblMaintenanceID);
            gbMaintenanceInformation.Controls.Add(lblStoreID);
            gbMaintenanceInformation.Controls.Add(cbContractID);
            gbMaintenanceInformation.Controls.Add(txtPaidAmount);
            gbMaintenanceInformation.Controls.Add(dtpMaintenanceDate);
            gbMaintenanceInformation.Controls.Add(lblMaintenanceDate);
            gbMaintenanceInformation.Controls.Add(txtMaintenanceID);
            gbMaintenanceInformation.Font = new Font("!Khmer OS Siemreap", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            gbMaintenanceInformation.Location = new Point(63, 12);
            gbMaintenanceInformation.Name = "gbMaintenanceInformation";
            gbMaintenanceInformation.Size = new Size(1427, 194);
            gbMaintenanceInformation.TabIndex = 25;
            gbMaintenanceInformation.TabStop = false;
            gbMaintenanceInformation.Text = "ព័ត៌មានការថែទាំ";
            // 
            // txtStoreID
            // 
            txtStoreID.Enabled = false;
            txtStoreID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStoreID.Location = new Point(199, 140);
            txtStoreID.Name = "txtStoreID";
            txtStoreID.Size = new Size(161, 51);
            txtStoreID.TabIndex = 49;
            // 
            // cbStaffID
            // 
            cbStaffID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbStaffID.FormattingEnabled = true;
            cbStaffID.Items.AddRange(new object[] { "ភ្នំពេញ", "តាកែវ" });
            cbStaffID.Location = new Point(576, 140);
            cbStaffID.Name = "cbStaffID";
            cbStaffID.Size = new Size(180, 51);
            cbStaffID.TabIndex = 48;
            // 
            // txtStaffName
            // 
            txtStaffName.Enabled = false;
            txtStaffName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffName.Location = new Point(937, 140);
            txtStaffName.Name = "txtStaffName";
            txtStaffName.Size = new Size(161, 51);
            txtStaffName.TabIndex = 47;
            // 
            // lblStaffName
            // 
            lblStaffName.AutoSize = true;
            lblStaffName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffName.Location = new Point(785, 143);
            lblStaffName.Name = "lblStaffName";
            lblStaffName.Size = new Size(155, 43);
            lblStaffName.TabIndex = 46;
            lblStaffName.Text = "ឈ្មោះបុគ្គលិក:";
            // 
            // txtStaffPosition
            // 
            txtStaffPosition.Enabled = false;
            txtStaffPosition.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffPosition.Location = new Point(1241, 140);
            txtStaffPosition.Name = "txtStaffPosition";
            txtStaffPosition.Size = new Size(157, 51);
            txtStaffPosition.TabIndex = 45;
            // 
            // lblStaffPosition
            // 
            lblStaffPosition.AutoSize = true;
            lblStaffPosition.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffPosition.Location = new Point(1104, 143);
            lblStaffPosition.Name = "lblStaffPosition";
            lblStaffPosition.Size = new Size(153, 43);
            lblStaffPosition.TabIndex = 44;
            lblStaffPosition.Text = "តួនាទីបុគ្គលិក:";
            // 
            // lblStaffID
            // 
            lblStaffID.AutoSize = true;
            lblStaffID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffID.Location = new Point(387, 143);
            lblStaffID.Name = "lblStaffID";
            lblStaffID.Size = new Size(214, 43);
            lblStaffID.TabIndex = 42;
            lblStaffID.Text = "លេខសម្គាល់បុគ្គលិក:";
            // 
            // txtOwedAmount
            // 
            txtOwedAmount.Enabled = false;
            txtOwedAmount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtOwedAmount.Location = new Point(681, 85);
            txtOwedAmount.Name = "txtOwedAmount";
            txtOwedAmount.Size = new Size(189, 51);
            txtOwedAmount.TabIndex = 40;
            // 
            // lblContractID
            // 
            lblContractID.AutoSize = true;
            lblContractID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblContractID.Location = new Point(905, 88);
            lblContractID.Name = "lblContractID";
            lblContractID.Size = new Size(229, 43);
            lblContractID.TabIndex = 39;
            lblContractID.Text = "លេខសម្គាល់កិច្ចសន្យា:";
            // 
            // lblPaidAmount
            // 
            lblPaidAmount.AutoSize = true;
            lblPaidAmount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPaidAmount.Location = new Point(18, 88);
            lblPaidAmount.Name = "lblPaidAmount";
            lblPaidAmount.Size = new Size(226, 43);
            lblPaidAmount.TabIndex = 38;
            lblPaidAmount.Text = "ចំនួនទឹកប្រាក់បានបង់:";
            // 
            // lblOwedAmount
            // 
            lblOwedAmount.AutoSize = true;
            lblOwedAmount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblOwedAmount.Location = new Point(482, 88);
            lblOwedAmount.Name = "lblOwedAmount";
            lblOwedAmount.Size = new Size(210, 43);
            lblOwedAmount.TabIndex = 37;
            lblOwedAmount.Text = "ចំនួនទឹកប្រាក់ជំពាក់:";
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotalAmount.Location = new Point(1109, 33);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.Size = new Size(289, 51);
            txtTotalAmount.TabIndex = 36;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalAmount.Location = new Point(905, 41);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(201, 43);
            lblTotalAmount.TabIndex = 35;
            lblTotalAmount.Text = "ចំនួនទឹកប្រាក់សរុប:";
            // 
            // lblMaintenanceID
            // 
            lblMaintenanceID.AutoSize = true;
            lblMaintenanceID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMaintenanceID.Location = new Point(18, 41);
            lblMaintenanceID.Name = "lblMaintenanceID";
            lblMaintenanceID.Size = new Size(223, 43);
            lblMaintenanceID.TabIndex = 34;
            lblMaintenanceID.Text = "លេខសម្គាល់ការថែទាំ:";
            // 
            // lblStoreID
            // 
            lblStoreID.AutoSize = true;
            lblStoreID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStoreID.Location = new Point(18, 143);
            lblStoreID.Name = "lblStoreID";
            lblStoreID.Size = new Size(175, 43);
            lblStoreID.TabIndex = 30;
            lblStoreID.Text = "លេខសម្គាល់តូប:";
            // 
            // cbContractID
            // 
            cbContractID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbContractID.FormattingEnabled = true;
            cbContractID.Items.AddRange(new object[] { "ភ្នំពេញ", "តាកែវ" });
            cbContractID.Location = new Point(1109, 85);
            cbContractID.Name = "cbContractID";
            cbContractID.Size = new Size(289, 51);
            cbContractID.TabIndex = 29;
            // 
            // txtPaidAmount
            // 
            txtPaidAmount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPaidAmount.Location = new Point(227, 85);
            txtPaidAmount.Name = "txtPaidAmount";
            txtPaidAmount.Size = new Size(217, 51);
            txtPaidAmount.TabIndex = 28;
            // 
            // dtpMaintenanceDate
            // 
            dtpMaintenanceDate.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpMaintenanceDate.Format = DateTimePickerFormat.Short;
            dtpMaintenanceDate.Location = new Point(681, 33);
            dtpMaintenanceDate.Name = "dtpMaintenanceDate";
            dtpMaintenanceDate.Size = new Size(189, 51);
            dtpMaintenanceDate.TabIndex = 20;
            // 
            // lblMaintenanceDate
            // 
            lblMaintenanceDate.AutoSize = true;
            lblMaintenanceDate.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMaintenanceDate.Location = new Point(482, 41);
            lblMaintenanceDate.Name = "lblMaintenanceDate";
            lblMaintenanceDate.Size = new Size(185, 43);
            lblMaintenanceDate.TabIndex = 19;
            lblMaintenanceDate.Text = "កាលបរិច្ឆេទថែទាំ:";
            // 
            // txtMaintenanceID
            // 
            txtMaintenanceID.Enabled = false;
            txtMaintenanceID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaintenanceID.Location = new Point(227, 33);
            txtMaintenanceID.Name = "txtMaintenanceID";
            txtMaintenanceID.Size = new Size(217, 51);
            txtMaintenanceID.TabIndex = 3;
            // 
            // pnlMaintenanceManipulation
            // 
            pnlMaintenanceManipulation.Controls.Add(btnCloseFormMaintenance);
            pnlMaintenanceManipulation.Controls.Add(btnNewMaintenance);
            pnlMaintenanceManipulation.Controls.Add(btnUpdateMaintenance);
            pnlMaintenanceManipulation.Controls.Add(btnInsertMaintenance);
            pnlMaintenanceManipulation.Location = new Point(329, 563);
            pnlMaintenanceManipulation.Name = "pnlMaintenanceManipulation";
            pnlMaintenanceManipulation.Size = new Size(1427, 62);
            pnlMaintenanceManipulation.TabIndex = 5;
            // 
            // btnCloseFormMaintenance
            // 
            btnCloseFormMaintenance.BackColor = Color.FromArgb(0, 28, 87);
            btnCloseFormMaintenance.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCloseFormMaintenance.ForeColor = Color.White;
            btnCloseFormMaintenance.Location = new Point(1231, 7);
            btnCloseFormMaintenance.Name = "btnCloseFormMaintenance";
            btnCloseFormMaintenance.Size = new Size(134, 52);
            btnCloseFormMaintenance.TabIndex = 3;
            btnCloseFormMaintenance.Text = "បិទ";
            btnCloseFormMaintenance.UseVisualStyleBackColor = false;
            // 
            // btnNewMaintenance
            // 
            btnNewMaintenance.BackColor = Color.FromArgb(0, 28, 87);
            btnNewMaintenance.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNewMaintenance.ForeColor = Color.White;
            btnNewMaintenance.Location = new Point(843, 7);
            btnNewMaintenance.Name = "btnNewMaintenance";
            btnNewMaintenance.Size = new Size(152, 52);
            btnNewMaintenance.TabIndex = 2;
            btnNewMaintenance.Text = "បង្កើតថ្មី";
            btnNewMaintenance.UseVisualStyleBackColor = false;
            // 
            // btnUpdateMaintenance
            // 
            btnUpdateMaintenance.BackColor = Color.FromArgb(0, 28, 87);
            btnUpdateMaintenance.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateMaintenance.ForeColor = Color.White;
            btnUpdateMaintenance.Location = new Point(455, 7);
            btnUpdateMaintenance.Name = "btnUpdateMaintenance";
            btnUpdateMaintenance.Size = new Size(152, 52);
            btnUpdateMaintenance.TabIndex = 1;
            btnUpdateMaintenance.Text = "កែប្រែ";
            btnUpdateMaintenance.UseVisualStyleBackColor = false;
            // 
            // btnInsertMaintenance
            // 
            btnInsertMaintenance.BackColor = Color.FromArgb(0, 28, 87);
            btnInsertMaintenance.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsertMaintenance.ForeColor = Color.White;
            btnInsertMaintenance.Location = new Point(67, 7);
            btnInsertMaintenance.Name = "btnInsertMaintenance";
            btnInsertMaintenance.Size = new Size(152, 52);
            btnInsertMaintenance.TabIndex = 0;
            btnInsertMaintenance.Text = "បញ្ចូល";
            btnInsertMaintenance.UseVisualStyleBackColor = false;
            // 
            // pnlLeftSide
            // 
            pnlLeftSide.Controls.Add(dgvMaintenanceItems);
            pnlLeftSide.Controls.Add(lblSearchMaintenance);
            pnlLeftSide.Controls.Add(txtSearchMaintenance);
            pnlLeftSide.Location = new Point(266, 643);
            pnlLeftSide.Name = "pnlLeftSide";
            pnlLeftSide.Size = new Size(1800, 354);
            pnlLeftSide.TabIndex = 6;
            // 
            // dgvMaintenanceItems
            // 
            dgvMaintenanceItems.AllowUserToAddRows = false;
            dgvMaintenanceItems.AllowUserToDeleteRows = false;
            dgvMaintenanceItems.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 28, 87);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMaintenanceItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMaintenanceItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaintenanceItems.Columns.AddRange(new DataGridViewColumn[] { ItemID, Description, UnitPrice, Quantity, Amount });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 28, 87);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvMaintenanceItems.DefaultCellStyle = dataGridViewCellStyle2;
            dgvMaintenanceItems.Location = new Point(63, 74);
            dgvMaintenanceItems.Name = "dgvMaintenanceItems";
            dgvMaintenanceItems.ReadOnly = true;
            dgvMaintenanceItems.RowHeadersWidth = 51;
            dgvMaintenanceItems.RowTemplate.Height = 29;
            dgvMaintenanceItems.Size = new Size(1427, 238);
            dgvMaintenanceItems.TabIndex = 3;
            // 
            // ItemID
            // 
            ItemID.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ItemID.HeaderText = "លេខសម្គាល់សម្ភារៈ";
            ItemID.MinimumWidth = 6;
            ItemID.Name = "ItemID";
            ItemID.ReadOnly = true;
            ItemID.Width = 236;
            // 
            // Description
            // 
            Description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Description.HeaderText = "ពិព័ណ៌នារបស់សម្ភារៈ";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            Description.ReadOnly = true;
            // 
            // UnitPrice
            // 
            UnitPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            UnitPrice.HeaderText = "តម្លៃក្នុងមួយឯកតា";
            UnitPrice.MinimumWidth = 6;
            UnitPrice.Name = "UnitPrice";
            UnitPrice.ReadOnly = true;
            UnitPrice.Width = 153;
            // 
            // Quantity
            // 
            Quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Quantity.HeaderText = "បរិមាណប្រើប្រាស់";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            Quantity.Width = 153;
            // 
            // Amount
            // 
            Amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Amount.HeaderText = "តម្លៃ";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            // 
            // lblSearchMaintenance
            // 
            lblSearchMaintenance.AutoSize = true;
            lblSearchMaintenance.Location = new Point(64, 17);
            lblSearchMaintenance.Name = "lblSearchMaintenance";
            lblSearchMaintenance.Size = new Size(327, 43);
            lblSearchMaintenance.TabIndex = 1;
            lblSearchMaintenance.Text = "ស្វែងរក (លេខសម្គាល់ការថែទាំ):";
            // 
            // txtSearchMaintenance
            // 
            txtSearchMaintenance.Location = new Point(372, 11);
            txtSearchMaintenance.Name = "txtSearchMaintenance";
            txtSearchMaintenance.Size = new Size(470, 51);
            txtSearchMaintenance.TabIndex = 2;
            // 
            // FrmMaintenance
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1800, 1000);
            ControlBox = true;
            Controls.Add(pnlLeftSide);
            Controls.Add(pnlMaintenanceManipulation);
            Controls.Add(pnlRightSide);
            Controls.Add(lblTitle);
            Name = "FrmMaintenance";
            Text = "ព័ត៌មានបុគ្គលិក";
            Controls.SetChildIndex(lblTitle, 0);
            Controls.SetChildIndex(pnlRightSide, 0);
            Controls.SetChildIndex(pnlMaintenanceManipulation, 0);
            Controls.SetChildIndex(pnlLeftSide, 0);
            pnlRightSide.ResumeLayout(false);
            gbMaintenanceDetails.ResumeLayout(false);
            gbMaintenanceDetails.PerformLayout();
            gbMaintenanceInformation.ResumeLayout(false);
            gbMaintenanceInformation.PerformLayout();
            pnlMaintenanceManipulation.ResumeLayout(false);
            pnlLeftSide.ResumeLayout(false);
            pnlLeftSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMaintenanceItems).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Panel pnlRightSide;
        private TextBox txtMaintenanceID;
        private TextBox txtItemDescription;
        private Label lblItemDescription;
        private Label lblItemID;
        private Label lblMaintenanceQty;
        private Label lblCategory;
        private TextBox txtUnitPrice;
        private Label lblUnitPrice;
        private TextBox txtCategory;
        private GroupBox gbMaintenanceInformation;
        private GroupBox gbImportDetails;
        private DateTimePicker dtpMaintenanceDate;
        private Label lblMaintenanceDate;
        private Panel pnlMaintenanceManipulation;
        private Button btnInsertMaintenance;
        private Button btnCloseFormMaintenance;
        private Button btnNewMaintenance;
        private Button btnUpdateMaintenance;
        private TextBox txtStaffName;
        private Label lblStaffPosition;
        private TextBox txtStaffPosition;
        private Label lblMaintenanceID;
        private TextBox txtUnit;
        private TextBox txtMaintenanceQty;
        private Button btnUpdateMaintenanceItem;
        private Button btnInsertMaintenanceItem;
        private Panel pnlLeftSide;
        private DataGridView dgvMaintenanceItems;
        private Label lblSearchMaintenance;
        private TextBox txtSearchMaintenance;
        private Label lblPaidAmount;
        private Label lblOwedAmount;
        private TextBox txtTotalAmount;
        private Label lblTotalAmount;
        private Label lblContractID;
        private TextBox txtOwedAmount;
        private GroupBox gbMaintenanceDetails;
        private TextBox txtPaidAmount;
        private Label lblStoreID;
        private ComboBox cbContractID;
        private Label lblStaffID;
        private Label lblStaffName;
        private TextBox txtAmount;
        private Label lblAmount;
        private ComboBox cbStaffID;
        private DataGridViewTextBoxColumn ItemID;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn UnitPrice;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Amount;
        private TextBox txtStoreID;
        private ComboBox cbItemID;
        private Label lblUnit;
    }
}