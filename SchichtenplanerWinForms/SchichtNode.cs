using Syncfusion.Windows.Forms.Tools;
using System.Drawing;

namespace SchichtenplanerWinForms
{
    class SchichtNode : TreeNodeAdv
    {
        Schicht thisSchicht;

        public SchichtNode(Schicht schicht)
        {
            thisSchicht = schicht;
            thisSchicht.SchichtChanged += ThisSchicht_SchichtChanged;
            Text = thisSchicht.Parent.Name + "(" + schicht.Mitarbeiter.Count + " / " + schicht.Parent.MinAnzahlMitarbeiter + ")";
            Background = new Syncfusion.Drawing.BrushInfo(Color.FromArgb(255, 255, 119, 114));
        }

        public void addMitarbeiter(Mitarbeiter m)
        {
            thisSchicht.Mitarbeiter.Add(m);
            Nodes.Add(new TreeNodeAdv(m.Name));
            Text = thisSchicht.Parent.Name + "(" + thisSchicht.Mitarbeiter.Count + " / " + thisSchicht.Parent.MinAnzahlMitarbeiter + ")";

            if (thisSchicht.Mitarbeiter.Count == thisSchicht.Parent.MinAnzahlMitarbeiter)
            {
                Background = new Syncfusion.Drawing.BrushInfo(Color.FromArgb(0, 4, 237, 86));
            }
        }

        private void ThisSchicht_SchichtChanged(System.ComponentModel.ListChangedEventArgs args)
        {
            
        }
    }
}
