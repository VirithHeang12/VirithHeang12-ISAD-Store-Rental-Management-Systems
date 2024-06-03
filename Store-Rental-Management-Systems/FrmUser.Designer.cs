namespace Store_Rental_Management_Systems
{
    partial class FrmUser
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
            lblSearchUser = new Label();
            txtSearchUser = new TextBox();
            pnlLeftSide = new Panel();
            dgvUsers = new DataGridView();
            userIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            passwordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            staffIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            staffNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            staffPositionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userBindingSource = new BindingSource(components);
            supplierBindingSource = new BindingSource(components);
            itemBindingSource = new BindingSource(components);
            pnlRightSide = new Panel();
            gbSupplierInformation = new GroupBox();
            lblStaffPosition = new Label();
            txtStaffPosition = new TextBox();
            txtStaffName = new TextBox();
            lblStaffName = new Label();
            cbStaffID = new ComboBox();
            pnlUserManipulation = new Panel();
            btnCloseFormUser = new Button();
            btnNewUser = new Button();
            btnUpdateUser = new Button();
            btnInsertUser = new Button();
            lblSupplierAddress = new Label();
            lblUserID = new Label();
            txtUserName = new TextBox();
            lblUserName = new Label();
            txtUserID = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
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
            pnlLeftSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)supplierBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemBindingSource).BeginInit();
            pnlRightSide.SuspendLayout();
            gbSupplierInformation.SuspendLayout();
            pnlUserManipulation.SuspendLayout();
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
            lblTitle.BackColor = Color.DarkBlue;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("!Khmer OS Siemreap", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(266, 80);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1534, 101);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ព័ត៌មានអ្នកប្រើប្រាស់";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSearchUser
            // 
            lblSearchUser.AutoSize = true;
            lblSearchUser.Location = new Point(82, 29);
            lblSearchUser.Name = "lblSearchUser";
            lblSearchUser.Size = new Size(81, 36);
            lblSearchUser.TabIndex = 1;
            lblSearchUser.Text = "ស្វែងរក:";
            // 
            // txtSearchUser
            // 
            txtSearchUser.Location = new Point(196, 21);
            txtSearchUser.Name = "txtSearchUser";
            txtSearchUser.Size = new Size(1248, 44);
            txtSearchUser.TabIndex = 2;
            // 
            // pnlLeftSide
            // 
            pnlLeftSide.Controls.Add(dgvUsers);
            pnlLeftSide.Controls.Add(lblSearchUser);
            pnlLeftSide.Controls.Add(txtSearchUser);
            pnlLeftSide.Location = new Point(266, 537);
            pnlLeftSide.Name = "pnlLeftSide";
            pnlLeftSide.Size = new Size(1534, 463);
            pnlLeftSide.TabIndex = 3;
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.AutoGenerateColumns = false;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Columns.AddRange(new DataGridViewColumn[] { userIDDataGridViewTextBoxColumn, userNameDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn, staffIDDataGridViewTextBoxColumn, staffNameDataGridViewTextBoxColumn, staffPositionDataGridViewTextBoxColumn });
            dgvUsers.DataSource = userBindingSource;
            dgvUsers.Location = new Point(82, 82);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.RowTemplate.Height = 29;
            dgvUsers.Size = new Size(1362, 325);
            dgvUsers.TabIndex = 3;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            userIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            userIDDataGridViewTextBoxColumn.ReadOnly = true;
            userIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            userNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            userNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            userNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            passwordDataGridViewTextBoxColumn.ReadOnly = true;
            passwordDataGridViewTextBoxColumn.Visible = false;
            passwordDataGridViewTextBoxColumn.Width = 125;
            // 
            // staffIDDataGridViewTextBoxColumn
            // 
            staffIDDataGridViewTextBoxColumn.DataPropertyName = "StaffID";
            staffIDDataGridViewTextBoxColumn.HeaderText = "StaffID";
            staffIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
            staffIDDataGridViewTextBoxColumn.ReadOnly = true;
            staffIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // staffNameDataGridViewTextBoxColumn
            // 
            staffNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            staffNameDataGridViewTextBoxColumn.DataPropertyName = "StaffName";
            staffNameDataGridViewTextBoxColumn.HeaderText = "StaffName";
            staffNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            staffNameDataGridViewTextBoxColumn.Name = "staffNameDataGridViewTextBoxColumn";
            staffNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // staffPositionDataGridViewTextBoxColumn
            // 
            staffPositionDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            staffPositionDataGridViewTextBoxColumn.DataPropertyName = "StaffPosition";
            staffPositionDataGridViewTextBoxColumn.HeaderText = "StaffPosition";
            staffPositionDataGridViewTextBoxColumn.MinimumWidth = 6;
            staffPositionDataGridViewTextBoxColumn.Name = "staffPositionDataGridViewTextBoxColumn";
            staffPositionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(StoreRentalHelper.entities.User);
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
            pnlRightSide.Controls.Add(gbSupplierInformation);
            pnlRightSide.Location = new Point(266, 184);
            pnlRightSide.Name = "pnlRightSide";
            pnlRightSide.Size = new Size(1534, 355);
            pnlRightSide.TabIndex = 4;
            // 
            // gbSupplierInformation
            // 
            gbSupplierInformation.Controls.Add(lblStaffPosition);
            gbSupplierInformation.Controls.Add(txtStaffPosition);
            gbSupplierInformation.Controls.Add(txtStaffName);
            gbSupplierInformation.Controls.Add(lblStaffName);
            gbSupplierInformation.Controls.Add(cbStaffID);
            gbSupplierInformation.Controls.Add(pnlUserManipulation);
            gbSupplierInformation.Controls.Add(lblSupplierAddress);
            gbSupplierInformation.Controls.Add(lblUserID);
            gbSupplierInformation.Controls.Add(txtUserName);
            gbSupplierInformation.Controls.Add(lblUserName);
            gbSupplierInformation.Controls.Add(txtUserID);
            gbSupplierInformation.Controls.Add(lblPassword);
            gbSupplierInformation.Controls.Add(txtPassword);
            gbSupplierInformation.Font = new Font("!Khmer OS Siemreap", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            gbSupplierInformation.Location = new Point(82, 12);
            gbSupplierInformation.Name = "gbSupplierInformation";
            gbSupplierInformation.Size = new Size(1362, 335);
            gbSupplierInformation.TabIndex = 25;
            gbSupplierInformation.TabStop = false;
            gbSupplierInformation.Text = "ព័ត៌មានអ្នកប្រើប្រាស់";
            // 
            // lblStaffPosition
            // 
            lblStaffPosition.AutoSize = true;
            lblStaffPosition.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffPosition.Location = new Point(711, 185);
            lblStaffPosition.Name = "lblStaffPosition";
            lblStaffPosition.Size = new Size(131, 36);
            lblStaffPosition.TabIndex = 32;
            lblStaffPosition.Text = "តួនាទីបុគ្គលិក:";
            // 
            // txtStaffPosition
            // 
            txtStaffPosition.Enabled = false;
            txtStaffPosition.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffPosition.Location = new Point(907, 177);
            txtStaffPosition.Name = "txtStaffPosition";
            txtStaffPosition.Size = new Size(412, 44);
            txtStaffPosition.TabIndex = 31;
            txtStaffPosition.UseSystemPasswordChar = true;
            // 
            // txtStaffName
            // 
            txtStaffName.Enabled = false;
            txtStaffName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffName.Location = new Point(245, 182);
            txtStaffName.Name = "txtStaffName";
            txtStaffName.Size = new Size(418, 44);
            txtStaffName.TabIndex = 30;
            txtStaffName.UseSystemPasswordChar = true;
            // 
            // lblStaffName
            // 
            lblStaffName.AutoSize = true;
            lblStaffName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffName.Location = new Point(18, 185);
            lblStaffName.Name = "lblStaffName";
            lblStaffName.Size = new Size(130, 36);
            lblStaffName.TabIndex = 29;
            lblStaffName.Text = "ឈ្មោះបុគ្គលិក:";
            // 
            // cbStaffID
            // 
            cbStaffID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbStaffID.FormattingEnabled = true;
            cbStaffID.Items.AddRange(new object[] { "អ្នកគ្រប់គ្រង", "គណនីករ" });
            cbStaffID.Location = new Point(907, 108);
            cbStaffID.Name = "cbStaffID";
            cbStaffID.Size = new Size(412, 44);
            cbStaffID.TabIndex = 28;
            // 
            // pnlUserManipulation
            // 
            pnlUserManipulation.Controls.Add(btnCloseFormUser);
            pnlUserManipulation.Controls.Add(btnNewUser);
            pnlUserManipulation.Controls.Add(btnUpdateUser);
            pnlUserManipulation.Controls.Add(btnInsertUser);
            pnlUserManipulation.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pnlUserManipulation.Location = new Point(18, 247);
            pnlUserManipulation.Name = "pnlUserManipulation";
            pnlUserManipulation.Size = new Size(1301, 81);
            pnlUserManipulation.TabIndex = 5;
            // 
            // btnCloseFormUser
            // 
            btnCloseFormUser.Location = new Point(1102, 20);
            btnCloseFormUser.Name = "btnCloseFormUser";
            btnCloseFormUser.Size = new Size(152, 52);
            btnCloseFormUser.TabIndex = 3;
            btnCloseFormUser.Text = "បិទ";
            btnCloseFormUser.UseVisualStyleBackColor = true;
            // 
            // btnNewUser
            // 
            btnNewUser.Location = new Point(774, 20);
            btnNewUser.Name = "btnNewUser";
            btnNewUser.Size = new Size(152, 52);
            btnNewUser.TabIndex = 2;
            btnNewUser.Text = "បង្កើតថ្មី";
            btnNewUser.UseVisualStyleBackColor = true;
            // 
            // btnUpdateUser
            // 
            btnUpdateUser.Location = new Point(411, 20);
            btnUpdateUser.Name = "btnUpdateUser";
            btnUpdateUser.Size = new Size(152, 52);
            btnUpdateUser.TabIndex = 1;
            btnUpdateUser.Text = "កែប្រែ";
            btnUpdateUser.UseVisualStyleBackColor = true;
            // 
            // btnInsertUser
            // 
            btnInsertUser.Location = new Point(20, 20);
            btnInsertUser.Name = "btnInsertUser";
            btnInsertUser.Size = new Size(152, 52);
            btnInsertUser.TabIndex = 0;
            btnInsertUser.Text = "បញ្ចូល";
            btnInsertUser.UseVisualStyleBackColor = true;
            // 
            // lblSupplierAddress
            // 
            lblSupplierAddress.AutoSize = true;
            lblSupplierAddress.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSupplierAddress.Location = new Point(711, 111);
            lblSupplierAddress.Name = "lblSupplierAddress";
            lblSupplierAddress.Size = new Size(183, 36);
            lblSupplierAddress.TabIndex = 27;
            lblSupplierAddress.Text = "លេខសម្គាល់បុគ្គលិក:";
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserID.Location = new Point(18, 41);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(221, 36);
            lblUserID.TabIndex = 0;
            lblUserID.Text = "លេខសម្គាល់អ្នកប្រើប្រាស់:";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.Location = new Point(907, 33);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(412, 44);
            txtUserName.TabIndex = 5;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserName.Location = new Point(711, 41);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(168, 36);
            lblUserName.TabIndex = 4;
            lblUserName.Text = "ឈ្មោះអ្នកប្រើប្រាស់:";
            // 
            // txtUserID
            // 
            txtUserID.Enabled = false;
            txtUserID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserID.Location = new Point(245, 33);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(418, 44);
            txtUserID.TabIndex = 3;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(18, 111);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(115, 36);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "លេខសម្ងាត់:";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(245, 111);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(418, 44);
            txtPassword.TabIndex = 13;
            txtPassword.UseSystemPasswordChar = true;
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
            // FrmUser
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1800, 1000);
            ControlBox = true;
            Controls.Add(pnlRightSide);
            Controls.Add(pnlLeftSide);
            Controls.Add(lblTitle);
            Name = "FrmUser";
            Text = "ព័ត៌មានបុគ្គលិក";
            Controls.SetChildIndex(lblTitle, 0);
            Controls.SetChildIndex(pnlLeftSide, 0);
            Controls.SetChildIndex(pnlRightSide, 0);
            pnlLeftSide.ResumeLayout(false);
            pnlLeftSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)supplierBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemBindingSource).EndInit();
            pnlRightSide.ResumeLayout(false);
            gbSupplierInformation.ResumeLayout(false);
            gbSupplierInformation.PerformLayout();
            pnlUserManipulation.ResumeLayout(false);
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
        private Label lblSearchUser;
        private TextBox txtSearchUser;
        private Panel pnlLeftSide;
        private Panel pnlRightSide;
        private Label lblUserID;
        private Label lblPassword;
        private TextBox txtUserName;
        private Label lblUserName;
        private TextBox txtUserID;
        private Label lblStockQty;
        private TextBox txtPassword;
        private Label lblUnitPrice;
        private GroupBox gbSupplierInformation;
        private Panel pnlUserManipulation;
        private Button btnInsertUser;
        private Button btnCloseFormUser;
        private Button btnNewUser;
        private Button btnUpdateUser;
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
        private DataGridView dgvUsers;
        private BindingSource itemBindingSource;
        private BindingSource supplierBindingSource;
        private Label lblStaffName;
        private ComboBox cbStaffID;
        private Label lblStaffPosition;
        private TextBox txtStaffPosition;
        private TextBox txtStaffName;
        private DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn staffNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn staffPositionDataGridViewTextBoxColumn;
        private BindingSource userBindingSource;
    }
}