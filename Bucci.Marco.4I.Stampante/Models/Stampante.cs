using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucci.Marco._4I.Stampante.Models
{
    public class Stampante
    {
        public int B { get; set; }
        public int Y { get; set; }
        public int M { get; set; }
        public int C { get; set; }
        public int Fogli { get; set; }

        public Stampante()
        {
            C = M = Y = B = 100;

            Fogli = 200;
        }

        public void SostituisiciColore(string s)
        {

        }

        public int StatoInchiostro(string i)
        {
            switch (i)
            {
                case "cyan":
                    return C;

                case "magenta":
                    return M;
                    
                case "yellow":
                    return Y;

                case "black":
                    return B;

            }
            return 0;
        }
        public int StatoCarta()
        {
            return Fogli;
        }
        public void AggiungiCarta(int qta)
        {
            Fogli += qta;

            if (Fogli > 200) Fogli = 200;
        }

        public bool Stampa(Pagina p)
        {
            if (Fogli == 0) return false;

            if ( ( p.C >= C) || (p.M >= M) || (p.Y >= Y) || (p.B >= B) ) return false;

            Fogli--;

            B -= p.B;
            Y -= p.Y;
            M -= p.M;
            C -= p.C;

            return true;
        }
    }
}
