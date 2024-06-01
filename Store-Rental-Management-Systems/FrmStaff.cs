using Microsoft.Data.SqlClient;
using StoreRentalHelper;
using StoreRentalHelper.entities;
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
        public FrmStaff(): base()
        {
           
            InitializeComponent();
            StaffBindingSource = new BindingSource();
            ConfigDefaultValues();

            #region Event registration for CRUD operations
            this.Load += LoadAllStaffs;
            btnPickStaffPhoto.Click += HandleBtnStaffPhotoClick;
            btnNewStaff.Click += HandleBtnNewStaffClick;
            btnInsertStaff.Click += HandleBtnInsertStaffClick;
            #endregion

            #region Event registration for shutting down error on got focus
            txtStaffFirstName.GotFocus += HandleTxtStaffFirstNameGotFocus;
            txtStaffLastName.GotFocus += HandleTxtStaffLastNameGotFocus;
            txtStaffIdentityCardNumber.GotFocus += HandleTxtIDCardNumberGotFocus;
            txtStaffSalary.GotFocus += HandleTxtStaffSalaryGotFocus;
            mtxtStaffContactNumber.GotFocus += HandleMTxtStaffContactNumberGotFocus;
            mtxtStaffPersonalNumber.GotFocus += MtxtStaffPersonalNumberGotFocus;
            txtStaffHouseNo.GotFocus += HandleStaffTxtHouseNoGotFocus;
            txtStaffStreetNo.GotFocus += HandleStaffTxtStreetNoGotFocus;
            txtStaffSangkat.GotFocus += HandleStaffTxtSangkatGotFocus;
            txtStaffKhan.GotFocus += HandleStaffTxtKhanGotFocus;
            #endregion
        }

        #region Error shutdown event handlers
        private void HandleStaffTxtKhanGotFocus(object? sender, EventArgs e)
        {
            ShutDownError(txtStaffKhan, epdStaffKhan);
        }

        private void HandleStaffTxtSangkatGotFocus(object? sender, EventArgs e)
        {
            ShutDownError(txtStaffSangkat, epdStaffSangkat);
        }

        private void HandleStaffTxtStreetNoGotFocus(object? sender, EventArgs e)
        {
            ShutDownError(txtStaffStreetNo, epdStaffStreetNo);
        }

        private void HandleStaffTxtHouseNoGotFocus(object? sender, EventArgs e)
        {
            ShutDownError(txtStaffHouseNo, epdStaffHouseNo);
        }

        private void MtxtStaffPersonalNumberGotFocus(object? sender, EventArgs e)
        {
            ShutDownError(mtxtStaffPersonalNumber, epdStaffPersonalNumber);
        }

        private void HandleMTxtStaffContactNumberGotFocus(object? sender, EventArgs e)
        {
            ShutDownError(mtxtStaffContactNumber, epdStaffContactNumber);
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
        #endregion

        #region Insert event handler
        private void HandleBtnInsertStaffClick(object? sender, EventArgs e)
        {
            if (ValidateTextBox(txtStaffFirstName, epdStaffFirstName) || ValidateTextBox(txtStaffLastName, epdStaffLastName) || ValidateTextBox(txtStaffIdentityCardNumber, epdStaffIdentityCardNumber) || ValidateTextBoxNumber(txtStaffSalary, epdStaffSalary) || ValidateMaskedTextBox(mtxtStaffContactNumber, epdStaffContactNumber) || ValidateMaskedTextBox(mtxtStaffPersonalNumber, epdStaffPersonalNumber) || ValidateTextBox(txtStaffHouseNo, epdStaffHouseNo) || ValidateTextBox(txtStaffStreetNo, epdStaffStreetNo) || ValidateTextBox(txtStaffSangkat, epdStaffSangkat) || ValidateTextBox(txtStaffKhan, epdStaffKhan))
            {
                StaffHelper.AddStaff(Program.Connection, new Staff()
                {
                    StaffFirstName = txtStaffFirstName.Text,
                    StaffLastName = txtStaffLastName.Text,
                    Sex = rdbFemale.Checked ? 'F' : 'M',
                    BirthDate = DateOnly.Parse(dtpStaffBirthDate.Text),
                    IdentityCardNumber = txtStaffIdentityCardNumber.Text,
                    StaffPosition = cbStaffPosition.Text,
                    HouseNo = txtStaffHouseNo.Text,
                    StreetNo = txtStaffStreetNo.Text,
                    Sangkat = txtStaffSangkat.Text,
                    Khan = txtStaffKhan.Text,
                    ProvinceOrCity = cbStaffCityOrProvince.Text,
                    ContactNumber = mtxtStaffContactNumber.Text,
                    PersonalNumber = mtxtStaffPersonalNumber.Text,
                    Salary = double.Parse(txtStaffSalary.Text),
                    HiredDate = DateOnly.Parse(dtpStaffHiredDate.Text),
                    Photo = BitmapToByteArray(new Bitmap(pbStaffPhoto.Image)),
                    StoppedWork = chbStaffStoppedWork.Checked

                }) ; 
            }
        }
        #endregion

        #region New event handler
        private void HandleBtnNewStaffClick(object? sender, EventArgs e)
        {
            ClearAllFields();
            ConfigDefaultValues();
            MaskedTextBox maskedText = new MaskedTextBox();
        }
        #endregion

        #region Clear all input fields
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
            mtxtStaffContactNumber.Text = string.Empty;
            mtxtStaffPersonalNumber.Text = string.Empty;
            txtStaffHouseNo.Text = string.Empty;
            txtStaffStreetNo.Text = string.Empty;
            txtStaffSangkat.Text = string.Empty;
            txtStaffKhan.Text = string.Empty;
            cbStaffCityOrProvince.SelectedIndex = -1;
            txtStaffFirstName.Focus();

        }
        #endregion

        #region Event handler for staff photo click
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
        #endregion

        #region Event handler for loading all staffs and render initial picture
        private void LoadAllStaffs(object? sender, EventArgs e)
        {
            RenderInitialPicture();
            //var staffs = StaffHelper.GetAllStaffs(Program.Connection);
        }
        #endregion

        #region Validate textbox number input fields
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

        #endregion

        #region Validate TextBox
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
        #endregion

        #region Validate MaskedTextBox
        private bool ValidateMaskedTextBox(MaskedTextBox mtxt, ErrorProvider errorProvider)
        {
            if (!mtxt.MaskCompleted)
            {
                errorProvider.SetError(mtxt, $"{nameof(mtxt)} cannot be empty!");
                return false;
            }
            else
            {
                errorProvider.SetError(mtxt, string.Empty);
                return true;
            }
        }
        #endregion

        #region Shutdown Error
        private void ShutDownError(TextBoxBase txt, ErrorProvider errorProvider)
        {
            if (errorProvider != null)
            {
                errorProvider.Clear();
            }
        }
        #endregion

        #region Config Default Input values
        private void ConfigDefaultValues()
        {
            chbStaffStoppedWork.Checked = false;
            rdbFemale.Checked = false;
            rdbMale.Checked = true;
            cbStaffCityOrProvince.SelectedIndex = 0;
            cbStaffPosition.SelectedIndex = 0;
        }
        #endregion

        #region Render initial picture
        private void RenderInitialPicture()
        {
            pbStaffPhoto.Visible = true;
            Bitmap initialImage = Properties.Resources.account_search;
            pbStaffPhoto.Image = initialImage;
        }
        #endregion

        #region Convert image to byte[]
        static byte[] BitmapToByteArray(Bitmap bitmap)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                // Save the bitmap to the stream in the desired format
                bitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Png);

                // Return the byte array from the stream
                return stream.ToArray();
            }
        }
        #endregion
    }
}
