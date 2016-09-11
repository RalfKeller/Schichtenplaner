using SchichtenplanerWinForms.Regeln.DefaultRegeln;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchichtenplanerWinForms.Regeln
{
    public static class RegelInfo
    {
        public static List<Regel> getDefaultRegelnFürMitarbeiter(Mitarbeiter m)
        {
            List<Regel> returnList = new List<Regel>();

            returnList.Add(new ArbeitszeitRegel(m));
            returnList.Add(new KrankUrlaubRegel());

            return returnList;
        }

        //Freie Regel = Regel die an keinen Mitarbeiter gebunden ist.
        public static List<Regel> getFreieRegeln()
        {
            List<Regel> returnList = new List<Regel>();

            returnList.Add(new SchichtNichtVollBesetztRegel());

            return returnList;
        }
    }
}
