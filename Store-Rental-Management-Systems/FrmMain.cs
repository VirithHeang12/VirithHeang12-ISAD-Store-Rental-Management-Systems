﻿using StoreRentalLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_Rental_Management_Systems
{
    public partial class FrmMain : Form
    {
        
        public Form? FrmActive { get; set; } = null;
        public FrmMain()
        {
            InitializeComponent();
            this.Resize += handleFormResize;

            FrmLogin.LoggedIn += handleLoggedIn;
            FrmHome.NavButtonClicked += handleNavButtonClicked;
            FrmHome.ButtonLogoutClicked += handleButtonLogoutClick;
            OpenChildForm(new FrmLogin());
           
        }

        private void handleButtonLogoutClick(object? sender, EventArgs e)
        {
            OpenChildForm(new FrmLogin());
        }

        private void handleNavButtonClicked(object? sender, FormEventArgs e)
        {
            switch(e.Form)
            {
                case FormTypes.FrmHome:
                    OpenChildForm(new FrmHome());
                    break;
                case FormTypes.FrmStaff: 
                    OpenChildForm(new FrmStaff()); 
                    break;
            }
        }

        private void handleLoggedIn(object? sender, EventArgs e)
        {
            OpenChildForm(new FrmHome());
        }

        private void handleFormResize(object? sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                AdjustChildFormSize(this.MdiChildren[0]);
            }
        }

        private void AdjustChildFormSize(Form child)
        {
            child.Left = 0;
            child.Top = 0;
            child.Width = this.ClientSize.Width - 4;
            child.Height = this.ClientSize.Height - 4;
        }

        private void OpenChildForm(Form form)
        {
            if (FrmActive != null)
            {
                FrmActive.Close();
                FrmActive.Dispose();
            }

            FrmActive = form;
            FrmActive.MdiParent = this;
            FrmActive.Show();
            AdjustChildFormSize(form);
        }
    }
}
