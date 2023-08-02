using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatricesPractice
{
    class Matrix
    {
        const int MaxRow= 100;
        const int MaxColumn = 100;
        private int[,] M;
        private int fil;
        private int column;
        public Matrix()
        {
            M = new int[MaxRow, MaxColumn];
            fil = 0;
            column = 0;

        }
        public void Cargar(int nf,int nc,int a,int b)
        {
            fil = nf;column = nc;
            Random r = new Random();
            for (int f = 1; f <= fil; f++)
            {
                for (int c = 1; c <= column; c++)
                {
                    M[f, c] = r.Next(a, b);
                }
            }
        }

        public String Descargar()
        {
            string s = "";
            for (int f = 1; f <= fil; f++)
            {
                for (int c = 1; c <= column; c++)
                {
                    s=s+M[f, c]+"\x09";
                }
                s = s + "\x0d"+"\x0a";
            }
            return s;

        }
        public String Pract1_Ejrc1()
        {
            string s= "";
            bool bandera = true;
            NEnt num = new NEnt();
            for (int f = fil; f >= 1; f--)
            {
                for (int c = column; c >=1; c--)
                {
                    num.Cargar(M[f, c]);
                    if (num.VerifPrim())
                    {
                        if (bandera)
                        {
                            s = s + "- (" + M[f, c] + ")^(1/2) ";
                            bandera = false;
                        }
                        else
                        {
                            s = s + "+ (" + M[f, c] + ")^(1/2)";
                            bandera = true;
                        }
                    }
                             
                }
            
            }
            return s;

        }

        public int Pract1_Ejrc2(int elem)
        {
            int cont=0;
            for (int f = 1; f <= fil; f++)
            {
                for (int c = 1; c <= column; c++)
                {
                    if (elem == M[f, c])
                        cont++;       
                }              
            }
            return cont;

        }

        public int Pract1_Ejrc3()
        {
            int auxctdr = 0;
            for (int f = 1; f <= fil; f++)
            {
                for (int c = 1; c <= column; c++)
                {
                    if (Pract1_Ejrc2(M[f, c]) == 1)
                        auxctdr++;            
                }
            }
            return auxctdr;
        }
        public void Pract1_Ejerc4()
        {
            Matrix Maux = new Matrix(); Maux.fil = 0; Maux.column = 0;
            Maux.fil = fil; Maux.column = column;

            for (int f = 1; f <= fil; f++)
            {
                for (int c = 1; c <= column; c++)
                    Maux.M[f, c] = M[f, c];

            }
            fil = Maux.column;
            column = Maux.fil;
            for (int f = 1; f <= fil; f++)
            {
                for (int c = 1; c <= column; c++)
                    M[f, c] = Maux.M[c, f];

            }
        }
        public bool Pract1_Ejerc5()
        {
            int aux;
            bool bandera = false;
            for (int f = 1; f <= fil; f++)
            {
                aux = M[f, 1];
                for (int c = 1; c <= column; c++)
                {
                    if (aux <= M[f, c])
                    {
                        aux = M[f, c];
                        bandera = true;
                    }
                    else
                        return false;
                }
            }
            return bandera;
        }
        public void Pract1_Ejerc6()
        {
            Vector vec = new Vector();
            Vector vi = new Vector();
            for (int f = 1; f <= fil; f++)
            {
                for (int c = 1; c <= column; c++)
                {
                    vec.Cargar1x1(M[f, c]);

                }
                vi.Cargar1x1(vec.Mayorfrecuencia());
                vec.begin();
            }
            for (int c = column + 1; c <= column + 1; c++)
            {
                for (int f = 1; f <= fil; f++)
                    M[f, c] = vi.Devolver(f);
            }
            column = column + 1;

        }
        public bool Pract1_Ejerc7()
        {
            int aux = 0;
            for (int f = 1; f <= fil; f++)
            {
                aux = M[f, 1];
                for (int c = 1; c <= column; c++)
                {
                    if (!(aux == M[f, c]))
                        return false;
                    aux++;
                }
            }
            return true;
        }
        public bool Pract1_Ejerc8(ref Matrix x)
        {
            bool bandera;
            for (int f = 1; f <= fil; f++)
            {
                for (int c = 1; c <= column; c++)
                {
                    bandera = false;
                    for (int fi = 1; fi <= x.fil; fi++)
                    {
                        for (int co = 1; co <= x.column; co++)
                        {
                            if (M[f, c] == x.M[fi, co])
                            {
                                bandera = true;
                                break;
                            }
                        }
                        if (bandera)
                            break;
                    }
                    if (bandera == false)
                        return false;                
                }
            }
            return true;
        }

        public void Pract1_Ejerc9()
        {
            Vector vct = new Vector();
            for (int f = 1; f <= fil; f++)
            {
                for (int c = 1; c <= column; c++)
                    vct.Cargar1x1(M[f, c]);
                vct.ParImpar();
                for (int co = 1; co <= column; co++)
                
                    M[f, co]=vct.Devolver(co);
                vct.begin();

            }
        }
        public void Pract1_Ejerc10()
        {
            int ctd=0,aux=0;
            NEnt nc = new NEnt();
            for (int f = 1; f <= fil; f++)
            {
                for (int c = 1; c <= column; c++)
                {
                    nc.Cargar(M[f, c]);
                    if (nc.VerifPrim())
                        aux++;
                }
                for (int fi = f + 1; fi <= fil; fi++)
                {
                    for (int co = 1; co <= column; co++)
                    {
                        nc.Cargar(M[fi, co]);
                        if (nc.VerifPrim())
                            ctd++;
                    }
                    if (!(aux <= ctd))
                    {
                        aux = ctd;
                        Swap(f, fi);
                    }
                    ctd = 0;
                }              
            } 
        }

        public void Swap(int a,int b)
        {
            int aux;
            for (int co = 1; co <= column; co++)
            {
                aux = M[a, co];
                M[a, co] = M[b, co];
                M[b, co] = aux; 
            }
        }

        public void Pract2_Ejerc1()
        {
            //Vector vprim = new Vector();
            int colaux=0 ;
            NEnt nc = new NEnt();
            for (int f = 1; f <= fil; f++)
            {
                int ctdr = 0;
                for (int c = 1; c <= column; c++)
                {
                    nc.Cargar(M[f, c]);
                    if (nc.VerifPrim())
                        ctdr++;
                    colaux = c;
                }
                M[f, colaux + 1] = ctdr;
            }
            column = column + 1;
        }
        public void Pract2_Ejerc2()
        {
            Vector vzz= new Vector();
            for (int f = 1; f <= fil; f++)
            {
                vzz.begin(); 
                for (int c = 1; c <= column; c++)            
                    vzz.Cargar1x1(M[f, c]);
                for (int c = column+1; c <= column+1; c++)
                {
                    M[f, c] = vzz.Mayorfrecuencia();
                }
            }
            column++;
        }
        public void Pract2_Ejerc3()
        {

            NEnt nc = new NEnt();
            Vector vpar = new Vector(); Vector vimpar = new Vector(); ;
           
            for (int f = 1; f <= fil; f++)
            {
                vpar.begin();vimpar.begin();
                for (int c = 1; c <= column; c++)
                {
                    nc.Cargar(M[f, c]);
                    if (nc.VerifPar())
                        vpar.Cargar1x1(M[f, c]);
                    else
                        vimpar.Cargar1x1(M[f, c]);
                }
                vpar.Ordenar_Ascente();
                vimpar.Ordenar_Ascente();
                int cntdr = 0;
                for (int c = 1; c <= column; c++)
                {
                    if (c <= vpar.LongVector())
                        M[f, c] = vpar.Devolver(c);
                    else
                    {
                        cntdr++;
                        M[f, c] = vimpar.Devolver(cntdr);
                    }
                }
            }
        }
        public void Pract2_Ejerc4(int row)
        {
            for(int i=1;i<= column;i++)
                for (int f = row; f <= row; f++)
                    for (int c = 1; c <= column - 1; c++)
                        if (M[f, c] >= M[f, c + 1])
                            SwapColumna(c, c + 1);                
        }
        public void SwapColumna(int col1,int col2)
        {
            for (int f = 1; f <= fil; f++)
            {
                int aux = M[f, col1];
                M[f, col1] = M[f, col2];
                M[f, col2] = aux;
            }
        }
        public bool Pract2_Ejerc5()
        {

            for (int c = 1; c <= column; c++)
                //aux = M[fil, c];
                for (int f = fil; f >= 1+1; f--)
                    if (!(M[f, c] <= M[f - 1, c]))
                        return false;
            return true;
                        
        }


        public void Pract2_Ejerc6()
        {
            int cntdr,cntelm=0;
            Vector elem = new Vector();Vector elfr = new Vector();
            for (int f = 1; f <= fil; f++)
            {
                for (int c = 1; c <= column; c++)
                {
                    cntdr = 0;
                    for(int fi = 1; fi<= fil; fi++)
                        for (int co= 1; co <= column; co++)
                        {
                            if (!(elem.dentro(M[f, c]) || elfr.dentro(M[f, c])))
                                if (M[f, c] == M[fi, co])
                                    cntdr++;
                        }
                    if (cntdr == 1)
                        elem.Cargar1x1(M[f, c]);
                    else if (cntdr > 1)
                        for (int i = 1; i <=cntdr; i++)                       
                            elfr.Cargar1x1(M[f, c]);                    
                }
            }
            elfr.Ordenar_Ascente();
            elem.Ordenar_Ascente();
            cntdr = 0;
            for (int c = column; c >= 1; c--)
            {
                for (int f = 1; f <= fil; f++)
                {
                    cntdr++;
                    if (cntdr <= elfr.LongVector())
                        M[f, c] = elfr.Devolver(cntdr);
                    else
                    {
                        cntelm++;
                        M[f, c] = elem.Devolver(cntelm);
                    }
                }
            }
        }
        public void Pract2_Ejerc7 ()
        {
            Vector par = new Vector();
            Vector impar = new Vector();  
            for (int f = 1; f <= fil; f++)
            {
                for (int c = 1; c <= column; c++)
                {
                    if (M[f, c] % 2 == 0)
                        par.Cargar1x1(M[f, c]);
                    else
                        impar.Cargar1x1(M[f, c]);
                }
            }
            par.Ordenar_Ascente();
            impar.Ordenar_Ascente();
            int cp = 0, ci = 0;
            for (int c = 1; c <= column; c++)
                for (int f = fil; f >= 1; f--)
                {
                    cp++;
                    if (cp <= par.LongVector())
                        M[f, c] = par.Devolver(cp);
                    else
                    {
                        ci++;
                        M[f, c] = impar.Devolver(ci);
                    }
                }
        }
    }
}
