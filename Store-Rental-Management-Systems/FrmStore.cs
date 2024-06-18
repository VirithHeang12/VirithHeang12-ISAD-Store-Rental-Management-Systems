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
    public partial class FrmStore : FrmHome
    {
        private const string TABLE_STORE_NAME = "tblStore";
        private const string TABLE_STORETYPE_NAME = "tblStoreType";


        private DataSet _storeRentalDataSet = new();

        private SqlDataAdapter _storeDataAdapter = new();
        private SqlDataAdapter _storetypeDataAdapter = new();


        private BindingSource _storeBindingSource = new();
        private BindingSource _storetypeBindingSource = new();


        private ErrorProvider _errorProvider = new();

        private List<Control> _validatingControls = new();

        public FrmStore() : base()
        {
            InitializeComponent();

            _errorProvider.ContainerControl = this;

            InitCommands();
            LoadAllData();
            LoadAllStores();
            BindToControls();

            cbStoreTypeID.TextChanged += HandleTextCbStoreTypeIDChanged;

            #region Event Registrations
            btnNewStore.Click += HandleBtnNewStoreClicked;
            btnInsertStore.Click += HandleBtnInsertStoreClicked;
            btnUpdateStore.Click += HandleBtnUpdateStoreClicked;
            btnCancelStore.Click += HandleBtnCancelStoreClicked;

            txtFloorNumber.Validating += ValidateTextBoxNumber;
            txtElectricityLastRecord.Validating += ValidateTextBoxNumber;
            txtWaterLastRecord.Validating += ValidateTextBoxNumber;


            dgvStores.SelectionChanged += HandleSelectionChanged;

            txtSearchStore.TextChanged += HandleSearchStore;
            #endregion

        }
        #region HandleTextCbStoreTypeIDChanged
        private void HandleTextCbStoreTypeIDChanged(object? sender, EventArgs e)
        {
            string searchID = cbStoreTypeID.Text.Trim();

            var dataView = _storeRentalDataSet.Tables[TABLE_STORETYPE_NAME]!.AsDataView();

            if (string.IsNullOrEmpty(searchID))
            {
                dataView.RowFilter = string.Empty;
                cbStoreTypeID.DroppedDown = true;
            }
            else
            {
                dataView.RowFilter = $"CONVERT(StoreTypeID, 'System.String') LIKE '%{searchID}%'";

                if (dataView.Count > 0)
                {
                    dataView.RowFilter = string.Empty;
                }
            }

            if (dataView.Count > 0)
            {
                cbStoreTypeID.Select(cbStoreTypeID.Text.Length, 0); // Keep the caret at the end
            }
            else
            {
                cbStoreTypeID.DroppedDown = false;
            }


            // Set the original text back to the ComboBox (to keep the user input)
            cbStoreTypeID.Text = searchID;
            cbStoreTypeID.SelectionStart = searchID.Length;
            cbStoreTypeID.SelectionLength = 0;

            //_supplierBindingSource.DataSource = dataView;
        }
        #endregion

        #region InitCommands
        private void InitCommands()
        {
            // store
            _storeDataAdapter.SelectCommand = StoreHelper.CreateGetAllStoresCommand();
            _storeDataAdapter.InsertCommand = StoreHelper.CreateInsertStoreCommand();
            _storeDataAdapter.UpdateCommand = StoreHelper.CreateUpdateStoreCommand();

            // storetype
            _storetypeDataAdapter.SelectCommand = StoreHelper.CreateGetAllStoreTypesForComboBoxCommand();

        }
        #endregion

        #region BindToControls
        private void BindToControls()
        {
            // binding for searching store
            txtStoreID.DataBindings.Add(new Binding("Text", _storeBindingSource, "StoreID"));
            txtFloorNumber.DataBindings.Add(new Binding("Text", _storeBindingSource, "FloorNumber"));
            txtElectricityLastRecord.DataBindings.Add(new Binding("Text", _storeBindingSource, "ElectricityLastRecord"));
            txtWaterLastRecord.DataBindings.Add(new Binding("Text", _storeBindingSource, "WaterLastRecord"));

            // Bind the radio buttons
            //BindRadioButton(rdbFree, StoreType.Free);
            //BindRadioButton(rdbRented, StoreType.Rent);

            // binding for choosing supplier
            cbStoreTypeID.DataBindings.Add(new Binding("SelectedItem", _storetypeBindingSource, "StoreTypeID"));

        }
        #endregion

        #region Load All Data
        private void LoadAllData()
        {
            //// filling tblStore DataTable
            //_storeDataAdapter.TableMappings.Add("Table", TABLE_STORE_NAME);
            //_storeDataAdapter.Fill(_storeRentalDataSet, TABLE_STORE_NAME);

            // filling tblStoreType DataTable
            _storetypeDataAdapter.TableMappings.Add("Table1", TABLE_STORETYPE_NAME);
            _storetypeDataAdapter.Fill(_storeRentalDataSet, TABLE_STORETYPE_NAME);

            // bind to StoreTypeID combo box
            _storetypeBindingSource.DataSource = _storeRentalDataSet.Tables[TABLE_STORETYPE_NAME]!.AsDataView();
            cbStoreTypeID.DataSource = _storetypeBindingSource;
            cbStoreTypeID.DisplayMember = "StoreTypeID";
            cbStoreTypeID.ValueMember = "StoreTypeID";

            //// bind to dgvStores
            //_storeBindingSource.DataSource = _storeRentalDataSet.Tables[TABLE_STORE_NAME];
            //dgvStores.DataSource = _storeBindingSource;



        }
        #endregion

        #region Handle DataGridView SelectionChanged
        private void HandleSelectionChanged(object? sender, EventArgs e)
        {
            if (!ContainsNewRow(_storeRentalDataSet.Tables[TABLE_STORE_NAME]!))
            {
                return;
            }
            else
            {
                btnCancelStore.PerformClick();
            }
        }

        private bool ContainsNewRow(DataTable table)
        {
            DataTable? changes = table.GetChanges(DataRowState.Added);

            return changes != null && changes.Rows.Count > 0;
        }
        #endregion

        #region Handle Search
        private void HandleSearchStore(object? sender, EventArgs e)
        {
            string searchText = txtSearchStore.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                _storeBindingSource.Filter = string.Empty;
            }
            else
            {
                _storeBindingSource.Filter = "SupplierName LIKE '" + searchText + "%'";

            }
        }
        #endregion

        #region Handle Validation
        private void ValidateTextBoxNumber(object? sender, CancelEventArgs e)
        {
            ErrorHelper.ValidateTextBoxNumber((sender as TextBox)!, _errorProvider);
        }

        #endregion

        #region Handle New
        private void HandleBtnNewStoreClicked(object? sender, EventArgs e)
        {
            try
            {
                _storeBindingSource.AddNew();
            }
            catch (Exception)
            {
                MessageBox.Show("ការថែមទិន្នន័យមិនបានសម្រេច", "ថែមទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtFloorNumber.Focus();
            
        }
        #endregion

        #region Handle Insert
        private void HandleBtnInsertStoreClicked(object? sender, EventArgs e)
        {
            CauseValidation();

            if (ErrorHelper.HasErrors(_validatingControls, _errorProvider)) return;
            _storeBindingSource.EndEdit();
            try
            {
                _storeDataAdapter.Update(_storeRentalDataSet, TABLE_STORE_NAME);
                _storeBindingSource.ResetBindings(false);
            }
            catch (Exception)
            {
                MessageBox.Show("ការបញ្ខូលឬកែប្រែមិនបានសម្រេច", "បញ្ខូលឬកែប្រែ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            RefreshDataGridView();
        }

        #endregion

        #region Handle Update
        private void HandleBtnUpdateStoreClicked(object? sender, EventArgs e)
        {
            HandleBtnInsertStoreClicked(null, EventArgs.Empty);
        }
        #endregion

        #region Handle Cancel
        private void HandleBtnCancelStoreClicked(object? sender, EventArgs e)
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
                    ErrorHelper.ValidateTextBoxNumber(textBox, _errorProvider);
                }
            }
        }
        #endregion

        #region Load
        private void LoadAllStores()
        {
            _storeDataAdapter.TableMappings.Add("Table", TABLE_STORE_NAME);

            try
            {
                _storeDataAdapter.Fill(_storeRentalDataSet);
                _storetypeDataAdapter.Fill(_storeRentalDataSet);
            }
            catch (Exception)
            {
                MessageBox.Show("ការទាញទិន្នន័យមិនបានសម្រេច", "ទាញទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _storeBindingSource.DataSource = _storeRentalDataSet.Tables[TABLE_STORE_NAME];
            dgvStores.DataSource = _storeBindingSource;

        }
        #endregion

        #region Refresh
        private void RefreshDataGridView()
        {
            _storeRentalDataSet.Tables[TABLE_STORE_NAME]?.Clear();
            try
            {
                _storeDataAdapter.Fill(_storeRentalDataSet, TABLE_STORE_NAME);
            }
            catch (Exception)
            {
                MessageBox.Show("ការទាញទិន្នន័យមិនបានសម្រេច", "ទាញទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion



    }
}
