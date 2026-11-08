namespace CMS_TAHANAN
{
	partial class frmDashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpRoot = new System.Windows.Forms.TableLayoutPanel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.tlpWorkspace = new System.Windows.Forms.TableLayoutPanel();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnPayments = new System.Windows.Forms.Button();
            this.btnMaintenance = new System.Windows.Forms.Button();
            this.btnFamilies = new System.Windows.Forms.Button();
            this.btnReservations = new System.Windows.Forms.Button();
            this.btnClassification = new System.Windows.Forms.Button();
            this.btnBurialPlots = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.tlpDashboard = new System.Windows.Forms.TableLayoutPanel();
            this.pnlWelcome = new System.Windows.Forms.Panel();
            this.lblWelcomeSubtitle = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblSectionTitle = new System.Windows.Forms.Label();
            this.tlpStats = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTransactions = new System.Windows.Forms.Panel();
            this.lblTransactionsDescription = new System.Windows.Forms.Label();
            this.lbltransactionValue = new System.Windows.Forms.Label();
            this.pnlTransaction = new System.Windows.Forms.Label();
            this.pnlReservations = new System.Windows.Forms.Panel();
            this.lblReservationsDescription = new System.Windows.Forms.Label();
            this.lblReservationValue = new System.Windows.Forms.Label();
            this.pnlReservation = new System.Windows.Forms.Label();
            this.pnlOccupiedPlots = new System.Windows.Forms.Panel();
            this.lblOccupiedDescription = new System.Windows.Forms.Label();
            this.lblTotalOccupeidPlotsValue = new System.Windows.Forms.Label();
            this.lblOccupiedPlots = new System.Windows.Forms.Label();
            this.pnlTotalPlots = new System.Windows.Forms.Panel();
            this.lblTotalPlotsDescription = new System.Windows.Forms.Label();
            this.lblTotalPlotsValue = new System.Windows.Forms.Label();
            this.lblTotalPlotsTitle = new System.Windows.Forms.Label();
            this.tlpLowerDashboard = new System.Windows.Forms.TableLayoutPanel();
            this.pnlRecentRecords = new System.Windows.Forms.Panel();
            this.dgvRecentRecords = new System.Windows.Forms.DataGridView();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchRecords = new System.Windows.Forms.TextBox();
            this.lblRecentSubtitle = new System.Windows.Forms.Label();
            this.lblRecentTitle = new System.Windows.Forms.Label();
            this.lblActivityLabel = new System.Windows.Forms.Label();
            this.tlpRightColumn = new System.Windows.Forms.TableLayoutPanel();
            this.pnlMemorialCard = new System.Windows.Forms.Panel();
            this.tlpMemorialContent = new System.Windows.Forms.TableLayoutPanel();
            this.picMemorial = new System.Windows.Forms.PictureBox();
            this.pnlMemorialInfo = new System.Windows.Forms.Panel();
            this.lblMemorialTime = new System.Windows.Forms.Label();
            this.lblMemorialDate = new System.Windows.Forms.Label();
            this.lblTodayLocation = new System.Windows.Forms.Label();
            this.pnlQuickActions = new System.Windows.Forms.Panel();
            this.pnlBurialPlotsPage = new System.Windows.Forms.Panel();
            this.tlpBurialRoot = new System.Windows.Forms.TableLayoutPanel();
            this.pnlBPHeader = new System.Windows.Forms.Panel();
            this.lblBPSubtitle = new System.Windows.Forms.Label();
            this.btnAddBurialPlot = new System.Windows.Forms.Button();
            this.lblBPTitle = new System.Windows.Forms.Label();
            this.lblBPSection = new System.Windows.Forms.Label();
            this.tlpBPStats = new System.Windows.Forms.TableLayoutPanel();
            this.pnlBPTotal = new System.Windows.Forms.Panel();
            this.lblBPTotalDescription = new System.Windows.Forms.Label();
            this.lblBPTotalValue = new System.Windows.Forms.Label();
            this.lblBPTotalTitle = new System.Windows.Forms.Label();
            this.pnlBPAvailable = new System.Windows.Forms.Panel();
            this.lblBPAvailableDescription = new System.Windows.Forms.Label();
            this.lblBPAvailableValue = new System.Windows.Forms.Label();
            this.lblBPAvailableTitle = new System.Windows.Forms.Label();
            this.pnlBPOccupied = new System.Windows.Forms.Panel();
            this.lblBPOccupiedDescription = new System.Windows.Forms.Label();
            this.lblBPOccupiedValue = new System.Windows.Forms.Label();
            this.lblBPOccupiedTitle = new System.Windows.Forms.Label();
            this.pnlBPReserved = new System.Windows.Forms.Panel();
            this.lblBPReservedDescription = new System.Windows.Forms.Label();
            this.lblBPReservedValue = new System.Windows.Forms.Label();
            this.lblBPReservedTitle = new System.Windows.Forms.Label();
            this.pnlBPFilters = new System.Windows.Forms.Panel();
            this.cmbPlotSection = new System.Windows.Forms.ComboBox();
            this.cmbPlotType = new System.Windows.Forms.ComboBox();
            this.lblMoreFilters = new System.Windows.Forms.Label();
            this.btnReservedFilter = new System.Windows.Forms.Button();
            this.btnOccupiedFilter = new System.Windows.Forms.Button();
            this.btnAvailableFilter = new System.Windows.Forms.Button();
            this.btnAllStatus = new System.Windows.Forms.Button();
            this.lblStatusFilter = new System.Windows.Forms.Label();
            this.txtPlotSearch = new System.Windows.Forms.TextBox();
            this.pnlBPRegistry = new System.Windows.Forms.Panel();
            this.dgvBurialPlots = new System.Windows.Forms.DataGridView();
            this.colPlotID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlotType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOccupant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateRegistered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblFooter = new System.Windows.Forms.Label();
            this.tlpRoot.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.tlpWorkspace.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            this.tlpDashboard.SuspendLayout();
            this.pnlWelcome.SuspendLayout();
            this.tlpStats.SuspendLayout();
            this.pnlTransactions.SuspendLayout();
            this.pnlReservations.SuspendLayout();
            this.pnlOccupiedPlots.SuspendLayout();
            this.pnlTotalPlots.SuspendLayout();
            this.tlpLowerDashboard.SuspendLayout();
            this.pnlRecentRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentRecords)).BeginInit();
            this.tlpRightColumn.SuspendLayout();
            this.pnlMemorialCard.SuspendLayout();
            this.tlpMemorialContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMemorial)).BeginInit();
            this.pnlMemorialInfo.SuspendLayout();
            this.pnlBurialPlotsPage.SuspendLayout();
            this.tlpBurialRoot.SuspendLayout();
            this.pnlBPHeader.SuspendLayout();
            this.tlpBPStats.SuspendLayout();
            this.pnlBPTotal.SuspendLayout();
            this.pnlBPAvailable.SuspendLayout();
            this.pnlBPOccupied.SuspendLayout();
            this.pnlBPReserved.SuspendLayout();
            this.pnlBPFilters.SuspendLayout();
            this.pnlBPRegistry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBurialPlots)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpRoot
            // 
            this.tlpRoot.ColumnCount = 1;
            this.tlpRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRoot.Controls.Add(this.pnlHeader, 0, 0);
            this.tlpRoot.Controls.Add(this.tlpWorkspace, 0, 1);
            this.tlpRoot.Controls.Add(this.pnlFooter, 0, 2);
            this.tlpRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRoot.Location = new System.Drawing.Point(0, 0);
            this.tlpRoot.Margin = new System.Windows.Forms.Padding(0);
            this.tlpRoot.Name = "tlpRoot";
            this.tlpRoot.RowCount = 3;
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpRoot.Size = new System.Drawing.Size(1006, 633);
            this.tlpRoot.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(62)))), ((int)(((byte)(50)))));
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Controls.Add(this.lblLogo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.pnlHeader.Size = new System.Drawing.Size(1006, 60);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.ForeColor = System.Drawing.Color.White;
            this.lblSubtitle.Location = new System.Drawing.Point(22, 36);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(200, 15);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "CEMETERY MANAGEMENT SYSTEM";
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Georgia", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(20, 4);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(224, 43);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "TAHANAN";
            // 
            // tlpWorkspace
            // 
            this.tlpWorkspace.ColumnCount = 2;
            this.tlpWorkspace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tlpWorkspace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpWorkspace.Controls.Add(this.pnlSidebar, 0, 0);
            this.tlpWorkspace.Controls.Add(this.pnlDashboard, 1, 0);
            this.tlpWorkspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpWorkspace.Location = new System.Drawing.Point(0, 60);
            this.tlpWorkspace.Margin = new System.Windows.Forms.Padding(0);
            this.tlpWorkspace.Name = "tlpWorkspace";
            this.tlpWorkspace.RowCount = 1;
            this.tlpWorkspace.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpWorkspace.Size = new System.Drawing.Size(1006, 543);
            this.tlpWorkspace.TabIndex = 1;
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(62)))), ((int)(((byte)(50)))));
            this.pnlSidebar.Controls.Add(this.btnSettings);
            this.pnlSidebar.Controls.Add(this.btnReports);
            this.pnlSidebar.Controls.Add(this.btnPayments);
            this.pnlSidebar.Controls.Add(this.btnMaintenance);
            this.pnlSidebar.Controls.Add(this.btnFamilies);
            this.pnlSidebar.Controls.Add(this.btnReservations);
            this.pnlSidebar.Controls.Add(this.btnClassification);
            this.pnlSidebar.Controls.Add(this.btnBurialPlots);
            this.pnlSidebar.Controls.Add(this.btnDashboard);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Padding = new System.Windows.Forms.Padding(12, 20, 10, 10);
            this.pnlSidebar.Size = new System.Drawing.Size(190, 543);
            this.pnlSidebar.TabIndex = 0;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSettings.Location = new System.Drawing.Point(10, 386);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(170, 34);
            this.btnSettings.TabIndex = 8;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.UseVisualStyleBackColor = false;
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.Transparent;
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReports.Location = new System.Drawing.Point(10, 344);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(170, 34);
            this.btnReports.TabIndex = 7;
            this.btnReports.Text = "Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.UseVisualStyleBackColor = false;
            // 
            // btnPayments
            // 
            this.btnPayments.BackColor = System.Drawing.Color.Transparent;
            this.btnPayments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayments.FlatAppearance.BorderSize = 0;
            this.btnPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayments.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayments.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPayments.Location = new System.Drawing.Point(10, 302);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(170, 34);
            this.btnPayments.TabIndex = 6;
            this.btnPayments.Text = "Payments && Transactions";
            this.btnPayments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayments.UseVisualStyleBackColor = false;
            // 
            // btnMaintenance
            // 
            this.btnMaintenance.BackColor = System.Drawing.Color.Transparent;
            this.btnMaintenance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaintenance.FlatAppearance.BorderSize = 0;
            this.btnMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaintenance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaintenance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMaintenance.Location = new System.Drawing.Point(10, 260);
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.Size = new System.Drawing.Size(170, 34);
            this.btnMaintenance.TabIndex = 5;
            this.btnMaintenance.Text = "Maintenance Requests";
            this.btnMaintenance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaintenance.UseVisualStyleBackColor = false;
            // 
            // btnFamilies
            // 
            this.btnFamilies.BackColor = System.Drawing.Color.Transparent;
            this.btnFamilies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFamilies.FlatAppearance.BorderSize = 0;
            this.btnFamilies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFamilies.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFamilies.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnFamilies.Location = new System.Drawing.Point(10, 218);
            this.btnFamilies.Name = "btnFamilies";
            this.btnFamilies.Size = new System.Drawing.Size(170, 34);
            this.btnFamilies.TabIndex = 4;
            this.btnFamilies.Text = "Families && Ownership";
            this.btnFamilies.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFamilies.UseVisualStyleBackColor = false;
            // 
            // btnReservations
            // 
            this.btnReservations.BackColor = System.Drawing.Color.Transparent;
            this.btnReservations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReservations.FlatAppearance.BorderSize = 0;
            this.btnReservations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservations.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservations.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReservations.Location = new System.Drawing.Point(10, 176);
            this.btnReservations.Name = "btnReservations";
            this.btnReservations.Size = new System.Drawing.Size(170, 34);
            this.btnReservations.TabIndex = 3;
            this.btnReservations.Text = "Reservations";
            this.btnReservations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservations.UseVisualStyleBackColor = false;
            // 
            // btnClassification
            // 
            this.btnClassification.BackColor = System.Drawing.Color.Transparent;
            this.btnClassification.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClassification.FlatAppearance.BorderSize = 0;
            this.btnClassification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClassification.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClassification.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClassification.Location = new System.Drawing.Point(10, 134);
            this.btnClassification.Name = "btnClassification";
            this.btnClassification.Size = new System.Drawing.Size(170, 34);
            this.btnClassification.TabIndex = 2;
            this.btnClassification.Text = "Grave Classification";
            this.btnClassification.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClassification.UseVisualStyleBackColor = false;
            // 
            // btnBurialPlots
            // 
            this.btnBurialPlots.BackColor = System.Drawing.Color.Transparent;
            this.btnBurialPlots.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBurialPlots.FlatAppearance.BorderSize = 0;
            this.btnBurialPlots.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBurialPlots.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBurialPlots.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBurialPlots.Location = new System.Drawing.Point(10, 92);
            this.btnBurialPlots.Name = "btnBurialPlots";
            this.btnBurialPlots.Size = new System.Drawing.Size(170, 34);
            this.btnBurialPlots.TabIndex = 1;
            this.btnBurialPlots.Text = "Burial Plots";
            this.btnBurialPlots.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBurialPlots.UseVisualStyleBackColor = false;
            this.btnBurialPlots.Click += new System.EventHandler(this.btnBurialPlots_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(134)))), ((int)(((byte)(117)))));
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDashboard.Location = new System.Drawing.Point(10, 50);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(170, 34);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.Controls.Add(this.tlpDashboard);
            this.pnlDashboard.Controls.Add(this.pnlBurialPlotsPage);
            this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashboard.Location = new System.Drawing.Point(190, 0);
            this.pnlDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Padding = new System.Windows.Forms.Padding(16);
            this.pnlDashboard.Size = new System.Drawing.Size(816, 543);
            this.pnlDashboard.TabIndex = 1;
            this.pnlDashboard.Visible = false;
            // 
            // tlpDashboard
            // 
            this.tlpDashboard.ColumnCount = 1;
            this.tlpDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDashboard.Controls.Add(this.pnlWelcome, 0, 0);
            this.tlpDashboard.Controls.Add(this.tlpStats, 0, 1);
            this.tlpDashboard.Controls.Add(this.tlpLowerDashboard, 0, 2);
            this.tlpDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDashboard.Location = new System.Drawing.Point(16, 16);
            this.tlpDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.tlpDashboard.Name = "tlpDashboard";
            this.tlpDashboard.Padding = new System.Windows.Forms.Padding(20, 16, 20, 12);
            this.tlpDashboard.RowCount = 3;
            this.tlpDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tlpDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tlpDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDashboard.Size = new System.Drawing.Size(784, 511);
            this.tlpDashboard.TabIndex = 0;
            // 
            // pnlWelcome
            // 
            this.pnlWelcome.Controls.Add(this.lblWelcomeSubtitle);
            this.pnlWelcome.Controls.Add(this.lblWelcome);
            this.pnlWelcome.Controls.Add(this.lblSectionTitle);
            this.pnlWelcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWelcome.Location = new System.Drawing.Point(20, 16);
            this.pnlWelcome.Margin = new System.Windows.Forms.Padding(0);
            this.pnlWelcome.Name = "pnlWelcome";
            this.pnlWelcome.Size = new System.Drawing.Size(744, 105);
            this.pnlWelcome.TabIndex = 0;
            // 
            // lblWelcomeSubtitle
            // 
            this.lblWelcomeSubtitle.AutoSize = true;
            this.lblWelcomeSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcomeSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(120)))), ((int)(((byte)(110)))));
            this.lblWelcomeSubtitle.Location = new System.Drawing.Point(2, 62);
            this.lblWelcomeSubtitle.Name = "lblWelcomeSubtitle";
            this.lblWelcomeSubtitle.Size = new System.Drawing.Size(443, 20);
            this.lblWelcomeSubtitle.TabIndex = 2;
            this.lblWelcomeSubtitle.Text = "A thoughtful overview of your cemetery records and daily activity.";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(55)))), ((int)(((byte)(47)))));
            this.lblWelcome.Location = new System.Drawing.Point(0, 18);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(375, 46);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome, Admin";
            // 
            // lblSectionTitle
            // 
            this.lblSectionTitle.AutoSize = true;
            this.lblSectionTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSectionTitle.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSectionTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(134)))), ((int)(((byte)(117)))));
            this.lblSectionTitle.Location = new System.Drawing.Point(4, 0);
            this.lblSectionTitle.Name = "lblSectionTitle";
            this.lblSectionTitle.Size = new System.Drawing.Size(146, 15);
            this.lblSectionTitle.TabIndex = 0;
            this.lblSectionTitle.Text = "DASHBOARD OVERVIEW";
            // 
            // tlpStats
            // 
            this.tlpStats.ColumnCount = 4;
            this.tlpStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpStats.Controls.Add(this.pnlTransactions, 3, 0);
            this.tlpStats.Controls.Add(this.pnlReservations, 2, 0);
            this.tlpStats.Controls.Add(this.pnlOccupiedPlots, 1, 0);
            this.tlpStats.Controls.Add(this.pnlTotalPlots, 0, 0);
            this.tlpStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpStats.Location = new System.Drawing.Point(20, 121);
            this.tlpStats.Margin = new System.Windows.Forms.Padding(0);
            this.tlpStats.Name = "tlpStats";
            this.tlpStats.RowCount = 1;
            this.tlpStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpStats.Size = new System.Drawing.Size(744, 135);
            this.tlpStats.TabIndex = 1;
            // 
            // pnlTransactions
            // 
            this.pnlTransactions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(224)))));
            this.pnlTransactions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTransactions.Controls.Add(this.lblTransactionsDescription);
            this.pnlTransactions.Controls.Add(this.lbltransactionValue);
            this.pnlTransactions.Controls.Add(this.pnlTransaction);
            this.pnlTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTransactions.Location = new System.Drawing.Point(563, 4);
            this.pnlTransactions.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pnlTransactions.Name = "pnlTransactions";
            this.pnlTransactions.Size = new System.Drawing.Size(176, 127);
            this.pnlTransactions.TabIndex = 3;
            // 
            // lblTransactionsDescription
            // 
            this.lblTransactionsDescription.AutoSize = true;
            this.lblTransactionsDescription.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionsDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(134)))), ((int)(((byte)(117)))));
            this.lblTransactionsDescription.Location = new System.Drawing.Point(12, 82);
            this.lblTransactionsDescription.Name = "lblTransactionsDescription";
            this.lblTransactionsDescription.Size = new System.Drawing.Size(72, 17);
            this.lblTransactionsDescription.TabIndex = 7;
            this.lblTransactionsDescription.Text = "This month";
            // 
            // lbltransactionValue
            // 
            this.lbltransactionValue.AutoSize = true;
            this.lbltransactionValue.Font = new System.Drawing.Font("Georgia", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltransactionValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(55)))), ((int)(((byte)(47)))));
            this.lbltransactionValue.Location = new System.Drawing.Point(12, 38);
            this.lbltransactionValue.Name = "lbltransactionValue";
            this.lbltransactionValue.Size = new System.Drawing.Size(71, 43);
            this.lbltransactionValue.TabIndex = 6;
            this.lbltransactionValue.Text = "00";
            // 
            // pnlTransaction
            // 
            this.pnlTransaction.AutoSize = true;
            this.pnlTransaction.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlTransaction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(55)))), ((int)(((byte)(47)))));
            this.pnlTransaction.Location = new System.Drawing.Point(12, 12);
            this.pnlTransaction.Name = "pnlTransaction";
            this.pnlTransaction.Size = new System.Drawing.Size(139, 20);
            this.pnlTransaction.TabIndex = 6;
            this.pnlTransaction.Text = "Recent Transactions";
            // 
            // pnlReservations
            // 
            this.pnlReservations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(224)))));
            this.pnlReservations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlReservations.Controls.Add(this.lblReservationsDescription);
            this.pnlReservations.Controls.Add(this.lblReservationValue);
            this.pnlReservations.Controls.Add(this.pnlReservation);
            this.pnlReservations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReservations.Location = new System.Drawing.Point(377, 4);
            this.pnlReservations.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pnlReservations.Name = "pnlReservations";
            this.pnlReservations.Size = new System.Drawing.Size(176, 127);
            this.pnlReservations.TabIndex = 2;
            // 
            // lblReservationsDescription
            // 
            this.lblReservationsDescription.AutoSize = true;
            this.lblReservationsDescription.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservationsDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(134)))), ((int)(((byte)(117)))));
            this.lblReservationsDescription.Location = new System.Drawing.Point(12, 82);
            this.lblReservationsDescription.Name = "lblReservationsDescription";
            this.lblReservationsDescription.Size = new System.Drawing.Size(97, 17);
            this.lblReservationsDescription.TabIndex = 6;
            this.lblReservationsDescription.Text = "Pending & Active";
            // 
            // lblReservationValue
            // 
            this.lblReservationValue.AutoSize = true;
            this.lblReservationValue.Font = new System.Drawing.Font("Georgia", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservationValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(55)))), ((int)(((byte)(47)))));
            this.lblReservationValue.Location = new System.Drawing.Point(12, 38);
            this.lblReservationValue.Name = "lblReservationValue";
            this.lblReservationValue.Size = new System.Drawing.Size(71, 43);
            this.lblReservationValue.TabIndex = 5;
            this.lblReservationValue.Text = "00";
            // 
            // pnlReservation
            // 
            this.pnlReservation.AutoSize = true;
            this.pnlReservation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlReservation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(55)))), ((int)(((byte)(47)))));
            this.pnlReservation.Location = new System.Drawing.Point(12, 12);
            this.pnlReservation.Name = "pnlReservation";
            this.pnlReservation.Size = new System.Drawing.Size(92, 20);
            this.pnlReservation.TabIndex = 0;
            this.pnlReservation.Text = "Reservations";
            // 
            // pnlOccupiedPlots
            // 
            this.pnlOccupiedPlots.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(224)))));
            this.pnlOccupiedPlots.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOccupiedPlots.Controls.Add(this.lblOccupiedDescription);
            this.pnlOccupiedPlots.Controls.Add(this.lblTotalOccupeidPlotsValue);
            this.pnlOccupiedPlots.Controls.Add(this.lblOccupiedPlots);
            this.pnlOccupiedPlots.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOccupiedPlots.Location = new System.Drawing.Point(191, 4);
            this.pnlOccupiedPlots.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pnlOccupiedPlots.Name = "pnlOccupiedPlots";
            this.pnlOccupiedPlots.Size = new System.Drawing.Size(176, 127);
            this.pnlOccupiedPlots.TabIndex = 1;
            // 
            // lblOccupiedDescription
            // 
            this.lblOccupiedDescription.AutoSize = true;
            this.lblOccupiedDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblOccupiedDescription.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOccupiedDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(134)))), ((int)(((byte)(117)))));
            this.lblOccupiedDescription.Location = new System.Drawing.Point(12, 82);
            this.lblOccupiedDescription.Name = "lblOccupiedDescription";
            this.lblOccupiedDescription.Size = new System.Drawing.Size(72, 17);
            this.lblOccupiedDescription.TabIndex = 4;
            this.lblOccupiedDescription.Text = "0% of total";
            // 
            // lblTotalOccupeidPlotsValue
            // 
            this.lblTotalOccupeidPlotsValue.AutoSize = true;
            this.lblTotalOccupeidPlotsValue.Font = new System.Drawing.Font("Georgia", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOccupeidPlotsValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(55)))), ((int)(((byte)(47)))));
            this.lblTotalOccupeidPlotsValue.Location = new System.Drawing.Point(12, 38);
            this.lblTotalOccupeidPlotsValue.Name = "lblTotalOccupeidPlotsValue";
            this.lblTotalOccupeidPlotsValue.Size = new System.Drawing.Size(71, 43);
            this.lblTotalOccupeidPlotsValue.TabIndex = 3;
            this.lblTotalOccupeidPlotsValue.Text = "00";
            // 
            // lblOccupiedPlots
            // 
            this.lblOccupiedPlots.AutoSize = true;
            this.lblOccupiedPlots.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOccupiedPlots.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(55)))), ((int)(((byte)(47)))));
            this.lblOccupiedPlots.Location = new System.Drawing.Point(12, 12);
            this.lblOccupiedPlots.Name = "lblOccupiedPlots";
            this.lblOccupiedPlots.Size = new System.Drawing.Size(108, 20);
            this.lblOccupiedPlots.TabIndex = 1;
            this.lblOccupiedPlots.Text = "Occupied Plots";
            // 
            // pnlTotalPlots
            // 
            this.pnlTotalPlots.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(224)))));
            this.pnlTotalPlots.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalPlots.Controls.Add(this.lblTotalPlotsDescription);
            this.pnlTotalPlots.Controls.Add(this.lblTotalPlotsValue);
            this.pnlTotalPlots.Controls.Add(this.lblTotalPlotsTitle);
            this.pnlTotalPlots.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTotalPlots.Location = new System.Drawing.Point(5, 4);
            this.pnlTotalPlots.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pnlTotalPlots.Name = "pnlTotalPlots";
            this.pnlTotalPlots.Size = new System.Drawing.Size(176, 127);
            this.pnlTotalPlots.TabIndex = 0;
            // 
            // lblTotalPlotsDescription
            // 
            this.lblTotalPlotsDescription.AutoSize = true;
            this.lblTotalPlotsDescription.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPlotsDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(134)))), ((int)(((byte)(117)))));
            this.lblTotalPlotsDescription.Location = new System.Drawing.Point(12, 82);
            this.lblTotalPlotsDescription.Name = "lblTotalPlotsDescription";
            this.lblTotalPlotsDescription.Size = new System.Drawing.Size(100, 17);
            this.lblTotalPlotsDescription.TabIndex = 2;
            this.lblTotalPlotsDescription.Text = "View all plots →";
            // 
            // lblTotalPlotsValue
            // 
            this.lblTotalPlotsValue.AutoSize = true;
            this.lblTotalPlotsValue.Font = new System.Drawing.Font("Georgia", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPlotsValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(55)))), ((int)(((byte)(47)))));
            this.lblTotalPlotsValue.Location = new System.Drawing.Point(12, 38);
            this.lblTotalPlotsValue.Name = "lblTotalPlotsValue";
            this.lblTotalPlotsValue.Size = new System.Drawing.Size(71, 43);
            this.lblTotalPlotsValue.TabIndex = 1;
            this.lblTotalPlotsValue.Text = "00";
            // 
            // lblTotalPlotsTitle
            // 
            this.lblTotalPlotsTitle.AutoSize = true;
            this.lblTotalPlotsTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPlotsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(55)))), ((int)(((byte)(47)))));
            this.lblTotalPlotsTitle.Location = new System.Drawing.Point(12, 12);
            this.lblTotalPlotsTitle.Name = "lblTotalPlotsTitle";
            this.lblTotalPlotsTitle.Size = new System.Drawing.Size(120, 20);
            this.lblTotalPlotsTitle.TabIndex = 0;
            this.lblTotalPlotsTitle.Text = "Total Burial Plots";
            // 
            // tlpLowerDashboard
            // 
            this.tlpLowerDashboard.ColumnCount = 2;
            this.tlpLowerDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68F));
            this.tlpLowerDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tlpLowerDashboard.Controls.Add(this.pnlRecentRecords, 0, 0);
            this.tlpLowerDashboard.Controls.Add(this.tlpRightColumn, 1, 0);
            this.tlpLowerDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLowerDashboard.Location = new System.Drawing.Point(20, 256);
            this.tlpLowerDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.tlpLowerDashboard.Name = "tlpLowerDashboard";
            this.tlpLowerDashboard.RowCount = 1;
            this.tlpLowerDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLowerDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 243F));
            this.tlpLowerDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 243F));
            this.tlpLowerDashboard.Size = new System.Drawing.Size(744, 243);
            this.tlpLowerDashboard.TabIndex = 2;
            // 
            // pnlRecentRecords
            // 
            this.pnlRecentRecords.Controls.Add(this.dgvRecentRecords);
            this.pnlRecentRecords.Controls.Add(this.txtSearchRecords);
            this.pnlRecentRecords.Controls.Add(this.lblRecentSubtitle);
            this.pnlRecentRecords.Controls.Add(this.lblRecentTitle);
            this.pnlRecentRecords.Controls.Add(this.lblActivityLabel);
            this.pnlRecentRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRecentRecords.Location = new System.Drawing.Point(0, 8);
            this.pnlRecentRecords.Margin = new System.Windows.Forms.Padding(0, 8, 8, 0);
            this.pnlRecentRecords.Name = "pnlRecentRecords";
            this.pnlRecentRecords.Padding = new System.Windows.Forms.Padding(12);
            this.pnlRecentRecords.Size = new System.Drawing.Size(497, 235);
            this.pnlRecentRecords.TabIndex = 0;
            // 
            // dgvRecentRecords
            // 
            this.dgvRecentRecords.AllowUserToAddRows = false;
            this.dgvRecentRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRecentRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecentRecords.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.dgvRecentRecords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(55)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecentRecords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRecentRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecentRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDate,
            this.colName,
            this.colType,
            this.colStatus,
            this.colAction});
            this.dgvRecentRecords.EnableHeadersVisualStyles = false;
            this.dgvRecentRecords.Location = new System.Drawing.Point(12, 132);
            this.dgvRecentRecords.Name = "dgvRecentRecords";
            this.dgvRecentRecords.ReadOnly = true;
            this.dgvRecentRecords.RowHeadersVisible = false;
            this.dgvRecentRecords.RowHeadersWidth = 51;
            this.dgvRecentRecords.RowTemplate.Height = 24;
            this.dgvRecentRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecentRecords.Size = new System.Drawing.Size(520, 340);
            this.dgvRecentRecords.TabIndex = 4;
            // 
            // colDate
            // 
            this.colDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDate.HeaderText = "Date";
            this.colDate.MinimumWidth = 6;
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            this.colDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colType
            // 
            this.colType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colType.HeaderText = "Type";
            this.colType.MinimumWidth = 6;
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            this.colType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colStatus
            // 
            this.colStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colStatus.HeaderText = "Status";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colAction
            // 
            this.colAction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAction.HeaderText = "Action";
            this.colAction.MinimumWidth = 6;
            this.colAction.Name = "colAction";
            this.colAction.ReadOnly = true;
            this.colAction.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtSearchRecords
            // 
            this.txtSearchRecords.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchRecords.Location = new System.Drawing.Point(12, 94);
            this.txtSearchRecords.Name = "txtSearchRecords";
            this.txtSearchRecords.Size = new System.Drawing.Size(230, 27);
            this.txtSearchRecords.TabIndex = 3;
            // 
            // lblRecentSubtitle
            // 
            this.lblRecentSubtitle.AutoSize = true;
            this.lblRecentSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblRecentSubtitle.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecentSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(134)))), ((int)(((byte)(117)))));
            this.lblRecentSubtitle.Location = new System.Drawing.Point(12, 62);
            this.lblRecentSubtitle.Name = "lblRecentSubtitle";
            this.lblRecentSubtitle.Size = new System.Drawing.Size(294, 17);
            this.lblRecentSubtitle.TabIndex = 2;
            this.lblRecentSubtitle.Text = "A record of the moments and details that matter.";
            // 
            // lblRecentTitle
            // 
            this.lblRecentTitle.AutoSize = true;
            this.lblRecentTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblRecentTitle.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecentTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(55)))), ((int)(((byte)(47)))));
            this.lblRecentTitle.Location = new System.Drawing.Point(12, 30);
            this.lblRecentTitle.Name = "lblRecentTitle";
            this.lblRecentTitle.Size = new System.Drawing.Size(223, 35);
            this.lblRecentTitle.TabIndex = 1;
            this.lblRecentTitle.Text = "Recent Records";
            // 
            // lblActivityLabel
            // 
            this.lblActivityLabel.AutoSize = true;
            this.lblActivityLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblActivityLabel.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(134)))), ((int)(((byte)(117)))));
            this.lblActivityLabel.Location = new System.Drawing.Point(12, 12);
            this.lblActivityLabel.Name = "lblActivityLabel";
            this.lblActivityLabel.Size = new System.Drawing.Size(86, 15);
            this.lblActivityLabel.TabIndex = 0;
            this.lblActivityLabel.Text = "ACTIVITY LOG";
            // 
            // tlpRightColumn
            // 
            this.tlpRightColumn.ColumnCount = 1;
            this.tlpRightColumn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRightColumn.Controls.Add(this.pnlMemorialCard, 0, 0);
            this.tlpRightColumn.Controls.Add(this.pnlQuickActions, 0, 1);
            this.tlpRightColumn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRightColumn.Location = new System.Drawing.Point(508, 3);
            this.tlpRightColumn.Name = "tlpRightColumn";
            this.tlpRightColumn.RowCount = 2;
            this.tlpRightColumn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpRightColumn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpRightColumn.Size = new System.Drawing.Size(233, 237);
            this.tlpRightColumn.TabIndex = 1;
            // 
            // pnlMemorialCard
            // 
            this.pnlMemorialCard.Controls.Add(this.tlpMemorialContent);
            this.pnlMemorialCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMemorialCard.Location = new System.Drawing.Point(3, 3);
            this.pnlMemorialCard.Name = "pnlMemorialCard";
            this.pnlMemorialCard.Size = new System.Drawing.Size(227, 136);
            this.pnlMemorialCard.TabIndex = 0;
            // 
            // tlpMemorialContent
            // 
            this.tlpMemorialContent.ColumnCount = 1;
            this.tlpMemorialContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMemorialContent.Controls.Add(this.picMemorial, 0, 1);
            this.tlpMemorialContent.Controls.Add(this.pnlMemorialInfo, 0, 0);
            this.tlpMemorialContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMemorialContent.Location = new System.Drawing.Point(0, 0);
            this.tlpMemorialContent.Name = "tlpMemorialContent";
            this.tlpMemorialContent.RowCount = 2;
            this.tlpMemorialContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tlpMemorialContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMemorialContent.Size = new System.Drawing.Size(227, 136);
            this.tlpMemorialContent.TabIndex = 0;
            // 
            // picMemorial
            // 
            this.picMemorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(224)))));
            this.picMemorial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picMemorial.Image = global::CMS_TAHANAN.Properties.Resources.Serene_Hillside_Memorial_Garden;
            this.picMemorial.Location = new System.Drawing.Point(0, 85);
            this.picMemorial.Margin = new System.Windows.Forms.Padding(0);
            this.picMemorial.Name = "picMemorial";
            this.picMemorial.Size = new System.Drawing.Size(227, 51);
            this.picMemorial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMemorial.TabIndex = 2;
            this.picMemorial.TabStop = false;
            // 
            // pnlMemorialInfo
            // 
            this.pnlMemorialInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(224)))));
            this.pnlMemorialInfo.Controls.Add(this.lblMemorialTime);
            this.pnlMemorialInfo.Controls.Add(this.lblMemorialDate);
            this.pnlMemorialInfo.Controls.Add(this.lblTodayLocation);
            this.pnlMemorialInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMemorialInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlMemorialInfo.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMemorialInfo.Name = "pnlMemorialInfo";
            this.pnlMemorialInfo.Padding = new System.Windows.Forms.Padding(12, 4, 8, 4);
            this.pnlMemorialInfo.Size = new System.Drawing.Size(227, 85);
            this.pnlMemorialInfo.TabIndex = 0;
            // 
            // lblMemorialTime
            // 
            this.lblMemorialTime.AutoSize = true;
            this.lblMemorialTime.BackColor = System.Drawing.Color.Transparent;
            this.lblMemorialTime.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemorialTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(55)))), ((int)(((byte)(47)))));
            this.lblMemorialTime.Location = new System.Drawing.Point(12, 52);
            this.lblMemorialTime.Name = "lblMemorialTime";
            this.lblMemorialTime.Size = new System.Drawing.Size(133, 32);
            this.lblMemorialTime.TabIndex = 2;
            this.lblMemorialTime.Text = "00:00 --";
            // 
            // lblMemorialDate
            // 
            this.lblMemorialDate.AutoSize = true;
            this.lblMemorialDate.BackColor = System.Drawing.Color.Transparent;
            this.lblMemorialDate.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemorialDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(55)))), ((int)(((byte)(47)))));
            this.lblMemorialDate.Location = new System.Drawing.Point(12, 25);
            this.lblMemorialDate.Name = "lblMemorialDate";
            this.lblMemorialDate.Size = new System.Drawing.Size(112, 21);
            this.lblMemorialDate.TabIndex = 1;
            this.lblMemorialDate.Text = "-, - 00, 0000";
            // 
            // lblTodayLocation
            // 
            this.lblTodayLocation.AutoSize = true;
            this.lblTodayLocation.BackColor = System.Drawing.Color.Transparent;
            this.lblTodayLocation.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(134)))), ((int)(((byte)(117)))));
            this.lblTodayLocation.Location = new System.Drawing.Point(12, 5);
            this.lblTodayLocation.Name = "lblTodayLocation";
            this.lblTodayLocation.Size = new System.Drawing.Size(90, 15);
            this.lblTodayLocation.TabIndex = 0;
            this.lblTodayLocation.Text = "Today in Davao";
            // 
            // pnlQuickActions
            // 
            this.pnlQuickActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlQuickActions.Location = new System.Drawing.Point(3, 145);
            this.pnlQuickActions.Name = "pnlQuickActions";
            this.pnlQuickActions.Size = new System.Drawing.Size(227, 89);
            this.pnlQuickActions.TabIndex = 1;
            // 
            // pnlBurialPlotsPage
            // 
            this.pnlBurialPlotsPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(243)))), ((int)(((byte)(234)))));
            this.pnlBurialPlotsPage.Controls.Add(this.tlpBurialRoot);
            this.pnlBurialPlotsPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBurialPlotsPage.Location = new System.Drawing.Point(16, 16);
            this.pnlBurialPlotsPage.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBurialPlotsPage.Name = "pnlBurialPlotsPage";
            this.pnlBurialPlotsPage.Size = new System.Drawing.Size(784, 511);
            this.pnlBurialPlotsPage.TabIndex = 1;
            this.pnlBurialPlotsPage.Visible = false;
            // 
            // tlpBurialRoot
            // 
            this.tlpBurialRoot.ColumnCount = 1;
            this.tlpBurialRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBurialRoot.Controls.Add(this.pnlBPHeader, 0, 0);
            this.tlpBurialRoot.Controls.Add(this.tlpBPStats, 0, 1);
            this.tlpBurialRoot.Controls.Add(this.pnlBPFilters, 0, 2);
            this.tlpBurialRoot.Controls.Add(this.pnlBPRegistry, 0, 3);
            this.tlpBurialRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBurialRoot.Location = new System.Drawing.Point(0, 0);
            this.tlpBurialRoot.Margin = new System.Windows.Forms.Padding(0);
            this.tlpBurialRoot.Name = "tlpBurialRoot";
            this.tlpBurialRoot.RowCount = 4;
            this.tlpBurialRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tlpBurialRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tlpBurialRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tlpBurialRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBurialRoot.Size = new System.Drawing.Size(784, 511);
            this.tlpBurialRoot.TabIndex = 0;
            // 
            // pnlBPHeader
            // 
            this.pnlBPHeader.Controls.Add(this.lblBPSubtitle);
            this.pnlBPHeader.Controls.Add(this.btnAddBurialPlot);
            this.pnlBPHeader.Controls.Add(this.lblBPTitle);
            this.pnlBPHeader.Controls.Add(this.lblBPSection);
            this.pnlBPHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBPHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlBPHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBPHeader.Name = "pnlBPHeader";
            this.pnlBPHeader.Size = new System.Drawing.Size(784, 92);
            this.pnlBPHeader.TabIndex = 0;
            // 
            // lblBPSubtitle
            // 
            this.lblBPSubtitle.AutoSize = true;
            this.lblBPSubtitle.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBPSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(139)))), ((int)(((byte)(124)))));
            this.lblBPSubtitle.Location = new System.Drawing.Point(2, 61);
            this.lblBPSubtitle.Name = "lblBPSubtitle";
            this.lblBPSubtitle.Size = new System.Drawing.Size(522, 17);
            this.lblBPSubtitle.TabIndex = 2;
            this.lblBPSubtitle.Text = "Manage cemetery plot records, track availability status, and review occupant allo" +
    "cations.";
            // 
            // btnAddBurialPlot
            // 
            this.btnAddBurialPlot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddBurialPlot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.btnAddBurialPlot.FlatAppearance.BorderSize = 0;
            this.btnAddBurialPlot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBurialPlot.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBurialPlot.ForeColor = System.Drawing.Color.White;
            this.btnAddBurialPlot.Location = new System.Drawing.Point(661, 16);
            this.btnAddBurialPlot.Name = "btnAddBurialPlot";
            this.btnAddBurialPlot.Size = new System.Drawing.Size(120, 34);
            this.btnAddBurialPlot.TabIndex = 1;
            this.btnAddBurialPlot.Text = "+ Add Burial Plot";
            this.btnAddBurialPlot.UseVisualStyleBackColor = false;
            // 
            // lblBPTitle
            // 
            this.lblBPTitle.AutoSize = true;
            this.lblBPTitle.Font = new System.Drawing.Font("Georgia", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBPTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(48)))), ((int)(((byte)(40)))));
            this.lblBPTitle.Location = new System.Drawing.Point(0, 18);
            this.lblBPTitle.Name = "lblBPTitle";
            this.lblBPTitle.Size = new System.Drawing.Size(238, 48);
            this.lblBPTitle.TabIndex = 1;
            this.lblBPTitle.Text = "Burial Plots";
            // 
            // lblBPSection
            // 
            this.lblBPSection.AutoSize = true;
            this.lblBPSection.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBPSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(111)))), ((int)(((byte)(83)))));
            this.lblBPSection.Location = new System.Drawing.Point(0, 2);
            this.lblBPSection.Name = "lblBPSection";
            this.lblBPSection.Size = new System.Drawing.Size(139, 15);
            this.lblBPSection.TabIndex = 0;
            this.lblBPSection.Text = "\t— CEMETERY REGISTRY";
            // 
            // tlpBPStats
            // 
            this.tlpBPStats.ColumnCount = 4;
            this.tlpBPStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpBPStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpBPStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpBPStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpBPStats.Controls.Add(this.pnlBPTotal, 0, 0);
            this.tlpBPStats.Controls.Add(this.pnlBPAvailable, 1, 0);
            this.tlpBPStats.Controls.Add(this.pnlBPOccupied, 2, 0);
            this.tlpBPStats.Controls.Add(this.pnlBPReserved, 3, 0);
            this.tlpBPStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBPStats.Location = new System.Drawing.Point(0, 92);
            this.tlpBPStats.Margin = new System.Windows.Forms.Padding(0);
            this.tlpBPStats.Name = "tlpBPStats";
            this.tlpBPStats.RowCount = 1;
            this.tlpBPStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBPStats.Size = new System.Drawing.Size(784, 92);
            this.tlpBPStats.TabIndex = 1;
            // 
            // pnlBPTotal
            // 
            this.pnlBPTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(221)))));
            this.pnlBPTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBPTotal.Controls.Add(this.lblBPTotalDescription);
            this.pnlBPTotal.Controls.Add(this.lblBPTotalValue);
            this.pnlBPTotal.Controls.Add(this.lblBPTotalTitle);
            this.pnlBPTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBPTotal.Location = new System.Drawing.Point(4, 3);
            this.pnlBPTotal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlBPTotal.Name = "pnlBPTotal";
            this.pnlBPTotal.Padding = new System.Windows.Forms.Padding(10, 8, 8, 5);
            this.pnlBPTotal.Size = new System.Drawing.Size(188, 86);
            this.pnlBPTotal.TabIndex = 0;
            // 
            // lblBPTotalDescription
            // 
            this.lblBPTotalDescription.AutoSize = true;
            this.lblBPTotalDescription.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBPTotalDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(139)))), ((int)(((byte)(124)))));
            this.lblBPTotalDescription.Location = new System.Drawing.Point(10, 60);
            this.lblBPTotalDescription.Name = "lblBPTotalDescription";
            this.lblBPTotalDescription.Size = new System.Drawing.Size(76, 15);
            this.lblBPTotalDescription.TabIndex = 2;
            this.lblBPTotalDescription.Text = "All 4 sections";
            // 
            // lblBPTotalValue
            // 
            this.lblBPTotalValue.AutoSize = true;
            this.lblBPTotalValue.Font = new System.Drawing.Font("Georgia", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBPTotalValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(48)))), ((int)(((byte)(40)))));
            this.lblBPTotalValue.Location = new System.Drawing.Point(10, 27);
            this.lblBPTotalValue.Name = "lblBPTotalValue";
            this.lblBPTotalValue.Size = new System.Drawing.Size(37, 38);
            this.lblBPTotalValue.TabIndex = 1;
            this.lblBPTotalValue.Text = "0";
            // 
            // lblBPTotalTitle
            // 
            this.lblBPTotalTitle.AutoSize = true;
            this.lblBPTotalTitle.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBPTotalTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(120)))), ((int)(((byte)(110)))));
            this.lblBPTotalTitle.Location = new System.Drawing.Point(10, 9);
            this.lblBPTotalTitle.Name = "lblBPTotalTitle";
            this.lblBPTotalTitle.Size = new System.Drawing.Size(82, 15);
            this.lblBPTotalTitle.TabIndex = 0;
            this.lblBPTotalTitle.Text = "TOTAL PLOTS";
            // 
            // pnlBPAvailable
            // 
            this.pnlBPAvailable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(221)))));
            this.pnlBPAvailable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBPAvailable.Controls.Add(this.lblBPAvailableDescription);
            this.pnlBPAvailable.Controls.Add(this.lblBPAvailableValue);
            this.pnlBPAvailable.Controls.Add(this.lblBPAvailableTitle);
            this.pnlBPAvailable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBPAvailable.Location = new System.Drawing.Point(200, 3);
            this.pnlBPAvailable.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlBPAvailable.Name = "pnlBPAvailable";
            this.pnlBPAvailable.Padding = new System.Windows.Forms.Padding(10, 8, 8, 5);
            this.pnlBPAvailable.Size = new System.Drawing.Size(188, 86);
            this.pnlBPAvailable.TabIndex = 1;
            // 
            // lblBPAvailableDescription
            // 
            this.lblBPAvailableDescription.AutoSize = true;
            this.lblBPAvailableDescription.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBPAvailableDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(139)))), ((int)(((byte)(124)))));
            this.lblBPAvailableDescription.Location = new System.Drawing.Point(10, 60);
            this.lblBPAvailableDescription.Name = "lblBPAvailableDescription";
            this.lblBPAvailableDescription.Size = new System.Drawing.Size(80, 15);
            this.lblBPAvailableDescription.TabIndex = 3;
            this.lblBPAvailableDescription.Text = "Ready for sale";
            // 
            // lblBPAvailableValue
            // 
            this.lblBPAvailableValue.AutoSize = true;
            this.lblBPAvailableValue.Font = new System.Drawing.Font("Georgia", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBPAvailableValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(48)))), ((int)(((byte)(40)))));
            this.lblBPAvailableValue.Location = new System.Drawing.Point(10, 27);
            this.lblBPAvailableValue.Name = "lblBPAvailableValue";
            this.lblBPAvailableValue.Size = new System.Drawing.Size(37, 38);
            this.lblBPAvailableValue.TabIndex = 2;
            this.lblBPAvailableValue.Text = "0";
            // 
            // lblBPAvailableTitle
            // 
            this.lblBPAvailableTitle.AutoSize = true;
            this.lblBPAvailableTitle.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBPAvailableTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(120)))), ((int)(((byte)(110)))));
            this.lblBPAvailableTitle.Location = new System.Drawing.Point(10, 9);
            this.lblBPAvailableTitle.Name = "lblBPAvailableTitle";
            this.lblBPAvailableTitle.Size = new System.Drawing.Size(106, 15);
            this.lblBPAvailableTitle.TabIndex = 0;
            this.lblBPAvailableTitle.Text = "AVAILABLE PLOTS";
            // 
            // pnlBPOccupied
            // 
            this.pnlBPOccupied.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(221)))));
            this.pnlBPOccupied.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBPOccupied.Controls.Add(this.lblBPOccupiedDescription);
            this.pnlBPOccupied.Controls.Add(this.lblBPOccupiedValue);
            this.pnlBPOccupied.Controls.Add(this.lblBPOccupiedTitle);
            this.pnlBPOccupied.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBPOccupied.Location = new System.Drawing.Point(396, 3);
            this.pnlBPOccupied.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlBPOccupied.Name = "pnlBPOccupied";
            this.pnlBPOccupied.Padding = new System.Windows.Forms.Padding(10, 8, 8, 5);
            this.pnlBPOccupied.Size = new System.Drawing.Size(188, 86);
            this.pnlBPOccupied.TabIndex = 2;
            // 
            // lblBPOccupiedDescription
            // 
            this.lblBPOccupiedDescription.AutoSize = true;
            this.lblBPOccupiedDescription.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBPOccupiedDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(139)))), ((int)(((byte)(124)))));
            this.lblBPOccupiedDescription.Location = new System.Drawing.Point(10, 60);
            this.lblBPOccupiedDescription.Name = "lblBPOccupiedDescription";
            this.lblBPOccupiedDescription.Size = new System.Drawing.Size(92, 15);
            this.lblBPOccupiedDescription.TabIndex = 3;
            this.lblBPOccupiedDescription.Text = "Deed confirmed";
            // 
            // lblBPOccupiedValue
            // 
            this.lblBPOccupiedValue.AutoSize = true;
            this.lblBPOccupiedValue.Font = new System.Drawing.Font("Georgia", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBPOccupiedValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(48)))), ((int)(((byte)(40)))));
            this.lblBPOccupiedValue.Location = new System.Drawing.Point(10, 27);
            this.lblBPOccupiedValue.Name = "lblBPOccupiedValue";
            this.lblBPOccupiedValue.Size = new System.Drawing.Size(37, 38);
            this.lblBPOccupiedValue.TabIndex = 2;
            this.lblBPOccupiedValue.Text = "0";
            // 
            // lblBPOccupiedTitle
            // 
            this.lblBPOccupiedTitle.AutoSize = true;
            this.lblBPOccupiedTitle.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBPOccupiedTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(120)))), ((int)(((byte)(110)))));
            this.lblBPOccupiedTitle.Location = new System.Drawing.Point(10, 9);
            this.lblBPOccupiedTitle.Name = "lblBPOccupiedTitle";
            this.lblBPOccupiedTitle.Size = new System.Drawing.Size(104, 15);
            this.lblBPOccupiedTitle.TabIndex = 0;
            this.lblBPOccupiedTitle.Text = "OCCUPIED PLOTS";
            // 
            // pnlBPReserved
            // 
            this.pnlBPReserved.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(221)))));
            this.pnlBPReserved.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBPReserved.Controls.Add(this.lblBPReservedDescription);
            this.pnlBPReserved.Controls.Add(this.lblBPReservedValue);
            this.pnlBPReserved.Controls.Add(this.lblBPReservedTitle);
            this.pnlBPReserved.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBPReserved.Location = new System.Drawing.Point(592, 3);
            this.pnlBPReserved.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlBPReserved.Name = "pnlBPReserved";
            this.pnlBPReserved.Padding = new System.Windows.Forms.Padding(10, 8, 8, 5);
            this.pnlBPReserved.Size = new System.Drawing.Size(188, 86);
            this.pnlBPReserved.TabIndex = 3;
            // 
            // lblBPReservedDescription
            // 
            this.lblBPReservedDescription.AutoSize = true;
            this.lblBPReservedDescription.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBPReservedDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(139)))), ((int)(((byte)(124)))));
            this.lblBPReservedDescription.Location = new System.Drawing.Point(10, 60);
            this.lblBPReservedDescription.Name = "lblBPReservedDescription";
            this.lblBPReservedDescription.Size = new System.Drawing.Size(72, 15);
            this.lblBPReservedDescription.TabIndex = 3;
            this.lblBPReservedDescription.Text = "Active holds";
            // 
            // lblBPReservedValue
            // 
            this.lblBPReservedValue.AutoSize = true;
            this.lblBPReservedValue.Font = new System.Drawing.Font("Georgia", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBPReservedValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(48)))), ((int)(((byte)(40)))));
            this.lblBPReservedValue.Location = new System.Drawing.Point(10, 27);
            this.lblBPReservedValue.Name = "lblBPReservedValue";
            this.lblBPReservedValue.Size = new System.Drawing.Size(37, 38);
            this.lblBPReservedValue.TabIndex = 2;
            this.lblBPReservedValue.Text = "0";
            // 
            // lblBPReservedTitle
            // 
            this.lblBPReservedTitle.AutoSize = true;
            this.lblBPReservedTitle.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBPReservedTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(120)))), ((int)(((byte)(110)))));
            this.lblBPReservedTitle.Location = new System.Drawing.Point(10, 9);
            this.lblBPReservedTitle.Name = "lblBPReservedTitle";
            this.lblBPReservedTitle.Size = new System.Drawing.Size(104, 15);
            this.lblBPReservedTitle.TabIndex = 0;
            this.lblBPReservedTitle.Text = "RESERVED PLOTS";
            // 
            // pnlBPFilters
            // 
            this.pnlBPFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(221)))));
            this.pnlBPFilters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBPFilters.Controls.Add(this.cmbPlotSection);
            this.pnlBPFilters.Controls.Add(this.cmbPlotType);
            this.pnlBPFilters.Controls.Add(this.lblMoreFilters);
            this.pnlBPFilters.Controls.Add(this.btnReservedFilter);
            this.pnlBPFilters.Controls.Add(this.btnOccupiedFilter);
            this.pnlBPFilters.Controls.Add(this.btnAvailableFilter);
            this.pnlBPFilters.Controls.Add(this.btnAllStatus);
            this.pnlBPFilters.Controls.Add(this.lblStatusFilter);
            this.pnlBPFilters.Controls.Add(this.txtPlotSearch);
            this.pnlBPFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBPFilters.Location = new System.Drawing.Point(4, 189);
            this.pnlBPFilters.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlBPFilters.Name = "pnlBPFilters";
            this.pnlBPFilters.Padding = new System.Windows.Forms.Padding(10);
            this.pnlBPFilters.Size = new System.Drawing.Size(776, 84);
            this.pnlBPFilters.TabIndex = 2;
            // 
            // cmbPlotSection
            // 
            this.cmbPlotSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlotSection.FormattingEnabled = true;
            this.cmbPlotSection.Items.AddRange(new object[] {
            "All Sections",
            "",
            "",
            "",
            "",
            "Section A - St. Gabriel",
            "",
            "",
            "",
            "",
            "Section B - St. Michael",
            "",
            "",
            "",
            "",
            "Section C - St. Raphael",
            "",
            "",
            "",
            "",
            "Section D - Holy Cross"});
            this.cmbPlotSection.Location = new System.Drawing.Point(293, 44);
            this.cmbPlotSection.Name = "cmbPlotSection";
            this.cmbPlotSection.Size = new System.Drawing.Size(120, 27);
            this.cmbPlotSection.TabIndex = 8;
            // 
            // cmbPlotType
            // 
            this.cmbPlotType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlotType.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPlotType.FormattingEnabled = true;
            this.cmbPlotType.Items.AddRange(new object[] {
            "All Plot Types",
            "",
            "",
            "",
            "",
            "Burial Plot",
            "",
            "",
            "",
            "",
            "Family Plot",
            "",
            "",
            "",
            "",
            "Standard Plot",
            "",
            "",
            "",
            "",
            "Cremation Plot",
            "",
            "",
            "",
            "",
            "Premium Garden"});
            this.cmbPlotType.Location = new System.Drawing.Point(138, 44);
            this.cmbPlotType.Name = "cmbPlotType";
            this.cmbPlotType.Size = new System.Drawing.Size(148, 25);
            this.cmbPlotType.TabIndex = 7;
            // 
            // lblMoreFilters
            // 
            this.lblMoreFilters.AutoSize = true;
            this.lblMoreFilters.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoreFilters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(120)))), ((int)(((byte)(110)))));
            this.lblMoreFilters.Location = new System.Drawing.Point(28, 55);
            this.lblMoreFilters.Name = "lblMoreFilters";
            this.lblMoreFilters.Size = new System.Drawing.Size(90, 15);
            this.lblMoreFilters.TabIndex = 6;
            this.lblMoreFilters.Text = "MORE FILTERS:";
            // 
            // btnReservedFilter
            // 
            this.btnReservedFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReservedFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReservedFilter.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservedFilter.Location = new System.Drawing.Point(80, 18);
            this.btnReservedFilter.Name = "btnReservedFilter";
            this.btnReservedFilter.Size = new System.Drawing.Size(80, 26);
            this.btnReservedFilter.TabIndex = 5;
            this.btnReservedFilter.Text = "Reserved 0";
            this.btnReservedFilter.UseVisualStyleBackColor = true;
            // 
            // btnOccupiedFilter
            // 
            this.btnOccupiedFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOccupiedFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOccupiedFilter.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOccupiedFilter.Location = new System.Drawing.Point(168, 18);
            this.btnOccupiedFilter.Name = "btnOccupiedFilter";
            this.btnOccupiedFilter.Size = new System.Drawing.Size(80, 26);
            this.btnOccupiedFilter.TabIndex = 4;
            this.btnOccupiedFilter.Text = "Occupied 0";
            this.btnOccupiedFilter.UseVisualStyleBackColor = true;
            // 
            // btnAvailableFilter
            // 
            this.btnAvailableFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAvailableFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAvailableFilter.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvailableFilter.Location = new System.Drawing.Point(256, 18);
            this.btnAvailableFilter.Name = "btnAvailableFilter";
            this.btnAvailableFilter.Size = new System.Drawing.Size(80, 26);
            this.btnAvailableFilter.TabIndex = 3;
            this.btnAvailableFilter.Text = "Available 0";
            this.btnAvailableFilter.UseVisualStyleBackColor = true;
            // 
            // btnAllStatus
            // 
            this.btnAllStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAllStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAllStatus.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllStatus.Location = new System.Drawing.Point(340, 18);
            this.btnAllStatus.Name = "btnAllStatus";
            this.btnAllStatus.Size = new System.Drawing.Size(76, 26);
            this.btnAllStatus.TabIndex = 2;
            this.btnAllStatus.Text = "All (0)";
            this.btnAllStatus.UseVisualStyleBackColor = true;
            // 
            // lblStatusFilter
            // 
            this.lblStatusFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatusFilter.AutoSize = true;
            this.lblStatusFilter.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(120)))), ((int)(((byte)(110)))));
            this.lblStatusFilter.Location = new System.Drawing.Point(596, 4);
            this.lblStatusFilter.Name = "lblStatusFilter";
            this.lblStatusFilter.Size = new System.Drawing.Size(164, 15);
            this.lblStatusFilter.TabIndex = 1;
            this.lblStatusFilter.Text = "FILTER BY CURRENT STATUS";
            // 
            // txtPlotSearch
            // 
            this.txtPlotSearch.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlotSearch.Location = new System.Drawing.Point(12, 12);
            this.txtPlotSearch.Name = "txtPlotSearch";
            this.txtPlotSearch.Size = new System.Drawing.Size(300, 25);
            this.txtPlotSearch.TabIndex = 0;
            // 
            // pnlBPRegistry
            // 
            this.pnlBPRegistry.Controls.Add(this.dgvBurialPlots);
            this.pnlBPRegistry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBPRegistry.Location = new System.Drawing.Point(4, 283);
            this.pnlBPRegistry.Margin = new System.Windows.Forms.Padding(4, 5, 4, 0);
            this.pnlBPRegistry.Name = "pnlBPRegistry";
            this.pnlBPRegistry.Size = new System.Drawing.Size(776, 228);
            this.pnlBPRegistry.TabIndex = 3;
            // 
            // dgvBurialPlots
            // 
            this.dgvBurialPlots.AllowUserToAddRows = false;
            this.dgvBurialPlots.AllowUserToDeleteRows = false;
            this.dgvBurialPlots.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBurialPlots.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.dgvBurialPlots.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBurialPlots.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBurialPlots.ColumnHeadersHeight = 32;
            this.dgvBurialPlots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBurialPlots.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPlotID,
            this.colSection,
            this.colPlotType,
            this.colStatu,
            this.colOccupant,
            this.colDateRegistered,
            this.colActions});
            this.dgvBurialPlots.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBurialPlots.EnableHeadersVisualStyles = false;
            this.dgvBurialPlots.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(223)))), ((int)(((byte)(212)))));
            this.dgvBurialPlots.Location = new System.Drawing.Point(0, 0);
            this.dgvBurialPlots.Margin = new System.Windows.Forms.Padding(0);
            this.dgvBurialPlots.MultiSelect = false;
            this.dgvBurialPlots.Name = "dgvBurialPlots";
            this.dgvBurialPlots.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(48)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(231)))), ((int)(((byte)(222)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(223)))), ((int)(((byte)(222)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBurialPlots.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBurialPlots.RowHeadersVisible = false;
            this.dgvBurialPlots.RowHeadersWidth = 51;
            this.dgvBurialPlots.RowTemplate.Height = 42;
            this.dgvBurialPlots.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBurialPlots.Size = new System.Drawing.Size(776, 228);
            this.dgvBurialPlots.TabIndex = 0;
            // 
            // colPlotID
            // 
            this.colPlotID.FillWeight = 90F;
            this.colPlotID.HeaderText = "PLOT ID";
            this.colPlotID.MinimumWidth = 6;
            this.colPlotID.Name = "colPlotID";
            this.colPlotID.ReadOnly = true;
            this.colPlotID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colSection
            // 
            this.colSection.FillWeight = 125F;
            this.colSection.HeaderText = "SECTION & GRID";
            this.colSection.MinimumWidth = 6;
            this.colSection.Name = "colSection";
            this.colSection.ReadOnly = true;
            this.colSection.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colPlotType
            // 
            this.colPlotType.HeaderText = "PLOT TYPE";
            this.colPlotType.MinimumWidth = 6;
            this.colPlotType.Name = "colPlotType";
            this.colPlotType.ReadOnly = true;
            this.colPlotType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colStatu
            // 
            this.colStatu.FillWeight = 85F;
            this.colStatu.HeaderText = "STATUS";
            this.colStatu.MinimumWidth = 6;
            this.colStatu.Name = "colStatu";
            this.colStatu.ReadOnly = true;
            this.colStatu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colOccupant
            // 
            this.colOccupant.FillWeight = 125F;
            this.colOccupant.HeaderText = "OCCUPANT / OWNER";
            this.colOccupant.MinimumWidth = 6;
            this.colOccupant.Name = "colOccupant";
            this.colOccupant.ReadOnly = true;
            this.colOccupant.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colDateRegistered
            // 
            this.colDateRegistered.FillWeight = 95F;
            this.colDateRegistered.HeaderText = "DATE REGISTERED";
            this.colDateRegistered.MinimumWidth = 6;
            this.colDateRegistered.Name = "colDateRegistered";
            this.colDateRegistered.ReadOnly = true;
            this.colDateRegistered.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colActions
            // 
            this.colActions.FillWeight = 70F;
            this.colActions.HeaderText = "ACTIONS";
            this.colActions.MinimumWidth = 6;
            this.colActions.Name = "colActions";
            this.colActions.ReadOnly = true;
            this.colActions.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.lblFooter);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFooter.Location = new System.Drawing.Point(0, 603);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(0);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.pnlFooter.Size = new System.Drawing.Size(1006, 30);
            this.pnlFooter.TabIndex = 2;
            // 
            // lblFooter
            // 
            this.lblFooter.AutoSize = true;
            this.lblFooter.BackColor = System.Drawing.Color.Transparent;
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(55)))), ((int)(((byte)(47)))));
            this.lblFooter.Location = new System.Drawing.Point(15, 8);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(282, 15);
            this.lblFooter.TabIndex = 0;
            this.lblFooter.Text = "© 2026 TAHANAN - Cemetery Management System";
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1006, 633);
            this.Controls.Add(this.tlpRoot);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1024, 680);
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TAHANAN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tlpRoot.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.tlpWorkspace.ResumeLayout(false);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlDashboard.ResumeLayout(false);
            this.tlpDashboard.ResumeLayout(false);
            this.pnlWelcome.ResumeLayout(false);
            this.pnlWelcome.PerformLayout();
            this.tlpStats.ResumeLayout(false);
            this.pnlTransactions.ResumeLayout(false);
            this.pnlTransactions.PerformLayout();
            this.pnlReservations.ResumeLayout(false);
            this.pnlReservations.PerformLayout();
            this.pnlOccupiedPlots.ResumeLayout(false);
            this.pnlOccupiedPlots.PerformLayout();
            this.pnlTotalPlots.ResumeLayout(false);
            this.pnlTotalPlots.PerformLayout();
            this.tlpLowerDashboard.ResumeLayout(false);
            this.pnlRecentRecords.ResumeLayout(false);
            this.pnlRecentRecords.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentRecords)).EndInit();
            this.tlpRightColumn.ResumeLayout(false);
            this.pnlMemorialCard.ResumeLayout(false);
            this.tlpMemorialContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMemorial)).EndInit();
            this.pnlMemorialInfo.ResumeLayout(false);
            this.pnlMemorialInfo.PerformLayout();
            this.pnlBurialPlotsPage.ResumeLayout(false);
            this.tlpBurialRoot.ResumeLayout(false);
            this.pnlBPHeader.ResumeLayout(false);
            this.pnlBPHeader.PerformLayout();
            this.tlpBPStats.ResumeLayout(false);
            this.pnlBPTotal.ResumeLayout(false);
            this.pnlBPTotal.PerformLayout();
            this.pnlBPAvailable.ResumeLayout(false);
            this.pnlBPAvailable.PerformLayout();
            this.pnlBPOccupied.ResumeLayout(false);
            this.pnlBPOccupied.PerformLayout();
            this.pnlBPReserved.ResumeLayout(false);
            this.pnlBPReserved.PerformLayout();
            this.pnlBPFilters.ResumeLayout(false);
            this.pnlBPFilters.PerformLayout();
            this.pnlBPRegistry.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBurialPlots)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpRoot;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.TableLayoutPanel tlpWorkspace;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnPayments;
        private System.Windows.Forms.Button btnMaintenance;
        private System.Windows.Forms.Button btnFamilies;
        private System.Windows.Forms.Button btnReservations;
        private System.Windows.Forms.Button btnClassification;
        private System.Windows.Forms.Button btnBurialPlots;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.TableLayoutPanel tlpDashboard;
        private System.Windows.Forms.Panel pnlWelcome;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblSectionTitle;
        private System.Windows.Forms.Label lblWelcomeSubtitle;
        private System.Windows.Forms.TableLayoutPanel tlpStats;
        private System.Windows.Forms.Panel pnlTransactions;
        private System.Windows.Forms.Panel pnlReservations;
        private System.Windows.Forms.Panel pnlOccupiedPlots;
        private System.Windows.Forms.Panel pnlTotalPlots;
        private System.Windows.Forms.Label lblTotalPlotsValue;
        private System.Windows.Forms.Label lblTotalPlotsTitle;
        private System.Windows.Forms.Label lblTotalPlotsDescription;
        private System.Windows.Forms.Label lblOccupiedPlots;
        private System.Windows.Forms.Label lblTotalOccupeidPlotsValue;
        private System.Windows.Forms.Label pnlReservation;
        private System.Windows.Forms.Label lblOccupiedDescription;
        private System.Windows.Forms.Label pnlTransaction;
        private System.Windows.Forms.Label lblReservationValue;
        private System.Windows.Forms.Label lbltransactionValue;
        private System.Windows.Forms.Label lblReservationsDescription;
        private System.Windows.Forms.Label lblTransactionsDescription;
        private System.Windows.Forms.TableLayoutPanel tlpLowerDashboard;
        private System.Windows.Forms.Panel pnlRecentRecords;
        private System.Windows.Forms.Label lblActivityLabel;
        private System.Windows.Forms.Label lblRecentSubtitle;
        private System.Windows.Forms.Label lblRecentTitle;
        private System.Windows.Forms.TextBox txtSearchRecords;
        private System.Windows.Forms.DataGridView dgvRecentRecords;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAction;
        private System.Windows.Forms.TableLayoutPanel tlpRightColumn;
        private System.Windows.Forms.Panel pnlMemorialCard;
        private System.Windows.Forms.TableLayoutPanel tlpMemorialContent;
        private System.Windows.Forms.Panel pnlMemorialInfo;
        private System.Windows.Forms.Panel pnlQuickActions;
        private System.Windows.Forms.Label lblMemorialTime;
        private System.Windows.Forms.Label lblMemorialDate;
        private System.Windows.Forms.Label lblTodayLocation;
        private System.Windows.Forms.PictureBox picMemorial;
        private System.Windows.Forms.Panel pnlBurialPlotsPage;
        private System.Windows.Forms.TableLayoutPanel tlpBurialRoot;
        private System.Windows.Forms.Panel pnlBPHeader;
        private System.Windows.Forms.Label lblBPTitle;
        private System.Windows.Forms.Label lblBPSection;
        private System.Windows.Forms.Label lblBPSubtitle;
        private System.Windows.Forms.Button btnAddBurialPlot;
        private System.Windows.Forms.TableLayoutPanel tlpBPStats;
        private System.Windows.Forms.Panel pnlBPTotal;
        private System.Windows.Forms.Panel pnlBPAvailable;
        private System.Windows.Forms.Panel pnlBPOccupied;
        private System.Windows.Forms.Panel pnlBPReserved;
        private System.Windows.Forms.Label lblBPTotalDescription;
        private System.Windows.Forms.Label lblBPTotalValue;
        private System.Windows.Forms.Label lblBPTotalTitle;
        private System.Windows.Forms.Label lblBPAvailableDescription;
        private System.Windows.Forms.Label lblBPAvailableValue;
        private System.Windows.Forms.Label lblBPAvailableTitle;
        private System.Windows.Forms.Label lblBPOccupiedDescription;
        private System.Windows.Forms.Label lblBPOccupiedValue;
        private System.Windows.Forms.Label lblBPOccupiedTitle;
        private System.Windows.Forms.Label lblBPReservedDescription;
        private System.Windows.Forms.Label lblBPReservedValue;
        private System.Windows.Forms.Label lblBPReservedTitle;
        private System.Windows.Forms.Panel pnlBPFilters;
        private System.Windows.Forms.TextBox txtPlotSearch;
        private System.Windows.Forms.Button btnReservedFilter;
        private System.Windows.Forms.Button btnOccupiedFilter;
        private System.Windows.Forms.Button btnAvailableFilter;
        private System.Windows.Forms.Button btnAllStatus;
        private System.Windows.Forms.Label lblStatusFilter;
        private System.Windows.Forms.ComboBox cmbPlotSection;
        private System.Windows.Forms.ComboBox cmbPlotType;
        private System.Windows.Forms.Label lblMoreFilters;
        private System.Windows.Forms.Panel pnlBPRegistry;
        private System.Windows.Forms.DataGridView dgvBurialPlots;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlotID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSection;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlotType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOccupant;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateRegistered;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActions;
    }
}

