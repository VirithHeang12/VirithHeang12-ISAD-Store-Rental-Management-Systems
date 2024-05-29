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
        public BindingSource StaffBindingSource {  get; set; }
        public FrmStaff(): base()
        {
           
            InitializeComponent();
            StaffBindingSource = new BindingSource();

            this.Load += LoadAllStaffs;
            btnPickStaffPhoto.Click += HandleBtnStaffPhotoClick;
            btnNewStaff.Click += HandleBtnNewStaffClick;
            btnInsertStaff.Click += HandleBtnInsertStaffClick;
            txtStaffFirstName.GotFocus += HandleTxtStaffFirstNameGotFocus;
        }

        private void HandleTxtStaffFirstNameGotFocus(object? sender, EventArgs e)
        {
            ShutDownError(txtStaffFirstName, epdStaffFirstName);
        }

        private void HandleBtnInsertStaffClick(object? sender, EventArgs e)
        {
            if (ValidateTextBox(txtStaffFirstName, epdStaffFirstName))
            {
                // Proceed with form submission or further processing
            }
            //else
            //{
            //    // Handle validation failure (e.g., show a message to the user)
            //    MessageBox.Show("Please correct the errors and try again.");
            //}
        }

        private void HandleBtnNewStaffClick(object? sender, EventArgs e)
        {
            ClearAllFields();

        }

        private void ClearAllFields()
        {
            chbStaffStoppedWork.Checked = false;
            txtStaffFirstName.Text = string.Empty;
            txtStaffLastName.Text = string.Empty;
            rdbFemale.Checked = false;
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

        private bool ValidateTextBox(TextBox txt, ErrorProvider errorProvider)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                errorProvider.SetError(txt, $"nameof(txt) cannot be empty!");
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
    }
}
