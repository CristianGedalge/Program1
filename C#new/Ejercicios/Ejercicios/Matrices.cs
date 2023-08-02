using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    class Matrices
    {
        const  int mxf= 100;
        const int mxc = 100;
        private int[,] x;
        private int nc, nf;
        public Matrices()
        {
            x = new int [mxf, mxc];
            nc = 0;
            nf = 0;
        }

        public void Cargar(int nfil,int ncol,int a,int b)
        {
            Random r = new Random();
            nf = nfil;
            nc = ncol;
            for (int f = 1; f <=nf ; f++)
            {
                for (int c = 1; c <=nc; c++)
                {
                    x[f, c] = r.Next(a, b);
                }

            }

        }
        public  string Descargar()
        {
            string s = "";
            for (int f = 1; f <= nf; f++)
            {
                for (int c = 1; c <= nc; c++)
                {
                    s = s +x[f,c]+ "\x09";
                }
                s = s + "\x0d" + "\x0a";
            }
            return s;
        }

        public void OrdenarRaro()
        {
            for (int f = 1; f <= nf; f++)
            {
                for (int c = 1; c <= nc; c++)
                {
                    int caux = c;
                    for (int f1 = f; f1 <= nf; f1++)
                    {
                        for (int c1 = caux; c1 <=nc; c1++)
                        {
                            if (this.Longi(x[f, c]) <= this.Longi(x[f1, c1]))
                            {
                                if (x[f, c] != x[f1, c1])
                                {
                                    if (x[f, c] < x[f1, c1] || this.Longi(x[f1, c1]) > this.Longi(x[f, c]))
                                        this.Swap(f, c, f1, c1);
                                }
                            }
                        }
                        caux = 1;

                    }
                }
            }

        }
        public void Swap(int fil1,int col1,int fil2,int col2)
        {
            int aux = x[fil1, col1];
            x[fil1, col1] = x[fil2, col2];
            x[fil2, col2] = aux;


        }

        public int Longi(int elem)
        {
            int ct=0;
            for (int f = 1; f <= nf; f++)
            {
                for (int c = 1; c <= nc; c++)
                {
                    if (elem == x[f, c])
                        ct++;
                }
            }
            return ct;
        }
        public Boolean filter(int elem)
        {
            int ct = 0; 
            for (int f = 1; f <= nf; f++)
            {
                for (int c = 1; c <= nc; c++)
                {
                    if (elem == x[f, c])
                        ct++;
                }            
            }
            return ct > 1;
        }

    }
}
