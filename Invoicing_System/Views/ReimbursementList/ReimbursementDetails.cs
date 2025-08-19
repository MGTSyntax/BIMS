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

namespace Invoicing_System.Views.ReimbursementList
{
    public partial class ReimbursementDetails : Form
    {
        public string FormCode { get; set; }
        public int reimbursementID { get; set; }
        public string customerName { get; set; }
        public int invoiceNumber { get; set; }
        public DateTime periodFrom { get; set; }
        public DateTime periodTo { get; set; }
        public string company { get; set; }
        public double reimbursementAmount { get; set; }
        public double totalPayroll { get; set; }
        public double thirteenthMP { get; set; }
        public double sil { get; set; }
        public double uniformAllow { get; set; }
        public double totalManda { get; set; }
        public double retirement { get; set; }
        public double insurance { get; set; }
        public double radioFirearms { get; set; }
        private frmInvoices frmInvoices;
        private frmReimbursements frmReimbursements;
        Validations val = new Validations();
        Functions functions = new Functions();
        Variables var = new Variables();
        const double zeroout = 0.00;

        public ReimbursementDetails(frmReimbursements frmReimbursements)
        {
            InitializeComponent();
            this.frmReimbursements = frmReimbursements;
        }

        public ReimbursementDetails(frmInvoices frmInvoices)
        {
            InitializeComponent();
            this.frmInvoices = frmInvoices;
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ReimbursementDetails_Load(object sender, EventArgs e)
        {
            if (FormCode == "UPD")
            {
                populateInvoiceDetails();
                populateReimbursementDetails();
                calculateTotal();
            }
            else
            {
                populateInvoiceDetails();
                Reset();
            }

        }

        // Invoice Details
        private void populateInvoiceDetails()
        {
            txtcompany.Text = company;
            txtinvoicenumber.Text = invoiceNumber.ToString();
            txtcustomer.Text = customerName;
            txtperiodfrom.Text = periodFrom.ToString("d");
            txtperiodto.Text = periodTo.ToString("d");
            txttotalreimbursement.Text = reimbursementAmount.ToString("N2");
        }

        // Reimbursement Break Down
        private void populateReimbursementDetails()
        {
            txttotalpayroll.Text = totalPayroll.ToString("N2");
            txt13thmp.Text = thirteenthMP.ToString("N2");
            txtsil.Text = sil.ToString("N2");
            txtuniformallow.Text = uniformAllow.ToString("N2");
            txttotalmanda.Text = totalManda.ToString("N2");
            txtretirement.Text = retirement.ToString("N2");
            txtinsurance.Text = insurance.ToString("N2");
            txtradionfirearms.Text = radioFirearms.ToString("N2");
        }

        // Reset Textboxes
        private void Reset()
        {
            foreach (var txt in new[] { txttotalpayroll, txt13thmp, txtsil, 
                txtuniformallow, txttotalmanda, txtretirement, txtinsurance, txtradionfirearms })
            {
                txt.Text = zeroout.ToString("F2");
            }
        }

        private IEnumerable<Control> GetControlsToValidateNumbers()
        {
            yield return txttotalpayroll;
            yield return txt13thmp;
            yield return txtsil;
            yield return txtuniformallow;
            yield return txttotalmanda;
            yield return txtretirement;
            yield return txtinsurance;
            yield return txtradionfirearms;
        }

        private void txttotalpayroll_TextChanged(object sender, EventArgs e)
        {
            bool isValid = val.ValidateNumeric(sender as TextBox, errorProvider);
            if (isValid) calculateTotal();
        }

        private void txttotalpayroll_Leave(object sender, EventArgs e)
        {
            bool isValid = val.ValidateNumeric(sender as TextBox, errorProvider);
            if (isValid) functions.ConvertToDecimal(txttotalpayroll);
        }

        private void txt13thmp_TextChanged(object sender, EventArgs e)
        {
            bool isValid = val.ValidateNumeric(sender as TextBox, errorProvider);
            if (isValid) calculateTotal();
        }

        private void txt13thmp_Leave(object sender, EventArgs e)
        {
            bool isValid = val.ValidateNumeric(sender as TextBox, errorProvider);
            if (isValid) functions.ConvertToDecimal(txt13thmp);
        }

        private void txtsil_TextChanged(object sender, EventArgs e)
        {
            bool isValid = val.ValidateNumeric(sender as TextBox, errorProvider);
            if (isValid) calculateTotal();
        }

        private void txtsil_Leave(object sender, EventArgs e)
        {
            bool isValid = val.ValidateNumeric(sender as TextBox, errorProvider);
            if (isValid) functions.ConvertToDecimal(txtsil);
        }

        private void txtuniformallow_TextChanged(object sender, EventArgs e)
        {
            bool isValid = val.ValidateNumeric(sender as TextBox, errorProvider);
            if (isValid) calculateTotal();
        }

        private void txtuniformallow_Leave(object sender, EventArgs e)
        {
            bool isValid = val.ValidateNumeric(sender as TextBox, errorProvider);
            if (isValid) functions.ConvertToDecimal(txtuniformallow);
        }

        private void txttotalmanda_TextChanged(object sender, EventArgs e)
        {
            bool isValid = val.ValidateNumeric(sender as TextBox, errorProvider);
            if (isValid) calculateTotal();
        }

        private void txttotalmanda_Leave(object sender, EventArgs e)
        {
            bool isValid = val.ValidateNumeric(sender as TextBox, errorProvider);
            if (isValid) functions.ConvertToDecimal(txttotalmanda);
        }

        private void txtretirement_TextChanged(object sender, EventArgs e)
        {
            bool isValid = val.ValidateNumeric(sender as TextBox, errorProvider);
            if (isValid) calculateTotal();
        }

        private void txtretirement_Leave(object sender, EventArgs e)
        {
            bool isValid = val.ValidateNumeric(sender as TextBox, errorProvider);
            if (isValid) functions.ConvertToDecimal(txtretirement);
        }

        private void txtinsurance_TextChanged(object sender, EventArgs e)
        {
            bool isValid = val.ValidateNumeric(sender as TextBox, errorProvider);
            if (isValid) calculateTotal();
        }

        private void txtinsurance_Leave(object sender, EventArgs e)
        {
            bool isValid = val.ValidateNumeric(sender as TextBox, errorProvider);
            if (isValid) functions.ConvertToDecimal(txtinsurance);
        }

        private void txtradionfirearms_TextChanged(object sender, EventArgs e)
        {
            bool isValid = val.ValidateNumeric(sender as TextBox, errorProvider);
            if (isValid) calculateTotal();
        }

        private void txtradionfirearms_Leave(object sender, EventArgs e)
        {
            bool isValid = val.ValidateNumeric(sender as TextBox, errorProvider);
            if (isValid) functions.ConvertToDecimal(txtradionfirearms);
        }

        private void calculateTotal()
        {
            decimal totalPayroll = TryParseDecimal(txttotalpayroll.Text);
            decimal thirteenthMP = TryParseDecimal(txt13thmp.Text);
            decimal sil = TryParseDecimal(txtsil.Text);
            decimal uniformAllowance = TryParseDecimal(txtuniformallow.Text);
            decimal totalManda = TryParseDecimal(txttotalmanda.Text);
            decimal retirement = TryParseDecimal(txtretirement.Text);
            decimal insurance = TryParseDecimal(txtinsurance.Text);
            decimal radioFirearms = TryParseDecimal(txtradionfirearms.Text);

            decimal TryParseDecimal(string input)
            {
                return decimal.TryParse(input, out decimal result) ? result : 0;
            }

            decimal totalBreakDown = (totalPayroll + thirteenthMP + sil + uniformAllowance + totalManda + retirement + insurance + radioFirearms);
            txttotalbreakdown.Text = totalBreakDown.ToString("N");
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (decimal.Parse(txttotalreimbursement.Text) != decimal.Parse(txttotalbreakdown.Text))
            {
                errorProvider.SetError(txttotalbreakdown, "Reimbursement amount is not tally!");
                return;
            }
            else
            {
                errorProvider.SetError(txttotalbreakdown, null);
            }

            if (FormCode == "CRT")
            {
                if (isInvNumNotExists())
                {
                    string query = @"
                        INSERT INTO reimbursement_details(invoice_number, total_payroll, thirteenth_mp, sil, uniform_allowance, 
                            total_mandatories, retirement, insurance, radio_n_firearms
                        ) VALUES (
                            @invoice_number, @total_payroll, @thirteenth_mp, @sil, @uniform_allowance, 
                            @total_mandatories, @retirement, @insurance, @radio_n_firearms
                        );
                    ";

                    var parameters = new Dictionary<string, object>
                    {
                        {"@invoice_number", txtinvoicenumber.Text },
                        {"@total_payroll", txttotalpayroll.Text.Replace(",", "") },
                        {"@thirteenth_mp", txt13thmp.Text.Replace(",", "") },
                        {"@sil", txtsil.Text.Replace(",", "") },
                        {"@uniform_allowance", txtuniformallow.Text.Replace(",", "") },
                        {"@total_mandatories", txttotalmanda.Text.Replace(",", "") },
                        {"@retirement", txtretirement.Text.Replace(",", "") },
                        {"@insurance", txtinsurance.Text.Replace(",", "") },
                        {"@radio_n_firearms", txtradionfirearms.Text.Replace(",", "") }
                    };

                    functions.ParamSaveData(query, parameters);

                    MessageBox.Show("Reimbursement details successfully saved!", var._title, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Save history for logs
                    functions.logEvent("reimbursement_details_h", "reimbursement_details", "id");

                    this.Dispose();
                }
            }
            else if (FormCode == "UPD")
            {
                string query = @"UPDATE reimbursement_details SET
                        total_payroll = @total_payroll, thirteenth_mp = @thirteenth_mp, sil = @sil, 
                        uniform_allowance = @uniform_allowance, total_mandatories = @total_mandatories, 
                        retirement = @retirement, insurance = @insurance, radio_n_firearms = @radio_n_firearms 
                        WHERE invoice_number = @invoice_number
                    ";

                var parameters = new Dictionary<string, object>
                    {
                        { "@total_payroll", txttotalpayroll.Text.Replace(",", "") },
                        { "@thirteenth_mp", txt13thmp.Text.Replace(",", "") },
                        { "@sil", txtsil.Text.Replace(",", "") },
                        { "@uniform_allowance", txtuniformallow.Text.Replace(",", "") },
                        { "@total_mandatories", txttotalmanda.Text.Replace(",", "") },
                        { "@retirement", txtretirement.Text.Replace(",", "") },
                        { "@insurance", txtinsurance.Text.Replace(",", "") },
                        { "@radio_n_firearms", txtradionfirearms.Text.Replace(",", "") },
                        { "@invoice_number", txtinvoicenumber.Text }
                    };

                functions.ParamSaveData(query, parameters);

                if (frmReimbursements != null)
                {
                    frmReimbursements.populateReimbursements();
                }

                MessageBox.Show("Reimbursement details successfully updated!", var._title, MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Save history for logs
                functions.logEvent("reimbursement_details_h", "reimbursement_details", "id", reimbursementID.ToString());

                this.Dispose();
            }
        }

        // Check for Exisiting Invoice Number
        public bool isInvNumNotExists()
        {
            string query = @"
                SELECT COUNT(*)
                FROM reimbursement_details
                WHERE invoice_number = @invoice_number 
            ";

            var parameters = new Dictionary<string, object>
            {
                { "@invoice_number", txtinvoicenumber.Text.Trim() }
            };

            DataTable dt = functions.ParamSelectData(query, "checkInvoice", parameters);

            int count = Convert.ToInt32(dt.Rows[0][0]);
            if (count > 0)
            {
                errorProvider.SetError(txtinvoicenumber, "This Invoice No. exists!");
                return false;
            }

            errorProvider.SetError(txtinvoicenumber, null);
            return true;
        }
    }
}
