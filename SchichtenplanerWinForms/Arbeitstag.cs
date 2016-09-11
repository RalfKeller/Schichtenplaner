using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchichtenplanerWinForms
{
    public class Arbeitstag : ICloneable
    {
        public DateTime dtDatum { get; set; }
        public List<Schicht> lstSchichten { get; set; }

        public Arbeitstag()
        {
            lstSchichten = new List<Schicht>();
        }
        public object Clone()
        {
            Arbeitstag neuerTag = new Arbeitstag();
            neuerTag.dtDatum = new DateTime(dtDatum.Ticks);

            List<Schicht> lstNeueListe = new List<Schicht>();

            foreach (Schicht s in lstSchichten)
            {
                lstNeueListe.Add((Schicht)s.Clone());
            }

            neuerTag.lstSchichten = lstNeueListe;

            return neuerTag;
        }
    }
}
