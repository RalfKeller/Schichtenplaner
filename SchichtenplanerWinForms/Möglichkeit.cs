using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchichtenplanerWinForms
{
    class Möglichkeit
    {

        public List<Arbeitstag> lstArbeitstage { get; private set; }
        public int linealisierterIndex { get; private set; }

        public List<Mitarbeiter> lstMitarbeiter { get; set; }

        public Möglichkeit(List<Arbeitstag> lstArbeitstage, int linealisierterIndex, List<Mitarbeiter> lstMitarbeiter)
        {
            this.lstMitarbeiter = lstMitarbeiter;
            //this.lstArbeitstage = lstArbeitstage;

            this.lstArbeitstage = new List<Arbeitstag>();
            foreach (Arbeitstag tag in lstArbeitstage)
            {
                this.lstArbeitstage.Add((Arbeitstag)tag.Clone());
            }

            this.linealisierterIndex = linealisierterIndex;
        }

        public List<Möglichkeit> permutiere()
        {
            List<Schicht> linListe = new List<Schicht>();

            //int counter = 0;
            //int schichtenTransferred;
            foreach (Arbeitstag tag in lstArbeitstage)
            {
                foreach (Schicht schicht in tag.lstSchichten)
                {
                    linListe.Add(schicht);

                    //counter++;
                }

                //if (counter > linealisierterIndex)
                //    break;
            }


            Schicht zuBearbeitendeSchicht = linListe[linealisierterIndex];

            List<List<Arbeitstag>> lstMöglichkeiten = new List<List<Arbeitstag>>();

            List<Schicht> lstNeueSchichten = zuBearbeitendeSchicht.permutate(lstMitarbeiter, 0);

            foreach (Schicht schicht in lstNeueSchichten)
            {
                List<Schicht> neuerMonat = new List<Schicht>();
                neuerMonat.AddRange(linListe);
                neuerMonat[linealisierterIndex] = schicht;

                lstMöglichkeiten.Add(neuerMonat.deLinearisiere());
            }


            List<Möglichkeit> returnList = new List<Möglichkeit>();
            foreach (List<Arbeitstag> lstMöglichkeit in lstMöglichkeiten)
            {
                Möglichkeit neueMöglichkeit = new Möglichkeit(lstMöglichkeit, linealisierterIndex + 1, lstMitarbeiter);
                returnList.Add(neueMöglichkeit);
            }

            return returnList;
        }

        public int punktzahl(List<Regel> lstRegeln)
        {
            int punkte = 1000;

            foreach (Regel regel in lstRegeln)
            {
                punkte += regel.punktzahl(lstArbeitstage);
            }

            return punkte;
        }


    }
}
