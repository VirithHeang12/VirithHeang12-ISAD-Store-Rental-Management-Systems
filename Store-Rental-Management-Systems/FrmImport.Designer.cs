namespace Store_Rental_Management_Systems
{
    partial class FrmImport
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
            txtImportStaffName = new TextBox();
            cbImportStaffPosition = new ComboBox();
            lblImportStaffPosition = new Label();
            lblMaintenanceTotalAmount = new Label();
            lblMaintenanceDate = new Label();
            cbImportSupplierID = new ComboBox();
            lblImportStaffName = new Label();
            cbImportStaffID = new ComboBox();
            txtImportSupplierName = new TextBox();
            lblImportSupplierName = new Label();
            lblMaintenanceID = new Label();
            lblImportStaffID = new Label();
            txtImportTotalAmount = new TextBox();
            txtImportID = new TextBox();
            lblImportSupplierID = new Label();
            dtpImportDate = new DateTimePicker();
            groupBox1 = new GroupBox();
            btnUpdateImportItem = new Button();
            btnInsertImportItem = new Button();
            txtImportItemUnitPrice = new TextBox();
            label2 = new Label();
            label3 = new Label();
            cbImportItemCategory = new ComboBox();
            txtImportItemQuantity = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtImportItemDescription = new TextBox();
            txtImportDetailID = new TextBox();
            label7 = new Label();
            txtImportItemUnit = new TextBox();
            dgvImportDetail = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            btnLogOutImport = new Button();
            btnNewImport = new Button();
            btnUpdateImport = new Button();
            btnInsertImport = new Button();
            cbImportID = new ComboBox();
            lblImportSearchID = new Label();
            gbMaintenanceInformation.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvImportDetail).BeginInit();
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
            lblTitle.Size = new Size(1534, 86);
            lblTitle.TabIndex = 50;
            lblTitle.Text = "ព័ត៌មានការនាំចូល";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gbMaintenanceInformation
            // 
            gbMaintenanceInformation.Controls.Add(txtImportStaffName);
            gbMaintenanceInformation.Controls.Add(cbImportStaffPosition);
            gbMaintenanceInformation.Controls.Add(lblImportStaffPosition);
            gbMaintenanceInformation.Controls.Add(lblMaintenanceTotalAmount);
            gbMaintenanceInformation.Controls.Add(lblMaintenanceDate);
            gbMaintenanceInformation.Controls.Add(cbImportSupplierID);
            gbMaintenanceInformation.Controls.Add(lblImportStaffName);
            gbMaintenanceInformation.Controls.Add(cbImportStaffID);
            gbMaintenanceInformation.Controls.Add(txtImportSupplierName);
            gbMaintenanceInformation.Controls.Add(lblImportSupplierName);
            gbMaintenanceInformation.Controls.Add(lblMaintenanceID);
            gbMaintenanceInformation.Controls.Add(lblImportStaffID);
            gbMaintenanceInformation.Controls.Add(txtImportTotalAmount);
            gbMaintenanceInformation.Controls.Add(txtImportID);
            gbMaintenanceInformation.Controls.Add(lblImportSupplierID);
            gbMaintenanceInformation.Controls.Add(dtpImportDate);
            gbMaintenanceInformation.Font = new Font("Khmer OS Siemreap", 10F, FontStyle.Bold, GraphicsUnit.Point);
            gbMaintenanceInformation.Location = new Point(291, 176);
            gbMaintenanceInformation.Name = "gbMaintenanceInformation";
            gbMaintenanceInformation.Size = new Size(1456, 229);
            gbMaintenanceInformation.TabIndex = 51;
            gbMaintenanceInformation.TabStop = false;
            gbMaintenanceInformation.Text = "ព័ត៌មានការនាំចូល";
            // 
            // txtImportStaffName
            // 
            txtImportStaffName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtImportStaffName.Location = new Point(265, 162);
            txtImportStaffName.Name = "txtImportStaffName";
            txtImportStaffName.Size = new Size(210, 51);
            txtImportStaffName.TabIndex = 34;
            // 
            // cbImportStaffPosition
            // 
            cbImportStaffPosition.DropDownStyle = ComboBoxStyle.DropDownList;
            cbImportStaffPosition.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbImportStaffPosition.FormattingEnabled = true;
            cbImportStaffPosition.Items.AddRange(new object[] { "អ្នកគ្រប់គ្រង", "គណនីករ" });
            cbImportStaffPosition.Location = new Point(715, 152);
            cbImportStaffPosition.Name = "cbImportStaffPosition";
            cbImportStaffPosition.Size = new Size(208, 51);
            cbImportStaffPosition.TabIndex = 33;
            // 
            // lblImportStaffPosition
            // 
            lblImportStaffPosition.AutoSize = true;
            lblImportStaffPosition.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblImportStaffPosition.Location = new Point(526, 165);
            lblImportStaffPosition.Name = "lblImportStaffPosition";
            lblImportStaffPosition.Size = new Size(153, 43);
            lblImportStaffPosition.TabIndex = 32;
            lblImportStaffPosition.Text = "តួនាទីបុគ្គលិក:";
            // 
            // lblMaintenanceTotalAmount
            // 
            lblMaintenanceTotalAmount.AutoSize = true;
            lblMaintenanceTotalAmount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMaintenanceTotalAmount.Location = new Point(986, 43);
            lblMaintenanceTotalAmount.Name = "lblMaintenanceTotalAmount";
            lblMaintenanceTotalAmount.Size = new Size(169, 43);
            lblMaintenanceTotalAmount.TabIndex = 31;
            lblMaintenanceTotalAmount.Text = "ចំនួនប្រាក់សរុប:";
            // 
            // lblMaintenanceDate
            // 
            lblMaintenanceDate.AutoSize = true;
            lblMaintenanceDate.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMaintenanceDate.Location = new Point(526, 37);
            lblMaintenanceDate.Name = "lblMaintenanceDate";
            lblMaintenanceDate.Size = new Size(137, 43);
            lblMaintenanceDate.TabIndex = 30;
            lblMaintenanceDate.Text = "កាលបរិច្ឆេទ:";
            // 
            // cbImportSupplierID
            // 
            cbImportSupplierID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbImportSupplierID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbImportSupplierID.FormattingEnabled = true;
            cbImportSupplierID.Items.AddRange(new object[] { "អ្នកគ្រប់គ្រង", "គណនីករ" });
            cbImportSupplierID.Location = new Point(265, 96);
            cbImportSupplierID.Name = "cbImportSupplierID";
            cbImportSupplierID.Size = new Size(210, 51);
            cbImportSupplierID.TabIndex = 29;
            // 
            // lblImportStaffName
            // 
            lblImportStaffName.AutoSize = true;
            lblImportStaffName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblImportStaffName.Location = new Point(18, 159);
            lblImportStaffName.Name = "lblImportStaffName";
            lblImportStaffName.Size = new Size(155, 43);
            lblImportStaffName.TabIndex = 28;
            lblImportStaffName.Text = "ឈ្មោះបុគ្គលិក:";
            // 
            // cbImportStaffID
            // 
            cbImportStaffID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbImportStaffID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbImportStaffID.FormattingEnabled = true;
            cbImportStaffID.Items.AddRange(new object[] { "អ្នកគ្រប់គ្រង", "គណនីករ" });
            cbImportStaffID.Location = new Point(1221, 103);
            cbImportStaffID.Name = "cbImportStaffID";
            cbImportStaffID.Size = new Size(219, 51);
            cbImportStaffID.TabIndex = 27;
            // 
            // txtImportSupplierName
            // 
            txtImportSupplierName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtImportSupplierName.Location = new Point(715, 90);
            txtImportSupplierName.Name = "txtImportSupplierName";
            txtImportSupplierName.Size = new Size(208, 51);
            txtImportSupplierName.TabIndex = 26;
            // 
            // lblImportSupplierName
            // 
            lblImportSupplierName.AutoSize = true;
            lblImportSupplierName.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblImportSupplierName.Location = new Point(526, 99);
            lblImportSupplierName.Name = "lblImportSupplierName";
            lblImportSupplierName.Size = new Size(180, 43);
            lblImportSupplierName.TabIndex = 25;
            lblImportSupplierName.Text = "ឈ្មោះអ្នកផ្គត់ផ្គង់:";
            // 
            // lblMaintenanceID
            // 
            lblMaintenanceID.AutoSize = true;
            lblMaintenanceID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMaintenanceID.Location = new Point(18, 41);
            lblMaintenanceID.Name = "lblMaintenanceID";
            lblMaintenanceID.Size = new Size(238, 43);
            lblMaintenanceID.TabIndex = 0;
            lblMaintenanceID.Text = "លេខសម្គាល់ការនាំចូល:";
            // 
            // lblImportStaffID
            // 
            lblImportStaffID.AutoSize = true;
            lblImportStaffID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblImportStaffID.Location = new Point(986, 106);
            lblImportStaffID.Name = "lblImportStaffID";
            lblImportStaffID.Size = new Size(214, 43);
            lblImportStaffID.TabIndex = 14;
            lblImportStaffID.Text = "លេខសម្គាល់បុគ្គលិក:";
            // 
            // txtImportTotalAmount
            // 
            txtImportTotalAmount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtImportTotalAmount.Location = new Point(1221, 41);
            txtImportTotalAmount.Name = "txtImportTotalAmount";
            txtImportTotalAmount.Size = new Size(217, 51);
            txtImportTotalAmount.TabIndex = 5;
            // 
            // txtImportID
            // 
            txtImportID.Enabled = false;
            txtImportID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtImportID.Location = new Point(265, 28);
            txtImportID.Name = "txtImportID";
            txtImportID.Size = new Size(210, 51);
            txtImportID.TabIndex = 3;
            // 
            // lblImportSupplierID
            // 
            lblImportSupplierID.AutoSize = true;
            lblImportSupplierID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblImportSupplierID.Location = new Point(18, 101);
            lblImportSupplierID.Name = "lblImportSupplierID";
            lblImportSupplierID.Size = new Size(239, 43);
            lblImportSupplierID.TabIndex = 6;
            lblImportSupplierID.Text = "លេខសម្គាល់អ្នកផ្គត់ផ្គង់:";
            // 
            // dtpImportDate
            // 
            dtpImportDate.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpImportDate.Format = DateTimePickerFormat.Short;
            dtpImportDate.Location = new Point(715, 31);
            dtpImportDate.Name = "dtpImportDate";
            dtpImportDate.Size = new Size(208, 51);
            dtpImportDate.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnUpdateImportItem);
            groupBox1.Controls.Add(btnInsertImportItem);
            groupBox1.Controls.Add(txtImportItemUnitPrice);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cbImportItemCategory);
            groupBox1.Controls.Add(txtImportItemQuantity);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtImportItemDescription);
            groupBox1.Controls.Add(txtImportDetailID);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtImportItemUnit);
            groupBox1.Font = new Font("Khmer OS Siemreap", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(291, 408);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1427, 241);
            groupBox1.TabIndex = 52;
            groupBox1.TabStop = false;
            groupBox1.Text = "ព័ត៌មានសម្ភារៈ";
            // 
            // btnUpdateImportItem
            // 
            btnUpdateImportItem.AutoSize = true;
            btnUpdateImportItem.BackColor = Color.FromArgb(0, 28, 87);
            btnUpdateImportItem.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateImportItem.ForeColor = Color.White;
            btnUpdateImportItem.Location = new Point(1032, 169);
            btnUpdateImportItem.Name = "btnUpdateImportItem";
            btnUpdateImportItem.Size = new Size(128, 60);
            btnUpdateImportItem.TabIndex = 34;
            btnUpdateImportItem.Text = "កែប្រែ";
            btnUpdateImportItem.UseVisualStyleBackColor = false;
            // 
            // btnInsertImportItem
            // 
            btnInsertImportItem.AutoSize = true;
            btnInsertImportItem.BackColor = Color.FromArgb(0, 28, 87);
            btnInsertImportItem.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsertImportItem.ForeColor = Color.White;
            btnInsertImportItem.Location = new Point(881, 169);
            btnInsertImportItem.Name = "btnInsertImportItem";
            btnInsertImportItem.Size = new Size(128, 60);
            btnInsertImportItem.TabIndex = 33;
            btnInsertImportItem.Text = "បញ្ចូល";
            btnInsertImportItem.UseVisualStyleBackColor = false;
            // 
            // txtImportItemUnitPrice
            // 
            txtImportItemUnitPrice.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtImportItemUnitPrice.Location = new Point(669, 40);
            txtImportItemUnitPrice.Name = "txtImportItemUnitPrice";
            txtImportItemUnitPrice.Size = new Size(208, 51);
            txtImportItemUnitPrice.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(949, 43);
            label2.Name = "label2";
            label2.Size = new Size(98, 43);
            label2.TabIndex = 31;
            label2.Text = "ពិណ៌នា:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(526, 46);
            label3.Name = "label3";
            label3.Size = new Size(129, 43);
            label3.TabIndex = 30;
            label3.Text = "តម្លៃនាំចូល:";
            // 
            // cbImportItemCategory
            // 
            cbImportItemCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbImportItemCategory.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbImportItemCategory.FormattingEnabled = true;
            cbImportItemCategory.Items.AddRange(new object[] { "អ្នកគ្រប់គ្រង", "គណនីករ" });
            cbImportItemCategory.Location = new Point(242, 108);
            cbImportItemCategory.Name = "cbImportItemCategory";
            cbImportItemCategory.Size = new Size(219, 51);
            cbImportItemCategory.TabIndex = 27;
            // 
            // txtImportItemQuantity
            // 
            txtImportItemQuantity.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtImportItemQuantity.Location = new Point(669, 108);
            txtImportItemQuantity.Name = "txtImportItemQuantity";
            txtImportItemQuantity.Size = new Size(208, 51);
            txtImportItemQuantity.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(18, 109);
            label4.Name = "label4";
            label4.Size = new Size(90, 43);
            label4.TabIndex = 25;
            label4.Text = "ប្រភេទ:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(18, 43);
            label5.Name = "label5";
            label5.Size = new Size(207, 43);
            label5.TabIndex = 0;
            label5.Text = "លេខសម្គាល់សម្ភារៈ:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(18, 178);
            label6.Name = "label6";
            label6.Size = new Size(121, 43);
            label6.TabIndex = 14;
            label6.Text = "ខ្នាតរង្វាស់:";
            // 
            // txtImportItemDescription
            // 
            txtImportItemDescription.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtImportItemDescription.Location = new Point(1067, 43);
            txtImportItemDescription.Multiline = true;
            txtImportItemDescription.Name = "txtImportItemDescription";
            txtImportItemDescription.Size = new Size(334, 100);
            txtImportItemDescription.TabIndex = 5;
            // 
            // txtImportDetailID
            // 
            txtImportDetailID.Enabled = false;
            txtImportDetailID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtImportDetailID.Location = new Point(242, 35);
            txtImportDetailID.Name = "txtImportDetailID";
            txtImportDetailID.Size = new Size(223, 51);
            txtImportDetailID.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(526, 111);
            label7.Name = "label7";
            label7.Size = new Size(106, 43);
            label7.TabIndex = 6;
            label7.Text = "បរិមាណ:";
            // 
            // txtImportItemUnit
            // 
            txtImportItemUnit.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtImportItemUnit.Location = new Point(242, 175);
            txtImportItemUnit.Name = "txtImportItemUnit";
            txtImportItemUnit.Size = new Size(219, 51);
            txtImportItemUnit.TabIndex = 7;
            // 
            // dgvImportDetail
            // 
            dgvImportDetail.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvImportDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvImportDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvImportDetail.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(25, 113, 176);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvImportDetail.DefaultCellStyle = dataGridViewCellStyle4;
            dgvImportDetail.Location = new Point(283, 809);
            dgvImportDetail.Name = "dgvImportDetail";
            dgvImportDetail.RowHeadersWidth = 60;
            dgvImportDetail.RowTemplate.Height = 33;
            dgvImportDetail.Size = new Size(1409, 173);
            dgvImportDetail.TabIndex = 55;
            // 
            // Column1
            // 
            Column1.HeaderText = "លេខសម្គាល់សម្ភារៈ";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 240;
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
            // Column5
            // 
            Column5.HeaderText = "ប្រភេទនៃសម្ភារៈ";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.Width = 215;
            // 
            // Column6
            // 
            Column6.HeaderText = "ខ្នាតរង្វាស់សម្ភារៈ";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.Width = 230;
            // 
            // btnLogOutImport
            // 
            btnLogOutImport.AutoSize = true;
            btnLogOutImport.BackColor = Color.FromArgb(0, 28, 87);
            btnLogOutImport.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogOutImport.ForeColor = Color.White;
            btnLogOutImport.Location = new Point(836, 659);
            btnLogOutImport.Name = "btnLogOutImport";
            btnLogOutImport.Size = new Size(128, 60);
            btnLogOutImport.TabIndex = 59;
            btnLogOutImport.Text = "បិទ";
            btnLogOutImport.UseVisualStyleBackColor = false;
            // 
            // btnNewImport
            // 
            btnNewImport.AutoSize = true;
            btnNewImport.BackColor = Color.FromArgb(0, 28, 87);
            btnNewImport.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNewImport.ForeColor = Color.White;
            btnNewImport.Location = new Point(650, 659);
            btnNewImport.Name = "btnNewImport";
            btnNewImport.Size = new Size(128, 60);
            btnNewImport.TabIndex = 58;
            btnNewImport.Text = "បង្កើតថ្មី";
            btnNewImport.UseVisualStyleBackColor = false;
            // 
            // btnUpdateImport
            // 
            btnUpdateImport.AutoSize = true;
            btnUpdateImport.BackColor = Color.FromArgb(0, 28, 87);
            btnUpdateImport.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateImport.ForeColor = Color.White;
            btnUpdateImport.Location = new Point(465, 659);
            btnUpdateImport.Name = "btnUpdateImport";
            btnUpdateImport.Size = new Size(128, 60);
            btnUpdateImport.TabIndex = 57;
            btnUpdateImport.Text = "កែប្រែ";
            btnUpdateImport.UseVisualStyleBackColor = false;
            // 
            // btnInsertImport
            // 
            btnInsertImport.AutoSize = true;
            btnInsertImport.BackColor = Color.FromArgb(0, 28, 87);
            btnInsertImport.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsertImport.ForeColor = Color.White;
            btnInsertImport.Location = new Point(292, 659);
            btnInsertImport.Name = "btnInsertImport";
            btnInsertImport.Size = new Size(128, 60);
            btnInsertImport.TabIndex = 56;
            btnInsertImport.Text = "បញ្ចូល";
            btnInsertImport.UseVisualStyleBackColor = false;
            // 
            // cbImportID
            // 
            cbImportID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbImportID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbImportID.FormattingEnabled = true;
            cbImportID.Items.AddRange(new object[] { "អ្នកគ្រប់គ្រង", "គណនីករ" });
            cbImportID.Location = new Point(632, 733);
            cbImportID.Name = "cbImportID";
            cbImportID.Size = new Size(323, 51);
            cbImportID.TabIndex = 54;
            // 
            // lblImportSearchID
            // 
            lblImportSearchID.AutoSize = true;
            lblImportSearchID.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblImportSearchID.Location = new Point(283, 737);
            lblImportSearchID.Name = "lblImportSearchID";
            lblImportSearchID.Size = new Size(334, 43);
            lblImportSearchID.TabIndex = 53;
            lblImportSearchID.Text = "ស្វែងរក (លេខសម្គាល់ការថែទាំ)​ :";
            // 
            // FrmImport
            // 
            AutoScaleDimensions = new SizeF(13F, 43F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1800, 1000);
            Controls.Add(dgvImportDetail);
            Controls.Add(btnLogOutImport);
            Controls.Add(btnNewImport);
            Controls.Add(btnUpdateImport);
            Controls.Add(btnInsertImport);
            Controls.Add(cbImportID);
            Controls.Add(lblImportSearchID);
            Controls.Add(groupBox1);
            Controls.Add(gbMaintenanceInformation);
            Controls.Add(lblTitle);
            Name = "FrmImport";
            Text = "FrmImport";
            Controls.SetChildIndex(lblTitle, 0);
            Controls.SetChildIndex(gbMaintenanceInformation, 0);
            Controls.SetChildIndex(groupBox1, 0);
            Controls.SetChildIndex(lblImportSearchID, 0);
            Controls.SetChildIndex(cbImportID, 0);
            Controls.SetChildIndex(btnInsertImport, 0);
            Controls.SetChildIndex(btnUpdateImport, 0);
            Controls.SetChildIndex(btnNewImport, 0);
            Controls.SetChildIndex(btnLogOutImport, 0);
            Controls.SetChildIndex(dgvImportDetail, 0);
            gbMaintenanceInformation.ResumeLayout(false);
            gbMaintenanceInformation.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvImportDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private GroupBox gbMaintenanceInformation;
        private Label lblMaintenanceTotalAmount;
        private Label lblMaintenanceDate;
        private ComboBox cbImportSupplierID;
        private Label lblImportStaffName;
        private ComboBox cbImportStaffID;
        private TextBox txtImportSupplierName;
        private Label lblImportSupplierName;
        private Label lblMaintenanceID;
        private Label lblImportStaffID;
        private TextBox txtImportTotalAmount;
        private TextBox txtImportID;
        private Label lblImportSupplierID;
        private DateTimePicker dtpImportDate;
        private TextBox txtImportStaffName;
        private ComboBox cbImportStaffPosition;
        private Label lblImportStaffPosition;
        private GroupBox groupBox1;
        private Button btnUpdateImportItem;
        private Button btnInsertImportItem;
        private TextBox txtImportItemUnitPrice;
        private Label label2;
        private Label label3;
        private ComboBox cbImportItemCategory;
        private TextBox txtImportItemQuantity;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtImportItemDescription;
        private TextBox txtImportDetailID;
        private Label label7;
        private TextBox txtImportItemUnit;
        private DataGridView dgvImportDetail;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Button btnLogOutImport;
        private Button btnNewImport;
        private Button btnUpdateImport;
        private Button btnInsertImport;
        private ComboBox cbImportID;
        private Label lblImportSearchID;
    }
}