using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchichtenplanerWinForms
{
    public static class Extensions
    {
        /// <summary>
        /// Vorraussetzung: Alle Schichten sind im selben Monat.
        /// </summary>
        /// <param name="lstSchicht"></param>
        /// <returns></returns>
        public static List<Arbeitstag> deLinearisiere(this List<Schicht> lstSchicht)
        {
            List<Arbeitstag> returnList = new List<Arbeitstag>();

            int year = lstSchicht[0].Date.Year;
            int month = lstSchicht[0].Date.Month;
            int tageInMonat = DateTime.DaysInMonth(year, month);

            for (int i = 0; i < tageInMonat; i++)
            {
                Arbeitstag neuerTag = new Arbeitstag();
                neuerTag.dtDatum = new DateTime(year, month, i + 1);
                returnList.Add(neuerTag);
            }

            foreach (Schicht schicht in lstSchicht)
            {
                returnList[schicht.Date.Day - 1].lstSchichten.Add(schicht);
            }

            return returnList;
        }

        public static List<E> deepCopy<E>(this List<E> lst) where E : ICloneable
        {
            List<E> returnList = new List<E>();

            foreach (ICloneable clonable in lst)
            {
                returnList.Add((E)clonable.Clone());
            }

            return returnList;
        }
    }
}
