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
    public partial class FrmItem : FrmHome
    {
        private const string TABLE_NAME = "tblItem";
        private DataSet _storeRentalDataSet = new DataSet();
        private SqlDataAdapter _itemDataAdapter = new();
        private BindingSource _itemBindingSource = new();

        private ErrorProvider _errorProvider = new();

        private List<Control> _validatingControls = new();
        public FrmItem() : base()
        {
            InitializeComponent();
            #region Init DataAdapter Commands
            _itemDataAdapter.SelectCommand = ItemHelper.CreateGetAllItemsCommand();
            _itemDataAdapter.InsertCommand = ItemHelper.CreateInsertItemCommand();
            _itemDataAdapter.UpdateCommand = ItemHelper.CreateUpdateItemCommand();
            #endregion

            #region Add controls for validation
            _errorProvider.ContainerControl = this;
            _validatingControls.Add(txtItemDescription);
            _validatingControls.Add(txtUnit);
            _validatingControls.Add(txtUnitPrice);
            _validatingControls.Add(txtStockQty);
            #endregion

            LoadAllItems();
            InitBindings();

            #region Event Registrations
            btnNewItem.Click += HandleBtnNewItemClicked;
            btnInsertItem.Click += HandleBtnInsertItemClicked;
            btnUpdateItem.Click += HandleBtnUpdateItemClicked;
            btnCancelItem.Click += HandleBtnCancelItemClicked;

            txtItemDescription.Validating += ValidateTextBox;
            txtUnit.Validating += ValidateTextBox;
            txtUnitPrice.Validating += ValidateTextBoxNumber;
            txtStockQty.Validating += ValidateTextBoxInteger;

            dgvItems.SelectionChanged += HandleSelectionChanged;

            txtSearchItem.TextChanged += HandleSearchItem;
            #endregion

        }
        #region Bind With Controls
        private void InitBindings()
        {
            txtItemID.DataBindings.Add("Text", _itemBindingSource, "ItemID");
            txtItemDescription.DataBindings.Add("Text", _itemBindingSource, "ItemDescription");
            cbCategory.DataBindings.Add("SelectedItem", _itemBindingSource, "Category");
            txtUnit.DataBindings.Add("Text", _itemBindingSource, "Unit");
            txtUnitPrice.DataBindings.Add("Text", _itemBindingSource, "UnitPrice");
            txtStockQty.DataBindings.Add("Text", _itemBindingSource, "StockQty");
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
                btnCancelItem.PerformClick();
            }
        }

        private bool ContainsNewRow(DataTable table)
        {
            DataTable? changes = table.GetChanges(DataRowState.Added);

            return changes != null && changes.Rows.Count > 0;
        }
        #endregion

        #region Handle Search
        private void HandleSearchItem(object? sender, EventArgs e)
        {
            string searchText = txtSearchItem.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                _itemBindingSource.Filter = string.Empty;
            }
            else
            {
                _itemBindingSource.Filter = "ItemDescription LIKE '" + searchText + "%'";
            }
        }
        #endregion

        #region Handle Validation
        private void ValidateTextBox(object? sender, CancelEventArgs e)
        {
            ErrorHelper.ValidateTextBox((sender as TextBox)!, _errorProvider);
        }
        private void ValidateTextBoxNumber(object? sender, CancelEventArgs e)
        {
            ErrorHelper.ValidateTextBoxNumber((sender as TextBox)!, _errorProvider);

        }
        private void ValidateTextBoxInteger(object? sender, CancelEventArgs e)
        {
            ErrorHelper.ValidateTextBoxInteger((sender as TextBox)!, _errorProvider);
        }
        #endregion

        #region Handle New
        private void HandleBtnNewItemClicked(object? sender, EventArgs e)
        {
            try
            {
                _itemBindingSource.AddNew();
            }
            catch (Exception)
            {
                MessageBox.Show("ការថែមទិន្នន័យមិនបានសម្រេច", "ថែមទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtItemDescription.Focus();
            cbCategory.SelectedIndex = 0;
        }
        #endregion

        #region Handle Insert
        private void HandleBtnInsertItemClicked(object? sender, EventArgs e)
        {
            CauseValidation();

            if (ErrorHelper.HasErrors(_validatingControls, _errorProvider)) return;
            _itemBindingSource.EndEdit();
            try
            {
                _itemDataAdapter.Update(_storeRentalDataSet, TABLE_NAME);
                _itemBindingSource.ResetBindings(false);
            }
            catch (Exception)
            {
                MessageBox.Show("ការបញ្ខូលឬកែប្រែមិនបានសម្រេច", "បញ្ខូលឬកែប្រែ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            RefreshDataGridView();
        }
        #endregion

        #region Handle Update
        private void HandleBtnUpdateItemClicked(object? sender, EventArgs e)
        {
            HandleBtnInsertItemClicked(null, EventArgs.Empty);
        }
        #endregion

        #region Handle Cancel
        private void HandleBtnCancelItemClicked(object? sender, EventArgs e)
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
                    if (control.Tag != null)
                    {
                        if (control.Tag.ToString()!.Equals('d'))
                        {
                            ErrorHelper.ValidateTextBoxInteger(textBox, _errorProvider);
                        }
                        else if (control.Tag.ToString()!.Equals('n'))
                        {
                            ErrorHelper.ValidateTextBoxNumber(textBox, _errorProvider);
                        }
                    }
                    else
                    {
                        ErrorHelper.ValidateTextBox(textBox, _errorProvider);
                    }
                }
            }
        }
        #endregion

        #region Load
        private void LoadAllItems()
        {
            _itemDataAdapter.TableMappings.Add("Table", TABLE_NAME);
            try
            {
                _itemDataAdapter.Fill(_storeRentalDataSet, TABLE_NAME);
            }
            catch (Exception)
            {
                MessageBox.Show("ការទាញទិន្នន័យមិនបានសម្រេច", "ទាញទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _itemBindingSource.DataSource = _storeRentalDataSet.Tables[TABLE_NAME];
            dgvItems.DataSource = _itemBindingSource;
        }
        #endregion

        #region Refresh
        private void RefreshDataGridView()
        {
            _storeRentalDataSet.Tables[TABLE_NAME]?.Clear();      
            try
            {
                _itemDataAdapter.Fill(_storeRentalDataSet, TABLE_NAME);
            }
            catch (Exception)
            {
                MessageBox.Show("ការទាញទិន្នន័យមិនបានសម្រេច", "ទាញទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

    }
}
