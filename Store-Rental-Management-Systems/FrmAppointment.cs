using StoreRentalHelper;
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
    public partial class FrmAppointment : FrmHome
    {
        public FrmAppointment() : base()
        {
            InitializeComponent();

            dtpAppointmentDate.GotFocus += HandleGotFocusEN;
            cbAppointmentStatus.GotFocus += HandleGotFocusKM;
            cbCustomerID.GotFocus += HandleGotFocusEN;
            cbStaffID.GotFocus += HandleGotFocusEN;
        }

        private void HandleGotFocusKM(object? sender, EventArgs e)
        {
            KeyboardLayoutHelper.SwitchToKhmerKeyboard();
        }

        private void HandleGotFocusEN(object? sender, EventArgs e)
        {
            KeyboardLayoutHelper.SwitchToEnglishKeyboard();
        }
    }
}
