namespace Store_Rental_Management_Systems
{
    partial class FrmStoreType
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
            lblSearchStoreType = new Label();
            txtSearchStoreType = new TextBox();
            pnlLeftSide = new Panel();
            dataItems = new DataGridView();
            storeTypeBindingSource = new BindingSource(components);
            supplierBindingSource = new BindingSource(components);
            itemBindingSource = new BindingSource(components);
            pnlRightSide = new Panel();
            gbStoreTypeInformation = new GroupBox();
            txtOneYearPaymentDiscount = new TextBox();
            lblOneYearPaymentDiscount = new Label();
            pnlStaffManipulation = new Panel();
            btnCloseFormStoreType = new Button();
            btnNewStoreType = new Button();
            btnUpdateStoreType = new Button();
            btnInsertStoreType = new Button();
            lblSixMonthPaymentDiscount = new Label();
            lblStoreTypeID = new Label();
            txtMonthlyLeasePrice = new TextBox();
            lblMonthlyLeasePrice = new Label();
            txtStoreTypeID = new TextBox();
            lblThreeMonthPaymentDiscount = new Label();
            txtSixMonthPaymentDiscount = new TextBox();
            txtThreeMonthPaymentDiscount = new TextBox();
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
            storeTypeIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            storeTypeDescriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            threeMonthPaymentDiscountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sixMonthPaymentDiscountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            oneYearPaymentDiscountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pnlLeftSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)storeTypeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)supplierBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemBindingSource).BeginInit();
            pnlRightSide.SuspendLayout();
            gbStoreTypeInformation.SuspendLayout();
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
            lblTitle.Text = "ព័ត៌មានប្រភេទតូប";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSearchStoreType
            // 
            lblSearchStoreType.AutoSize = true;
            lblSearchStoreType.Location = new Point(82, 25);
            lblSearchStoreType.Name = "lblSearchStoreType";
            lblSearchStoreType.Size = new Size(291, 36);
            lblSearchStoreType.TabIndex = 1;
            lblSearchStoreType.Text = "ស្វែងរក (លេខសម្គាល់ប្រភេទតូប):";
            // 
            // txtSearchStoreType
            // 
            txtSearchStoreType.Location = new Point(495, 17);
            txtSearchStoreType.Name = "txtSearchStoreType";
            txtSearchStoreType.Size = new Size(445, 44);
            txtSearchStoreType.TabIndex = 2;
            // 
            // pnlLeftSide
            // 
            pnlLeftSide.Controls.Add(dataItems);
            pnlLeftSide.Controls.Add(lblSearchStoreType);
            pnlLeftSide.Controls.Add(txtSearchStoreType);
            pnlLeftSide.Location = new Point(266, 537);
            pnlLeftSide.Name = "pnlLeftSide";
            pnlLeftSide.Size = new Size(1534, 463);
            pnlLeftSide.TabIndex = 3;
            // 
            // dataItems
            // 
            dataItems.AllowUserToAddRows = false;
            dataItems.AllowUserToDeleteRows = false;
            dataItems.AutoGenerateColumns = false;
            dataItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataItems.Columns.AddRange(new DataGridViewColumn[] { storeTypeIDDataGridViewTextBoxColumn, storeTypeDescriptionDataGridViewTextBoxColumn, threeMonthPaymentDiscountDataGridViewTextBoxColumn, sixMonthPaymentDiscountDataGridViewTextBoxColumn, oneYearPaymentDiscountDataGridViewTextBoxColumn });
            dataItems.DataSource = storeTypeBindingSource;
            dataItems.Location = new Point(82, 81);
            dataItems.Name = "dataItems";
            dataItems.ReadOnly = true;
            dataItems.RowHeadersWidth = 51;
            dataItems.RowTemplate.Height = 29;
            dataItems.Size = new Size(1397, 337);
            dataItems.TabIndex = 3;
            // 
            // storeTypeBindingSource
            // 
            storeTypeBindingSource.DataSource = typeof(StoreRentalHelper.entities.StoreType);
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
            pnlRightSide.Controls.Add(gbStoreTypeInformation);
            pnlRightSide.Location = new Point(266, 184);
            pnlRightSide.Name = "pnlRightSide";
            pnlRightSide.Size = new Size(1534, 347);
            pnlRightSide.TabIndex = 4;
            // 
            // gbStoreTypeInformation
            // 
            gbStoreTypeInformation.Controls.Add(txtOneYearPaymentDiscount);
            gbStoreTypeInformation.Controls.Add(lblOneYearPaymentDiscount);
            gbStoreTypeInformation.Controls.Add(pnlStaffManipulation);
            gbStoreTypeInformation.Controls.Add(lblSixMonthPaymentDiscount);
            gbStoreTypeInformation.Controls.Add(lblStoreTypeID);
            gbStoreTypeInformation.Controls.Add(txtMonthlyLeasePrice);
            gbStoreTypeInformation.Controls.Add(lblMonthlyLeasePrice);
            gbStoreTypeInformation.Controls.Add(txtStoreTypeID);
            gbStoreTypeInformation.Controls.Add(lblThreeMonthPaymentDiscount);
            gbStoreTypeInformation.Controls.Add(txtSixMonthPaymentDiscount);
            gbStoreTypeInformation.Controls.Add(txtThreeMonthPaymentDiscount);
            gbStoreTypeInformation.Font = new Font("Khmer OS Siemreap", 10F, FontStyle.Bold, GraphicsUnit.Point);
            gbStoreTypeInformation.Location = new Point(82, 12);
            gbStoreTypeInformation.Name = "gbStoreTypeInformation";
            gbStoreTypeInformation.Size = new Size(1397, 319);
            gbStoreTypeInformation.TabIndex = 25;
            gbStoreTypeInformation.TabStop = false;
            gbStoreTypeInformation.Text = "ព័ត៌មានប្រភេទតូប";
            // 
            // txtOneYearPaymentDiscount
            // 
            txtOneYearPaymentDiscount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtOneYearPaymentDiscount.Location = new Point(309, 179);
            txtOneYearPaymentDiscount.Name = "txtOneYearPaymentDiscount";
            txtOneYearPaymentDiscount.Size = new Size(354, 44);
            txtOneYearPaymentDiscount.TabIndex = 29;
            // 
            // lblOneYearPaymentDiscount
            // 
            lblOneYearPaymentDiscount.AutoSize = true;
            lblOneYearPaymentDiscount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblOneYearPaymentDiscount.Location = new Point(18, 182);
            lblOneYearPaymentDiscount.Name = "lblOneYearPaymentDiscount";
            lblOneYearPaymentDiscount.Size = new Size(229, 36);
            lblOneYearPaymentDiscount.TabIndex = 28;
            lblOneYearPaymentDiscount.Text = "អត្រាបញ្ចុះតម្លៃបង់ម្ដង១ឆ្នាំ:";
            // 
            // pnlStaffManipulation
            // 
            pnlStaffManipulation.Controls.Add(btnCloseFormStoreType);
            pnlStaffManipulation.Controls.Add(btnNewStoreType);
            pnlStaffManipulation.Controls.Add(btnUpdateStoreType);
            pnlStaffManipulation.Controls.Add(btnInsertStoreType);
            pnlStaffManipulation.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pnlStaffManipulation.Location = new Point(18, 232);
            pnlStaffManipulation.Name = "pnlStaffManipulation";
            pnlStaffManipulation.Size = new Size(1301, 81);
            pnlStaffManipulation.TabIndex = 5;
            // 
            // btnCloseFormStoreType
            // 
            btnCloseFormStoreType.BackColor = Color.FromArgb(0, 28, 87);
            btnCloseFormStoreType.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCloseFormStoreType.ForeColor = Color.WhiteSmoke;
            btnCloseFormStoreType.Location = new Point(1102, 20);
            btnCloseFormStoreType.Name = "btnCloseFormStoreType";
            btnCloseFormStoreType.Size = new Size(152, 52);
            btnCloseFormStoreType.TabIndex = 3;
            btnCloseFormStoreType.Text = "បិទ";
            btnCloseFormStoreType.UseVisualStyleBackColor = false;
            // 
            // btnNewStoreType
            // 
            btnNewStoreType.BackColor = Color.FromArgb(0, 28, 87);
            btnNewStoreType.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNewStoreType.ForeColor = Color.White;
            btnNewStoreType.Location = new Point(774, 20);
            btnNewStoreType.Name = "btnNewStoreType";
            btnNewStoreType.Size = new Size(152, 52);
            btnNewStoreType.TabIndex = 2;
            btnNewStoreType.Text = "បង្កើតថ្មី";
            btnNewStoreType.UseVisualStyleBackColor = false;
            // 
            // btnUpdateStoreType
            // 
            btnUpdateStoreType.BackColor = Color.FromArgb(0, 28, 87);
            btnUpdateStoreType.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateStoreType.ForeColor = Color.White;
            btnUpdateStoreType.Location = new Point(411, 20);
            btnUpdateStoreType.Name = "btnUpdateStoreType";
            btnUpdateStoreType.Size = new Size(152, 52);
            btnUpdateStoreType.TabIndex = 1;
            btnUpdateStoreType.Text = "កែប្រែ";
            btnUpdateStoreType.UseVisualStyleBackColor = false;
            // 
            // btnInsertStoreType
            // 
            btnInsertStoreType.BackColor = Color.FromArgb(0, 28, 87);
            btnInsertStoreType.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsertStoreType.ForeColor = Color.White;
            btnInsertStoreType.Location = new Point(20, 20);
            btnInsertStoreType.Name = "btnInsertStoreType";
            btnInsertStoreType.Size = new Size(152, 52);
            btnInsertStoreType.TabIndex = 0;
            btnInsertStoreType.Text = "បញ្ចូល";
            btnInsertStoreType.UseVisualStyleBackColor = false;
            // 
            // lblSixMonthPaymentDiscount
            // 
            lblSixMonthPaymentDiscount.AutoSize = true;
            lblSixMonthPaymentDiscount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSixMonthPaymentDiscount.Location = new Point(711, 111);
            lblSixMonthPaymentDiscount.Name = "lblSixMonthPaymentDiscount";
            lblSixMonthPaymentDiscount.Size = new Size(229, 36);
            lblSixMonthPaymentDiscount.TabIndex = 27;
            lblSixMonthPaymentDiscount.Text = "អត្រាបញ្ចុះតម្លៃបង់ម្ដង៦ខែ:";
            // 
            // lblStoreTypeID
            // 
            lblStoreTypeID.AutoSize = true;
            lblStoreTypeID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStoreTypeID.Location = new Point(18, 41);
            lblStoreTypeID.Name = "lblStoreTypeID";
            lblStoreTypeID.Size = new Size(203, 36);
            lblStoreTypeID.TabIndex = 0;
            lblStoreTypeID.Text = "លេខសម្គាល់ប្រភេទតូប:";
            // 
            // txtMonthlyLeasePrice
            // 
            txtMonthlyLeasePrice.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMonthlyLeasePrice.Location = new Point(977, 33);
            txtMonthlyLeasePrice.Name = "txtMonthlyLeasePrice";
            txtMonthlyLeasePrice.Size = new Size(342, 44);
            txtMonthlyLeasePrice.TabIndex = 5;
            // 
            // lblMonthlyLeasePrice
            // 
            lblMonthlyLeasePrice.AutoSize = true;
            lblMonthlyLeasePrice.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMonthlyLeasePrice.Location = new Point(711, 41);
            lblMonthlyLeasePrice.Name = "lblMonthlyLeasePrice";
            lblMonthlyLeasePrice.Size = new Size(135, 36);
            lblMonthlyLeasePrice.TabIndex = 4;
            lblMonthlyLeasePrice.Text = "ថ្លៃជួលប្រចាំខែ:";
            // 
            // txtStoreTypeID
            // 
            txtStoreTypeID.Enabled = false;
            txtStoreTypeID.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStoreTypeID.Location = new Point(309, 33);
            txtStoreTypeID.Name = "txtStoreTypeID";
            txtStoreTypeID.Size = new Size(354, 44);
            txtStoreTypeID.TabIndex = 3;
            // 
            // lblThreeMonthPaymentDiscount
            // 
            lblThreeMonthPaymentDiscount.AutoSize = true;
            lblThreeMonthPaymentDiscount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblThreeMonthPaymentDiscount.Location = new Point(18, 111);
            lblThreeMonthPaymentDiscount.Name = "lblThreeMonthPaymentDiscount";
            lblThreeMonthPaymentDiscount.Size = new Size(232, 36);
            lblThreeMonthPaymentDiscount.TabIndex = 6;
            lblThreeMonthPaymentDiscount.Text = "អត្រាបញ្ចុះតម្លៃបង់ម្ដង៣ខែ:";
            // 
            // txtSixMonthPaymentDiscount
            // 
            txtSixMonthPaymentDiscount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSixMonthPaymentDiscount.Location = new Point(977, 103);
            txtSixMonthPaymentDiscount.Name = "txtSixMonthPaymentDiscount";
            txtSixMonthPaymentDiscount.Size = new Size(342, 44);
            txtSixMonthPaymentDiscount.TabIndex = 7;
            // 
            // txtThreeMonthPaymentDiscount
            // 
            txtThreeMonthPaymentDiscount.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtThreeMonthPaymentDiscount.Location = new Point(309, 103);
            txtThreeMonthPaymentDiscount.Name = "txtThreeMonthPaymentDiscount";
            txtThreeMonthPaymentDiscount.Size = new Size(354, 44);
            txtThreeMonthPaymentDiscount.TabIndex = 13;
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
            // storeTypeIDDataGridViewTextBoxColumn
            // 
            storeTypeIDDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            storeTypeIDDataGridViewTextBoxColumn.DataPropertyName = "StoreTypeID";
            storeTypeIDDataGridViewTextBoxColumn.HeaderText = "លេខសម្គាល់ប្រភេទតូប";
            storeTypeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            storeTypeIDDataGridViewTextBoxColumn.Name = "storeTypeIDDataGridViewTextBoxColumn";
            storeTypeIDDataGridViewTextBoxColumn.ReadOnly = true;
            storeTypeIDDataGridViewTextBoxColumn.Width = 226;
            // 
            // storeTypeDescriptionDataGridViewTextBoxColumn
            // 
            storeTypeDescriptionDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            storeTypeDescriptionDataGridViewTextBoxColumn.DataPropertyName = "StoreTypeDescription";
            storeTypeDescriptionDataGridViewTextBoxColumn.HeaderText = "ថ្លៃជួលប្រចាំខែ";
            storeTypeDescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            storeTypeDescriptionDataGridViewTextBoxColumn.Name = "storeTypeDescriptionDataGridViewTextBoxColumn";
            storeTypeDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // threeMonthPaymentDiscountDataGridViewTextBoxColumn
            // 
            threeMonthPaymentDiscountDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            threeMonthPaymentDiscountDataGridViewTextBoxColumn.DataPropertyName = "ThreeMonthPaymentDiscount";
            threeMonthPaymentDiscountDataGridViewTextBoxColumn.HeaderText = "អត្រាបញ្ចុះតម្លៃបង់ម្ដង៣ខែ";
            threeMonthPaymentDiscountDataGridViewTextBoxColumn.MinimumWidth = 6;
            threeMonthPaymentDiscountDataGridViewTextBoxColumn.Name = "threeMonthPaymentDiscountDataGridViewTextBoxColumn";
            threeMonthPaymentDiscountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sixMonthPaymentDiscountDataGridViewTextBoxColumn
            // 
            sixMonthPaymentDiscountDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            sixMonthPaymentDiscountDataGridViewTextBoxColumn.DataPropertyName = "SixMonthPaymentDiscount";
            sixMonthPaymentDiscountDataGridViewTextBoxColumn.HeaderText = "អត្រាបញ្ចុះតម្លៃបង់ម្ដង៦ខែ";
            sixMonthPaymentDiscountDataGridViewTextBoxColumn.MinimumWidth = 6;
            sixMonthPaymentDiscountDataGridViewTextBoxColumn.Name = "sixMonthPaymentDiscountDataGridViewTextBoxColumn";
            sixMonthPaymentDiscountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oneYearPaymentDiscountDataGridViewTextBoxColumn
            // 
            oneYearPaymentDiscountDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            oneYearPaymentDiscountDataGridViewTextBoxColumn.DataPropertyName = "OneYearPaymentDiscount";
            oneYearPaymentDiscountDataGridViewTextBoxColumn.HeaderText = "អត្រាបញ្ចុះតម្លៃបង់ម្ដង១ឆ្នាំ";
            oneYearPaymentDiscountDataGridViewTextBoxColumn.MinimumWidth = 6;
            oneYearPaymentDiscountDataGridViewTextBoxColumn.Name = "oneYearPaymentDiscountDataGridViewTextBoxColumn";
            oneYearPaymentDiscountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmStoreType
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1800, 1000);
            ControlBox = true;
            Controls.Add(pnlRightSide);
            Controls.Add(pnlLeftSide);
            Controls.Add(lblTitle);
            Name = "FrmStoreType";
            Text = "ព័ត៌មានបុគ្គលិក";
            Controls.SetChildIndex(lblTitle, 0);
            Controls.SetChildIndex(pnlLeftSide, 0);
            Controls.SetChildIndex(pnlRightSide, 0);
            pnlLeftSide.ResumeLayout(false);
            pnlLeftSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)storeTypeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)supplierBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemBindingSource).EndInit();
            pnlRightSide.ResumeLayout(false);
            gbStoreTypeInformation.ResumeLayout(false);
            gbStoreTypeInformation.PerformLayout();
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
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblSearchStoreType;
        private TextBox txtSearchStoreType;
        private Panel pnlLeftSide;
        private Panel pnlRightSide;
        private Label lblStoreTypeID;
        private TextBox txtSixMonthPaymentDiscount;
        private Label lblThreeMonthPaymentDiscount;
        private TextBox txtMonthlyLeasePrice;
        private Label lblMonthlyLeasePrice;
        private TextBox txtStoreTypeID;
        private Label lblStockQty;
        private TextBox txtThreeMonthPaymentDiscount;
        private Label lblUnitPrice;
        private GroupBox gbStoreTypeInformation;
        private Panel pnlStaffManipulation;
        private Button btnInsertStoreType;
        private Button btnCloseFormStoreType;
        private Button btnNewStoreType;
        private Button btnUpdateStoreType;
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
        private Label lblSixMonthPaymentDiscount;
        private DataGridView dataItems;
        private BindingSource itemBindingSource;
        private BindingSource supplierBindingSource;
        private TextBox txtOneYearPaymentDiscount;
        private Label lblOneYearPaymentDiscount;
        private BindingSource storeTypeBindingSource;
        private DataGridViewTextBoxColumn storeTypeIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn storeTypeDescriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn threeMonthPaymentDiscountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sixMonthPaymentDiscountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn oneYearPaymentDiscountDataGridViewTextBoxColumn;
    }
}