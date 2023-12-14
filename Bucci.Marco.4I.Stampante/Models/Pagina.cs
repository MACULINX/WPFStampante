using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucci.Marco._4I.Stampante.Models
{
    public class Pagina
    {
        private int c;
        private int m;
        private int y;
        private int k;

        public int C
        {
            get
            {
                return c;
            }
            set
            {
                if (value >= MAX || value < 0)
                    throw new ArgumentOutOfRangeException($"Il valore inserito non e' consentito \n (il valore deve essere compreso tra 0 e {MAX - 1})");
                c = value;
            }
        }
        public int M
        {
            get
            {
                return m;
            }
            set
            {
                if (value >= MAX || value < 0)
                    throw new ArgumentOutOfRangeException($"Il valore inserito non e' consentito \n (il valore deve essere compreso tra 0 e {MAX - 1})");
                m = value;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                if (value >= MAX || value < 0)
                    throw new ArgumentOutOfRangeException($"Il valore inserito non e' consentito \n (il valore deve essere compreso tra 0 e {MAX - 1})");
                y = value;
            }
        }
        public int K
        {
            get
            {
                return k;
            }
            set
            {
                if (value >= MAX || value < 0)
                    throw new ArgumentOutOfRangeException($"Il valore inserito non e' consentito \n (il valore deve essere compreso tra 0 e {MAX - 1})");
                k = value;
            }
        }


        private const int MAX = 4;

        public Pagina(int c, int m, int y, int k)
        {
            C = c;
            M = m;
            Y = y;
            K = k;
        }

        public Pagina()
        {
            var r = new Random();

            C = r.Next(MAX);
            M = r.Next(MAX);
            Y = r.Next(MAX);
            K = r.Next(MAX);
        }
    }
}
