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

    public partial class FrmUser : FrmHome
    {
        private const string TABLE_NAME = "tblUser";
        private const string TABLE_STAFF_NAME = "tblStaff";

        private DataSet _storeRentalDataSet = new();

        private SqlDataAdapter _userDataAdapter = new();
        private SqlDataAdapter _staffDataAdapter = new();

        private BindingSource _userBindingSource = new();
        private BindingSource _staffBindingSource = new();

        private ErrorProvider _errorProvider = new();

        private List<Control> _validatingControls = new();




        public FrmUser() : base()
        {
            InitializeComponent();
            _errorProvider.ContainerControl = this;

            #region Add controls for validation
            _errorProvider.ContainerControl = this;
            _validatingControls.Add(txtUserName);
            _validatingControls.Add(txtPassword);

            #endregion

            #region Event Registrations
            btnNewUser.Click += HandleBtnNewUserClicked;
            btnInsertUser.Click += HandleBtnInsertUserClicked;
            btnUpdateUser.Click += HandleBtnUpdateUserClicked;
            btnCancelFormUser.Click += HandleBtnCancelFormUserClicked;
            #endregion

            InitCommands();
            LoadAllData();
            LoadAllUsers();
            BindWithControls();
            cbStaffID.TextChanged += HandleTextCbStaffIDChanged;
            dgvUsers.SelectionChanged += HandleSelectionChanged;
        }

        #region HandleTextCbStaffIDChanged
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

        }
        #endregion

        #region LoadAllData
        private void LoadAllData()
        {
            // filling tblStaff DataTable
            _staffDataAdapter.TableMappings.Add("Table1", TABLE_STAFF_NAME);
            _staffDataAdapter.Fill(_storeRentalDataSet, TABLE_STAFF_NAME);

            // bind to StoreTypeID combo box
            _staffBindingSource.DataSource = _storeRentalDataSet.Tables[TABLE_STAFF_NAME]!.AsDataView();
            cbStaffID.DataSource = _staffBindingSource;
            cbStaffID.DisplayMember = "StaffID";
            cbStaffID.ValueMember = "StaffID";

        }
        #endregion

        #region Load
        private void LoadAllUsers()
        {
            _userDataAdapter.TableMappings.Add("Table", TABLE_NAME);
            _userDataAdapter.Fill(_storeRentalDataSet, TABLE_NAME);
            try
            {

                _userDataAdapter.Fill(_storeRentalDataSet);
            }
            catch (Exception)
            {
                MessageBox.Show("ការទាញទិន្នន័យមិនបានសម្រេច", "ទាញទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _userBindingSource.DataSource = _storeRentalDataSet.Tables[TABLE_NAME];
            dgvUsers.DataSource = _userBindingSource;
        }
        #endregion

        #region BindWithControls
        private void BindWithControls()
        {
            // binding for searching user
            txtUserID.DataBindings.Add(new Binding("Text", _userBindingSource, "UserID"));
            txtUserName.DataBindings.Add(new Binding("Text", _userBindingSource, "UserName"));
            txtPassword.DataBindings.Add(new Binding("Text", _userBindingSource, "Password"));

            // binding for choosing staff
            cbStaffID.DataBindings.Add(new Binding("SelectedValue", _staffBindingSource, "StaffID"));
            txtStaffName.DataBindings.Add(new Binding("Text", _staffBindingSource, "StaffName"));
            txtStaffPosition.DataBindings.Add(new Binding("Text", _staffBindingSource, "StaffPosition"));

        }
        #endregion

        #region InitCommands
        private void InitCommands()
        {
            //user
            _userDataAdapter.SelectCommand = UserHelper.CreateGetAllUsersCommand();
            _userDataAdapter.InsertCommand = UserHelper.CreateInsertUserCommand();
            _userDataAdapter.UpdateCommand = UserHelper.CreateUpdateUserCommand();

            // staff
            _staffDataAdapter.SelectCommand = UserHelper.CreateGetAllStaffsForComboBoxCommand();
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
                btnCancelFormUser.PerformClick();
            }
        }

        private bool ContainsNewRow(DataTable table)
        {
            DataTable? changes = table.GetChanges(DataRowState.Added);

            return changes != null && changes.Rows.Count > 0;
        }
        #endregion

        #region Handle New
        private void HandleBtnNewUserClicked(object? sender, EventArgs e)
        {
            try
            {
                _userBindingSource.AddNew();
            }
            catch (Exception)
            {
                MessageBox.Show("ការថែមទិន្នន័យមិនបានសម្រេច", "ថែមទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtUserName.Focus();
        }
        #endregion

        #region Handle Insert
        private void HandleBtnInsertUserClicked(object? sender, EventArgs e)
        {
            CauseValidation();

            if (ErrorHelper.HasErrors(_validatingControls, _errorProvider)) return;
            _userBindingSource.EndEdit();
            try
            {
                _userDataAdapter.Update(_storeRentalDataSet, TABLE_NAME);
                _userBindingSource.ResetBindings(false);
            }
            catch (Exception)
            {
                MessageBox.Show("ការបញ្ខូលឬកែប្រែមិនបានសម្រេច", "បញ្ខូលឬកែប្រែ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            RefreshDataGridView();
        }

        #endregion

        #region Handle Update
        private void HandleBtnUpdateUserClicked(object? sender, EventArgs e)
        {
            HandleBtnInsertUserClicked(null, EventArgs.Empty);
        }
        #endregion

        #region Handle Cancel
        private void HandleBtnCancelFormUserClicked(object? sender, EventArgs e)
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
                    ErrorHelper.ValidateTextBox(textBox, _errorProvider);
                }
                else if (control is MaskedTextBox maskedTextBox)
                {
                    ErrorHelper.ValidateMaskedTextBox(maskedTextBox, _errorProvider);
                }
            }
        }
        #endregion

        #region Refresh
        private void RefreshDataGridView()
        {
            _storeRentalDataSet.Tables[TABLE_NAME]?.Clear();
            try
            {
                _userDataAdapter.Fill(_storeRentalDataSet, TABLE_NAME);
            }
            catch (Exception)
            {
                MessageBox.Show("ការទាញទិន្នន័យមិនបានសម្រេច", "ទាញទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        #region Refresh

        #endregion

    }
}
