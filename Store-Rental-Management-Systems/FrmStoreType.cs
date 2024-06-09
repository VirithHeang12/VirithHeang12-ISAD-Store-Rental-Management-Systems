using Microsoft.Data.SqlClient;
using StoreRentalHelper;
using StoreRentalHelper.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_Rental_Management_Systems
{
    public partial class FrmStoreType : FrmHome
    {

        private const string TABLE_NAME = "tblStoreType";
        private DataSet _storeRentalDataSet = new DataSet();
        private SqlDataAdapter _storetypeDataAdapter = new();
        private BindingSource _storetypeBindingSource = new();

        private ErrorProvider _errorProvider = new();

        private Binding? _storetypeIDBinding;
        private Binding? _storetypeDescriptionBinding;
        private Binding? _storetypeMonthlyLeasePriceBinding;
        private Binding? _storetypeThreeMonthPaymentDiscountBinding;
        private Binding? _storetypeSixMonthPaymentDiscountBinding;
        private Binding? _storetypeOneYearPaymentDiscountBinding;

        private List<Control> _validatingControls = new();
        public FrmStoreType() : base()
        {
            InitializeComponent();
            _storetypeDataAdapter.SelectCommand = StoreTypeHelper.CreateGetAllStoreTypesCommand();
            _storetypeDataAdapter.InsertCommand = StoreTypeHelper.CreateInsertStoreTypeCommand();
            _storetypeDataAdapter.UpdateCommand = StoreTypeHelper.CreateUpdateStoreTypeCommand();

            _errorProvider.ContainerControl = this;


            LoadAllStoreTypes();
            InitBindings();
            //BindWithControls();

            #region event registrations
            btnNewStoreType.Click += HandleBtnNewStoreTypeClicked;
            btnInsertStoreType.Click += HandleBtnInsertStoreTypeClicked;
            btnUpdateStoreType.Click += HandleBtnUpdateStoreTypeClicked;
            btnCancelStoreType.Click += HandleBtnCancelStoreTypeClicked;

            btnInsertStoreType.EnabledChanged += HandleBtnEnabledChanged;
            btnNewStoreType.EnabledChanged += HandleBtnEnabledChanged;
            btnUpdateStoreType.EnabledChanged += HandleBtnEnabledChanged;
            btnCancelStoreType.EnabledChanged += HandleBtnEnabledChanged;

            txtStoreTypeDescription.Validating += ValidateTextBox;
            txtMonthlyLeasePrice.Validating += ValidateTextBoxNumber;
            txtThreeMonthPaymentDiscount.Validating += ValidateTextBoxNumber;
            txtSixMonthPaymentDiscount.Validating += ValidateTextBoxNumber;
            txtOneYearPaymentDiscount.Validating += ValidateTextBoxNumber;

            _validatingControls.Add(txtStoreTypeDescription);
            _validatingControls.Add(txtMonthlyLeasePrice);
            _validatingControls.Add(txtThreeMonthPaymentDiscount);
            _validatingControls.Add(txtSixMonthPaymentDiscount);
            _validatingControls.Add(txtOneYearPaymentDiscount);


            txtSearchStoreType.TextChanged += HandleSearchStoreType;
            #endregion


        }
        private void HandleSearchStoreType(object? sender, EventArgs e)
        {
            string searchText = txtSearchStoreType.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                _storetypeBindingSource.Filter = string.Empty;
            }
            else
            {
                _storetypeBindingSource.Filter = "StoreTypeDescription LIKE '%" + searchText + "%'";

            }
        }

        //private void HandleSearchStoreType(object? sender, EventArgs e)
        //{
        //    string searchText = txtSearchStoreType.Text.Trim().ToLower();

        //    if (string.IsNullOrEmpty(searchText))
        //    {
        //        _storetypeBindingSource.Filter = string.Empty;
        //    }
        //    else
        //    {
        //        if (int.TryParse(searchText, out int storeTypeId))
        //        {
        //            _storetypeBindingSource.Filter = $"StoreTypeID = {storeTypeId}";
        //        }
        //        else
        //        {
        //            _storetypeBindingSource.Filter = string.Empty;
        //        }
        //    }
        //}



        private void ValidateTextBox(object? sender, CancelEventArgs e)
        {
            ErrorHelper.ValidateTextBox((sender as TextBox)!, _errorProvider);
        }

        private void ValidateTextBoxNumber(object? sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;


            if (!Regex.IsMatch(textBox.Text, @"^\d*\.?\d*$"))
            {
                _errorProvider.SetError(textBox, "Only numbers are allowed.");
            }
            else
            {
                _errorProvider.SetError(textBox, "");
            }
        }

        private void HandleBtnCancelStoreTypeClicked(object? sender, EventArgs e)
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
        private void HandleBtnUpdateStoreTypeClicked(object? sender, EventArgs e)
        {
            HandleBtnInsertStoreTypeClicked(null, EventArgs.Empty);
        }

        //private void InitBindings()
        //{
        //    _storetypeIDBinding = new Binding("Text", _storetypeBindingSource, "StoreTypeID");
        //    _storetypeDescriptionBinding = new Binding("Text", _storetypeDescriptionBinding, "StoreTypeDescription");
        //    _storetypeMonthlyLeasePriceBinding = new Binding("Text", _storetypeMonthlyLeasePriceBinding, "MonthlyLeasePrice");
        //    _storetypeThreeMonthPaymentDiscountBinding = new Binding("Text", _storetypeThreeMonthPaymentDiscountBinding, "ThreeMonthPaymentDiscount");
        //    _storetypeSixMonthPaymentDiscountBinding = new Binding("Text", _storetypeSixMonthPaymentDiscountBinding, "SixMonthPaymentDiscount");
        //    _storetypeOneYearPaymentDiscountBinding = new Binding("Text", _storetypeOneYearPaymentDiscountBinding, "OneYearPaymentDiscount");
        //}

        private void InitBindings()
        {
            txtStoreTypeID.DataBindings.Add(new Binding("Text", _storetypeBindingSource, "StoreTypeID"));
            txtStoreTypeDescription.DataBindings.Add(new Binding("Text", _storetypeBindingSource, "StoreTypeDescription"));
            txtMonthlyLeasePrice.DataBindings.Add(new Binding("Text", _storetypeBindingSource, "MonthlyLeasePrice"));
            txtThreeMonthPaymentDiscount.DataBindings.Add(new Binding("Text", _storetypeBindingSource, "ThreeMonthPaymentDiscount"));
            txtSixMonthPaymentDiscount.DataBindings.Add(new Binding("Text", _storetypeBindingSource, "SixMonthPaymentDiscount"));
            txtOneYearPaymentDiscount.DataBindings.Add(new Binding("Text", _storetypeBindingSource, "OneYearPaymentDiscount"));
        }

        //private void BindWithControls()
        //{
        //    txtStoreTypeID.DataBindings.Add(_storetypeIDBinding);
        //    txtStoreTypeDescription.DataBindings.Add(_storetypeDescriptionBinding);
        //    txtMonthlyLeasePrice.DataBindings.Add(_storetypeMonthlyLeasePriceBinding);
        //    txtThreeMonthPaymentDiscount.DataBindings.Add(_storetypeThreeMonthPaymentDiscountBinding);
        //    txtSixMonthPaymentDiscount.DataBindings.Add(_storetypeSixMonthPaymentDiscountBinding);
        //    txtOneYearPaymentDiscount.DataBindings.Add(_storetypeOneYearPaymentDiscountBinding);
        //}

        private void HandleBtnInsertStoreTypeClicked(object? sender, EventArgs e)
        {
            foreach (var control in _validatingControls)
            {
                ErrorHelper.ValidateTextBox((control as TextBox)!, _errorProvider);
            }

            if (ErrorHelper.HasErrors(_validatingControls, _errorProvider)) return;
            _storetypeBindingSource.EndEdit();
            try
            {
                _storetypeDataAdapter.Update(_storeRentalDataSet, TABLE_NAME);
            }
            catch (Exception)
            {
                MessageBox.Show("ការបញ្ចូលមិនបានសម្រេច");
            }

            _storetypeBindingSource.ResetBindings(false);

            RefreshDataGridView();
        }

        public bool HasErrors()
        {
            foreach (Control control in _validatingControls)
            {
                control.Focus();
                var err = _errorProvider.GetError(control);

                if (!string.IsNullOrEmpty(err))
                {
                    return true;
                }
            }
            return false;
        }

        private void HandleBtnNewStoreTypeClicked(object? sender, EventArgs e)
        {
            _storetypeBindingSource.AddNew();
            txtStoreTypeDescription.Focus();
        }
        private void LoadAllStoreTypes()
        {
            _storetypeDataAdapter.TableMappings.Add("Table", TABLE_NAME);
            _storetypeDataAdapter.Fill(_storeRentalDataSet);

            _storetypeBindingSource.DataSource = _storeRentalDataSet.Tables[TABLE_NAME];
            dgvStoreTypes.DataSource = _storetypeBindingSource;
        }


        private void RefreshDataGridView()
        {
            _storeRentalDataSet.Tables[TABLE_NAME]?.Clear();
            _storetypeDataAdapter.Fill(_storeRentalDataSet, TABLE_NAME);
        }

        //private void RefreshDataGridView()
        //{
        //    try
        //    {
        //        _storeRentalDataSet.Tables[TABLE_NAME]?.Clear();
        //        _storetypeDataAdapter.Fill(_storeRentalDataSet, TABLE_NAME);

        //        // Ensure the DataTable is not null and has data
        //        if (_storeRentalDataSet.Tables[TABLE_NAME] == null || _storeRentalDataSet.Tables[TABLE_NAME].Rows.Count == 0)
        //        {
        //            MessageBox.Show("No data found.");
        //            return;
        //        }

        //        _storetypeBindingSource.DataSource = _storeRentalDataSet.Tables[TABLE_NAME];
        //        dgvStoreTypes.DataSource = _storetypeBindingSource;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("An error occurred while refreshing data: " + ex.Message);
        //    }
        //}


    }
}
