using DocumentFormat.OpenXml.Drawing.Charts;
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

namespace Invoicing_System.Views
{
    public partial class frmExporting : Form
    {
        private Functions functions = new Functions();
        private Validations _validations = new Validations();
        private Variables var = new Variables();

        public frmExporting()
        {
            InitializeComponent();
        }

        private void frmExporting_Load(object sender, EventArgs e)
        {
            dtpBPFrom.Value = DateTime.Now;
            dtpBPTo.Value = DateTime.Now;

            _validations.isCheckBoxChecked(chkCompany, cbCompany);
            _validations.isCheckBoxChecked(chkDet, cbDet);
            _validations.isCheckBoxChecked(chkInvNo, txtInvNo);
            _validations.isCheckBoxChecked(chkBP, panel3);
            _validations.isCheckBoxChecked(chkStatus, cbStatus);

            cbreportfile.SelectedIndex = 0;
            cbStatus.SelectedIndex = 0;
            PopCompany();
            PopDet();
        }

        private void chkCompany_CheckedChanged(object sender, EventArgs e)
        {
            _validations.isCheckBoxChecked(chkCompany, cbCompany);
        }

        private void chkDet_CheckedChanged(object sender, EventArgs e)
        {
            _validations.isCheckBoxChecked(chkDet, cbDet);
        }

        private void chkInvNo_CheckedChanged(object sender, EventArgs e)
        {
            _validations.isCheckBoxChecked(chkInvNo, txtInvNo);
        }

        private void chkStatus_CheckedChanged(object sender, EventArgs e)
        {
            _validations.isCheckBoxChecked(chkStatus, cbStatus);
        }

        private void chkBP_CheckedChanged(object sender, EventArgs e)
        {
            _validations.isCheckBoxChecked(chkBP, panel3);
        }

        private void PopCompany()
        {
            cbCompany.Items.Clear();
            string companyStr = "SELECT * FROM tblcompanies WHERE companyID IN (" + Variables.User_CompAccess + ")";
            string companyDM = "companyID";
            string companyVM = "id";
            functions.PopulateComboboxFromDb(cbCompany, companyStr, companyDM, companyVM, "--Select an option--", "0");
        }

        private void PopDet()
        {
            cbDet.Items.Clear();
            string detStr = "SELECT custID, custName FROM customerstable WHERE compID IN (" + Variables.User_CompAccess + ") ORDER BY custName";
            string detDM = "custName";
            string detVM = "custID";
            functions.PopulateComboboxFromDb(cbDet, detStr, detDM, detVM, "--Select an option--", "0");
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btngenerate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!chkCompany.Checked && !chkDet.Checked && !chkInvNo.Checked && !chkBP.Checked && !chkStatus.Checked)
                {
                    MessageBox.Show("No filter to apply.    ", var._title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (cbreportfile.SelectedIndex == 0)
                {
                    MessageBox.Show("Select file to generate.", var._title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    defaults();
                    return;
                }

                if (cbreportfile.Text == "Invoices with Reimbursement Breakdown (.xlsx)")
                {
                    string filter = "";
                    filter = "WHERE a.isVoid = 0 ";
                    if (chkCompany.Checked && cbCompany.SelectedIndex != 0) filter += "AND a.compID = '" + cbCompany.Text + "' ";
                    if (chkDet.Checked && cbDet.SelectedIndex != 0) filter += "AND a.customerID = '" + cbDet.SelectedValue?.ToString() + "' ";
                    if (chkInvNo.Checked && txtInvNo.Text != string.Empty) filter += "AND a.invoiceNumber = '" + txtInvNo.Text + "' ";
                    if (chkBP.Checked) filter += "AND a.billingPeriod_from BETWEEN '" + dtpBPFrom.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpBPTo.Value.ToString("yyyy-MM-dd") + "'  ";
                    if (chkStatus.Checked && !string.IsNullOrEmpty(cbStatus.Text))
                    {
                        if (cbStatus.SelectedIndex == 1) filter += "AND isPaid IN ('0','1') ";
                        else if (cbStatus.SelectedIndex == 2) filter += "AND isPaid = 1 ";
                        else if (cbStatus.SelectedIndex == 3) filter += "AND isPaid = 0 ";
                    }
                    filter += "ORDER BY b.custName";

                    string sheetName = "Reimbursement Details";
                    string query = "SELECT " +
                        "UPPER(a.compID) AS 'Company', " +
                        "a.invoiceNumber AS 'Invoice Number', " +
                        "b.custName AS 'Customer Name', " +
                        "CAST(a.billingPeriod_from AS DATE) AS 'Billing Period From', " +
                        "CAST(a.billingPeriod_to AS DATE) AS 'Billing Period To', " +
                        "Round(a.reimbursement,2) AS 'Reimbursement', " +
                        "Round(a.nonDeductible,2) AS 'Additional Reimbursement', " +
                        "Round(a.agencyFee,2) AS 'Agency Fee', " +
                        "Round(a.vat,2) AS 'VAT', " +
                        "Round(a.otherBillable,2) AS 'Other Billable', " +
                        "Round(a.discount,2) AS 'Less Discount', " +
                        "Round((a.reimbursement + a.nonDeductible + a.agencyFee + a.vat + a.otherBillable),2) AS 'Total Amount', " +
                        "Round((a.agencyFee * wt.wtax_rate),2) AS 'Withholding Tax', " +
                        "Round((a.reimbursement + a.nonDeductible + a.agencyFee + a.vat + a.otherBillable + a.discount) - (a.agencyFee * wt.wtax_rate),2) AS 'Grand Total Amount', " +
                        "If(a.isPaid = '1', 'Paid', 'Unpaid') AS 'Payment Status', " +
                        "Round(rd.total_payroll,2) AS 'Total Payroll', " +
                        "Round(rd.thirteenth_mp,2) AS '13th Month', " +
                        "Round(rd.sil,2) AS '5 Days SIL', " +
                        "Round(rd.uniform_allowance,2) AS 'Uniform Allowance', " +
                        "Round(rd.total_mandatories,2) AS 'Total Mandatories', " +
                        "Round(rd.retirement,2) AS 'Retirement', " +
                        "Round(rd.insurance,2) AS 'Insurance', " +
                        "Round(rd.radio_n_firearms,2) AS 'Radio And Firearms' " +
                        "FROM invoice_monitoring a " +
                        "LEFT JOIN customerstable b ON a.customerID = b.custID " +
                        "LEFT JOIN (SELECT wtax_rate FROM tblwtax WHERE wtaxID = '1') wt ON 1 = 1 " +
                        "INNER JOIN reimbursement_details rd ON a.invoiceNumber = rd.invoice_number " +
                        "" + filter + "";
                    functions.createExcelReport(query, sheetName);
                }
                else if (cbreportfile.Text == "QuickBooks Invoice Template (.iif)")
                {
                    string filter = "";
                    filter = "WHERE a.isVoid = 0 ";
                    if (chkCompany.Checked && cbCompany.SelectedIndex != 0) filter += "AND a.compID = '" + cbCompany.Text + "' ";
                    if (chkDet.Checked && cbDet.SelectedIndex != 0) filter += "AND a.customerID = '" + cbDet.SelectedValue?.ToString() + "' ";
                    if (chkInvNo.Checked && txtInvNo.Text != string.Empty) filter += "AND a.invoiceNumber = '" + txtInvNo.Text + "' ";
                    if (chkBP.Checked) filter += "AND a.billingPeriod_from BETWEEN '" + dtpBPFrom.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpBPTo.Value.ToString("yyyy-MM-dd") + "' ";
                    if (chkStatus.Checked && !string.IsNullOrEmpty(cbStatus.Text))
                    {
                        if (cbStatus.SelectedIndex == 1) filter += "AND isPaid IN ('0','1') ";
                        else if (cbStatus.SelectedIndex == 2) filter += "AND isPaid = 1 ";
                        else if (cbStatus.SelectedIndex == 3) filter += "AND isPaid = 0 ";
                    }

                    string query = "SELECT " +
                    "a.invoiceNumber, " +
                    "b.custName, " +
                    "b.clientName, " +
                    "a.billingPeriod_from, " +
                    "a.billingPeriod_to, " +
                    "a.reimbursement, " +
                    "a.agencyFee, " +
                    "a.otherBillable, " +
                    "(a.reimbursement+a.nonDeductible+a.agencyFee+a.vat+a.otherBillable) as totalamt, " +
                    "ROUND(a.agencyFee * wt.wtax_rate) as wht, " +
                    "ROUND((a.reimbursement + a.nonDeductible + a.agencyFee + a.vat + a.otherBillable + a.discount) - (a.agencyFee * wt.wtax_rate),2) as grandtotal, " +
                    "IF(a.isPaid='1','Y','N') as isPaid, " +
                    "c.dueDate, " +
                    "c.shippingDate " +
                    "FROM invoice_monitoring a " +
                    "LEFT JOIN customerstable b ON a.customerID = b.custID " +
                    "INNER JOIN interest_monitoring c ON a.invoiceNumber = c.invoiceNum " +
                    "LEFT JOIN (SELECT wtax_rate FROM tblwtax WHERE wtaxID = '1') wt ON 1 = 1 " +
                    "" + filter + "";
                    functions.createIIFReport(query);
                }
            }
            catch (Exception ex)
            {
                functions.LogErrorToDb(ex, "frmExporting", "btngenerate_Click");
                MessageBox.Show("An unexpected error occurred. The error has been logged. Please contact your administrator.");
            }
        }

        private void cbCompany_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbDet_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbreportfile_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void defaults()
        {
            chkCompany.Checked = false;
            cbCompany.SelectedIndex = 0;
            chkDet.Checked = false;
            cbDet.SelectedIndex = 0;
            chkInvNo.Checked = false;
            txtInvNo.Clear();
            chkBP.Checked = false;
            dtpBPFrom.Value = DateTime.Now;
            dtpBPTo.Value = DateTime.Now;
            chkStatus.Checked = false;
        }
    }
}
