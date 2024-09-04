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

namespace Invoicing_System.Views.CompanyList
{
    public partial class CompanyDetails : Form
    {
        public string FormCode { get; set; }
        private frmCompany _frmCompany;
        Validations val = new Validations();
        Functions functions = new Functions();
        Variables var = new Variables();
        public int CompID { get; set; }

        public CompanyDetails(frmCompany frmCompany)
        {
            InitializeComponent();
            _frmCompany = frmCompany;
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSaveCompany_Click(object sender, EventArgs e)
        {
            bool isStringValid = val.FormStringValidation(GetControlsToValidateString(), companyEP);
            int isActive = chkisActive.Checked ? 1 : 0;

            if (FormCode == "CRT")
            {
                if (isStringValid)
                {
                    string addCompany = "INSERT INTO tblcompanies(companyID,companyName,isActive," +
                        "approveBy,notedBy) " +
                        "VALUES('" + txtCompCode.Text + "','" + txtCompanyDesc.Text + "'," +
                        "'" + isActive + "','" + txtApprovedBy.Text + "'," +
                        "'" + txtNotedBy.Text + "')";
                    functions.SaveData(addCompany);

                    _frmCompany.PopulateCompanies();
                    MessageBox.Show("Company Successfully Added!", var._title, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Save history for logs
                    functions.SaveData("CALL SP_history('" + Variables.user_unameValue + "','tblcompanies_h'," +
                        "'tblcompanies','id',(SELECT MAX(id) FROM tblcompanies))");

                    this.Dispose();
                }
            }
            else if (FormCode == "UPD")
            {
                if (isStringValid)
                {
                    string updateCustomer = "UPDATE tblcompanies SET " +
                        "companyID = '" + txtCompCode.Text + "'," +
                        "companyName = '" + txtCompanyDesc.Text + "'," +
                        "isActive = '" + isActive + "'," +
                        "approveBy = '" + txtApprovedBy.Text + "'," +
                        "notedBy = '" + txtNotedBy.Text + "' " +
                        "WHERE id = '" + CompID + "'";
                    functions.SaveData(updateCustomer);

                    MessageBox.Show("Company Details Successfully Updated!", var._title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _frmCompany.PopulateCompanies();

                    // Save history for logs
                    functions.SaveData("CALL SP_history('" + Variables.user_unameValue + "','tblcompanies_h'," +
                        "'tblcompanies','id','" + CompID + "')");

                    this.Dispose();
                }
            }
        }

        // Get Controls to Validate String Value
        private IEnumerable<Control> GetControlsToValidateString()
        {
            yield return txtCompCode;
            yield return txtCompanyDesc;
            yield return txtApprovedBy;
            yield return txtNotedBy;

        } // End of GetControlsToValidateString

        private void CompanyDetails_Load(object sender, EventArgs e)
        {
            if (FormCode == "UPD")
            {
                PopulateControlsToUpdate();
            }
        }

        private void PopulateControlsToUpdate()
        {
            string query = "SELECT * FROM tblcompanies WHERE id = '" + CompID.ToString() + "'";
            var.dt = functions.SelectData(query, "tblcompanies");
            if (var.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in var.dt.Rows)
                {
                    txtCompCode.Text = dr[1].ToString();
                    txtCompanyDesc.Text = dr[2].ToString();
                    chkisActive.Checked = dr[3].ToString() == "1" ? true : false;
                    txtApprovedBy.Text = dr[4].ToString();
                    txtNotedBy.Text = dr[5].ToString();
                }
            }
        } // End of PopulateControlsToUpdate

    }
}
