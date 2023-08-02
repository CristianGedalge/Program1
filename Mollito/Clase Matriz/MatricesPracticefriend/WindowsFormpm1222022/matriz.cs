using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormpm1222022
{
    class matriz
    {

        const int MAXF = 100;
        const int MAXC = 100;
        private int[,] x;
        private int f, c;


        public matriz()
        {
            x = new int[MAXF, MAXC];
            f = 0; c = 0;
        }

        public void cargar(int nf, int nc, int a, int b)
        {
            f = nf; c = nc;
            int f1, c1;
            Random r = new Random();
            for (f1 = 1; f1 <= f; f1++)
            {
                for (c1 = 1; c1 <= c; c1++)
                {
                    x[f1, c1] = r.Next(a, b);
                }
            }
        }
        public string descargar()
        {
            string s = "";
            int f1, c1;
            for (f1 = 1; f1 <= f; f1++)
            {
                for (c1 = 1; c1 <= c; c1++)
                {
                    s = s + x[f1, c1] + "\x09";
                }
                s = s + "\x0d" + "\x0a";
            }
            return s;
        }

        //practico

        //ejercicio 1


        public double ejercicio1()
        {
            int f1, c1;
            double s = 0;
            bool ban = true;
            for (f1 = f; f1 >= 1; f1--)
            {
                for (c1 = c; c1 >= 1; c1--)
                {
                    nent num = new nent();
                    num.cargar(x[f1, c1]);
                    if (num.verifpri())
                    {
                        if (ban == true)
                        {
                            s = s - Math.Sqrt(x[f1, c1]);
                            ban = false;
                        }
                        else
                        {
                            s = s + Math.Sqrt(x[f1, c1]);
                            ban = true;
                        }
                    }
                }
            }
            return s;
        }


        public int ejercicio2(int ele)
        {
            int f1, c1, c;
            c = 0;
            {
                for (f1 = 1; f1 <= f; f1++)
                {
                    for (c1 = 1; c1 <= this.c; c1++)
                    {
                        if (x[f1, c1] == ele)
                        {
                            c++;
                        }
                    }
                }
            }
            return c;
        }


        public int ejercicio3()
        {
            int f1, c1, contador;
            contador = 0;
            for (f1 = 1; f1 <= f; f1++)
            {
                for (c1 = 1; c1 <= c; c1++)
                {
                    if (ejercicio2(x[f1, c1]) == 1)
                    {
                        contador++;
                    }
                }
            }
            return contador;
        }


        public void ejercicio4(matriz m2)
        {
            int f1, c1;
            for (f1 = 1; f1 <= f; f1++)
            {
                for (c1 = 1; c1 <= c; c1++)
                {
                    m2.x[c1, f1] = x[f1, c1];
                }
            }
            m2.f = c;
            m2.c = f;

        }


        public bool verf_fila(int f1)
        {
            int c1, c2;
            bool ban = true;
            for (c1 = 1; c1 <= c; c1++)
            {
                for (c2 = c1; c2 <= c; c2++)
                {
                    if (ban == true)
                    {
                        if (x[f1, c1] > x[f1, c2])
                        {
                            ban = false;
                        }
                    }
                }
            }
            return ban;
        }

        public bool ejercicio5()
        {
            int f1;
            bool ban = true;
            for (f1 = 1; f1 <= f; f1++)
            {
                if (!(verf_fila(f1) && (ban == true)))
                {
                    ban = false;
                }
            }
            return ban;
        }

        public int FrecEle1(int ele, int f1)
        {
            int c1, c;
            c = 0;
            {
                for (c1 = 1; c1 <= this.c; c1++)
                {
                    if (x[f1, c1] == ele)
                    {
                        c++;
                    }
                }
            }
            return c;
        }

        public int ele_may(int f1)
        {
            int c1, ele;
            ele = 0;
            int may = 0;
            int may2;
            for (c1 = 1; c1 <= c; c1++)
            {
                may2 = FrecEle1(x[f1, c1], f1);
                if (may2 > may)
                {
                    may = may2;
                    ele = x[f1, c1];
                }
            }
            return ele;
        }

        public void ejercicio6()
        {
            int f1;
            for (f1 = 1; f1 <= f; f1++)
            {
                x[f1, c + 1] = ele_may(f1);
            }
            c = c + 1;
        }

        public bool ejercicio7()
        {
            bool ban = true;
            int f1, c1;
            for (f1 = f; f1 >= 1; f1--)
            {
                for (c1 = 1; c1 <= c; c1++)
                {
                    int aux = x[f1, c1];
                    if ((x[f1, c1 + 1] - aux != 1) && (c1 + 1 <= c))
                    {
                        ban = false;
                    }
                }
            }
            return ban;
        }

        public bool Buscar_Ele(int ele)
        {
            int f1, c1, aux;
            aux = 0;
            bool ban = false;
            for (f1 = 1; f1 <= f; f1++)
            {
                for (c1 = 1; c1 <= c; c1++)
                {
                    if (x[f1, c1] == ele)
                    {
                        ban = true;
                        aux = x[f1, c1];
                    }
                }
            }
            return ban;
        }

        public bool ejercicio8(matriz m2)
        {
            bool ban = true;
            int f1, c1;
            for (f1 = 1; f1 <= f; f1++)
            {
                for (c1 = 1; c1 <= c; c1++)
                {
                    if (!(m2.Buscar_Ele(x[f1, c1])))
                    {
                        ban = false;
                    }
                }
            }
            return ban;
        }

        //ejercicio 9

        public void seg_parimp(int f1)
        {
            int izq, der;
            izq = 1; der = c;
            while (izq < der)
            {
                while ((izq < der) && (x[f1, izq] % 2 == 0))
                {
                    izq = izq + 1;
                }
                while ((izq < der) && (x[f1, der] % 2 != 0))
                {
                    der = der - 1;
                }
                if (izq < der)
                {
                    Inter(f1, izq, f1, der);
                }
            }
            if (x[f1, izq] % 2 == 0)
            {
                OrdFilaAsc(f1, 1, izq);
                OrdFilaAsc(f1, izq + 1, c);
            }
            else
            {
                OrdFilaAsc(f1, 1, izq - 1);
                OrdFilaAsc(f1, izq, c);
            }
        }

        public void OrdFilaAsc(int f1, int a, int b)
        {
            int c1, c2;
            for (c1 = a; c1 <= b; c1++)
            {
                for (c2 = c1 + 1; c2 <= b; c2++)
                {
                    if (x[f1, c1] > x[f1, c2])
                    {
                        Inter(f1, c1, f1, c2);
                    }
                }
            }
        }

        public void Inter(int f1, int c1, int f2, int c2)
        {
            int aux = x[f1, c1];
            x[f1, c1] = x[f2, c2];
            x[f2, c2] = aux;
        }


        public void ejercicio9()
        {
            int f1;
            for (f1 = 1; f1 <= f; f1++)
            {
                seg_parimp(f1);
            }
        }

        //ejercicio 10

        public int ContadorDePrimos(int f1)
        {
            int c = 0;
            int c1;
            for (c1 = 1; c1 <= this.c; c1++)
            {
                nent num = new nent();
                num.cargar(x[f1, c1]);
                if (num.verifpri())
                {
                    c++;
                }
            }
            return c;
        }

        public void Intercambiarfilas(int f1, int f2)
        {
            int c1;
            for (c1 = 1; c1 <= c; c1++)
            {
                Inter(f1, c1, f2, c1);
            }
        }

        public void ejercicio10()
        {


            int p, d;
            for (p = 1; p <= f - 1; p++)
            {
                for (d = p + 1; d <= f; d++)
                {
                    if (ContadorDePrimos(p) > ContadorDePrimos(d))
                    {
                        Intercambiarfilas(p, d);
                    }
                }
            }
        }

        //PRACTICO 2

        //EJERCICIO 6



        public void Ejercicio1p2()
        {
            int num = c;
            checked
            {
                for (int i = num; i >= 1; i += -1)
                {
                    int num2 = f;
                    for (int j = 1; j <= num2; j++)
                    {
                        int num3 = FrecuenciaElemento(x[j, i]);
                        int num4 = i;
                        for (int k = num4; k >= 1; k += -1)
                        {
                            bool flag = k == i;
                            int num5;
                            if (flag)
                            {
                                num5 = j;
                            }
                            else
                            {
                                num5 = 1;
                            }
                            int num6 = num5;
                            int num7 = f;
                            for (int l = num6; l <= num7; l++)
                            {
                                int num8 = FrecuenciaElemento(x[l, k]);
                                bool flag2 = num3 < num8;
                                if (flag2)
                                {
                                    interV2(j, i, l, k);
                                    num3 = num8;
                                }
                                else
                                {
                                    bool flag3 = num3 == num8 & x[j, i] > x[l, k];
                                    if (flag3)
                                    {
                                        interV2(j, i, l, k);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public int FrecuenciaElemento(int e)
        {
            int num = 0;
            int num2 = this.f;
            checked
            {
                for (int i = 1; i <= num2; i++)
                {
                    int num3 = this.c;
                    for (int j = 1; j <= num3; j++)
                    {
                        bool flag = this.x[i, j] == e;
                        if (flag)
                        {
                            num++;
                        }
                    }
                }
                return num;
            }
        } 

        public void interV2(int a, int b, int f1, int c1)
        {
            int num = x[a, b];
            x[a, b] = x[f1, c1];
            x[f1, c1] = num;
        }




        //ejercicio 7

        public void ejercicio2p2()
        {
            nent nent = new nent();
            nent nent2 = new nent();
            int num = c;

            {
                for (int i = num; i >= 1; i += -1)
                {
                    int num2 = f;
                    for (int j = 1; j <= num2; j++)
                    {
                        int num3 = c;
                        for (int k = num3; k >= 1; k += -1)
                        {
                            int num4 = f;
                            for (int l = 1; l <= num4; l++)
                            {
                                nent.cargar(x[j, i]);
                                nent2.cargar(x[l, k]);
                                bool flag = (nent2.verifpar() & !nent.verifpar()) | (nent2.verifpar() & nent.verifpar() & x[j, i] > x[l, k]) | (!nent2.verifpar() & !nent.verifpar() & x[j, i] > x[l, k]);
                                if (flag) 
                                {
                                    interV2(j, i, l, k);
                                }
                            }
                        }
                    }
                }
            }
        }

        //EJERCICIO 2
        public void ElemMayor_frec_filas()
        {
            int num = f;

            {
                for (int i = 1; i <= num; i++)
                {
                    int num2 = 0;
                    int num3 = c;
                    for (int j = 1; j <= num3; j++)
                    {
                        int num4 = x[i, j];
                        int num5 = frec_ele_fila(num4, i);
                        bool flag = num5 > num2;
                        if (flag)
                        {
                            num2 = num5;
                            x[i, c + 1] = num4;
                        }
                    }
                }
                c++;
            }
        }

        public int frec_ele_fila(int ele, int f1)
        {
            int num = 0;
            int num2 = c;
            checked
            {
                for (int i = 1; i <= num2; i++)
                {
                    bool flag = ele == x[f1, i];
                    if (flag)
                    {
                        num++;
                    }
                }
                return num;
            }
        }


        //ejercicio 3

        public void seg_par_impar_ordenado_todas_filas()
        {
            nent nENT = new nent();
            nent nENT2 = new nent();
            int num = f;
            checked
            {
                for (int i = 1; i <= num; i++)
                {
                    int num2 = c;
                    for (int j = 1; j <= num2; j++)
                    {
                        int num3 = j + 1;
                        int num4 = c;
                        for (int k = num3; k <= num4; k++)
                        { 
                            nENT.cargar(x[i, k]);
                            nENT2.cargar(x[i, j]);
                            bool flag = (nENT.verifpar() & !nENT2.verifpar()) | (nENT.verifpar() & nENT2.verifpar() & x[i, k] < x[i, j]) | (!nENT.verifpar() & !nENT2.verifpar() & x[i, k] < x[i, j]);
                            if (flag)
                            {
                                intercambiar(i, k, i, j);
                            }
                        }
                    }
                }
            }
        }


        public void OrdFilas_PorNumElem_Primos()
        {
            nent nENT = new nent();
            int num = f;
            checked
            {
                for (int i = 1; i <= num; i++)
                {
                    int num2 = 0;
                    int num3 = c;
                    for (int j = 1; j <= num3; j++)
                    {
                        nENT.cargar(x[i, j]);
                        bool flag = nENT.verifpri();
                        if (flag)
                        {
                            num2++;
                        }
                    }
                    x[i, c + 1] = num2;
                }
                c++;
                int num4 = f - 1;
                for (int k = 1; k <= num4; k++)
                {
                    int num5 = k;
                    int num6 = f;
                    for (int l = num5; l <= num6; l++)
                    {
                        bool flag2 = x[k, c] > x[l, c];
                        if (flag2)
                        {
                            IntercambiarFilas(k, l);
                        }
                    }
                }
                c--;
            }
        }

        public void IntercambiarFilas(int nf1, int nf2)
        {
            int num = c;
            int num2 = c;
            checked
            {
                for (int i = 1; i <= num2; i++)
                {
                    bool flag = i <= num;
                    if (flag)
                    {
                        intercambiar(nf1, i, nf2, i);
                    }
                }
            }
        }

        public void intercambiar(int f1, int c1, int f2, int c2)
        {
            int num = x[f1, c1];
            x[f1, c1] = x[f2, c2];
            x[f2, c2] = num;
        }


        //EJERCICIO 4
        public void OrdenaFilaEnFuncAlElemLosRestSeMuevan(int f1)
        {
            checked
            {
                int num = c - 1;
                for (int i = 1; i <= num; i++)
                {
                    int num2 = i + 1;
                    int num3 = c;
                    for (int j = num2; j <= num3; j++)
                    {
                        bool flag = x[f1, j] < x[f1, i];
                        if (flag)
                        {
                            IntercambiarColumnas(j, i);
                        }
                    }
                }
            }
        }

        public void IntercambiarColumnas(int nc1, int nc2)
        {
            int num = f;
            int num2 = f;
            checked
            {
                for (int i = 1; i <= num2; i++)
                {
                    bool flag = i <= num;
                    if (flag)
                    {
                        intercambiar(i, nc1, i, nc2);
                    }
                }
            }
        }


        //EJERCICIO 1


        public void ejercicio1_P2()
        {
            int c1, cont, f1;
            cont = 0;
            nent num = new nent();
            for (f1 = 1; f1 <= f; f1++)
            {

                for (c1 = 1; c1 <= c; c1++)
                {

                    num.cargar(x[f1, c1]);

                    if (num.verifpri())
                    {

                        cont = cont + 1;

                    }

                }

                x[f1, c + 1] = cont;

                cont = 0;


            }

            c = c + 1;

        }

        //EJERCICIO 5

        public bool ejercicio5_P2()
        {
            int c1, cont, f1,aux,a,b;
            bool ban;
            ban = true;
            cont = 0;
            a = 1;
            b = 1;
            aux = (x[1, 1]);
            for (c1 = 1; c1 <= c; c1++)
            {


                for (f1 = 1; f1 <= f-1; f1++)
                {



                    if (aux > (x[f1 + 1, c1]))
                    {

                        if (a==b)
                        {
                           
                            aux = (x[f1, c1]);
                        }
                      
                    }
                    else
                    { 
                        ban = false;
                        a = -1;
                    }

            

                }

                x[f1, c + 1] = cont;

                cont = 0;


            }

            c = c + 1;
            return ban;
        }

    }
}
