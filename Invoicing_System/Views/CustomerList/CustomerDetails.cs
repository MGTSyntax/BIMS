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

namespace Invoicing_System.Views.CustomerList
{
    public partial class CustomerDetails : Form
    {
        private CustomerSetup customerSetup;
        Variables var = new Variables();
        Functions functions = new Functions();
        Validations val = new Validations();
        public string FormCode { get; set; }
        public int CustID { get; set; }

        public CustomerDetails(CustomerSetup _customerSetup)
        {
            InitializeComponent();
            customerSetup = _customerSetup;
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void CustomerDetails_Load(object sender, EventArgs e)
        {
            txtAgencyFeeRate.Text = "0.00";
            txtFBAmt.Text = "0.00";

            PopulateTitleTemplate();
            functions.PopulateMIBCompanies(cmbComp, txtcompID, null);
            if (FormCode == "UPD")
            {
                PopulateControlsToUpdate();
            }
        }

        // Populate Title Template
        private void PopulateTitleTemplate()
        {
            string TTquery = "SELECT titleid,titleDescription FROM titletemplate WHERE titleStatus=1 ORDER by titleid";
            string TTdisplayMember = "titleid";
            string TTvalueMember = "titleDescription";
            functions.PopulateComboboxFromDb(cbTT, TTquery, TTdisplayMember, TTvalueMember, "0", null);
            lblTT.Text = cbTT.SelectedValue.ToString();
        } // End of Populate Title Template

        //// Populate MIB Companies
        //private void PopulateMIBCompanies()
        //{
        //    string TTquery = "SELECT companyID,companyName FROM tblcompanies WHERE isActive=1 ORDER by companyID";
        //    string TTdisplayMember = "companyName";
        //    string TTvalueMember = "companyID";
        //    functions.PopulateComboboxFromDb(cmbComp, TTquery, TTdisplayMember, TTvalueMember, "Select an option", "0");
        //    txtcompID.Text = cmbComp.SelectedValue.ToString();
        //} // End of Populate Title Template

        private void PopulateControlsToUpdate()
        {
            string query = "SELECT custName,contactPerson,cpPosition,custagencyFee,isvatable,otherBillAmt," +
                "companyAddress,emailAddress,titleid,hasInterest,b.companyName,tin,telno FROM customerstable a " +
                "LEFT JOIN tblcompanies b ON a.compID = b.companyID WHERE custID = '" + CustID.ToString() + "'";
            var.dt = functions.SelectData(query, "customerstable");
            if (var.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in var.dt.Rows)
                {
                    txtDetachmentName.Text = dr[0].ToString();
                    txtContactPerson.Text = dr[1].ToString();
                    txtPosition.Text = dr[2].ToString();
                    txtAgencyFeeRate.Text = dr[3].ToString();
                    chkVatable.Checked = dr[4].ToString() == "1" ? true : false;
                    txtFBAmt.Text = dr[5].ToString();
                    txtCompanyAddress.Text = dr[6].ToString();
                    txtEmailAddress.Text = dr[7].ToString();
                    cbTT.Text = dr[8].ToString();
                    chkInterest.Checked = dr[9].ToString() == "1" ? true : false;
                    cmbComp.Text = dr[10].ToString();
                    txtTIN.Text = dr[11].ToString();
                    txtTelNo.Text = dr[12].ToString();
                }
            }
        } // End of PopulateControlsToUpdate

        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            bool isStringValid = val.FormStringValidation(GetControlsToValidateString(), errorProvider1);
            bool isNumbersValid = val.isNumeric(GetControlsToValidateNumbers(), errorProvider1);
            int isVATValue = chkVatable.Checked ? 1 : 0;
            int isInterestValue = chkInterest.Checked ? 1 : 0;

            if (FormCode == "CRT")
            {
                if (isStringValid && isNumbersValid)
                {
                    string addCustomer = "INSERT INTO customerstable(custName,contactPerson,cpPosition," +
                        "custagencyFee,isvatable,otherBillAmt,companyAddress,emailAddress,titleid," +
                        "hasInterest,isDeleted,compID,tin,telno) " +
                        "VALUES('" + txtDetachmentName.Text + "','" + txtContactPerson.Text + "'," +
                        "'" + txtPosition.Text + "','" + txtAgencyFeeRate.Text + "','" + isVATValue + "'," +
                        "'" + txtFBAmt.Text + "','" + txtCompanyAddress.Text + "','" + txtEmailAddress.Text + "'," +
                        "'" + cbTT.Text + "','" + isInterestValue + "','0','" + txtcompID.Text + "'," +
                        ",'" + txtTIN.Text + "','" + txtTelNo.Text + "')";
                    functions.SaveData(addCustomer);

                    customerSetup.PopulateCustomers();
                    customerSetup.PopTotal();
                    MessageBox.Show("Customer Successfully Added!", var._title, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Save history for logs
                    functions.SaveData("CALL SP_history('" + Variables.user_unameValue + "','customerstable_h'," +
                        "'customerstable','custID',(SELECT MAX(custID) FROM customerstable))");

                    this.Dispose();
                }
            }
            else if (FormCode == "UPD")
            {
                if (isStringValid && isNumbersValid)
                {
                    string updateCustomer = "UPDATE customerstable SET " +
                        "custName = '" + txtDetachmentName.Text + "'," +
                        "contactPerson = '" + txtContactPerson.Text + "'," +
                        "cpPosition = '" + txtPosition.Text + "'," +
                        "custagencyFee = '" + txtAgencyFeeRate.Text + "'," +
                        "isvatable = '" + isVATValue + "'," +
                        "otherBillAmt = '" + txtFBAmt.Text + "'," +
                        "companyAddress = '" + txtCompanyAddress.Text + "'," +
                        "emailAddress = '" + txtEmailAddress.Text + "'," +
                        "titleid = '" + cbTT.Text + "'," +
                        "hasInterest = '" + isInterestValue + "'," +
                        "compID = '" + txtcompID.Text + "'," +
                        "tin = '" + txtTIN.Text + "'," +
                        "telno = '" + txtTelNo.Text + "' " +
                        "WHERE custID = '" + CustID.ToString() + "'";
                    functions.SaveData(updateCustomer);

                    MessageBox.Show("Customer Details Successfully Updated!", var._title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    customerSetup.PopulateCustomers();
                    customerSetup.PopTotal();

                    // Save history for logs
                    functions.SaveData("CALL SP_history('" + Variables.user_unameValue + "','customerstable_h'," +
                        "'customerstable','custID','" + CustID.ToString() + "')");

                    this.Dispose();
                }
            }
        }

        // Get Controls to Validate String Value
        private IEnumerable<Control> GetControlsToValidateString()
        {
            yield return txtDetachmentName;
            yield return txtContactPerson;
            yield return txtEmailAddress;

        } // End of GetControlsToValidateString

        // Get Controls to Validate Numeric Value
        private IEnumerable<Control> GetControlsToValidateNumbers()
        {
            yield return txtAgencyFeeRate;
            yield return txtFBAmt;
            yield return txtTIN;
            yield return txtTelNo;

        } // End of GetControlsToValidateNumbers

        private void cbTT_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTT.Text = cbTT.SelectedValue.ToString();
        }

        private void cmbComp_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtcompID.Text = cmbComp.SelectedValue.ToString();
        }
    }
}
