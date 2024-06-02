namespace Store_Rental_Management_Systems
{
    partial class FrmItem
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
            txtItemDescription = new TextBox();
            cbItemCategory = new ComboBox();
            lblItemUnit = new Label();
            lblItemCategory = new Label();
            txtItemUnit = new TextBox();
            lblItemUnitPrice = new Label();
            txtItemUnitPrice = new TextBox();
            lblItemQuantity = new Label();
            lblItemID = new Label();
            txtItemID = new TextBox();
            lblItemDescription = new Label();
            txtItemQuantity = new TextBox();
            btnLogOutItem = new Button();
            btnNewItem = new Button();
            btnUpdateItem = new Button();
            btnInsertItem = new Button();
            txtItemSearchID = new TextBox();
            lblItemSearchID = new Label();
            dgvItem = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            lblTitle = new Label();
            gbMaintenanceInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItem).BeginInit();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(1372, 0);
            // 
            // gbMaintenanceInformation
            // 
            gbMaintenanceInformation.Controls.Add(txtItemDescription);
            gbMaintenanceInformation.Controls.Add(cbItemCategory);
            gbMaintenanceInformation.Controls.Add(lblItemUnit);
            gbMaintenanceInformation.Controls.Add(lblItemCategory);
            gbMaintenanceInformation.Controls.Add(txtItemUnit);
            gbMaintenanceInformation.Controls.Add(lblItemUnitPrice);
            gbMaintenanceInformation.Controls.Add(txtItemUnitPrice);
            gbMaintenanceInformation.Controls.Add(lblItemQuantity);
            gbMaintenanceInformation.Controls.Add(lblItemID);
            gbMaintenanceInformation.Controls.Add(txtItemID);
            gbMaintenanceInformation.Controls.Add(lblItemDescription);
            gbMaintenanceInformation.Controls.Add(txtItemQuantity);
            gbMaintenanceInformation.Font = new Font("Khmer OS Siemreap", 10F, FontStyle.Bold, GraphicsUnit.Point);
            gbMaintenanceInformation.Location = new Point(360, 196);
            gbMaintenanceInformation.Name = "gbMaintenanceInformation";
            gbMaintenanceInformation.Size = new Size(1347, 313);
            gbMaintenanceInformation.TabIndex = 50;
            gbMaintenanceInformation.TabStop = false;
            gbMaintenanceInformation.Text = "ព័ត៌មានសម្ភារៈ";
            // 
            // txtItemDescription
            // 
            txtItemDescription.Enabled = false;
            txtItemDescription.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtItemDescription.Location = new Point(1008, 186);
            txtItemDescription.Multiline = true;
            txtItemDescription.Name = "txtItemDescription";
            txtItemDescription.Size = new Size(288, 108);
            txtItemDescription.TabIndex = 42;
            // 
            // cbItemCategory
            // 
            cbItemCategory.FormattingEnabled = true;
            cbItemCategory.Location = new Point(342, 187);
            cbItemCategory.Name = "cbItemCategory";
            cbItemCategory.Size = new Size(288, 44);
            cbItemCategory.TabIndex = 41;
            // 
            // lblItemUnit
            // 
            lblItemUnit.AutoSize = true;
            lblItemUnit.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblItemUnit.Location = new Point(713, 119);
            lblItemUnit.Name = "lblItemUnit";
            lblItemUnit.Size = new Size(232, 43);
            lblItemUnit.TabIndex = 40;
            lblItemUnit.Text = "ខ្នាតរង្វាស់របស់សម្ភារៈ:";
            // 
            // lblItemCategory
            // 
            lblItemCategory.AutoSize = true;
            lblItemCategory.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblItemCategory.Location = new Point(21, 185);
            lblItemCategory.Name = "lblItemCategory";
            lblItemCategory.Size = new Size(201, 43);
            lblItemCategory.TabIndex = 39;
            lblItemCategory.Text = "ប្រភេទរបស់សម្ភារៈ:";
            // 
            // txtItemUnit
            // 
            txtItemUnit.Enabled = false;
            txtItemUnit.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtItemUnit.Location = new Point(1008, 111);
            txtItemUnit.Name = "txtItemUnit";
            txtItemUnit.Size = new Size(288, 51);
            txtItemUnit.TabIndex = 38;
            // 
            // lblItemUnitPrice
            // 
            lblItemUnitPrice.AutoSize = true;
            lblItemUnitPrice.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblItemUnitPrice.Location = new Point(713, 48);
            lblItemUnitPrice.Name = "lblItemUnitPrice";
            lblItemUnitPrice.Size = new Size(240, 43);
            lblItemUnitPrice.TabIndex = 37;
            lblItemUnitPrice.Text = "តម្លៃនាំចូលរបស់សម្ភារៈ:";
            // 
            // txtItemUnitPrice
            // 
            txtItemUnitPrice.Enabled = false;
            txtItemUnitPrice.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtItemUnitPrice.Location = new Point(1008, 40);
            txtItemUnitPrice.Name = "txtItemUnitPrice";
            txtItemUnitPrice.Size = new Size(288, 51);
            txtItemUnitPrice.TabIndex = 36;
            // 
            // lblItemQuantity
            // 
            lblItemQuantity.AutoSize = true;
            lblItemQuantity.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblItemQuantity.Location = new Point(21, 119);
            lblItemQuantity.Name = "lblItemQuantity";
            lblItemQuantity.Size = new Size(217, 43);
            lblItemQuantity.TabIndex = 28;
            lblItemQuantity.Text = "បរិមាណរបស់សម្ភារៈ:";
            // 
            // lblItemID
            // 
            lblItemID.AutoSize = true;
            lblItemID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblItemID.Location = new Point(21, 48);
            lblItemID.Name = "lblItemID";
            lblItemID.Size = new Size(254, 43);
            lblItemID.TabIndex = 0;
            lblItemID.Text = "លេខសម្គាល់របស់សម្ភារៈ:";
            // 
            // txtItemID
            // 
            txtItemID.Enabled = false;
            txtItemID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtItemID.Location = new Point(342, 40);
            txtItemID.Name = "txtItemID";
            txtItemID.Size = new Size(288, 51);
            txtItemID.TabIndex = 3;
            // 
            // lblItemDescription
            // 
            lblItemDescription.AutoSize = true;
            lblItemDescription.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblItemDescription.Location = new Point(713, 185);
            lblItemDescription.Name = "lblItemDescription";
            lblItemDescription.Size = new Size(225, 43);
            lblItemDescription.TabIndex = 6;
            lblItemDescription.Text = "ពិពណ៌នារបស់សម្ភារៈ:";
            // 
            // txtItemQuantity
            // 
            txtItemQuantity.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtItemQuantity.Location = new Point(342, 111);
            txtItemQuantity.Name = "txtItemQuantity";
            txtItemQuantity.Size = new Size(288, 51);
            txtItemQuantity.TabIndex = 7;
            // 
            // btnLogOutItem
            // 
            btnLogOutItem.AutoSize = true;
            btnLogOutItem.BackColor = Color.FromArgb(0, 28, 87);
            btnLogOutItem.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogOutItem.ForeColor = Color.White;
            btnLogOutItem.Location = new Point(902, 537);
            btnLogOutItem.Name = "btnLogOutItem";
            btnLogOutItem.Size = new Size(128, 60);
            btnLogOutItem.TabIndex = 57;
            btnLogOutItem.Text = "បិទ";
            btnLogOutItem.UseVisualStyleBackColor = false;
            // 
            // btnNewItem
            // 
            btnNewItem.AutoSize = true;
            btnNewItem.BackColor = Color.FromArgb(0, 28, 87);
            btnNewItem.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNewItem.ForeColor = Color.White;
            btnNewItem.Location = new Point(716, 537);
            btnNewItem.Name = "btnNewItem";
            btnNewItem.Size = new Size(128, 60);
            btnNewItem.TabIndex = 56;
            btnNewItem.Text = "បង្កើតថ្មី";
            btnNewItem.UseVisualStyleBackColor = false;
            // 
            // btnUpdateItem
            // 
            btnUpdateItem.AutoSize = true;
            btnUpdateItem.BackColor = Color.FromArgb(0, 28, 87);
            btnUpdateItem.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateItem.ForeColor = Color.White;
            btnUpdateItem.Location = new Point(531, 537);
            btnUpdateItem.Name = "btnUpdateItem";
            btnUpdateItem.Size = new Size(128, 60);
            btnUpdateItem.TabIndex = 55;
            btnUpdateItem.Text = "កែប្រែ";
            btnUpdateItem.UseVisualStyleBackColor = false;
            // 
            // btnInsertItem
            // 
            btnInsertItem.AutoSize = true;
            btnInsertItem.BackColor = Color.FromArgb(0, 28, 87);
            btnInsertItem.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsertItem.ForeColor = Color.White;
            btnInsertItem.Location = new Point(358, 537);
            btnInsertItem.Name = "btnInsertItem";
            btnInsertItem.Size = new Size(128, 60);
            btnInsertItem.TabIndex = 54;
            btnInsertItem.Text = "បញ្ចូល";
            btnInsertItem.UseVisualStyleBackColor = false;
            // 
            // txtItemSearchID
            // 
            txtItemSearchID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtItemSearchID.Location = new Point(700, 613);
            txtItemSearchID.Name = "txtItemSearchID";
            txtItemSearchID.Size = new Size(288, 51);
            txtItemSearchID.TabIndex = 58;
            // 
            // lblItemSearchID
            // 
            lblItemSearchID.AutoSize = true;
            lblItemSearchID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblItemSearchID.Location = new Point(358, 616);
            lblItemSearchID.Name = "lblItemSearchID";
            lblItemSearchID.Size = new Size(311, 43);
            lblItemSearchID.TabIndex = 59;
            lblItemSearchID.Text = "ស្វែងរក (លេខសម្គាល់សម្ភារៈ):";
            // 
            // dgvItem
            // 
            dgvItem.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvItem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItem.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(25, 113, 176);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvItem.DefaultCellStyle = dataGridViewCellStyle4;
            dgvItem.Location = new Point(319, 697);
            dgvItem.Name = "dgvItem";
            dgvItem.RowHeadersWidth = 60;
            dgvItem.RowTemplate.Height = 33;
            dgvItem.Size = new Size(1409, 218);
            dgvItem.TabIndex = 60;
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
            lblTitle.Size = new Size(1512, 94);
            lblTitle.TabIndex = 61;
            lblTitle.Text = "ព័ត៌មានសម្ភារៈ";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmItem
            // 
            AutoScaleDimensions = new SizeF(13F, 43F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1778, 1000);
            Controls.Add(lblTitle);
            Controls.Add(dgvItem);
            Controls.Add(txtItemSearchID);
            Controls.Add(lblItemSearchID);
            Controls.Add(btnLogOutItem);
            Controls.Add(btnNewItem);
            Controls.Add(btnUpdateItem);
            Controls.Add(btnInsertItem);
            Controls.Add(gbMaintenanceInformation);
            Name = "FrmItem";
            Text = "FrmItem";
            Controls.SetChildIndex(gbMaintenanceInformation, 0);
            Controls.SetChildIndex(btnInsertItem, 0);
            Controls.SetChildIndex(btnUpdateItem, 0);
            Controls.SetChildIndex(btnNewItem, 0);
            Controls.SetChildIndex(btnLogOutItem, 0);
            Controls.SetChildIndex(lblItemSearchID, 0);
            Controls.SetChildIndex(txtItemSearchID, 0);
            Controls.SetChildIndex(dgvItem, 0);
            Controls.SetChildIndex(lblTitle, 0);
            gbMaintenanceInformation.ResumeLayout(false);
            gbMaintenanceInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox gbMaintenanceInformation;
        private TextBox txtItemUnit;
        private Label lblItemUnitPrice;
        private TextBox txtItemUnitPrice;
        private Label lblItemQuantity;
        private Label lblItemID;
        private TextBox txtItemID;
        private Label lblItemDescription;
        private TextBox txtItemQuantity;
        private Label lblItemUnit;
        private Label lblItemCategory;
        private TextBox txtItemDescription;
        private ComboBox cbItemCategory;
        private Button btnLogOutItem;
        private Button btnNewItem;
        private Button btnUpdateItem;
        private Button btnInsertItem;
        private TextBox txtItemSearchID;
        private Label lblItemSearchID;
        private DataGridView dgvItem;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Label lblTitle;
    }
}