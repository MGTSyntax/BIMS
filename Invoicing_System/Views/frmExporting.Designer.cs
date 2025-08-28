namespace Invoicing_System.Views
{
    partial class frmExporting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExporting));
            this.label23 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.btngenerate = new System.Windows.Forms.Button();
            this.chkBP = new System.Windows.Forms.CheckBox();
            this.txtInvNo = new System.Windows.Forms.TextBox();
            this.chkInvNo = new System.Windows.Forms.CheckBox();
            this.cbDet = new System.Windows.Forms.ComboBox();
            this.chkDet = new System.Windows.Forms.CheckBox();
            this.cbCompany = new System.Windows.Forms.ComboBox();
            this.chkCompany = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtpBPTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpBPFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.label23.Size = new System.Drawing.Size(96, 15);
            this.label23.TabIndex = 24;
            this.label23.Text = "EXPORT REPORT";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.pbClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 34);
            this.panel1.TabIndex = 4;
            // 
            // pbClose
            // 
            this.pbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(561, 5);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(25, 24);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbClose.TabIndex = 1;
            this.pbClose.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btngenerate);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(590, 477);
            this.panel2.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(164, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(378, 28);
            this.comboBox1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Select Report File";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbStatus);
            this.groupBox1.Controls.Add(this.chkStatus);
            this.groupBox1.Controls.Add(this.chkBP);
            this.groupBox1.Controls.Add(this.txtInvNo);
            this.groupBox1.Controls.Add(this.chkInvNo);
            this.groupBox1.Controls.Add(this.cbDet);
            this.groupBox1.Controls.Add(this.chkDet);
            this.groupBox1.Controls.Add(this.cbCompany);
            this.groupBox1.Controls.Add(this.chkCompany);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Location = new System.Drawing.Point(12, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 289);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(159, 152);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(194, 28);
            this.cbStatus.TabIndex = 22;
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.Location = new System.Drawing.Point(32, 154);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(69, 24);
            this.chkStatus.TabIndex = 21;
            this.chkStatus.Text = "Status";
            this.chkStatus.UseVisualStyleBackColor = true;
            // 
            // btngenerate
            // 
            this.btngenerate.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btngenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngenerate.FlatAppearance.BorderSize = 0;
            this.btngenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngenerate.ForeColor = System.Drawing.Color.White;
            this.btngenerate.Location = new System.Drawing.Point(205, 411);
            this.btngenerate.Name = "btngenerate";
            this.btngenerate.Size = new System.Drawing.Size(155, 41);
            this.btngenerate.TabIndex = 20;
            this.btngenerate.Text = "Generate";
            this.btngenerate.UseVisualStyleBackColor = false;
            // 
            // chkBP
            // 
            this.chkBP.AutoSize = true;
            this.chkBP.Location = new System.Drawing.Point(32, 192);
            this.chkBP.Name = "chkBP";
            this.chkBP.Size = new System.Drawing.Size(119, 24);
            this.chkBP.TabIndex = 19;
            this.chkBP.Text = "Billing Period";
            this.chkBP.UseVisualStyleBackColor = true;
            // 
            // txtInvNo
            // 
            this.txtInvNo.Location = new System.Drawing.Point(159, 115);
            this.txtInvNo.Name = "txtInvNo";
            this.txtInvNo.Size = new System.Drawing.Size(194, 27);
            this.txtInvNo.TabIndex = 17;
            // 
            // chkInvNo
            // 
            this.chkInvNo.AutoSize = true;
            this.chkInvNo.Location = new System.Drawing.Point(32, 117);
            this.chkInvNo.Name = "chkInvNo";
            this.chkInvNo.Size = new System.Drawing.Size(106, 24);
            this.chkInvNo.TabIndex = 16;
            this.chkInvNo.Text = "Invoice No.";
            this.chkInvNo.UseVisualStyleBackColor = true;
            // 
            // cbDet
            // 
            this.cbDet.Enabled = false;
            this.cbDet.FormattingEnabled = true;
            this.cbDet.Location = new System.Drawing.Point(159, 77);
            this.cbDet.Name = "cbDet";
            this.cbDet.Size = new System.Drawing.Size(378, 28);
            this.cbDet.TabIndex = 15;
            // 
            // chkDet
            // 
            this.chkDet.AutoSize = true;
            this.chkDet.Location = new System.Drawing.Point(32, 79);
            this.chkDet.Name = "chkDet";
            this.chkDet.Size = new System.Drawing.Size(111, 24);
            this.chkDet.TabIndex = 14;
            this.chkDet.Text = "Detachment";
            this.chkDet.UseVisualStyleBackColor = true;
            // 
            // cbCompany
            // 
            this.cbCompany.FormattingEnabled = true;
            this.cbCompany.Location = new System.Drawing.Point(159, 40);
            this.cbCompany.Name = "cbCompany";
            this.cbCompany.Size = new System.Drawing.Size(194, 28);
            this.cbCompany.TabIndex = 13;
            // 
            // chkCompany
            // 
            this.chkCompany.AutoSize = true;
            this.chkCompany.Location = new System.Drawing.Point(32, 42);
            this.chkCompany.Name = "chkCompany";
            this.chkCompany.Size = new System.Drawing.Size(93, 24);
            this.chkCompany.TabIndex = 12;
            this.chkCompany.Text = "Company";
            this.chkCompany.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtpBPTo);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.dtpBPFrom);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(32, 203);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(505, 68);
            this.panel3.TabIndex = 18;
            // 
            // dtpBPTo
            // 
            this.dtpBPTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBPTo.Location = new System.Drawing.Point(296, 23);
            this.dtpBPTo.Name = "dtpBPTo";
            this.dtpBPTo.Size = new System.Drawing.Size(170, 27);
            this.dtpBPTo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "To";
            // 
            // dtpBPFrom
            // 
            this.dtpBPFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBPFrom.Location = new System.Drawing.Point(85, 23);
            this.dtpBPFrom.Name = "dtpBPFrom";
            this.dtpBPFrom.Size = new System.Drawing.Size(170, 27);
            this.dtpBPFrom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // frmExporting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 477);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmExporting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmExporting_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.CheckBox chkBP;
        private System.Windows.Forms.TextBox txtInvNo;
        private System.Windows.Forms.CheckBox chkInvNo;
        private System.Windows.Forms.ComboBox cbDet;
        private System.Windows.Forms.CheckBox chkDet;
        private System.Windows.Forms.ComboBox cbCompany;
        private System.Windows.Forms.CheckBox chkCompany;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtpBPTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpBPFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btngenerate;
    }
}