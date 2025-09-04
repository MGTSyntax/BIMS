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
            if (Variables.isSupervisorValue)
            {
                lblRole.Text = "Supervisor";
                btnMainCompany.Enabled = true;
                btnMainCompany.Visible = true;
                btnMainTitle.Enabled = true;
                btnMainTitle.Visible = true;
            }
            else if (Variables.isAdminValue)
            {
                lblRole.Text = "Administrator";
                btnMainUsers.Enabled = true;
                btnMainUsers.Visible = true;
                btnUploadBillings.Enabled = true;
                btnUploadBillings.Visible = true;
                btnMainCompany.Enabled = true;
                btnMainCompany.Visible = true;
                btnMainTitle.Enabled = true;
                btnMainTitle.Visible = true;
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
            resetButtons(btnMainDashboard);
            showAnalytics(btnMainDashboard);
        }

        private void btnMainExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMainMonitoring_Click(object sender, EventArgs e)
        {
            resetButtons(btnMainMonitoring);

            pnlMainView.Controls.Clear();
            frmInvoices frmInvoices = new frmInvoices();
            frmInvoices.TopLevel = false;
            pnlMainView.Controls.Add(frmInvoices);

            frmInvoices.FormClosed += (s, args) =>
            {
                showAnalytics(btnMainMonitoring);
            };

            frmInvoices.BringToFront();
            frmInvoices.Show();
        }

        private void btnMainCustomers_Click(object sender, EventArgs e)
        {
            resetButtons(btnMainCustomers);

            pnlMainView.Controls.Clear();
            CustomerSetup Customer = new CustomerSetup();
            Customer.TopLevel = false;
            pnlMainView.Controls.Add(Customer);

            Customer.FormClosed += (s, args) =>
            {
                showAnalytics(btnMainCustomers);
            };

            Customer.BringToFront();
            Customer.Show();
        }

        private void btnMainTitle_Click(object sender, EventArgs e)
        {
            resetButtons(btnMainTitle);

            pnlMainView.Controls.Clear();
            frmOtherSetup frmTitleTemplate = new frmOtherSetup();
            frmTitleTemplate.TopLevel = false;
            pnlMainView.Controls.Add(frmTitleTemplate);

            frmTitleTemplate.FormClosed += (s, args) =>
            {
                showAnalytics(btnMainTitle);
            };

            frmTitleTemplate.BringToFront();
            frmTitleTemplate.Show();
        }

        private void btnMainUsers_Click(object sender, EventArgs e)
        {
            resetButtons(btnMainUsers);

            pnlMainView.Controls.Clear();
            frmUsers frmUsers = new frmUsers();
            frmUsers.TopLevel = false;
            pnlMainView.Controls.Add(frmUsers);

            frmUsers.FormClosed += (s, args) =>
            {
                showAnalytics(btnMainUsers);
            };

            frmUsers.BringToFront();
            frmUsers.Show();
        }

        private void btnMainCompany_Click(object sender, EventArgs e)
        {
            resetButtons(btnMainCompany);

            pnlMainView.Controls.Clear();
            frmCompany frmCompany = new frmCompany();
            frmCompany.TopLevel = false;
            pnlMainView.Controls.Add(frmCompany);

            frmCompany.FormClosed += (s, args) =>
            {
                showAnalytics(btnMainCompany);
            };

            frmCompany.BringToFront();
            frmCompany.Show();
        }

        private void btnMainPayments_Click(object sender, EventArgs e)
        {
            resetButtons(btnMainPayments);

            pnlMainView.Controls.Clear();
            frmPayments frmPayments = new frmPayments();
            frmPayments.TopLevel = false;
            pnlMainView.Controls.Add(frmPayments);

            frmPayments.FormClosed += (s, args) =>
            {
                showAnalytics(btnMainPayments);
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
            resetButtons(btnUploadBillings);

            pnlMainView.Controls.Clear();
            frmUploadBillings frmUploadBillings = new frmUploadBillings();
            frmUploadBillings.TopLevel = false;
            pnlMainView.Controls.Add(frmUploadBillings);

            frmUploadBillings.FormClosed += (s, args) =>
            {
                showAnalytics(btnUploadBillings);
            };

            frmUploadBillings.BringToFront();
            frmUploadBillings.Show();
        }

        private void btnReimBreakDown_Click(object sender, EventArgs e)
        {
            resetButtons(btnReimBreakDown);

            pnlMainView.Controls.Clear();
            frmReimbursements frmReimbursements = new frmReimbursements();
            frmReimbursements.TopLevel = false;
            pnlMainView.Controls.Add(frmReimbursements);

            frmReimbursements.FormClosed += (s, args) =>
            {
                showAnalytics(btnReimBreakDown);
            };

            frmReimbursements.BringToFront();
            frmReimbursements.Show();
        }

        private void btnexporting_Click(object sender, EventArgs e)
        {
            resetButtons(btnexporting);

            pnlMainView.Controls.Clear();
            frmExporting frmExporting = new frmExporting();
            frmExporting.TopLevel = false;
            pnlMainView.Controls.Add(frmExporting);

            frmExporting.Location = new Point(
                (pnlMainView.Width - frmExporting.Width) / 2,
                (pnlMainView.Height - frmExporting.Height) / 2);

            frmExporting.FormClosed += (s, args) =>
            {
                showAnalytics(btnexporting);
            };

            frmExporting.BringToFront();
            frmExporting.Show();
        }

        private void showAnalytics(Button activeButton)
        {
            pnlMainView.Controls.Clear();
            frmAnalytics frmAnalytics = new frmAnalytics();
            frmAnalytics.TopLevel = false;
            pnlMainView.Controls.Add(frmAnalytics);
            frmAnalytics.BringToFront();
            frmAnalytics.Show();

            activeButton.BackColor = Color.Transparent;
            activeButton.ForeColor = Color.White;
        }

        private void resetButtons(Button resetButton)
        {
            btnMainDashboard.BackColor = Color.Transparent;
            btnMainDashboard.ForeColor = Color.White;

            btnMainMonitoring.BackColor = Color.Transparent;
            btnMainMonitoring.ForeColor = Color.White;

            btnReimBreakDown.BackColor = Color.Transparent;
            btnReimBreakDown.ForeColor = Color.White;

            btnMainPayments.BackColor = Color.Transparent;
            btnMainPayments.ForeColor = Color.White;

            btnMainCustomers.BackColor = Color.Transparent;
            btnMainCustomers.ForeColor = Color.White;
            
            btnexporting.BackColor = Color.Transparent;
            btnexporting.ForeColor = Color.White;

            btnMainTitle.BackColor = Color.Transparent;
            btnMainTitle.ForeColor = Color.White;

            btnMainCompany.BackColor = Color.Transparent;
            btnMainCompany.ForeColor = Color.White;

            btnUploadBillings.BackColor = Color.Transparent;
            btnUploadBillings.ForeColor = Color.White;

            btnMainUsers.BackColor = Color.Transparent;
            btnMainUsers.ForeColor = Color.White;

            resetButton.BackColor = SystemColors.Control;
            resetButton.ForeColor = Color.Black;
        }

    }
}
