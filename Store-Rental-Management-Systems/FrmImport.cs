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
    public partial class FrmImport : FrmHome
    {
        private const string RELATIONSHIP_NAME = "import_importDetail";

        private const string TABLE_IMPORT_NAME = "tblImport";
        private const string TABLE_IMPORT_DETAIL_NAME = "tblImportDetail";
        private const string TABLE_SUPPLIER_NAME = "tblSupplier";
        private const string TABLE_STAFF_NAME = "tblStaff";
        private const string TABLE_ITEM_NAME = "tblItem";

        private DataSet _storeRentalDataSet = new();

        private SqlDataAdapter _importDataAdapter = new();
        private SqlDataAdapter _importDetailDataAdapter = new();
        private SqlDataAdapter _supplierDataAdapter = new();
        private SqlDataAdapter _staffDataAdapter = new();
        private SqlDataAdapter _itemDataAdapter = new();

        private BindingSource _importBindingSource = new();
        private BindingSource _importDetailBindingSource = new();
        private BindingSource _supplierBindingSource = new();
        private BindingSource _staffBindingSource = new();
        private BindingSource _itemBindingSource = new();

        private ErrorProvider _errorProvider = new();

        private DataView? tempDetails = null;

        public FrmImport() : base()
        {
            InitializeComponent();

            InitCommands();
            LoadAllData();
            BindToControls();

            #region Event Registrations
            cbSupplierID.SelectedIndexChanged += HandleCbSupplierIDSelectedIndexChanged;
            cbStaffID.SelectedIndexChanged += HandleCbStaffIDSelectedIndexChanged;
            cbItemID.SelectedIndexChanged += HandleCbItemIDSelectedIndexChanged;

            txtImportQty.TextChanged += HandleTxtImportQtyTextChanged;
            txtUnitPrice.TextChanged += HandleTxtImportQtyTextChanged;

            btnInsertImportItem.Click += HandleBtnInsertImportItemClicked;
            btnUpdateImportItem.Click += HandleBtnUpdateImportItemClicked;
            btnDeleteImportItem.Click += HandleBtnDeleteImportItemClicked;
            btnCancelImportItem.Click += HandleBtnCancelImportItemClicked;

            btnNewImport.Click += HandleBtnNewImportClicked;
            btnInsertImport.Click += HandleBtnInsertImportClicked;
            btnUpdateImport.Click += HandleBtnUpdateImportClicked;
            btnCancelImport.Click += HandleBtnCancelImportClicked;

            cbSearchImport.SelectedIndexChanged += HandleSearchImport;

            cbSupplierID.GotFocus += HandleGotFocusEN;
            cbStaffID.GotFocus += HandleGotFocusEN;
            cbItemID.GotFocus += HandleGotFocusEN;
            txtImportQty.GotFocus += HandleGotFocusEN;

            dgvImportItems.DataError += HandleDataError;

            txtImportQty.Validating += HandleValidateImportQty;
            dtpImportDate.Validating += HandleValidateImportDate;
            #endregion
        }

        private void HandleValidateImportDate(object? sender, CancelEventArgs e)
        {
            ErrorHelper.ValidateDtpNowOrPast(dtpImportDate, _errorProvider);
        }

        private void HandleValidateImportQty(object? sender, CancelEventArgs e)
        {
            ErrorHelper.ValidateTextBoxInteger(txtImportQty, _errorProvider);
        }

        private void HandleDataError(object? sender, DataGridViewDataErrorEventArgs e)
        {
            // do nothing just to fix bug on datagridview
        }

        private void UpdateTotalAmount()
        {
            DataRowView masterRowView = (_importBindingSource.Current as DataRowView)!;

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

        #region Init Commands
        private void InitCommands()
        {
            // import
            _importDataAdapter.InsertCommand = ImportHelper.CreateInsertOrUpdateImportCommand();
            _importDataAdapter.SelectCommand = ImportHelper.CreateGetAllImportsCommand();
            _importDataAdapter.UpdateCommand = ImportHelper.CreateInsertOrUpdateImportCommand();

            // import detail
            _importDetailDataAdapter.SelectCommand = ImportHelper.CreateGetAllImportDetailsCommand();

            // supplier
            _supplierDataAdapter.SelectCommand = ImportHelper.CreateGetAllSuppliersForComboBoxCommand();

            // staff
            _staffDataAdapter.SelectCommand = ImportHelper.CreateGetAllStaffsForComboBoxCommand();

            // item
            _itemDataAdapter.SelectCommand = ImportHelper.CreateGetAllItemsForComboBoxCommand();
        }
        #endregion

        #region Bind To Controls
        private void BindToControls()
        {
            txtImportID.DataBindings.Add(new Binding("Text", _importBindingSource, "ImportID"));
            dtpImportDate.DataBindings.Add(new Binding("Value", _importBindingSource, "ImportDate"));
            txtTotalAmount.DataBindings.Add(new Binding("Text", _importBindingSource, "TotalAmount"));
            cbSupplierID.DataBindings.Add(new Binding("SelectedValue", _importBindingSource, "SupplierID"));
            txtSupplierName.DataBindings.Add(new Binding("Text", _importBindingSource, "SupplierName"));
            cbStaffID.DataBindings.Add(new Binding("SelectedValue", _importBindingSource, "StaffID"));
            txtStaffName.DataBindings.Add(new Binding("Text", _importBindingSource, "StaffName"));
            txtStaffPosition.DataBindings.Add(new Binding("Text", _importBindingSource, "StaffPosition"));

            cbItemID.DataBindings.Add(new Binding("SelectedValue", _importDetailBindingSource, "ItemID"));
            txtItemDescription.DataBindings.Add(new Binding("Text", _importDetailBindingSource, "Description"));
            txtImportQty.DataBindings.Add(new Binding("Text", _importDetailBindingSource, "ImportQty"));
            txtUnitPrice.DataBindings.Add(new Binding("Text", _importDetailBindingSource, "UnitPrice"));
            txtAmount.DataBindings.Add(new Binding("Text", _importDetailBindingSource, "Amount"));
        }
        #endregion

        #region Unbind with controls
        private void UnbindWithControls()
        {
            txtImportID.DataBindings.Clear();
            dtpImportDate.DataBindings.Clear();
            txtTotalAmount.DataBindings.Clear();
            cbSupplierID.DataBindings.Clear();
            txtSupplierName.DataBindings.Clear();
            cbStaffID.DataBindings.Clear();
            txtStaffName.DataBindings.Clear();
            txtStaffPosition.DataBindings.Clear();

            cbItemID.DataBindings.Clear();
            txtItemDescription.DataBindings.Clear();
            txtImportQty.DataBindings.Clear();
            txtUnitPrice.DataBindings.Clear();
            txtAmount.DataBindings.Clear();
        }
        #endregion

        #region Handle Cancel
        private void HandleBtnCancelImportClicked(object? sender, EventArgs e)
        {
            _errorProvider.Clear();
            RefreshComboBox();
        }
        #endregion

        #region Handle Update
        private void HandleBtnUpdateImportClicked(object? sender, EventArgs e)
        {
            HandleBtnInsertImportClicked(null, EventArgs.Empty);
        }
        #endregion

        #region Handle Insert
        private void HandleBtnInsertImportClicked(object? sender, EventArgs e)
        {
            HandleValidateImportDate(null, null!);
            if (!string.IsNullOrEmpty(_errorProvider.GetError(dtpImportDate))) return;

            if (tempDetails == null || tempDetails.Count == 0)
            {
                MessageBox.Show("សូមបញ្ចូលសម្ភារៈ", "ថែមទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _importDataAdapter.InsertCommand.Parameters["@ImportDetails"].Value = tempDetails.ToTable();
            _importDataAdapter.UpdateCommand.Parameters["@ImportDetails"].Value = tempDetails.ToTable();

            _importBindingSource.EndEdit();
            try
            {
                _importDataAdapter.Update(_storeRentalDataSet);
                _importBindingSource.ResetBindings(false);
            }
            catch (Exception)
            {
                MessageBox.Show("ការបញ្ខូលឬកែប្រែមិនបានសម្រេច", "បញ្ខូលឬកែប្រែ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            RefreshComboBox();
        }

        #endregion

        #region Handle New
        private void HandleBtnNewImportClicked(object? sender, EventArgs e)
        {
            if (cbStaffID.Items.Count < 1)
            {
                MessageBox.Show("សូមបញ្ចូលបុគ្គលិកជាមុនសិន", "ថែមទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbSupplierID.Items.Count < 1)
            {
                MessageBox.Show("សូមបញ្ចូលអ្នកផ្គត់ផ្គង់ជាមុនសិន", "ថែមទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (cbItemID.Items.Count < 1)
            {
                MessageBox.Show("សូមបញ្ចូលសម្ភារៈជាមុនសិន", "ថែមទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UnbindWithControls();
            cbSearchImport.SelectedIndexChanged -= HandleSearchImport;

            try
            {
                _importBindingSource.AddNew();

                DataRowView masterRowView = (_importBindingSource.Current as DataRowView)!;

                masterRowView.BeginEdit();

                masterRowView["ImportID"] = -1;

                masterRowView["ImportDate"] = DateTime.Now;

                cbStaffID.SelectedIndex = 0;
                var dataRowView = cbStaffID.SelectedItem as DataRowView;
                masterRowView["StaffID"] = cbStaffID.SelectedValue;
                masterRowView["StaffName"] = dataRowView?["StaffName"];
                masterRowView["StaffPosition"] = dataRowView?["StaffPosition"];

                cbSupplierID.SelectedIndex = 0;
                masterRowView["SupplierID"] = cbSupplierID.SelectedValue;
                dataRowView = cbSupplierID.SelectedItem as DataRowView;
                masterRowView["SupplierName"] = dataRowView?["SupplierName"];

                masterRowView.EndEdit();

                tempDetails = masterRowView.CreateChildView(RELATIONSHIP_NAME);

                _importDetailBindingSource.DataSource = tempDetails;
                dgvImportItems.DataSource = _importDetailBindingSource;

                txtImportQty.Text = string.Empty;
                cbItemID.SelectedIndex = 0;

            }
            catch (Exception)
            {
                MessageBox.Show("ការថែមទិន្នន័យមិនបានសម្រេច", "ថែមទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            BindToControls();
            cbSearchImport.SelectedIndexChanged += HandleSearchImport;
        }
        #endregion

        #region Handle Search
        private void HandleSearchImport(object? sender, EventArgs e)
        {
            DataRowView? selectedImport = (cbSearchImport.SelectedItem as DataRowView);
            if (selectedImport != null)
            {
                tempDetails = selectedImport.CreateChildView(RELATIONSHIP_NAME);

                _importDetailBindingSource.DataSource = tempDetails;
                dgvImportItems.DataSource = _importDetailBindingSource;
            }
        }
        #endregion

        #region Handle Cancel Item
        private void HandleBtnCancelImportItemClicked(object? sender, EventArgs e)
        {
            _importDetailBindingSource.CancelEdit();
            tempDetails!.Table!.AcceptChanges();

            UpdateTotalAmount();
            cbItemID.SelectedIndex = 0;
        }
        #endregion

        #region Handle Delete Item
        private void HandleBtnDeleteImportItemClicked(object? sender, EventArgs e)
        {
            if (_importDetailBindingSource.Count == 0) return;
            if (_importDetailBindingSource.Current == null) return;

            DataRowView masterRowView = (_importBindingSource.Current as DataRowView)!;
            if (masterRowView == null) return;
            if (int.Parse(masterRowView["ImportID"].ToString()!) != -1) return;

            _importDetailBindingSource.RemoveCurrent();

            _importDetailBindingSource.EndEdit();
            tempDetails!.Table!.AcceptChanges();

            UpdateTotalAmount();
            cbItemID.SelectedIndex = 0;        
        }
        #endregion

        #region Handle Update Item
        private void HandleBtnUpdateImportItemClicked(object? sender, EventArgs e)
        {
            DataRowView masterRowView = (_importBindingSource.Current as DataRowView)!;
            if (masterRowView == null) return;
            if (int.Parse(masterRowView["ImportID"].ToString()!) != -1) return;

            HandleValidateImportQty(null, null!);

            if (!string.IsNullOrEmpty(_errorProvider.GetError(txtImportQty))) return;

            DataRowView currentItem = (_importDetailBindingSource.Current as DataRowView)!;

            if (currentItem == null) return;

            currentItem["ItemID"] = cbItemID.SelectedValue;
            currentItem["Description"] = txtItemDescription.Text;
            currentItem["UnitPrice"] = txtUnitPrice.Text;
            currentItem["ImportQty"] = txtImportQty.Text;
            currentItem["Amount"] = txtAmount.Text;

            try
            {
                _importDetailBindingSource.EndEdit();
            }
            catch (Exception)
            {
                MessageBox.Show("សម្ភារៈស្ទួន", "បញ្ខូលសម្ភារៈ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvImportItems.Refresh();
            }
            tempDetails!.Table!.AcceptChanges();

            UpdateTotalAmount();
            cbItemID.SelectedIndex = 0;
        }
        #endregion

        #region Handle Insert Item
        private void HandleBtnInsertImportItemClicked(object? sender, EventArgs e)
        {
            DataRowView masterRowView = (_importBindingSource.Current as DataRowView)!;

            if (masterRowView == null) return;
            if (int.Parse(masterRowView["ImportID"].ToString()!) != -1) return;

            HandleValidateImportQty(null, null!);

            if (!string.IsNullOrEmpty(_errorProvider.GetError(txtImportQty))) return;


            object itemID = cbItemID.SelectedValue;
            string description = txtItemDescription.Text;
            string unitPrice = txtUnitPrice.Text;
            string importQty = txtImportQty.Text;
            string amount = txtAmount.Text;

            DataRowView? dataRowView = tempDetails?.AddNew();
                     
            if (dataRowView == null) return;
            // reject changes made to existing rows when insert new row otherwise unique constraint violation occurs
            tempDetails!.Table!.RejectChanges();

            dataRowView.BeginEdit();
            dataRowView["ImportID"] = masterRowView["ImportID"];
            dataRowView["ItemID"] = itemID;
            dataRowView["Description"] = description;         
            dataRowView["UnitPrice"] = unitPrice;
            dataRowView["ImportQty"] = importQty;
            dataRowView["Amount"] = amount;
      
            try
            {
                dataRowView.EndEdit();
            }
            catch (Exception)
            {
                dataRowView.Delete();
                MessageBox.Show("សម្ភារៈស្ទួន", "បញ្ខូលសម្ភារៈ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvImportItems.Refresh();
            }
            tempDetails!.Table!.AcceptChanges();

            UpdateTotalAmount();

            txtImportQty.Text = string.Empty;
            cbItemID.SelectedIndex = 0; 
        }

        #endregion

        #region Handle ImportQty TextChanged
        private void HandleTxtImportQtyTextChanged(object? sender, EventArgs e)
        {
            if (int.TryParse(txtImportQty.Text, out int qty) && decimal.TryParse(txtUnitPrice.Text, out decimal unitPrice))
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

        #region Handle cbSupplierIDSelectedIndexChanged
        private void HandleCbSupplierIDSelectedIndexChanged(object? sender, EventArgs e)
        {
            var dataRowView = cbSupplierID.SelectedItem as DataRowView;
            txtSupplierName.Text = dataRowView?["SupplierName"] as string ?? string.Empty;
        }
        #endregion

        #region HandleGotFocus
        private void HandleGotFocusEN(object? sender, EventArgs e)
        {
            KeyboardLayoutHelper.SwitchToEnglishKeyboard();
        }

        #endregion

        #region Load All Data
        private void LoadAllData()
        {
            _importDataAdapter.TableMappings.Add("Table", TABLE_IMPORT_NAME);
            _importDetailDataAdapter.TableMappings.Add("Table", TABLE_IMPORT_DETAIL_NAME);
            _supplierDataAdapter.TableMappings.Add("Table", TABLE_SUPPLIER_NAME);
            _staffDataAdapter.TableMappings.Add("Table", TABLE_STAFF_NAME);
            _itemDataAdapter.TableMappings.Add("Table", TABLE_ITEM_NAME);

            try
            {
                _importDataAdapter.Fill(_storeRentalDataSet, TABLE_IMPORT_NAME);
                _importDetailDataAdapter.Fill(_storeRentalDataSet, TABLE_IMPORT_DETAIL_NAME);
                _supplierDataAdapter.Fill(_storeRentalDataSet, TABLE_SUPPLIER_NAME);
                _staffDataAdapter.Fill(_storeRentalDataSet, TABLE_STAFF_NAME);
                _itemDataAdapter.Fill(_storeRentalDataSet, TABLE_ITEM_NAME);
            } catch (Exception)
            {
                MessageBox.Show("ការទាញទិន្នន័យមិនបានសម្រេច", "ទាញទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // setting primary keys on tables
            _storeRentalDataSet.Tables[TABLE_IMPORT_NAME]!.PrimaryKey = new DataColumn[]
            {
                _storeRentalDataSet.Tables[TABLE_IMPORT_NAME]!.Columns["ImportID"]!,
            };
            _storeRentalDataSet.Tables[TABLE_IMPORT_DETAIL_NAME]!.PrimaryKey = new DataColumn[]
            {
                _storeRentalDataSet.Tables[TABLE_IMPORT_DETAIL_NAME]!.Columns["ImportID"]!,
                _storeRentalDataSet.Tables[TABLE_IMPORT_DETAIL_NAME]!.Columns["ItemID"]!,
            };
            _storeRentalDataSet.Tables[TABLE_SUPPLIER_NAME]!.PrimaryKey = new DataColumn[]
            {
                _storeRentalDataSet.Tables[TABLE_SUPPLIER_NAME]!.Columns["SupplierID"]!,
            };
            _storeRentalDataSet.Tables[TABLE_STAFF_NAME]!.PrimaryKey = new DataColumn[]
            {
                _storeRentalDataSet.Tables[TABLE_STAFF_NAME]!.Columns["StaffID"]!,
            };
            _storeRentalDataSet.Tables[TABLE_ITEM_NAME]!.PrimaryKey = new DataColumn[]
            {
                _storeRentalDataSet.Tables[TABLE_ITEM_NAME]!.Columns["ItemID"]!,
            };


            _importBindingSource.DataSource = _storeRentalDataSet.Tables[TABLE_IMPORT_NAME]!.AsDataView();
            cbSearchImport.DataSource = _importBindingSource;
            cbSearchImport.DisplayMember = "ImportID";
            cbSearchImport.ValueMember = "ImportID";

            _importDetailBindingSource.DataSource = _storeRentalDataSet.Tables[TABLE_IMPORT_DETAIL_NAME]!.AsDataView();
   
            _supplierBindingSource.DataSource = _storeRentalDataSet.Tables[TABLE_SUPPLIER_NAME]!.AsDataView();
            cbSupplierID.DataSource = _supplierBindingSource;
            cbSupplierID.DisplayMember = "SupplierID";
            cbSupplierID.ValueMember = "SupplierID";

            _staffBindingSource.DataSource = _storeRentalDataSet.Tables[TABLE_STAFF_NAME]!.AsDataView();
            cbStaffID.DataSource = _staffBindingSource;
            cbStaffID.DisplayMember = "StaffID";
            cbStaffID.ValueMember = "StaffID";
   
            _itemBindingSource.DataSource = _storeRentalDataSet.Tables[TABLE_ITEM_NAME]!.AsDataView();
            cbItemID.DataSource = _itemBindingSource;
            cbItemID.DisplayMember = "ItemID";
            cbItemID.ValueMember = "ItemID";

            // create and add relation
            DataRelation relation = new DataRelation(RELATIONSHIP_NAME, _storeRentalDataSet.Tables[TABLE_IMPORT_NAME]!.Columns["ImportID"]!, _storeRentalDataSet.Tables[TABLE_IMPORT_DETAIL_NAME]!.Columns["ImportID"]!);

            _storeRentalDataSet.Relations.Add(relation);

            HandleCbItemIDSelectedIndexChanged(null, EventArgs.Empty);
            HandleCbStaffIDSelectedIndexChanged(null, EventArgs.Empty);
            HandleCbSupplierIDSelectedIndexChanged(null, EventArgs.Empty);

            if (cbSearchImport.Items.Count > 0)
            {
                cbSearchImport.SelectedIndex = 0;
            }

            HandleSearchImport(null, EventArgs.Empty);
        }
        #endregion

        #region Refresh
        private void RefreshComboBox()
        {
            UnbindWithControls();

            _storeRentalDataSet.Clear();

            try
            {
                _importDataAdapter.Fill(_storeRentalDataSet, TABLE_IMPORT_NAME);
                _importDetailDataAdapter.Fill(_storeRentalDataSet, TABLE_IMPORT_DETAIL_NAME);
                _supplierDataAdapter.Fill(_storeRentalDataSet, TABLE_SUPPLIER_NAME);
                _staffDataAdapter.Fill(_storeRentalDataSet, TABLE_STAFF_NAME);
                _itemDataAdapter.Fill(_storeRentalDataSet, TABLE_ITEM_NAME);
            }
            catch (Exception)
            {
                MessageBox.Show("ការទាញទិន្នន័យមិនបានសម្រេច", "ទាញទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (cbSearchImport.Items.Count > 0)
            {
                cbSearchImport.SelectedIndex = 0;
            }

            HandleCbItemIDSelectedIndexChanged(null, EventArgs.Empty);
            HandleCbStaffIDSelectedIndexChanged(null, EventArgs.Empty);
            HandleCbSupplierIDSelectedIndexChanged(null, EventArgs.Empty);
            HandleSearchImport(null, EventArgs.Empty);
            BindToControls();
        }
        #endregion
    }
}
