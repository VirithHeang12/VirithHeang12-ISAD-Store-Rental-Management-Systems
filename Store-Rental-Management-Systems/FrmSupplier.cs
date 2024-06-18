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

        private List<Control> _validatingControls = new();
        public FrmSupplier() : base()
        {
            InitializeComponent();

            #region Init DataAdapter Commands
            _supplierDataAdapter.SelectCommand = SupplierHelper.CreateGetAllSuppliersCommand();
            _supplierDataAdapter.InsertCommand = SupplierHelper.CreateInsertSupplierCommand();
            _supplierDataAdapter.UpdateCommand = SupplierHelper.CreateUpdateSupplierCommand();
            #endregion

            #region Add controls for validation
            _errorProvider.ContainerControl = this;
            _validatingControls.Add(txtSupplierName);
            _validatingControls.Add(mtxtContactNumber);
            _validatingControls.Add(txtSupplierAddress);
            #endregion

            LoadAllSuppliers();
            BindWithControls();

            #region Event Registrations
            btnNewSupplier.Click += HandleBtnNewSupplierClicked;
            btnInsertSupplier.Click += HandleBtnInsertSupplierClicked;
            btnUpdateSupplier.Click += HandleBtnUpdateSupplierClicked;
            btnCancelSupplier.Click += HandleBtnCancelSupplierClicked;

            txtSupplierName.Validating += ValidateTextBox;
            mtxtContactNumber.Validating += ValidateMaskedTextBox;
            txtSupplierAddress.Validating += ValidateTextBox;

            dgvSuppliers.SelectionChanged += HandleSelectionChanged;

            txtSearchSupplier.TextChanged += HandleSearchSupplier;
            #endregion
        }
        #region Bind With Controls
        private void BindWithControls()
        {
            txtSupplierID.DataBindings.Add(new Binding("Text", _supplierBindingSource, "SupplierID"));
            txtSupplierName.DataBindings.Add(new Binding("Text", _supplierBindingSource, "SupplierName"));
            mtxtContactNumber.DataBindings.Add(new Binding("Text", _supplierBindingSource, "ContactNumber"));
            txtSupplierAddress.DataBindings.Add(new Binding("Text", _supplierBindingSource, "SupplierAddress"));
        }
        #endregion

        #region Handle DataGridView SelectionChanged
        private void HandleSelectionChanged(object? sender, EventArgs e)
        {
            if (!ContainsNewRow(_storeRentalDataSet.Tables[TABLE_NAME]!))
            {
                return;
            }
            else
            {
                btnCancelSupplier.PerformClick();
            }
        }

        private bool ContainsNewRow(DataTable table)
        {
            DataTable? changes = table.GetChanges(DataRowState.Added);

            return changes != null && changes.Rows.Count > 0;
        }
        #endregion

        #region Handle Search
        private void HandleSearchSupplier(object? sender, EventArgs e)
        {
            string searchText = txtSearchSupplier.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                _supplierBindingSource.Filter = string.Empty;
            }
            else
            {
                _supplierBindingSource.Filter = "SupplierName LIKE '" + searchText + "%'";

            }
        }
        #endregion

        #region Handle Validation
        private void ValidateTextBox(object? sender, CancelEventArgs e)
        {
            ErrorHelper.ValidateTextBox((sender as TextBox)!, _errorProvider);
        }

        private void ValidateMaskedTextBox(object? sender, CancelEventArgs e)
        {
            ErrorHelper.ValidateMaskedTextBox((sender as MaskedTextBox)!, _errorProvider);
        }
        #endregion

        #region Handle New
        private void HandleBtnNewSupplierClicked(object? sender, EventArgs e)
        {
            try
            {
                _supplierBindingSource.AddNew();
            }
            catch (Exception)
            {
                MessageBox.Show("ការថែមទិន្នន័យមិនបានសម្រេច", "ថែមទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtSupplierName.Focus();
        }
        #endregion

        #region Handle Insert
        private void HandleBtnInsertSupplierClicked(object? sender, EventArgs e)
        {
            CauseValidation();

            if (ErrorHelper.HasErrors(_validatingControls, _errorProvider)) return;
            _supplierBindingSource.EndEdit();
            try
            {
                _supplierDataAdapter.Update(_storeRentalDataSet, TABLE_NAME);
                _supplierBindingSource.ResetBindings(false);
            }
            catch (Exception)
            {
                MessageBox.Show("ការបញ្ខូលឬកែប្រែមិនបានសម្រេច", "បញ្ខូលឬកែប្រែ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            RefreshDataGridView();
        }

        #endregion

        #region Handle Update
        private void HandleBtnUpdateSupplierClicked(object? sender, EventArgs e)
        {
            HandleBtnInsertSupplierClicked(null, EventArgs.Empty);
        }
        #endregion

        #region Handle Cancel
        private void HandleBtnCancelSupplierClicked(object? sender, EventArgs e)
        {
            _errorProvider.Clear();
            _storeRentalDataSet.RejectChanges();
            RefreshDataGridView();

        }
        #endregion

        #region Cause Validation
        private void CauseValidation()
        {
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
        }
        #endregion

        #region Load
        private void LoadAllSuppliers()
        {
            _supplierDataAdapter.TableMappings.Add("Table", TABLE_NAME);  
            try
            {
                _supplierDataAdapter.Fill(_storeRentalDataSet);
            }
            catch (Exception)
            {
                MessageBox.Show("ការទាញទិន្នន័យមិនបានសម្រេច", "ទាញទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _supplierBindingSource.DataSource = _storeRentalDataSet.Tables[TABLE_NAME];
            dgvSuppliers.DataSource = _supplierBindingSource;
        }
        #endregion

        #region Refresh
        private void RefreshDataGridView()
        {
            _storeRentalDataSet.Tables[TABLE_NAME]?.Clear();
            try
            {
                _supplierDataAdapter.Fill(_storeRentalDataSet, TABLE_NAME);
            }
            catch (Exception)
            {
                MessageBox.Show("ការទាញទិន្នន័យមិនបានសម្រេច", "ទាញទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        #endregion


    }
}
