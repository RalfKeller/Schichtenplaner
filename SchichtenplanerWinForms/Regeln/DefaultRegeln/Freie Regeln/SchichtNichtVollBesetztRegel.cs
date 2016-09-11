using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchichtenplanerWinForms.Regeln.DefaultRegeln
{
    class SchichtNichtVollBesetztRegel : Regel
    {
        public const int PRIO = -10;
        public int punktzahl(List<Arbeitstag> lstMonat)
        {

            if(lstMonat.Any(tag => tag.lstSchichten.Any(schicht => (schicht.Mitarbeiter.Count != schicht.Parent.MinAnzahlMitarbeiter))))
            {
                return PRIO;
            }

            return 0;
        }
    }
}
