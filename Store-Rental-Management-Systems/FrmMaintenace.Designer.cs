using Microsoft.IdentityModel.Tokens;

namespace Store_Rental_Management_Systems
{
    partial class FrmMaintenace
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
            lbMaintenace = new Label();
            pnTop = new Panel();
            btnClose = new Button();
            btnCancel = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnUpdate = new Button();
            btnInsert = new Button();
            pnSearchMtn = new Panel();
            pnSearchbox = new Panel();
            txtSearch = new TextBox();
            lbSearch = new Label();
            pnDetailMtn = new Panel();
            txtDescription = new TextBox();
            lbDescription = new Label();
            txtAmount = new TextBox();
            lbAmount = new Label();
            txtQuantity = new TextBox();
            lbQuantity = new Label();
            txtUnitPrice = new TextBox();
            lbUnitPriceItem = new Label();
            txtItemID = new TextBox();
            lbItemID = new Label();
            txtMaintenaceID = new TextBox();
            labelMtnID = new Label();
            txtDetailMtn = new TextBox();
            DetailIDMtn = new Label();
            lbDetailMtn = new Label();
            txtStoreID = new TextBox();
            lbStoreID = new Label();
            txtOwnedAmountMtn = new TextBox();
            lbOwnedAmountMtn = new Label();
            txtPaidAmountMtn = new TextBox();
            lbPaidAmountMtn = new Label();
            txtContractID = new TextBox();
            lbContractID = new Label();
            dateMtn = new DateTimePicker();
            lbDateMtn = new Label();
            txtTotalMtn = new TextBox();
            lbTotalMtn = new Label();
            txtMtnID = new TextBox();
            lbMtnID = new Label();
            pnBackTopMtn = new Panel();
            pnTop.SuspendLayout();
            pnSearchMtn.SuspendLayout();
            pnDetailMtn.SuspendLayout();
            SuspendLayout();
            // 
            // lbMaintenace
            // 
            lbMaintenace.BackColor = SystemColors.HotTrack;
            lbMaintenace.BorderStyle = BorderStyle.Fixed3D;
            lbMaintenace.Dock = DockStyle.Top;
            lbMaintenace.Font = new Font("Khmer Muol", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbMaintenace.ForeColor = SystemColors.ControlLightLight;
            lbMaintenace.Location = new Point(0, 0);
            lbMaintenace.Name = "lbMaintenace";
            lbMaintenace.Size = new Size(1782, 59);
            lbMaintenace.TabIndex = 0;
            lbMaintenace.Text = "ព័ត៌មាននៃការថែទាំ";
            lbMaintenace.TextAlign = ContentAlignment.MiddleCenter;
            lbMaintenace.Click += lbMaintenace_Click;
            // 
            // pnTop
            // 
            pnTop.AutoSize = true;
            pnTop.BackColor = SystemColors.ControlLight;
            pnTop.BorderStyle = BorderStyle.Fixed3D;
            pnTop.Controls.Add(btnClose);
            pnTop.Controls.Add(btnCancel);
            pnTop.Controls.Add(btnDelete);
            pnTop.Controls.Add(btnClear);
            pnTop.Controls.Add(btnUpdate);
            pnTop.Controls.Add(btnInsert);
            pnTop.Controls.Add(pnSearchMtn);
            pnTop.Controls.Add(pnDetailMtn);
            pnTop.Controls.Add(txtStoreID);
            pnTop.Controls.Add(lbStoreID);
            pnTop.Controls.Add(txtOwnedAmountMtn);
            pnTop.Controls.Add(lbOwnedAmountMtn);
            pnTop.Controls.Add(txtPaidAmountMtn);
            pnTop.Controls.Add(lbPaidAmountMtn);
            pnTop.Controls.Add(txtContractID);
            pnTop.Controls.Add(lbContractID);
            pnTop.Controls.Add(dateMtn);
            pnTop.Controls.Add(lbDateMtn);
            pnTop.Controls.Add(txtTotalMtn);
            pnTop.Controls.Add(lbTotalMtn);
            pnTop.Controls.Add(txtMtnID);
            pnTop.Controls.Add(lbMtnID);
            pnTop.Controls.Add(pnBackTopMtn);
            pnTop.Dock = DockStyle.Fill;
            pnTop.Location = new Point(0, 0);
            pnTop.Name = "pnTop";
            pnTop.Size = new Size(1782, 953);
            pnTop.TabIndex = 1;
            pnTop.Paint += pnTop_Paint;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.Font = new Font("Khmer OS Siemreap", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = SystemColors.ControlLightLight;
            btnClose.Location = new Point(1647, 887);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(121, 52);
            btnClose.TabIndex = 22;
            btnClose.Text = "បិទ";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.ForestGreen;
            btnCancel.Font = new Font("Khmer OS Siemreap", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = SystemColors.ControlLightLight;
            btnCancel.Location = new Point(1523, 887);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(121, 52);
            btnCancel.TabIndex = 21;
            btnCancel.Text = "ត្រឡប់";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Khmer OS Siemreap", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.ControlLightLight;
            btnDelete.Location = new Point(1037, 833);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(121, 52);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "លុប";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.MenuHighlight;
            btnClear.Font = new Font("Khmer OS Siemreap", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = SystemColors.ControlLightLight;
            btnClear.Location = new Point(865, 833);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(121, 52);
            btnClear.TabIndex = 19;
            btnClear.Text = "សម្អាត";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.MenuHighlight;
            btnUpdate.Font = new Font("Khmer OS Siemreap", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = SystemColors.ControlLightLight;
            btnUpdate.Location = new Point(696, 833);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(121, 52);
            btnUpdate.TabIndex = 18;
            btnUpdate.Text = "កែប្រែ";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = SystemColors.MenuHighlight;
            btnInsert.Font = new Font("Khmer OS Siemreap", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsert.ForeColor = SystemColors.ControlLightLight;
            btnInsert.Location = new Point(525, 833);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(121, 52);
            btnInsert.TabIndex = 17;
            btnInsert.Text = "បញ្ចូល";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += button2_Click;
            // 
            // pnSearchMtn
            // 
            pnSearchMtn.BackColor = SystemColors.ControlLightLight;
            pnSearchMtn.BorderStyle = BorderStyle.Fixed3D;
            pnSearchMtn.Controls.Add(pnSearchbox);
            pnSearchMtn.Controls.Add(txtSearch);
            pnSearchMtn.Controls.Add(lbSearch);
            pnSearchMtn.Location = new Point(1311, 309);
            pnSearchMtn.Name = "pnSearchMtn";
            pnSearchMtn.Size = new Size(457, 496);
            pnSearchMtn.TabIndex = 16;
            // 
            // pnSearchbox
            // 
            pnSearchbox.BackColor = SystemColors.ControlLight;
            pnSearchbox.BorderStyle = BorderStyle.Fixed3D;
            pnSearchbox.Location = new Point(31, 82);
            pnSearchbox.Name = "pnSearchbox";
            pnSearchbox.Size = new Size(400, 384);
            pnSearchbox.TabIndex = 19;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.Menu;
            txtSearch.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(106, 27);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(321, 44);
            txtSearch.TabIndex = 18;
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.BackColor = SystemColors.ControlLightLight;
            lbSearch.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbSearch.Location = new Point(24, 31);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new Size(87, 36);
            lbSearch.TabIndex = 17;
            lbSearch.Text = "ស្វែងរក:";
            // 
            // pnDetailMtn
            // 
            pnDetailMtn.BackColor = SystemColors.GradientInactiveCaption;
            pnDetailMtn.BorderStyle = BorderStyle.Fixed3D;
            pnDetailMtn.Controls.Add(txtDescription);
            pnDetailMtn.Controls.Add(lbDescription);
            pnDetailMtn.Controls.Add(txtAmount);
            pnDetailMtn.Controls.Add(lbAmount);
            pnDetailMtn.Controls.Add(txtQuantity);
            pnDetailMtn.Controls.Add(lbQuantity);
            pnDetailMtn.Controls.Add(txtUnitPrice);
            pnDetailMtn.Controls.Add(lbUnitPriceItem);
            pnDetailMtn.Controls.Add(txtItemID);
            pnDetailMtn.Controls.Add(lbItemID);
            pnDetailMtn.Controls.Add(txtMaintenaceID);
            pnDetailMtn.Controls.Add(labelMtnID);
            pnDetailMtn.Controls.Add(txtDetailMtn);
            pnDetailMtn.Controls.Add(DetailIDMtn);
            pnDetailMtn.Controls.Add(lbDetailMtn);
            pnDetailMtn.ForeColor = SystemColors.ActiveCaptionText;
            pnDetailMtn.Location = new Point(46, 309);
            pnDetailMtn.Name = "pnDetailMtn";
            pnDetailMtn.Size = new Size(1244, 496);
            pnDetailMtn.TabIndex = 15;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescription.Location = new Point(916, 308);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(259, 127);
            txtDescription.TabIndex = 28;
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.BackColor = SystemColors.GradientInactiveCaption;
            lbDescription.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbDescription.ForeColor = SystemColors.ActiveCaptionText;
            lbDescription.Location = new Point(721, 311);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(187, 36);
            lbDescription.TabIndex = 27;
            lbDescription.Text = "ពណ៌នាបន្ថែម       :";
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAmount.Location = new Point(916, 223);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(259, 44);
            txtAmount.TabIndex = 26;
            // 
            // lbAmount
            // 
            lbAmount.AutoSize = true;
            lbAmount.BackColor = SystemColors.GradientInactiveCaption;
            lbAmount.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbAmount.ForeColor = SystemColors.ActiveCaptionText;
            lbAmount.Location = new Point(722, 226);
            lbAmount.Name = "lbAmount";
            lbAmount.Size = new Size(188, 36);
            lbAmount.TabIndex = 25;
            lbAmount.Text = "ចំនួនសម្ភារៈ         :";
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuantity.Location = new Point(916, 139);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(259, 44);
            txtQuantity.TabIndex = 24;
            // 
            // lbQuantity
            // 
            lbQuantity.AutoSize = true;
            lbQuantity.BackColor = SystemColors.GradientInactiveCaption;
            lbQuantity.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbQuantity.ForeColor = SystemColors.ActiveCaptionText;
            lbQuantity.Location = new Point(718, 142);
            lbQuantity.Name = "lbQuantity";
            lbQuantity.Size = new Size(193, 36);
            lbQuantity.TabIndex = 23;
            lbQuantity.Text = "បរិមាណសម្ភារៈ      :";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUnitPrice.Location = new Point(282, 391);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(259, 44);
            txtUnitPrice.TabIndex = 22;
            // 
            // lbUnitPriceItem
            // 
            lbUnitPriceItem.AutoSize = true;
            lbUnitPriceItem.BackColor = SystemColors.GradientInactiveCaption;
            lbUnitPriceItem.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbUnitPriceItem.Location = new Point(37, 394);
            lbUnitPriceItem.Name = "lbUnitPriceItem";
            lbUnitPriceItem.Size = new Size(244, 36);
            lbUnitPriceItem.TabIndex = 21;
            lbUnitPriceItem.Text = "តម្លៃនាំចូលសម្ភារៈ          :";
            // 
            // txtItemID
            // 
            txtItemID.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtItemID.Location = new Point(282, 308);
            txtItemID.Name = "txtItemID";
            txtItemID.Size = new Size(259, 44);
            txtItemID.TabIndex = 20;
            // 
            // lbItemID
            // 
            lbItemID.AutoSize = true;
            lbItemID.BackColor = SystemColors.GradientInactiveCaption;
            lbItemID.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbItemID.Location = new Point(37, 311);
            lbItemID.Name = "lbItemID";
            lbItemID.Size = new Size(242, 36);
            lbItemID.TabIndex = 19;
            lbItemID.Text = "លេខសម្គាល់សម្ភារៈ        ​​:\r\n";
            // 
            // txtMaintenaceID
            // 
            txtMaintenaceID.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaintenaceID.Location = new Point(282, 223);
            txtMaintenaceID.Name = "txtMaintenaceID";
            txtMaintenaceID.Size = new Size(259, 44);
            txtMaintenaceID.TabIndex = 18;
            txtMaintenaceID.TextChanged += txtMaintenaceID_TextChanged;
            // 
            // labelMtnID
            // 
            labelMtnID.AutoSize = true;
            labelMtnID.BackColor = SystemColors.GradientInactiveCaption;
            labelMtnID.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelMtnID.Location = new Point(36, 226);
            labelMtnID.Name = "labelMtnID";
            labelMtnID.Size = new Size(241, 36);
            labelMtnID.TabIndex = 17;
            labelMtnID.Text = "លេខសម្គាល់ការថែទាំ      :\r\n";
            // 
            // txtDetailMtn
            // 
            txtDetailMtn.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDetailMtn.Location = new Point(282, 139);
            txtDetailMtn.Name = "txtDetailMtn";
            txtDetailMtn.Size = new Size(259, 44);
            txtDetailMtn.TabIndex = 18;
            txtDetailMtn.TextChanged += textBox1_TextChanged_1;
            // 
            // DetailIDMtn
            // 
            DetailIDMtn.AutoSize = true;
            DetailIDMtn.BackColor = SystemColors.GradientInactiveCaption;
            DetailIDMtn.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DetailIDMtn.ForeColor = SystemColors.ActiveCaptionText;
            DetailIDMtn.Location = new Point(36, 142);
            DetailIDMtn.Name = "DetailIDMtn";
            DetailIDMtn.Size = new Size(246, 36);
            DetailIDMtn.TabIndex = 17;
            DetailIDMtn.Text = "លេខសម្គាល់ព័ត៌មានបន្ថែម:";
            DetailIDMtn.Click += label2_Click_1;
            // 
            // lbDetailMtn
            // 
            lbDetailMtn.BackColor = SystemColors.HotTrack;
            lbDetailMtn.BorderStyle = BorderStyle.Fixed3D;
            lbDetailMtn.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbDetailMtn.ForeColor = SystemColors.ButtonHighlight;
            lbDetailMtn.Location = new Point(-1, 0);
            lbDetailMtn.Name = "lbDetailMtn";
            lbDetailMtn.Size = new Size(1244, 46);
            lbDetailMtn.TabIndex = 2;
            lbDetailMtn.Text = "ព័ត៌មានបន្ថែមនៃការថែទាំ";
            lbDetailMtn.TextAlign = ContentAlignment.MiddleCenter;
            lbDetailMtn.Click += lbDetailMtn_Click;
            // 
            // txtStoreID
            // 
            txtStoreID.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStoreID.Location = new Point(1158, 118);
            txtStoreID.Name = "txtStoreID";
            txtStoreID.Size = new Size(233, 44);
            txtStoreID.TabIndex = 13;
            txtStoreID.TextChanged += textBox1_TextChanged;
            // 
            // lbStoreID
            // 
            lbStoreID.AutoSize = true;
            lbStoreID.BackColor = SystemColors.GradientInactiveCaption;
            lbStoreID.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbStoreID.Location = new Point(1000, 123);
            lbStoreID.Name = "lbStoreID";
            lbStoreID.Size = new Size(158, 36);
            lbStoreID.TabIndex = 12;
            lbStoreID.Text = "លេខសម្គាល់តូប:";
            lbStoreID.Click += lbStoreID_Click;
            // 
            // txtOwnedAmountMtn
            // 
            txtOwnedAmountMtn.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtOwnedAmountMtn.Location = new Point(1437, 191);
            txtOwnedAmountMtn.Name = "txtOwnedAmountMtn";
            txtOwnedAmountMtn.Size = new Size(274, 44);
            txtOwnedAmountMtn.TabIndex = 11;
            txtOwnedAmountMtn.TextChanged += txtOwnedAmountMtn_TextChanged;
            // 
            // lbOwnedAmountMtn
            // 
            lbOwnedAmountMtn.AutoSize = true;
            lbOwnedAmountMtn.BackColor = SystemColors.GradientInactiveCaption;
            lbOwnedAmountMtn.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbOwnedAmountMtn.Location = new Point(1212, 194);
            lbOwnedAmountMtn.Name = "lbOwnedAmountMtn";
            lbOwnedAmountMtn.Size = new Size(234, 36);
            lbOwnedAmountMtn.TabIndex = 10;
            lbOwnedAmountMtn.Text = "ចំនួនទឺកប្រាក់ដែលជំពាក់:";
            lbOwnedAmountMtn.Click += lbOwnedAmountMtn_Click;
            // 
            // txtPaidAmountMtn
            // 
            txtPaidAmountMtn.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPaidAmountMtn.Location = new Point(865, 190);
            txtPaidAmountMtn.Name = "txtPaidAmountMtn";
            txtPaidAmountMtn.Size = new Size(326, 44);
            txtPaidAmountMtn.TabIndex = 9;
            txtPaidAmountMtn.TextChanged += txtPaidAmountMtn_TextChanged;
            // 
            // lbPaidAmountMtn
            // 
            lbPaidAmountMtn.AutoSize = true;
            lbPaidAmountMtn.BackColor = SystemColors.GradientInactiveCaption;
            lbPaidAmountMtn.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbPaidAmountMtn.Location = new Point(616, 195);
            lbPaidAmountMtn.Name = "lbPaidAmountMtn";
            lbPaidAmountMtn.Size = new Size(249, 36);
            lbPaidAmountMtn.TabIndex = 8;
            lbPaidAmountMtn.Text = "ចំនួនទឹកប្រាក់ដែលបានបង់:";
            lbPaidAmountMtn.Click += lbPaidAmountMtn_Click;
            // 
            // txtContractID
            // 
            txtContractID.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtContractID.Location = new Point(721, 118);
            txtContractID.Name = "txtContractID";
            txtContractID.Size = new Size(252, 44);
            txtContractID.TabIndex = 7;
            txtContractID.TextChanged += txtContractID_TextChanged;
            // 
            // lbContractID
            // 
            lbContractID.AutoSize = true;
            lbContractID.BackColor = SystemColors.GradientInactiveCaption;
            lbContractID.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbContractID.Location = new Point(537, 123);
            lbContractID.Name = "lbContractID";
            lbContractID.Size = new Size(186, 36);
            lbContractID.TabIndex = 6;
            lbContractID.Text = "លេខសម្គាល់កុងត្រា:";
            lbContractID.Click += lbContractID_Click;
            // 
            // dateMtn
            // 
            dateMtn.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateMtn.Format = DateTimePickerFormat.Short;
            dateMtn.Location = new Point(1517, 115);
            dateMtn.Name = "dateMtn";
            dateMtn.Size = new Size(194, 44);
            dateMtn.TabIndex = 5;
            dateMtn.ValueChanged += dateMtn_ValueChanged;
            // 
            // lbDateMtn
            // 
            lbDateMtn.AutoSize = true;
            lbDateMtn.BackColor = SystemColors.GradientInactiveCaption;
            lbDateMtn.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbDateMtn.Location = new Point(1397, 121);
            lbDateMtn.Name = "lbDateMtn";
            lbDateMtn.Size = new Size(123, 36);
            lbDateMtn.TabIndex = 4;
            lbDateMtn.Text = "កាលបរិច្ឆេទ:";
            lbDateMtn.Click += lbDateMtn_Click;
            // 
            // txtTotalMtn
            // 
            txtTotalMtn.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotalMtn.Location = new Point(281, 191);
            txtTotalMtn.Name = "txtTotalMtn";
            txtTotalMtn.Size = new Size(307, 44);
            txtTotalMtn.TabIndex = 3;
            txtTotalMtn.TextChanged += txtTotalMtn_TextChanged;
            // 
            // lbTotalMtn
            // 
            lbTotalMtn.AutoSize = true;
            lbTotalMtn.BackColor = SystemColors.GradientInactiveCaption;
            lbTotalMtn.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbTotalMtn.Location = new Point(57, 196);
            lbTotalMtn.Name = "lbTotalMtn";
            lbTotalMtn.Size = new Size(231, 36);
            lbTotalMtn.TabIndex = 2;
            lbTotalMtn.Text = "ទឺកប្រាក់សរុបនៃការថែទាំ:";
            lbTotalMtn.Click += lbTotalMtn_Click;
            // 
            // txtMtnID
            // 
            txtMtnID.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMtnID.Location = new Point(255, 118);
            txtMtnID.Name = "txtMtnID";
            txtMtnID.Size = new Size(259, 44);
            txtMtnID.TabIndex = 1;
            txtMtnID.TextChanged += txtMtnID_TextChanged;
            // 
            // lbMtnID
            // 
            lbMtnID.AutoSize = true;
            lbMtnID.BackColor = SystemColors.GradientInactiveCaption;
            lbMtnID.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbMtnID.Location = new Point(57, 121);
            lbMtnID.Name = "lbMtnID";
            lbMtnID.Size = new Size(199, 36);
            lbMtnID.TabIndex = 0;
            lbMtnID.Text = "លេខសម្គាល់ការថែទាំ:";
            lbMtnID.Click += label2_Click;
            // 
            // pnBackTopMtn
            // 
            pnBackTopMtn.BackColor = SystemColors.GradientInactiveCaption;
            pnBackTopMtn.BorderStyle = BorderStyle.FixedSingle;
            pnBackTopMtn.Location = new Point(46, 78);
            pnBackTopMtn.Name = "pnBackTopMtn";
            pnBackTopMtn.Size = new Size(1722, 192);
            pnBackTopMtn.TabIndex = 14;
            pnBackTopMtn.Paint += pnBackTopMtn_Paint;
            // 
            // FrmMaintenace
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1782, 953);
            Controls.Add(lbMaintenace);
            Controls.Add(pnTop);
            Name = "FrmMaintenace";
            RightToLeft = RightToLeft.No;
            Text = "FormMaintenace";
            Load += Maintenace_Load;
            pnTop.ResumeLayout(false);
            pnTop.PerformLayout();
            pnSearchMtn.ResumeLayout(false);
            pnSearchMtn.PerformLayout();
            pnDetailMtn.ResumeLayout(false);
            pnDetailMtn.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbMaintenace;
        private Panel pnTop;
        private TextBox txtMtnID;
        private Label lbMtnID;
        private Label lbTotalMtn;
        private TextBox txtTotalMtn;
        private Label lbDateMtn;
        private TextBox txtContractID;
        private Label lbContractID;
        private DateTimePicker dateMtn;
        private TextBox txtPaidAmountMtn;
        private Label lbPaidAmountMtn;
        private TextBox txtOwnedAmountMtn;
        private Label lbOwnedAmountMtn;
        private TextBox txtStoreID;
        private Label lbStoreID;
        private Panel pnBackTopMtn;
        private Panel pnDetailMtn;
        private Label labelMtnID;
        private Label lbDetailMtn;
        private Panel pnSearchMtn;
        private TextBox txtDetailMtn;
        private Label DetailIDMtn;
        private TextBox txtMaintenaceID;
        private TextBox txtItemID;
        private Label lbItemID;
        private TextBox txtQuantity;
        private Label lbQuantity;
        private TextBox txtUnitPrice;
        private Label lbUnitPriceItem;
        private TextBox txtDescription;
        private Label lbDescription;
        private TextBox txtAmount;
        private Label lbAmount;
        private Panel pnSearchbox;
        private TextBox txtSearch;
        private Label lbSearch;
        private Button btnInsert;
        private Button btnDelete;
        private Button btnClear;
        private Button btnUpdate;
        private Button btnCancel;
        private Button btnClose;
    }
}