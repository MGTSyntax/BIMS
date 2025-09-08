using DocumentFormat.OpenXml.Drawing;
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
        }

        public void PopulateInterest()
        {
            try
            {
                string qryFilter = "WHERE isPaid=0 AND isVoid=0 AND a.compID IN (" + useraccess + ") ORDER BY b.custName";
                PopPaymentDGV(qryFilter);
                lastfilterreport = qryFilter;
            }
            catch (Exception ex)
            {
                functions.LogErrorToDb(ex, "frmPayments", "PopulateInterest");
                MessageBox.Show("An unexpected error occurred. The error has been logged. Please contact your administrator.");
            }
        }

        public void PopPaymentDGV(string queryFilters)
        {
            try
            {
                string qryInterest = @"
                SELECT 
                    a.interestID,
                    a.invoiceNum,
                    b.custName,
                    a.shippingDate,
                    a.dueDate,
                    IFNULL(a.balanceAmt - (
                        SELECT IFNULL(SUM(p_invoiceBalPay), 0) 
                        FROM tblpayment 
                        WHERE p_invoiceNum = a.invoiceNum
                    ), a.balanceAmt) AS balance,
                    age.age_value AS aging,
                    a.interestAmount AS interest,
                    UPPER(a.compID) AS compID,
                    a.isPaid,
                    b.hasInterest
                FROM interest_monitoring a 
                LEFT JOIN customerstable b ON a.customerID = b.custID 
                LEFT JOIN (
                    SELECT 
                        invoiceNum,
                        DATEDIFF(CURDATE(), shippingDate) AS age_value 
                    FROM interest_monitoring
                ) age ON a.invoiceNum = age.invoiceNum
            ";

                functions.PopulateDataGridView(dgvInterest, qryInterest + " " + queryFilters);
                lastperformedQuery = qryInterest + " " + queryFilters;
            }
            catch (Exception ex)
            {
                functions.LogErrorToDb(ex, "frmPayments", "PopPaymentDGV");
                MessageBox.Show("An unexpected error occurred. The error has been logged. Please contact your administrator.");
            }
        }

        public void PopInterestDGV()
        {
            try
            {
                string qryInterest = @"
                SELECT 
                    a.invoiceNum,
                    IFNULL(a.balanceAmt - (
                        SELECT IFNULL(SUM(p_invoiceBalPay), 0) 
                        FROM tblpayment 
                        WHERE p_invoiceNum = a.invoiceNum
                    ), a.balanceAmt) AS balance,
                    CASE 
                        WHEN DATEDIFF(CURDATE(), a.dueDate) > 0
                        THEN DATEDIFF(
                            CURDATE(),
                            GREATEST(
                                a.dueDate,
                                IFNULL((
                                    SELECT MAX(p_datePaid)
                                    FROM tblpayment 
                                    WHERE p_invoiceNum = a.invoiceNum
                                ), a.dueDate)
                            )
                        )
                        ELSE 0
                    END AS age,
                    b.hasInterest
                FROM interest_monitoring a 
                LEFT JOIN customerstable b ON a.customerID = b.custID 
                WHERE a.isPaid = 0 AND a.isVoid = 0 AND a.compID IN (" + useraccess + @")
                ";

                var dtqryInterest = functions.SelectData(qryInterest, "interest");
                decimal rate = functions.GetInterestRate();

                foreach (DataRow drInterest in dtqryInterest.Rows)
                {
                    decimal balance = drInterest["balance"] != DBNull.Value ? Convert.ToDecimal(drInterest["balance"]) : 0;
                    int age = drInterest["age"] != DBNull.Value ? Convert.ToInt32(drInterest["age"]) : 0;
                    bool hasInterest = drInterest["hasInterest"] != DBNull.Value && Convert.ToInt32(drInterest["hasInterest"]) == 1;

                    decimal newInterest = 0;
                    if (hasInterest && age > 0)
                    {
                        newInterest = Math.Round(balance * (rate / 30) * age, 2);
                    }

                    string invoiceNum = drInterest["invoiceNum"].ToString();
                    UpdateInterest(invoiceNum, newInterest, age);

                    if (balance == 0 && newInterest == 0)
                    {
                        UpdatePaidStatus(invoiceNum);
                    }
                }
            }
            catch (Exception ex)
            {
                functions.LogErrorToDb(ex, "frmPayments", "PopInterestDGV");
                MessageBox.Show("An unexpected error occurred. The error has been logged. Please contact your administrator.");
            }
        }

        private void UpdateInterest(string invoiceNum, decimal newInterest, int age)
        {
            try
            {
                string qryUpdateInterest = @"
                UPDATE interest_monitoring 
                SET aging = @Age, 
                    interestAmount = @Interest 
                WHERE invoiceNum = @InvoiceNum";

                functions.ParamSaveData(qryUpdateInterest, new Dictionary<string, object>
                {
                    {"@Age", age },
                    {"@Interest", newInterest },
                    {"@InvoiceNum", invoiceNum }
                });
            }
            catch (Exception ex)
            {
                functions.LogErrorToDb(ex, "frmPayments", "UpdateInterest");
                MessageBox.Show("An unexpected error occurred. The error has been logged. Please contact your administrator.");
            }
        }

        private void UpdatePaidStatus(string invoiceNum)
        {
            try
            {
                string qryUpdisPaid1 = @"
                UPDATE interest_monitoring 
                SET isPaid = @paidStats 
                WHERE invoiceNum = @InvoiceNum";
                functions.ParamSaveData(qryUpdisPaid1, new Dictionary<string, object>
                {
                    {"@paidStats", '1' },
                    {"invoiceNum", invoiceNum}
                });

                string qryUpdisPaid2 = @"
                UPDATE invoice_monitoring 
                SET isPaid = @paidStats 
                WHERE invoiceNum = @InvoiceNum";
                functions.ParamSaveData(qryUpdisPaid2, new Dictionary<string, object>
                {
                    {"@paidStats", '1' },
                    {"invoiceNum", invoiceNum}
                });
            }
            catch (Exception ex)
            {
                functions.LogErrorToDb(ex, "frmPayments", "UpdatePaidStatus");
                MessageBox.Show("An unexpected error occurred. The error has been logged. Please contact your administrator.");
            }
        }

        private void btnEnterPayment_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvInterest.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvInterest.SelectedRows[0];
                    dgvPaymentHistory.Rows.Clear();

                    string interestNo = selectedRow.Cells[0].Value.ToString();
                    decimal invBal = Convert.ToDecimal(selectedRow.Cells[5].Value.ToString());
                    decimal interestAmount = Convert.ToDecimal(selectedRow.Cells[7].Value.ToString());

                    PayAmountDetails = new PayAmountDetails(this);
                    PayAmountDetails.InterestNo = interestNo;
                    PayAmountDetails.InvBal = invBal;
                    PayAmountDetails.InterestAmt = interestAmount;
                    PayAmountDetails.ShowDialog();
                }
                else MessageBox.Show("No payment selected", var._title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                functions.LogErrorToDb(ex, "frmPayments", "btnEnterPayment_Click");
                MessageBox.Show("An unexpected error occurred. The error has been logged. Please contact your administrator.");
            }
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
            try
            {
                if (dgvInterest.SelectedRows.Count < 1)
                {
                    MessageBox.Show("No item selected.", var._title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string paymentHistory = "SELECT " +
                    "a.interestID," +
                    "a.invoiceNum," +
                    "b.custName," +
                    "a.shippingDate," +
                    "a.dueDate," +
                    "a.balanceAmt AS balance," +
                    "DATEDIFF(CURDATE(), a.shippingDate) AS aging," +
                    "a.interestAmount as interest," +
                    "IFNULL(c.p_invoiceBalPay,0) AS payment," +
                    "c.p_orNum AS orno," +
                    "c.p_arNum AS arno," +
                    "c.p_bank AS bank," +
                    "c.p_checkNum AS checkno," +
                    "a.compID," +
                    "a.isPaid, " +
                    "c.p_datePaid AS datepaid " +
                    "FROM interest_monitoring a " +
                    "LEFT JOIN customerstable b ON a.customerID = b.custID " +
                    "LEFT JOIN tblpayment c ON a.invoiceNum = c.p_invoiceNum";

                PopPaymentHistoryReport(paymentHistory);

                frmPaymentList = new frmPaymentList();
                frmPaymentList.PreviewPaymentList(lastperformedQueryreport);
                frmPaymentList.ShowDialog();
            }
            catch (Exception ex)
            {
                functions.LogErrorToDb(ex, "frmPayments", "bntExport_Click");
                MessageBox.Show("An unexpected error occurred. The error has been logged. Please contact your administrator.");
            }
        }

        public void PopPaymentHistoryReport(string queryFilters)
        {
            try
            {
                lastperformedQueryreport = queryFilters + " " + lastfilterreport;
            }
            catch (Exception ex)
            {
                functions.LogErrorToDb(ex, "frmPayments", "PopPaymentHistoryReport");
                MessageBox.Show("An unexpected error occurred. The error has been logged. Please contact your administrator.");
            }
        }

        private void dgvInterest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;

                DataGridViewRow selectedRow = dgvInterest.SelectedRows[0];
                string invoiceNumber = selectedRow.Cells[1].Value?.ToString() ?? "";

                // View Payment History
                qryPaymentHistory = "SELECT p_id, p_invoiceBalPay, p_datePaid, " +
                    "p_orNum, p_arNum, p_bank, p_checkNum FROM tblpayment " +
                    "WHERE p_invoiceNum = '" + invoiceNumber + "' " +
                    "ORDER BY p_datePaid";
                functions.PopulateDataGridView(dgvPaymentHistory, qryPaymentHistory);
            }
            catch (Exception ex)
            {
                functions.LogErrorToDb(ex, "frmPayments", "dgvInterest_CellClick");
                MessageBox.Show("An unexpected error occurred. The error has been logged. Please contact your administrator.");
            }
        }
    }
}
