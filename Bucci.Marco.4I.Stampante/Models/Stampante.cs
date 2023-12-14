using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucci.Marco._4I.Stampante.Models
{
    public class Stampante
    {
        public int C { get; set; }
        public int M { get; set; }
        public int Y { get; set; }
        public int K { get; set; }

        public int Fogli { get; set; }

        public Stampante()
        {
            C = M = Y = K = 100;

            Fogli = 200;
        }

        public Stampante(string row)
        { 
            try 
            {
                string[] r = row.Split(';');

                C = Convert.ToInt32(r[0]);
                M = Convert.ToInt32(r[1]);
                Y = Convert.ToInt32(r[2]);
                K = Convert.ToInt32(r[3]);

                Fogli = Convert.ToInt32(r[4]);


            }catch 
            {
                throw new Exception("L'ultimo salvataggio non e' valido");
            }

        }

        public void SostituisiciColore(int i)
        {
            switch (i)
            {
                case (int)Colori.Cyan:
                    C = 100;
                    return;

                case (int)Colori.Magenta:
                    M = 100;
                    return;

                case (int)Colori.Yellow:
                    Y = 100;
                    return;

                case (int)Colori.Black:
                    K = 100;
                    return;

                default:
                    throw new Exception("Opzione non valida");
            }

        }

        public int AggiungiCarta(int qta)
        { 
            int retVal = 0;

            if (qta < 0) qta = 0;  
            
            Fogli += qta;

            if (Fogli > 200)
            { 
                retVal = Fogli - 200;
                Fogli = 200;

                return retVal;
            }

            return retVal;
        }

        public bool Stampa(Pagina p)
        {
            if (Fogli == 0) return false;

            if ( ( p.C >= C) || (p.M >= M) || (p.Y >= Y) || (p.K >= K) ) return false;

            Fogli--;

            K -= p.K;
            Y -= p.Y;
            M -= p.M;
            C -= p.C;

            return true;
        }

        public override string ToString() 
        {
            return $"{C};{M};{Y};{K};{Fogli}";
        }
    }
}
