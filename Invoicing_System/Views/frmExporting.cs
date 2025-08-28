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
        Functions functions = new Functions();

        public frmExporting()
        {
            InitializeComponent();
        }

        private void frmExporting_Load(object sender, EventArgs e)
        {
            
        }

        private void btnexportqbtemplate_Click(object sender, EventArgs e)
        {
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
                "WHERE a.billingPeriod_from BETWEEN '" + dtpBPFrom.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpBPTo.Value.ToString("yyyy-MM-dd") + "'";
            functions.createIIFReport(query);
        }
    }
}
