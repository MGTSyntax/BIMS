using Invoicing_System.Data;
using Invoicing_System.Views.Monitoring;
using Invoicing_System.Views.UserList;
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
    public partial class frmUsers : Form
    {
        Functions functions = new Functions();
        private string qryUsers;
        private string qryRequests;
        private UserDetails userDetails;

        public frmUsers()
        {
            InitializeComponent();
            //dgvUser.CellFormatting += dgvUser_CellFormatting;
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            PopulateUsers();
            PopulateRequests();
        }

        public void PopulateUsers()
        {
            qryUsers = "SELECT * FROM tblusers ORDER BY user_username";
            functions.PopulateDataGridView(dgvUser, qryUsers);
        }

        public void PopulateRequests()
        {
            qryRequests = "SELECT * FROM tblaccess_request ORDER BY date_requested";
            functions.PopulateDataGridView(dgvRequests, qryRequests);
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            userDetails = new UserDetails(this, null);
            userDetails.ShowDialog();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvUser_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvUser.Columns[e.ColumnIndex].Name == "coluser_password")
            {
                if (e.Value != null)
                {
                    e.Value = new string('\u25CF', e.Value.ToString().Length);
                    e.FormattingApplied = true;
                }
            }
        }

        private void dgvRequests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
