namespace Store_Rental_Management_Systems
{
    partial class FrmAppointment
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
            gbStaffAssignments = new GroupBox();
            btnUpdateAppointmentStaff = new Button();
            btnInsertAppointmentStaff = new Button();
            lblStaffPosition = new Label();
            txtStaffPosition = new TextBox();
            lblStaffName = new Label();
            txtStaffName = new TextBox();
            lblStaffID = new Label();
            txtStaffID = new TextBox();
            gbAppointmentInformation = new GroupBox();
            lblAppointmentID = new Label();
            cbAppointmentStatus = new ComboBox();
            dtpAppointmentDate = new DateTimePicker();
            lblAppointmentDate = new Label();
            lblAppointmentStatus = new Label();
            txtAppointmentID = new TextBox();
            lblCustomerID = new Label();
            pnlStaffManipulation = new Panel();
            btnCloseFormStaff = new Button();
            btnNewStaff = new Button();
            btnUpdateStaff = new Button();
            btnInsertStaff = new Button();
            pnlLeftSide = new Panel();
            dgvStaffAssignments = new DataGridView();
            staffBindingSource = new BindingSource(components);
            lblSearchAppointment = new Label();
            txtSearchAppointment = new TextBox();
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
            cbCustomerID = new ComboBox();
            staffIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fullNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            staffPositionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pnlRightSide.SuspendLayout();
            gbStaffAssignments.SuspendLayout();
            gbAppointmentInformation.SuspendLayout();
            pnlStaffManipulation.SuspendLayout();
            pnlLeftSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStaffAssignments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)staffBindingSource).BeginInit();
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
            lblTitle.BackColor = Color.FromArgb(0, 28, 87);
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("!Khmer OS Siemreap", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(266, 80);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1534, 101);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ព័ត៌មានការណាត់ជួបពិភាក្សា";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlRightSide
            // 
            pnlRightSide.Controls.Add(gbStaffAssignments);
            pnlRightSide.Controls.Add(gbAppointmentInformation);
            pnlRightSide.Location = new Point(266, 184);
            pnlRightSide.Name = "pnlRightSide";
            pnlRightSide.Size = new Size(1534, 409);
            pnlRightSide.TabIndex = 4;
            // 
            // gbStaffAssignments
            // 
            gbStaffAssignments.Controls.Add(btnUpdateAppointmentStaff);
            gbStaffAssignments.Controls.Add(btnInsertAppointmentStaff);
            gbStaffAssignments.Controls.Add(lblStaffPosition);
            gbStaffAssignments.Controls.Add(txtStaffPosition);
            gbStaffAssignments.Controls.Add(lblStaffName);
            gbStaffAssignments.Controls.Add(txtStaffName);
            gbStaffAssignments.Controls.Add(lblStaffID);
            gbStaffAssignments.Controls.Add(txtStaffID);
            gbStaffAssignments.Font = new Font("!Khmer OS Siemreap", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            gbStaffAssignments.Location = new Point(63, 164);
            gbStaffAssignments.Name = "gbStaffAssignments";
            gbStaffAssignments.Size = new Size(1427, 147);
            gbStaffAssignments.TabIndex = 27;
            gbStaffAssignments.TabStop = false;
            gbStaffAssignments.Text = "សេចក្ដីលម្អិត";
            // 
            // btnUpdateAppointmentStaff
            // 
            btnUpdateAppointmentStaff.BackColor = Color.FromArgb(0, 28, 87);
            btnUpdateAppointmentStaff.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateAppointmentStaff.ForeColor = Color.White;
            btnUpdateAppointmentStaff.Location = new Point(1265, 95);
            btnUpdateAppointmentStaff.Name = "btnUpdateAppointmentStaff";
            btnUpdateAppointmentStaff.Size = new Size(116, 46);
            btnUpdateAppointmentStaff.TabIndex = 24;
            btnUpdateAppointmentStaff.Text = "កែប្រែ";
            btnUpdateAppointmentStaff.UseVisualStyleBackColor = false;
            // 
            // btnInsertAppointmentStaff
            // 
            btnInsertAppointmentStaff.BackColor = Color.FromArgb(0, 28, 87);
            btnInsertAppointmentStaff.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsertAppointmentStaff.ForeColor = Color.White;
            btnInsertAppointmentStaff.Location = new Point(1084, 95);
            btnInsertAppointmentStaff.Name = "btnInsertAppointmentStaff";
            btnInsertAppointmentStaff.Size = new Size(118, 46);
            btnInsertAppointmentStaff.TabIndex = 23;
            btnInsertAppointmentStaff.Text = "បញ្ចូល";
            btnInsertAppointmentStaff.UseVisualStyleBackColor = false;
            // 
            // lblStaffPosition
            // 
            lblStaffPosition.AutoSize = true;
            lblStaffPosition.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffPosition.Location = new Point(922, 46);
            lblStaffPosition.Name = "lblStaffPosition";
            lblStaffPosition.Size = new Size(131, 36);
            lblStaffPosition.TabIndex = 22;
            lblStaffPosition.Text = "តួនាទីបុគ្គលិក:";
            // 
            // txtStaffPosition
            // 
            txtStaffPosition.Enabled = false;
            txtStaffPosition.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffPosition.Location = new Point(1084, 43);
            txtStaffPosition.Name = "txtStaffPosition";
            txtStaffPosition.Size = new Size(297, 44);
            txtStaffPosition.TabIndex = 21;
            // 
            // lblStaffName
            // 
            lblStaffName.AutoSize = true;
            lblStaffName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffName.Location = new Point(502, 46);
            lblStaffName.Name = "lblStaffName";
            lblStaffName.Size = new Size(130, 36);
            lblStaffName.TabIndex = 20;
            lblStaffName.Text = "ឈ្មោះបុគ្គលិក:";
            // 
            // txtStaffName
            // 
            txtStaffName.Enabled = false;
            txtStaffName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffName.Location = new Point(649, 43);
            txtStaffName.Name = "txtStaffName";
            txtStaffName.Size = new Size(237, 44);
            txtStaffName.TabIndex = 19;
            // 
            // lblStaffID
            // 
            lblStaffID.AutoSize = true;
            lblStaffID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffID.Location = new Point(18, 46);
            lblStaffID.Name = "lblStaffID";
            lblStaffID.Size = new Size(183, 36);
            lblStaffID.TabIndex = 18;
            lblStaffID.Text = "លេខសម្គាល់បុគ្គលិក:";
            // 
            // txtStaffID
            // 
            txtStaffID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffID.Location = new Point(223, 43);
            txtStaffID.Name = "txtStaffID";
            txtStaffID.Size = new Size(237, 44);
            txtStaffID.TabIndex = 17;
            // 
            // gbAppointmentInformation
            // 
            gbAppointmentInformation.Controls.Add(cbCustomerID);
            gbAppointmentInformation.Controls.Add(lblAppointmentID);
            gbAppointmentInformation.Controls.Add(cbAppointmentStatus);
            gbAppointmentInformation.Controls.Add(dtpAppointmentDate);
            gbAppointmentInformation.Controls.Add(lblAppointmentDate);
            gbAppointmentInformation.Controls.Add(lblAppointmentStatus);
            gbAppointmentInformation.Controls.Add(txtAppointmentID);
            gbAppointmentInformation.Controls.Add(lblCustomerID);
            gbAppointmentInformation.Font = new Font("!Khmer OS Siemreap", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            gbAppointmentInformation.Location = new Point(64, 4);
            gbAppointmentInformation.Name = "gbAppointmentInformation";
            gbAppointmentInformation.Size = new Size(1427, 155);
            gbAppointmentInformation.TabIndex = 25;
            gbAppointmentInformation.TabStop = false;
            gbAppointmentInformation.Text = "ព័ត៌មានការណាត់ជួបពិភាក្សា";
            // 
            // lblAppointmentID
            // 
            lblAppointmentID.AutoSize = true;
            lblAppointmentID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAppointmentID.Location = new Point(18, 41);
            lblAppointmentID.Name = "lblAppointmentID";
            lblAppointmentID.Size = new Size(223, 36);
            lblAppointmentID.TabIndex = 34;
            lblAppointmentID.Text = "លេខសម្គាល់ការណាត់ជួប:";
            // 
            // cbAppointmentStatus
            // 
            cbAppointmentStatus.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbAppointmentStatus.FormattingEnabled = true;
            cbAppointmentStatus.Items.AddRange(new object[] { "ភ្នំពេញ", "តាកែវ" });
            cbAppointmentStatus.Location = new Point(261, 95);
            cbAppointmentStatus.Name = "cbAppointmentStatus";
            cbAppointmentStatus.Size = new Size(371, 44);
            cbAppointmentStatus.TabIndex = 27;
            // 
            // dtpAppointmentDate
            // 
            dtpAppointmentDate.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpAppointmentDate.Format = DateTimePickerFormat.Short;
            dtpAppointmentDate.Location = new Point(960, 35);
            dtpAppointmentDate.Name = "dtpAppointmentDate";
            dtpAppointmentDate.Size = new Size(421, 44);
            dtpAppointmentDate.TabIndex = 20;
            // 
            // lblAppointmentDate
            // 
            lblAppointmentDate.AutoSize = true;
            lblAppointmentDate.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAppointmentDate.Location = new Point(760, 39);
            lblAppointmentDate.Name = "lblAppointmentDate";
            lblAppointmentDate.Size = new Size(191, 36);
            lblAppointmentDate.TabIndex = 19;
            lblAppointmentDate.Text = "កាលបរិច្ឆេទណាត់ជួប:";
            // 
            // lblAppointmentStatus
            // 
            lblAppointmentStatus.AutoSize = true;
            lblAppointmentStatus.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAppointmentStatus.Location = new Point(19, 98);
            lblAppointmentStatus.Name = "lblAppointmentStatus";
            lblAppointmentStatus.Size = new Size(171, 36);
            lblAppointmentStatus.TabIndex = 4;
            lblAppointmentStatus.Text = "ស្ថានភាពណាត់ជួប:";
            // 
            // txtAppointmentID
            // 
            txtAppointmentID.Enabled = false;
            txtAppointmentID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAppointmentID.Location = new Point(261, 33);
            txtAppointmentID.Name = "txtAppointmentID";
            txtAppointmentID.Size = new Size(371, 44);
            txtAppointmentID.TabIndex = 3;
            // 
            // lblCustomerID
            // 
            lblCustomerID.AutoSize = true;
            lblCustomerID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCustomerID.Location = new Point(760, 98);
            lblCustomerID.Name = "lblCustomerID";
            lblCustomerID.Size = new Size(191, 36);
            lblCustomerID.TabIndex = 6;
            lblCustomerID.Text = "លេខសម្គាល់អតិថិជន:";
            // 
            // pnlStaffManipulation
            // 
            pnlStaffManipulation.Controls.Add(btnCloseFormStaff);
            pnlStaffManipulation.Controls.Add(btnNewStaff);
            pnlStaffManipulation.Controls.Add(btnUpdateStaff);
            pnlStaffManipulation.Controls.Add(btnInsertStaff);
            pnlStaffManipulation.Location = new Point(329, 501);
            pnlStaffManipulation.Name = "pnlStaffManipulation";
            pnlStaffManipulation.Size = new Size(1427, 57);
            pnlStaffManipulation.TabIndex = 5;
            // 
            // btnCloseFormStaff
            // 
            btnCloseFormStaff.BackColor = Color.FromArgb(0, 28, 87);
            btnCloseFormStaff.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCloseFormStaff.ForeColor = Color.White;
            btnCloseFormStaff.Location = new Point(1228, 0);
            btnCloseFormStaff.Name = "btnCloseFormStaff";
            btnCloseFormStaff.Size = new Size(152, 52);
            btnCloseFormStaff.TabIndex = 3;
            btnCloseFormStaff.Text = "បិទ";
            btnCloseFormStaff.UseVisualStyleBackColor = false;
            // 
            // btnNewStaff
            // 
            btnNewStaff.BackColor = Color.FromArgb(0, 28, 87);
            btnNewStaff.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNewStaff.ForeColor = Color.White;
            btnNewStaff.Location = new Point(835, 3);
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
            btnUpdateStaff.Location = new Point(442, 3);
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
            btnInsertStaff.Location = new Point(49, 0);
            btnInsertStaff.Name = "btnInsertStaff";
            btnInsertStaff.Size = new Size(152, 52);
            btnInsertStaff.TabIndex = 0;
            btnInsertStaff.Text = "បញ្ចូល";
            btnInsertStaff.UseVisualStyleBackColor = false;
            // 
            // pnlLeftSide
            // 
            pnlLeftSide.Controls.Add(dgvStaffAssignments);
            pnlLeftSide.Controls.Add(lblSearchAppointment);
            pnlLeftSide.Controls.Add(txtSearchAppointment);
            pnlLeftSide.Location = new Point(266, 579);
            pnlLeftSide.Name = "pnlLeftSide";
            pnlLeftSide.Size = new Size(1800, 418);
            pnlLeftSide.TabIndex = 6;
            // 
            // dgvStaffAssignments
            // 
            dgvStaffAssignments.AllowUserToAddRows = false;
            dgvStaffAssignments.AllowUserToDeleteRows = false;
            dgvStaffAssignments.AutoGenerateColumns = false;
            dgvStaffAssignments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStaffAssignments.Columns.AddRange(new DataGridViewColumn[] { staffIDDataGridViewTextBoxColumn, fullNameDataGridViewTextBoxColumn, staffPositionDataGridViewTextBoxColumn });
            dgvStaffAssignments.DataSource = staffBindingSource;
            dgvStaffAssignments.Location = new Point(63, 74);
            dgvStaffAssignments.Name = "dgvStaffAssignments";
            dgvStaffAssignments.ReadOnly = true;
            dgvStaffAssignments.RowHeadersWidth = 51;
            dgvStaffAssignments.RowTemplate.Height = 29;
            dgvStaffAssignments.Size = new Size(1428, 303);
            dgvStaffAssignments.TabIndex = 3;
            // 
            // staffBindingSource
            // 
            staffBindingSource.DataSource = typeof(StoreRentalHelper.entities.Staff);
            // 
            // lblSearchAppointment
            // 
            lblSearchAppointment.AutoSize = true;
            lblSearchAppointment.Location = new Point(64, 17);
            lblSearchAppointment.Name = "lblSearchAppointment";
            lblSearchAppointment.Size = new Size(311, 36);
            lblSearchAppointment.TabIndex = 1;
            lblSearchAppointment.Text = "ស្វែងរក (លេខសម្គាល់ការណាត់ជួប):";
            // 
            // txtSearchAppointment
            // 
            txtSearchAppointment.Location = new Point(402, 11);
            txtSearchAppointment.Name = "txtSearchAppointment";
            txtSearchAppointment.Size = new Size(501, 44);
            txtSearchAppointment.TabIndex = 2;
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
            // cbCustomerID
            // 
            cbCustomerID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbCustomerID.FormattingEnabled = true;
            cbCustomerID.Items.AddRange(new object[] { "ភ្នំពេញ", "តាកែវ" });
            cbCustomerID.Location = new Point(960, 95);
            cbCustomerID.Name = "cbCustomerID";
            cbCustomerID.Size = new Size(421, 44);
            cbCustomerID.TabIndex = 35;
            // 
            // staffIDDataGridViewTextBoxColumn
            // 
            staffIDDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            staffIDDataGridViewTextBoxColumn.DataPropertyName = "StaffID";
            staffIDDataGridViewTextBoxColumn.HeaderText = "លេខសម្គាល់បុគ្គលិក";
            staffIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
            staffIDDataGridViewTextBoxColumn.ReadOnly = true;
            staffIDDataGridViewTextBoxColumn.Width = 206;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            fullNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            fullNameDataGridViewTextBoxColumn.HeaderText = "ឈ្មោះបុគ្គលិក";
            fullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // staffPositionDataGridViewTextBoxColumn
            // 
            staffPositionDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            staffPositionDataGridViewTextBoxColumn.DataPropertyName = "StaffPosition";
            staffPositionDataGridViewTextBoxColumn.HeaderText = "តួនាទីបុគ្គលិក";
            staffPositionDataGridViewTextBoxColumn.MinimumWidth = 6;
            staffPositionDataGridViewTextBoxColumn.Name = "staffPositionDataGridViewTextBoxColumn";
            staffPositionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmAppointment
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1800, 1000);
            ControlBox = true;
            Controls.Add(pnlLeftSide);
            Controls.Add(pnlStaffManipulation);
            Controls.Add(pnlRightSide);
            Controls.Add(lblTitle);
            Name = "FrmAppointment";
            Text = "ព័ត៌មានបុគ្គលិក";
            Controls.SetChildIndex(lblTitle, 0);
            Controls.SetChildIndex(pnlRightSide, 0);
            Controls.SetChildIndex(pnlStaffManipulation, 0);
            Controls.SetChildIndex(pnlLeftSide, 0);
            pnlRightSide.ResumeLayout(false);
            gbStaffAssignments.ResumeLayout(false);
            gbStaffAssignments.PerformLayout();
            gbAppointmentInformation.ResumeLayout(false);
            gbAppointmentInformation.PerformLayout();
            pnlStaffManipulation.ResumeLayout(false);
            pnlLeftSide.ResumeLayout(false);
            pnlLeftSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStaffAssignments).EndInit();
            ((System.ComponentModel.ISupportInitialize)staffBindingSource).EndInit();
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
        private Label lblSearchStaff;
        private TextBox txtSearchStaff;
        private ListBox lbStaff;
        private Panel pnlRightSide;
        private Label lblSupplierName;
        private Label lblCustomerID;
        private TextBox txtTotalAmount;
        private Label lblAppointmentStatus;
        private TextBox txtAppointmentID;
        private DateTimePicker dtpStaffBirthDate;
        private TextBox txtItemDescription;
        private Label lblItemDescription;
        private TextBox txtStaffID;
        private Label lblItemID;
        private Label lblImportQty;
        private Label lblCategory;
        private TextBox txtUnitPrice;
        private Label lblUnitPrice;
        private TextBox txtCategory;
        private GroupBox gbAppointmentInformation;
        private RadioButton rdbFemale;
        private RadioButton rdbMale;
        private GroupBox gbStaffAssignments;
        private PictureBox pbStaffPhoto;
        private Button btnPickStaffPhoto;
        private DateTimePicker dtpAppointmentDate;
        private Label lblAppointmentDate;
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
        private ComboBox cbAppointmentStatus;
        private TextBox txtSupplierName;
        private ComboBox cbStaffID;
        private Label lblAppointmentID;
        private TextBox txtImportQty;
        private Button btnUpdateImportItem;
        private Panel pnlLeftSide;
        private DataGridView dgvStaffAssignments;
        private Label lblSearchAppointment;
        private TextBox txtSearchAppointment;
        private BindingSource staffBindingSource;
        private Button btnInsertImportItem;
        private TextBox txtUnit;
        private Label lblUnit;
        private Label lblStaffID;
        private Label lblStaffName;
        private TextBox txtStaffName;
        private Label lblStaffPosition;
        private TextBox txtStaffPosition;
        private Button btnUpdateAppointmentStaff;
        private Button btnInsertAppointmentStaff;
        private ComboBox cbCustomerID;
        private DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn staffPositionDataGridViewTextBoxColumn;
    }
}