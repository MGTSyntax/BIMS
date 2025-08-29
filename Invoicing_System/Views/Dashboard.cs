using Invoicing_System.Views;
using Invoicing_System.Data;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace Invoicing_System
{
    public partial class Dashboard : Form
    {
        public string user_username { get; set; }

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;

            lblUsername.Text = Variables.user_unameValue;
            if (Variables.isSupervisorValue) lblRole.Text = "Supervisor";
            else if (Variables.isAdminValue)
            {
                lblRole.Text = "Administrator";
                btnMainUsers.Enabled = true;
                btnMainUsers.Visible = true;
            }
            else lblRole.Text = "User";

            pnlMainView.Controls.Clear();
            frmAnalytics frmAnalytics = new frmAnalytics();
            frmAnalytics.TopLevel = false;
            pnlMainView.Controls.Add(frmAnalytics);
            frmAnalytics.BringToFront();
            frmAnalytics.Show();
        }

        private void btnMainDashboard_Click(object sender, EventArgs e)
        {
            showAnalytics();
        }

        private void btnMainExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMainMonitoring_Click(object sender, EventArgs e)
        {
            pnlMainView.Controls.Clear();
            frmInvoices frmInvoices = new frmInvoices();
            frmInvoices.TopLevel = false;
            pnlMainView.Controls.Add(frmInvoices);

            frmInvoices.FormClosed += (s, args) =>
            {
                showAnalytics();
            };

            frmInvoices.BringToFront();
            frmInvoices.Show();
        }

        private void btnMainCustomers_Click(object sender, EventArgs e)
        {
            pnlMainView.Controls.Clear();
            CustomerSetup Customer = new CustomerSetup();
            Customer.TopLevel = false;
            pnlMainView.Controls.Add(Customer);

            Customer.FormClosed += (s, args) =>
            {
                showAnalytics();
            };

            Customer.BringToFront();
            Customer.Show();
        }

        private void btnMainTitle_Click(object sender, EventArgs e)
        {
            pnlMainView.Controls.Clear();
            frmOtherSetup frmTitleTemplate = new frmOtherSetup();
            frmTitleTemplate.TopLevel = false;
            pnlMainView.Controls.Add(frmTitleTemplate);

            frmTitleTemplate.FormClosed += (s, args) =>
            {
                showAnalytics();
            };

            frmTitleTemplate.BringToFront();
            frmTitleTemplate.Show();
        }

        private void btnMainUsers_Click(object sender, EventArgs e)
        {
            pnlMainView.Controls.Clear();
            frmUsers frmUsers = new frmUsers();
            frmUsers.TopLevel = false;
            pnlMainView.Controls.Add(frmUsers);

            frmUsers.FormClosed += (s, args) =>
            {
                showAnalytics();
            };

            frmUsers.BringToFront();
            frmUsers.Show();
        }

        private void btnMainCompany_Click(object sender, EventArgs e)
        {
            pnlMainView.Controls.Clear();
            frmCompany frmCompany = new frmCompany();
            frmCompany.TopLevel = false;
            pnlMainView.Controls.Add(frmCompany);

            frmCompany.FormClosed += (s, args) =>
            {
                showAnalytics();
            };

            frmCompany.BringToFront();
            frmCompany.Show();
        }

        private void btnMainPayments_Click(object sender, EventArgs e)
        {
            pnlMainView.Controls.Clear();
            frmPayments frmPayments = new frmPayments();
            frmPayments.TopLevel = false;
            pnlMainView.Controls.Add(frmPayments);

            frmPayments.FormClosed += (s, args) =>
            {
                showAnalytics();
            };

            frmPayments.BringToFront();
            frmPayments.Show();
        }

        private void btnSignout_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Close();
        }

        private void btnUploadBillings_Click(object sender, EventArgs e)
        {
            pnlMainView.Controls.Clear();
            frmUploadBillings frmUploadBillings = new frmUploadBillings();
            frmUploadBillings.TopLevel = false;
            pnlMainView.Controls.Add(frmUploadBillings);

            frmUploadBillings.FormClosed += (s, args) =>
            {
                showAnalytics();
            };

            frmUploadBillings.BringToFront();
            frmUploadBillings.Show();
        }

        private void btnReimBreakDown_Click(object sender, EventArgs e)
        {
            pnlMainView.Controls.Clear();
            frmReimbursements frmReimbursements = new frmReimbursements();
            frmReimbursements.TopLevel = false;
            pnlMainView.Controls.Add(frmReimbursements);

            frmReimbursements.FormClosed += (s, args) =>
            {
                showAnalytics();
            };

            frmReimbursements.BringToFront();
            frmReimbursements.Show();
        }

        private void btnexporting_Click(object sender, EventArgs e)
        {
            pnlMainView.Controls.Clear();
            frmExporting frmExporting = new frmExporting();
            frmExporting.TopLevel = false;
            pnlMainView.Controls.Add(frmExporting);

            frmExporting.Location = new Point(
                (pnlMainView.Width - frmExporting.Width) / 2,
                (pnlMainView.Height - frmExporting.Height) / 2);

            frmExporting.FormClosed += (s, args) =>
            {
                showAnalytics();
            };

            frmExporting.BringToFront();
            frmExporting.Show();
        }

        private void showAnalytics()
        {
            pnlMainView.Controls.Clear();
            frmAnalytics frmAnalytics = new frmAnalytics();
            frmAnalytics.TopLevel = false;
            pnlMainView.Controls.Add(frmAnalytics);
            frmAnalytics.BringToFront();
            frmAnalytics.Show();
        }
    }
}
