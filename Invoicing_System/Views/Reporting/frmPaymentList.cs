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
    public partial class frmPaymentList : Form
    {
        Variables var = new Variables();

        public frmPaymentList()
        {
            InitializeComponent();
        }

        private void frmPaymentList_Load(object sender, EventArgs e)
        {

        }

        public void PreviewPaymentList(string query)
        {
            ReportDataSource rptDs;
            rptVPaymentList.LocalReport.ReportPath = Application.StartupPath + @"\Reports\rptPaymentList.rdlc";
            rptVPaymentList.LocalReport.DataSources.Clear();

            DSPayments dSPayments = new DSPayments();
            MySqlDataAdapter rptda = new MySqlDataAdapter();

            var.con.Open();
            rptda.SelectCommand = new MySqlCommand(query, var.con);
            rptda.Fill(dSPayments.Tables["dtPayments"]);
            rptDs = new ReportDataSource("DSPayments", dSPayments.Tables["dtPayments"]);

            rptVPaymentList.LocalReport.DataSources.Add(rptDs);

            DataRow row = dSPayments.Tables["dtPayments"].Rows[0];

            //Display Report
            rptVPaymentList.SetDisplayMode(DisplayMode.PrintLayout);
            rptVPaymentList.ZoomMode = ZoomMode.Percent;
            rptVPaymentList.ZoomPercent = 100;
            var.con.Close();
        }

    }
}
