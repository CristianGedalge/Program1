using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repechaje
{
    class Matrix
    {
        const int Maxf = 100;
        const int Maxc = 100;
        private int[,] M;
        private int fil;
        private int col;
        public Matrix()
        {
            fil = 0;
            col = 0;
            M = new int[Maxf, Maxc];
        }
        public void Cargar(int nf,int nc,int a ,int b)
        {
            fil = nf;col = nc;
            Random r = new Random();
            for (int f = 1; f <=fil; f++)
            {
                for (int c = 1; c <=col; c++)
                {
                    M[f, c] = r.Next(a, b);
                }
            }
        }

        public string desc()
        {
            string s = "";
            for (int f = 1; f <= fil; f++)
            {
                for (int c = 1; c <= col; c++)
                {
                    s=s+M[f, c]+"\x09";
                }
                s = s + "\x0d" + "\x0a";
            }
            return s;
        }

        public void p1(int ncol)
        {

            for (int c = ncol; c <= ncol; c++)
                for (int f = 1; f <= fil; f++)
                    for (int fi = f; fi <= fil; fi++)
                        if (!(M[f, c] <= M[fi, c]))
                            SwapCol(f, fi);         
        }
        public void SwapCol(int f, int fi)
        {
            int aux;
            for (int c = 1; c <= col; c++)
            {
                aux = M[f, c];
                M[f, c] = M[fi, c];
                M[fi, c] = aux;
            }
        }

        public void p2(int nfi,int nff,int nci,int ncf)
        {
            int cnt;
            Vector velr = new Vector(), vfre = new Vector(), veleu = new Vector();
            for (int c= nci; c <=ncf; c++)
                for (int f = nff; f >=nfi; f--)
                {
                    cnt = 0;
                    for (int co = nci; co <= ncf; co++)
                        for (int fi = nff; fi >= nfi; fi--)
                            if (M[f, c] == M[fi, co])
                                cnt++;
                    if(!(velr.dentro(M[f,c])||veleu.dentro(M[f,c])))
                    {
                        if (cnt > 1)
                            for (int i = 1; i <=cnt; i++)
                                velr.Cargar1x1(M[f, c]);                                                 
                        if (cnt == 1)
                            veleu.Cargar1x1(M[f, c]);
                    }
                }
            velr.may_frec();
            veleu.asc();
            int c1 = 0,c2 = 0;

            for (int c = nci; c <= ncf; c++)
                for (int f = nff; f >= nfi; f--)
                {
                    c1++;
                    if (c1 <= velr.longi())
                        M[f, c] = velr.devol(c1);
                    else
                    {
                        c2++;
                        M[f, c] = veleu.devol(c2);
                    }
                }


        }
    }

}
