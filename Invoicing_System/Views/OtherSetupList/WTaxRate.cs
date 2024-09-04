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
    public partial class WTaxRate : Form
    {
        Variables var = new Variables();
        Functions functions = new Functions();
        Validations val = new Validations();
        private frmOtherSetup frmOtherSetup;
        public string FormCode { get; set; }
        public int WTRID { get; set; }
        public WTaxRate(frmOtherSetup frmOS)
        {
            InitializeComponent();
            frmOtherSetup = frmOS;
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void WTaxRate_Load(object sender, EventArgs e)
        {
            PopulateControlsToUpdate();
        }

        private void PopulateControlsToUpdate()
        {
            string query = "SELECT * FROM tblwtax WHERE wtaxID = '" + WTRID.ToString() + "'";
            var.dt = functions.SelectData(query, "tblwtax");
            if (var.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in var.dt.Rows)
                {
                    txtWTaxRate.Text = dr[1].ToString();
                }
            }
        } // End of PopulateControlsToUpdate

        private void btnSaveWTR_Click(object sender, EventArgs e)
        {
            bool isNumbersValid = val.isNumeric(GetControlsToValidateNumbers(), errorProvider1);

            if (isNumbersValid)
            {
                string updateWTaxRate = "UPDATE tblwtax SET " +
                    "wtax_rate = '" + txtWTaxRate.Text + "' " +
                    "WHERE wtaxID = '" + WTRID.ToString() + "'";
                functions.SaveData(updateWTaxRate);

                MessageBox.Show("Withholding Tax Rate Successfully Updated!", var._title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmOtherSetup.PopulateWTaxRate();

                // Save history for logs
                functions.SaveData("CALL SP_history('" + Variables.user_unameValue + "','tblwtax_h'," +
                    "'tblwtax','wtaxID','" + WTRID.ToString() + "')");

                this.Dispose();
            }
        }

        // Get Controls to Validate Numeric Value
        private IEnumerable<Control> GetControlsToValidateNumbers()
        {
            yield return txtWTaxRate;

        } // End of GetControlsToValidateNumbers

    }
}
