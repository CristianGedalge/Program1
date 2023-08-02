using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCE
{
    class nent
    {
        private int n;

        public nent()
        {
            n = 0;
        }
        public void load(int d)
        {
            n = d;
        }
        public int descargar()
        {
            return n;
        }
        public bool verifDigIgual()
        {
            int na, d, dr;
            bool b;
            na = n;
            d = 0;
            dr = na % 10;
            na = na / 10;
            b = true;
            while (na > 0 && b == true)
            {
                d = na % 10;
                na = na / 10;
                if (d == dr)
                    dr = d;
                else
                    b = false;
            }
            return b;
        }
        public bool DigDif()
        {
            int na, d, dr;
            bool b;
            na = n;
            d = 0;
            dr = na % 10;
            na = na / 10;
            b = true;
            while (na > 0 && b == true)
            {
                d = na % 10;
                na = na / 10;
                if (!(d == dr))
                    dr = d;
                else
                    b = false;
            }
            return b;
        }
        public bool DigRig()
        {
            int na, d, dr;
            bool b;
            na = n;
            d = 0;
            dr = na % 10;
            na = na / 10;
            b = true;
            while (na > 0 && b == true)
            {
                d = na % 10;
                na = na / 10;
                if (d - dr == 1)
                {
                    dr = d;
                }
                else
                {
                    b = false;
                }
            }
            return b;
        }
        public bool DigMay()
        {
            int na, d, dr;
            bool b;
            na = n;
            d = 0;
            dr = na % 10;
            na = na / 10;
            b = true;
            while (na > 0 && b == true)
            {
                d = na % 10;
                na = na / 10;
                if (d + 1 == dr)
                {
                    dr = d;
                }
                else
                {
                    b = false;
                }
            }
            return b;
        }

    }
}
