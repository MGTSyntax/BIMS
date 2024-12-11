using Invoicing_System.Data;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Invoicing_System.Views
{
    public partial class frmUploadBillings : Form
    {
        Functions functions = new Functions();
        Variables var = new Variables();

        public frmUploadBillings()
        {
            InitializeComponent();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Excel Files|*.xlsx;*.xls";
                ofd.Title = "Select and Excel File";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtFilePath.Text = ofd.FileName;

                    string filePath = txtFilePath.Text;

                    if (string.IsNullOrWhiteSpace(filePath) || !File.Exists(filePath))
                    {
                        MessageBox.Show("Please select a valid Excel File.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    try
                    {
                        functions.ReadExcelFile(filePath, dgvUploadedBM);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occured while displaying the file:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ready to upload?", "UPLOAD", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                foreach (DataGridViewRow dgvRow in dgvUploadedBM.Rows)
                {
                    string customerID = dgvRow.Cells[0].Value.ToString();
                    string invoiceNumber = dgvRow.Cells[2].Value.ToString();
                    string billingPeriod_from = Convert.ToDateTime(dgvRow.Cells[3].Value).ToString("yyyy-MM-dd");
                    string billingPeriod_to = Convert.ToDateTime(dgvRow.Cells[4].Value).ToString("yyyy-MM-dd");
                    string reimbursement = dgvRow.Cells[5].Value.ToString().Replace(",", "");
                    string agencyFee = dgvRow.Cells[6].Value.ToString().Replace(",", "");
                    string otherBillable = dgvRow.Cells[7].Value.ToString().Replace(",", "");
                    string vat = dgvRow.Cells[8].Value.ToString().Replace(",", "");
                    string nonDeductible = dgvRow.Cells[9].Value.ToString().Replace(",", "");
                    string isVoid = dgvRow.Cells[10].Value.ToString() == "True" ? "1" : "0";
                    string isPaid = dgvRow.Cells[11].Value.ToString() == "True" ? "1" : "0";
                    string preparedBy = dgvRow.Cells[12].Value.ToString();
                    string shippingDate = Convert.ToDateTime(dgvRow.Cells[13].Value).ToString("yyyy-MM-dd");
                    string dueDate = Convert.ToDateTime(dgvRow.Cells[14].Value).ToString("yyyy-MM-dd");
                    string balanceAmt = dgvRow.Cells[15].Value.ToString().Replace(",", "");
                    string p_invoiceBalPay = dgvRow.Cells[16].Value.ToString().Replace(",", "");
                    string p_datePaid = Convert.ToDateTime(dgvRow.Cells[17].Value).ToString("yyyy-MM-dd");
                    string p_orNum = dgvRow.Cells[18].Value.ToString();
                    string p_arNum = dgvRow.Cells[19].Value.ToString();
                    string p_checkNum = dgvRow.Cells[21].Value.ToString();
                    string p_bank = dgvRow.Cells[20].Value.ToString();
                    string compID = dgvRow.Cells[22].Value.ToString();
                    string titleTemplate = "SECURITY SERVICES RENDERED FOR THE PERIOD";

                    string createInvoice = "INSERT INTO invoice_monitoring(reimbursement,agencyFee,vat,otherBillable,customerID," +
                        "titleTemplate,billingPeriod_from,billingPeriod_to,invoiceNumber,notes,compID,nonDeductible,preparedBy," +
                        "isVoid,printStatus,isPaid) " +
                        "VALUES('" + reimbursement + "'," +
                        "'" + agencyFee + "'," +
                        "'" + vat + "'," +
                        "'" + otherBillable + "'," +
                        "'" + customerID + "'," +
                        "'" + titleTemplate + "'," +
                        "'" + billingPeriod_from + "'," +
                        "'" + billingPeriod_to + "'," +
                        "'" + invoiceNumber + "'," +
                        "''," +
                        "'" + compID + "'," +
                        "'" + nonDeductible + "'," +
                        "'" + preparedBy + "'," +
                        "'" + isVoid + "'," +
                        "'0'," +
                        "'" + isPaid + "')";
                    functions.SaveData(createInvoice);

                    string addInterest = "INSERT INTO interest_monitoring(invoiceNum,customerID,shippingDate," +
                            "dueDate,balanceAmt,aging,interestAmount,compID,isVoid,isPaid) " +
                            "VALUES('" + invoiceNumber + "'," +
                            "'" + customerID + "'," +
                            "'" + shippingDate + "'," +
                            "'" + dueDate + "'," +
                            "'" + balanceAmt + "'," +
                            "'0'," +
                            "'0'," +
                            "'" + compID + "'," +
                            "'" + isVoid + "'," +
                            "'" + isPaid + "')";
                    functions.SaveData(addInterest);

                    string addPayment = "INSERT INTO tblpayment(p_invoiceNum,p_invoiceBalPay,p_datePaid," +
                    "p_customer,p_orNum,p_arNum,p_bank,p_checkNum) " +
                    "VALUES('" + invoiceNumber + "'," +
                    "'" + p_invoiceBalPay + "'," +
                    "'" + p_datePaid + "'," +
                    "'" + customerID + "'," +
                    "'" + p_orNum + "'," +
                    "'" + p_arNum + "'," +
                    "'" + p_bank + "'," +
                    "'" + p_checkNum + "')";
                    functions.SaveData(addPayment);

                    MessageBox.Show("Invoices Successfully Uploaded!", var._title, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Save history for logs
                    //functions.SaveData("CALL SP_history('" + Variables.user_unameValue + "','invoice_monitoring_h'," +
                    //    "'invoice_monitoring','invoicesid',(SELECT MAX(invoicesid) FROM invoice_monitoring))");
                }
            }
        }
    }
}
