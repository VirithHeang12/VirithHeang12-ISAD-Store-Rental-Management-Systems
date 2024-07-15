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
    public partial class FrmAppointment : FrmHome
    {
        private const string RELATIONSHIP_NAME = "appointment_staffAssignment";
        private const string TABLE_APPOINTMENT_NAME = "tblAppointment";
        private const string TABLE_STAFF_ASSIGNMENT_NAME = "tblStaffAssignment";
        private const string TABLE_CUSTOMER_NAME = "tblCustomer";
        private const string TABLE_STAFF_NAME = "tblStaff";

        private DataSet _storeRentalDataSet = new();

        private SqlDataAdapter _appointmentDataAdapter = new();
        private SqlDataAdapter _staffAssignmentDataAdapter = new();
        private SqlDataAdapter _customerDataAdapter = new();
        private SqlDataAdapter _staffDataAdapter = new();

        private BindingSource _appointmentBindingSource = new();
        private BindingSource _staffAssignmentBindingSource = new();
        private BindingSource _customerBindingSource = new();
        private BindingSource _staffBindingSource = new();

        private ErrorProvider _errorProvider = new();

        private DataView? tempDetails = null;

        public FrmAppointment() : base()
        {
            InitializeComponent();

            InitCommands();
            LoadAllData();
            BindToControls();

            #region Event Registrations
            cbStaffID.SelectedIndexChanged += HandleCbStaffIDSelectedIndexChanged;

            btnInsertAppointmentStaff.Click += HandleBtnInsertAppointmentStaffClicked;
            btnUpdateAppointmentStaff.Click += HandleBtnUpdateAppointmentStaffClicked;
            btnDeleteAppointmentStaff.Click += HandleBtnDeleteAppointmentStaffClicked;
            btnCancelAppointmentStaff.Click += HandleBtnCancelAppointmentStaffClicked;

            btnNewAppointment.Click += HandleBtnNewAppointmentClicked;
            btnInsertAppointment.Click += HandleBtnInsertAppointmentClicked;
            btnUpdateAppointment.Click += HandleBtnUpdateAppointmentClicked;
            btnCancelAppointment.Click += HandleBtnCancelAppointmentClicked;

            cbSearchAppointment.SelectedIndexChanged += HandleSearchAppointment;

            dgvStaffAssignments.DataError += HandleDataError;

            #endregion
        }

        private void HandleDataError(object? sender, DataGridViewDataErrorEventArgs e)
        {
            // do nothing just to fix bug on datagridview
        }

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
            // appointment
            _appointmentDataAdapter.InsertCommand = AppointmentHelper.CreateInsertOrUpdateAppointmentCommand();
            _appointmentDataAdapter.SelectCommand = AppointmentHelper.CreateGetAllAppointmentsCommand();
            _appointmentDataAdapter.UpdateCommand = AppointmentHelper.CreateInsertOrUpdateAppointmentCommand();

            // appointment detail
            _staffAssignmentDataAdapter.SelectCommand = AppointmentHelper.CreateGetAllAppointmentDetailsCommand();

            // customer
            _customerDataAdapter.SelectCommand = AppointmentHelper.CreateGetAllCustomersForComboBoxCommand();

            // staff
            _staffDataAdapter.SelectCommand = AppointmentHelper.CreateGetAllStaffsForComboBoxCommand();

        }
        #endregion

        #region Bind To Controls
        private void BindToControls()
        {
            txtAppointmentID.DataBindings.Add(new Binding("Text", _appointmentBindingSource, "AppointmentID"));
            dtpAppointmentDate.DataBindings.Add(new Binding("Value", _appointmentBindingSource, "AppointmentDate"));
            cbAppointmentStatus.DataBindings.Add(new Binding("Text", _appointmentBindingSource, "AppointmentStatus"));
            cbCustomerID.DataBindings.Add(new Binding("SelectedValue", _appointmentBindingSource, "CustomerID"));

            cbStaffID.DataBindings.Add(new Binding("SelectedValue", _staffAssignmentBindingSource, "StaffID"));
            txtStaffPosition.DataBindings.Add(new Binding("Text", _staffAssignmentBindingSource, "StaffPosition"));
            txtStaffName.DataBindings.Add(new Binding("Text", _staffAssignmentBindingSource, "StaffName"));
            

        }
        #endregion

        #region Load All Data
        private void LoadAllData()
        {
            _appointmentDataAdapter.TableMappings.Add("Table", TABLE_APPOINTMENT_NAME);
            _staffAssignmentDataAdapter.TableMappings.Add("Table", TABLE_STAFF_ASSIGNMENT_NAME);
            _customerDataAdapter.TableMappings.Add("Table", TABLE_CUSTOMER_NAME);
            _staffDataAdapter.TableMappings.Add("Table", TABLE_STAFF_NAME);


            try
            {
                _appointmentDataAdapter.Fill(_storeRentalDataSet, TABLE_APPOINTMENT_NAME);
                _staffAssignmentDataAdapter.Fill(_storeRentalDataSet, TABLE_STAFF_ASSIGNMENT_NAME);
                _customerDataAdapter.Fill(_storeRentalDataSet, TABLE_CUSTOMER_NAME);
                _staffDataAdapter.Fill(_storeRentalDataSet, TABLE_STAFF_NAME);

            }
            catch (Exception)
            {
                MessageBox.Show("ការទាញទិន្នន័យមិនបានសម្រេច", "ទាញទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // setting primary keys on tables
            _storeRentalDataSet.Tables[TABLE_APPOINTMENT_NAME]!.PrimaryKey = new DataColumn[]
            {
                _storeRentalDataSet.Tables[TABLE_APPOINTMENT_NAME]!.Columns["AppointmentID"]!,
            };
            _storeRentalDataSet.Tables[TABLE_STAFF_ASSIGNMENT_NAME]!.PrimaryKey = new DataColumn[]
            {
                _storeRentalDataSet.Tables[TABLE_STAFF_ASSIGNMENT_NAME]!.Columns["AppointmentID"]!,
                _storeRentalDataSet.Tables[TABLE_STAFF_ASSIGNMENT_NAME]!.Columns["StaffID"]!,
            };
            _storeRentalDataSet.Tables[TABLE_CUSTOMER_NAME]!.PrimaryKey = new DataColumn[]
            {
                _storeRentalDataSet.Tables[TABLE_CUSTOMER_NAME]!.Columns["CustomerID"]!,
            };
            _storeRentalDataSet.Tables[TABLE_STAFF_NAME]!.PrimaryKey = new DataColumn[]
           {
                _storeRentalDataSet.Tables[TABLE_STAFF_NAME]!.Columns["StaffID"]!,
           };



            _appointmentBindingSource.DataSource = _storeRentalDataSet.Tables[TABLE_APPOINTMENT_NAME]!.AsDataView();
            cbSearchAppointment.DataSource = _appointmentBindingSource;
            cbSearchAppointment.DisplayMember = "AppointmentID";
            cbSearchAppointment.ValueMember = "AppointmentID";

            _staffAssignmentBindingSource.DataSource = _storeRentalDataSet.Tables[TABLE_STAFF_ASSIGNMENT_NAME]!.AsDataView();

            _customerBindingSource.DataSource = _storeRentalDataSet.Tables[TABLE_CUSTOMER_NAME]!.AsDataView();
            cbCustomerID.DataSource = _customerBindingSource;
            cbCustomerID.DisplayMember = "CustomerID";
            cbCustomerID.ValueMember = "CustomerID";

            _staffBindingSource.DataSource = _storeRentalDataSet.Tables[TABLE_STAFF_NAME]!.AsDataView();
            cbStaffID.DataSource = _staffBindingSource;
            cbStaffID.DisplayMember = "StaffID";
            cbStaffID.ValueMember = "StaffID";

            // create and add relation
            DataRelation relation = new DataRelation(RELATIONSHIP_NAME, _storeRentalDataSet.Tables[TABLE_APPOINTMENT_NAME]!.Columns["AppointmentID"]!, _storeRentalDataSet.Tables[TABLE_STAFF_ASSIGNMENT_NAME]!.Columns["AppointmentID"]!);

            _storeRentalDataSet.Relations.Add(relation);

            HandleCbStaffIDSelectedIndexChanged(null, EventArgs.Empty);

            if (cbSearchAppointment.Items.Count > 0)
            {
                cbSearchAppointment.SelectedIndex = 0;
            }

            cbAppointmentStatus.SelectedIndex = 0;
            HandleSearchAppointment(null, EventArgs.Empty);
        }
        #endregion

        #region Unbind with controls
        private void UnbindWithControls()
        {
            txtAppointmentID.DataBindings.Clear();
            dtpAppointmentDate.DataBindings.Clear();
            cbAppointmentStatus.DataBindings.Clear();
            cbCustomerID.DataBindings.Clear();

            cbStaffID.DataBindings.Clear();
            txtStaffPosition.DataBindings.Clear();
            txtStaffName.DataBindings.Clear();
        }
        #endregion

        #region Handle Cancel
        private void HandleBtnCancelAppointmentClicked(object? sender, EventArgs e)
        {
            _errorProvider.Clear();
            RefreshComboBox();
        }
        #endregion

        #region Handle Search
        private void HandleSearchAppointment(object? sender, EventArgs e)
        {
            DataRowView? selectedAppointment = (cbSearchAppointment.SelectedItem as DataRowView);
            if (selectedAppointment != null)
            {
                tempDetails = selectedAppointment.CreateChildView(RELATIONSHIP_NAME);

                _staffAssignmentBindingSource.DataSource = tempDetails;
                dgvStaffAssignments.DataSource = _staffAssignmentBindingSource;
            }
        }
        #endregion

        #region Handle Update
        private void HandleBtnUpdateAppointmentClicked(object? sender, EventArgs e)
        {
            HandleBtnInsertAppointmentClicked(null, EventArgs.Empty);
        }
        #endregion

        #region Handle Insert
        private void HandleBtnInsertAppointmentClicked(object? sender, EventArgs e)
        {

            if (tempDetails == null || tempDetails.Count == 0)
            {
                MessageBox.Show("សូមបញ្ចូលបុគ្គលិក", "ថែមទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _appointmentDataAdapter.InsertCommand.Parameters["@StaffAssignments"].Value = tempDetails.ToTable();
            _appointmentDataAdapter.UpdateCommand.Parameters["@StaffAssignments"].Value = tempDetails.ToTable();

            _appointmentBindingSource.EndEdit();
            try
            {
                _appointmentDataAdapter.Update(_storeRentalDataSet);
                _appointmentBindingSource.ResetBindings(false);
            }
            catch (Exception)
            {
                MessageBox.Show("ការបញ្ខូលឬកែប្រែមិនបានសម្រេច", "បញ្ខូលឬកែប្រែ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            RefreshComboBox();
        }

        #endregion

        #region Handle New
        private void HandleBtnNewAppointmentClicked(object? sender, EventArgs e)
        {
            if (cbStaffID.Items.Count < 1)
            {
                MessageBox.Show("សូមបញ្ចូលបុគ្គលិកជាមុនសិន", "ថែមទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbCustomerID.Items.Count < 1)
            {
                MessageBox.Show("សូមបញ្ចូលអតិថិជនជាមុនសិន", "ថែមទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UnbindWithControls();
            cbSearchAppointment.SelectedIndexChanged -= HandleSearchAppointment;

            try
            {
                _appointmentBindingSource.AddNew();

                DataRowView masterRowView = (_appointmentBindingSource.Current as DataRowView)!;

                masterRowView.BeginEdit();

                masterRowView["AppointmentID"] = -1;

                masterRowView["AppointmentDate"] = DateTime.Now;

                cbCustomerID.SelectedIndex = 0;
                masterRowView["CustomerID"] = cbCustomerID.SelectedValue;

                cbAppointmentStatus.SelectedIndex = 0;
                masterRowView["AppointmentStatus"] = cbAppointmentStatus.Text;

                masterRowView.EndEdit();

                tempDetails = masterRowView.CreateChildView(RELATIONSHIP_NAME);

                _staffAssignmentBindingSource.DataSource = tempDetails;
                dgvStaffAssignments.DataSource = _staffAssignmentBindingSource;

                cbStaffID.SelectedIndex = 0;
                cbAppointmentStatus.SelectedIndex = 0;
            }
            catch (Exceptio​n​​)
            {
                MessageBox.Show("ការថែមទិន្នន័យមិនបានសម្រេច", "ថែមទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            BindToControls();
            cbSearchAppointment.SelectedIndexChanged += HandleSearchAppointment;
        }
        #endregion

        #region Handle Cancel Staff
        private void HandleBtnCancelAppointmentStaffClicked(object? sender, EventArgs e)
        {
            _staffAssignmentBindingSource.CancelEdit();
            tempDetails!.Table!.AcceptChanges();

            cbStaffID.SelectedIndex = 0;
        }
        #endregion

        #region Handle Delete Staff
        private void HandleBtnDeleteAppointmentStaffClicked(object? sender, EventArgs e)
        {
            if (_staffAssignmentBindingSource.Count == 0) return;
            if (_staffAssignmentBindingSource.Current == null) return;

            DataRowView masterRowView = (_appointmentBindingSource.Current as DataRowView)!;
            if (masterRowView == null) return;
            if (int.Parse(masterRowView["AppointmentID"].ToString()!) != -1) return;

            _staffAssignmentBindingSource.RemoveCurrent();

            _staffAssignmentBindingSource.EndEdit();

            tempDetails!.Table!.AcceptChanges();

            cbStaffID.SelectedIndex = 0;
        }
        #endregion

        #region Handle Update Staff
        private void HandleBtnUpdateAppointmentStaffClicked(object? sender, EventArgs e)
        {
            DataRowView masterRowView = (_appointmentBindingSource.Current as DataRowView)!;
            if (masterRowView == null) return;
            if (int.Parse(masterRowView["AppointmentID"].ToString()!) != -1) return;

            DataRowView currentStaff = (_staffAssignmentBindingSource.Current as DataRowView)!;

            if (currentStaff == null) return;

            currentStaff["StaffID"] = cbStaffID.SelectedValue;
            currentStaff["StaffName"] = txtStaffName.Text;
            currentStaff["StaffPosition"] = txtStaffPosition.Text;    

            try
            {
                _staffAssignmentBindingSource.EndEdit();
            }
            catch (Exception)
            {
                MessageBox.Show("សម្ភារៈស្ទួន", "បញ្ខូលសម្ភារៈ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvStaffAssignments.Refresh();
            }

            tempDetails!.Table!.AcceptChanges();

            cbStaffID.SelectedIndex = 0;
        }
        #endregion

        #region Handle Insert Staff
        private void HandleBtnInsertAppointmentStaffClicked(object? sender, EventArgs e)
        {
            DataRowView masterRowView = (_appointmentBindingSource.Current as DataRowView)!;
            if (masterRowView == null) return;
            if (int.Parse(masterRowView["AppointmentID"].ToString()!) != -1) return;

            object staffID = cbStaffID.SelectedValue;
            string staffName = txtStaffName.Text;
            string staffPosition = txtStaffPosition.Text;

            DataRowView? dataRowView = tempDetails?.AddNew();

            if (dataRowView == null) return;
            // reject changes made to existing rows when insert new row otherwise unique constraint violation occurs
            tempDetails!.Table!.RejectChanges();

            dataRowView.BeginEdit();
            dataRowView["AppointmentID"] = masterRowView["AppointmentID"];
            dataRowView["StaffID"] = staffID;
            dataRowView["StaffName"] = staffName;
            dataRowView["StaffPosition"] = staffPosition;


            try
            {
                dataRowView.EndEdit();
            }
            catch (Exception)
            {
                dataRowView.Delete();
                MessageBox.Show("បុគ្គលិកស្ទួន", "បញ្ខូលបុគ្គលិក", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvStaffAssignments.Refresh();
            }
            tempDetails!.Table!.AcceptChanges();

            cbStaffID.SelectedIndex = 0;
        }

        #endregion

        #region Refresh
        private void RefreshComboBox()
        {
            UnbindWithControls();

            _storeRentalDataSet.Clear();

            try
            {
                _appointmentDataAdapter.Fill(_storeRentalDataSet, TABLE_APPOINTMENT_NAME);
                _staffAssignmentDataAdapter.Fill(_storeRentalDataSet, TABLE_STAFF_ASSIGNMENT_NAME);
                _customerDataAdapter.Fill(_storeRentalDataSet, TABLE_CUSTOMER_NAME);
                _staffDataAdapter.Fill(_storeRentalDataSet, TABLE_STAFF_NAME);
            }
            catch (Exception)
            {
                MessageBox.Show("ការទាញទិន្នន័យមិនបានសម្រេច", "ទាញទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (cbSearchAppointment.Items.Count > 0)
            {
                cbSearchAppointment.SelectedIndex = 0;
            }
            cbAppointmentStatus.SelectedIndex = 0;
            HandleCbStaffIDSelectedIndexChanged(null, EventArgs.Empty);
            HandleSearchAppointment(null, EventArgs.Empty);
            BindToControls();
        }
        #endregion
    }
}
