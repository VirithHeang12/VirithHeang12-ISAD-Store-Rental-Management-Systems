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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            lblTitle = new Label();
            lblSearchExpenseType = new Label();
            txtSearchExpenseType = new TextBox();
            pnlLeftSide = new Panel();
            dgvExpenseTypes = new DataGridView();
            ExpenseTypeID = new DataGridViewTextBoxColumn();
            ExpenseDescription = new DataGridViewTextBoxColumn();
            pnlRightSide = new Panel();
            gbExpenseTypeInformation = new GroupBox();
            pnlExpenseTypeManipulation = new Panel();
            btnCancelExpenseType = new Button();
            btnNewExpenseType = new Button();
            btnUpdateExpenseType = new Button();
            btnInsertExpenseType = new Button();
            lblExpenseTypeID = new Label();
            txtExpenseTypeID = new TextBox();
            lblExpenseDescription = new Label();
            txtExpenseDescription = new TextBox();
            pnlLeftSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExpenseTypes).BeginInit();
            pnlRightSide.SuspendLayout();
            gbExpenseTypeInformation.SuspendLayout();
            pnlExpenseTypeManipulation.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.FromArgb(0, 28, 87);
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Khmer OS Siemreap", 20F, FontStyle.Bold, GraphicsUnit.Point);
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
            lblSearchExpenseType.Size = new Size(362, 43);
            lblSearchExpenseType.TabIndex = 1;
            lblSearchExpenseType.Text = "ស្វែងរក (ពិពណ៌នាប្រភេទចំណាយ):";
            // 
            // txtSearchExpenseType
            // 
            txtSearchExpenseType.Location = new Point(436, 11);
            txtSearchExpenseType.Name = "txtSearchExpenseType";
            txtSearchExpenseType.Size = new Size(556, 51);
            txtSearchExpenseType.TabIndex = 2;
            txtSearchExpenseType.TabStop = false;
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
            dgvExpenseTypes.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(0, 28, 87);
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvExpenseTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvExpenseTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpenseTypes.Columns.AddRange(new DataGridViewColumn[] { ExpenseTypeID, ExpenseDescription });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(0, 28, 87);
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvExpenseTypes.DefaultCellStyle = dataGridViewCellStyle8;
            dgvExpenseTypes.Location = new Point(82, 74);
            dgvExpenseTypes.Name = "dgvExpenseTypes";
            dgvExpenseTypes.ReadOnly = true;
            dgvExpenseTypes.RowHeadersWidth = 51;
            dgvExpenseTypes.RowTemplate.Height = 29;
            dgvExpenseTypes.Size = new Size(1362, 369);
            dgvExpenseTypes.TabIndex = 3;
            dgvExpenseTypes.TabStop = false;
            // 
            // ExpenseTypeID
            // 
            ExpenseTypeID.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ExpenseTypeID.DataPropertyName = "ExpenseTypeID";
            ExpenseTypeID.HeaderText = "លេខសម្គាល់ប្រភេទចំណាយ";
            ExpenseTypeID.MinimumWidth = 6;
            ExpenseTypeID.Name = "ExpenseTypeID";
            ExpenseTypeID.ReadOnly = true;
            ExpenseTypeID.Width = 201;
            // 
            // ExpenseDescription
            // 
            ExpenseDescription.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ExpenseDescription.DataPropertyName = "ExpenseDescription";
            ExpenseDescription.HeaderText = "ពិពណ៌នាប្រភេទចំណាយ";
            ExpenseDescription.MinimumWidth = 6;
            ExpenseDescription.Name = "ExpenseDescription";
            ExpenseDescription.ReadOnly = true;
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
            gbExpenseTypeInformation.Font = new Font("Khmer OS Siemreap", 11F, FontStyle.Bold, GraphicsUnit.Point);
            gbExpenseTypeInformation.Location = new Point(82, 12);
            gbExpenseTypeInformation.Name = "gbExpenseTypeInformation";
            gbExpenseTypeInformation.Size = new Size(1362, 288);
            gbExpenseTypeInformation.TabIndex = 25;
            gbExpenseTypeInformation.TabStop = false;
            gbExpenseTypeInformation.Text = "ព័ត៌មានប្រភេទចំណាយ";
            // 
            // pnlExpenseTypeManipulation
            // 
            pnlExpenseTypeManipulation.Controls.Add(btnCancelExpenseType);
            pnlExpenseTypeManipulation.Controls.Add(btnNewExpenseType);
            pnlExpenseTypeManipulation.Controls.Add(btnUpdateExpenseType);
            pnlExpenseTypeManipulation.Controls.Add(btnInsertExpenseType);
            pnlExpenseTypeManipulation.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pnlExpenseTypeManipulation.Location = new Point(18, 175);
            pnlExpenseTypeManipulation.Name = "pnlExpenseTypeManipulation";
            pnlExpenseTypeManipulation.Size = new Size(1301, 81);
            pnlExpenseTypeManipulation.TabIndex = 5;
            // 
            // btnCancelExpenseType
            // 
            btnCancelExpenseType.BackColor = Color.FromArgb(0, 28, 87);
            btnCancelExpenseType.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelExpenseType.ForeColor = Color.White;
            btnCancelExpenseType.Location = new Point(1100, 20);
            btnCancelExpenseType.Name = "btnCancelExpenseType";
            btnCancelExpenseType.Size = new Size(152, 52);
            btnCancelExpenseType.TabIndex = 3;
            btnCancelExpenseType.TabStop = false;
            btnCancelExpenseType.Text = "បោះបង់";
            btnCancelExpenseType.UseVisualStyleBackColor = false;
            // 
            // btnNewExpenseType
            // 
            btnNewExpenseType.BackColor = Color.FromArgb(0, 28, 87);
            btnNewExpenseType.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNewExpenseType.ForeColor = Color.White;
            btnNewExpenseType.Location = new Point(740, 20);
            btnNewExpenseType.Name = "btnNewExpenseType";
            btnNewExpenseType.Size = new Size(152, 52);
            btnNewExpenseType.TabIndex = 2;
            btnNewExpenseType.TabStop = false;
            btnNewExpenseType.Text = "បង្កើតថ្មី";
            btnNewExpenseType.UseVisualStyleBackColor = false;
            // 
            // btnUpdateExpenseType
            // 
            btnUpdateExpenseType.BackColor = Color.FromArgb(0, 28, 87);
            btnUpdateExpenseType.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateExpenseType.ForeColor = Color.White;
            btnUpdateExpenseType.Location = new Point(380, 20);
            btnUpdateExpenseType.Name = "btnUpdateExpenseType";
            btnUpdateExpenseType.Size = new Size(152, 52);
            btnUpdateExpenseType.TabIndex = 1;
            btnUpdateExpenseType.TabStop = false;
            btnUpdateExpenseType.Text = "កែប្រែ";
            btnUpdateExpenseType.UseVisualStyleBackColor = false;
            // 
            // btnInsertExpenseType
            // 
            btnInsertExpenseType.BackColor = Color.FromArgb(0, 28, 87);
            btnInsertExpenseType.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsertExpenseType.ForeColor = Color.White;
            btnInsertExpenseType.Location = new Point(20, 20);
            btnInsertExpenseType.Name = "btnInsertExpenseType";
            btnInsertExpenseType.Size = new Size(152, 52);
            btnInsertExpenseType.TabIndex = 0;
            btnInsertExpenseType.TabStop = false;
            btnInsertExpenseType.Text = "បញ្ចូល";
            btnInsertExpenseType.UseVisualStyleBackColor = false;
            // 
            // lblExpenseTypeID
            // 
            lblExpenseTypeID.AutoSize = true;
            lblExpenseTypeID.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblExpenseTypeID.Location = new Point(18, 41);
            lblExpenseTypeID.Name = "lblExpenseTypeID";
            lblExpenseTypeID.Size = new Size(287, 43);
            lblExpenseTypeID.TabIndex = 0;
            lblExpenseTypeID.Text = "លេខសម្គាល់ប្រភេទចំណាយ:";
            // 
            // txtExpenseTypeID
            // 
            txtExpenseTypeID.Enabled = false;
            txtExpenseTypeID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtExpenseTypeID.Location = new Point(300, 33);
            txtExpenseTypeID.Name = "txtExpenseTypeID";
            txtExpenseTypeID.Size = new Size(363, 35);
            txtExpenseTypeID.TabIndex = 3;
            // 
            // lblExpenseDescription
            // 
            lblExpenseDescription.AutoSize = true;
            lblExpenseDescription.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblExpenseDescription.Location = new Point(18, 111);
            lblExpenseDescription.Name = "lblExpenseDescription";
            lblExpenseDescription.Size = new Size(258, 43);
            lblExpenseDescription.TabIndex = 6;
            lblExpenseDescription.Text = "ពិព័ណ៌នាប្រភេទចំណាយ:";
            // 
            // txtExpenseDescription
            // 
            txtExpenseDescription.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtExpenseDescription.Location = new Point(300, 111);
            txtExpenseDescription.Name = "txtExpenseDescription";
            txtExpenseDescription.Size = new Size(970, 35);
            txtExpenseDescription.TabIndex = 13;
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
            pnlRightSide.ResumeLayout(false);
            gbExpenseTypeInformation.ResumeLayout(false);
            gbExpenseTypeInformation.PerformLayout();
            pnlExpenseTypeManipulation.ResumeLayout(false);
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
        private Button btnCancelExpenseType;
        private Button btnNewExpenseType;
        private Button btnUpdateExpenseType;
        private DataGridView dgvExpenseTypes;
        private DataGridViewTextBoxColumn expenseTypeIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn expenseDescriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ExpenseTypeID;
        private DataGridViewTextBoxColumn ExpenseDescription;
    }
}
