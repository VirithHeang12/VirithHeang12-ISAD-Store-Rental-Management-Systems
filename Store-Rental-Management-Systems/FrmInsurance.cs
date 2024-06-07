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
        private DataSet _storeRentalDataSet = new();
        private SqlDataAdapter _insuranceDataAdapter = new();
        private BindingSource _insuranceBindingSource = new();

        private Binding? _insuranceIDBinding;
        private Binding? _insuranceNameBinding;
        private Binding? _insuranceWebsiteBinding;

        private bool _isAdding = false;
        private bool _isUpdatable = false;

        public FrmInsurance() : base()
        {
            InitializeComponent();
            _insuranceDataAdapter.SelectCommand = InsuranceHelper.CreateGetAllInsurancesCommand();
            _insuranceDataAdapter.InsertCommand = InsuranceHelper.CreateInsertInsuranceCommand();
            _insuranceDataAdapter.UpdateCommand = InsuranceHelper.CreateUpdateInsuranceCommand();

            LoadAllInsurances();
            InitBindings();
            BindWithControls();

            #region event registrations
            btnNewInsurance.Click += HandleBtnNewInsuranceClicked;
            btnInsertInsurance.Click += HandleBtnInsertInsuranceClicked;
            btnUpdateInsurance.Click += HandleBtnUpdateInsuranceClicked;
            _insuranceBindingSource.CurrentChanged += HandleBindingSourceCurrentChanged;

            btnInsertInsurance.EnabledChanged += HandleBtnEnabledChanged;
            btnInsertInsurance.Enabled = false;
            btnCancelAddingInsurance.Enabled = false;
            btnUpdateInsurance.Enabled = false;

            btnInsertInsurance.ForeColor = Color.White;
            btnCancelAddingInsurance.ForeColor = Color.White;
            btnUpdateInsurance.ForeColor = Color.White;
            #endregion
        }

        private void HandleBtnEnabledChanged(object? sender, EventArgs e)
        {
            Button btn = (sender as Button)!;

            if (btn != null && !btn.Enabled)
            {
                btn.ForeColor = Color.Gray;
            }
            else
            {
                btn!.ForeColor = Color.White;
            }
        }

        private void HandleBindingSourceCurrentChanged(object? sender, EventArgs e)
        {
            _isUpdatable = true;
            btnUpdateInsurance.Enabled = _isUpdatable;
        }

        private void HandleBtnUpdateInsuranceClicked(object? sender, EventArgs e)
        {
            HandleBtnInsertInsuranceClicked(null, EventArgs.Empty);
        }

        private void InitBindings()
        {
            _insuranceIDBinding = new Binding(nameof(txtInsuranceID.Text), _insuranceBindingSource, "InsuranceID");
            _insuranceNameBinding = new Binding(nameof(txtInsuranceName.Text), _insuranceBindingSource, "InsuranceName");
            _insuranceWebsiteBinding = new Binding(nameof(txtInsuranceWebsite.Text), _insuranceBindingSource, "InsuranceWebsite");
        }
        private void BindWithControls()
        {
            txtInsuranceID.DataBindings.Add(_insuranceIDBinding);
            txtInsuranceName.DataBindings.Add(_insuranceNameBinding);
            txtInsuranceWebsite.DataBindings.Add(_insuranceWebsiteBinding);
        }

        private void HandleBtnInsertInsuranceClicked(object? sender, EventArgs e)
        {
            _insuranceBindingSource.EndEdit();
            _insuranceDataAdapter.Update(_storeRentalDataSet);
            _insuranceBindingSource.ResetBindings(false);

            RefreshDataGridView();
        }

        private void HandleBtnNewInsuranceClicked(object? sender, EventArgs e)
        {
            _insuranceBindingSource.AddNew();
        }

        private void LoadAllInsurances()
        {
            _insuranceDataAdapter.TableMappings.Add("Table", "tblInsurance");
            _insuranceDataAdapter.Fill(_storeRentalDataSet);

            _insuranceBindingSource.DataSource = _storeRentalDataSet.Tables["tblInsurance"];
            dgvInsurances.DataSource = _insuranceBindingSource;
        }

        private void RefreshDataGridView()
        {
            _storeRentalDataSet.Tables["tblInsurance"]?.Clear();

            _insuranceDataAdapter.Fill(_storeRentalDataSet);
        }
    }
}
