using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Archivos
{
    class Vector
    {
        const int max = 1000;
        private int[] v;
        private int n;
        public Vector()
        {
            n = 0;
            v = new int[max];
        }
        public void Cargar(int longi,int a,int b)
        {
            Random r = new Random();
            n = longi;
            for (int i = 1; i <=n; i++)
            {
                v[i] = r.Next(a, b);
            }
        }
        public String Descargar()
        {
            String s = "";
            for (int i = 1; i <=n; i++)
            {
                s = s + v[i]+"   ";
            }
            return s;
        }

        public Boolean Elem_digIguals(int ele)
        {
            int aux = ele % 10;
            while (ele > 0)
            {
                int res = ele % 10;
                ele = ele / 10;
                if (!(res == aux))
                    return false;
                else
                    aux = res;             
            }
            return true;
        }

        public void Ejerc_1()
        {
            int cntd = 0;
            for (int i = 1; i <=n; i++)
            {
                if (Elem_digIguals(v[i]))
                {
                    cntd++;
                    v[cntd] = v[i];
                }         
            }
            n = cntd;
        }


        public void Ejerc_2()
        {
            int cntd = 0;
            for (int i = 1; i <= n; i++)
            {
                if (Elem_digDifernts(v[i]))
                {
                    cntd++;
                    v[cntd] = v[i];
                }
            }
            n = cntd;
        }

        public Boolean Elem_digDifernts(int ele)//232
        {
            while(ele > 0)//22
            {
                int res1 = ele % 10;
                ele = ele / 10;
                int ele1 = ele;
                while (ele1 > 0)
                {
                    int res2 = ele1% 10;
                    ele1 = ele1 / 10;
                    if (res1 == res2)
                        return false;                   
                }
            }
            return true;
            //Vector aux = new Vector();
            //int c = 0;
            //while (ele > 0)
            //{
            //    int res = ele % 10;
            //    c++;
            //    aux.v[c] = res;
            //    ele = ele / 10;
            //}
            //aux.n = c;
            //for (int i = 1; i <=aux.n; i++)
            //{
            //    int ban = aux.v[i];
            //    int c1 = 0;
            //    for (int p = 1; p <= aux.n; p++)
            //        if (ban == aux.v[p])
            //            c1++;
            //    if (!(c1 == 1))
            //        return false;
            //}
            //return true;
        }
        public void Ejerc_3()
        {
            int cntd = 0;
            for (int i = 1; i <= n; i++)
            {
                if (Asc1(v[i]) || Desc1(v[i]))
                {
                    cntd++;
                    v[cntd] = v[i];
                }
            }
            n = cntd;
        }

        public bool Asc1(int ele)//123
        {
            int aux = ele % 10;//3
            ele = ele / 10;
            while (ele > 0)
            {
                int res = ele % 10;  
                ele = ele / 10;
                if (!(res == aux-1))
                    return false;
                else
                    aux = res;
            }
            return true;
        }
        public bool Desc1(int ele)
        {
            int aux = ele % 10;
            ele = ele / 10;
            while (ele > 0)
            {
                int res = ele % 10;
                ele = ele / 10;
                if (!(res == aux +1))
                    return false;
                else
                    aux = res;
            }
            return true;
        }

        public void Ejerc_4(ref  Vector vtwo)//  214 215 222 280  //213  216 
        {
            for (int i =1;i<=vtwo.n;i++)
                Cargar1x1(vtwo.v[i]);
            OrdAscente();
            
        }

        public void OrdAscente()
        {
            for (int i = 1; i <=n; i++)
            {
                for (int p= i+1; p <=n; p++)
                {
                    if (!(v[i] <= v[p]))
                        Swap(i, p);  
                }
            }
        }
        public  void Swap(int i,int p)
        {
            int aux = v[i];
            v[i] = v[p];
            v[p] = aux;

        }

        public void Cargar1x1(int ele)
        {
            n++;
            v[n] = ele;
        }

        public void Grabar(string s)
        {
            ArchSecuen a1 = new ArchSecuen();
            a1.Abrir_Grabar(s);
            for (int i = 1; i <=n; i++)
            {
                a1.Grabar(v[i]);
            }
            a1.Cerrar_Grabar();
        }

        public void Accesar(string ss)
        {
            ArchSecuen a1 = new ArchSecuen();
            a1.Abrir_Leer(ss);
            int i = 0;
            while (!a1.Verif_fin())
            {
                i++;
                v[i] = a1.Leer();
            }
            n = i;
            a1.Cerrar_Leer();
        }









        //public void GrabarVector(String Narch11)
        //{
        //    ArchSecuen a1 = new ArchSecuen();
        //    a1.Abrir_Grabar(Narch11);
        //    for (int i = 1; i <= n; i++)
        //    {
        //        a1.Grabar(v[i]);
        //    }
        //    a1.Cerrar_Grabar();
        //}
        //public void LeerVector(String Narch11)
        //{
        //    ArchSecuen a1 = new ArchSecuen();
        //    a1.Abrir_Leer(Narch11);
        //    int i = 0;
        //    while (!a1.Verif_fin())
        //    {
        //        i++;
        //        v[i] = a1.Leer();
        //    }
        //    n = i;
        //    a1.Cerrar_Leer();
        //}
    }
}
