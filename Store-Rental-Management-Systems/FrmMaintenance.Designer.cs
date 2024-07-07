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
            btnDeleteMaintenanceItem = new Button();
            btnCancelMaintenanceItem = new Button();
            cbItemID = new ComboBox();
            txtAmount = new TextBox();
            lblAmount = new Label();
            btnUpdateMaintenanceItem = new Button();
            btnInsertMaintenanceItem = new Button();
            txtMaintenanceQty = new TextBox();
            lblItemDescription = new Label();
            txtItemDescription = new TextBox();
            lblMaintenanceQty = new Label();
            lblItemID = new Label();
            lblUnitPrice = new Label();
            txtUnitPrice = new TextBox();
            gbMaintenanceInformation = new GroupBox();
            cbStoreID = new ComboBox();
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
            btnCancelMaintenance = new Button();
            btnNewMaintenance = new Button();
            btnUpdateMaintenance = new Button();
            btnInsertMaintenance = new Button();
            pnlLeftSide = new Panel();
            cbSearchMaintenance = new ComboBox();
            dgvMaintenanceItems = new DataGridView();
            lblSearchMaintenance = new Label();
            ItemID = new DataGridViewTextBoxColumn();
            MaintenanceID = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            UnitPrice = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
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
            gbMaintenanceDetails.Controls.Add(btnDeleteMaintenanceItem);
            gbMaintenanceDetails.Controls.Add(btnCancelMaintenanceItem);
            gbMaintenanceDetails.Controls.Add(cbItemID);
            gbMaintenanceDetails.Controls.Add(txtAmount);
            gbMaintenanceDetails.Controls.Add(lblAmount);
            gbMaintenanceDetails.Controls.Add(btnUpdateMaintenanceItem);
            gbMaintenanceDetails.Controls.Add(btnInsertMaintenanceItem);
            gbMaintenanceDetails.Controls.Add(txtMaintenanceQty);
            gbMaintenanceDetails.Controls.Add(lblItemDescription);
            gbMaintenanceDetails.Controls.Add(txtItemDescription);
            gbMaintenanceDetails.Controls.Add(lblMaintenanceQty);
            gbMaintenanceDetails.Controls.Add(lblItemID);
            gbMaintenanceDetails.Controls.Add(lblUnitPrice);
            gbMaintenanceDetails.Controls.Add(txtUnitPrice);
            gbMaintenanceDetails.Font = new Font("!Khmer OS Siemreap", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            gbMaintenanceDetails.Location = new Point(63, 214);
            gbMaintenanceDetails.Name = "gbMaintenanceDetails";
            gbMaintenanceDetails.Size = new Size(1427, 154);
            gbMaintenanceDetails.TabIndex = 26;
            gbMaintenanceDetails.TabStop = false;
            gbMaintenanceDetails.Text = "សេចក្ដីលម្អិត";
            // 
            // btnDeleteMaintenanceItem
            // 
            btnDeleteMaintenanceItem.BackColor = Color.FromArgb(0, 28, 87);
            btnDeleteMaintenanceItem.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteMaintenanceItem.ForeColor = Color.White;
            btnDeleteMaintenanceItem.Location = new Point(1175, 96);
            btnDeleteMaintenanceItem.Name = "btnDeleteMaintenanceItem";
            btnDeleteMaintenanceItem.Size = new Size(102, 52);
            btnDeleteMaintenanceItem.TabIndex = 52;
            btnDeleteMaintenanceItem.TabStop = false;
            btnDeleteMaintenanceItem.Text = "លុប";
            btnDeleteMaintenanceItem.UseVisualStyleBackColor = false;
            // 
            // btnCancelMaintenanceItem
            // 
            btnCancelMaintenanceItem.BackColor = Color.FromArgb(0, 28, 87);
            btnCancelMaintenanceItem.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelMaintenanceItem.ForeColor = Color.White;
            btnCancelMaintenanceItem.Location = new Point(1298, 93);
            btnCancelMaintenanceItem.Name = "btnCancelMaintenanceItem";
            btnCancelMaintenanceItem.Size = new Size(102, 52);
            btnCancelMaintenanceItem.TabIndex = 51;
            btnCancelMaintenanceItem.TabStop = false;
            btnCancelMaintenanceItem.Text = "បោះបង់";
            btnCancelMaintenanceItem.UseVisualStyleBackColor = false;
            // 
            // cbItemID
            // 
            cbItemID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbItemID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbItemID.FormattingEnabled = true;
            cbItemID.Items.AddRange(new object[] { "ភ្នំពេញ", "តាកែវ" });
            cbItemID.Location = new Point(199, 44);
            cbItemID.Name = "cbItemID";
            cbItemID.Size = new Size(161, 44);
            cbItemID.TabIndex = 6;
            // 
            // txtAmount
            // 
            txtAmount.Enabled = false;
            txtAmount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAmount.Location = new Point(888, 98);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(179, 44);
            txtAmount.TabIndex = 30;
            txtAmount.TabStop = false;
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
            // btnUpdateMaintenanceItem
            // 
            btnUpdateMaintenanceItem.BackColor = Color.FromArgb(0, 28, 87);
            btnUpdateMaintenanceItem.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateMaintenanceItem.ForeColor = Color.White;
            btnUpdateMaintenanceItem.Location = new Point(1298, 38);
            btnUpdateMaintenanceItem.Name = "btnUpdateMaintenanceItem";
            btnUpdateMaintenanceItem.Size = new Size(100, 52);
            btnUpdateMaintenanceItem.TabIndex = 4;
            btnUpdateMaintenanceItem.TabStop = false;
            btnUpdateMaintenanceItem.Text = "កែប្រែ";
            btnUpdateMaintenanceItem.UseVisualStyleBackColor = false;
            // 
            // btnInsertMaintenanceItem
            // 
            btnInsertMaintenanceItem.BackColor = Color.FromArgb(0, 28, 87);
            btnInsertMaintenanceItem.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsertMaintenanceItem.ForeColor = Color.White;
            btnInsertMaintenanceItem.Location = new Point(1175, 38);
            btnInsertMaintenanceItem.Name = "btnInsertMaintenanceItem";
            btnInsertMaintenanceItem.Size = new Size(102, 52);
            btnInsertMaintenanceItem.TabIndex = 28;
            btnInsertMaintenanceItem.TabStop = false;
            btnInsertMaintenanceItem.Text = "បញ្ចូល";
            btnInsertMaintenanceItem.UseVisualStyleBackColor = false;
            // 
            // txtMaintenanceQty
            // 
            txtMaintenanceQty.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaintenanceQty.Location = new Point(583, 101);
            txtMaintenanceQty.Name = "txtMaintenanceQty";
            txtMaintenanceQty.Size = new Size(198, 44);
            txtMaintenanceQty.TabIndex = 7;
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
            txtItemDescription.Size = new Size(484, 44);
            txtItemDescription.TabIndex = 19;
            txtItemDescription.TabStop = false;
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
            // txtUnitPrice
            // 
            txtUnitPrice.Enabled = false;
            txtUnitPrice.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUnitPrice.Location = new Point(199, 98);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(163, 44);
            txtUnitPrice.TabIndex = 21;
            txtUnitPrice.TabStop = false;
            // 
            // gbMaintenanceInformation
            // 
            gbMaintenanceInformation.Controls.Add(cbStoreID);
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
            // cbStoreID
            // 
            cbStoreID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStoreID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbStoreID.FormattingEnabled = true;
            cbStoreID.Items.AddRange(new object[] { "ភ្នំពេញ", "តាកែវ" });
            cbStoreID.Location = new Point(184, 140);
            cbStoreID.Name = "cbStoreID";
            cbStoreID.Size = new Size(176, 44);
            cbStoreID.TabIndex = 4;
            // 
            // cbStaffID
            // 
            cbStaffID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStaffID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbStaffID.FormattingEnabled = true;
            cbStaffID.Items.AddRange(new object[] { "ភ្នំពេញ", "តាកែវ" });
            cbStaffID.Location = new Point(576, 140);
            cbStaffID.Name = "cbStaffID";
            cbStaffID.Size = new Size(180, 44);
            cbStaffID.TabIndex = 5;
            // 
            // txtStaffName
            // 
            txtStaffName.Enabled = false;
            txtStaffName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffName.Location = new Point(937, 140);
            txtStaffName.Name = "txtStaffName";
            txtStaffName.Size = new Size(161, 44);
            txtStaffName.TabIndex = 47;
            txtStaffName.TabStop = false;
            // 
            // lblStaffName
            // 
            lblStaffName.AutoSize = true;
            lblStaffName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffName.Location = new Point(785, 143);
            lblStaffName.Name = "lblStaffName";
            lblStaffName.Size = new Size(130, 36);
            lblStaffName.TabIndex = 46;
            lblStaffName.Text = "ឈ្មោះបុគ្គលិក:";
            // 
            // txtStaffPosition
            // 
            txtStaffPosition.Enabled = false;
            txtStaffPosition.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffPosition.Location = new Point(1241, 140);
            txtStaffPosition.Name = "txtStaffPosition";
            txtStaffPosition.Size = new Size(157, 44);
            txtStaffPosition.TabIndex = 45;
            txtStaffPosition.TabStop = false;
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
            lblStaffID.Location = new Point(387, 143);
            lblStaffID.Name = "lblStaffID";
            lblStaffID.Size = new Size(183, 36);
            lblStaffID.TabIndex = 42;
            lblStaffID.Text = "លេខសម្គាល់បុគ្គលិក:";
            // 
            // txtOwedAmount
            // 
            txtOwedAmount.Enabled = false;
            txtOwedAmount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtOwedAmount.Location = new Point(681, 85);
            txtOwedAmount.Name = "txtOwedAmount";
            txtOwedAmount.Size = new Size(189, 44);
            txtOwedAmount.TabIndex = 40;
            txtOwedAmount.TabStop = false;
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
            txtTotalAmount.Enabled = false;
            txtTotalAmount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotalAmount.Location = new Point(1109, 33);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.Size = new Size(289, 44);
            txtTotalAmount.TabIndex = 36;
            txtTotalAmount.TabStop = false;
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
            cbContractID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbContractID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbContractID.FormattingEnabled = true;
            cbContractID.Items.AddRange(new object[] { "ភ្នំពេញ", "តាកែវ" });
            cbContractID.Location = new Point(1109, 85);
            cbContractID.Name = "cbContractID";
            cbContractID.Size = new Size(289, 44);
            cbContractID.TabIndex = 3;
            // 
            // txtPaidAmount
            // 
            txtPaidAmount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPaidAmount.Location = new Point(227, 85);
            txtPaidAmount.Name = "txtPaidAmount";
            txtPaidAmount.Size = new Size(217, 44);
            txtPaidAmount.TabIndex = 2;
            // 
            // dtpMaintenanceDate
            // 
            dtpMaintenanceDate.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpMaintenanceDate.Format = DateTimePickerFormat.Short;
            dtpMaintenanceDate.Location = new Point(681, 33);
            dtpMaintenanceDate.Name = "dtpMaintenanceDate";
            dtpMaintenanceDate.Size = new Size(189, 44);
            dtpMaintenanceDate.TabIndex = 1;
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
            txtMaintenanceID.TabStop = false;
            // 
            // pnlMaintenanceManipulation
            // 
            pnlMaintenanceManipulation.Controls.Add(btnCancelMaintenance);
            pnlMaintenanceManipulation.Controls.Add(btnNewMaintenance);
            pnlMaintenanceManipulation.Controls.Add(btnUpdateMaintenance);
            pnlMaintenanceManipulation.Controls.Add(btnInsertMaintenance);
            pnlMaintenanceManipulation.Location = new Point(329, 563);
            pnlMaintenanceManipulation.Name = "pnlMaintenanceManipulation";
            pnlMaintenanceManipulation.Size = new Size(1427, 62);
            pnlMaintenanceManipulation.TabIndex = 5;
            // 
            // btnCancelMaintenance
            // 
            btnCancelMaintenance.BackColor = Color.FromArgb(0, 28, 87);
            btnCancelMaintenance.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelMaintenance.ForeColor = Color.White;
            btnCancelMaintenance.Location = new Point(1231, 7);
            btnCancelMaintenance.Name = "btnCancelMaintenance";
            btnCancelMaintenance.Size = new Size(134, 52);
            btnCancelMaintenance.TabIndex = 3;
            btnCancelMaintenance.TabStop = false;
            btnCancelMaintenance.Text = "បោះបង់";
            btnCancelMaintenance.UseVisualStyleBackColor = false;
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
            btnNewMaintenance.TabStop = false;
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
            btnUpdateMaintenance.TabStop = false;
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
            btnInsertMaintenance.TabStop = false;
            btnInsertMaintenance.Text = "បញ្ចូល";
            btnInsertMaintenance.UseVisualStyleBackColor = false;
            // 
            // pnlLeftSide
            // 
            pnlLeftSide.Controls.Add(cbSearchMaintenance);
            pnlLeftSide.Controls.Add(dgvMaintenanceItems);
            pnlLeftSide.Controls.Add(lblSearchMaintenance);
            pnlLeftSide.Location = new Point(266, 643);
            pnlLeftSide.Name = "pnlLeftSide";
            pnlLeftSide.Size = new Size(1800, 354);
            pnlLeftSide.TabIndex = 6;
            // 
            // cbSearchMaintenance
            // 
            cbSearchMaintenance.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSearchMaintenance.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbSearchMaintenance.FormattingEnabled = true;
            cbSearchMaintenance.Items.AddRange(new object[] { "ភ្នំពេញ", "តាកែវ" });
            cbSearchMaintenance.Location = new Point(375, 9);
            cbSearchMaintenance.Name = "cbSearchMaintenance";
            cbSearchMaintenance.Size = new Size(469, 44);
            cbSearchMaintenance.TabIndex = 8;
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
            dgvMaintenanceItems.Columns.AddRange(new DataGridViewColumn[] { ItemID, MaintenanceID, Description, UnitPrice, Quantity, Amount });
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
            dgvMaintenanceItems.TabStop = false;
            // 
            // lblSearchMaintenance
            // 
            lblSearchMaintenance.AutoSize = true;
            lblSearchMaintenance.Location = new Point(64, 17);
            lblSearchMaintenance.Name = "lblSearchMaintenance";
            lblSearchMaintenance.Size = new Size(275, 36);
            lblSearchMaintenance.TabIndex = 1;
            lblSearchMaintenance.Text = "ស្វែងរក (លេខសម្គាល់ការថែទាំ):";
            // 
            // ItemID
            // 
            ItemID.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ItemID.DataPropertyName = "ItemID";
            ItemID.HeaderText = "លេខសម្គាល់សម្ភារៈ";
            ItemID.MinimumWidth = 6;
            ItemID.Name = "ItemID";
            ItemID.ReadOnly = true;
            ItemID.Width = 198;
            // 
            // MaintenanceID
            // 
            MaintenanceID.DataPropertyName = "MaintenanceID";
            MaintenanceID.HeaderText = "លេខសម្គាល់ការថែទាំ";
            MaintenanceID.MinimumWidth = 6;
            MaintenanceID.Name = "MaintenanceID";
            MaintenanceID.ReadOnly = true;
            MaintenanceID.Visible = false;
            MaintenanceID.Width = 125;
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
            UnitPrice.Width = 188;
            // 
            // Quantity
            // 
            Quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Quantity.DataPropertyName = "Quantity";
            Quantity.HeaderText = "បរិមាណប្រើប្រាស់";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            Quantity.Width = 183;
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
        private TextBox txtUnitPrice;
        private Label lblUnitPrice;
        private GroupBox gbMaintenanceInformation;
        private GroupBox gbImportDetails;
        private DateTimePicker dtpMaintenanceDate;
        private Label lblMaintenanceDate;
        private Panel pnlMaintenanceManipulation;
        private Button btnInsertMaintenance;
        private Button btnCancelMaintenance;
        private Button btnNewMaintenance;
        private Button btnUpdateMaintenance;
        private TextBox txtStaffName;
        private Label lblStaffPosition;
        private TextBox txtStaffPosition;
        private Label lblMaintenanceID;
        private TextBox txtMaintenanceQty;
        private Button btnUpdateMaintenanceItem;
        private Button btnInsertMaintenanceItem;
        private Panel pnlLeftSide;
        private DataGridView dgvMaintenanceItems;
        private Label lblSearchMaintenance;
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
        private ComboBox cbItemID;
        private Button btnDeleteMaintenanceItem;
        private Button btnCancelMaintenanceItem;
        private ComboBox cbStoreID;
        private ComboBox cbSearchMaintenance;
        private DataGridViewTextBoxColumn ItemID;
        private DataGridViewTextBoxColumn MaintenanceID;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn UnitPrice;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Amount;
    }
}