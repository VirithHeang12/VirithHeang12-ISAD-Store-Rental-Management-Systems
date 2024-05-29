namespace Store_Rental_Management_Systems
{
    partial class FrmLogin
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
            lblSystemTitle = new Label();
            lblLoginUserName = new Label();
            txtLoginUserName = new TextBox();
            lblLoginTitle = new Label();
            lblLoginPassword = new Label();
            txtLoginPassword = new TextBox();
            btnLogin = new Button();
            pnlLogin = new Panel();
            pnlLogin.SuspendLayout();
            SuspendLayout();
            // 
            // lblSystemTitle
            // 
            lblSystemTitle.BackColor = Color.HotPink;
            lblSystemTitle.Dock = DockStyle.Top;
            lblSystemTitle.ForeColor = Color.Magenta;
            lblSystemTitle.Location = new Point(0, 0);
            lblSystemTitle.Name = "lblSystemTitle";
            lblSystemTitle.Size = new Size(1800, 93);
            lblSystemTitle.TabIndex = 0;
            lblSystemTitle.Text = "ប្រព័ន្ធគ្រប់គ្រងការជួលតូប";
            lblSystemTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLoginUserName
            // 
            lblLoginUserName.AutoSize = true;
            lblLoginUserName.Location = new Point(111, 107);
            lblLoginUserName.Name = "lblLoginUserName";
            lblLoginUserName.Size = new Size(162, 36);
            lblLoginUserName.TabIndex = 1;
            lblLoginUserName.Text = "ឈ្មោះអ្នកប្រើប្រាស់";
            // 
            // txtLoginUserName
            // 
            txtLoginUserName.Location = new Point(350, 99);
            txtLoginUserName.Name = "txtLoginUserName";
            txtLoginUserName.Size = new Size(269, 44);
            txtLoginUserName.TabIndex = 2;
            // 
            // lblLoginTitle
            // 
            lblLoginTitle.AutoSize = true;
            lblLoginTitle.Location = new Point(136, 29);
            lblLoginTitle.Name = "lblLoginTitle";
            lblLoginTitle.Size = new Size(422, 36);
            lblLoginTitle.TabIndex = 3;
            lblLoginTitle.Text = "សូមបញ្ចូលឈ្មោះនិងលេខសម្ងាត់ដើម្បីចូលក្នុងប្រព័ន្ធ";
            // 
            // lblLoginPassword
            // 
            lblLoginPassword.AutoSize = true;
            lblLoginPassword.Location = new Point(122, 186);
            lblLoginPassword.Name = "lblLoginPassword";
            lblLoginPassword.Size = new Size(109, 36);
            lblLoginPassword.TabIndex = 4;
            lblLoginPassword.Text = "លេខសម្ងាត់";
            // 
            // txtLoginPassword
            // 
            txtLoginPassword.Location = new Point(350, 186);
            txtLoginPassword.Name = "txtLoginPassword";
            txtLoginPassword.PasswordChar = '*';
            txtLoginPassword.Size = new Size(269, 44);
            txtLoginPassword.TabIndex = 5;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(472, 280);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(147, 51);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "ចូលក្នុងប្រព័ន្ធ";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // pnlLogin
            // 
            pnlLogin.BackColor = Color.SkyBlue;
            pnlLogin.Controls.Add(lblLoginTitle);
            pnlLogin.Controls.Add(btnLogin);
            pnlLogin.Controls.Add(lblLoginUserName);
            pnlLogin.Controls.Add(txtLoginPassword);
            pnlLogin.Controls.Add(txtLoginUserName);
            pnlLogin.Controls.Add(lblLoginPassword);
            pnlLogin.Location = new Point(374, 141);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(673, 414);
            pnlLogin.TabIndex = 7;
            // 
            // FrmLogin
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1800, 1000);
            ControlBox = false;
            Controls.Add(pnlLogin);
            Controls.Add(lblSystemTitle);
            Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblSystemTitle;
        private Label lblLoginUserName;
        private TextBox txtLoginUserName;
        private Label lblLoginTitle;
        private Label lblLoginPassword;
        private TextBox txtLoginPassword;
        private Button btnLogin;
        private Panel pnlLogin;
    }
}