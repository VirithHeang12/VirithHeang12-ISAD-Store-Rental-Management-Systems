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
            btnHome.Click += HandleShowFormHome;
            btnShowStaffForm.Click += HandleShowFormStaff;
            btnShowCustomerForm.Click += HandleShowFormCustomer;
            btnShowItemForm.Click += HandleShowFormItem;
            btnShowSupplierForm.Click += HandleShowFromSupplier;
            btnShowStoreTypeForm.Click += HandleShowFormStoreType;
            btnShowUserForm.Click += HandleShowFormUser;
            btnShowInsuranceForm.Click += HandleShowFormInsurance;
            btnLogout.Click += HandleButtonLogoutClick;
        }

        private void HandleShowFormInsurance(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void HandleShowFormUser(object? sender, EventArgs e)
        {
            RaiseEvent(FormTypes.FrmUser);
        }

        private void HandleShowFormStoreType(object? sender, EventArgs e)
        {
            RaiseEvent(FormTypes.FrmStoreType);
        }

        private void HandleShowFromSupplier(object? sender, EventArgs e)
        {
            RaiseEvent(FormTypes.FrmSupplier);
        }

        private void HandleShowFormItem(object? sender, EventArgs e)
        {
            RaiseEvent(FormTypes.FrmItem);
        }

        private void HandleShowFormCustomer(object? sender, EventArgs e)
        {
            RaiseEvent(FormTypes.FrmCustomer);
        }

        private void HandleButtonLogoutClick(object? sender, EventArgs e)
        {
            var result = MessageBox.Show("តើអ្នកពិតជាចង់ចាកចេញពីប្រព័ន្ធមែនឬទេ?", "ចាកចេញពីប្រព័ន្ធ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                ButtonLogoutClicked?.Invoke(this, e);
            }
            
        }

        private void HandleShowFormHome(object? sender, EventArgs e)
        {
            RaiseEvent(FormTypes.FrmHome);
        }

        private void HandleShowFormStaff(object? sender, EventArgs e)
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
