namespace Store_Rental_Management_Systems
{
    partial class FrmPayment
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
            gbMaintenanceInformation = new GroupBox();
            cbPaymentStaffPosition = new ComboBox();
            lblPaymentStaffPosition = new Label();
            txtPaymentStaffName = new TextBox();
            lblPaymentStaffName = new Label();
            lblPaymentTotalAmount = new Label();
            lblPaymentDate = new Label();
            cbPaymentStaffID = new ComboBox();
            lblPaymentStaffID = new Label();
            cbPaymentContractID = new ComboBox();
            txtPaymentOwedAmount = new TextBox();
            lblPaymentOwedAmount = new Label();
            lblPaymentID = new Label();
            lblPaymentContractID = new Label();
            txtPaymentTotalAmount = new TextBox();
            txtPaymentID = new TextBox();
            lblPaymentPaidAmount = new Label();
            txtPaymentPaidAmount = new TextBox();
            dtpPaymentDate = new DateTimePicker();
            groupBox1 = new GroupBox();
            txtExpenseTypeQty = new TextBox();
            btnUpdateExpenseType = new Button();
            btnInsertExpenseType = new Button();
            txtExpenseTypeUnitPrice = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtExpenseTypeAmount = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtExpenseTypeDescription = new TextBox();
            txtExpenseTypeID = new TextBox();
            label7 = new Label();
            btnLogOutPayment = new Button();
            btnNewPayment = new Button();
            btnUpdatePayment = new Button();
            btnInsertPayment = new Button();
            cbPaymentSearchID = new ComboBox();
            label8 = new Label();
            dgvPaymentDetail = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            gbMaintenanceInformation.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPaymentDetail).BeginInit();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(1372, 0);
            // 
            // gbMaintenanceInformation
            // 
            gbMaintenanceInformation.Controls.Add(cbPaymentStaffPosition);
            gbMaintenanceInformation.Controls.Add(lblPaymentStaffPosition);
            gbMaintenanceInformation.Controls.Add(txtPaymentStaffName);
            gbMaintenanceInformation.Controls.Add(lblPaymentStaffName);
            gbMaintenanceInformation.Controls.Add(lblPaymentTotalAmount);
            gbMaintenanceInformation.Controls.Add(lblPaymentDate);
            gbMaintenanceInformation.Controls.Add(cbPaymentStaffID);
            gbMaintenanceInformation.Controls.Add(lblPaymentStaffID);
            gbMaintenanceInformation.Controls.Add(cbPaymentContractID);
            gbMaintenanceInformation.Controls.Add(txtPaymentOwedAmount);
            gbMaintenanceInformation.Controls.Add(lblPaymentOwedAmount);
            gbMaintenanceInformation.Controls.Add(lblPaymentID);
            gbMaintenanceInformation.Controls.Add(lblPaymentContractID);
            gbMaintenanceInformation.Controls.Add(txtPaymentTotalAmount);
            gbMaintenanceInformation.Controls.Add(txtPaymentID);
            gbMaintenanceInformation.Controls.Add(lblPaymentPaidAmount);
            gbMaintenanceInformation.Controls.Add(txtPaymentPaidAmount);
            gbMaintenanceInformation.Controls.Add(dtpPaymentDate);
            gbMaintenanceInformation.Font = new Font("Khmer OS Siemreap", 10F, FontStyle.Bold, GraphicsUnit.Point);
            gbMaintenanceInformation.Location = new Point(311, 86);
            gbMaintenanceInformation.Name = "gbMaintenanceInformation";
            gbMaintenanceInformation.Size = new Size(1427, 234);
            gbMaintenanceInformation.TabIndex = 27;
            gbMaintenanceInformation.TabStop = false;
            gbMaintenanceInformation.Text = "ព័ត៌មានថែទាំ";
            // 
            // cbPaymentStaffPosition
            // 
            cbPaymentStaffPosition.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPaymentStaffPosition.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbPaymentStaffPosition.FormattingEnabled = true;
            cbPaymentStaffPosition.Items.AddRange(new object[] { "អ្នកគ្រប់គ្រង", "គណនីករ" });
            cbPaymentStaffPosition.Location = new Point(1184, 166);
            cbPaymentStaffPosition.Name = "cbPaymentStaffPosition";
            cbPaymentStaffPosition.Size = new Size(219, 51);
            cbPaymentStaffPosition.TabIndex = 35;
            // 
            // lblPaymentStaffPosition
            // 
            lblPaymentStaffPosition.AutoSize = true;
            lblPaymentStaffPosition.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPaymentStaffPosition.Location = new Point(954, 170);
            lblPaymentStaffPosition.Name = "lblPaymentStaffPosition";
            lblPaymentStaffPosition.Size = new Size(82, 43);
            lblPaymentStaffPosition.TabIndex = 34;
            lblPaymentStaffPosition.Text = "តួនាទី:";
            // 
            // txtPaymentStaffName
            // 
            txtPaymentStaffName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPaymentStaffName.Location = new Point(686, 167);
            txtPaymentStaffName.Name = "txtPaymentStaffName";
            txtPaymentStaffName.Size = new Size(208, 51);
            txtPaymentStaffName.TabIndex = 33;
            // 
            // lblPaymentStaffName
            // 
            lblPaymentStaffName.AutoSize = true;
            lblPaymentStaffName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPaymentStaffName.Location = new Point(526, 173);
            lblPaymentStaffName.Name = "lblPaymentStaffName";
            lblPaymentStaffName.Size = new Size(155, 43);
            lblPaymentStaffName.TabIndex = 32;
            lblPaymentStaffName.Text = "ឈ្មោះបុគ្គលិក:";
            // 
            // lblPaymentTotalAmount
            // 
            lblPaymentTotalAmount.AutoSize = true;
            lblPaymentTotalAmount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPaymentTotalAmount.Location = new Point(949, 43);
            lblPaymentTotalAmount.Name = "lblPaymentTotalAmount";
            lblPaymentTotalAmount.Size = new Size(113, 43);
            lblPaymentTotalAmount.TabIndex = 31;
            lblPaymentTotalAmount.Text = "តម្លៃសរុប:";
            // 
            // lblPaymentDate
            // 
            lblPaymentDate.AutoSize = true;
            lblPaymentDate.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPaymentDate.Location = new Point(526, 46);
            lblPaymentDate.Name = "lblPaymentDate";
            lblPaymentDate.Size = new Size(137, 43);
            lblPaymentDate.TabIndex = 30;
            lblPaymentDate.Text = "កាលបរិច្ឆេទ:";
            // 
            // cbPaymentStaffID
            // 
            cbPaymentStaffID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPaymentStaffID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbPaymentStaffID.FormattingEnabled = true;
            cbPaymentStaffID.Items.AddRange(new object[] { "អ្នកគ្រប់គ្រង", "គណនីករ" });
            cbPaymentStaffID.Location = new Point(255, 165);
            cbPaymentStaffID.Name = "cbPaymentStaffID";
            cbPaymentStaffID.Size = new Size(223, 51);
            cbPaymentStaffID.TabIndex = 29;
            // 
            // lblPaymentStaffID
            // 
            lblPaymentStaffID.AutoSize = true;
            lblPaymentStaffID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPaymentStaffID.Location = new Point(18, 168);
            lblPaymentStaffID.Name = "lblPaymentStaffID";
            lblPaymentStaffID.Size = new Size(175, 43);
            lblPaymentStaffID.TabIndex = 28;
            lblPaymentStaffID.Text = "លេខសម្គាល់តូប:";
            // 
            // cbPaymentContractID
            // 
            cbPaymentContractID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPaymentContractID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbPaymentContractID.FormattingEnabled = true;
            cbPaymentContractID.Items.AddRange(new object[] { "អ្នកគ្រប់គ្រង", "គណនីករ" });
            cbPaymentContractID.Location = new Point(1184, 102);
            cbPaymentContractID.Name = "cbPaymentContractID";
            cbPaymentContractID.Size = new Size(219, 51);
            cbPaymentContractID.TabIndex = 27;
            // 
            // txtPaymentOwedAmount
            // 
            txtPaymentOwedAmount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPaymentOwedAmount.Location = new Point(683, 101);
            txtPaymentOwedAmount.Name = "txtPaymentOwedAmount";
            txtPaymentOwedAmount.Size = new Size(208, 51);
            txtPaymentOwedAmount.TabIndex = 26;
            // 
            // lblPaymentOwedAmount
            // 
            lblPaymentOwedAmount.AutoSize = true;
            lblPaymentOwedAmount.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPaymentOwedAmount.Location = new Point(526, 109);
            lblPaymentOwedAmount.Name = "lblPaymentOwedAmount";
            lblPaymentOwedAmount.Size = new Size(122, 43);
            lblPaymentOwedAmount.TabIndex = 25;
            lblPaymentOwedAmount.Text = "តម្លៃជំពាក់:";
            // 
            // lblPaymentID
            // 
            lblPaymentID.AutoSize = true;
            lblPaymentID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPaymentID.Location = new Point(18, 41);
            lblPaymentID.Name = "lblPaymentID";
            lblPaymentID.Size = new Size(231, 43);
            lblPaymentID.TabIndex = 0;
            lblPaymentID.Text = "លេខសម្គាល់ការបង់ថ្លៃ:";
            // 
            // lblPaymentContractID
            // 
            lblPaymentContractID.AutoSize = true;
            lblPaymentContractID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPaymentContractID.Location = new Point(949, 105);
            lblPaymentContractID.Name = "lblPaymentContractID";
            lblPaymentContractID.Size = new Size(229, 43);
            lblPaymentContractID.TabIndex = 14;
            lblPaymentContractID.Text = "លេខសម្គាល់កិច្ចសន្យា:";
            // 
            // txtPaymentTotalAmount
            // 
            txtPaymentTotalAmount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPaymentTotalAmount.Location = new Point(1184, 41);
            txtPaymentTotalAmount.Name = "txtPaymentTotalAmount";
            txtPaymentTotalAmount.Size = new Size(217, 51);
            txtPaymentTotalAmount.TabIndex = 5;
            // 
            // txtPaymentID
            // 
            txtPaymentID.Enabled = false;
            txtPaymentID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPaymentID.Location = new Point(255, 33);
            txtPaymentID.Name = "txtPaymentID";
            txtPaymentID.Size = new Size(223, 51);
            txtPaymentID.TabIndex = 3;
            // 
            // lblPaymentPaidAmount
            // 
            lblPaymentPaidAmount.AutoSize = true;
            lblPaymentPaidAmount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPaymentPaidAmount.Location = new Point(18, 106);
            lblPaymentPaidAmount.Name = "lblPaymentPaidAmount";
            lblPaymentPaidAmount.Size = new Size(162, 43);
            lblPaymentPaidAmount.TabIndex = 6;
            lblPaymentPaidAmount.Text = "តម្លៃបានទូទាត់:";
            // 
            // txtPaymentPaidAmount
            // 
            txtPaymentPaidAmount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPaymentPaidAmount.Location = new Point(255, 98);
            txtPaymentPaidAmount.Name = "txtPaymentPaidAmount";
            txtPaymentPaidAmount.Size = new Size(223, 51);
            txtPaymentPaidAmount.TabIndex = 7;
            // 
            // dtpPaymentDate
            // 
            dtpPaymentDate.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpPaymentDate.Format = DateTimePickerFormat.Short;
            dtpPaymentDate.Location = new Point(683, 36);
            dtpPaymentDate.Name = "dtpPaymentDate";
            dtpPaymentDate.Size = new Size(208, 51);
            dtpPaymentDate.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtExpenseTypeQty);
            groupBox1.Controls.Add(btnUpdateExpenseType);
            groupBox1.Controls.Add(btnInsertExpenseType);
            groupBox1.Controls.Add(txtExpenseTypeUnitPrice);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtExpenseTypeAmount);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtExpenseTypeDescription);
            groupBox1.Controls.Add(txtExpenseTypeID);
            groupBox1.Controls.Add(label7);
            groupBox1.Font = new Font("Khmer OS Siemreap", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(311, 320);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1427, 241);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            groupBox1.Text = "ប្រភេទនៃការចំណាយ";
            // 
            // txtExpenseTypeQty
            // 
            txtExpenseTypeQty.Enabled = false;
            txtExpenseTypeQty.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtExpenseTypeQty.Location = new Point(260, 109);
            txtExpenseTypeQty.Name = "txtExpenseTypeQty";
            txtExpenseTypeQty.Size = new Size(223, 51);
            txtExpenseTypeQty.TabIndex = 35;
            // 
            // btnUpdateExpenseType
            // 
            btnUpdateExpenseType.AutoSize = true;
            btnUpdateExpenseType.BackColor = Color.FromArgb(0, 28, 87);
            btnUpdateExpenseType.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateExpenseType.ForeColor = Color.White;
            btnUpdateExpenseType.Location = new Point(1032, 169);
            btnUpdateExpenseType.Name = "btnUpdateExpenseType";
            btnUpdateExpenseType.Size = new Size(128, 60);
            btnUpdateExpenseType.TabIndex = 34;
            btnUpdateExpenseType.Text = "កែប្រែ";
            btnUpdateExpenseType.UseVisualStyleBackColor = false;
            // 
            // btnInsertExpenseType
            // 
            btnInsertExpenseType.AutoSize = true;
            btnInsertExpenseType.BackColor = Color.FromArgb(0, 28, 87);
            btnInsertExpenseType.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsertExpenseType.ForeColor = Color.White;
            btnInsertExpenseType.Location = new Point(881, 169);
            btnInsertExpenseType.Name = "btnInsertExpenseType";
            btnInsertExpenseType.Size = new Size(128, 60);
            btnInsertExpenseType.TabIndex = 33;
            btnInsertExpenseType.Text = "បញ្ចូល";
            btnInsertExpenseType.UseVisualStyleBackColor = false;
            // 
            // txtExpenseTypeUnitPrice
            // 
            txtExpenseTypeUnitPrice.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtExpenseTypeUnitPrice.Location = new Point(669, 40);
            txtExpenseTypeUnitPrice.Name = "txtExpenseTypeUnitPrice";
            txtExpenseTypeUnitPrice.Size = new Size(208, 51);
            txtExpenseTypeUnitPrice.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(949, 43);
            label1.Name = "label1";
            label1.Size = new Size(98, 43);
            label1.TabIndex = 31;
            label1.Text = "ពិណ៌នា:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(526, 46);
            label2.Name = "label2";
            label2.Size = new Size(129, 43);
            label2.TabIndex = 30;
            label2.Text = "តម្លៃនាំចូល:";
            // 
            // txtExpenseTypeAmount
            // 
            txtExpenseTypeAmount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtExpenseTypeAmount.Location = new Point(669, 108);
            txtExpenseTypeAmount.Name = "txtExpenseTypeAmount";
            txtExpenseTypeAmount.Size = new Size(208, 51);
            txtExpenseTypeAmount.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(527, 117);
            label4.Name = "label4";
            label4.Size = new Size(113, 43);
            label4.TabIndex = 25;
            label4.Text = "តម្លៃសរុប:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(6, 49);
            label5.Name = "label5";
            label5.Size = new Size(255, 43);
            label5.TabIndex = 0;
            label5.Text = "លេខសម្គាល់ការចំណាយ:";
            // 
            // txtExpenseTypeDescription
            // 
            txtExpenseTypeDescription.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtExpenseTypeDescription.Location = new Point(1075, 41);
            txtExpenseTypeDescription.Multiline = true;
            txtExpenseTypeDescription.Name = "txtExpenseTypeDescription";
            txtExpenseTypeDescription.Size = new Size(326, 111);
            txtExpenseTypeDescription.TabIndex = 5;
            // 
            // txtExpenseTypeID
            // 
            txtExpenseTypeID.Enabled = false;
            txtExpenseTypeID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtExpenseTypeID.Location = new Point(260, 43);
            txtExpenseTypeID.Name = "txtExpenseTypeID";
            txtExpenseTypeID.Size = new Size(223, 51);
            txtExpenseTypeID.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(18, 111);
            label7.Name = "label7";
            label7.Size = new Size(106, 43);
            label7.TabIndex = 6;
            label7.Text = "បរិមាណ:";
            // 
            // btnLogOutPayment
            // 
            btnLogOutPayment.AutoSize = true;
            btnLogOutPayment.BackColor = Color.FromArgb(0, 28, 87);
            btnLogOutPayment.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogOutPayment.ForeColor = Color.White;
            btnLogOutPayment.Location = new Point(852, 583);
            btnLogOutPayment.Name = "btnLogOutPayment";
            btnLogOutPayment.Size = new Size(128, 60);
            btnLogOutPayment.TabIndex = 42;
            btnLogOutPayment.Text = "បិទ";
            btnLogOutPayment.UseVisualStyleBackColor = false;
            // 
            // btnNewPayment
            // 
            btnNewPayment.AutoSize = true;
            btnNewPayment.BackColor = Color.FromArgb(0, 28, 87);
            btnNewPayment.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNewPayment.ForeColor = Color.White;
            btnNewPayment.Location = new Point(666, 583);
            btnNewPayment.Name = "btnNewPayment";
            btnNewPayment.Size = new Size(128, 60);
            btnNewPayment.TabIndex = 41;
            btnNewPayment.Text = "បង្កើតថ្មី";
            btnNewPayment.UseVisualStyleBackColor = false;
            // 
            // btnUpdatePayment
            // 
            btnUpdatePayment.AutoSize = true;
            btnUpdatePayment.BackColor = Color.FromArgb(0, 28, 87);
            btnUpdatePayment.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdatePayment.ForeColor = Color.White;
            btnUpdatePayment.Location = new Point(481, 583);
            btnUpdatePayment.Name = "btnUpdatePayment";
            btnUpdatePayment.Size = new Size(128, 60);
            btnUpdatePayment.TabIndex = 40;
            btnUpdatePayment.Text = "កែប្រែ";
            btnUpdatePayment.UseVisualStyleBackColor = false;
            // 
            // btnInsertPayment
            // 
            btnInsertPayment.AutoSize = true;
            btnInsertPayment.BackColor = Color.FromArgb(0, 28, 87);
            btnInsertPayment.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsertPayment.ForeColor = Color.White;
            btnInsertPayment.Location = new Point(308, 583);
            btnInsertPayment.Name = "btnInsertPayment";
            btnInsertPayment.Size = new Size(128, 60);
            btnInsertPayment.TabIndex = 39;
            btnInsertPayment.Text = "បញ្ចូល";
            btnInsertPayment.UseVisualStyleBackColor = false;
            // 
            // cbPaymentSearchID
            // 
            cbPaymentSearchID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPaymentSearchID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbPaymentSearchID.FormattingEnabled = true;
            cbPaymentSearchID.Items.AddRange(new object[] { "អ្នកគ្រប់គ្រង", "គណនីករ" });
            cbPaymentSearchID.Location = new Point(660, 663);
            cbPaymentSearchID.Name = "cbPaymentSearchID";
            cbPaymentSearchID.Size = new Size(323, 51);
            cbPaymentSearchID.TabIndex = 44;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(311, 666);
            label8.Name = "label8";
            label8.Size = new Size(342, 43);
            label8.TabIndex = 43;
            label8.Text = "ស្វែងរក (លេខសម្គាល់ការបង់ថ្លៃ)​ :";
            // 
            // dgvPaymentDetail
            // 
            dgvPaymentDetail.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvPaymentDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvPaymentDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPaymentDetail.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column6 });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(25, 113, 176);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvPaymentDetail.DefaultCellStyle = dataGridViewCellStyle4;
            dgvPaymentDetail.Location = new Point(287, 735);
            dgvPaymentDetail.Name = "dgvPaymentDetail";
            dgvPaymentDetail.RowHeadersWidth = 60;
            dgvPaymentDetail.RowTemplate.Height = 33;
            dgvPaymentDetail.Size = new Size(1451, 185);
            dgvPaymentDetail.TabIndex = 45;
            // 
            // Column1
            // 
            Column1.HeaderText = "លេខសម្គាល់ការចំណាយ";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 300;
            // 
            // Column2
            // 
            Column2.HeaderText = "ពិពណ៌នាសម្ភារៈ";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 215;
            // 
            // Column3
            // 
            Column3.HeaderText = "បរិមាណសម្ភារៈ";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 215;
            // 
            // Column4
            // 
            Column4.HeaderText = "តម្លៃនាំចូលសម្ភារៈ";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 230;
            // 
            // Column6
            // 
            Column6.HeaderText = "ខ្នាតរង្វាស់សម្ភារៈ";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.Width = 230;
            // 
            // FrmPayment
            // 
            AutoScaleDimensions = new SizeF(13F, 43F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1778, 944);
            Controls.Add(dgvPaymentDetail);
            Controls.Add(cbPaymentSearchID);
            Controls.Add(label8);
            Controls.Add(btnLogOutPayment);
            Controls.Add(btnNewPayment);
            Controls.Add(btnUpdatePayment);
            Controls.Add(btnInsertPayment);
            Controls.Add(groupBox1);
            Controls.Add(gbMaintenanceInformation);
            Name = "FrmPayment";
            Text = "FrmPayment";
            Controls.SetChildIndex(gbMaintenanceInformation, 0);
            Controls.SetChildIndex(groupBox1, 0);
            Controls.SetChildIndex(btnInsertPayment, 0);
            Controls.SetChildIndex(btnUpdatePayment, 0);
            Controls.SetChildIndex(btnNewPayment, 0);
            Controls.SetChildIndex(btnLogOutPayment, 0);
            Controls.SetChildIndex(label8, 0);
            Controls.SetChildIndex(cbPaymentSearchID, 0);
            Controls.SetChildIndex(dgvPaymentDetail, 0);
            gbMaintenanceInformation.ResumeLayout(false);
            gbMaintenanceInformation.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPaymentDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbMaintenanceInformation;
        private Label lblPaymentTotalAmount;
        private Label lblPaymentDate;
        private ComboBox cbPaymentStaffID;
        private Label lblPaymentStaffID;
        private ComboBox cbPaymentContractID;
        private TextBox txtPaymentOwedAmount;
        private Label lblPaymentOwedAmount;
        private Label lblPaymentID;
        private Label lblPaymentContractID;
        private TextBox txtPaymentTotalAmount;
        private TextBox txtPaymentID;
        private Label lblPaymentPaidAmount;
        private TextBox txtPaymentPaidAmount;
        private DateTimePicker dtpPaymentDate;
        private Label lblPaymentStaffName;
        private ComboBox cbPaymentStaffPosition;
        private Label lblPaymentStaffPosition;
        private TextBox txtPaymentStaffName;
        private GroupBox groupBox1;
        private Button btnUpdateExpenseType;
        private Button btnInsertExpenseType;
        private TextBox txtExpenseTypeUnitPrice;
        private Label label1;
        private Label label2;
        private TextBox txtExpenseTypeAmount;
        private Label label4;
        private Label label5;
        private TextBox txtExpenseTypeDescription;
        private TextBox txtExpenseTypeID;
        private Label label7;
        private TextBox txtExpenseTypeQty;
        private Button btnLogOutPayment;
        private Button btnNewPayment;
        private Button btnUpdatePayment;
        private Button btnInsertPayment;
        private ComboBox cbPaymentSearchID;
        private Label label8;
        private DataGridView dgvPaymentDetail;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;
    }
}