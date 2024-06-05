﻿namespace Store_Rental_Management_Systems
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
            textBox1 = new TextBox();
            label1 = new Label();
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
            pnlStaffManipulation = new Panel();
            btnCloseFormStaff = new Button();
            btnNewStaff = new Button();
            btnUpdateStaff = new Button();
            btnInsertStaff = new Button();
            pnlLeftSide = new Panel();
            dgvImportItems = new DataGridView();
            lblSearchImport = new Label();
            txtSearchImport = new TextBox();
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
            itemBindingSource = new BindingSource(components);
            itemIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            itemDescriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stockQtyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unitPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            pnlRightSide.SuspendLayout();
            gbImportDetails.SuspendLayout();
            gbImportInformation.SuspendLayout();
            pnlStaffManipulation.SuspendLayout();
            pnlLeftSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvImportItems).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)itemBindingSource).BeginInit();
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
            lblUnit.Location = new Point(997, 38);
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
            lblItemDescription.Location = new Point(496, 46);
            lblItemDescription.Name = "lblItemDescription";
            lblItemDescription.Size = new Size(190, 36);
            lblItemDescription.TabIndex = 18;
            lblItemDescription.Text = "ពិព័ណ៌នារបស់សម្ភារៈ:";
            // 
            // txtItemDescription
            // 
            txtItemDescription.Enabled = false;
            txtItemDescription.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtItemDescription.Location = new Point(710, 43);
            txtItemDescription.Name = "txtItemDescription";
            txtItemDescription.Size = new Size(219, 44);
            txtItemDescription.TabIndex = 19;
            // 
            // txtItemID
            // 
            txtItemID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtItemID.Location = new Point(199, 38);
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
            gbImportInformation.Controls.Add(lblStaffID);
            gbImportInformation.Controls.Add(lblSupplierName);
            gbImportInformation.Controls.Add(lblSupplierID);
            gbImportInformation.Controls.Add(textBox1);
            gbImportInformation.Controls.Add(label1);
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
            lblStaffID.Location = new Point(22, 146);
            lblStaffID.Name = "lblStaffID";
            lblStaffID.Size = new Size(183, 36);
            lblStaffID.TabIndex = 39;
            lblStaffID.Text = "លេខសម្គាល់បុគ្គលិក:";
            // 
            // lblSupplierName
            // 
            lblSupplierName.AutoSize = true;
            lblSupplierName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSupplierName.Location = new Point(928, 88);
            lblSupplierName.Name = "lblSupplierName";
            lblSupplierName.Size = new Size(152, 36);
            lblSupplierName.TabIndex = 38;
            lblSupplierName.Text = "ឈ្មោះអ្នកផ្គត់ផ្គង់:";
            // 
            // lblSupplierID
            // 
            lblSupplierID.AutoSize = true;
            lblSupplierID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSupplierID.Location = new Point(496, 88);
            lblSupplierID.Name = "lblSupplierID";
            lblSupplierID.Size = new Size(205, 36);
            lblSupplierID.TabIndex = 37;
            lblSupplierID.Text = "លេខសម្គាល់អ្នកផ្គត់ផ្គង់:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(227, 85);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(235, 44);
            textBox1.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(22, 88);
            label1.Name = "label1";
            label1.Size = new Size(171, 36);
            label1.TabIndex = 35;
            label1.Text = "ចំនួនទឹកប្រាក់សរុប:";
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
            txtStaffPosition.Location = new Point(1109, 145);
            txtStaffPosition.Name = "txtStaffPosition";
            txtStaffPosition.Size = new Size(272, 44);
            txtStaffPosition.TabIndex = 33;
            // 
            // lblStaffPosition
            // 
            lblStaffPosition.AutoSize = true;
            lblStaffPosition.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffPosition.Location = new Point(928, 148);
            lblStaffPosition.Name = "lblStaffPosition";
            lblStaffPosition.Size = new Size(131, 36);
            lblStaffPosition.TabIndex = 32;
            lblStaffPosition.Text = "តួនាទីបុគ្គលិក:";
            // 
            // txtStaffName
            // 
            txtStaffName.Enabled = false;
            txtStaffName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffName.Location = new Point(724, 143);
            txtStaffName.Name = "txtStaffName";
            txtStaffName.Size = new Size(171, 44);
            txtStaffName.TabIndex = 31;
            // 
            // lblStaffName
            // 
            lblStaffName.AutoSize = true;
            lblStaffName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffName.Location = new Point(496, 148);
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
            cbStaffID.Location = new Point(227, 143);
            cbStaffID.Name = "cbStaffID";
            cbStaffID.Size = new Size(235, 44);
            cbStaffID.TabIndex = 29;
            // 
            // txtSupplierName
            // 
            txtSupplierName.Enabled = false;
            txtSupplierName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSupplierName.Location = new Point(1109, 85);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(272, 44);
            txtSupplierName.TabIndex = 28;
            // 
            // cbSupplierID
            // 
            cbSupplierID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbSupplierID.FormattingEnabled = true;
            cbSupplierID.Items.AddRange(new object[] { "ភ្នំពេញ", "តាកែវ" });
            cbSupplierID.Location = new Point(724, 85);
            cbSupplierID.Name = "cbSupplierID";
            cbSupplierID.Size = new Size(171, 44);
            cbSupplierID.TabIndex = 27;
            // 
            // dtpImportDate
            // 
            dtpImportDate.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpImportDate.Format = DateTimePickerFormat.Short;
            dtpImportDate.Location = new Point(724, 35);
            dtpImportDate.Name = "dtpImportDate";
            dtpImportDate.Size = new Size(657, 44);
            dtpImportDate.TabIndex = 20;
            // 
            // lblImportDate
            // 
            lblImportDate.AutoSize = true;
            lblImportDate.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblImportDate.Location = new Point(496, 41);
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
            // pnlStaffManipulation
            // 
            pnlStaffManipulation.Controls.Add(btnCloseFormStaff);
            pnlStaffManipulation.Controls.Add(btnNewStaff);
            pnlStaffManipulation.Controls.Add(btnUpdateStaff);
            pnlStaffManipulation.Controls.Add(btnInsertStaff);
            pnlStaffManipulation.Location = new Point(329, 563);
            pnlStaffManipulation.Name = "pnlStaffManipulation";
            pnlStaffManipulation.Size = new Size(1427, 62);
            pnlStaffManipulation.TabIndex = 5;
            // 
            // btnCloseFormStaff
            // 
            btnCloseFormStaff.BackColor = Color.FromArgb(0, 28, 87);
            btnCloseFormStaff.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCloseFormStaff.ForeColor = Color.White;
            btnCloseFormStaff.Location = new Point(1231, 7);
            btnCloseFormStaff.Name = "btnCloseFormStaff";
            btnCloseFormStaff.Size = new Size(134, 52);
            btnCloseFormStaff.TabIndex = 3;
            btnCloseFormStaff.Text = "បិទ";
            btnCloseFormStaff.UseVisualStyleBackColor = false;
            // 
            // btnNewStaff
            // 
            btnNewStaff.BackColor = Color.FromArgb(0, 28, 87);
            btnNewStaff.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNewStaff.ForeColor = Color.White;
            btnNewStaff.Location = new Point(843, 7);
            btnNewStaff.Name = "btnNewStaff";
            btnNewStaff.Size = new Size(152, 52);
            btnNewStaff.TabIndex = 2;
            btnNewStaff.Text = "បង្កើតថ្មី";
            btnNewStaff.UseVisualStyleBackColor = false;
            // 
            // btnUpdateStaff
            // 
            btnUpdateStaff.BackColor = Color.FromArgb(0, 28, 87);
            btnUpdateStaff.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateStaff.ForeColor = Color.White;
            btnUpdateStaff.Location = new Point(455, 7);
            btnUpdateStaff.Name = "btnUpdateStaff";
            btnUpdateStaff.Size = new Size(152, 52);
            btnUpdateStaff.TabIndex = 1;
            btnUpdateStaff.Text = "កែប្រែ";
            btnUpdateStaff.UseVisualStyleBackColor = false;
            // 
            // btnInsertStaff
            // 
            btnInsertStaff.BackColor = Color.FromArgb(0, 28, 87);
            btnInsertStaff.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsertStaff.ForeColor = Color.White;
            btnInsertStaff.Location = new Point(67, 7);
            btnInsertStaff.Name = "btnInsertStaff";
            btnInsertStaff.Size = new Size(152, 52);
            btnInsertStaff.TabIndex = 0;
            btnInsertStaff.Text = "បញ្ចូល";
            btnInsertStaff.UseVisualStyleBackColor = false;
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
            dgvImportItems.Columns.AddRange(new DataGridViewColumn[] { itemIDDataGridViewTextBoxColumn, itemDescriptionDataGridViewTextBoxColumn, stockQtyDataGridViewTextBoxColumn, unitPriceDataGridViewTextBoxColumn, categoryDataGridViewTextBoxColumn, unitDataGridViewTextBoxColumn, Amount });
            dgvImportItems.DataSource = itemBindingSource;
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
            // itemBindingSource
            // 
            itemBindingSource.DataSource = typeof(StoreRentalHelper.entities.Item);
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
            // itemDescriptionDataGridViewTextBoxColumn
            // 
            itemDescriptionDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            itemDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ItemDescription";
            itemDescriptionDataGridViewTextBoxColumn.HeaderText = "ពិព័ណ៌នារបស់សម្ភារៈ";
            itemDescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            itemDescriptionDataGridViewTextBoxColumn.Name = "itemDescriptionDataGridViewTextBoxColumn";
            itemDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockQtyDataGridViewTextBoxColumn
            // 
            stockQtyDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            stockQtyDataGridViewTextBoxColumn.DataPropertyName = "StockQty";
            stockQtyDataGridViewTextBoxColumn.HeaderText = "បរិមាណនាំចូល";
            stockQtyDataGridViewTextBoxColumn.MinimumWidth = 6;
            stockQtyDataGridViewTextBoxColumn.Name = "stockQtyDataGridViewTextBoxColumn";
            stockQtyDataGridViewTextBoxColumn.ReadOnly = true;
            stockQtyDataGridViewTextBoxColumn.Width = 165;
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
            // categoryDataGridViewTextBoxColumn
            // 
            categoryDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            categoryDataGridViewTextBoxColumn.HeaderText = "ប្រភេទ";
            categoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            categoryDataGridViewTextBoxColumn.ReadOnly = true;
            categoryDataGridViewTextBoxColumn.Width = 98;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            unitDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            unitDataGridViewTextBoxColumn.HeaderText = "ឯកតា";
            unitDataGridViewTextBoxColumn.MinimumWidth = 6;
            unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            unitDataGridViewTextBoxColumn.ReadOnly = true;
            unitDataGridViewTextBoxColumn.Width = 92;
            // 
            // Amount
            // 
            Amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Amount.HeaderText = "តម្លៃ";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            // 
            // FrmImport
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1800, 1000);
            ControlBox = true;
            Controls.Add(pnlLeftSide);
            Controls.Add(pnlStaffManipulation);
            Controls.Add(pnlRightSide);
            Controls.Add(lblTitle);
            Name = "FrmImport";
            Text = "ព័ត៌មានបុគ្គលិក";
            Controls.SetChildIndex(lblTitle, 0);
            Controls.SetChildIndex(pnlRightSide, 0);
            Controls.SetChildIndex(pnlStaffManipulation, 0);
            Controls.SetChildIndex(pnlLeftSide, 0);
            pnlRightSide.ResumeLayout(false);
            gbImportDetails.ResumeLayout(false);
            gbImportDetails.PerformLayout();
            gbImportInformation.ResumeLayout(false);
            gbImportInformation.PerformLayout();
            pnlStaffManipulation.ResumeLayout(false);
            pnlLeftSide.ResumeLayout(false);
            pnlLeftSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvImportItems).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)itemBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Panel pnlRightSide;
        private TextBox txtImportID;
        private DateTimePicker dtpStaffBirthDate;
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
        private RadioButton rdbFemale;
        private RadioButton rdbMale;
        private GroupBox gbImportDetails;
        private PictureBox pbStaffPhoto;
        private Button btnPickStaffPhoto;
        private DateTimePicker dtpImportDate;
        private Label lblImportDate;
        private Panel pnlStaffManipulation;
        private Button btnInsertStaff;
        private Button btnCloseFormStaff;
        private Button btnNewStaff;
        private Button btnUpdateStaff;
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
        private TextBox textBox1;
        private Label label1;
        private Label lblStaffID;
        private BindingSource itemBindingSource;
        private DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn itemDescriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stockQtyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Amount;
    }
}