using Invoicing_System.Data;
using Invoicing_System.Reports;
using Invoicing_System.Views.InterestList;
using Invoicing_System.Views.InvoiceList;
using Invoicing_System.Views.Monitoring;
using Invoicing_System.Views.Reporting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoicing_System.Views
{
    public partial class frmPayments : Form
    {
        private string qryPaymentHistory;
        private string qryPaymentDetails;
        Functions functions = new Functions();
        Variables var = new Variables();
        private PayAmountDetails PayAmountDetails;
        private string useraccess = Variables.User_CompAccess;
        private string lastperformedQuery;
        private string lastperformedQueryreport;
        public string lastfilterreport;
        private PaymentFilter paymentFilter;
        private frmPaymentList frmPaymentList;

        public frmPayments()
        {
            InitializeComponent();
        }

        private void frmPayments_Load(object sender, EventArgs e)
        {
            PopInterestDGV();
            PopulateInterest();

            var balance = 0;
            var pay = 0;
            lblbalance.Text = balance.ToString("N2");
            lblpay.Text = pay.ToString("N2");
        }

        public void PopulateInterest()
        {
            string qryFilter = "WHERE isPaid=0 AND isVoid=0 AND a.compID IN (" + useraccess + ") ORDER BY b.custName";
            PopPaymentDGV(qryFilter);
            lastfilterreport = qryFilter;
        }

        public void PopPaymentDGV(string queryFilters)
        {
            string qryInterest = "SELECT a.interestID," +
                "a.invoiceNum," +
                "b.custName," +
                "a.shippingDate," +
                "a.dueDate," +
                "IFNULL(a.balanceAmt-(SELECT IFNULL(SUM(p_invoiceBalPay), 0) FROM tblpayment WHERE p_invoiceNum = a.invoiceNum), a.balanceAmt) AS balance," +
                "age.age_value AS aging," +
                "a.interestAmount AS interest," +
                "a.compID," +
                "a.isPaid " +
                "FROM interest_monitoring a LEFT JOIN customerstable b ON a.customerID = b.custID LEFT JOIN " +
                "(SELECT IF(DATEDIFF(CURDATE(), shippingDate) < 0, (DATEDIFF(CURDATE(), shippingDate) * - 1), DATEDIFF(CURDATE(), shippingDate)) AS age_value, invoiceNum FROM interest_monitoring) AS age ON a.invoiceNum = age.invoiceNum";
            //Interest  - IF(age.age_value > 30, (IFNULL(a.balanceAmt - (SELECT SUM(p_invoiceBalPay) FROM tblpayment WHERE p_invoiceNum = a.invoiceNum), a.balanceAmt) * (SELECT interest_rate FROM tblinterest)), a.interestAmount) as interest,

            functions.PopulateDataGridView(dgvInterest, qryInterest + " " + queryFilters);
            lastperformedQuery = qryInterest + " " + queryFilters;
        }

        public void PopInterestDGV()
        {
            string qryInterest = "SELECT a.invoiceNum," +
                "IFNULL(a.balanceAmt-(SELECT SUM(p_invoiceBalPay) FROM tblpayment WHERE p_invoiceNum = a.invoiceNum), a.balanceAmt) AS balance," +
                "age.age_value AS age," +
                "IF(age.age_value > 30, ROUND((IFNULL(a.balanceAmt-(SELECT SUM(p_invoiceBalPay) FROM tblpayment WHERE p_invoiceNum = a.invoiceNum), a.balanceAmt)) * ((0.02 / 30) * (DATEDIFF(curdate(),shippingDate))),2),0) AS interest " +
                "FROM interest_monitoring a LEFT JOIN " +
                "(SELECT IF(DATEDIFF(CURDATE(), shippingDate) < 0, (DATEDIFF(CURDATE(), shippingDate) * - 1), DATEDIFF(CURDATE(), shippingDate)) AS age_value, " +
                "invoiceNum FROM interest_monitoring) AS age ON a.invoiceNum = age.invoiceNum " +
                "WHERE isPaid = 0 AND isVoid = 0 AND compID IN (" + useraccess + ")";

            var dtqryInterest = functions.SelectData(qryInterest, "interest");
            foreach (DataRow drInterest in dtqryInterest.Rows)
            {
                UpdateInterest(drInterest["invoiceNum"].ToString(), decimal.Parse(drInterest["interest"].ToString()), int.Parse(drInterest["age"].ToString()));
                if (decimal.Parse(drInterest["balance"].ToString()) == 0)
                {
                    UpdatePaidStatus(drInterest["invoiceNum"].ToString(), decimal.Parse(drInterest["balance"].ToString()));
                }
            }
        }

        private void UpdateInterest(string invoiceNum, decimal newInterest, int age)
        {
            string qryUpdateInterest = "UPDATE interest_monitoring SET aging='" + age + "', interestAmount='" + newInterest + "' WHERE invoiceNum='" + invoiceNum + "'";
            functions.SaveData(qryUpdateInterest);
        }

        private void UpdatePaidStatus(string invoiceNum, decimal newPaidStatus)
        {
            string qryUpdisPaid1 = "UPDATE interest_monitoring SET isPaid='1' WHERE invoiceNum='" + invoiceNum + "'";
            functions.SaveData(qryUpdisPaid1);

            string qryUpdisPaid2 = "UPDATE invoice_monitoring SET isPaid='1' WHERE invoiceNumber='" + invoiceNum + "'";
            functions.SaveData(qryUpdisPaid2);
        }

        private void dgvInterest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string colName = dgvInterest.Columns[e.ColumnIndex].Name;
                switch (colName)
                {
                    case "colViewPayment":
                        // Payment History
                        qryPaymentHistory = "SELECT p_id,p_invoiceBalPay,p_datePaid FROM tblpayment WHERE " +
                            "p_invoiceNum = '" + dgvInterest.Rows[e.RowIndex].Cells[1].Value.ToString() + "' " +
                            "ORDER BY p_datePaid";
                        functions.PopulateDataGridView(dgvPaymentHistory, qryPaymentHistory);

                        decimal totalBalance = 0;
                        decimal updatedBalance = 0;
                        decimal invTotalAmt = Convert.ToDecimal(dgvInterest.Rows[e.RowIndex].Cells[5].Value);
                        decimal invInterestAmt = Convert.ToDecimal(dgvInterest.Rows[e.RowIndex].Cells[7].Value);

                        var dtqryPaymentHistory = functions.SelectData(qryPaymentHistory, "qryPaymentHistory");
                        if (dtqryPaymentHistory.Rows.Count > 0)
                        {
                            foreach (DataRow dr in dtqryPaymentHistory.Rows)
                            {
                                decimal rowBalance = Convert.ToDecimal(dr[1]);
                                totalBalance += rowBalance;
                            }
                            updatedBalance = (invTotalAmt + invInterestAmt);
                            lblbalance.Text = updatedBalance.ToString("N2");
                            lblpay.Text = totalBalance.ToString("N2");
                        } else
                        {
                            updatedBalance = (invTotalAmt + invInterestAmt);
                            lblbalance.Text = updatedBalance.ToString("N2");
                            lblpay.Text = totalBalance.ToString("N2");
                        }
                        break;
                }
                lblORN.Text = "No payment details";
                lblARN.Text = "No payment details";
                lblCHKN.Text = "No payment details";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnEnterPayment_Click(object sender, EventArgs e)
        {
            if (dgvInterest.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvInterest.SelectedRows[0];
                dgvPaymentHistory.Rows.Clear();

                string interestNo = selectedRow.Cells[0].Value.ToString();
                decimal invBal = Convert.ToDecimal(selectedRow.Cells[5].Value.ToString());
                decimal interestAmt = Convert.ToDecimal(selectedRow.Cells[7].Value.ToString());
                decimal totalInvBal = invBal + interestAmt;
                bool paid = Convert.ToBoolean(selectedRow.Cells[9].Value.ToString());

                if (paid == true)
                {
                    MessageBox.Show("Invoice No. is already paid.", var._title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    PayAmountDetails = new PayAmountDetails(this);
                    PayAmountDetails.InterestNo = interestNo;
                    PayAmountDetails.InvBal = invBal;
                    PayAmountDetails.InterestAmt = interestAmt;
                    PayAmountDetails.totalInvBal = totalInvBal;
                    PayAmountDetails.ShowDialog();
                }
            }
            else MessageBox.Show("No payment selected", var._title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateInterest();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            paymentFilter = new PaymentFilter(this);
            paymentFilter.ShowDialog();
        }

        private void bntExport_Click(object sender, EventArgs e)
        {
            List<string> paymentHID = new List<string>();
            foreach (DataGridViewRow phidrow in dgvInterest.Rows)
            {
                if (phidrow.Cells[0].Value != null)
                {
                    string value = phidrow.Cells[0].Value.ToString();
                    paymentHID.Add(value);
                }
            }
            string paymentHistory = "SELECT " +
                "a.interestID," +
                "a.invoiceNum," +
                "b.custName," +
                "a.shippingDate," +
                "a.dueDate," +
                "a.balanceAmt AS balance," +
                "IF(DATEDIFF(CURDATE(), a.shippingDate) < 0, (DATEDIFF(CURDATE(), a.shippingDate) * - 1), DATEDIFF(CURDATE(), a.shippingDate)) AS aging," +
                "a.interestAmount as interest," +
                "IFNULL(c.p_invoiceBalPay,0) AS payment," +
                "c.p_orNum AS orno," +
                "c.p_arNum AS arno," +
                "c.p_checkNum AS checkno," +
                "a.compID," +
                "a.isPaid " +
                "FROM interest_monitoring a " +
                "LEFT JOIN customerstable b ON a.customerID = b.custID " +
                "LEFT JOIN tblpayment c ON a.invoiceNum = c.p_invoiceNum";

            PopPaymentHistoryReport(paymentHistory);

            frmPaymentList = new frmPaymentList();
            frmPaymentList.PreviewPaymentList(lastperformedQueryreport);
            frmPaymentList.ShowDialog();
        }

        public void PopPaymentHistoryReport(string queryFilters)
        {
            lastperformedQueryreport = queryFilters + " " + lastfilterreport;
        }

        private void dgvPaymentHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvPaymentHistory.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvPaymentHistory.SelectedRows[0];
                    string pID = selectedRow.Cells["colp_id"].Value.ToString();

                    // Payment Details
                    qryPaymentDetails = "SELECT p_orNum,p_arNum,p_checkNum FROM tblpayment WHERE p_id = '" + pID + "'";
                    var dtqryPaymentDetails = functions.SelectData(qryPaymentDetails, "qryPaymentDetails");
                    if (dtqryPaymentDetails.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dtqryPaymentDetails.Rows)
                        {
                            lblORN.Text = dr[0].ToString();
                            lblARN.Text = dr[1].ToString();
                            lblCHKN.Text = dr[2].ToString();
                        }
                    }
                    else
                    {
                        lblORN.Text = "No payments made";
                        lblARN.Text = "No payments made";
                        lblCHKN.Text = "No payments made";
                    }
                }
                else MessageBox.Show("No row is selected.");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
