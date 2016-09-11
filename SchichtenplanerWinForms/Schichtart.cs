using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchichtenplanerWinForms
{
    public class Schichtart : INotifyPropertyChanged
    {
        public string ChangedProperty { get; protected set; }
        public event PropertyChangedEventHandler PropertyChanged;

        private string _name;
        /// <summary>
        /// Der Name der Schicht
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; NotifiyPropertyChanged("Name"); }
        }

        /// <summary>
        /// Der Arbeitsbereich dem diese Schicht zugeordnet ist
        /// </summary>
        public Arbeitsbereich Arbeitsbereich { get; set; }

        /// <summary>
        /// Die Anzahl der Mitarbeiter, die für diese Schicht benötigt wird
        /// </summary>
        public int MinAnzahlMitarbeiter { get; set; }

        /// <summary>
        /// Die Uhrzeit zu der diese Schicht anfängt
        /// </summary>
        public string Startzeit { get; set; }

        /// <summary>
        /// Die Uhrzeit zu der diese Schicht aufhört
        /// </summary>
        public string Endzeit { get; set; }

        /// <summary>
        /// Die Dauer der Schicht in Stunden
        /// </summary>
        public float Zeitspanne
        {
            get
            {
                DateTime start = DateTime.Parse(Startzeit);
                DateTime end = DateTime.Parse(Endzeit);
                TimeSpan span = end - start;
                return span.Hours + (span.Minutes / 60);
            }
        }

        public List<string> Wochentage { get; set; }

        public Schicht getSchicht()
        {
            Schicht s = new Schicht(this);
            return s;
        }

        protected void NotifiyPropertyChanged(string info)
        {
            ChangedProperty = info;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));
        }
    }
}
