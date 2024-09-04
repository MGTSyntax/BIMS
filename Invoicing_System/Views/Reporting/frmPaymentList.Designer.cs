namespace Invoicing_System.Views.Reporting
{
    partial class frmPaymentList
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
            this.rptVPaymentList = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptVPaymentList
            // 
            this.rptVPaymentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptVPaymentList.Location = new System.Drawing.Point(0, 0);
            this.rptVPaymentList.Name = "rptVPaymentList";
            this.rptVPaymentList.ServerReport.BearerToken = null;
            this.rptVPaymentList.Size = new System.Drawing.Size(800, 450);
            this.rptVPaymentList.TabIndex = 0;
            // 
            // frmPaymentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptVPaymentList);
            this.Name = "frmPaymentList";
            this.Text = "frmPaymentList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPaymentList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptVPaymentList;
    }
}