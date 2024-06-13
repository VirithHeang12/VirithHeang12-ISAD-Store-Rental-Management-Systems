using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_Rental_Management_Systems
{
    public static class ErrorHelper
    {
        private const string NOT_EMPTY_MSG = "Cannot be empty!";
        #region Validate TextBox
        public static void ValidateTextBox(TextBox txt, ErrorProvider errorProvider)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                errorProvider.SetError(txt, NOT_EMPTY_MSG);
            }
            else
            {
                errorProvider.SetError(txt, string.Empty);
            }
        }
        #endregion

        #region Validate textbox number input fields
        public static bool ValidateTextBoxNumber(TextBox txt, ErrorProvider errorProvider)
        {
            string errMsg = "Only numbers are allowed!";
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                errorProvider.SetError(txt, NOT_EMPTY_MSG);
                return false;
            }
            if (!double.TryParse(txt.Text, out double _))
            {
                errorProvider.SetError(txt, errMsg);
                return false;
            }
            else
            {
                errorProvider.SetError(txt, string.Empty);
                return true;
            }
        }

        #endregion

        #region Validate textbox integer input fields
        public static bool ValidateTextBoxIntegerOneToHundred(TextBox txt, ErrorProvider errorProvider)
        {
            string errMsg = "Only integeter from 1 to 100!";
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                errorProvider.SetError(txt, NOT_EMPTY_MSG);
                return false;
            }
            if (!byte.TryParse(txt.Text, out byte x) || x < 0 || x > 100)
            {
                errorProvider.SetError(txt, errMsg);
                return false;
            }
            else
            {
                errorProvider.SetError(txt, string.Empty);
                return true;
            }
        }
        #endregion

        #region Validate textbox integer input fields
        public static bool ValidateTextBoxInteger(TextBox txt, ErrorProvider errorProvider)
        {
            string errMsg = "Only integeter from 1 to 100,000!";
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                errorProvider.SetError(txt, NOT_EMPTY_MSG);
                return false;
            }
            if (!int.TryParse(txt.Text, out int x) || x < 0 || x > 100000)
            {
                errorProvider.SetError(txt, errMsg);
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
        public static bool ValidateMaskedTextBox(MaskedTextBox mtxt, ErrorProvider errorProvider)
        {
            if (!string.IsNullOrWhiteSpace(mtxt.Text))
            {
                errorProvider.SetError(mtxt, NOT_EMPTY_MSG);
                return false;
            }
            else
            {
                errorProvider.SetError(mtxt, string.Empty);
                return true;
            }
        }
        #endregion

        public static bool HasErrors(List<Control> controls, ErrorProvider errorProvider)
        {
            foreach (Control control in controls)
            {
                control.Focus();
             
                var err = errorProvider.GetError(control);

                if (!string.IsNullOrEmpty(err))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
