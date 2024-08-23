namespace ToDoList
{
    partial class frmMainScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainScreen));
            this.dtp = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.dgvShowTasks = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colHeader = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.personalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.btnCalculatePercentage = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnStartTimer = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnManage = new Guna.UI2.WinForms.Guna2Button();
            this.btnComplete = new Guna.UI2.WinForms.Guna2Button();
            this.btnPending = new Guna.UI2.WinForms.Guna2Button();
            this.btnAll = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowTasks)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtp
            // 
            this.dtp.BackColor = System.Drawing.Color.Transparent;
            this.dtp.Checked = true;
            this.dtp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dtp.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp.ForeColor = System.Drawing.Color.Thistle;
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtp.Location = new System.Drawing.Point(12, 24);
            this.dtp.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(322, 36);
            this.dtp.TabIndex = 0;
            this.dtp.UseTransparentBackground = true;
            this.dtp.Value = new System.DateTime(2024, 7, 7, 19, 38, 43, 47);
            this.dtp.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.Thistle;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Purple;
            this.btnAdd.Location = new System.Drawing.Point(748, 83);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(197, 45);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add Task";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.Thistle;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Purple;
            this.btnDelete.Location = new System.Drawing.Point(965, 83);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(197, 45);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete Selected";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Location = new System.Drawing.Point(340, 0);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 785);
            this.guna2VSeparator1.TabIndex = 9;
            // 
            // dgvShowTasks
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvShowTasks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvShowTasks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowTasks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvShowTasks.ColumnHeadersHeight = 50;
            this.dgvShowTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvShowTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colHeader,
            this.colDescription,
            this.colCategory,
            this.colStartDate,
            this.colEndDate,
            this.colStatus});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShowTasks.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvShowTasks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgvShowTasks.Location = new System.Drawing.Point(0, 153);
            this.dgvShowTasks.Name = "dgvShowTasks";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowTasks.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvShowTasks.RowHeadersVisible = false;
            this.dgvShowTasks.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvShowTasks.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvShowTasks.RowTemplate.Height = 26;
            this.dgvShowTasks.Size = new System.Drawing.Size(1172, 617);
            this.dgvShowTasks.TabIndex = 10;
            this.dgvShowTasks.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.dgvShowTasks.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvShowTasks.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvShowTasks.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvShowTasks.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvShowTasks.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvShowTasks.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgvShowTasks.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgvShowTasks.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgvShowTasks.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvShowTasks.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvShowTasks.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvShowTasks.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvShowTasks.ThemeStyle.HeaderStyle.Height = 50;
            this.dgvShowTasks.ThemeStyle.ReadOnly = false;
            this.dgvShowTasks.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dgvShowTasks.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvShowTasks.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvShowTasks.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvShowTasks.ThemeStyle.RowsStyle.Height = 26;
            this.dgvShowTasks.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgvShowTasks.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvShowTasks.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowTasks_CellValueChanged);
            this.dgvShowTasks.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvShowTasks_CurrentCellDirtyStateChanged);
            this.dgvShowTasks.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvShowTasks_RowPrePaint);
            // 
            // colHeader
            // 
            this.colHeader.FalseValue = "false";
            this.colHeader.HeaderText = "";
            this.colHeader.MinimumWidth = 6;
            this.colHeader.Name = "colHeader";
            this.colHeader.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colHeader.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colHeader.TrueValue = "true";
            // 
            // colDescription
            // 
            this.colDescription.HeaderText = "Description";
            this.colDescription.MinimumWidth = 6;
            this.colDescription.Name = "colDescription";
            this.colDescription.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colCategory
            // 
            this.colCategory.HeaderText = "Category";
            this.colCategory.MinimumWidth = 6;
            this.colCategory.Name = "colCategory";
            this.colCategory.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colStartDate
            // 
            this.colStartDate.HeaderText = "Start Date";
            this.colStartDate.MinimumWidth = 6;
            this.colStartDate.Name = "colStartDate";
            // 
            // colEndDate
            // 
            this.colEndDate.HeaderText = "End Date";
            this.colEndDate.MinimumWidth = 6;
            this.colEndDate.Name = "colEndDate";
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.dgvShowTasks);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(351, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1204, 813);
            this.panel1.TabIndex = 11;
            // 
            // pbSearch
            // 
            this.pbSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSearch.Image = global::ToDoList.Properties.Resources.OIP__16_;
            this.pbSearch.Location = new System.Drawing.Point(1114, 14);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(37, 31);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSearch.TabIndex = 13;
            this.pbSearch.TabStop = false;
            this.pbSearch.Click += new System.EventHandler(this.pbSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(895, 12);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(267, 38);
            this.txtSearch.TabIndex = 12;
            this.txtSearch.Text = "Search Item...";
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1204, 39);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // personalToolStripMenuItem
            // 
            this.personalToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personalToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.personalToolStripMenuItem.Name = "personalToolStripMenuItem";
            this.personalToolStripMenuItem.Size = new System.Drawing.Size(116, 35);
            this.personalToolStripMenuItem.Text = "Personal";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // btnCalculatePercentage
            // 
            this.btnCalculatePercentage.AutoRoundedCorners = true;
            this.btnCalculatePercentage.BorderRadius = 37;
            this.btnCalculatePercentage.BorderThickness = 4;
            this.btnCalculatePercentage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCalculatePercentage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCalculatePercentage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCalculatePercentage.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCalculatePercentage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCalculatePercentage.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnCalculatePercentage.FillColor2 = System.Drawing.Color.Purple;
            this.btnCalculatePercentage.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnCalculatePercentage.ForeColor = System.Drawing.Color.White;
            this.btnCalculatePercentage.Location = new System.Drawing.Point(12, 344);
            this.btnCalculatePercentage.Name = "btnCalculatePercentage";
            this.btnCalculatePercentage.Size = new System.Drawing.Size(306, 76);
            this.btnCalculatePercentage.TabIndex = 12;
            this.btnCalculatePercentage.Text = "Percentage of achievement of goals";
            this.btnCalculatePercentage.Click += new System.EventHandler(this.btnCalculatePercentage_Click);
            // 
            // btnStartTimer
            // 
            this.btnStartTimer.AutoRoundedCorners = true;
            this.btnStartTimer.BorderRadius = 37;
            this.btnStartTimer.BorderThickness = 4;
            this.btnStartTimer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStartTimer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStartTimer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStartTimer.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStartTimer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStartTimer.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnStartTimer.FillColor2 = System.Drawing.Color.Purple;
            this.btnStartTimer.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnStartTimer.ForeColor = System.Drawing.Color.White;
            this.btnStartTimer.Location = new System.Drawing.Point(12, 253);
            this.btnStartTimer.Name = "btnStartTimer";
            this.btnStartTimer.Size = new System.Drawing.Size(306, 76);
            this.btnStartTimer.TabIndex = 13;
            this.btnStartTimer.Text = "Start a timer ?";
            this.btnStartTimer.Click += new System.EventHandler(this.btnStartTimer_Click);
            // 
            // btnManage
            // 
            this.btnManage.BackColor = System.Drawing.Color.Transparent;
            this.btnManage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnManage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManage.FillColor = System.Drawing.Color.Transparent;
            this.btnManage.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManage.ForeColor = System.Drawing.Color.White;
            this.btnManage.Image = global::ToDoList.Properties.Resources.project_management;
            this.btnManage.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManage.ImageSize = new System.Drawing.Size(35, 35);
            this.btnManage.Location = new System.Drawing.Point(9, 666);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(309, 45);
            this.btnManage.TabIndex = 5;
            this.btnManage.Text = "Manage Categories";
            this.btnManage.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.Color.Transparent;
            this.btnComplete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnComplete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnComplete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnComplete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnComplete.FillColor = System.Drawing.Color.Transparent;
            this.btnComplete.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplete.ForeColor = System.Drawing.Color.White;
            this.btnComplete.Image = global::ToDoList.Properties.Resources.work_order;
            this.btnComplete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnComplete.ImageSize = new System.Drawing.Size(35, 35);
            this.btnComplete.Location = new System.Drawing.Point(9, 595);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(309, 45);
            this.btnComplete.TabIndex = 4;
            this.btnComplete.Text = "Complete";
            this.btnComplete.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // btnPending
            // 
            this.btnPending.BackColor = System.Drawing.Color.Transparent;
            this.btnPending.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPending.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPending.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPending.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPending.FillColor = System.Drawing.Color.Transparent;
            this.btnPending.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPending.ForeColor = System.Drawing.Color.White;
            this.btnPending.Image = global::ToDoList.Properties.Resources.daily_planning;
            this.btnPending.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPending.ImageSize = new System.Drawing.Size(35, 35);
            this.btnPending.Location = new System.Drawing.Point(9, 526);
            this.btnPending.Name = "btnPending";
            this.btnPending.Size = new System.Drawing.Size(309, 45);
            this.btnPending.TabIndex = 3;
            this.btnPending.Text = "Pending";
            this.btnPending.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPending.Click += new System.EventHandler(this.btnPending_Click);
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.Color.Transparent;
            this.btnAll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAll.FillColor = System.Drawing.Color.Transparent;
            this.btnAll.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.ForeColor = System.Drawing.Color.White;
            this.btnAll.Image = global::ToDoList.Properties.Resources.list;
            this.btnAll.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAll.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAll.Location = new System.Drawing.Point(9, 454);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(309, 45);
            this.btnAll.TabIndex = 1;
            this.btnAll.Text = "All";
            this.btnAll.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // frmMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1554, 771);
            this.Controls.Add(this.btnStartTimer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2VSeparator1);
            this.Controls.Add(this.btnCalculatePercentage);
            this.Controls.Add(this.btnManage);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.btnPending);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.dtp);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMainScreen";
            this.Text = "To Do List";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.frmMainScreen_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowTasks)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker dtp;
        private Guna.UI2.WinForms.Guna2Button btnAll;
        private Guna.UI2.WinForms.Guna2Button btnPending;
        private Guna.UI2.WinForms.Guna2Button btnComplete;
        private Guna.UI2.WinForms.Guna2Button btnManage;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvShowTasks;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personalToolStripMenuItem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pbSearch;
        private Guna.UI2.WinForms.Guna2GradientButton btnCalculatePercentage;
        private Guna.UI2.WinForms.Guna2GradientButton btnStartTimer;
    }
}

