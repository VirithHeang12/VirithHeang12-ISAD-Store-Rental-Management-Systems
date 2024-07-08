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
    public partial class FrmPayment : FrmHome
    {

        private const string RELATIONSHIP_NAME = "payment_paymentDetail";

        private const string TABLE_PAYMENT_NAME = "tblPayment";
        private const string TABLE_PAYMENT_DETAIL_NAME = "tblPaymentDetail";
        private const string TABLE_STORE_NAME = "tblStore";
        private const string TABLE_CONTRACT_NAME = "tblContract";
        private const string TABLE_STAFF_NAME = "tblStaff";
        private const string TABLE_EXPENSETYPE_NAME = "tblExpenseType";

        private DataSet _storeRentalDataSet = new();

        private SqlDataAdapter _paymentDataAdapter = new();
        private SqlDataAdapter _paymentDetailDataAdapter = new();
        private SqlDataAdapter _storeDataAdapter = new();
        private SqlDataAdapter _contractDataAdapter = new();
        private SqlDataAdapter _staffDataAdapter = new();
        private SqlDataAdapter _expenseTypeDataAdapter = new();

        private BindingSource _paymentBindingSource = new();
        private BindingSource _paymentDetailBindingSource = new();
        private BindingSource _storeBindingSource = new();
        private BindingSource _contractBindingSource = new();
        private BindingSource _staffBindingSource = new();
        private BindingSource _expenseTypeBindingSource = new();

        private ErrorProvider _errorProvider = new();

        private List<Control> _validatingControls = new();

        private DataView? tempDetails = null;
        public FrmPayment() : base()
        {
            InitializeComponent();

            InitCommands();
            LoadAllData();
            BindToControls();

            #region Add controls for validation
            _errorProvider.ContainerControl = this;
            _validatingControls.Add(dtpPaymentDate);
            _validatingControls.Add(txtExpenseTypeQty);           
            #endregion

            #region Event Registrations

            cbStaffID.SelectedIndexChanged += HandleCbStaffIDSelectedIndexChanged;
            cbExpenseTypeID.SelectedIndexChanged += HandleCbExpenseTypeIDSelectedIndexChanged;

            txtTotalAmount.TextChanged += HandleTxtPaidAmountTextChanged;
            txtPaidAmount.TextChanged += HandleTxtPaidAmountTextChanged;
            txtExpenseTypeQty.TextChanged += HandleTxtExpenseTypeQtyTextChanged;
            txtUnitPrice.TextChanged += HandleTxtExpenseTypeQtyTextChanged;

            btnInsertPaymentExpenseType.Click += HandleBtnInsertPaymentExpenseTypeClicked;
            btnUpdatePaymentExpenseType.Click += HandleBtnUpdatePaymentExpenseTypeClicked;
            btnDeletePaymentExpenseType.Click += HandleBtnDeletePaymentExpenseTypeClicked;
            btnCancelPaymentExpenseType.Click += HandleBtnCancelPaymentExpenseTypeClicked;

            btnNewPayment.Click += HandleBtnNewPaymentClicked;
            btnInsertPayment.Click += HandleBtnInsertPaymentClicked;
            btnUpdatePayment.Click += HandleBtnUpdatePaymentClicked;
            btnCancelPayment.Click += HandleBtnCancelPaymentClicked;

            cbSearchPayment.SelectedIndexChanged += HandleSearchPayment;

            txtTotalAmount.GotFocus += HandleGotFocusEN;
            txtPaidAmount.GotFocus += HandleGotFocusEN;
            txtOwedAmount.GotFocus += HandleGotFocusEN;
            txtExpenseDescription.GotFocus += HandleGotFocusKM;
            txtUnitPrice.GotFocus += HandleGotFocusEN;
            txtExpenseTypeQty.GotFocus += HandleGotFocusEN;
            txtAmount.GotFocus += HandleGotFocusEN;

            dgvExpenses.DataError += HandleDataError;
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

        private void UpdateTotalAmount()
        {
            DataRowView masterRowView = (_paymentBindingSource.Current as DataRowView)!;

            if (tempDetails == null) return;
            if (tempDetails.Count == 0) return;

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
        private void HandleBtnCancelPaymentClicked(object? sender, EventArgs e)
        {
            _errorProvider.Clear();
            RefreshComboBox();
        }
        #endregion

        #region Handle Update
        private void HandleBtnUpdatePaymentClicked(object? sender, EventArgs e)
        {
            HandleBtnInsertPaymentClicked(null, EventArgs.Empty);
        }
        #endregion

        #region Handle Insert
        private void HandleBtnInsertPaymentClicked(object? sender, EventArgs e)
        {

            if (tempDetails == null || tempDetails.Count == 0)
            {
                MessageBox.Show("សូមបញ្ចូលសម្ភារៈ", "ថែមទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _paymentDataAdapter.InsertCommand.Parameters["@PaymentDetails"].Value = tempDetails.ToTable();
            _paymentDataAdapter.UpdateCommand.Parameters["@PaymentDetails"].Value = tempDetails.ToTable();

            _paymentBindingSource.EndEdit();
            try
            {
                _paymentDataAdapter.Update(_storeRentalDataSet);
                _paymentBindingSource.ResetBindings(false);
            }
            catch (Exception)
            {
                MessageBox.Show("ការបញ្ខូលឬកែប្រែមិនបានសម្រេច", "បញ្ខូលឬកែប្រែ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            RefreshComboBox();
        }
        #endregion

        #region Handle New
        private void HandleBtnNewPaymentClicked(object? sender, EventArgs e)
        {
            UnbindWithControls();
            cbSearchPayment.SelectedIndexChanged -= HandleSearchPayment;

            try
            {
                _paymentBindingSource.AddNew();

                DataRowView masterRowView = (_paymentBindingSource.Current as DataRowView)!;

                masterRowView.BeginEdit();

                masterRowView["PaymentID"] = -1;

                masterRowView["PaymentDate"] = DateTime.Now;

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

                _paymentDetailBindingSource.DataSource = tempDetails;
                dgvExpenses.DataSource = _paymentDetailBindingSource;

                txtExpenseTypeQty.Text = string.Empty;
                cbExpenseTypeID.SelectedIndex = 0;

            }
            catch (Exception)
            {
                MessageBox.Show("ការថែមទិន្នន័យមិនបានសម្រេច", "ថែមទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            BindToControls();
            cbSearchPayment.SelectedIndexChanged += HandleSearchPayment;
        }

        #endregion

        #region Handle Cancel ExpenseType
        private void HandleBtnCancelPaymentExpenseTypeClicked(object? sender, EventArgs e)
        {
            _paymentDetailBindingSource.CancelEdit();
            UpdateTotalAmount();
        }
        #endregion

        #region Handle Delete ExpenseType
        private void HandleBtnDeletePaymentExpenseTypeClicked(object? sender, EventArgs e)
        {
            if (_paymentDetailBindingSource.Count == 0) return;
            if (_paymentDetailBindingSource.Current == null) return;

            _paymentDetailBindingSource.RemoveCurrent();

            _paymentDetailBindingSource.EndEdit();
            UpdateTotalAmount();
        }
        #endregion

        #region Handle Update ExpenseType
        private void HandleBtnUpdatePaymentExpenseTypeClicked(object? sender, EventArgs e)
        {
            DataRowView currentItem = (_paymentDetailBindingSource.Current as DataRowView)!;

            if (currentItem != null)
            {
                currentItem["ExpenseTypeID"] = cbExpenseTypeID.SelectedValue;
                currentItem["ExpenseDescription"] = txtExpenseDescription.Text;
                currentItem["UnitPrice"] = txtUnitPrice.Text;
                currentItem["Quantity"] = txtExpenseTypeQty.Text;
                currentItem["Amount"] = txtAmount.Text;
            }

            try
            {
                _paymentDetailBindingSource.EndEdit();
            }
            catch (Exception)
            {
                MessageBox.Show("ប្រភេទចំណាយស្ទួន", "បញ្ខូលប្រភេទចំណាយ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvExpenses.Refresh();
            }
            UpdateTotalAmount();
        }
        #endregion

        #region Handle Insert ExpenseType
        private void HandleBtnInsertPaymentExpenseTypeClicked(object? sender, EventArgs e)
        {
            DataRowView masterRowView = (_paymentBindingSource.Current as DataRowView)!;

            object expensetypeID = cbExpenseTypeID.SelectedValue;
            string description = txtExpenseDescription.Text;
            string unitPrice = txtUnitPrice.Text;
            string expensetypeQty = txtExpenseTypeQty.Text;
            string amount = txtAmount.Text;

            // validate when insert item
            ErrorHelper.ValidateTextBoxInteger(txtExpenseTypeQty, _errorProvider);
            ErrorHelper.ValidateTextBoxNumber(txtUnitPrice, _errorProvider);
  
            if (ErrorHelper.HasErrors(_validatingControls, _errorProvider)) return;

            DataRowView? dataRowView = tempDetails?.AddNew();

            if (dataRowView == null) return;
            // reject changes made to existing rows when insert new row otherwise unique constraint violation occurs
            tempDetails!.Table!.RejectChanges();

            dataRowView.BeginEdit();
            dataRowView["PaymentID"] = masterRowView["PaymentID"];
            dataRowView["ExpenseTypeID"] = expensetypeID;
            
            dataRowView["UnitPrice"] = unitPrice;
            dataRowView["Quantity"] = expensetypeQty;
            dataRowView["Amount"] = amount;
            dataRowView["ExpenseDescription"] = description;

            try
            {
                dataRowView.EndEdit();
            }
            catch (Exception)
            {
                dataRowView.Delete();
                MessageBox.Show("សម្ភារៈស្ទួន", "បញ្ខូលសម្ភារៈ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvExpenses.Refresh();
            }
            tempDetails!.Table!.AcceptChanges();

            txtExpenseTypeQty.Text = string.Empty;
            cbExpenseTypeID.SelectedIndex = 0;

            UpdateTotalAmount();
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

        #region Handle TxtExpenseTypeQtyTextChanged
        private void HandleTxtExpenseTypeQtyTextChanged(object? sender, EventArgs e)
        {
            if (int.TryParse(txtExpenseTypeQty.Text, out int qty) && decimal.TryParse(txtUnitPrice.Text, out decimal unitPrice))
            {
                txtAmount.Text = (qty * unitPrice).ToString();
            }
            else
            {
                txtAmount.Text = string.Empty;
            }
        }
        #endregion

        #region Handle cbExpenseTypeIDSelectedIndexChanged
        private void HandleCbExpenseTypeIDSelectedIndexChanged(object? sender, EventArgs e)
        {
            var dataRowView = cbExpenseTypeID.SelectedItem as DataRowView;
            txtExpenseDescription.Text = dataRowView?["ExpenseDescription"] as string ?? string.Empty;
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

        #region Init Commands
        private void InitCommands()
        {
            // payment
            _paymentDataAdapter.InsertCommand = PaymentHelper.CreateInsertOrUpdatePaymentCommand();
            _paymentDataAdapter.SelectCommand = PaymentHelper.CreateGetAllPaymentsCommand();
            _paymentDataAdapter.UpdateCommand = PaymentHelper.CreateInsertOrUpdatePaymentCommand();

            // payment detail
            _paymentDetailDataAdapter.SelectCommand = PaymentHelper.CreateGetAllPaymentDetailsCommand();

            // store
            _storeDataAdapter.SelectCommand = PaymentHelper.CreateGetAllStoresForComboBoxCommand();

            // contract
            _contractDataAdapter.SelectCommand = PaymentHelper.CreateGetAllContractsForComboBoxCommand();

            // staff
            _staffDataAdapter.SelectCommand = PaymentHelper.CreateGetAllStaffsForComboBoxCommand();

            // expansetype
            _expenseTypeDataAdapter.SelectCommand = PaymentHelper.CreateGetAllExpenseTypesForComboBoxCommand();
        }
        #endregion

        #region Bind To Controls
        private void BindToControls()
        {
            txtPaymentID.DataBindings.Add(new Binding("Text", _paymentBindingSource, "PaymentID"));
            dtpPaymentDate.DataBindings.Add(new Binding("Value", _paymentBindingSource, "PaymentDate"));
            txtTotalAmount.DataBindings.Add(new Binding("Text", _paymentBindingSource, "TotalAmount"));
            txtPaidAmount.DataBindings.Add(new Binding("Text", _paymentBindingSource, "PaidAmount"));
            txtOwedAmount.DataBindings.Add(new Binding("Text", _paymentBindingSource, "OwedAmount"));
            cbStoreID.DataBindings.Add(new Binding("SelectedValue", _paymentBindingSource, "StoreID"));
            cbContractID.DataBindings.Add(new Binding("SelectedValue", _paymentBindingSource, "ContractID"));
            cbStaffID.DataBindings.Add(new Binding("SelectedValue", _paymentBindingSource, "StaffID"));
            txtStaffName.DataBindings.Add(new Binding("Text", _paymentBindingSource, "StaffName"));
            txtStaffPosition.DataBindings.Add(new Binding("Text", _paymentBindingSource, "StaffPosition"));

            cbExpenseTypeID.DataBindings.Add(new Binding("SelectedValue", _paymentDetailBindingSource, "ExpenseTypeID"));
            txtExpenseDescription.DataBindings.Add(new Binding("Text", _paymentDetailBindingSource, "ExpenseDescription"));
            txtExpenseTypeQty.DataBindings.Add(new Binding("Text", _paymentDetailBindingSource, "Quantity"));
            txtUnitPrice.DataBindings.Add(new Binding("Text", _paymentDetailBindingSource, "UnitPrice"));
            txtAmount.DataBindings.Add(new Binding("Text", _paymentDetailBindingSource, "Amount"));

        }
        #endregion

        #region Unbind with controls
        private void UnbindWithControls()
        {
            txtPaymentID.DataBindings.Clear();
            dtpPaymentDate.DataBindings.Clear();
            txtTotalAmount.DataBindings.Clear();
            txtPaidAmount.DataBindings.Clear();
            txtOwedAmount.DataBindings.Clear();
            cbStoreID.DataBindings.Clear();
            cbContractID.DataBindings.Clear();
            cbStaffID.DataBindings.Clear();
            txtStaffName.DataBindings.Clear();
            txtStaffPosition.DataBindings.Clear();

            cbExpenseTypeID.DataBindings.Clear();
            txtExpenseDescription.DataBindings.Clear();
            txtExpenseTypeQty.DataBindings.Clear();
            txtUnitPrice.DataBindings.Clear();
            txtAmount.DataBindings.Clear();
        }
        #endregion

        #region Handle Search
        private void HandleSearchPayment(object? sender, EventArgs e)
        {
            DataRowView? selectedImport = (cbSearchPayment.SelectedItem as DataRowView);
            if (selectedImport != null)
            {
                tempDetails = selectedImport.CreateChildView(RELATIONSHIP_NAME);

                _paymentDetailBindingSource.DataSource = tempDetails;
                dgvExpenses.DataSource = _paymentDetailBindingSource;
            }
        }
        #endregion

        #region Load All Data
        private void LoadAllData()
        {
            _paymentDataAdapter.TableMappings.Add("Table", TABLE_PAYMENT_NAME);
            _paymentDetailDataAdapter.TableMappings.Add("Table", TABLE_PAYMENT_DETAIL_NAME);
            _storeDataAdapter.TableMappings.Add("Table", TABLE_STORE_NAME);
            _contractDataAdapter.TableMappings.Add("Table", TABLE_CONTRACT_NAME);
            _staffDataAdapter.TableMappings.Add("Table", TABLE_STAFF_NAME);
            _expenseTypeDataAdapter.TableMappings.Add("Table", TABLE_EXPENSETYPE_NAME);

            try
            {
                _paymentDataAdapter.Fill(_storeRentalDataSet, TABLE_PAYMENT_NAME);
                _paymentDetailDataAdapter.Fill(_storeRentalDataSet, TABLE_PAYMENT_DETAIL_NAME);
                _storeDataAdapter.Fill(_storeRentalDataSet, TABLE_STORE_NAME);
                _contractDataAdapter.Fill(_storeRentalDataSet, TABLE_CONTRACT_NAME);
                _staffDataAdapter.Fill(_storeRentalDataSet, TABLE_STAFF_NAME);
                _expenseTypeDataAdapter.Fill(_storeRentalDataSet, TABLE_EXPENSETYPE_NAME);
            }
            catch (Exception)
            {
                MessageBox.Show("ការទាញទិន្នន័យមិនបានសម្រេច", "ទាញទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // setting primary keys on tables
            _storeRentalDataSet.Tables[TABLE_PAYMENT_NAME]!.PrimaryKey = new DataColumn[]
            {
                _storeRentalDataSet.Tables[TABLE_PAYMENT_NAME]!.Columns["PaymentID"]!,
            };
            _storeRentalDataSet.Tables[TABLE_PAYMENT_DETAIL_NAME]!.PrimaryKey = new DataColumn[]
            {
                _storeRentalDataSet.Tables[TABLE_PAYMENT_DETAIL_NAME]!.Columns["PaymentID"]!,
                _storeRentalDataSet.Tables[TABLE_PAYMENT_DETAIL_NAME]!.Columns["ExpenseTypeID"]!,
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
            _storeRentalDataSet.Tables[TABLE_EXPENSETYPE_NAME]!.PrimaryKey = new DataColumn[]
            {
                _storeRentalDataSet.Tables[TABLE_EXPENSETYPE_NAME]!.Columns["ExpenseTypeID"]!,
            };


            _paymentBindingSource.DataSource = _storeRentalDataSet.Tables[TABLE_PAYMENT_NAME]!.AsDataView();
            cbSearchPayment.DataSource = _paymentBindingSource;
            cbSearchPayment.DisplayMember = "PaymentID";
            cbSearchPayment.ValueMember = "PaymentID";

            _paymentDetailBindingSource.DataSource = _storeRentalDataSet.Tables[TABLE_PAYMENT_DETAIL_NAME]!.AsDataView();

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

            _expenseTypeBindingSource.DataSource = _storeRentalDataSet.Tables[TABLE_EXPENSETYPE_NAME]!.AsDataView();
            cbExpenseTypeID.DataSource = _expenseTypeBindingSource;
            cbExpenseTypeID.DisplayMember = "ExpenseTypeID";
            cbExpenseTypeID.ValueMember = "ExpenseTypeID";

            // create and add relation
            DataRelation relation = new DataRelation(RELATIONSHIP_NAME, _storeRentalDataSet.Tables[TABLE_PAYMENT_NAME]!.Columns["PaymentID"]!, _storeRentalDataSet.Tables[TABLE_PAYMENT_DETAIL_NAME]!.Columns["PaymentID"]!);

            _storeRentalDataSet.Relations.Add(relation);

            HandleCbExpenseTypeIDSelectedIndexChanged(null, EventArgs.Empty);
            HandleCbStaffIDSelectedIndexChanged(null, EventArgs.Empty);


            if (cbSearchPayment.Items.Count > 0)
            {
                cbSearchPayment.SelectedIndex = 0;
            }

            HandleSearchPayment(null, EventArgs.Empty);
        }
        #endregion

        #region Refresh
        private void RefreshComboBox()
        {
            UnbindWithControls();

            _storeRentalDataSet.Tables[TABLE_PAYMENT_DETAIL_NAME]?.Clear();
            _storeRentalDataSet.Tables[TABLE_PAYMENT_NAME]?.Clear();

            try
            {
                _paymentDataAdapter.Fill(_storeRentalDataSet, TABLE_PAYMENT_NAME);
                _paymentDetailDataAdapter.Fill(_storeRentalDataSet, TABLE_PAYMENT_DETAIL_NAME);
            }
            catch (Exception)
            {
                MessageBox.Show("ការទាញទិន្នន័យមិនបានសម្រេច", "ទាញទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (cbSearchPayment.Items.Count > 0)
            {
                cbSearchPayment.SelectedIndex = 0;
            }

            HandleSearchPayment(null, EventArgs.Empty);
            BindToControls();
        }
        #endregion

    }
}
