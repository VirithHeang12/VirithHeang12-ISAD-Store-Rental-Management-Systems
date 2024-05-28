﻿namespace Store_Rental_Management_Systems
{
    partial class FrmStaff
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
            lblSearchStaff = new Label();
            txtSearchStaff = new TextBox();
            pnlLeftSide = new Panel();
            lbStaff = new ListBox();
            pnlRightSide = new Panel();
            gbStaffInformation = new GroupBox();
            lblStaffID = new Label();
            txtStaffFirstName = new TextBox();
            label1 = new Label();
            txtStaffID = new TextBox();
            lblStaffProvinceOrCity = new Label();
            txtStaffKhan = new TextBox();
            lblStaffKhan = new Label();
            txtStaffSangkat = new TextBox();
            lblStaffSangkat = new Label();
            txtStaffStreetNo = new TextBox();
            lblStaffStreetNo = new Label();
            txtStaffHouseNo = new TextBox();
            lblStaffHouseNo = new Label();
            cbStaffPosition = new ComboBox();
            lblStaffPosition = new Label();
            txtStaffIdentityCardNumber = new TextBox();
            lblStaffIdentityCardNumber = new Label();
            dtpStaffBirthDate = new DateTimePicker();
            lblStaffBirthDate = new Label();
            lblStaffSex = new Label();
            txtStaffLastName = new TextBox();
            lblStaffLastName = new Label();
            rdbMale = new RadioButton();
            rdbFemale = new RadioButton();
            gbStaffAddress = new GroupBox();
            cbStaffCityOrProvince = new ComboBox();
            pbStaffPhoto = new PictureBox();
            btnPickStaffPhoto = new Button();
            lblStaffSalary = new Label();
            txtStaffSalary = new TextBox();
            chbStaffStoppedWork = new CheckBox();
            lblStaffHiredDate = new Label();
            dtpStaffHiredDate = new DateTimePicker();
            lblStaffContactNumber = new Label();
            textBox1 = new TextBox();
            lblStaffPersonalNumber = new Label();
            txtStaffPersonalNumber = new TextBox();
            pnlStaffManipulation = new Panel();
            btnInsertStaff = new Button();
            btnUpdateStaff = new Button();
            btnNewStaff = new Button();
            btnCloseFormStaff = new Button();
            pnlLeftSide.SuspendLayout();
            pnlRightSide.SuspendLayout();
            gbStaffInformation.SuspendLayout();
            gbStaffAddress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbStaffPhoto).BeginInit();
            pnlStaffManipulation.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.DarkBlue;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("!Khmer OS Siemreap", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1782, 101);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ព័ត៌មានបុគ្គលិក";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSearchStaff
            // 
            lblSearchStaff.AutoSize = true;
            lblSearchStaff.Location = new Point(38, 11);
            lblSearchStaff.Name = "lblSearchStaff";
            lblSearchStaff.Size = new Size(81, 36);
            lblSearchStaff.TabIndex = 1;
            lblSearchStaff.Text = "ស្វែងរក:";
            // 
            // txtSearchStaff
            // 
            txtSearchStaff.Location = new Point(38, 50);
            txtSearchStaff.Name = "txtSearchStaff";
            txtSearchStaff.Size = new Size(319, 44);
            txtSearchStaff.TabIndex = 2;
            // 
            // pnlLeftSide
            // 
            pnlLeftSide.Controls.Add(lbStaff);
            pnlLeftSide.Controls.Add(lblSearchStaff);
            pnlLeftSide.Controls.Add(txtSearchStaff);
            pnlLeftSide.Location = new Point(26, 147);
            pnlLeftSide.Name = "pnlLeftSide";
            pnlLeftSide.Size = new Size(396, 673);
            pnlLeftSide.TabIndex = 3;
            // 
            // lbStaff
            // 
            lbStaff.FormattingEnabled = true;
            lbStaff.ItemHeight = 36;
            lbStaff.Location = new Point(38, 107);
            lbStaff.Name = "lbStaff";
            lbStaff.Size = new Size(319, 544);
            lbStaff.TabIndex = 3;
            // 
            // pnlRightSide
            // 
            pnlRightSide.Controls.Add(btnPickStaffPhoto);
            pnlRightSide.Controls.Add(pbStaffPhoto);
            pnlRightSide.Controls.Add(gbStaffAddress);
            pnlRightSide.Controls.Add(gbStaffInformation);
            pnlRightSide.Location = new Point(468, 147);
            pnlRightSide.Name = "pnlRightSide";
            pnlRightSide.Size = new Size(1267, 673);
            pnlRightSide.TabIndex = 4;
            // 
            // gbStaffInformation
            // 
            gbStaffInformation.Controls.Add(txtStaffPersonalNumber);
            gbStaffInformation.Controls.Add(lblStaffPersonalNumber);
            gbStaffInformation.Controls.Add(textBox1);
            gbStaffInformation.Controls.Add(lblStaffContactNumber);
            gbStaffInformation.Controls.Add(dtpStaffHiredDate);
            gbStaffInformation.Controls.Add(lblStaffHiredDate);
            gbStaffInformation.Controls.Add(chbStaffStoppedWork);
            gbStaffInformation.Controls.Add(txtStaffSalary);
            gbStaffInformation.Controls.Add(lblStaffSalary);
            gbStaffInformation.Controls.Add(rdbFemale);
            gbStaffInformation.Controls.Add(rdbMale);
            gbStaffInformation.Controls.Add(cbStaffPosition);
            gbStaffInformation.Controls.Add(lblStaffID);
            gbStaffInformation.Controls.Add(lblStaffPosition);
            gbStaffInformation.Controls.Add(txtStaffFirstName);
            gbStaffInformation.Controls.Add(label1);
            gbStaffInformation.Controls.Add(txtStaffID);
            gbStaffInformation.Controls.Add(lblStaffLastName);
            gbStaffInformation.Controls.Add(txtStaffLastName);
            gbStaffInformation.Controls.Add(lblStaffSex);
            gbStaffInformation.Controls.Add(lblStaffBirthDate);
            gbStaffInformation.Controls.Add(dtpStaffBirthDate);
            gbStaffInformation.Controls.Add(lblStaffIdentityCardNumber);
            gbStaffInformation.Controls.Add(txtStaffIdentityCardNumber);
            gbStaffInformation.Font = new Font("!Khmer OS Siemreap", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            gbStaffInformation.Location = new Point(45, 32);
            gbStaffInformation.Name = "gbStaffInformation";
            gbStaffInformation.Size = new Size(888, 428);
            gbStaffInformation.TabIndex = 25;
            gbStaffInformation.TabStop = false;
            gbStaffInformation.Text = "ព័ត៌មានបុគ្គលិក";
            // 
            // lblStaffID
            // 
            lblStaffID.AutoSize = true;
            lblStaffID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffID.Location = new Point(18, 41);
            lblStaffID.Name = "lblStaffID";
            lblStaffID.Size = new Size(183, 36);
            lblStaffID.TabIndex = 0;
            lblStaffID.Text = "លេខសម្គាល់បុគ្គលិក:";
            // 
            // txtStaffFirstName
            // 
            txtStaffFirstName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffFirstName.Location = new Point(150, 98);
            txtStaffFirstName.Name = "txtStaffFirstName";
            txtStaffFirstName.Size = new Size(266, 44);
            txtStaffFirstName.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(18, 106);
            label1.Name = "label1";
            label1.Size = new Size(109, 36);
            label1.TabIndex = 4;
            label1.Text = "នាមត្រកូល:";
            // 
            // txtStaffID
            // 
            txtStaffID.Enabled = false;
            txtStaffID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffID.Location = new Point(209, 33);
            txtStaffID.Name = "txtStaffID";
            txtStaffID.Size = new Size(324, 44);
            txtStaffID.TabIndex = 3;
            // 
            // lblStaffProvinceOrCity
            // 
            lblStaffProvinceOrCity.AutoSize = true;
            lblStaffProvinceOrCity.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffProvinceOrCity.Location = new Point(438, 108);
            lblStaffProvinceOrCity.Name = "lblStaffProvinceOrCity";
            lblStaffProvinceOrCity.Size = new Size(95, 36);
            lblStaffProvinceOrCity.TabIndex = 24;
            lblStaffProvinceOrCity.Text = "ខេត្ត/ក្រុង:";
            // 
            // txtStaffKhan
            // 
            txtStaffKhan.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffKhan.Location = new Point(108, 100);
            txtStaffKhan.Name = "txtStaffKhan";
            txtStaffKhan.Size = new Size(242, 44);
            txtStaffKhan.TabIndex = 23;
            // 
            // lblStaffKhan
            // 
            lblStaffKhan.AutoSize = true;
            lblStaffKhan.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffKhan.Location = new Point(18, 108);
            lblStaffKhan.Name = "lblStaffKhan";
            lblStaffKhan.Size = new Size(62, 36);
            lblStaffKhan.TabIndex = 22;
            lblStaffKhan.Text = "ខណ្ឌ:";
            // 
            // txtStaffSangkat
            // 
            txtStaffSangkat.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffSangkat.Location = new Point(878, 38);
            txtStaffSangkat.Name = "txtStaffSangkat";
            txtStaffSangkat.Size = new Size(249, 44);
            txtStaffSangkat.TabIndex = 21;
            // 
            // lblStaffSangkat
            // 
            lblStaffSangkat.AutoSize = true;
            lblStaffSangkat.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffSangkat.Location = new Point(797, 46);
            lblStaffSangkat.Name = "lblStaffSangkat";
            lblStaffSangkat.Size = new Size(75, 36);
            lblStaffSangkat.TabIndex = 20;
            lblStaffSangkat.Text = "សង្កាត់:";
            // 
            // txtStaffStreetNo
            // 
            txtStaffStreetNo.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffStreetNo.Location = new Point(540, 38);
            txtStaffStreetNo.Name = "txtStaffStreetNo";
            txtStaffStreetNo.Size = new Size(219, 44);
            txtStaffStreetNo.TabIndex = 19;
            // 
            // lblStaffStreetNo
            // 
            lblStaffStreetNo.AutoSize = true;
            lblStaffStreetNo.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffStreetNo.Location = new Point(438, 46);
            lblStaffStreetNo.Name = "lblStaffStreetNo";
            lblStaffStreetNo.Size = new Size(81, 36);
            lblStaffStreetNo.TabIndex = 18;
            lblStaffStreetNo.Text = "លេខផ្លូវ:";
            // 
            // txtStaffHouseNo
            // 
            txtStaffHouseNo.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffHouseNo.Location = new Point(108, 38);
            txtStaffHouseNo.Name = "txtStaffHouseNo";
            txtStaffHouseNo.Size = new Size(242, 44);
            txtStaffHouseNo.TabIndex = 17;
            // 
            // lblStaffHouseNo
            // 
            lblStaffHouseNo.AutoSize = true;
            lblStaffHouseNo.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffHouseNo.Location = new Point(18, 46);
            lblStaffHouseNo.Name = "lblStaffHouseNo";
            lblStaffHouseNo.Size = new Size(84, 36);
            lblStaffHouseNo.TabIndex = 16;
            lblStaffHouseNo.Text = "លេខផ្ទះ:";
            // 
            // cbStaffPosition
            // 
            cbStaffPosition.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStaffPosition.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbStaffPosition.FormattingEnabled = true;
            cbStaffPosition.Location = new Point(606, 218);
            cbStaffPosition.Name = "cbStaffPosition";
            cbStaffPosition.Size = new Size(237, 44);
            cbStaffPosition.TabIndex = 15;
            // 
            // lblStaffPosition
            // 
            lblStaffPosition.AutoSize = true;
            lblStaffPosition.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffPosition.Location = new Point(531, 221);
            lblStaffPosition.Name = "lblStaffPosition";
            lblStaffPosition.Size = new Size(69, 36);
            lblStaffPosition.TabIndex = 14;
            lblStaffPosition.Text = "តួនាទី:";
            // 
            // txtStaffIdentityCardNumber
            // 
            txtStaffIdentityCardNumber.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffIdentityCardNumber.Location = new Point(227, 218);
            txtStaffIdentityCardNumber.Name = "txtStaffIdentityCardNumber";
            txtStaffIdentityCardNumber.Size = new Size(236, 44);
            txtStaffIdentityCardNumber.TabIndex = 13;
            // 
            // lblStaffIdentityCardNumber
            // 
            lblStaffIdentityCardNumber.AutoSize = true;
            lblStaffIdentityCardNumber.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffIdentityCardNumber.Location = new Point(18, 221);
            lblStaffIdentityCardNumber.Name = "lblStaffIdentityCardNumber";
            lblStaffIdentityCardNumber.Size = new Size(203, 36);
            lblStaffIdentityCardNumber.TabIndex = 12;
            lblStaffIdentityCardNumber.Text = "លេខអត្តសញ្ញាណប័ណ្ណ:";
            // 
            // dtpStaffBirthDate
            // 
            dtpStaffBirthDate.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpStaffBirthDate.Format = DateTimePickerFormat.Short;
            dtpStaffBirthDate.Location = new Point(531, 156);
            dtpStaffBirthDate.Name = "dtpStaffBirthDate";
            dtpStaffBirthDate.Size = new Size(312, 44);
            dtpStaffBirthDate.TabIndex = 11;
            // 
            // lblStaffBirthDate
            // 
            lblStaffBirthDate.AutoSize = true;
            lblStaffBirthDate.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffBirthDate.Location = new Point(377, 164);
            lblStaffBirthDate.Name = "lblStaffBirthDate";
            lblStaffBirthDate.Size = new Size(142, 36);
            lblStaffBirthDate.TabIndex = 10;
            lblStaffBirthDate.Text = "ថ្ងៃខែឆ្នាំកំណើត:";
            // 
            // lblStaffSex
            // 
            lblStaffSex.AutoSize = true;
            lblStaffSex.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffSex.Location = new Point(18, 164);
            lblStaffSex.Name = "lblStaffSex";
            lblStaffSex.Size = new Size(55, 36);
            lblStaffSex.TabIndex = 8;
            lblStaffSex.Text = "ភេទ:";
            // 
            // txtStaffLastName
            // 
            txtStaffLastName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffLastName.Location = new Point(531, 98);
            txtStaffLastName.Name = "txtStaffLastName";
            txtStaffLastName.Size = new Size(312, 44);
            txtStaffLastName.TabIndex = 7;
            // 
            // lblStaffLastName
            // 
            lblStaffLastName.AutoSize = true;
            lblStaffLastName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffLastName.Location = new Point(436, 106);
            lblStaffLastName.Name = "lblStaffLastName";
            lblStaffLastName.Size = new Size(83, 36);
            lblStaffLastName.TabIndex = 6;
            lblStaffLastName.Text = "នាមខ្លួន:";
            // 
            // rdbMale
            // 
            rdbMale.AutoSize = true;
            rdbMale.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbMale.Location = new Point(88, 160);
            rdbMale.Name = "rdbMale";
            rdbMale.Size = new Size(76, 40);
            rdbMale.TabIndex = 9;
            rdbMale.TabStop = true;
            rdbMale.Text = "ប្រុស";
            rdbMale.UseVisualStyleBackColor = true;
            // 
            // rdbFemale
            // 
            rdbFemale.AutoSize = true;
            rdbFemale.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbFemale.Location = new Point(170, 160);
            rdbFemale.Name = "rdbFemale";
            rdbFemale.Size = new Size(62, 40);
            rdbFemale.TabIndex = 10;
            rdbFemale.TabStop = true;
            rdbFemale.Text = "ស្រី";
            rdbFemale.UseVisualStyleBackColor = true;
            // 
            // gbStaffAddress
            // 
            gbStaffAddress.Controls.Add(cbStaffCityOrProvince);
            gbStaffAddress.Controls.Add(lblStaffStreetNo);
            gbStaffAddress.Controls.Add(txtStaffStreetNo);
            gbStaffAddress.Controls.Add(txtStaffHouseNo);
            gbStaffAddress.Controls.Add(lblStaffProvinceOrCity);
            gbStaffAddress.Controls.Add(lblStaffHouseNo);
            gbStaffAddress.Controls.Add(lblStaffSangkat);
            gbStaffAddress.Controls.Add(txtStaffKhan);
            gbStaffAddress.Controls.Add(txtStaffSangkat);
            gbStaffAddress.Controls.Add(lblStaffKhan);
            gbStaffAddress.Font = new Font("!Khmer OS Siemreap", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            gbStaffAddress.Location = new Point(45, 479);
            gbStaffAddress.Name = "gbStaffAddress";
            gbStaffAddress.Size = new Size(1183, 172);
            gbStaffAddress.TabIndex = 26;
            gbStaffAddress.TabStop = false;
            gbStaffAddress.Text = "អាសយដ្ឋាន";
            // 
            // cbStaffCityOrProvince
            // 
            cbStaffCityOrProvince.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbStaffCityOrProvince.FormattingEnabled = true;
            cbStaffCityOrProvince.Location = new Point(540, 105);
            cbStaffCityOrProvince.Name = "cbStaffCityOrProvince";
            cbStaffCityOrProvince.Size = new Size(219, 44);
            cbStaffCityOrProvince.TabIndex = 25;
            // 
            // pbStaffPhoto
            // 
            pbStaffPhoto.Location = new Point(970, 32);
            pbStaffPhoto.Name = "pbStaffPhoto";
            pbStaffPhoto.Size = new Size(258, 299);
            pbStaffPhoto.TabIndex = 27;
            pbStaffPhoto.TabStop = false;
            // 
            // btnPickStaffPhoto
            // 
            btnPickStaffPhoto.Location = new Point(998, 364);
            btnPickStaffPhoto.Name = "btnPickStaffPhoto";
            btnPickStaffPhoto.Size = new Size(211, 63);
            btnPickStaffPhoto.TabIndex = 28;
            btnPickStaffPhoto.Text = "ជ្រើសរើសរូបភាព";
            btnPickStaffPhoto.UseVisualStyleBackColor = true;
            // 
            // lblStaffSalary
            // 
            lblStaffSalary.AutoSize = true;
            lblStaffSalary.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffSalary.Location = new Point(18, 292);
            lblStaffSalary.Name = "lblStaffSalary";
            lblStaffSalary.Size = new Size(81, 36);
            lblStaffSalary.TabIndex = 16;
            lblStaffSalary.Text = "ប្រាក់ខែ:";
            // 
            // txtStaffSalary
            // 
            txtStaffSalary.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffSalary.Location = new Point(108, 284);
            txtStaffSalary.Name = "txtStaffSalary";
            txtStaffSalary.Size = new Size(164, 44);
            txtStaffSalary.TabIndex = 17;
            // 
            // chbStaffStoppedWork
            // 
            chbStaffStoppedWork.AutoSize = true;
            chbStaffStoppedWork.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chbStaffStoppedWork.Location = new Point(686, 41);
            chbStaffStoppedWork.Name = "chbStaffStoppedWork";
            chbStaffStoppedWork.Size = new Size(157, 40);
            chbStaffStoppedWork.TabIndex = 18;
            chbStaffStoppedWork.Text = "បានឈប់ធ្វើការ";
            chbStaffStoppedWork.UseVisualStyleBackColor = true;
            // 
            // lblStaffHiredDate
            // 
            lblStaffHiredDate.AutoSize = true;
            lblStaffHiredDate.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffHiredDate.Location = new Point(284, 292);
            lblStaffHiredDate.Name = "lblStaffHiredDate";
            lblStaffHiredDate.Size = new Size(241, 36);
            lblStaffHiredDate.TabIndex = 19;
            lblStaffHiredDate.Text = "កាលបរិច្ឆេទចូលបម្រើការងារ:";
            // 
            // dtpStaffHiredDate
            // 
            dtpStaffHiredDate.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpStaffHiredDate.Format = DateTimePickerFormat.Short;
            dtpStaffHiredDate.Location = new Point(531, 286);
            dtpStaffHiredDate.Name = "dtpStaffHiredDate";
            dtpStaffHiredDate.Size = new Size(312, 44);
            dtpStaffHiredDate.TabIndex = 20;
            // 
            // lblStaffContactNumber
            // 
            lblStaffContactNumber.AutoSize = true;
            lblStaffContactNumber.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffContactNumber.Location = new Point(18, 354);
            lblStaffContactNumber.Name = "lblStaffContactNumber";
            lblStaffContactNumber.Size = new Size(151, 36);
            lblStaffContactNumber.TabIndex = 21;
            lblStaffContactNumber.Text = "លេខទំនាក់ទំនង:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(186, 351);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(230, 44);
            textBox1.TabIndex = 22;
            // 
            // lblStaffPersonalNumber
            // 
            lblStaffPersonalNumber.AutoSize = true;
            lblStaffPersonalNumber.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffPersonalNumber.Location = new Point(438, 354);
            lblStaffPersonalNumber.Name = "lblStaffPersonalNumber";
            lblStaffPersonalNumber.Size = new Size(129, 36);
            lblStaffPersonalNumber.TabIndex = 23;
            lblStaffPersonalNumber.Text = "លេខផ្ទាល់ខ្លួន:";
            // 
            // txtStaffPersonalNumber
            // 
            txtStaffPersonalNumber.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffPersonalNumber.Location = new Point(596, 351);
            txtStaffPersonalNumber.Name = "txtStaffPersonalNumber";
            txtStaffPersonalNumber.Size = new Size(247, 44);
            txtStaffPersonalNumber.TabIndex = 24;
            // 
            // pnlStaffManipulation
            // 
            pnlStaffManipulation.Controls.Add(btnCloseFormStaff);
            pnlStaffManipulation.Controls.Add(btnNewStaff);
            pnlStaffManipulation.Controls.Add(btnUpdateStaff);
            pnlStaffManipulation.Controls.Add(btnInsertStaff);
            pnlStaffManipulation.Location = new Point(343, 840);
            pnlStaffManipulation.Name = "pnlStaffManipulation";
            pnlStaffManipulation.Size = new Size(992, 101);
            pnlStaffManipulation.TabIndex = 5;
            // 
            // btnInsertStaff
            // 
            btnInsertStaff.Location = new Point(38, 20);
            btnInsertStaff.Name = "btnInsertStaff";
            btnInsertStaff.Size = new Size(152, 52);
            btnInsertStaff.TabIndex = 0;
            btnInsertStaff.Text = "បញ្ចូល";
            btnInsertStaff.UseVisualStyleBackColor = true;
            // 
            // btnUpdateStaff
            // 
            btnUpdateStaff.Location = new Point(305, 20);
            btnUpdateStaff.Name = "btnUpdateStaff";
            btnUpdateStaff.Size = new Size(152, 52);
            btnUpdateStaff.TabIndex = 1;
            btnUpdateStaff.Text = "កែប្រែ";
            btnUpdateStaff.UseVisualStyleBackColor = true;
            // 
            // btnNewStaff
            // 
            btnNewStaff.Location = new Point(551, 20);
            btnNewStaff.Name = "btnNewStaff";
            btnNewStaff.Size = new Size(152, 52);
            btnNewStaff.TabIndex = 2;
            btnNewStaff.Text = "បង្កើតថ្មី";
            btnNewStaff.UseVisualStyleBackColor = true;
            // 
            // btnCloseFormStaff
            // 
            btnCloseFormStaff.Location = new Point(801, 20);
            btnCloseFormStaff.Name = "btnCloseFormStaff";
            btnCloseFormStaff.Size = new Size(152, 52);
            btnCloseFormStaff.TabIndex = 3;
            btnCloseFormStaff.Text = "បិទ";
            btnCloseFormStaff.UseVisualStyleBackColor = true;
            // 
            // FrmStaff
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1782, 953);
            Controls.Add(pnlStaffManipulation);
            Controls.Add(pnlRightSide);
            Controls.Add(pnlLeftSide);
            Controls.Add(lblTitle);
            Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FrmStaff";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormStaff";
            pnlLeftSide.ResumeLayout(false);
            pnlLeftSide.PerformLayout();
            pnlRightSide.ResumeLayout(false);
            gbStaffInformation.ResumeLayout(false);
            gbStaffInformation.PerformLayout();
            gbStaffAddress.ResumeLayout(false);
            gbStaffAddress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbStaffPhoto).EndInit();
            pnlStaffManipulation.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblSearchStaff;
        private TextBox txtSearchStaff;
        private Panel pnlLeftSide;
        private ListBox lbStaff;
        private Panel pnlRightSide;
        private Label lblStaffID;
        private Label lblStaffSex;
        private TextBox txtStaffLastName;
        private Label lblStaffLastName;
        private TextBox txtStaffFirstName;
        private Label label1;
        private TextBox txtStaffID;
        private Label lblStaffBirthDate;
        private DateTimePicker dtpStaffBirthDate;
        private ComboBox cbStaffPosition;
        private Label lblStaffPosition;
        private TextBox txtStaffIdentityCardNumber;
        private Label lblStaffIdentityCardNumber;
        private TextBox txtStaffStreetNo;
        private Label lblStaffStreetNo;
        private TextBox txtStaffHouseNo;
        private Label lblStaffHouseNo;
        private Label lblStaffProvinceOrCity;
        private Label lblStaffKhan;
        private TextBox txtStaffSangkat;
        private Label lblStaffSangkat;
        private TextBox txtStaffKhan;
        private GroupBox gbStaffInformation;
        private RadioButton rdbFemale;
        private RadioButton rdbMale;
        private GroupBox gbStaffAddress;
        private PictureBox pbStaffPhoto;
        private ComboBox cbStaffCityOrProvince;
        private Button btnPickStaffPhoto;
        private CheckBox chbStaffStoppedWork;
        private TextBox txtStaffSalary;
        private Label lblStaffSalary;
        private DateTimePicker dtpStaffHiredDate;
        private Label lblStaffHiredDate;
        private TextBox textBox1;
        private Label lblStaffContactNumber;
        private TextBox txtStaffPersonalNumber;
        private Label lblStaffPersonalNumber;
        private Panel pnlStaffManipulation;
        private Button btnInsertStaff;
        private Button btnCloseFormStaff;
        private Button btnNewStaff;
        private Button btnUpdateStaff;
    }
}