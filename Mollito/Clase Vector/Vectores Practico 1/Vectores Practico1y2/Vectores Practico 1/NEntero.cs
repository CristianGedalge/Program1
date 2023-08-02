using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectores_Practico_1
{
    class NEntero
    {
        private int n;
        public NEntero()
        {
            n = 0;
        }
        public void Cargar(int n1)
        {
            n = n1;
        }
        public int Descargar()
        {
            return n;
        }
        public int Factorial()
        {
            int fac=1;
            if (n == 1 || n == 0)
                return 1;
            else
            {
                for (int i = 1; i <= n; i++)
                    fac = fac * i;
                return fac;
            }       
        }

        public Boolean Submultiplo(int a, int b)
        {
            if ((a % b) == 0)

                return true;
            else
                return false;
            
        }  
        
        public Boolean VerifPrimo()
        {
            int i,c=0;
            for(i=1;i<= n; i++)
            {
                if (n % i == 0)
                    c++;
            }
            return c == 2;
        }

        public Boolean Capicua() 
        {
            int mod, div=n,res=0; 
        
            while ( div > 0)
            {
                mod=div%10;
                div = div/ 10;
                res = (res*10)+mod;  
            }
            return (n == res);
      
        }

    }
}
