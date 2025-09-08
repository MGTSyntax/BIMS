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
            try
            {
                string query = "WHERE b.isVoid=0 AND b.compID IN (" + Variables.User_CompAccess + ") " +
                "ORDER BY c.custName LIMIT 100";
                queryData(query);
            }
            catch (Exception ex)
            {
                functions.LogErrorToDb(ex, "frmReimbursements", "populateReimbursements");
                MessageBox.Show("An unexpected error occurred. The error has been logged. Please contact your administrator.");
            }
        }

        public void queryData(string whereQuery)
        {
            try
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
            catch (Exception ex)
            {
                functions.LogErrorToDb(ex, "frmReimbursements", "queryData");
                MessageBox.Show("An unexpected error occurred. The error has been logged. Please contact your administrator.");
            }
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
            catch (Exception ex)
            {
                functions.LogErrorToDb(ex, "frmReimbursements", "dgvreimbursements_CellContentClick");
                MessageBox.Show("An unexpected error occurred. The error has been logged. Please contact your administrator.");
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            populateReimbursements();
        }

        private void btnfilter_Click(object sender, EventArgs e)
        {
            InvoiceFilter = new InvoiceFilter(this);
            InvoiceFilter.formCode = "frmReimbursements";
            InvoiceFilter.ShowDialog();
        }
    }
}
