namespace Store_Rental_Management_Systems
{
    partial class FrmCustomer
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
            pnlLeftSide = new Panel();
            lbCustomer = new ListBox();
            lblSearchStaff = new Label();
            txtSearchCustomer = new TextBox();
            pnlRightSide = new Panel();
            btnPickCustomerPhoto = new Button();
            pbCustomerPhoto = new PictureBox();
            gbStaffAddress = new GroupBox();
            cbCustomerCityOrProvince = new ComboBox();
            lblCustomerStreetNo = new Label();
            txtCustomerStreetNo = new TextBox();
            txtCustomerHouseNo = new TextBox();
            lblCustomerProvinceOrCity = new Label();
            lblCustomerHouseNo = new Label();
            lblCustomerSangkat = new Label();
            txtCustomerKhan = new TextBox();
            txtCustomerSangkat = new TextBox();
            lblCustomerKhan = new Label();
            gbStaffInformation = new GroupBox();
            txtCustomerContactNumber = new TextBox();
            lblCustomerContactNumber = new Label();
            rdbFemale = new RadioButton();
            rdbMale = new RadioButton();
            lblCustomerID = new Label();
            txtCustomerLastName = new TextBox();
            lblCustomerFirstName = new Label();
            txtCustomerID = new TextBox();
            lblCustomerLastName = new Label();
            txtCustomerFirstName = new TextBox();
            lblCustomerSex = new Label();
            lblStaffBirthDate = new Label();
            dtpCustomerBirthDate = new DateTimePicker();
            lblCustomerIdentityCardNumber = new Label();
            txtCustomerIdentityCardNumber = new TextBox();
            pnlStaffManipulation = new Panel();
            btnCloseFormCustomer = new Button();
            btnNewCustomer = new Button();
            btnUpdateCustomer = new Button();
            btnInsertCustomer = new Button();
            pnlLeftSide.SuspendLayout();
            pnlRightSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCustomerPhoto).BeginInit();
            gbStaffAddress.SuspendLayout();
            gbStaffInformation.SuspendLayout();
            pnlStaffManipulation.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(1394, 0);
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.FromArgb(0, 28, 87);
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("!Khmer OS Siemreap", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(266, 80);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1534, 94);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "ព័ត៌មានអតិថិជន";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlLeftSide
            // 
            pnlLeftSide.Controls.Add(lbCustomer);
            pnlLeftSide.Controls.Add(lblSearchStaff);
            pnlLeftSide.Controls.Add(txtSearchCustomer);
            pnlLeftSide.Location = new Point(272, 177);
            pnlLeftSide.Name = "pnlLeftSide";
            pnlLeftSide.Size = new Size(364, 666);
            pnlLeftSide.TabIndex = 4;
            // 
            // lbCustomer
            // 
            lbCustomer.FormattingEnabled = true;
            lbCustomer.ItemHeight = 43;
            lbCustomer.Location = new Point(21, 123);
            lbCustomer.Name = "lbCustomer";
            lbCustomer.Size = new Size(319, 520);
            lbCustomer.TabIndex = 3;
            // 
            // lblSearchStaff
            // 
            lblSearchStaff.AutoSize = true;
            lblSearchStaff.Location = new Point(21, 11);
            lblSearchStaff.Name = "lblSearchStaff";
            lblSearchStaff.Size = new Size(97, 43);
            lblSearchStaff.TabIndex = 1;
            lblSearchStaff.Text = "ស្វែងរក:";
            // 
            // txtSearchCustomer
            // 
            txtSearchCustomer.Location = new Point(21, 57);
            txtSearchCustomer.Name = "txtSearchCustomer";
            txtSearchCustomer.Size = new Size(319, 51);
            txtSearchCustomer.TabIndex = 2;
            // 
            // pnlRightSide
            // 
            pnlRightSide.Controls.Add(btnPickCustomerPhoto);
            pnlRightSide.Controls.Add(pbCustomerPhoto);
            pnlRightSide.Controls.Add(gbStaffAddress);
            pnlRightSide.Controls.Add(gbStaffInformation);
            pnlRightSide.Location = new Point(653, 177);
            pnlRightSide.Name = "pnlRightSide";
            pnlRightSide.Size = new Size(1147, 678);
            pnlRightSide.TabIndex = 5;
            // 
            // btnPickCustomerPhoto
            // 
            btnPickCustomerPhoto.Location = new Point(882, 375);
            btnPickCustomerPhoto.Name = "btnPickCustomerPhoto";
            btnPickCustomerPhoto.Size = new Size(211, 63);
            btnPickCustomerPhoto.TabIndex = 28;
            btnPickCustomerPhoto.Text = "ជ្រើសរើសរូបភាព";
            btnPickCustomerPhoto.UseVisualStyleBackColor = true;
            // 
            // pbCustomerPhoto
            // 
            pbCustomerPhoto.BorderStyle = BorderStyle.FixedSingle;
            pbCustomerPhoto.Location = new Point(856, 55);
            pbCustomerPhoto.Name = "pbCustomerPhoto";
            pbCustomerPhoto.Size = new Size(258, 299);
            pbCustomerPhoto.TabIndex = 27;
            pbCustomerPhoto.TabStop = false;
            // 
            // gbStaffAddress
            // 
            gbStaffAddress.Controls.Add(cbCustomerCityOrProvince);
            gbStaffAddress.Controls.Add(lblCustomerStreetNo);
            gbStaffAddress.Controls.Add(txtCustomerStreetNo);
            gbStaffAddress.Controls.Add(txtCustomerHouseNo);
            gbStaffAddress.Controls.Add(lblCustomerProvinceOrCity);
            gbStaffAddress.Controls.Add(lblCustomerHouseNo);
            gbStaffAddress.Controls.Add(lblCustomerSangkat);
            gbStaffAddress.Controls.Add(txtCustomerKhan);
            gbStaffAddress.Controls.Add(txtCustomerSangkat);
            gbStaffAddress.Controls.Add(lblCustomerKhan);
            gbStaffAddress.Font = new Font("Khmer OS Siemreap", 10F, FontStyle.Bold, GraphicsUnit.Point);
            gbStaffAddress.Location = new Point(45, 508);
            gbStaffAddress.Name = "gbStaffAddress";
            gbStaffAddress.Size = new Size(1069, 158);
            gbStaffAddress.TabIndex = 26;
            gbStaffAddress.TabStop = false;
            gbStaffAddress.Text = "អាសយដ្ឋាន";
            // 
            // cbCustomerCityOrProvince
            // 
            cbCustomerCityOrProvince.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbCustomerCityOrProvince.FormattingEnabled = true;
            cbCustomerCityOrProvince.Items.AddRange(new object[] { "ភ្នំពេញ", "តាកែវ" });
            cbCustomerCityOrProvince.Location = new Point(471, 101);
            cbCustomerCityOrProvince.Name = "cbCustomerCityOrProvince";
            cbCustomerCityOrProvince.Size = new Size(219, 51);
            cbCustomerCityOrProvince.TabIndex = 25;
            // 
            // lblCustomerStreetNo
            // 
            lblCustomerStreetNo.AutoSize = true;
            lblCustomerStreetNo.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCustomerStreetNo.Location = new Point(352, 46);
            lblCustomerStreetNo.Name = "lblCustomerStreetNo";
            lblCustomerStreetNo.Size = new Size(97, 43);
            lblCustomerStreetNo.TabIndex = 18;
            lblCustomerStreetNo.Text = "លេខផ្លូវ:";
            // 
            // txtCustomerStreetNo
            // 
            txtCustomerStreetNo.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCustomerStreetNo.Location = new Point(469, 38);
            txtCustomerStreetNo.Name = "txtCustomerStreetNo";
            txtCustomerStreetNo.Size = new Size(219, 51);
            txtCustomerStreetNo.TabIndex = 19;
            // 
            // txtCustomerHouseNo
            // 
            txtCustomerHouseNo.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCustomerHouseNo.Location = new Point(124, 38);
            txtCustomerHouseNo.Name = "txtCustomerHouseNo";
            txtCustomerHouseNo.Size = new Size(193, 51);
            txtCustomerHouseNo.TabIndex = 17;
            // 
            // lblCustomerProvinceOrCity
            // 
            lblCustomerProvinceOrCity.AutoSize = true;
            lblCustomerProvinceOrCity.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCustomerProvinceOrCity.Location = new Point(352, 108);
            lblCustomerProvinceOrCity.Name = "lblCustomerProvinceOrCity";
            lblCustomerProvinceOrCity.Size = new Size(113, 43);
            lblCustomerProvinceOrCity.TabIndex = 24;
            lblCustomerProvinceOrCity.Text = "ខេត្ត/ក្រុង:";
            // 
            // lblCustomerHouseNo
            // 
            lblCustomerHouseNo.AutoSize = true;
            lblCustomerHouseNo.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCustomerHouseNo.Location = new Point(18, 46);
            lblCustomerHouseNo.Name = "lblCustomerHouseNo";
            lblCustomerHouseNo.Size = new Size(100, 43);
            lblCustomerHouseNo.TabIndex = 16;
            lblCustomerHouseNo.Text = "លេខផ្ទះ:";
            // 
            // lblCustomerSangkat
            // 
            lblCustomerSangkat.AutoSize = true;
            lblCustomerSangkat.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCustomerSangkat.Location = new Point(742, 46);
            lblCustomerSangkat.Name = "lblCustomerSangkat";
            lblCustomerSangkat.Size = new Size(89, 43);
            lblCustomerSangkat.TabIndex = 20;
            lblCustomerSangkat.Text = "សង្កាត់:";
            // 
            // txtCustomerKhan
            // 
            txtCustomerKhan.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCustomerKhan.Location = new Point(124, 100);
            txtCustomerKhan.Name = "txtCustomerKhan";
            txtCustomerKhan.Size = new Size(193, 51);
            txtCustomerKhan.TabIndex = 23;
            // 
            // txtCustomerSangkat
            // 
            txtCustomerSangkat.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCustomerSangkat.Location = new Point(837, 38);
            txtCustomerSangkat.Name = "txtCustomerSangkat";
            txtCustomerSangkat.Size = new Size(217, 51);
            txtCustomerSangkat.TabIndex = 21;
            // 
            // lblCustomerKhan
            // 
            lblCustomerKhan.AutoSize = true;
            lblCustomerKhan.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCustomerKhan.Location = new Point(18, 108);
            lblCustomerKhan.Name = "lblCustomerKhan";
            lblCustomerKhan.Size = new Size(74, 43);
            lblCustomerKhan.TabIndex = 22;
            lblCustomerKhan.Text = "ខណ្ឌ:";
            // 
            // gbStaffInformation
            // 
            gbStaffInformation.Controls.Add(txtCustomerContactNumber);
            gbStaffInformation.Controls.Add(lblCustomerContactNumber);
            gbStaffInformation.Controls.Add(rdbFemale);
            gbStaffInformation.Controls.Add(rdbMale);
            gbStaffInformation.Controls.Add(lblCustomerID);
            gbStaffInformation.Controls.Add(txtCustomerLastName);
            gbStaffInformation.Controls.Add(lblCustomerFirstName);
            gbStaffInformation.Controls.Add(txtCustomerID);
            gbStaffInformation.Controls.Add(lblCustomerLastName);
            gbStaffInformation.Controls.Add(txtCustomerFirstName);
            gbStaffInformation.Controls.Add(lblCustomerSex);
            gbStaffInformation.Controls.Add(lblStaffBirthDate);
            gbStaffInformation.Controls.Add(dtpCustomerBirthDate);
            gbStaffInformation.Controls.Add(lblCustomerIdentityCardNumber);
            gbStaffInformation.Controls.Add(txtCustomerIdentityCardNumber);
            gbStaffInformation.Font = new Font("Khmer OS Siemreap", 10F, FontStyle.Bold, GraphicsUnit.Point);
            gbStaffInformation.Location = new Point(45, 36);
            gbStaffInformation.Name = "gbStaffInformation";
            gbStaffInformation.Size = new Size(776, 466);
            gbStaffInformation.TabIndex = 25;
            gbStaffInformation.TabStop = false;
            gbStaffInformation.Text = "ព័ត៌មានអតិថិជន";
            // 
            // txtCustomerContactNumber
            // 
            txtCustomerContactNumber.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCustomerContactNumber.Location = new Point(288, 389);
            txtCustomerContactNumber.Name = "txtCustomerContactNumber";
            txtCustomerContactNumber.Size = new Size(272, 51);
            txtCustomerContactNumber.TabIndex = 22;
            // 
            // lblCustomerContactNumber
            // 
            lblCustomerContactNumber.AutoSize = true;
            lblCustomerContactNumber.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCustomerContactNumber.Location = new Point(23, 397);
            lblCustomerContactNumber.Name = "lblCustomerContactNumber";
            lblCustomerContactNumber.Size = new Size(177, 43);
            lblCustomerContactNumber.TabIndex = 21;
            lblCustomerContactNumber.Text = "លេខទំនាក់ទំនង:";
            // 
            // rdbFemale
            // 
            rdbFemale.AutoSize = true;
            rdbFemale.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbFemale.Location = new Point(189, 257);
            rdbFemale.Name = "rdbFemale";
            rdbFemale.Size = new Size(75, 47);
            rdbFemale.TabIndex = 10;
            rdbFemale.Text = "ស្រី";
            rdbFemale.UseVisualStyleBackColor = true;
            // 
            // rdbMale
            // 
            rdbMale.AutoSize = true;
            rdbMale.Checked = true;
            rdbMale.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbMale.Location = new Point(93, 257);
            rdbMale.Name = "rdbMale";
            rdbMale.Size = new Size(91, 47);
            rdbMale.TabIndex = 9;
            rdbMale.TabStop = true;
            rdbMale.Text = "ប្រុស";
            rdbMale.UseVisualStyleBackColor = true;
            // 
            // lblCustomerID
            // 
            lblCustomerID.AutoSize = true;
            lblCustomerID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCustomerID.Location = new Point(18, 41);
            lblCustomerID.Name = "lblCustomerID";
            lblCustomerID.Size = new Size(223, 43);
            lblCustomerID.TabIndex = 0;
            lblCustomerID.Text = "លេខសម្គាល់អតិថិជន:";
            // 
            // txtCustomerLastName
            // 
            txtCustomerLastName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCustomerLastName.Location = new Point(288, 173);
            txtCustomerLastName.Name = "txtCustomerLastName";
            txtCustomerLastName.Size = new Size(272, 51);
            txtCustomerLastName.TabIndex = 5;
            // 
            // lblCustomerFirstName
            // 
            lblCustomerFirstName.AutoSize = true;
            lblCustomerFirstName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCustomerFirstName.Location = new Point(18, 107);
            lblCustomerFirstName.Name = "lblCustomerFirstName";
            lblCustomerFirstName.Size = new Size(129, 43);
            lblCustomerFirstName.TabIndex = 4;
            lblCustomerFirstName.Text = "នាមត្រកូល:";
            // 
            // txtCustomerID
            // 
            txtCustomerID.Enabled = false;
            txtCustomerID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCustomerID.Location = new Point(288, 32);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(272, 51);
            txtCustomerID.TabIndex = 3;
            // 
            // lblCustomerLastName
            // 
            lblCustomerLastName.AutoSize = true;
            lblCustomerLastName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCustomerLastName.Location = new Point(18, 181);
            lblCustomerLastName.Name = "lblCustomerLastName";
            lblCustomerLastName.Size = new Size(98, 43);
            lblCustomerLastName.TabIndex = 6;
            lblCustomerLastName.Text = "នាមខ្លួន:";
            // 
            // txtCustomerFirstName
            // 
            txtCustomerFirstName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCustomerFirstName.Location = new Point(288, 100);
            txtCustomerFirstName.Name = "txtCustomerFirstName";
            txtCustomerFirstName.Size = new Size(272, 51);
            txtCustomerFirstName.TabIndex = 7;
            // 
            // lblCustomerSex
            // 
            lblCustomerSex.AutoSize = true;
            lblCustomerSex.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCustomerSex.Location = new Point(23, 261);
            lblCustomerSex.Name = "lblCustomerSex";
            lblCustomerSex.Size = new Size(66, 43);
            lblCustomerSex.TabIndex = 8;
            lblCustomerSex.Text = "ភេទ:";
            // 
            // lblStaffBirthDate
            // 
            lblStaffBirthDate.AutoSize = true;
            lblStaffBirthDate.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffBirthDate.Location = new Point(323, 262);
            lblStaffBirthDate.Name = "lblStaffBirthDate";
            lblStaffBirthDate.Size = new Size(170, 43);
            lblStaffBirthDate.TabIndex = 10;
            lblStaffBirthDate.Text = "ថ្ងៃខែឆ្នាំកំណើត:";
            // 
            // dtpCustomerBirthDate
            // 
            dtpCustomerBirthDate.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpCustomerBirthDate.Format = DateTimePickerFormat.Short;
            dtpCustomerBirthDate.Location = new Point(508, 252);
            dtpCustomerBirthDate.Name = "dtpCustomerBirthDate";
            dtpCustomerBirthDate.Size = new Size(225, 51);
            dtpCustomerBirthDate.TabIndex = 11;
            // 
            // lblCustomerIdentityCardNumber
            // 
            lblCustomerIdentityCardNumber.AutoSize = true;
            lblCustomerIdentityCardNumber.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCustomerIdentityCardNumber.Location = new Point(18, 329);
            lblCustomerIdentityCardNumber.Name = "lblCustomerIdentityCardNumber";
            lblCustomerIdentityCardNumber.Size = new Size(240, 43);
            lblCustomerIdentityCardNumber.TabIndex = 12;
            lblCustomerIdentityCardNumber.Text = "លេខអត្តសញ្ញាណប័ណ្ណ:";
            // 
            // txtCustomerIdentityCardNumber
            // 
            txtCustomerIdentityCardNumber.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCustomerIdentityCardNumber.Location = new Point(288, 326);
            txtCustomerIdentityCardNumber.Name = "txtCustomerIdentityCardNumber";
            txtCustomerIdentityCardNumber.Size = new Size(272, 51);
            txtCustomerIdentityCardNumber.TabIndex = 13;
            // 
            // pnlStaffManipulation
            // 
            pnlStaffManipulation.Controls.Add(btnCloseFormCustomer);
            pnlStaffManipulation.Controls.Add(btnNewCustomer);
            pnlStaffManipulation.Controls.Add(btnUpdateCustomer);
            pnlStaffManipulation.Controls.Add(btnInsertCustomer);
            pnlStaffManipulation.Location = new Point(664, 861);
            pnlStaffManipulation.Name = "pnlStaffManipulation";
            pnlStaffManipulation.Size = new Size(925, 101);
            pnlStaffManipulation.TabIndex = 29;
            // 
            // btnCloseFormCustomer
            // 
            btnCloseFormCustomer.BackColor = Color.FromArgb(0, 28, 87);
            btnCloseFormCustomer.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCloseFormCustomer.ForeColor = Color.White;
            btnCloseFormCustomer.Location = new Point(706, 20);
            btnCloseFormCustomer.Name = "btnCloseFormCustomer";
            btnCloseFormCustomer.Size = new Size(152, 62);
            btnCloseFormCustomer.TabIndex = 3;
            btnCloseFormCustomer.Text = "បិទ";
            btnCloseFormCustomer.UseVisualStyleBackColor = false;
            // 
            // btnNewCustomer
            // 
            btnNewCustomer.BackColor = Color.FromArgb(0, 28, 87);
            btnNewCustomer.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNewCustomer.ForeColor = Color.White;
            btnNewCustomer.Location = new Point(481, 20);
            btnNewCustomer.Name = "btnNewCustomer";
            btnNewCustomer.Size = new Size(152, 62);
            btnNewCustomer.TabIndex = 2;
            btnNewCustomer.Text = "បង្កើតថ្មី";
            btnNewCustomer.UseVisualStyleBackColor = false;
            // 
            // btnUpdateCustomer
            // 
            btnUpdateCustomer.BackColor = Color.FromArgb(0, 28, 87);
            btnUpdateCustomer.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateCustomer.ForeColor = Color.White;
            btnUpdateCustomer.Location = new Point(247, 20);
            btnUpdateCustomer.Name = "btnUpdateCustomer";
            btnUpdateCustomer.Size = new Size(152, 62);
            btnUpdateCustomer.TabIndex = 1;
            btnUpdateCustomer.Text = "កែប្រែ";
            btnUpdateCustomer.UseVisualStyleBackColor = false;
            // 
            // btnInsertCustomer
            // 
            btnInsertCustomer.BackColor = Color.FromArgb(0, 28, 87);
            btnInsertCustomer.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsertCustomer.ForeColor = Color.White;
            btnInsertCustomer.Location = new Point(20, 20);
            btnInsertCustomer.Name = "btnInsertCustomer";
            btnInsertCustomer.Size = new Size(152, 62);
            btnInsertCustomer.TabIndex = 0;
            btnInsertCustomer.Text = "បញ្ចូល";
            btnInsertCustomer.UseVisualStyleBackColor = false;
            // 
            // FrmCustomer
            // 
            AutoScaleDimensions = new SizeF(13F, 43F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1800, 1000);
            Controls.Add(pnlStaffManipulation);
            Controls.Add(pnlRightSide);
            Controls.Add(pnlLeftSide);
            Controls.Add(lblTitle);
            Name = "FrmCustomer";
            Text = "FrmCustomer";
            Controls.SetChildIndex(lblTitle, 0);
            Controls.SetChildIndex(pnlLeftSide, 0);
            Controls.SetChildIndex(pnlRightSide, 0);
            Controls.SetChildIndex(pnlStaffManipulation, 0);
            pnlLeftSide.ResumeLayout(false);
            pnlLeftSide.PerformLayout();
            pnlRightSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbCustomerPhoto).EndInit();
            gbStaffAddress.ResumeLayout(false);
            gbStaffAddress.PerformLayout();
            gbStaffInformation.ResumeLayout(false);
            gbStaffInformation.PerformLayout();
            pnlStaffManipulation.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Panel pnlLeftSide;
        private ListBox lbCustomer;
        private Label lblSearchStaff;
        private TextBox txtSearchCustomer;
        private Panel pnlRightSide;
        private Button btnPickCustomerPhoto;
        private PictureBox pbCustomerPhoto;
        private GroupBox gbStaffAddress;
        private ComboBox cbCustomerCityOrProvince;
        private Label lblCustomerStreetNo;
        private TextBox txtCustomerStreetNo;
        private TextBox txtCustomerHouseNo;
        private Label lblCustomerProvinceOrCity;
        private Label lblCustomerHouseNo;
        private Label lblCustomerSangkat;
        private TextBox txtCustomerKhan;
        private TextBox txtCustomerSangkat;
        private Label lblCustomerKhan;
        private GroupBox gbStaffInformation;
        private TextBox txtCustomerContactNumber;
        private Label lblCustomerContactNumber;
        private RadioButton rdbFemale;
        private RadioButton rdbMale;
        private Label lblCustomerID;
        private TextBox txtCustomerLastName;
        private Label lblCustomerFirstName;
        private TextBox txtCustomerID;
        private Label lblCustomerLastName;
        private TextBox txtCustomerFirstName;
        private Label lblCustomerSex;
        private Label lblStaffBirthDate;
        private DateTimePicker dtpCustomerBirthDate;
        private Label lblCustomerIdentityCardNumber;
        private TextBox txtCustomerIdentityCardNumber;
        private Panel pnlStaffManipulation;
        private Button btnCloseFormCustomer;
        private Button btnNewCustomer;
        private Button btnUpdateCustomer;
        private Button btnInsertCustomer;
    }
}