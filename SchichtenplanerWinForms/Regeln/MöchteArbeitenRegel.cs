using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchichtenplanerWinForms
{
    class MöchteArbeitenRegel : Regel
    {
        public List<DateTime> lstTage { get; set; }
        public int iPrio { get; set; }
        public Mitarbeiter mArbeiter { get; set; }

        /// <summary>
        /// Möchte arbeiten: True; Möchte nicht arbeiten: False
        /// </summary>
        public bool bMode { get; set; }
        
        public MöchteArbeitenRegel(Mitarbeiter mArbeiter, List<DateTime> lstTage, int iPrio, bool bMode)
        {
            this.mArbeiter = mArbeiter;
            this.lstTage = lstTage;
            this.iPrio = iPrio;
            this.bMode = bMode;
        }
        public int punktzahl(List<Arbeitstag> lstMonat)
        {
            int currentPunkte = 0;
            foreach (Arbeitstag tag in lstMonat)
            {
                if(bMode)
                {
                    //Der zweite Teil heißt:
                    //Wenn es nicht eine schicht an dem Tag gibt, für die gilt dass der Mitarbeiter in ihr arbeitet
                    //Ganze Abfrage auf deutsch: Möchte der Arbeiter an dem Tag arbeiten, macht es aber nicht? Dann Minuspunkte
                    if (lstTage.Contains(tag.dtDatum) && !tag.lstSchichten.Any(schicht => schicht.Mitarbeiter.Contains(mArbeiter)))
                    {
                        currentPunkte -= iPrio;
                    }
                }

                else
                {
                    //Deutsch: Möchte der Arbeiter an dem Tag nicht arbeiten, tut es aber? Dann Minuspunkte
                    if(lstTage.Contains(tag.dtDatum) && tag.lstSchichten.Any(schicht => schicht.Mitarbeiter.Contains(mArbeiter)))
                    {
                        currentPunkte -= iPrio;
                    }
                }

            }

            return currentPunkte;
        }
    }
}
