namespace Store_Rental_Management_Systems
{
    partial class FrmMain
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
            label1 = new Label();
            lblUserName = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            pnlLogin = new Panel();
            pnlLogin.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.HotPink;
            label1.Dock = DockStyle.Top;
            label1.ForeColor = Color.Magenta;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1351, 93);
            label1.TabIndex = 0;
            label1.Text = "ប្រព័ន្ធគ្រប់គ្រងការជួលតូប";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(111, 107);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(162, 36);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "ឈ្មោះអ្នកប្រើប្រាស់";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(350, 99);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(269, 44);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(136, 29);
            label2.Name = "label2";
            label2.Size = new Size(422, 36);
            label2.TabIndex = 3;
            label2.Text = "សូមបញ្ចូលឈ្មោះនិងលេខសម្ងាត់ដើម្បីចូលក្នុងប្រព័ន្ធ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(122, 186);
            label3.Name = "label3";
            label3.Size = new Size(109, 36);
            label3.TabIndex = 4;
            label3.Text = "លេខសម្ងាត់";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(350, 186);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(269, 44);
            textBox2.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(472, 280);
            button1.Name = "button1";
            button1.Size = new Size(147, 51);
            button1.TabIndex = 6;
            button1.Text = "ចូលក្នុងប្រព័ន្ធ";
            button1.UseVisualStyleBackColor = true;
            // 
            // pnlLogin
            // 
            pnlLogin.BackColor = Color.SkyBlue;
            pnlLogin.Controls.Add(label2);
            pnlLogin.Controls.Add(button1);
            pnlLogin.Controls.Add(lblUserName);
            pnlLogin.Controls.Add(textBox2);
            pnlLogin.Controls.Add(textBox1);
            pnlLogin.Controls.Add(label3);
            pnlLogin.Location = new Point(374, 141);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(673, 414);
            pnlLogin.TabIndex = 7;
            // 
            // FrmMain
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1351, 698);
            Controls.Add(pnlLogin);
            Controls.Add(label1);
            Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMain";
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label lblUserName;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Button button1;
        private Panel pnlLogin;
    }
}