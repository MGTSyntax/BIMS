using Invoicing_System.Data;
using Invoicing_System.Views.InvoiceList;
using Invoicing_System.Views.Monitoring;
using Invoicing_System.Views.ReimbursementList;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoicing_System.Views
{
    public partial class frmReimbursements : Form
    {
        Functions functions = new Functions();
        Variables var = new Variables();
        private ReimbursementDetails insertReimbursementDetails;
        private InvoiceFilter InvoiceFilter;
        private string lastperformedQuery;

        public frmReimbursements()
        {
            InitializeComponent();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReimbursements_Load(object sender, EventArgs e)
        {
            populateReimbursements();
        }

        public void populateReimbursements()
        {
            string query = "WHERE b.isVoid=0 AND b.compID IN (" + Variables.User_CompAccess + ") " +
                "ORDER BY c.custName LIMIT 100";
            queryData(query);
        }

        public void queryData(string whereQuery)
        {
            string query = "SELECT a.id, UPPER(b.compID) as company, a.invoice_number, c.custName, b.billingPeriod_from, " +
                "b.billingPeriod_to, b.reimbursement, a.total_payroll, a.thirteenth_mp, a.sil, a.uniform_allowance, " +
                "a.total_mandatories, a.retirement, a.insurance, a.radio_n_firearms " +
                "FROM reimbursement_details a " +
                "LEFT JOIN invoice_monitoring b ON a.invoice_number = b.invoiceNumber " +
                "INNER JOIN customerstable c ON b.customerID = c.custID";
            functions.PopulateDataGridView(dgvreimbursements, query + " " + whereQuery);
            lastperformedQuery = query + " " + whereQuery;
        }

        private void dgvreimbursements_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                string colName = dgvreimbursements.Columns[e.ColumnIndex].Name;
                DataGridViewRow selectedRow = dgvreimbursements.SelectedRows[0];
                string dgvId = selectedRow.Cells[0].Value.ToString();
                string dgvCompany = selectedRow.Cells[1].Value.ToString();
                string dgvInvoiceNumber = selectedRow.Cells[2].Value.ToString();
                string dgvCustomer = selectedRow.Cells[3].Value.ToString();
                string dgvPeriodFrom = selectedRow.Cells[4].Value.ToString();
                string dgvPeriodTo = selectedRow.Cells[5].Value.ToString();
                string dgvReimbursement = selectedRow.Cells[6].Value.ToString();
                string dgvTotalPayroll = selectedRow.Cells[7].Value.ToString();
                string dgv13thMP = selectedRow.Cells[8].Value.ToString();
                string dgvSIL = selectedRow.Cells[9].Value.ToString();
                string dgvUniformAllowance = selectedRow.Cells[10].Value.ToString();
                string dgvTotalManda = selectedRow.Cells[11].Value.ToString();
                string dgvRetirement = selectedRow.Cells[12].Value.ToString();
                string dgvInsurance = selectedRow.Cells[13].Value.ToString();
                string dgvRadioFirearms = selectedRow.Cells[14].Value.ToString();

                switch (colName)
                {
                    case "colEdit":
                        if (string.IsNullOrEmpty(dgvId))
                        {
                            MessageBox.Show("No break down to change yet.", var._title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        insertReimbursementDetails = new ReimbursementDetails(this);
                        insertReimbursementDetails.reimbursementID = int.Parse(dgvId);
                        insertReimbursementDetails.company = dgvCompany;
                        insertReimbursementDetails.invoiceNumber = int.Parse(dgvInvoiceNumber);
                        insertReimbursementDetails.customerName = dgvCustomer;
                        insertReimbursementDetails.periodFrom = DateTime.Parse(dgvPeriodFrom);
                        insertReimbursementDetails.periodTo = DateTime.Parse(dgvPeriodTo);
                        insertReimbursementDetails.reimbursementAmount = double.Parse(dgvReimbursement);
                        insertReimbursementDetails.totalPayroll = double.Parse(dgvTotalPayroll);
                        insertReimbursementDetails.thirteenthMP = double.Parse(dgv13thMP);
                        insertReimbursementDetails.sil = double.Parse(dgvSIL);
                        insertReimbursementDetails.uniformAllow = double.Parse(dgvUniformAllowance);
                        insertReimbursementDetails.totalManda = double.Parse(dgvTotalManda);
                        insertReimbursementDetails.retirement = double.Parse(dgvRetirement);
                        insertReimbursementDetails.insurance = double.Parse(dgvInsurance);
                        insertReimbursementDetails.radioFirearms = double.Parse(dgvRadioFirearms);
                        insertReimbursementDetails.FormCode = "UPD";
                        insertReimbursementDetails.ShowDialog();
                        break;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            populateReimbursements();
        }

        private void btnexportexcel_Click(object sender, EventArgs e)
        {
            string sheetName = "Reimbursement Details";
            string query = "SELECT " +
                "UPPER(a.compID) AS 'Company', " +
                "a.invoiceNumber AS 'Invoice Number', " +
                "b.custName AS 'Customer Name', " +
                "a.billingPeriod_from AS 'Billing Period From', " +
                "a.billingPeriod_to AS 'Billing Period To', " +
                "Round(a.reimbursement,2) AS 'Reimbursement', " +
                "Round(a.nonDeductible,2) AS 'Additional Reimbursement', " +
                "Round(a.agencyFee,2) AS 'Agency Fee', " +
                "Round(a.vat,2) AS 'VAT', " +
                "Round(a.otherBillable,2) AS 'Other Billable', " +
                "Round(a.discount,2) AS 'Less Discount', " +
                "Round((a.reimbursement + a.nonDeductible + a.agencyFee + a.vat + a.otherBillable),2) AS 'Total Amount', " +
                "Round((a.agencyFee * wt.wtax_rate),2) AS 'Withholding Tax', " +
                "Round((a.reimbursement + a.nonDeductible + a.agencyFee + a.vat + a.otherBillable + a.discount) - (a.agencyFee * wt.wtax_rate),2) AS 'Grand Total Amount', " +
                "If(a.isPaid = 'True', 'Paid', 'Unpaid') AS 'Payment Status', " +
                "Round(rd.total_payroll,2) AS 'Total Payroll', " +
                "Round(rd.thirteenth_mp,2) AS 'Thirteenth Month Pay', " +
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
                "WHERE a.isVoid=0 AND a.compID IN (" + Variables.User_CompAccess + ") " +
                "ORDER BY b.custName";
            functions.createExcelReport(query, sheetName);
        }

        private void btnfilter_Click(object sender, EventArgs e)
        {
            InvoiceFilter = new InvoiceFilter(this);
            InvoiceFilter.formCode = "frmReimbursements";
            InvoiceFilter.ShowDialog();
        }
    }
}
