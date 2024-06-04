namespace Store_Rental_Management_Systems
{
    partial class FrmPayment
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
            gbPaymentDetails = new GroupBox();
            btnUpdateExpenseType = new Button();
            btnInsertExpenseType = new Button();
            txtExpenseQty = new TextBox();
            lblExpenseQty = new Label();
            lblExpenseDescription = new Label();
            txtExpenseDescription = new TextBox();
            txtExpenseTypeID = new TextBox();
            lblExpenseTypeID = new Label();
            lblUnitPrice = new Label();
            txtCategory = new TextBox();
            txtUnitPrice = new TextBox();
            lblAmount = new Label();
            gbPaymentInformation = new GroupBox();
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
            lblPaymentID = new Label();
            lblStoreID = new Label();
            cbContractID = new ComboBox();
            txtPaidAmount = new TextBox();
            dtpPaymentDate = new DateTimePicker();
            lblPaymentDate = new Label();
            txtPaymentID = new TextBox();
            pnlPaymentManipulation = new Panel();
            btnCloseFormPayment = new Button();
            btnNewPayment = new Button();
            btnUpdatePayment = new Button();
            btnInsertPayment = new Button();
            pnlLeftSide = new Panel();
            dgvMaintenanceItems = new DataGridView();
            itemIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            itemDescriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stockQtyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unitPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            itemBindingSource = new BindingSource(components);
            lblSearchPayment = new Label();
            txtSearchPayment = new TextBox();
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
            pnlRightSide.SuspendLayout();
            gbPaymentDetails.SuspendLayout();
            gbPaymentInformation.SuspendLayout();
            pnlPaymentManipulation.SuspendLayout();
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
            lblTitle.Text = "ព័ត៌មានការបង់ថ្លៃ";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlRightSide
            // 
            pnlRightSide.Controls.Add(gbPaymentDetails);
            pnlRightSide.Controls.Add(gbPaymentInformation);
            pnlRightSide.Location = new Point(266, 184);
            pnlRightSide.Name = "pnlRightSide";
            pnlRightSide.Size = new Size(1534, 375);
            pnlRightSide.TabIndex = 4;
            // 
            // gbPaymentDetails
            // 
            gbPaymentDetails.Controls.Add(btnUpdateExpenseType);
            gbPaymentDetails.Controls.Add(btnInsertExpenseType);
            gbPaymentDetails.Controls.Add(txtExpenseQty);
            gbPaymentDetails.Controls.Add(lblExpenseQty);
            gbPaymentDetails.Controls.Add(txtUnitPrice);
            gbPaymentDetails.Controls.Add(lblUnitPrice);
            gbPaymentDetails.Controls.Add(lblExpenseDescription);
            gbPaymentDetails.Controls.Add(txtExpenseDescription);
            gbPaymentDetails.Controls.Add(txtExpenseTypeID);
            gbPaymentDetails.Controls.Add(lblExpenseTypeID);
            gbPaymentDetails.Controls.Add(txtCategory);
            gbPaymentDetails.Controls.Add(lblAmount);
            gbPaymentDetails.Font = new Font("!Khmer OS Siemreap", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            gbPaymentDetails.Location = new Point(63, 214);
            gbPaymentDetails.Name = "gbPaymentDetails";
            gbPaymentDetails.Size = new Size(1427, 154);
            gbPaymentDetails.TabIndex = 26;
            gbPaymentDetails.TabStop = false;
            gbPaymentDetails.Text = "សេចក្ដីលម្អិត";
            // 
            // btnUpdateExpenseType
            // 
            btnUpdateExpenseType.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdateExpenseType.Location = new Point(1281, 93);
            btnUpdateExpenseType.Name = "btnUpdateExpenseType";
            btnUpdateExpenseType.Size = new Size(100, 52);
            btnUpdateExpenseType.TabIndex = 4;
            btnUpdateExpenseType.Text = "កែប្រែ";
            btnUpdateExpenseType.UseVisualStyleBackColor = true;
            // 
            // btnInsertExpenseType
            // 
            btnInsertExpenseType.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnInsertExpenseType.Location = new Point(1120, 93);
            btnInsertExpenseType.Name = "btnInsertExpenseType";
            btnInsertExpenseType.Size = new Size(102, 52);
            btnInsertExpenseType.TabIndex = 28;
            btnInsertExpenseType.Text = "បញ្ចូល";
            btnInsertExpenseType.UseVisualStyleBackColor = true;
            // 
            // txtExpenseQty
            // 
            txtExpenseQty.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtExpenseQty.Location = new Point(173, 98);
            txtExpenseQty.Name = "txtExpenseQty";
            txtExpenseQty.Size = new Size(271, 44);
            txtExpenseQty.TabIndex = 27;
            // 
            // lblExpenseQty
            // 
            lblExpenseQty.AutoSize = true;
            lblExpenseQty.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblExpenseQty.Location = new Point(18, 101);
            lblExpenseQty.Name = "lblExpenseQty";
            lblExpenseQty.Size = new Size(88, 36);
            lblExpenseQty.TabIndex = 26;
            lblExpenseQty.Text = "បរិមាណ:";
            // 
            // lblExpenseDescription
            // 
            lblExpenseDescription.AutoSize = true;
            lblExpenseDescription.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblExpenseDescription.Location = new Point(482, 47);
            lblExpenseDescription.Name = "lblExpenseDescription";
            lblExpenseDescription.Size = new Size(190, 36);
            lblExpenseDescription.TabIndex = 18;
            lblExpenseDescription.Text = "ពិព័ណ៌នាការចំណាយ:";
            // 
            // txtExpenseDescription
            // 
            txtExpenseDescription.Enabled = false;
            txtExpenseDescription.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtExpenseDescription.Location = new Point(681, 38);
            txtExpenseDescription.Name = "txtExpenseDescription";
            txtExpenseDescription.Size = new Size(219, 44);
            txtExpenseDescription.TabIndex = 19;
            // 
            // txtExpenseTypeID
            // 
            txtExpenseTypeID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtExpenseTypeID.Location = new Point(267, 38);
            txtExpenseTypeID.Name = "txtExpenseTypeID";
            txtExpenseTypeID.Size = new Size(177, 44);
            txtExpenseTypeID.TabIndex = 17;
            // 
            // lblExpenseTypeID
            // 
            lblExpenseTypeID.AutoSize = true;
            lblExpenseTypeID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblExpenseTypeID.Location = new Point(18, 46);
            lblExpenseTypeID.Name = "lblExpenseTypeID";
            lblExpenseTypeID.Size = new Size(243, 36);
            lblExpenseTypeID.TabIndex = 16;
            lblExpenseTypeID.Text = "លេខសម្គាល់ប្រភេទចំណាយ:";
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUnitPrice.Location = new Point(947, 46);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(165, 36);
            lblUnitPrice.TabIndex = 20;
            lblUnitPrice.Text = "តម្លៃក្នុងមួយឯកតា:";
            // 
            // txtCategory
            // 
            txtCategory.Enabled = false;
            txtCategory.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCategory.Location = new Point(681, 98);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(219, 44);
            txtCategory.TabIndex = 23;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Enabled = false;
            txtUnitPrice.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUnitPrice.Location = new Point(1120, 38);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(261, 44);
            txtUnitPrice.TabIndex = 21;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAmount.Location = new Point(482, 101);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(55, 36);
            lblAmount.TabIndex = 22;
            lblAmount.Text = "តម្លៃ:";
            // 
            // gbPaymentInformation
            // 
            gbPaymentInformation.Controls.Add(txtStaffName);
            gbPaymentInformation.Controls.Add(lblStaffName);
            gbPaymentInformation.Controls.Add(txtStaffPosition);
            gbPaymentInformation.Controls.Add(lblStaffPosition);
            gbPaymentInformation.Controls.Add(textBox1);
            gbPaymentInformation.Controls.Add(lblStaffID);
            gbPaymentInformation.Controls.Add(cbStoreID);
            gbPaymentInformation.Controls.Add(txtOwedAmount);
            gbPaymentInformation.Controls.Add(lblContractID);
            gbPaymentInformation.Controls.Add(lblPaidAmount);
            gbPaymentInformation.Controls.Add(lblOwedAmount);
            gbPaymentInformation.Controls.Add(txtTotalAmount);
            gbPaymentInformation.Controls.Add(lblTotalAmount);
            gbPaymentInformation.Controls.Add(lblPaymentID);
            gbPaymentInformation.Controls.Add(lblStoreID);
            gbPaymentInformation.Controls.Add(cbContractID);
            gbPaymentInformation.Controls.Add(txtPaidAmount);
            gbPaymentInformation.Controls.Add(dtpPaymentDate);
            gbPaymentInformation.Controls.Add(lblPaymentDate);
            gbPaymentInformation.Controls.Add(txtPaymentID);
            gbPaymentInformation.Font = new Font("!Khmer OS Siemreap", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            gbPaymentInformation.Location = new Point(63, 19);
            gbPaymentInformation.Name = "gbPaymentInformation";
            gbPaymentInformation.Size = new Size(1427, 194);
            gbPaymentInformation.TabIndex = 25;
            gbPaymentInformation.TabStop = false;
            gbPaymentInformation.Text = "ព័ត៌មានការបង់ថ្លៃ";
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
            // lblPaymentID
            // 
            lblPaymentID.AutoSize = true;
            lblPaymentID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPaymentID.Location = new Point(18, 41);
            lblPaymentID.Name = "lblPaymentID";
            lblPaymentID.Size = new Size(195, 36);
            lblPaymentID.TabIndex = 34;
            lblPaymentID.Text = "លេខសម្គាល់ការបង់ថ្លៃ:";
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
            // dtpPaymentDate
            // 
            dtpPaymentDate.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpPaymentDate.Format = DateTimePickerFormat.Short;
            dtpPaymentDate.Location = new Point(681, 33);
            dtpPaymentDate.Name = "dtpPaymentDate";
            dtpPaymentDate.Size = new Size(189, 44);
            dtpPaymentDate.TabIndex = 20;
            // 
            // lblPaymentDate
            // 
            lblPaymentDate.AutoSize = true;
            lblPaymentDate.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPaymentDate.Location = new Point(482, 41);
            lblPaymentDate.Name = "lblPaymentDate";
            lblPaymentDate.Size = new Size(163, 36);
            lblPaymentDate.TabIndex = 19;
            lblPaymentDate.Text = "កាលបរិច្ឆេទបង់ថ្លៃ:";
            // 
            // txtPaymentID
            // 
            txtPaymentID.Enabled = false;
            txtPaymentID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPaymentID.Location = new Point(227, 33);
            txtPaymentID.Name = "txtPaymentID";
            txtPaymentID.Size = new Size(217, 44);
            txtPaymentID.TabIndex = 3;
            // 
            // pnlPaymentManipulation
            // 
            pnlPaymentManipulation.Controls.Add(btnCloseFormPayment);
            pnlPaymentManipulation.Controls.Add(btnNewPayment);
            pnlPaymentManipulation.Controls.Add(btnUpdatePayment);
            pnlPaymentManipulation.Controls.Add(btnInsertPayment);
            pnlPaymentManipulation.Location = new Point(329, 563);
            pnlPaymentManipulation.Name = "pnlPaymentManipulation";
            pnlPaymentManipulation.Size = new Size(1427, 62);
            pnlPaymentManipulation.TabIndex = 5;
            // 
            // btnCloseFormPayment
            // 
            btnCloseFormPayment.Location = new Point(1231, 7);
            btnCloseFormPayment.Name = "btnCloseFormPayment";
            btnCloseFormPayment.Size = new Size(134, 52);
            btnCloseFormPayment.TabIndex = 3;
            btnCloseFormPayment.Text = "បិទ";
            btnCloseFormPayment.UseVisualStyleBackColor = true;
            // 
            // btnNewPayment
            // 
            btnNewPayment.Location = new Point(871, 7);
            btnNewPayment.Name = "btnNewPayment";
            btnNewPayment.Size = new Size(152, 52);
            btnNewPayment.TabIndex = 2;
            btnNewPayment.Text = "បង្កើតថ្មី";
            btnNewPayment.UseVisualStyleBackColor = true;
            // 
            // btnUpdatePayment
            // 
            btnUpdatePayment.Location = new Point(452, 7);
            btnUpdatePayment.Name = "btnUpdatePayment";
            btnUpdatePayment.Size = new Size(152, 52);
            btnUpdatePayment.TabIndex = 1;
            btnUpdatePayment.Text = "កែប្រែ";
            btnUpdatePayment.UseVisualStyleBackColor = true;
            // 
            // btnInsertPayment
            // 
            btnInsertPayment.Location = new Point(67, 7);
            btnInsertPayment.Name = "btnInsertPayment";
            btnInsertPayment.Size = new Size(152, 52);
            btnInsertPayment.TabIndex = 0;
            btnInsertPayment.Text = "បញ្ចូល";
            btnInsertPayment.UseVisualStyleBackColor = true;
            // 
            // pnlLeftSide
            // 
            pnlLeftSide.Controls.Add(dgvMaintenanceItems);
            pnlLeftSide.Controls.Add(lblSearchPayment);
            pnlLeftSide.Controls.Add(txtSearchPayment);
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
            dgvMaintenanceItems.Columns.AddRange(new DataGridViewColumn[] { itemIDDataGridViewTextBoxColumn, itemDescriptionDataGridViewTextBoxColumn, stockQtyDataGridViewTextBoxColumn, unitPriceDataGridViewTextBoxColumn, categoryDataGridViewTextBoxColumn, unitDataGridViewTextBoxColumn });
            dgvMaintenanceItems.DataSource = itemBindingSource;
            dgvMaintenanceItems.Location = new Point(63, 74);
            dgvMaintenanceItems.Name = "dgvMaintenanceItems";
            dgvMaintenanceItems.ReadOnly = true;
            dgvMaintenanceItems.RowHeadersWidth = 51;
            dgvMaintenanceItems.RowTemplate.Height = 29;
            dgvMaintenanceItems.Size = new Size(1427, 238);
            dgvMaintenanceItems.TabIndex = 3;
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
            stockQtyDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            stockQtyDataGridViewTextBoxColumn.DataPropertyName = "StockQty";
            stockQtyDataGridViewTextBoxColumn.HeaderText = "MaintenanceQty";
            stockQtyDataGridViewTextBoxColumn.MinimumWidth = 6;
            stockQtyDataGridViewTextBoxColumn.Name = "stockQtyDataGridViewTextBoxColumn";
            stockQtyDataGridViewTextBoxColumn.ReadOnly = true;
            stockQtyDataGridViewTextBoxColumn.Width = 189;
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            unitPriceDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
            unitPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            unitPriceDataGridViewTextBoxColumn.ReadOnly = true;
            unitPriceDataGridViewTextBoxColumn.Width = 124;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            categoryDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            categoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            categoryDataGridViewTextBoxColumn.ReadOnly = true;
            categoryDataGridViewTextBoxColumn.Width = 123;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            unitDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            unitDataGridViewTextBoxColumn.HeaderText = "Unit";
            unitDataGridViewTextBoxColumn.MinimumWidth = 6;
            unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            unitDataGridViewTextBoxColumn.ReadOnly = true;
            unitDataGridViewTextBoxColumn.Width = 80;
            // 
            // itemBindingSource
            // 
            itemBindingSource.DataSource = typeof(StoreRentalHelper.entities.Item);
            // 
            // lblSearchPayment
            // 
            lblSearchPayment.AutoSize = true;
            lblSearchPayment.Location = new Point(64, 17);
            lblSearchPayment.Name = "lblSearchPayment";
            lblSearchPayment.Size = new Size(81, 36);
            lblSearchPayment.TabIndex = 1;
            lblSearchPayment.Text = "ស្វែងរក:";
            // 
            // txtSearchPayment
            // 
            txtSearchPayment.Location = new Point(169, 11);
            txtSearchPayment.Name = "txtSearchPayment";
            txtSearchPayment.Size = new Size(1321, 44);
            txtSearchPayment.TabIndex = 2;
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
            // FrmPayment
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1800, 1000);
            ControlBox = true;
            Controls.Add(pnlLeftSide);
            Controls.Add(pnlPaymentManipulation);
            Controls.Add(pnlRightSide);
            Controls.Add(lblTitle);
            Name = "FrmPayment";
            Text = "ព័ត៌មានបុគ្គលិក";
            Controls.SetChildIndex(lblTitle, 0);
            Controls.SetChildIndex(pnlRightSide, 0);
            Controls.SetChildIndex(pnlPaymentManipulation, 0);
            Controls.SetChildIndex(pnlLeftSide, 0);
            pnlRightSide.ResumeLayout(false);
            gbPaymentDetails.ResumeLayout(false);
            gbPaymentDetails.PerformLayout();
            gbPaymentInformation.ResumeLayout(false);
            gbPaymentInformation.PerformLayout();
            pnlPaymentManipulation.ResumeLayout(false);
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
        private TextBox txtPaymentID;
        private DateTimePicker dtpStaffBirthDate;
        private TextBox txtExpenseDescription;
        private Label lblExpenseDescription;
        private TextBox txtExpenseTypeID;
        private Label lblExpenseTypeID;
        private Label lblAmount;
        private TextBox txtUnitPrice;
        private Label lblUnitPrice;
        private TextBox txtCategory;
        private GroupBox gbPaymentInformation;
        private RadioButton rdbFemale;
        private RadioButton rdbMale;
        private GroupBox gbImportDetails;
        private PictureBox pbStaffPhoto;
        private Button btnPickStaffPhoto;
        private DateTimePicker dtpPaymentDate;
        private Label lblPaymentDate;
        private Panel pnlPaymentManipulation;
        private Button btnInsertPayment;
        private Button btnCloseFormPayment;
        private Button btnNewPayment;
        private Button btnUpdatePayment;
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
        private Label lblPaymentID;
        private TextBox txtExpenseQty;
        private Label lblExpenseQty;
        private Button btnUpdateExpenseType;
        private Button btnInsertExpenseType;
        private Panel pnlLeftSide;
        private DataGridView dgvMaintenanceItems;
        private Label lblSearchPayment;
        private TextBox txtSearchPayment;
        private Label lblPaidAmount;
        private Label lblOwedAmount;
        private TextBox txtTotalAmount;
        private Label lblTotalAmount;
        private Label lblContractID;
        private TextBox txtOwedAmount;
        private ComboBox cbStoreID;
        private GroupBox gbPaymentDetails;
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
    }
}