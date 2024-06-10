using Microsoft.Data.SqlClient;
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
    public partial class FrmSupplier : FrmHome
    {
        private const string TABLE_NAME = "tblSupplier";
        private DataSet _storeRentalDataSet = new DataSet();
        private SqlDataAdapter _supplierDataAdapter = new();
        private BindingSource _supplierBindingSource = new();

        private ErrorProvider _errorProvider = new();

        private Binding? _supplierIDBinding;
        private Binding? _supplierNameBinding;
        private Binding? _supplierContactNumberBinding;
        private Binding? _supplierAddressBinding;


        private List<Control> _validatingControls = new();
        public FrmSupplier() : base()
        {
            InitializeComponent();
            _supplierDataAdapter.SelectCommand = SupplierHelper.CreateGetAllSuppliersCommand();
            _supplierDataAdapter.InsertCommand = SupplierHelper.CreateInsertSupplierCommand();
            _supplierDataAdapter.UpdateCommand = SupplierHelper.CreateUpdateSupplierCommand();

            _errorProvider.ContainerControl = this;

            LoadAllSupplier();
            InitBindings();

            #region event registrations
            btnNewSupplier.Click += HandleBtnNewSupplierClicked;
            btnInsertSupplier.Click += HandleBtnInsertSupplierClicked;
            btnUpdateSupplier.Click += HandleBtnUpdateSupplierClicked;
            btnCancelSupplier.Click += HandleBtnCancelSupplierClicked;

            btnInsertSupplier.EnabledChanged += HandleBtnEnabledChanged;
            btnNewSupplier.EnabledChanged += HandleBtnEnabledChanged;
            btnUpdateSupplier.EnabledChanged += HandleBtnEnabledChanged;
            btnCancelSupplier.EnabledChanged += HandleBtnEnabledChanged;

            txtSupplierName.Validating += ValidateTextBox;
            mtxtContactNumber.Validating += ValidateMaskedTextBox;
            txtSupplierAddress.Validating += ValidateTextBox;


            _validatingControls.Add(txtSupplierName);
            _validatingControls.Add(mtxtContactNumber);
            _validatingControls.Add(txtSupplierAddress);


            txtSearchSupplier.TextChanged += HandleSearchSupplier;
            #endregion


        }
        private void HandleSearchSupplier(object? sender, EventArgs e)
        {
            string searchText = txtSearchSupplier.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                _supplierBindingSource.Filter = string.Empty;
            }
            else
            {
                _supplierBindingSource.Filter = "SupplierName LIKE '%" + searchText + "%'";

            }
        }
        private void ValidateTextBox(object? sender, CancelEventArgs e)
        {
            ErrorHelper.ValidateTextBox((sender as TextBox)!, _errorProvider);
        }

        private void ValidateMaskedTextBox(object? sender, CancelEventArgs e)
        {
            ErrorHelper.ValidateMaskedTextBox((sender as MaskedTextBox)!, _errorProvider);
        }

        private void HandleBtnCancelSupplierClicked(object? sender, EventArgs e)
        {
            _storeRentalDataSet.RejectChanges();
            RefreshDataGridView();

            foreach (var control in _validatingControls)
            {
                ErrorHelper.ValidateTextBox((control as TextBox)!, _errorProvider);
            }

            if (ErrorHelper.HasErrors(_validatingControls, _errorProvider)) return;

        }
        private void HandleBtnEnabledChanged(object? sender, EventArgs e)
        {
            Button btn = (sender as Button)!;

            if (btn != null && !btn.Enabled)
            {
                btn.BackColor = Color.White;
            }
            else
            {
                btn!.BackColor = Color.FromArgb(0, 28, 87);
            }
        }
        private void HandleBtnUpdateSupplierClicked(object? sender, EventArgs e)
        {
            HandleBtnInsertSupplierClicked(null, EventArgs.Empty);
        }

        private void InitBindings()
        {
            txtSupplierID.DataBindings.Add(new Binding("Text", _supplierBindingSource, "SupplierID"));
            txtSupplierName.DataBindings.Add(new Binding("Text", _supplierBindingSource, "SupplierName"));
            mtxtContactNumber.DataBindings.Add(new Binding("Text", _supplierBindingSource, "ContactNumber"));
            txtSupplierAddress.DataBindings.Add(new Binding("Text", _supplierBindingSource, "SupplierAddress"));
        }

        private void HandleBtnInsertSupplierClicked(object? sender, EventArgs e)
        {
            //foreach (var control in _validatingControls)
            //{
            //    ErrorHelper.ValidateTextBox((control as TextBox)!, _errorProvider);

            //}

            foreach (var control in _validatingControls)
            {
                if (control is TextBox textBox)
                {
                    ErrorHelper.ValidateTextBox(textBox, _errorProvider);
                }
                else if (control is MaskedTextBox maskedTextBox)
                {
                    ErrorHelper.ValidateMaskedTextBox(maskedTextBox, _errorProvider);
                }
            }


            if (ErrorHelper.HasErrors(_validatingControls, _errorProvider)) return;
            _supplierBindingSource.EndEdit();
            try
            {
                _supplierDataAdapter.Update(_storeRentalDataSet, TABLE_NAME);
            }
            catch (Exception)
            {
                MessageBox.Show("ការបញ្ចូលមិនបានសម្រេច");
            }

            _supplierBindingSource.ResetBindings(false);

            RefreshDataGridView();
        }
        private void HandleBtnNewSupplierClicked(object? sender, EventArgs e)
        {
            _supplierBindingSource.AddNew();
            txtSupplierName.Focus();
        }
        private void LoadAllSupplier()
        {
            _supplierDataAdapter.TableMappings.Add("Table", TABLE_NAME);
            _supplierDataAdapter.Fill(_storeRentalDataSet);

            _supplierBindingSource.DataSource = _storeRentalDataSet.Tables[TABLE_NAME];
            dgvSuppliers.DataSource = _supplierBindingSource;
        }

        private void RefreshDataGridView()
        {
            _storeRentalDataSet.Tables[TABLE_NAME]?.Clear();
            _supplierDataAdapter.Fill(_storeRentalDataSet, TABLE_NAME);
        }



    }
}
