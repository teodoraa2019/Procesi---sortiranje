using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IspisProcesaKonzola
{
    class Program
    {
        static void Main(string[] args)
        {
            var popisProcesa = System.Diagnostics.Process.GetProcesses();

            foreach(System.Diagnostics.Process p in popisProcesa)
            {
                Console.WriteLine(p);
            }
        }
    }
}
