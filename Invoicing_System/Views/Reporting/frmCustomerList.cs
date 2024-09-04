using Invoicing_System.Data;
using Invoicing_System.Reports;
using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoicing_System.Views.Reporting
{
    public partial class frmCustomerList : Form
    {
        Variables var = new Variables();

        public frmCustomerList()
        {
            InitializeComponent();
        }

        private void frmCustomerList_Load(object sender, EventArgs e)
        {

        }

        public void PreviewCustomerList(string query)
        {
            ReportDataSource rptDs;
            rvCust.LocalReport.ReportPath = Application.StartupPath + @"\Reports\rptCustList.rdlc";
            rvCust.LocalReport.DataSources.Clear();

            DSCustomer dSCustomer = new DSCustomer();
            MySqlDataAdapter rptda = new MySqlDataAdapter();

            var.con.Open();
            rptda.SelectCommand = new MySqlCommand(query, var.con);
            rptda.Fill(dSCustomer.Tables["dtCustomers"]);
            rptDs = new ReportDataSource("DSCustomer", dSCustomer.Tables["dtCustomers"]);

            rvCust.LocalReport.DataSources.Add(rptDs);

            DataRow row = dSCustomer.Tables["dtCustomers"].Rows[0];

            //Convert Numbers to Words
            //decimal conVerted = Convert.ToDecimal(row["toTals"]);
            //rptVInvList.LocalReport.SetParameters(new ReportParameter("NumericToWords", functions.ConvertCurrencyToWords(conVerted)));

            //Display Report
            rvCust.SetDisplayMode(DisplayMode.PrintLayout);
            rvCust.ZoomMode = ZoomMode.Percent;
            rvCust.ZoomPercent = 100;
            var.con.Close();
        }

    }
}
