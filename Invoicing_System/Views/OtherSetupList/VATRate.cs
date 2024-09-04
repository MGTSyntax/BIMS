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
    public partial class VATRate : Form
    {
        Variables var = new Variables();
        Functions functions = new Functions();
        Validations val = new Validations();
        private frmOtherSetup frmOtherSetup;
        public string FormCode { get; set; }
        public int VRID { get; set; }

        public VATRate(frmOtherSetup frmOS)
        {
            InitializeComponent();
            frmOtherSetup = frmOS;
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void VATRate_Load(object sender, EventArgs e)
        {
            PopulateControlsToUpdate();
        }

        private void PopulateControlsToUpdate()
        {
            string query = "SELECT * FROM tblvat WHERE rateID = '" + VRID.ToString() + "'";
            var.dt = functions.SelectData(query, "tblvat");
            if (var.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in var.dt.Rows)
                {
                    txtVATRate.Text = dr[1].ToString();
                }
            }
        } // End of PopulateControlsToUpdate

        private void btnSaveVR_Click(object sender, EventArgs e)
        {
            bool isNumbersValid = val.isNumeric(GetControlsToValidateNumbers(), errorProvider1);

            if (isNumbersValid)
            {
                string updateVATRate = "UPDATE tblvat SET " +
                    "vat_rate = '" + txtVATRate.Text + "' " +
                    "WHERE rateID = '" + VRID.ToString() + "'";
                functions.SaveData(updateVATRate);

                MessageBox.Show("VAT Rate Successfully Updated!", var._title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmOtherSetup.PopulateVATRate();

                // Save history for logs
                functions.SaveData("CALL SP_history('" + Variables.user_unameValue + "','tblvat_h'," +
                    "'tblvat','rateID','" + VRID.ToString() + "')");

                this.Dispose();
            }
        }

        // Get Controls to Validate Numeric Value
        private IEnumerable<Control> GetControlsToValidateNumbers()
        {
            yield return txtVATRate;

        } // End of GetControlsToValidateNumbers

    }
}
