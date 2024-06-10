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
            lblTitle = new Label();
            lblSearchSupplier = new Label();
            txtSearchSupplier = new TextBox();
            pnlLeftSide = new Panel();
            dgvSuppliers = new DataGridView();
            pnlRightSide = new Panel();
            gbSupplierInformation = new GroupBox();
            mtxtContactNumber = new MaskedTextBox();
            pnlSupplierManipulation = new Panel();
            btnCancelSupplier = new Button();
            btnNewSupplier = new Button();
            btnUpdateSupplier = new Button();
            btnInsertSupplier = new Button();
            lblSupplierAddress = new Label();
            lblSupplierID = new Label();
            txtSupplierName = new TextBox();
            lblSupplierName = new Label();
            txtSupplierID = new TextBox();
            lblContactNumber = new Label();
            txtSupplierAddress = new TextBox();
            SupplierID = new DataGridViewTextBoxColumn();
            SupplierName = new DataGridViewTextBoxColumn();
            ContactNumber = new DataGridViewTextBoxColumn();
            SupplierAddress = new DataGridViewTextBoxColumn();
            pnlLeftSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).BeginInit();
            pnlRightSide.SuspendLayout();
            gbSupplierInformation.SuspendLayout();
            pnlSupplierManipulation.SuspendLayout();
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
            lblTitle.Text = "ព័ត៌មានអ្នកផ្គត់ផ្គង់";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSearchSupplier
            // 
            lblSearchSupplier.AutoSize = true;
            lblSearchSupplier.Location = new Point(82, 19);
            lblSearchSupplier.Name = "lblSearchSupplier";
            lblSearchSupplier.Size = new Size(343, 43);
            lblSearchSupplier.TabIndex = 1;
            lblSearchSupplier.Text = "ស្វែងរក (លេខសម្គាល់អ្នកផ្គត់ផ្គង់):";
            // 
            // txtSearchSupplier
            // 
            txtSearchSupplier.Location = new Point(396, 11);
            txtSearchSupplier.Name = "txtSearchSupplier";
            txtSearchSupplier.Size = new Size(349, 51);
            txtSearchSupplier.TabIndex = 2;
            // 
            // pnlLeftSide
            // 
            pnlLeftSide.Controls.Add(dgvSuppliers);
            pnlLeftSide.Controls.Add(lblSearchSupplier);
            pnlLeftSide.Controls.Add(txtSearchSupplier);
            pnlLeftSide.Location = new Point(266, 509);
            pnlLeftSide.Name = "pnlLeftSide";
            pnlLeftSide.Size = new Size(1534, 491);
            pnlLeftSide.TabIndex = 3;
            // 
            // dgvSuppliers
            // 
            dgvSuppliers.AllowUserToAddRows = false;
            dgvSuppliers.AllowUserToDeleteRows = false;
            dgvSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSuppliers.Columns.AddRange(new DataGridViewColumn[] { SupplierID, SupplierName, ContactNumber, SupplierAddress });
            dgvSuppliers.Location = new Point(82, 74);
            dgvSuppliers.Name = "dgvSuppliers";
            dgvSuppliers.ReadOnly = true;
            dgvSuppliers.RowHeadersWidth = 51;
            dgvSuppliers.RowTemplate.Height = 29;
            dgvSuppliers.Size = new Size(1362, 369);
            dgvSuppliers.TabIndex = 3;
            // 
            // pnlRightSide
            // 
            pnlRightSide.Controls.Add(gbSupplierInformation);
            pnlRightSide.Location = new Point(266, 184);
            pnlRightSide.Name = "pnlRightSide";
            pnlRightSide.Size = new Size(1534, 319);
            pnlRightSide.TabIndex = 4;
            // 
            // gbSupplierInformation
            // 
            gbSupplierInformation.BackColor = Color.White;
            gbSupplierInformation.Controls.Add(mtxtContactNumber);
            gbSupplierInformation.Controls.Add(pnlSupplierManipulation);
            gbSupplierInformation.Controls.Add(lblSupplierAddress);
            gbSupplierInformation.Controls.Add(lblSupplierID);
            gbSupplierInformation.Controls.Add(txtSupplierName);
            gbSupplierInformation.Controls.Add(lblSupplierName);
            gbSupplierInformation.Controls.Add(txtSupplierID);
            gbSupplierInformation.Controls.Add(lblContactNumber);
            gbSupplierInformation.Controls.Add(txtSupplierAddress);
            gbSupplierInformation.Font = new Font("!Khmer OS Siemreap", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            gbSupplierInformation.Location = new Point(82, 12);
            gbSupplierInformation.Name = "gbSupplierInformation";
            gbSupplierInformation.Size = new Size(1362, 288);
            gbSupplierInformation.TabIndex = 25;
            gbSupplierInformation.TabStop = false;
            gbSupplierInformation.Text = "ព័ត៌មានអ្នកផ្គត់ផ្គង់";
            // 
            // mtxtContactNumber
            // 
            mtxtContactNumber.Location = new Point(229, 111);
            mtxtContactNumber.Mask = "(999) 00-000-0000";
            mtxtContactNumber.Name = "mtxtContactNumber";
            mtxtContactNumber.Size = new Size(434, 45);
            mtxtContactNumber.TabIndex = 28;
            // 
            // pnlSupplierManipulation
            // 
            pnlSupplierManipulation.Controls.Add(btnCancelSupplier);
            pnlSupplierManipulation.Controls.Add(btnNewSupplier);
            pnlSupplierManipulation.Controls.Add(btnUpdateSupplier);
            pnlSupplierManipulation.Controls.Add(btnInsertSupplier);
            pnlSupplierManipulation.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pnlSupplierManipulation.Location = new Point(18, 171);
            pnlSupplierManipulation.Name = "pnlSupplierManipulation";
            pnlSupplierManipulation.Size = new Size(1301, 85);
            pnlSupplierManipulation.TabIndex = 5;
            // 
            // btnCancelSupplier
            // 
            btnCancelSupplier.BackColor = Color.FromArgb(0, 28, 87);
            btnCancelSupplier.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelSupplier.ForeColor = Color.White;
            btnCancelSupplier.Location = new Point(1100, 20);
            btnCancelSupplier.Name = "btnCancelSupplier";
            btnCancelSupplier.Size = new Size(152, 52);
            btnCancelSupplier.TabIndex = 3;
            btnCancelSupplier.Text = "បោះបង់";
            btnCancelSupplier.UseVisualStyleBackColor = false;
            // 
            // btnNewSupplier
            // 
            btnNewSupplier.BackColor = Color.FromArgb(0, 28, 87);
            btnNewSupplier.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNewSupplier.ForeColor = Color.White;
            btnNewSupplier.Location = new Point(740, 20);
            btnNewSupplier.Name = "btnNewSupplier";
            btnNewSupplier.Size = new Size(152, 52);
            btnNewSupplier.TabIndex = 2;
            btnNewSupplier.Text = "បង្កើតថ្មី";
            btnNewSupplier.UseVisualStyleBackColor = false;
            // 
            // btnUpdateSupplier
            // 
            btnUpdateSupplier.BackColor = Color.FromArgb(0, 28, 87);
            btnUpdateSupplier.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateSupplier.ForeColor = Color.White;
            btnUpdateSupplier.Location = new Point(380, 20);
            btnUpdateSupplier.Name = "btnUpdateSupplier";
            btnUpdateSupplier.Size = new Size(152, 52);
            btnUpdateSupplier.TabIndex = 1;
            btnUpdateSupplier.Text = "កែប្រែ";
            btnUpdateSupplier.UseVisualStyleBackColor = false;
            // 
            // btnInsertSupplier
            // 
            btnInsertSupplier.BackColor = Color.FromArgb(0, 28, 87);
            btnInsertSupplier.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsertSupplier.ForeColor = Color.White;
            btnInsertSupplier.Location = new Point(20, 20);
            btnInsertSupplier.Name = "btnInsertSupplier";
            btnInsertSupplier.Size = new Size(152, 52);
            btnInsertSupplier.TabIndex = 0;
            btnInsertSupplier.Text = "បញ្ចូល";
            btnInsertSupplier.UseVisualStyleBackColor = false;
            // 
            // lblSupplierAddress
            // 
            lblSupplierAddress.AutoSize = true;
            lblSupplierAddress.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSupplierAddress.Location = new Point(711, 111);
            lblSupplierAddress.Name = "lblSupplierAddress";
            lblSupplierAddress.Size = new Size(137, 43);
            lblSupplierAddress.TabIndex = 27;
            lblSupplierAddress.Text = "អាសយដ្ឋាន:";
            // 
            // lblSupplierID
            // 
            lblSupplierID.AutoSize = true;
            lblSupplierID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSupplierID.Location = new Point(18, 41);
            lblSupplierID.Name = "lblSupplierID";
            lblSupplierID.Size = new Size(239, 43);
            lblSupplierID.TabIndex = 0;
            lblSupplierID.Text = "លេខសម្គាល់អ្នកផ្គត់ផ្គង់:";
            // 
            // txtSupplierName
            // 
            txtSupplierName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSupplierName.Location = new Point(907, 33);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(412, 51);
            txtSupplierName.TabIndex = 5;
            // 
            // lblSupplierName
            // 
            lblSupplierName.AutoSize = true;
            lblSupplierName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSupplierName.Location = new Point(711, 41);
            lblSupplierName.Name = "lblSupplierName";
            lblSupplierName.Size = new Size(180, 43);
            lblSupplierName.TabIndex = 4;
            lblSupplierName.Text = "ឈ្មោះអ្នកផ្គត់ផ្គង់:";
            // 
            // txtSupplierID
            // 
            txtSupplierID.Enabled = false;
            txtSupplierID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSupplierID.Location = new Point(229, 33);
            txtSupplierID.Name = "txtSupplierID";
            txtSupplierID.Size = new Size(434, 51);
            txtSupplierID.TabIndex = 3;
            // 
            // lblContactNumber
            // 
            lblContactNumber.AutoSize = true;
            lblContactNumber.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblContactNumber.Location = new Point(18, 111);
            lblContactNumber.Name = "lblContactNumber";
            lblContactNumber.Size = new Size(177, 43);
            lblContactNumber.TabIndex = 6;
            lblContactNumber.Text = "លេខទំនាក់ទំនង:";
            // 
            // txtSupplierAddress
            // 
            txtSupplierAddress.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSupplierAddress.Location = new Point(907, 103);
            txtSupplierAddress.Name = "txtSupplierAddress";
            txtSupplierAddress.Size = new Size(412, 51);
            txtSupplierAddress.TabIndex = 7;
            // 
            // SupplierID
            // 
            SupplierID.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            SupplierID.DataPropertyName = "SupplierID";
            SupplierID.HeaderText = "លេខសម្គាល់អ្នកផ្គត់ផ្គង់";
            SupplierID.MinimumWidth = 6;
            SupplierID.Name = "SupplierID";
            SupplierID.ReadOnly = true;
            SupplierID.Width = 268;
            // 
            // SupplierName
            // 
            SupplierName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SupplierName.DataPropertyName = "SupplierName";
            SupplierName.HeaderText = "ឈ្មោះអ្នកផ្គត់ផ្គង់";
            SupplierName.MinimumWidth = 6;
            SupplierName.Name = "SupplierName";
            SupplierName.ReadOnly = true;
            // 
            // ContactNumber
            // 
            ContactNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ContactNumber.DataPropertyName = "ContactNumber";
            ContactNumber.HeaderText = "លេខទំនាក់ទំនង";
            ContactNumber.MinimumWidth = 6;
            ContactNumber.Name = "ContactNumber";
            ContactNumber.ReadOnly = true;
            ContactNumber.Width = 206;
            // 
            // SupplierAddress
            // 
            SupplierAddress.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SupplierAddress.DataPropertyName = "SupplierAddress";
            SupplierAddress.HeaderText = "អាសយដ្ឋាន";
            SupplierAddress.MinimumWidth = 6;
            SupplierAddress.Name = "SupplierAddress";
            SupplierAddress.ReadOnly = true;
            // 
            // FrmSupplier
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1800, 1000);
            ControlBox = true;
            Controls.Add(pnlRightSide);
            Controls.Add(pnlLeftSide);
            Controls.Add(lblTitle);
            Name = "FrmSupplier";
            Text = "ព័ត៌មានបុគ្គលិក";
            Controls.SetChildIndex(lblTitle, 0);
            Controls.SetChildIndex(pnlLeftSide, 0);
            Controls.SetChildIndex(pnlRightSide, 0);
            pnlLeftSide.ResumeLayout(false);
            pnlLeftSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).EndInit();
            pnlRightSide.ResumeLayout(false);
            gbSupplierInformation.ResumeLayout(false);
            gbSupplierInformation.PerformLayout();
            pnlSupplierManipulation.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblSearchSupplier;
        private TextBox txtSearchSupplier;
        private Panel pnlLeftSide;
        private Panel pnlRightSide;
        private Label lblSupplierID;
        private TextBox txtSupplierAddress;
        private Label lblContactNumber;
        private TextBox txtSupplierName;
        private Label lblSupplierName;
        private TextBox txtSupplierID;
        private GroupBox gbSupplierInformation;
        private Panel pnlSupplierManipulation;
        private Button btnInsertSupplier;
        private Button btnCancelSupplier;
        private Button btnNewSupplier;
        private Button btnUpdateSupplier;
        private Label lblSupplierAddress;
        private DataGridView dgvSuppliers;
        private DataGridViewTextBoxColumn supplierIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn supplierNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contactNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn supplierAddressDataGridViewTextBoxColumn;
        private MaskedTextBox mtxtContactNumber;
        private DataGridViewTextBoxColumn SupplierID;
        private DataGridViewTextBoxColumn SupplierName;
        private DataGridViewTextBoxColumn ContactNumber;
        private DataGridViewTextBoxColumn SupplierAddress;
    }
}