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
    public partial class FrmContract : FrmHome
    {
        public FrmContract() : base()
        {
            InitializeComponent();
            dtpContractDate.GotFocus += HandleGotFocusEN;
            dtpLeaseStartDate.GotFocus += HandleGotFocusEN;
            dtpLeaseEndDate.GotFocus += HandleGotFocusEN;
            cbStoreID.GotFocus += HandleGotFocusEN;
            cbCustomerID.GotFocus += HandleGotFocusEN;
            cbInsuranceID.GotFocus += HandleGotFocusEN;
            cbStaffID.GotFocus += HandleGotFocusEN;
        }

        #region HandleGotFocus
        private void HandleGotFocusEN(object? sender, EventArgs e)
        {
            KeyboardLayoutHelper.SwitchToEnglishKeyboard();
        }
        #endregion
    }
}
