namespace Store_Rental_Management_Systems
{
    partial class FrmMaintenace
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
            gbMaintenanceInformation = new GroupBox();
            lblMaintenanceID = new Label();
            lblMaintenanceContractID = new Label();
            txtMaintenanceTotalAmount = new TextBox();

            txtMaintenanceID = new TextBox();
            lblMaintenancePaidAmount = new Label();
            txtMaintenancePaidAmount = new TextBox();
   
            dtpMaintenanceDate = new DateTimePicker();
            lblMaintenanceOwedAmount = new Label();
            txtMaintenanceOwedAmount = new TextBox();
            cbMaintenanceContractID = new ComboBox();
            lblMaintenanceStoreID = new Label();
            cbMaintenanceStoreID = new ComboBox();
            gbMaintenanceInformation.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(1394, 0);
            // 
            // gbMaintenanceInformation
            // 
            gbMaintenanceInformation.Controls.Add(cbMaintenanceStoreID);
            gbMaintenanceInformation.Controls.Add(lblMaintenanceStoreID);
            gbMaintenanceInformation.Controls.Add(cbMaintenanceContractID);
            gbMaintenanceInformation.Controls.Add(txtMaintenanceOwedAmount);
            gbMaintenanceInformation.Controls.Add(lblMaintenanceOwedAmount);
            gbMaintenanceInformation.Controls.Add(lblMaintenanceID);
            gbMaintenanceInformation.Controls.Add(lblMaintenanceContractID);
            gbMaintenanceInformation.Controls.Add(txtMaintenanceTotalAmount);

            gbMaintenanceInformation.Controls.Add(txtMaintenanceID);
            gbMaintenanceInformation.Controls.Add(lblMaintenancePaidAmount);
            gbMaintenanceInformation.Controls.Add(txtMaintenancePaidAmount);

            gbMaintenanceInformation.Controls.Add(dtpMaintenanceDate);
            gbMaintenanceInformation.Font = new Font("!Khmer OS Siemreap", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            gbMaintenanceInformation.Location = new Point(350, 120);
            gbMaintenanceInformation.Name = "gbMaintenanceInformation";
            gbMaintenanceInformation.Size = new Size(1382, 234);
            gbMaintenanceInformation.TabIndex = 26;
            gbMaintenanceInformation.TabStop = false;
            gbMaintenanceInformation.Text = "ព័ត៌មានថែទាំ";
            // 
            // lblMaintenanceID
            // 
            lblMaintenanceID.AutoSize = true;
            lblMaintenanceID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMaintenanceID.Location = new Point(18, 41);
            lblMaintenanceID.Name = "lblMaintenanceID";
            lblMaintenanceID.Size = new Size(187, 36);
            lblMaintenanceID.TabIndex = 0;
            lblMaintenanceID.Text = "លេខសម្គាល់ការថែទាំ:";
            // 
            // lblMaintenanceContractID
            // 
            lblMaintenanceContractID.AutoSize = true;
            lblMaintenanceContractID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMaintenanceContractID.Location = new Point(840, 106);
            lblMaintenanceContractID.Name = "lblMaintenanceContractID";
            lblMaintenanceContractID.Size = new Size(196, 36);
            lblMaintenanceContractID.TabIndex = 14;
            lblMaintenanceContractID.Text = "លេខសម្គាល់កិច្ចសន្យា:";
            // 
            // txtMaintenanceTotalAmount
            // 
            txtMaintenanceTotalAmount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaintenanceTotalAmount.Location = new Point(1048, 33);
            txtMaintenanceTotalAmount.Name = "txtMaintenanceTotalAmount";
            txtMaintenanceTotalAmount.Size = new Size(217, 44);
            txtMaintenanceTotalAmount.TabIndex = 5;

            // 
            // txtMaintenanceID
            // 
            txtMaintenanceID.Enabled = false;
            txtMaintenanceID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaintenanceID.Location = new Point(209, 33);
            txtMaintenanceID.Name = "txtMaintenanceID";
            txtMaintenanceID.Size = new Size(223, 44);
            txtMaintenanceID.TabIndex = 3;
            // 
            // lblMaintenancePaidAmount
            // 
            lblMaintenancePaidAmount.AutoSize = true;
            lblMaintenancePaidAmount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMaintenancePaidAmount.Location = new Point(18, 106);
            lblMaintenancePaidAmount.Name = "lblMaintenancePaidAmount";
            lblMaintenancePaidAmount.Size = new Size(137, 36);
            lblMaintenancePaidAmount.TabIndex = 6;
            lblMaintenancePaidAmount.Text = "តម្លៃបានទូទាត់:";
            // 
            // txtMaintenancePaidAmount
            // 
            txtMaintenancePaidAmount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaintenancePaidAmount.Location = new Point(209, 103);
            txtMaintenancePaidAmount.Name = "txtMaintenancePaidAmount";
            txtMaintenancePaidAmount.Size = new Size(223, 44);
            txtMaintenancePaidAmount.TabIndex = 7;
   
            // 
            // dtpMaintenanceDate
            // 
            dtpMaintenanceDate.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpMaintenanceDate.Format = DateTimePickerFormat.Short;
            dtpMaintenanceDate.Location = new Point(647, 35);
            dtpMaintenanceDate.Name = "dtpMaintenanceDate";
            dtpMaintenanceDate.Size = new Size(208, 44);
            dtpMaintenanceDate.TabIndex = 11;
            // 
            // lblMaintenanceOwedAmount
            // 
            lblMaintenanceOwedAmount.AutoSize = true;
            lblMaintenanceOwedAmount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMaintenanceOwedAmount.Location = new Point(486, 111);
            lblMaintenanceOwedAmount.Name = "lblMaintenanceOwedAmount";
            lblMaintenanceOwedAmount.Size = new Size(103, 36);
            lblMaintenanceOwedAmount.TabIndex = 25;
            lblMaintenanceOwedAmount.Text = "តម្លៃជំពាក់:";
            // 
            // txtMaintenanceOwedAmount
            // 
            txtMaintenanceOwedAmount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaintenanceOwedAmount.Location = new Point(595, 103);
            txtMaintenanceOwedAmount.Name = "txtMaintenanceOwedAmount";
            txtMaintenanceOwedAmount.Size = new Size(223, 44);
            txtMaintenanceOwedAmount.TabIndex = 26;
            // 
            // cbMaintenanceContractID
            // 
            cbMaintenanceContractID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMaintenanceContractID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbMaintenanceContractID.FormattingEnabled = true;
            cbMaintenanceContractID.Items.AddRange(new object[] { "អ្នកគ្រប់គ្រង", "គណនីករ" });
            cbMaintenanceContractID.Location = new Point(1046, 103);
            cbMaintenanceContractID.Name = "cbMaintenanceContractID";
            cbMaintenanceContractID.Size = new Size(219, 44);
            cbMaintenanceContractID.TabIndex = 27;
            // 
            // lblMaintenanceStoreID
            // 
            lblMaintenanceStoreID.AutoSize = true;
            lblMaintenanceStoreID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMaintenanceStoreID.Location = new Point(18, 168);
            lblMaintenanceStoreID.Name = "lblMaintenanceStoreID";
            lblMaintenanceStoreID.Size = new Size(149, 36);
            lblMaintenanceStoreID.TabIndex = 28;
            lblMaintenanceStoreID.Text = "លេខសម្គាល់តូប:";
            // 
            // cbMaintenanceStoreID
            // 
            cbMaintenanceStoreID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMaintenanceStoreID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbMaintenanceStoreID.FormattingEnabled = true;
            cbMaintenanceStoreID.Items.AddRange(new object[] { "អ្នកគ្រប់គ្រង", "គណនីករ" });
            cbMaintenanceStoreID.Location = new Point(209, 160);
            cbMaintenanceStoreID.Name = "cbMaintenanceStoreID";
            cbMaintenanceStoreID.Size = new Size(219, 44);
            cbMaintenanceStoreID.TabIndex = 29;
            // 
            // FrmMaintenace
            // 
            AutoScaleDimensions = new SizeF(11F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1800, 1000);
            Controls.Add(gbMaintenanceInformation);
            Name = "FrmMaintenace";
            Text = "FrmMaintenace";
            Controls.SetChildIndex(gbMaintenanceInformation, 0);
            gbMaintenanceInformation.ResumeLayout(false);
            gbMaintenanceInformation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbMaintenanceInformation;
        private Label lblMaintenanceID;
        private Label lblMaintenanceContractID;
        private TextBox txtMaintenanceTotalAmount;
        private TextBox txtMaintenanceID;
        private Label lblMaintenancePaidAmount;
        private TextBox txtMaintenancePaidAmount;
        private Label lblStaffBirthDate;
        private DateTimePicker dtpMaintenanceDate;
        private Label lblMaintenanceOwedAmount;
        private TextBox txtMaintenanceOwedAmount;
        private ComboBox cbMaintenanceContractID;
        private Label lblMaintenanceStoreID;
        private ComboBox cbMaintenanceStoreID;
    }
}