using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchichtenplanerWinForms.Regeln.DefaultRegeln
{
    /// <summary>
    /// Bewertet die Einhaltung der Arbeitszeit eines Mitarbeiters in einem Monat.
    /// </summary>
    public class ArbeitszeitRegel : Regel
    {
        public const int PRIO = -5;

        public Mitarbeiter mArbeiter { get; set; }

        public ArbeitszeitRegel(Mitarbeiter mArbeiter)
        {
            this.mArbeiter = mArbeiter;
        }

        public int punktzahl(List<Arbeitstag> lstMonat)
        {
            float countedHours = 0;
            foreach (Arbeitstag tag in lstMonat)
            {
                List<Schicht> lstSchichtenDesArbeiters = tag.lstSchichten.Where(schicht => schicht.Mitarbeiter.Contains(mArbeiter)).ToList();

                foreach (Schicht schicht in lstSchichtenDesArbeiters)
                {
                    countedHours = schicht.Parent.Zeitspanne;
                } 
            }

            if (countedHours != mArbeiter.GeplanteArbeitszeit)
            {
                return -5;
            }

            else
                return 0;
        }
    }
}
