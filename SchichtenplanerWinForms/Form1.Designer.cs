﻿namespace SchichtenplanerWinForms
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Montag");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Dienstag");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Mittwoch");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Donnerstag");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Freitag");
            this.tabControl = new System.Windows.Forms.TabControl();
            this.planungPage = new System.Windows.Forms.TabPage();
            this.mitarbeiterGrid = new System.Windows.Forms.DataGridView();
            this.geplanteArbeitszeitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.mitarbeiterPage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddArbeitsbereich = new System.Windows.Forms.Button();
            this.kalenderPage = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.mitarbeiterGridSmall = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.geplanteArbeitszeitDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mitarbeiterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.geplanteArbeitszeitDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.planungPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mitarbeiterGrid)).BeginInit();
            this.mitarbeiterPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.kalenderPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mitarbeiterGridSmall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitarbeiterBindingSource)).BeginInit();
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
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Margin = new System.Windows.Forms.Padding(10);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(820, 415);
            this.tabControl.TabIndex = 0;
            // 
            // planungPage
            // 
            this.planungPage.AutoScroll = true;
            this.planungPage.Controls.Add(this.groupBox1);
            this.planungPage.Location = new System.Drawing.Point(4, 22);
            this.planungPage.Name = "planungPage";
            this.planungPage.Padding = new System.Windows.Forms.Padding(3);
            this.planungPage.Size = new System.Drawing.Size(812, 389);
            this.planungPage.TabIndex = 1;
            this.planungPage.Text = "Planung";
            this.planungPage.UseVisualStyleBackColor = true;
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
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(553, 360);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Hinzufügen";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(634, 360);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Ändern";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(715, 360);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Löschen";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // mitarbeiterPage
            // 
            this.mitarbeiterPage.Controls.Add(this.btnDelete);
            this.mitarbeiterPage.Controls.Add(this.btnEdit);
            this.mitarbeiterPage.Controls.Add(this.btnAdd);
            this.mitarbeiterPage.Controls.Add(this.label2);
            this.mitarbeiterPage.Controls.Add(this.label1);
            this.mitarbeiterPage.Controls.Add(this.mitarbeiterGrid);
            this.mitarbeiterPage.Location = new System.Drawing.Point(4, 22);
            this.mitarbeiterPage.Name = "mitarbeiterPage";
            this.mitarbeiterPage.Padding = new System.Windows.Forms.Padding(3);
            this.mitarbeiterPage.Size = new System.Drawing.Size(812, 389);
            this.mitarbeiterPage.TabIndex = 0;
            this.mitarbeiterPage.Text = "Mitarbeiter";
            this.mitarbeiterPage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnAddArbeitsbereich);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 227);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arbeitsbereiche";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(777, 172);
            this.dataGridView1.TabIndex = 0;
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
            // kalenderPage
            // 
            this.kalenderPage.Controls.Add(this.mitarbeiterGridSmall);
            this.kalenderPage.Controls.Add(this.treeView1);
            this.kalenderPage.Location = new System.Drawing.Point(4, 22);
            this.kalenderPage.Name = "kalenderPage";
            this.kalenderPage.Padding = new System.Windows.Forms.Padding(3);
            this.kalenderPage.Size = new System.Drawing.Size(812, 389);
            this.kalenderPage.TabIndex = 2;
            this.kalenderPage.Text = "Kalender";
            this.kalenderPage.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.AllowDrop = true;
            this.treeView1.Location = new System.Drawing.Point(306, 7);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "montagRoot";
            treeNode1.Text = "Montag";
            treeNode2.Name = "dienstagRoot";
            treeNode2.Text = "Dienstag";
            treeNode3.Name = "mittwochRoot";
            treeNode3.Text = "Mittwoch";
            treeNode4.Name = "donnerstagRoot";
            treeNode4.Text = "Donnerstag";
            treeNode5.Name = "freitagRoot";
            treeNode5.Text = "Freitag";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            this.treeView1.Size = new System.Drawing.Size(500, 376);
            this.treeView1.TabIndex = 0;
            this.treeView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeView1_DragDrop);
            this.treeView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeView1_DragEnter);
            this.treeView1.DragOver += new System.Windows.Forms.DragEventHandler(this.treeView1_DragOver);
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
            this.mitarbeiterGridSmall.Location = new System.Drawing.Point(7, 7);
            this.mitarbeiterGridSmall.MultiSelect = false;
            this.mitarbeiterGridSmall.Name = "mitarbeiterGridSmall";
            this.mitarbeiterGridSmall.ReadOnly = true;
            this.mitarbeiterGridSmall.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mitarbeiterGridSmall.Size = new System.Drawing.Size(293, 376);
            this.mitarbeiterGridSmall.TabIndex = 1;
            this.mitarbeiterGridSmall.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mitarbeiterGridSmall_MouseDown);
            this.mitarbeiterGridSmall.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mitarbeiterGridSmall_MouseMove);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 439);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Schichtenplanung";
            this.tabControl.ResumeLayout(false);
            this.planungPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mitarbeiterGrid)).EndInit();
            this.mitarbeiterPage.ResumeLayout(false);
            this.mitarbeiterPage.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.kalenderPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mitarbeiterGridSmall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitarbeiterBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddArbeitsbereich;
        private System.Windows.Forms.TabPage kalenderPage;
        private System.Windows.Forms.DataGridView mitarbeiterGridSmall;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn geplanteArbeitszeitDataGridViewTextBoxColumn2;
        private System.Windows.Forms.TreeView treeView1;
    }
}

