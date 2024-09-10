using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szintfelmero_2024_kovacs_peter_12f
{
    public class Meccs
    {
        public int Fordulo { get; set; }
        public int Hazai { get; set; }
        public int Vendeg { get; set; }
        public int HazaiFel { get; set; }
        public int VendegFel { get; set; }
        public string HazaiNev { get; set; }
        public string VendegNev { get; set; }

        public Meccs(int fordulo, int hazai, int vendeg, int hazaiFel, int vendegFel, string hazaiNev, string vendegNev)
        {
            Fordulo = fordulo;
            Hazai = hazai;
            Vendeg = vendeg;
            HazaiFel = hazaiFel;
            VendegFel = vendegFel;
            HazaiNev = hazaiNev;
            VendegNev = vendegNev;
        }
    }
}
