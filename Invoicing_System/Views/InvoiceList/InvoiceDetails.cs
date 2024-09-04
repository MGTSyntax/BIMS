using Invoicing_System.Data;
using System.ComponentModel;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;

namespace Invoicing_System.Views.Monitoring
{
    public partial class InvoiceDetails : Form
    {
        Variables var = new Variables();
        Functions functions = new Functions();
        Validations val = new Validations();
        private frmInvoices frmInvoices;
        public string FormCode { get; set; }
        public int InvID { get; set; }
        private string _vatactive;

        public InvoiceDetails(frmInvoices frmI)
        {
            InitializeComponent();
            frmInvoices = frmI;
        }

        private void btnSaveInvoice_Click(object sender, EventArgs e)
        {
            bool isStringValid = val.FormStringValidation(GetControlsToValidateString(), errorProvider);
            bool isNumbersValid = val.isNumeric(GetControlsToValidateNumbers(), errorProvider);
            bool isDateRangeValid = val.isDateRangeValid(bpFrom, bpTo, errorProvider);

            if (FormCode == "CRT")
            {
                if (isStringValid && isNumbersValid && isDateRangeValid && isInvNumNotExists())
                {
                    string createInvoice = "INSERT INTO invoice_monitoring(reimbursement,agencyFee,vat,otherBillable,customerID," +
                        "titleTemplate,billingPeriod_from,billingPeriod_to,invoiceNumber,notes,compID,nonDeductible,preparedBy," +
                        "isVoid,printStatus,isPaid) " +
                        "VALUES('" + txtBillableType.Text.Replace(",", "") + "','" + txtAgencyFee.Text.Replace(",", "") + "','" + txtVAT.Text.Replace(",", "") + "'," +
                        "'" + txtOtherBillables.Text.Replace(",", "") + "','" + txtDetID.Text + "','" + txtInvoiceFor.Text + "'," +
                        "'" + bpFrom.Value.ToString("yyyy-MM-dd") + "','" + bpTo.Value.ToString("yyyy-MM-dd") + "'," +
                        "'" + txtInvoiceNo.Text + "','" + txtNotes.Text + "','" + txtcompID.Text + "'," +
                        "'" + txtNonDeductible.Text.Replace(",", "") + "','" + txtpreparedBy.Text + "','0','0','0')";
                    functions.SaveData(createInvoice);

                    frmInvoices.PopulateInvoices();
                    frmInvoices.PopTotals();
                    MessageBox.Show("Invoice Successfully Saved!", var._title, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Save history for logs
                    functions.SaveData("CALL SP_history('" + Variables.user_unameValue + "','invoice_monitoring_h'," +
                        "'invoice_monitoring','invoicesid',(SELECT MAX(invoicesid) FROM invoice_monitoring))");

                    this.Dispose();
                }
            }
            else if(FormCode == "UPD")
            {
                if (isStringValid && isNumbersValid && isDateRangeValid && isInvNumNotExists())
                {
                    string updateInvoice = "UPDATE invoice_monitoring SET " +
                        "reimbursement = '" + txtBillableType.Text.Replace(",", "") + "'," +
                        "agencyFee = '" + txtAgencyFee.Text.Replace(",", "") + "'," +
                        "vat = '" + txtVAT.Text.Replace(",", "") + "'," +
                        "otherBillable = '" + txtOtherBillables.Text.Replace(",", "") + "'," +
                        "customerID = '" + txtDetID.Text + "'," +
                        "titleTemplate = '" + txtInvoiceFor.Text + "'," +
                        "billingPeriod_from = '" + bpFrom.Value.ToString("yyyy-MM-dd") + "'," +
                        "billingPeriod_to = '" + bpTo.Value.ToString("yyyy-MM-dd") + "'," +
                        "invoiceNumber = '" + txtInvoiceNo.Text + "'," +
                        "notes = '" + txtNotes.Text + "'," +
                        "nonDeductible = '" + txtNonDeductible.Text.Replace(",", "") + "'," +
                        "preparedBy = '" + txtpreparedBy.Text + "' " +
                        "WHERE invoicesid = '" + InvID.ToString() + "'";
                    functions.SaveData(updateInvoice);

                    MessageBox.Show("Invoice Successfully Updated!", var._title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmInvoices.PopulateInvoices();
                    frmInvoices.PopTotals();

                    // Save history for logs
                    functions.SaveData("CALL SP_history('" + Variables.user_unameValue + "','invoice_monitoring_h'," +
                        "'invoice_monitoring','invoicesid','" + InvID.ToString() + "')");

                    this.Dispose();
                }
            }
        }

        public bool isInvNumNotExists()
        {
            string chkInvNoIfExists = "SELECT * FROM invoice_monitoring WHERE invoicesid <> '" + InvID.ToString() + "' " +
                "AND invoiceNumber = '" + txtInvoiceNo.Text + "' AND isVoid = 0";

            if (!string.IsNullOrEmpty(txtInvoiceNo.Text) || !string.IsNullOrWhiteSpace(txtInvoiceNo.Text))
            {
                var.dt = functions.SelectData(chkInvNoIfExists, "chkInvNoIfExists");
                if (var.dt.Rows.Count > 0)
                {
                    errorProvider.SetError(txtInvoiceNo, "This Invoice No. exists!");
                    return false;
                }
            }
            errorProvider.SetError(txtInvoiceNo, null);
            return true;
        }

        // Get Controls to Validate String Value
        private IEnumerable<Control> GetControlsToValidateString()
        {
            yield return cmbDetachment;

        } // End of GetControlsToValidateString

        // Get Controls to Validate Numeric Value
        private IEnumerable<Control> GetControlsToValidateNumbers()
        {
            yield return txtBillableType;
            yield return txtOtherBillables;

        } // End of GetControlsToValidateNumbers

        // Populate Detachment
        private void PopulateDetachment()
        {
            string Detquery = "SELECT custID, custName FROM customerstable WHERE isDeleted=0 " +
                "AND compID IN (" + Variables.User_CompAccess + ") ORDER by custName";
            string DetdisplayMember = "custName";
            string DetvalueMember = "custID";
            functions.PopulateComboboxFromDb(cmbDetachment, Detquery, DetdisplayMember, DetvalueMember, "Select an option", "0");
            txtDetID.Text = cmbDetachment.SelectedValue.ToString();
        } // End of Populate Detachment

        private void PopulateControlsToUpdate()
        {
            string query = "SELECT a.reimbursement,a.agencyFee,a.vat,a.otherBillable,b.custName,a.titleTemplate," +
                "a.billingPeriod_from,a.billingPeriod_to,a.invoiceNumber,a.notes,a.nonDeductible,preparedBy FROM invoice_monitoring a " +
                "LEFT JOIN customerstable b ON a.customerID = b.custID WHERE invoicesid = '" + InvID.ToString() + "'";
            var.dt = functions.SelectData(query, "invoice_monitoring");
            if (var.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in var.dt.Rows)
                {
                    txtBillableType.Text = dr[0].ToString();
                    functions.ConvertToDecimal(txtBillableType);
                    txtAgencyFee.Text = dr[1].ToString();
                    functions.ConvertToDecimal(txtAgencyFee);
                    txtVAT.Text = dr[2].ToString();
                    functions.ConvertToDecimal(txtVAT);
                    txtOtherBillables.Text = dr[3].ToString();
                    functions.ConvertToDecimal(txtOtherBillables);
                    cmbDetachment.Text = dr[4].ToString();
                    txtInvoiceFor.Text = dr[5].ToString();
                    bpFrom.Value = (DateTime)dr[6];
                    bpTo.Value = (DateTime)dr[7];
                    txtInvoiceNo.Text = dr[8].ToString();
                    txtNotes.Text = dr[9].ToString();
                    txtNonDeductible.Text = dr[10].ToString();
                    txtpreparedBy.Text = dr[11].ToString();
                    functions.ConvertToDecimal(txtNonDeductible);
                }
                string qryinvoiceNum = "SELECT * FROM interest_monitoring WHERE invoiceNum = '" + txtInvoiceNo.Text + "'";
                var dtqryinvoiceNum = functions.SelectData(qryinvoiceNum, "qryinvoiceNum");
                if (dtqryinvoiceNum.Rows.Count > 0)
                {
                    txtInvoiceNo.ReadOnly = true;
                }
            }
        } // End of PopulateControlsToUpdate

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cmbDetachment_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Reset();
            txtDetID.Text = cmbDetachment.SelectedValue.ToString();
        }

        private void txtBillableType_Leave(object sender, EventArgs e)
        {
            bool isValid = val.isNumeric(GetControlsToValidateNumbers(), errorProvider);
            if (!isValid)
            {
                txtBillableType.SelectAll();
                txtBillableType.Focus();
                txtAgencyFee.Text = "0.00";
                txtVAT.Text = "0.00";
            }
            else
            {
                functions.ConvertToDecimal(txtBillableType);

                txtAgencyFee.Text = Math.Round(double.Parse(txtBillableType.Text) * 0.2, 2).ToString();
                functions.ConvertToDecimal(txtAgencyFee);

                if(_vatactive == "1")
                {
                    txtVAT.Text = (double.Parse(txtAgencyFee.Text) * 0.12).ToString();
                    functions.ConvertToDecimal(txtVAT);
                }
            }
        }

        private void txtOtherBillables_Leave(object sender, EventArgs e)
        {
            bool isValid = val.isNumeric(GetControlsToValidateNumbers(), errorProvider);
            if (!isValid)
            {
                txtOtherBillables.SelectAll();
                txtOtherBillables.Focus();
            }
            else functions.ConvertToDecimal(txtOtherBillables);
        }

        private void chkbSpecifyTT_CheckedChanged(object sender, EventArgs e)
        {
            bool isStringValid = val.FormStringValidation(GetControlsToValidateString(), errorProvider);
            if (isStringValid)
            {
                if (chkbSpecifyTT.Checked)
                {
                    txtInvoiceFor.ReadOnly = false;
                    txtInvoiceFor.SelectAll();
                    txtInvoiceFor.Focus();
                }
                else
                {
                    txtInvoiceFor.ReadOnly = true;
                    GetCustDetails();
                }
            }
            else chkbSpecifyTT.Checked = false;
        }

        private void txtDetID_TextChanged(object sender, EventArgs e)
        {
            GetCustDetails();
        }

        public void GetCustDetails()
        {
            string qryTitleDesc = "SELECT a.titleDescription,b.isvatable,b.otherBillAmt,b.compID FROM titletemplate a " +
                "LEFT JOIN customerstable b ON a.titleid = b.titleid WHERE b.custID = '" + txtDetID.Text + "'";
            if (txtDetID.Text != "0")
            {
                var.dt = functions.SelectData(qryTitleDesc, "qryTitleDesc");
                if (var.dt.Rows.Count > 0)
                {
                    txtInvoiceFor.Text = var.dt.Rows[0]["titleDescription"].ToString();
                    _vatactive = var.dt.Rows[0]["isvatable"].ToString();
                    if (Convert.ToDecimal(var.dt.Rows[0]["otherBillAmt"].ToString()) > 0)
                    {
                        txtOtherBillables.Text = var.dt.Rows[0]["otherBillAmt"].ToString();
                    }
                    txtcompID.Text = var.dt.Rows[0]["compID"].ToString();
                }
            }
            else txtInvoiceFor.Clear();
        }

        private void txtBillableType_Click(object sender, EventArgs e)
        {
            txtBillableType.SelectAll();
            txtBillableType.Focus();
        }

        private void txtOtherBillables_Click(object sender, EventArgs e)
        {
            txtOtherBillables.SelectAll();
            txtOtherBillables.Focus();
        }

        private void InvoiceDetails_Load(object sender, EventArgs e)
        {
            Reset();

            PopulateDetachment();
            if (FormCode == "UPD")
            {
                PopulateControlsToUpdate();
            }
        }

        private void Reset()
        {
            txtBillableType.Text = "0.00";
            txtNonDeductible.Text = "0.00";
            txtAgencyFee.Text = "0.00";
            txtVAT.Text = "0.00";
            txtOtherBillables.Text = "0.00";
            bpFrom.Value = DateTime.Now;
            bpTo.Value = DateTime.Now;
            txtInvoiceNo.Clear();
            txtInvoiceFor.Clear();
            txtNotes.Clear();
            txtpreparedBy.Text = Variables.user_unameValue;
        }

        private void txtNonDeductible_Leave(object sender, EventArgs e)
        {
            functions.ConvertToDecimal(txtNonDeductible);
        }

        private void txtNonDeductible_Click(object sender, EventArgs e)
        {
            txtNonDeductible.SelectAll();
            txtNonDeductible.Focus();
        }
    }
}
