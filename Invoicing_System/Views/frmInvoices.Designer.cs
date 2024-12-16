namespace Invoicing_System.Views
{
    partial class frmInvoices
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvoices));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvInvoices = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.bntExport = new System.Windows.Forms.Button();
            this.btnShipDate = new System.Windows.Forms.Button();
            this.btnNewInvoice = new System.Windows.Forms.Button();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbltotalDisc = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.colInvoiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBPFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBPTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReimbursement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colnondeductible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAgencyFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOtherBillable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGrandT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcomp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colisPaid = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colprinted = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colPrint = new System.Windows.Forms.DataGridViewImageColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.colVoid = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(1335, 637);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.dgvInvoices);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1327, 604);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Invoices";
            // 
            // dgvInvoices
            // 
            this.dgvInvoices.AllowUserToAddRows = false;
            this.dgvInvoices.BackgroundColor = System.Drawing.Color.White;
            this.dgvInvoices.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvInvoices.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvInvoices.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvInvoices.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvoices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInvoices.ColumnHeadersHeight = 40;
            this.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvInvoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colInvoiceID,
            this.colInvoiceNo,
            this.colCustomer,
            this.colBPFrom,
            this.colBPTo,
            this.colReimbursement,
            this.colnondeductible,
            this.colAgencyFee,
            this.colVAT,
            this.colOtherBillable,
            this.colDiscount,
            this.colTotal,
            this.colWTax,
            this.colGrandT,
            this.colcomp,
            this.colisPaid,
            this.colprinted,
            this.colPrint,
            this.colEdit,
            this.colVoid});
            this.dgvInvoices.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInvoices.DefaultCellStyle = dataGridViewCellStyle16;
            this.dgvInvoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInvoices.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvInvoices.EnableHeadersVisualStyles = false;
            this.dgvInvoices.GridColor = System.Drawing.SystemColors.Control;
            this.dgvInvoices.Location = new System.Drawing.Point(3, 41);
            this.dgvInvoices.MultiSelect = false;
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.RowHeadersVisible = false;
            this.dgvInvoices.RowHeadersWidth = 62;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            this.dgvInvoices.RowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvInvoices.RowTemplate.Height = 27;
            this.dgvInvoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoices.Size = new System.Drawing.Size(1321, 536);
            this.dgvInvoices.TabIndex = 1;
            this.dgvInvoices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoices_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnFilter);
            this.panel1.Controls.Add(this.bntExport);
            this.panel1.Controls.Add(this.btnShipDate);
            this.panel1.Controls.Add(this.btnNewInvoice);
            this.panel1.Controls.Add(this.pbClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1321, 38);
            this.panel1.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(191, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(93, 30);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Location = new System.Drawing.Point(285, 4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(93, 30);
            this.btnFilter.TabIndex = 5;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // bntExport
            // 
            this.bntExport.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bntExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntExport.FlatAppearance.BorderSize = 0;
            this.bntExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntExport.ForeColor = System.Drawing.Color.White;
            this.bntExport.Location = new System.Drawing.Point(379, 4);
            this.bntExport.Name = "bntExport";
            this.bntExport.Size = new System.Drawing.Size(93, 30);
            this.bntExport.TabIndex = 4;
            this.bntExport.Text = "Export";
            this.bntExport.UseVisualStyleBackColor = false;
            this.bntExport.Click += new System.EventHandler(this.bntExport_Click);
            // 
            // btnShipDate
            // 
            this.btnShipDate.BackColor = System.Drawing.Color.Salmon;
            this.btnShipDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShipDate.FlatAppearance.BorderSize = 0;
            this.btnShipDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShipDate.ForeColor = System.Drawing.Color.White;
            this.btnShipDate.Location = new System.Drawing.Point(97, 4);
            this.btnShipDate.Name = "btnShipDate";
            this.btnShipDate.Size = new System.Drawing.Size(93, 30);
            this.btnShipDate.TabIndex = 2;
            this.btnShipDate.Text = "Ship";
            this.btnShipDate.UseVisualStyleBackColor = false;
            this.btnShipDate.Click += new System.EventHandler(this.btnShipDate_Click);
            // 
            // btnNewInvoice
            // 
            this.btnNewInvoice.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNewInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewInvoice.FlatAppearance.BorderSize = 0;
            this.btnNewInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewInvoice.ForeColor = System.Drawing.Color.White;
            this.btnNewInvoice.Location = new System.Drawing.Point(3, 4);
            this.btnNewInvoice.Name = "btnNewInvoice";
            this.btnNewInvoice.Size = new System.Drawing.Size(93, 30);
            this.btnNewInvoice.TabIndex = 1;
            this.btnNewInvoice.Text = "New";
            this.btnNewInvoice.UseVisualStyleBackColor = false;
            this.btnNewInvoice.Click += new System.EventHandler(this.btnNewInvoice_Click);
            // 
            // pbClose
            // 
            this.pbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(1292, 7);
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
            this.panel2.Controls.Add(this.lbltotalDisc);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label3);
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
            this.panel2.Location = new System.Drawing.Point(3, 577);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1321, 24);
            this.panel2.TabIndex = 2;
            // 
            // lbltotalDisc
            // 
            this.lbltotalDisc.AutoSize = true;
            this.lbltotalDisc.Location = new System.Drawing.Point(776, 5);
            this.lbltotalDisc.Name = "lbltotalDisc";
            this.lbltotalDisc.Size = new System.Drawing.Size(21, 15);
            this.lbltotalDisc.TabIndex = 22;
            this.lbltotalDisc.Text = "00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(754, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "D:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(882, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(2, 18);
            this.label3.TabIndex = 20;
            // 
            // lbltotalofTotals
            // 
            this.lbltotalofTotals.AutoSize = true;
            this.lbltotalofTotals.Location = new System.Drawing.Point(971, 5);
            this.lbltotalofTotals.Name = "lbltotalofTotals";
            this.lbltotalofTotals.Size = new System.Drawing.Size(21, 15);
            this.lbltotalofTotals.TabIndex = 19;
            this.lbltotalofTotals.Text = "00";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(889, 5);
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
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle18.NullValue")));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.White;
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.MinimumWidth = 8;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle19.NullValue")));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.White;
            this.dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.MinimumWidth = 8;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle20.NullValue")));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.White;
            this.dataGridViewImageColumn3.DefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn3.Image")));
            this.dataGridViewImageColumn3.MinimumWidth = 8;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colInvoiceID
            // 
            this.colInvoiceID.HeaderText = "InvoiceID";
            this.colInvoiceID.MinimumWidth = 8;
            this.colInvoiceID.Name = "colInvoiceID";
            this.colInvoiceID.Visible = false;
            this.colInvoiceID.Width = 150;
            // 
            // colInvoiceNo
            // 
            this.colInvoiceNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colInvoiceNo.HeaderText = "Invoice No.";
            this.colInvoiceNo.MinimumWidth = 8;
            this.colInvoiceNo.Name = "colInvoiceNo";
            this.colInvoiceNo.Width = 84;
            // 
            // colCustomer
            // 
            this.colCustomer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCustomer.HeaderText = "Customer";
            this.colCustomer.MinimumWidth = 8;
            this.colCustomer.Name = "colCustomer";
            // 
            // colBPFrom
            // 
            this.colBPFrom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.colBPFrom.DefaultCellStyle = dataGridViewCellStyle2;
            this.colBPFrom.HeaderText = "Period From";
            this.colBPFrom.MinimumWidth = 8;
            this.colBPFrom.Name = "colBPFrom";
            this.colBPFrom.Width = 87;
            // 
            // colBPTo
            // 
            this.colBPTo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle3.Format = "d";
            this.colBPTo.DefaultCellStyle = dataGridViewCellStyle3;
            this.colBPTo.HeaderText = "Period To";
            this.colBPTo.MinimumWidth = 8;
            this.colBPTo.Name = "colBPTo";
            this.colBPTo.Width = 74;
            // 
            // colReimbursement
            // 
            this.colReimbursement.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0";
            this.colReimbursement.DefaultCellStyle = dataGridViewCellStyle4;
            this.colReimbursement.HeaderText = "Reimbursement";
            this.colReimbursement.MinimumWidth = 8;
            this.colReimbursement.Name = "colReimbursement";
            // 
            // colnondeductible
            // 
            this.colnondeductible.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = "0";
            this.colnondeductible.DefaultCellStyle = dataGridViewCellStyle5;
            this.colnondeductible.HeaderText = "Non-Deductible";
            this.colnondeductible.MinimumWidth = 8;
            this.colnondeductible.Name = "colnondeductible";
            // 
            // colAgencyFee
            // 
            this.colAgencyFee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = "0";
            this.colAgencyFee.DefaultCellStyle = dataGridViewCellStyle6;
            this.colAgencyFee.HeaderText = "Agency Fee";
            this.colAgencyFee.MinimumWidth = 8;
            this.colAgencyFee.Name = "colAgencyFee";
            // 
            // colVAT
            // 
            this.colVAT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = "0";
            this.colVAT.DefaultCellStyle = dataGridViewCellStyle7;
            this.colVAT.HeaderText = "VAT";
            this.colVAT.MinimumWidth = 8;
            this.colVAT.Name = "colVAT";
            // 
            // colOtherBillable
            // 
            this.colOtherBillable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = "0";
            this.colOtherBillable.DefaultCellStyle = dataGridViewCellStyle8;
            this.colOtherBillable.HeaderText = "Other Billable";
            this.colOtherBillable.MinimumWidth = 8;
            this.colOtherBillable.Name = "colOtherBillable";
            // 
            // colDiscount
            // 
            this.colDiscount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle9.Format = "N2";
            this.colDiscount.DefaultCellStyle = dataGridViewCellStyle9;
            this.colDiscount.HeaderText = "Discount";
            this.colDiscount.MinimumWidth = 8;
            this.colDiscount.Name = "colDiscount";
            // 
            // colTotal
            // 
            this.colTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle10.Format = "N2";
            dataGridViewCellStyle10.NullValue = "0";
            this.colTotal.DefaultCellStyle = dataGridViewCellStyle10;
            this.colTotal.HeaderText = "Total Amount";
            this.colTotal.MinimumWidth = 8;
            this.colTotal.Name = "colTotal";
            // 
            // colWTax
            // 
            this.colWTax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle11.Format = "N2";
            this.colWTax.DefaultCellStyle = dataGridViewCellStyle11;
            this.colWTax.HeaderText = "W Tax";
            this.colWTax.Name = "colWTax";
            // 
            // colGrandT
            // 
            this.colGrandT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle12.Format = "N2";
            this.colGrandT.DefaultCellStyle = dataGridViewCellStyle12;
            this.colGrandT.HeaderText = "Grand Total";
            this.colGrandT.Name = "colGrandT";
            // 
            // colcomp
            // 
            this.colcomp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colcomp.HeaderText = "Company";
            this.colcomp.Name = "colcomp";
            this.colcomp.Width = 81;
            // 
            // colisPaid
            // 
            this.colisPaid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colisPaid.HeaderText = "Paid";
            this.colisPaid.Name = "colisPaid";
            this.colisPaid.Width = 34;
            // 
            // colprinted
            // 
            this.colprinted.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colprinted.HeaderText = "Printed";
            this.colprinted.MinimumWidth = 8;
            this.colprinted.Name = "colprinted";
            this.colprinted.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colprinted.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colprinted.Width = 68;
            // 
            // colPrint
            // 
            this.colPrint.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle13.NullValue")));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.White;
            this.colPrint.DefaultCellStyle = dataGridViewCellStyle13;
            this.colPrint.HeaderText = "";
            this.colPrint.Image = ((System.Drawing.Image)(resources.GetObject("colPrint.Image")));
            this.colPrint.MinimumWidth = 8;
            this.colPrint.Name = "colPrint";
            this.colPrint.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colPrint.Width = 17;
            // 
            // colEdit
            // 
            this.colEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle14.NullValue")));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.White;
            this.colEdit.DefaultCellStyle = dataGridViewCellStyle14;
            this.colEdit.HeaderText = "";
            this.colEdit.Image = ((System.Drawing.Image)(resources.GetObject("colEdit.Image")));
            this.colEdit.MinimumWidth = 8;
            this.colEdit.Name = "colEdit";
            this.colEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colEdit.Width = 17;
            // 
            // colVoid
            // 
            this.colVoid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle15.NullValue")));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.White;
            this.colVoid.DefaultCellStyle = dataGridViewCellStyle15;
            this.colVoid.HeaderText = "";
            this.colVoid.Image = global::Invoicing_System.Properties.Resources.voidfile;
            this.colVoid.MinimumWidth = 8;
            this.colVoid.Name = "colVoid";
            this.colVoid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colVoid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colVoid.Width = 17;
            // 
            // frmInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 637);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmInvoices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInvoices_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Button btnNewInvoice;
        private System.Windows.Forms.Button btnShipDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblnoofcust;
        private System.Windows.Forms.Button bntExport;
        private System.Windows.Forms.DataGridView dgvInvoices;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbltotalreim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbltotalNonD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbltotalAF;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbltotalVAT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbltotalOBill;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbltotalofTotals;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbltotalDisc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBPFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBPTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReimbursement;
        private System.Windows.Forms.DataGridViewTextBoxColumn colnondeductible;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAgencyFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOtherBillable;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGrandT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcomp;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colisPaid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colprinted;
        private System.Windows.Forms.DataGridViewImageColumn colPrint;
        private System.Windows.Forms.DataGridViewImageColumn colEdit;
        private System.Windows.Forms.DataGridViewImageColumn colVoid;
    }
}