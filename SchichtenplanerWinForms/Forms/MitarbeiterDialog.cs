using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchichtenplanerWinForms
{
    public partial class MitarbeiterDialog : Form
    {
        private Mitarbeiter mitarbeiter;
        private BindingList<Arbeitsbereich> blAlleBereiche;

        public MitarbeiterDialog(Mitarbeiter mitarbeiter, BindingList<Arbeitsbereich> arbeitsbereiche)
        {
            InitializeComponent();

            this.mitarbeiter = mitarbeiter;
            this.blAlleBereiche = arbeitsbereiche;

            if (mitarbeiter.Name == "" || mitarbeiter.Name == null)
            {
                this.Text = "Neuer Mitarbeiter";
            }

            else
            {
                this.Text = mitarbeiter.Name;
                txtbxName.Text = mitarbeiter.Name;
                numArbeitszeit.Value = mitarbeiter.GeplanteArbeitszeit;

                foreach (Arbeitsbereich bereich in arbeitsbereiche)
                {
                    lstbxArbeitsbereiche.Items.Add(bereich.Name);
                    if (mitarbeiter.Arbeitsbereiche.Contains(bereich))
                        lstbxArbeitsbereiche.SetItemChecked(lstbxArbeitsbereiche.Items.Count - 1, true);
                }

            }
        }

        private void lstbxArbeitsbereiche_ItemCheck(object sender, ItemCheckEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (string bereich in lstbxArbeitsbereiche.SelectedItems)
            {
                if (!mitarbeiter.Arbeitsbereiche.Any(a => a.Name == bereich))
                {
                    mitarbeiter.Arbeitsbereiche.Add(blAlleBereiche.First(b => b.Name == bereich));
                }
            }
        }
    }
}
