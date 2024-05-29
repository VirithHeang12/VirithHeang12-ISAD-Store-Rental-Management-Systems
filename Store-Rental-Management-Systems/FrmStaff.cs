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
    public partial class FrmStaff : FrmHome
    {
        public BindingSource StaffBindingSource { get; set; }
        public FrmStaff() : base()
        {

            InitializeComponent();
            StaffBindingSource = new BindingSource();
            ConfigDefaultValues();

            this.Load += LoadAllStaffs;
            btnPickStaffPhoto.Click += HandleBtnStaffPhotoClick;
            btnNewStaff.Click += HandleBtnNewStaffClick;
            btnInsertStaff.Click += HandleBtnInsertStaffClick;
            txtStaffFirstName.GotFocus += HandleTxtStaffFirstNameGotFocus;
            txtStaffLastName.GotFocus += HandleTxtStaffLastNameGotFocus;
            txtStaffIdentityCardNumber.GotFocus += HandleTxtIDCardNumberGotFocus;
            txtStaffSalary.GotFocus += HandleTxtStaffSalaryGotFocus;
        }

        private void HandleTxtStaffSalaryGotFocus(object? sender, EventArgs e)
        {
            ShutDownError(txtStaffSalary, epdStaffSalary);
        }

        private void HandleTxtIDCardNumberGotFocus(object? sender, EventArgs e)
        {
            ShutDownError(txtStaffIdentityCardNumber, epdStaffIdentityCardNumber);
        }

        private void HandleTxtStaffLastNameGotFocus(object? sender, EventArgs e)
        {
            ShutDownError(txtStaffLastName, epdStaffLastName);
        }

        private void HandleTxtStaffFirstNameGotFocus(object? sender, EventArgs e)
        {
            ShutDownError(txtStaffFirstName, epdStaffFirstName);
        }

        private void HandleBtnInsertStaffClick(object? sender, EventArgs e)
        {
            if (ValidateTextBox(txtStaffFirstName, epdStaffFirstName) || ValidateTextBox(txtStaffLastName, epdStaffLastName) || ValidateTextBox(txtStaffIdentityCardNumber, epdStaffIdentityCardNumber) || ValidateTextBoxNumber(txtStaffSalary, epdStaffSalary))
            {
                // Proceed with form submission or further processing
            }
        }

        private void HandleBtnNewStaffClick(object? sender, EventArgs e)
        {
            ClearAllFields();
            ConfigDefaultValues();
        }

        private void ClearAllFields()
        {
            chbStaffStoppedWork.Checked = false;
            txtStaffFirstName.Text = string.Empty;
            txtStaffLastName.Text = string.Empty;
            rdbFemale.Checked = true;
            rdbMale.Checked = false;
            dtpStaffBirthDate.Value = DateTime.Now;
            txtStaffIdentityCardNumber.Text = string.Empty;
            cbStaffPosition.SelectedIndex = -1;
            txtStaffSalary.Text = string.Empty;
            dtpStaffHiredDate.Value = DateTime.Now;
            txtStaffContactNumber.Text = string.Empty;
            txtStaffPersonalNumber.Text = string.Empty;
            txtStaffHouseNo.Text = string.Empty;
            txtStaffStreetNo.Text = string.Empty;
            txtStaffSangkat.Text = string.Empty;
            txtStaffKhan.Text = string.Empty;
            cbStaffCityOrProvince.SelectedIndex = -1;
            txtStaffFirstName.Focus();

        }

        private void HandleBtnStaffPhotoClick(object? sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif;*.tiff;*.svg";
            openFileDialog.FilterIndex = 1; // Default filter index
            openFileDialog.RestoreDirectory = true;


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the path of the selected file
                string selectedFilePath = openFileDialog.FileName;

                // Load the selected image into the PictureBox
                pbStaffPhoto.Image = System.Drawing.Image.FromFile(selectedFilePath);
                pbStaffPhoto.SizeMode = PictureBoxSizeMode.StretchImage; //
            }
        }

        private void LoadAllStaffs(object? sender, EventArgs e)
        {
            var staffs = StaffHelper.GetAllStaffs(Program.Connection);
        }

        private bool ValidateTextBoxNumber(TextBox txt, ErrorProvider errorProvider)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                errorProvider.SetError(txt, $"{nameof(txt)} cannot be empty!");
                return false;
            }
            else if (!double.TryParse(txt.Text, out double _))
            {
                errorProvider.SetError(txt, $"{nameof(txt)} must be a number!");
                return false;
            }
            else
            {
                errorProvider.SetError(txt, string.Empty);
                return true;
            }
        }

        private bool ValidateTextBox(TextBox txt, ErrorProvider errorProvider)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                errorProvider.SetError(txt, $"{nameof(txt)} cannot be empty!");
                return false;
            }
            else
            {
                errorProvider.SetError(txt, string.Empty);
                return true;
            }
        }

        private void ShutDownError(TextBox txt, ErrorProvider errorProvider)
        {
            if (errorProvider != null)
            {
                errorProvider.Clear();
            }
        }

        private void ConfigDefaultValues()
        {
            chbStaffStoppedWork.Checked = false;
            rdbFemale.Checked = false;
            rdbMale.Checked = true;
            cbStaffCityOrProvince.SelectedIndex = 0;
            cbStaffPosition.SelectedIndex = 0;
        }
    }
}
