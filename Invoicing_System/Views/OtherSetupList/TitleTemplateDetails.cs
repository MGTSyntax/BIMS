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

namespace Invoicing_System.Views.TitleTemplateList
{
    public partial class TitleTemplateDetails : Form
    {
        Variables var = new Variables();
        Functions functions = new Functions();
        Validations val = new Validations();
        private frmOtherSetup frmOtherSetup;
        public string FormCode { get; set; }
        public int TTID { get; set; }

        public TitleTemplateDetails(frmOtherSetup frmOS)
        {
            InitializeComponent();
            frmOtherSetup = frmOS;
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSaveTitle_Click(object sender, EventArgs e)
        {
            bool isStringValid = val.FormStringValidation(GetControlsToValidateString(), errorProvider1);
            int isTTStat = chkTTStat.Checked ? 1 : 0;

            if (FormCode == "CRT")
            {
                if (isStringValid)
                {
                    string createTitle = "INSERT INTO titletemplate(titleDescription,titleStatus) " +
                        "VALUES('" + txtTitleName.Text + "','" + isTTStat + "')";
                    functions.SaveData(createTitle);

                    frmOtherSetup.PopulateTitleTemplates();
                    MessageBox.Show("Title Template Successfully Saved!", var._title, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Save history for logs
                    functions.SaveData("CALL SP_history('" + Variables.user_unameValue + "','titletemplate_h'," +
                        "'titletemplate','titleid',(SELECT MAX(titleid) FROM titletemplate))");

                    this.Dispose();
                }
            }
            else if (FormCode == "UPD")
            {
                if (isStringValid)
                {
                    string updateTitle = "UPDATE titletemplate SET " +
                        "titleDescription = '" + txtTitleName.Text + "'," +
                        "titleStatus = '" + isTTStat + "' " +
                        "WHERE titleid = '" + TTID.ToString() + "'";
                    functions.SaveData(updateTitle);

                    MessageBox.Show("Title Template Successfully Updated!", var._title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmOtherSetup.PopulateTitleTemplates();

                    // Save history for logs
                    functions.SaveData("CALL SP_history('" + Variables.user_unameValue + "','titletemplate_h'," +
                        "'titletemplate','titleid','" + TTID.ToString() + "')");

                    this.Dispose();
                }
            }
        }

        // Get Controls to Validate String Value
        private IEnumerable<Control> GetControlsToValidateString()
        {
            yield return txtTitleName;

        } // End of GetControlsToValidateString

        private void chkTTStat_CheckedChanged(object sender, EventArgs e)
        {
            chkTTStat.Text = chkTTStat.Checked ? "Active" : "Inactive";
        }

        private void TitleTemplateDetails_Load(object sender, EventArgs e)
        {
            chkTTStat.Text = chkTTStat.Checked ? "Active" : "Inactive";
            if (FormCode == "UPD")
            {
                PopulateControlsToUpdate();
            }
        }

        private void PopulateControlsToUpdate()
        {
            string query = "SELECT * FROM titletemplate WHERE titleid = '" + TTID.ToString() + "'";
            var.dt = functions.SelectData(query, "titletemplate");
            if (var.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in var.dt.Rows)
                {
                    txtTitleName.Text = dr[1].ToString();
                    chkTTStat.Checked = dr[2].ToString() == "1" ? true : false;
                }
            }
        } // End of PopulateControlsToUpdate

    }
}
