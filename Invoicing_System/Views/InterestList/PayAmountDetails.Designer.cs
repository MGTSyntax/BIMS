namespace Invoicing_System.Views.InterestList
{
    partial class PayAmountDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayAmountDetails));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBalancePay = new System.Windows.Forms.TextBox();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtInvoiceNum = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.dtpPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtORN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtARN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCheckN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtInterest = new System.Windows.Forms.TextBox();
            this.errPPayAmt = new System.Windows.Forms.ErrorProvider(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.gbPayment = new System.Windows.Forms.GroupBox();
            this.gbBalance = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txttotalBal = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPPayAmt)).BeginInit();
            this.gbPayment.SuspendLayout();
            this.gbBalance.SuspendLayout();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(913, 39);
            this.panel1.TabIndex = 2;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(8, 12);
            this.label23.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(60, 15);
            this.label23.TabIndex = 24;
            this.label23.Text = "PAYMENT";
            // 
            // pbClose
            // 
            this.pbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(879, 6);
            this.pbClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(29, 28);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbClose.TabIndex = 1;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(34, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 47;
            this.label2.Text = "Invoice Balance :";
            // 
            // txtBalancePay
            // 
            this.txtBalancePay.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalancePay.Location = new System.Drawing.Point(139, 66);
            this.txtBalancePay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBalancePay.Name = "txtBalancePay";
            this.txtBalancePay.Size = new System.Drawing.Size(269, 23);
            this.txtBalancePay.TabIndex = 7;
            this.txtBalancePay.Click += new System.EventHandler(this.txtBalancePay_Click);
            this.txtBalancePay.Leave += new System.EventHandler(this.txtBalancePay_Leave);
            // 
            // txtCustID
            // 
            this.txtCustID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCustID.Enabled = false;
            this.txtCustID.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustID.Location = new System.Drawing.Point(397, 14);
            this.txtCustID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.ReadOnly = true;
            this.txtCustID.Size = new System.Drawing.Size(31, 16);
            this.txtCustID.TabIndex = 45;
            this.txtCustID.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(30, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 44;
            this.label1.Text = "Customer";
            // 
            // txtCustomer
            // 
            this.txtCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCustomer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomer.Location = new System.Drawing.Point(33, 60);
            this.txtCustomer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCustomer.Multiline = true;
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.ReadOnly = true;
            this.txtCustomer.Size = new System.Drawing.Size(370, 37);
            this.txtCustomer.TabIndex = 1;
            this.txtCustomer.Text = "No record";
            this.txtCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(30, 112);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 15);
            this.label13.TabIndex = 42;
            this.label13.Text = "Invoice Number";
            // 
            // txtInvoiceNum
            // 
            this.txtInvoiceNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInvoiceNum.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtInvoiceNum.Location = new System.Drawing.Point(134, 109);
            this.txtInvoiceNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtInvoiceNum.Multiline = true;
            this.txtInvoiceNum.Name = "txtInvoiceNum";
            this.txtInvoiceNum.ReadOnly = true;
            this.txtInvoiceNum.Size = new System.Drawing.Size(269, 20);
            this.txtInvoiceNum.TabIndex = 2;
            this.txtInvoiceNum.Text = "No record";
            this.txtInvoiceNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(320, 205);
            this.btnPay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(88, 33);
            this.btnPay.TabIndex = 12;
            this.btnPay.Text = "PAY";
            this.btnPay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label16.Location = new System.Drawing.Point(34, 34);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 15);
            this.label16.TabIndex = 39;
            this.label16.Text = "Payment Date :";
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.CustomFormat = "yyyy/MM/dd";
            this.dtpPaymentDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPaymentDate.Location = new System.Drawing.Point(139, 31);
            this.dtpPaymentDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(269, 23);
            this.dtpPaymentDate.TabIndex = 6;
            this.dtpPaymentDate.Value = new System.DateTime(2023, 5, 29, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(34, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 49;
            this.label3.Text = "OR Reference :";
            // 
            // txtORN
            // 
            this.txtORN.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtORN.Location = new System.Drawing.Point(139, 102);
            this.txtORN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtORN.Name = "txtORN";
            this.txtORN.Size = new System.Drawing.Size(269, 23);
            this.txtORN.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(34, 141);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 51;
            this.label4.Text = "AR Reference :";
            // 
            // txtARN
            // 
            this.txtARN.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtARN.Location = new System.Drawing.Point(139, 138);
            this.txtARN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtARN.Name = "txtARN";
            this.txtARN.Size = new System.Drawing.Size(269, 23);
            this.txtARN.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(34, 177);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 15);
            this.label5.TabIndex = 53;
            this.label5.Text = "Check Number :";
            // 
            // txtCheckN
            // 
            this.txtCheckN.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckN.Location = new System.Drawing.Point(139, 174);
            this.txtCheckN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCheckN.Name = "txtCheckN";
            this.txtCheckN.Size = new System.Drawing.Size(269, 23);
            this.txtCheckN.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(30, 178);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 55;
            this.label6.Text = "Interest";
            // 
            // txtInterest
            // 
            this.txtInterest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInterest.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtInterest.Location = new System.Drawing.Point(134, 175);
            this.txtInterest.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtInterest.Multiline = true;
            this.txtInterest.Name = "txtInterest";
            this.txtInterest.ReadOnly = true;
            this.txtInterest.Size = new System.Drawing.Size(269, 20);
            this.txtInterest.TabIndex = 4;
            this.txtInterest.Text = "0";
            this.txtInterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // errPPayAmt
            // 
            this.errPPayAmt.ContainerControl = this;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(30, 145);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 15);
            this.label7.TabIndex = 57;
            this.label7.Text = "Invoice Balance";
            // 
            // txtBalance
            // 
            this.txtBalance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBalance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtBalance.Location = new System.Drawing.Point(134, 142);
            this.txtBalance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBalance.Multiline = true;
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(269, 20);
            this.txtBalance.TabIndex = 3;
            this.txtBalance.Text = "0";
            this.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbPayment
            // 
            this.gbPayment.Controls.Add(this.btnPay);
            this.gbPayment.Controls.Add(this.dtpPaymentDate);
            this.gbPayment.Controls.Add(this.label16);
            this.gbPayment.Controls.Add(this.txtBalancePay);
            this.gbPayment.Controls.Add(this.label2);
            this.gbPayment.Controls.Add(this.label5);
            this.gbPayment.Controls.Add(this.txtORN);
            this.gbPayment.Controls.Add(this.txtCheckN);
            this.gbPayment.Controls.Add(this.label3);
            this.gbPayment.Controls.Add(this.label4);
            this.gbPayment.Controls.Add(this.txtARN);
            this.gbPayment.Location = new System.Drawing.Point(465, 57);
            this.gbPayment.Name = "gbPayment";
            this.gbPayment.Size = new System.Drawing.Size(435, 247);
            this.gbPayment.TabIndex = 58;
            this.gbPayment.TabStop = false;
            this.gbPayment.Text = "Pay";
            // 
            // gbBalance
            // 
            this.gbBalance.Controls.Add(this.label9);
            this.gbBalance.Controls.Add(this.txttotalBal);
            this.gbBalance.Controls.Add(this.txtInvoiceNum);
            this.gbBalance.Controls.Add(this.txtCustID);
            this.gbBalance.Controls.Add(this.label13);
            this.gbBalance.Controls.Add(this.label7);
            this.gbBalance.Controls.Add(this.txtCustomer);
            this.gbBalance.Controls.Add(this.txtBalance);
            this.gbBalance.Controls.Add(this.label1);
            this.gbBalance.Controls.Add(this.label6);
            this.gbBalance.Controls.Add(this.txtInterest);
            this.gbBalance.Location = new System.Drawing.Point(12, 57);
            this.gbBalance.Name = "gbBalance";
            this.gbBalance.Size = new System.Drawing.Size(435, 247);
            this.gbBalance.TabIndex = 59;
            this.gbBalance.TabStop = false;
            this.gbBalance.Text = "Balance";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(30, 211);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 15);
            this.label9.TabIndex = 59;
            this.label9.Text = "Total Balance";
            // 
            // txttotalBal
            // 
            this.txttotalBal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttotalBal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txttotalBal.ForeColor = System.Drawing.Color.Red;
            this.txttotalBal.Location = new System.Drawing.Point(134, 208);
            this.txttotalBal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txttotalBal.Multiline = true;
            this.txttotalBal.Name = "txttotalBal";
            this.txttotalBal.ReadOnly = true;
            this.txttotalBal.Size = new System.Drawing.Size(269, 20);
            this.txttotalBal.TabIndex = 5;
            this.txttotalBal.Text = "0";
            this.txttotalBal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PayAmountDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 314);
            this.ControlBox = false;
            this.Controls.Add(this.gbBalance);
            this.Controls.Add(this.gbPayment);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "PayAmountDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PayAmountDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPPayAmt)).EndInit();
            this.gbPayment.ResumeLayout(false);
            this.gbPayment.PerformLayout();
            this.gbBalance.ResumeLayout(false);
            this.gbBalance.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBalancePay;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtInvoiceNum;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtpPaymentDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtORN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtARN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCheckN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtInterest;
        private System.Windows.Forms.ErrorProvider errPPayAmt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.GroupBox gbPayment;
        private System.Windows.Forms.GroupBox gbBalance;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txttotalBal;
    }
}