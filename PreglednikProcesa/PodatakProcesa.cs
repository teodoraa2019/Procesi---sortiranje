using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreglednikProcesa
{
    class PodatakProcesa
    {
        public PodatakProcesa(System.Diagnostics.Process p)
        {
            this.p = p;
        }

        public System.Diagnostics.Process p { get; set; }
        public override string ToString()
        {
            return p.ProcessName + " - " + p.Id;
        }
    }
}
