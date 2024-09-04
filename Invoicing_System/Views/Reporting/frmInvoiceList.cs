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
    public partial class frmInvoiceList : Form
    {
        Variables var = new Variables();

        public frmInvoiceList()
        {
            InitializeComponent();
        }

        private void frmInvoiceList_Load(object sender, EventArgs e)
        {

        }

        public void PreviewInvoiceList(string query)
        {
            ReportDataSource rptDs;
            rptVInvList.LocalReport.ReportPath = Application.StartupPath + @"\Reports\rptInvoiceList.rdlc";
            rptVInvList.LocalReport.DataSources.Clear();

            DSInvoice dSInvoice = new DSInvoice();
            MySqlDataAdapter rptda = new MySqlDataAdapter();

            var.con.Open();
            rptda.SelectCommand = new MySqlCommand(query, var.con);
            rptda.Fill(dSInvoice.Tables["dtInvoices"]);
            rptDs = new ReportDataSource("DSInvoiceList", dSInvoice.Tables["dtInvoices"]);

            rptVInvList.LocalReport.DataSources.Add(rptDs);

            //DataRow row = dSInvoice.Tables["dtInvoices"].Rows[0];

            //Convert Numbers to Words
            //decimal conVerted = Convert.ToDecimal(row["toTals"]);
            //rptVInvList.LocalReport.SetParameters(new ReportParameter("NumericToWords", functions.ConvertCurrencyToWords(conVerted)));

            //Display Report
            rptVInvList.SetDisplayMode(DisplayMode.PrintLayout);
            rptVInvList.ZoomMode = ZoomMode.Percent;
            rptVInvList.ZoomPercent = 100;
            var.con.Close();
        }

    }
}
