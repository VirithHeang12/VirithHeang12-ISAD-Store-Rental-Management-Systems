namespace Store_Rental_Management_Systems
{
    partial class FrmSupplier
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            lblTitle = new Label();
            gbMaintenanceInformation = new GroupBox();
            txtSupplierAddress = new TextBox();
            lblSupplierAddress = new Label();
            txtSupplierName = new TextBox();
            lblSupplierContact = new Label();
            lblSupplierID = new Label();
            txtSupplierID = new TextBox();
            lblSupplierName = new Label();
            txtSupplierContact = new TextBox();
            btnLogOutSupplier = new Button();
            btnNewSupplier = new Button();
            btnUpdateSupplier = new Button();
            btnInsertSupplier = new Button();
            lblSupplierSearch = new Label();
            txtSupplierSearchID = new TextBox();
            dgvSupplier = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            gbMaintenanceInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSupplier).BeginInit();
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
            lblTitle.TabIndex = 48;
            lblTitle.Text = "ព័ត៌មានអ្នកផ្គត់ផ្គង់";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gbMaintenanceInformation
            // 
            gbMaintenanceInformation.Controls.Add(txtSupplierAddress);
            gbMaintenanceInformation.Controls.Add(lblSupplierAddress);
            gbMaintenanceInformation.Controls.Add(txtSupplierName);
            gbMaintenanceInformation.Controls.Add(lblSupplierContact);
            gbMaintenanceInformation.Controls.Add(lblSupplierID);
            gbMaintenanceInformation.Controls.Add(txtSupplierID);
            gbMaintenanceInformation.Controls.Add(lblSupplierName);
            gbMaintenanceInformation.Controls.Add(txtSupplierContact);
            gbMaintenanceInformation.Font = new Font("Khmer OS Siemreap", 10F, FontStyle.Bold, GraphicsUnit.Point);
            gbMaintenanceInformation.Location = new Point(343, 208);
            gbMaintenanceInformation.Name = "gbMaintenanceInformation";
            gbMaintenanceInformation.Size = new Size(1347, 194);
            gbMaintenanceInformation.TabIndex = 49;
            gbMaintenanceInformation.TabStop = false;
            gbMaintenanceInformation.Text = "ព័ត៌មានអ្នកផ្គត់ផ្គង់";
            // 
            // txtSupplierAddress
            // 
            txtSupplierAddress.Enabled = false;
            txtSupplierAddress.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSupplierAddress.Location = new Point(1008, 111);
            txtSupplierAddress.Name = "txtSupplierAddress";
            txtSupplierAddress.Size = new Size(288, 51);
            txtSupplierAddress.TabIndex = 38;
            // 
            // lblSupplierAddress
            // 
            lblSupplierAddress.AutoSize = true;
            lblSupplierAddress.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSupplierAddress.Location = new Point(697, 114);
            lblSupplierAddress.Name = "lblSupplierAddress";
            lblSupplierAddress.Size = new Size(137, 43);
            lblSupplierAddress.TabIndex = 37;
            lblSupplierAddress.Text = "អាសយដ្ឋាន:";
            // 
            // txtSupplierName
            // 
            txtSupplierName.Enabled = false;
            txtSupplierName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSupplierName.Location = new Point(1008, 40);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(288, 51);
            txtSupplierName.TabIndex = 36;
            // 
            // lblSupplierContact
            // 
            lblSupplierContact.AutoSize = true;
            lblSupplierContact.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSupplierContact.Location = new Point(21, 119);
            lblSupplierContact.Name = "lblSupplierContact";
            lblSupplierContact.Size = new Size(177, 43);
            lblSupplierContact.TabIndex = 28;
            lblSupplierContact.Text = "លេខទំនាក់ទំនង:";
            // 
            // lblSupplierID
            // 
            lblSupplierID.AutoSize = true;
            lblSupplierID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSupplierID.Location = new Point(21, 48);
            lblSupplierID.Name = "lblSupplierID";
            lblSupplierID.Size = new Size(286, 43);
            lblSupplierID.TabIndex = 0;
            lblSupplierID.Text = "លេខសម្គាល់របស់អ្នកផ្គត់ផ្គង់:";
            // 
            // txtSupplierID
            // 
            txtSupplierID.Enabled = false;
            txtSupplierID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSupplierID.Location = new Point(342, 40);
            txtSupplierID.Name = "txtSupplierID";
            txtSupplierID.Size = new Size(288, 51);
            txtSupplierID.TabIndex = 3;
            // 
            // lblSupplierName
            // 
            lblSupplierName.AutoSize = true;
            lblSupplierName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSupplierName.Location = new Point(697, 50);
            lblSupplierName.Name = "lblSupplierName";
            lblSupplierName.Size = new Size(227, 43);
            lblSupplierName.TabIndex = 6;
            lblSupplierName.Text = "ឈ្មោះរបស់អ្នកផ្គត់ផ្គង់:";
            // 
            // txtSupplierContact
            // 
            txtSupplierContact.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSupplierContact.Location = new Point(342, 111);
            txtSupplierContact.Name = "txtSupplierContact";
            txtSupplierContact.Size = new Size(288, 51);
            txtSupplierContact.TabIndex = 7;
            // 
            // btnLogOutSupplier
            // 
            btnLogOutSupplier.AutoSize = true;
            btnLogOutSupplier.BackColor = Color.FromArgb(0, 28, 87);
            btnLogOutSupplier.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogOutSupplier.ForeColor = Color.White;
            btnLogOutSupplier.Location = new Point(886, 443);
            btnLogOutSupplier.Name = "btnLogOutSupplier";
            btnLogOutSupplier.Size = new Size(128, 60);
            btnLogOutSupplier.TabIndex = 53;
            btnLogOutSupplier.Text = "បិទ";
            btnLogOutSupplier.UseVisualStyleBackColor = false;
            // 
            // btnNewSupplier
            // 
            btnNewSupplier.AutoSize = true;
            btnNewSupplier.BackColor = Color.FromArgb(0, 28, 87);
            btnNewSupplier.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNewSupplier.ForeColor = Color.White;
            btnNewSupplier.Location = new Point(700, 443);
            btnNewSupplier.Name = "btnNewSupplier";
            btnNewSupplier.Size = new Size(128, 60);
            btnNewSupplier.TabIndex = 52;
            btnNewSupplier.Text = "បង្កើតថ្មី";
            btnNewSupplier.UseVisualStyleBackColor = false;
            // 
            // btnUpdateSupplier
            // 
            btnUpdateSupplier.AutoSize = true;
            btnUpdateSupplier.BackColor = Color.FromArgb(0, 28, 87);
            btnUpdateSupplier.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateSupplier.ForeColor = Color.White;
            btnUpdateSupplier.Location = new Point(515, 443);
            btnUpdateSupplier.Name = "btnUpdateSupplier";
            btnUpdateSupplier.Size = new Size(128, 60);
            btnUpdateSupplier.TabIndex = 51;
            btnUpdateSupplier.Text = "កែប្រែ";
            btnUpdateSupplier.UseVisualStyleBackColor = false;
            // 
            // btnInsertSupplier
            // 
            btnInsertSupplier.AutoSize = true;
            btnInsertSupplier.BackColor = Color.FromArgb(0, 28, 87);
            btnInsertSupplier.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsertSupplier.ForeColor = Color.White;
            btnInsertSupplier.Location = new Point(342, 443);
            btnInsertSupplier.Name = "btnInsertSupplier";
            btnInsertSupplier.Size = new Size(128, 60);
            btnInsertSupplier.TabIndex = 50;
            btnInsertSupplier.Text = "បញ្ចូល";
            btnInsertSupplier.UseVisualStyleBackColor = false;
            // 
            // lblSupplierSearch
            // 
            lblSupplierSearch.AutoSize = true;
            lblSupplierSearch.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSupplierSearch.Location = new Point(343, 555);
            lblSupplierSearch.Name = "lblSupplierSearch";
            lblSupplierSearch.Size = new Size(343, 43);
            lblSupplierSearch.TabIndex = 39;
            lblSupplierSearch.Text = "ស្វែងរក (លេខសម្គាល់អ្នកផ្គត់ផ្គង់):";
            // 
            // txtSupplierSearchID
            // 
            txtSupplierSearchID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSupplierSearchID.Location = new Point(685, 552);
            txtSupplierSearchID.Name = "txtSupplierSearchID";
            txtSupplierSearchID.Size = new Size(288, 51);
            txtSupplierSearchID.TabIndex = 39;
            // 
            // dgvSupplier
            // 
            dgvSupplier.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvSupplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvSupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSupplier.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(25, 113, 176);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvSupplier.DefaultCellStyle = dataGridViewCellStyle4;
            dgvSupplier.Location = new Point(342, 631);
            dgvSupplier.Name = "dgvSupplier";
            dgvSupplier.RowHeadersWidth = 60;
            dgvSupplier.RowTemplate.Height = 33;
            dgvSupplier.Size = new Size(1330, 252);
            dgvSupplier.TabIndex = 54;
            // 
            // Column1
            // 
            Column1.HeaderText = "លេខសម្គាល់របស់អ្នកផ្គត់ផ្គង់";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 320;
            // 
            // Column2
            // 
            Column2.HeaderText = "ឈ្មោះរបស់អ្នកផ្គត់ផ្គង់";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 280;
            // 
            // Column3
            // 
            Column3.HeaderText = "លេខទំនាក់ទំនងរបស់អ្នកផ្គត់ផ្គង់";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 360;
            // 
            // Column4
            // 
            Column4.HeaderText = "អាសយដ្ឋានរបស់អ្នកផ្គត់ផ្គង់";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 310;
            // 
            // FrmSupplier
            // 
            AutoScaleDimensions = new SizeF(13F, 43F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1800, 1000);
            Controls.Add(dgvSupplier);
            Controls.Add(txtSupplierSearchID);
            Controls.Add(lblSupplierSearch);
            Controls.Add(btnLogOutSupplier);
            Controls.Add(btnNewSupplier);
            Controls.Add(btnUpdateSupplier);
            Controls.Add(btnInsertSupplier);
            Controls.Add(gbMaintenanceInformation);
            Controls.Add(lblTitle);
            Name = "FrmSupplier";
            Text = "FrmSupplier";
            Controls.SetChildIndex(lblTitle, 0);
            Controls.SetChildIndex(gbMaintenanceInformation, 0);
            Controls.SetChildIndex(btnInsertSupplier, 0);
            Controls.SetChildIndex(btnUpdateSupplier, 0);
            Controls.SetChildIndex(btnNewSupplier, 0);
            Controls.SetChildIndex(btnLogOutSupplier, 0);
            Controls.SetChildIndex(lblSupplierSearch, 0);
            Controls.SetChildIndex(txtSupplierSearchID, 0);
            Controls.SetChildIndex(dgvSupplier, 0);
            gbMaintenanceInformation.ResumeLayout(false);
            gbMaintenanceInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSupplier).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private GroupBox gbMaintenanceInformation;
        private TextBox txtSupplierAddress;
        private Label lblSupplierAddress;
        private TextBox txtSupplierName;
        private Label lblSupplierContact;
        private Label lblSupplierID;
        private TextBox txtSupplierID;
        private Label lblSupplierName;
        private TextBox txtSupplierContact;
        private Button btnLogOutSupplier;
        private Button btnNewSupplier;
        private Button btnUpdateSupplier;
        private Button btnInsertSupplier;
        private Label lblSupplierSearch;
        private TextBox txtSupplierSearchID;
        private DataGridView dgvSupplier;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}