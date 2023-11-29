using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucci.Marco._4I.Stampante
{
    internal class Pagina
    {
        int _c;
        int _m;
        int _y;
        int _b;

        public int B { get => _b; }
        public int Y { get => _y; }
        public int M { get => _m; }
        public int C { get => _c; }

        public Pagina(int c, int m, int y, int b)
        {
            if (c >3 || m > 3 || y > 3 || b > 3)
                throw new ArgumentException("Troppo inchiostro");

            _c = c;
            _m = m;
            _y = y;
            _b = b;
        }

        public Pagina() 
        { 
            var r = new Random();

            _c = r.Next(4);
            _m = r.Next(4);
            _y = r.Next(4);
            _b = r.Next(4);
        }
    }
}
