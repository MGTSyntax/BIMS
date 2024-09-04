using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoicing_System.Data.CustomerList
{
    internal class Customers : Variables
    {
        public void LoadCustomers(DataGridView dgvCustomers, string getCustomers)
        {
            try
            {
                dgvCustomers.Rows.Clear();
                cmd = new MySqlCommand(getCustomers, con);
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dgvCustomers.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(),
                        dr[4].ToString(), dr[5].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Can't load Customers! Please ask your administrator.\n" + ex.Message, _title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw;
            }
        }
    }
}
