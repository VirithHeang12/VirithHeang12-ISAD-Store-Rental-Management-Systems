namespace Store_Rental_Management_Systems
{
    partial class FrmSalaryPayment
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
            lblSearchSalaryPayment = new Label();
            txtSearchSalaryPayment = new TextBox();
            pnlLeftSide = new Panel();
            dgvSalaryPayments = new DataGridView();
            salaryPaymentBindingSource1 = new BindingSource(components);
            userBindingSource = new BindingSource(components);
            supplierBindingSource = new BindingSource(components);
            itemBindingSource = new BindingSource(components);
            pnlRightSide = new Panel();
            gbSalaryPaymentInformation = new GroupBox();
            dtpSalaryPaymentDate = new DateTimePicker();
            lblStaffPosition = new Label();
            txtStaffPosition = new TextBox();
            txtStaffName = new TextBox();
            lblStaffName = new Label();
            cbStaffID = new ComboBox();
            pnlSalaryPaymentManipulation = new Panel();
            btnCloseFormSalaryPayment = new Button();
            btnNewSalaryPayment = new Button();
            btnUpdateSalaryPayment = new Button();
            btnInsertSalaryPayment = new Button();
            lblStaffID = new Label();
            lblSalaryPaymentID = new Label();
            lblSalaryPaymentDate = new Label();
            txtSalaryPaymentID = new TextBox();
            lblSalaryPaymentAmount = new Label();
            txtSalaryPaymentAmount = new TextBox();
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
            salaryPaymentBindingSource = new BindingSource(components);
            SalaryPaymentID = new DataGridViewTextBoxColumn();
            SalaryPaymentDate = new DataGridViewTextBoxColumn();
            SalaryPaymentAmount = new DataGridViewTextBoxColumn();
            staffIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            staffNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            staffPositionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pnlLeftSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSalaryPayments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)salaryPaymentBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)supplierBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemBindingSource).BeginInit();
            pnlRightSide.SuspendLayout();
            gbSalaryPaymentInformation.SuspendLayout();
            pnlSalaryPaymentManipulation.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)salaryPaymentBindingSource).BeginInit();
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
            lblTitle.Text = "ព័ត៌មានការបើកប្រាក់ខែបុគ្គលិក";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSearchSalaryPayment
            // 
            lblSearchSalaryPayment.AutoSize = true;
            lblSearchSalaryPayment.Location = new Point(82, 29);
            lblSearchSalaryPayment.Name = "lblSearchSalaryPayment";
            lblSearchSalaryPayment.Size = new Size(81, 36);
            lblSearchSalaryPayment.TabIndex = 1;
            lblSearchSalaryPayment.Text = "ស្វែងរក:";
            // 
            // txtSearchSalaryPayment
            // 
            txtSearchSalaryPayment.Location = new Point(196, 21);
            txtSearchSalaryPayment.Name = "txtSearchSalaryPayment";
            txtSearchSalaryPayment.Size = new Size(1248, 44);
            txtSearchSalaryPayment.TabIndex = 2;
            // 
            // pnlLeftSide
            // 
            pnlLeftSide.Controls.Add(dgvSalaryPayments);
            pnlLeftSide.Controls.Add(lblSearchSalaryPayment);
            pnlLeftSide.Controls.Add(txtSearchSalaryPayment);
            pnlLeftSide.Location = new Point(266, 537);
            pnlLeftSide.Name = "pnlLeftSide";
            pnlLeftSide.Size = new Size(1534, 463);
            pnlLeftSide.TabIndex = 3;
            // 
            // dgvSalaryPayments
            // 
            dgvSalaryPayments.AllowUserToAddRows = false;
            dgvSalaryPayments.AllowUserToDeleteRows = false;
            dgvSalaryPayments.AutoGenerateColumns = false;
            dgvSalaryPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSalaryPayments.Columns.AddRange(new DataGridViewColumn[] { SalaryPaymentID, SalaryPaymentDate, SalaryPaymentAmount, staffIDDataGridViewTextBoxColumn, staffNameDataGridViewTextBoxColumn, staffPositionDataGridViewTextBoxColumn });
            dgvSalaryPayments.DataSource = salaryPaymentBindingSource1;
            dgvSalaryPayments.Location = new Point(82, 82);
            dgvSalaryPayments.Name = "dgvSalaryPayments";
            dgvSalaryPayments.ReadOnly = true;
            dgvSalaryPayments.RowHeadersWidth = 51;
            dgvSalaryPayments.RowTemplate.Height = 29;
            dgvSalaryPayments.Size = new Size(1362, 325);
            dgvSalaryPayments.TabIndex = 3;
            // 
            // salaryPaymentBindingSource1
            // 
            salaryPaymentBindingSource1.DataSource = typeof(StoreRentalHelper.entities.SalaryPayment);
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(StoreRentalHelper.entities.User);
            // 
            // supplierBindingSource
            // 
            supplierBindingSource.DataSource = typeof(StoreRentalHelper.entities.Supplier);
            // 
            // itemBindingSource
            // 
            itemBindingSource.DataSource = typeof(StoreRentalHelper.entities.Item);
            // 
            // pnlRightSide
            // 
            pnlRightSide.Controls.Add(gbSalaryPaymentInformation);
            pnlRightSide.Location = new Point(266, 184);
            pnlRightSide.Name = "pnlRightSide";
            pnlRightSide.Size = new Size(1534, 355);
            pnlRightSide.TabIndex = 4;
            // 
            // gbSalaryPaymentInformation
            // 
            gbSalaryPaymentInformation.Controls.Add(dtpSalaryPaymentDate);
            gbSalaryPaymentInformation.Controls.Add(lblStaffPosition);
            gbSalaryPaymentInformation.Controls.Add(txtStaffPosition);
            gbSalaryPaymentInformation.Controls.Add(txtStaffName);
            gbSalaryPaymentInformation.Controls.Add(lblStaffName);
            gbSalaryPaymentInformation.Controls.Add(cbStaffID);
            gbSalaryPaymentInformation.Controls.Add(pnlSalaryPaymentManipulation);
            gbSalaryPaymentInformation.Controls.Add(lblStaffID);
            gbSalaryPaymentInformation.Controls.Add(lblSalaryPaymentID);
            gbSalaryPaymentInformation.Controls.Add(lblSalaryPaymentDate);
            gbSalaryPaymentInformation.Controls.Add(txtSalaryPaymentID);
            gbSalaryPaymentInformation.Controls.Add(lblSalaryPaymentAmount);
            gbSalaryPaymentInformation.Controls.Add(txtSalaryPaymentAmount);
            gbSalaryPaymentInformation.Font = new Font("!Khmer OS Siemreap", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            gbSalaryPaymentInformation.Location = new Point(82, 12);
            gbSalaryPaymentInformation.Name = "gbSalaryPaymentInformation";
            gbSalaryPaymentInformation.Size = new Size(1362, 335);
            gbSalaryPaymentInformation.TabIndex = 25;
            gbSalaryPaymentInformation.TabStop = false;
            gbSalaryPaymentInformation.Text = "ព័ត៌មានការបើកប្រាក់ខែបុគ្គលិក";
            // 
            // dtpSalaryPaymentDate
            // 
            dtpSalaryPaymentDate.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpSalaryPaymentDate.Format = DateTimePickerFormat.Short;
            dtpSalaryPaymentDate.Location = new Point(926, 33);
            dtpSalaryPaymentDate.Name = "dtpSalaryPaymentDate";
            dtpSalaryPaymentDate.Size = new Size(393, 44);
            dtpSalaryPaymentDate.TabIndex = 33;
            // 
            // lblStaffPosition
            // 
            lblStaffPosition.AutoSize = true;
            lblStaffPosition.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffPosition.Location = new Point(711, 185);
            lblStaffPosition.Name = "lblStaffPosition";
            lblStaffPosition.Size = new Size(131, 36);
            lblStaffPosition.TabIndex = 32;
            lblStaffPosition.Text = "តួនាទីបុគ្គលិក:";
            // 
            // txtStaffPosition
            // 
            txtStaffPosition.Enabled = false;
            txtStaffPosition.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffPosition.Location = new Point(926, 177);
            txtStaffPosition.Name = "txtStaffPosition";
            txtStaffPosition.Size = new Size(393, 44);
            txtStaffPosition.TabIndex = 31;
            txtStaffPosition.UseSystemPasswordChar = true;
            // 
            // txtStaffName
            // 
            txtStaffName.Enabled = false;
            txtStaffName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffName.Location = new Point(245, 182);
            txtStaffName.Name = "txtStaffName";
            txtStaffName.Size = new Size(418, 44);
            txtStaffName.TabIndex = 30;
            txtStaffName.UseSystemPasswordChar = true;
            // 
            // lblStaffName
            // 
            lblStaffName.AutoSize = true;
            lblStaffName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffName.Location = new Point(18, 185);
            lblStaffName.Name = "lblStaffName";
            lblStaffName.Size = new Size(130, 36);
            lblStaffName.TabIndex = 29;
            lblStaffName.Text = "ឈ្មោះបុគ្គលិក:";
            // 
            // cbStaffID
            // 
            cbStaffID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbStaffID.FormattingEnabled = true;
            cbStaffID.Items.AddRange(new object[] { "អ្នកគ្រប់គ្រង", "គណនីករ" });
            cbStaffID.Location = new Point(926, 108);
            cbStaffID.Name = "cbStaffID";
            cbStaffID.Size = new Size(393, 44);
            cbStaffID.TabIndex = 28;
            // 
            // pnlSalaryPaymentManipulation
            // 
            pnlSalaryPaymentManipulation.Controls.Add(btnCloseFormSalaryPayment);
            pnlSalaryPaymentManipulation.Controls.Add(btnNewSalaryPayment);
            pnlSalaryPaymentManipulation.Controls.Add(btnUpdateSalaryPayment);
            pnlSalaryPaymentManipulation.Controls.Add(btnInsertSalaryPayment);
            pnlSalaryPaymentManipulation.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pnlSalaryPaymentManipulation.Location = new Point(18, 247);
            pnlSalaryPaymentManipulation.Name = "pnlSalaryPaymentManipulation";
            pnlSalaryPaymentManipulation.Size = new Size(1301, 81);
            pnlSalaryPaymentManipulation.TabIndex = 5;
            // 
            // btnCloseFormSalaryPayment
            // 
            btnCloseFormSalaryPayment.Location = new Point(1102, 20);
            btnCloseFormSalaryPayment.Name = "btnCloseFormSalaryPayment";
            btnCloseFormSalaryPayment.Size = new Size(152, 52);
            btnCloseFormSalaryPayment.TabIndex = 3;
            btnCloseFormSalaryPayment.Text = "បិទ";
            btnCloseFormSalaryPayment.UseVisualStyleBackColor = true;
            // 
            // btnNewSalaryPayment
            // 
            btnNewSalaryPayment.Location = new Point(774, 20);
            btnNewSalaryPayment.Name = "btnNewSalaryPayment";
            btnNewSalaryPayment.Size = new Size(152, 52);
            btnNewSalaryPayment.TabIndex = 2;
            btnNewSalaryPayment.Text = "បង្កើតថ្មី";
            btnNewSalaryPayment.UseVisualStyleBackColor = true;
            // 
            // btnUpdateSalaryPayment
            // 
            btnUpdateSalaryPayment.Location = new Point(411, 20);
            btnUpdateSalaryPayment.Name = "btnUpdateSalaryPayment";
            btnUpdateSalaryPayment.Size = new Size(152, 52);
            btnUpdateSalaryPayment.TabIndex = 1;
            btnUpdateSalaryPayment.Text = "កែប្រែ";
            btnUpdateSalaryPayment.UseVisualStyleBackColor = true;
            // 
            // btnInsertSalaryPayment
            // 
            btnInsertSalaryPayment.Location = new Point(20, 20);
            btnInsertSalaryPayment.Name = "btnInsertSalaryPayment";
            btnInsertSalaryPayment.Size = new Size(152, 52);
            btnInsertSalaryPayment.TabIndex = 0;
            btnInsertSalaryPayment.Text = "បញ្ចូល";
            btnInsertSalaryPayment.UseVisualStyleBackColor = true;
            // 
            // lblStaffID
            // 
            lblStaffID.AutoSize = true;
            lblStaffID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffID.Location = new Point(711, 111);
            lblStaffID.Name = "lblStaffID";
            lblStaffID.Size = new Size(183, 36);
            lblStaffID.TabIndex = 27;
            lblStaffID.Text = "លេខសម្គាល់បុគ្គលិក:";
            // 
            // lblSalaryPaymentID
            // 
            lblSalaryPaymentID.AutoSize = true;
            lblSalaryPaymentID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSalaryPaymentID.Location = new Point(18, 41);
            lblSalaryPaymentID.Name = "lblSalaryPaymentID";
            lblSalaryPaymentID.Size = new Size(241, 36);
            lblSalaryPaymentID.TabIndex = 0;
            lblSalaryPaymentID.Text = "លេខសម្គាល់ការបើកប្រាក់ខែ:";
            // 
            // lblSalaryPaymentDate
            // 
            lblSalaryPaymentDate.AutoSize = true;
            lblSalaryPaymentDate.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSalaryPaymentDate.Location = new Point(711, 41);
            lblSalaryPaymentDate.Name = "lblSalaryPaymentDate";
            lblSalaryPaymentDate.Size = new Size(209, 36);
            lblSalaryPaymentDate.TabIndex = 4;
            lblSalaryPaymentDate.Text = "កាលបរិច្ឆេទបើកប្រាក់ខែ:";
            // 
            // txtSalaryPaymentID
            // 
            txtSalaryPaymentID.Enabled = false;
            txtSalaryPaymentID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSalaryPaymentID.Location = new Point(265, 33);
            txtSalaryPaymentID.Name = "txtSalaryPaymentID";
            txtSalaryPaymentID.Size = new Size(398, 44);
            txtSalaryPaymentID.TabIndex = 3;
            // 
            // lblSalaryPaymentAmount
            // 
            lblSalaryPaymentAmount.AutoSize = true;
            lblSalaryPaymentAmount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSalaryPaymentAmount.Location = new Point(18, 111);
            lblSalaryPaymentAmount.Name = "lblSalaryPaymentAmount";
            lblSalaryPaymentAmount.Size = new Size(131, 36);
            lblSalaryPaymentAmount.TabIndex = 6;
            lblSalaryPaymentAmount.Text = "ចំនួនទឹកប្រាក់:";
            // 
            // txtSalaryPaymentAmount
            // 
            txtSalaryPaymentAmount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSalaryPaymentAmount.Location = new Point(265, 111);
            txtSalaryPaymentAmount.Name = "txtSalaryPaymentAmount";
            txtSalaryPaymentAmount.Size = new Size(398, 44);
            txtSalaryPaymentAmount.TabIndex = 13;
            txtSalaryPaymentAmount.UseSystemPasswordChar = true;
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
            // salaryPaymentBindingSource
            // 
            salaryPaymentBindingSource.DataSource = typeof(StoreRentalHelper.entities.SalaryPayment);
            // 
            // SalaryPaymentID
            // 
            SalaryPaymentID.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            SalaryPaymentID.DataPropertyName = "SalaryPaymentID";
            SalaryPaymentID.HeaderText = "SalaryPaymentID";
            SalaryPaymentID.MinimumWidth = 6;
            SalaryPaymentID.Name = "SalaryPaymentID";
            SalaryPaymentID.ReadOnly = true;
            SalaryPaymentID.Width = 197;
            // 
            // SalaryPaymentDate
            // 
            SalaryPaymentDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            SalaryPaymentDate.DataPropertyName = "SalaryPaymentDate";
            SalaryPaymentDate.HeaderText = "SalaryPaymentDate";
            SalaryPaymentDate.MinimumWidth = 6;
            SalaryPaymentDate.Name = "SalaryPaymentDate";
            SalaryPaymentDate.ReadOnly = true;
            SalaryPaymentDate.Width = 219;
            // 
            // SalaryPaymentAmount
            // 
            SalaryPaymentAmount.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            SalaryPaymentAmount.DataPropertyName = "SalaryPaymentAmount";
            SalaryPaymentAmount.HeaderText = "SalaryPaymentAmount";
            SalaryPaymentAmount.MinimumWidth = 6;
            SalaryPaymentAmount.Name = "SalaryPaymentAmount";
            SalaryPaymentAmount.ReadOnly = true;
            SalaryPaymentAmount.Width = 248;
            // 
            // staffIDDataGridViewTextBoxColumn
            // 
            staffIDDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            staffIDDataGridViewTextBoxColumn.DataPropertyName = "StaffID";
            staffIDDataGridViewTextBoxColumn.HeaderText = "StaffID";
            staffIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
            staffIDDataGridViewTextBoxColumn.ReadOnly = true;
            staffIDDataGridViewTextBoxColumn.Width = 102;
            // 
            // staffNameDataGridViewTextBoxColumn
            // 
            staffNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            staffNameDataGridViewTextBoxColumn.DataPropertyName = "StaffName";
            staffNameDataGridViewTextBoxColumn.HeaderText = "StaffName";
            staffNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            staffNameDataGridViewTextBoxColumn.Name = "staffNameDataGridViewTextBoxColumn";
            staffNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // staffPositionDataGridViewTextBoxColumn
            // 
            staffPositionDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            staffPositionDataGridViewTextBoxColumn.DataPropertyName = "StaffPosition";
            staffPositionDataGridViewTextBoxColumn.HeaderText = "StaffPosition";
            staffPositionDataGridViewTextBoxColumn.MinimumWidth = 6;
            staffPositionDataGridViewTextBoxColumn.Name = "staffPositionDataGridViewTextBoxColumn";
            staffPositionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmSalaryPayment
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1800, 1000);
            ControlBox = true;
            Controls.Add(pnlRightSide);
            Controls.Add(pnlLeftSide);
            Controls.Add(lblTitle);
            Name = "FrmSalaryPayment";
            Text = "ព័ត៌មានបុគ្គលិក";
            Controls.SetChildIndex(lblTitle, 0);
            Controls.SetChildIndex(pnlLeftSide, 0);
            Controls.SetChildIndex(pnlRightSide, 0);
            pnlLeftSide.ResumeLayout(false);
            pnlLeftSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSalaryPayments).EndInit();
            ((System.ComponentModel.ISupportInitialize)salaryPaymentBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)supplierBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemBindingSource).EndInit();
            pnlRightSide.ResumeLayout(false);
            gbSalaryPaymentInformation.ResumeLayout(false);
            gbSalaryPaymentInformation.PerformLayout();
            pnlSalaryPaymentManipulation.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)salaryPaymentBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblSearchSalaryPayment;
        private TextBox txtSearchSalaryPayment;
        private Panel pnlLeftSide;
        private Panel pnlRightSide;
        private Label lblSalaryPaymentID;
        private Label lblSalaryPaymentAmount;
        private Label lblSalaryPaymentDate;
        private TextBox txtSalaryPaymentID;
        private Label lblStockQty;
        private TextBox txtSalaryPaymentAmount;
        private Label lblUnitPrice;
        private GroupBox gbSalaryPaymentInformation;
        private Panel pnlSalaryPaymentManipulation;
        private Button btnInsertSalaryPayment;
        private Button btnCloseFormSalaryPayment;
        private Button btnNewSalaryPayment;
        private Button btnUpdateSalaryPayment;
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
        private TextBox txtStockQty;
        private Label lblStaffID;
        private DataGridView dgvSalaryPayments;
        private BindingSource itemBindingSource;
        private BindingSource supplierBindingSource;
        private Label lblStaffName;
        private ComboBox cbStaffID;
        private Label lblStaffPosition;
        private TextBox txtStaffPosition;
        private TextBox txtStaffName;
        private BindingSource userBindingSource;
        private DateTimePicker dtpSalaryPaymentDate;
        private BindingSource salaryPaymentBindingSource1;
        private BindingSource salaryPaymentBindingSource;
        private DataGridViewTextBoxColumn SalaryPaymentID;
        private DataGridViewTextBoxColumn SalaryPaymentDate;
        private DataGridViewTextBoxColumn SalaryPaymentAmount;
        private DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn staffNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn staffPositionDataGridViewTextBoxColumn;
    }
}