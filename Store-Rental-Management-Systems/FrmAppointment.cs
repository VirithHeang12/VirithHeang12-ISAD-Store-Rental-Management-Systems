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
        private const string RELATIONSHIP_NAME = "appointment_appointmentDetail";
        private const string TABLE_APPOINTMENT_NAME = "tblAppointment";
        private const string TABLE_APPOINTMENT_DETAIL_NAME = "tblStaffAssignment";
        private const string TABLE_CUSTOMER_NAME = "tblCustomer";
        private const string TABLE_STAFF_NAME = "tblStaff";

        private DataSet _storeRentalDataSet = new();

        private SqlDataAdapter _appointmentDataAdapter = new();
        private SqlDataAdapter _appointmentDetailDataAdapter = new();
        private SqlDataAdapter _customerDataAdapter = new();
        private SqlDataAdapter _staffDataAdapter = new();

        private BindingSource _appointmentBindingSource = new();
        private BindingSource _appointmentDetailBindingSource = new();
        private BindingSource _customerBindingSource = new();
        private BindingSource _staffBindingSource = new();

        private ErrorProvider _errorProvider = new();

        private List<Control> _validatingControls = new();

        private DataView? tempDetails = null;

        public FrmAppointment() : base()
        {
            InitializeComponent();
            InitCommands();
            LoadAllData();
            BindToControls();

            dtpAppointmentDate.GotFocus += HandleGotFocusEN;
            //cbAppointmentStatus.GotFocus += HandleGotFocusKM;
            cbCustomerID.GotFocus += HandleGotFocusEN;
            cbStaffID.GotFocus += HandleGotFocusEN;

            #region Event Registrations
            //cbAppointmentStatus.SelectedIndexChanged += HandleCbAppointmentStatusSelectedIndexChanged;
            cbStaffID.SelectedIndexChanged += HandleCbStaffIDSelectedIndexChanged;
            cbCustomerID.SelectedIndexChanged += HandleCbCustomerIDSelectedIndexChanged;



            btnInsertAppointmentStaff.Click += HandleBtnInsertAppointmentStaffClicked;
            btnUpdateAppointmentStaff.Click += HandleBtnUpdateAppointmentStaffClicked;
            btnDeleteAppointmentStaff.Click += HandleBtnDeleteAppointmentStaffClicked;
            btnCancelAppointmentStaff.Click += HandleBtnCancelAppointmentStaffClicked;

            btnNewAppointment.Click += HandleBtnNewAppointmentClicked;
            btnInsertAppointment.Click += HandleBtnInsertAppointmentClicked;
            btnUpdateAppointment.Click += HandleBtnUpdateAppointmentClicked;
            btnCancelFormAppointment.Click += HandleBtnCancelAppointmentClicked;

            cbSearchAppointment.SelectedIndexChanged += HandleSearchAppointment;



            // dgvStaffAssignments.DataError += HandleDataError;
            #endregion
        }

        private void HandleGotFocusKM(object? sender, EventArgs e)
        {
            KeyboardLayoutHelper.SwitchToKhmerKeyboard();
        }

        private void HandleGotFocusEN(object? sender, EventArgs e)
        {
            KeyboardLayoutHelper.SwitchToEnglishKeyboard();
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
            _appointmentDataAdapter.InsertCommand = StaffAssignmentHelper.CreateInsertOrUpdateAppointmentCommand();
            _appointmentDataAdapter.SelectCommand = StaffAssignmentHelper.CreateGetAllAppointmentsCommand();
            _appointmentDataAdapter.UpdateCommand = StaffAssignmentHelper.CreateInsertOrUpdateAppointmentCommand();

            // appointment detail
            _appointmentDetailDataAdapter.SelectCommand = StaffAssignmentHelper.CreateGetAllAppointmentDetailsCommand();

            // customer
            _customerDataAdapter.SelectCommand = StaffAssignmentHelper.CreateGetAllCustomersForComboBoxCommand();
            //_appointmentDataAdapter.SelectCommand = StaffAssignmentHelper.CreateGetAllCustomersForComboBoxCommand();

            // staff
            _staffDataAdapter.SelectCommand = StaffAssignmentHelper.CreateGetAllStaffsForComboBoxCommand();

        }
        #endregion

        #region Bind To Controls
        private void BindToControls()
        {
            txtAppointmentID.DataBindings.Add(new Binding("Text", _appointmentBindingSource, "AppointmentID"));
            dtpAppointmentDate.DataBindings.Add(new Binding("Value", _appointmentBindingSource, "AppointmentDate"));
            //cbCustomerID.DataBindings.Add(new Binding("SelectedValue", _appointmentBindingSource, "CustomerID"));
            cbCustomerID.DataBindings.Add(new Binding("SelectedValue", _customerBindingSource, "CustomerID"));
            //cbAppointmentStatus.DataBindings.Add(new Binding("SelectedValue", _appointmentBindingSource, "AppointmentStatus"));
            //txtStaffName.DataBindings.Add(new Binding("Text", _appointmentBindingSource, "StaffName"));
            //txtStaffPosition.DataBindings.Add(new Binding("Text", _appointmentBindingSource, "StaffPosition"));
            txtStaffPosition.DataBindings.Add(new Binding("Text", _staffBindingSource, "StaffPosition"));
            txtStaffName.DataBindings.Add(new Binding("Text", _staffBindingSource, "StaffName"));
            cbStaffID.DataBindings.Add(new Binding("SelectedValue", _staffBindingSource, "StaffID"));
            //cbStaffID.DataBindings.Add(new Binding("SelectedValue", _appointmentDetailBindingSource, "StaffID"));

        }
        #endregion

        #region Load All Data
        private void LoadAllData()
        {
            _appointmentDataAdapter.TableMappings.Add("Table", TABLE_APPOINTMENT_NAME);
            _appointmentDetailDataAdapter.TableMappings.Add("Table", TABLE_APPOINTMENT_DETAIL_NAME);
            _customerDataAdapter.TableMappings.Add("Table", TABLE_CUSTOMER_NAME);
            _staffDataAdapter.TableMappings.Add("Table", TABLE_STAFF_NAME);


            try
            {
                _appointmentDataAdapter.Fill(_storeRentalDataSet, TABLE_APPOINTMENT_NAME);
                _appointmentDetailDataAdapter.Fill(_storeRentalDataSet, TABLE_APPOINTMENT_DETAIL_NAME);
                _customerDataAdapter.Fill(_storeRentalDataSet, TABLE_CUSTOMER_NAME);
                _staffDataAdapter.Fill(_storeRentalDataSet, TABLE_STAFF_NAME);

            }
            catch (Exception ex)
            {
                MessageBox.Show("ការទាញទិន្នន័យមិនបានសម្រេច", "ទាញទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // setting primary keys on tables
            _storeRentalDataSet.Tables[TABLE_APPOINTMENT_NAME]!.PrimaryKey = new DataColumn[]
            {
                _storeRentalDataSet.Tables[TABLE_APPOINTMENT_NAME]!.Columns["AppointmentID"]!,
            };
            _storeRentalDataSet.Tables[TABLE_APPOINTMENT_DETAIL_NAME]!.PrimaryKey = new DataColumn[]
            {
                _storeRentalDataSet.Tables[TABLE_APPOINTMENT_DETAIL_NAME]!.Columns["AppointmentID"]!,
                _storeRentalDataSet.Tables[TABLE_APPOINTMENT_DETAIL_NAME]!.Columns["StaffID"]!,
            };
            _storeRentalDataSet.Tables[TABLE_CUSTOMER_NAME]!.PrimaryKey = new DataColumn[]
            {
                _storeRentalDataSet.Tables[TABLE_CUSTOMER_NAME]!.Columns["CustomerID"]!,
            };
            _storeRentalDataSet.Tables[TABLE_APPOINTMENT_NAME]!.PrimaryKey = new DataColumn[]
            {
                _storeRentalDataSet.Tables[TABLE_APPOINTMENT_NAME]!.Columns["AppointmentStatus"]!,
            };
            _storeRentalDataSet.Tables[TABLE_STAFF_NAME]!.PrimaryKey = new DataColumn[]
           {
                _storeRentalDataSet.Tables[TABLE_STAFF_NAME]!.Columns["StaffID"]!,
           };



            _appointmentBindingSource.DataSource = _storeRentalDataSet.Tables[TABLE_APPOINTMENT_NAME]!.AsDataView();
            cbSearchAppointment.DataSource = _appointmentBindingSource;
            cbSearchAppointment.DisplayMember = "AppointmentID";
            cbSearchAppointment.ValueMember = "AppointmentID";

            _appointmentDetailBindingSource.DataSource = _storeRentalDataSet.Tables[TABLE_APPOINTMENT_DETAIL_NAME]!.AsDataView();

            _customerBindingSource.DataSource = _storeRentalDataSet.Tables[TABLE_CUSTOMER_NAME]!.AsDataView();
            cbCustomerID.DataSource = _customerBindingSource;
            cbCustomerID.DisplayMember = "CustomerID";
            cbCustomerID.ValueMember = "CustomerID";

            _staffBindingSource.DataSource = _storeRentalDataSet.Tables[TABLE_STAFF_NAME]!.AsDataView();
            cbStaffID.DataSource = _staffBindingSource;
            cbStaffID.DisplayMember = "StaffID";
            cbStaffID.ValueMember = "StaffID";

            _appointmentBindingSource.DataSource = _storeRentalDataSet.Tables[TABLE_APPOINTMENT_NAME]!.AsDataView();
            //cbAppointmentStatus.DataSource = _appointmentBindingSource;


            // create and add relation
            DataRelation relation = new DataRelation(RELATIONSHIP_NAME, _storeRentalDataSet.Tables[TABLE_APPOINTMENT_NAME]!.Columns["AppointmentID"]!, _storeRentalDataSet.Tables[TABLE_APPOINTMENT_DETAIL_NAME]!.Columns["AppointmentID"]!);

            _storeRentalDataSet.Relations.Add(relation);


            HandleCbStaffIDSelectedIndexChanged(null, EventArgs.Empty);


            if (cbSearchAppointment.Items.Count > 0)
            {
                cbSearchAppointment.SelectedIndex = 0;
            }

            HandleSearchAppointment(null, EventArgs.Empty);
        }
        #endregion

        #region Unbind with controls
        private void UnbindWithControls()
        {
            txtAppointmentID.DataBindings.Clear();
            dtpAppointmentDate.DataBindings.Clear();
            cbCustomerID.DataBindings.Clear();
            //cbAppointmentStatus.DataBindings.Clear();

            cbStaffID.DataBindings.Clear();
            txtStaffName.DataBindings.Clear();
            txtStaffPosition.DataBindings.Clear();
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

                _appointmentDetailBindingSource.DataSource = tempDetails;
                dgvStaffAssignments.DataSource = _appointmentDetailBindingSource;
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

            decimal totalAmount = 0;

            if (tempDetails == null || tempDetails.Count == 0)
            {
                MessageBox.Show("សូមបញ្ចូល", "ថែមទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (DataRowView r in tempDetails)
            {
                totalAmount += decimal.Parse(r["Amount"].ToString()!);
            }
            DataRowView masterRowView = (_appointmentBindingSource.Current as DataRowView)!;
            if (masterRowView != null)
            {
                masterRowView["TotalAmount"] = totalAmount;
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
            UnbindWithControls();
            cbSearchAppointment.SelectedIndexChanged -= HandleSearchAppointment;

            try
            {
                _appointmentBindingSource.AddNew();

                DataRowView masterRowView = (_appointmentBindingSource.Current as DataRowView)!;

                masterRowView.BeginEdit();

                masterRowView["AppointmentID"] = -1;

                masterRowView["AppointmentDate"] = DateTime.Now;

                cbStaffID.SelectedIndex = 0;
                var dataRowView = cbStaffID.SelectedItem as DataRowView;
                masterRowView["StaffID"] = cbStaffID.SelectedValue;
                masterRowView["StaffName"] = dataRowView?["StaffName"];
                masterRowView["StaffPosition"] = dataRowView?["StaffPosition"];

                cbAppointmentStatus.SelectedIndex = 0;
                masterRowView["AppointmentStatus"] = cbAppointmentStatus.SelectedValue;
                dataRowView = cbAppointmentStatus.SelectedItem as DataRowView;

                cbCustomerID.SelectedIndex = 0;
                masterRowView["CustomerID"] = cbCustomerID.SelectedValue;
                dataRowView = cbCustomerID.SelectedItem as DataRowView;


                masterRowView.EndEdit();

                tempDetails = masterRowView.CreateChildView(RELATIONSHIP_NAME);

                _appointmentDetailBindingSource.DataSource = tempDetails;
                dgvStaffAssignments.DataSource = _appointmentDetailBindingSource;


                cbStaffID.SelectedIndex = 0;

            }
            catch (Exception​)
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
            _appointmentDetailBindingSource.CancelEdit();
        }
        #endregion

        #region Handle Delete Staff
        private void HandleBtnDeleteAppointmentStaffClicked(object? sender, EventArgs e)
        {
            if (_appointmentDetailBindingSource.Count == 0) return;
            if (_appointmentDetailBindingSource.Current == null) return;

            _appointmentDetailBindingSource.RemoveCurrent();

            _appointmentDetailBindingSource.EndEdit();
        }
        #endregion

        #region Handle Update Staff
        private void HandleBtnUpdateAppointmentStaffClicked(object? sender, EventArgs e)
        {
            DataRowView currentStaff = (_appointmentDetailBindingSource.Current as DataRowView)!;

            if (currentStaff != null)
            {
                currentStaff["StaffID"] = cbStaffID.SelectedValue;
                currentStaff["StaffName"] = txtStaffName.Text;
                currentStaff["StaffPosition"] = txtStaffPosition.Text;


                try
                {
                    _appointmentDetailBindingSource.EndEdit();
                }
                catch (Exception)
                {
                    MessageBox.Show("សម្ភារៈស្ទួន", "បញ្ខូលសម្ភារៈ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvStaffAssignments.Refresh();
                }
            }

        }
        #endregion

        #region Handle Insert Staff
        private void HandleBtnInsertAppointmentStaffClicked(object? sender, EventArgs e)
        {
            DataRowView masterRowView = (_appointmentBindingSource.Current as DataRowView)!;

            object staffID = cbStaffID.SelectedValue;
            string staffName = txtStaffName.Text;
            string staffPosition = txtStaffPosition.Text;


            // validate when insert staff
            //ErrorHelper.ValidateTextBox(cbStaffID, _errorProvider);
            //if (ErrorHelper.HasErrors(_validatingControls, _errorProvider)) return;

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
                MessageBox.Show("សម្ភារៈស្ទួន", "បញ្ខូលសម្ភារៈ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvStaffAssignments.Refresh();
            }
            tempDetails!.Table!.AcceptChanges();

            //txtImportQty.Text = string.Empty;
            cbStaffID.SelectedIndex = 0;
        }

        #endregion

        #region Handle cbCustomerIDSelectedIndexChanged
        private void HandleCbCustomerIDSelectedIndexChanged(object? sender, EventArgs e)
        {
            var dataRowView = cbCustomerID.SelectedItem as DataRowView;
            //  txtCustomerName.Text = dataRowView?["SupplierName"] as string ?? string.Empty;
        }
        #endregion

        #region Handle cbAppointmentStatusSelectedIndexChanged
        private void HandleCbAppointmentStatusSelectedIndexChanged(object? sender, EventArgs e)
        {
            var dataRowView = cbAppointmentStatus.SelectedItem as DataRowView;
            //txtItemDescription.Text = dataRowView?["ItemDescription"] as string ?? string.Empty;
            //txtUnitPrice.Text = dataRowView?["UnitPrice"].ToString() ?? string.Empty;
        }
        #endregion

        #region Refresh
        private void RefreshComboBox()
        {
            UnbindWithControls();

            _storeRentalDataSet.Tables[TABLE_APPOINTMENT_DETAIL_NAME]?.Clear();
            _storeRentalDataSet.Tables[TABLE_APPOINTMENT_NAME]?.Clear();

            try
            {
                _appointmentDataAdapter.Fill(_storeRentalDataSet, TABLE_APPOINTMENT_NAME);
                _appointmentDetailDataAdapter.Fill(_storeRentalDataSet, TABLE_APPOINTMENT_DETAIL_NAME);
            }
            catch (Exception)
            {
                MessageBox.Show("ការទាញទិន្នន័យមិនបានសម្រេច", "ទាញទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (cbSearchAppointment.Items.Count > 0)
            {
                cbSearchAppointment.SelectedIndex = 0;
            }

            HandleSearchAppointment(null, EventArgs.Empty);
            BindToControls();
        }
        #endregion
    }
}
