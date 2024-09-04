using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Invoicing_System.Data.Monitoring
{
    internal class Invoices : Variables
    {
        public void LoadInvoicesDataReader(DataGridView dgvInvoices, string getInvoices)
        {
            try
            {
                dgvInvoices.Rows.Clear();
                cmd = new MySqlCommand(getInvoices, con);
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    // Create Array to Store Column Values
                    object[] drvalues = new object[dr.FieldCount];
                    dr.GetValues(drvalues);

                    // Add New Row to the DataGridView
                    dgvInvoices.Rows.Add(drvalues.ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Can't load Invoices! Please ask your administrator.\n" + ex.Message, _title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw;
            }
        }

        public void LoadInvoicesDataAdapter(DataGridView dgvInvoices, string getInvoices)
        {
            try
            {
                cmd = new MySqlCommand(getInvoices, con);
                con.Open();
                da = new MySqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);

                con.Close();
                dgvInvoices.DataSource = dt;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Can't load Invoices! Please ask your administrator.\n" + ex.Message, _title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw;
            }
        }
    }
}
