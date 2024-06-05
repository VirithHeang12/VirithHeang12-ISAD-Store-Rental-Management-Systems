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
            components = new System.ComponentModel.Container();
            lblTitle = new Label();
            lblSearchSupplier = new Label();
            txtSearchSupplier = new TextBox();
            pnlLeftSide = new Panel();
            dgvSuppliers = new DataGridView();
            supplierIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            supplierNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contactNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            supplierAddressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            supplierBindingSource = new BindingSource(components);
            pnlRightSide = new Panel();
            gbSupplierInformation = new GroupBox();
            pnlSupplierManipulation = new Panel();
            btnCloseFormSupplier = new Button();
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
            txtContactNumber = new TextBox();
            pnlLeftSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)supplierBindingSource).BeginInit();
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
            lblSearchSupplier.Size = new Size(293, 36);
            lblSearchSupplier.TabIndex = 1;
            lblSearchSupplier.Text = "ស្វែងរក (លេខសម្គាល់អ្នកផ្គត់ផ្គង់):";
            // 
            // txtSearchSupplier
            // 
            txtSearchSupplier.Location = new Point(396, 11);
            txtSearchSupplier.Name = "txtSearchSupplier";
            txtSearchSupplier.Size = new Size(349, 44);
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
            dgvSuppliers.AutoGenerateColumns = false;
            dgvSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSuppliers.Columns.AddRange(new DataGridViewColumn[] { supplierIDDataGridViewTextBoxColumn, supplierNameDataGridViewTextBoxColumn, contactNumberDataGridViewTextBoxColumn, supplierAddressDataGridViewTextBoxColumn });
            dgvSuppliers.DataSource = supplierBindingSource;
            dgvSuppliers.Location = new Point(82, 74);
            dgvSuppliers.Name = "dgvSuppliers";
            dgvSuppliers.ReadOnly = true;
            dgvSuppliers.RowHeadersWidth = 51;
            dgvSuppliers.RowTemplate.Height = 29;
            dgvSuppliers.Size = new Size(1362, 369);
            dgvSuppliers.TabIndex = 3;
            // 
            // supplierIDDataGridViewTextBoxColumn
            // 
            supplierIDDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            supplierIDDataGridViewTextBoxColumn.DataPropertyName = "SupplierID";
            supplierIDDataGridViewTextBoxColumn.HeaderText = "លេខសម្គាល់អ្នកផ្គត់ផ្គង់";
            supplierIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            supplierIDDataGridViewTextBoxColumn.Name = "supplierIDDataGridViewTextBoxColumn";
            supplierIDDataGridViewTextBoxColumn.ReadOnly = true;
            supplierIDDataGridViewTextBoxColumn.Width = 228;
            // 
            // supplierNameDataGridViewTextBoxColumn
            // 
            supplierNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            supplierNameDataGridViewTextBoxColumn.DataPropertyName = "SupplierName";
            supplierNameDataGridViewTextBoxColumn.HeaderText = "ឈ្មោះអ្នកផ្គត់ផ្គង់";
            supplierNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            supplierNameDataGridViewTextBoxColumn.Name = "supplierNameDataGridViewTextBoxColumn";
            supplierNameDataGridViewTextBoxColumn.ReadOnly = true;
            supplierNameDataGridViewTextBoxColumn.Width = 175;
            // 
            // contactNumberDataGridViewTextBoxColumn
            // 
            contactNumberDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            contactNumberDataGridViewTextBoxColumn.DataPropertyName = "ContactNumber";
            contactNumberDataGridViewTextBoxColumn.HeaderText = "លេខទំនាក់ទំនង";
            contactNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            contactNumberDataGridViewTextBoxColumn.Name = "contactNumberDataGridViewTextBoxColumn";
            contactNumberDataGridViewTextBoxColumn.ReadOnly = true;
            contactNumberDataGridViewTextBoxColumn.Width = 174;
            // 
            // supplierAddressDataGridViewTextBoxColumn
            // 
            supplierAddressDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            supplierAddressDataGridViewTextBoxColumn.DataPropertyName = "SupplierAddress";
            supplierAddressDataGridViewTextBoxColumn.HeaderText = "អាសយដ្ឋានអ្នកផ្គត់ផ្គង់";
            supplierAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            supplierAddressDataGridViewTextBoxColumn.Name = "supplierAddressDataGridViewTextBoxColumn";
            supplierAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // supplierBindingSource
            // 
            supplierBindingSource.DataSource = typeof(StoreRentalHelper.entities.Supplier);
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
            gbSupplierInformation.Controls.Add(pnlSupplierManipulation);
            gbSupplierInformation.Controls.Add(lblSupplierAddress);
            gbSupplierInformation.Controls.Add(lblSupplierID);
            gbSupplierInformation.Controls.Add(txtSupplierName);
            gbSupplierInformation.Controls.Add(lblSupplierName);
            gbSupplierInformation.Controls.Add(txtSupplierID);
            gbSupplierInformation.Controls.Add(lblContactNumber);
            gbSupplierInformation.Controls.Add(txtSupplierAddress);
            gbSupplierInformation.Controls.Add(txtContactNumber);
            gbSupplierInformation.Font = new Font("!Khmer OS Siemreap", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            gbSupplierInformation.Location = new Point(82, 12);
            gbSupplierInformation.Name = "gbSupplierInformation";
            gbSupplierInformation.Size = new Size(1362, 288);
            gbSupplierInformation.TabIndex = 25;
            gbSupplierInformation.TabStop = false;
            gbSupplierInformation.Text = "ព័ត៌មានអ្នកផ្គត់ផ្គង់";
            // 
            // pnlSupplierManipulation
            // 
            pnlSupplierManipulation.Controls.Add(btnCloseFormSupplier);
            pnlSupplierManipulation.Controls.Add(btnNewSupplier);
            pnlSupplierManipulation.Controls.Add(btnUpdateSupplier);
            pnlSupplierManipulation.Controls.Add(btnInsertSupplier);
            pnlSupplierManipulation.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pnlSupplierManipulation.Location = new Point(18, 171);
            pnlSupplierManipulation.Name = "pnlSupplierManipulation";
            pnlSupplierManipulation.Size = new Size(1301, 85);
            pnlSupplierManipulation.TabIndex = 5;
            // 
            // btnCloseFormSupplier
            // 
            btnCloseFormSupplier.BackColor = Color.FromArgb(0, 28, 87);
            btnCloseFormSupplier.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCloseFormSupplier.ForeColor = Color.White;
            btnCloseFormSupplier.Location = new Point(1100, 20);
            btnCloseFormSupplier.Name = "btnCloseFormSupplier";
            btnCloseFormSupplier.Size = new Size(152, 52);
            btnCloseFormSupplier.TabIndex = 3;
            btnCloseFormSupplier.Text = "បិទ";
            btnCloseFormSupplier.UseVisualStyleBackColor = false;
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
            lblSupplierAddress.Size = new Size(115, 36);
            lblSupplierAddress.TabIndex = 27;
            lblSupplierAddress.Text = "អាសយដ្ឋាន:";
            // 
            // lblSupplierID
            // 
            lblSupplierID.AutoSize = true;
            lblSupplierID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSupplierID.Location = new Point(18, 41);
            lblSupplierID.Name = "lblSupplierID";
            lblSupplierID.Size = new Size(205, 36);
            lblSupplierID.TabIndex = 0;
            lblSupplierID.Text = "លេខសម្គាល់អ្នកផ្គត់ផ្គង់:";
            // 
            // txtSupplierName
            // 
            txtSupplierName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSupplierName.Location = new Point(907, 33);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(412, 44);
            txtSupplierName.TabIndex = 5;
            // 
            // lblSupplierName
            // 
            lblSupplierName.AutoSize = true;
            lblSupplierName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSupplierName.Location = new Point(711, 41);
            lblSupplierName.Name = "lblSupplierName";
            lblSupplierName.Size = new Size(152, 36);
            lblSupplierName.TabIndex = 4;
            lblSupplierName.Text = "ឈ្មោះអ្នកផ្គត់ផ្គង់:";
            // 
            // txtSupplierID
            // 
            txtSupplierID.Enabled = false;
            txtSupplierID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSupplierID.Location = new Point(229, 33);
            txtSupplierID.Name = "txtSupplierID";
            txtSupplierID.Size = new Size(434, 44);
            txtSupplierID.TabIndex = 3;
            // 
            // lblContactNumber
            // 
            lblContactNumber.AutoSize = true;
            lblContactNumber.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblContactNumber.Location = new Point(18, 111);
            lblContactNumber.Name = "lblContactNumber";
            lblContactNumber.Size = new Size(151, 36);
            lblContactNumber.TabIndex = 6;
            lblContactNumber.Text = "លេខទំនាក់ទំនង:";
            // 
            // txtSupplierAddress
            // 
            txtSupplierAddress.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSupplierAddress.Location = new Point(907, 103);
            txtSupplierAddress.Name = "txtSupplierAddress";
            txtSupplierAddress.Size = new Size(412, 44);
            txtSupplierAddress.TabIndex = 7;
            // 
            // txtContactNumber
            // 
            txtContactNumber.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtContactNumber.Location = new Point(229, 111);
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.Size = new Size(434, 44);
            txtContactNumber.TabIndex = 13;
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
            ((System.ComponentModel.ISupportInitialize)supplierBindingSource).EndInit();
            pnlRightSide.ResumeLayout(false);
            gbSupplierInformation.ResumeLayout(false);
            gbSupplierInformation.PerformLayout();
            pnlSupplierManipulation.ResumeLayout(false);
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
        private TextBox txtContactNumber;
        private GroupBox gbSupplierInformation;
        private Panel pnlSupplierManipulation;
        private Button btnInsertSupplier;
        private Button btnCloseFormSupplier;
        private Button btnNewSupplier;
        private Button btnUpdateSupplier;
        private Label lblSupplierAddress;
        private DataGridView dgvSuppliers;
        private BindingSource supplierBindingSource;
        private DataGridViewTextBoxColumn supplierIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn supplierNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contactNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn supplierAddressDataGridViewTextBoxColumn;
    }
}