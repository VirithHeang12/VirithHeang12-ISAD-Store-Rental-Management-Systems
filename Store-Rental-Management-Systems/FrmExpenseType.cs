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
    public partial class FrmExpenseType : FrmHome
    {
        private const string TABLE_NAME = "tblExpenseType";
        private DataSet _storeRentalDataSet = new();
        private SqlDataAdapter _expenseTypeDataAdapter = new();
        private BindingSource _expenseTypeBindingSource = new();

        private ErrorProvider _errorProvider = new();

        private List<Control> _validatingControls = new();

        public FrmExpenseType() : base()
        {
            InitializeComponent();
            #region Init DataAdapter Commands
            _expenseTypeDataAdapter.SelectCommand = ExpenseTypeHelper.CreateGetAllExpenseTypesCommand();
            _expenseTypeDataAdapter.InsertCommand = ExpenseTypeHelper.CreateInsertExpenseTypeCommand();
            _expenseTypeDataAdapter.UpdateCommand = ExpenseTypeHelper.CreateUpdateExpenseTypeCommand();
            #endregion

            #region Add controls for validation
            _errorProvider.ContainerControl = this;
            _validatingControls.Add(txtExpenseDescription);
            #endregion

            LoadAllExpenseTypes();
            BindWithControls();
            

            #region Event Registrations
            btnNewExpenseType.Click += HandleBtnNewExpenseTypeClicked;
            btnInsertExpenseType.Click += HandleBtnInsertExpenseTypeClicked;
            btnUpdateExpenseType.Click += HandleBtnUpdateExpenseTypeClicked;
            btnCancelExpenseType.Click += HandleBtnCancelExpenseTypeClicked;

            txtExpenseDescription.Validating += ValidateTextBox;

            dgvExpenseTypes.SelectionChanged += HandleSelectionChanged;

            txtSearchExpenseType.TextChanged += HandleSearchExpenseType;

            txtExpenseDescription.GotFocus += HandleGotFocusKM;
            #endregion
        }

        #region HandleGotFocus
        private void HandleGotFocusKM(object? sender, EventArgs e)
        {
            KeyboardLayoutHelper.SwitchToKhmerKeyboard();
        }
     
        #endregion

        #region Bind With Controls
        private void BindWithControls()
        {
            txtExpenseTypeID.DataBindings.Add(new Binding("Text", _expenseTypeBindingSource, "ExpenseTypeID"));
            txtExpenseDescription.DataBindings.Add(new Binding("Text", _expenseTypeBindingSource, "ExpenseDescription"));

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
                btnCancelExpenseType.PerformClick();
            }
        }

        private bool ContainsNewRow(DataTable table)
        {
            DataTable? changes = table.GetChanges(DataRowState.Added);

            return changes != null && changes.Rows.Count > 0;
        }

        #endregion

        #region Handle Search
        private void HandleSearchExpenseType(object? sender, EventArgs e)
        {
            string searchText = txtSearchExpenseType.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                _expenseTypeBindingSource.Filter = string.Empty;
            }
            else
            {
                _expenseTypeBindingSource.Filter = "ExpenseDescription LIKE '" + searchText + "%'";
            }
        }
        #endregion

        #region Handle Validation
        private void ValidateTextBox(object? sender, CancelEventArgs e)
        {
            ErrorHelper.ValidateTextBox((sender as TextBox)!, _errorProvider);
        }
        #endregion

        #region Handle New

        private void HandleBtnNewExpenseTypeClicked(object? sender, EventArgs e)
        {
            try
            {
                _expenseTypeBindingSource.AddNew();
            }
            catch (Exception)
            {
                MessageBox.Show("ការថែមទិន្នន័យមិនបានសម្រេច", "ថែមទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtExpenseDescription.Focus();
        }

        #endregion

        #region Handle Insert
        private void HandleBtnInsertExpenseTypeClicked(object? sender, EventArgs e)
        {
            CauseValidation();

            if (ErrorHelper.HasErrors(_validatingControls, _errorProvider)) return;
            _expenseTypeBindingSource.EndEdit();
            try
            {
                _expenseTypeDataAdapter.Update(_storeRentalDataSet, TABLE_NAME);
                _expenseTypeBindingSource.ResetBindings(false);
            }
            catch (Exception)
            {
                MessageBox.Show("ការបញ្ខូលឬកែប្រែមិនបានសម្រេច", "បញ្ខូលឬកែប្រែ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            RefreshDataGridView();
        }
        #endregion

        #region Handle Update
        private void HandleBtnUpdateExpenseTypeClicked(object? sender, EventArgs e)
        {
            HandleBtnInsertExpenseTypeClicked(null, EventArgs.Empty);
        }
        #endregion

        #region Handle Cancel
        private void HandleBtnCancelExpenseTypeClicked(object? sender, EventArgs e)
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
                ErrorHelper.ValidateTextBox((control as TextBox)!, _errorProvider);
            }
        }
        #endregion

        #region Load
        private void LoadAllExpenseTypes()
        {
            _expenseTypeDataAdapter.TableMappings.Add("Table", TABLE_NAME);
            try
            {
                _expenseTypeDataAdapter.Fill(_storeRentalDataSet);
            }
            catch (Exception)
            {
                MessageBox.Show("ការទាញទិន្នន័យមិនបានសម្រេច", "ទាញទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _expenseTypeBindingSource.DataSource = _storeRentalDataSet.Tables[TABLE_NAME];
            dgvExpenseTypes.DataSource = _expenseTypeBindingSource;
        }
        #endregion

        #region Refresh
        private void RefreshDataGridView()
        {
            _storeRentalDataSet.Tables[TABLE_NAME]?.Clear();
            try
            {
                _expenseTypeDataAdapter.Fill(_storeRentalDataSet, TABLE_NAME);
            }
            catch (Exception)
            {
                MessageBox.Show("ការទាញទិន្នន័យមិនបានសម្រេច", "ទាញទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
