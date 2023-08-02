using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectores
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

        public void Cargar(int n1, int a, int b)
        {
            int i;
            Random r;
            r = new Random();
            n = n1;
            for (i = 1; i <= n; i++)
            {
                v[i] = r.Next(a, b);

            }

        }
        public string Descargar()
        {

            string s;
            int i;
            s = "";
            for (i = 1; i <= n; i++)
            {
                s = s + v[i] + " ";
            }
            return s;
        }
        public int suma()
        {
            int sum, i;
            sum = 0;
            for (i = 1; i <= n; i++)
            {
                sum = sum + v[i];
            }
            return sum;
        }

        public double media()
        {
            double mdia;
            mdia = suma() / (double)n;
            return mdia;
        }
        //clase  8 de septiembre 

        public double desvmedia()
        {
            double dv, f;
            int i;
            f = 0;
            double med = media();
            for (i = 1; i <= n; i++)      //dv=Sumatoria i a n |x-Xmedia|/n
            {
                f = f + Math.Abs(med - v[i]);

            }
            dv = f / n;
            return dv;



        }
        public int contadorprimos()
        {
            int cp = 0, i;
            NEnt nclass;
            nclass = new NEnt();
            for (i = 1; i <= n; i++)
            {
                nclass.Cargar(v[i]);
                if (nclass.VerifPrimo() == true)
                {
                    cp++;
                }
            }
            return cp;
        }

        public int maximo()
        {
            int i, may;
            may = v[1];
            for (i = 1; i <= n; i++)
            {

                if (v[i] >= may)
                    may = v[i];
            }
            return may;
        }

        public int minimo()
        {
            int i, men;
            men = v[1];
            for (i = 1; i <= n; i++)
            {
                if (v[i] <= men)
                    men = v[i];
            }
            return men;
        }
        public void SelecPrimo(ref Vector vr) //procedimiento (entonces se debe descargar del vector de ref que en diseño de formulario en V2)
        {
            int i;
            NEnt na;
            na = new NEnt();
            vr.n = 0;
            for (i = 1; i <= n; i++)
            {
                na.Cargar(v[i]);
                if (na.VerifPrimo() == true)
                {
                    vr.n++;
                    vr.v[vr.n] = v[i];
                }

            }
        }
        public bool BusqSecuencial(int ele)
        {
            int i;
            bool b;
            i = 1;
            b = false;
            while ((i <= n) && (b == false))
            {
                if (v[i] == ele)
                    b = true;
                else
                    i++;
            }
            return b;
        }

        public int BusqSecuencial1(int ele) // devuelve posicion del numero
        {
            int i, p;
            i = 1; p = 0;
            while ((i <= n) && (p == 0))    //1 2  4 6

            {
                if (v[i] == ele)
                    p = i;
                else
                    i++;
            }
            return p;

        }
        public int BusqSecuencialPrim() // devuelve la posicion del primer primo del vector
        {
            int i = 1, p = 0;
            NEnt nu;
            nu = new NEnt();
            while ((i <= n) && (p == 0))
            {
                nu.Cargar(v[i]);
                if (nu.VerifPrimo() == true)
                    p = i;
                else
                    i++;
            }
            return p;
        }

        public int BusqSecuencial2(int ele)//devuelve la posicion del elemnto a buscar (utiliza el método de busqueda por ambos lados)
        {
            int i, d, p;

            i = 1; p = 0; d = n;
            while ((i <= n) && (p == 0))
            {
                if ((v[i] == ele) || (v[d] == ele))
                {
                    if (v[i] == ele)
                        p = i;
                    else
                        p = d;
                }

                else
                    i++; d--;
            }
            return p;

        }
        //falta el codigo de verif primo con vector  tome foto pero utiliza la clase NEnt 
        public bool VerifOrden()
        {
            int i;
            bool b;
            b = true;
            i = 1;
            while ((i <= n - 1) && (b == true))
                if (v[i] <= v[i + 1])
                    i++;
                else
                    b = false;
            return b;

        }
        //jueves 15 de septiembre

        public int MayorElPosi(int m) //Encontrar el mayor elemnto en posisciones multiplos de m
        {
            int i = 1, may;
            may = v[m * i];
            for (i = 2; i <= n; i++)
                if (v[m * i] > may)
                    may = v[m * i];
            return may;
        }
        public void Swap_Intercambiar(int a, int b) //procedimiento
        {
            int aux = v[a];
            v[a] = v[b];
            v[b] = aux;

        }
        public void Invertir()//procedimiento
        {
            int i, d = n;

            for (i = 1; i <= n / 2; i++)
            {
                Swap_Intercambiar(i, d);
                d--;
            }
        }
        public void OrdenaXInterc() //Ordena el vector de forma ascendente
        {
            int i, p;
            for (i = 1; i <= n; i++)
                for (p = i + 1; p <= n; p++)
                    if (v[p] < v[i])
                        Swap_Intercambiar(i, p);
        }

        public void OrdenaXInterc1() // Ordena el vector de forma descendente
        {
            int i, p;
            for (i = 1; i <= n; i++)
                for (p = i + 1; p <= n; p++)
                    if (v[p] > v[i])
                        Swap_Intercambiar(i, p);
        }
        // martes 20 de septiembre 

        public void OrdenaXselecc()
        {
            int p, s, i;
            for (p = n; p >= 2; p--)                     //4 2 2 1
            {
                s = p;
                for (i = p - 1; i >= 1; i--)
                    if (v[i] > v[s])
                        s = i;
                if (s != p)
                    Swap_Intercambiar(s, p);
            }
        }


        public void Insert(int ele)
        {
            int i;
            i = n; // i iniciliza en cero
            while ((i >= 1) && (v[i] > ele))
            {
                v[i + 1] = v[i];
                i--;

            }
            v[i + 1] = ele;
            n++;

        }
       

        public void OrdXInser(ref Vector  vr)          // 4 9 6 3 1
        {
            int i;
            vr.n = 0;
            for (i = 1; i <= n; i++)
                vr.Insert(v[i]);      
              

        }

        public void OrdXInser2() //4 3 7 2
        {
            int i,p,ele;

            for (p = 2; p <= n; p++)
            {
                ele = v[p];
                i = p - 1;
                while ((i >=1) && (v[i] > ele))
                {
                    v[i + 1] = v[i];
                    i--;
                }
                v[i + 1] = ele;
            }
        }
  




        //jueves 22 de septiembre
        public void OrdCont(ref Vector vr)
        {
            Vector vc;
            int p, i;
            vc = new Vector();
            vc.Cargar(n, 1, 1);
            for (p = 1; p <= n - 1; p++)
            
                for (i = p + 1; i <= n; i++)
                    if (v[i] <v[p])
                        vc.v[p] = vc.v[p] + 1;
                    else
                       vc.v[i] = vc.v[i] + 1;    
            for (i=1;i<=n;i++)
                    vr.v[vc.v[i]]= v[i];
                vr.n = n;



            

        }

        public void OrdBurbuja()
        {
            int t, i;
            for (t = n; t >= 2; t--)
                for (i = 1; i <= t - 1; i++)
                    if (v[i] < v[i + 1])
                        Swap_Intercambiar(i,i+1);                                     

        }

       //mates 27 de septiembre

        public void SegPrimYnoPrimos()
        {
            int i,p;
            bool b= true;
            NEnt n1,n2;
            n1 = new NEnt();
            n2 = new NEnt();
            for (i = 1; i <= n; i++)
            {
                if(b==true)
                    for(p=i+1;p<= n; p++)
                    {
                        n1.Cargar(v[i]);
                        n2.Cargar(v[p]);
                        if ((!n1.VerifPrimo()) && (n2.VerifPrimo()) || (n1.VerifPrimo()) && (n2.VerifPrimo()) && (v[p] < v[i]) || (!n1.VerifPrimo()) && (!n2.VerifPrimo()) && (v[i] < v[p]))
                            this.Swap_Intercambiar(i, p);
                    }
                //else
                //    for (p = i + 1; p <= n; p++)
                //    {
                //        n1.Cargar(v[i]);
                //        n2.Cargar(v[p]);
                //        if ((!n1.VerifPrimo()) && (n2.VerifPrimo()) || (n1.VerifPrimo()) && (n2.VerifPrimo()) && (v[p] < v[i]) || (!n1.VerifPrimo()) && (!n2.VerifPrimo()) && (v[i] < v[p]))
                //            this.Swap_Intercambiar(i, p);
                //    }
            }

        }
        public void ParImpar()//[1,3,2,7,6] 2,1,6,3,7
        {
            NEnt ne1 = new NEnt(), ne2 = new NEnt();
            for (int i = 1; i <=n; i++)
            {
                for (int p = i + 1; p <= n; p++)
                {
                    ne1.Cargar(v[i]);
                    ne2.Cargar(v[p]);
                    if ((!ne1.VerifPar()) && (ne2.VerifPar()) || (ne1.VerifPar() && ne2.VerifPar() && (v[p] < v[i])) || (!ne1.VerifPar() && !ne2.VerifPar() && v[p] < v[i]))
                        Swap_Intercambiar(i, p);
                }
            }      





            //int i = 0,p;
            //bool eje = true;
            //NEnt nc;
            //nc = new NEnt();
            //for(i=1;i<= n; i++)
            //{
            //    while(i<=n)
            //    {
            //        if (eje == true)
            //        {
            //            nc.Cargar(v[i]);
            //            if (nc.VerifPar() == true) 
            //                v[i] = v[i];
            //            else
            //                for (p = i + 1; p <= n; p++)
            //                {
            //                    nc.Cargar(v[p]);
            //                    if (nc.VerifPar() == true)
            //                    {
            //                        Swap_Intercambiar(i, p);
            //                        break;
            //                    } 
            //                }
            //        }
            //        else
            //        { 
            //            if (nc.VerifPar() == false)                       
            //                v[i] = v[i];
            //            else
            //                for (p = i + 1; p <= n; p++)
            //                {
            //                    nc.Cargar(v[p]);
            //                    if (nc.VerifPar() == false)
            //                    {
            //                        Swap_Intercambiar(i, p);
            //                        break;
            //                    }
            //                }
            //        }                                             
            //    }                
            //}                                
        }

        public int NElem()
        {
            int i=1, c=0, ele;
            while (i <= n)
            {
                ele = v[i];
                while ((i <= n) && (v[i] == ele))
                    i++;
                c++;          
            
            }
            return c;
        }
        public void Purgar(ref Vector vr)
        {
            int i = 1, c = 0, ele;
            OrdenaXInterc();
            while (i <= n)
            {
                ele = v[i];
                while ((i <= n) && (v[i] == ele))
                    i++;
                c++;
                vr.v[c] = ele;

            }
            vr.n = c;
           
        }
        public void FrecDistr(ref Vector ve,ref Vector vf)
        {
            int i = 1, c = 0, ele,f;
            OrdenaXInterc();
            while (i <= n)
            {
                ele = v[i];
                f = 0;
                while ((i <= n) && (v[i] == ele))
                {
                    i++;
                    f++;
                }
                c++;
                ve.v[c] = ele;
                vf.v[c] = f;

            }
            ve.n = c;
            vf.n = c;

        }

        public void FrecueDistri1(ref Vector ve, ref Vector vf,int m)
        {
            int i = 1, f, c=0,b,a;
            OrdenaXInterc();
            while (i <= n)
            {
                a = v[i] / m * m;b = a + m - 1;f = 0;
                while ((i <= n) && (v[i] >= a) && (v[i] <= b))
                {
                    i++; f++;
                }
                c++;
                ve.v[c] = a;
                vf.v[c] = f;

            }
            ve.n = c;
            vf.n = c;

        
        }
        public bool BusquedaBinaria(int ele)
        {
            bool b = false;
            int i = 1, d = n,m;
            OrdenaXInterc();
            while ((i <= d) && (b == false)) //si v[i] in v;
            {
                m = (i + d) / 2;
                if (ele < v[m])
                    d = m - 1;
                else
                    if (ele == v[n])
                        b = true;
                    else
                        i = m + 1;              
            }
            return b;
        }
        public void push(int de)
        {
            n++;
            v[n] = de;

        }
        public int pop()
        {
            int aux;
            aux = v[n];
            n--;
            return aux;

        }
        public bool Vacia()
        {
            return (n == 0);

        }


    }
}
