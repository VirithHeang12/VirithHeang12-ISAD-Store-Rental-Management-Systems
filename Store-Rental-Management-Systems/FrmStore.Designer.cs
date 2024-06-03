namespace Store_Rental_Management_Systems
{
    partial class FrmStore
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
            lbStore = new ListBox();
            lblSearchStore = new Label();
            txtStoreSearchID = new TextBox();
            panel3 = new Panel();
            gbMaintenanceInformation = new GroupBox();
            txtStoreWaterRecord = new TextBox();
            lblStoreTypeID = new Label();
            txtStoreFloor = new TextBox();
            cbStoreStoreTypeID = new ComboBox();
            txtStaffName = new TextBox();
            lblStoreStatus = new Label();
            lblStoreElectricityRecord = new Label();
            lblStoreWaterRecord = new Label();
            lblStoreFloor = new Label();
            lblStoreID = new Label();
            txtStoreID = new TextBox();
            txtStoreElectricityRecord = new TextBox();
            lblTitle = new Label();
            btnLogOutStore = new Button();
            btnNewStore = new Button();
            btnUpdateStore = new Button();
            btnInsertStore = new Button();
            panel2.SuspendLayout();
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
            panel2.Controls.Add(lbStore);
            panel2.Controls.Add(lblSearchStore);
            panel2.Controls.Add(txtStoreSearchID);
            panel2.Location = new Point(272, 244);
            panel2.Name = "panel2";
            panel2.Size = new Size(386, 493);
            panel2.TabIndex = 55;
            // 
            // lbStore
            // 
            lbStore.FormattingEnabled = true;
            lbStore.ItemHeight = 43;
            lbStore.Location = new Point(31, 131);
            lbStore.Name = "lbStore";
            lbStore.Size = new Size(319, 305);
            lbStore.TabIndex = 6;
            // 
            // lblSearchStore
            // 
            lblSearchStore.AutoSize = true;
            lblSearchStore.Location = new Point(31, 11);
            lblSearchStore.Name = "lblSearchStore";
            lblSearchStore.Size = new Size(97, 43);
            lblSearchStore.TabIndex = 4;
            lblSearchStore.Text = "ស្វែងរក:";
            // 
            // txtStoreSearchID
            // 
            txtStoreSearchID.Location = new Point(31, 57);
            txtStoreSearchID.Name = "txtStoreSearchID";
            txtStoreSearchID.Size = new Size(319, 51);
            txtStoreSearchID.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Controls.Add(gbMaintenanceInformation);
            panel3.Location = new Point(676, 301);
            panel3.Name = "panel3";
            panel3.Size = new Size(1097, 425);
            panel3.TabIndex = 56;
            // 
            // gbMaintenanceInformation
            // 
            gbMaintenanceInformation.Controls.Add(txtStoreWaterRecord);
            gbMaintenanceInformation.Controls.Add(lblStoreTypeID);
            gbMaintenanceInformation.Controls.Add(txtStoreFloor);
            gbMaintenanceInformation.Controls.Add(cbStoreStoreTypeID);
            gbMaintenanceInformation.Controls.Add(txtStaffName);
            gbMaintenanceInformation.Controls.Add(lblStoreStatus);
            gbMaintenanceInformation.Controls.Add(lblStoreElectricityRecord);
            gbMaintenanceInformation.Controls.Add(lblStoreWaterRecord);
            gbMaintenanceInformation.Controls.Add(lblStoreFloor);
            gbMaintenanceInformation.Controls.Add(lblStoreID);
            gbMaintenanceInformation.Controls.Add(txtStoreID);
            gbMaintenanceInformation.Controls.Add(txtStoreElectricityRecord);
            gbMaintenanceInformation.Font = new Font("Khmer OS Siemreap", 10F, FontStyle.Bold, GraphicsUnit.Point);
            gbMaintenanceInformation.Location = new Point(13, 74);
            gbMaintenanceInformation.Name = "gbMaintenanceInformation";
            gbMaintenanceInformation.Size = new Size(1069, 314);
            gbMaintenanceInformation.TabIndex = 50;
            gbMaintenanceInformation.TabStop = false;
            gbMaintenanceInformation.Text = "ព័ត៌មានតូប";
            // 
            // txtStoreWaterRecord
            // 
            txtStoreWaterRecord.Enabled = false;
            txtStoreWaterRecord.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStoreWaterRecord.Location = new Point(826, 135);
            txtStoreWaterRecord.Name = "txtStoreWaterRecord";
            txtStoreWaterRecord.Size = new Size(219, 51);
            txtStoreWaterRecord.TabIndex = 38;
            // 
            // lblStoreTypeID
            // 
            lblStoreTypeID.AutoSize = true;
            lblStoreTypeID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStoreTypeID.Location = new Point(577, 212);
            lblStoreTypeID.Name = "lblStoreTypeID";
            lblStoreTypeID.Size = new Size(239, 43);
            lblStoreTypeID.TabIndex = 37;
            lblStoreTypeID.Text = "លេខសម្គាល់ប្រភេទតូប:";
            // 
            // txtStoreFloor
            // 
            txtStoreFloor.Enabled = false;
            txtStoreFloor.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStoreFloor.Location = new Point(825, 64);
            txtStoreFloor.Name = "txtStoreFloor";
            txtStoreFloor.Size = new Size(219, 51);
            txtStoreFloor.TabIndex = 36;
            // 
            // cbStoreStoreTypeID
            // 
            cbStoreStoreTypeID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStoreStoreTypeID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbStoreStoreTypeID.FormattingEnabled = true;
            cbStoreStoreTypeID.Items.AddRange(new object[] { "អ្នកគ្រប់គ្រង", "គណនីករ" });
            cbStoreStoreTypeID.Location = new Point(826, 206);
            cbStoreStoreTypeID.Name = "cbStoreStoreTypeID";
            cbStoreStoreTypeID.Size = new Size(219, 51);
            cbStoreStoreTypeID.TabIndex = 35;
            // 
            // txtStaffName
            // 
            txtStaffName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffName.Location = new Point(292, 208);
            txtStaffName.Name = "txtStaffName";
            txtStaffName.Size = new Size(237, 51);
            txtStaffName.TabIndex = 33;
            // 
            // lblStoreStatus
            // 
            lblStoreStatus.AutoSize = true;
            lblStoreStatus.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStoreStatus.Location = new Point(21, 209);
            lblStoreStatus.Name = "lblStoreStatus";
            lblStoreStatus.Size = new Size(113, 43);
            lblStoreStatus.TabIndex = 32;
            lblStoreStatus.Text = "ស្ថានភាព:";
            // 
            // lblStoreElectricityRecord
            // 
            lblStoreElectricityRecord.AutoSize = true;
            lblStoreElectricityRecord.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStoreElectricityRecord.Location = new Point(21, 138);
            lblStoreElectricityRecord.Name = "lblStoreElectricityRecord";
            lblStoreElectricityRecord.Size = new Size(200, 43);
            lblStoreElectricityRecord.TabIndex = 31;
            lblStoreElectricityRecord.Text = "លេខកុងទ័រអគ្គិសនី:";
            // 
            // lblStoreWaterRecord
            // 
            lblStoreWaterRecord.AutoSize = true;
            lblStoreWaterRecord.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStoreWaterRecord.Location = new Point(574, 143);
            lblStoreWaterRecord.Name = "lblStoreWaterRecord";
            lblStoreWaterRecord.Size = new Size(163, 43);
            lblStoreWaterRecord.TabIndex = 30;
            lblStoreWaterRecord.Text = "លេខកុងទ័រទឹកៈ";
            // 
            // lblStoreFloor
            // 
            lblStoreFloor.AutoSize = true;
            lblStoreFloor.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStoreFloor.Location = new Point(571, 70);
            lblStoreFloor.Name = "lblStoreFloor";
            lblStoreFloor.Size = new Size(216, 43);
            lblStoreFloor.TabIndex = 28;
            lblStoreFloor.Text = "ជាន់ដែលតូបស្ថិតនៅ:";
            // 
            // lblStoreID
            // 
            lblStoreID.AutoSize = true;
            lblStoreID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStoreID.Location = new Point(21, 67);
            lblStoreID.Name = "lblStoreID";
            lblStoreID.Size = new Size(222, 43);
            lblStoreID.TabIndex = 0;
            lblStoreID.Text = "លេខសម្គាល់របស់តូប:";
            // 
            // txtStoreID
            // 
            txtStoreID.Enabled = false;
            txtStoreID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStoreID.Location = new Point(292, 59);
            txtStoreID.Name = "txtStoreID";
            txtStoreID.Size = new Size(237, 51);
            txtStoreID.TabIndex = 3;
            // 
            // txtStoreElectricityRecord
            // 
            txtStoreElectricityRecord.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStoreElectricityRecord.Location = new Point(292, 130);
            txtStoreElectricityRecord.Name = "txtStoreElectricityRecord";
            txtStoreElectricityRecord.Size = new Size(237, 51);
            txtStoreElectricityRecord.TabIndex = 7;
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
            lblTitle.TabIndex = 57;
            lblTitle.Text = "ព័ត៌មានតូប";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLogOutStore
            // 
            btnLogOutStore.AutoSize = true;
            btnLogOutStore.BackColor = Color.FromArgb(0, 28, 87);
            btnLogOutStore.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogOutStore.ForeColor = Color.White;
            btnLogOutStore.Location = new Point(1228, 753);
            btnLogOutStore.Name = "btnLogOutStore";
            btnLogOutStore.Size = new Size(128, 60);
            btnLogOutStore.TabIndex = 61;
            btnLogOutStore.Text = "បិទ";
            btnLogOutStore.UseVisualStyleBackColor = false;
            // 
            // btnNewStore
            // 
            btnNewStore.AutoSize = true;
            btnNewStore.BackColor = Color.FromArgb(0, 28, 87);
            btnNewStore.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNewStore.ForeColor = Color.White;
            btnNewStore.Location = new Point(1042, 753);
            btnNewStore.Name = "btnNewStore";
            btnNewStore.Size = new Size(128, 60);
            btnNewStore.TabIndex = 60;
            btnNewStore.Text = "បង្កើតថ្មី";
            btnNewStore.UseVisualStyleBackColor = false;
            // 
            // btnUpdateStore
            // 
            btnUpdateStore.AutoSize = true;
            btnUpdateStore.BackColor = Color.FromArgb(0, 28, 87);
            btnUpdateStore.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateStore.ForeColor = Color.White;
            btnUpdateStore.Location = new Point(857, 753);
            btnUpdateStore.Name = "btnUpdateStore";
            btnUpdateStore.Size = new Size(128, 60);
            btnUpdateStore.TabIndex = 59;
            btnUpdateStore.Text = "កែប្រែ";
            btnUpdateStore.UseVisualStyleBackColor = false;
            // 
            // btnInsertStore
            // 
            btnInsertStore.AutoSize = true;
            btnInsertStore.BackColor = Color.FromArgb(0, 28, 87);
            btnInsertStore.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsertStore.ForeColor = Color.White;
            btnInsertStore.Location = new Point(673, 753);
            btnInsertStore.Name = "btnInsertStore";
            btnInsertStore.Size = new Size(128, 60);
            btnInsertStore.TabIndex = 58;
            btnInsertStore.Text = "បញ្ចូល";
            btnInsertStore.UseVisualStyleBackColor = false;
            // 
            // FrmStore
            // 
            AutoScaleDimensions = new SizeF(13F, 43F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1800, 1000);
            Controls.Add(btnLogOutStore);
            Controls.Add(btnNewStore);
            Controls.Add(btnUpdateStore);
            Controls.Add(btnInsertStore);
            Controls.Add(lblTitle);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "FrmStore";
            Text = "FrmStore";
            Controls.SetChildIndex(panel2, 0);
            Controls.SetChildIndex(panel3, 0);
            Controls.SetChildIndex(lblTitle, 0);
            Controls.SetChildIndex(btnInsertStore, 0);
            Controls.SetChildIndex(btnUpdateStore, 0);
            Controls.SetChildIndex(btnNewStore, 0);
            Controls.SetChildIndex(btnLogOutStore, 0);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            gbMaintenanceInformation.ResumeLayout(false);
            gbMaintenanceInformation.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Label lblSearchStore;
        private TextBox txtStoreSearchID;
        private Panel panel3;
        private GroupBox gbMaintenanceInformation;
        private TextBox txtStoreFloor;
        private ComboBox cbStaffID;
        private TextBox txtStaffName;
        private Label lblStoreElectricityRecord;
        private Label lblStoreWaterRecord;
        private Label lblStoreFloor;
        private Label lblStoreID;
        private TextBox txtStoreID;
        private TextBox txtStoreElectricityRecord;
        private ListBox lbStore;
        private Button btnLogOutUser;
        private Button btnNewUser;
        private Button btnUpdateUser;
        private Label lblTitle;
        private Label lblStoreStatus;
        private Label lblStoreTypeID;
        private ComboBox cbStoreStoreTypeID;
        private TextBox txtStoreWaterRecord;
        private Button btnLogOutStore;
        private Button btnNewStore;
        private Button btnUpdateStore;
        private Button btnInsertStore;
    }
}