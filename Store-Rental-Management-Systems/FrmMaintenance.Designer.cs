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
            this.gbMaintenanceDetails = new GroupBox();
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
            lblContractID = new Label();
            lblPaidAmount = new Label();
            lblOwedAmount = new Label();
            txtTotalAmount = new TextBox();
            lblTotalAmount = new Label();
            lblMaintenanceID = new Label();
            this.lblStoreID = new Label();
            this.cbContractID = new ComboBox();
            this.txtPaidAmount = new TextBox();
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
            txtOwedAmount = new TextBox();
            cbStoreID = new ComboBox();
            pnlRightSide.SuspendLayout();
            this.gbMaintenanceDetails.SuspendLayout();
            gbMaintenanceInformation.SuspendLayout();
            pnlMaintenanceManipulation.SuspendLayout();
            pnlLeftSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMaintenanceItems).BeginInit();
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
            pnlRightSide.Controls.Add(this.gbMaintenanceDetails);
            pnlRightSide.Controls.Add(gbMaintenanceInformation);
            pnlRightSide.Location = new Point(266, 184);
            pnlRightSide.Name = "pnlRightSide";
            pnlRightSide.Size = new Size(1534, 375);
            pnlRightSide.TabIndex = 4;
            // 
            // gbMaintenanceDetails
            // 
            this.gbMaintenanceDetails.Controls.Add(btnUpdateMaintenanceItem);
            this.gbMaintenanceDetails.Controls.Add(btnInsertMaintenanceItem);
            this.gbMaintenanceDetails.Controls.Add(txtUnit);
            this.gbMaintenanceDetails.Controls.Add(lblUnit);
            this.gbMaintenanceDetails.Controls.Add(txtMaintenanceQty);
            this.gbMaintenanceDetails.Controls.Add(lblItemDescription);
            this.gbMaintenanceDetails.Controls.Add(txtItemDescription);
            this.gbMaintenanceDetails.Controls.Add(txtItemID);
            this.gbMaintenanceDetails.Controls.Add(lblMaintenanceQty);
            this.gbMaintenanceDetails.Controls.Add(lblItemID);
            this.gbMaintenanceDetails.Controls.Add(lblUnitPrice);
            this.gbMaintenanceDetails.Controls.Add(txtCategory);
            this.gbMaintenanceDetails.Controls.Add(txtUnitPrice);
            this.gbMaintenanceDetails.Controls.Add(lblCategory);
            this.gbMaintenanceDetails.Font = new Font("!Khmer OS Siemreap", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            this.gbMaintenanceDetails.Location = new Point(63, 214);
            this.gbMaintenanceDetails.Name = "gbMaintenanceDetails";
            this.gbMaintenanceDetails.Size = new Size(1427, 154);
            this.gbMaintenanceDetails.TabIndex = 26;
            this.gbMaintenanceDetails.TabStop = false;
            this.gbMaintenanceDetails.Text = "សេចក្ដីលម្អិត";
            // 
            // btnUpdateMaintenanceItem
            // 
            btnUpdateMaintenanceItem.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdateMaintenanceItem.Location = new Point(1281, 93);
            btnUpdateMaintenanceItem.Name = "btnUpdateMaintenanceItem";
            btnUpdateMaintenanceItem.Size = new Size(100, 52);
            btnUpdateMaintenanceItem.TabIndex = 4;
            btnUpdateMaintenanceItem.Text = "កែប្រែ";
            btnUpdateMaintenanceItem.UseVisualStyleBackColor = true;
            // 
            // btnInsertMaintenanceItem
            // 
            btnInsertMaintenanceItem.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnInsertMaintenanceItem.Location = new Point(1120, 93);
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
            txtUnit.Location = new Point(1120, 38);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(261, 44);
            txtUnit.TabIndex = 27;
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUnit.Location = new Point(997, 47);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(69, 36);
            lblUnit.TabIndex = 26;
            lblUnit.Text = "ឯកតា:";
            // 
            // txtMaintenanceQty
            // 
            txtMaintenanceQty.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaintenanceQty.Location = new Point(888, 98);
            txtMaintenanceQty.Name = "txtMaintenanceQty";
            txtMaintenanceQty.Size = new Size(196, 44);
            txtMaintenanceQty.TabIndex = 25;
            // 
            // lblItemDescription
            // 
            lblItemDescription.AutoSize = true;
            lblItemDescription.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblItemDescription.Location = new Point(482, 47);
            lblItemDescription.Name = "lblItemDescription";
            lblItemDescription.Size = new Size(190, 36);
            lblItemDescription.TabIndex = 18;
            lblItemDescription.Text = "ពិព័ណ៌នារបស់សម្ភារៈ:";
            // 
            // txtItemDescription
            // 
            txtItemDescription.Enabled = false;
            txtItemDescription.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtItemDescription.Location = new Point(681, 38);
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
            // lblMaintenanceQty
            // 
            lblMaintenanceQty.AutoSize = true;
            lblMaintenanceQty.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMaintenanceQty.Location = new Point(710, 106);
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
            // gbMaintenanceInformation
            // 
            gbMaintenanceInformation.Controls.Add(cbStoreID);
            gbMaintenanceInformation.Controls.Add(txtOwedAmount);
            gbMaintenanceInformation.Controls.Add(lblContractID);
            gbMaintenanceInformation.Controls.Add(lblPaidAmount);
            gbMaintenanceInformation.Controls.Add(lblOwedAmount);
            gbMaintenanceInformation.Controls.Add(txtTotalAmount);
            gbMaintenanceInformation.Controls.Add(lblTotalAmount);
            gbMaintenanceInformation.Controls.Add(lblMaintenanceID);
            gbMaintenanceInformation.Controls.Add(this.lblStoreID);
            gbMaintenanceInformation.Controls.Add(this.cbContractID);
            gbMaintenanceInformation.Controls.Add(this.txtPaidAmount);
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
            // lblContractID
            // 
            lblContractID.AutoSize = true;
            lblContractID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblContractID.Location = new Point(22, 146);
            lblContractID.Name = "lblContractID";
            lblContractID.Size = new Size(196, 36);
            lblContractID.TabIndex = 39;
            lblContractID.Text = "លេខសម្គាល់កិច្ចសន្យា:";
            // 
            // lblPaidAmount
            // 
            lblPaidAmount.AutoSize = true;
            lblPaidAmount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPaidAmount.Location = new Point(482, 88);
            lblPaidAmount.Name = "lblPaidAmount";
            lblPaidAmount.Size = new Size(193, 36);
            lblPaidAmount.TabIndex = 38;
            lblPaidAmount.Text = "ចំនួនទឹកប្រាក់បានបង់:";
            // 
            // lblOwedAmount
            // 
            lblOwedAmount.AutoSize = true;
            lblOwedAmount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblOwedAmount.Location = new Point(905, 88);
            lblOwedAmount.Name = "lblOwedAmount";
            lblOwedAmount.Size = new Size(179, 36);
            lblOwedAmount.TabIndex = 37;
            lblOwedAmount.Text = "ចំនួនទឹកប្រាក់ជំពាក់:";
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotalAmount.Location = new Point(227, 85);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.Size = new Size(217, 44);
            txtTotalAmount.TabIndex = 36;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalAmount.Location = new Point(22, 88);
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
            this.lblStoreID.AutoSize = true;
            this.lblStoreID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            this.lblStoreID.Location = new Point(482, 148);
            this.lblStoreID.Name = "lblStoreID";
            this.lblStoreID.Size = new Size(149, 36);
            this.lblStoreID.TabIndex = 30;
            this.lblStoreID.Text = "លេខសម្គាល់តូប:";
            // 
            // cbContractID
            // 
            this.cbContractID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            this.cbContractID.FormattingEnabled = true;
            this.cbContractID.Items.AddRange(new object[] { "ភ្នំពេញ", "តាកែវ" });
            this.cbContractID.Location = new Point(227, 143);
            this.cbContractID.Name = "cbContractID";
            this.cbContractID.Size = new Size(217, 44);
            this.cbContractID.TabIndex = 29;
            // 
            // txtPaidAmount
            // 
            this.txtPaidAmount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            this.txtPaidAmount.Location = new Point(681, 85);
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.txtPaidAmount.Size = new Size(189, 44);
            this.txtPaidAmount.TabIndex = 28;
            // 
            // dtpMaintenanceDate
            // 
            dtpMaintenanceDate.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpMaintenanceDate.Format = DateTimePickerFormat.Short;
            dtpMaintenanceDate.Location = new Point(960, 35);
            dtpMaintenanceDate.Name = "dtpMaintenanceDate";
            dtpMaintenanceDate.Size = new Size(421, 44);
            dtpMaintenanceDate.TabIndex = 20;
            // 
            // lblMaintenanceDate
            // 
            lblMaintenanceDate.AutoSize = true;
            lblMaintenanceDate.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMaintenanceDate.Location = new Point(760, 39);
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
            txtMaintenanceID.Size = new Size(377, 44);
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
            dgvMaintenanceItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            // txtOwedAmount
            // 
            txtOwedAmount.Enabled = false;
            txtOwedAmount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtOwedAmount.Location = new Point(1109, 88);
            txtOwedAmount.Name = "txtOwedAmount";
            txtOwedAmount.Size = new Size(272, 44);
            txtOwedAmount.TabIndex = 40;
            // 
            // cbStoreID
            // 
            cbStoreID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbStoreID.FormattingEnabled = true;
            cbStoreID.Items.AddRange(new object[] { "ភ្នំពេញ", "តាកែវ" });
            cbStoreID.Location = new Point(681, 143);
            cbStoreID.Name = "cbStoreID";
            cbStoreID.Size = new Size(189, 44);
            cbStoreID.TabIndex = 41;
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
            this.gbMaintenanceDetails.ResumeLayout(false);
            this.gbMaintenanceDetails.PerformLayout();
            gbMaintenanceInformation.ResumeLayout(false);
            gbMaintenanceInformation.PerformLayout();
            pnlMaintenanceManipulation.ResumeLayout(false);
            pnlLeftSide.ResumeLayout(false);
            pnlLeftSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMaintenanceItems).EndInit();
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
        private Label lblStaffName;
        private TextBox txtStaffPosition;
        private Label lblStaffPosition;
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
    }
}