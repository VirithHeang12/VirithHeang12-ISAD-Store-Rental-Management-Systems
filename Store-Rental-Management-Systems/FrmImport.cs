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
        private const string TABLE_IMPORT_NAME = "tblInsurance";
        private const string TABLE_IMPORT_DETAIL_NAME = "tblImportDetail";
        private const string TABLE_SUPPLIER_NAME = "tblSupplier";
        private const string TABLE_STAFF_NAME = "tblStaff";
        private const string TABLE_ITEM_NAME = "tblItem";

        private DataSet _storeRentalDataSet = new();

        private SqlDataAdapter _importDataAdapter = new();
        private SqlDataAdapter _importDetailDataAdapter = new();
        private SqlDataAdapter _supplierDataAdapter = new();
        private SqlDataAdapter _staffDataAdapter =  new();
        private SqlDataAdapter _itemDataAdapter = new();

        private BindingSource _importBindingSource = new();
        private BindingSource _importDetailBindingSource = new();
        private BindingSource _supplierBindingSource = new();
        private BindingSource _staffBindingSource = new();
        private BindingSource _itemBindingSource = new();

        private ErrorProvider _errorProvider = new();

        private List<Control> _validatingControls = new();

        public FrmImport() : base()
        {
            InitializeComponent();

            _errorProvider.ContainerControl = this;

            InitCommands();
            LoadAllData();
            BindToControls();

            cbSupplierID.TextChanged += HandleTextCbSupplierIDChanged;
            cbStaffID.TextChanged += HandleTextCbStaffIDChanged;
            cbItemID.TextChanged += HandleTextcbItemIDChanged;

        }

        private void HandleTextcbItemIDChanged(object? sender, EventArgs e)
        {
            string searchID = cbItemID.Text.Trim();

            var dataView = _storeRentalDataSet.Tables[TABLE_ITEM_NAME]!.AsDataView();

            if (string.IsNullOrEmpty(searchID))
            {
                dataView.RowFilter = string.Empty;
                cbItemID.DroppedDown = true;
            }
            else
            {
                dataView.RowFilter = $"CONVERT(ItemID, 'System.String') LIKE '%{searchID}%'";

                if (dataView.Count > 0)
                {
                    dataView.RowFilter = string.Empty;
                }
            }

            if (dataView.Count > 0)
            {
                cbItemID.Select(cbItemID.Text.Length, 0); // Keep the caret at the end
            }
            else
            {
                cbItemID.DroppedDown = false;
            }


            // Set the original text back to the ComboBox (to keep the user input)
            cbItemID.Text = searchID;
            cbItemID.SelectionStart = searchID.Length;
            cbItemID.SelectionLength = 0;

            //_supplierBindingSource.DataSource = dataView;
        }

        private void HandleTextCbStaffIDChanged(object? sender, EventArgs e)
        {
            string searchID = cbStaffID.Text.Trim();

            var dataView = _storeRentalDataSet.Tables[TABLE_STAFF_NAME]!.AsDataView();

            if (string.IsNullOrEmpty(searchID))
            {
                dataView.RowFilter = string.Empty;
                cbStaffID.DroppedDown = true;
            }
            else
            {
                dataView.RowFilter = $"CONVERT(StaffID, 'System.String') LIKE '%{searchID}%'";

                if (dataView.Count > 0)
                {
                    dataView.RowFilter = string.Empty;
                }
            }

            if (dataView.Count > 0)
            {
                cbStaffID.Select(cbStaffID.Text.Length, 0); // Keep the caret at the end
            }
            else
            {
                cbStaffID.DroppedDown = false;
            }


            // Set the original text back to the ComboBox (to keep the user input)
            cbStaffID.Text = searchID;
            cbStaffID.SelectionStart = searchID.Length;
            cbStaffID.SelectionLength = 0;

            //_supplierBindingSource.DataSource = dataView;
        }

        private void HandleTextCbSupplierIDChanged(object? sender, EventArgs e)
        {
            string searchID = cbSupplierID.Text.Trim();

            var dataView = _storeRentalDataSet.Tables[TABLE_SUPPLIER_NAME]!.AsDataView();

            if (string.IsNullOrEmpty(searchID))
            {
                dataView.RowFilter = string.Empty;
                cbSupplierID.DroppedDown = true;
            } 
            else
            {
                dataView.RowFilter = $"CONVERT(SupplierID, 'System.String') LIKE '%{searchID}%'";

                if (dataView.Count > 0)
                {
                    dataView.RowFilter = string.Empty;
                }
            }

            if (dataView.Count > 0)
            {
                cbSupplierID.Select(cbSupplierID.Text.Length, 0); // Keep the caret at the end
            }
            else
            {
                cbSupplierID.DroppedDown = false;
            }


            // Set the original text back to the ComboBox (to keep the user input)
            cbSupplierID.Text = searchID;
            cbSupplierID.SelectionStart = searchID.Length;
            cbSupplierID.SelectionLength = 0;

            //_supplierBindingSource.DataSource = dataView;
        }

        private void InitCommands()
        {
            // import
            _importDataAdapter.SelectCommand = ImportHelper.CreateGetAllImportsCommand();
            _importDataAdapter.InsertCommand = ImportHelper.CreateInsertImportCommand();
            _importDataAdapter.UpdateCommand = ImportHelper.CreateUpdateImportCommand();

            // import detail
            _importDetailDataAdapter.SelectCommand = ImportHelper.CreateGetAllImportDetailsCommand();
            _importDetailDataAdapter.InsertCommand = ImportHelper.CreateInsertImportDetailCommand();
            _importDetailDataAdapter.UpdateCommand= ImportHelper.CreateUpdateImportDetailCommand();

            // supplier
            _supplierDataAdapter.SelectCommand = ImportHelper.CreateGetAllSuppliersForComboBoxCommand();

            // staff
            _staffDataAdapter.SelectCommand = ImportHelper.CreateGetAllStaffsForComboBoxCommand();

            // item
            _itemDataAdapter.SelectCommand = ImportHelper.CreateGetAllItemsForComboBoxCommand();
        }

        private void BindToControls()
        {
            // binding for searching import
            txtImportID.DataBindings.Add(new Binding("Text", _importBindingSource, "ImportID"));
            dtpImportDate.DataBindings.Add(new Binding("Value", _importBindingSource, "ImportDate"));
            txtTotalAmount.DataBindings.Add(new Binding("Text", _importBindingSource, "TotalAmount"));
            //cbSupplierID.DataBindings.Add(new Binding("Text", _importBindingSource, "SupplierID"));
            //txtSupplierName.DataBindings.Add(new Binding("Text", _importBindingSource, "SupplierName"));
            //cbStaffID.DataBindings.Add(new Binding("Text", _importBindingSource, "StaffID"));
            //txtStaffName.DataBindings.Add(new Binding("Text", _importBindingSource, "StaffName"));
            //txtStaffPosition.DataBindings.Add(new Binding("Text", _importBindingSource, "StaffPosition"));

            // binding for choosing supplier
            cbSupplierID.DataBindings.Add(new Binding("SelectedItem", _supplierBindingSource, "SupplierID"));
            txtSupplierName.DataBindings.Add(new Binding("Text", _supplierBindingSource, "SupplierName"));


            // binding for choosing staff
            cbStaffID.DataBindings.Add(new Binding("SelectedItem", _staffBindingSource, "StaffID"));
            txtStaffName.DataBindings.Add(new Binding("Text", _staffBindingSource, "StaffName"));
            txtStaffPosition.DataBindings.Add(new Binding("Text", _staffBindingSource, "StaffPosition"));

            // binding for choosing item
            cbItemID.DataBindings.Add(new Binding("SelectedItem", _itemBindingSource, "ItemID"));
            txtItemDescription.DataBindings.Add(new Binding("Text", _itemBindingSource, "ItemDescription"));
            txtUnitPrice.DataBindings.Add(new Binding("Text", _itemBindingSource, "UnitPrice"));
            txtCategory.DataBindings.Add(new Binding("Text", _itemBindingSource, "Category"));

            // binding for selecting each row in dgv
            txtImportQty.DataBindings.Add(new Binding("Text", _importDetailBindingSource, "ImportQty"));
            txtAmount.DataBindings.Add(new Binding("Text", _importDetailBindingSource, "Amount"));
            //cbItemID.DataBindings.Add(new Binding("Text", _importDetailBindingSource, "ItemID"));
            //txtItemDescription.DataBindings.Add(new Binding("Text", _importDetailBindingSource, "Description"));
            //txtUnitPrice.DataBindings.Add(new Binding("Text", _importDetailBindingSource, "UnitPrice"));
        }

        private void LoadAllData()
        {
            // filling tblImport DataTable
            _importDataAdapter.TableMappings.Add("Table", TABLE_IMPORT_NAME);
            _importDataAdapter.Fill(_storeRentalDataSet, TABLE_IMPORT_NAME);

            // filling tblImportDetail DataTable
            _importDetailDataAdapter.TableMappings.Add("Table1", TABLE_IMPORT_DETAIL_NAME);
            _importDetailDataAdapter.Fill(_storeRentalDataSet, TABLE_IMPORT_DETAIL_NAME);

            // filling tblSupplier DataTable
            _supplierDataAdapter.TableMappings.Add("Table2", TABLE_SUPPLIER_NAME);
            _supplierDataAdapter.Fill(_storeRentalDataSet, TABLE_SUPPLIER_NAME);

            // filling tblStaff DataTable
            _staffDataAdapter.TableMappings.Add("Table3", TABLE_STAFF_NAME);
            _staffDataAdapter.Fill(_storeRentalDataSet, TABLE_STAFF_NAME);

            // filling tblItem DataTable
            _itemDataAdapter.TableMappings.Add("Table4", TABLE_ITEM_NAME);
            _itemDataAdapter.Fill(_storeRentalDataSet, TABLE_ITEM_NAME);

            // bind to import search combo box
            _importBindingSource.DataSource = _storeRentalDataSet.Tables[TABLE_IMPORT_NAME];
            cbSearchImport.DataSource = _importBindingSource;

            // bind to dgvItems
            _importDetailBindingSource.DataSource = _storeRentalDataSet.Tables[TABLE_IMPORT_DETAIL_NAME];
            dgvImportItems.DataSource = _importDetailBindingSource;

            // bind to supplierID combo box
            _supplierBindingSource.DataSource = _storeRentalDataSet.Tables[TABLE_SUPPLIER_NAME]!.AsDataView();
            cbSupplierID.DataSource = _supplierBindingSource;
            cbSupplierID.DisplayMember = "SupplierID";
            cbSupplierID.ValueMember = "SupplierID";

            // bind to staffID combo box
            _staffBindingSource.DataSource = _storeRentalDataSet.Tables[TABLE_STAFF_NAME]!.AsDataView();
            cbStaffID.DataSource = _staffBindingSource;
            cbStaffID.DisplayMember = "StaffID";
            cbStaffID.ValueMember = "StaffID";

            // bind to itemID combo box
            _itemBindingSource.DataSource = _storeRentalDataSet.Tables[TABLE_ITEM_NAME]!.AsDataView();
            cbItemID.DataSource = _itemBindingSource;
            cbItemID.DisplayMember = "ItemID";
            cbItemID.ValueMember = "ItemID";
   
        }
    }
}
