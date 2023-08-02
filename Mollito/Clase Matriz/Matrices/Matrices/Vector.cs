using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    class Vector
    {
        const int max = 100;
        private int[] v;
        private int n;
        public Vector()
        {
            n = 0;
            v = new int[max];
        }
        public void Cargar1x1(int elem)
        {
            n++;
            v[n] = elem;
        }
        public string Descar()
        {
            String s = "";
            for (int i = 1; i <= n; i++)
                s = s + v[i] + "  ";
            return s;
        }
        public void Ordenar_Asc()
        {
            for (int i = 1; i <=n; i++)
                for (int p = i+1; p <=n; p++)
                {
                    if (!(v[i] <= v[p]))
                        Swap(i, p);
                }
        }

        public void Swap(int i,int p)
        {
            int aux = v[i];
            v[i] = v[p];
            v[p] = aux;
        }
        public int devol(int i)
        {
            return v[i];
        }
        public void OrdxFrec()
        {
            Vector ele = new Vector();
            Vector fre = new Vector();
            int c = 1;
            for (int i = 1; i <= n; i++)
            {
                if (v[i] == v[i + 1])
                    c++;
                else
                {
                    ele.Cargar1x1(v[i]);
                    fre.Cargar1x1(c);
                    c = 1;
                }
            }
            for (int i = 1; i <= fre.n; i++)
                for (int p = i; p <= fre.n; p++)
                    if (!(fre.v[i] >= fre.v[p]))
                    {
                        fre.Swap(i, p);
                        ele.Swap(i, p);
                    }
            n = 0;
            for(int i = 1; i <= ele.n; i++)
            {
                for (int p = 1; p <=fre.v[i]; p++)
                {
                    Cargar1x1(ele.v[i]);
                }
            }
        }

        public Boolean dentro(int elem)
        {
            for (int i = 1; i <=n; i++)
            {
                if (v[i] == elem)
                    return true;
            }
            return false;
        }
        public int longi()
        {
            return n;
        }
    }
}
