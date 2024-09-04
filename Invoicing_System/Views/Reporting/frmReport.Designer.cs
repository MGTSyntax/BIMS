namespace Invoicing_System.Views
{
    partial class frmReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rptVInvoice = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptVInvoice
            // 
            this.rptVInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptVInvoice.Location = new System.Drawing.Point(0, 0);
            this.rptVInvoice.Name = "rptVInvoice";
            this.rptVInvoice.PageCountMode = Microsoft.Reporting.WinForms.PageCountMode.Actual;
            this.rptVInvoice.ServerReport.BearerToken = null;
            this.rptVInvoice.Size = new System.Drawing.Size(933, 519);
            this.rptVInvoice.TabIndex = 1;
            this.rptVInvoice.PrintingBegin += new Microsoft.Reporting.WinForms.ReportPrintEventHandler(this.rptVInvoice_PrintingBegin);
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.rptVInvoice);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRINT PREVIEW";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer rptVInvoice;
    }
}