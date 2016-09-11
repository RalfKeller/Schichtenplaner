using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchichtenplanerWinForms
{
    public partial class SchichtDialog : Form
    {
        Schichtart schicht;
        BindingList<Arbeitsbereich> blArbeitsbereiche;

        public SchichtDialog(Schichtart schicht, BindingList<Arbeitsbereich> blArbeitsbereiche, Arbeitsbereich selectedArbeitsbereich) : this(schicht, blArbeitsbereiche)
        {
            cbArbeitsbereich.Text = selectedArbeitsbereich.Name;
        }
        public SchichtDialog(Schichtart schicht, BindingList<Arbeitsbereich> blArbeitsbereiche)
        {
            InitializeComponent();

            this.schicht = schicht;
            this.blArbeitsbereiche = blArbeitsbereiche;

            cbArbeitsbereich.Items.AddRange(blArbeitsbereiche.Select(a => a.Name).ToArray());

            if (schicht.Name == "" || schicht.Name == null)
            {

            }

            else
            {
                txtbxName.Text = schicht.Name;
                dtpStart.Value = DateTime.Parse(schicht.Startzeit);
                dtpEnd.Value = DateTime.Parse(schicht.Endzeit);

                foreach (ListViewItem wochentag in lvTage.Items)
                {
                    if(schicht.Wochentage.Contains(wochentag.Text))
                    {
                        wochentag.Checked = true;
                    }
                }
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            schicht.Name = txtbxName.Text;
            schicht.Startzeit = dtpStart.Value.ToString();
            schicht.Endzeit = dtpEnd.Value.ToString();
            schicht.Wochentage = new List<string>();
            schicht.Arbeitsbereich = blArbeitsbereiche.First(a => a.Name == cbArbeitsbereich.Text);
            schicht.MinAnzahlMitarbeiter = (int)numAnzahlMitarbeiter.Value;
            foreach (ListViewItem wochentag in lvTage.CheckedItems)
            {
                schicht.Wochentage.Add(wochentag.Text);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvTage.Items)
            {
                item.Checked = true;
            }
        }
    }
}
