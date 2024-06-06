namespace Store_Rental_Management_Systems
{
    partial class FrmStore
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
            components = new System.ComponentModel.Container();
            lblTitle = new Label();
            lblSearchStore = new Label();
            txtSearchStore = new TextBox();
            pnlLeftSide = new Panel();
            dgvStores = new DataGridView();
            storeIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            floorNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            electricityLastRecordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            waterLastRecordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            storeTypeIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pnlRightSide = new Panel();
            gbStoreInformation = new GroupBox();
            cbStoreTypeID = new ComboBox();
            rdbRented = new RadioButton();
            rdbFree = new RadioButton();
            txtWaterLastRecord = new TextBox();
            lblStoreTypeID = new Label();
            lblStatus = new Label();
            pnlStoreManipulation = new Panel();
            btnCloseFormStore = new Button();
            btnNewStore = new Button();
            btnUpdateStore = new Button();
            btnInsertStore = new Button();
            lblWaterLastRecord = new Label();
            lblStoreID = new Label();
            txtFloorNumber = new TextBox();
            lblFloorNumber = new Label();
            txtStoreID = new TextBox();
            lblElectricityLastRecord = new Label();
            txtElectricityLastRecord = new TextBox();
            pnlLeftSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStores).BeginInit();
            pnlRightSide.SuspendLayout();
            gbStoreInformation.SuspendLayout();
            pnlStoreManipulation.SuspendLayout();
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
            lblTitle.Text = "ព័ត៌មានតូប";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSearchStore
            // 
            lblSearchStore.AutoSize = true;
            lblSearchStore.Location = new Point(82, 29);
            lblSearchStore.Name = "lblSearchStore";
            lblSearchStore.Size = new Size(309, 36);
            lblSearchStore.TabIndex = 1;
            lblSearchStore.Text = "ស្វែងរក (លេខសម្គាល់អ្នកប្រើប្រាស់):";
            // 
            // txtSearchStore
            // 
            txtSearchStore.Location = new Point(411, 26);
            txtSearchStore.Name = "txtSearchStore";
            txtSearchStore.Size = new Size(334, 44);
            txtSearchStore.TabIndex = 2;
            // 
            // pnlLeftSide
            // 
            pnlLeftSide.Controls.Add(dgvStores);
            pnlLeftSide.Controls.Add(lblSearchStore);
            pnlLeftSide.Controls.Add(txtSearchStore);
            pnlLeftSide.Location = new Point(266, 537);
            pnlLeftSide.Name = "pnlLeftSide";
            pnlLeftSide.Size = new Size(1534, 463);
            pnlLeftSide.TabIndex = 3;
            // 
            // dgvStores
            // 
            dgvStores.AllowUserToAddRows = false;
            dgvStores.AllowUserToDeleteRows = false;
            dgvStores.AutoGenerateColumns = false;
            dgvStores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStores.Columns.AddRange(new DataGridViewColumn[] { storeIDDataGridViewTextBoxColumn, floorNumberDataGridViewTextBoxColumn, electricityLastRecordDataGridViewTextBoxColumn, waterLastRecordDataGridViewTextBoxColumn, statusDataGridViewCheckBoxColumn, storeTypeIDDataGridViewTextBoxColumn });
            dgvStores.Location = new Point(82, 82);
            dgvStores.Name = "dgvStores";
            dgvStores.ReadOnly = true;
            dgvStores.RowHeadersWidth = 51;
            dgvStores.RowTemplate.Height = 29;
            dgvStores.Size = new Size(1362, 325);
            dgvStores.TabIndex = 3;
            // 
            // storeIDDataGridViewTextBoxColumn
            // 
            storeIDDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            storeIDDataGridViewTextBoxColumn.DataPropertyName = "StoreID";
            storeIDDataGridViewTextBoxColumn.HeaderText = "លេខសម្គាល់តូប";
            storeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            storeIDDataGridViewTextBoxColumn.Name = "storeIDDataGridViewTextBoxColumn";
            storeIDDataGridViewTextBoxColumn.ReadOnly = true;
            storeIDDataGridViewTextBoxColumn.Width = 172;
            // 
            // floorNumberDataGridViewTextBoxColumn
            // 
            floorNumberDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            floorNumberDataGridViewTextBoxColumn.DataPropertyName = "FloorNumber";
            floorNumberDataGridViewTextBoxColumn.HeaderText = "ជាន់";
            floorNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            floorNumberDataGridViewTextBoxColumn.Name = "floorNumberDataGridViewTextBoxColumn";
            floorNumberDataGridViewTextBoxColumn.ReadOnly = true;
            floorNumberDataGridViewTextBoxColumn.Width = 78;
            // 
            // electricityLastRecordDataGridViewTextBoxColumn
            // 
            electricityLastRecordDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            electricityLastRecordDataGridViewTextBoxColumn.DataPropertyName = "ElectricityLastRecord";
            electricityLastRecordDataGridViewTextBoxColumn.HeaderText = "លេខនាឡិកាអគ្គិសនីចុងក្រោយ";
            electricityLastRecordDataGridViewTextBoxColumn.MinimumWidth = 6;
            electricityLastRecordDataGridViewTextBoxColumn.Name = "electricityLastRecordDataGridViewTextBoxColumn";
            electricityLastRecordDataGridViewTextBoxColumn.ReadOnly = true;
            electricityLastRecordDataGridViewTextBoxColumn.Width = 286;
            // 
            // waterLastRecordDataGridViewTextBoxColumn
            // 
            waterLastRecordDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            waterLastRecordDataGridViewTextBoxColumn.DataPropertyName = "WaterLastRecord";
            waterLastRecordDataGridViewTextBoxColumn.HeaderText = "លេខនាឡិកាទឹកចុងក្រោយ";
            waterLastRecordDataGridViewTextBoxColumn.MinimumWidth = 6;
            waterLastRecordDataGridViewTextBoxColumn.Name = "waterLastRecordDataGridViewTextBoxColumn";
            waterLastRecordDataGridViewTextBoxColumn.ReadOnly = true;
            waterLastRecordDataGridViewTextBoxColumn.Width = 252;
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            statusDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            statusDataGridViewCheckBoxColumn.DataPropertyName = "Status";
            statusDataGridViewCheckBoxColumn.HeaderText = "ស្ថានភាព";
            statusDataGridViewCheckBoxColumn.MinimumWidth = 6;
            statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            statusDataGridViewCheckBoxColumn.ReadOnly = true;
            statusDataGridViewCheckBoxColumn.Width = 95;
            // 
            // storeTypeIDDataGridViewTextBoxColumn
            // 
            storeTypeIDDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            storeTypeIDDataGridViewTextBoxColumn.DataPropertyName = "StoreTypeID";
            storeTypeIDDataGridViewTextBoxColumn.HeaderText = "ប្រភេទតូប";
            storeTypeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            storeTypeIDDataGridViewTextBoxColumn.Name = "storeTypeIDDataGridViewTextBoxColumn";
            storeTypeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // pnlRightSide
            // 
            pnlRightSide.Controls.Add(gbStoreInformation);
            pnlRightSide.Location = new Point(266, 184);
            pnlRightSide.Name = "pnlRightSide";
            pnlRightSide.Size = new Size(1534, 355);
            pnlRightSide.TabIndex = 4;
            // 
            // gbStoreInformation
            // 
            gbStoreInformation.Controls.Add(cbStoreTypeID);
            gbStoreInformation.Controls.Add(rdbRented);
            gbStoreInformation.Controls.Add(rdbFree);
            gbStoreInformation.Controls.Add(txtWaterLastRecord);
            gbStoreInformation.Controls.Add(lblStoreTypeID);
            gbStoreInformation.Controls.Add(lblStatus);
            gbStoreInformation.Controls.Add(pnlStoreManipulation);
            gbStoreInformation.Controls.Add(lblWaterLastRecord);
            gbStoreInformation.Controls.Add(lblStoreID);
            gbStoreInformation.Controls.Add(txtFloorNumber);
            gbStoreInformation.Controls.Add(lblFloorNumber);
            gbStoreInformation.Controls.Add(txtStoreID);
            gbStoreInformation.Controls.Add(lblElectricityLastRecord);
            gbStoreInformation.Controls.Add(txtElectricityLastRecord);
            gbStoreInformation.Font = new Font("!Khmer OS Siemreap", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            gbStoreInformation.Location = new Point(82, 12);
            gbStoreInformation.Name = "gbStoreInformation";
            gbStoreInformation.Size = new Size(1362, 335);
            gbStoreInformation.TabIndex = 25;
            gbStoreInformation.TabStop = false;
            gbStoreInformation.Text = "ព័ត៌មានតូប";
            // 
            // cbStoreTypeID
            // 
            cbStoreTypeID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbStoreTypeID.FormattingEnabled = true;
            cbStoreTypeID.Items.AddRange(new object[] { "ភ្នំពេញ", "តាកែវ" });
            cbStoreTypeID.Location = new Point(946, 174);
            cbStoreTypeID.Name = "cbStoreTypeID";
            cbStoreTypeID.Size = new Size(373, 44);
            cbStoreTypeID.TabIndex = 36;
            // 
            // rdbRented
            // 
            rdbRented.AutoSize = true;
            rdbRented.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbRented.Location = new Point(398, 175);
            rdbRented.Name = "rdbRented";
            rdbRented.Size = new Size(104, 40);
            rdbRented.TabIndex = 35;
            rdbRented.Text = "បានជួល";
            rdbRented.UseVisualStyleBackColor = true;
            // 
            // rdbFree
            // 
            rdbFree.AutoSize = true;
            rdbFree.Checked = true;
            rdbFree.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbFree.Location = new Point(287, 175);
            rdbFree.Name = "rdbFree";
            rdbFree.Size = new Size(76, 40);
            rdbFree.TabIndex = 34;
            rdbFree.TabStop = true;
            rdbFree.Text = "ទំនេរ";
            rdbFree.UseVisualStyleBackColor = true;
            // 
            // txtWaterLastRecord
            // 
            txtWaterLastRecord.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtWaterLastRecord.Location = new Point(946, 105);
            txtWaterLastRecord.Name = "txtWaterLastRecord";
            txtWaterLastRecord.Size = new Size(373, 44);
            txtWaterLastRecord.TabIndex = 33;
            txtWaterLastRecord.UseSystemPasswordChar = true;
            // 
            // lblStoreTypeID
            // 
            lblStoreTypeID.AutoSize = true;
            lblStoreTypeID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStoreTypeID.Location = new Point(711, 177);
            lblStoreTypeID.Name = "lblStoreTypeID";
            lblStoreTypeID.Size = new Size(103, 36);
            lblStoreTypeID.TabIndex = 32;
            lblStoreTypeID.Text = "ប្រភេទតូប:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatus.Location = new Point(18, 177);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(95, 36);
            lblStatus.TabIndex = 29;
            lblStatus.Text = "ស្ថានភាព:";
            // 
            // pnlStoreManipulation
            // 
            pnlStoreManipulation.Controls.Add(btnCloseFormStore);
            pnlStoreManipulation.Controls.Add(btnNewStore);
            pnlStoreManipulation.Controls.Add(btnUpdateStore);
            pnlStoreManipulation.Controls.Add(btnInsertStore);
            pnlStoreManipulation.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pnlStoreManipulation.Location = new Point(18, 232);
            pnlStoreManipulation.Name = "pnlStoreManipulation";
            pnlStoreManipulation.Size = new Size(1301, 81);
            pnlStoreManipulation.TabIndex = 5;
            // 
            // btnCloseFormStore
            // 
            btnCloseFormStore.BackColor = Color.FromArgb(0, 28, 87);
            btnCloseFormStore.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCloseFormStore.ForeColor = Color.White;
            btnCloseFormStore.Location = new Point(1100, 20);
            btnCloseFormStore.Name = "btnCloseFormStore";
            btnCloseFormStore.Size = new Size(152, 52);
            btnCloseFormStore.TabIndex = 3;
            btnCloseFormStore.Text = "បិទ";
            btnCloseFormStore.UseVisualStyleBackColor = false;
            // 
            // btnNewStore
            // 
            btnNewStore.BackColor = Color.FromArgb(0, 28, 87);
            btnNewStore.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNewStore.ForeColor = Color.White;
            btnNewStore.Location = new Point(740, 20);
            btnNewStore.Name = "btnNewStore";
            btnNewStore.Size = new Size(152, 52);
            btnNewStore.TabIndex = 2;
            btnNewStore.Text = "បង្កើតថ្មី";
            btnNewStore.UseVisualStyleBackColor = false;
            // 
            // btnUpdateStore
            // 
            btnUpdateStore.BackColor = Color.FromArgb(0, 28, 87);
            btnUpdateStore.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateStore.ForeColor = Color.White;
            btnUpdateStore.Location = new Point(380, 20);
            btnUpdateStore.Name = "btnUpdateStore";
            btnUpdateStore.Size = new Size(152, 52);
            btnUpdateStore.TabIndex = 1;
            btnUpdateStore.Text = "កែប្រែ";
            btnUpdateStore.UseVisualStyleBackColor = false;
            // 
            // btnInsertStore
            // 
            btnInsertStore.BackColor = Color.FromArgb(0, 28, 87);
            btnInsertStore.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsertStore.ForeColor = Color.White;
            btnInsertStore.Location = new Point(20, 20);
            btnInsertStore.Name = "btnInsertStore";
            btnInsertStore.Size = new Size(152, 52);
            btnInsertStore.TabIndex = 0;
            btnInsertStore.Text = "បញ្ចូល";
            btnInsertStore.UseVisualStyleBackColor = false;
            // 
            // lblWaterLastRecord
            // 
            lblWaterLastRecord.AutoSize = true;
            lblWaterLastRecord.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblWaterLastRecord.Location = new Point(711, 111);
            lblWaterLastRecord.Name = "lblWaterLastRecord";
            lblWaterLastRecord.Size = new Size(229, 36);
            lblWaterLastRecord.TabIndex = 27;
            lblWaterLastRecord.Text = "លេខនាឡិកាទឹកចុងក្រោយ:";
            // 
            // lblStoreID
            // 
            lblStoreID.AutoSize = true;
            lblStoreID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStoreID.Location = new Point(18, 41);
            lblStoreID.Name = "lblStoreID";
            lblStoreID.Size = new Size(149, 36);
            lblStoreID.TabIndex = 0;
            lblStoreID.Text = "លេខសម្គាល់តូប:";
            // 
            // txtFloorNumber
            // 
            txtFloorNumber.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFloorNumber.Location = new Point(946, 33);
            txtFloorNumber.Name = "txtFloorNumber";
            txtFloorNumber.Size = new Size(373, 44);
            txtFloorNumber.TabIndex = 5;
            // 
            // lblFloorNumber
            // 
            lblFloorNumber.AutoSize = true;
            lblFloorNumber.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFloorNumber.Location = new Point(711, 41);
            lblFloorNumber.Name = "lblFloorNumber";
            lblFloorNumber.Size = new Size(55, 36);
            lblFloorNumber.TabIndex = 4;
            lblFloorNumber.Text = "ជាន់:";
            // 
            // txtStoreID
            // 
            txtStoreID.Enabled = false;
            txtStoreID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStoreID.Location = new Point(287, 33);
            txtStoreID.Name = "txtStoreID";
            txtStoreID.Size = new Size(376, 44);
            txtStoreID.TabIndex = 3;
            // 
            // lblElectricityLastRecord
            // 
            lblElectricityLastRecord.AutoSize = true;
            lblElectricityLastRecord.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblElectricityLastRecord.Location = new Point(18, 111);
            lblElectricityLastRecord.Name = "lblElectricityLastRecord";
            lblElectricityLastRecord.Size = new Size(263, 36);
            lblElectricityLastRecord.TabIndex = 6;
            lblElectricityLastRecord.Text = "លេខនាឡិកាអគ្គិសនីចុងក្រោយ:";
            // 
            // txtElectricityLastRecord
            // 
            txtElectricityLastRecord.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtElectricityLastRecord.Location = new Point(287, 105);
            txtElectricityLastRecord.Name = "txtElectricityLastRecord";
            txtElectricityLastRecord.Size = new Size(376, 44);
            txtElectricityLastRecord.TabIndex = 13;
            txtElectricityLastRecord.UseSystemPasswordChar = true;
            // 
            // FrmStore
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1800, 1000);
            ControlBox = true;
            Controls.Add(pnlRightSide);
            Controls.Add(pnlLeftSide);
            Controls.Add(lblTitle);
            Name = "FrmStore";
            Text = "ព័ត៌មានបុគ្គលិក";
            Controls.SetChildIndex(lblTitle, 0);
            Controls.SetChildIndex(pnlLeftSide, 0);
            Controls.SetChildIndex(pnlRightSide, 0);
            pnlLeftSide.ResumeLayout(false);
            pnlLeftSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStores).EndInit();
            pnlRightSide.ResumeLayout(false);
            gbStoreInformation.ResumeLayout(false);
            gbStoreInformation.PerformLayout();
            pnlStoreManipulation.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblSearchStore;
        private TextBox txtSearchStore;
        private Panel pnlLeftSide;
        private Panel pnlRightSide;
        private Label lblStoreID;
        private Label lblElectricityLastRecord;
        private TextBox txtFloorNumber;
        private Label lblFloorNumber;
        private TextBox txtStoreID;
        private TextBox txtElectricityLastRecord;
        private GroupBox gbStoreInformation;
        private Panel pnlStoreManipulation;
        private Button btnInsertStore;
        private Button btnCloseFormStore;
        private Button btnNewStore;
        private Button btnUpdateStore;
        private Label lblWaterLastRecord;
        private DataGridView dgvStores;
        private Label lblStatus;
        private Label lblStoreTypeID;
        private TextBox txtWaterLastRecord;
        private RadioButton rdbFree;
        private RadioButton rdbRented;
        private ComboBox cbStoreTypeID;
        private DataGridViewTextBoxColumn storeIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn floorNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn electricityLastRecordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn waterLastRecordDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn storeTypeIDDataGridViewTextBoxColumn;
    }
}