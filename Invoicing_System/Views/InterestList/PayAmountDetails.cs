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
            totalInvBal = (InvBal + InterestAmt);
            txttotalBal.Text = totalInvBal.ToString("N2");
        } // End of PopulateControlsToUpdate

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (double.Parse(txtBalancePay.Text) > double.Parse(txtBalance.Text))
            {
                errPPayAmt.SetError(txtBalancePay, "The payment amount should not be greater than the balance amount!");
                return;
            }
            else
            {
                errPPayAmt.SetError(txtBalancePay, null);
            }

            bool isStringValid = val.FormStringValidation(GetControlsToValidateString(), errPPayAmt);
            bool isNumbersValid = val.isNumeric(GetControlsToValidateNumbers(), errPPayAmt);

            if (isStringValid && isNumbersValid)
            {
                string query = @"
                        INSERT INTO 
                            tblpayment(p_invoiceNum, p_invoiceBalPay, p_datePaid, 
                            p_customer, p_orNum, p_arNum, p_bank, p_checkNum
                        ) VALUES (
                            @p_invoiceNum, @p_invoiceBalPay, @p_datePaid, 
                            @p_customer, @p_orNum, @p_arNum, @p_bank, @p_checkNum
                        );
                    ";

                var parameters = new Dictionary<string, object>
                    {
                        {"@p_invoiceNum", txtInvoiceNum.Text },
                        {"@p_invoiceBalPay", txtBalancePay.Text.Replace(",", "") },
                        {"@p_datePaid", dtpPaymentDate.Value.ToString("yyyy-MM-dd") },
                        {"@p_customer", txtCustID.Text },
                        {"@p_orNum", txtORN.Text },
                        {"@p_arNum", txtARN.Text },
                        {"@p_bank", txtBank.Text },
                        {"@p_checkNum", txtCheckN.Text }
                    };

                functions.ParamSaveData(query, parameters);

                MessageBox.Show("Payment for Invoice no. " + txtInvoiceNum.Text + " successfully made!", var._title, MessageBoxButtons.OK, MessageBoxIcon.Information);

                _frmPayments.PopInterestDGV();
                _frmPayments.PopulateInterest();

                // Save history for logs
                functions.logEvent("tblpayment_h", "tblpayment", "p_id");

                this.Dispose();
            }
        }

        // Get Controls to Validate String Value
        private IEnumerable<Control> GetControlsToValidateString()
        {
            yield return txtARN;
            yield return txtORN;
            yield return txtCheckN;
        }

        // Get Controls to Validate Numeric Value
        private IEnumerable<Control> GetControlsToValidateNumbers()
        {
            yield return txtBalancePay;

        }

        private void txtBalancePay_Leave(object sender, EventArgs e)
        {
            bool isValid = val.ValidateNumeric(sender as TextBox, errPPayAmt);
            if (isValid) functions.ConvertToDecimal(txtBalancePay);
        }

        private void txtBalancePay_Click(object sender, EventArgs e)
        {
            txtBalancePay.SelectAll();
            txtBalancePay.Focus();
        }

        private void txtBalancePay_TextChanged(object sender, EventArgs e)
        {
            val.ValidateNumeric(sender as TextBox, errPPayAmt);
        }
    }
}
