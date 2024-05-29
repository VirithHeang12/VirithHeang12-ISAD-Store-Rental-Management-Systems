using StoreRentalLib;
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
    public partial class FrmHome : Form
    {
        public static event EventHandler<FormEventArgs>? NavButtonClicked;
        public static event EventHandler? ButtonLogoutClicked;
        public FrmHome()
        {
            InitializeComponent();

            btnShowStaffForm.Click += handleShowFormStaff;
            btnHome.Click += handleShowFormHome;
            btnLogout.Click += handleButtonLogoutClick;
        }

        private void handleButtonLogoutClick(object? sender, EventArgs e)
        {
            var result = MessageBox.Show("តើអ្នកពិតជាចង់ចាកចេញពីប្រព័ន្ធមែនឬទេ?", "ចាកចេញពីប្រព័ន្ធ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                ButtonLogoutClicked?.Invoke(this, e);
            }
            
        }

        private void handleShowFormHome(object? sender, EventArgs e)
        {
            RaiseEvent(FormTypes.FrmHome);
        }

        private void handleShowFormStaff(object? sender, EventArgs e)
        {
            RaiseEvent(FormTypes.FrmStaff);
        }

        private void RaiseEvent(FormTypes ft)
        {
            NavButtonClicked?.Invoke(this, new FormEventArgs()
            {
                Form = ft,
            });
        } 
    }
}
