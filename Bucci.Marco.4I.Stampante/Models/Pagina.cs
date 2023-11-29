using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucci.Marco._4I.Stampante.Models
{
    public class Pagina
    {
        public int B { get ; set; }
        public int Y { get ; set; }
        public int M { get; set; }
        public int C { get; set; }

        public Pagina(int c, int m, int y, int b)
        {
            if (c > 3 || m > 3 || y > 3 || b > 3)
                throw new ArgumentException("Troppo inchiostro");

            C = c;
            M = m;
            Y = y;
            B = b;
        }

        public Pagina()
        {
            var r = new Random();

            C = r.Next(4);
            M = r.Next(4);
            Y = r.Next(4);
            B = r.Next(4);
        }
    }
}
