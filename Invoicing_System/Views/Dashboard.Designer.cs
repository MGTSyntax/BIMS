namespace Invoicing_System
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pnlMainView = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSignout = new System.Windows.Forms.Button();
            this.btnMainUsers = new System.Windows.Forms.Button();
            this.btnUploadBillings = new System.Windows.Forms.Button();
            this.btnMainCompany = new System.Windows.Forms.Button();
            this.btnMainTitle = new System.Windows.Forms.Button();
            this.btnMainPayments = new System.Windows.Forms.Button();
            this.btnMainCustomers = new System.Windows.Forms.Button();
            this.btnReimBreakDown = new System.Windows.Forms.Button();
            this.btnMainExit = new System.Windows.Forms.Button();
            this.btnMainMonitoring = new System.Windows.Forms.Button();
            this.btnMainDashboard = new System.Windows.Forms.Button();
            this.pbMainLogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnMainUsers);
            this.panel1.Controls.Add(this.btnUploadBillings);
            this.panel1.Controls.Add(this.btnMainCompany);
            this.panel1.Controls.Add(this.btnMainTitle);
            this.panel1.Controls.Add(this.btnMainCustomers);
            this.panel1.Controls.Add(this.btnMainPayments);
            this.panel1.Controls.Add(this.btnReimBreakDown);
            this.panel1.Controls.Add(this.btnMainExit);
            this.panel1.Controls.Add(this.btnMainMonitoring);
            this.panel1.Controls.Add(this.btnMainDashboard);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 9);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 38, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 754);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.lblUsername);
            this.panel4.Controls.Add(this.lblRole);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.pbMainLogo);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(214, 200);
            this.panel4.TabIndex = 0;
            // 
            // lblUsername
            // 
            this.lblUsername.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(0, 144);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(214, 20);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "MGTORRES";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblRole
            // 
            this.lblRole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRole.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.Color.Silver;
            this.lblRole.Location = new System.Drawing.Point(0, 164);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(214, 35);
            this.lblRole.TabIndex = 2;
            this.lblRole.Text = "Role";
            this.lblRole.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 199);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(214, 1);
            this.panel6.TabIndex = 1;
            // 
            // pnlMainView
            // 
            this.pnlMainView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMainView.Location = new System.Drawing.Point(219, 41);
            this.pnlMainView.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMainView.Name = "pnlMainView";
            this.pnlMainView.Padding = new System.Windows.Forms.Padding(13, 14, 13, 14);
            this.pnlMainView.Size = new System.Drawing.Size(1242, 718);
            this.pnlMainView.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1465, 9);
            this.panel2.TabIndex = 0;
            // 
            // btnSignout
            // 
            this.btnSignout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSignout.BackColor = System.Drawing.Color.Brown;
            this.btnSignout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignout.FlatAppearance.BorderSize = 0;
            this.btnSignout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSignout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignout.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignout.ForeColor = System.Drawing.Color.White;
            this.btnSignout.Image = global::Invoicing_System.Properties.Resources.cross_inverted;
            this.btnSignout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignout.Location = new System.Drawing.Point(1381, 11);
            this.btnSignout.Margin = new System.Windows.Forms.Padding(4);
            this.btnSignout.Name = "btnSignout";
            this.btnSignout.Size = new System.Drawing.Size(80, 27);
            this.btnSignout.TabIndex = 10;
            this.btnSignout.Text = " Signout";
            this.btnSignout.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSignout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSignout.UseVisualStyleBackColor = false;
            this.btnSignout.Click += new System.EventHandler(this.btnSignout_Click);
            // 
            // btnMainUsers
            // 
            this.btnMainUsers.BackColor = System.Drawing.Color.Transparent;
            this.btnMainUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMainUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMainUsers.Enabled = false;
            this.btnMainUsers.FlatAppearance.BorderSize = 0;
            this.btnMainUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnMainUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainUsers.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainUsers.ForeColor = System.Drawing.Color.White;
            this.btnMainUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnMainUsers.Image")));
            this.btnMainUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainUsers.Location = new System.Drawing.Point(0, 600);
            this.btnMainUsers.Margin = new System.Windows.Forms.Padding(4);
            this.btnMainUsers.Name = "btnMainUsers";
            this.btnMainUsers.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnMainUsers.Size = new System.Drawing.Size(214, 50);
            this.btnMainUsers.TabIndex = 9;
            this.btnMainUsers.Text = "   Users";
            this.btnMainUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMainUsers.UseVisualStyleBackColor = false;
            this.btnMainUsers.Visible = false;
            this.btnMainUsers.Click += new System.EventHandler(this.btnMainUsers_Click);
            // 
            // btnUploadBillings
            // 
            this.btnUploadBillings.BackColor = System.Drawing.Color.Transparent;
            this.btnUploadBillings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUploadBillings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUploadBillings.Enabled = false;
            this.btnUploadBillings.FlatAppearance.BorderSize = 0;
            this.btnUploadBillings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUploadBillings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadBillings.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadBillings.ForeColor = System.Drawing.Color.White;
            this.btnUploadBillings.Image = ((System.Drawing.Image)(resources.GetObject("btnUploadBillings.Image")));
            this.btnUploadBillings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUploadBillings.Location = new System.Drawing.Point(0, 550);
            this.btnUploadBillings.Margin = new System.Windows.Forms.Padding(4);
            this.btnUploadBillings.Name = "btnUploadBillings";
            this.btnUploadBillings.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnUploadBillings.Size = new System.Drawing.Size(214, 50);
            this.btnUploadBillings.TabIndex = 8;
            this.btnUploadBillings.Text = "   Upload Billings";
            this.btnUploadBillings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUploadBillings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUploadBillings.UseVisualStyleBackColor = false;
            this.btnUploadBillings.Visible = false;
            this.btnUploadBillings.Click += new System.EventHandler(this.btnUploadBillings_Click);
            // 
            // btnMainCompany
            // 
            this.btnMainCompany.BackColor = System.Drawing.Color.Transparent;
            this.btnMainCompany.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMainCompany.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMainCompany.FlatAppearance.BorderSize = 0;
            this.btnMainCompany.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnMainCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainCompany.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainCompany.ForeColor = System.Drawing.Color.White;
            this.btnMainCompany.Image = ((System.Drawing.Image)(resources.GetObject("btnMainCompany.Image")));
            this.btnMainCompany.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainCompany.Location = new System.Drawing.Point(0, 500);
            this.btnMainCompany.Margin = new System.Windows.Forms.Padding(4);
            this.btnMainCompany.Name = "btnMainCompany";
            this.btnMainCompany.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnMainCompany.Size = new System.Drawing.Size(214, 50);
            this.btnMainCompany.TabIndex = 7;
            this.btnMainCompany.Text = "   Company";
            this.btnMainCompany.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainCompany.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMainCompany.UseVisualStyleBackColor = false;
            this.btnMainCompany.Click += new System.EventHandler(this.btnMainCompany_Click);
            // 
            // btnMainTitle
            // 
            this.btnMainTitle.BackColor = System.Drawing.Color.Transparent;
            this.btnMainTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMainTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMainTitle.FlatAppearance.BorderSize = 0;
            this.btnMainTitle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnMainTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainTitle.ForeColor = System.Drawing.Color.White;
            this.btnMainTitle.Image = ((System.Drawing.Image)(resources.GetObject("btnMainTitle.Image")));
            this.btnMainTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainTitle.Location = new System.Drawing.Point(0, 450);
            this.btnMainTitle.Margin = new System.Windows.Forms.Padding(4);
            this.btnMainTitle.Name = "btnMainTitle";
            this.btnMainTitle.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnMainTitle.Size = new System.Drawing.Size(214, 50);
            this.btnMainTitle.TabIndex = 6;
            this.btnMainTitle.Text = "   Rates";
            this.btnMainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainTitle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMainTitle.UseVisualStyleBackColor = false;
            this.btnMainTitle.Click += new System.EventHandler(this.btnMainTitle_Click);
            // 
            // btnMainPayments
            // 
            this.btnMainPayments.BackColor = System.Drawing.Color.Transparent;
            this.btnMainPayments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMainPayments.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMainPayments.FlatAppearance.BorderSize = 0;
            this.btnMainPayments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnMainPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainPayments.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainPayments.ForeColor = System.Drawing.Color.White;
            this.btnMainPayments.Image = ((System.Drawing.Image)(resources.GetObject("btnMainPayments.Image")));
            this.btnMainPayments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainPayments.Location = new System.Drawing.Point(0, 350);
            this.btnMainPayments.Margin = new System.Windows.Forms.Padding(4);
            this.btnMainPayments.Name = "btnMainPayments";
            this.btnMainPayments.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnMainPayments.Size = new System.Drawing.Size(214, 50);
            this.btnMainPayments.TabIndex = 5;
            this.btnMainPayments.Text = "   Payments";
            this.btnMainPayments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainPayments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMainPayments.UseVisualStyleBackColor = false;
            this.btnMainPayments.Click += new System.EventHandler(this.btnMainPayments_Click);
            // 
            // btnMainCustomers
            // 
            this.btnMainCustomers.BackColor = System.Drawing.Color.Transparent;
            this.btnMainCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMainCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMainCustomers.FlatAppearance.BorderSize = 0;
            this.btnMainCustomers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnMainCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainCustomers.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainCustomers.ForeColor = System.Drawing.Color.White;
            this.btnMainCustomers.Image = ((System.Drawing.Image)(resources.GetObject("btnMainCustomers.Image")));
            this.btnMainCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainCustomers.Location = new System.Drawing.Point(0, 400);
            this.btnMainCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.btnMainCustomers.Name = "btnMainCustomers";
            this.btnMainCustomers.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnMainCustomers.Size = new System.Drawing.Size(214, 50);
            this.btnMainCustomers.TabIndex = 4;
            this.btnMainCustomers.Text = "   Customers";
            this.btnMainCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMainCustomers.UseVisualStyleBackColor = false;
            this.btnMainCustomers.Click += new System.EventHandler(this.btnMainCustomers_Click);
            // 
            // btnReimBreakDown
            // 
            this.btnReimBreakDown.BackColor = System.Drawing.Color.Transparent;
            this.btnReimBreakDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReimBreakDown.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReimBreakDown.FlatAppearance.BorderSize = 0;
            this.btnReimBreakDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnReimBreakDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReimBreakDown.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReimBreakDown.ForeColor = System.Drawing.Color.White;
            this.btnReimBreakDown.Image = ((System.Drawing.Image)(resources.GetObject("btnReimBreakDown.Image")));
            this.btnReimBreakDown.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReimBreakDown.Location = new System.Drawing.Point(0, 300);
            this.btnReimBreakDown.Margin = new System.Windows.Forms.Padding(4);
            this.btnReimBreakDown.Name = "btnReimBreakDown";
            this.btnReimBreakDown.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnReimBreakDown.Size = new System.Drawing.Size(214, 50);
            this.btnReimBreakDown.TabIndex = 3;
            this.btnReimBreakDown.Text = "   Reimbursements";
            this.btnReimBreakDown.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReimBreakDown.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReimBreakDown.UseVisualStyleBackColor = false;
            this.btnReimBreakDown.Click += new System.EventHandler(this.btnReimBreakDown_Click);
            // 
            // btnMainExit
            // 
            this.btnMainExit.BackColor = System.Drawing.Color.Brown;
            this.btnMainExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMainExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnMainExit.FlatAppearance.BorderSize = 0;
            this.btnMainExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainExit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainExit.ForeColor = System.Drawing.Color.White;
            this.btnMainExit.Image = global::Invoicing_System.Properties.Resources.cross_inverted;
            this.btnMainExit.Location = new System.Drawing.Point(0, 710);
            this.btnMainExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnMainExit.Name = "btnMainExit";
            this.btnMainExit.Size = new System.Drawing.Size(214, 44);
            this.btnMainExit.TabIndex = 9;
            this.btnMainExit.Text = " EXIT";
            this.btnMainExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMainExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMainExit.UseVisualStyleBackColor = false;
            this.btnMainExit.Click += new System.EventHandler(this.btnMainExit_Click);
            // 
            // btnMainMonitoring
            // 
            this.btnMainMonitoring.BackColor = System.Drawing.Color.Transparent;
            this.btnMainMonitoring.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMainMonitoring.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMainMonitoring.FlatAppearance.BorderSize = 0;
            this.btnMainMonitoring.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnMainMonitoring.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainMonitoring.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMonitoring.ForeColor = System.Drawing.Color.White;
            this.btnMainMonitoring.Image = ((System.Drawing.Image)(resources.GetObject("btnMainMonitoring.Image")));
            this.btnMainMonitoring.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainMonitoring.Location = new System.Drawing.Point(0, 250);
            this.btnMainMonitoring.Margin = new System.Windows.Forms.Padding(4);
            this.btnMainMonitoring.Name = "btnMainMonitoring";
            this.btnMainMonitoring.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnMainMonitoring.Size = new System.Drawing.Size(214, 50);
            this.btnMainMonitoring.TabIndex = 2;
            this.btnMainMonitoring.Text = "   Invoices";
            this.btnMainMonitoring.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainMonitoring.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMainMonitoring.UseVisualStyleBackColor = false;
            this.btnMainMonitoring.Click += new System.EventHandler(this.btnMainMonitoring_Click);
            // 
            // btnMainDashboard
            // 
            this.btnMainDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnMainDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMainDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMainDashboard.FlatAppearance.BorderSize = 0;
            this.btnMainDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnMainDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainDashboard.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainDashboard.ForeColor = System.Drawing.Color.White;
            this.btnMainDashboard.Image = global::Invoicing_System.Properties.Resources.folder;
            this.btnMainDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainDashboard.Location = new System.Drawing.Point(0, 200);
            this.btnMainDashboard.Margin = new System.Windows.Forms.Padding(4);
            this.btnMainDashboard.Name = "btnMainDashboard";
            this.btnMainDashboard.Padding = new System.Windows.Forms.Padding(13, 5, 0, 0);
            this.btnMainDashboard.Size = new System.Drawing.Size(214, 50);
            this.btnMainDashboard.TabIndex = 1;
            this.btnMainDashboard.Text = "   Dashboard";
            this.btnMainDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMainDashboard.UseVisualStyleBackColor = false;
            this.btnMainDashboard.Click += new System.EventHandler(this.btnMainDashboard_Click);
            // 
            // pbMainLogo
            // 
            this.pbMainLogo.Image = global::Invoicing_System.Properties.Resources.mib_logo;
            this.pbMainLogo.Location = new System.Drawing.Point(64, 25);
            this.pbMainLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pbMainLogo.Name = "pbMainLogo";
            this.pbMainLogo.Size = new System.Drawing.Size(83, 105);
            this.pbMainLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMainLogo.TabIndex = 0;
            this.pbMainLogo.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 763);
            this.ControlBox = false;
            this.Controls.Add(this.btnSignout);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlMainView);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMainLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlMainView;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pbMainLogo;
        private System.Windows.Forms.Button btnMainExit;
        private System.Windows.Forms.Button btnMainMonitoring;
        private System.Windows.Forms.Button btnMainDashboard;
        private System.Windows.Forms.Button btnMainCustomers;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnMainTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMainUsers;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Button btnMainCompany;
        private System.Windows.Forms.Button btnMainPayments;
        private System.Windows.Forms.Button btnSignout;
        private System.Windows.Forms.Button btnUploadBillings;
        private System.Windows.Forms.Button btnReimBreakDown;
    }
}

