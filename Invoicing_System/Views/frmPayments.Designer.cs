namespace Invoicing_System.Views
{
    partial class frmPayments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayments));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvInterest = new System.Windows.Forms.DataGridView();
            this.colinterestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colinvoiceNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colshippingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbalanceAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colaging = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colinterestAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colisPaid = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.bntExport = new System.Windows.Forms.Button();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.btnEnterPayment = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvPaymentHistory = new System.Windows.Forms.DataGridView();
            this.colp_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colp_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colp_datePaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colornumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colarnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colchecknum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterest)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1082, 702);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(67, 25);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1076, 450);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.dgvInterest);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1068, 417);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Interest Monitoring";
            // 
            // dgvInterest
            // 
            this.dgvInterest.AllowUserToAddRows = false;
            this.dgvInterest.AllowUserToDeleteRows = false;
            this.dgvInterest.AllowUserToResizeColumns = false;
            this.dgvInterest.AllowUserToResizeRows = false;
            this.dgvInterest.BackgroundColor = System.Drawing.Color.White;
            this.dgvInterest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvInterest.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvInterest.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvInterest.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInterest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInterest.ColumnHeadersHeight = 40;
            this.dgvInterest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvInterest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colinterestID,
            this.colinvoiceNum,
            this.colcustomerID,
            this.colshippingDate,
            this.coldueDate,
            this.colbalanceAmt,
            this.colaging,
            this.colinterestAmount,
            this.colComp,
            this.colisPaid});
            this.dgvInterest.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInterest.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvInterest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInterest.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvInterest.EnableHeadersVisualStyles = false;
            this.dgvInterest.GridColor = System.Drawing.SystemColors.Control;
            this.dgvInterest.Location = new System.Drawing.Point(3, 41);
            this.dgvInterest.MultiSelect = false;
            this.dgvInterest.Name = "dgvInterest";
            this.dgvInterest.RowHeadersVisible = false;
            this.dgvInterest.RowHeadersWidth = 62;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            this.dgvInterest.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvInterest.RowTemplate.Height = 27;
            this.dgvInterest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInterest.Size = new System.Drawing.Size(1062, 373);
            this.dgvInterest.TabIndex = 1;
            this.dgvInterest.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInterest_CellContentClick);
            // 
            // colinterestID
            // 
            this.colinterestID.HeaderText = "interestID";
            this.colinterestID.MinimumWidth = 8;
            this.colinterestID.Name = "colinterestID";
            this.colinterestID.Visible = false;
            this.colinterestID.Width = 150;
            // 
            // colinvoiceNum
            // 
            this.colinvoiceNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.colinvoiceNum.DefaultCellStyle = dataGridViewCellStyle2;
            this.colinvoiceNum.HeaderText = "Invoice No.";
            this.colinvoiceNum.MinimumWidth = 8;
            this.colinvoiceNum.Name = "colinvoiceNum";
            this.colinvoiceNum.Width = 84;
            // 
            // colcustomerID
            // 
            this.colcustomerID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.colcustomerID.DefaultCellStyle = dataGridViewCellStyle3;
            this.colcustomerID.HeaderText = "Customer";
            this.colcustomerID.MinimumWidth = 8;
            this.colcustomerID.Name = "colcustomerID";
            // 
            // colshippingDate
            // 
            this.colshippingDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.colshippingDate.DefaultCellStyle = dataGridViewCellStyle4;
            this.colshippingDate.HeaderText = "Date Shipped";
            this.colshippingDate.MinimumWidth = 8;
            this.colshippingDate.Name = "colshippingDate";
            this.colshippingDate.Width = 94;
            // 
            // coldueDate
            // 
            this.coldueDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.coldueDate.DefaultCellStyle = dataGridViewCellStyle5;
            this.coldueDate.HeaderText = "Due Date";
            this.coldueDate.MinimumWidth = 8;
            this.coldueDate.Name = "coldueDate";
            // 
            // colbalanceAmt
            // 
            this.colbalanceAmt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.colbalanceAmt.DefaultCellStyle = dataGridViewCellStyle6;
            this.colbalanceAmt.HeaderText = "Balance";
            this.colbalanceAmt.MinimumWidth = 8;
            this.colbalanceAmt.Name = "colbalanceAmt";
            // 
            // colaging
            // 
            this.colaging.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle7.Format = "d";
            dataGridViewCellStyle7.NullValue = null;
            this.colaging.DefaultCellStyle = dataGridViewCellStyle7;
            this.colaging.HeaderText = "Age";
            this.colaging.MinimumWidth = 8;
            this.colaging.Name = "colaging";
            this.colaging.Width = 51;
            // 
            // colinterestAmount
            // 
            this.colinterestAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            this.colinterestAmount.DefaultCellStyle = dataGridViewCellStyle8;
            this.colinterestAmount.HeaderText = "Interest";
            this.colinterestAmount.MinimumWidth = 8;
            this.colinterestAmount.Name = "colinterestAmount";
            this.colinterestAmount.Width = 70;
            // 
            // colComp
            // 
            this.colComp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colComp.HeaderText = "Company";
            this.colComp.Name = "colComp";
            this.colComp.Width = 81;
            // 
            // colisPaid
            // 
            this.colisPaid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colisPaid.HeaderText = "Paid";
            this.colisPaid.Name = "colisPaid";
            this.colisPaid.Width = 34;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnFilter);
            this.panel1.Controls.Add(this.bntExport);
            this.panel1.Controls.Add(this.pbClose);
            this.panel1.Controls.Add(this.btnEnterPayment);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1062, 38);
            this.panel1.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(102, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(93, 30);
            this.btnRefresh.TabIndex = 32;
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
            this.btnFilter.Location = new System.Drawing.Point(196, 4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(93, 30);
            this.btnFilter.TabIndex = 31;
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
            this.bntExport.Location = new System.Drawing.Point(290, 4);
            this.bntExport.Name = "bntExport";
            this.bntExport.Size = new System.Drawing.Size(93, 30);
            this.bntExport.TabIndex = 30;
            this.bntExport.Text = "Export";
            this.bntExport.UseVisualStyleBackColor = false;
            this.bntExport.Click += new System.EventHandler(this.bntExport_Click);
            // 
            // pbClose
            // 
            this.pbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(1031, 7);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(25, 24);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbClose.TabIndex = 0;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // btnEnterPayment
            // 
            this.btnEnterPayment.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEnterPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnterPayment.FlatAppearance.BorderSize = 0;
            this.btnEnterPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnterPayment.ForeColor = System.Drawing.Color.White;
            this.btnEnterPayment.Location = new System.Drawing.Point(3, 4);
            this.btnEnterPayment.Name = "btnEnterPayment";
            this.btnEnterPayment.Size = new System.Drawing.Size(98, 30);
            this.btnEnterPayment.TabIndex = 1;
            this.btnEnterPayment.Text = "Enter Payment";
            this.btnEnterPayment.UseVisualStyleBackColor = false;
            this.btnEnterPayment.Click += new System.EventHandler(this.btnEnterPayment_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.ItemSize = new System.Drawing.Size(67, 25);
            this.tabControl2.Location = new System.Drawing.Point(3, 459);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1076, 240);
            this.tabControl2.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.dgvPaymentHistory);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1068, 207);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Payment History";
            // 
            // dgvPaymentHistory
            // 
            this.dgvPaymentHistory.AllowUserToAddRows = false;
            this.dgvPaymentHistory.BackgroundColor = System.Drawing.Color.Salmon;
            this.dgvPaymentHistory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPaymentHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPaymentHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPaymentHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvPaymentHistory.ColumnHeadersHeight = 40;
            this.dgvPaymentHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPaymentHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colp_id,
            this.colp_amount,
            this.colp_datePaid,
            this.colornumber,
            this.colarnum,
            this.colbank,
            this.colchecknum});
            this.dgvPaymentHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPaymentHistory.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvPaymentHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPaymentHistory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPaymentHistory.EnableHeadersVisualStyles = false;
            this.dgvPaymentHistory.GridColor = System.Drawing.SystemColors.Control;
            this.dgvPaymentHistory.Location = new System.Drawing.Point(3, 3);
            this.dgvPaymentHistory.MultiSelect = false;
            this.dgvPaymentHistory.Name = "dgvPaymentHistory";
            this.dgvPaymentHistory.RowHeadersVisible = false;
            this.dgvPaymentHistory.RowHeadersWidth = 62;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Azure;
            this.dgvPaymentHistory.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvPaymentHistory.RowTemplate.Height = 27;
            this.dgvPaymentHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPaymentHistory.Size = new System.Drawing.Size(1062, 201);
            this.dgvPaymentHistory.TabIndex = 2;
            // 
            // colp_id
            // 
            this.colp_id.HeaderText = "paymentID";
            this.colp_id.MinimumWidth = 8;
            this.colp_id.Name = "colp_id";
            this.colp_id.Visible = false;
            this.colp_id.Width = 150;
            // 
            // colp_amount
            // 
            this.colp_amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle12.Format = "N2";
            dataGridViewCellStyle12.NullValue = null;
            this.colp_amount.DefaultCellStyle = dataGridViewCellStyle12;
            this.colp_amount.HeaderText = "Amount";
            this.colp_amount.MinimumWidth = 8;
            this.colp_amount.Name = "colp_amount";
            // 
            // colp_datePaid
            // 
            this.colp_datePaid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle13.Format = "d";
            dataGridViewCellStyle13.NullValue = null;
            this.colp_datePaid.DefaultCellStyle = dataGridViewCellStyle13;
            this.colp_datePaid.HeaderText = "Date Paid";
            this.colp_datePaid.MinimumWidth = 8;
            this.colp_datePaid.Name = "colp_datePaid";
            // 
            // colornumber
            // 
            this.colornumber.HeaderText = "OR No.";
            this.colornumber.Name = "colornumber";
            // 
            // colarnum
            // 
            this.colarnum.HeaderText = "AR No.";
            this.colarnum.Name = "colarnum";
            // 
            // colbank
            // 
            this.colbank.HeaderText = "Bank";
            this.colbank.Name = "colbank";
            // 
            // colchecknum
            // 
            this.colchecknum.HeaderText = "Check No.";
            this.colchecknum.Name = "colchecknum";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.MinimumWidth = 8;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // frmPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 702);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmPayments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPayments_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterest)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvInterest;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEnterPayment;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvPaymentHistory;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button bntExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn colp_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn colp_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colp_datePaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colornumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colarnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbank;
        private System.Windows.Forms.DataGridViewTextBoxColumn colchecknum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colinterestID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colinvoiceNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colshippingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbalanceAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colaging;
        private System.Windows.Forms.DataGridViewTextBoxColumn colinterestAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComp;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colisPaid;
    }
}