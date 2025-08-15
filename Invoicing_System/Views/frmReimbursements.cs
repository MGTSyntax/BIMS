using Invoicing_System.Data;
using Invoicing_System.Views.Monitoring;
using Invoicing_System.Views.ReimbursementList;
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
    public partial class frmReimbursements : Form
    {
        Functions functions = new Functions();
        Variables var = new Variables();
        private ReimbursementDetails insertReimbursementDetails;
        private string lastperformedQuery;

        public frmReimbursements()
        {
            InitializeComponent();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btninsertdetails_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvreimbursements.SelectedRows[0];
            string company = selectedRow.Cells[1].Value.ToString();
            int invoiceNumber = int.Parse(selectedRow.Cells[2].Value.ToString());
            string customerName = selectedRow.Cells[3].Value.ToString();
            DateTime periodFrom = DateTime.Parse(selectedRow.Cells[4].Value.ToString());
            DateTime periodTo = DateTime.Parse(selectedRow.Cells[5].Value.ToString());
            double reimbursementAmount = double.Parse(selectedRow.Cells[6].Value.ToString());

            if (dgvreimbursements.Rows.Count > 0)
            {
                insertReimbursementDetails = new ReimbursementDetails(this);
                insertReimbursementDetails.company = company;
                insertReimbursementDetails.invoiceNumber = invoiceNumber;
                insertReimbursementDetails.customerName = customerName;
                insertReimbursementDetails.periodFrom = periodFrom;
                insertReimbursementDetails.periodTo = periodTo;
                insertReimbursementDetails.reimbursementAmount = reimbursementAmount;
                insertReimbursementDetails.FormCode = "CRT";
                insertReimbursementDetails.ShowDialog();
            }
            else
            {

            }
        }

        private void frmReimbursements_Load(object sender, EventArgs e)
        {
            populateReimbursements();
        }

        public void populateReimbursements()
        {
            string query = "WHERE a.isVoid=0 AND a.compID IN (" + Variables.User_CompAccess + ") " +
                "ORDER BY c.custName LIMIT 100";
            queryData(query);
        }

        public void queryData(string whereQuery)
        {
            string query = "SELECT b.id, UPPER(a.compID) as company, a.invoiceNumber, c.custName, a.billingPeriod_from, " +
                "a.billingPeriod_to, a.reimbursement, b.total_payroll, b.thirteenth_mp, b.sil, b.uniform_allowance, " +
                "b.total_mandatories, b.retirement, b.insurance, b.radio_n_firearms " +
                "FROM invoice_monitoring a " +
                "LEFT JOIN reimbursement_details b ON a.invoiceNumber = b.invoice_number " +
                "LEFT JOIN customerstable c ON a.customerID = c.custID";
            functions.PopulateDataGridView(dgvreimbursements, query + " " + whereQuery);
            lastperformedQuery = query + " " + whereQuery;
        }

        private void dgvreimbursements_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            // NEED LANG GAWAN NG VALIDATION IF NULL IS EQUAL TO ZERO
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
    }
}
