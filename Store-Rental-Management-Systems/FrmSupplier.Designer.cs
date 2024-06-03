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
            dataItems = new DataGridView();
            itemBindingSource = new BindingSource(components);
            pnlRightSide = new Panel();
            gbSupplierInformation = new GroupBox();
            pnlStaffManipulation = new Panel();
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
            epdStaffFirstName = new ErrorProvider(components);
            epdStaffLastName = new ErrorProvider(components);
            epdStaffIdentityCardNumber = new ErrorProvider(components);
            epdStaffSalary = new ErrorProvider(components);
            epdStaffContactNumber = new ErrorProvider(components);
            epdStaffPersonalNumber = new ErrorProvider(components);
            epdStaffHouseNo = new ErrorProvider(components);
            epdStaffStreetNo = new ErrorProvider(components);
            epdStaffSangkat = new ErrorProvider(components);
            epdStaffKhan = new ErrorProvider(components);
            supplierBindingSource = new BindingSource(components);
            supplierIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            supplierNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contactNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            supplierAddressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pnlLeftSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemBindingSource).BeginInit();
            pnlRightSide.SuspendLayout();
            gbSupplierInformation.SuspendLayout();
            pnlStaffManipulation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)epdStaffFirstName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epdStaffLastName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epdStaffIdentityCardNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epdStaffSalary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epdStaffContactNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epdStaffPersonalNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epdStaffHouseNo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epdStaffStreetNo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epdStaffSangkat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epdStaffKhan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)supplierBindingSource).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.DarkBlue;
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
            lblSearchSupplier.Size = new Size(81, 36);
            lblSearchSupplier.TabIndex = 1;
            lblSearchSupplier.Text = "ស្វែងរក:";
            // 
            // txtSearchSupplier
            // 
            txtSearchSupplier.Location = new Point(169, 11);
            txtSearchSupplier.Name = "txtSearchSupplier";
            txtSearchSupplier.Size = new Size(1275, 44);
            txtSearchSupplier.TabIndex = 2;
            // 
            // pnlLeftSide
            // 
            pnlLeftSide.Controls.Add(dataItems);
            pnlLeftSide.Controls.Add(lblSearchSupplier);
            pnlLeftSide.Controls.Add(txtSearchSupplier);
            pnlLeftSide.Location = new Point(266, 509);
            pnlLeftSide.Name = "pnlLeftSide";
            pnlLeftSide.Size = new Size(1534, 491);
            pnlLeftSide.TabIndex = 3;
            // 
            // dataItems
            // 
            dataItems.AllowUserToAddRows = false;
            dataItems.AllowUserToDeleteRows = false;
            dataItems.AutoGenerateColumns = false;
            dataItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataItems.Columns.AddRange(new DataGridViewColumn[] { supplierIDDataGridViewTextBoxColumn, supplierNameDataGridViewTextBoxColumn, contactNumberDataGridViewTextBoxColumn, supplierAddressDataGridViewTextBoxColumn });
            dataItems.DataSource = supplierBindingSource;
            dataItems.Location = new Point(82, 74);
            dataItems.Name = "dataItems";
            dataItems.ReadOnly = true;
            dataItems.RowHeadersWidth = 51;
            dataItems.RowTemplate.Height = 29;
            dataItems.Size = new Size(1362, 369);
            dataItems.TabIndex = 3;
            // 
            // itemBindingSource
            // 
            itemBindingSource.DataSource = typeof(StoreRentalHelper.entities.Item);
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
            gbSupplierInformation.Controls.Add(pnlStaffManipulation);
            gbSupplierInformation.Controls.Add(lblSupplierAddress);
            gbSupplierInformation.Controls.Add(lblSupplierID);
            gbSupplierInformation.Controls.Add(txtSupplierName);
            gbSupplierInformation.Controls.Add(lblSupplierName);
            gbSupplierInformation.Controls.Add(txtSupplierID);
            gbSupplierInformation.Controls.Add(lblContactNumber);
            gbSupplierInformation.Controls.Add(txtSupplierAddress);
            gbSupplierInformation.Controls.Add(txtContactNumber);
            gbSupplierInformation.Font = new Font("!Khmer OS Siemreap", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            gbSupplierInformation.Location = new Point(82, 12);
            gbSupplierInformation.Name = "gbSupplierInformation";
            gbSupplierInformation.Size = new Size(1362, 288);
            gbSupplierInformation.TabIndex = 25;
            gbSupplierInformation.TabStop = false;
            gbSupplierInformation.Text = "ព័ត៌មានអ្នកផ្គត់ផ្គង់";
            // 
            // pnlStaffManipulation
            // 
            pnlStaffManipulation.Controls.Add(btnCloseFormSupplier);
            pnlStaffManipulation.Controls.Add(btnNewSupplier);
            pnlStaffManipulation.Controls.Add(btnUpdateSupplier);
            pnlStaffManipulation.Controls.Add(btnInsertSupplier);
            pnlStaffManipulation.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pnlStaffManipulation.Location = new Point(18, 175);
            pnlStaffManipulation.Name = "pnlStaffManipulation";
            pnlStaffManipulation.Size = new Size(1301, 81);
            pnlStaffManipulation.TabIndex = 5;
            // 
            // btnCloseFormSupplier
            // 
            btnCloseFormSupplier.Location = new Point(1102, 20);
            btnCloseFormSupplier.Name = "btnCloseFormSupplier";
            btnCloseFormSupplier.Size = new Size(152, 52);
            btnCloseFormSupplier.TabIndex = 3;
            btnCloseFormSupplier.Text = "បិទ";
            btnCloseFormSupplier.UseVisualStyleBackColor = true;
            // 
            // btnNewSupplier
            // 
            btnNewSupplier.Location = new Point(774, 20);
            btnNewSupplier.Name = "btnNewSupplier";
            btnNewSupplier.Size = new Size(152, 52);
            btnNewSupplier.TabIndex = 2;
            btnNewSupplier.Text = "បង្កើតថ្មី";
            btnNewSupplier.UseVisualStyleBackColor = true;
            // 
            // btnUpdateSupplier
            // 
            btnUpdateSupplier.Location = new Point(411, 20);
            btnUpdateSupplier.Name = "btnUpdateSupplier";
            btnUpdateSupplier.Size = new Size(152, 52);
            btnUpdateSupplier.TabIndex = 1;
            btnUpdateSupplier.Text = "កែប្រែ";
            btnUpdateSupplier.UseVisualStyleBackColor = true;
            // 
            // btnInsertSupplier
            // 
            btnInsertSupplier.Location = new Point(20, 20);
            btnInsertSupplier.Name = "btnInsertSupplier";
            btnInsertSupplier.Size = new Size(152, 52);
            btnInsertSupplier.TabIndex = 0;
            btnInsertSupplier.Text = "បញ្ចូល";
            btnInsertSupplier.UseVisualStyleBackColor = true;
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
            // epdStaffFirstName
            // 
            epdStaffFirstName.ContainerControl = this;
            // 
            // epdStaffLastName
            // 
            epdStaffLastName.ContainerControl = this;
            // 
            // epdStaffIdentityCardNumber
            // 
            epdStaffIdentityCardNumber.ContainerControl = this;
            // 
            // epdStaffSalary
            // 
            epdStaffSalary.ContainerControl = this;
            // 
            // epdStaffContactNumber
            // 
            epdStaffContactNumber.ContainerControl = this;
            // 
            // epdStaffPersonalNumber
            // 
            epdStaffPersonalNumber.ContainerControl = this;
            // 
            // epdStaffHouseNo
            // 
            epdStaffHouseNo.ContainerControl = this;
            // 
            // epdStaffStreetNo
            // 
            epdStaffStreetNo.ContainerControl = this;
            // 
            // epdStaffSangkat
            // 
            epdStaffSangkat.ContainerControl = this;
            // 
            // epdStaffKhan
            // 
            epdStaffKhan.ContainerControl = this;
            // 
            // supplierBindingSource
            // 
            supplierBindingSource.DataSource = typeof(StoreRentalHelper.entities.Supplier);
            // 
            // supplierIDDataGridViewTextBoxColumn
            // 
            supplierIDDataGridViewTextBoxColumn.DataPropertyName = "SupplierID";
            supplierIDDataGridViewTextBoxColumn.HeaderText = "SupplierID";
            supplierIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            supplierIDDataGridViewTextBoxColumn.Name = "supplierIDDataGridViewTextBoxColumn";
            supplierIDDataGridViewTextBoxColumn.ReadOnly = true;
            supplierIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // supplierNameDataGridViewTextBoxColumn
            // 
            supplierNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            supplierNameDataGridViewTextBoxColumn.DataPropertyName = "SupplierName";
            supplierNameDataGridViewTextBoxColumn.HeaderText = "SupplierName";
            supplierNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            supplierNameDataGridViewTextBoxColumn.Name = "supplierNameDataGridViewTextBoxColumn";
            supplierNameDataGridViewTextBoxColumn.ReadOnly = true;
            supplierNameDataGridViewTextBoxColumn.Width = 169;
            // 
            // contactNumberDataGridViewTextBoxColumn
            // 
            contactNumberDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            contactNumberDataGridViewTextBoxColumn.DataPropertyName = "ContactNumber";
            contactNumberDataGridViewTextBoxColumn.HeaderText = "ContactNumber";
            contactNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            contactNumberDataGridViewTextBoxColumn.Name = "contactNumberDataGridViewTextBoxColumn";
            contactNumberDataGridViewTextBoxColumn.ReadOnly = true;
            contactNumberDataGridViewTextBoxColumn.Width = 184;
            // 
            // supplierAddressDataGridViewTextBoxColumn
            // 
            supplierAddressDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            supplierAddressDataGridViewTextBoxColumn.DataPropertyName = "SupplierAddress";
            supplierAddressDataGridViewTextBoxColumn.HeaderText = "SupplierAddress";
            supplierAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            supplierAddressDataGridViewTextBoxColumn.Name = "supplierAddressDataGridViewTextBoxColumn";
            supplierAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmSupplier
            // 
            AutoScaleMode = AutoScaleMode.None;
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
            ((System.ComponentModel.ISupportInitialize)dataItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemBindingSource).EndInit();
            pnlRightSide.ResumeLayout(false);
            gbSupplierInformation.ResumeLayout(false);
            gbSupplierInformation.PerformLayout();
            pnlStaffManipulation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)epdStaffFirstName).EndInit();
            ((System.ComponentModel.ISupportInitialize)epdStaffLastName).EndInit();
            ((System.ComponentModel.ISupportInitialize)epdStaffIdentityCardNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)epdStaffSalary).EndInit();
            ((System.ComponentModel.ISupportInitialize)epdStaffContactNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)epdStaffPersonalNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)epdStaffHouseNo).EndInit();
            ((System.ComponentModel.ISupportInitialize)epdStaffStreetNo).EndInit();
            ((System.ComponentModel.ISupportInitialize)epdStaffSangkat).EndInit();
            ((System.ComponentModel.ISupportInitialize)epdStaffKhan).EndInit();
            ((System.ComponentModel.ISupportInitialize)supplierBindingSource).EndInit();
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
        private Label lblStockQty;
        private TextBox txtContactNumber;
        private Label lblUnitPrice;
        private GroupBox gbSupplierInformation;
        private Panel pnlStaffManipulation;
        private Button btnInsertSupplier;
        private Button btnCloseFormSupplier;
        private Button btnNewSupplier;
        private Button btnUpdateSupplier;
        private ErrorProvider epdStaffFirstName;
        private ErrorProvider epdStaffLastName;
        private ErrorProvider epdStaffIdentityCardNumber;
        private ErrorProvider epdStaffSalary;
        private ErrorProvider epdStaffContactNumber;
        private ErrorProvider epdStaffPersonalNumber;
        private ErrorProvider epdStaffHouseNo;
        private ErrorProvider epdStaffStreetNo;
        private ErrorProvider epdStaffSangkat;
        private ErrorProvider epdStaffKhan;
        private TextBox txtStockQty;
        private Label lblSupplierAddress;
        private DataGridView dataItems;
        private BindingSource itemBindingSource;
        private BindingSource supplierBindingSource;
        private DataGridViewTextBoxColumn supplierIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn supplierNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contactNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn supplierAddressDataGridViewTextBoxColumn;
    }
}