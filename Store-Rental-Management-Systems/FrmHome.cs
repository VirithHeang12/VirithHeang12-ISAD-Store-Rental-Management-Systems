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
        public FrmHome()
        {
            InitializeComponent();

            btnShowStaffForm.Click += handleShowFormStaff;
            btnHome.Click += handleShowFormHome;
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
