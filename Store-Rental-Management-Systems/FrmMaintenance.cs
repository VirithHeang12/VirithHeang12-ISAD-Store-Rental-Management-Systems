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
using static System.Net.Mime.MediaTypeNames;


namespace Store_Rental_Management_Systems
{
    public partial class FrmMaintenance : FrmHome
    {
        private const string RELATIONSHIP_NAME = "maintenance_maintenanceDetail";

        private const string TABLE_MAINTENANCE_NAME = "tblMaintenance";
        private const string TABLE_MAINTENANCE_DETAIL_NAME = "tblMaintenanceDetail";
        private const string TABLE_STORE_NAME = "tblStore";
        private const string TABLE_CONTRACT_NAME = "tblContract";
        private const string TABLE_STAFF_NAME = "tblStaff";
        private const string TABLE_ITEM_NAME = "tblItem";

        private DataSet _storeRentalDataSet = new();

        private SqlDataAdapter _maintenanceDataAdapter = new();
        private SqlDataAdapter _maintenanceDetailDataAdapter = new();
        private SqlDataAdapter _storeDataAdapter = new();
        private SqlDataAdapter _contractDataAdapter = new();
        private SqlDataAdapter _staffDataAdapter = new();
        private SqlDataAdapter _itemDataAdapter = new();

        private BindingSource _maintenanceBindingSource = new();
        private BindingSource _maintenanceDetailBindingSource = new();
        private BindingSource _storeBindingSource = new();
        private BindingSource _contractBindingSource = new();
        private BindingSource _staffBindingSource = new();
        private BindingSource _itemBindingSource = new();

        private ErrorProvider _errorProvider = new();

        private DataView? tempDetails = null;
        public FrmMaintenance() : base()
        {
            InitializeComponent();

            InitCommands();
            LoadAllData();
            BindToControls();

            #region Event Registrations

            cbStaffID.SelectedIndexChanged += HandleCbStaffIDSelectedIndexChanged;
            cbItemID.SelectedIndexChanged += HandleCbItemIDSelectedIndexChanged;

            txtTotalAmount.TextChanged += HandleTxtPaidAmountTextChanged;
            txtPaidAmount.TextChanged += HandleTxtPaidAmountTextChanged;
            txtMaintenanceQty.TextChanged += HandleTxtMaintenanceQtyTextChanged;
            txtUnitPrice.TextChanged += HandleTxtMaintenanceQtyTextChanged;

            btnInsertMaintenanceItem.Click += HandleBtnInsertMaintenanceItemClicked;
            btnUpdateMaintenanceItem.Click += HandleBtnUpdateMaintenanceItemClicked;
            btnDeleteMaintenanceItem.Click += HandleBtnDeleteMaintenanceItemClicked;
            btnCancelMaintenanceItem.Click += HandleBtnCancelMaintenanceItemClicked;

            btnNewMaintenance.Click += HandleBtnNewMaintenanceClicked;
            btnInsertMaintenance.Click += HandleBtnInsertMaintenanceClicked;
            btnUpdateMaintenance.Click += HandleBtnUpdateMaintenanceClicked;
            btnCancelMaintenance.Click += HandleBtnCancelMaintenanceClicked;

            cbSearchMaintenance.SelectedIndexChanged += HandleSearchMaintenance;

            txtPaidAmount.GotFocus += HandleGotFocusEN;
            txtMaintenanceQty.GotFocus += HandleGotFocusEN;

            dgvMaintenanceItems.DataError += HandleDataError;

            dtpMaintenanceDate.Validating += HandleValidateMaintenanceDate;
            txtPaidAmount.Validating += HandleValidatePaidAmount;
            txtMaintenanceQty.Validating += HandleValidateQty;

            #endregion
        }

        private void HandleValidateMaintenanceDate(object? sender, CancelEventArgs e)
        {
            ErrorHelper.ValidateDtpNowOrPast(dtpMaintenanceDate, _errorProvider);
        }

        private void HandleValidateQty(object? sender, CancelEventArgs e)
        {
            var dataRowView = cbItemID.SelectedItem as DataRowView;
            if (dataRowView == null) return;

            int stockQty = int.Parse(dataRowView["StockQty"].ToString()!);
            string errMsg = $"Only {stockQty} left in stock!";
            if (string.IsNullOrWhiteSpace(txtMaintenanceQty.Text))
            {
                _errorProvider.SetError(txtMaintenanceQty, "Cannot be empty!");
                return;
            }
            if (!int.TryParse(txtMaintenanceQty.Text, out int x) || x <= 0 || x > stockQty)
            {
                _errorProvider.SetError(txtMaintenanceQty, errMsg);
                return;
            }

            _errorProvider.SetError(txtMaintenanceQty, string.Empty);

        }

        private void HandleValidatePaidAmount(object? sender, CancelEventArgs e)
        {
            string errMsg = "Only numbers are allowed!";
            if (string.IsNullOrWhiteSpace(txtPaidAmount.Text))
            {
                _errorProvider.SetError(txtPaidAmount, "Cannot be empty!");
                return;
            }
            if (!double.TryParse(txtPaidAmount.Text, out double n) || n <= 0)
            {
                _errorProvider.SetError(txtPaidAmount, errMsg);
                return;
            }
            if (!double.TryParse(txtTotalAmount.Text, out double t) || n > t)
            {
                _errorProvider.SetError(txtPaidAmount, "Cannot be greater than TotalAmount");
                return;
            }

            _errorProvider.SetError(txtPaidAmount, string.Empty);

        }

        private void UpdateTotalAmount()
        {
            DataRowView masterRowView = (_maintenanceBindingSource.Current as DataRowView)!;

            if (tempDetails == null) return;
            
            decimal totalAmount = 0;

            foreach (DataRowView r in tempDetails)
            {
                totalAmount += decimal.Parse(r["Amount"].ToString()!);
            }

            if (masterRowView != null)
            {
                masterRowView["TotalAmount"] = totalAmount;
            }
        }

        private void HandleDataError(object? sender, DataGridViewDataErrorEventArgs e)
        {
            // do nothing just to fix bug on datagridview
        }


        #region Handle Cancel
        private void HandleBtnCancelMaintenanceClicked(object? sender, EventArgs e)
        {
            _errorProvider.Clear();
            RefreshComboBox();
        }
        #endregion

        #region Handle Update
        private void HandleBtnUpdateMaintenanceClicked(object? sender, EventArgs e)
        {
            HandleBtnInsertMaintenanceClicked(null, EventArgs.Empty);
        }
        #endregion

        #region Handle Insert
        private void HandleBtnInsertMaintenanceClicked(object? sender, EventArgs e)
        {
            HandleValidatePaidAmount(null, null!);
            HandleValidateMaintenanceDate(null, null!);

            if (!string.IsNullOrEmpty(_errorProvider.GetError(txtPaidAmount)) || !string.IsNullOrEmpty(_errorProvider.GetError(dtpMaintenanceDate))) return;

            if (tempDetails == null || tempDetails.Count == 0)
            {
                MessageBox.Show("សូមបញ្ចូលសម្ភារៈ", "ថែមទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _maintenanceDataAdapter.InsertCommand.Parameters["@MaintenanceDetails"].Value = tempDetails.ToTable();
            _maintenanceDataAdapter.UpdateCommand.Parameters["@MaintenanceDetails"].Value = tempDetails.ToTable();

            _maintenanceBindingSource.EndEdit();
            try
            {
                _maintenanceDataAdapter.Update(_storeRentalDataSet);
                _maintenanceBindingSource.ResetBindings(false);
            }
            catch (Exception)
            {
                MessageBox.Show("ការបញ្ខូលឬកែប្រែមិនបានសម្រេច", "បញ្ខូលឬកែប្រែ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            RefreshComboBox();
        }
        #endregion

        #region Handle New
        private void HandleBtnNewMaintenanceClicked(object? sender, EventArgs e)
        {
            if (cbStaffID.Items.Count < 1)
            {
                MessageBox.Show("សូមបញ្ចូលបុគ្គលិកជាមុនសិន", "ថែមទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbStoreID.Items.Count < 1)
            {
                MessageBox.Show("សូមបញ្ចូលតូបជាមុនសិន", "ថែមទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (cbContractID.Items.Count < 1)
            {
                MessageBox.Show("សូមបញ្ចូលកិច្ចសន្យាជាមុនសិន", "ថែមទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (cbItemID.Items.Count < 1)
            {
                MessageBox.Show("សូមបញ្ចូលសម្ភារៈជាមុនសិន", "ថែមទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            UnbindWithControls();
            cbSearchMaintenance.SelectedIndexChanged -= HandleSearchMaintenance;

            try
            {
                _maintenanceBindingSource.AddNew();

                DataRowView masterRowView = (_maintenanceBindingSource.Current as DataRowView)!;

                masterRowView.BeginEdit();

                masterRowView["MaintenanceID"] = -1;

                masterRowView["MaintenanceDate"] = DateTime.Now;

                cbStaffID.SelectedIndex = 0;
                var dataRowView = cbStaffID.SelectedItem as DataRowView;
                masterRowView["StaffID"] = cbStaffID.SelectedValue;
                masterRowView["StaffName"] = dataRowView?["StaffName"];
                masterRowView["StaffPosition"] = dataRowView?["StaffPosition"];

                cbStoreID.SelectedIndex = 0;
                masterRowView["StoreID"] = cbStoreID.SelectedValue;

                cbContractID.SelectedIndex = 0;
                masterRowView["ContractID"] = cbContractID.SelectedValue;

                masterRowView.EndEdit();

                tempDetails = masterRowView.CreateChildView(RELATIONSHIP_NAME);

                _maintenanceDetailBindingSource.DataSource = tempDetails;
                dgvMaintenanceItems.DataSource = _maintenanceDetailBindingSource;

                txtMaintenanceQty.Text = string.Empty;
                cbItemID.SelectedIndex = 0;

            }
            catch (Exception)
            {
                MessageBox.Show("ការថែមទិន្នន័យមិនបានសម្រេច", "ថែមទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            BindToControls();
            cbSearchMaintenance.SelectedIndexChanged += HandleSearchMaintenance;
        }

        #endregion

        #region Handle Cancel Item
        private void HandleBtnCancelMaintenanceItemClicked(object? sender, EventArgs e)
        {
            _maintenanceDetailBindingSource.CancelEdit();
            tempDetails!.Table!.AcceptChanges();
            UpdateTotalAmount();

            cbItemID.SelectedIndex = 0;
        }
        #endregion

        #region Handle Delete Item
        private void HandleBtnDeleteMaintenanceItemClicked(object? sender, EventArgs e)
        {
            DataRowView masterRowView = (_maintenanceBindingSource.Current as DataRowView)!;

            if (masterRowView == null) return;
            if (int.Parse(masterRowView["MaintenanceID"].ToString()!) != -1) return;

            if (_maintenanceDetailBindingSource.Count == 0) return;
            if (_maintenanceDetailBindingSource.Current == null) return;
            
            _maintenanceDetailBindingSource.RemoveCurrent();

            _maintenanceDetailBindingSource.EndEdit();

            tempDetails!.Table!.AcceptChanges();
            UpdateTotalAmount();

            cbItemID.SelectedIndex = 0;
        }
        #endregion

        #region Handle Update Item
        private void HandleBtnUpdateMaintenanceItemClicked(object? sender, EventArgs e)
        {
            DataRowView masterRowView = (_maintenanceBindingSource.Current as DataRowView)!;

            if (masterRowView == null) return;
            if (int.Parse(masterRowView["MaintenanceID"].ToString()!) != -1) return;

            HandleValidateQty(null, null!);

            if (!string.IsNullOrEmpty(_errorProvider.GetError(txtMaintenanceQty))) return;
            

            DataRowView currentItem = (_maintenanceDetailBindingSource.Current as DataRowView)!;

            if (currentItem != null)
            {
                currentItem["ItemID"] = cbItemID.SelectedValue;
                currentItem["Description"] = txtItemDescription.Text;
                currentItem["UnitPrice"] = txtUnitPrice.Text;
                currentItem["Quantity"] = txtMaintenanceQty.Text;
                currentItem["Amount"] = txtAmount.Text;
            }

            try
            {
                _maintenanceDetailBindingSource.EndEdit();
            }
            catch (Exception)
            {
                MessageBox.Show("សម្ភារៈស្ទួន", "បញ្ខូលសម្ភារៈ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvMaintenanceItems.Refresh();
            }

            tempDetails!.Table!.AcceptChanges();
            UpdateTotalAmount();

            cbItemID.SelectedIndex = 0;
        }
        #endregion

        #region Handle Insert Item
        private void HandleBtnInsertMaintenanceItemClicked(object? sender, EventArgs e)
        {
            DataRowView masterRowView = (_maintenanceBindingSource.Current as DataRowView)!;

            if (masterRowView == null) return;
            if (int.Parse(masterRowView["MaintenanceID"].ToString()!) != -1) return;

            HandleValidateQty(null, null!);

            if (!string.IsNullOrEmpty(_errorProvider.GetError(txtMaintenanceQty))) return;

            object itemID = cbItemID.SelectedValue;
            string description = txtItemDescription.Text;
            string unitPrice = txtUnitPrice.Text;
            string maintenanceQty = txtMaintenanceQty.Text;
            string amount = txtAmount.Text;

            DataRowView? dataRowView = tempDetails?.AddNew();

            if (dataRowView == null) return;
            // reject changes made to existing rows when insert new row otherwise unique constraint violation occurs
            tempDetails!.Table!.RejectChanges();

            dataRowView.BeginEdit();
            dataRowView["MaintenanceID"] = masterRowView["MaintenanceID"];
            dataRowView["ItemID"] = itemID;
            dataRowView["Description"] = description;
            dataRowView["UnitPrice"] = unitPrice;
            dataRowView["Quantity"] = maintenanceQty;
            dataRowView["Amount"] = amount;

            try
            {
                dataRowView.EndEdit();
            }
            catch (Exception)
            {
                dataRowView.Delete();
                MessageBox.Show("សម្ភារៈស្ទួន", "បញ្ខូលសម្ភារៈ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvMaintenanceItems.Refresh();
            }
            tempDetails!.Table!.AcceptChanges();
            UpdateTotalAmount();

            txtMaintenanceQty.Text = string.Empty;
            cbItemID.SelectedIndex = 0;
            
        }
        #endregion

        #region Handle TxtPaidAmountTextChanged
        private void HandleTxtPaidAmountTextChanged(object? sender, EventArgs e)
        {
            if (decimal.TryParse(txtTotalAmount.Text, out decimal totalAmount) && decimal.TryParse(txtPaidAmount.Text, out decimal paidAmount))
            {
                txtOwedAmount.Text = (totalAmount - paidAmount).ToString();
            }
            else
            {
                txtOwedAmount.Text = string.Empty;
            }
        }
        #endregion

        #region Handle TxtMaintenanceQtyTextChanged
        private void HandleTxtMaintenanceQtyTextChanged(object? sender, EventArgs e)
        {
            if (int.TryParse(txtMaintenanceQty.Text, out int qty) && decimal.TryParse(txtUnitPrice.Text, out decimal unitPrice))
            {
                txtAmount.Text = (qty * unitPrice).ToString();
            }
            else
            {
                txtAmount.Text = string.Empty;
            }
        }
        #endregion

        #region Handle cbItemIDSelectedIndexChanged
        private void HandleCbItemIDSelectedIndexChanged(object? sender, EventArgs e)
        {
            var dataRowView = cbItemID.SelectedItem as DataRowView;
            txtItemDescription.Text = dataRowView?["ItemDescription"] as string ?? string.Empty;
            txtUnitPrice.Text = dataRowView?["UnitPrice"].ToString() ?? string.Empty;
        }
        #endregion

        #region Handle cbStaffIDSelectedIndexChanged
        private void HandleCbStaffIDSelectedIndexChanged(object? sender, EventArgs e)
        {
            var dataRowView = cbStaffID.SelectedItem as DataRowView;
            txtStaffName.Text = dataRowView?["StaffName"] as string ?? string.Empty;
            txtStaffPosition.Text = dataRowView?["StaffPosition"] as string ?? string.Empty;
        }
        #endregion

        #region HandleGotFocusEN
        private void HandleGotFocusEN(object? sender, EventArgs e)
        {
            KeyboardLayoutHelper.SwitchToEnglishKeyboard();
        }
        #endregion

        #region Init Commands
        private void InitCommands()
        {
            // maintenance
            _maintenanceDataAdapter.InsertCommand = MaintenanceHelper.CreateInsertOrUpdateMaintenanceCommand();
            _maintenanceDataAdapter.SelectCommand = MaintenanceHelper.CreateGetAllMaintenancesCommand();
            _maintenanceDataAdapter.UpdateCommand = MaintenanceHelper.CreateInsertOrUpdateMaintenanceCommand();

            // maintenance detail
            _maintenanceDetailDataAdapter.SelectCommand = MaintenanceHelper.CreateGetAllMaintenanceDetailsCommand();

            // supplier
            _storeDataAdapter.SelectCommand = MaintenanceHelper.CreateGetAllStoresForComboBoxCommand();

            // contract
            _contractDataAdapter.SelectCommand = MaintenanceHelper.CreateGetAllContractsForComboBoxCommand();

            // staff
            _staffDataAdapter.SelectCommand = MaintenanceHelper.CreateGetAllStaffsForComboBoxCommand();

            // item
            _itemDataAdapter.SelectCommand = MaintenanceHelper.CreateGetAllItemsForComboBoxCommand();
        }
        #endregion

        #region Bind To Controls
        private void BindToControls()
        {
            txtMaintenanceID.DataBindings.Add(new Binding("Text", _maintenanceBindingSource, "MaintenanceID"));
            dtpMaintenanceDate.DataBindings.Add(new Binding("Value", _maintenanceBindingSource, "MaintenanceDate"));
            txtTotalAmount.DataBindings.Add(new Binding("Text", _maintenanceBindingSource, "TotalAmount"));
            txtPaidAmount.DataBindings.Add(new Binding("Text", _maintenanceBindingSource, "PaidAmount"));
            txtOwedAmount.DataBindings.Add(new Binding("Text", _maintenanceBindingSource, "OwedAmount"));
            cbStoreID.DataBindings.Add(new Binding("SelectedValue", _maintenanceBindingSource, "StoreID"));
            cbContractID.DataBindings.Add(new Binding("SelectedValue", _maintenanceBindingSource, "ContractID"));
            cbStaffID.DataBindings.Add(new Binding("SelectedValue", _maintenanceBindingSource, "StaffID"));
            txtStaffName.DataBindings.Add(new Binding("Text", _maintenanceBindingSource, "StaffName"));
            txtStaffPosition.DataBindings.Add(new Binding("Text", _maintenanceBindingSource, "StaffPosition"));

            cbItemID.DataBindings.Add(new Binding("SelectedValue", _maintenanceDetailBindingSource, "ItemID"));
            txtItemDescription.DataBindings.Add(new Binding("Text", _maintenanceDetailBindingSource, "Description"));
            txtMaintenanceQty.DataBindings.Add(new Binding("Text", _maintenanceDetailBindingSource, "Quantity"));
            txtUnitPrice.DataBindings.Add(new Binding("Text", _maintenanceDetailBindingSource, "UnitPrice"));
            txtAmount.DataBindings.Add(new Binding("Text", _maintenanceDetailBindingSource, "Amount"));
        }
        #endregion

        #region Unbind with controls
        private void UnbindWithControls()
        {
            txtMaintenanceID.DataBindings.Clear();
            dtpMaintenanceDate.DataBindings.Clear();
            txtTotalAmount.DataBindings.Clear();
            txtPaidAmount.DataBindings.Clear();
            txtOwedAmount.DataBindings.Clear();
            cbStoreID.DataBindings.Clear();
            cbContractID.DataBindings.Clear();
            cbStaffID.DataBindings.Clear();
            txtStaffName.DataBindings.Clear();
            txtStaffPosition.DataBindings.Clear();

            cbItemID.DataBindings.Clear();
            txtItemDescription.DataBindings.Clear();
            txtMaintenanceQty.DataBindings.Clear();
            txtUnitPrice.DataBindings.Clear();
            txtAmount.DataBindings.Clear();
        }
        #endregion

        #region Handle Search
        private void HandleSearchMaintenance(object? sender, EventArgs e)
        {
            DataRowView? selectedImport = (cbSearchMaintenance.SelectedItem as DataRowView);
            if (selectedImport != null)
            {
                tempDetails = selectedImport.CreateChildView(RELATIONSHIP_NAME);

                _maintenanceDetailBindingSource.DataSource = tempDetails;
                dgvMaintenanceItems.DataSource = _maintenanceDetailBindingSource;
            }
        }
        #endregion

        #region Load All Data
        private void LoadAllData()
        {
            _maintenanceDataAdapter.TableMappings.Add("Table", TABLE_MAINTENANCE_NAME);
            _maintenanceDetailDataAdapter.TableMappings.Add("Table", TABLE_MAINTENANCE_DETAIL_NAME);
            _storeDataAdapter.TableMappings.Add("Table", TABLE_STORE_NAME);
            _contractDataAdapter.TableMappings.Add("Table", TABLE_CONTRACT_NAME);
            _staffDataAdapter.TableMappings.Add("Table", TABLE_STAFF_NAME);
            _itemDataAdapter.TableMappings.Add("Table", TABLE_ITEM_NAME);

            try
            {
                _maintenanceDataAdapter.Fill(_storeRentalDataSet, TABLE_MAINTENANCE_NAME);
                _maintenanceDetailDataAdapter.Fill(_storeRentalDataSet, TABLE_MAINTENANCE_DETAIL_NAME);
                _storeDataAdapter.Fill(_storeRentalDataSet, TABLE_STORE_NAME);
                _contractDataAdapter.Fill(_storeRentalDataSet, TABLE_CONTRACT_NAME);
                _staffDataAdapter.Fill(_storeRentalDataSet, TABLE_STAFF_NAME);
                _itemDataAdapter.Fill(_storeRentalDataSet, TABLE_ITEM_NAME);
            }
            catch (Exception)
            {
                MessageBox.Show("ការទាញទិន្នន័យមិនបានសម្រេច", "ទាញទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // setting primary keys on tables
            _storeRentalDataSet.Tables[TABLE_MAINTENANCE_NAME]!.PrimaryKey = new DataColumn[]
            {
                _storeRentalDataSet.Tables[TABLE_MAINTENANCE_NAME]!.Columns["MaintenanceID"]!,
            };
            _storeRentalDataSet.Tables[TABLE_MAINTENANCE_DETAIL_NAME]!.PrimaryKey = new DataColumn[]
            {
                _storeRentalDataSet.Tables[TABLE_MAINTENANCE_DETAIL_NAME]!.Columns["MaintenanceID"]!,
                _storeRentalDataSet.Tables[TABLE_MAINTENANCE_DETAIL_NAME]!.Columns["ItemID"]!,
            };
            _storeRentalDataSet.Tables[TABLE_STORE_NAME]!.PrimaryKey = new DataColumn[]
            {
                _storeRentalDataSet.Tables[TABLE_STORE_NAME]!.Columns["StoreID"]!,
            };
            _storeRentalDataSet.Tables[TABLE_CONTRACT_NAME]!.PrimaryKey = new DataColumn[]
            {
                _storeRentalDataSet.Tables[TABLE_CONTRACT_NAME]!.Columns["ContractID"]!,
            };
            _storeRentalDataSet.Tables[TABLE_STAFF_NAME]!.PrimaryKey = new DataColumn[]
            {
                _storeRentalDataSet.Tables[TABLE_STAFF_NAME]!.Columns["StaffID"]!,
            };
            _storeRentalDataSet.Tables[TABLE_ITEM_NAME]!.PrimaryKey = new DataColumn[]
            {
                _storeRentalDataSet.Tables[TABLE_ITEM_NAME]!.Columns["ItemID"]!,
            };


            _maintenanceBindingSource.DataSource = _storeRentalDataSet.Tables[TABLE_MAINTENANCE_NAME]!.AsDataView();
            cbSearchMaintenance.DataSource = _maintenanceBindingSource;
            cbSearchMaintenance.DisplayMember = "MaintenanceID";
            cbSearchMaintenance.ValueMember = "MaintenanceID";

            _maintenanceDetailBindingSource.DataSource = _storeRentalDataSet.Tables[TABLE_MAINTENANCE_DETAIL_NAME]!.AsDataView();

            _storeBindingSource.DataSource = _storeRentalDataSet.Tables[TABLE_STORE_NAME]!.AsDataView();
            cbStoreID.DataSource = _storeBindingSource;
            cbStoreID.DisplayMember = "StoreID";
            cbStoreID.ValueMember = "StoreID";

            _contractBindingSource.DataSource = _storeRentalDataSet.Tables[TABLE_CONTRACT_NAME]!.AsDataView();
            cbContractID.DataSource = _contractBindingSource;
            cbContractID.DisplayMember = "ContractID";
            cbContractID.ValueMember = "ContractID";

            _staffBindingSource.DataSource = _storeRentalDataSet.Tables[TABLE_STAFF_NAME]!.AsDataView();
            cbStaffID.DataSource = _staffBindingSource;
            cbStaffID.DisplayMember = "StaffID";
            cbStaffID.ValueMember = "StaffID";

            _itemBindingSource.DataSource = _storeRentalDataSet.Tables[TABLE_ITEM_NAME]!.AsDataView();
            cbItemID.DataSource = _itemBindingSource;
            cbItemID.DisplayMember = "ItemID";
            cbItemID.ValueMember = "ItemID";

            // create and add relation
            DataRelation relation = new DataRelation(RELATIONSHIP_NAME, _storeRentalDataSet.Tables[TABLE_MAINTENANCE_NAME]!.Columns["MaintenanceID"]!, _storeRentalDataSet.Tables[TABLE_MAINTENANCE_DETAIL_NAME]!.Columns["MaintenanceID"]!);

            _storeRentalDataSet.Relations.Add(relation);

            HandleCbItemIDSelectedIndexChanged(null, EventArgs.Empty);
            HandleCbStaffIDSelectedIndexChanged(null, EventArgs.Empty);

            if (cbSearchMaintenance.Items.Count > 0)
            {
                cbSearchMaintenance.SelectedIndex = 0;
            }

            HandleSearchMaintenance(null, EventArgs.Empty);
        }
        #endregion

        #region Refresh
        private void RefreshComboBox()
        {
            UnbindWithControls();

            _storeRentalDataSet.Clear();

            try
            {
                _maintenanceDataAdapter.Fill(_storeRentalDataSet, TABLE_MAINTENANCE_NAME);
                _maintenanceDetailDataAdapter.Fill(_storeRentalDataSet, TABLE_MAINTENANCE_DETAIL_NAME);
                _contractDataAdapter.Fill(_storeRentalDataSet, TABLE_CONTRACT_NAME);
                _storeDataAdapter.Fill(_storeRentalDataSet, TABLE_STORE_NAME);
                _staffDataAdapter.Fill(_storeRentalDataSet, TABLE_STAFF_NAME);
                _itemDataAdapter.Fill(_storeRentalDataSet, TABLE_ITEM_NAME);

            }
            catch (Exception)
            {
                MessageBox.Show("ការទាញទិន្នន័យមិនបានសម្រេច", "ទាញទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (cbSearchMaintenance.Items.Count > 0)
            {
                cbSearchMaintenance.SelectedIndex = 0;
            }

            HandleSearchMaintenance(null, EventArgs.Empty);
            BindToControls();
        }
        #endregion
    }
}
