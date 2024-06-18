namespace Store_Rental_Management_Systems
{
    partial class FrmSalaryPayment
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
            lblSearchSalaryPayment = new Label();
            txtSearchSalaryPayment = new TextBox();
            pnlLeftSide = new Panel();
            pnlRightSide = new Panel();
            gbSalaryPaymentInformation = new GroupBox();
            dtpSalaryPaymentDate = new DateTimePicker();
            lblStaffPosition = new Label();
            txtStaffPosition = new TextBox();
            txtStaffName = new TextBox();
            lblStaffName = new Label();
            cbStaffID = new ComboBox();
            pnlSalaryPaymentManipulation = new Panel();
            btnCancelSalaryPayment = new Button();
            btnNewSalaryPayment = new Button();
            btnUpdateSalaryPayment = new Button();
            btnInsertSalaryPayment = new Button();
            lblStaffID = new Label();
            lblSalaryPaymentID = new Label();
            lblSalaryPaymentDate = new Label();
            txtSalaryPaymentID = new TextBox();
            lblSalaryPaymentAmount = new Label();
            txtSalaryPaymentAmount = new TextBox();
            dgvSalaryPayments = new DataGridView();
            SalaryPaymentID = new DataGridViewTextBoxColumn();
            SalaryPaymentDate = new DataGridViewTextBoxColumn();
            SalaryPaymentAmount = new DataGridViewTextBoxColumn();
            StaffID = new DataGridViewTextBoxColumn();
            StaffName = new DataGridViewTextBoxColumn();
            StaffPosition = new DataGridViewTextBoxColumn();
            pnlLeftSide.SuspendLayout();
            pnlRightSide.SuspendLayout();
            gbSalaryPaymentInformation.SuspendLayout();
            pnlSalaryPaymentManipulation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSalaryPayments).BeginInit();
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
            lblTitle.Text = "ព័ត៌មានការបើកប្រាក់ខែបុគ្គលិក";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSearchSalaryPayment
            // 
            lblSearchSalaryPayment.AutoSize = true;
            lblSearchSalaryPayment.Location = new Point(34, 29);
            lblSearchSalaryPayment.Name = "lblSearchSalaryPayment";
            lblSearchSalaryPayment.Size = new Size(329, 36);
            lblSearchSalaryPayment.TabIndex = 1;
            lblSearchSalaryPayment.Text = "ស្វែងរក (លេខសម្គាល់ការបើកប្រាក់ខែ):";
            // 
            // txtSearchSalaryPayment
            // 
            txtSearchSalaryPayment.Location = new Point(470, 21);
            txtSearchSalaryPayment.Name = "txtSearchSalaryPayment";
            txtSearchSalaryPayment.Size = new Size(338, 44);
            txtSearchSalaryPayment.TabIndex = 2;
            // 
            // pnlLeftSide
            // 
            pnlLeftSide.Controls.Add(dgvSalaryPayments);
            pnlLeftSide.Controls.Add(lblSearchSalaryPayment);
            pnlLeftSide.Controls.Add(txtSearchSalaryPayment);
            pnlLeftSide.Location = new Point(266, 537);
            pnlLeftSide.Name = "pnlLeftSide";
            pnlLeftSide.Size = new Size(1534, 463);
            pnlLeftSide.TabIndex = 3;
            // 
            // pnlRightSide
            // 
            pnlRightSide.Controls.Add(gbSalaryPaymentInformation);
            pnlRightSide.Location = new Point(266, 184);
            pnlRightSide.Name = "pnlRightSide";
            pnlRightSide.Size = new Size(1534, 355);
            pnlRightSide.TabIndex = 4;
            // 
            // gbSalaryPaymentInformation
            // 
            gbSalaryPaymentInformation.Controls.Add(dtpSalaryPaymentDate);
            gbSalaryPaymentInformation.Controls.Add(lblStaffPosition);
            gbSalaryPaymentInformation.Controls.Add(txtStaffPosition);
            gbSalaryPaymentInformation.Controls.Add(txtStaffName);
            gbSalaryPaymentInformation.Controls.Add(lblStaffName);
            gbSalaryPaymentInformation.Controls.Add(cbStaffID);
            gbSalaryPaymentInformation.Controls.Add(pnlSalaryPaymentManipulation);
            gbSalaryPaymentInformation.Controls.Add(lblStaffID);
            gbSalaryPaymentInformation.Controls.Add(lblSalaryPaymentID);
            gbSalaryPaymentInformation.Controls.Add(lblSalaryPaymentDate);
            gbSalaryPaymentInformation.Controls.Add(txtSalaryPaymentID);
            gbSalaryPaymentInformation.Controls.Add(lblSalaryPaymentAmount);
            gbSalaryPaymentInformation.Controls.Add(txtSalaryPaymentAmount);
            gbSalaryPaymentInformation.Font = new Font("Khmer OS Siemreap", 10F, FontStyle.Bold, GraphicsUnit.Point);
            gbSalaryPaymentInformation.Location = new Point(34, 12);
            gbSalaryPaymentInformation.Name = "gbSalaryPaymentInformation";
            gbSalaryPaymentInformation.Size = new Size(1448, 335);
            gbSalaryPaymentInformation.TabIndex = 25;
            gbSalaryPaymentInformation.TabStop = false;
            gbSalaryPaymentInformation.Text = "ព័ត៌មានការបើកប្រាក់ខែបុគ្គលិក";
            // 
            // dtpSalaryPaymentDate
            // 
            dtpSalaryPaymentDate.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpSalaryPaymentDate.Format = DateTimePickerFormat.Short;
            dtpSalaryPaymentDate.Location = new Point(1013, 41);
            dtpSalaryPaymentDate.Name = "dtpSalaryPaymentDate";
            dtpSalaryPaymentDate.Size = new Size(366, 44);
            dtpSalaryPaymentDate.TabIndex = 33;
            // 
            // lblStaffPosition
            // 
            lblStaffPosition.AutoSize = true;
            lblStaffPosition.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffPosition.Location = new Point(771, 193);
            lblStaffPosition.Name = "lblStaffPosition";
            lblStaffPosition.Size = new Size(131, 36);
            lblStaffPosition.TabIndex = 32;
            lblStaffPosition.Text = "តួនាទីបុគ្គលិក:";
            // 
            // txtStaffPosition
            // 
            txtStaffPosition.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffPosition.Location = new Point(1013, 185);
            txtStaffPosition.Name = "txtStaffPosition";
            txtStaffPosition.ReadOnly = true;
            txtStaffPosition.Size = new Size(366, 44);
            txtStaffPosition.TabIndex = 31;
            // 
            // txtStaffName
            // 
            txtStaffName.Enabled = false;
            txtStaffName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffName.Location = new Point(303, 182);
            txtStaffName.Name = "txtStaffName";
            txtStaffName.ReadOnly = true;
            txtStaffName.Size = new Size(360, 44);
            txtStaffName.TabIndex = 30;
            // 
            // lblStaffName
            // 
            lblStaffName.AutoSize = true;
            lblStaffName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffName.Location = new Point(18, 185);
            lblStaffName.Name = "lblStaffName";
            lblStaffName.Size = new Size(130, 36);
            lblStaffName.TabIndex = 29;
            lblStaffName.Text = "ឈ្មោះបុគ្គលិក:";
            // 
            // cbStaffID
            // 
            cbStaffID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStaffID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbStaffID.FormattingEnabled = true;
            cbStaffID.Location = new Point(1013, 116);
            cbStaffID.Name = "cbStaffID";
            cbStaffID.Size = new Size(366, 44);
            cbStaffID.TabIndex = 28;
            // 
            // pnlSalaryPaymentManipulation
            // 
            pnlSalaryPaymentManipulation.Controls.Add(btnCancelSalaryPayment);
            pnlSalaryPaymentManipulation.Controls.Add(btnNewSalaryPayment);
            pnlSalaryPaymentManipulation.Controls.Add(btnUpdateSalaryPayment);
            pnlSalaryPaymentManipulation.Controls.Add(btnInsertSalaryPayment);
            pnlSalaryPaymentManipulation.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pnlSalaryPaymentManipulation.Location = new Point(18, 247);
            pnlSalaryPaymentManipulation.Name = "pnlSalaryPaymentManipulation";
            pnlSalaryPaymentManipulation.Size = new Size(1375, 81);
            pnlSalaryPaymentManipulation.TabIndex = 5;
            // 
            // btnCancelSalaryPayment
            // 
            btnCancelSalaryPayment.BackColor = Color.FromArgb(0, 28, 87);
            btnCancelSalaryPayment.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelSalaryPayment.ForeColor = Color.White;
            btnCancelSalaryPayment.Location = new Point(1102, 20);
            btnCancelSalaryPayment.Name = "btnCancelSalaryPayment";
            btnCancelSalaryPayment.Size = new Size(152, 52);
            btnCancelSalaryPayment.TabIndex = 3;
            btnCancelSalaryPayment.Text = "បោះបង់";
            btnCancelSalaryPayment.UseVisualStyleBackColor = false;
            // 
            // btnNewSalaryPayment
            // 
            btnNewSalaryPayment.BackColor = Color.FromArgb(0, 28, 87);
            btnNewSalaryPayment.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNewSalaryPayment.ForeColor = Color.White;
            btnNewSalaryPayment.Location = new Point(774, 20);
            btnNewSalaryPayment.Name = "btnNewSalaryPayment";
            btnNewSalaryPayment.Size = new Size(152, 52);
            btnNewSalaryPayment.TabIndex = 2;
            btnNewSalaryPayment.Text = "បង្កើតថ្មី";
            btnNewSalaryPayment.UseVisualStyleBackColor = false;
            // 
            // btnUpdateSalaryPayment
            // 
            btnUpdateSalaryPayment.BackColor = Color.FromArgb(0, 28, 87);
            btnUpdateSalaryPayment.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateSalaryPayment.ForeColor = Color.White;
            btnUpdateSalaryPayment.Location = new Point(411, 20);
            btnUpdateSalaryPayment.Name = "btnUpdateSalaryPayment";
            btnUpdateSalaryPayment.Size = new Size(152, 52);
            btnUpdateSalaryPayment.TabIndex = 1;
            btnUpdateSalaryPayment.Text = "កែប្រែ";
            btnUpdateSalaryPayment.UseVisualStyleBackColor = false;
            // 
            // btnInsertSalaryPayment
            // 
            btnInsertSalaryPayment.BackColor = Color.FromArgb(0, 28, 87);
            btnInsertSalaryPayment.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsertSalaryPayment.ForeColor = Color.White;
            btnInsertSalaryPayment.Location = new Point(20, 20);
            btnInsertSalaryPayment.Name = "btnInsertSalaryPayment";
            btnInsertSalaryPayment.Size = new Size(152, 52);
            btnInsertSalaryPayment.TabIndex = 0;
            btnInsertSalaryPayment.Text = "បញ្ចូល";
            btnInsertSalaryPayment.UseVisualStyleBackColor = false;
            // 
            // lblStaffID
            // 
            lblStaffID.AutoSize = true;
            lblStaffID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffID.Location = new Point(771, 119);
            lblStaffID.Name = "lblStaffID";
            lblStaffID.Size = new Size(183, 36);
            lblStaffID.TabIndex = 27;
            lblStaffID.Text = "លេខសម្គាល់បុគ្គលិក:";
            // 
            // lblSalaryPaymentID
            // 
            lblSalaryPaymentID.AutoSize = true;
            lblSalaryPaymentID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSalaryPaymentID.Location = new Point(18, 41);
            lblSalaryPaymentID.Name = "lblSalaryPaymentID";
            lblSalaryPaymentID.Size = new Size(241, 36);
            lblSalaryPaymentID.TabIndex = 0;
            lblSalaryPaymentID.Text = "លេខសម្គាល់ការបើកប្រាក់ខែ:";
            // 
            // lblSalaryPaymentDate
            // 
            lblSalaryPaymentDate.AutoSize = true;
            lblSalaryPaymentDate.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSalaryPaymentDate.Location = new Point(771, 49);
            lblSalaryPaymentDate.Name = "lblSalaryPaymentDate";
            lblSalaryPaymentDate.Size = new Size(209, 36);
            lblSalaryPaymentDate.TabIndex = 4;
            lblSalaryPaymentDate.Text = "កាលបរិច្ឆេទបើកប្រាក់ខែ:";
            // 
            // txtSalaryPaymentID
            // 
            txtSalaryPaymentID.Enabled = false;
            txtSalaryPaymentID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSalaryPaymentID.Location = new Point(303, 33);
            txtSalaryPaymentID.Name = "txtSalaryPaymentID";
            txtSalaryPaymentID.Size = new Size(360, 44);
            txtSalaryPaymentID.TabIndex = 3;
            // 
            // lblSalaryPaymentAmount
            // 
            lblSalaryPaymentAmount.AutoSize = true;
            lblSalaryPaymentAmount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSalaryPaymentAmount.Location = new Point(18, 111);
            lblSalaryPaymentAmount.Name = "lblSalaryPaymentAmount";
            lblSalaryPaymentAmount.Size = new Size(131, 36);
            lblSalaryPaymentAmount.TabIndex = 6;
            lblSalaryPaymentAmount.Text = "ចំនួនទឹកប្រាក់:";
            // 
            // txtSalaryPaymentAmount
            // 
            txtSalaryPaymentAmount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSalaryPaymentAmount.Location = new Point(303, 111);
            txtSalaryPaymentAmount.Name = "txtSalaryPaymentAmount";
            txtSalaryPaymentAmount.Size = new Size(360, 44);
            txtSalaryPaymentAmount.TabIndex = 13;
            // 
            // dgvSalaryPayments
            // 
            dgvSalaryPayments.AllowUserToAddRows = false;
            dgvSalaryPayments.AllowUserToDeleteRows = false;
            dgvSalaryPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSalaryPayments.Columns.AddRange(new DataGridViewColumn[] { SalaryPaymentID, SalaryPaymentDate, SalaryPaymentAmount, StaffID, StaffName, StaffPosition });
            dgvSalaryPayments.Location = new Point(34, 76);
            dgvSalaryPayments.Name = "dgvSalaryPayments";
            dgvSalaryPayments.ReadOnly = true;
            dgvSalaryPayments.RowHeadersWidth = 51;
            dgvSalaryPayments.RowTemplate.Height = 29;
            dgvSalaryPayments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSalaryPayments.Size = new Size(1448, 346);
            dgvSalaryPayments.TabIndex = 4;
            dgvSalaryPayments.TabStop = false;
            // 
            // SalaryPaymentID
            // 
            SalaryPaymentID.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            SalaryPaymentID.DataPropertyName = "SalaryPaymentID";
            SalaryPaymentID.HeaderText = "លេខសម្គាល់ការបើកប្រាក់ខែ";
            SalaryPaymentID.MinimumWidth = 6;
            SalaryPaymentID.Name = "SalaryPaymentID";
            SalaryPaymentID.ReadOnly = true;
            SalaryPaymentID.Width = 264;
            // 
            // SalaryPaymentDate
            // 
            SalaryPaymentDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            SalaryPaymentDate.DataPropertyName = "SalaryPaymentDate";
            SalaryPaymentDate.HeaderText = "កាលបរិច្ឆេទបើកប្រាក់ខែ";
            SalaryPaymentDate.MinimumWidth = 6;
            SalaryPaymentDate.Name = "SalaryPaymentDate";
            SalaryPaymentDate.ReadOnly = true;
            SalaryPaymentDate.Width = 232;
            // 
            // SalaryPaymentAmount
            // 
            SalaryPaymentAmount.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            SalaryPaymentAmount.DataPropertyName = "SalaryPaymentAmount";
            SalaryPaymentAmount.HeaderText = "ចំនួនទឹកប្រាក់";
            SalaryPaymentAmount.MinimumWidth = 6;
            SalaryPaymentAmount.Name = "SalaryPaymentAmount";
            SalaryPaymentAmount.ReadOnly = true;
            SalaryPaymentAmount.Width = 154;
            // 
            // StaffID
            // 
            StaffID.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            StaffID.DataPropertyName = "StaffID";
            StaffID.HeaderText = "លេខសម្គាល់បុគ្គលិក";
            StaffID.MinimumWidth = 6;
            StaffID.Name = "StaffID";
            StaffID.ReadOnly = true;
            StaffID.Width = 206;
            // 
            // StaffName
            // 
            StaffName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StaffName.DataPropertyName = "StaffName";
            StaffName.HeaderText = "ឈ្មោះបុគ្គលិក";
            StaffName.MinimumWidth = 6;
            StaffName.Name = "StaffName";
            StaffName.ReadOnly = true;
            // 
            // StaffPosition
            // 
            StaffPosition.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StaffPosition.DataPropertyName = "StaffPosition";
            StaffPosition.HeaderText = "តួនាទីបុគ្គលិក";
            StaffPosition.MinimumWidth = 6;
            StaffPosition.Name = "StaffPosition";
            StaffPosition.ReadOnly = true;
            // 
            // FrmSalaryPayment
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1800, 1000);
            ControlBox = true;
            Controls.Add(pnlRightSide);
            Controls.Add(pnlLeftSide);
            Controls.Add(lblTitle);
            Name = "FrmSalaryPayment";
            Text = "ព័ត៌មានបុគ្គលិក";
            Controls.SetChildIndex(lblTitle, 0);
            Controls.SetChildIndex(pnlLeftSide, 0);
            Controls.SetChildIndex(pnlRightSide, 0);
            pnlLeftSide.ResumeLayout(false);
            pnlLeftSide.PerformLayout();
            pnlRightSide.ResumeLayout(false);
            gbSalaryPaymentInformation.ResumeLayout(false);
            gbSalaryPaymentInformation.PerformLayout();
            pnlSalaryPaymentManipulation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSalaryPayments).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblSearchSalaryPayment;
        private TextBox txtSearchSalaryPayment;
        private Panel pnlLeftSide;
        private Panel pnlRightSide;
        private Label lblSalaryPaymentID;
        private Label lblSalaryPaymentAmount;
        private Label lblSalaryPaymentDate;
        private TextBox txtSalaryPaymentID;
        private TextBox txtSalaryPaymentAmount;
        private GroupBox gbSalaryPaymentInformation;
        private Panel pnlSalaryPaymentManipulation;
        private Button btnInsertSalaryPayment;
        private Button btnCancelSalaryPayment;
        private Button btnNewSalaryPayment;
        private Button btnUpdateSalaryPayment;
        private Label lblStaffID;
        private Label lblStaffName;
        private ComboBox cbStaffID;
        private Label lblStaffPosition;
        private TextBox txtStaffPosition;
        private TextBox txtStaffName;
        private DateTimePicker dtpSalaryPaymentDate;
        private DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn staffNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn staffPositionDataGridViewTextBoxColumn;
        private DataGridView dgvSalaryPayments;
        private DataGridViewTextBoxColumn SalaryPaymentID;
        private DataGridViewTextBoxColumn SalaryPaymentDate;
        private DataGridViewTextBoxColumn SalaryPaymentAmount;
        private DataGridViewTextBoxColumn StaffID;
        private DataGridViewTextBoxColumn StaffName;
        private DataGridViewTextBoxColumn StaffPosition;
    }
}