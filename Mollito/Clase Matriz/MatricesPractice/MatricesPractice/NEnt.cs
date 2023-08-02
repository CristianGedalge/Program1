using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatricesPractice
{
    class NEnt
    {
        private int n;
        public NEnt()
        {
            n = 0;
        }

        public void Cargar(int elem)
        {
            n = elem;
        }

        public  int Descargar()
        {
            return n;
        }

        public bool VerifPrim()
        {
            int cntdr = 0;
            for (int i = 1; i <=n; i++)
            {
                if (n% i == 0)
                    cntdr++;
            }
            return cntdr == 2;
        }
        public bool VerifPar()
        {
            return n % 2 == 0;
        }
    }

}
