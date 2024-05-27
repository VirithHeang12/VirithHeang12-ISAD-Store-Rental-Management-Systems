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
            lblSearch = new Label();
            txtSearch = new TextBox();
            pnlLeftSide = new Panel();
            lbStaff = new ListBox();
            pnlRightSide = new Panel();
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
            cbStaffSex = new ComboBox();
            lblStaffSex = new Label();
            txtStaffLastName = new TextBox();
            lblStaffLastName = new Label();
            txtStaffFirstName = new TextBox();
            label1 = new Label();
            txtStaffID = new TextBox();
            lblStaffID = new Label();
            pnlLeftSide.SuspendLayout();
            pnlRightSide.SuspendLayout();
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
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(38, 11);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(84, 36);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(38, 50);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(319, 44);
            txtSearch.TabIndex = 2;
            // 
            // pnlLeftSide
            // 
            pnlLeftSide.Controls.Add(lbStaff);
            pnlLeftSide.Controls.Add(lblSearch);
            pnlLeftSide.Controls.Add(txtSearch);
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
            pnlRightSide.Controls.Add(txtStaffStreetNo);
            pnlRightSide.Controls.Add(lblStaffStreetNo);
            pnlRightSide.Controls.Add(txtStaffHouseNo);
            pnlRightSide.Controls.Add(lblStaffHouseNo);
            pnlRightSide.Controls.Add(cbStaffPosition);
            pnlRightSide.Controls.Add(lblStaffPosition);
            pnlRightSide.Controls.Add(txtStaffIdentityCardNumber);
            pnlRightSide.Controls.Add(lblStaffIdentityCardNumber);
            pnlRightSide.Controls.Add(dtpStaffBirthDate);
            pnlRightSide.Controls.Add(lblStaffBirthDate);
            pnlRightSide.Controls.Add(cbStaffSex);
            pnlRightSide.Controls.Add(lblStaffSex);
            pnlRightSide.Controls.Add(txtStaffLastName);
            pnlRightSide.Controls.Add(lblStaffLastName);
            pnlRightSide.Controls.Add(txtStaffFirstName);
            pnlRightSide.Controls.Add(label1);
            pnlRightSide.Controls.Add(txtStaffID);
            pnlRightSide.Controls.Add(lblStaffID);
            pnlRightSide.Location = new Point(468, 147);
            pnlRightSide.Name = "pnlRightSide";
            pnlRightSide.Size = new Size(1267, 673);
            pnlRightSide.TabIndex = 4;
            // 
            // txtStaffStreetNo
            // 
            txtStaffStreetNo.Location = new Point(236, 534);
            txtStaffStreetNo.Name = "txtStaffStreetNo";
            txtStaffStreetNo.Size = new Size(200, 44);
            txtStaffStreetNo.TabIndex = 19;
            // 
            // lblStaffStreetNo
            // 
            lblStaffStreetNo.AutoSize = true;
            lblStaffStreetNo.Location = new Point(30, 556);
            lblStaffStreetNo.Name = "lblStaffStreetNo";
            lblStaffStreetNo.Size = new Size(81, 36);
            lblStaffStreetNo.TabIndex = 18;
            lblStaffStreetNo.Text = "លេខផ្លូវ:";
            // 
            // txtStaffHouseNo
            // 
            txtStaffHouseNo.Location = new Point(236, 463);
            txtStaffHouseNo.Name = "txtStaffHouseNo";
            txtStaffHouseNo.Size = new Size(200, 44);
            txtStaffHouseNo.TabIndex = 17;
            // 
            // lblStaffHouseNo
            // 
            lblStaffHouseNo.AutoSize = true;
            lblStaffHouseNo.Location = new Point(30, 471);
            lblStaffHouseNo.Name = "lblStaffHouseNo";
            lblStaffHouseNo.Size = new Size(84, 36);
            lblStaffHouseNo.TabIndex = 16;
            lblStaffHouseNo.Text = "លេខផ្ទះ:";
            // 
            // cbStaffPosition
            // 
            cbStaffPosition.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStaffPosition.FormattingEnabled = true;
            cbStaffPosition.Location = new Point(236, 398);
            cbStaffPosition.Name = "cbStaffPosition";
            cbStaffPosition.Size = new Size(200, 44);
            cbStaffPosition.TabIndex = 15;
            // 
            // lblStaffPosition
            // 
            lblStaffPosition.AutoSize = true;
            lblStaffPosition.Location = new Point(30, 406);
            lblStaffPosition.Name = "lblStaffPosition";
            lblStaffPosition.Size = new Size(69, 36);
            lblStaffPosition.TabIndex = 14;
            lblStaffPosition.Text = "តួនាទី:";
            // 
            // txtStaffIdentityCardNumber
            // 
            txtStaffIdentityCardNumber.Location = new Point(236, 333);
            txtStaffIdentityCardNumber.Name = "txtStaffIdentityCardNumber";
            txtStaffIdentityCardNumber.Size = new Size(200, 44);
            txtStaffIdentityCardNumber.TabIndex = 13;
            // 
            // lblStaffIdentityCardNumber
            // 
            lblStaffIdentityCardNumber.AutoSize = true;
            lblStaffIdentityCardNumber.Location = new Point(30, 341);
            lblStaffIdentityCardNumber.Name = "lblStaffIdentityCardNumber";
            lblStaffIdentityCardNumber.Size = new Size(203, 36);
            lblStaffIdentityCardNumber.TabIndex = 12;
            lblStaffIdentityCardNumber.Text = "លេខអត្តសញ្ញាណប័ណ្ណ:";
            // 
            // dtpStaffBirthDate
            // 
            dtpStaffBirthDate.Format = DateTimePickerFormat.Short;
            dtpStaffBirthDate.Location = new Point(236, 260);
            dtpStaffBirthDate.Name = "dtpStaffBirthDate";
            dtpStaffBirthDate.Size = new Size(200, 44);
            dtpStaffBirthDate.TabIndex = 11;
            // 
            // lblStaffBirthDate
            // 
            lblStaffBirthDate.AutoSize = true;
            lblStaffBirthDate.Location = new Point(30, 268);
            lblStaffBirthDate.Name = "lblStaffBirthDate";
            lblStaffBirthDate.Size = new Size(142, 36);
            lblStaffBirthDate.TabIndex = 10;
            lblStaffBirthDate.Text = "ថ្ងៃខែឆ្នាំកំណើត:";
            // 
            // cbStaffSex
            // 
            cbStaffSex.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStaffSex.FormattingEnabled = true;
            cbStaffSex.Items.AddRange(new object[] { "Male", "Female" });
            cbStaffSex.Location = new Point(236, 193);
            cbStaffSex.Name = "cbStaffSex";
            cbStaffSex.Size = new Size(200, 44);
            cbStaffSex.TabIndex = 9;
            // 
            // lblStaffSex
            // 
            lblStaffSex.AutoSize = true;
            lblStaffSex.Location = new Point(30, 201);
            lblStaffSex.Name = "lblStaffSex";
            lblStaffSex.Size = new Size(55, 36);
            lblStaffSex.TabIndex = 8;
            lblStaffSex.Text = "ភេទ:";
            // 
            // txtStaffLastName
            // 
            txtStaffLastName.Location = new Point(236, 129);
            txtStaffLastName.Name = "txtStaffLastName";
            txtStaffLastName.Size = new Size(200, 44);
            txtStaffLastName.TabIndex = 7;
            // 
            // lblStaffLastName
            // 
            lblStaffLastName.AutoSize = true;
            lblStaffLastName.Location = new Point(30, 137);
            lblStaffLastName.Name = "lblStaffLastName";
            lblStaffLastName.Size = new Size(83, 36);
            lblStaffLastName.TabIndex = 6;
            lblStaffLastName.Text = "នាមខ្លួន:";
            // 
            // txtStaffFirstName
            // 
            txtStaffFirstName.Location = new Point(236, 68);
            txtStaffFirstName.Name = "txtStaffFirstName";
            txtStaffFirstName.Size = new Size(200, 44);
            txtStaffFirstName.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 76);
            label1.Name = "label1";
            label1.Size = new Size(109, 36);
            label1.TabIndex = 4;
            label1.Text = "នាមត្រកូល:";
            // 
            // txtStaffID
            // 
            txtStaffID.Location = new Point(236, 8);
            txtStaffID.Name = "txtStaffID";
            txtStaffID.Size = new Size(200, 44);
            txtStaffID.TabIndex = 3;
            // 
            // lblStaffID
            // 
            lblStaffID.AutoSize = true;
            lblStaffID.Location = new Point(30, 16);
            lblStaffID.Name = "lblStaffID";
            lblStaffID.Size = new Size(183, 36);
            lblStaffID.TabIndex = 0;
            lblStaffID.Text = "លេខសម្គាល់បុគ្គលិក:";
            // 
            // FrmStaff
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1782, 953);
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
            pnlRightSide.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblSearch;
        private TextBox txtSearch;
        private Panel pnlLeftSide;
        private ListBox lbStaff;
        private Panel pnlRightSide;
        private Label lblStaffID;
        private ComboBox cbStaffSex;
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
    }
}