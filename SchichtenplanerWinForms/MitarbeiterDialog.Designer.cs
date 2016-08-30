namespace SchichtenplanerWinForms
{
    partial class MitarbeiterDialog
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
            this.lstbxArbeitsbereiche = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numArbeitszeit = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numArbeitszeit)).BeginInit();
            this.SuspendLayout();
            // 
            // lstbxArbeitsbereiche
            // 
            this.lstbxArbeitsbereiche.FormattingEnabled = true;
            this.lstbxArbeitsbereiche.Location = new System.Drawing.Point(24, 185);
            this.lstbxArbeitsbereiche.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstbxArbeitsbereiche.Name = "lstbxArbeitsbereiche";
            this.lstbxArbeitsbereiche.Size = new System.Drawing.Size(757, 235);
            this.lstbxArbeitsbereiche.TabIndex = 0;
            this.lstbxArbeitsbereiche.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lstbxArbeitsbereiche_ItemCheck);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Geplante Arbeitszeit:";
            // 
            // txtbxName
            // 
            this.txtbxName.Location = new System.Drawing.Point(189, 15);
            this.txtbxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(592, 26);
            this.txtbxName.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(549, 454);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Speichern";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(670, 454);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 6;
            this.button2.Text = "Verwerfen";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Arbeitsbereiche:";
            // 
            // numArbeitszeit
            // 
            this.numArbeitszeit.Location = new System.Drawing.Point(189, 63);
            this.numArbeitszeit.Name = "numArbeitszeit";
            this.numArbeitszeit.Size = new System.Drawing.Size(592, 26);
            this.numArbeitszeit.TabIndex = 8;
            // 
            // MitarbeiterDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 508);
            this.Controls.Add(this.numArbeitszeit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtbxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstbxArbeitsbereiche);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MitarbeiterDialog";
            ((System.ComponentModel.ISupportInitialize)(this.numArbeitszeit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox lstbxArbeitsbereiche;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbxName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numArbeitszeit;
    }
}