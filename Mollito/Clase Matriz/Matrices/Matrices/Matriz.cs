using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    class Matriz
    {
        const int MAXFilas = 50;
        const int MAXColums = 50;
        private int[,] x;
        private int f, c;
        public Matriz()
        {
            x = new int[MAXFilas, MAXColums];
            f = 0;
            c = 0;

        }

        public void Cargar(int nf, int nc, int a, int b)
        {
            int f1, c1;
            Random r;
            r = new Random();
            f = nf; c = nc;
            for (f1 = 1; f1 <= f; f1++)
                for (c1 = 1; c1 <= c; c1++)
                    x[f1, c1] = r.Next(a, b);

        }
        public string Descargar()
        {
            string s = "";
            int f1, c1;
            for (f1 = 1; f1 <= f; f1++)
            {
                for (c1 = 1; c1 <= c; c1++)
                    s = s + x[f1, c1] + "\x09"; //"\x09"= 5 esp.
                s = s + "\x0d" + "\x0a";                                      //s = s + "\x0d" + "\x0a";                                               
            }
            return s;


        }
        public void CargarXFilas(int nf, int nc, int vi, int r)
        {
            int f1, c1, i = 0;
            for (f1 = 1; f1 <= nf; f1++)
                for (c1 = 1; c1 <= nc; c1++)
                {
                    x[f1, c1] = vi + (i * r);
                    i++;
                }

        }
        public void CargarxColums(int nf, int nc, int vi, int r)
        {
            int f1, c1, i;
            f = nf; c = nc; i = 0;
            for (c1 = 1; c1 <= c; c1++)
                for (f1 = 1; f1 <= f; f1++)
                {
                    i++;
                    x[f1, c1] = vi + (i - 1) * r;

                }

        }
        public void Sumar(ref Matriz m2, ref Matriz m3)
        {
            int f1, c1;
            for (f1 = 1; f1 <= f; f1++)
                for (c1 = 1; c1 <= c; c1++)
                    m3.x[f1, c1] = x[f1, c1] + m2.x[f1, c1];
            m3.f = f; m3.c = c;
        }

        public void Multiplicar(ref Matriz m2, ref Matriz m3)
        {
            int f1, c1, d;
            for (f1 = 1; f1 <= f; f1++)
                for (c1 = 1; c1 <= m2.c; c1++)
                {
                    m3.x[f1, c1] = 0;
                    for (d = 1; d <= c; d++)
                        m3.x[f1, c1] = m3.x[f1, c1] + (m2.x[d, c1] * x[f1, d]);
                }
            m3.f = f;
            m3.c = m2.c;
        }

        public void RetDim(ref int nf, ref int nc)
        {
            nf = f;
            nc = c;
        }
        public void CargarXcolumnadeReves(int nf, int nc, int inicializador, int sumdr)
        {
            f = nf;
            c = nc;
            int sum = inicializador, sumdr1 = 0;

            for (int colum = nc; colum >= 1; colum--)
                for (int fila = nf; fila >= 1; fila--)
                {
                    sum = sum + sumdr1;
                    x[fila, colum] = sum;
                    sumdr1 = sumdr;

                }

        }
        public void OrdenarXColumnas()
        {
            for (int c1 = 1; c1 <= c; c1++)
                for (int f1 = 1; f1 <= f; f1++)
                {
                    int fil = f1 + 1;
                    for (int c2 = c1; c2 <= c; c2++)
                    {
                        for (int f2 = fil; f2 <= f; f2++)
                            if (!(x[f1, c1] <= x[f2, c2]))
                                swap(f1, c1, f2, c2);
                        fil = 1;
                    }
                }
        

        //Vector vec = new Vector();
        //for (int co = 1; co <= c; co++)
        //    for (int fi = 1; fi <= f; fi++)
        //        vec.Cargar1x1(x[fi, co]);
        //int cnt = 0;vec.Ordenar_Asc();
        //for (int co = 1; co <= c; co++)
        //    for (int fi = 1; fi <= f; fi++)
        //    {
        //        cnt++;
        //        x[fi,co] = vec.devol(cnt);
        //    }

        }

        public void OrdeXFilas()
        {
            for (int f1 = 1; f1 <= f; f1++)
                for (int c1 = 1; c1 <= c; c1++)
                {
                    int col = c1 + 1;
                    for (int f2 = f1; f2 <= f; f2++)
                    {
                        for (int c2 =col ; c2 <=c; c2++)
                            if(!(x[f1,c1]<=x[f2,c2]))
                                swap(f1, c1, f2, c2);
                        col = 1;                             
                    }      
                }
        }

        public void swap(int fi1,int co1,int f2,int c2)
        {
            int aux = x[fi1, co1];
            x[fi1, co1] = x[f2, c2];
            x[f2, c2] = aux;


        }
        public void SwapFilas(int f1,int f2)
        {
            for (int c1 = 1; c1 <=c; c1++)
            {
                int aux = x[f1, c1];
                x[f1, c1] = x[f2, c1];
                x[f2, c1] = aux;
            }
        }
        public void OrdFilasXEledeNumpares()
        {
            NEnt ne = new NEnt();          
            int cnt1 = 0,cnt2=0;
            for (int f1 = 1; f1 <=f; f1++)
            {
                for (int f2 = f1+1; f2 <= f; f2++)
                {
                    for (int c1 = 1; c1 <= c; c1++)
                    {
                        ne.Cargar(x[f1, c1]);
                        cnt1 = cnt1 + Convert.ToInt16( ne.VerifPar());
                        ne.Cargar(x[f2, c1]);
                        cnt2 = cnt2 + Convert.ToInt16(ne.VerifPar());
                    }
                    if (!(cnt1 <= cnt2))
                    {
                        SwapFilas(f1, f2);              
                    }
                    cnt1 = 0;cnt2 = 0;
                }
            }
        }

        public void OrdenarParImpar()
        {
            NEnt nf1 = new NEnt(), nf2 = new NEnt();
            for (int f1 = 1; f1 <= f; f1++)
                for (int c1 = 1; c1 <= c; c1++)
                {
                    int colum = c1 + 1;
                    for (int f2 = f1; f2 <= f; f2++)
                    {
                        for (int c2 = colum; c2 <= c; c2++)
                        {
                            nf1.Cargar(x[f1, c1]);
                            nf2.Cargar(x[f2, c2]);
                            if (!nf1.VerifPar() && nf2.VerifPar() || nf1.VerifPar() && nf2.VerifPar() && x[f2, c2] < x[f1, c1] || !nf1.VerifPar() && !nf2.VerifPar() && x[f2, c2] < x[f1, c1])
                                swap(f1, c1, f2, c2);
                        }
                        colum = 1;
                    }
                }
        }
            


            /// <summary>
            /// ///////
            /// </summary>
            /// 

            //int p, d;
            //for (int i = 1; i<=f-1; i++)
            //    for(int d = i + 1;d<=f;)

            //13/11/22 1er ejerccio parimpar ordenado [2,1,4,3,]

            //public void segmat1()
            //{

            //    nent n1, n2;
            //    n1 = new nent(); n2 = new nent();      //1,8,2
            //    int fp, cp, fd, cd, i;
            //    bool bandera = true;
            //    for (fp = 1; fp <= f; fp++)
            //        for (cp = 1; cp <= c; cp++)
            //        {
            //            if (bandera)
            //            {
            //                for (fd = fp; fd <=f; fd++)
            //                {  
            //                    if (fd == fp)
            //                        i = cp;
            //                    else
            //                        i = 1;
            //                    for (cd = i; cd <=c; cd++)
            //                    {
            //                        n1.cargar(x[fp, cp]);
            //                        n2.cargar(x[fd, cd]);
            //                        if ((n2.verifpar() && !n1.verifpar())
            //                            || (n2.verifpar() && n1.verifpar() && (x[fd, cd] < x[fp, cp]))
            //                            || (n2.verifpar() && n1.verifpar() && (x[fd, cd] < x[fp, cp])))
            //                            this.intercparimpar(fd, cd, fp, cp);




            //                    }
            //                }
            //            }
            //        }









            //}
            //public void intercparimpar()
            //{
            //    for (int fil = 1;  fil<=f; fil++)
            //    {
            //        for (int  col = 1; col<=c; col++)
            //        {

            //        }
            //    }
            //}


            //public void tranpuesta()
            //{
            //    int f1, c1;
            //    for (f1 = 2; f1 <= f; f1++)
            //        for (c1 = 1; c1 <= f1 - 1; c1++)
            //            inter(f1, c1, c1, f1);

            //}
            //public void transp(ref matriz xaux)
            //{
            //    int f1, c1;
            //    for(f1=1;f1<=
            //}
        public void OrdXfilasParsImprs(int nfi ,int nff,int nci,int ncf)
        {
            NEnt ne1 = new NEnt(), ne2 = new NEnt();
            for (int f1 = nfi; f1 <=nff; f1++)
            {
                for (int c1 = nci; c1 <= ncf; c1++)
                {
                    int coli = c1 + 1;
                    for (int f2 = f1; f2 <= nff; f2++)
                    {
                        for (int c2 =coli; c2 <= ncf; c2++)
                        {
                            ne1.Cargar(x[f1, c1]);
                            ne2.Cargar(x[f2, c2]);
                            if (!ne1.VerifPar() && ne2.VerifPar() || ne1.VerifPar() && ne2.VerifPar() && x[f2, c2] < x[f1, c1] || !ne1.VerifPar() && !ne2.VerifPar() && x[f2, c2] < x[f1, c1])
                                swap(f1, c1, f2, c2);

                        }
                        coli = nci;
                    }
                }
            }
        }
        public void Intercalar_Par_Impar()
        {
            NEnt ne = new NEnt();
            int cnt1 = 0, cnt2 = 0;
            Matriz xpar = new Matriz(), ximpar = new Matriz();
            for (int f1 = 1; f1 <= f; f1++)
                for (int c1 = 1; c1 <= c; c1++)
                {
                    ne.Cargar(x[f1, c1]);
                    if (ne.VerifPar())
                    {
                        cnt1++;
                        xpar.x[1, cnt1] = x[f1, c1];
                    }

                    else
                    {
                        cnt2++;
                        ximpar.x[1, cnt2] = x[f1, c1];
                    }
                }
            xpar.f = 1;ximpar.f = 1;xpar.c = cnt1;ximpar.c = cnt2;
            xpar.OrdenarAsc();ximpar.OrdenarAsc();
            Boolean bandera = true; cnt1 = 1; cnt2 = 0;
            for (int f1 = 1; f1 <= f; f1++)
                for (int c1 = 1; c1 <= c; c1++)
                {
                    if (bandera && cnt1 <= xpar.c)
                    {
                        x[f1, c1] = xpar.x[1, cnt1];
                        cnt1++;
                        bandera = false;
                    }
                    else
                    {
                        cnt2++;
                        x[f1, c1] = ximpar.x[1, cnt2];
                        bandera = true;
                    }
                }
        }
        public void OrdenarAsc()
        {
            for (int f1 = 1; f1 <= f; f1++)
                for (int c1 = 1; c1 <= c; c1++)
                    for (int c2 = c1; c2 <= c; c2++)
                        if (!(x[f1, c1] <= x[f1, c2]))
                            swap(f1, c1, f1, c2);
        }


        public void OrdXFrecuenciadeMayAMenor()
        {
            Vector eleunic = new Vector(),elerep = new Vector();
            for (int c1 = c; c1 >=1; c1--)
            {
                for (int f1 = 1; f1 <=f; f1++)
                {
                    if(!(eleunic.dentro(x[f1,c1]) || elerep.dentro(x[f1,c1])))
                    {
                        int frecu = fre(x[f1, c1]);
;                        if (frecu > 1)
                        {
                            for (int i = 1; i <= frecu; i++)
                                elerep.Cargar1x1(x[f1, c1]);
                        }
                        else
                            eleunic.Cargar1x1(x[f1,c1]);
                    }
                } 
                        
            }
            elerep.OrdxFrec();
            eleunic.Ordenar_Asc();int cnt1 = 1,cnt2=0;
            for (int c1 = c; c1 >= 1; c1--)
            {
                for (int f1 = 1; f1 <= f; f1++)
                {
                    if (cnt1 <= elerep.longi())
                    {
                        x[f1,c1] = elerep.devol(cnt1);
                        cnt1++;
                    }
                    else
                    {
                        cnt2++;
                        x[f1, c1] = eleunic.devol(cnt2);
                    }

                }
            }
        }
        public int fre(int ele)
        {
            int cnt = 0;
            for (int f1 = 1; f1 <= f; f1++)
                for (int c1 = 1; c1 <= c; c1++)
                    if (x[f1, c1] == ele)
                        cnt++;
            return cnt;
        }
        public void Cargar1x1(int elem)
        {
            f = 1;
            c++;
            x[f, c] = elem;
        }
        public Boolean dentro(int elem)
        {
            for (int f1 = 1; f1 <= f; f1++)
                for (int c1 = 1; c1 <= c; c1++)
                    if (x[f1, c1] == elem)
                        return true;
            return false;
        }
        public int FrecOfElem(int elem)
        {
            int c = 0;
            for (int f1 = 1; f1 <= f; f1++)
                for (int c1 = 1; c1 <= c; c1++)
                    if(x[f1,c1]==elem)
                        c++;
            return c;
        }
        public void OrdFilXEleCol(int col)
        {
            for (int f1 = 1; f1 <= f; f1++)       
                for (int f2 = f1; f2 <= f; f2++)
                    if (!(x[f1,col] <= x[f2,col]))
                    {
                        SwapFilas(f1, f2);
                    }

            
        }

    }
}
