using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchichtenplanerWinForms
{
    public class Mitarbeiter
    {
        public string Name { get; set; }
        public int GeplanteArbeitszeit { get; set; }
        public BindingList<Arbeitsbereich> Arbeitsbereiche { get; set; } = new BindingList<Arbeitsbereich>();
    }
}
