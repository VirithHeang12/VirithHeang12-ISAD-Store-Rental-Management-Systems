namespace Store_Rental_Management_Systems
{
    partial class FrmAppointment
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblTitle = new Label();
            pnlRightSide = new Panel();
            gbStaffAssignments = new GroupBox();
            cbStaffID = new ComboBox();
            btnUpdateAppointmentStaff = new Button();
            btnInsertAppointmentStaff = new Button();
            lblStaffPosition = new Label();
            txtStaffPosition = new TextBox();
            lblStaffName = new Label();
            txtStaffName = new TextBox();
            lblStaffID = new Label();
            gbAppointmentInformation = new GroupBox();
            cbCustomerID = new ComboBox();
            lblAppointmentID = new Label();
            cbAppointmentStatus = new ComboBox();
            dtpAppointmentDate = new DateTimePicker();
            lblAppointmentDate = new Label();
            lblAppointmentStatus = new Label();
            txtAppointmentID = new TextBox();
            lblCustomerID = new Label();
            pnlAppointmentManipulation = new Panel();
            btnCloseFormAppointment = new Button();
            btnNewAppointment = new Button();
            btnUpdateAppointment = new Button();
            btnInsertAppointment = new Button();
            pnlLeftSide = new Panel();
            dgvStaffAssignments = new DataGridView();
            StaffID = new DataGridViewTextBoxColumn();
            StaffName = new DataGridViewTextBoxColumn();
            StaffPosition = new DataGridViewTextBoxColumn();
            lblSearchAppointment = new Label();
            txtSearchAppointment = new TextBox();
            pnlRightSide.SuspendLayout();
            gbStaffAssignments.SuspendLayout();
            gbAppointmentInformation.SuspendLayout();
            pnlAppointmentManipulation.SuspendLayout();
            pnlLeftSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStaffAssignments).BeginInit();
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
            lblTitle.Text = "ព័ត៌មានការណាត់ជួបពិភាក្សា";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlRightSide
            // 
            pnlRightSide.Controls.Add(gbStaffAssignments);
            pnlRightSide.Controls.Add(gbAppointmentInformation);
            pnlRightSide.Location = new Point(266, 184);
            pnlRightSide.Name = "pnlRightSide";
            pnlRightSide.Size = new Size(1534, 409);
            pnlRightSide.TabIndex = 4;
            // 
            // gbStaffAssignments
            // 
            gbStaffAssignments.Controls.Add(cbStaffID);
            gbStaffAssignments.Controls.Add(btnUpdateAppointmentStaff);
            gbStaffAssignments.Controls.Add(btnInsertAppointmentStaff);
            gbStaffAssignments.Controls.Add(lblStaffPosition);
            gbStaffAssignments.Controls.Add(txtStaffPosition);
            gbStaffAssignments.Controls.Add(lblStaffName);
            gbStaffAssignments.Controls.Add(txtStaffName);
            gbStaffAssignments.Controls.Add(lblStaffID);
            gbStaffAssignments.Font = new Font("!Khmer OS Siemreap", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            gbStaffAssignments.Location = new Point(63, 164);
            gbStaffAssignments.Name = "gbStaffAssignments";
            gbStaffAssignments.Size = new Size(1427, 147);
            gbStaffAssignments.TabIndex = 27;
            gbStaffAssignments.TabStop = false;
            gbStaffAssignments.Text = "សេចក្ដីលម្អិត";
            // 
            // cbStaffID
            // 
            cbStaffID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbStaffID.FormattingEnabled = true;
            cbStaffID.Items.AddRange(new object[] { "ភ្នំពេញ", "តាកែវ" });
            cbStaffID.Location = new Point(212, 43);
            cbStaffID.Name = "cbStaffID";
            cbStaffID.Size = new Size(261, 51);
            cbStaffID.TabIndex = 36;
            // 
            // btnUpdateAppointmentStaff
            // 
            btnUpdateAppointmentStaff.BackColor = Color.FromArgb(0, 28, 87);
            btnUpdateAppointmentStaff.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateAppointmentStaff.ForeColor = Color.White;
            btnUpdateAppointmentStaff.Location = new Point(1265, 95);
            btnUpdateAppointmentStaff.Name = "btnUpdateAppointmentStaff";
            btnUpdateAppointmentStaff.Size = new Size(116, 46);
            btnUpdateAppointmentStaff.TabIndex = 24;
            btnUpdateAppointmentStaff.Text = "កែប្រែ";
            btnUpdateAppointmentStaff.UseVisualStyleBackColor = false;
            // 
            // btnInsertAppointmentStaff
            // 
            btnInsertAppointmentStaff.BackColor = Color.FromArgb(0, 28, 87);
            btnInsertAppointmentStaff.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsertAppointmentStaff.ForeColor = Color.White;
            btnInsertAppointmentStaff.Location = new Point(1084, 95);
            btnInsertAppointmentStaff.Name = "btnInsertAppointmentStaff";
            btnInsertAppointmentStaff.Size = new Size(118, 46);
            btnInsertAppointmentStaff.TabIndex = 23;
            btnInsertAppointmentStaff.Text = "បញ្ចូល";
            btnInsertAppointmentStaff.UseVisualStyleBackColor = false;
            // 
            // lblStaffPosition
            // 
            lblStaffPosition.AutoSize = true;
            lblStaffPosition.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffPosition.Location = new Point(922, 46);
            lblStaffPosition.Name = "lblStaffPosition";
            lblStaffPosition.Size = new Size(153, 43);
            lblStaffPosition.TabIndex = 22;
            lblStaffPosition.Text = "តួនាទីបុគ្គលិក:";
            // 
            // txtStaffPosition
            // 
            txtStaffPosition.Enabled = false;
            txtStaffPosition.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffPosition.Location = new Point(1084, 43);
            txtStaffPosition.Name = "txtStaffPosition";
            txtStaffPosition.Size = new Size(297, 51);
            txtStaffPosition.TabIndex = 21;
            // 
            // lblStaffName
            // 
            lblStaffName.AutoSize = true;
            lblStaffName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffName.Location = new Point(502, 46);
            lblStaffName.Name = "lblStaffName";
            lblStaffName.Size = new Size(155, 43);
            lblStaffName.TabIndex = 20;
            lblStaffName.Text = "ឈ្មោះបុគ្គលិក:";
            // 
            // txtStaffName
            // 
            txtStaffName.Enabled = false;
            txtStaffName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffName.Location = new Point(649, 43);
            txtStaffName.Name = "txtStaffName";
            txtStaffName.Size = new Size(237, 51);
            txtStaffName.TabIndex = 19;
            // 
            // lblStaffID
            // 
            lblStaffID.AutoSize = true;
            lblStaffID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffID.Location = new Point(18, 46);
            lblStaffID.Name = "lblStaffID";
            lblStaffID.Size = new Size(214, 43);
            lblStaffID.TabIndex = 18;
            lblStaffID.Text = "លេខសម្គាល់បុគ្គលិក:";
            // 
            // gbAppointmentInformation
            // 
            gbAppointmentInformation.Controls.Add(cbCustomerID);
            gbAppointmentInformation.Controls.Add(lblAppointmentID);
            gbAppointmentInformation.Controls.Add(cbAppointmentStatus);
            gbAppointmentInformation.Controls.Add(dtpAppointmentDate);
            gbAppointmentInformation.Controls.Add(lblAppointmentDate);
            gbAppointmentInformation.Controls.Add(lblAppointmentStatus);
            gbAppointmentInformation.Controls.Add(txtAppointmentID);
            gbAppointmentInformation.Controls.Add(lblCustomerID);
            gbAppointmentInformation.Font = new Font("!Khmer OS Siemreap", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            gbAppointmentInformation.Location = new Point(64, 4);
            gbAppointmentInformation.Name = "gbAppointmentInformation";
            gbAppointmentInformation.Size = new Size(1427, 155);
            gbAppointmentInformation.TabIndex = 25;
            gbAppointmentInformation.TabStop = false;
            gbAppointmentInformation.Text = "ព័ត៌មានការណាត់ជួបពិភាក្សា";
            // 
            // cbCustomerID
            // 
            cbCustomerID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbCustomerID.FormattingEnabled = true;
            cbCustomerID.Items.AddRange(new object[] { "ភ្នំពេញ", "តាកែវ" });
            cbCustomerID.Location = new Point(960, 95);
            cbCustomerID.Name = "cbCustomerID";
            cbCustomerID.Size = new Size(421, 51);
            cbCustomerID.TabIndex = 35;
            // 
            // lblAppointmentID
            // 
            lblAppointmentID.AutoSize = true;
            lblAppointmentID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAppointmentID.Location = new Point(18, 41);
            lblAppointmentID.Name = "lblAppointmentID";
            lblAppointmentID.Size = new Size(263, 43);
            lblAppointmentID.TabIndex = 34;
            lblAppointmentID.Text = "លេខសម្គាល់ការណាត់ជួប:";
            // 
            // cbAppointmentStatus
            // 
            cbAppointmentStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAppointmentStatus.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbAppointmentStatus.FormattingEnabled = true;
            cbAppointmentStatus.Items.AddRange(new object[] { "ភ្នំពេញ", "តាកែវ" });
            cbAppointmentStatus.Location = new Point(261, 95);
            cbAppointmentStatus.Name = "cbAppointmentStatus";
            cbAppointmentStatus.Size = new Size(371, 51);
            cbAppointmentStatus.TabIndex = 27;
            // 
            // dtpAppointmentDate
            // 
            dtpAppointmentDate.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpAppointmentDate.Format = DateTimePickerFormat.Short;
            dtpAppointmentDate.Location = new Point(960, 35);
            dtpAppointmentDate.Name = "dtpAppointmentDate";
            dtpAppointmentDate.Size = new Size(421, 51);
            dtpAppointmentDate.TabIndex = 20;
            // 
            // lblAppointmentDate
            // 
            lblAppointmentDate.AutoSize = true;
            lblAppointmentDate.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAppointmentDate.Location = new Point(760, 39);
            lblAppointmentDate.Name = "lblAppointmentDate";
            lblAppointmentDate.Size = new Size(225, 43);
            lblAppointmentDate.TabIndex = 19;
            lblAppointmentDate.Text = "កាលបរិច្ឆេទណាត់ជួប:";
            // 
            // lblAppointmentStatus
            // 
            lblAppointmentStatus.AutoSize = true;
            lblAppointmentStatus.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAppointmentStatus.Location = new Point(19, 98);
            lblAppointmentStatus.Name = "lblAppointmentStatus";
            lblAppointmentStatus.Size = new Size(201, 43);
            lblAppointmentStatus.TabIndex = 4;
            lblAppointmentStatus.Text = "ស្ថានភាពណាត់ជួប:";
            // 
            // txtAppointmentID
            // 
            txtAppointmentID.Enabled = false;
            txtAppointmentID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAppointmentID.Location = new Point(261, 33);
            txtAppointmentID.Name = "txtAppointmentID";
            txtAppointmentID.Size = new Size(371, 51);
            txtAppointmentID.TabIndex = 3;
            // 
            // lblCustomerID
            // 
            lblCustomerID.AutoSize = true;
            lblCustomerID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCustomerID.Location = new Point(760, 98);
            lblCustomerID.Name = "lblCustomerID";
            lblCustomerID.Size = new Size(223, 43);
            lblCustomerID.TabIndex = 6;
            lblCustomerID.Text = "លេខសម្គាល់អតិថិជន:";
            // 
            // pnlAppointmentManipulation
            // 
            pnlAppointmentManipulation.Controls.Add(btnCloseFormAppointment);
            pnlAppointmentManipulation.Controls.Add(btnNewAppointment);
            pnlAppointmentManipulation.Controls.Add(btnUpdateAppointment);
            pnlAppointmentManipulation.Controls.Add(btnInsertAppointment);
            pnlAppointmentManipulation.Location = new Point(329, 501);
            pnlAppointmentManipulation.Name = "pnlAppointmentManipulation";
            pnlAppointmentManipulation.Size = new Size(1427, 57);
            pnlAppointmentManipulation.TabIndex = 5;
            // 
            // btnCloseFormAppointment
            // 
            btnCloseFormAppointment.BackColor = Color.FromArgb(0, 28, 87);
            btnCloseFormAppointment.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCloseFormAppointment.ForeColor = Color.White;
            btnCloseFormAppointment.Location = new Point(1228, 0);
            btnCloseFormAppointment.Name = "btnCloseFormAppointment";
            btnCloseFormAppointment.Size = new Size(152, 52);
            btnCloseFormAppointment.TabIndex = 3;
            btnCloseFormAppointment.Text = "បិទ";
            btnCloseFormAppointment.UseVisualStyleBackColor = false;
            // 
            // btnNewAppointment
            // 
            btnNewAppointment.BackColor = Color.FromArgb(0, 28, 87);
            btnNewAppointment.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNewAppointment.ForeColor = Color.White;
            btnNewAppointment.Location = new Point(835, 3);
            btnNewAppointment.Name = "btnNewAppointment";
            btnNewAppointment.Size = new Size(152, 52);
            btnNewAppointment.TabIndex = 2;
            btnNewAppointment.Text = "បង្កើតថ្មី";
            btnNewAppointment.UseVisualStyleBackColor = false;
            // 
            // btnUpdateAppointment
            // 
            btnUpdateAppointment.BackColor = Color.FromArgb(0, 28, 87);
            btnUpdateAppointment.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateAppointment.ForeColor = Color.White;
            btnUpdateAppointment.Location = new Point(442, 3);
            btnUpdateAppointment.Name = "btnUpdateAppointment";
            btnUpdateAppointment.Size = new Size(152, 52);
            btnUpdateAppointment.TabIndex = 1;
            btnUpdateAppointment.Text = "កែប្រែ";
            btnUpdateAppointment.UseVisualStyleBackColor = false;
            // 
            // btnInsertAppointment
            // 
            btnInsertAppointment.BackColor = Color.FromArgb(0, 28, 87);
            btnInsertAppointment.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsertAppointment.ForeColor = Color.White;
            btnInsertAppointment.Location = new Point(49, 0);
            btnInsertAppointment.Name = "btnInsertAppointment";
            btnInsertAppointment.Size = new Size(152, 52);
            btnInsertAppointment.TabIndex = 0;
            btnInsertAppointment.Text = "បញ្ចូល";
            btnInsertAppointment.UseVisualStyleBackColor = false;
            // 
            // pnlLeftSide
            // 
            pnlLeftSide.Controls.Add(dgvStaffAssignments);
            pnlLeftSide.Controls.Add(lblSearchAppointment);
            pnlLeftSide.Controls.Add(txtSearchAppointment);
            pnlLeftSide.Location = new Point(266, 579);
            pnlLeftSide.Name = "pnlLeftSide";
            pnlLeftSide.Size = new Size(1800, 418);
            pnlLeftSide.TabIndex = 6;
            // 
            // dgvStaffAssignments
            // 
            dgvStaffAssignments.AllowUserToAddRows = false;
            dgvStaffAssignments.AllowUserToDeleteRows = false;
            dgvStaffAssignments.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 28, 87);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvStaffAssignments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvStaffAssignments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStaffAssignments.Columns.AddRange(new DataGridViewColumn[] { StaffID, StaffName, StaffPosition });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 28, 87);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvStaffAssignments.DefaultCellStyle = dataGridViewCellStyle2;
            dgvStaffAssignments.Location = new Point(63, 74);
            dgvStaffAssignments.Name = "dgvStaffAssignments";
            dgvStaffAssignments.ReadOnly = true;
            dgvStaffAssignments.RowHeadersWidth = 51;
            dgvStaffAssignments.RowTemplate.Height = 29;
            dgvStaffAssignments.Size = new Size(1428, 303);
            dgvStaffAssignments.TabIndex = 3;
            // 
            // StaffID
            // 
            StaffID.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            StaffID.HeaderText = "លេខសម្គាល់បុគ្គលិក";
            StaffID.MinimumWidth = 6;
            StaffID.Name = "StaffID";
            StaffID.ReadOnly = true;
            StaffID.Width = 243;
            // 
            // StaffName
            // 
            StaffName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StaffName.HeaderText = "ឈ្មោះបុគ្គលិក";
            StaffName.MinimumWidth = 6;
            StaffName.Name = "StaffName";
            StaffName.ReadOnly = true;
            // 
            // StaffPosition
            // 
            StaffPosition.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StaffPosition.HeaderText = "តួនាទីបុគ្គលិក";
            StaffPosition.MinimumWidth = 6;
            StaffPosition.Name = "StaffPosition";
            StaffPosition.ReadOnly = true;
            // 
            // lblSearchAppointment
            // 
            lblSearchAppointment.AutoSize = true;
            lblSearchAppointment.Location = new Point(64, 17);
            lblSearchAppointment.Name = "lblSearchAppointment";
            lblSearchAppointment.Size = new Size(367, 43);
            lblSearchAppointment.TabIndex = 1;
            lblSearchAppointment.Text = "ស្វែងរក (លេខសម្គាល់ការណាត់ជួប):";
            // 
            // txtSearchAppointment
            // 
            txtSearchAppointment.Location = new Point(402, 11);
            txtSearchAppointment.Name = "txtSearchAppointment";
            txtSearchAppointment.Size = new Size(501, 51);
            txtSearchAppointment.TabIndex = 2;
            // 
            // FrmAppointment
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1800, 1000);
            ControlBox = true;
            Controls.Add(pnlLeftSide);
            Controls.Add(pnlAppointmentManipulation);
            Controls.Add(pnlRightSide);
            Controls.Add(lblTitle);
            Name = "FrmAppointment";
            Text = "ព័ត៌មានបុគ្គលិក";
            Controls.SetChildIndex(lblTitle, 0);
            Controls.SetChildIndex(pnlRightSide, 0);
            Controls.SetChildIndex(pnlAppointmentManipulation, 0);
            Controls.SetChildIndex(pnlLeftSide, 0);
            pnlRightSide.ResumeLayout(false);
            gbStaffAssignments.ResumeLayout(false);
            gbStaffAssignments.PerformLayout();
            gbAppointmentInformation.ResumeLayout(false);
            gbAppointmentInformation.PerformLayout();
            pnlAppointmentManipulation.ResumeLayout(false);
            pnlLeftSide.ResumeLayout(false);
            pnlLeftSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStaffAssignments).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Panel pnlRightSide;
        private Label lblCustomerID;
        private Label lblAppointmentStatus;
        private TextBox txtAppointmentID;
        private GroupBox gbAppointmentInformation;
        private GroupBox gbStaffAssignments;
        private DateTimePicker dtpAppointmentDate;
        private Label lblAppointmentDate;
        private Panel pnlAppointmentManipulation;
        private Button btnInsertAppointment;
        private Button btnCloseFormAppointment;
        private Button btnNewAppointment;
        private Button btnUpdateAppointment;
        private ComboBox cbAppointmentStatus;
        private Label lblAppointmentID;
        private Panel pnlLeftSide;
        private DataGridView dgvStaffAssignments;
        private Label lblSearchAppointment;
        private TextBox txtSearchAppointment;
        private Label lblStaffID;
        private Label lblStaffName;
        private TextBox txtStaffName;
        private Label lblStaffPosition;
        private TextBox txtStaffPosition;
        private Button btnUpdateAppointmentStaff;
        private Button btnInsertAppointmentStaff;
        private ComboBox cbCustomerID;
        private DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn StaffNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn staffPositionDataGridViewTextBoxColumn;
        private ComboBox cbStaffID;
        private DataGridViewTextBoxColumn StaffID;
        private DataGridViewTextBoxColumn StaffName;
        private DataGridViewTextBoxColumn StaffPosition;
    }
}