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
    public partial class FrmSalaryPayment : FrmHome
    {
        private const string TABLE_SALARY_PAYMENT_NAME = "tblSalaryPayment";
        private const string TABLE_STAFF_NAME = "tblStaff";

        private DataSet _storeRentalDataSet = new DataSet();

        private SqlDataAdapter _salaryPaymentDataAdapter = new();
        private SqlDataAdapter _staffDataAdapter = new();

        private BindingSource _salaryPaymentBindingSource = new();
        private BindingSource _staffBindingSource = new();

        private ErrorProvider _errorProvider = new();

        private List<Control> _validatingControls = new();
        public FrmSalaryPayment() : base()
        {
            InitializeComponent();

            #region Add controls for validation
            _errorProvider.ContainerControl = this;
            _validatingControls.Add(dtpSalaryPaymentDate);
            _validatingControls.Add(txtSalaryPaymentAmount);
            #endregion

            InitCommands();
            LoadAllData();
            BindWithControls();

            #region Event Registrations
            btnNewSalaryPayment.Click += HandleBtnNewSalaryPaymentClicked;
            btnInsertSalaryPayment.Click += HandleBtnInsertSalaryPaymentClicked;
            btnUpdateSalaryPayment.Click += HandleBtnUpdateSalaryPaymentClicked;
            btnCancelSalaryPayment.Click += HandleBtnCancelSalaryPaymentClicked;

            dtpSalaryPaymentDate.Validating += ValidateSalaryPaymentDate;
            txtSalaryPaymentAmount.Validating += ValidateSalaryPaymentAmount;

            dgvSalaryPayments.SelectionChanged += HandleSelectionChanged;

            txtSearchSalaryPayment.TextChanged += HandleSearchSalaryPayment;
            txtSalaryPaymentAmount.GotFocus += HandleGotFocusEN;
            txtSearchSalaryPayment.GotFocus += HandleGotFocusEN;

            cbStaffID.SelectedIndexChanged += HandleSelectedIndexChanged;

            #endregion
        }

        #region HandleGotFocusKM
        private void HandleGotFocusKM(object? sender, EventArgs e)
        {
            KeyboardLayoutHelper.SwitchToKhmerKeyboard();
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
            _salaryPaymentDataAdapter.SelectCommand = SalaryPaymentHelper.CreateGetAllSalaryPaymentsCommand();
            _salaryPaymentDataAdapter.InsertCommand = SalaryPaymentHelper.CreateInsertSalaryPaymentCommand();
            _salaryPaymentDataAdapter.UpdateCommand = SalaryPaymentHelper.CreateUpdateSalaryPaymentCommand();

            _staffDataAdapter.SelectCommand = SalaryPaymentHelper.CreateGetAllStaffsForComboBoxCommand();
        }
        #endregion

        #region Bind With Controls
        private void BindWithControls()
        {
            txtSalaryPaymentID.DataBindings.Add(new Binding("Text", _salaryPaymentBindingSource, "SalaryPaymentID"));
            dtpSalaryPaymentDate.DataBindings.Add(new Binding("Value", _salaryPaymentBindingSource, "SalaryPaymentDate"));
            txtSalaryPaymentAmount.DataBindings.Add(new Binding("Text", _salaryPaymentBindingSource, "SalaryPaymentAmount"));
            cbStaffID.DataBindings.Add(new Binding("SelectedValue", _salaryPaymentBindingSource, "StaffID"));
            txtStaffName.DataBindings.Add(new Binding("Text", _salaryPaymentBindingSource, "StaffName"));
            txtStaffPosition.DataBindings.Add(new Binding("Text", _salaryPaymentBindingSource, "StaffPosition"));
        }

        private void UnbindWithControls()
        {
            txtSalaryPaymentID.DataBindings.Clear();
            dtpSalaryPaymentDate.DataBindings.Clear();
            txtSalaryPaymentAmount.DataBindings.Clear();
            cbStaffID.DataBindings.Clear();
            txtStaffName.DataBindings.Clear();
            txtStaffPosition.DataBindings.Clear();
        }
        #endregion

        #region Handle SelectedIndexChanged
        private void HandleSelectedIndexChanged(object? sender, EventArgs e)
        {
            var dataRowView = cbStaffID.SelectedItem as DataRowView;
            txtStaffName.Text = dataRowView?["StaffName"] as string ?? string.Empty;
            txtStaffPosition.Text = dataRowView?["StaffPosition"] as string ?? string.Empty;
        }
        #endregion

        #region Handle DataGridView SelectionChanged
        private void HandleSelectionChanged(object? sender, EventArgs e)
        {
            if (!ContainsNewRow(_storeRentalDataSet.Tables[TABLE_SALARY_PAYMENT_NAME]!))
            {
                return;
            }
            else
            {
                btnCancelSalaryPayment.PerformClick();
            }
        }

        private bool ContainsNewRow(DataTable table)
        {
            DataTable? changes = table.GetChanges(DataRowState.Added);

            return changes != null && changes.Rows.Count > 0;
        }
        #endregion

        #region Handle Search
        private void HandleSearchSalaryPayment(object? sender, EventArgs e)
        {
            UnbindWithControls();
            string searchText = txtSearchSalaryPayment.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                _salaryPaymentBindingSource.Filter = string.Empty;
            }
            else
            {
                _salaryPaymentBindingSource.Filter = "StaffName LIKE '%" + searchText + "%'";

            }
            BindWithControls();
        }
        #endregion

        #region Handle Validation
        private void ValidateSalaryPaymentAmount(object? sender, CancelEventArgs e)
        {
            ErrorHelper.ValidateTextBoxNumber((sender as TextBox)!, _errorProvider);
        }

        private void ValidateSalaryPaymentDate(object? sender, CancelEventArgs e)
        {
            ErrorHelper.ValidateDtpNowOrPast((sender as DateTimePicker)!, _errorProvider);
        }
        #endregion

        #region Handle New
        private void HandleBtnNewSalaryPaymentClicked(object? sender, EventArgs e)
        {
            try
            {
                UnbindWithControls();

                _salaryPaymentBindingSource.AddNew();

                var newRowView = (_salaryPaymentBindingSource.Current as DataRowView)!;

                cbStaffID.SelectedIndex = 0;
                newRowView["StaffID"] = cbStaffID.SelectedValue;

                var dataRowView = cbStaffID.SelectedItem as DataRowView;
                newRowView["StaffName"] = dataRowView?["StaffName"];
                newRowView["StaffPosition"] = dataRowView?["StaffPosition"];

                newRowView["SalaryPaymentDate"] = DateTime.Now;

                BindWithControls();

                int lastRowIndex = dgvSalaryPayments.Rows.Count - 1;
                dgvSalaryPayments.CurrentCell = dgvSalaryPayments.Rows[lastRowIndex].Cells[0];
            }
            catch (Exception)
            {
                MessageBox.Show("ការថែមទិន្នន័យមិនបានសម្រេច", "ថែមទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dtpSalaryPaymentDate.Focus();
        }
        #endregion

        #region Handle Insert
        private void HandleBtnInsertSalaryPaymentClicked(object? sender, EventArgs e)
        {
            CauseValidation();

            if (ErrorHelper.HasErrors(_validatingControls, _errorProvider)) return;
            _salaryPaymentBindingSource.EndEdit();
            try
            {
                _salaryPaymentDataAdapter.Update(_storeRentalDataSet, TABLE_SALARY_PAYMENT_NAME);
                _salaryPaymentBindingSource.ResetBindings(false);
            }
            catch (Exception)
            {
                MessageBox.Show("ការបញ្ខូលឬកែប្រែមិនបានសម្រេច", "បញ្ខូលឬកែប្រែ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            RefreshDataGridView();
        }
        #endregion

        #region Handle Update
        private void HandleBtnUpdateSalaryPaymentClicked(object? sender, EventArgs e)
        {
            HandleBtnInsertSalaryPaymentClicked(null, EventArgs.Empty);
        }
        #endregion

        #region Handle Cancel
        private void HandleBtnCancelSalaryPaymentClicked(object? sender, EventArgs e)
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
                else if (control is DateTimePicker dtp)
                {
                    ErrorHelper.ValidateDtpNowOrPast(dtp, _errorProvider);
                }
            }
        }
        #endregion

        #region Load
        private void LoadAllData()
        {
            _salaryPaymentDataAdapter.TableMappings.Add("Table", TABLE_SALARY_PAYMENT_NAME);
            _staffDataAdapter.TableMappings.Add("Table", TABLE_STAFF_NAME);
            try
            {
                _salaryPaymentDataAdapter.Fill(_storeRentalDataSet, TABLE_SALARY_PAYMENT_NAME);
                _staffDataAdapter.Fill(_storeRentalDataSet, TABLE_STAFF_NAME);
            }
            catch (Exception)
            {
                MessageBox.Show("ការទាញទិន្នន័យមិនបានសម្រេច", "ទាញទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _salaryPaymentBindingSource.DataSource = _storeRentalDataSet.Tables[TABLE_SALARY_PAYMENT_NAME];
            dgvSalaryPayments.DataSource = _salaryPaymentBindingSource;

            _storeRentalDataSet.Tables[TABLE_STAFF_NAME]!.PrimaryKey = new DataColumn[] { _storeRentalDataSet.Tables[TABLE_STAFF_NAME]!.Columns["StaffID"]! };
            _staffBindingSource.DataSource = _storeRentalDataSet.Tables[TABLE_STAFF_NAME]!.AsDataView();
            cbStaffID.DataSource = _staffBindingSource;
            cbStaffID.ValueMember = "StaffID";
            cbStaffID.DisplayMember = "StaffID";

            HandleSelectedIndexChanged(null, EventArgs.Empty);
        }
        #endregion

        #region Refresh
        private void RefreshDataGridView()
        {
            UnbindWithControls();
            _storeRentalDataSet.Tables[TABLE_SALARY_PAYMENT_NAME]?.Clear();
            try
            {

                _salaryPaymentDataAdapter.Fill(_storeRentalDataSet, TABLE_SALARY_PAYMENT_NAME);

            }
            catch (Exception)
            {
                MessageBox.Show("ការទាញទិន្នន័យមិនបានសម្រេច", "ទាញទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            BindWithControls();

        }
        #endregion

    }
}
