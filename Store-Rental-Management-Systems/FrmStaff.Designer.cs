namespace Store_Rental_Management_Systems
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
            btnPickStaffPhoto = new Button();
            pbStaffPhoto = new PictureBox();
            gbStaffAddress = new GroupBox();
            cbStaffCityOrProvince = new ComboBox();
            lblStaffStreetNo = new Label();
            txtStaffStreetNo = new TextBox();
            txtStaffHouseNo = new TextBox();
            lblStaffProvinceOrCity = new Label();
            lblStaffHouseNo = new Label();
            lblStaffSangkat = new Label();
            txtStaffKhan = new TextBox();
            txtStaffSangkat = new TextBox();
            lblStaffKhan = new Label();
            gbStaffInformation = new GroupBox();
            txtStaffPersonalNumber = new TextBox();
            lblStaffPersonalNumber = new Label();
            textBox1 = new TextBox();
            lblStaffContactNumber = new Label();
            dtpStaffHiredDate = new DateTimePicker();
            lblStaffHiredDate = new Label();
            chbStaffStoppedWork = new CheckBox();
            txtStaffSalary = new TextBox();
            lblStaffSalary = new Label();
            rdbFemale = new RadioButton();
            rdbMale = new RadioButton();
            cbStaffPosition = new ComboBox();
            lblStaffID = new Label();
            lblStaffPosition = new Label();
            txtStaffFirstName = new TextBox();
            label1 = new Label();
            txtStaffID = new TextBox();
            lblStaffLastName = new Label();
            txtStaffLastName = new TextBox();
            lblStaffSex = new Label();
            lblStaffBirthDate = new Label();
            dtpStaffBirthDate = new DateTimePicker();
            lblStaffIdentityCardNumber = new Label();
            txtStaffIdentityCardNumber = new TextBox();
            pnlStaffManipulation = new Panel();
            btnCloseFormStaff = new Button();
            btnNewStaff = new Button();
            btnUpdateStaff = new Button();
            btnInsertStaff = new Button();
            pnlLeftSide.SuspendLayout();
            pnlRightSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbStaffPhoto).BeginInit();
            gbStaffAddress.SuspendLayout();
            gbStaffInformation.SuspendLayout();
            pnlStaffManipulation.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.DarkBlue;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1782, 101);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ព័ត៌មានបុគ្គលិក";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Click += lblTitle_Click;
            // 
            // lblSearchStaff
            // 
            lblSearchStaff.AutoSize = true;
            lblSearchStaff.Location = new Point(38, 11);
            lblSearchStaff.Name = "lblSearchStaff";
            lblSearchStaff.Size = new Size(66, 25);
            lblSearchStaff.TabIndex = 1;
            lblSearchStaff.Text = "ស្វែងរក:";
            // 
            // txtSearchStaff
            // 
            txtSearchStaff.Location = new Point(38, 50);
            txtSearchStaff.Name = "txtSearchStaff";
            txtSearchStaff.Size = new Size(319, 30);
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
            lbStaff.ItemHeight = 25;
            lbStaff.Location = new Point(38, 107);
            lbStaff.Name = "lbStaff";
            lbStaff.Size = new Size(319, 529);
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
            // btnPickStaffPhoto
            // 
            btnPickStaffPhoto.Location = new Point(998, 364);
            btnPickStaffPhoto.Name = "btnPickStaffPhoto";
            btnPickStaffPhoto.Size = new Size(211, 63);
            btnPickStaffPhoto.TabIndex = 28;
            btnPickStaffPhoto.Text = "ជ្រើសរើសរូបភាព";
            btnPickStaffPhoto.UseVisualStyleBackColor = true;
            // 
            // pbStaffPhoto
            // 
            pbStaffPhoto.BorderStyle = BorderStyle.FixedSingle;
            pbStaffPhoto.Location = new Point(970, 32);
            pbStaffPhoto.Name = "pbStaffPhoto";
            pbStaffPhoto.Size = new Size(258, 299);
            pbStaffPhoto.TabIndex = 27;
            pbStaffPhoto.TabStop = false;
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
            gbStaffAddress.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            gbStaffAddress.Location = new Point(45, 479);
            gbStaffAddress.Name = "gbStaffAddress";
            gbStaffAddress.Size = new Size(1183, 172);
            gbStaffAddress.TabIndex = 26;
            gbStaffAddress.TabStop = false;
            gbStaffAddress.Text = "អាសយដ្ឋាន";
            // 
            // cbStaffCityOrProvince
            // 
            cbStaffCityOrProvince.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbStaffCityOrProvince.FormattingEnabled = true;
            cbStaffCityOrProvince.Location = new Point(540, 105);
            cbStaffCityOrProvince.Name = "cbStaffCityOrProvince";
            cbStaffCityOrProvince.Size = new Size(219, 33);
            cbStaffCityOrProvince.TabIndex = 25;
            // 
            // lblStaffStreetNo
            // 
            lblStaffStreetNo.AutoSize = true;
            lblStaffStreetNo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffStreetNo.Location = new Point(438, 46);
            lblStaffStreetNo.Name = "lblStaffStreetNo";
            lblStaffStreetNo.Size = new Size(68, 25);
            lblStaffStreetNo.TabIndex = 18;
            lblStaffStreetNo.Text = "លេខផ្លូវ:";
            // 
            // txtStaffStreetNo
            // 
            txtStaffStreetNo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffStreetNo.Location = new Point(540, 38);
            txtStaffStreetNo.Name = "txtStaffStreetNo";
            txtStaffStreetNo.Size = new Size(219, 30);
            txtStaffStreetNo.TabIndex = 19;
            // 
            // txtStaffHouseNo
            // 
            txtStaffHouseNo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffHouseNo.Location = new Point(108, 38);
            txtStaffHouseNo.Name = "txtStaffHouseNo";
            txtStaffHouseNo.Size = new Size(242, 30);
            txtStaffHouseNo.TabIndex = 17;
            // 
            // lblStaffProvinceOrCity
            // 
            lblStaffProvinceOrCity.AutoSize = true;
            lblStaffProvinceOrCity.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffProvinceOrCity.Location = new Point(438, 108);
            lblStaffProvinceOrCity.Name = "lblStaffProvinceOrCity";
            lblStaffProvinceOrCity.Size = new Size(83, 25);
            lblStaffProvinceOrCity.TabIndex = 24;
            lblStaffProvinceOrCity.Text = "ខេត្ត/ក្រុង:";
            // 
            // lblStaffHouseNo
            // 
            lblStaffHouseNo.AutoSize = true;
            lblStaffHouseNo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffHouseNo.Location = new Point(18, 46);
            lblStaffHouseNo.Name = "lblStaffHouseNo";
            lblStaffHouseNo.Size = new Size(66, 25);
            lblStaffHouseNo.TabIndex = 16;
            lblStaffHouseNo.Text = "លេខផ្ទះ:";
            // 
            // lblStaffSangkat
            // 
            lblStaffSangkat.AutoSize = true;
            lblStaffSangkat.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffSangkat.Location = new Point(797, 46);
            lblStaffSangkat.Name = "lblStaffSangkat";
            lblStaffSangkat.Size = new Size(60, 25);
            lblStaffSangkat.TabIndex = 20;
            lblStaffSangkat.Text = "សង្កាត់:";
            // 
            // txtStaffKhan
            // 
            txtStaffKhan.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffKhan.Location = new Point(108, 100);
            txtStaffKhan.Name = "txtStaffKhan";
            txtStaffKhan.Size = new Size(242, 30);
            txtStaffKhan.TabIndex = 23;
            // 
            // txtStaffSangkat
            // 
            txtStaffSangkat.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffSangkat.Location = new Point(878, 38);
            txtStaffSangkat.Name = "txtStaffSangkat";
            txtStaffSangkat.Size = new Size(249, 30);
            txtStaffSangkat.TabIndex = 21;
            // 
            // lblStaffKhan
            // 
            lblStaffKhan.AutoSize = true;
            lblStaffKhan.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffKhan.Location = new Point(18, 108);
            lblStaffKhan.Name = "lblStaffKhan";
            lblStaffKhan.Size = new Size(44, 25);
            lblStaffKhan.TabIndex = 22;
            lblStaffKhan.Text = "ខណ្ឌ:";
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
            gbStaffInformation.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            gbStaffInformation.Location = new Point(45, 32);
            gbStaffInformation.Name = "gbStaffInformation";
            gbStaffInformation.Size = new Size(888, 428);
            gbStaffInformation.TabIndex = 25;
            gbStaffInformation.TabStop = false;
            gbStaffInformation.Text = "ព័ត៌មានបុគ្គលិក";
            // 
            // txtStaffPersonalNumber
            // 
            txtStaffPersonalNumber.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffPersonalNumber.Location = new Point(596, 351);
            txtStaffPersonalNumber.Name = "txtStaffPersonalNumber";
            txtStaffPersonalNumber.Size = new Size(247, 30);
            txtStaffPersonalNumber.TabIndex = 24;
            // 
            // lblStaffPersonalNumber
            // 
            lblStaffPersonalNumber.AutoSize = true;
            lblStaffPersonalNumber.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffPersonalNumber.Location = new Point(438, 354);
            lblStaffPersonalNumber.Name = "lblStaffPersonalNumber";
            lblStaffPersonalNumber.Size = new Size(104, 25);
            lblStaffPersonalNumber.TabIndex = 23;
            lblStaffPersonalNumber.Text = "លេខផ្ទាល់ខ្លួន:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(186, 351);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(230, 30);
            textBox1.TabIndex = 22;
            // 
            // lblStaffContactNumber
            // 
            lblStaffContactNumber.AutoSize = true;
            lblStaffContactNumber.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffContactNumber.Location = new Point(18, 354);
            lblStaffContactNumber.Name = "lblStaffContactNumber";
            lblStaffContactNumber.Size = new Size(127, 25);
            lblStaffContactNumber.TabIndex = 21;
            lblStaffContactNumber.Text = "លេខទំនាក់ទំនង:";
            // 
            // dtpStaffHiredDate
            // 
            dtpStaffHiredDate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpStaffHiredDate.Format = DateTimePickerFormat.Short;
            dtpStaffHiredDate.Location = new Point(531, 286);
            dtpStaffHiredDate.Name = "dtpStaffHiredDate";
            dtpStaffHiredDate.Size = new Size(312, 30);
            dtpStaffHiredDate.TabIndex = 20;
            // 
            // lblStaffHiredDate
            // 
            lblStaffHiredDate.AutoSize = true;
            lblStaffHiredDate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffHiredDate.Location = new Point(284, 292);
            lblStaffHiredDate.Name = "lblStaffHiredDate";
            lblStaffHiredDate.Size = new Size(205, 25);
            lblStaffHiredDate.TabIndex = 19;
            lblStaffHiredDate.Text = "កាលបរិច្ឆេទចូលបម្រើការងារ:";
            // 
            // chbStaffStoppedWork
            // 
            chbStaffStoppedWork.AutoSize = true;
            chbStaffStoppedWork.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chbStaffStoppedWork.Location = new Point(686, 41);
            chbStaffStoppedWork.Name = "chbStaffStoppedWork";
            chbStaffStoppedWork.Size = new Size(139, 29);
            chbStaffStoppedWork.TabIndex = 18;
            chbStaffStoppedWork.Text = "បានឈប់ធ្វើការ";
            chbStaffStoppedWork.UseVisualStyleBackColor = true;
            // 
            // txtStaffSalary
            // 
            txtStaffSalary.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffSalary.Location = new Point(108, 284);
            txtStaffSalary.Name = "txtStaffSalary";
            txtStaffSalary.Size = new Size(164, 30);
            txtStaffSalary.TabIndex = 17;
            // 
            // lblStaffSalary
            // 
            lblStaffSalary.AutoSize = true;
            lblStaffSalary.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffSalary.Location = new Point(18, 292);
            lblStaffSalary.Name = "lblStaffSalary";
            lblStaffSalary.Size = new Size(69, 25);
            lblStaffSalary.TabIndex = 16;
            lblStaffSalary.Text = "ប្រាក់ខែ:";
            // 
            // rdbFemale
            // 
            rdbFemale.AutoSize = true;
            rdbFemale.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbFemale.Location = new Point(170, 160);
            rdbFemale.Name = "rdbFemale";
            rdbFemale.Size = new Size(51, 29);
            rdbFemale.TabIndex = 10;
            rdbFemale.TabStop = true;
            rdbFemale.Text = "ស្រី";
            rdbFemale.UseVisualStyleBackColor = true;
            // 
            // rdbMale
            // 
            rdbMale.AutoSize = true;
            rdbMale.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbMale.Location = new Point(88, 160);
            rdbMale.Name = "rdbMale";
            rdbMale.Size = new Size(64, 29);
            rdbMale.TabIndex = 9;
            rdbMale.TabStop = true;
            rdbMale.Text = "ប្រុស";
            rdbMale.UseVisualStyleBackColor = true;
            // 
            // cbStaffPosition
            // 
            cbStaffPosition.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStaffPosition.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbStaffPosition.FormattingEnabled = true;
            cbStaffPosition.Location = new Point(606, 218);
            cbStaffPosition.Name = "cbStaffPosition";
            cbStaffPosition.Size = new Size(237, 33);
            cbStaffPosition.TabIndex = 15;
            // 
            // lblStaffID
            // 
            lblStaffID.AutoSize = true;
            lblStaffID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffID.Location = new Point(18, 41);
            lblStaffID.Name = "lblStaffID";
            lblStaffID.Size = new Size(147, 25);
            lblStaffID.TabIndex = 0;
            lblStaffID.Text = "លេខសម្គាល់បុគ្គលិក:";
            // 
            // lblStaffPosition
            // 
            lblStaffPosition.AutoSize = true;
            lblStaffPosition.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffPosition.Location = new Point(531, 221);
            lblStaffPosition.Name = "lblStaffPosition";
            lblStaffPosition.Size = new Size(57, 25);
            lblStaffPosition.TabIndex = 14;
            lblStaffPosition.Text = "តួនាទី:";
            // 
            // txtStaffFirstName
            // 
            txtStaffFirstName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffFirstName.Location = new Point(150, 98);
            txtStaffFirstName.Name = "txtStaffFirstName";
            txtStaffFirstName.Size = new Size(266, 30);
            txtStaffFirstName.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(18, 106);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 4;
            label1.Text = "នាមត្រកូល:";
            // 
            // txtStaffID
            // 
            txtStaffID.Enabled = false;
            txtStaffID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffID.Location = new Point(209, 33);
            txtStaffID.Name = "txtStaffID";
            txtStaffID.Size = new Size(324, 30);
            txtStaffID.TabIndex = 3;
            // 
            // lblStaffLastName
            // 
            lblStaffLastName.AutoSize = true;
            lblStaffLastName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffLastName.Location = new Point(436, 106);
            lblStaffLastName.Name = "lblStaffLastName";
            lblStaffLastName.Size = new Size(72, 25);
            lblStaffLastName.TabIndex = 6;
            lblStaffLastName.Text = "នាមខ្លួន:";
            // 
            // txtStaffLastName
            // 
            txtStaffLastName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffLastName.Location = new Point(531, 98);
            txtStaffLastName.Name = "txtStaffLastName";
            txtStaffLastName.Size = new Size(312, 30);
            txtStaffLastName.TabIndex = 7;
            // 
            // lblStaffSex
            // 
            lblStaffSex.AutoSize = true;
            lblStaffSex.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffSex.Location = new Point(18, 164);
            lblStaffSex.Name = "lblStaffSex";
            lblStaffSex.Size = new Size(45, 25);
            lblStaffSex.TabIndex = 8;
            lblStaffSex.Text = "ភេទ:";
            // 
            // lblStaffBirthDate
            // 
            lblStaffBirthDate.AutoSize = true;
            lblStaffBirthDate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffBirthDate.Location = new Point(377, 164);
            lblStaffBirthDate.Name = "lblStaffBirthDate";
            lblStaffBirthDate.Size = new Size(118, 25);
            lblStaffBirthDate.TabIndex = 10;
            lblStaffBirthDate.Text = "ថ្ងៃខែឆ្នាំកំណើត:";
            // 
            // dtpStaffBirthDate
            // 
            dtpStaffBirthDate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpStaffBirthDate.Format = DateTimePickerFormat.Short;
            dtpStaffBirthDate.Location = new Point(531, 156);
            dtpStaffBirthDate.Name = "dtpStaffBirthDate";
            dtpStaffBirthDate.Size = new Size(312, 30);
            dtpStaffBirthDate.TabIndex = 11;
            // 
            // lblStaffIdentityCardNumber
            // 
            lblStaffIdentityCardNumber.AutoSize = true;
            lblStaffIdentityCardNumber.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffIdentityCardNumber.Location = new Point(18, 221);
            lblStaffIdentityCardNumber.Name = "lblStaffIdentityCardNumber";
            lblStaffIdentityCardNumber.Size = new Size(152, 25);
            lblStaffIdentityCardNumber.TabIndex = 12;
            lblStaffIdentityCardNumber.Text = "លេខអត្តសញ្ញាណប័ណ្ណ:";
            // 
            // txtStaffIdentityCardNumber
            // 
            txtStaffIdentityCardNumber.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffIdentityCardNumber.Location = new Point(227, 218);
            txtStaffIdentityCardNumber.Name = "txtStaffIdentityCardNumber";
            txtStaffIdentityCardNumber.Size = new Size(236, 30);
            txtStaffIdentityCardNumber.TabIndex = 13;
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
            // btnCloseFormStaff
            // 
            btnCloseFormStaff.Location = new Point(801, 20);
            btnCloseFormStaff.Name = "btnCloseFormStaff";
            btnCloseFormStaff.Size = new Size(152, 52);
            btnCloseFormStaff.TabIndex = 3;
            btnCloseFormStaff.Text = "បិទ";
            btnCloseFormStaff.UseVisualStyleBackColor = true;
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
            // btnUpdateStaff
            // 
            btnUpdateStaff.Location = new Point(305, 20);
            btnUpdateStaff.Name = "btnUpdateStaff";
            btnUpdateStaff.Size = new Size(152, 52);
            btnUpdateStaff.TabIndex = 1;
            btnUpdateStaff.Text = "កែប្រែ";
            btnUpdateStaff.UseVisualStyleBackColor = true;
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
            // FrmStaff
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1782, 953);
            Controls.Add(pnlStaffManipulation);
            Controls.Add(pnlRightSide);
            Controls.Add(pnlLeftSide);
            Controls.Add(lblTitle);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FrmStaff";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormStaff";
            Load += FrmStaff_Load;
            pnlLeftSide.ResumeLayout(false);
            pnlLeftSide.PerformLayout();
            pnlRightSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbStaffPhoto).EndInit();
            gbStaffAddress.ResumeLayout(false);
            gbStaffAddress.PerformLayout();
            gbStaffInformation.ResumeLayout(false);
            gbStaffInformation.PerformLayout();
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