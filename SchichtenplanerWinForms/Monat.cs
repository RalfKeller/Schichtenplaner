using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchichtenplanerWinForms
{
    public class JahrMonatIdentifier
    {
        public int Jahr { get; set; }
        public int Monat { get; set; }

        public override bool Equals(object obj)
        {
            if (!(obj.GetType() == typeof(JahrMonatIdentifier)))
                return false;

            JahrMonatIdentifier other = obj as JahrMonatIdentifier;
            return Jahr == other.Jahr && Monat == other.Monat;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
