using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchichtenplanerWinForms.Regeln.DefaultRegeln
{
    /// <summary>
    /// Ein Mitarbeiter kann nicht arbeiten wenn er krank oder im Urlaub ist
    /// </summary>
    class KrankUrlaubRegel : Regel
    {
        public int punktzahl(List<Arbeitstag> lstMonat)
        {
            //throw new NotImplementedException();
            return 0;
        }
    }
}
