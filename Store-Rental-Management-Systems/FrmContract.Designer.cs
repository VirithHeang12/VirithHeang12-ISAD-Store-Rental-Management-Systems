namespace Store_Rental_Management_Systems
{
    partial class FrmContract
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
            lblSearchContract = new Label();
            txtSearchContract = new TextBox();
            pnlLeftSide = new Panel();
            lbContract = new ListBox();
            pnlRightSide = new Panel();
            gbContractInformation = new GroupBox();
            lblStaffPosition = new Label();
            lblStaffName = new Label();
            txtInsuranceName = new TextBox();
            lblInsuranceName = new Label();
            this.cbStoreID = new ComboBox();
            lblContractID = new Label();
            this.lblStoreID = new Label();
            txtContractID = new TextBox();
            this.lblContractDate = new Label();
            dtpContractDate = new DateTimePicker();
            lblCustomerID = new Label();
            pnlContractManipulation = new Panel();
            btnCloseFormContract = new Button();
            btnNewContract = new Button();
            btnUpdateContract = new Button();
            btnInsertContract = new Button();
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
            this.lblLeaseStartDate = new Label();
            dtpLeaseStartDate = new DateTimePicker();
            this.lblLeaseEndDate = new Label();
            this.dtpLeaseEndDate = new DateTimePicker();
            lblNextPaymentDate = new Label();
            dtpNextPaymentDate = new DateTimePicker();
            cbCustomerID = new ComboBox();
            lblInsuranceID = new Label();
            cbInsuranceID = new ComboBox();
            lblStaffID = new Label();
            cbStaffID = new ComboBox();
            txtStaffName = new TextBox();
            txtStaffPosition = new TextBox();
            pnlLeftSide.SuspendLayout();
            pnlRightSide.SuspendLayout();
            gbContractInformation.SuspendLayout();
            pnlContractManipulation.SuspendLayout();
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
            lblTitle.Text = "ព័ត៌មានកិច្ចសន្យា";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSearchContract
            // 
            lblSearchContract.AutoSize = true;
            lblSearchContract.Location = new Point(21, 11);
            lblSearchContract.Name = "lblSearchContract";
            lblSearchContract.Size = new Size(81, 36);
            lblSearchContract.TabIndex = 1;
            lblSearchContract.Text = "ស្វែងរក:";
            // 
            // txtSearchContract
            // 
            txtSearchContract.Location = new Point(21, 50);
            txtSearchContract.Name = "txtSearchContract";
            txtSearchContract.Size = new Size(319, 44);
            txtSearchContract.TabIndex = 2;
            // 
            // pnlLeftSide
            // 
            pnlLeftSide.Controls.Add(lbContract);
            pnlLeftSide.Controls.Add(lblSearchContract);
            pnlLeftSide.Controls.Add(txtSearchContract);
            pnlLeftSide.Location = new Point(272, 272);
            pnlLeftSide.Name = "pnlLeftSide";
            pnlLeftSide.Size = new Size(364, 636);
            pnlLeftSide.TabIndex = 3;
            // 
            // lbContract
            // 
            lbContract.FormattingEnabled = true;
            lbContract.ItemHeight = 36;
            lbContract.Location = new Point(21, 114);
            lbContract.Name = "lbContract";
            lbContract.Size = new Size(319, 472);
            lbContract.TabIndex = 3;
            // 
            // pnlRightSide
            // 
            pnlRightSide.Controls.Add(pnlContractManipulation);
            pnlRightSide.Controls.Add(gbContractInformation);
            pnlRightSide.Location = new Point(662, 272);
            pnlRightSide.Name = "pnlRightSide";
            pnlRightSide.Size = new Size(1147, 636);
            pnlRightSide.TabIndex = 4;
            // 
            // gbContractInformation
            // 
            gbContractInformation.Controls.Add(txtStaffPosition);
            gbContractInformation.Controls.Add(txtStaffName);
            gbContractInformation.Controls.Add(cbStaffID);
            gbContractInformation.Controls.Add(lblStaffID);
            gbContractInformation.Controls.Add(cbInsuranceID);
            gbContractInformation.Controls.Add(lblInsuranceID);
            gbContractInformation.Controls.Add(cbCustomerID);
            gbContractInformation.Controls.Add(dtpNextPaymentDate);
            gbContractInformation.Controls.Add(lblNextPaymentDate);
            gbContractInformation.Controls.Add(this.dtpLeaseEndDate);
            gbContractInformation.Controls.Add(this.lblLeaseEndDate);
            gbContractInformation.Controls.Add(dtpLeaseStartDate);
            gbContractInformation.Controls.Add(this.lblLeaseStartDate);
            gbContractInformation.Controls.Add(lblStaffPosition);
            gbContractInformation.Controls.Add(lblStaffName);
            gbContractInformation.Controls.Add(txtInsuranceName);
            gbContractInformation.Controls.Add(lblInsuranceName);
            gbContractInformation.Controls.Add(this.cbStoreID);
            gbContractInformation.Controls.Add(lblContractID);
            gbContractInformation.Controls.Add(this.lblStoreID);
            gbContractInformation.Controls.Add(txtContractID);
            gbContractInformation.Controls.Add(this.lblContractDate);
            gbContractInformation.Controls.Add(dtpContractDate);
            gbContractInformation.Controls.Add(lblCustomerID);
            gbContractInformation.Font = new Font("!Khmer OS Siemreap", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            gbContractInformation.Location = new Point(45, 32);
            gbContractInformation.Name = "gbContractInformation";
            gbContractInformation.Size = new Size(1069, 409);
            gbContractInformation.TabIndex = 25;
            gbContractInformation.TabStop = false;
            gbContractInformation.Text = "ព័ត៌មានកិច្ចសន្យា";
            // 
            // lblStaffPosition
            // 
            lblStaffPosition.AutoSize = true;
            lblStaffPosition.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffPosition.Location = new Point(513, 341);
            lblStaffPosition.Name = "lblStaffPosition";
            lblStaffPosition.Size = new Size(131, 36);
            lblStaffPosition.TabIndex = 23;
            lblStaffPosition.Text = "តួនាទីបុគ្គលិក:";
            // 
            // lblStaffName
            // 
            lblStaffName.AutoSize = true;
            lblStaffName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffName.Location = new Point(18, 341);
            lblStaffName.Name = "lblStaffName";
            lblStaffName.Size = new Size(130, 36);
            lblStaffName.TabIndex = 21;
            lblStaffName.Text = "ឈ្មោះបុគ្គលិក:";
            // 
            // txtInsuranceName
            // 
            txtInsuranceName.Enabled = false;
            txtInsuranceName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtInsuranceName.Location = new Point(256, 276);
            txtInsuranceName.Name = "txtInsuranceName";
            txtInsuranceName.Size = new Size(242, 44);
            txtInsuranceName.TabIndex = 17;
            // 
            // lblInsuranceName
            // 
            lblInsuranceName.AutoSize = true;
            lblInsuranceName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblInsuranceName.Location = new Point(19, 279);
            lblInsuranceName.Name = "lblInsuranceName";
            lblInsuranceName.Size = new Size(223, 36);
            lblInsuranceName.TabIndex = 16;
            lblInsuranceName.Text = "ឈ្មោះក្រុមហ៊ុនធានារ៉ាប់រង:";
            // 
            // cbStoreID
            // 
            this.cbStoreID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            this.cbStoreID.FormattingEnabled = true;
            this.cbStoreID.Items.AddRange(new object[] { "អ្នកគ្រប់គ្រង", "គណនីករ" });
            this.cbStoreID.Location = new Point(761, 154);
            this.cbStoreID.Name = "cbStoreID";
            this.cbStoreID.Size = new Size(264, 44);
            this.cbStoreID.TabIndex = 15;
            // 
            // lblContractID
            // 
            lblContractID.AutoSize = true;
            lblContractID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblContractID.Location = new Point(18, 41);
            lblContractID.Name = "lblContractID";
            lblContractID.Size = new Size(196, 36);
            lblContractID.TabIndex = 0;
            lblContractID.Text = "លេខសម្គាល់កិច្ចសន្យា:";
            // 
            // lblStoreID
            // 
            this.lblStoreID.AutoSize = true;
            this.lblStoreID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            this.lblStoreID.Location = new Point(513, 157);
            this.lblStoreID.Name = "lblStoreID";
            this.lblStoreID.Size = new Size(149, 36);
            this.lblStoreID.TabIndex = 14;
            this.lblStoreID.Text = "លេខសម្គាល់តូប:";
            // 
            // txtContractID
            // 
            txtContractID.Enabled = false;
            txtContractID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtContractID.Location = new Point(256, 38);
            txtContractID.Name = "txtContractID";
            txtContractID.Size = new Size(242, 44);
            txtContractID.TabIndex = 3;
            // 
            // lblContractDate
            // 
            this.lblContractDate.AutoSize = true;
            this.lblContractDate.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            this.lblContractDate.Location = new Point(513, 41);
            this.lblContractDate.Name = "lblContractDate";
            this.lblContractDate.Size = new Size(213, 36);
            this.lblContractDate.TabIndex = 10;
            this.lblContractDate.Text = "កាលបរិច្ឆេទចុះកិច្ចសន្យា:";
            // 
            // dtpContractDate
            // 
            dtpContractDate.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpContractDate.Format = DateTimePickerFormat.Short;
            dtpContractDate.Location = new Point(761, 35);
            dtpContractDate.Name = "dtpContractDate";
            dtpContractDate.Size = new Size(264, 44);
            dtpContractDate.TabIndex = 11;
            // 
            // lblCustomerID
            // 
            lblCustomerID.AutoSize = true;
            lblCustomerID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCustomerID.Location = new Point(18, 218);
            lblCustomerID.Name = "lblCustomerID";
            lblCustomerID.Size = new Size(191, 36);
            lblCustomerID.TabIndex = 12;
            lblCustomerID.Text = "លេខសម្គាល់អតិថិជន:";
            // 
            // pnlContractManipulation
            // 
            pnlContractManipulation.Controls.Add(btnCloseFormContract);
            pnlContractManipulation.Controls.Add(btnNewContract);
            pnlContractManipulation.Controls.Add(btnUpdateContract);
            pnlContractManipulation.Controls.Add(btnInsertContract);
            pnlContractManipulation.Location = new Point(45, 481);
            pnlContractManipulation.Name = "pnlContractManipulation";
            pnlContractManipulation.Size = new Size(1025, 101);
            pnlContractManipulation.TabIndex = 5;
            // 
            // btnCloseFormContract
            // 
            btnCloseFormContract.Location = new Point(706, 20);
            btnCloseFormContract.Name = "btnCloseFormContract";
            btnCloseFormContract.Size = new Size(152, 52);
            btnCloseFormContract.TabIndex = 3;
            btnCloseFormContract.Text = "បិទ";
            btnCloseFormContract.UseVisualStyleBackColor = true;
            // 
            // btnNewContract
            // 
            btnNewContract.Location = new Point(481, 20);
            btnNewContract.Name = "btnNewContract";
            btnNewContract.Size = new Size(152, 52);
            btnNewContract.TabIndex = 2;
            btnNewContract.Text = "បង្កើតថ្មី";
            btnNewContract.UseVisualStyleBackColor = true;
            // 
            // btnUpdateContract
            // 
            btnUpdateContract.Location = new Point(247, 20);
            btnUpdateContract.Name = "btnUpdateContract";
            btnUpdateContract.Size = new Size(152, 52);
            btnUpdateContract.TabIndex = 1;
            btnUpdateContract.Text = "កែប្រែ";
            btnUpdateContract.UseVisualStyleBackColor = true;
            // 
            // btnInsertContract
            // 
            btnInsertContract.Location = new Point(20, 20);
            btnInsertContract.Name = "btnInsertContract";
            btnInsertContract.Size = new Size(152, 52);
            btnInsertContract.TabIndex = 0;
            btnInsertContract.Text = "បញ្ចូល";
            btnInsertContract.UseVisualStyleBackColor = true;
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
            // lblLeaseStartDate
            // 
            this.lblLeaseStartDate.AutoSize = true;
            this.lblLeaseStartDate.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            this.lblLeaseStartDate.Location = new Point(19, 98);
            this.lblLeaseStartDate.Name = "lblLeaseStartDate";
            this.lblLeaseStartDate.Size = new Size(217, 36);
            this.lblLeaseStartDate.TabIndex = 27;
            this.lblLeaseStartDate.Text = "កាលបរិច្ឆេទចាប់ផ្ដើមជួល:";
            // 
            // dtpLeaseStartDate
            // 
            dtpLeaseStartDate.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpLeaseStartDate.Format = DateTimePickerFormat.Short;
            dtpLeaseStartDate.Location = new Point(256, 92);
            dtpLeaseStartDate.Name = "dtpLeaseStartDate";
            dtpLeaseStartDate.Size = new Size(242, 44);
            dtpLeaseStartDate.TabIndex = 28;
            // 
            // lblLeaseEndDate
            // 
            this.lblLeaseEndDate.AutoSize = true;
            this.lblLeaseEndDate.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            this.lblLeaseEndDate.Location = new Point(513, 98);
            this.lblLeaseEndDate.Name = "lblLeaseEndDate";
            this.lblLeaseEndDate.Size = new Size(223, 36);
            this.lblLeaseEndDate.TabIndex = 29;
            this.lblLeaseEndDate.Text = "កាលបរិច្ឆេទបញ្ចប់ការជួល:";
            // 
            // dtpLeaseEndDate
            // 
            this.dtpLeaseEndDate.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            this.dtpLeaseEndDate.Format = DateTimePickerFormat.Short;
            this.dtpLeaseEndDate.Location = new Point(761, 92);
            this.dtpLeaseEndDate.Name = "dtpLeaseEndDate";
            this.dtpLeaseEndDate.Size = new Size(264, 44);
            this.dtpLeaseEndDate.TabIndex = 30;
            // 
            // lblNextPaymentDate
            // 
            lblNextPaymentDate.AutoSize = true;
            lblNextPaymentDate.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNextPaymentDate.Location = new Point(18, 157);
            lblNextPaymentDate.Name = "lblNextPaymentDate";
            lblNextPaymentDate.Size = new Size(231, 36);
            lblNextPaymentDate.TabIndex = 31;
            lblNextPaymentDate.Text = "កាលបរិច្ឆេទបង់ប្រាក់បន្ទាប់:";
            // 
            // dtpNextPaymentDate
            // 
            dtpNextPaymentDate.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNextPaymentDate.Format = DateTimePickerFormat.Short;
            dtpNextPaymentDate.Location = new Point(256, 151);
            dtpNextPaymentDate.Name = "dtpNextPaymentDate";
            dtpNextPaymentDate.Size = new Size(242, 44);
            dtpNextPaymentDate.TabIndex = 32;
            // 
            // cbCustomerID
            // 
            cbCustomerID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbCustomerID.FormattingEnabled = true;
            cbCustomerID.Items.AddRange(new object[] { "អ្នកគ្រប់គ្រង", "គណនីករ" });
            cbCustomerID.Location = new Point(256, 215);
            cbCustomerID.Name = "cbCustomerID";
            cbCustomerID.Size = new Size(242, 44);
            cbCustomerID.TabIndex = 33;
            // 
            // lblInsuranceID
            // 
            lblInsuranceID.AutoSize = true;
            lblInsuranceID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblInsuranceID.Location = new Point(513, 218);
            lblInsuranceID.Name = "lblInsuranceID";
            lblInsuranceID.Size = new Size(276, 36);
            lblInsuranceID.TabIndex = 34;
            lblInsuranceID.Text = "លេខសម្គាល់ក្រុមហ៊ុនធានារ៉ាប់រង:";
            // 
            // cbInsuranceID
            // 
            cbInsuranceID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbInsuranceID.FormattingEnabled = true;
            cbInsuranceID.Items.AddRange(new object[] { "អ្នកគ្រប់គ្រង", "គណនីករ" });
            cbInsuranceID.Location = new Point(805, 215);
            cbInsuranceID.Name = "cbInsuranceID";
            cbInsuranceID.Size = new Size(220, 44);
            cbInsuranceID.TabIndex = 35;
            // 
            // lblStaffID
            // 
            lblStaffID.AutoSize = true;
            lblStaffID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffID.Location = new Point(513, 276);
            lblStaffID.Name = "lblStaffID";
            lblStaffID.Size = new Size(183, 36);
            lblStaffID.TabIndex = 36;
            lblStaffID.Text = "លេខសម្គាល់បុគ្គលិក:";
            // 
            // cbStaffID
            // 
            cbStaffID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbStaffID.FormattingEnabled = true;
            cbStaffID.Items.AddRange(new object[] { "អ្នកគ្រប់គ្រង", "គណនីករ" });
            cbStaffID.Location = new Point(761, 276);
            cbStaffID.Name = "cbStaffID";
            cbStaffID.Size = new Size(264, 44);
            cbStaffID.TabIndex = 37;
            // 
            // txtStaffName
            // 
            txtStaffName.Enabled = false;
            txtStaffName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffName.Location = new Point(256, 338);
            txtStaffName.Name = "txtStaffName";
            txtStaffName.Size = new Size(242, 44);
            txtStaffName.TabIndex = 38;
            // 
            // txtStaffPosition
            // 
            txtStaffPosition.Enabled = false;
            txtStaffPosition.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffPosition.Location = new Point(761, 338);
            txtStaffPosition.Name = "txtStaffPosition";
            txtStaffPosition.Size = new Size(264, 44);
            txtStaffPosition.TabIndex = 39;
            // 
            // FrmContract
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1800, 1000);
            ControlBox = true;
            Controls.Add(pnlRightSide);
            Controls.Add(pnlLeftSide);
            Controls.Add(lblTitle);
            Name = "FrmContract";
            Text = "ព័ត៌មានបុគ្គលិក";
            Controls.SetChildIndex(lblTitle, 0);
            Controls.SetChildIndex(pnlLeftSide, 0);
            Controls.SetChildIndex(pnlRightSide, 0);
            pnlLeftSide.ResumeLayout(false);
            pnlLeftSide.PerformLayout();
            pnlRightSide.ResumeLayout(false);
            gbContractInformation.ResumeLayout(false);
            gbContractInformation.PerformLayout();
            pnlContractManipulation.ResumeLayout(false);
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
        private Label lblSearchContract;
        private TextBox txtSearchContract;
        private Panel pnlLeftSide;
        private ListBox lbContract;
        private Panel pnlRightSide;
        private Label lblContractID;
        private Label lblStaffSex;
        private TextBox txtStaffLastName;
        private Label lblStaffLastName;
        private TextBox txtContractID;
        private Label lblStaffBirthDate;
        private DateTimePicker dtpContractDate;
        private ComboBox cbStaffPosition;
        private Label lblStaffPosition;
        private TextBox txtStaffIdentityCardNumber;
        private Label lblCustomerID;
        private TextBox txtStaffStreetNo;
        private Label lblStaffStreetNo;
        private TextBox txtStaffHouseNo;
        private Label lblStaffHouseNo;
        private Label lblStaffProvinceOrCity;
        private Label lblStaffKhan;
        private TextBox txtStaffSangkat;
        private Label lblStaffSangkat;
        private TextBox txtStaffKhan;
        private GroupBox gbContractInformation;
        private RadioButton rdbFemale;
        private RadioButton rdbMale;
        private GroupBox gbStaffAddress;
        private ComboBox cbStaffCityOrProvince;
        private TextBox txtInsuranceName;
        private Label lblInsuranceName;
        private Label lblStaffName;
        private Panel pnlContractManipulation;
        private Button btnInsertContract;
        private Button btnCloseFormContract;
        private Button btnNewContract;
        private Button btnUpdateContract;
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
        private Label lblContractStartDate;
        private DateTimePicker dtpContractEndDate;
        private Label lblContractEndDate;
        private DateTimePicker dtpLeaseStartDate;
        private DateTimePicker dtpNextPaymentDate;
        private Label lblNextPaymentDate;
        private ComboBox cbCustomerID;
        private Label lblInsuranceID;
        private ComboBox cbInsuranceID;
        private TextBox txtStaffName;
        private ComboBox cbStaffID;
        private Label lblStaffID;
        private TextBox txtStaffPosition;
        private Label lblLeaseEndDate;
        private DateTimePicker dtpLeaseEndDate;
        private Label lblLeaseStartDate;
        private Label lblContractDate;
        private Label lblStoreID;
        private ComboBox cbStoreID;
    }
}