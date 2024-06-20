﻿namespace Store_Rental_Management_Systems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnLogin = new Button();
            txtLoginPassword = new TextBox();
            txtLoginUserName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 28, 87);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(916, 1000);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(229, 934);
            label3.Name = "label3";
            label3.Size = new Size(460, 43);
            label3.TabIndex = 3;
            label3.Text = "Copyright © 2024 - ISAD SLS Group 3. All Rights Reserved.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Dangrek", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(152, 520);
            label2.Name = "label2";
            label2.Size = new Size(587, 67);
            label2.TabIndex = 2;
            label2.Text = "ប្រព័ន្ធគ្រប់គ្រងនៃការជួលតូបក្នុងផ្សារទំនើប";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Dangrek", 28F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(251, 405);
            label1.Name = "label1";
            label1.Size = new Size(380, 85);
            label1.TabIndex = 1;
            label1.Text = "សូមស្វាគមន៍មកកាន់";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(168, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(532, 342);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(238, 238, 238);
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(txtLoginPassword);
            panel2.Controls.Add(txtLoginUserName);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(916, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(884, 1000);
            panel2.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.AutoSize = true;
            btnLogin.BackColor = Color.FromArgb(0, 28, 87);
            btnLogin.Font = new Font("Kantumruy", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(602, 524);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(200, 71);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "ចូលក្នុងប្រព័ន្ធ";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // txtLoginPassword
            // 
            txtLoginPassword.Location = new Point(379, 412);
            txtLoginPassword.Name = "txtLoginPassword";
            txtLoginPassword.Size = new Size(423, 44);
            txtLoginPassword.TabIndex = 4;
            txtLoginPassword.UseSystemPasswordChar = true;
            // 
            // txtLoginUserName
            // 
            txtLoginUserName.Location = new Point(379, 320);
            txtLoginUserName.Name = "txtLoginUserName";
            txtLoginUserName.Size = new Size(423, 44);
            txtLoginUserName.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Kantumruy", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(0, 28, 87);
            label6.Location = new Point(97, 420);
            label6.Name = "label6";
            label6.Size = new Size(126, 36);
            label6.TabIndex = 2;
            label6.Text = "លេខសម្ងាត់ៈ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Kantumruy", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 28, 87);
            label5.Location = new Point(97, 328);
            label5.Name = "label5";
            label5.Size = new Size(183, 36);
            label5.TabIndex = 1;
            label5.Text = "ឈ្មោះអ្នកប្រើប្រាស់ៈ";
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(0, 28, 87);
            label4.Font = new Font("Dangrek", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(97, 171);
            label4.Name = "label4";
            label4.Size = new Size(705, 66);
            label4.TabIndex = 0;
            label4.Text = "សូមបញ្ចូលឈ្មោះ និង លេខសម្ងាត់ដើម្បីចូលក្នុងប្រព័ន្ធ";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmLogin
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1800, 1000);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("!Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label3;
        private Panel panel2;
        private Label label4;
        private TextBox txtLoginPassword;
        private TextBox txtLoginUserName;
        private Label label6;
        private Label label5;
        private Button btnLogin;
    }
}