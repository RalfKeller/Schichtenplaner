using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchichtenplanerWinForms
{
    public class Mitarbeiter : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _name;
        private int _geplanteArbeitszeit;
        private BindingList<Arbeitsbereich> _arbeitsbereiche;

        public string Name
        {
            get { return _name; }
            set { _name = value; NotifiyPropertyChanged("Name"); }
        }

        public int GeplanteArbeitszeit
        {
            get { return _geplanteArbeitszeit; }
            set { _geplanteArbeitszeit = value; NotifiyPropertyChanged("GeplanteArbeitszeit"); }
        }

        public BindingList<Arbeitsbereich> Arbeitsbereiche
        {
            get { return _arbeitsbereiche; }
            set { _arbeitsbereiche = value; NotifiyPropertyChanged("Arbeitsbereiche"); }
        }

        public Dictionary<JahrMonatIdentifier, BindingList<Schicht>> Schichten { get; set; }

        public List<string> Arbeitstage { get; set; } = new List<string>();

        private void NotifiyPropertyChanged(string info)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));
        }

        public Mitarbeiter()
        {
            Arbeitsbereiche = new BindingList<Arbeitsbereich>();
            Schichten = new Dictionary<JahrMonatIdentifier, BindingList<Schicht>>();
        }
    }
}
