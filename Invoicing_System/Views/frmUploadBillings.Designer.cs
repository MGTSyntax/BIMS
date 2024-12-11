namespace Invoicing_System.Views
{
    partial class frmUploadBillings
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUploadBillings));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvUploadedBM = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbltotalofTotals = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lbltotalOBill = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbltotalVAT = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbltotalAF = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbltotalNonD = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbltotalreim = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblnoofcust = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.customerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cutoffFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cutoffTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reimbursement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agencyFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otherBillable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nondeductible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isVoid = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isPaid = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.preparedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datePaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUploadedBM)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(67, 25);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1321, 600);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.dgvUploadedBM);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1313, 567);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Uploaded Data";
            // 
            // dgvUploadedBM
            // 
            this.dgvUploadedBM.AllowUserToAddRows = false;
            this.dgvUploadedBM.BackgroundColor = System.Drawing.Color.White;
            this.dgvUploadedBM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUploadedBM.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUploadedBM.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvUploadedBM.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUploadedBM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUploadedBM.ColumnHeadersHeight = 40;
            this.dgvUploadedBM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUploadedBM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerId,
            this.customerName,
            this.invoiceNo,
            this.cutoffFrom,
            this.cutoffTo,
            this.reimbursement,
            this.agencyFee,
            this.otherBillable,
            this.vat,
            this.nondeductible,
            this.isVoid,
            this.isPaid,
            this.preparedBy,
            this.shipDate,
            this.dueDate,
            this.balanceAmt,
            this.paymentAmt,
            this.datePaid,
            this.orNo,
            this.arNo,
            this.bank,
            this.checkNo,
            this.compID});
            this.dgvUploadedBM.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUploadedBM.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvUploadedBM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUploadedBM.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvUploadedBM.EnableHeadersVisualStyles = false;
            this.dgvUploadedBM.GridColor = System.Drawing.SystemColors.Control;
            this.dgvUploadedBM.Location = new System.Drawing.Point(3, 41);
            this.dgvUploadedBM.MultiSelect = false;
            this.dgvUploadedBM.Name = "dgvUploadedBM";
            this.dgvUploadedBM.RowHeadersVisible = false;
            this.dgvUploadedBM.RowHeadersWidth = 62;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            this.dgvUploadedBM.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvUploadedBM.RowTemplate.Height = 27;
            this.dgvUploadedBM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUploadedBM.Size = new System.Drawing.Size(1307, 499);
            this.dgvUploadedBM.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.txtFilePath);
            this.panel1.Controls.Add(this.btnUpload);
            this.panel1.Controls.Add(this.btnBrowse);
            this.panel1.Controls.Add(this.pbClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1307, 38);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(98, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(379, 1);
            this.panel3.TabIndex = 8;
            // 
            // txtFilePath
            // 
            this.txtFilePath.BackColor = System.Drawing.Color.White;
            this.txtFilePath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFilePath.Location = new System.Drawing.Point(100, 17);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(376, 16);
            this.txtFilePath.TabIndex = 7;
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpload.FlatAppearance.BorderSize = 0;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.ForeColor = System.Drawing.Color.White;
            this.btnUpload.Location = new System.Drawing.Point(485, 4);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(93, 30);
            this.btnUpload.TabIndex = 6;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.FlatAppearance.BorderSize = 0;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Location = new System.Drawing.Point(3, 4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(93, 30);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pbClose
            // 
            this.pbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(1278, 7);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(25, 24);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbClose.TabIndex = 0;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lbltotalofTotals);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.lbltotalOBill);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.lbltotalVAT);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.lbltotalAF);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.lbltotalNonD);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lbltotalreim);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblnoofcust);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 540);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1307, 24);
            this.panel2.TabIndex = 2;
            // 
            // lbltotalofTotals
            // 
            this.lbltotalofTotals.AutoSize = true;
            this.lbltotalofTotals.Location = new System.Drawing.Point(836, 5);
            this.lbltotalofTotals.Name = "lbltotalofTotals";
            this.lbltotalofTotals.Size = new System.Drawing.Size(21, 15);
            this.lbltotalofTotals.TabIndex = 19;
            this.lbltotalofTotals.Text = "00";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(754, 5);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(83, 15);
            this.label17.TabIndex = 18;
            this.label17.Text = "Total Amount:";
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.DimGray;
            this.label18.Location = new System.Drawing.Point(749, 3);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(2, 18);
            this.label18.TabIndex = 17;
            // 
            // lbltotalOBill
            // 
            this.lbltotalOBill.AutoSize = true;
            this.lbltotalOBill.Location = new System.Drawing.Point(646, 5);
            this.lbltotalOBill.Name = "lbltotalOBill";
            this.lbltotalOBill.Size = new System.Drawing.Size(21, 15);
            this.lbltotalOBill.TabIndex = 16;
            this.lbltotalOBill.Text = "00";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(621, 5);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 15);
            this.label14.TabIndex = 15;
            this.label14.Text = "OB:";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.DimGray;
            this.label15.Location = new System.Drawing.Point(616, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(2, 18);
            this.label15.TabIndex = 14;
            // 
            // lbltotalVAT
            // 
            this.lbltotalVAT.AutoSize = true;
            this.lbltotalVAT.Location = new System.Drawing.Point(526, 5);
            this.lbltotalVAT.Name = "lbltotalVAT";
            this.lbltotalVAT.Size = new System.Drawing.Size(21, 15);
            this.lbltotalVAT.TabIndex = 13;
            this.lbltotalVAT.Text = "00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(496, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 15);
            this.label11.TabIndex = 12;
            this.label11.Text = "VAT:";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(491, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(2, 18);
            this.label12.TabIndex = 11;
            // 
            // lbltotalAF
            // 
            this.lbltotalAF.AutoSize = true;
            this.lbltotalAF.Location = new System.Drawing.Point(410, 5);
            this.lbltotalAF.Name = "lbltotalAF";
            this.lbltotalAF.Size = new System.Drawing.Size(21, 15);
            this.lbltotalAF.TabIndex = 10;
            this.lbltotalAF.Text = "00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(387, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "AF:";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(383, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(2, 18);
            this.label9.TabIndex = 8;
            // 
            // lbltotalNonD
            // 
            this.lbltotalNonD.AutoSize = true;
            this.lbltotalNonD.Location = new System.Drawing.Point(296, 5);
            this.lbltotalNonD.Name = "lbltotalNonD";
            this.lbltotalNonD.Size = new System.Drawing.Size(21, 15);
            this.lbltotalNonD.TabIndex = 7;
            this.lbltotalNonD.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "ND:";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(265, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(2, 18);
            this.label6.TabIndex = 5;
            // 
            // lbltotalreim
            // 
            this.lbltotalreim.AutoSize = true;
            this.lbltotalreim.Location = new System.Drawing.Point(170, 5);
            this.lbltotalreim.Name = "lbltotalreim";
            this.lbltotalreim.Size = new System.Drawing.Size(21, 15);
            this.lbltotalreim.TabIndex = 4;
            this.lbltotalreim.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "R:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(150, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(2, 18);
            this.label2.TabIndex = 2;
            // 
            // lblnoofcust
            // 
            this.lblnoofcust.AutoSize = true;
            this.lblnoofcust.Location = new System.Drawing.Point(113, 5);
            this.lblnoofcust.Name = "lblnoofcust";
            this.lblnoofcust.Size = new System.Drawing.Size(21, 15);
            this.lblnoofcust.TabIndex = 1;
            this.lblnoofcust.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Displayed Invoices:";
            // 
            // customerId
            // 
            this.customerId.HeaderText = "Customer Id";
            this.customerId.MinimumWidth = 8;
            this.customerId.Name = "customerId";
            this.customerId.Visible = false;
            this.customerId.Width = 150;
            // 
            // customerName
            // 
            this.customerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.customerName.HeaderText = "Customer";
            this.customerName.MinimumWidth = 8;
            this.customerName.Name = "customerName";
            this.customerName.Width = 81;
            // 
            // invoiceNo
            // 
            this.invoiceNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.invoiceNo.HeaderText = "Invoice No.";
            this.invoiceNo.MinimumWidth = 8;
            this.invoiceNo.Name = "invoiceNo";
            this.invoiceNo.Width = 84;
            // 
            // cutoffFrom
            // 
            this.cutoffFrom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.cutoffFrom.DefaultCellStyle = dataGridViewCellStyle2;
            this.cutoffFrom.HeaderText = "Period From";
            this.cutoffFrom.MinimumWidth = 8;
            this.cutoffFrom.Name = "cutoffFrom";
            this.cutoffFrom.Width = 87;
            // 
            // cutoffTo
            // 
            this.cutoffTo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle3.Format = "d";
            this.cutoffTo.DefaultCellStyle = dataGridViewCellStyle3;
            this.cutoffTo.HeaderText = "Period To";
            this.cutoffTo.MinimumWidth = 8;
            this.cutoffTo.Name = "cutoffTo";
            this.cutoffTo.Width = 74;
            // 
            // reimbursement
            // 
            this.reimbursement.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0";
            this.reimbursement.DefaultCellStyle = dataGridViewCellStyle4;
            this.reimbursement.HeaderText = "Reimbursement";
            this.reimbursement.MinimumWidth = 8;
            this.reimbursement.Name = "reimbursement";
            // 
            // agencyFee
            // 
            this.agencyFee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = "0";
            this.agencyFee.DefaultCellStyle = dataGridViewCellStyle5;
            this.agencyFee.HeaderText = "Agency Fee";
            this.agencyFee.MinimumWidth = 8;
            this.agencyFee.Name = "agencyFee";
            // 
            // otherBillable
            // 
            this.otherBillable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = "0";
            this.otherBillable.DefaultCellStyle = dataGridViewCellStyle6;
            this.otherBillable.HeaderText = "Other Billable";
            this.otherBillable.MinimumWidth = 8;
            this.otherBillable.Name = "otherBillable";
            // 
            // vat
            // 
            this.vat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = "0";
            this.vat.DefaultCellStyle = dataGridViewCellStyle7;
            this.vat.HeaderText = "VAT";
            this.vat.MinimumWidth = 8;
            this.vat.Name = "vat";
            // 
            // nondeductible
            // 
            this.nondeductible.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = "0";
            this.nondeductible.DefaultCellStyle = dataGridViewCellStyle8;
            this.nondeductible.HeaderText = "Non-Deductible";
            this.nondeductible.MinimumWidth = 8;
            this.nondeductible.Name = "nondeductible";
            // 
            // isVoid
            // 
            this.isVoid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.isVoid.HeaderText = "Voided";
            this.isVoid.MinimumWidth = 8;
            this.isVoid.Name = "isVoid";
            this.isVoid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isVoid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.isVoid.Width = 67;
            // 
            // isPaid
            // 
            this.isPaid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.isPaid.HeaderText = "Paid";
            this.isPaid.Name = "isPaid";
            this.isPaid.Width = 34;
            // 
            // preparedBy
            // 
            this.preparedBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.preparedBy.HeaderText = "Prepared By";
            this.preparedBy.Name = "preparedBy";
            this.preparedBy.Width = 86;
            // 
            // shipDate
            // 
            dataGridViewCellStyle9.Format = "d";
            this.shipDate.DefaultCellStyle = dataGridViewCellStyle9;
            this.shipDate.HeaderText = "Ship Date";
            this.shipDate.Name = "shipDate";
            // 
            // dueDate
            // 
            dataGridViewCellStyle10.Format = "d";
            this.dueDate.DefaultCellStyle = dataGridViewCellStyle10;
            this.dueDate.HeaderText = "Due Date";
            this.dueDate.Name = "dueDate";
            // 
            // balanceAmt
            // 
            this.balanceAmt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle11.Format = "N2";
            dataGridViewCellStyle11.NullValue = "0";
            this.balanceAmt.DefaultCellStyle = dataGridViewCellStyle11;
            this.balanceAmt.HeaderText = "Balance";
            this.balanceAmt.MinimumWidth = 8;
            this.balanceAmt.Name = "balanceAmt";
            // 
            // paymentAmt
            // 
            dataGridViewCellStyle12.Format = "N2";
            dataGridViewCellStyle12.NullValue = "0";
            this.paymentAmt.DefaultCellStyle = dataGridViewCellStyle12;
            this.paymentAmt.HeaderText = "Payment";
            this.paymentAmt.Name = "paymentAmt";
            // 
            // datePaid
            // 
            dataGridViewCellStyle13.Format = "d";
            this.datePaid.DefaultCellStyle = dataGridViewCellStyle13;
            this.datePaid.HeaderText = "Date Paid";
            this.datePaid.Name = "datePaid";
            // 
            // orNo
            // 
            this.orNo.HeaderText = "OR No.";
            this.orNo.Name = "orNo";
            // 
            // arNo
            // 
            this.arNo.HeaderText = "AR No.";
            this.arNo.Name = "arNo";
            // 
            // bank
            // 
            this.bank.HeaderText = "Bank";
            this.bank.Name = "bank";
            // 
            // checkNo
            // 
            this.checkNo.HeaderText = "Check No.";
            this.checkNo.Name = "checkNo";
            // 
            // compID
            // 
            this.compID.HeaderText = "Comp Id";
            this.compID.Name = "compID";
            // 
            // frmUploadBillings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 600);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmUploadBillings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUploadedBM)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvUploadedBM;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbltotalofTotals;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lbltotalOBill;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbltotalVAT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbltotalAF;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbltotalNonD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbltotalreim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblnoofcust;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cutoffFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn cutoffTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn reimbursement;
        private System.Windows.Forms.DataGridViewTextBoxColumn agencyFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn otherBillable;
        private System.Windows.Forms.DataGridViewTextBoxColumn vat;
        private System.Windows.Forms.DataGridViewTextBoxColumn nondeductible;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isVoid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn preparedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn datePaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn orNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn arNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn bank;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn compID;
    }
}