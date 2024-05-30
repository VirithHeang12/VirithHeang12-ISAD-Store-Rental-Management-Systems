using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtImportID = new TextBox();
            dtpImport = new DateTimePicker();
            txtImportAmount = new TextBox();
            groupBoxSupplier = new GroupBox();
            txtSupplierName = new TextBox();
            txtSupplierID = new TextBox();
            label6 = new Label();
            label5 = new Label();
            panelTop = new Panel();
            dataGridView1 = new DataGridView();
            groupBoxItem = new GroupBox();
            cbItem = new ComboBox();
            btnItemUpdate = new Button();
            btnItemInsert = new Button();
            txtItemCategory = new TextBox();
            txtItemDescription = new TextBox();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label10 = new Label();
            txtItemPrice = new TextBox();
            txtItemStockQty = new TextBox();
            label11 = new Label();
            label12 = new Label();
            btnImportLogout = new Button();
            btnImportNew = new Button();
            btnImportUpdate = new Button();
            btnImportInsert = new Button();
            groupBoxStaff = new GroupBox();
            cbStaffPosition = new ComboBox();
            label9 = new Label();
            txtStaffName = new TextBox();
            txtStaffID = new TextBox();
            label7 = new Label();
            label8 = new Label();
            cbImport = new ComboBox();
            label16 = new Label();
            txtItemUnit = new TextBox();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            groupBoxSupplier.SuspendLayout();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBoxItem.SuspendLayout();
            groupBoxStaff.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(0, 28, 87);
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Dangrek", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1478, 81);
            label1.TabIndex = 0;
            label1.Text = "ព័ត៌មានការនាំចូល";
            label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kantumruy", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(16, 4);
            label2.Name = "label2";
            label2.Size = new Size(231, 40);
            label2.TabIndex = 1;
            label2.Text = "លេខសម្គាល់ការនាំចូល:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Kantumruy", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(695, 5);
            label3.Name = "label3";
            label3.Size = new Size(222, 40);
            label3.TabIndex = 2;
            label3.Text = "កាលបរិច្ឆេទការនាំចូល:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Kantumruy", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(15, 51);
            label4.Name = "label4";
            label4.Size = new Size(162, 40);
            label4.TabIndex = 3;
            label4.Text = "ចំនួនប្រាក់សរុប:";
            // 
            // txtImportID
            // 
            txtImportID.Font = new Font("Kantumruy Pro", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtImportID.Location = new Point(331, 5);
            txtImportID.Name = "txtImportID";
            txtImportID.Size = new Size(248, 36);
            txtImportID.TabIndex = 4;
            // 
            // dtpImport
            // 
            dtpImport.Font = new Font("Kantumruy Pro", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpImport.Format = DateTimePickerFormat.Short;
            dtpImport.Location = new Point(981, 4);
            dtpImport.Name = "dtpImport";
            dtpImport.Size = new Size(279, 36);
            dtpImport.TabIndex = 5;
            // 
            // txtImportAmount
            // 
            txtImportAmount.Font = new Font("Kantumruy Pro", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtImportAmount.Location = new Point(331, 55);
            txtImportAmount.Name = "txtImportAmount";
            txtImportAmount.Size = new Size(248, 36);
            txtImportAmount.TabIndex = 6;
            // 
            // groupBoxSupplier
            // 
            groupBoxSupplier.Controls.Add(txtSupplierName);
            groupBoxSupplier.Controls.Add(txtSupplierID);
            groupBoxSupplier.Controls.Add(label6);
            groupBoxSupplier.Controls.Add(label5);
            groupBoxSupplier.Font = new Font("Dangrek", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxSupplier.Location = new Point(15, 100);
            groupBoxSupplier.Name = "groupBoxSupplier";
            groupBoxSupplier.Size = new Size(1269, 93);
            groupBoxSupplier.TabIndex = 7;
            groupBoxSupplier.TabStop = false;
            groupBoxSupplier.Text = "អ្នកផ្គត់ផ្គង់";
            // 
            // txtSupplierName
            // 
            txtSupplierName.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtSupplierName.Location = new Point(966, 34);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(279, 37);
            txtSupplierName.TabIndex = 4;
            // 
            // txtSupplierID
            // 
            txtSupplierID.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtSupplierID.Location = new Point(316, 38);
            txtSupplierID.Name = "txtSupplierID";
            txtSupplierID.Size = new Size(248, 37);
            txtSupplierID.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Kantumruy", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(680, 38);
            label6.Name = "label6";
            label6.Size = new Size(171, 40);
            label6.TabIndex = 3;
            label6.Text = "ឈ្មោះអ្នកផ្គត់ផ្គង់:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Kantumruy", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(6, 38);
            label5.Name = "label5";
            label5.Size = new Size(236, 40);
            label5.TabIndex = 3;
            label5.Text = "លេខសម្គាល់អ្នកផ្គត់ផ្គង់:";
            // 
            // panelTop
            // 
            panelTop.Controls.Add(dataGridView1);
            panelTop.Controls.Add(groupBoxItem);
            panelTop.Controls.Add(btnImportLogout);
            panelTop.Controls.Add(btnImportNew);
            panelTop.Controls.Add(btnImportUpdate);
            panelTop.Controls.Add(btnImportInsert);
            panelTop.Controls.Add(groupBoxStaff);
            panelTop.Controls.Add(txtImportID);
            panelTop.Controls.Add(groupBoxSupplier);
            panelTop.Controls.Add(cbImport);
            panelTop.Controls.Add(label2);
            panelTop.Controls.Add(txtImportAmount);
            panelTop.Controls.Add(label3);
            panelTop.Controls.Add(dtpImport);
            panelTop.Controls.Add(label16);
            panelTop.Controls.Add(label4);
            panelTop.Location = new Point(60, 86);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1365, 952);
            panelTop.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Kantumruy", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Kantumruy", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(25, 113, 176);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(15, 749);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 60;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1336, 171);
            dataGridView1.TabIndex = 14;
            // 
            // groupBoxItem
            // 
            groupBoxItem.Controls.Add(cbItem);
            groupBoxItem.Controls.Add(btnItemUpdate);
            groupBoxItem.Controls.Add(btnItemInsert);
            groupBoxItem.Controls.Add(txtItemUnit);
            groupBoxItem.Controls.Add(txtItemCategory);
            groupBoxItem.Controls.Add(txtItemDescription);
            groupBoxItem.Controls.Add(label15);
            groupBoxItem.Controls.Add(label14);
            groupBoxItem.Controls.Add(label13);
            groupBoxItem.Controls.Add(label10);
            groupBoxItem.Controls.Add(txtItemPrice);
            groupBoxItem.Controls.Add(txtItemStockQty);
            groupBoxItem.Controls.Add(label11);
            groupBoxItem.Controls.Add(label12);
            groupBoxItem.Font = new Font("Dangrek", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxItem.Location = new Point(16, 343);
            groupBoxItem.Name = "groupBoxItem";
            groupBoxItem.Size = new Size(1269, 255);
            groupBoxItem.TabIndex = 9;
            groupBoxItem.TabStop = false;
            groupBoxItem.Text = "សម្ភារៈ";
            // 
            // cbItem
            // 
            cbItem.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbItem.FormattingEnabled = true;
            cbItem.ItemHeight = 31;
            cbItem.Location = new Point(317, 35);
            cbItem.Name = "cbItem";
            cbItem.Size = new Size(248, 39);
            cbItem.TabIndex = 6;
            // 
            // btnItemUpdate
            // 
            btnItemUpdate.AutoSize = true;
            btnItemUpdate.BackColor = Color.FromArgb(0, 28, 87);
            btnItemUpdate.Font = new Font("Kantumruy", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnItemUpdate.ForeColor = Color.White;
            btnItemUpdate.Location = new Point(1124, 188);
            btnItemUpdate.Name = "btnItemUpdate";
            btnItemUpdate.Size = new Size(121, 50);
            btnItemUpdate.TabIndex = 14;
            btnItemUpdate.Text = "កែប្រែ";
            btnItemUpdate.UseVisualStyleBackColor = false;
            // 
            // btnItemInsert
            // 
            btnItemInsert.AutoSize = true;
            btnItemInsert.BackColor = Color.FromArgb(0, 28, 87);
            btnItemInsert.Font = new Font("Kantumruy", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnItemInsert.ForeColor = Color.White;
            btnItemInsert.Location = new Point(965, 188);
            btnItemInsert.Name = "btnItemInsert";
            btnItemInsert.Size = new Size(128, 50);
            btnItemInsert.TabIndex = 13;
            btnItemInsert.Text = "បញ្ចូល";
            btnItemInsert.UseVisualStyleBackColor = false;
            // 
            // txtItemCategory
            // 
            txtItemCategory.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtItemCategory.Location = new Point(966, 80);
            txtItemCategory.Name = "txtItemCategory";
            txtItemCategory.Size = new Size(279, 37);
            txtItemCategory.TabIndex = 11;
            // 
            // txtItemDescription
            // 
            txtItemDescription.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtItemDescription.Location = new Point(316, 85);
            txtItemDescription.Name = "txtItemDescription";
            txtItemDescription.Size = new Size(248, 37);
            txtItemDescription.TabIndex = 10;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Kantumruy", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(684, 133);
            label15.Name = "label15";
            label15.Size = new Size(169, 40);
            label15.TabIndex = 9;
            label15.Text = "ខ្នាតរង្វាស់សម្ភារៈ";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Kantumruy", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(680, 83);
            label14.Name = "label14";
            label14.Size = new Size(162, 40);
            label14.TabIndex = 8;
            label14.Text = "ប្រភេទនៃសម្ភារៈ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Kantumruy", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(680, 36);
            label13.Name = "label13";
            label13.Size = new Size(179, 40);
            label13.TabIndex = 7;
            label13.Text = "តម្លៃនាំចូលសម្ភារៈ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Kantumruy", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(6, 83);
            label10.Name = "label10";
            label10.Size = new Size(143, 40);
            label10.TabIndex = 5;
            label10.Text = "ពិណ៌នាសម្ភារ:";
            // 
            // txtItemPrice
            // 
            txtItemPrice.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtItemPrice.Location = new Point(966, 31);
            txtItemPrice.Name = "txtItemPrice";
            txtItemPrice.Size = new Size(279, 37);
            txtItemPrice.TabIndex = 4;
            // 
            // txtItemStockQty
            // 
            txtItemStockQty.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtItemStockQty.Location = new Point(317, 137);
            txtItemStockQty.Name = "txtItemStockQty";
            txtItemStockQty.Size = new Size(248, 37);
            txtItemStockQty.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Kantumruy", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(6, 138);
            label11.Name = "label11";
            label11.Size = new Size(152, 40);
            label11.TabIndex = 3;
            label11.Text = "បរិមាណសម្ភារៈ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Kantumruy", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(6, 35);
            label12.Name = "label12";
            label12.Size = new Size(193, 40);
            label12.TabIndex = 3;
            label12.Text = "លេខសម្គាល់សម្ភារ:";
            // 
            // btnImportLogout
            // 
            btnImportLogout.AutoSize = true;
            btnImportLogout.BackColor = Color.FromArgb(0, 28, 87);
            btnImportLogout.Font = new Font("Kantumruy", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnImportLogout.ForeColor = Color.White;
            btnImportLogout.Location = new Point(926, 615);
            btnImportLogout.Name = "btnImportLogout";
            btnImportLogout.Size = new Size(131, 52);
            btnImportLogout.TabIndex = 13;
            btnImportLogout.Text = "ចាកចេញ";
            btnImportLogout.UseVisualStyleBackColor = false;
            // 
            // btnImportNew
            // 
            btnImportNew.AutoSize = true;
            btnImportNew.BackColor = Color.FromArgb(0, 28, 87);
            btnImportNew.Font = new Font("Kantumruy", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnImportNew.ForeColor = Color.White;
            btnImportNew.Location = new Point(714, 615);
            btnImportNew.Name = "btnImportNew";
            btnImportNew.Size = new Size(128, 52);
            btnImportNew.TabIndex = 13;
            btnImportNew.Text = "ថ្មី";
            btnImportNew.UseVisualStyleBackColor = false;
            // 
            // btnImportUpdate
            // 
            btnImportUpdate.AutoSize = true;
            btnImportUpdate.BackColor = Color.FromArgb(0, 28, 87);
            btnImportUpdate.Font = new Font("Kantumruy", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnImportUpdate.ForeColor = Color.White;
            btnImportUpdate.Location = new Point(505, 615);
            btnImportUpdate.Name = "btnImportUpdate";
            btnImportUpdate.Size = new Size(128, 52);
            btnImportUpdate.TabIndex = 13;
            btnImportUpdate.Text = "កែប្រែ";
            btnImportUpdate.UseVisualStyleBackColor = false;
            // 
            // btnImportInsert
            // 
            btnImportInsert.AutoSize = true;
            btnImportInsert.BackColor = Color.FromArgb(0, 28, 87);
            btnImportInsert.Font = new Font("Kantumruy", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnImportInsert.ForeColor = Color.White;
            btnImportInsert.Location = new Point(292, 615);
            btnImportInsert.Name = "btnImportInsert";
            btnImportInsert.Size = new Size(128, 52);
            btnImportInsert.TabIndex = 13;
            btnImportInsert.Text = "បញ្ចូល";
            btnImportInsert.UseVisualStyleBackColor = false;
            // 
            // groupBoxStaff
            // 
            groupBoxStaff.Controls.Add(cbStaffPosition);
            groupBoxStaff.Controls.Add(label9);
            groupBoxStaff.Controls.Add(txtStaffName);
            groupBoxStaff.Controls.Add(txtStaffID);
            groupBoxStaff.Controls.Add(label7);
            groupBoxStaff.Controls.Add(label8);
            groupBoxStaff.Font = new Font("Dangrek", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxStaff.Location = new Point(15, 194);
            groupBoxStaff.Name = "groupBoxStaff";
            groupBoxStaff.Size = new Size(1269, 147);
            groupBoxStaff.TabIndex = 8;
            groupBoxStaff.TabStop = false;
            groupBoxStaff.Text = "បុគ្គលិក";
            // 
            // cbStaffPosition
            // 
            cbStaffPosition.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbStaffPosition.FormattingEnabled = true;
            cbStaffPosition.ItemHeight = 31;
            cbStaffPosition.Location = new Point(316, 88);
            cbStaffPosition.Name = "cbStaffPosition";
            cbStaffPosition.Size = new Size(248, 39);
            cbStaffPosition.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Kantumruy", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(6, 89);
            label9.Name = "label9";
            label9.Size = new Size(149, 40);
            label9.TabIndex = 5;
            label9.Text = "តួនាទីបុគ្គលិក:";
            // 
            // txtStaffName
            // 
            txtStaffName.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffName.Location = new Point(966, 38);
            txtStaffName.Name = "txtStaffName";
            txtStaffName.Size = new Size(279, 37);
            txtStaffName.TabIndex = 4;
            // 
            // txtStaffID
            // 
            txtStaffID.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffID.Location = new Point(316, 37);
            txtStaffID.Name = "txtStaffID";
            txtStaffID.Size = new Size(248, 37);
            txtStaffID.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Kantumruy", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(680, 38);
            label7.Name = "label7";
            label7.Size = new Size(147, 40);
            label7.TabIndex = 3;
            label7.Text = "ឈ្មោះបុគ្គលិក:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Kantumruy", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(6, 35);
            label8.Name = "label8";
            label8.Size = new Size(212, 40);
            label8.TabIndex = 3;
            label8.Text = "លេខសម្គាល់បុគ្គលិក:";
            // 
            // cbImport
            // 
            cbImport.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbImport.FormattingEnabled = true;
            cbImport.ItemHeight = 31;
            cbImport.Location = new Point(405, 688);
            cbImport.Name = "cbImport";
            cbImport.Size = new Size(248, 39);
            cbImport.TabIndex = 6;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Kantumruy", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.Black;
            label16.Location = new Point(45, 686);
            label16.Name = "label16";
            label16.Size = new Size(337, 40);
            label16.TabIndex = 3;
            label16.Text = "ស្វែងរក​ (លេខសម្គាល់ការនាំចូល)";
            // 
            // txtItemUnit
            // 
            txtItemUnit.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtItemUnit.Location = new Point(968, 132);
            txtItemUnit.Name = "txtItemUnit";
            txtItemUnit.Size = new Size(279, 37);
            txtItemUnit.TabIndex = 12;
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
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.HeaderText = "បរិមាណសម្ភារៈ";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 190;
            // 
            // Column4
            // 
            Column4.HeaderText = "តម្លៃនាំចូលសម្ភារៈ";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 220;
            // 
            // Column5
            // 
            Column5.HeaderText = "ប្រភេទនៃសម្ភារៈ";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.Width = 200;
            // 
            // Column6
            // 
            Column6.HeaderText = "ខ្នាតរង្វាស់សម្ភារៈ";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.Width = 220;
            // 
            // FrmImport
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1478, 1050);
            Controls.Add(panelTop);
            Controls.Add(label1);
            Font = new Font("Kantumruy Pro", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(25, 113, 176);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmImport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmImport";
            groupBoxSupplier.ResumeLayout(false);
            groupBoxSupplier.PerformLayout();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBoxItem.ResumeLayout(false);
            groupBoxItem.PerformLayout();
            groupBoxStaff.ResumeLayout(false);
            groupBoxStaff.PerformLayout();
            ResumeLayout(false);
        }

        #endregion


        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtImportID;
        private DateTimePicker dtpImport;
        private TextBox txtImportAmount;
        private GroupBox groupBoxSupplier;
        private Panel panelTop;
        private TextBox txtSupplierName;
        private TextBox txtSupplierID;
        private Label label6;
        private Label label5;
        private GroupBox groupBoxStaff;
        private TextBox txtStaffName;
        private TextBox txtStaffID;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox cbStaffPosition;
        private GroupBox groupBoxItem;
        private ComboBox cbImport;
        private Label label10;
        private TextBox txtItemPrice;
        private TextBox txtItemStockQty;
        private Label label11;
        private Label label12;
        private TextBox txtItemDescription;
        private Label label15;
        private Label label14;
        private Label label13;
        private TextBox txtItemCategory;
        private Button btnItemUpdate;
        private Button btnItemInsert;
        private Button btnImportLogout;
        private Button btnImportNew;
        private Button btnImportUpdate;
        private Button btnImportInsert;
        private Label label16;
        private DataGridView dataGridView1;
        private ComboBox cbItem;
        private TextBox txtItemUnit;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}
