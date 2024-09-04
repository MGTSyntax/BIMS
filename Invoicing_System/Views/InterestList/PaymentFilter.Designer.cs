namespace Invoicing_System.Views.InterestList
{
    partial class PaymentFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentFilter));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.btnApplyFilter = new System.Windows.Forms.Button();
            this.chkDD = new System.Windows.Forms.CheckBox();
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
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(568, 34);
            this.panel1.TabIndex = 3;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(7, 10);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(92, 15);
            this.label23.TabIndex = 24;
            this.label23.Text = "FILTER INVOICE";
            // 
            // pbClose
            // 
            this.pbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(539, 5);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(25, 24);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbClose.TabIndex = 1;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbStatus);
            this.panel2.Controls.Add(this.chkStatus);
            this.panel2.Controls.Add(this.btnClearFilter);
            this.panel2.Controls.Add(this.btnApplyFilter);
            this.panel2.Controls.Add(this.chkDD);
            this.panel2.Controls.Add(this.txtInvNo);
            this.panel2.Controls.Add(this.chkInvNo);
            this.panel2.Controls.Add(this.cbDet);
            this.panel2.Controls.Add(this.chkDet);
            this.panel2.Controls.Add(this.cbCompany);
            this.panel2.Controls.Add(this.chkCompany);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(568, 283);
            this.panel2.TabIndex = 4;
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.BackColor = System.Drawing.Color.Salmon;
            this.btnClearFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearFilter.FlatAppearance.BorderSize = 0;
            this.btnClearFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFilter.ForeColor = System.Drawing.Color.White;
            this.btnClearFilter.Location = new System.Drawing.Point(298, 241);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(92, 30);
            this.btnClearFilter.TabIndex = 9;
            this.btnClearFilter.Text = "Clear";
            this.btnClearFilter.UseVisualStyleBackColor = false;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // btnApplyFilter
            // 
            this.btnApplyFilter.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnApplyFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApplyFilter.FlatAppearance.BorderSize = 0;
            this.btnApplyFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyFilter.ForeColor = System.Drawing.Color.White;
            this.btnApplyFilter.Location = new System.Drawing.Point(205, 241);
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.Size = new System.Drawing.Size(92, 30);
            this.btnApplyFilter.TabIndex = 8;
            this.btnApplyFilter.Text = "Apply";
            this.btnApplyFilter.UseVisualStyleBackColor = false;
            this.btnApplyFilter.Click += new System.EventHandler(this.btnApplyFilter_Click);
            // 
            // chkDD
            // 
            this.chkDD.AutoSize = true;
            this.chkDD.Location = new System.Drawing.Point(31, 162);
            this.chkDD.Name = "chkDD";
            this.chkDD.Size = new System.Drawing.Size(76, 19);
            this.chkDD.TabIndex = 7;
            this.chkDD.Text = "Due Date";
            this.chkDD.UseVisualStyleBackColor = true;
            this.chkDD.CheckedChanged += new System.EventHandler(this.chkDD_CheckedChanged);
            // 
            // txtInvNo
            // 
            this.txtInvNo.Location = new System.Drawing.Point(125, 91);
            this.txtInvNo.Name = "txtInvNo";
            this.txtInvNo.Size = new System.Drawing.Size(175, 23);
            this.txtInvNo.TabIndex = 5;
            // 
            // chkInvNo
            // 
            this.chkInvNo.AutoSize = true;
            this.chkInvNo.Location = new System.Drawing.Point(31, 95);
            this.chkInvNo.Name = "chkInvNo";
            this.chkInvNo.Size = new System.Drawing.Size(87, 19);
            this.chkInvNo.TabIndex = 4;
            this.chkInvNo.Text = "Invoice No.";
            this.chkInvNo.UseVisualStyleBackColor = true;
            this.chkInvNo.CheckedChanged += new System.EventHandler(this.chkInvNo_CheckedChanged);
            // 
            // cbDet
            // 
            this.cbDet.Enabled = false;
            this.cbDet.FormattingEnabled = true;
            this.cbDet.Location = new System.Drawing.Point(125, 57);
            this.cbDet.Name = "cbDet";
            this.cbDet.Size = new System.Drawing.Size(411, 23);
            this.cbDet.TabIndex = 3;
            this.cbDet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbDet_KeyPress);
            // 
            // chkDet
            // 
            this.chkDet.AutoSize = true;
            this.chkDet.Location = new System.Drawing.Point(31, 61);
            this.chkDet.Name = "chkDet";
            this.chkDet.Size = new System.Drawing.Size(92, 19);
            this.chkDet.TabIndex = 2;
            this.chkDet.Text = "Detachment";
            this.chkDet.UseVisualStyleBackColor = true;
            this.chkDet.CheckedChanged += new System.EventHandler(this.chkDet_CheckedChanged);
            // 
            // cbCompany
            // 
            this.cbCompany.FormattingEnabled = true;
            this.cbCompany.Location = new System.Drawing.Point(125, 23);
            this.cbCompany.Name = "cbCompany";
            this.cbCompany.Size = new System.Drawing.Size(175, 23);
            this.cbCompany.TabIndex = 1;
            this.cbCompany.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbCompany_KeyPress);
            // 
            // chkCompany
            // 
            this.chkCompany.AutoSize = true;
            this.chkCompany.Location = new System.Drawing.Point(31, 27);
            this.chkCompany.Name = "chkCompany";
            this.chkCompany.Size = new System.Drawing.Size(77, 19);
            this.chkCompany.TabIndex = 0;
            this.chkCompany.Text = "Company";
            this.chkCompany.UseVisualStyleBackColor = true;
            this.chkCompany.CheckedChanged += new System.EventHandler(this.chkCompany_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtpBPTo);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.dtpBPFrom);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(31, 173);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(505, 55);
            this.panel3.TabIndex = 6;
            // 
            // dtpBPTo
            // 
            this.dtpBPTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBPTo.Location = new System.Drawing.Point(293, 19);
            this.dtpBPTo.Name = "dtpBPTo";
            this.dtpBPTo.Size = new System.Drawing.Size(145, 23);
            this.dtpBPTo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "To";
            // 
            // dtpBPFrom
            // 
            this.dtpBPFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBPFrom.Location = new System.Drawing.Point(97, 19);
            this.dtpBPFrom.Name = "dtpBPFrom";
            this.dtpBPFrom.Size = new System.Drawing.Size(145, 23);
            this.dtpBPFrom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(125, 125);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(175, 23);
            this.cbStatus.TabIndex = 11;
            this.cbStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbStatus_KeyPress);
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.Location = new System.Drawing.Point(31, 127);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(59, 19);
            this.chkStatus.TabIndex = 10;
            this.chkStatus.Text = "Status";
            this.chkStatus.UseVisualStyleBackColor = true;
            this.chkStatus.CheckedChanged += new System.EventHandler(this.chkStatus_CheckedChanged);
            // 
            // PaymentFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 317);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "PaymentFilter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PaymentFilter_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.Button btnApplyFilter;
        private System.Windows.Forms.CheckBox chkDD;
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
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.CheckBox chkStatus;
    }
}