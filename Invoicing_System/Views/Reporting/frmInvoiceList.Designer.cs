namespace Invoicing_System.Views.Reporting
{
    partial class frmInvoiceList
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
            this.rptVInvList = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptVInvList
            // 
            this.rptVInvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptVInvList.Location = new System.Drawing.Point(0, 0);
            this.rptVInvList.Name = "rptVInvList";
            this.rptVInvList.ServerReport.BearerToken = null;
            this.rptVInvList.Size = new System.Drawing.Size(1074, 577);
            this.rptVInvList.TabIndex = 0;
            // 
            // frmInvoiceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 577);
            this.Controls.Add(this.rptVInvList);
            this.Name = "frmInvoiceList";
            this.Text = "frmInvoiceList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInvoiceList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptVInvList;
    }
}