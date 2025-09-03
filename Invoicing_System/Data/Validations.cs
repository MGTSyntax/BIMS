using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoicing_System.Data
{
    public class Validations : Variables
    {

        // Check Controls for Null or Empty Value
        public bool FormStringValidation(IEnumerable<Control> control, ErrorProvider errorProvider)
        {
            foreach (var ctrl in control)
            {
                if (string.IsNullOrEmpty(ctrl.Text) || ctrl.Text == "--Select an option--")
                {
                    errorProvider.SetError(ctrl, "This field is required.");
                    ctrl.Focus();
                    return false;
                }
                else errorProvider.SetError(ctrl, null);
            }
            return true;
        } // End of FormStringValidation

        // Check Controls for Numeric Value Only
        public bool isNumeric(IEnumerable<Control> control, ErrorProvider errorProvider)
        {
            foreach (var ctrl in control)
            {
                if (!decimal.TryParse(ctrl.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out _))
                {
                    errorProvider.SetError(ctrl, "Numbers Only!");
                    return false;
                }
                else errorProvider.SetError(ctrl, null);
            }

            return true;
        } // End of isNumeric

        // Check if a textbox has numeric value only
        public bool ValidateNumeric(TextBox ctrl, ErrorProvider errorProvider)
        {
            if (ctrl == null) return false;

            bool isValid = decimal.TryParse(ctrl.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out _);
            
            if(!isValid)
            {
                errorProvider.SetError(ctrl, "Numbers Only!");
                ctrl.SelectAll();
                ctrl.Focus();
            }
            else
            {
                errorProvider.SetError(ctrl, null);
            }

            return isValid;
        }

        // Check for Valid Date Range
        public bool isDateRangeValid(DateTimePicker dateFrom, DateTimePicker dateTo, ErrorProvider errorProvider)
        {
            if (dateFrom.Value.Date > dateTo.Value.Date)
            {
                errorProvider.SetError(dateFrom, "Please check your date value!");
                return false;
            }
            return true;
        } // End of isDateRangeValid

        public void isCheckBoxChecked(CheckBox chkbox, Control ctrl)
        {
            if (chkbox.Checked) ctrl.Enabled = true;
            else ctrl.Enabled = false;
        }
    }
}
