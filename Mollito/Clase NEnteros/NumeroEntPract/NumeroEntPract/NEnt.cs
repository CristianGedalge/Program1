using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroEntPract
{
    class NEnt
    {
        private int n;
        public NEnt()
        {
            n = 0;
        }
        public void Cargar(int dato) 
        {
            n = dato;
        }
        public int Descargar()
        {
            return n;
        }
        public bool VerifPar()
        {
            return (n % 2 == 0);
        }
        public bool EsMultiplo(int valor)
        {
            return ( n % valor == 0);
        }
        public bool VerifPrimo()
        {
            int i,c;
            c = 0;
            if (n == 0)
                return false;
            for (i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    c++;
            }
            return (c == 2);
        }
        public bool VerificarSubMultiplo(int valor)
        {
            return (valor % n == 0);
               
        }
        public bool VerificarCapicua()
        {
            int cociente, residuo,m,nuevo;
            m = 1;
            nuevo = 0;
            cociente = n;
            while (cociente != 0)                   //102  2 0 1

            {
                residuo = cociente % 10;
                cociente = cociente / 10;
                nuevo = nuevo * m + residuo;
                m = 10;
            }
            //if (n > 0 && n % 10 == 0)
                //return false;
            //else
            return (n == nuevo);

        }
        public  bool VerificarFibo()
        {
            int  m,aux;
            m = 0;
            aux = 1;
            while( m< n)
            {
                m = m + aux;
                aux = m - aux;
            

            }
            return (n == m);
        }
        public int Factorial()
        {
            int i,m;
            if (n <= 1)
                return 1;
            m = 1;
            for(i=1;i<= n; i++)
            {
                m = m * i;
            }
            return m;
                

        }

        public  bool verificarorden()
        {
            bool b;
            int coc, res,co;
            coc = n;
            co = 9;
            b = true;
            while (coc != 0)
            {
                res = coc % 10;
                coc = coc / 10;
                if ( res <= co)
                 
                    co = res;
                else
                {
                    b = false;
                    break;
                }                                              
            }
            return b;
        }

               

    }
}
