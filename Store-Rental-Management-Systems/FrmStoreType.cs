using Microsoft.Data.SqlClient;
using StoreRentalHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_Rental_Management_Systems
{
    public partial class FrmStoreType : FrmHome
    {

        private const string TABLE_NAME = "tblStoreType";
        private DataSet _storeRentalDataSet = new DataSet();
        private SqlDataAdapter _storetypeDataAdapter = new();
        private BindingSource _storetypeBindingSource = new();

        private ErrorProvider _errorProvider = new();

        private List<Control> _validatingControls = new();
        public FrmStoreType() : base()
        {
            InitializeComponent();
            _storetypeDataAdapter.SelectCommand = StoreTypeHelper.CreateGetAllStoreTypesCommand();
            _storetypeDataAdapter.InsertCommand = StoreTypeHelper.CreateInsertStoreTypeCommand();
            _storetypeDataAdapter.UpdateCommand = StoreTypeHelper.CreateUpdateStoreTypeCommand();

            _errorProvider.ContainerControl = this;


            LoadAllStoreTypes();
            InitBindings();
     

            #region event registrations
            btnNewStoreType.Click += HandleBtnNewStoreTypeClicked;
            btnInsertStoreType.Click += HandleBtnInsertStoreTypeClicked;
            btnUpdateStoreType.Click += HandleBtnUpdateStoreTypeClicked;
            btnCancelStoreType.Click += HandleBtnCancelStoreTypeClicked;

            txtStoreTypeDescription.Validating += ValidateTextBox;
            txtMonthlyLeasePrice.Validating += ValidateTextBoxNumber;
            txtThreeMonthPaymentDiscount.Validating += ValidateTextBoxIntegerOneToHundred;
            txtSixMonthPaymentDiscount.Validating += ValidateTextBoxIntegerOneToHundred;
            txtOneYearPaymentDiscount.Validating += ValidateTextBoxIntegerOneToHundred;

            _validatingControls.Add(txtStoreTypeDescription);
            _validatingControls.Add(txtMonthlyLeasePrice);
            _validatingControls.Add(txtThreeMonthPaymentDiscount);
            _validatingControls.Add(txtSixMonthPaymentDiscount);
            _validatingControls.Add(txtOneYearPaymentDiscount);

            dgvStoreTypes.SelectionChanged += HandleSelectionChanged;

            txtSearchStoreType.TextChanged += HandleSearchStoreType;
            #endregion

        }

        private void HandleSelectionChanged(object? sender, EventArgs e)
        {
            if (!ContainsNewRow(_storeRentalDataSet.Tables[TABLE_NAME]!))
            {
                return;
            }
            else
            {
                btnCancelStoreType.PerformClick();
            }
        }

        private bool ContainsNewRow(DataTable table)
        {
            DataTable? changes = table.GetChanges(DataRowState.Added);

            return changes != null && changes.Rows.Count > 0;
        }

        private void ValidateTextBoxIntegerOneToHundred(object? sender, CancelEventArgs e)
        {
            ErrorHelper.ValidateTextBoxIntegerOneToHundred((sender as TextBox)!, _errorProvider);
        }

        private void HandleSearchStoreType(object? sender, EventArgs e)
        {
            string searchText = txtSearchStoreType.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                _storetypeBindingSource.Filter = string.Empty;
            }
            else
            {
                _storetypeBindingSource.Filter = "StoreTypeDescription LIKE '" + searchText + "%'";

            }
        }

        private void ValidateTextBox(object? sender, CancelEventArgs e)
        {
            ErrorHelper.ValidateTextBox((sender as TextBox)!, _errorProvider);
        }

        private void ValidateTextBoxNumber(object? sender, EventArgs e)
        {
            ErrorHelper.ValidateTextBoxNumber((sender as TextBox)!, _errorProvider);
        }

        private void HandleBtnCancelStoreTypeClicked(object? sender, EventArgs e)
        {
            _errorProvider.Clear();
            _storeRentalDataSet.RejectChanges();
            RefreshDataGridView();

        }
        private void HandleBtnUpdateStoreTypeClicked(object? sender, EventArgs e)
        {
            HandleBtnInsertStoreTypeClicked(null, EventArgs.Empty);
        }

        private void InitBindings()
        {
            txtStoreTypeID.DataBindings.Add(new Binding("Text", _storetypeBindingSource, "StoreTypeID"));
            txtStoreTypeDescription.DataBindings.Add(new Binding("Text", _storetypeBindingSource, "StoreTypeDescription"));
            txtMonthlyLeasePrice.DataBindings.Add(new Binding("Text", _storetypeBindingSource, "MonthlyLeasePrice"));
            txtThreeMonthPaymentDiscount.DataBindings.Add(new Binding("Text", _storetypeBindingSource, "ThreeMonthPaymentDiscount"));
            txtSixMonthPaymentDiscount.DataBindings.Add(new Binding("Text", _storetypeBindingSource, "SixMonthPaymentDiscount"));
            txtOneYearPaymentDiscount.DataBindings.Add(new Binding("Text", _storetypeBindingSource, "OneYearPaymentDiscount"));
        }

        private void HandleBtnInsertStoreTypeClicked(object? sender, EventArgs e)
        {
            CauseValidation();

            if (ErrorHelper.HasErrors(_validatingControls, _errorProvider)) return;
            _storetypeBindingSource.EndEdit();
            try
            {
                _storetypeDataAdapter.Update(_storeRentalDataSet, TABLE_NAME);
                _storetypeBindingSource.ResetBindings(false);
            }
            catch (Exception)
            {
                MessageBox.Show("ការបញ្ខូលឬកែប្រែមិនបានសម្រេច", "បញ្ខូលឬកែប្រែ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            RefreshDataGridView();
        }

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
                            ErrorHelper.ValidateTextBoxIntegerOneToHundred(textBox, _errorProvider);
                        }
                        else if (control.Tag.ToString()!.Equals('n'))
                        {
                            ErrorHelper.ValidateTextBoxNumber(textBox, _errorProvider);
                        }
                    } else
                    {
                        ErrorHelper.ValidateTextBox(textBox, _errorProvider);
                    } 
                }
                else if (control is MaskedTextBox maskedTextBox)
                {
                    ErrorHelper.ValidateMaskedTextBox(maskedTextBox, _errorProvider);
                }
            }
        }

        private void HandleBtnNewStoreTypeClicked(object? sender, EventArgs e)
        {
            try
            {
                _storetypeBindingSource.AddNew();
            } catch (Exception)
            {
                MessageBox.Show("ការថែមទិន្នន័យមិនបានសម្រេច", "ថែមទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            txtStoreTypeDescription.Focus();
        }
        private void LoadAllStoreTypes()
        {
            _storetypeDataAdapter.TableMappings.Add("Table", TABLE_NAME);
            try
            {
                _storetypeDataAdapter.Fill(_storeRentalDataSet, TABLE_NAME);
            }
            catch (Exception)
            {
                MessageBox.Show("ការទាញទិន្នន័យមិនបានសម្រេច", "ទាញទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _storetypeBindingSource.DataSource = _storeRentalDataSet.Tables[TABLE_NAME];
            dgvStoreTypes.DataSource = _storetypeBindingSource;
        }


        private void RefreshDataGridView()
        {
            _storeRentalDataSet.Tables[TABLE_NAME]?.Clear();
            try
            {
                _storetypeDataAdapter.Fill(_storeRentalDataSet, TABLE_NAME);
            } catch (Exception)
            {
                MessageBox.Show("ការទាញទិន្នន័យមិនបានសម្រេច", "ទាញទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }       
        }
    }
}
