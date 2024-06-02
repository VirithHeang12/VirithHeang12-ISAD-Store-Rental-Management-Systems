namespace Store_Rental_Management_Systems
{
    partial class FrmUser
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
            panel2 = new Panel();
            lbUser = new ListBox();
            lblSearchStaff = new Label();
            txtUserSearchID = new TextBox();
            panel4 = new Panel();
            btnLogOutUser = new Button();
            btnNewUser = new Button();
            btnUpdateUser = new Button();
            btnInsertUser = new Button();
            panel3 = new Panel();
            gbMaintenanceInformation = new GroupBox();
            txtUserPassword = new TextBox();
            cbStaffPosition = new ComboBox();
            cbStaffID = new ComboBox();
            txtStaffName = new TextBox();
            lblStaffPosition = new Label();
            lblStaffName = new Label();
            lblStaffID = new Label();
            lblUserPassword = new Label();
            lblUserName = new Label();
            lblUserID = new Label();
            txtUserID = new TextBox();
            txtUserName = new TextBox();
            lblTitle = new Label();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            gbMaintenanceInformation.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(1394, 0);
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(lbUser);
            panel2.Controls.Add(lblSearchStaff);
            panel2.Controls.Add(txtUserSearchID);
            panel2.Location = new Point(291, 220);
            panel2.Name = "panel2";
            panel2.Size = new Size(386, 493);
            panel2.TabIndex = 50;
            // 
            // lbUser
            // 
            lbUser.FormattingEnabled = true;
            lbUser.ItemHeight = 43;
            lbUser.Location = new Point(31, 131);
            lbUser.Name = "lbUser";
            lbUser.Size = new Size(319, 305);
            lbUser.TabIndex = 6;
            // 
            // lblSearchStaff
            // 
            lblSearchStaff.AutoSize = true;
            lblSearchStaff.Location = new Point(31, 11);
            lblSearchStaff.Name = "lblSearchStaff";
            lblSearchStaff.Size = new Size(97, 43);
            lblSearchStaff.TabIndex = 4;
            lblSearchStaff.Text = "ស្វែងរក:";
            // 
            // txtUserSearchID
            // 
            txtUserSearchID.Location = new Point(31, 57);
            txtUserSearchID.Name = "txtUserSearchID";
            txtUserSearchID.Size = new Size(319, 51);
            txtUserSearchID.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnLogOutUser);
            panel4.Controls.Add(btnNewUser);
            panel4.Controls.Add(btnUpdateUser);
            panel4.Controls.Add(btnInsertUser);
            panel4.Location = new Point(696, 699);
            panel4.Name = "panel4";
            panel4.Size = new Size(745, 101);
            panel4.TabIndex = 51;
            // 
            // btnLogOutUser
            // 
            btnLogOutUser.AutoSize = true;
            btnLogOutUser.BackColor = Color.FromArgb(0, 28, 87);
            btnLogOutUser.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogOutUser.ForeColor = Color.White;
            btnLogOutUser.Location = new Point(573, 16);
            btnLogOutUser.Name = "btnLogOutUser";
            btnLogOutUser.Size = new Size(128, 60);
            btnLogOutUser.TabIndex = 57;
            btnLogOutUser.Text = "បិទ";
            btnLogOutUser.UseVisualStyleBackColor = false;
            // 
            // btnNewUser
            // 
            btnNewUser.AutoSize = true;
            btnNewUser.BackColor = Color.FromArgb(0, 28, 87);
            btnNewUser.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNewUser.ForeColor = Color.White;
            btnNewUser.Location = new Point(387, 16);
            btnNewUser.Name = "btnNewUser";
            btnNewUser.Size = new Size(128, 60);
            btnNewUser.TabIndex = 56;
            btnNewUser.Text = "បង្កើតថ្មី";
            btnNewUser.UseVisualStyleBackColor = false;
            // 
            // btnUpdateUser
            // 
            btnUpdateUser.AutoSize = true;
            btnUpdateUser.BackColor = Color.FromArgb(0, 28, 87);
            btnUpdateUser.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateUser.ForeColor = Color.White;
            btnUpdateUser.Location = new Point(202, 16);
            btnUpdateUser.Name = "btnUpdateUser";
            btnUpdateUser.Size = new Size(128, 60);
            btnUpdateUser.TabIndex = 55;
            btnUpdateUser.Text = "កែប្រែ";
            btnUpdateUser.UseVisualStyleBackColor = false;
            // 
            // btnInsertUser
            // 
            btnInsertUser.AutoSize = true;
            btnInsertUser.BackColor = Color.FromArgb(0, 28, 87);
            btnInsertUser.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsertUser.ForeColor = Color.White;
            btnInsertUser.Location = new Point(18, 16);
            btnInsertUser.Name = "btnInsertUser";
            btnInsertUser.Size = new Size(128, 60);
            btnInsertUser.TabIndex = 54;
            btnInsertUser.Text = "បញ្ចូល";
            btnInsertUser.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(gbMaintenanceInformation);
            panel3.Location = new Point(683, 255);
            panel3.Name = "panel3";
            panel3.Size = new Size(1097, 425);
            panel3.TabIndex = 52;
            // 
            // gbMaintenanceInformation
            // 
            gbMaintenanceInformation.Controls.Add(txtUserPassword);
            gbMaintenanceInformation.Controls.Add(cbStaffPosition);
            gbMaintenanceInformation.Controls.Add(cbStaffID);
            gbMaintenanceInformation.Controls.Add(txtStaffName);
            gbMaintenanceInformation.Controls.Add(lblStaffPosition);
            gbMaintenanceInformation.Controls.Add(lblStaffName);
            gbMaintenanceInformation.Controls.Add(lblStaffID);
            gbMaintenanceInformation.Controls.Add(lblUserPassword);
            gbMaintenanceInformation.Controls.Add(lblUserName);
            gbMaintenanceInformation.Controls.Add(lblUserID);
            gbMaintenanceInformation.Controls.Add(txtUserID);
            gbMaintenanceInformation.Controls.Add(txtUserName);
            gbMaintenanceInformation.Font = new Font("Khmer OS Siemreap", 10F, FontStyle.Bold, GraphicsUnit.Point);
            gbMaintenanceInformation.Location = new Point(13, 74);
            gbMaintenanceInformation.Name = "gbMaintenanceInformation";
            gbMaintenanceInformation.Size = new Size(1069, 314);
            gbMaintenanceInformation.TabIndex = 50;
            gbMaintenanceInformation.TabStop = false;
            gbMaintenanceInformation.Text = "ព័ត៌មានអ្នកប្រើប្រាស់";
            // 
            // txtUserPassword
            // 
            txtUserPassword.Enabled = false;
            txtUserPassword.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserPassword.Location = new Point(811, 57);
            txtUserPassword.Name = "txtUserPassword";
            txtUserPassword.Size = new Size(219, 51);
            txtUserPassword.TabIndex = 36;
            // 
            // cbStaffPosition
            // 
            cbStaffPosition.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStaffPosition.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbStaffPosition.FormattingEnabled = true;
            cbStaffPosition.Items.AddRange(new object[] { "អ្នកគ្រប់គ្រង", "គណនីករ" });
            cbStaffPosition.Location = new Point(811, 200);
            cbStaffPosition.Name = "cbStaffPosition";
            cbStaffPosition.Size = new Size(219, 51);
            cbStaffPosition.TabIndex = 35;
            // 
            // cbStaffID
            // 
            cbStaffID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStaffID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbStaffID.FormattingEnabled = true;
            cbStaffID.Items.AddRange(new object[] { "អ្នកគ្រប់គ្រង", "គណនីករ" });
            cbStaffID.Location = new Point(811, 122);
            cbStaffID.Name = "cbStaffID";
            cbStaffID.Size = new Size(219, 51);
            cbStaffID.TabIndex = 34;
            // 
            // txtStaffName
            // 
            txtStaffName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffName.Location = new Point(292, 208);
            txtStaffName.Name = "txtStaffName";
            txtStaffName.Size = new Size(237, 51);
            txtStaffName.TabIndex = 33;
            // 
            // lblStaffPosition
            // 
            lblStaffPosition.AutoSize = true;
            lblStaffPosition.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffPosition.Location = new Point(585, 206);
            lblStaffPosition.Name = "lblStaffPosition";
            lblStaffPosition.Size = new Size(153, 43);
            lblStaffPosition.TabIndex = 32;
            lblStaffPosition.Text = "តួនាទីបុគ្គលិក:";
            // 
            // lblStaffName
            // 
            lblStaffName.AutoSize = true;
            lblStaffName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffName.Location = new Point(21, 208);
            lblStaffName.Name = "lblStaffName";
            lblStaffName.Size = new Size(155, 43);
            lblStaffName.TabIndex = 31;
            lblStaffName.Text = "ឈ្មោះបុគ្គលិក:";
            // 
            // lblStaffID
            // 
            lblStaffID.AutoSize = true;
            lblStaffID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffID.Location = new Point(585, 130);
            lblStaffID.Name = "lblStaffID";
            lblStaffID.Size = new Size(214, 43);
            lblStaffID.TabIndex = 30;
            lblStaffID.Text = "លេខសម្គាល់បុគ្គលិក:";
            // 
            // lblUserPassword
            // 
            lblUserPassword.AutoSize = true;
            lblUserPassword.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserPassword.Location = new Point(585, 65);
            lblUserPassword.Name = "lblUserPassword";
            lblUserPassword.Size = new Size(136, 43);
            lblUserPassword.TabIndex = 29;
            lblUserPassword.Text = "លេខសម្ងាត់:";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserName.Location = new Point(21, 138);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(203, 43);
            lblUserName.TabIndex = 28;
            lblUserName.Text = "ឈ្មោះអ្នកប្រើប្រាស់:";
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserID.Location = new Point(21, 67);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(262, 43);
            lblUserID.TabIndex = 0;
            lblUserID.Text = "លេខសម្គាល់អ្នកប្រើប្រាស់:";
            // 
            // txtUserID
            // 
            txtUserID.Enabled = false;
            txtUserID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserID.Location = new Point(292, 59);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(237, 51);
            txtUserID.TabIndex = 3;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.Location = new Point(292, 130);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(237, 51);
            txtUserName.TabIndex = 7;
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
            lblTitle.TabIndex = 53;
            lblTitle.Text = "ព័ត៌មានអ្នកប្រើប្រាស់";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmUser
            // 
            AutoScaleDimensions = new SizeF(13F, 43F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1800, 1000);
            Controls.Add(lblTitle);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Name = "FrmUser";
            Text = "FrmUser";
            Controls.SetChildIndex(panel2, 0);
            Controls.SetChildIndex(panel4, 0);
            Controls.SetChildIndex(panel3, 0);
            Controls.SetChildIndex(lblTitle, 0);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            gbMaintenanceInformation.ResumeLayout(false);
            gbMaintenanceInformation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel4;
        private ListBox lbUser;
        private Label lblSearchStaff;
        private TextBox txtUserSearchID;
        private Panel panel3;
        private GroupBox gbMaintenanceInformation;
        private Label lblUserPassword;
        private Label lblUserName;
        private Label lblUserID;
        private TextBox txtUserID;
        private TextBox txtUserName;
        private TextBox txtStaffName;
        private Label lblStaffPosition;
        private Label lblStaffName;
        private Label lblStaffID;
        private TextBox txtUserPassword;
        private ComboBox cbStaffPosition;
        private ComboBox cbStaffID;
        private Label lblTitle;
        private Button btnLogOutUser;
        private Button btnNewUser;
        private Button btnUpdateUser;
        private Button btnInsertUser;
    }
}