using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchichtenplanerWinForms
{
    public interface Regel
    {
        int punktzahl(List<Arbeitstag> lstMonat);
    }
}
