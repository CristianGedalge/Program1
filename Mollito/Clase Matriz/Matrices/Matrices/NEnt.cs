using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
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

        public int Descargar()
        {
            return n;
        }

        public bool VerifPar()
        {
            return n% 2 == 0;
        }





        
    }
}
