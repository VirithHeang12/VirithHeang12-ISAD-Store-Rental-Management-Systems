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
    public partial class FrmInsurance : FrmHome
    {
        private const string TABLE_NAME = "tblInsurance";
        private DataSet _storeRentalDataSet = new();
        private SqlDataAdapter _insuranceDataAdapter = new();
        private BindingSource _insuranceBindingSource = new();

        private ErrorProvider _errorProvider = new();

        private Binding? _insuranceIDBinding;
        private Binding? _insuranceNameBinding;
        private Binding? _insuranceWebsiteBinding;

        private List<Control> _validatingControls = new();

        public FrmInsurance() : base()
        {
            InitializeComponent();
            _insuranceDataAdapter.SelectCommand = InsuranceHelper.CreateGetAllInsurancesCommand();
            _insuranceDataAdapter.InsertCommand = InsuranceHelper.CreateInsertInsuranceCommand();
            _insuranceDataAdapter.UpdateCommand = InsuranceHelper.CreateUpdateInsuranceCommand();

            _errorProvider.ContainerControl = this;

            LoadAllInsurances();
            InitBindings();
            BindWithControls();

            #region event registrations
            btnNewInsurance.Click += HandleBtnNewInsuranceClicked;
            btnInsertInsurance.Click += HandleBtnInsertInsuranceClicked;
            btnUpdateInsurance.Click += HandleBtnUpdateInsuranceClicked;
            btnCancelInsurance.Click += HandleBtnCancelInsuranceClicked;

            btnInsertInsurance.EnabledChanged += HandleBtnEnabledChanged;
            btnNewInsurance.EnabledChanged += HandleBtnEnabledChanged;
            btnUpdateInsurance.EnabledChanged += HandleBtnEnabledChanged;
            btnCancelInsurance.EnabledChanged += HandleBtnEnabledChanged;

            txtInsuranceName.Validating += ValidateTextBox;
            txtInsuranceWebsite.Validating += ValidateTextBox;

            _validatingControls.Add(txtInsuranceName);
            _validatingControls.Add(txtInsuranceWebsite);

            txtSearchInsurance.TextChanged += HandleSearchInsurance;
            #endregion
            insuranceBindingSource.Position = -1;
        }

        private void HandleSearchInsurance(object? sender, EventArgs e)
        {
            string searchText = txtSearchInsurance.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                _insuranceBindingSource.Filter = string.Empty;
            }
            else
            {
                _insuranceBindingSource.Filter = "InsuranceName LIKE '%" + searchText + "%'";
            }
        }

        private void ValidateTextBox(object? sender, CancelEventArgs e)
        {
            ErrorHelper.ValidateTextBox((sender as TextBox)!, _errorProvider);
        }

        private void HandleBtnCancelInsuranceClicked(object? sender, EventArgs e)
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

        private void HandleBtnUpdateInsuranceClicked(object? sender, EventArgs e)
        {
            HandleBtnInsertInsuranceClicked(null, EventArgs.Empty);
        }

        private void InitBindings()
        {
            _insuranceIDBinding = new Binding("Text", _insuranceBindingSource, "InsuranceID");
            _insuranceNameBinding = new Binding("Text", _insuranceBindingSource, "InsuranceName");
            _insuranceWebsiteBinding = new Binding("Text", _insuranceBindingSource, "InsuranceWebsite");
        }
        private void BindWithControls()
        {
            txtInsuranceID.DataBindings.Add(_insuranceIDBinding);
            txtInsuranceName.DataBindings.Add(_insuranceNameBinding);
            txtInsuranceWebsite.DataBindings.Add(_insuranceWebsiteBinding);
        }

        private void HandleBtnInsertInsuranceClicked(object? sender, EventArgs e)
        {
            foreach (var control in _validatingControls)
            {
                ErrorHelper.ValidateTextBox((control as TextBox)!, _errorProvider);
            }

            if (ErrorHelper.HasErrors(_validatingControls, _errorProvider)) return;
            _insuranceBindingSource.EndEdit();
            try
            {
                _insuranceDataAdapter.Update(_storeRentalDataSet, TABLE_NAME);
            }
            catch (Exception)
            {
                MessageBox.Show("ការបញ្ចូលមិនបានសម្រេច");
            }

            _insuranceBindingSource.ResetBindings(false);

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

        private void HandleBtnNewInsuranceClicked(object? sender, EventArgs e)
        {
            _insuranceBindingSource.AddNew();
            txtInsuranceName.Focus();
        }

        private void LoadAllInsurances()
        {
            _insuranceDataAdapter.TableMappings.Add("Table", TABLE_NAME);
            _insuranceDataAdapter.Fill(_storeRentalDataSet);

            _insuranceBindingSource.DataSource = _storeRentalDataSet.Tables[TABLE_NAME];
            dgvInsurances.DataSource = _insuranceBindingSource;

        }

        private void RefreshDataGridView()
        {
            _storeRentalDataSet.Tables[TABLE_NAME]?.Clear();
            _insuranceDataAdapter.Fill(_storeRentalDataSet, TABLE_NAME);
        }
    }
}
