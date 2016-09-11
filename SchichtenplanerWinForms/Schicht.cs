using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchichtenplanerWinForms
{
    public class Schicht : ICloneable
    {
        public delegate void SchichtChangedHandler(ListChangedEventArgs args);
        public event SchichtChangedHandler SchichtChanged;

        public DateTime Date { get; set; }

        private Schichtart _parent;
        public Schichtart Parent
        {
            get { return _parent; }
            private set { _parent = value; }
        }

        private BindingList<Mitarbeiter> _mitarbeiter;
        public BindingList<Mitarbeiter> Mitarbeiter
        {
            get { return _mitarbeiter; }
            private set { _mitarbeiter = value; }
        }

        public Schicht(Schichtart parent)
        {
            _parent = parent;
            _mitarbeiter = new BindingList<Mitarbeiter>();

            _parent.PropertyChanged += _parent_PropertyChanged;
            _mitarbeiter.ListChanged += _mitarbeiter_ListChanged;
        }

        private void _parent_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            SchichtChanged?.Invoke(null);
        }

        private void _mitarbeiter_ListChanged(object sender, ListChangedEventArgs e)
        {
            SchichtChanged?.Invoke(e);
        }

        public object Clone()
        {
            Schicht neueSchicht = new Schicht(Parent);
            neueSchicht.Date = new DateTime(Date.Ticks);
            neueSchicht.Mitarbeiter = new BindingList<Mitarbeiter>();

            foreach (Mitarbeiter mArbeiter in Mitarbeiter)
            {
                neueSchicht.Mitarbeiter.Add(mArbeiter);
            }

            return neueSchicht;
        }

        public List<Schicht> permutate(List<Mitarbeiter> lstMitarbeiter, int index)
        {
            List<Schicht> returnList = new List<Schicht>();

            if (index == Parent.MinAnzahlMitarbeiter)
                return returnList;

            for (int i = 0; i < lstMitarbeiter.Count; i++)
            {
                Schicht neueSchicht = (Schicht)this.Clone();
                neueSchicht.Mitarbeiter.Add(lstMitarbeiter[i]);
                returnList.Add(neueSchicht);
            }

            returnList.AddRange(permutate(lstMitarbeiter, index + 1));
            return returnList;
        }

        public class SchichtChangedEventArgs
        {
            public enum ChangeType
            {
                MitarbeiterAdded,
                MitarbeiterRemoved,
                MitarbeiterRenamed,
            }

            public ChangeType Type;
            public int index;
        }

    }
}
