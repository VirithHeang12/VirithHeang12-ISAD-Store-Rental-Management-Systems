using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_Rental_Management_Systems
{
    public static class ErrorHelper
    {
        #region Validate TextBox
        public static void ValidateTextBox(TextBox txt, ErrorProvider errorProvider)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                errorProvider.SetError(txt, $"{nameof(txt)} cannot be empty!");
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

        #region Validate MaskedTextBox
        public static bool ValidateMaskedTextBox(MaskedTextBox mtxt, ErrorProvider errorProvider)
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
