using Invoicing_System.Data;
using System.ComponentModel;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

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
        private double zeroout = 0.00;

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
                    string createInvoice = @"
                        INSERT INTO invoice_monitoring(reimbursement, agencyFee, vat, otherBillable, customerID, 
                            titleTemplate, billingPeriod_from, billingPeriod_to, invoiceNumber, 
                            notes, compID, nonDeductible, preparedBy, 
                            isVoid, printStatus, isPaid, discount
                        ) VALUES (
                            @reimbursement, @agencyFee, @vat, @otherBillable, @customerID, 
                            @titleTemplate, @billingPeriod_from, @billingPeriod_to, @invoiceNumber, 
                            @notes, @compID, @nonDeductible, @preparedBy, 
                            0, 0, 0, @discount
                        );
                    ";

                    var parameters = new Dictionary<string, object>
                    {
                        {"@reimbursement", txtBillableType.Text.Replace(",", "") },
                        {"@agencyFee", txtAgencyFee.Text.Replace(",", "") },
                        {"@vat", txtVAT.Text.Replace(",", "") },
                        {"@otherBillable", txtOtherBillables.Text.Replace(",", "") },
                        {"@customerID", txtDetID.Text },
                        {"@titleTemplate", txtInvoiceFor.Text },
                        {"@billingPeriod_from", bpFrom.Value.ToString("yyyy-MM-dd") },
                        {"@billingPeriod_to", bpTo.Value.ToString("yyyy-MM-dd") },
                        {"@invoiceNumber", txtInvoiceNo.Text },
                        {"@notes", txtNotes.Text },
                        {"@compID", txtcompID.Text },
                        {"@nonDeductible", txtNonDeductible.Text.Replace(",", "") },
                        {"@preparedBy", txtpreparedBy.Text },
                        {"@discount", txtDiscount.Text.Replace(",", "") }
                    };

                    functions.ParamSaveData(createInvoice, parameters);
                    IncrementInvoiceSeries(txtcompID.Text);

                    frmInvoices.PopulateInvoices();
                    frmInvoices.PopTotals();
                    MessageBox.Show("Invoice Successfully Saved!", var._title, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Save history for logs
                    logEvent("invoice_monitoring_h", "invoice_monitoring", "invoicesid");

                    this.Dispose();

                }
            }
            else if (FormCode == "UPD")
            {
                if (isStringValid && isNumbersValid && isDateRangeValid && isInvNumNotExists())
                {
                    string updateInvoice = @"UPDATE invoice_monitoring SET
                        reimbursement = @reimbursement, agencyFee = @agencyFee, vat = @vat, 
                        otherBillable = @otherBillable, customerID = @customerID, titleTemplate = @titleTemplate, 
                        billingPeriod_from = @billingPeriod_from, billingPeriod_to = @billingPeriod_to, 
                        invoiceNumber = @invoiceNumber, notes = @notes, nonDeductible = @nonDeductible,
                        preparedBy = @preparedBy WHERE invoicesid = @invoicesid
                    ";

                    var parameters = new Dictionary<string, object>
                    {
                        { "@reimbursement", txtBillableType.Text.Replace(",", "") },
                        { "@agencyFee", txtAgencyFee.Text.Replace(",", "") },
                        { "@vat", txtVAT.Text.Replace(",", "") },
                        { "@otherBillable", txtOtherBillables.Text.Replace(",", "") },
                        { "@customerID", txtDetID.Text },
                        { "@titleTemplate", txtInvoiceFor.Text },
                        { "@billingPeriod_from", bpFrom.Value.ToString("yyyy-MM-dd") },
                        { "@billingPeriod_to", bpTo.Value.ToString("yyyy-MM-dd") },
                        { "@invoiceNumber", txtInvoiceNo.Text },
                        { "@notes", txtNotes.Text },
                        { "@nonDeductible", txtNonDeductible.Text.Replace(",", "") },
                        { "@preparedBy", txtpreparedBy.Text },
                        { "@invoicesid", InvID }
                    };

                    functions.ParamSaveData(updateInvoice, parameters);

                    frmInvoices.PopulateInvoices();
                    frmInvoices.PopTotals();
                    MessageBox.Show("Invoice Successfully Updated!", var._title, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Save history for logs
                    logEvent("invoice_monitoring_h", "invoice_monitoring", "invoicesid");

                    this.Dispose();
                }
            }
        }

        // Lock Increment Invoice Series
        public void IncrementInvoiceSeries(string compID)
        {
            string updateQuery = @"
                UPDATE tblcompanies
                SET invNumSeries  = invNumSeries + 1
                WHERE companyID = @compID
            ";

            var parameters = new Dictionary<string, object>
            {
                { "@compID", compID }
            };

            functions.ParamSaveData(updateQuery, parameters);
        }

        // Check for Exisiting Invoice Number
        public bool isInvNumNotExists()
        {
            string query = @"
                SELECT COUNT(*)
                FROM invoice_monitoring
                WHERE invoicesid <> @invoicesid
                    AND invoiceNumber = @invoiceNumber 
                    AND isVoid = 0
            ";

            var parameters = new Dictionary<string, object>
            {
                { "@invoicesid", InvID },
                { "@invoiceNumber", txtInvoiceNo.Text.Trim() }
            };

            DataTable dt = functions.ParamSelectData(query, "checkInvoice", parameters);

            int count = Convert.ToInt32(dt.Rows[0][0]);
            if (count > 0)
            {
                errorProvider.SetError(txtInvoiceNo, "This Invoice No. exists!");
                return false;
            }

            errorProvider.SetError(txtInvoiceNo, null);
            return true;
        }

        // Logging Method
        public void logEvent(string historyTable, string queryTable, string queryTableId)
        {
            // Save history for logs
            string logQuery = $@"
                CALL SP_history(@username, 
                    `{historyTable}`, 
                    `{queryTable}`, 
                    `{queryTableId}`, 
                    (SELECT MAX(`{queryTableId}`) FROM `{queryTable}`)
                );
            ";

            var parameters = new Dictionary<string, object>
            {
                { "@username", Variables.user_unameValue }
            };

            functions.ParamSaveData(logQuery, parameters);
        }

        // Get Controls to Validate String Value
        private IEnumerable<Control> GetControlsToValidateString()
        {
            yield return cmbDetachment;

        }

        // Get Controls to Validate Numeric Value
        private IEnumerable<Control> GetControlsToValidateNumbers()
        {
            yield return txtBillableType;
            yield return txtNonDeductible;
            yield return txtOtherBillables;
            yield return txtDiscount;
        }

        private void InvoiceDetails_Load(object sender, EventArgs e)
        {
            if (FormCode == "UPD")
            {
                functions.PopulateMIBCompanies(cbComp, txtcompID, txtInvoiceNo, isUpdateMode: true);

                var headerQuery = "SELECT compID, customerID FROM invoice_monitoring WHERE invoicesid = @InvID";
                var parameters = new Dictionary<string, object> { { "@InvID", InvID } };
                DataTable headerDt = functions.ParamSelectData(headerQuery, "invoiceHeader", parameters);

                if (headerDt.Rows.Count > 0)
                {
                    txtcompID.Text = headerDt.Rows[0]["compID"].ToString();
                    cbComp.SelectedValue = txtcompID.Text.ToLower();

                    PopulateDetachment();

                    txtDetID.Text = headerDt.Rows[0]["customerID"].ToString();
                    cmbDetachment.SelectedValue = txtDetID.Text;
                }

                PopulateControlsToUpdate();
            }
            else
            {
                functions.PopulateMIBCompanies(cbComp, txtcompID, txtInvoiceNo);
                Reset();
            }
        }

        private void cbComp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbComp.SelectedValue != null)
            {
                txtcompID.Text = cbComp.SelectedValue.ToString().ToLower();
            }
        }

        private void cmbDetachment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDetachment.SelectedValue != null)
            {
                txtDetID.Text = cmbDetachment.SelectedValue.ToString();
            }

            if (txtDetID.Text == "0")
            {
                Reset();
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void txtcompID_TextChanged(object sender, EventArgs e)
        {
            //cbComp.SelectedValue = txtcompID.Text;
            if (!string.IsNullOrEmpty(txtcompID.Text))
            {
                PopulateDetachment();
            }
        }

        // Populate Detachment
        private void PopulateDetachment()
        {
            string Detquery = "SELECT custID, custName FROM customerstable WHERE isDeleted=0 " +
                "AND compID IN (" + Variables.User_CompAccess + ") AND compID = '" + txtcompID.Text + "' ORDER by custName";
            string DetdisplayMember = "custName";
            string DetvalueMember = "custID";

            functions.PopulateComboboxFromDb(cmbDetachment, Detquery, DetdisplayMember, DetvalueMember, "Select an option", "0");

            //txtDetID.Text = cmbDetachment.SelectedValue.ToString();
        }

        private void PopulateControlsToUpdate()
        {
            string query = @"SELECT a.reimbursement, a.agencyFee, a.vat, a.otherBillable, b.custName, a.titleTemplate,
                        a.billingPeriod_from, a.billingPeriod_to, a.invoiceNumber, a.notes, a.nonDeductible,
                        preparedBy, a.discount, a.compID, a.customerID
                    FROM invoice_monitoring a
                    INNER JOIN customerstable b ON a.customerID = b.custID
                    INNER JOIN tblcompanies c ON a.compID = c.companyID
                    WHERE invoicesid = @InvID";

            var parameters = new Dictionary<string, object> { { "@InvID", InvID } };
            var.dt = functions.ParamSelectData(query, "invoice_monitoring", parameters);

            if (var.dt.Rows.Count > 0)
            {
                DataRow dr = var.dt.Rows[0];

                txtBillableType.Text = dr[0].ToString();
                functions.ConvertToDecimal(txtBillableType);

                txtAgencyFee.Text = dr[1].ToString();
                functions.ConvertToDecimal(txtAgencyFee);

                txtVAT.Text = dr[2].ToString();
                functions.ConvertToDecimal(txtVAT);

                txtOtherBillables.Text = dr[3].ToString();
                functions.ConvertToDecimal(txtOtherBillables);

                // Don't set cmbDetachment.Text here — already handled in Load event

                txtInvoiceFor.Text = dr[5].ToString();
                bpFrom.Value = (DateTime)dr[6];
                bpTo.Value = (DateTime)dr[7];
                txtInvoiceNo.Text = dr[8].ToString();
                txtNotes.Text = dr[9].ToString();

                txtNonDeductible.Text = dr[10].ToString();
                functions.ConvertToDecimal(txtNonDeductible);

                txtpreparedBy.Text = dr[11].ToString();
                txtDiscount.Text = dr[12].ToString();
                functions.ConvertToDecimal(txtDiscount);

                // Calculate display fields
                CalculateTotal();

                // Invoice number lock check
                string qryinvoiceNum = "SELECT * FROM interest_monitoring WHERE invoiceNum = @InvoiceNo";
                var checkParams = new Dictionary<string, object> { { "@InvoiceNo", txtInvoiceNo.Text } };
                var dtqryinvoiceNum = functions.ParamSelectData(qryinvoiceNum, "qryinvoiceNum", checkParams);
                if (dtqryinvoiceNum.Rows.Count > 0)
                {
                    txtInvoiceNo.ReadOnly = true;
                }
            }
        }


        //private void PopulateControlsToUpdate()
        //{
        //    string query = "SELECT a.reimbursement, a.agencyFee, a.vat, a.otherBillable, b.custName, a.titleTemplate, " +
        //        "a.billingPeriod_from, a.billingPeriod_to, a.invoiceNumber, a.notes, a.nonDeductible, preparedBy, a.discount, " +
        //        "a.compID, a.customerID FROM invoice_monitoring a INNER JOIN customerstable b ON a.customerID = b.custID " +
        //        "INNER JOIN tblcompanies c ON a.compID = c.companyID WHERE invoicesid = '" + InvID.ToString() + "'";
        //    // c.companyName, 
        //    var.dt = functions.SelectData(query, "invoice_monitoring");
        //    if (var.dt.Rows.Count > 0)
        //    {
        //        foreach (DataRow dr in var.dt.Rows)
        //        {
        //            txtBillableType.Text = dr[0].ToString();
        //            functions.ConvertToDecimal(txtBillableType);

        //            txtAgencyFee.Text = dr[1].ToString();
        //            functions.ConvertToDecimal(txtAgencyFee);

        //            txtVAT.Text = dr[2].ToString();
        //            functions.ConvertToDecimal(txtVAT);

        //            txtOtherBillables.Text = dr[3].ToString();
        //            functions.ConvertToDecimal(txtOtherBillables);

        //            cmbDetachment.Text = dr[4].ToString();

        //            txtInvoiceFor.Text = dr[5].ToString();

        //            bpFrom.Value = (DateTime)dr[6];

        //            bpTo.Value = (DateTime)dr[7];

        //            txtInvoiceNo.Text = dr[8].ToString();

        //            txtNotes.Text = dr[9].ToString();

        //            txtNonDeductible.Text = dr[10].ToString();
        //            functions.ConvertToDecimal(txtNonDeductible);

        //            txtpreparedBy.Text = dr[11].ToString();

        //            txtDiscount.Text = dr[12].ToString();
        //            functions.ConvertToDecimal(txtDiscount);

        //            txtcompID.Text = dr[13].ToString();
        //            cbComp.SelectedValue = txtcompID.Text;

        //            txtDetID.Text = dr[14].ToString();

        //            // Calculate and Display the total sales
        //            decimal totalSales = Convert.ToDecimal(txtAgencyFee.Text) + Convert.ToDecimal(txtVAT.Text);
        //            txttsVATin.Text = totalSales.ToString("N");

        //            // Display less: VAT
        //            txtlessVAT.Text = (-Math.Abs(Convert.ToDecimal(txtVAT.Text))).ToString("N");

        //            // Display net of VAT
        //            txtnetofVAT.Text = Convert.ToDecimal(txtAgencyFee.Text).ToString("N");

        //            // Fetch, calculate and display less: Withholding Tax
        //            string qrywTaxRate = functions.GetRecordString("SELECT wtax_rate FROM tblwtax");
        //            decimal wTaxRate = Convert.ToDecimal(qrywTaxRate);
        //            decimal wTax = Convert.ToDecimal(txtAgencyFee.Text) * wTaxRate;
        //            txtlessWTax.Text = (-Math.Abs(wTax)).ToString("N");

        //            // Calculate and display amount due
        //            decimal amtDue = Convert.ToDecimal(txtAgencyFee.Text) - wTax;
        //            txtamtDue.Text = amtDue.ToString("N");

        //            // Display add: 12% VAT
        //            txtaddVAT.Text = Convert.ToDecimal(txtVAT.Text).ToString("N");

        //            // Calculate and display total amount due
        //            decimal totalAmtDue = amtDue + Convert.ToDecimal(txtVAT.Text);
        //            txttotalamtDue.Text = totalAmtDue.ToString("N");

        //            // Calculate and display grand total
        //            decimal grandTotal = Convert.ToDecimal(txtTotal.Text) - wTax;
        //            txtgrandTotal.Text = grandTotal.ToString("N");
        //        }

        //        string qryinvoiceNum = "SELECT * FROM interest_monitoring WHERE invoiceNum = '" + txtInvoiceNo.Text + "'";
        //        var dtqryinvoiceNum = functions.SelectData(qryinvoiceNum, "qryinvoiceNum");
        //        if (dtqryinvoiceNum.Rows.Count > 0)
        //        {
        //            txtInvoiceNo.ReadOnly = true;
        //        }
        //    }
        //}

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
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

        private void Reset()
        {
            txtBillableType.Text = zeroout.ToString("F2");
            txtNonDeductible.Text = zeroout.ToString("F2");
            txtAgencyFee.Text = zeroout.ToString("F2");
            txtVAT.Text = zeroout.ToString("F2");
            txtOtherBillables.Text = zeroout.ToString("F2");
            txtDiscount.Text = zeroout.ToString("F2");
            bpFrom.Value = DateTime.Now;
            bpTo.Value = DateTime.Now;
            txtInvoiceNo.Clear();
            txtInvoiceFor.Clear();
            txtNotes.Clear();
            txtpreparedBy.Text = Variables.user_unameValue;
        }

        private void txtBillableType_Click(object sender, EventArgs e)
        {
            txtBillableType.SelectAll();
            txtBillableType.Focus();
            if (cmbDetachment.Text == "Select an option")
            {
                errorProvider.SetError(cmbDetachment, "Please select detachment.");
                Reset();
            }
        }

        private void txtBillableType_Leave(object sender, EventArgs e)
        {
            bool isValid = val.isNumeric(GetControlsToValidateNumbers(), errorProvider);
            if (!isValid)
            {
                txtBillableType.SelectAll();
                txtBillableType.Focus();
                txtAgencyFee.Text = zeroout.ToString();
                txtVAT.Text = zeroout.ToString();
                txtTotal.Text = zeroout.ToString();
                txtDiscount.Text = zeroout.ToString();
            }
            else
            {
                functions.ConvertToDecimal(txtBillableType);
            }
        }

        private void txtBillableType_TextChanged(object sender, EventArgs e)
        {
            bool isValid = val.isNumeric(GetControlsToValidateNumbers(), errorProvider);

            if (!isValid)
            {
                txtBillableType.SelectAll();
                txtBillableType.Focus();
                txtAgencyFee.Text = zeroout.ToString();
                txtVAT.Text = zeroout.ToString();
                txtTotal.Text = zeroout.ToString();
                txtDiscount.Text = zeroout.ToString();
            }
            else
            {
                CalculateTotal();
            }
        }

        private void txtNonDeductible_Click(object sender, EventArgs e)
        {
            txtNonDeductible.SelectAll();
            txtNonDeductible.Focus();
        }

        private void txtNonDeductible_Leave(object sender, EventArgs e)
        {
            bool isValid = val.isNumeric(GetControlsToValidateNumbers(), errorProvider);
            if (!isValid)
            {
                txtNonDeductible.SelectAll();
                txtNonDeductible.Focus();
            }
            else
            {
                functions.ConvertToDecimal(txtNonDeductible);
            }
        }

        private void txtNonDeductible_TextChanged(object sender, EventArgs e)
        {
            bool isValid = val.isNumeric(GetControlsToValidateNumbers(), errorProvider);
            if (!isValid)
            {
                txtNonDeductible.SelectAll();
                txtNonDeductible.Focus();
            }
            else
            {
                CalculateTotal();
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
            else
            {
                functions.ConvertToDecimal(txtOtherBillables);
            }
        }

        private void txtOtherBillables_Click(object sender, EventArgs e)
        {
            txtOtherBillables.SelectAll();
            txtOtherBillables.Focus();
        }

        private void txtOtherBillables_TextChanged(object sender, EventArgs e)
        {
            bool isValid = val.isNumeric(GetControlsToValidateNumbers(), errorProvider);
            if (!isValid)
            {
                txtOtherBillables.SelectAll();
                txtOtherBillables.Focus();
            }
            else
            {
                CalculateTotal();
            }
        }

        private void txtDiscount_Click(object sender, EventArgs e)
        {
            txtDiscount.SelectAll();
            txtDiscount.Focus();
        }

        private void txtDiscount_Leave(object sender, EventArgs e)
        {
            bool isValid = val.isNumeric(GetControlsToValidateNumbers(), errorProvider);
            if (!isValid)
            {
                txtDiscount.SelectAll();
                txtDiscount.Focus();
            }
            else
            {
                functions.ConvertToDecimal(txtDiscount);

                if (decimal.TryParse(txtDiscount.Text, out var value))
                {
                    txtDiscount.Text = (-Math.Abs(value)).ToString();
                }
            }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            bool isValid = val.isNumeric(GetControlsToValidateNumbers(), errorProvider);
            if (!isValid)
            {
                txtDiscount.SelectAll();
                txtDiscount.Focus();
            }
            else
            {
                CalculateTotal();
            }
        }

        private void CalculateTotal()
        {
            decimal reimbursement = TryParseDecimal(txtBillableType.Text);
            decimal otherbillable = TryParseDecimal(txtOtherBillables.Text);
            decimal discount = TryParseDecimal(txtDiscount.Text);

            decimal vatAmount = 0;
            decimal agencyFee = 0;

            decimal TryParseDecimal(string input)
            {
                return decimal.TryParse(input, out decimal result) ? result : 0;
            }

            // Fetch agency fee rate from database
            string qryAFrate = functions.GetRecordString("SELECT custagencyFee FROM customerstable WHERE custID = '" + txtDetID.Text + "'");
            if (!string.IsNullOrWhiteSpace(qryAFrate) && decimal.TryParse(qryAFrate, out decimal parsedAgencyFeeRate))
            {
                // Calculate and Display agency fee
                agencyFee = reimbursement * parsedAgencyFeeRate;
                txtAgencyFee.Text = agencyFee.ToString("N");
            }

            if (_vatactive == "1")
            {
                // Fetch vat rate from database
                string qryVATrate = functions.GetRecordString("SELECT vat_rate FROM tblvat");
                decimal vatrate = Convert.ToDecimal(qryVATrate);

                // Calculate VAT
                vatAmount = agencyFee * vatrate;
            }

            // Display VAT
            txtVAT.Text = vatAmount.ToString("N");

            // Calculate and Display total ((Reimbursement + VAT + Agency Fee + Other Billable) - Discount)
            decimal total = reimbursement + vatAmount + agencyFee + otherbillable + discount;
            txtTotal.Text = total.ToString("N");

            // Calculate and Display the total sales
            decimal totalSales = agencyFee + vatAmount;
            txttsVATin.Text = totalSales.ToString("N");

            // Display less: VAT
            txtlessVAT.Text = (-Math.Abs(vatAmount)).ToString("N");

            // Display net of VAT
            txtnetofVAT.Text = agencyFee.ToString("N");

            // Fetch, calculate and display less: Withholding Tax
            string qrywTaxRate = functions.GetRecordString("SELECT wtax_rate FROM tblwtax");
            decimal wTaxRate = Convert.ToDecimal(qrywTaxRate);
            decimal wTax = agencyFee * wTaxRate;
            txtlessWTax.Text = (-Math.Abs(wTax)).ToString("N");

            // Calculate and display amount due
            decimal amtDue = agencyFee - wTax;
            txtamtDue.Text = amtDue.ToString("N");

            // Display add: 12% VAT
            txtaddVAT.Text = vatAmount.ToString("N");

            // Calculate and display total amount due
            decimal totalAmtDue = amtDue + vatAmount;
            txttotalamtDue.Text = totalAmtDue.ToString("N");

            // Calculate and display grand total
            decimal grandTotal = total - wTax;
            txtgrandTotal.Text = grandTotal.ToString("N");
        }

    }
}
