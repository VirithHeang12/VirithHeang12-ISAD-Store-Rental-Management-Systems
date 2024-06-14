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
            _itemDataAdapter.SelectCommand = ItemHelper.CreateGetAllItemsCommand();
            _itemDataAdapter.InsertCommand = ItemHelper.CreateInsertItemCommand();
            _itemDataAdapter.UpdateCommand = ItemHelper.CreateUpdateItemCommand();

            _errorProvider.ContainerControl = this;

            LoadAllItems();
            InitBindings();

            #region event registrations
            btnNewItem.Click += HandleBtnNewItemClicked;
            btnInsertItem.Click += HandleBtnInsertItemClicked;
            btnUpdateItem.Click += HandleBtnUpdateItemClicked;
            btnCancelItem.Click += HandleBtnCancelItemClicked;

            btnInsertItem.EnabledChanged += HandleBtnEnabledChanged;
            btnNewItem.EnabledChanged += HandleBtnEnabledChanged;
            btnUpdateItem.EnabledChanged += HandleBtnEnabledChanged;
            btnCancelItem.EnabledChanged += HandleBtnEnabledChanged;

            txtItemDescription.Validating += ValidateTextBox;
            cbCategory.Validating += (sender, e) => ValidateComboBox((ComboBox)sender, _errorProvider);
            txtUnit.Validating += ValidateTextBox;
            txtUnitPrice.Validating += ValidateTextBoxNumber;
            txtStockQty.Validating += ValidateTextBoxNumber;



            _validatingControls.Add(txtItemDescription);
            _validatingControls.Add(cbCategory);
            _validatingControls.Add(txtUnit);
            _validatingControls.Add(txtUnitPrice);
            _validatingControls.Add(txtStockQty);


            txtSearchItem.TextChanged += HandleSearchItem;
            #endregion

        }
        private void HandleSearchItem(object? sender, EventArgs e)
        {
            string searchText = txtSearchItem.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                _itemBindingSource.Filter = string.Empty;
            }
            else
            {
                _itemBindingSource.Filter = "ItemDescription LIKE '%" + searchText + "%'";

            }
        }

        private void ValidateTextBox(object? sender, CancelEventArgs e)
        {
            ErrorHelper.ValidateTextBox((sender as TextBox)!, _errorProvider);
        }
        private void ValidateTextBoxNumber(object? sender, CancelEventArgs e)
        {
            ErrorHelper.ValidateTextBoxNumber((sender as TextBox)!, _errorProvider);

        }

        private void ValidateComboBox(object sender, ErrorProvider errorProvider)
        {
            ComboBox comboBox = (ComboBox)sender;
            if (comboBox.SelectedIndex == -1)
            {
                errorProvider.SetError(comboBox, "Please select a value.");
            }
            else
            {
                errorProvider.SetError(comboBox, string.Empty);
            }
        }

        private void HandleBtnCancelItemClicked(object? sender, EventArgs e)
        {
            _storeRentalDataSet.RejectChanges();
            RefreshDataGridView();

            foreach (var control in _validatingControls)
            {
                if (control is TextBox textBox)
                {
                    ErrorHelper.ValidateTextBox(textBox, _errorProvider);
                }
                else if (control is ComboBox comboBox)
                {
                    ValidateComboBox(comboBox, _errorProvider);
                }
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
        private void HandleBtnUpdateItemClicked(object? sender, EventArgs e)
        {
            HandleBtnInsertItemClicked(null, EventArgs.Empty);
        }
        private void InitBindings()
        {
            txtItemID.DataBindings.Add("Text", _itemBindingSource, "ItemID");
            txtItemDescription.DataBindings.Add("Text", _itemBindingSource, "ItemDescription");
            cbCategory.DataBindings.Add("Text", _itemBindingSource, "Category");
            txtUnit.DataBindings.Add("Text", _itemBindingSource, "Unit");
            txtUnitPrice.DataBindings.Add("Text", _itemBindingSource, "UnitPrice");
            txtStockQty.DataBindings.Add("Text", _itemBindingSource, "StockQty");
        }


        private void HandleBtnInsertItemClicked(object? sender, EventArgs e)
        {
            foreach (var control in _validatingControls)
            {
                if (control is TextBox textBox)
                {
                    ErrorHelper.ValidateTextBox(textBox, _errorProvider);
                }
                else if (control is ComboBox comboBox)
                {
                    ValidateComboBox(comboBox, _errorProvider);
                }
            }

            if (ErrorHelper.HasErrors(_validatingControls, _errorProvider))
            {
                return;
            }

            _itemBindingSource.EndEdit();
            try
            {
                _itemDataAdapter.Update(_storeRentalDataSet, TABLE_NAME);
            }
            catch (Exception)
            {
                MessageBox.Show("ការបញ្ចូលមិនបានសម្រេច");
            }

            _itemBindingSource.ResetBindings(false);
            RefreshDataGridView();
        }

        private void HandleBtnNewItemClicked(object? sender, EventArgs e)
        {
            _itemBindingSource.AddNew();
            txtItemDescription.Focus();
        }
        private void LoadAllItems()
        {
            _itemDataAdapter.TableMappings.Add("Table", TABLE_NAME);
            _itemDataAdapter.Fill(_storeRentalDataSet);

            _itemBindingSource.DataSource = _storeRentalDataSet.Tables[TABLE_NAME];
            dgvItems.DataSource = _itemBindingSource;
        }
        private void RefreshDataGridView()
        {
            _storeRentalDataSet.Tables[TABLE_NAME]?.Clear();
            _itemDataAdapter.Fill(_storeRentalDataSet, TABLE_NAME);
        }


    }
}
