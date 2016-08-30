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
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Montag");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Dienstag");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Mittwoch");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Donnerstag");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Freitag");
            this.tabControl = new System.Windows.Forms.TabControl();
            this.mitarbeiterPage = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mitarbeiterGrid = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.geplanteArbeitszeitDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mitarbeiterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.planungPage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddArbeitsbereich = new System.Windows.Forms.Button();
            this.dgvArbeitsbereiche = new System.Windows.Forms.DataGridView();
            this.kalenderPage = new System.Windows.Forms.TabPage();
            this.mitarbeiterGridSmall = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.geplanteArbeitszeitDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.geplanteArbeitszeitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arbeitsbereichBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.mitarbeiterPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mitarbeiterGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitarbeiterBindingSource)).BeginInit();
            this.planungPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArbeitsbereiche)).BeginInit();
            this.kalenderPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mitarbeiterGridSmall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arbeitsbereichBindingSource)).BeginInit();
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
            this.tabControl.Location = new System.Drawing.Point(18, 18);
            this.tabControl.Margin = new System.Windows.Forms.Padding(15);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1230, 638);
            this.tabControl.TabIndex = 0;
            // 
            // mitarbeiterPage
            // 
            this.mitarbeiterPage.Controls.Add(this.btnDelete);
            this.mitarbeiterPage.Controls.Add(this.btnEdit);
            this.mitarbeiterPage.Controls.Add(this.btnAdd);
            this.mitarbeiterPage.Controls.Add(this.label2);
            this.mitarbeiterPage.Controls.Add(this.label1);
            this.mitarbeiterPage.Controls.Add(this.mitarbeiterGrid);
            this.mitarbeiterPage.Location = new System.Drawing.Point(4, 29);
            this.mitarbeiterPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mitarbeiterPage.Name = "mitarbeiterPage";
            this.mitarbeiterPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mitarbeiterPage.Size = new System.Drawing.Size(1222, 605);
            this.mitarbeiterPage.TabIndex = 0;
            this.mitarbeiterPage.Text = "Mitarbeiter";
            this.mitarbeiterPage.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(1072, 554);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 35);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Löschen";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(951, 554);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(112, 35);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Ändern";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(830, 554);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 35);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Hinzufügen";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoEllipsis = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1168, 71);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod t" +
    "empor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At ve" +
    "ro eos et accusam et justo duo ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 73);
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
            this.mitarbeiterGrid.Location = new System.Drawing.Point(22, 143);
            this.mitarbeiterGrid.Margin = new System.Windows.Forms.Padding(15);
            this.mitarbeiterGrid.MultiSelect = false;
            this.mitarbeiterGrid.Name = "mitarbeiterGrid";
            this.mitarbeiterGrid.ReadOnly = true;
            this.mitarbeiterGrid.Size = new System.Drawing.Size(1162, 391);
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
            this.planungPage.Controls.Add(this.groupBox1);
            this.planungPage.Location = new System.Drawing.Point(4, 29);
            this.planungPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.planungPage.Name = "planungPage";
            this.planungPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.planungPage.Size = new System.Drawing.Size(1222, 605);
            this.planungPage.TabIndex = 1;
            this.planungPage.Text = "Planung";
            this.planungPage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnAddArbeitsbereich);
            this.groupBox1.Controls.Add(this.dgvArbeitsbereiche);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1200, 349);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arbeitsbereiche";
            // 
            // btnAddArbeitsbereich
            // 
            this.btnAddArbeitsbereich.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddArbeitsbereich.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddArbeitsbereich.Location = new System.Drawing.Point(1064, 305);
            this.btnAddArbeitsbereich.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddArbeitsbereich.Name = "btnAddArbeitsbereich";
            this.btnAddArbeitsbereich.Size = new System.Drawing.Size(112, 35);
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
            this.dgvArbeitsbereiche.Location = new System.Drawing.Point(10, 31);
            this.dgvArbeitsbereiche.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvArbeitsbereiche.Name = "dgvArbeitsbereiche";
            this.dgvArbeitsbereiche.Size = new System.Drawing.Size(1166, 265);
            this.dgvArbeitsbereiche.TabIndex = 0;
            // 
            // kalenderPage
            // 
            this.kalenderPage.Controls.Add(this.mitarbeiterGridSmall);
            this.kalenderPage.Controls.Add(this.treeView1);
            this.kalenderPage.Location = new System.Drawing.Point(4, 29);
            this.kalenderPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.kalenderPage.Name = "kalenderPage";
            this.kalenderPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.kalenderPage.Size = new System.Drawing.Size(1222, 605);
            this.kalenderPage.TabIndex = 2;
            this.kalenderPage.Text = "Kalender";
            this.kalenderPage.UseVisualStyleBackColor = true;
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
            this.mitarbeiterGridSmall.Location = new System.Drawing.Point(10, 11);
            this.mitarbeiterGridSmall.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mitarbeiterGridSmall.MultiSelect = false;
            this.mitarbeiterGridSmall.Name = "mitarbeiterGridSmall";
            this.mitarbeiterGridSmall.ReadOnly = true;
            this.mitarbeiterGridSmall.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mitarbeiterGridSmall.Size = new System.Drawing.Size(440, 578);
            this.mitarbeiterGridSmall.TabIndex = 1;
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
            // treeView1
            // 
            this.treeView1.AllowDrop = true;
            this.treeView1.Location = new System.Drawing.Point(459, 11);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.treeView1.Name = "treeView1";
            treeNode6.Name = "montagRoot";
            treeNode6.Text = "Montag";
            treeNode7.Name = "dienstagRoot";
            treeNode7.Text = "Dienstag";
            treeNode8.Name = "mittwochRoot";
            treeNode8.Text = "Mittwoch";
            treeNode9.Name = "donnerstagRoot";
            treeNode9.Text = "Donnerstag";
            treeNode10.Name = "freitagRoot";
            treeNode10.Text = "Freitag";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10});
            this.treeView1.Size = new System.Drawing.Size(748, 576);
            this.treeView1.TabIndex = 0;
            this.treeView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeView1_DragDrop);
            this.treeView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeView1_DragEnter);
            this.treeView1.DragOver += new System.Windows.Forms.DragEventHandler(this.treeView1_DragOver);
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
            // arbeitsbereichBindingSource
            // 
            this.arbeitsbereichBindingSource.DataSource = typeof(SchichtenplanerWinForms.Arbeitsbereich);
            // 
            // nameDataGridViewTextBoxColumn3
            // 
            this.nameDataGridViewTextBoxColumn3.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn3.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn3.Name = "nameDataGridViewTextBoxColumn3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 675);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Schichtenplanung";
            this.tabControl.ResumeLayout(false);
            this.mitarbeiterPage.ResumeLayout(false);
            this.mitarbeiterPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mitarbeiterGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitarbeiterBindingSource)).EndInit();
            this.planungPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArbeitsbereiche)).EndInit();
            this.kalenderPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mitarbeiterGridSmall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arbeitsbereichBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage planungPage;
        private System.Windows.Forms.BindingSource mitarbeiterBindingSource;
        private System.Windows.Forms.TabPage mitarbeiterPage;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
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
        private System.Windows.Forms.DataGridView mitarbeiterGridSmall;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn geplanteArbeitszeitDataGridViewTextBoxColumn2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource arbeitsbereichBindingSource;
    }
}

