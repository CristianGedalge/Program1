using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Vector
    {
        const int max = 100;//atributos
        private int[] v;
        private int n;
        public Vector() {
            n = 0;
            v = new int[max];
        }
        // metodos 
        public void cargar(int longi, int a, int b)
        {
            Random r = new Random();
            n = longi;
            for (int i = 1; i <= n; i++)
            {
                v[i] = r.Next(a, b);
            }
        }

        public String Descargar()
        {
            string s = "";
            for (int i = 1; i <= n; i++)
            {
                s = s + v[i] + " ";
            }
            return s;
        }

        public void Pregunt1(int m, Vector auxv2, ref Vector auxv3)
        {
            auxv2.n = 0;
            auxv3.n = 0;
            int c = 1, c1 = 0;
            for (int i = 1; i <= n; i++)
            {
                if (this.Multiplo(i, m))
                {
                    if (v[i] % 2 == 0)
                        auxv3.Cargar1x1(v[i]);
                    else
                        auxv2.Cargar1x1(v[i]);
                }
            }
            auxv2.Ascend();
            auxv3.Ascend();
            for (int i = 1; i <= n; i++)
            {

                if (this.Multiplo(i, m))
                    if (c <= auxv2.n)
                    {
                        v[i] = auxv2.v[c];
                        c++;
                    }
                    else
                    {
                        c1++;
                        v[i] = auxv3.v[c1];
                    }
            }
        }

        public void Ascend()   // 8513==5813==5183==5138
        {
            int aux;
            for (int i = 1; i <= n; i++)
            {
                aux = v[i];
                for (int p = i + 1; p <= n; p++)
                {
                    if (!(aux < v[p]))
                    {
                        aux = v[p];
                        Swap(i, p);
                    }
                }
            }
        }
        public void Swap(int a,int b) {
            int aux = v[a];
            v[a] = v[b];
            v[b] = aux;
        }
     
        public void Cargar1x1(int a)
        {
            n++;
            v[n] = a;
        }
        public Boolean Multiplo(int a ,int b)
        {
            return a % b == 0;

        }

        public void Pregunta2(int mult,int a, int b ,ref Vector aux1,ref Vector aux2)
        {
            int c;
            aux1.n = 0;
            aux2.n = 0;
            Vector bu = new Vector();
            bu.n = 0;
            for (int i = a; i <=b; i++)
            {
                bu.Cargar1x1(v[i]);
            }
            bu.Ascend();

            for (int p = 1; p <=bu.n; p++)
            {
                if (bu.v[p] % mult == 0 && !aux1.Dentro(bu.v[p]))
                {
                    aux1.Cargar1x1(bu.v[p]);
                    c = 0;
                    for (int j = 1; j<= bu.n; j++)
                        if (bu.v[p] == bu.v[j])
                            c++;
                    aux2.Cargar1x1(c);
                }   
            }
            
        }

        public Boolean Dentro(int a)
        {
            Boolean bandera = false;
            for (int i = 1; i <=n; i++)
            {
                if (v[i] == a)
                    bandera=true;
            }
            return bandera; 
        }

        public void Descendente()//1234
        {
            int aux;
            for (int i = 1; i <=n; i++)
            {
                aux = v[i];
                for(int p=i+1;p<= n;p++)
                    if ((v[i] <= v[p]))
                    {
                        aux = v[p];
                        Swap(i, p);
                    }
            }
        }
        public void Pares()
        {
            Vector vi= new Vector();
            vi.n = 0;
            for (int i = 1;  i <=n; i++)
            {
                if (v[i] % 2 == 0)
                    vi.Cargar1x1(v[i]);
            }
            n = 0;
            for(int i = 1; i <= vi.n; i++)
            {
                n++;
                v[i]=vi.v[i];
            }
        }
    }
}
