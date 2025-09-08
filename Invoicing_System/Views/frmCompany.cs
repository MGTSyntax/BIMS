using Invoicing_System.Data;
using Invoicing_System.Views.CompanyList;
using Invoicing_System.Views.CustomerList;
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
    public partial class frmCompany : Form
    {
        Functions functions = new Functions();
        private string qryCompanies;
        private CompanyDetails companyDetails;

        public frmCompany()
        {
            InitializeComponent();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCompany_Load(object sender, EventArgs e)
        {
            PopulateCompanies();
        }

        public void PopulateCompanies()
        {
            try
            {
                qryCompanies = "SELECT * FROM tblcompanies ORDER BY companyID";
                functions.PopulateDataGridView(dgvCompanies, qryCompanies);
            }
            catch (Exception ex)
            {
                functions.LogErrorToDb(ex, "frmCompany", "PopulateCompanies");
                MessageBox.Show("An unexpected error occurred. The error has been logged. Please contact your administrator.");
            }
        }

        private void btnNewCompany_Click(object sender, EventArgs e)
        {
            companyDetails = new CompanyDetails(this);
            companyDetails.FormCode = "CRT";
            companyDetails.ShowDialog();
        }

        private void dgvCompanies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string colName = dgvCompanies.Columns[e.ColumnIndex].Name;
                switch (colName)
                {
                    case "colEditComp":
                        companyDetails = new CompanyDetails(this);
                        companyDetails.CompID = int.Parse(dgvCompanies.Rows[e.RowIndex].Cells[0].Value.ToString());
                        companyDetails.FormCode = "UPD";
                        companyDetails.ShowDialog();
                        break;
                }
            }
            catch (Exception ex)
            {
                functions.LogErrorToDb(ex, "frmCompany", "dgvCompanies_CellContentClick");
                MessageBox.Show("An unexpected error occurred. The error has been logged. Please contact your administrator.");
            }
        }
    }
}
