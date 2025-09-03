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

namespace Invoicing_System.Views.CustomerList
{
    public partial class CustomerFilter : Form
    {
        private Validations _validations = new Validations();
        private Functions functions = new Functions();
        private Variables var = new Variables();
        private CustomerSetup customerSetup;

        public CustomerFilter(CustomerSetup customerSetup)
        {
            InitializeComponent();
            this.customerSetup = customerSetup;
        }

        private void CustomerFilter_Load(object sender, EventArgs e)
        {
            _validations.isCheckBoxChecked(chkCompany, cbCompany);
            _validations.isCheckBoxChecked(chkDet, cbDet);

            PopCompany();
            PopDet();
        }

        private void PopCompany()
        {
            cbCompany.Items.Clear();
            string companyStr = "SELECT * FROM tblcompanies";
            string companyDM = "companyID";
            string companyVM = "id";
            functions.PopulateComboboxFromDb(cbCompany, companyStr, companyDM, companyVM, "Select an option", "0");
        }

        private void PopDet()
        {
            cbDet.Items.Clear();
            string detStr = "SELECT custName,custID FROM customerstable " +
                "WHERE isDeleted = 0 AND compID IN (" + Variables.User_CompAccess + ") ORDER BY custName";
            string detDM = "custName";
            string detVM = "custID";
            functions.PopulateComboboxFromDb(cbDet, detStr, detDM, detVM, "Select an option", "0");
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            chkCompany.Checked = false;
            cbCompany.SelectedIndex = 0;
            chkDet.Checked = false;
            cbDet.SelectedIndex = 0;
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            if (!chkCompany.Checked && !chkDet.Checked)
            {
                MessageBox.Show("No filter to apply!", var._title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string filterCust = string.Empty;
                string qryCust = "SELECT custID, clientName, custName, contactPerson, cpPosition, emailAddress, custagencyFee, " +
                "isvatable, hasInterest, otherBillAmt, UPPER(compID) as compID, tin, telno FROM customerstable";
                filterCust = "WHERE isDeleted = 0 AND compID IN (" + Variables.User_CompAccess + ") ";
                if (chkCompany.Checked && cbCompany.SelectedIndex != 0) filterCust += "AND compID = '" + cbCompany.Text + "'";
                if (chkDet.Checked && cbDet.SelectedIndex != 0) filterCust += "AND custID = '" + cbDet.SelectedValue?.ToString() + "'";
                filterCust += " ORDER BY custName";
                customerSetup.PopCustDGV(qryCust, filterCust);
                customerSetup.PopTotal();
                this.Dispose();
            }
        }

        private void chkCompany_CheckedChanged(object sender, EventArgs e)
        {
            _validations.isCheckBoxChecked(chkCompany, cbCompany);
        }

        private void chkDet_CheckedChanged(object sender, EventArgs e)
        {
            _validations.isCheckBoxChecked(chkDet, cbDet);
        }
    }
}
