using DocumentFormat.OpenXml.Drawing.Charts;
using Invoicing_System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Invoicing_System.Views.InvoiceList
{
    public partial class InvoiceFilter : Form
    {
        private Validations _validations = new Validations();
        private Functions functions = new Functions();
        private Variables var = new Variables();
        private frmInvoices frmInvoices;
        private frmReimbursements frmReimbursements;
        public string formCode { get; set; }

        public InvoiceFilter(frmInvoices frmInvoices)
        {
            InitializeComponent();
            this.frmInvoices = frmInvoices;
        }

        public InvoiceFilter(frmReimbursements frmReimbursements)
        {
            InitializeComponent();
            this.frmReimbursements = frmReimbursements;
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void chkCompany_CheckedChanged(object sender, EventArgs e)
        {
            _validations.isCheckBoxChecked(chkCompany, cbCompany);
        }

        private void chkDet_CheckedChanged(object sender, EventArgs e)
        {
            _validations.isCheckBoxChecked(chkDet, cbDet);
        }

        private void chkInvNo_CheckedChanged(object sender, EventArgs e)
        {
            _validations.isCheckBoxChecked(chkInvNo, txtInvNo);
        }

        private void chkBP_CheckedChanged(object sender, EventArgs e)
        {
            _validations.isCheckBoxChecked(chkBP, panel3);
        }

        private void chkStatus_CheckedChanged(object sender, EventArgs e)
        {
            _validations.isCheckBoxChecked(chkStatus, cbStatus);
        }

        private void InvoiceFilter_Load(object sender, EventArgs e)
        {
            dtpBPFrom.Value = DateTime.Now;
            dtpBPTo.Value = DateTime.Now;

            _validations.isCheckBoxChecked(chkCompany, cbCompany);
            _validations.isCheckBoxChecked(chkDet, cbDet);
            _validations.isCheckBoxChecked(chkInvNo, txtInvNo);
            _validations.isCheckBoxChecked(chkBP, panel3);
            _validations.isCheckBoxChecked(chkStatus, cbStatus);

            PopCompany();
            PopDet();
            PopStatus();
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
            string detStr = "";
            cbDet.Items.Clear();

            if (formCode == "frmInvoices")
            {
                detStr = "SELECT DISTINCT(b.custName), a.customerID FROM invoice_monitoring a " +
                    "LEFT JOIN customerstable b ON a.customerID = b.custID WHERE a.isVoid = 0 AND " +
                    "a.compID IN (" + Variables.User_CompAccess + ") ORDER BY b.custName";
            }
            else if (formCode == "frmReimbursements")
            {
                detStr = "SELECT DISTINCT(cm.custName), im.customerID FROM reimbursement_details rd " +
                    "INNER JOIN invoice_monitoring im ON rd.invoice_number = im.invoiceNumber " +
                    "INNER JOIN customerstable cm ON im.customerID = cm.custID WHERE im.isVoid = 0 AND " +
                    "im.compID IN (" + Variables.User_CompAccess + ") ORDER BY cm.custName";
            }

            string detDM = "custName";
            string detVM = "customerID";
            functions.PopulateComboboxFromDb(cbDet, detStr, detDM, detVM, "Select an option", "0");
        }

        private void PopStatus()
        {
            cbStatus.Items.Add("All");
            cbStatus.Items.Add("Paid");
            cbStatus.Items.Add("Unpaid");
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            if (formCode == "frmInvoices")
            {
                if (!chkCompany.Checked && !chkDet.Checked && !chkInvNo.Checked && !chkBP.Checked && !chkStatus.Checked)
                {
                    MessageBox.Show("No filter to apply!", var._title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string filterInvoices = string.Empty;
                    filterInvoices = "WHERE a.isVoid = 0 AND a.compID IN (" + Variables.User_CompAccess + ") ";
                    if (chkCompany.Checked && cbCompany.SelectedIndex != 0) filterInvoices += "AND a.compID = '" + cbCompany.Text + "'";
                    if (chkDet.Checked && cbDet.SelectedIndex != 0) filterInvoices += "AND a.customerID = '" + cbDet.SelectedValue?.ToString() + "'";
                    if (chkInvNo.Checked && txtInvNo.Text != string.Empty) filterInvoices += "AND a.invoiceNumber = '" + txtInvNo.Text + "'";
                    if (chkBP.Checked) filterInvoices += "AND a.billingPeriod_from >= '" + dtpBPFrom.Value.ToString("yyyy-MM-dd") + "' AND a.billingPeriod_to <= '" + dtpBPTo.Value.ToString("yyyy-MM-dd") + "'";
                    if (chkStatus.Checked && !string.IsNullOrEmpty(cbStatus.Text))
                    {
                        if (cbStatus.SelectedIndex == 0) filterInvoices += "AND isPaid IN ('0','1')";
                        else if (cbStatus.SelectedIndex == 1) filterInvoices += "AND isPaid = 1";
                        else filterInvoices += "AND isPaid = 0";
                    }
                    filterInvoices += " ORDER BY b.custName";
                    frmInvoices.PopInvDGV(filterInvoices);
                    frmInvoices.PopTotals();
                    this.Dispose();
                }
            }
            else if (formCode == "frmReimbursements")
            {
                if (!chkCompany.Checked && !chkDet.Checked && !chkInvNo.Checked && !chkBP.Checked && !chkStatus.Checked)
                {
                    MessageBox.Show("No filter to apply!", var._title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string filterInvoices = string.Empty;
                    filterInvoices = "WHERE b.isVoid = 0 AND b.compID IN (" + Variables.User_CompAccess + ") ";
                    if (chkCompany.Checked && cbCompany.SelectedIndex != 0) filterInvoices += "AND b.compID = '" + cbCompany.Text + "'";
                    if (chkDet.Checked && cbDet.SelectedIndex != 0) filterInvoices += "AND b.customerID = '" + cbDet.SelectedValue?.ToString() + "'";
                    if (chkInvNo.Checked && txtInvNo.Text != string.Empty) filterInvoices += "AND a.invoice_number = '" + txtInvNo.Text + "'";
                    if (chkBP.Checked) filterInvoices += "AND b.billingPeriod_from >= '" + dtpBPFrom.Value.ToString("yyyy-MM-dd") + "' AND b.billingPeriod_to <= '" + dtpBPTo.Value.ToString("yyyy-MM-dd") + "'";
                    if (chkStatus.Checked && !string.IsNullOrEmpty(cbStatus.Text))
                    {
                        if (cbStatus.SelectedIndex == 0) filterInvoices += "AND b.isPaid IN ('0','1')";
                        else if (cbStatus.SelectedIndex == 1) filterInvoices += "AND b.isPaid = 1";
                        else filterInvoices += "AND b.isPaid = 0";
                    }
                    filterInvoices += " ORDER BY c.custName";
                    frmReimbursements.queryData(filterInvoices);
                    //frmInvoices.PopTotals();
                    this.Dispose();
                }
            }
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            chkCompany.Checked = false;
            cbCompany.SelectedIndex = 0;
            chkDet.Checked = false;
            cbDet.SelectedIndex = 0;
            chkInvNo.Checked = false;
            txtInvNo.Clear();
            chkBP.Checked = false;
            dtpBPFrom.Value = DateTime.Now;
            dtpBPTo.Value = DateTime.Now;
            chkStatus.Checked = false;
        }

        private void cbCompany_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbDet_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
