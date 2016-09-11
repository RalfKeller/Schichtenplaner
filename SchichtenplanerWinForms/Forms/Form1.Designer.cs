namespace SchichtenplanerWinForms
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle1 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle2 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle3 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle4 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle1 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.mitarbeiterPage = new System.Windows.Forms.TabPage();
            this.btnDeleteMitarbeiter = new System.Windows.Forms.Button();
            this.btnEditMitarbeiter = new System.Windows.Forms.Button();
            this.btnAddMitarbeiter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mitarbeiterGrid = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.geplanteArbeitszeitDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mitarbeiterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.planungPage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tvSchichten = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddArbeitsbereich = new System.Windows.Forms.Button();
            this.dgvArbeitsbereiche = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arbeitsbereichBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kalenderPage = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.mitarbeiterGridSmall = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.geplanteArbeitszeitDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcKalender = new Syncfusion.Windows.Forms.Grid.GridControl();
            this.btnMakePlan = new System.Windows.Forms.Button();
            this.dtpViewmonth = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.regelPage = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.comboPrio = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.comboRegel = new System.Windows.Forms.ComboBox();
            this.comboMitarbeiter = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.geplanteArbeitszeitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpVon = new System.Windows.Forms.DateTimePicker();
            this.dtpBis = new System.Windows.Forms.DateTimePicker();
            this.lstbxRegeln = new System.Windows.Forms.ListBox();
            this.tabControl.SuspendLayout();
            this.mitarbeiterPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mitarbeiterGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitarbeiterBindingSource)).BeginInit();
            this.planungPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArbeitsbereiche)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arbeitsbereichBindingSource)).BeginInit();
            this.kalenderPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mitarbeiterGridSmall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKalender)).BeginInit();
            this.regelPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.mitarbeiterPage);
            this.tabControl.Controls.Add(this.planungPage);
            this.tabControl.Controls.Add(this.kalenderPage);
            this.tabControl.Controls.Add(this.regelPage);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Margin = new System.Windows.Forms.Padding(10);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(820, 474);
            this.tabControl.TabIndex = 0;
            this.tabControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mitarbeiterGridSmall_MouseDown);
            // 
            // mitarbeiterPage
            // 
            this.mitarbeiterPage.Controls.Add(this.btnDeleteMitarbeiter);
            this.mitarbeiterPage.Controls.Add(this.btnEditMitarbeiter);
            this.mitarbeiterPage.Controls.Add(this.btnAddMitarbeiter);
            this.mitarbeiterPage.Controls.Add(this.label2);
            this.mitarbeiterPage.Controls.Add(this.label1);
            this.mitarbeiterPage.Controls.Add(this.mitarbeiterGrid);
            this.mitarbeiterPage.Location = new System.Drawing.Point(4, 22);
            this.mitarbeiterPage.Name = "mitarbeiterPage";
            this.mitarbeiterPage.Padding = new System.Windows.Forms.Padding(3);
            this.mitarbeiterPage.Size = new System.Drawing.Size(812, 448);
            this.mitarbeiterPage.TabIndex = 0;
            this.mitarbeiterPage.Text = "Mitarbeiter";
            this.mitarbeiterPage.UseVisualStyleBackColor = true;
            // 
            // btnDeleteMitarbeiter
            // 
            this.btnDeleteMitarbeiter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteMitarbeiter.Location = new System.Drawing.Point(715, 360);
            this.btnDeleteMitarbeiter.Name = "btnDeleteMitarbeiter";
            this.btnDeleteMitarbeiter.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteMitarbeiter.TabIndex = 5;
            this.btnDeleteMitarbeiter.Text = "Löschen";
            this.btnDeleteMitarbeiter.UseVisualStyleBackColor = true;
            // 
            // btnEditMitarbeiter
            // 
            this.btnEditMitarbeiter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditMitarbeiter.Location = new System.Drawing.Point(634, 360);
            this.btnEditMitarbeiter.Name = "btnEditMitarbeiter";
            this.btnEditMitarbeiter.Size = new System.Drawing.Size(75, 23);
            this.btnEditMitarbeiter.TabIndex = 4;
            this.btnEditMitarbeiter.Text = "Ändern";
            this.btnEditMitarbeiter.UseVisualStyleBackColor = true;
            this.btnEditMitarbeiter.Click += new System.EventHandler(this.btnEditMitarbeiter_Click);
            // 
            // btnAddMitarbeiter
            // 
            this.btnAddMitarbeiter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddMitarbeiter.Location = new System.Drawing.Point(553, 360);
            this.btnAddMitarbeiter.Name = "btnAddMitarbeiter";
            this.btnAddMitarbeiter.Size = new System.Drawing.Size(75, 23);
            this.btnAddMitarbeiter.TabIndex = 3;
            this.btnAddMitarbeiter.Text = "Hinzufügen";
            this.btnAddMitarbeiter.UseVisualStyleBackColor = true;
            this.btnAddMitarbeiter.Click += new System.EventHandler(this.btnAddMitarbeiter_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoEllipsis = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(779, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod t" +
    "empor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At ve" +
    "ro eos et accusam et justo duo ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mitarbeiter";
            // 
            // mitarbeiterGrid
            // 
            this.mitarbeiterGrid.AllowUserToAddRows = false;
            this.mitarbeiterGrid.AllowUserToDeleteRows = false;
            this.mitarbeiterGrid.AllowUserToResizeRows = false;
            this.mitarbeiterGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mitarbeiterGrid.AutoGenerateColumns = false;
            this.mitarbeiterGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mitarbeiterGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mitarbeiterGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.geplanteArbeitszeitDataGridViewTextBoxColumn1});
            this.mitarbeiterGrid.DataSource = this.mitarbeiterBindingSource;
            this.mitarbeiterGrid.Location = new System.Drawing.Point(15, 93);
            this.mitarbeiterGrid.Margin = new System.Windows.Forms.Padding(10);
            this.mitarbeiterGrid.MultiSelect = false;
            this.mitarbeiterGrid.Name = "mitarbeiterGrid";
            this.mitarbeiterGrid.ReadOnly = true;
            this.mitarbeiterGrid.Size = new System.Drawing.Size(775, 254);
            this.mitarbeiterGrid.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // geplanteArbeitszeitDataGridViewTextBoxColumn1
            // 
            this.geplanteArbeitszeitDataGridViewTextBoxColumn1.DataPropertyName = "GeplanteArbeitszeit";
            this.geplanteArbeitszeitDataGridViewTextBoxColumn1.HeaderText = "GeplanteArbeitszeit";
            this.geplanteArbeitszeitDataGridViewTextBoxColumn1.Name = "geplanteArbeitszeitDataGridViewTextBoxColumn1";
            this.geplanteArbeitszeitDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // mitarbeiterBindingSource
            // 
            this.mitarbeiterBindingSource.DataSource = typeof(SchichtenplanerWinForms.Mitarbeiter);
            // 
            // planungPage
            // 
            this.planungPage.AutoScroll = true;
            this.planungPage.Controls.Add(this.groupBox2);
            this.planungPage.Controls.Add(this.groupBox1);
            this.planungPage.Location = new System.Drawing.Point(4, 22);
            this.planungPage.Name = "planungPage";
            this.planungPage.Padding = new System.Windows.Forms.Padding(3);
            this.planungPage.Size = new System.Drawing.Size(812, 448);
            this.planungPage.TabIndex = 1;
            this.planungPage.Text = "Planung";
            this.planungPage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tvSchichten);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox2.Location = new System.Drawing.Point(13, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(793, 126);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Schichten";
            // 
            // tvSchichten
            // 
            this.tvSchichten.Location = new System.Drawing.Point(7, 22);
            this.tvSchichten.Name = "tvSchichten";
            this.tvSchichten.Size = new System.Drawing.Size(770, 98);
            this.tvSchichten.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnAddArbeitsbereich);
            this.groupBox1.Controls.Add(this.dgvArbeitsbereiche);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 227);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arbeitsbereiche";
            // 
            // btnAddArbeitsbereich
            // 
            this.btnAddArbeitsbereich.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddArbeitsbereich.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddArbeitsbereich.Location = new System.Drawing.Point(709, 198);
            this.btnAddArbeitsbereich.Name = "btnAddArbeitsbereich";
            this.btnAddArbeitsbereich.Size = new System.Drawing.Size(75, 23);
            this.btnAddArbeitsbereich.TabIndex = 1;
            this.btnAddArbeitsbereich.Text = "Hinzufügen";
            this.btnAddArbeitsbereich.UseVisualStyleBackColor = true;
            // 
            // dgvArbeitsbereiche
            // 
            this.dgvArbeitsbereiche.AllowUserToResizeRows = false;
            this.dgvArbeitsbereiche.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArbeitsbereiche.AutoGenerateColumns = false;
            this.dgvArbeitsbereiche.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArbeitsbereiche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArbeitsbereiche.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn3});
            this.dgvArbeitsbereiche.DataSource = this.arbeitsbereichBindingSource;
            this.dgvArbeitsbereiche.Location = new System.Drawing.Point(7, 20);
            this.dgvArbeitsbereiche.Name = "dgvArbeitsbereiche";
            this.dgvArbeitsbereiche.Size = new System.Drawing.Size(777, 172);
            this.dgvArbeitsbereiche.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn3
            // 
            this.nameDataGridViewTextBoxColumn3.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn3.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn3.Name = "nameDataGridViewTextBoxColumn3";
            // 
            // arbeitsbereichBindingSource
            // 
            this.arbeitsbereichBindingSource.DataSource = typeof(SchichtenplanerWinForms.Arbeitsbereich);
            // 
            // kalenderPage
            // 
            this.kalenderPage.Controls.Add(this.splitContainer1);
            this.kalenderPage.Controls.Add(this.btnMakePlan);
            this.kalenderPage.Controls.Add(this.dtpViewmonth);
            this.kalenderPage.Controls.Add(this.label3);
            this.kalenderPage.Location = new System.Drawing.Point(4, 22);
            this.kalenderPage.Name = "kalenderPage";
            this.kalenderPage.Padding = new System.Windows.Forms.Padding(3);
            this.kalenderPage.Size = new System.Drawing.Size(812, 448);
            this.kalenderPage.TabIndex = 2;
            this.kalenderPage.Text = "Kalender";
            this.kalenderPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.AllowDrop = true;
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BackColor = System.Drawing.Color.Black;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Location = new System.Drawing.Point(6, 32);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AllowDrop = true;
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.mitarbeiterGridSmall);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AllowDrop = true;
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.gcKalender);
            this.splitContainer1.Size = new System.Drawing.Size(800, 381);
            this.splitContainer1.SplitterDistance = 399;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 9;
            // 
            // mitarbeiterGridSmall
            // 
            this.mitarbeiterGridSmall.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.mitarbeiterGridSmall.AllowUserToAddRows = false;
            this.mitarbeiterGridSmall.AllowUserToDeleteRows = false;
            this.mitarbeiterGridSmall.AllowUserToResizeRows = false;
            this.mitarbeiterGridSmall.AutoGenerateColumns = false;
            this.mitarbeiterGridSmall.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mitarbeiterGridSmall.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.mitarbeiterGridSmall.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.mitarbeiterGridSmall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mitarbeiterGridSmall.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn2,
            this.geplanteArbeitszeitDataGridViewTextBoxColumn2});
            this.mitarbeiterGridSmall.DataSource = this.mitarbeiterBindingSource;
            this.mitarbeiterGridSmall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mitarbeiterGridSmall.Location = new System.Drawing.Point(0, 0);
            this.mitarbeiterGridSmall.MultiSelect = false;
            this.mitarbeiterGridSmall.Name = "mitarbeiterGridSmall";
            this.mitarbeiterGridSmall.ReadOnly = true;
            this.mitarbeiterGridSmall.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mitarbeiterGridSmall.Size = new System.Drawing.Size(395, 377);
            this.mitarbeiterGridSmall.TabIndex = 7;
            this.mitarbeiterGridSmall.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mitarbeiterGridSmall_MouseDown);
            this.mitarbeiterGridSmall.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mitarbeiterGridSmall_MouseMove);
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            this.nameDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // geplanteArbeitszeitDataGridViewTextBoxColumn2
            // 
            this.geplanteArbeitszeitDataGridViewTextBoxColumn2.DataPropertyName = "GeplanteArbeitszeit";
            this.geplanteArbeitszeitDataGridViewTextBoxColumn2.HeaderText = "GeplanteArbeitszeit";
            this.geplanteArbeitszeitDataGridViewTextBoxColumn2.Name = "geplanteArbeitszeitDataGridViewTextBoxColumn2";
            this.geplanteArbeitszeitDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // gcKalender
            // 
            this.gcKalender.AllowDrop = true;
            this.gcKalender.AllowSelection = Syncfusion.Windows.Forms.Grid.GridSelectionFlags.None;
            gridBaseStyle1.Name = "Header";
            gridBaseStyle1.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle1.StyleInfo.Borders.Left = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle1.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle1.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle1.StyleInfo.CellType = "Header";
            gridBaseStyle1.StyleInfo.Font.Bold = true;
            gridBaseStyle1.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(184))))), System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(216))))));
            gridBaseStyle1.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle;
            gridBaseStyle2.Name = "Standard";
            gridBaseStyle2.StyleInfo.Font.Facename = "Tahoma";
            gridBaseStyle2.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window);
            gridBaseStyle3.Name = "Column Header";
            gridBaseStyle3.StyleInfo.BaseStyle = "Header";
            gridBaseStyle3.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridBaseStyle4.Name = "Row Header";
            gridBaseStyle4.StyleInfo.BaseStyle = "Header";
            gridBaseStyle4.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left;
            gridBaseStyle4.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(184))))), System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(216))))));
            this.gcKalender.BaseStylesMap.AddRange(new Syncfusion.Windows.Forms.Grid.GridBaseStyle[] {
            gridBaseStyle1,
            gridBaseStyle2,
            gridBaseStyle3,
            gridBaseStyle4});
            this.gcKalender.ColCount = 0;
            this.gcKalender.ColWidthEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridColWidth[] {
            new Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35)});
            this.gcKalender.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid;
            this.gcKalender.DefaultRowHeight = 20;
            this.gcKalender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcKalender.DragSelectedCellsMouseButtonsMask = System.Windows.Forms.MouseButtons.None;
            this.gcKalender.Font = new System.Drawing.Font("Tahoma", 9F);
            this.gcKalender.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gcKalender.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gcKalender.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gcKalender.Location = new System.Drawing.Point(0, 0);
            this.gcKalender.MetroScrollBars = true;
            this.gcKalender.Name = "gcKalender";
            this.gcKalender.NumberedColHeaders = false;
            this.gcKalender.NumberedRowHeaders = false;
            this.gcKalender.Properties.DisplayHorzLines = false;
            this.gcKalender.Properties.DisplayVertLines = false;
            this.gcKalender.Properties.ForceImmediateRepaint = false;
            this.gcKalender.Properties.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gcKalender.Properties.MarkColHeader = false;
            this.gcKalender.Properties.MarkRowHeader = false;
            this.gcKalender.Properties.PrintRowHeader = false;
            this.gcKalender.Properties.RowHeaders = false;
            gridRangeStyle1.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle1.StyleInfo.Font.Bold = false;
            gridRangeStyle1.StyleInfo.Font.Facename = "Tahoma";
            gridRangeStyle1.StyleInfo.Font.Italic = false;
            gridRangeStyle1.StyleInfo.Font.Size = 9F;
            gridRangeStyle1.StyleInfo.Font.Strikeout = false;
            gridRangeStyle1.StyleInfo.Font.Underline = false;
            gridRangeStyle1.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            this.gcKalender.RangeStyles.AddRange(new Syncfusion.Windows.Forms.Grid.GridRangeStyle[] {
            gridRangeStyle1});
            this.gcKalender.RefreshCurrentCellBehavior = Syncfusion.Windows.Forms.Grid.GridRefreshCurrentCellBehavior.RefreshRow;
            this.gcKalender.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gcKalender.RowCount = 0;
            this.gcKalender.RowHeightEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridRowHeight[] {
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 25)});
            this.gcKalender.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode;
            this.gcKalender.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.HideAlways;
            this.gcKalender.Size = new System.Drawing.Size(391, 377);
            this.gcKalender.SmartSizeBox = false;
            this.gcKalender.TabIndex = 8;
            this.gcKalender.ThemesEnabled = true;
            this.gcKalender.UseRightToLeftCompatibleTextBox = true;
            this.gcKalender.CellMouseHover += new Syncfusion.Windows.Forms.Grid.GridCellMouseEventHandler(this.gcKalender_CellMouseHover);
            this.gcKalender.DragDrop += new System.Windows.Forms.DragEventHandler(this.gcKalender_DragDrop);
            this.gcKalender.DragEnter += new System.Windows.Forms.DragEventHandler(this.gcKalender_DragEnter);
            this.gcKalender.DragOver += new System.Windows.Forms.DragEventHandler(this.gcKalender_DragOver);
            // 
            // btnMakePlan
            // 
            this.btnMakePlan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMakePlan.Location = new System.Drawing.Point(697, 419);
            this.btnMakePlan.Name = "btnMakePlan";
            this.btnMakePlan.Size = new System.Drawing.Size(109, 23);
            this.btnMakePlan.TabIndex = 4;
            this.btnMakePlan.Text = "Mache den Plan!";
            this.btnMakePlan.UseVisualStyleBackColor = true;
            this.btnMakePlan.Click += new System.EventHandler(this.btnMakePlan_Click);
            // 
            // dtpViewmonth
            // 
            this.dtpViewmonth.CustomFormat = "MMMM yyyy";
            this.dtpViewmonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpViewmonth.Location = new System.Drawing.Point(362, 6);
            this.dtpViewmonth.Name = "dtpViewmonth";
            this.dtpViewmonth.Size = new System.Drawing.Size(200, 20);
            this.dtpViewmonth.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(306, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Datum:";
            // 
            // regelPage
            // 
            this.regelPage.Controls.Add(this.lstbxRegeln);
            this.regelPage.Controls.Add(this.dtpBis);
            this.regelPage.Controls.Add(this.dtpVon);
            this.regelPage.Controls.Add(this.label7);
            this.regelPage.Controls.Add(this.label6);
            this.regelPage.Controls.Add(this.label5);
            this.regelPage.Controls.Add(this.comboPrio);
            this.regelPage.Controls.Add(this.btnAdd);
            this.regelPage.Controls.Add(this.comboRegel);
            this.regelPage.Controls.Add(this.comboMitarbeiter);
            this.regelPage.Controls.Add(this.label4);
            this.regelPage.Location = new System.Drawing.Point(4, 22);
            this.regelPage.Name = "regelPage";
            this.regelPage.Size = new System.Drawing.Size(812, 448);
            this.regelPage.TabIndex = 3;
            this.regelPage.Text = "Regeln";
            this.regelPage.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Prio:";
            // 
            // comboPrio
            // 
            this.comboPrio.FormattingEnabled = true;
            this.comboPrio.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.comboPrio.Location = new System.Drawing.Point(65, 54);
            this.comboPrio.Name = "comboPrio";
            this.comboPrio.Size = new System.Drawing.Size(121, 21);
            this.comboPrio.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(404, 11);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Hinzufügen";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // comboRegel
            // 
            this.comboRegel.FormattingEnabled = true;
            this.comboRegel.Items.AddRange(new object[] {
            "hat frei",
            "ist krank",
            "möchte arbeiten",
            "möchte nicht arbeiten"});
            this.comboRegel.Location = new System.Drawing.Point(228, 13);
            this.comboRegel.Name = "comboRegel";
            this.comboRegel.Size = new System.Drawing.Size(121, 21);
            this.comboRegel.TabIndex = 3;
            // 
            // comboMitarbeiter
            // 
            this.comboMitarbeiter.FormattingEnabled = true;
            this.comboMitarbeiter.Location = new System.Drawing.Point(65, 13);
            this.comboMitarbeiter.Name = "comboMitarbeiter";
            this.comboMitarbeiter.Size = new System.Drawing.Size(121, 21);
            this.comboMitarbeiter.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mitarbeiter";
            // 
            // geplanteArbeitszeitDataGridViewTextBoxColumn
            // 
            this.geplanteArbeitszeitDataGridViewTextBoxColumn.DataPropertyName = "GeplanteArbeitszeit";
            this.geplanteArbeitszeitDataGridViewTextBoxColumn.HeaderText = "Geplante Arbeitszeit";
            this.geplanteArbeitszeitDataGridViewTextBoxColumn.Name = "geplanteArbeitszeitDataGridViewTextBoxColumn";
            this.geplanteArbeitszeitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(208, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Von:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(213, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Bis:";
            // 
            // dtpVon
            // 
            this.dtpVon.Location = new System.Drawing.Point(254, 51);
            this.dtpVon.Name = "dtpVon";
            this.dtpVon.Size = new System.Drawing.Size(200, 20);
            this.dtpVon.TabIndex = 9;
            // 
            // dtpBis
            // 
            this.dtpBis.Location = new System.Drawing.Point(254, 104);
            this.dtpBis.Name = "dtpBis";
            this.dtpBis.Size = new System.Drawing.Size(200, 20);
            this.dtpBis.TabIndex = 10;
            // 
            // lstbxRegeln
            // 
            this.lstbxRegeln.FormattingEnabled = true;
            this.lstbxRegeln.Location = new System.Drawing.Point(6, 238);
            this.lstbxRegeln.Name = "lstbxRegeln";
            this.lstbxRegeln.Size = new System.Drawing.Size(803, 199);
            this.lstbxRegeln.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 498);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Schichtenplanung";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl.ResumeLayout(false);
            this.mitarbeiterPage.ResumeLayout(false);
            this.mitarbeiterPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mitarbeiterGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitarbeiterBindingSource)).EndInit();
            this.planungPage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArbeitsbereiche)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arbeitsbereichBindingSource)).EndInit();
            this.kalenderPage.ResumeLayout(false);
            this.kalenderPage.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mitarbeiterGridSmall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKalender)).EndInit();
            this.regelPage.ResumeLayout(false);
            this.regelPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage planungPage;
        private System.Windows.Forms.BindingSource mitarbeiterBindingSource;
        private System.Windows.Forms.TabPage mitarbeiterPage;
        private System.Windows.Forms.Button btnDeleteMitarbeiter;
        private System.Windows.Forms.Button btnEditMitarbeiter;
        private System.Windows.Forms.Button btnAddMitarbeiter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView mitarbeiterGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn geplanteArbeitszeitDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn geplanteArbeitszeitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvArbeitsbereiche;
        private System.Windows.Forms.Button btnAddArbeitsbereich;
        private System.Windows.Forms.TabPage kalenderPage;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource arbeitsbereichBindingSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TreeView tvSchichten;
        private System.Windows.Forms.DateTimePicker dtpViewmonth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMakePlan;
        private Syncfusion.Windows.Forms.Grid.GridControl gcKalender;
        private System.Windows.Forms.DataGridView mitarbeiterGridSmall;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn geplanteArbeitszeitDataGridViewTextBoxColumn2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabPage regelPage;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox comboRegel;
        private System.Windows.Forms.ComboBox comboMitarbeiter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboPrio;
        private System.Windows.Forms.DateTimePicker dtpBis;
        private System.Windows.Forms.DateTimePicker dtpVon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstbxRegeln;
    }
}

