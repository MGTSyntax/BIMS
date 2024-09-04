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
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoicing_System.Views
{
    public partial class frmReport : Form
    {
        Variables var = new Variables();
        Functions functions = new Functions();
        public int InvID { get; set; }
        private frmInvoices frmInvoices;

        public frmReport(frmInvoices frmInvoices)
        {
            InitializeComponent();
            this.frmInvoices = frmInvoices;
        }

        private void frmReport_Load(object sender, EventArgs e)
        {

        }

        public void PreviewInvoice(string query)
        {
            ReportDataSource rptDs;
            rptVInvoice.LocalReport.ReportPath = Application.StartupPath + @"\Reports\rptInvoice.rdlc";
            rptVInvoice.LocalReport.DataSources.Clear();

            DSInvoice dSInvoice = new DSInvoice();
            MySqlDataAdapter rptda = new MySqlDataAdapter();

            var.con.Open();
            rptda.SelectCommand = new MySqlCommand(query, var.con);
            rptda.Fill(dSInvoice.Tables["dtInvoices"]);
            rptDs = new ReportDataSource("DSInvoice", dSInvoice.Tables["dtInvoices"]);

            rptVInvoice.LocalReport.DataSources.Add(rptDs);

            DataRow row = dSInvoice.Tables["dtInvoices"].Rows[0];

            //Convert Numbers to Words
            decimal totals = Convert.ToDecimal(row["toTals"]);
            decimal agencyfee = Convert.ToDecimal(row["agencyFee"]);
            decimal conVerted = totals - (agencyfee*0.02m);
            rptVInvoice.LocalReport.SetParameters(new ReportParameter("NumericToWords", functions.ConvertCurrencyToWords(conVerted)));


            //Display Report
            rptVInvoice.SetDisplayMode(DisplayMode.PrintLayout);
            rptVInvoice.ZoomMode = ZoomMode.Percent;
            rptVInvoice.ZoomPercent = 100;
            var.con.Close();
        }

        private void rptVInvoice_PrintingBegin(object sender, ReportPrintEventArgs e)
        {
            string voidInvoice = "UPDATE invoice_monitoring SET printStatus = 1 WHERE " +
                "invoicesid = '" + InvID.ToString() + "'";
            functions.SaveData(voidInvoice);
        }
    }
}
