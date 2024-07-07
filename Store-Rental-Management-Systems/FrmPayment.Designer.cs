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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblTitle = new Label();
            pnlRightSide = new Panel();
            gbPaymentDetails = new GroupBox();
            txtAmount = new TextBox();
            lblAmount = new Label();
            txtExpenseTypeQty = new TextBox();
            label3 = new Label();
            txtUnitPrice = new TextBox();
            label2 = new Label();
            btnCancelPaymentExpenseType = new Button();
            btnDeletePaymentExpenseType = new Button();
            cbExpenseTypeID = new ComboBox();
            btnUpdatePaymentExpenseType = new Button();
            btnInsertPaymentExpenseType = new Button();
            lblExpenseDescription = new Label();
            txtExpenseDescription = new TextBox();
            lblExpenseTypeID = new Label();
            gbPaymentInformation = new GroupBox();
            cbStoreID = new ComboBox();
            label1 = new Label();
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
            lblPaymentID = new Label();
            cbContractID = new ComboBox();
            txtPaidAmount = new TextBox();
            dtpPaymentDate = new DateTimePicker();
            lblPaymentDate = new Label();
            txtPaymentID = new TextBox();
            pnlPaymentManipulation = new Panel();
            btnCancelPayment = new Button();
            btnNewPayment = new Button();
            btnUpdatePayment = new Button();
            btnInsertPayment = new Button();
            pnlLeftSide = new Panel();
            cbSearchPayment = new ComboBox();
            dgvExpenses = new DataGridView();
            ExpenseTypeID = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            UnitPrice = new DataGridViewTextBoxColumn();
            ExpenseTypeQty = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            lblSearchPayment = new Label();
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
            gbPaymentDetails.Controls.Add(txtAmount);
            gbPaymentDetails.Controls.Add(lblAmount);
            gbPaymentDetails.Controls.Add(txtExpenseTypeQty);
            gbPaymentDetails.Controls.Add(label3);
            gbPaymentDetails.Controls.Add(txtUnitPrice);
            gbPaymentDetails.Controls.Add(label2);
            gbPaymentDetails.Controls.Add(btnCancelPaymentExpenseType);
            gbPaymentDetails.Controls.Add(btnDeletePaymentExpenseType);
            gbPaymentDetails.Controls.Add(cbExpenseTypeID);
            gbPaymentDetails.Controls.Add(btnUpdatePaymentExpenseType);
            gbPaymentDetails.Controls.Add(btnInsertPaymentExpenseType);
            gbPaymentDetails.Controls.Add(lblExpenseDescription);
            gbPaymentDetails.Controls.Add(txtExpenseDescription);
            gbPaymentDetails.Controls.Add(lblExpenseTypeID);
            gbPaymentDetails.Font = new Font("!Khmer OS Siemreap", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            gbPaymentDetails.Location = new Point(63, 212);
            gbPaymentDetails.Name = "gbPaymentDetails";
            gbPaymentDetails.Size = new Size(1427, 154);
            gbPaymentDetails.TabIndex = 26;
            gbPaymentDetails.TabStop = false;
            gbPaymentDetails.Text = "សេចក្ដីលម្អិត";
            // 
            // txtAmount
            // 
            txtAmount.Enabled = false;
            txtAmount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAmount.Location = new Point(730, 93);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(183, 51);
            txtAmount.TabIndex = 57;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAmount.Location = new Point(498, 102);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(113, 43);
            lblAmount.TabIndex = 56;
            lblAmount.Text = "តម្លៃសរុប:";
            // 
            // txtExpenseTypeQty
            // 
            txtExpenseTypeQty.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtExpenseTypeQty.Location = new Point(310, 94);
            txtExpenseTypeQty.Name = "txtExpenseTypeQty";
            txtExpenseTypeQty.Size = new Size(170, 51);
            txtExpenseTypeQty.TabIndex = 55;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(18, 96);
            label3.Name = "label3";
            label3.Size = new Size(106, 43);
            label3.TabIndex = 54;
            label3.Text = "បរិមាណ:";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Enabled = false;
            txtUnitPrice.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUnitPrice.Location = new Point(1194, 29);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(204, 51);
            txtUnitPrice.TabIndex = 53;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(955, 34);
            label2.Name = "label2";
            label2.Size = new Size(194, 43);
            label2.TabIndex = 52;
            label2.Text = "តម្លៃក្នុងមួយឯកតា:";
            // 
            // btnCancelPaymentExpenseType
            // 
            btnCancelPaymentExpenseType.BackColor = Color.FromArgb(0, 28, 87);
            btnCancelPaymentExpenseType.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelPaymentExpenseType.ForeColor = Color.White;
            btnCancelPaymentExpenseType.Location = new Point(1274, 96);
            btnCancelPaymentExpenseType.Name = "btnCancelPaymentExpenseType";
            btnCancelPaymentExpenseType.Size = new Size(124, 52);
            btnCancelPaymentExpenseType.TabIndex = 51;
            btnCancelPaymentExpenseType.TabStop = false;
            btnCancelPaymentExpenseType.Text = "បោះបង់";
            btnCancelPaymentExpenseType.UseVisualStyleBackColor = false;
            // 
            // btnDeletePaymentExpenseType
            // 
            btnDeletePaymentExpenseType.BackColor = Color.FromArgb(0, 28, 87);
            btnDeletePaymentExpenseType.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeletePaymentExpenseType.ForeColor = Color.White;
            btnDeletePaymentExpenseType.Location = new Point(1170, 96);
            btnDeletePaymentExpenseType.Name = "btnDeletePaymentExpenseType";
            btnDeletePaymentExpenseType.Size = new Size(87, 52);
            btnDeletePaymentExpenseType.TabIndex = 50;
            btnDeletePaymentExpenseType.TabStop = false;
            btnDeletePaymentExpenseType.Text = "លុប";
            btnDeletePaymentExpenseType.UseVisualStyleBackColor = false;
            // 
            // cbExpenseTypeID
            // 
            cbExpenseTypeID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbExpenseTypeID.FormattingEnabled = true;
            cbExpenseTypeID.Location = new Point(310, 31);
            cbExpenseTypeID.Name = "cbExpenseTypeID";
            cbExpenseTypeID.Size = new Size(170, 51);
            cbExpenseTypeID.TabIndex = 49;
            // 
            // btnUpdatePaymentExpenseType
            // 
            btnUpdatePaymentExpenseType.BackColor = Color.FromArgb(0, 28, 87);
            btnUpdatePaymentExpenseType.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdatePaymentExpenseType.ForeColor = Color.White;
            btnUpdatePaymentExpenseType.Location = new Point(1052, 96);
            btnUpdatePaymentExpenseType.Name = "btnUpdatePaymentExpenseType";
            btnUpdatePaymentExpenseType.Size = new Size(100, 52);
            btnUpdatePaymentExpenseType.TabIndex = 4;
            btnUpdatePaymentExpenseType.Text = "កែប្រែ";
            btnUpdatePaymentExpenseType.UseVisualStyleBackColor = false;
            // 
            // btnInsertPaymentExpenseType
            // 
            btnInsertPaymentExpenseType.BackColor = Color.FromArgb(0, 28, 87);
            btnInsertPaymentExpenseType.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsertPaymentExpenseType.ForeColor = Color.White;
            btnInsertPaymentExpenseType.Location = new Point(935, 96);
            btnInsertPaymentExpenseType.Name = "btnInsertPaymentExpenseType";
            btnInsertPaymentExpenseType.Size = new Size(102, 52);
            btnInsertPaymentExpenseType.TabIndex = 28;
            btnInsertPaymentExpenseType.Text = "បញ្ចូល";
            btnInsertPaymentExpenseType.UseVisualStyleBackColor = false;
            // 
            // lblExpenseDescription
            // 
            lblExpenseDescription.AutoSize = true;
            lblExpenseDescription.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblExpenseDescription.Location = new Point(498, 39);
            lblExpenseDescription.Name = "lblExpenseDescription";
            lblExpenseDescription.Size = new Size(226, 43);
            lblExpenseDescription.TabIndex = 18;
            lblExpenseDescription.Text = "ពិព័ណ៌នាការចំណាយ:";
            // 
            // txtExpenseDescription
            // 
            txtExpenseDescription.Enabled = false;
            txtExpenseDescription.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtExpenseDescription.Location = new Point(730, 31);
            txtExpenseDescription.Name = "txtExpenseDescription";
            txtExpenseDescription.Size = new Size(183, 51);
            txtExpenseDescription.TabIndex = 19;
            // 
            // lblExpenseTypeID
            // 
            lblExpenseTypeID.AutoSize = true;
            lblExpenseTypeID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblExpenseTypeID.Location = new Point(18, 46);
            lblExpenseTypeID.Name = "lblExpenseTypeID";
            lblExpenseTypeID.Size = new Size(287, 43);
            lblExpenseTypeID.TabIndex = 16;
            lblExpenseTypeID.Text = "លេខសម្គាល់ប្រភេទចំណាយ:";
            // 
            // gbPaymentInformation
            // 
            gbPaymentInformation.Controls.Add(cbStoreID);
            gbPaymentInformation.Controls.Add(label1);
            gbPaymentInformation.Controls.Add(cbStaffID);
            gbPaymentInformation.Controls.Add(txtStaffName);
            gbPaymentInformation.Controls.Add(lblStaffName);
            gbPaymentInformation.Controls.Add(txtStaffPosition);
            gbPaymentInformation.Controls.Add(lblStaffPosition);
            gbPaymentInformation.Controls.Add(lblStaffID);
            gbPaymentInformation.Controls.Add(txtOwedAmount);
            gbPaymentInformation.Controls.Add(lblContractID);
            gbPaymentInformation.Controls.Add(lblPaidAmount);
            gbPaymentInformation.Controls.Add(lblOwedAmount);
            gbPaymentInformation.Controls.Add(txtTotalAmount);
            gbPaymentInformation.Controls.Add(lblTotalAmount);
            gbPaymentInformation.Controls.Add(lblPaymentID);
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
            // cbStoreID
            // 
            cbStoreID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStoreID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbStoreID.FormattingEnabled = true;
            cbStoreID.Location = new Point(188, 140);
            cbStoreID.Name = "cbStoreID";
            cbStoreID.Size = new Size(128, 51);
            cbStoreID.TabIndex = 50;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(18, 147);
            label1.Name = "label1";
            label1.Size = new Size(175, 43);
            label1.TabIndex = 49;
            label1.Text = "លេខសម្គាល់តូប:";
            // 
            // cbStaffID
            // 
            cbStaffID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStaffID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbStaffID.FormattingEnabled = true;
            cbStaffID.Location = new Point(521, 140);
            cbStaffID.Name = "cbStaffID";
            cbStaffID.Size = new Size(154, 51);
            cbStaffID.TabIndex = 48;
            // 
            // txtStaffName
            // 
            txtStaffName.Enabled = false;
            txtStaffName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffName.Location = new Point(908, 140);
            txtStaffName.Name = "txtStaffName";
            txtStaffName.Size = new Size(161, 51);
            txtStaffName.TabIndex = 47;
            // 
            // lblStaffName
            // 
            lblStaffName.AutoSize = true;
            lblStaffName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffName.Location = new Point(676, 143);
            lblStaffName.Name = "lblStaffName";
            lblStaffName.Size = new Size(226, 43);
            lblStaffName.TabIndex = 46;
            lblStaffName.Text = "ឈ្មោះបុគ្គលិកបុគ្គលិក:";
            // 
            // txtStaffPosition
            // 
            txtStaffPosition.Enabled = false;
            txtStaffPosition.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffPosition.Location = new Point(1229, 140);
            txtStaffPosition.Name = "txtStaffPosition";
            txtStaffPosition.Size = new Size(169, 51);
            txtStaffPosition.TabIndex = 45;
            // 
            // lblStaffPosition
            // 
            lblStaffPosition.AutoSize = true;
            lblStaffPosition.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffPosition.Location = new Point(1070, 147);
            lblStaffPosition.Name = "lblStaffPosition";
            lblStaffPosition.Size = new Size(153, 43);
            lblStaffPosition.TabIndex = 44;
            lblStaffPosition.Text = "តួនាទីបុគ្គលិក:";
            // 
            // lblStaffID
            // 
            lblStaffID.AutoSize = true;
            lblStaffID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffID.Location = new Point(310, 143);
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
            // lblPaymentID
            // 
            lblPaymentID.AutoSize = true;
            lblPaymentID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPaymentID.Location = new Point(18, 41);
            lblPaymentID.Name = "lblPaymentID";
            lblPaymentID.Size = new Size(231, 43);
            lblPaymentID.TabIndex = 34;
            lblPaymentID.Text = "លេខសម្គាល់ការបង់ថ្លៃ:";
            // 
            // cbContractID
            // 
            cbContractID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbContractID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbContractID.FormattingEnabled = true;
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
            // dtpPaymentDate
            // 
            dtpPaymentDate.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpPaymentDate.Format = DateTimePickerFormat.Short;
            dtpPaymentDate.Location = new Point(681, 33);
            dtpPaymentDate.Name = "dtpPaymentDate";
            dtpPaymentDate.Size = new Size(189, 51);
            dtpPaymentDate.TabIndex = 20;
            // 
            // lblPaymentDate
            // 
            lblPaymentDate.AutoSize = true;
            lblPaymentDate.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPaymentDate.Location = new Point(482, 41);
            lblPaymentDate.Name = "lblPaymentDate";
            lblPaymentDate.Size = new Size(193, 43);
            lblPaymentDate.TabIndex = 19;
            lblPaymentDate.Text = "កាលបរិច្ឆេទបង់ថ្លៃ:";
            // 
            // txtPaymentID
            // 
            txtPaymentID.Enabled = false;
            txtPaymentID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPaymentID.Location = new Point(227, 33);
            txtPaymentID.Name = "txtPaymentID";
            txtPaymentID.Size = new Size(217, 51);
            txtPaymentID.TabIndex = 3;
            // 
            // pnlPaymentManipulation
            // 
            pnlPaymentManipulation.Controls.Add(btnCancelPayment);
            pnlPaymentManipulation.Controls.Add(btnNewPayment);
            pnlPaymentManipulation.Controls.Add(btnUpdatePayment);
            pnlPaymentManipulation.Controls.Add(btnInsertPayment);
            pnlPaymentManipulation.Location = new Point(329, 563);
            pnlPaymentManipulation.Name = "pnlPaymentManipulation";
            pnlPaymentManipulation.Size = new Size(1427, 62);
            pnlPaymentManipulation.TabIndex = 5;
            // 
            // btnCancelPayment
            // 
            btnCancelPayment.BackColor = Color.FromArgb(0, 28, 87);
            btnCancelPayment.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelPayment.ForeColor = Color.White;
            btnCancelPayment.Location = new Point(1246, 7);
            btnCancelPayment.Name = "btnCancelPayment";
            btnCancelPayment.Size = new Size(152, 52);
            btnCancelPayment.TabIndex = 3;
            btnCancelPayment.Text = "បោះបង់";
            btnCancelPayment.UseVisualStyleBackColor = false;
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
            pnlLeftSide.Controls.Add(cbSearchPayment);
            pnlLeftSide.Controls.Add(dgvExpenses);
            pnlLeftSide.Controls.Add(lblSearchPayment);
            pnlLeftSide.Location = new Point(266, 643);
            pnlLeftSide.Name = "pnlLeftSide";
            pnlLeftSide.Size = new Size(1800, 354);
            pnlLeftSide.TabIndex = 6;
            // 
            // cbSearchPayment
            // 
            cbSearchPayment.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSearchPayment.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbSearchPayment.FormattingEnabled = true;
            cbSearchPayment.Items.AddRange(new object[] { "ភ្នំពេញ", "តាកែវ" });
            cbSearchPayment.Location = new Point(396, 9);
            cbSearchPayment.Name = "cbSearchPayment";
            cbSearchPayment.Size = new Size(342, 51);
            cbSearchPayment.TabIndex = 41;
            cbSearchPayment.TabStop = false;
            // 
            // dgvExpenses
            // 
            dgvExpenses.AllowUserToAddRows = false;
            dgvExpenses.AllowUserToDeleteRows = false;
            dgvExpenses.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 28, 87);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvExpenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvExpenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpenses.Columns.AddRange(new DataGridViewColumn[] { ExpenseTypeID, Description, UnitPrice, ExpenseTypeQty, Amount });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 28, 87);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvExpenses.DefaultCellStyle = dataGridViewCellStyle2;
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
            ExpenseTypeID.Width = 201;
            // 
            // Description
            // 
            Description.DataPropertyName = "Description";
            Description.HeaderText = "ពិព័ណ៌នាការចំណាយ";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            Description.ReadOnly = true;
            Description.Width = 650;
            // 
            // UnitPrice
            // 
            UnitPrice.DataPropertyName = "UnitPrice";
            UnitPrice.HeaderText = "តម្លៃក្នុងមួយឯកតា";
            UnitPrice.MinimumWidth = 8;
            UnitPrice.Name = "UnitPrice";
            UnitPrice.ReadOnly = true;
            UnitPrice.Width = 230;
            // 
            // ExpenseTypeQty
            // 
            ExpenseTypeQty.DataPropertyName = "ExpenseTypeQty";
            ExpenseTypeQty.HeaderText = "បរិមាណ";
            ExpenseTypeQty.MinimumWidth = 8;
            ExpenseTypeQty.Name = "ExpenseTypeQty";
            ExpenseTypeQty.ReadOnly = true;
            ExpenseTypeQty.Width = 150;
            // 
            // Amount
            // 
            Amount.DataPropertyName = "Amount";
            Amount.HeaderText = "តម្លៃសរុប";
            Amount.MinimumWidth = 8;
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            Amount.Width = 150;
            // 
            // lblSearchPayment
            // 
            lblSearchPayment.AutoSize = true;
            lblSearchPayment.Location = new Point(64, 17);
            lblSearchPayment.Name = "lblSearchPayment";
            lblSearchPayment.Size = new Size(335, 43);
            lblSearchPayment.TabIndex = 1;
            lblSearchPayment.Text = "ស្វែងរក (លេខសម្គាល់ការបង់ថ្លៃ):";
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
        private Label lblExpenseTypeID;
        private GroupBox gbPaymentInformation;
        private DateTimePicker dtpPaymentDate;
        private Label lblPaymentDate;
        private Panel pnlPaymentManipulation;
        private TextBox txtSupplierName;
        private TextBox txtStaffName;
        private Label lblStaffPosition;
        private TextBox txtStaffPosition;
        private Label lblPaymentID;
        private Button btnUpdatePaymentExpenseType;
        private Button btnInsertPaymentExpenseType;
        private Panel pnlLeftSide;
        private Label lblSearchPayment;
        private Label lblPaidAmount;
        private Label lblOwedAmount;
        private TextBox txtTotalAmount;
        private Label lblTotalAmount;
        private Label lblContractID;
        private TextBox txtOwedAmount;
        private GroupBox gbPaymentDetails;
        private TextBox txtPaidAmount;
        private ComboBox cbContractID;
        private Label lblStaffID;
        private Label lblStaffName;
        private Button btnNewPayment;
        private Button btnUpdatePayment;
        private Button btnInsertPayment;
        private ComboBox cbStaffID;
        private Button btnCancelPayment;
        private DataGridView dgvExpenses;
        private ComboBox cbExpenseTypeID;
        private Button btnDeletePaymentExpenseType;
        private Button btnCancelPaymentExpenseType;
        private ComboBox cbSearchPayment;
        private Label label1;
        private Label label3;
        private TextBox txtUnitPrice;
        private Label label2;
        private TextBox txtAmount;
        private Label lblAmount;
        private TextBox txtExpenseTypeQty;
        private DataGridViewTextBoxColumn ExpenseTypeID;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn UnitPrice;
        private DataGridViewTextBoxColumn ExpenseTypeQty;
        private DataGridViewTextBoxColumn Amount;
        private ComboBox cbStoreID;
    }
}