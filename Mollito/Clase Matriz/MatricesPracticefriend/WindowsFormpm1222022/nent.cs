using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormpm1222022
{
    class nent
    {

        private int n;
        public nent() // Constructor
        {
            n = 0;
        }

        public void cargar(int dato)
        {
            n = dato;
        }
        public int descargar()
        {
            return n;
        }


        public bool verifpri()
        {
            int num = 0;
            int num2 = this.n;

            {
                for (int i = 1; i <= num2; i++)
                {
                    int num3 = this.n % i;
                    bool flag = num3 == 0;
                    if (flag)
                    {
                        num++;
                    }
                }
                return num == 2;
            }
        }

        public bool verifpar()
        {
            int r;
            bool b;

            r = n % 2;
            if (r == 0)
            {
                b = true;
            }
            else
            {
                b = false;
            }
            return b;

        }




    }
}
