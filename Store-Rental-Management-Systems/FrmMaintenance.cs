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
    public partial class FrmMaintenance : FrmHome
    {
        public FrmMaintenance() : base()
        {
            InitializeComponent();

            #region Event Registrations

            txtTotalAmount.GotFocus += HandleGotFocusEN;
            txtPaidAmount.GotFocus += HandleGotFocusEN;
            txtOwedAmount.GotFocus += HandleGotFocusEN;
            txtItemDescription.GotFocus += HandleGotFocusKM;
            txtUnit.GotFocus += HandleGotFocusKM;
            txtUnitPrice.GotFocus += HandleGotFocusEN;
            txtMaintenanceQty.GotFocus += HandleGotFocusEN;
            txtAmount.GotFocus += HandleGotFocusEN;

            txtSearchMaintenance.GotFocus += HandleGotFocusEN;

            #endregion
        }

        #region HandleGotFocusKM
        private void HandleGotFocusKM(object? sender, EventArgs e)
        {
            KeyboardLayoutHelper.SwitchToKhmerKeyboard();
        }
        #endregion

        #region HandleGotFocusEN
        private void HandleGotFocusEN(object? sender, EventArgs e)
        {
            KeyboardLayoutHelper.SwitchToEnglishKeyboard();
        }
        #endregion
    }
}
