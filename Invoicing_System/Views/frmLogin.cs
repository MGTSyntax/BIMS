using Invoicing_System.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Invoicing_System.Views.UserList;
using System.Security.Cryptography;
using System.Diagnostics;

namespace Invoicing_System.Views
{
    public partial class frmLogin : Form
    {
        Functions functions = new Functions();
        private Dashboard dashboard;
        //private UserRequest userRequest;
        //private UserDetails userDetails;
        //private string localServerPath;
        //private string localExePath;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string enteredUsername = txtUsename.Text.ToUpper();
            string enteredPassword = txtPassword.Text;

            string qryUser = "SELECT * FROM tblusers WHERE " +
                "user_username = @Username AND " +
                "user_password = @Password AND " +
                "isactive = 1";

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@Username", enteredUsername },
                { "@Password", enteredPassword }
            };

            var userexists = functions.SelectDataParameters(qryUser, "tblusers", parameters);
            if (userexists.Rows.Count > 0)
            {
                //username value
                Variables.user_unameValue = enteredUsername;
                //user company value
                Variables.User_CompAccess = functions.ConvertCompAccess(userexists.Rows[0]["useraccess"].ToString());
                //user status
                Variables.isActiveValue = Convert.ToBoolean(userexists.Rows[0]["isactive"].ToString());
                //supervisory value
                Variables.isSupervisorValue = Convert.ToBoolean(userexists.Rows[0]["supervisor"].ToString());
                //admin value
                Variables.isAdminValue = Convert.ToBoolean(userexists.Rows[0]["admin"].ToString());
                //viewing only value
                Variables.isViewingValue = Convert.ToBoolean(userexists.Rows[0]["viewing"].ToString());

                dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();
            }
            else lblerrormsg.Text = "Login failed. Invalid username or password.";
        }

        //// Helper method to hash the password using SHA256
        //private static string GetHashedPassword(string password)
        //{
        //    using (SHA256 sha256 = SHA256.Create())
        //    {
        //        byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
        //        StringBuilder builder = new StringBuilder();
        //        foreach (byte b in bytes)
        //        {
        //            builder.Append(b.ToString("x2"));
        //        }
        //        return builder.ToString();
        //    }
        //}

        private void txtUsename_Click(object sender, EventArgs e)
        {
            txtUsename.Focus();
            txtUsename.SelectAll();
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Focus();
            txtPassword.SelectAll();
        }

        private void txtUsename_TextChanged(object sender, EventArgs e)
        {
            lblerrormsg.Text = "";
        }

        private void llblFPwd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("This feature is in working progress. Please check back later.", "In Progress", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //userRequest = new UserRequest();
            //userRequest.enteredUserName = txtUsename.Text;
            //userRequest.ShowDialog();
        }

        private void llblSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("This feature is in working progress. Please check back later.", "In Progress", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //userDetails = new UserDetails(null, this);
            //userDetails.ShowDialog();
        }

        private void CheckForVersionUpdate()
        {
            string updatedExePath = functions.GetRecordString("SELECT updateLink FROM systemsettings");
            if (string.IsNullOrEmpty(updatedExePath))
                return;

            string applicationPath = Application.ExecutablePath;
            FileVersionInfo currentAssemblyInfo = FileVersionInfo.GetVersionInfo(applicationPath);

            if (File.Exists(updatedExePath))
            {
                FileVersionInfo updatedAssemblyInfo = FileVersionInfo.GetVersionInfo(updatedExePath);
                if (updatedAssemblyInfo.FileVersion.CompareTo(currentAssemblyInfo.FileVersion) > 0)
                {
                    if (MessageBox.Show("New update found. " + Environment.NewLine +
                        "Do you want to update your system to the latest version?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == DialogResult.Yes)
                    {
                        string currentApplicationPath = applicationPath + "Old";
                        if (File.Exists(currentApplicationPath))
                        {
                            File.Delete(currentApplicationPath);
                        }

                        File.Move(applicationPath, currentApplicationPath);
                        File.Copy(updatedExePath, applicationPath, true);
                        Process.Start(applicationPath);
                        Application.Exit();
                    }
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // Check for updates when the login form loads
            CheckForVersionUpdate();
        }

    }
}
