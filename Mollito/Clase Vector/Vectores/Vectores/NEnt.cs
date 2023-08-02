using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectores
{
    class NEnt
    {
        private int n;//atributos 
        public NEnt() //constructor
        {
            n = 0;
        }
        public void Cargar(int dato)  //procedimiento void 
        {
            n = dato;

        }
        public void Cargar(int a, int b)
        {
            Random r;
            r = new Random();
            n = r.Next(a, b);

        }
        public int Descargar()    //funcion
        {
            return n;
        }
        public bool VerifPar()
        {
            //int res;
            bool b;
            //res = n % 2;
            if (n % 2 == 0)
                b = true;
            else
                b = false;
            return b;
        }
        public bool VerifPrimo()
        {
            int c, i, r;
            c = 0;
            for (i = 1; i <= n; i++)
            {
                r = n % i;
                if (r == 0)
                    c++;

            }
            return (c == 2);
        }
        public bool multiplo(NEnt n2)
        {

            int r = n % n2.n;

            return (r == 0);//34:06
        }

        public double AcumulDigitos()
        {
            double f = 0;
            int d;
            while (n > 0)
            {
                d = n % 10;
                f = f + 1.0 / d;
                n = n / 10;
            }
            return f;

        }
    }
}
