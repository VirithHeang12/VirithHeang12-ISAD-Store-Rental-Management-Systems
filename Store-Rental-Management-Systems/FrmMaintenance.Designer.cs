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
            components = new System.ComponentModel.Container();
            lblTitle = new Label();
            pnlRightSide = new Panel();
            gbMaintenanceDetails = new GroupBox();
            btnUpdateMaintenanceItem = new Button();
            btnInsertMaintenanceItem = new Button();
            txtUnit = new TextBox();
            lblUnit = new Label();
            txtMaintenanceQty = new TextBox();
            lblItemDescription = new Label();
            txtItemDescription = new TextBox();
            txtItemID = new TextBox();
            lblMaintenanceQty = new Label();
            lblItemID = new Label();
            lblUnitPrice = new Label();
            txtCategory = new TextBox();
            txtUnitPrice = new TextBox();
            lblCategory = new Label();
            gbMaintenanceInformation = new GroupBox();
            txtStaffName = new TextBox();
            lblStaffName = new Label();
            txtStaffPosition = new TextBox();
            lblStaffPosition = new Label();
            textBox1 = new TextBox();
            lblStaffID = new Label();
            cbStoreID = new ComboBox();
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
            itemBindingSource = new BindingSource(components);
            lblSearchMaintenance = new Label();
            txtSearchMaintenance = new TextBox();
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
            lblAmount = new Label();
            txtAmount = new TextBox();
            pnlRightSide.SuspendLayout();
            gbMaintenanceDetails.SuspendLayout();
            gbMaintenanceInformation.SuspendLayout();
            pnlMaintenanceManipulation.SuspendLayout();
            pnlLeftSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMaintenanceItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemBindingSource).BeginInit();
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
            gbMaintenanceDetails.Controls.Add(txtAmount);
            gbMaintenanceDetails.Controls.Add(lblAmount);
            gbMaintenanceDetails.Controls.Add(btnUpdateMaintenanceItem);
            gbMaintenanceDetails.Controls.Add(btnInsertMaintenanceItem);
            gbMaintenanceDetails.Controls.Add(txtUnit);
            gbMaintenanceDetails.Controls.Add(lblUnit);
            gbMaintenanceDetails.Controls.Add(txtMaintenanceQty);
            gbMaintenanceDetails.Controls.Add(lblItemDescription);
            gbMaintenanceDetails.Controls.Add(txtItemDescription);
            gbMaintenanceDetails.Controls.Add(txtItemID);
            gbMaintenanceDetails.Controls.Add(lblMaintenanceQty);
            gbMaintenanceDetails.Controls.Add(lblItemID);
            gbMaintenanceDetails.Controls.Add(lblUnitPrice);
            gbMaintenanceDetails.Controls.Add(txtCategory);
            gbMaintenanceDetails.Controls.Add(txtUnitPrice);
            gbMaintenanceDetails.Controls.Add(lblCategory);
            gbMaintenanceDetails.Font = new Font("!Khmer OS Siemreap", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            gbMaintenanceDetails.Location = new Point(63, 214);
            gbMaintenanceDetails.Name = "gbMaintenanceDetails";
            gbMaintenanceDetails.Size = new Size(1427, 154);
            gbMaintenanceDetails.TabIndex = 26;
            gbMaintenanceDetails.TabStop = false;
            gbMaintenanceDetails.Text = "សេចក្ដីលម្អិត";
            // 
            // btnUpdateMaintenanceItem
            // 
            btnUpdateMaintenanceItem.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdateMaintenanceItem.Location = new Point(1298, 93);
            btnUpdateMaintenanceItem.Name = "btnUpdateMaintenanceItem";
            btnUpdateMaintenanceItem.Size = new Size(100, 52);
            btnUpdateMaintenanceItem.TabIndex = 4;
            btnUpdateMaintenanceItem.Text = "កែប្រែ";
            btnUpdateMaintenanceItem.UseVisualStyleBackColor = true;
            // 
            // btnInsertMaintenanceItem
            // 
            btnInsertMaintenanceItem.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnInsertMaintenanceItem.Location = new Point(1177, 93);
            btnInsertMaintenanceItem.Name = "btnInsertMaintenanceItem";
            btnInsertMaintenanceItem.Size = new Size(102, 52);
            btnInsertMaintenanceItem.TabIndex = 28;
            btnInsertMaintenanceItem.Text = "បញ្ចូល";
            btnInsertMaintenanceItem.UseVisualStyleBackColor = true;
            // 
            // txtUnit
            // 
            txtUnit.Enabled = false;
            txtUnit.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUnit.Location = new Point(888, 43);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(179, 44);
            txtUnit.TabIndex = 27;
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUnit.Location = new Point(801, 46);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(69, 36);
            lblUnit.TabIndex = 26;
            lblUnit.Text = "ឯកតា:";
            // 
            // txtMaintenanceQty
            // 
            txtMaintenanceQty.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaintenanceQty.Location = new Point(583, 101);
            txtMaintenanceQty.Name = "txtMaintenanceQty";
            txtMaintenanceQty.Size = new Size(196, 44);
            txtMaintenanceQty.TabIndex = 25;
            // 
            // lblItemDescription
            // 
            lblItemDescription.AutoSize = true;
            lblItemDescription.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblItemDescription.Location = new Point(387, 47);
            lblItemDescription.Name = "lblItemDescription";
            lblItemDescription.Size = new Size(190, 36);
            lblItemDescription.TabIndex = 18;
            lblItemDescription.Text = "ពិព័ណ៌នារបស់សម្ភារៈ:";
            // 
            // txtItemDescription
            // 
            txtItemDescription.Enabled = false;
            txtItemDescription.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtItemDescription.Location = new Point(583, 44);
            txtItemDescription.Name = "txtItemDescription";
            txtItemDescription.Size = new Size(198, 44);
            txtItemDescription.TabIndex = 19;
            // 
            // txtItemID
            // 
            txtItemID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtItemID.Location = new Point(199, 38);
            txtItemID.Name = "txtItemID";
            txtItemID.Size = new Size(151, 44);
            txtItemID.TabIndex = 17;
            // 
            // lblMaintenanceQty
            // 
            lblMaintenanceQty.AutoSize = true;
            lblMaintenanceQty.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMaintenanceQty.Location = new Point(387, 101);
            lblMaintenanceQty.Name = "lblMaintenanceQty";
            lblMaintenanceQty.Size = new Size(160, 36);
            lblMaintenanceQty.TabIndex = 24;
            lblMaintenanceQty.Text = "បរិមាណប្រើប្រាស់:";
            // 
            // lblItemID
            // 
            lblItemID.AutoSize = true;
            lblItemID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblItemID.Location = new Point(18, 46);
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
            txtCategory.Location = new Point(1177, 43);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(221, 44);
            txtCategory.TabIndex = 23;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Enabled = false;
            txtUnitPrice.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUnitPrice.Location = new Point(199, 98);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(143, 44);
            txtUnitPrice.TabIndex = 21;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCategory.Location = new Point(1091, 47);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(75, 36);
            lblCategory.TabIndex = 22;
            lblCategory.Text = "ប្រភេទ:";
            // 
            // gbMaintenanceInformation
            // 
            gbMaintenanceInformation.Controls.Add(txtStaffName);
            gbMaintenanceInformation.Controls.Add(lblStaffName);
            gbMaintenanceInformation.Controls.Add(txtStaffPosition);
            gbMaintenanceInformation.Controls.Add(lblStaffPosition);
            gbMaintenanceInformation.Controls.Add(textBox1);
            gbMaintenanceInformation.Controls.Add(lblStaffID);
            gbMaintenanceInformation.Controls.Add(cbStoreID);
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
            gbMaintenanceInformation.Font = new Font("!Khmer OS Siemreap", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            gbMaintenanceInformation.Location = new Point(63, 19);
            gbMaintenanceInformation.Name = "gbMaintenanceInformation";
            gbMaintenanceInformation.Size = new Size(1427, 194);
            gbMaintenanceInformation.TabIndex = 25;
            gbMaintenanceInformation.TabStop = false;
            gbMaintenanceInformation.Text = "ព័ត៌មានការថែទាំ";
            // 
            // txtStaffName
            // 
            txtStaffName.Enabled = false;
            txtStaffName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffName.Location = new Point(937, 140);
            txtStaffName.Name = "txtStaffName";
            txtStaffName.Size = new Size(161, 44);
            txtStaffName.TabIndex = 47;
            // 
            // lblStaffName
            // 
            lblStaffName.AutoSize = true;
            lblStaffName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffName.Location = new Point(739, 143);
            lblStaffName.Name = "lblStaffName";
            lblStaffName.Size = new Size(192, 36);
            lblStaffName.TabIndex = 46;
            lblStaffName.Text = "ឈ្មោះបុគ្គលិកបុគ្គលិក:";
            // 
            // txtStaffPosition
            // 
            txtStaffPosition.Enabled = false;
            txtStaffPosition.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffPosition.Location = new Point(1241, 140);
            txtStaffPosition.Name = "txtStaffPosition";
            txtStaffPosition.Size = new Size(157, 44);
            txtStaffPosition.TabIndex = 45;
            // 
            // lblStaffPosition
            // 
            lblStaffPosition.AutoSize = true;
            lblStaffPosition.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffPosition.Location = new Point(1104, 143);
            lblStaffPosition.Name = "lblStaffPosition";
            lblStaffPosition.Size = new Size(131, 36);
            lblStaffPosition.TabIndex = 44;
            lblStaffPosition.Text = "តួនាទីបុគ្គលិក:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(576, 140);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(157, 44);
            textBox1.TabIndex = 43;
            // 
            // lblStaffID
            // 
            lblStaffID.AutoSize = true;
            lblStaffID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffID.Location = new Point(387, 143);
            lblStaffID.Name = "lblStaffID";
            lblStaffID.Size = new Size(183, 36);
            lblStaffID.TabIndex = 42;
            lblStaffID.Text = "លេខសម្គាល់បុគ្គលិក:";
            // 
            // cbStoreID
            // 
            cbStoreID.Enabled = false;
            cbStoreID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbStoreID.FormattingEnabled = true;
            cbStoreID.Items.AddRange(new object[] { "ភ្នំពេញ", "តាកែវ" });
            cbStoreID.Location = new Point(173, 140);
            cbStoreID.Name = "cbStoreID";
            cbStoreID.Size = new Size(189, 44);
            cbStoreID.TabIndex = 41;
            // 
            // txtOwedAmount
            // 
            txtOwedAmount.Enabled = false;
            txtOwedAmount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtOwedAmount.Location = new Point(681, 85);
            txtOwedAmount.Name = "txtOwedAmount";
            txtOwedAmount.Size = new Size(189, 44);
            txtOwedAmount.TabIndex = 40;
            // 
            // lblContractID
            // 
            lblContractID.AutoSize = true;
            lblContractID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblContractID.Location = new Point(905, 88);
            lblContractID.Name = "lblContractID";
            lblContractID.Size = new Size(196, 36);
            lblContractID.TabIndex = 39;
            lblContractID.Text = "លេខសម្គាល់កិច្ចសន្យា:";
            // 
            // lblPaidAmount
            // 
            lblPaidAmount.AutoSize = true;
            lblPaidAmount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPaidAmount.Location = new Point(18, 88);
            lblPaidAmount.Name = "lblPaidAmount";
            lblPaidAmount.Size = new Size(193, 36);
            lblPaidAmount.TabIndex = 38;
            lblPaidAmount.Text = "ចំនួនទឹកប្រាក់បានបង់:";
            // 
            // lblOwedAmount
            // 
            lblOwedAmount.AutoSize = true;
            lblOwedAmount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblOwedAmount.Location = new Point(482, 88);
            lblOwedAmount.Name = "lblOwedAmount";
            lblOwedAmount.Size = new Size(179, 36);
            lblOwedAmount.TabIndex = 37;
            lblOwedAmount.Text = "ចំនួនទឹកប្រាក់ជំពាក់:";
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotalAmount.Location = new Point(1109, 33);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.Size = new Size(289, 44);
            txtTotalAmount.TabIndex = 36;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalAmount.Location = new Point(905, 41);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(171, 36);
            lblTotalAmount.TabIndex = 35;
            lblTotalAmount.Text = "ចំនួនទឹកប្រាក់សរុប:";
            // 
            // lblMaintenanceID
            // 
            lblMaintenanceID.AutoSize = true;
            lblMaintenanceID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMaintenanceID.Location = new Point(18, 41);
            lblMaintenanceID.Name = "lblMaintenanceID";
            lblMaintenanceID.Size = new Size(187, 36);
            lblMaintenanceID.TabIndex = 34;
            lblMaintenanceID.Text = "លេខសម្គាល់ការថែទាំ:";
            // 
            // lblStoreID
            // 
            lblStoreID.AutoSize = true;
            lblStoreID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStoreID.Location = new Point(18, 143);
            lblStoreID.Name = "lblStoreID";
            lblStoreID.Size = new Size(149, 36);
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
            cbContractID.Size = new Size(289, 44);
            cbContractID.TabIndex = 29;
            // 
            // txtPaidAmount
            // 
            txtPaidAmount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPaidAmount.Location = new Point(227, 85);
            txtPaidAmount.Name = "txtPaidAmount";
            txtPaidAmount.Size = new Size(217, 44);
            txtPaidAmount.TabIndex = 28;
            // 
            // dtpMaintenanceDate
            // 
            dtpMaintenanceDate.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpMaintenanceDate.Format = DateTimePickerFormat.Short;
            dtpMaintenanceDate.Location = new Point(681, 33);
            dtpMaintenanceDate.Name = "dtpMaintenanceDate";
            dtpMaintenanceDate.Size = new Size(189, 44);
            dtpMaintenanceDate.TabIndex = 20;
            // 
            // lblMaintenanceDate
            // 
            lblMaintenanceDate.AutoSize = true;
            lblMaintenanceDate.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMaintenanceDate.Location = new Point(482, 41);
            lblMaintenanceDate.Name = "lblMaintenanceDate";
            lblMaintenanceDate.Size = new Size(155, 36);
            lblMaintenanceDate.TabIndex = 19;
            lblMaintenanceDate.Text = "កាលបរិច្ឆេទថែទាំ:";
            // 
            // txtMaintenanceID
            // 
            txtMaintenanceID.Enabled = false;
            txtMaintenanceID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaintenanceID.Location = new Point(227, 33);
            txtMaintenanceID.Name = "txtMaintenanceID";
            txtMaintenanceID.Size = new Size(217, 44);
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
            btnCloseFormMaintenance.Location = new Point(1231, 7);
            btnCloseFormMaintenance.Name = "btnCloseFormMaintenance";
            btnCloseFormMaintenance.Size = new Size(134, 52);
            btnCloseFormMaintenance.TabIndex = 3;
            btnCloseFormMaintenance.Text = "បិទ";
            btnCloseFormMaintenance.UseVisualStyleBackColor = true;
            // 
            // btnNewMaintenance
            // 
            btnNewMaintenance.Location = new Point(871, 7);
            btnNewMaintenance.Name = "btnNewMaintenance";
            btnNewMaintenance.Size = new Size(152, 52);
            btnNewMaintenance.TabIndex = 2;
            btnNewMaintenance.Text = "បង្កើតថ្មី";
            btnNewMaintenance.UseVisualStyleBackColor = true;
            // 
            // btnUpdateMaintenance
            // 
            btnUpdateMaintenance.Location = new Point(452, 7);
            btnUpdateMaintenance.Name = "btnUpdateMaintenance";
            btnUpdateMaintenance.Size = new Size(152, 52);
            btnUpdateMaintenance.TabIndex = 1;
            btnUpdateMaintenance.Text = "កែប្រែ";
            btnUpdateMaintenance.UseVisualStyleBackColor = true;
            // 
            // btnInsertMaintenance
            // 
            btnInsertMaintenance.Location = new Point(67, 7);
            btnInsertMaintenance.Name = "btnInsertMaintenance";
            btnInsertMaintenance.Size = new Size(152, 52);
            btnInsertMaintenance.TabIndex = 0;
            btnInsertMaintenance.Text = "បញ្ចូល";
            btnInsertMaintenance.UseVisualStyleBackColor = true;
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
            dgvMaintenanceItems.AutoGenerateColumns = false;
            dgvMaintenanceItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaintenanceItems.DataSource = itemBindingSource;
            dgvMaintenanceItems.Location = new Point(63, 74);
            dgvMaintenanceItems.Name = "dgvMaintenanceItems";
            dgvMaintenanceItems.ReadOnly = true;
            dgvMaintenanceItems.RowHeadersWidth = 51;
            dgvMaintenanceItems.RowTemplate.Height = 29;
            dgvMaintenanceItems.Size = new Size(1427, 238);
            dgvMaintenanceItems.TabIndex = 3;
            // 
            // lblSearchMaintenance
            // 
            lblSearchMaintenance.AutoSize = true;
            lblSearchMaintenance.Location = new Point(64, 17);
            lblSearchMaintenance.Name = "lblSearchMaintenance";
            lblSearchMaintenance.Size = new Size(81, 36);
            lblSearchMaintenance.TabIndex = 1;
            lblSearchMaintenance.Text = "ស្វែងរក:";
            // 
            // txtSearchMaintenance
            // 
            txtSearchMaintenance.Location = new Point(169, 11);
            txtSearchMaintenance.Name = "txtSearchMaintenance";
            txtSearchMaintenance.Size = new Size(1321, 44);
            txtSearchMaintenance.TabIndex = 2;
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
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAmount.Location = new Point(801, 101);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(55, 36);
            lblAmount.TabIndex = 29;
            lblAmount.Text = "តម្លៃ:";
            // 
            // txtAmount
            // 
            txtAmount.Enabled = false;
            txtAmount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAmount.Location = new Point(888, 98);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(179, 44);
            txtAmount.TabIndex = 30;
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
            ((System.ComponentModel.ISupportInitialize)itemBindingSource).EndInit();
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
        private Panel pnlRightSide;
        private TextBox txtMaintenanceID;
        private DateTimePicker dtpStaffBirthDate;
        private TextBox txtItemDescription;
        private Label lblItemDescription;
        private TextBox txtItemID;
        private Label lblItemID;
        private Label lblMaintenanceQty;
        private Label lblCategory;
        private TextBox txtUnitPrice;
        private Label lblUnitPrice;
        private TextBox txtCategory;
        private GroupBox gbMaintenanceInformation;
        private RadioButton rdbFemale;
        private RadioButton rdbMale;
        private GroupBox gbImportDetails;
        private PictureBox pbStaffPhoto;
        private Button btnPickStaffPhoto;
        private DateTimePicker dtpMaintenanceDate;
        private Label lblMaintenanceDate;
        private Panel pnlMaintenanceManipulation;
        private Button btnInsertMaintenance;
        private Button btnCloseFormMaintenance;
        private Button btnNewMaintenance;
        private Button btnUpdateMaintenance;
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
        private ComboBox cbSupplierID;
        private TextBox txtSupplierName;
        private ComboBox cbStaffID;
        private TextBox txtStaffName;
        private Label lblStaffPosition;
        private TextBox txtStaffPosition;
        private Label lblMaintenanceID;
        private TextBox txtUnit;
        private Label lblUnit;
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
        private ComboBox cbStoreID;
        private GroupBox gbMaintenanceDetails;
        private TextBox txtPaidAmount;
        private Label lblStoreID;
        private ComboBox cbContractID;
        private BindingSource itemBindingSource;
        private DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn itemDescriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stockQtyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private Label lblStaffID;
        private TextBox textBox1;
        private Label lblStaffName;
        private TextBox txtAmount;
        private Label lblAmount;
    }
}