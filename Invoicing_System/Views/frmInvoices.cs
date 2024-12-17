using Invoicing_System.Data;
using Invoicing_System.Views.InvoiceList;
using Invoicing_System.Views.Monitoring;
using Invoicing_System.Views.Reporting;
using System;
using System.Collections;
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
    public partial class frmInvoices : Form
    {
        Functions functions = new Functions();
        private InvoiceDetails createInvoice;
        private ShippingDetails shippingDetails;
        private InvoiceFilter InvoiceFilter;
        private frmReport frmReport;
        private frmInvoiceList frmInvoiceList;
        Variables var = new Variables();
        private string lastperformedQuery;

        public frmInvoices()
        {
            InitializeComponent();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewInvoice_Click(object sender, EventArgs e)
        {
            createInvoice = new InvoiceDetails(this);
            createInvoice.FormCode = "CRT";
            createInvoice.ShowDialog();
        }

        private void frmInvoices_Load(object sender, EventArgs e)
        {
            if (!(Variables.isAdminValue || Variables.isSupervisorValue))
            {
                dgvInvoices.Columns["colVoid"].Visible = false;
            }
            
            PopulateInvoices();
            PopTotals();
        }

        public void PopulateInvoices()
        {
            string qryInvoicesFilters = "WHERE a.isPaid=0 AND a.isVoid=0 AND a.compID IN (" + Variables.User_CompAccess + ") " +
                "ORDER BY b.custName LIMIT 100";
            PopInvDGV(qryInvoicesFilters);
        }

        public void PopInvDGV(string queryFilters)
        {
            string qryInvoices = "SELECT a.invoicesid,a.invoiceNumber,b.custName,a.billingPeriod_from," +
                "a.billingPeriod_to,a.reimbursement,a.nonDeductible,a.agencyFee,a.vat,a.otherBillable,a.discount," +
                "(a.reimbursement+a.nonDeductible+a.agencyFee+a.vat+a.otherBillable) as totalamt," +
                "ROUND(a.agencyFee * wt.wtax_rate) as wht," +
                "ROUND((a.reimbursement + a.nonDeductible + a.agencyFee + a.vat + a.otherBillable + a.discount) - (a.agencyFee * wt.wtax_rate),2) as grandtotal," +
                "UPPER(a.compID) as company,a.isPaid,a.printStatus FROM invoice_monitoring a " +
                "LEFT JOIN customerstable b ON a.customerID = b.custID " +
                "LEFT JOIN (SELECT wtax_rate FROM tblwtax WHERE wtaxID = '1') wt ON 1 = 1";
            functions.PopulateDataGridView(dgvInvoices, qryInvoices + " " + queryFilters);
            lastperformedQuery = qryInvoices + " " + queryFilters;
        }

        public void PopTotals()
        {
            int visibleRowCount = dgvInvoices.Rows.Cast<DataGridViewRow>().Count(row => !row.IsNewRow && row.Cells[2].Visible);
            lblnoofcust.Text = visibleRowCount.ToString();

            decimal totalReim = dgvInvoices.Rows.Cast<DataGridViewRow>().Where(row => !row.IsNewRow && row.Visible && row.Cells[5].Visible)
                .Sum(row => decimal.TryParse(row.Cells[5].Value?.ToString(), out decimal amount) ? amount : 0);
            lbltotalreim.Text = totalReim.ToString("N2");

            decimal totalNonD = dgvInvoices.Rows.Cast<DataGridViewRow>().Where(row => !row.IsNewRow && row.Visible && row.Cells[6].Visible)
                .Sum(row => decimal.TryParse(row.Cells[6].Value?.ToString(), out decimal amount) ? amount : 0);
            lbltotalNonD.Text = totalNonD.ToString("N2");

            decimal totalAF = dgvInvoices.Rows.Cast<DataGridViewRow>().Where(row => !row.IsNewRow && row.Visible && row.Cells[7].Visible)
                .Sum(row => decimal.TryParse(row.Cells[7].Value?.ToString(), out decimal amount) ? amount : 0);
            lbltotalAF.Text = totalAF.ToString("N2");

            decimal totalVAT = dgvInvoices.Rows.Cast<DataGridViewRow>().Where(row => !row.IsNewRow && row.Visible && row.Cells[8].Visible)
                .Sum(row => decimal.TryParse(row.Cells[8].Value?.ToString(), out decimal amount) ? amount : 0);
            lbltotalVAT.Text = totalVAT.ToString("N2");

            decimal totalOB = dgvInvoices.Rows.Cast<DataGridViewRow>().Where(row => !row.IsNewRow && row.Visible && row.Cells[9].Visible)
                .Sum(row => decimal.TryParse(row.Cells[9].Value?.ToString(), out decimal amount) ? amount : 0);
            lbltotalOBill.Text = totalOB.ToString("N2");

            decimal totalDisc = dgvInvoices.Rows.Cast<DataGridViewRow>().Where(row => !row.IsNewRow && row.Visible && row.Cells[10].Visible)
                .Sum(row => decimal.TryParse(row.Cells[10].Value?.ToString(), out decimal amount) ? amount : 0);
            lbltotalDisc.Text = totalDisc.ToString("N2");

            decimal totalTAmt = dgvInvoices.Rows.Cast<DataGridViewRow>().Where(row => !row.IsNewRow && row.Visible && row.Cells[11].Visible)
                .Sum(row => decimal.TryParse(row.Cells[11].Value?.ToString(), out decimal amount) ? amount : 0);
            lbltotalofTotals.Text = totalTAmt.ToString("N2");
        }

        private void dgvInvoices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string colName = dgvInvoices.Columns[e.ColumnIndex].Name;
                string dgvInvNo = dgvInvoices.Rows[e.RowIndex].Cells[1].Value.ToString();
                string dgvInvId = dgvInvoices.Rows[e.RowIndex].Cells[0].Value.ToString();
                string isPaid = dgvInvoices.Rows[e.RowIndex].Cells[12].Value.ToString();
                switch (colName)
                {
                    case "colEdit":
                        if (isPaid == "False")
                        {
                            createInvoice = new InvoiceDetails(this);
                            createInvoice.InvID = int.Parse(dgvInvId);
                            createInvoice.FormCode = "UPD";
                            createInvoice.ShowDialog();
                        } else MessageBox.Show("You cannot modify paid invoice.", var._title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "colVoid":
                        if (!string.IsNullOrEmpty(dgvInvNo))
                        {
                            string qryinvoiceNum = "SELECT * FROM interest_monitoring WHERE invoiceNum = '" + dgvInvNo + "'";
                            var dtqryinvoiceNum = functions.SelectData(qryinvoiceNum, "qryinvoiceNum");
                            if (dtqryinvoiceNum.Rows.Count > 0)
                            {
                                if (MessageBox.Show("The item with Invoice number " + dgvInvNo + " has already been shipped. Are you sure you want to proceed with voiding this item?", var._title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    string voidInvoice = "UPDATE invoice_monitoring SET isVoid = 1 WHERE " +
                                        "invoiceNumber = '" + dgvInvNo + "'";
                                    functions.SaveData(voidInvoice);

                                    // Save history for logs
                                    functions.SaveData("CALL SP_history('" + Variables.user_unameValue + "','invoice_monitoring_h'," +
                                        "'invoice_monitoring','invoicesid','" + dgvInvId + "')");

                                    string voidInterest = "UPDATE interest_monitoring SET isVoid = 1 WHERE " +
                                        "invoiceNum = '" + dgvInvNo + "'";
                                    functions.SaveData(voidInterest);
                                    MessageBox.Show("Item " + dgvInvNo + " successfully voided!", var._title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    PopulateInvoices();

                                    // Save history for logs
                                    functions.SaveData("CALL SP_history('" + Variables.user_unameValue + "','interest_monitoring_h'," +
                                        "'interest_monitoring','invoiceNum','" + dgvInvNo + "')");

                                }
                            }
                            else
                            {
                                if (MessageBox.Show("Void Invoice no. " + dgvInvNo + "?", var._title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    string voidInvoice = "UPDATE invoice_monitoring SET isVoid = 1 WHERE " +
                                        "invoiceNumber = '" + dgvInvNo + "'";
                                    functions.SaveData(voidInvoice);
                                    MessageBox.Show("Item " + dgvInvNo + " successfully voided!", var._title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    PopulateInvoices();

                                    // Save history for logs
                                    functions.SaveData("CALL SP_history('" + Variables.user_unameValue + "','invoice_monitoring_h'," +
                                        "'invoice_monitoring','invoicesid','" + dgvInvNo + "')");

                                }
                            }
                        }
                        else MessageBox.Show("Cannot void empty Invoice No..", var._title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "colPrint":
                        frmReport = new frmReport(this);
                        frmReport.PreviewInvoice("SELECT invoicesid,(reimbursement+nonDeductible) as reimbursement,agencyFee,vat," +
                            "otherBillable,custName,titleTemplate,billingPeriod_from,billingPeriod_to," +
                            "invoiceNumber,notes,companyAddress,contactPerson,cpPosition," +
                            "(reimbursement+agencyFee+vat+otherBillable) as toTals, " +
                            "preparedBy,approveBy,notedBy,tin,telno " +
                            "FROM invoice_monitoring a INNER JOIN customerstable b ON b.custID = a.customerID " +
                            "INNER JOIN tblcompanies c ON c.companyID = b.compID " +
                            "WHERE invoicesid = '" + dgvInvId + "'");
                        frmReport.InvID = int.Parse(dgvInvId);
                        frmReport.ShowDialog();
                        break;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnShipDate_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvInvoices.SelectedRows[0];
            string invID = selectedRow.Cells[0].Value.ToString();
            string invNo = selectedRow.Cells[1].Value.ToString();
            string isPaid = selectedRow.Cells[12].Value.ToString();

            if (isPaid == "False")
            {
                string qryinvoiceNum = "SELECT * FROM interest_monitoring WHERE invoiceNum = '" + invNo.ToString() + "'";
                var dtqryinvoiceNum = functions.SelectData(qryinvoiceNum, "qryinvoiceNum");
                if (dtqryinvoiceNum.Rows.Count > 0)
                {
                    MessageBox.Show("Invoice no. " + invNo.ToString() + " already tagged.", var._title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (!string.IsNullOrEmpty(invNo))
                    {
                        shippingDetails = new ShippingDetails(this);
                        shippingDetails.InvID = invID;
                        shippingDetails.ShowDialog();
                    }
                    else MessageBox.Show("Invoice no. cannot be empty.", var._title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } else MessageBox.Show("You cannot ship paid invoice.", var._title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            InvoiceFilter = new InvoiceFilter(this);
            InvoiceFilter.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateInvoices();
        }

        private void bntExport_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvInvoices.SelectedRows[0];
            string invID = selectedRow.Cells[0].Value.ToString();

            frmInvoiceList = new frmInvoiceList();
            frmInvoiceList.PreviewInvoiceList(lastperformedQuery);
            frmInvoiceList.ShowDialog();
        }
    }
}
