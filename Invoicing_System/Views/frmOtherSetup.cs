using Invoicing_System.Data;
using Invoicing_System.Views.CustomerList;
using Invoicing_System.Views.Monitoring;
using Invoicing_System.Views.OtherSetupList;
using Invoicing_System.Views.TitleTemplateList;
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
    public partial class frmOtherSetup : Form
    {
        Functions functions = new Functions();
        Variables var = new Variables();
        private TitleTemplateDetails titleTemplateDetails;
        private VATRate vATRate;
        private InterestRate interestRate;
        private WTaxRate wtaxrate;
        private string qryTitleTemplates;
        private string qryVATRate;
        private string qryInterestRate;
        private string qryWTaxRate;

        public frmOtherSetup()
        {
            InitializeComponent();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTitleTemplate_Load(object sender, EventArgs e)
        {
            PopulateTitleTemplates();
            PopulateVATRate();
            PopulateInterestRate();
            PopulateWTaxRate();
        }

        public void PopulateTitleTemplates()
        {
            try
            {
                qryTitleTemplates = "SELECT titleid,titleDescription,titleStatus FROM titletemplate";
                functions.PopulateDataGridView(dgvTitleTemplate, qryTitleTemplates);
            }
            catch (Exception ex)
            {
                functions.LogErrorToDb(ex, "frmOtherSetup", "PopulateTitleTemplates");
                MessageBox.Show("An unexpected error occurred. The error has been logged. Please contact your administrator.");
            }
        }

        public void PopulateVATRate()
        {
            try
            {
                qryVATRate = "SELECT rateID,vat_rate FROM tblvat";
                functions.PopulateDataGridView(dgvVATRate, qryVATRate);
            }
            catch (Exception ex)
            {
                functions.LogErrorToDb(ex, "frmOtherSetup", "PopulateVATRate");
                MessageBox.Show("An unexpected error occurred. The error has been logged. Please contact your administrator.");
            }
        }

        public void PopulateInterestRate()
        {
            try
            {
                qryInterestRate = "SELECT interestID,interest_rate FROM tblinterest";
                functions.PopulateDataGridView(dgvInterestRate, qryInterestRate);
            }
            catch (Exception ex)
            {
                functions.LogErrorToDb(ex, "frmOtherSetup", "PopulateInterestRate");
                MessageBox.Show("An unexpected error occurred. The error has been logged. Please contact your administrator.");
            }
        }

        public void PopulateWTaxRate()
        {
            try
            {
                qryWTaxRate = "SELECT wtaxID,wtax_rate FROM tblwtax";
                functions.PopulateDataGridView(dgvWTaxRate, qryWTaxRate);
            }
            catch (Exception ex)
            {
                functions.LogErrorToDb(ex, "frmOtherSetup", "PopulateWTaxRate");
                MessageBox.Show("An unexpected error occurred. The error has been logged. Please contact your administrator.");
            }
        }

        private void btnNewTitle_Click(object sender, EventArgs e)
        {
            titleTemplateDetails = new TitleTemplateDetails(this);
            titleTemplateDetails.FormCode = "CRT";
            titleTemplateDetails.ShowDialog();
        }

        private void dgvTitleTemplate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string colName = dgvTitleTemplate.Columns[e.ColumnIndex].Name;
                switch (colName)
                {
                    case "colEditTT":
                        titleTemplateDetails = new TitleTemplateDetails(this);
                        titleTemplateDetails.TTID = int.Parse(dgvTitleTemplate.Rows[e.RowIndex].Cells[0].Value.ToString());
                        titleTemplateDetails.FormCode = "UPD";
                        titleTemplateDetails.ShowDialog();
                        break;
                    case "colDelTT":
                        if (MessageBox.Show("Delete Title Template " + dgvTitleTemplate.Rows[e.RowIndex].Cells[1].Value.ToString(), var._title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            string voidInvoice = "UPDATE titletemplate SET titleStatus = 1 WHERE " +
                                "titleid = '" + dgvTitleTemplate.Rows[e.RowIndex].Cells[0].Value.ToString() + "'";
                            functions.SaveData(voidInvoice);
                            MessageBox.Show("Title Template " + dgvTitleTemplate.Rows[e.RowIndex].Cells[1].Value.ToString() + " successfully deleted!", var._title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            PopulateTitleTemplates();

                            // Save history for logs
                            functions.SaveData("CALL SP_history('" + Variables.user_unameValue + "','titletemplate_h'," +
                                "'titletemplate','titleid','" + dgvTitleTemplate.Rows[e.RowIndex].Cells[0].Value.ToString() + "')");

                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                functions.LogErrorToDb(ex, "frmOtherSetup", "dgvTitleTemplate_CellContentClick");
                MessageBox.Show("An unexpected error occurred. The error has been logged. Please contact your administrator.");
            }
        }

        private void dgvVATRate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string colName = dgvVATRate.Columns[e.ColumnIndex].Name;
                switch (colName)
                {
                    case "colEditVATR":
                        vATRate = new VATRate(this);
                        vATRate.VRID = int.Parse(dgvVATRate.Rows[e.RowIndex].Cells[0].Value.ToString());
                        vATRate.ShowDialog();
                        break;
                }
            }
            catch (Exception ex)
            {
                functions.LogErrorToDb(ex, "frmOtherSetup", "PopulateTitleTemplates");
                MessageBox.Show("An unexpected error occurred. The error has been logged. Please contact your administrator.");
            }
        }

        private void dgvInterestRate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string colName = dgvInterestRate.Columns[e.ColumnIndex].Name;
                switch (colName)
                {
                    case "colEditIR":
                        interestRate = new InterestRate(this);
                        interestRate.IRID = int.Parse(dgvInterestRate.Rows[e.RowIndex].Cells[0].Value.ToString());
                        interestRate.ShowDialog();
                        break;
                }
            }
            catch (Exception ex)
            {
                functions.LogErrorToDb(ex, "frmOtherSetup", "dgvInterestRate_CellContentClick");
                MessageBox.Show("An unexpected error occurred. The error has been logged. Please contact your administrator.");
            }
        }

        private void dgvWTaxRate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string colName = dgvWTaxRate.Columns[e.ColumnIndex].Name;
                switch (colName)
                {
                    case "colEditWT":
                        wtaxrate = new WTaxRate(this);
                        wtaxrate.WTRID = int.Parse(dgvWTaxRate.Rows[e.RowIndex].Cells[0].Value.ToString());
                        wtaxrate.ShowDialog();
                        break;
                }
            }
            catch (Exception ex)
            {
                functions.LogErrorToDb(ex, "frmOtherSetup", "dgvWTaxRate_CellContentClick");
                MessageBox.Show("An unexpected error occurred. The error has been logged. Please contact your administrator.");
            }
        }
    }
}
