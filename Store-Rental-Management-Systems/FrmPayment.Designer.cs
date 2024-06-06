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
            lblTitle = new Label();
            pnlRightSide = new Panel();
            gbPaymentDetails = new GroupBox();
            btnUpdateExpenseType = new Button();
            btnInsertExpenseType = new Button();
            txtExpenseQty = new TextBox();
            lblExpenseQty = new Label();
            txtUnitPrice = new TextBox();
            lblUnitPrice = new Label();
            lblExpenseDescription = new Label();
            txtExpenseDescription = new TextBox();
            txtExpenseTypeID = new TextBox();
            lblExpenseTypeID = new Label();
            txtAmount = new TextBox();
            lblAmount = new Label();
            gbPaymentInformation = new GroupBox();
            cbStaffID = new ComboBox();
            txtStaffName = new TextBox();
            lblStaffName = new Label();
            txtStaffPosition = new TextBox();
            lblStaffPosition = new Label();
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
            dgvExpenses = new DataGridView();
            ExpenseTypeID = new DataGridViewTextBoxColumn();
            ExpenseDescription = new DataGridViewTextBoxColumn();
            UnitPrice = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            lblSearchPayment = new Label();
            txtSearchPayment = new TextBox();
            pnlRightSide.SuspendLayout();
            gbPaymentDetails.SuspendLayout();
            gbPaymentInformation.SuspendLayout();
            pnlPaymentManipulation.SuspendLayout();
            pnlLeftSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExpenses).BeginInit();
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
            lblTitle.Text = "ព័ត៌មានការបង់ថ្លៃ";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlRightSide
            // 
            pnlRightSide.Controls.Add(gbPaymentDetails);
            pnlRightSide.Controls.Add(gbPaymentInformation);
            pnlRightSide.Location = new Point(266, 184);
            pnlRightSide.Name = "pnlRightSide";
            pnlRightSide.Size = new Size(1534, 373);
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
            gbPaymentDetails.Controls.Add(txtAmount);
            gbPaymentDetails.Controls.Add(lblAmount);
            gbPaymentDetails.Font = new Font("!Khmer OS Siemreap", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            gbPaymentDetails.Location = new Point(63, 212);
            gbPaymentDetails.Name = "gbPaymentDetails";
            gbPaymentDetails.Size = new Size(1427, 154);
            gbPaymentDetails.TabIndex = 26;
            gbPaymentDetails.TabStop = false;
            gbPaymentDetails.Text = "សេចក្ដីលម្អិត";
            // 
            // btnUpdateExpenseType
            // 
            btnUpdateExpenseType.BackColor = Color.FromArgb(0, 28, 87);
            btnUpdateExpenseType.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateExpenseType.ForeColor = Color.White;
            btnUpdateExpenseType.Location = new Point(1298, 90);
            btnUpdateExpenseType.Name = "btnUpdateExpenseType";
            btnUpdateExpenseType.Size = new Size(100, 52);
            btnUpdateExpenseType.TabIndex = 4;
            btnUpdateExpenseType.Text = "កែប្រែ";
            btnUpdateExpenseType.UseVisualStyleBackColor = false;
            // 
            // btnInsertExpenseType
            // 
            btnInsertExpenseType.BackColor = Color.FromArgb(0, 28, 87);
            btnInsertExpenseType.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsertExpenseType.ForeColor = Color.White;
            btnInsertExpenseType.Location = new Point(1120, 93);
            btnInsertExpenseType.Name = "btnInsertExpenseType";
            btnInsertExpenseType.Size = new Size(102, 52);
            btnInsertExpenseType.TabIndex = 28;
            btnInsertExpenseType.Text = "បញ្ចូល";
            btnInsertExpenseType.UseVisualStyleBackColor = false;
            // 
            // txtExpenseQty
            // 
            txtExpenseQty.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtExpenseQty.Location = new Point(267, 98);
            txtExpenseQty.Name = "txtExpenseQty";
            txtExpenseQty.Size = new Size(177, 44);
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
            // txtUnitPrice
            // 
            txtUnitPrice.Enabled = false;
            txtUnitPrice.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUnitPrice.Location = new Point(1120, 38);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(278, 44);
            txtUnitPrice.TabIndex = 21;
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
            // txtAmount
            // 
            txtAmount.Enabled = false;
            txtAmount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAmount.Location = new Point(681, 98);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(219, 44);
            txtAmount.TabIndex = 23;
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
            gbPaymentInformation.Controls.Add(cbStaffID);
            gbPaymentInformation.Controls.Add(txtStaffName);
            gbPaymentInformation.Controls.Add(lblStaffName);
            gbPaymentInformation.Controls.Add(txtStaffPosition);
            gbPaymentInformation.Controls.Add(lblStaffPosition);
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
            gbPaymentInformation.Font = new Font("!Khmer OS Siemreap", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            gbPaymentInformation.Location = new Point(63, 12);
            gbPaymentInformation.Name = "gbPaymentInformation";
            gbPaymentInformation.Size = new Size(1427, 194);
            gbPaymentInformation.TabIndex = 25;
            gbPaymentInformation.TabStop = false;
            gbPaymentInformation.Text = "ព័ត៌មានការបង់ថ្លៃ";
            // 
            // cbStaffID
            // 
            cbStaffID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbStaffID.FormattingEnabled = true;
            cbStaffID.Items.AddRange(new object[] { "ភ្នំពេញ", "តាកែវ" });
            cbStaffID.Location = new Point(555, 140);
            cbStaffID.Name = "cbStaffID";
            cbStaffID.Size = new Size(166, 44);
            cbStaffID.TabIndex = 48;
            // 
            // txtStaffName
            // 
            txtStaffName.Enabled = false;
            txtStaffName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffName.Location = new Point(928, 140);
            txtStaffName.Name = "txtStaffName";
            txtStaffName.Size = new Size(161, 44);
            txtStaffName.TabIndex = 47;
            // 
            // lblStaffName
            // 
            lblStaffName.AutoSize = true;
            lblStaffName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffName.Location = new Point(730, 143);
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
            // lblStaffID
            // 
            lblStaffID.AutoSize = true;
            lblStaffID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffID.Location = new Point(366, 143);
            lblStaffID.Name = "lblStaffID";
            lblStaffID.Size = new Size(183, 36);
            lblStaffID.TabIndex = 42;
            lblStaffID.Text = "លេខសម្គាល់បុគ្គលិក:";
            // 
            // cbStoreID
            // 
            cbStoreID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbStoreID.FormattingEnabled = true;
            cbStoreID.Items.AddRange(new object[] { "ភ្នំពេញ", "តាកែវ" });
            cbStoreID.Location = new Point(173, 140);
            cbStoreID.Name = "cbStoreID";
            cbStoreID.Size = new Size(166, 44);
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
            btnCloseFormPayment.BackColor = Color.FromArgb(0, 28, 87);
            btnCloseFormPayment.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCloseFormPayment.ForeColor = Color.White;
            btnCloseFormPayment.Location = new Point(1246, 7);
            btnCloseFormPayment.Name = "btnCloseFormPayment";
            btnCloseFormPayment.Size = new Size(152, 52);
            btnCloseFormPayment.TabIndex = 3;
            btnCloseFormPayment.Text = "បិទ";
            btnCloseFormPayment.UseVisualStyleBackColor = false;
            // 
            // btnNewPayment
            // 
            btnNewPayment.BackColor = Color.FromArgb(0, 28, 87);
            btnNewPayment.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNewPayment.ForeColor = Color.White;
            btnNewPayment.Location = new Point(843, 7);
            btnNewPayment.Name = "btnNewPayment";
            btnNewPayment.Size = new Size(152, 52);
            btnNewPayment.TabIndex = 2;
            btnNewPayment.Text = "បង្កើតថ្មី";
            btnNewPayment.UseVisualStyleBackColor = false;
            // 
            // btnUpdatePayment
            // 
            btnUpdatePayment.BackColor = Color.FromArgb(0, 28, 87);
            btnUpdatePayment.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdatePayment.ForeColor = Color.White;
            btnUpdatePayment.Location = new Point(455, 7);
            btnUpdatePayment.Name = "btnUpdatePayment";
            btnUpdatePayment.Size = new Size(152, 52);
            btnUpdatePayment.TabIndex = 1;
            btnUpdatePayment.Text = "កែប្រែ";
            btnUpdatePayment.UseVisualStyleBackColor = false;
            // 
            // btnInsertPayment
            // 
            btnInsertPayment.BackColor = Color.FromArgb(0, 28, 87);
            btnInsertPayment.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsertPayment.ForeColor = Color.White;
            btnInsertPayment.Location = new Point(67, 7);
            btnInsertPayment.Name = "btnInsertPayment";
            btnInsertPayment.Size = new Size(152, 52);
            btnInsertPayment.TabIndex = 0;
            btnInsertPayment.Text = "បញ្ចូល";
            btnInsertPayment.UseVisualStyleBackColor = false;
            // 
            // pnlLeftSide
            // 
            pnlLeftSide.Controls.Add(dgvExpenses);
            pnlLeftSide.Controls.Add(lblSearchPayment);
            pnlLeftSide.Controls.Add(txtSearchPayment);
            pnlLeftSide.Location = new Point(266, 643);
            pnlLeftSide.Name = "pnlLeftSide";
            pnlLeftSide.Size = new Size(1800, 354);
            pnlLeftSide.TabIndex = 6;
            // 
            // dgvExpenses
            // 
            dgvExpenses.AllowUserToAddRows = false;
            dgvExpenses.AllowUserToDeleteRows = false;
            dgvExpenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpenses.Columns.AddRange(new DataGridViewColumn[] { ExpenseTypeID, ExpenseDescription, UnitPrice, Quantity, Amount });
            dgvExpenses.Location = new Point(64, 70);
            dgvExpenses.Name = "dgvExpenses";
            dgvExpenses.ReadOnly = true;
            dgvExpenses.RowHeadersWidth = 51;
            dgvExpenses.RowTemplate.Height = 29;
            dgvExpenses.Size = new Size(1427, 238);
            dgvExpenses.TabIndex = 4;
            // 
            // ExpenseTypeID
            // 
            ExpenseTypeID.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ExpenseTypeID.DataPropertyName = "ExpenseTypeID";
            ExpenseTypeID.HeaderText = "លេខសម្គាល់ប្រភេទចំណាយ";
            ExpenseTypeID.MinimumWidth = 6;
            ExpenseTypeID.Name = "ExpenseTypeID";
            ExpenseTypeID.ReadOnly = true;
            ExpenseTypeID.Width = 266;
            // 
            // ExpenseDescription
            // 
            ExpenseDescription.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ExpenseDescription.DataPropertyName = "ExpenseDescription";
            ExpenseDescription.HeaderText = "ពិព័ណ៌នាការចំណាយ";
            ExpenseDescription.MinimumWidth = 6;
            ExpenseDescription.Name = "ExpenseDescription";
            ExpenseDescription.ReadOnly = true;
            // 
            // UnitPrice
            // 
            UnitPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            UnitPrice.DataPropertyName = "UnitPrice";
            UnitPrice.HeaderText = "តម្លៃក្នុងមួយឯកតា";
            UnitPrice.MinimumWidth = 6;
            UnitPrice.Name = "UnitPrice";
            UnitPrice.ReadOnly = true;
            UnitPrice.Width = 188;
            // 
            // Quantity
            // 
            Quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Quantity.DataPropertyName = "Quantity";
            Quantity.HeaderText = "បរិមាណ";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            Quantity.Width = 111;
            // 
            // Amount
            // 
            Amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Amount.DataPropertyName = "Amount";
            Amount.HeaderText = "តម្លៃ";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            Amount.Width = 78;
            // 
            // lblSearchPayment
            // 
            lblSearchPayment.AutoSize = true;
            lblSearchPayment.Location = new Point(64, 17);
            lblSearchPayment.Name = "lblSearchPayment";
            lblSearchPayment.Size = new Size(283, 36);
            lblSearchPayment.TabIndex = 1;
            lblSearchPayment.Text = "ស្វែងរក (លេខសម្គាល់ការបង់ថ្លៃ):";
            // 
            // txtSearchPayment
            // 
            txtSearchPayment.Location = new Point(365, 11);
            txtSearchPayment.Name = "txtSearchPayment";
            txtSearchPayment.Size = new Size(370, 44);
            txtSearchPayment.TabIndex = 2;
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
            ((System.ComponentModel.ISupportInitialize)dgvExpenses).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Panel pnlRightSide;
        private TextBox txtPaymentID;
        private TextBox txtExpenseDescription;
        private Label lblExpenseDescription;
        private TextBox txtExpenseTypeID;
        private Label lblExpenseTypeID;
        private Label lblAmount;
        private TextBox txtUnitPrice;
        private Label lblUnitPrice;
        private TextBox txtAmount;
        private GroupBox gbPaymentInformation;
        private DateTimePicker dtpPaymentDate;
        private Label lblPaymentDate;
        private Panel pnlPaymentManipulation;
        private ComboBox cbSupplierID;
        private TextBox txtSupplierName;
        private TextBox txtStaffName;
        private Label lblStaffPosition;
        private TextBox txtStaffPosition;
        private Label lblPaymentID;
        private TextBox txtExpenseQty;
        private Label lblExpenseQty;
        private Button btnUpdateExpenseType;
        private Button btnInsertExpenseType;
        private Panel pnlLeftSide;
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
        private Label lblStaffID;
        private Label lblStaffName;
        private Button btnNewPayment;
        private Button btnUpdatePayment;
        private Button btnInsertPayment;
        private ComboBox cbStaffID;
        private Button btnCloseFormPayment;
        private DataGridView dgvExpenses;
        private DataGridViewTextBoxColumn ExpenseTypeID;
        private DataGridViewTextBoxColumn ExpenseDescription;
        private DataGridViewTextBoxColumn UnitPrice;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Amount;
    }
}