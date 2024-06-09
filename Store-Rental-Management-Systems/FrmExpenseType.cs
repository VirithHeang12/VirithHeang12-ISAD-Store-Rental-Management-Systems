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

        private Binding? _expenseTypeIDBinding;
        private Binding? _expenseDescriptionBinding;


        private List<Control> _validatingControls = new();

        public FrmExpenseType() : base()
        {
            InitializeComponent();
            _expenseTypeDataAdapter.SelectCommand = ExpenseTypeHelper.CreateGetAllExpenseTypesCommand();
            _expenseTypeDataAdapter.InsertCommand = ExpenseTypeHelper.CreateInsertExpenseTypeCommand();
            _expenseTypeDataAdapter.UpdateCommand = ExpenseTypeHelper.CreateUpdateExpenseTypeCommand();

            _errorProvider.ContainerControl = this;

            LoadAllExpenseTypes();
            InitBindings();
            BindWithControls();

            #region event registrations
            btnNewExpenseType.Click += HandleBtnNewExpenseTypeClicked;
            btnInsertExpenseType.Click += HandleBtnInsertExpenseTypeClicked;
            btnUpdateExpenseType.Click += HandleBtnUpdateExpenseTypeClicked;
            btnCancelExpenseType.Click += HandleBtnCancelExpenseTypeClicked;

            btnInsertExpenseType.EnabledChanged += HandleBtnEnabledChanged;
            btnNewExpenseType.EnabledChanged += HandleBtnEnabledChanged;
            btnUpdateExpenseType.EnabledChanged += HandleBtnEnabledChanged;
            btnCancelExpenseType.EnabledChanged += HandleBtnEnabledChanged;

            txtExpenseDescription.Validating += ValidateTextBox;


            _validatingControls.Add(txtExpenseDescription);


            txtSearchExpenseType.TextChanged += HandleSearchExpenseType;
            #endregion
        }

        private void HandleSearchExpenseType(object? sender, EventArgs e)
        {
            string searchText = txtSearchExpenseType.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                _expenseTypeBindingSource.Filter = string.Empty;
            }
            else
            {
                _expenseTypeBindingSource.Filter = "ExpenseDescription LIKE '%" + searchText + "%'";
            }
        }

        private void ValidateTextBox(object? sender, CancelEventArgs e)
        {
            ErrorHelper.ValidateTextBox((sender as TextBox)!, _errorProvider);
        }

        private void HandleBtnCancelExpenseTypeClicked(object? sender, EventArgs e)
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

        private void HandleBtnUpdateExpenseTypeClicked(object? sender, EventArgs e)
        {
            HandleBtnInsertExpenseTypeClicked(null, EventArgs.Empty);
        }

        private void InitBindings()
        {
            //txtExpenseTypeID.DataBindings.Add(new Binding("Text", _expenseTypeBindingSource, "ExpenseTypeID"));
            //txtExpenseDescription.DataBindings.Add(new Binding("Text", _expenseTypeBindingSource, "ExpenseDescription"));
            _expenseTypeIDBinding = new Binding("Text", _expenseTypeBindingSource, "ExpenseTypeID");
            _expenseDescriptionBinding = new Binding("Text", _expenseTypeBindingSource, "ExpenseDescription");
        }
        private void BindWithControls()
        {
            txtExpenseTypeID.DataBindings.Add(_expenseTypeIDBinding);
            txtExpenseDescription.DataBindings.Add(_expenseDescriptionBinding);

        }

        private void HandleBtnInsertExpenseTypeClicked(object? sender, EventArgs e)
        {
            foreach (var control in _validatingControls)
            {
                ErrorHelper.ValidateTextBox((control as TextBox)!, _errorProvider);
            }

            if (ErrorHelper.HasErrors(_validatingControls, _errorProvider)) return;
            _expenseTypeBindingSource.EndEdit();
            try
            {
                _expenseTypeDataAdapter.Update(_storeRentalDataSet, TABLE_NAME);
            }
            catch (Exception)
            {
                MessageBox.Show("ការបញ្ចូលមិនបានសម្រេច");
            }

            _expenseTypeBindingSource.ResetBindings(false);

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

        private void HandleBtnNewExpenseTypeClicked(object? sender, EventArgs e)
        {
            _expenseTypeBindingSource.AddNew();
            txtExpenseDescription.Focus();
        }

        private void LoadAllExpenseTypes()
        {
            _expenseTypeDataAdapter.TableMappings.Add("Table", TABLE_NAME);
            _expenseTypeDataAdapter.Fill(_storeRentalDataSet);

            _expenseTypeBindingSource.DataSource = _storeRentalDataSet.Tables[TABLE_NAME];
            dgvExpenseTypes.DataSource = _expenseTypeBindingSource;
        }

        private void RefreshDataGridView()
        {
            _storeRentalDataSet.Tables[TABLE_NAME]?.Clear();
            _expenseTypeDataAdapter.Fill(_storeRentalDataSet, TABLE_NAME);
        }
    }
}
