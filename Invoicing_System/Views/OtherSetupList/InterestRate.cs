using Invoicing_System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoicing_System.Views.OtherSetupList
{
    public partial class InterestRate : Form
    {
        Variables var = new Variables();
        Functions functions = new Functions();
        Validations val = new Validations();
        private frmOtherSetup frmOtherSetup;
        public string FormCode { get; set; }
        public int IRID { get; set; }

        public InterestRate(frmOtherSetup frmOS)
        {
            InitializeComponent();
            frmOtherSetup = frmOS;
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void InterestRate_Load(object sender, EventArgs e)
        {
            PopulateControlsToUpdate();
        }

        private void PopulateControlsToUpdate()
        {
            string query = "SELECT * FROM tblinterest WHERE interestID = '" + IRID.ToString() + "'";
            var.dt = functions.SelectData(query, "tblinterest");
            if (var.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in var.dt.Rows)
                {
                    txtInterestRate.Text = dr[1].ToString();
                }
            }
        } // End of PopulateControlsToUpdate

        private void btnSaveIR_Click(object sender, EventArgs e)
        {
            bool isNumbersValid = val.isNumeric(GetControlsToValidateNumbers(), errorProvider1);

            if (isNumbersValid)
            {
                string updateInterestRate = "UPDATE tblinterest SET " +
                    "interest_rate = '" + txtInterestRate.Text + "' " +
                    "WHERE interestID = '" + IRID.ToString() + "'";
                functions.SaveData(updateInterestRate);

                MessageBox.Show("Interest Rate Successfully Updated!", var._title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmOtherSetup.PopulateInterestRate();

                // Save history for logs
                functions.SaveData("CALL SP_history('" + Variables.user_unameValue + "','tblinterest_h'," +
                    "'tblinterest','interestID','" + IRID.ToString() + "')");

                this.Dispose();
            }
        }

        // Get Controls to Validate Numeric Value
        private IEnumerable<Control> GetControlsToValidateNumbers()
        {
            yield return txtInterestRate;

        } // End of GetControlsToValidateNumbers

    }
}
