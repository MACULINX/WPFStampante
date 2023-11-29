using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucci.Marco._4I.Stampante
{
    internal class Stampante
    {
        int _c;
        int _m;
        int _y;
        int _b;
        int _fogli;

        public Stampante()
        {
            _c = 100;
            _m = 100;
            _y = 100;
            _b = 100;
            _fogli = 200;
        }

        public void SostituisiciColore(int c)
        {

        }

        public void AggiungiCarta(int qta)
        {
            _fogli += qta;

            if (_fogli > 200) _fogli = 200;
        }

        public bool Stampa(Pagina p)
        {
            if (_fogli == 0) return false;


            return true;
        }
    }
}
