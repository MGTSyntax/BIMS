using Invoicing_System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoicing_System.Views.InterestList
{
    public partial class PayAmountDetails : Form
    {
        private frmPayments _frmPayments;
        Functions functions = new Functions();
        Variables var = new Variables();
        Validations val = new Validations();
        public string InterestNo { get; set; }
        public decimal InvBal { get; set; }
        public decimal InterestAmt { get; set; }
        public decimal totalInvBal { get; set; }

        public PayAmountDetails(frmPayments frmPayments)
        {
            InitializeComponent();
            _frmPayments = frmPayments;
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void PayAmountDetails_Load(object sender, EventArgs e)
        {
            PopulateControlsToUpdate();
            Reset();
        }

        private void Reset()
        {
            txtBalancePay.Text = "0.00";
            txtARN.Clear();
            txtORN.Clear();
            txtCheckN.Clear();
            dtpPaymentDate.Value = DateTime.Now;
        }

        private void PopulateControlsToUpdate()
        {
            string qryInterestDetails = "SELECT a.invoiceNum,a.customerID,b.custName " +
                "FROM interest_monitoring a LEFT JOIN customerstable b ON a.customerID = b.custID " +
                "WHERE interestID = '" + InterestNo.ToString() + "'";
            var dtqryInterestDetails = functions.SelectData(qryInterestDetails, "qryInterestDetails");
            if (dtqryInterestDetails.Rows.Count > 0)
            {
                foreach (DataRow dr in dtqryInterestDetails.Rows)
                {
                    txtInvoiceNum.Text = dr[0].ToString();
                    txtCustID.Text = dr[1].ToString();
                    txtCustomer.Text = dr[2].ToString();
                }
            }
            txtBalance.Text = InvBal.ToString("N2");
            txtInterest.Text = InterestAmt.ToString("N2");
            txttotalBal.Text = totalInvBal.ToString("N2");
        } // End of PopulateControlsToUpdate

        private void btnPay_Click(object sender, EventArgs e)
        {
            bool isStringValid = val.FormStringValidation(GetControlsToValidateString(), errPPayAmt);
            bool isNumbersValid = val.isNumeric(GetControlsToValidateNumbers(), errPPayAmt);
            if (isStringValid && isNumbersValid)
            {
                string addPayment = "INSERT INTO tblpayment(p_invoiceNum,p_invoiceBalPay,p_datePaid,p_customer,p_orNum," +
                    "p_arNum,p_bank,p_checkNum) VALUES('" + txtInvoiceNum.Text + "','" + txtBalancePay.Text.Replace(",", "") + "'," +
                    "'" + dtpPaymentDate.Value.ToString("yyyy-MM-dd") + "','" + txtCustID.Text + "'," +
                    "'" + txtORN.Text + "','" + txtARN.Text + "','" + txtBank.Text + "','" + txtCheckN.Text + "')";
                functions.SaveData(addPayment);
                MessageBox.Show("Payment for Invoice no. " + txtInvoiceNum.Text + " successfully made!", var._title, MessageBoxButtons.OK, MessageBoxIcon.Information);

                _frmPayments.PopInterestDGV();
                _frmPayments.PopulateInterest();

                // Save history for logs
                functions.SaveData("CALL SP_history('" + Variables.user_unameValue + "','tblpayment_h'," +
                    "'tblpayment','p_id',(SELECT MAX(p_id) FROM tblpayment))");

                this.Dispose();
            }
        }

        // Get Controls to Validate String Value
        private IEnumerable<Control> GetControlsToValidateString()
        {
            yield return txtARN;
            yield return txtORN;
            yield return txtCheckN;
        } // End of GetControlsToValidateString

        // Get Controls to Validate Numeric Value
        private IEnumerable<Control> GetControlsToValidateNumbers()
        {
            yield return txtBalancePay;

        } // End of GetControlsToValidateNumbers

        private void txtBalancePay_Leave(object sender, EventArgs e)
        {
            bool isValid = val.isNumeric(GetControlsToValidateNumbers(), errPPayAmt);
            if (!isValid)
            {
                txtBalancePay.SelectAll();
                txtBalancePay.Focus();
            }
            else
            {
                functions.ConvertToDecimal(txtBalancePay);
            }
        }

        private void txtBalancePay_Click(object sender, EventArgs e)
        {
            txtBalancePay.SelectAll();
            txtBalancePay.Focus();
        }

    }
}
