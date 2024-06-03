namespace Store_Rental_Management_Systems
{
    partial class FrmInsurance
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
            lblSearchInsurance = new Label();
            txtSearchInsurance = new TextBox();
            pnlLeftSide = new Panel();
            dgvInsurances = new DataGridView();
            supplierBindingSource = new BindingSource(components);
            itemBindingSource = new BindingSource(components);
            pnlRightSide = new Panel();
            gbInsuranceInformation = new GroupBox();
            pnlInsuranceManipulation = new Panel();
            btnCloseFormInsurance = new Button();
            btnNewInsurance = new Button();
            btnUpdateInsurance = new Button();
            btnInsertInsurance = new Button();
            lblInsuranceID = new Label();
            txtInsuranceName = new TextBox();
            lblInsuranceName = new Label();
            txtInsuranceID = new TextBox();
            lblInsuranceWebsite = new Label();
            txtInsuranceWebsite = new TextBox();
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
            insuranceBindingSource = new BindingSource(components);
            insuranceIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            insuranceNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            insuranceWebsiteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pnlLeftSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInsurances).BeginInit();
            ((System.ComponentModel.ISupportInitialize)supplierBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemBindingSource).BeginInit();
            pnlRightSide.SuspendLayout();
            gbInsuranceInformation.SuspendLayout();
            pnlInsuranceManipulation.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)insuranceBindingSource).BeginInit();
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
            lblTitle.Text = "ព័ត៌មានក្រុមហ៊ុនធានារ៉ាប់រង";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSearchInsurance
            // 
            lblSearchInsurance.AutoSize = true;
            lblSearchInsurance.Location = new Point(82, 19);
            lblSearchInsurance.Name = "lblSearchInsurance";
            lblSearchInsurance.Size = new Size(81, 36);
            lblSearchInsurance.TabIndex = 1;
            lblSearchInsurance.Text = "ស្វែងរក:";
            // 
            // txtSearchInsurance
            // 
            txtSearchInsurance.Location = new Point(169, 11);
            txtSearchInsurance.Name = "txtSearchInsurance";
            txtSearchInsurance.Size = new Size(1275, 44);
            txtSearchInsurance.TabIndex = 2;
            // 
            // pnlLeftSide
            // 
            pnlLeftSide.Controls.Add(dgvInsurances);
            pnlLeftSide.Controls.Add(lblSearchInsurance);
            pnlLeftSide.Controls.Add(txtSearchInsurance);
            pnlLeftSide.Location = new Point(266, 509);
            pnlLeftSide.Name = "pnlLeftSide";
            pnlLeftSide.Size = new Size(1534, 491);
            pnlLeftSide.TabIndex = 3;
            // 
            // dgvInsurances
            // 
            dgvInsurances.AllowUserToAddRows = false;
            dgvInsurances.AllowUserToDeleteRows = false;
            dgvInsurances.AutoGenerateColumns = false;
            dgvInsurances.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInsurances.Columns.AddRange(new DataGridViewColumn[] { insuranceIDDataGridViewTextBoxColumn, insuranceNameDataGridViewTextBoxColumn, insuranceWebsiteDataGridViewTextBoxColumn });
            dgvInsurances.DataSource = insuranceBindingSource;
            dgvInsurances.Location = new Point(82, 74);
            dgvInsurances.Name = "dgvInsurances";
            dgvInsurances.ReadOnly = true;
            dgvInsurances.RowHeadersWidth = 51;
            dgvInsurances.RowTemplate.Height = 29;
            dgvInsurances.Size = new Size(1362, 369);
            dgvInsurances.TabIndex = 3;
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
            pnlRightSide.Controls.Add(gbInsuranceInformation);
            pnlRightSide.Location = new Point(266, 184);
            pnlRightSide.Name = "pnlRightSide";
            pnlRightSide.Size = new Size(1534, 319);
            pnlRightSide.TabIndex = 4;
            // 
            // gbInsuranceInformation
            // 
            gbInsuranceInformation.Controls.Add(pnlInsuranceManipulation);
            gbInsuranceInformation.Controls.Add(lblInsuranceID);
            gbInsuranceInformation.Controls.Add(txtInsuranceName);
            gbInsuranceInformation.Controls.Add(lblInsuranceName);
            gbInsuranceInformation.Controls.Add(txtInsuranceID);
            gbInsuranceInformation.Controls.Add(lblInsuranceWebsite);
            gbInsuranceInformation.Controls.Add(txtInsuranceWebsite);
            gbInsuranceInformation.Font = new Font("!Khmer OS Siemreap", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            gbInsuranceInformation.Location = new Point(82, 12);
            gbInsuranceInformation.Name = "gbInsuranceInformation";
            gbInsuranceInformation.Size = new Size(1362, 288);
            gbInsuranceInformation.TabIndex = 25;
            gbInsuranceInformation.TabStop = false;
            gbInsuranceInformation.Text = "ព័ត៌មានក្រុមហ៊ុនធានារ៉ាប់រង";
            // 
            // pnlInsuranceManipulation
            // 
            pnlInsuranceManipulation.Controls.Add(btnCloseFormInsurance);
            pnlInsuranceManipulation.Controls.Add(btnNewInsurance);
            pnlInsuranceManipulation.Controls.Add(btnUpdateInsurance);
            pnlInsuranceManipulation.Controls.Add(btnInsertInsurance);
            pnlInsuranceManipulation.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pnlInsuranceManipulation.Location = new Point(18, 175);
            pnlInsuranceManipulation.Name = "pnlInsuranceManipulation";
            pnlInsuranceManipulation.Size = new Size(1301, 81);
            pnlInsuranceManipulation.TabIndex = 5;
            // 
            // btnCloseFormInsurance
            // 
            btnCloseFormInsurance.Location = new Point(1102, 20);
            btnCloseFormInsurance.Name = "btnCloseFormInsurance";
            btnCloseFormInsurance.Size = new Size(152, 52);
            btnCloseFormInsurance.TabIndex = 3;
            btnCloseFormInsurance.Text = "បិទ";
            btnCloseFormInsurance.UseVisualStyleBackColor = true;
            // 
            // btnNewInsurance
            // 
            btnNewInsurance.Location = new Point(774, 20);
            btnNewInsurance.Name = "btnNewInsurance";
            btnNewInsurance.Size = new Size(152, 52);
            btnNewInsurance.TabIndex = 2;
            btnNewInsurance.Text = "បង្កើតថ្មី";
            btnNewInsurance.UseVisualStyleBackColor = true;
            // 
            // btnUpdateInsurance
            // 
            btnUpdateInsurance.Location = new Point(411, 20);
            btnUpdateInsurance.Name = "btnUpdateInsurance";
            btnUpdateInsurance.Size = new Size(152, 52);
            btnUpdateInsurance.TabIndex = 1;
            btnUpdateInsurance.Text = "កែប្រែ";
            btnUpdateInsurance.UseVisualStyleBackColor = true;
            // 
            // btnInsertInsurance
            // 
            btnInsertInsurance.Location = new Point(20, 20);
            btnInsertInsurance.Name = "btnInsertInsurance";
            btnInsertInsurance.Size = new Size(152, 52);
            btnInsertInsurance.TabIndex = 0;
            btnInsertInsurance.Text = "បញ្ចូល";
            btnInsertInsurance.UseVisualStyleBackColor = true;
            // 
            // lblInsuranceID
            // 
            lblInsuranceID.AutoSize = true;
            lblInsuranceID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblInsuranceID.Location = new Point(18, 41);
            lblInsuranceID.Name = "lblInsuranceID";
            lblInsuranceID.Size = new Size(276, 36);
            lblInsuranceID.TabIndex = 0;
            lblInsuranceID.Text = "លេខសម្គាល់ក្រុមហ៊ុនធានារ៉ាប់រង:";
            // 
            // txtInsuranceName
            // 
            txtInsuranceName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtInsuranceName.Location = new Point(940, 33);
            txtInsuranceName.Name = "txtInsuranceName";
            txtInsuranceName.Size = new Size(379, 44);
            txtInsuranceName.TabIndex = 5;
            // 
            // lblInsuranceName
            // 
            lblInsuranceName.AutoSize = true;
            lblInsuranceName.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblInsuranceName.Location = new Point(711, 41);
            lblInsuranceName.Name = "lblInsuranceName";
            lblInsuranceName.Size = new Size(223, 36);
            lblInsuranceName.TabIndex = 4;
            lblInsuranceName.Text = "ឈ្មោះក្រុមហ៊ុនធានារ៉ាប់រង:";
            // 
            // txtInsuranceID
            // 
            txtInsuranceID.Enabled = false;
            txtInsuranceID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtInsuranceID.Location = new Point(300, 33);
            txtInsuranceID.Name = "txtInsuranceID";
            txtInsuranceID.Size = new Size(363, 44);
            txtInsuranceID.TabIndex = 3;
            // 
            // lblInsuranceWebsite
            // 
            lblInsuranceWebsite.AutoSize = true;
            lblInsuranceWebsite.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblInsuranceWebsite.Location = new Point(18, 111);
            lblInsuranceWebsite.Name = "lblInsuranceWebsite";
            lblInsuranceWebsite.Size = new Size(250, 36);
            lblInsuranceWebsite.TabIndex = 6;
            lblInsuranceWebsite.Text = "គេហទំព័រក្រុមហ៊ុនធានារ៉ាប់រង:";
            // 
            // txtInsuranceWebsite
            // 
            txtInsuranceWebsite.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtInsuranceWebsite.Location = new Point(300, 111);
            txtInsuranceWebsite.Name = "txtInsuranceWebsite";
            txtInsuranceWebsite.Size = new Size(634, 44);
            txtInsuranceWebsite.TabIndex = 13;
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
            // insuranceBindingSource
            // 
            insuranceBindingSource.DataSource = typeof(StoreRentalHelper.entities.Insurance);
            // 
            // insuranceIDDataGridViewTextBoxColumn
            // 
            insuranceIDDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            insuranceIDDataGridViewTextBoxColumn.DataPropertyName = "InsuranceID";
            insuranceIDDataGridViewTextBoxColumn.HeaderText = "InsuranceID";
            insuranceIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            insuranceIDDataGridViewTextBoxColumn.Name = "insuranceIDDataGridViewTextBoxColumn";
            insuranceIDDataGridViewTextBoxColumn.ReadOnly = true;
            insuranceIDDataGridViewTextBoxColumn.Width = 154;
            // 
            // insuranceNameDataGridViewTextBoxColumn
            // 
            insuranceNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            insuranceNameDataGridViewTextBoxColumn.DataPropertyName = "InsuranceName";
            insuranceNameDataGridViewTextBoxColumn.HeaderText = "InsuranceName";
            insuranceNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            insuranceNameDataGridViewTextBoxColumn.Name = "insuranceNameDataGridViewTextBoxColumn";
            insuranceNameDataGridViewTextBoxColumn.ReadOnly = true;
            insuranceNameDataGridViewTextBoxColumn.Width = 188;
            // 
            // insuranceWebsiteDataGridViewTextBoxColumn
            // 
            insuranceWebsiteDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            insuranceWebsiteDataGridViewTextBoxColumn.DataPropertyName = "InsuranceWebsite";
            insuranceWebsiteDataGridViewTextBoxColumn.HeaderText = "InsuranceWebsite";
            insuranceWebsiteDataGridViewTextBoxColumn.MinimumWidth = 6;
            insuranceWebsiteDataGridViewTextBoxColumn.Name = "insuranceWebsiteDataGridViewTextBoxColumn";
            insuranceWebsiteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmInsurance
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1800, 1000);
            ControlBox = true;
            Controls.Add(pnlRightSide);
            Controls.Add(pnlLeftSide);
            Controls.Add(lblTitle);
            Name = "FrmInsurance";
            Text = "ព័ត៌មានបុគ្គលិក";
            Controls.SetChildIndex(lblTitle, 0);
            Controls.SetChildIndex(pnlLeftSide, 0);
            Controls.SetChildIndex(pnlRightSide, 0);
            pnlLeftSide.ResumeLayout(false);
            pnlLeftSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInsurances).EndInit();
            ((System.ComponentModel.ISupportInitialize)supplierBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemBindingSource).EndInit();
            pnlRightSide.ResumeLayout(false);
            gbInsuranceInformation.ResumeLayout(false);
            gbInsuranceInformation.PerformLayout();
            pnlInsuranceManipulation.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)insuranceBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblSearchInsurance;
        private TextBox txtSearchInsurance;
        private Panel pnlLeftSide;
        private Panel pnlRightSide;
        private Label lblInsuranceID;
        private Label lblInsuranceWebsite;
        private TextBox txtInsuranceName;
        private Label lblInsuranceName;
        private TextBox txtInsuranceID;
        private TextBox txtInsuranceWebsite;
        private GroupBox gbInsuranceInformation;
        private Panel pnlInsuranceManipulation;
        private Button btnInsertInsurance;
        private Button btnCloseFormInsurance;
        private Button btnNewInsurance;
        private Button btnUpdateInsurance;
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
        private DataGridView dgvInsurances;
        private BindingSource itemBindingSource;
        private BindingSource supplierBindingSource;
        private DataGridViewTextBoxColumn insuranceIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn insuranceNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn insuranceWebsiteDataGridViewTextBoxColumn;
        private BindingSource insuranceBindingSource;
    }
}