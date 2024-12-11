using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Text.RegularExpressions;
using Invoicing_System.Reports;
using Microsoft.Reporting.WinForms;
using System.Runtime.Remoting.Lifetime;
using System.IO;
using OfficeOpenXml;
using Google.Protobuf.WellKnownTypes;
using static OfficeOpenXml.ExcelErrorValue;

namespace Invoicing_System.Data
{
    public class Functions : Variables
    {
        public void SaveData(string str)
        {
            try
            {
                using (cmd = new MySqlCommand(str, con))
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                //Log.Error("Problem in saving data", ex);
                MessageBox.Show("Problem in Saving data! Please ask your administrator.\n" + ex.Message, _title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
        } // End of SaveData

        public DataTable SelectData(string query, string dtds)
        {
            try
            {
                con.Open();
                ds = new DataSet();
                da = new MySqlDataAdapter(query, con);
                da.Fill(ds, dtds);
                con.Close();
                return ds.Tables[dtds];
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Problem in Getting Data! Please ask your administrator.\n" + ex.Message, _title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
        } // End of SelectData

        public DataTable SelectDataParameters(string query, string dtds, Dictionary<string, object> parameters = null)
        {
            try
            {
                con.Open();
                ds = new DataSet();
                da = new MySqlDataAdapter(query, con);

                //Add parameters to the command if they are provided
                if (parameters != null)
                {
                    foreach (var parameter in parameters)
                    {
                        da.SelectCommand.Parameters.AddWithValue(parameter.Key, parameter.Value);
                    }
                }

                da.Fill(ds, dtds);
                con.Close();
                return ds.Tables[dtds];
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Problem in Getting Data! Please ask your administrator.\n" + ex.Message, _title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
        } // End of SelectData

        public void PopulateComboboxFromDb(ComboBox cmb, string qry, string displayMem, string valueMem, object customDisplay, string customValue)
        {
            try
            {
                con.Open();
                cmd = new MySqlCommand(qry, con);
                da = new MySqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                con.Close();

                // Creating index 0
                DataRow dr = dt.NewRow();
                dr[displayMem] = customDisplay;
                dr[valueMem] = customValue;

                // Insert index 0
                dt.Rows.InsertAt(dr, 0);

                cmb.DataSource = dt;
                cmb.DisplayMember = displayMem;
                cmb.ValueMember = valueMem;
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Problem in Loading data! Please ask your administrator.\n" + ex.Message, _title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
        } // End of PopulateComboboxFromDb

        public void ConvertToDecimal(Control control)
        {
            decimal number = decimal.Parse(control.Text);
            string formattedNumber = number.ToString("N2");
            control.Text = formattedNumber;
        } // End of ConvertToDecimal

        public void PopulateDataGridView(DataGridView dgv, string query)
        {
            try
            {
                dgv.Rows.Clear();
                con.Open();
                cmd = new MySqlCommand(query, con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    // Create Array to Store Column Values
                    object[] drValues = new object[dr.FieldCount];
                    //dr.GetValues(drValues);

                    // Iterate over readers columns
                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        // Check if the Column is of type DateTime
                        if (dr.GetFieldType(i) == typeof(DateTime))
                        {
                            // Format the DateTime value to display only the date portion
                            drValues[i] = ((DateTime)dr.GetValue(i)).ToShortDateString();
                        }
                        else drValues[i] = dr.GetValue(i); // Retrieve the value for others

                        // Check if the Column is of Boolean
                        if (dr.GetFieldType(i) == typeof(bool))
                        {
                            // Get the Boolean value
                            drValues[i] = (dr.GetBoolean(i)) ? true : false;
                        }
                        else drValues[i] = dr.GetValue(i); // Retrieve the value for others
                    }

                    // Add New Row to DataGridView
                    dgv.Rows.Add(drValues);
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Problem in Loading data! Please ask your administrator.\n" + ex.Message, _title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
            finally
            {
                dr.Close();
                con.Close();
            }
        } // End of PopulateDataGridView

        public void PopulateListBox(ListView listview, string query)
        {
            listview.Items.Clear();
            con.Open();
            cmd = new MySqlCommand(query,con);
            using (dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem();

                    // Create Array to Store Column Values
                    //object[] drValues = new object[dr.FieldCount];

                    // Iterate over readers columns
                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        //object value = dr.GetValue(i);
                        item.SubItems.Add(dr[i].ToString());
                    }

                    // Add the ListViewItem to the ListView
                    listview.Items.Add(item);
                }
            }
            con.Close();
        }

        public string ConvertCurrencyToWords(decimal amount)
        {
            string[] units = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
            string[] teens = { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
            string[] tens = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
            string[] denom = { "", "Thousand", "Million", "Billion", "Trillion" };

            // Edge case: Zero amount
            if (amount == 0)
                return "Zero Pesos";

            int pesos = (int)Math.Floor(amount);
            int cents = (int)Math.Floor((amount - pesos) * 100);

            string pesosInWords = "";
            string centsInWords = "";

            // Convert pesos to words
            if (pesos > 0)
            {
                int groupCount = 0;
                while (pesos > 0)
                {
                    int threeDigits = pesos % 1000;
                    if (threeDigits > 0)
                    {
                        string groupWords = "";

                        //int hundreds = (int)Math.Floor((decimal)threeDigits / 100);
                        int hundreds = threeDigits / 100;
                        int tensAndUnits = threeDigits % 100;

                        if (hundreds > 0)
                            groupWords += units[hundreds] + " Hundred ";

                        if (tensAndUnits >= 20)
                        {
                            //groupWords += tens[(int)Math.Floor((decimal)tensAndUnits / 10)] + " ";
                            groupWords += tens[tensAndUnits / 10] + " ";

                            //if (tensAndUnits % 10 != 0)
                            //{
                            //    groupWords += " " + units[tensAndUnits % 10];
                            //}
                            groupWords += units[tensAndUnits % 10] + " ";
                            //groupWords += " " + units[tensAndUnits % 10];
                        }
                        else if (tensAndUnits >= 10)
                        {
                            groupWords += teens[tensAndUnits % 10] + " ";
                        }
                        else if (tensAndUnits > 0)
                        {
                            groupWords += units[tensAndUnits] + " ";
                        }

                        groupWords += denom[groupCount];

                        if (!string.IsNullOrEmpty(pesosInWords))
                        {
                            // Add a space between groups if the current group is not empty
                            groupWords += " ";
                            //groupWords = " " + groupWords;
                        }

                        pesosInWords = groupWords + pesosInWords;
                    }

                    //pesos = (int)Math.Floor((decimal)pesos / 1000);
                    pesos /= 1000;
                    groupCount++;
                }
            }
            else
            {
                pesosInWords = "Zero";
            }

            // Convert cents to words
            if (cents > 0)
            {
                //centsInWords = " and " + cents.ToString("D2") + "/100";
                centsInWords = " and " + ConvertToWords(cents) + " Centavos";
            }

            // Combine pesos and cents in words
            string result = pesosInWords + " Pesos " + centsInWords;
            return result.Trim();
        }

        //Cents to Words
        private string ConvertToWords(int number)
        {
            if (number == 0)
                return "Zero";

            string[] units = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
            string[] teens = { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
            string[] tens = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

            if (number < 10)
            {
                return units[number];
            }
            else if (number < 20)
            {
                return teens[number - 10];
            }
            else if (number < 100)
            {
                return tens[number / 10] + " " + units[number % 10];
            }
            else if (number < 1000)
            {
                return units[number / 100] + " Hundred " + ConvertToWords(number % 100);
            }
            else if (number < 1000000)
            {
                return ConvertToWords(number / 1000) + " Thousand " + ConvertToWords(number % 1000);
            }
            else if (number < 1000000000)
            {
                return ConvertToWords(number / 1000000) + " Million " + ConvertToWords(number % 1000000);
            }
            else
            {
                return ConvertToWords(number / 1000000000) + " Billion " + ConvertToWords(number % 1000000000);
            }
        }

        public string ConvertCompAccess(string str)
        {
            string[] values = str.Split(new char[] { ',' });

            for (int i = 0; i < values.Length; i++)
            {
                values[i] = "'" + values[i] + "'";
            }

            string result = string.Join(",", values);
            return result;
        }

        public void TogglePassswordVisibility(PictureBox pbobj, TextBox txtobj, string tagval)
        {
            if (pbobj.Tag != null && pbobj.Tag.Equals(tagval))
            {
                pbobj.Image = Properties.Resources.hidden;
                txtobj.UseSystemPasswordChar = false;
                pbobj.Tag = "hide";
            }
            else
            {
                pbobj.Image = Properties.Resources.view;
                txtobj.UseSystemPasswordChar = true;
                pbobj.Tag = "show";
            }
        }

        public string GetRecordString(string sqlCommandTxt)
        {
            string retVal = "";

            try
            {
                con.Open();
                using (MySqlCommand scalarCommand = new MySqlCommand(sqlCommandTxt, con))
                {
                    object result = scalarCommand.ExecuteScalar();
                    retVal = (result == null || DBNull.Value.Equals(result)) ? "" : result.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
            finally { con.Close(); }

            return retVal;
        }

        public void ReadExcelFile(string filePath, DataGridView dgv)
        {
            using (ExcelPackage package = new ExcelPackage(new FileInfo(filePath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                // Validate worksheet dimensions
                if (worksheet.Dimension == null) throw new Exception("The Excel file is empty or has no readable data.");

                // Start reading from row 2 (A2) 
                for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                {
                    DataGridViewRow dgvRow = new DataGridViewRow();
                    dgvRow.CreateCells(dgv);

                    for (int col = 1; col <= worksheet.Dimension.End.Column; col++)
                    {
                        var cellValue = worksheet.Cells[row, col].Text.Trim();

                        if (string.Equals(cellValue, "Yes", StringComparison.OrdinalIgnoreCase)) cellValue = "True";
                        else if (string.Equals(cellValue, "No", StringComparison.OrdinalIgnoreCase)) cellValue = "False";

                        dgvRow.Cells[col - 1].Value = cellValue;
                    }

                    dgv.Rows.Add(dgvRow);
                }
            }
        }
    }
}
