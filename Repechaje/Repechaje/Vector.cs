using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repechaje
{
    class Vector
    {
        const int Max = 100;
      
        private int[] v;
        private int n;
        public Vector()
        {
            n = 0;
            v = new int[Max];
        }
        public void Cargar1x1(int elem)
        {
            n++;
            v[n] = elem;
        }
        public string descargar()
        {
            string s = "";
            for (int i = 1; i <=n; i++)
            {
                s = s + v[i] + "   ";

            }
            return s;
        }
        public bool dentro(int elem)
        {
            for (int i = 1; i <= n; i++)
                if (v[i] == elem)
                    return true;
            return false;
        }
        public void may_frec()
        {
            Vector elem = new Vector(), frec = new Vector();
            int c = 1;
            for (int i = 1; i <= n; i++)
            {
                if (v[i] == v[i + 1])
                    c++;
                else
                {
                    elem.Cargar1x1(v[i]);
                    frec.Cargar1x1(c);
                    c = 1;
                }
            }      

            for (int i = 1; i <= frec.n; i++)           
                for (int p = i; p <=frec.n; p++)
                    if (!(frec.v[i] >= frec.v[p]))
                    {
                        frec.Swap(i, p);
                        elem.Swap(i, p);
                    }
            c = 0;
            for (int i = 1; i <=elem.n; i++)
            {
                for (int p = 1; p <= frec.v[i]; p++)
                {
                    c++;
                    v[c] = elem.v[i];
                }
            }

            
        }
        public void Swap(int i,int p)
        {
            int aux = v[i];
            v[i] = v[p];
            v[p] = aux;
        }

        public void asc()
        {
            for (int i = 1; i <=n; i++)
                for (int p = i; p <=n; p++)
                {
                    if (!(v[i] <= v[p]))
                        Swap(i, p);
                }
        }
        public int longi()
        {
            return n;
        }
        public int devol(int pos)
        {
            return v[pos];
        }

        public void OrdXfrecuencia()
        {
            Vector vfre = new Vector(),vele=new Vector();
            int c = 1;
            for (int i = 1; i <=n; i++)
            {
                if (v[i] == v[i + 1])
                    c++;
                else
                {
                    vfre.Cargar1x1(c);
                    vele.Cargar1x1(v[i]);
                    c = 1;
                }
            }
            for (int i = 1; i <= vfre.n; i++)
                for (int p = i; p <= vfre.n; p++)
                    if (!(vfre.v[i] >= vfre.v[p]))
                    {
                        vfre.Swap(i, p);
                        vele.Swap(i, p);
                    }
            c = 0;
            for (int i = 1; i <=vele.n; i++)
            {
                for(int p=1;p<=vfre.v[i];p++)
                {
                    c++;
                    v[c] = vele.v[i];
                }
            }    
        }
    }
}
