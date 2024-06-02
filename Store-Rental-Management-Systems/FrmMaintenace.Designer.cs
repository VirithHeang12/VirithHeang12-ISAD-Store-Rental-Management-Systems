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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            gbMaintenanceInformation = new GroupBox();
            lblMaintenanceTotalAmount = new Label();
            lblMaintenanceDate = new Label();
            cbMaintenanceStoreID = new ComboBox();
            lblMaintenanceStoreID = new Label();
            cbMaintenanceContractID = new ComboBox();
            txtMaintenanceOwedAmount = new TextBox();
            lblMaintenanceOwedAmount = new Label();
            lblMaintenanceID = new Label();
            lblMaintenanceContractID = new Label();
            txtMaintenanceTotalAmount = new TextBox();
            txtMaintenanceID = new TextBox();
            lblMaintenancePaidAmount = new Label();
            txtMaintenancePaidAmount = new TextBox();
            dtpMaintenanceDate = new DateTimePicker();
            groupBox1 = new GroupBox();
            btnUpdateMaintenanceItem = new Button();
            btnInsertMaintenanceItem = new Button();
            txtMaintenanceItemUnitPrice = new TextBox();
            label1 = new Label();
            label2 = new Label();
            cbMainteanceItemCategory = new ComboBox();
            txtMaintenanceItemQuantity = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtMaintenanceItemDescription = new TextBox();
            txtMaintenanceItemID = new TextBox();
            label7 = new Label();
            txtMaintenanceItemUnit = new TextBox();
            btnInsertMaintenance = new Button();
            btnUpdateMaintenance = new Button();
            btnNewMaintenance = new Button();
            btnLogOutMaintenance = new Button();
            label8 = new Label();
            cbMaintenanceSearchID = new ComboBox();
            dgvMaintenanceDetail = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            lblTitle = new Label();
            gbMaintenanceInformation.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMaintenanceDetail).BeginInit();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(1394, 0);
            // 
            // gbMaintenanceInformation
            // 
            gbMaintenanceInformation.Controls.Add(lblMaintenanceTotalAmount);
            gbMaintenanceInformation.Controls.Add(lblMaintenanceDate);
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
            gbMaintenanceInformation.Font = new Font("Khmer OS Siemreap", 10F, FontStyle.Bold, GraphicsUnit.Point);
            gbMaintenanceInformation.Location = new Point(326, 187);
            gbMaintenanceInformation.Name = "gbMaintenanceInformation";
            gbMaintenanceInformation.Size = new Size(1427, 223);
            gbMaintenanceInformation.TabIndex = 26;
            gbMaintenanceInformation.TabStop = false;
            gbMaintenanceInformation.Text = "ព័ត៌មានថែទាំ";
            // 
            // lblMaintenanceTotalAmount
            // 
            lblMaintenanceTotalAmount.AutoSize = true;
            lblMaintenanceTotalAmount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMaintenanceTotalAmount.Location = new Point(949, 43);
            lblMaintenanceTotalAmount.Name = "lblMaintenanceTotalAmount";
            lblMaintenanceTotalAmount.Size = new Size(113, 43);
            lblMaintenanceTotalAmount.TabIndex = 31;
            lblMaintenanceTotalAmount.Text = "តម្លៃសរុប:";
            // 
            // lblMaintenanceDate
            // 
            lblMaintenanceDate.AutoSize = true;
            lblMaintenanceDate.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMaintenanceDate.Location = new Point(526, 46);
            lblMaintenanceDate.Name = "lblMaintenanceDate";
            lblMaintenanceDate.Size = new Size(137, 43);
            lblMaintenanceDate.TabIndex = 30;
            lblMaintenanceDate.Text = "កាលបរិច្ឆេទ:";
            // 
            // cbMaintenanceStoreID
            // 
            cbMaintenanceStoreID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMaintenanceStoreID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbMaintenanceStoreID.FormattingEnabled = true;
            cbMaintenanceStoreID.Items.AddRange(new object[] { "អ្នកគ្រប់គ្រង", "គណនីករ" });
            cbMaintenanceStoreID.Location = new Point(242, 159);
            cbMaintenanceStoreID.Name = "cbMaintenanceStoreID";
            cbMaintenanceStoreID.Size = new Size(219, 51);
            cbMaintenanceStoreID.TabIndex = 29;
            // 
            // lblMaintenanceStoreID
            // 
            lblMaintenanceStoreID.AutoSize = true;
            lblMaintenanceStoreID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMaintenanceStoreID.Location = new Point(18, 159);
            lblMaintenanceStoreID.Name = "lblMaintenanceStoreID";
            lblMaintenanceStoreID.Size = new Size(175, 43);
            lblMaintenanceStoreID.TabIndex = 28;
            lblMaintenanceStoreID.Text = "លេខសម្គាល់តូប:";
            // 
            // cbMaintenanceContractID
            // 
            cbMaintenanceContractID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMaintenanceContractID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbMaintenanceContractID.FormattingEnabled = true;
            cbMaintenanceContractID.Items.AddRange(new object[] { "អ្នកគ្រប់គ្រង", "គណនីករ" });
            cbMaintenanceContractID.Location = new Point(1184, 103);
            cbMaintenanceContractID.Name = "cbMaintenanceContractID";
            cbMaintenanceContractID.Size = new Size(219, 51);
            cbMaintenanceContractID.TabIndex = 27;
            // 
            // txtMaintenanceOwedAmount
            // 
            txtMaintenanceOwedAmount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaintenanceOwedAmount.Location = new Point(669, 108);
            txtMaintenanceOwedAmount.Name = "txtMaintenanceOwedAmount";
            txtMaintenanceOwedAmount.Size = new Size(208, 51);
            txtMaintenanceOwedAmount.TabIndex = 26;
            // 
            // lblMaintenanceOwedAmount
            // 
            lblMaintenanceOwedAmount.AutoSize = true;
            lblMaintenanceOwedAmount.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMaintenanceOwedAmount.Location = new Point(526, 111);
            lblMaintenanceOwedAmount.Name = "lblMaintenanceOwedAmount";
            lblMaintenanceOwedAmount.Size = new Size(122, 43);
            lblMaintenanceOwedAmount.TabIndex = 25;
            lblMaintenanceOwedAmount.Text = "តម្លៃជំពាក់:";
            // 
            // lblMaintenanceID
            // 
            lblMaintenanceID.AutoSize = true;
            lblMaintenanceID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMaintenanceID.Location = new Point(18, 41);
            lblMaintenanceID.Name = "lblMaintenanceID";
            lblMaintenanceID.Size = new Size(223, 43);
            lblMaintenanceID.TabIndex = 0;
            lblMaintenanceID.Text = "លេខសម្គាល់ការថែទាំ:";
            // 
            // lblMaintenanceContractID
            // 
            lblMaintenanceContractID.AutoSize = true;
            lblMaintenanceContractID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMaintenanceContractID.Location = new Point(949, 106);
            lblMaintenanceContractID.Name = "lblMaintenanceContractID";
            lblMaintenanceContractID.Size = new Size(229, 43);
            lblMaintenanceContractID.TabIndex = 14;
            lblMaintenanceContractID.Text = "លេខសម្គាល់កិច្ចសន្យា:";
            // 
            // txtMaintenanceTotalAmount
            // 
            txtMaintenanceTotalAmount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaintenanceTotalAmount.Location = new Point(1184, 41);
            txtMaintenanceTotalAmount.Name = "txtMaintenanceTotalAmount";
            txtMaintenanceTotalAmount.Size = new Size(217, 51);
            txtMaintenanceTotalAmount.TabIndex = 5;
            // 
            // txtMaintenanceID
            // 
            txtMaintenanceID.Enabled = false;
            txtMaintenanceID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaintenanceID.Location = new Point(242, 28);
            txtMaintenanceID.Name = "txtMaintenanceID";
            txtMaintenanceID.Size = new Size(223, 51);
            txtMaintenanceID.TabIndex = 3;
            // 
            // lblMaintenancePaidAmount
            // 
            lblMaintenancePaidAmount.AutoSize = true;
            lblMaintenancePaidAmount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMaintenancePaidAmount.Location = new Point(18, 101);
            lblMaintenancePaidAmount.Name = "lblMaintenancePaidAmount";
            lblMaintenancePaidAmount.Size = new Size(162, 43);
            lblMaintenancePaidAmount.TabIndex = 6;
            lblMaintenancePaidAmount.Text = "តម្លៃបានទូទាត់:";
            // 
            // txtMaintenancePaidAmount
            // 
            txtMaintenancePaidAmount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaintenancePaidAmount.Location = new Point(242, 93);
            txtMaintenancePaidAmount.Name = "txtMaintenancePaidAmount";
            txtMaintenancePaidAmount.Size = new Size(223, 51);
            txtMaintenancePaidAmount.TabIndex = 7;
            // 
            // dtpMaintenanceDate
            // 
            dtpMaintenanceDate.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpMaintenanceDate.Format = DateTimePickerFormat.Short;
            dtpMaintenanceDate.Location = new Point(669, 42);
            dtpMaintenanceDate.Name = "dtpMaintenanceDate";
            dtpMaintenanceDate.Size = new Size(208, 51);
            dtpMaintenanceDate.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnUpdateMaintenanceItem);
            groupBox1.Controls.Add(btnInsertMaintenanceItem);
            groupBox1.Controls.Add(txtMaintenanceItemUnitPrice);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cbMainteanceItemCategory);
            groupBox1.Controls.Add(txtMaintenanceItemQuantity);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtMaintenanceItemDescription);
            groupBox1.Controls.Add(txtMaintenanceItemID);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtMaintenanceItemUnit);
            groupBox1.Font = new Font("Khmer OS Siemreap", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(326, 416);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1427, 241);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            groupBox1.Text = "ព័ត៌មានសម្ភារៈ";
            // 
            // btnUpdateMaintenanceItem
            // 
            btnUpdateMaintenanceItem.AutoSize = true;
            btnUpdateMaintenanceItem.BackColor = Color.FromArgb(0, 28, 87);
            btnUpdateMaintenanceItem.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateMaintenanceItem.ForeColor = Color.White;
            btnUpdateMaintenanceItem.Location = new Point(1032, 169);
            btnUpdateMaintenanceItem.Name = "btnUpdateMaintenanceItem";
            btnUpdateMaintenanceItem.Size = new Size(128, 60);
            btnUpdateMaintenanceItem.TabIndex = 34;
            btnUpdateMaintenanceItem.Text = "កែប្រែ";
            btnUpdateMaintenanceItem.UseVisualStyleBackColor = false;
            // 
            // btnInsertMaintenanceItem
            // 
            btnInsertMaintenanceItem.AutoSize = true;
            btnInsertMaintenanceItem.BackColor = Color.FromArgb(0, 28, 87);
            btnInsertMaintenanceItem.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsertMaintenanceItem.ForeColor = Color.White;
            btnInsertMaintenanceItem.Location = new Point(881, 169);
            btnInsertMaintenanceItem.Name = "btnInsertMaintenanceItem";
            btnInsertMaintenanceItem.Size = new Size(128, 60);
            btnInsertMaintenanceItem.TabIndex = 33;
            btnInsertMaintenanceItem.Text = "បញ្ចូល";
            btnInsertMaintenanceItem.UseVisualStyleBackColor = false;
            // 
            // txtMaintenanceItemUnitPrice
            // 
            txtMaintenanceItemUnitPrice.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaintenanceItemUnitPrice.Location = new Point(669, 40);
            txtMaintenanceItemUnitPrice.Name = "txtMaintenanceItemUnitPrice";
            txtMaintenanceItemUnitPrice.Size = new Size(208, 51);
            txtMaintenanceItemUnitPrice.TabIndex = 32;
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
            // cbMainteanceItemCategory
            // 
            cbMainteanceItemCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMainteanceItemCategory.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbMainteanceItemCategory.FormattingEnabled = true;
            cbMainteanceItemCategory.Items.AddRange(new object[] { "អ្នកគ្រប់គ្រង", "គណនីករ" });
            cbMainteanceItemCategory.Location = new Point(242, 108);
            cbMainteanceItemCategory.Name = "cbMainteanceItemCategory";
            cbMainteanceItemCategory.Size = new Size(219, 51);
            cbMainteanceItemCategory.TabIndex = 27;
            // 
            // txtMaintenanceItemQuantity
            // 
            txtMaintenanceItemQuantity.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaintenanceItemQuantity.Location = new Point(669, 108);
            txtMaintenanceItemQuantity.Name = "txtMaintenanceItemQuantity";
            txtMaintenanceItemQuantity.Size = new Size(208, 51);
            txtMaintenanceItemQuantity.TabIndex = 26;
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
            // txtMaintenanceItemDescription
            // 
            txtMaintenanceItemDescription.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaintenanceItemDescription.Location = new Point(1067, 43);
            txtMaintenanceItemDescription.Multiline = true;
            txtMaintenanceItemDescription.Name = "txtMaintenanceItemDescription";
            txtMaintenanceItemDescription.Size = new Size(334, 100);
            txtMaintenanceItemDescription.TabIndex = 5;
            // 
            // txtMaintenanceItemID
            // 
            txtMaintenanceItemID.Enabled = false;
            txtMaintenanceItemID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaintenanceItemID.Location = new Point(242, 35);
            txtMaintenanceItemID.Name = "txtMaintenanceItemID";
            txtMaintenanceItemID.Size = new Size(223, 51);
            txtMaintenanceItemID.TabIndex = 3;
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
            // txtMaintenanceItemUnit
            // 
            txtMaintenanceItemUnit.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaintenanceItemUnit.Location = new Point(242, 175);
            txtMaintenanceItemUnit.Name = "txtMaintenanceItemUnit";
            txtMaintenanceItemUnit.Size = new Size(219, 51);
            txtMaintenanceItemUnit.TabIndex = 7;
            // 
            // btnInsertMaintenance
            // 
            btnInsertMaintenance.AutoSize = true;
            btnInsertMaintenance.BackColor = Color.FromArgb(0, 28, 87);
            btnInsertMaintenance.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsertMaintenance.ForeColor = Color.White;
            btnInsertMaintenance.Location = new Point(326, 669);
            btnInsertMaintenance.Name = "btnInsertMaintenance";
            btnInsertMaintenance.Size = new Size(128, 60);
            btnInsertMaintenance.TabIndex = 35;
            btnInsertMaintenance.Text = "បញ្ចូល";
            btnInsertMaintenance.UseVisualStyleBackColor = false;
            // 
            // btnUpdateMaintenance
            // 
            btnUpdateMaintenance.AutoSize = true;
            btnUpdateMaintenance.BackColor = Color.FromArgb(0, 28, 87);
            btnUpdateMaintenance.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateMaintenance.ForeColor = Color.White;
            btnUpdateMaintenance.Location = new Point(499, 669);
            btnUpdateMaintenance.Name = "btnUpdateMaintenance";
            btnUpdateMaintenance.Size = new Size(128, 60);
            btnUpdateMaintenance.TabIndex = 36;
            btnUpdateMaintenance.Text = "កែប្រែ";
            btnUpdateMaintenance.UseVisualStyleBackColor = false;
            // 
            // btnNewMaintenance
            // 
            btnNewMaintenance.AutoSize = true;
            btnNewMaintenance.BackColor = Color.FromArgb(0, 28, 87);
            btnNewMaintenance.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNewMaintenance.ForeColor = Color.White;
            btnNewMaintenance.Location = new Point(684, 669);
            btnNewMaintenance.Name = "btnNewMaintenance";
            btnNewMaintenance.Size = new Size(128, 60);
            btnNewMaintenance.TabIndex = 37;
            btnNewMaintenance.Text = "បង្កើតថ្មី";
            btnNewMaintenance.UseVisualStyleBackColor = false;
            // 
            // btnLogOutMaintenance
            // 
            btnLogOutMaintenance.AutoSize = true;
            btnLogOutMaintenance.BackColor = Color.FromArgb(0, 28, 87);
            btnLogOutMaintenance.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogOutMaintenance.ForeColor = Color.White;
            btnLogOutMaintenance.Location = new Point(870, 669);
            btnLogOutMaintenance.Name = "btnLogOutMaintenance";
            btnLogOutMaintenance.Size = new Size(128, 60);
            btnLogOutMaintenance.TabIndex = 38;
            btnLogOutMaintenance.Text = "បិទ";
            btnLogOutMaintenance.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(317, 748);
            label8.Name = "label8";
            label8.Size = new Size(334, 43);
            label8.TabIndex = 25;
            label8.Text = "ស្វែងរក (លេខសម្គាល់ការថែទាំ)​ :";
            // 
            // cbMaintenanceSearchID
            // 
            cbMaintenanceSearchID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMaintenanceSearchID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbMaintenanceSearchID.FormattingEnabled = true;
            cbMaintenanceSearchID.Items.AddRange(new object[] { "អ្នកគ្រប់គ្រង", "គណនីករ" });
            cbMaintenanceSearchID.Location = new Point(666, 742);
            cbMaintenanceSearchID.Name = "cbMaintenanceSearchID";
            cbMaintenanceSearchID.Size = new Size(323, 51);
            cbMaintenanceSearchID.TabIndex = 27;
            // 
            // dgvMaintenanceDetail
            // 
            dgvMaintenanceDetail.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvMaintenanceDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvMaintenanceDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaintenanceDetail.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(25, 113, 176);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvMaintenanceDetail.DefaultCellStyle = dataGridViewCellStyle4;
            dgvMaintenanceDetail.Location = new Point(317, 809);
            dgvMaintenanceDetail.Name = "dgvMaintenanceDetail";
            dgvMaintenanceDetail.RowHeadersWidth = 60;
            dgvMaintenanceDetail.RowTemplate.Height = 33;
            dgvMaintenanceDetail.Size = new Size(1409, 173);
            dgvMaintenanceDetail.TabIndex = 35;
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
            // lblTitle
            // 
            lblTitle.BackColor = Color.FromArgb(0, 28, 87);
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("!Khmer OS Siemreap", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(266, 80);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1534, 86);
            lblTitle.TabIndex = 49;
            lblTitle.Text = "ព័ត៌មានការថែទាំ";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmMaintenace
            // 
            AutoScaleDimensions = new SizeF(13F, 43F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1800, 1000);
            Controls.Add(lblTitle);
            Controls.Add(dgvMaintenanceDetail);
            Controls.Add(btnLogOutMaintenance);
            Controls.Add(btnNewMaintenance);
            Controls.Add(btnUpdateMaintenance);
            Controls.Add(btnInsertMaintenance);
            Controls.Add(groupBox1);
            Controls.Add(gbMaintenanceInformation);
            Controls.Add(cbMaintenanceSearchID);
            Controls.Add(label8);
            Name = "FrmMaintenace";
            Text = "FrmMaintenace";
            Controls.SetChildIndex(label8, 0);
            Controls.SetChildIndex(cbMaintenanceSearchID, 0);
            Controls.SetChildIndex(gbMaintenanceInformation, 0);
            Controls.SetChildIndex(groupBox1, 0);
            Controls.SetChildIndex(btnInsertMaintenance, 0);
            Controls.SetChildIndex(btnUpdateMaintenance, 0);
            Controls.SetChildIndex(btnNewMaintenance, 0);
            Controls.SetChildIndex(btnLogOutMaintenance, 0);
            Controls.SetChildIndex(dgvMaintenanceDetail, 0);
            Controls.SetChildIndex(lblTitle, 0);
            gbMaintenanceInformation.ResumeLayout(false);
            gbMaintenanceInformation.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMaintenanceDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Label lblMaintenanceTotalAmount;
        private Label lblMaintenanceDate;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private ComboBox cbMainteanceItemCategory;
        private TextBox txtMaintenanceItemQuantity;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtMaintenanceItemDescription;
        private TextBox txtMaintenanceItemID;
        private Label label7;
        private TextBox txtMaintenanceItemUnit;
        private TextBox txtMaintenanceItemUnitPrice;
        private Button btnUpdateMaintenanceItem;
        private Button btnInsertMaintenanceItem;
        private Button btnInsertMaintenance;
        private Button btnUpdateMaintenance;
        private Button btnNewMaintenance;
        private Button btnLogOutMaintenance;
        private Label label8;
        private ComboBox cbMaintenanceSearchID;
        private DataGridView dgvMaintenanceDetail;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Label lblTitle;
    }
}