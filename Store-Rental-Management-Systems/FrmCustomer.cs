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
    public partial class FrmCustomer : FrmHome
    {
        public BindingSource CustomerBindingSource { get; set; }
        private Binding? _customerIDBinding;
        private Binding? _customerFirstNameBinding;
        private Binding? _customerLastNameBinding;
        private Binding? _customerIsMaleBinding;
        private Binding? _customerIsFemaleBinding;
        private Binding? _customerBirthDateBinding;
        private Binding? _customerIdentityCardNumberBinding;
        private Binding? _customerHouseNoBinding;
        private Binding? _customerStreetNoBinding;
        private Binding? _customerSangkatBinding;
        private Binding? _customerKhanBinding;
        private Binding? _customerProvinceOrCityBinding;
        private Binding? _customerContactNumberBinding;

        public FrmCustomer() : base()
        {

            InitializeComponent();
            CustomerBindingSource = new BindingSource();
            ConfigDefaultValues();


            txtCustomerFirstName.GotFocus += HandleGotFocusKM;
            txtCustomerLastName.GotFocus += HandleGotFocusKM;
            dtpCustomerBirthDate.GotFocus += HandleGotFocusEN;
            mtxtCustomerContactNumber.GotFocus += HandleGotFocusEN;
            txtCustomerIdentityCardNumber.GotFocus += HandleGotFocusEN;
            txtCustomerHouseNo.GotFocus += HandleGotFocusEN;
            txtCustomerStreetNo.GotFocus += HandleGotFocusEN;
            txtCustomerSangkat.GotFocus += HandleGotFocusKM;
            txtCustomerKhan.GotFocus += HandleGotFocusKM;
            cbCustomerCityOrProvince.GotFocus += HandleGotFocusKM;


            #region Event registration for CRUD operations
            //this.Load += LoadAllCustomers;
            btnPickCustomerPhoto.Click += HandleBtnCustomerPhotoClick;
            btnNewCustomer.Click += HandleBtnNewCustomerClick;
            btnInsertCustomer.Click += HandleBtnInsertCustomerClick;
            #endregion

            #region Event registration for shutting down error on got focus
            txtCustomerFirstName.GotFocus += HandleTxtCustomerFirstNameGotFocus;
            txtCustomerLastName.GotFocus += HandleTxtCustomerLastNameGotFocus;
            txtCustomerIdentityCardNumber.GotFocus += HandleTxtIDCardNumberGotFocus;
            mtxtCustomerContactNumber.GotFocus += HandleMTxtCustomerContactNumberGotFocus;
            txtCustomerHouseNo.GotFocus += HandleCustomerTxtHouseNoGotFocus;
            txtCustomerStreetNo.GotFocus += HandleCustomerTxtStreetNoGotFocus;
            txtCustomerSangkat.GotFocus += HandleCustomerTxtSangkatGotFocus;
            txtCustomerKhan.GotFocus += HandleCustomerTxtKhanGotFocus;
            #endregion

            #region Register event for converting and changing image
            CustomerBindingSource.CurrentChanged += HandleCustomerBindingSourceCurrentChanged;
            #endregion

        }

        #region HandleGotFocus
        private void HandleGotFocusKM(object? sender, EventArgs e)
        {
            KeyboardLayoutHelper.SwitchToKhmerKeyboard();
        }
        private void HandleGotFocusEN(object? sender, EventArgs e)
        {
            KeyboardLayoutHelper.SwitchToEnglishKeyboard();
        }
        #endregion

        #region HandleCustomerBindingSourceCurrentChanged
        private void HandleCustomerBindingSourceCurrentChanged(object? sender, EventArgs e)
        {
            //if (CustomerBindingSource.Current is Customer selectedCustomer && selectedCustomer.Photo != null)
            //{
            //    using (MemoryStream ms = new MemoryStream(selectedCustomer.Photo))
            //    {
            //        pbCustomerPhoto.Image = Image.FromStream(ms);
            //    }
            //}
            //else
            //{
            //    pbCustomerPhoto.Image = null;
            //}
        }
        #endregion

        #region Instantiate bindings

        private void InstantiateBindings()
        {
            _customerIDBinding = new Binding("Text", CustomerBindingSource, "CustomerID");
            _customerFirstNameBinding = new Binding("Text", CustomerBindingSource, "CustomerFirstName");
            _customerLastNameBinding = new Binding("Text", CustomerBindingSource, "CustomerLastName");
            _customerIsFemaleBinding = new Binding("Checked", CustomerBindingSource, "IsFemale");
            _customerIsMaleBinding = new Binding("Checked", CustomerBindingSource, "IsMale");
            _customerBirthDateBinding = new Binding("Text", CustomerBindingSource, "BirthDate");
            _customerIdentityCardNumberBinding = new Binding("Text", CustomerBindingSource, "IdentityCardNumber");
            _customerHouseNoBinding = new Binding("Text", CustomerBindingSource, "HouseNo");
            _customerStreetNoBinding = new Binding("Text", CustomerBindingSource, "StreetNo");
            _customerSangkatBinding = new Binding("Text", CustomerBindingSource, "Sangkat");
            _customerKhanBinding = new Binding("Text", CustomerBindingSource, "Khan");
            _customerProvinceOrCityBinding = new Binding("Text", CustomerBindingSource, "ProvinceOrCity");
            _customerContactNumberBinding = new Binding("Text", CustomerBindingSource, "ContactNumber");
        }

        #endregion

        #region Bind bindings to controls
        private void BindListBoxToOtherControl()
        {
            if (txtCustomerID.DataBindings.Count == 0)
                txtCustomerID.DataBindings.Add(_customerIDBinding);

            if (txtCustomerFirstName.DataBindings.Count == 0)
                txtCustomerFirstName.DataBindings.Add(_customerFirstNameBinding);

            if (txtCustomerLastName.DataBindings.Count == 0)
                txtCustomerLastName.DataBindings.Add(_customerLastNameBinding);

            if (rdbFemale.DataBindings.Count == 0)
                rdbFemale.DataBindings.Add(_customerIsFemaleBinding);

            if (rdbMale.DataBindings.Count == 0)
                rdbMale.DataBindings.Add(_customerIsMaleBinding);

            if (dtpCustomerBirthDate.DataBindings.Count == 0)
                dtpCustomerBirthDate.DataBindings.Add(_customerBirthDateBinding);

            if (txtCustomerIdentityCardNumber.DataBindings.Count == 0)
                txtCustomerIdentityCardNumber.DataBindings.Add(_customerIdentityCardNumberBinding);

            if (txtCustomerHouseNo.DataBindings.Count == 0)
                txtCustomerHouseNo.DataBindings.Add(_customerHouseNoBinding);

            if (txtCustomerStreetNo.DataBindings.Count == 0)
                txtCustomerStreetNo.DataBindings.Add(_customerStreetNoBinding);

            if (txtCustomerSangkat.DataBindings.Count == 0)
                txtCustomerSangkat.DataBindings.Add(_customerSangkatBinding);

            if (txtCustomerKhan.DataBindings.Count == 0)
                txtCustomerKhan.DataBindings.Add(_customerKhanBinding);

            if (cbCustomerCityOrProvince.DataBindings.Count == 0)
                cbCustomerCityOrProvince.DataBindings.Add(_customerProvinceOrCityBinding);

            if (mtxtCustomerContactNumber.DataBindings.Count == 0)
                mtxtCustomerContactNumber.DataBindings.Add(_customerContactNumberBinding);
        }
        #endregion

        #region Unbind bindings
        private void UnBindListBoxToOtherControl()
        {
            if (txtCustomerID.DataBindings.Count > 0)
                txtCustomerID.DataBindings.Remove(_customerIDBinding);

            if (txtCustomerFirstName.DataBindings.Count > 0)
                txtCustomerFirstName.DataBindings.Remove(_customerFirstNameBinding);

            if (txtCustomerLastName.DataBindings.Count > 0)
                txtCustomerLastName.DataBindings.Remove(_customerLastNameBinding);

            if (rdbFemale.DataBindings.Count > 0)
                rdbFemale.DataBindings.Remove(_customerIsFemaleBinding);

            if (rdbMale.DataBindings.Count > 0)
                rdbMale.DataBindings.Remove(_customerIsMaleBinding);

            if (dtpCustomerBirthDate.DataBindings.Count > 0)
                dtpCustomerBirthDate.DataBindings.Remove(_customerBirthDateBinding);

            if (txtCustomerIdentityCardNumber.DataBindings.Count > 0)
                txtCustomerIdentityCardNumber.DataBindings.Remove(_customerIdentityCardNumberBinding);

            if (txtCustomerHouseNo.DataBindings.Count > 0)
                txtCustomerHouseNo.DataBindings.Remove(_customerHouseNoBinding);

            if (txtCustomerStreetNo.DataBindings.Count > 0)
                txtCustomerStreetNo.DataBindings.Remove(_customerStreetNoBinding);

            if (txtCustomerSangkat.DataBindings.Count > 0)
                txtCustomerSangkat.DataBindings.Remove(_customerSangkatBinding);

            if (txtCustomerKhan.DataBindings.Count > 0)
                txtCustomerKhan.DataBindings.Remove(_customerKhanBinding);

            if (cbCustomerCityOrProvince.DataBindings.Count > 0)
                cbCustomerCityOrProvince.DataBindings.Remove(_customerProvinceOrCityBinding);

            if (mtxtCustomerContactNumber.DataBindings.Count > 0)
                mtxtCustomerContactNumber.DataBindings.Remove(_customerContactNumberBinding);

        }
        #endregion

        #region Error shutdown event handlers
        private void HandleCustomerTxtKhanGotFocus(object? sender, EventArgs e)
        {
            ShutDownError(txtCustomerKhan, epdCustomerKhan);
        }

        private void HandleCustomerTxtSangkatGotFocus(object? sender, EventArgs e)
        {
            ShutDownError(txtCustomerSangkat, epdCustomerSangkat);
        }

        private void HandleCustomerTxtStreetNoGotFocus(object? sender, EventArgs e)
        {
            ShutDownError(txtCustomerStreetNo, epdCustomerStreetNo);
        }

        private void HandleCustomerTxtHouseNoGotFocus(object? sender, EventArgs e)
        {
            ShutDownError(txtCustomerHouseNo, epdCustomerHouseNo);
        }

        private void HandleMTxtCustomerContactNumberGotFocus(object? sender, EventArgs e)
        {
            ShutDownError(mtxtCustomerContactNumber, epdCustomerContactNumber);
        }

        private void HandleTxtIDCardNumberGotFocus(object? sender, EventArgs e)
        {
            ShutDownError(txtCustomerIdentityCardNumber, epdCustomerIdentityCardNumber);
        }

        private void HandleTxtCustomerLastNameGotFocus(object? sender, EventArgs e)
        {
            ShutDownError(txtCustomerLastName, epdCustomerLastName);
        }

        private void HandleTxtCustomerFirstNameGotFocus(object? sender, EventArgs e)
        {
            ShutDownError(txtCustomerFirstName, epdCustomerFirstName);
        }
        #endregion

        #region Insert event handler
        private void HandleBtnInsertCustomerClick(object? sender, EventArgs e)
        {
            //if (ValidateTextBox(txtCustomerFirstName, epdCustomerFirstName) || ValidateTextBox(txtCustomerLastName, epdCustomerLastName) || ValidateTextBox(txtCustomerIdentityCardNumber, epdCustomerIdentityCardNumber) || ValidateMaskedTextBox(mtxtCustomerContactNumber, epdCustomerContactNumber) || ValidateTextBox(txtCustomerHouseNo, epdCustomerHouseNo) || ValidateTextBox(txtCustomerStreetNo, epdCustomerStreetNo) || ValidateTextBox(txtCustomerSangkat, epdCustomerSangkat) || ValidateTextBox(txtCustomerKhan, epdCustomerKhan))
            //{
            //    CustomerHelper.AddCustomer(Program.Connection, new Customer()
            //    {
            //        CustomerFirstName = txtCustomerFirstName.Text,
            //        CustomerLastName = txtCustomerLastName.Text,
            //        Sex = rdbFemale.Checked ? 'F' : 'M',
            //        BirthDate = DateOnly.Parse(dtpCustomerBirthDate.Text),
            //        IdentityCardNumber = txtCustomerIdentityCardNumber.Text,
            //        HouseNo = txtCustomerHouseNo.Text,
            //        StreetNo = txtCustomerStreetNo.Text,
            //        Sangkat = txtCustomerSangkat.Text,
            //        Khan = txtCustomerKhan.Text,
            //        ProvinceOrCity = cbCustomerCityOrProvince.Text,
            //        ContactNumber = mtxtCustomerContactNumber.Text,
            //        Photo = BitmapToByteArray(new Bitmap(pbCustomerPhoto.Image)),
            //    });
            //    ReloadCustomers();
            //    BindListBoxToOtherControl();
            //}

        }
        #endregion

        #region New event handler
        private void HandleBtnNewCustomerClick(object? sender, EventArgs e)
        {
            ClearAllFields();
            ConfigDefaultValues();
            RenderInitialPicture();
            UnBindListBoxToOtherControl();
        }
        #endregion

        #region Clear all input fields
        private void ClearAllFields()
        {
            txtCustomerID.Text = string.Empty;
            txtCustomerFirstName.Text = string.Empty;
            txtCustomerLastName.Text = string.Empty;
            rdbFemale.Checked = true;
            rdbMale.Checked = false;
            dtpCustomerBirthDate.Value = DateTime.Now;
            txtCustomerIdentityCardNumber.Text = string.Empty;
            mtxtCustomerContactNumber.Text = string.Empty;
            txtCustomerHouseNo.Text = string.Empty;
            txtCustomerStreetNo.Text = string.Empty;
            txtCustomerSangkat.Text = string.Empty;
            txtCustomerKhan.Text = string.Empty;
            cbCustomerCityOrProvince.SelectedIndex = -1;
            txtCustomerFirstName.Focus();

        }
        #endregion

        #region Event handler for Customer photo click
        private void HandleBtnCustomerPhotoClick(object? sender, EventArgs e)
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
                pbCustomerPhoto.Image = System.Drawing.Image.FromFile(selectedFilePath);
                pbCustomerPhoto.SizeMode = PictureBoxSizeMode.StretchImage; //
            }
        }
        #endregion

        #region Event handler for loading all Customers and render initial picture
        private void LoadAllCustomers(object? sender, EventArgs e)
        {
            //RenderInitialPicture();
            //var customers = CustomerHelper.GetAllCustomers(Program.Connection);
            //CustomerBindingSource.DataSource = customers;
            //lbCustomer.Items.Clear();
            //lbCustomer.DataSource = CustomerBindingSource;
            //lbCustomer.DisplayMember = "FullName";
            //lbCustomer.ValueMember = "CustomerID";
            //InstantiateBindings();
            //BindListBoxToOtherControl();
        }
        #endregion

        #region Reload Customers
        private void ReloadCustomers()
        {
            //var customers = CustomerHelper.GetAllCustomers(Program.Connection);
            //CustomerBindingSource.DataSource = customers;
            //lbCustomer.DataSource = CustomerBindingSource;
            //lbCustomer.DisplayMember = "FullName";
            //lbCustomer.ValueMember = "CustomerID";
            //BindListBoxToOtherControl();
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
            rdbFemale.Checked = false;
            rdbMale.Checked = true;
            cbCustomerCityOrProvince.SelectedIndex = 0;
        }
        #endregion

        #region Render initial picture
        private void RenderInitialPicture()
        {
            pbCustomerPhoto.Visible = true;
            Bitmap initialImage = Properties.Resources.account_search;
            pbCustomerPhoto.Image = initialImage;
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
