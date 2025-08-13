using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Invoicing_System.Data;
using Invoicing_System.Views.CustomerList;
using Invoicing_System.Views.InvoiceList;
using Invoicing_System.Views.Monitoring;
using Invoicing_System.Views.Reporting;

namespace Invoicing_System.Views
{
    public partial class CustomerSetup : Form
    {
        Functions functions = new Functions();
        private CustomerDetails customerDetails;
        private string qryCustomers;
        Variables var = new Variables();
        private CustomerFilter customerFilter;
        private string lastperformedQuery;
        private string useraccess = Variables.User_CompAccess;
        private frmCustomerList frmCustomerList;

        public CustomerSetup()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            if (!(Variables.isAdminValue || Variables.isSupervisorValue))
            {
                dgvCustomers.Columns[10].Visible = false;
            }

            PopulateCustomers();
            PopTotal();
        }

        public void PopTotal()
        {
            int visibleCustCount = dgvCustomers.Rows.Cast<DataGridViewRow>().Count(row => !row.IsNewRow && row.Cells[1].Visible);
            lblnoofcust.Text = visibleCustCount.ToString();
        }

        public void PopulateCustomers()
        {
            qryCustomers = "SELECT custID,custName,contactPerson,cpPosition,emailAddress,custagencyFee, " +
                "isvatable,hasInterest,otherBillAmt,UPPER(compID) as compID,tin,telno FROM customerstable";

            string qryFilter = "WHERE isDeleted = 0 AND compID IN (" + useraccess + ") ORDER BY custName";
            PopCustDGV(qryCustomers, qryFilter);
        }

        public void PopCustDGV(string query, string queryFilters)
        {
            functions.PopulateDataGridView(dgvCustomers, query + " " + queryFilters);
            lastperformedQuery = query + " " + queryFilters;
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            customerDetails = new CustomerDetails(this);
            customerDetails.FormCode = "CRT";
            customerDetails.ShowDialog();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            try
            {
                string colName = dgvCustomers.Columns[e.ColumnIndex].Name;
                string custID = dgvCustomers.Rows[e.RowIndex].Cells[0].Value.ToString();
                string custName = dgvCustomers.Rows[e.RowIndex].Cells[1].Value.ToString();
                switch (colName)
                {
                    case "colEditCust":
                        customerDetails = new CustomerDetails(this);
                        customerDetails.CustID = int.Parse(dgvCustomers.Rows[e.RowIndex].Cells[0].Value.ToString());
                        customerDetails.FormCode = "UPD";
                        customerDetails.ShowDialog();
                        break;
                    case "colDelCust":
                        string qrycustomerID = "SELECT * FROM interest_monitoring WHERE " +
                            "customerID = '" + custID + "' " +
                            "AND isVoid = 0";
                        var dtqrycustomerID = functions.SelectData(qrycustomerID, "qrycustomerID");
                        if (dtqrycustomerID.Rows.Count > 0)
                        {
                            MessageBox.Show("Customer deletion failed. " + custName + " has active invoice(s) that must be settled before deletion is allowed.", var._title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (MessageBox.Show("Are you sure you want to delete customer " + custName + "? This action cannot be undone, and all associated data will be permanently removed.", var._title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                string voidInvoice = "UPDATE customerstable SET isDeleted = 1 WHERE " +
                                    "custID = '" + custID + "'";
                                functions.SaveData(voidInvoice);
                                MessageBox.Show("Customer " + custName + " successfully deleted!", var._title, MessageBoxButtons.OK, MessageBoxIcon.Information);

                                PopulateCustomers();

                                // Save history for logs
                                functions.SaveData("CALL SP_history('" + Variables.user_unameValue + "','customerstable_h'," +
                                    "'customerstable','custID','" + custID + "')");
                            }
                        }
                        break;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateCustomers();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            customerFilter = new CustomerFilter(this);
            customerFilter.ShowDialog();
        }

        private void bntExport_Click(object sender, EventArgs e)
        {
            frmCustomerList = new frmCustomerList();
            frmCustomerList.PreviewCustomerList(lastperformedQuery);
            frmCustomerList.ShowDialog();
        }
    }
}
