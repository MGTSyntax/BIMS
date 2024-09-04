using Invoicing_System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Invoicing_System.Views.UserList
{
    public partial class UserDetails : Form
    {
        Functions functions = new Functions();
        Variables var = new Variables();
        Validations val = new Validations();
        public string pbpwShowVal = "show";
        public string pbcpwShowVal = "show";
        private frmUsers frmUsers;
        private frmLogin frmLogin;

        public UserDetails(frmUsers frmUsers, frmLogin frmLogin)
        {
            InitializeComponent();
            this.frmUsers = frmUsers;
            this.frmLogin = frmLogin;
        }

        private void UserDetails_Load(object sender, EventArgs e)
        {
            pbpwShow.Tag = pbpwShowVal;
            pbcpwShow.Tag = pbcpwShowVal;
            PopCompany();

            var userForm = frmUsers != null ? btnSave.Text = "Save" : btnSave.Text = "Request";
            var loginForm = frmLogin != null ? rbtnAdmin.Enabled = false : rbtnAdmin.Enabled = true;
        }

        private void PopCompany()
        {
            string qryComp = "SELECT UPPER(companyID), companyName FROM tblcompanies WHERE isActive=1";
            functions.PopulateListBox(lvComp, qryComp);
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //private void btnAdd_Click(object sender, EventArgs e)
        //{
        //    string cmbValue = cbComp.SelectedValue.ToString();
        //    int activeStatus = chkIsActive.Checked ? 1 : 0;
        //    int userValue = rbtnUser.Checked ? 1 : 0;
        //    int supervisorValue = rbtnSupervisor.Checked ? 1 : 0;
        //    int adminValue = rbtnAdmin.Checked ? 1 : 0;
        //    int viewingValue = rbtnViewing.Checked ? 1 : 0;

        //    if (!string.IsNullOrEmpty(cmbValue))
        //    {
        //        ListViewItem listViewItem = new ListViewItem(new string[] { cmbValue, activeStatus.ToString(), userValue.ToString(),
        //                supervisorValue.ToString(), adminValue.ToString(), viewingValue.ToString() });
        //        lvComp.Items.Add(listViewItem);

        //        rbtnUser.Checked = false;
        //        rbtnSupervisor.Checked = false;
        //        rbtnAdmin.Checked = false;
        //        rbtnViewing.Checked = false;
        //    }
        //    else MessageBox.Show("Please select a role.");
        //}

        private void txtConfirmPass_Leave(object sender, EventArgs e)
        {
            bool passwordMatch = txtConfirmPass.Text == txtPassword.Text;

            if (passwordMatch)
            {
                lblerrmessage.Text = "";
                txtPassword.BackColor = SystemColors.Window;
                txtConfirmPass.BackColor = SystemColors.Window;
            }
            else
            {
                lblerrmessage.Text = "Password not match.";
                txtPassword.BackColor = Color.Salmon;
                txtConfirmPass.BackColor = Color.Salmon;
            }
        }

        private void pbpwShow_Click(object sender, EventArgs e)
        {
            functions.TogglePassswordVisibility(pbpwShow,txtPassword,pbpwShowVal);
        }

        private void pbcpwShow_Click(object sender, EventArgs e)
        {
            functions.TogglePassswordVisibility(pbcpwShow, txtConfirmPass, pbcpwShowVal);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isStringValid = val.FormStringValidation(GetControlsToValidateString(), errP);
            string selectedCompanies = string.Join(", ", lvComp.CheckedItems.Cast<ListViewItem>().Select(item => { return item.SubItems[1].Text; }));
            int activeStatus = chkIsActive.Checked ? 1 : 0;
            int userValue = rbtnUser.Checked ? 1 : 0;
            int supervisorValue = rbtnSupervisor.Checked ? 1 : 0;
            int adminValue = rbtnAdmin.Checked ? 1 : 0;
            int viewingValue = rbtnViewing.Checked ? 1 : 0;

            if (frmUsers != null)
            {
                if (isStringValid)
                {
                    string saveUser = "INSERT INTO tblusers(user_username,user_password," +
                        "useraccess,isactive,user,supervisor,admin,viewing,date_created) VALUES" +
                        "('" + txtUsername.Text + "','" + txtPassword.Text + "','" + selectedCompanies.ToString() + "'," +
                        "'" + activeStatus.ToString() + "','" + userValue.ToString() + "','" + supervisorValue.ToString() + "'," +
                        "'" + adminValue.ToString() + "','" + viewingValue.ToString() + "', curdate())";
                    functions.SaveData(saveUser);

                    frmUsers.PopulateUsers();

                    MessageBox.Show("New User Successfully Saved!", var._title, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Save history for logs
                    functions.SaveData("CALL SP_history('" + Variables.user_unameValue + "','tblusers_h'," +
                        "'tblusers','tblusers_id',(SELECT MAX(tblusers_id) FROM tblusers))");
                }
            }

            if (frmLogin != null)
            {
                if (isStringValid)
                {
                    string saveUser = "INSERT INTO tblaccess_request(request_username,request_password," +
                        "requestCompAccess,isactive,user,supervisor,admin,viewing,date_requested,accepted) VALUES" +
                        "('" + txtUsername.Text + "','" + txtPassword.Text + "','" + selectedCompanies.ToString() + "'," +
                        "'" + activeStatus.ToString() + "','" + userValue.ToString() + "','" + supervisorValue.ToString() + "'," +
                        "'" + adminValue.ToString() + "','" + viewingValue.ToString() + "',curdate(),0)";
                    functions.SaveData(saveUser);

                    //frmUsers.PopulateRequests();

                    MessageBox.Show("Access request has been sent for approval.", var._title, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Save history for logs
                    functions.SaveData("CALL SP_history('" + Variables.user_unameValue + "','tblaccess_request_h'," +
                        "'tblaccess_request','requestid',(SELECT MAX(requestid) FROM tblaccess_request))");

                    this.Dispose();
                }
            }
        }

        // Get Controls to Validate String Value
        private IEnumerable<Control> GetControlsToValidateString()
        {
            yield return txtUsername;
            yield return txtPassword;

        } // End of GetControlsToValidateString

    }
}
