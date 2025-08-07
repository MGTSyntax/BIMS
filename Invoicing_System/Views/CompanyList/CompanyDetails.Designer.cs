namespace Invoicing_System.Views.CompanyList
{
    partial class CompanyDetails
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyDetails));
            this.label23 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.chkisActive = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApprovedBy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCompanyDesc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCompCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNotedBy = new System.Windows.Forms.TextBox();
            this.btnSaveCompany = new System.Windows.Forms.Button();
            this.companyEP = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtInvNoSeries = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyEP)).BeginInit();
            this.SuspendLayout();
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(7, 10);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(113, 15);
            this.label23.TabIndex = 25;
            this.label23.Text = "COMPANY DETAILS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.pbClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 34);
            this.panel1.TabIndex = 2;
            // 
            // pbClose
            // 
            this.pbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(281, 5);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(25, 24);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbClose.TabIndex = 2;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // chkisActive
            // 
            this.chkisActive.AutoSize = true;
            this.chkisActive.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.chkisActive.Location = new System.Drawing.Point(229, 59);
            this.chkisActive.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkisActive.Name = "chkisActive";
            this.chkisActive.Size = new System.Drawing.Size(70, 19);
            this.chkisActive.TabIndex = 69;
            this.chkisActive.Text = "is Active";
            this.chkisActive.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(16, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 68;
            this.label3.Text = "Approved By";
            // 
            // txtApprovedBy
            // 
            this.txtApprovedBy.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txtApprovedBy.Location = new System.Drawing.Point(19, 200);
            this.txtApprovedBy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtApprovedBy.Name = "txtApprovedBy";
            this.txtApprovedBy.Size = new System.Drawing.Size(274, 23);
            this.txtApprovedBy.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(16, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 15);
            this.label2.TabIndex = 66;
            this.label2.Text = "Company Description";
            // 
            // txtCompanyDesc
            // 
            this.txtCompanyDesc.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txtCompanyDesc.Location = new System.Drawing.Point(19, 126);
            this.txtCompanyDesc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCompanyDesc.Multiline = true;
            this.txtCompanyDesc.Name = "txtCompanyDesc";
            this.txtCompanyDesc.Size = new System.Drawing.Size(274, 50);
            this.txtCompanyDesc.TabIndex = 65;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(16, 60);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 15);
            this.label9.TabIndex = 64;
            this.label9.Text = "Company Code";
            // 
            // txtCompCode
            // 
            this.txtCompCode.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txtCompCode.Location = new System.Drawing.Point(19, 78);
            this.txtCompCode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCompCode.Name = "txtCompCode";
            this.txtCompCode.Size = new System.Drawing.Size(274, 23);
            this.txtCompCode.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(16, 231);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 73;
            this.label1.Text = "Noted By";
            // 
            // txtNotedBy
            // 
            this.txtNotedBy.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txtNotedBy.Location = new System.Drawing.Point(19, 249);
            this.txtNotedBy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNotedBy.Name = "txtNotedBy";
            this.txtNotedBy.Size = new System.Drawing.Size(274, 23);
            this.txtNotedBy.TabIndex = 72;
            // 
            // btnSaveCompany
            // 
            this.btnSaveCompany.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSaveCompany.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveCompany.FlatAppearance.BorderSize = 0;
            this.btnSaveCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveCompany.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCompany.ForeColor = System.Drawing.Color.White;
            this.btnSaveCompany.Location = new System.Drawing.Point(198, 332);
            this.btnSaveCompany.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSaveCompany.Name = "btnSaveCompany";
            this.btnSaveCompany.Size = new System.Drawing.Size(95, 28);
            this.btnSaveCompany.TabIndex = 74;
            this.btnSaveCompany.Text = "Save";
            this.btnSaveCompany.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveCompany.UseVisualStyleBackColor = false;
            this.btnSaveCompany.Click += new System.EventHandler(this.btnSaveCompany_Click);
            // 
            // companyEP
            // 
            this.companyEP.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(16, 281);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 15);
            this.label4.TabIndex = 76;
            this.label4.Text = "Invoice No. Series";
            // 
            // txtInvNoSeries
            // 
            this.txtInvNoSeries.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txtInvNoSeries.Location = new System.Drawing.Point(19, 299);
            this.txtInvNoSeries.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtInvNoSeries.Name = "txtInvNoSeries";
            this.txtInvNoSeries.Size = new System.Drawing.Size(274, 23);
            this.txtInvNoSeries.TabIndex = 75;
            // 
            // CompanyDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 378);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtInvNoSeries);
            this.Controls.Add(this.btnSaveCompany);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNotedBy);
            this.Controls.Add(this.chkisActive);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtApprovedBy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCompanyDesc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCompCode);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CompanyDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.CompanyDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyEP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.CheckBox chkisActive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApprovedBy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCompanyDesc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCompCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNotedBy;
        private System.Windows.Forms.Button btnSaveCompany;
        private System.Windows.Forms.ErrorProvider companyEP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInvNoSeries;
    }
}