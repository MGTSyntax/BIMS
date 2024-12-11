using Invoicing_System.Views;
using Invoicing_System.Data;
using System;
using System.Windows.Forms;

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
            pnlMainView.Controls.Clear();
            frmAnalytics frmAnalytics = new frmAnalytics();
            frmAnalytics.TopLevel = false;
            pnlMainView.Controls.Add(frmAnalytics);
            frmAnalytics.BringToFront();
            frmAnalytics.Show();
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
            frmInvoices.BringToFront();
            frmInvoices.Show();
        }

        private void btnMainCustomers_Click(object sender, EventArgs e)
        {
            pnlMainView.Controls.Clear();
            CustomerSetup Customer = new CustomerSetup();
            Customer.TopLevel = false;
            pnlMainView.Controls.Add(Customer);
            Customer.BringToFront();
            Customer.Show();
        }

        private void btnMainTitle_Click(object sender, EventArgs e)
        {
            pnlMainView.Controls.Clear();
            frmOtherSetup frmTitleTemplate = new frmOtherSetup();
            frmTitleTemplate.TopLevel = false;
            pnlMainView.Controls.Add(frmTitleTemplate);
            frmTitleTemplate.BringToFront();
            frmTitleTemplate.Show();
        }

        private void btnMainUsers_Click(object sender, EventArgs e)
        {
            pnlMainView.Controls.Clear();
            frmUsers frmUsers = new frmUsers();
            frmUsers.TopLevel = false;
            pnlMainView.Controls.Add(frmUsers);
            frmUsers.BringToFront();
            frmUsers.Show();
        }

        private void btnMainCompany_Click(object sender, EventArgs e)
        {
            pnlMainView.Controls.Clear();
            frmCompany frmCompany = new frmCompany();
            frmCompany.TopLevel = false;
            pnlMainView.Controls.Add(frmCompany);
            frmCompany.BringToFront();
            frmCompany.Show();
        }

        private void btnMainPayments_Click(object sender, EventArgs e)
        {
            pnlMainView.Controls.Clear();
            frmPayments frmPayments = new frmPayments();
            frmPayments.TopLevel = false;
            pnlMainView.Controls.Add(frmPayments);
            frmPayments.BringToFront();
            frmPayments.Show();
        }

        private void btnSignout_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Dispose();
        }

        private void btnUploadBillings_Click(object sender, EventArgs e)
        {
            pnlMainView.Controls.Clear();
            frmUploadBillings frmUploadBillings = new frmUploadBillings();
            frmUploadBillings.TopLevel = false;
            pnlMainView.Controls.Add(frmUploadBillings);
            frmUploadBillings.BringToFront();
            frmUploadBillings.Show();
        }
    }
}
