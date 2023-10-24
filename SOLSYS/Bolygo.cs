using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLSYS
{
    internal class Bolygo
    {
        public string Neve { get; set; }
        public int Szama { get; set; }
        public string Terfogat { get; set; }

        public Bolygo(string Sor)
        {
            var adat = Sor.Split(';');
            Neve = adat[0];
            Szama = int.Parse(adat[1]);
            Terfogat = adat[2];
        }
    }
}
