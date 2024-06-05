namespace Store_Rental_Management_Systems
{
    partial class FrmExpenseType
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
            lblSearchExpenseType = new Label();
            txtSearchExpenseType = new TextBox();
            pnlLeftSide = new Panel();
            dgvExpenseTypes = new DataGridView();
            expenseTypeBindingSource = new BindingSource(components);
            insuranceBindingSource = new BindingSource(components);
            supplierBindingSource = new BindingSource(components);
            itemBindingSource = new BindingSource(components);
            pnlRightSide = new Panel();
            gbExpenseTypeInformation = new GroupBox();
            pnlExpenseTypeManipulation = new Panel();
            btnCloseFormExpenseType = new Button();
            btnNewExpenseType = new Button();
            btnUpdateExpenseType = new Button();
            btnInsertExpenseType = new Button();
            lblExpenseTypeID = new Label();
            txtExpenseTypeID = new TextBox();
            lblExpenseDescription = new Label();
            txtExpenseDescription = new TextBox();
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
            expenseTypeIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            expenseDescriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pnlLeftSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExpenseTypes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)expenseTypeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)insuranceBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)supplierBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemBindingSource).BeginInit();
            pnlRightSide.SuspendLayout();
            gbExpenseTypeInformation.SuspendLayout();
            pnlExpenseTypeManipulation.SuspendLayout();
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
            lblTitle.Text = "ព័ត៌មានប្រភេទចំណាយ";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSearchExpenseType
            // 
            lblSearchExpenseType.AutoSize = true;
            lblSearchExpenseType.Location = new Point(82, 19);
            lblSearchExpenseType.Name = "lblSearchExpenseType";
            lblSearchExpenseType.Size = new Size(331, 36);
            lblSearchExpenseType.TabIndex = 1;
            lblSearchExpenseType.Text = "ស្វែងរក (លេខសម្គាល់ប្រភេទចំណាយ):";
            // 
            // txtSearchExpenseType
            // 
            txtSearchExpenseType.Location = new Point(436, 11);
            txtSearchExpenseType.Name = "txtSearchExpenseType";
            txtSearchExpenseType.Size = new Size(556, 44);
            txtSearchExpenseType.TabIndex = 2;
            // 
            // pnlLeftSide
            // 
            pnlLeftSide.Controls.Add(dgvExpenseTypes);
            pnlLeftSide.Controls.Add(lblSearchExpenseType);
            pnlLeftSide.Controls.Add(txtSearchExpenseType);
            pnlLeftSide.Location = new Point(266, 509);
            pnlLeftSide.Name = "pnlLeftSide";
            pnlLeftSide.Size = new Size(1534, 491);
            pnlLeftSide.TabIndex = 3;
            // 
            // dgvExpenseTypes
            // 
            dgvExpenseTypes.AllowUserToAddRows = false;
            dgvExpenseTypes.AllowUserToDeleteRows = false;
            dgvExpenseTypes.AutoGenerateColumns = false;
            dgvExpenseTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpenseTypes.Columns.AddRange(new DataGridViewColumn[] { expenseTypeIDDataGridViewTextBoxColumn, expenseDescriptionDataGridViewTextBoxColumn });
            dgvExpenseTypes.DataSource = expenseTypeBindingSource;
            dgvExpenseTypes.Location = new Point(82, 74);
            dgvExpenseTypes.Name = "dgvExpenseTypes";
            dgvExpenseTypes.ReadOnly = true;
            dgvExpenseTypes.RowHeadersWidth = 51;
            dgvExpenseTypes.RowTemplate.Height = 29;
            dgvExpenseTypes.Size = new Size(1362, 369);
            dgvExpenseTypes.TabIndex = 3;
            // 
            // expenseTypeBindingSource
            // 
            expenseTypeBindingSource.DataSource = typeof(StoreRentalHelper.entities.ExpenseType);
            // 
            // insuranceBindingSource
            // 
            insuranceBindingSource.DataSource = typeof(StoreRentalHelper.entities.Insurance);
            // 
            // supplierBindingSource
            // 
            supplierBindingSource.DataSource = typeof(StoreRentalHelper.entities.Supplier);
            // 
            // itemBindingSource
            // 
            itemBindingSource.DataSource = typeof(StoreRentalHelper.entities.Item);
            // 
            // pnlRightSide
            // 
            pnlRightSide.Controls.Add(gbExpenseTypeInformation);
            pnlRightSide.Location = new Point(266, 184);
            pnlRightSide.Name = "pnlRightSide";
            pnlRightSide.Size = new Size(1534, 319);
            pnlRightSide.TabIndex = 4;
            // 
            // gbExpenseTypeInformation
            // 
            gbExpenseTypeInformation.Controls.Add(pnlExpenseTypeManipulation);
            gbExpenseTypeInformation.Controls.Add(lblExpenseTypeID);
            gbExpenseTypeInformation.Controls.Add(txtExpenseTypeID);
            gbExpenseTypeInformation.Controls.Add(lblExpenseDescription);
            gbExpenseTypeInformation.Controls.Add(txtExpenseDescription);
            gbExpenseTypeInformation.Font = new Font("!Khmer OS Siemreap", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            gbExpenseTypeInformation.Location = new Point(82, 12);
            gbExpenseTypeInformation.Name = "gbExpenseTypeInformation";
            gbExpenseTypeInformation.Size = new Size(1362, 288);
            gbExpenseTypeInformation.TabIndex = 25;
            gbExpenseTypeInformation.TabStop = false;
            gbExpenseTypeInformation.Text = "ព័ត៌មានប្រភេទចំណាយ";
            // 
            // pnlExpenseTypeManipulation
            // 
            pnlExpenseTypeManipulation.Controls.Add(btnCloseFormExpenseType);
            pnlExpenseTypeManipulation.Controls.Add(btnNewExpenseType);
            pnlExpenseTypeManipulation.Controls.Add(btnUpdateExpenseType);
            pnlExpenseTypeManipulation.Controls.Add(btnInsertExpenseType);
            pnlExpenseTypeManipulation.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pnlExpenseTypeManipulation.Location = new Point(18, 175);
            pnlExpenseTypeManipulation.Name = "pnlExpenseTypeManipulation";
            pnlExpenseTypeManipulation.Size = new Size(1301, 81);
            pnlExpenseTypeManipulation.TabIndex = 5;
            // 
            // btnCloseFormExpenseType
            // 
            btnCloseFormExpenseType.BackColor = Color.FromArgb(0, 28, 87);
            btnCloseFormExpenseType.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCloseFormExpenseType.ForeColor = Color.White;
            btnCloseFormExpenseType.Location = new Point(1100, 20);
            btnCloseFormExpenseType.Name = "btnCloseFormExpenseType";
            btnCloseFormExpenseType.Size = new Size(152, 52);
            btnCloseFormExpenseType.TabIndex = 3;
            btnCloseFormExpenseType.Text = "បិទ";
            btnCloseFormExpenseType.UseVisualStyleBackColor = false;
            // 
            // btnNewExpenseType
            // 
            btnNewExpenseType.BackColor = Color.FromArgb(0, 28, 87);
            btnNewExpenseType.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNewExpenseType.ForeColor = Color.White;
            btnNewExpenseType.Location = new Point(740, 20);
            btnNewExpenseType.Name = "btnNewExpenseType";
            btnNewExpenseType.Size = new Size(152, 52);
            btnNewExpenseType.TabIndex = 2;
            btnNewExpenseType.Text = "បង្កើតថ្មី";
            btnNewExpenseType.UseVisualStyleBackColor = false;
            // 
            // btnUpdateExpenseType
            // 
            btnUpdateExpenseType.BackColor = Color.FromArgb(0, 28, 87);
            btnUpdateExpenseType.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateExpenseType.ForeColor = Color.White;
            btnUpdateExpenseType.Location = new Point(380, 20);
            btnUpdateExpenseType.Name = "btnUpdateExpenseType";
            btnUpdateExpenseType.Size = new Size(152, 52);
            btnUpdateExpenseType.TabIndex = 1;
            btnUpdateExpenseType.Text = "កែប្រែ";
            btnUpdateExpenseType.UseVisualStyleBackColor = false;
            // 
            // btnInsertExpenseType
            // 
            btnInsertExpenseType.BackColor = Color.FromArgb(0, 28, 87);
            btnInsertExpenseType.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsertExpenseType.ForeColor = Color.White;
            btnInsertExpenseType.Location = new Point(20, 20);
            btnInsertExpenseType.Name = "btnInsertExpenseType";
            btnInsertExpenseType.Size = new Size(152, 52);
            btnInsertExpenseType.TabIndex = 0;
            btnInsertExpenseType.Text = "បញ្ចូល";
            btnInsertExpenseType.UseVisualStyleBackColor = false;
            // 
            // lblExpenseTypeID
            // 
            lblExpenseTypeID.AutoSize = true;
            lblExpenseTypeID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblExpenseTypeID.Location = new Point(18, 41);
            lblExpenseTypeID.Name = "lblExpenseTypeID";
            lblExpenseTypeID.Size = new Size(243, 36);
            lblExpenseTypeID.TabIndex = 0;
            lblExpenseTypeID.Text = "លេខសម្គាល់ប្រភេទចំណាយ:";
            // 
            // txtExpenseTypeID
            // 
            txtExpenseTypeID.Enabled = false;
            txtExpenseTypeID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtExpenseTypeID.Location = new Point(300, 33);
            txtExpenseTypeID.Name = "txtExpenseTypeID";
            txtExpenseTypeID.Size = new Size(363, 44);
            txtExpenseTypeID.TabIndex = 3;
            // 
            // lblExpenseDescription
            // 
            lblExpenseDescription.AutoSize = true;
            lblExpenseDescription.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblExpenseDescription.Location = new Point(18, 111);
            lblExpenseDescription.Name = "lblExpenseDescription";
            lblExpenseDescription.Size = new Size(190, 36);
            lblExpenseDescription.TabIndex = 6;
            lblExpenseDescription.Text = "ពិព័ណ៌នាការចំណាយ:";
            // 
            // txtExpenseDescription
            // 
            txtExpenseDescription.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtExpenseDescription.Location = new Point(300, 111);
            txtExpenseDescription.Name = "txtExpenseDescription";
            txtExpenseDescription.Size = new Size(1019, 44);
            txtExpenseDescription.TabIndex = 13;
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
            // expenseTypeIDDataGridViewTextBoxColumn
            // 
            expenseTypeIDDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            expenseTypeIDDataGridViewTextBoxColumn.DataPropertyName = "ExpenseTypeID";
            expenseTypeIDDataGridViewTextBoxColumn.HeaderText = "លេខសម្គាល់ប្រភេទចំណាយ";
            expenseTypeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            expenseTypeIDDataGridViewTextBoxColumn.Name = "expenseTypeIDDataGridViewTextBoxColumn";
            expenseTypeIDDataGridViewTextBoxColumn.ReadOnly = true;
            expenseTypeIDDataGridViewTextBoxColumn.Width = 266;
            // 
            // expenseDescriptionDataGridViewTextBoxColumn
            // 
            expenseDescriptionDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            expenseDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ExpenseDescription";
            expenseDescriptionDataGridViewTextBoxColumn.HeaderText = "ពិព័ណ៌នាការចំណាយ";
            expenseDescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            expenseDescriptionDataGridViewTextBoxColumn.Name = "expenseDescriptionDataGridViewTextBoxColumn";
            expenseDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmExpenseType
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1800, 1000);
            ControlBox = true;
            Controls.Add(pnlRightSide);
            Controls.Add(pnlLeftSide);
            Controls.Add(lblTitle);
            Name = "FrmExpenseType";
            Text = "ព័ត៌មានបុគ្គលិក";
            Controls.SetChildIndex(lblTitle, 0);
            Controls.SetChildIndex(pnlLeftSide, 0);
            Controls.SetChildIndex(pnlRightSide, 0);
            pnlLeftSide.ResumeLayout(false);
            pnlLeftSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExpenseTypes).EndInit();
            ((System.ComponentModel.ISupportInitialize)expenseTypeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)insuranceBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)supplierBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemBindingSource).EndInit();
            pnlRightSide.ResumeLayout(false);
            gbExpenseTypeInformation.ResumeLayout(false);
            gbExpenseTypeInformation.PerformLayout();
            pnlExpenseTypeManipulation.ResumeLayout(false);
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
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblSearchExpenseType;
        private TextBox txtSearchExpenseType;
        private Panel pnlLeftSide;
        private Panel pnlRightSide;
        private Label lblExpenseTypeID;
        private Label lblExpenseDescription;
        private TextBox txtExpenseTypeID;
        private TextBox txtExpenseDescription;
        private GroupBox gbExpenseTypeInformation;
        private Panel pnlExpenseTypeManipulation;
        private Button btnInsertExpenseType;
        private Button btnCloseFormExpenseType;
        private Button btnNewExpenseType;
        private Button btnUpdateExpenseType;
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
        private DataGridView dgvExpenseTypes;
        private BindingSource itemBindingSource;
        private BindingSource supplierBindingSource;
        private BindingSource insuranceBindingSource;
        private BindingSource expenseTypeBindingSource;
        private DataGridViewTextBoxColumn expenseTypeIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn expenseDescriptionDataGridViewTextBoxColumn;
    }
}
