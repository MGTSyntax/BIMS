using Invoicing_System.Data;
using Invoicing_System.Views.OtherSetupList;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoicing_System.Views.InvoiceList
{
    public partial class ShippingDetails : Form
    {
        private frmInvoices _invoices;
        public string InvID { get; set; }
        Functions functions = new Functions();
        Variables var = new Variables();
        Validations val = new Validations();

        public ShippingDetails(frmInvoices invoices)
        {
            InitializeComponent();
            _invoices = invoices;
        }

        private void ShippingDetails_Load(object sender, EventArgs e)
        {
            PopulateControlsToUpdate();
            dtpDateShipped.Value = DateTime.Now;
        }

        private void PopulateControlsToUpdate()
        {
            string qryCustomerID = "SELECT a.customerID,b.custName,a.invoiceNumber," +
                "(reimbursement+nonDeductible+agencyFee+vat+otherBillable+discount) as toTals FROM invoice_monitoring a " +
                "LEFT JOIN customerstable b ON a.customerID = b.custID WHERE invoicesid = '" + InvID.ToString() + "'";
            var dtqryCustomerID = functions.SelectData(qryCustomerID, "qryCustomerID");
            if (dtqryCustomerID.Rows.Count > 0)
            {
                foreach (DataRow dr in dtqryCustomerID.Rows)
                {
                    txtCustID.Text = dr[0].ToString();
                    txtCustomer.Text = dr[1].ToString();
                    txtInvoiceNum.Text = dr[2].ToString();
                    txtInvAmt.Text = dr[3].ToString();
                }
            }
        } // End of PopulateControlsToUpdate

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DateTimePicker dtNOw = new DateTimePicker();
            dtNOw.Value = DateTime.Today.Date;
            bool isDateRangeValid = val.isDateRangeValid(dtpDateShipped, dtNOw, errP);

            if (isDateRangeValid)
            {
                DateTime shipDate = dtpDateShipped.Value.Date;
                DateTime dueDate = shipDate.AddDays(30);

                string addInterest = "INSERT INTO interest_monitoring(invoiceNum,customerID,shippingDate," +
                            "dueDate,balanceAmt,aging,interestAmount,compID,isVoid,isPaid) " +
                            "VALUES('" + txtInvoiceNum.Text + "'," +
                            "'" + txtCustID.Text + "','" + shipDate.ToString("yyyy-MM-dd") + "'," +
                            "'" + dueDate.ToString("yyyy-MM-dd") + "','" + txtInvAmt.Text + "'," +
                            "'0','0','" + txtcompID.Text + "','0','0')";
                functions.SaveData(addInterest);
                MessageBox.Show("Invoice No. " + txtInvoiceNum.Text + " successfully shipped!", var._title, MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Save history for logs
                functions.SaveData("CALL SP_history('" + Variables.user_unameValue + "','interest_monitoring_h'," +
                    "'interest_monitoring','interestID',(SELECT MAX(interestID) FROM interest_monitoring))");

                this.Dispose();
            }
        }

        private void txtCustID_TextChanged(object sender, EventArgs e)
        {
            GetCustDetails();
        }

        public void GetCustDetails()
        {
            string qrycompID = "SELECT compID FROM customerstable WHERE custID = '" + txtCustID.Text + "'";
            var dtqrycompID = functions.SelectData(qrycompID, "qrycompID");
            if (dtqrycompID.Rows.Count > 0)
            {
                txtcompID.Text = dtqrycompID.Rows[0]["compID"].ToString();
            }
        }

    }
}
