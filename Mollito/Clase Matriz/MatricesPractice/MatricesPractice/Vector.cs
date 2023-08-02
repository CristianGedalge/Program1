using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatricesPractice
{
    class Vector
    {
        const int max = 100;
        private int[] v;
        private int n;
        public Vector()
        {
            n = 0;
            v=new int [max];
        }
        public void Cargar1x1(int elem)
        {
            n++;
            v[n] = elem;
        }

        public int Mayorfrecuencia()
        {
            Vector vaux = new Vector();vaux.n = 0;
            Vector vaux2 = new Vector();vaux2.n = 0;
            int c=0, aux;
            for (int i = 1; i <=n; i++)
            {
                aux = v[i];
                if (!vaux.dentro(aux))
                {
                    vaux.Cargar1x1(v[i]);
                    for(int p=1;p<= n; p++)
                    {
                        if (v[p] == aux)
                            c++;
                    }
                    vaux2.Cargar1x1(c);
                    c = 0;
                }
            }
            return vaux.v[vaux2.MayorPosicion()];
        }
        public int Devolver(int i)
        {
            return v[i];
        }
        public void begin()
        {
            n = 0;
        }

        public int MayorPosicion()//17238
        {
            int mayor = 1;
            int aux = v[1];
            for (int i = 1; i <= n; i++)
            {
                if (!(aux >= v[i]))
                {
                    aux = v[i];
                    mayor = i;
                }
            }
            return mayor;
        }
        public bool dentro(int elem)
        {
            for (int i= 1; i <=n; i++)
            {
                if (v[i] == elem)
                    return true;
            }
            return false;
        }

        public void ParImpar()
        {
            int c = 0; 
            Vector Par = new Vector();
            Vector Impar = new Vector();
            Ordenar_Ascente();
            for (int i = 1; i <= n; i++)
            {
                if (v[i] % 2 == 0)
                    Par.Cargar1x1(v[i]);
                else
                    Impar.Cargar1x1(v[i]);
            }
            for (int i = 1; i <= n; i++)
            {
                if (i <= Par.n)
                    v[i] = Par.v[i];
                else
                {
                    c++;
                    v[i] = Impar.v[c];
                }
            }
        }
        public void Ordenar_Ascente()
        {
            for (int i = 1; i <= n; i++)
            {
                for (int p = i; p <= n; p++)//32751 23751 13752 12753 12573 12375
                {
                    if (!(v[i]<= v[p]))
                    {
                        Swap(i, p);
                    }
                }
            }
        }
        public void Swap(int a,int b)
        {
            int aux = v[a];
            v[a] = v[b];
            v[b] = aux;
        }

        public int LongVector()
        {
            return n;
        }

    }
}
