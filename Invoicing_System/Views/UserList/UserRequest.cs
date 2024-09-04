using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoicing_System.Views.UserList
{
    public partial class UserRequest : Form
    {
        public string enteredUserName { get; set; }

        public UserRequest()
        {
            InitializeComponent();
        }

        private void UserRequest_Load(object sender, EventArgs e)
        {
            txtUsername.Text = enteredUserName;
            txtPassword.Focus();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
