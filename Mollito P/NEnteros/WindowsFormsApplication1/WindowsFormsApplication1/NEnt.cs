using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class NEnt
    {
        private int n;
        public NEnt()
        {
            n = 0;
        }
        public void Cargar(int ele)
        {
            n = ele;
        }

        public int Descargar()
        {
            return n;
        }
        public bool EsMultiplo(int valor)
        {
            return (n % valor == 0);
        }
        public bool VerificarSubMultiplo(int valor)
        {
            return (valor % n == 0);

        }
        public int factorial()
        {
            if (n <= 1)
                return 1;
            int m = 1;
            for (int i = 1; i <= n; i++)
            {
                m *= i;
            }
            return m;


        }

        public bool VerifCapic()
        {
            int ncopy = n, res = 0;

            while (ncopy > 0)
            {
                res = res * 10 + ncopy % 10;
                ncopy = ncopy / 10;
            }
            return res == n;
        }

        public bool VerifPerteFibo()
        {
            int ant = 0, actual = 1;
            int fib = 0;
            while (fib < n)
            {
                fib = ant + actual;
                ant = actual;
                actual = fib;
            }
            return fib == n;
        }

        public void UnirMEnMAy(NEnt ele2,NEnt ele3)
        {
            int ncopy = n;
            if (ncopy < ele2.n)
                ele3.n = ncopy * (int)Math.Pow(10, ele2.n.ToString().Length) + ele2.n;
            else
                ele3.n = ele2.n * (int)Math.Pow(10, n.ToString().Length) + ncopy;
        }

        public void UnirMenMEdMayor(ref NEnt ele2, ref NEnt ele3,ref NEnt ele4)
        {
            int m = 0, r = 10,r2;
            if (n < r||n>r)
                r = n;
            if (ele2.n < r)
            {
                m = ele2.n * (int)Math.Pow(10, r.ToString().Length) + r;
                r = ele2.n;
                r2 = n;
            }
            else
            {
                m = r * (int)Math.Pow(10, ele2.n.ToString().Length) + ele2.n;
                r2 = ele2.n;
            }   
            if (ele3.n < ele2.n && ele3.n < n)
                m = ele3.n * (int)Math.Pow(10, m.ToString().Length) + m;
                
            else if (ele3.n >= r && ele3.n <= r2)
            {
                m = (r * (int)Math.Pow(10, ele3.n.ToString().Length)+ele3.n)* (int)Math.Pow(10, r2.ToString().Length)+r2;
            }
             else if (ele3.n > r && ele3.n > r2)
            {
                m = m * (int)Math.Pow(10, ele3.n.ToString().Length) + ele3.n;
            }

            ele4.n = m;
        }


        public void MAyorObjeto(NEnt ele2,NEnt ele3,ref NEnt ele4)
        {
            int obj=0;

            if (n > ele2.n && n > ele3.n)
                obj +=1;
            else
            {
                if (ele2.n > ele3.n)
                    obj += 2;
                else
                    obj += 3;
            }
            ele4.n = obj;

        }
        public bool VerifEveryIguales()
        {
            int ncopy = n;
            int res=ncopy%10;
            while (ncopy > 0)
            {
                if (ncopy % 10 == res)
                {
                    ncopy = ncopy / 10;
                }
                else
                    return false;         
            }
            return true;
        }
        public bool TodosPares()
        {
            int ncopy = n;
            while (ncopy>0)
            {
                if ((ncopy%2)%2==0)
                    ncopy = ncopy / 10;
                else
                    return false;
            }
            return true;
        }

        public  void Ordenar()
        {
            int m = 0;
            while (n> 0)
            {
                m = m * 10 + this.orden();
            }
            n = m;
            
        }

        public int orden()
        {
            int m = 0;
            int r = 10;
            while (n > 0)
            {
                if (n % 10 <= r)
                {
                    if (r < 10)
                        m = m * 10 + r;
                    r = n % 10;
                }
                else
                    m = m * 10 + n % 10;
                n = n / 10;
       
            }
            n = m;
            return r;
        }

        public bool Par(int ele)
        {
            return ele % 2 == 0;
        }
        public bool Primo(int ele)
        {
            return (ele == 2 || ele == 3 || ele == 5 || ele == 7);
            
        }
        public void Pares(NEnt ele2)
        {
            int m1=1,m=0;
            while (n > 0)
            {
                if (this.Par(n % 10)) {
                    m = n % 10 * m1+m;
                    m1 *= 10;
                }
                n /= 10;       
            }
            ele2.n = m;
        }
        public void Primos_Ordenados(ref NEnt ele2)
        {
            int m = 0;
            while (n > 0)
            {
                if (this.Primo(n % 10))
                    m = m*10+n%10;
                n /= 10;
            }
            ele2.n = m;
            ele2.Ordenar();
        }
    }
}
