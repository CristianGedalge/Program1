using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Vectores_Practico_1
{
    class Vector
    {
        const int max = 100;
        private int[] v;
        private int n;
        public Vector()
        {
            n = 0;
            v =  new int[max];
        }
        public void Cargar(int n1,int a ,int b)
        {
            int i;
            Random r;
            r = new Random();
            n = n1;

            for (i = 1; i <= n; i++)
                v[i] = r.Next(a, b);
            
        }

        public String Descargar()
        {
            String s;
            int i;
            s = "";
            for (i = 1; i <= n; i++)
                s = s + v[i] + " ";

            return s;
        }
        public  void Ejercicio1Pr1(int n1 , int bas)
        {
            int i,exp;
            n = n1;
            exp = 0;
            for (i = 1; i <= n; i++)
            {               
                v[i] =Convert.ToInt32( Math.Pow(bas, exp));
                exp++;
            }
        }
        public String Ejercicio2Pr1()
        {
            //double operacion=0 ,vd;
            Boolean bandera = true;
            NEntero f=new NEntero();
            String cadena = "";
            int anterior=-1, actual=1,fibo,i;
            for (i = 1; i <= n; i++)
            {
                fibo = anterior + actual;
                anterior = actual;
                actual = fibo;
                f.Cargar(fibo);
                if (bandera)
                {
                    cadena = cadena + v[i] + "/" + fibo + "!";
                    bandera = false;
                }
                else
                {
                    cadena = cadena + "-" + v[i] + "/" + fibo + "!" + "+";
                    bandera = true;
                }
            }
            return cadena;
          
        }

        public int Ejercicio3Pr1()

        {
            int i,c=0;
            NEntero sub;
            sub = new NEntero();
            for(i=1;i<= n; i++)
            {
                if (sub.Submultiplo(v[i], i))
                    c++;                    
            }
            return c;
        }

        public double Ejercicio4Pr1(int vi,int r)
        {
            int i, serie, contador = 0;
            double suma = 0;
            i = 1;
            serie = vi + (i + 1) * r;
            while(serie <= n)
            {
                suma = suma + v[serie];
                contador++;
                i++;
                serie =vi+(i - 1) * r;

            }
            return Convert.ToDouble(suma / contador);
        }
        public double ejer4(int vi,int r)//5178911923 5 3
        {
            double media=0;
            int c = 0,pos=0,i=1;
            pos = vi + (i - 1) * r;
            while (pos <= n)
            {
                media = media + v[pos];
                c++;
                i++;
                pos = vi + (i - 1) * r;
            }
            return (media/c);
        }

        public void Ejercicio5Pr1( ref Vector v1,ref Vector v2)
        {
            NEntero nc;
            nc = new NEntero();
            int elemento;
            
            for(int i= 1;i<= n; i++)
            {
                elemento = v[i];
                nc.Cargar(elemento);

                if (nc.VerifPrimo())
                    v1.Cargar1X1(v[i]);
                else
                    v2.Cargar1X1(v[i]);
            }
        }
        public void CargXelem(int elment)
        {
            n++;
            v[n] = elment;

        }

        public void Ejercicio6Pr1(int a,int b) // 2 3 5 
        {
            int i, aux;
            aux = (a + b) / 2;
            for (i = b; i>aux; i--)
            {
                SwapIntercambiar(a, i);
                a++;
                //aux = v[a];
                //v[a] = v[i];
                //v[i] = aux;
                //a++; 
            }
        }

        public Boolean Ejercicio7Pr1()
        {
            Boolean resp = true;
            int i,p;
            for (i=1;i<= n-1; i++)
            {
                for (p=i+1;p<= n;p++)
                    if (v[i] ==v[p])
                    {
                        resp = false;
                    }
            }
            return resp;
        }


        public void Ejercicio8Pr1( ref Vector v2,ref Vector v3)// no pongo v2.n=0 por que es un objeto que ingresa el usuario y si lo pongo dara nada,en cambio inicilizo v3.n pr que hay almaceno las intersecciones
        {
            v3.n = 0;
            int i;
            for (i = 1; i <= n; i++)
                if (v2.ExisteDentro(v[i])&& !v3.ExisteDentro(v[i]))
                    v3.Cargar1X1(v[i]);                
        }

        public bool ExisteDentro(int valor)
        {
            for (int i = 1; i <= n; i++)
            {
                if (v[i] == valor)
                    return true;                
            }
            return false;
        }
        public void Ejercicio9Pr1(Vector v2,ref Vector v3)
        {
            v3.n = 0;
            for (int i = 1; i <= n; i++)
                if (!v3.ExisteDentro(v[i]))
                    v3.Cargar1X1(v[i]);
            for (int p = 1; p <= v2.n; p++)
                if (!v3.ExisteDentro(v2.v[p]))
                    v3.Cargar1X1(v2.v[p]);
            v3.OrdAscdt();

            

        }
        public Boolean Ejercicio10Pr1(int a ,int b)
        {
            Boolean res=true ;
            int i;
            for (i = a; i <= b - 1; i++)
                if (v[i] <= v[i + 1])
                    res = true;
                else
                    return  false;
            return res;
            
        } 



        public void Ejercicio1Pr2()
        {
            int i = 1, ele;
            NEntero numPri = new NEntero();
            ele = n;
            
            OrdAscdt();
            n = 0;
            for (i = 1; i <= ele; i++)
            {
                numPri.Cargar(v[i]);
                if (numPri.VerifPrimo())
                {
                    this.Cargar1X1(v[i]);
                }
            }
        }
        public void Cargar1X1(int num)
        {
            n++;
            v[n] = num;
        }
        public void Ejercicio2Pr2(int m)

        {
            int p=0;
            Vector aux = new Vector();
            for (int i = 1; i <= n; i++)
                if ((i % m) == 0)
                    aux.CargXelem(v[i]);
            aux.ordenar();
            for (int i = 1; i <= n; i++)
            {
                if ((i% m) == 0)
                {
                    p++;
                    v[i] = aux.Getelemto(p);

                }

                    
            }
        }
        public int Getelemto(int pos)
        {
            return v[pos];
        }

        public void ordenar()

        {
            int aux;
            for (int i = 1; i <= n; i++)
                for (int j = i+1; j <= n; j++)
                    if (v[i] > v[j])
                    {
                        aux = v[i];
                        v[i] = v[j];
                        v[j] = aux; 
                    }
        }
        public void Ejercicio3Pr2()
        {
            Boolean bandera = true;
            int nu = n, ini = 1;
            Vector aux = new Vector();
            for (int i = 1; i <= n; i++)
            {
                aux.CargXelem(v[i]);
            }
            aux.ordenar();
            for (int i = 1; i <= n; i++)
                if (bandera)
                {
                    v[ini] = aux.Getelemto(i);
                    ini++;
                    bandera = false;
                }

                else
                {
                    v[nu] = aux.Getelemto(i);
                    nu--;
                    bandera = true;
                }
        }

        public int Ejercicio4Pr2(int rangoA, int rangoB)
        {
            Vector aux = new Vector();
            for(int i=rangoA;i<= rangoB;i++)
            {
                if (!(aux.ExisteDentro(v[i])))
                    aux.Cargar1X1(v[i]);
            }
            return aux.n;
           
        }
        public void  Ejercicio5Pr2(int rangoA,int rangoB,Vector v222, ref Vector v333) //245526412
        {
            int men;
            Vector aux1 = new Vector();
            Vector aux2 = new Vector();
            v222.n = 1;v333.n = 1;
            for(int i = rangoA; i <= rangoB; i++)
            {
                if ((!aux1.ExisteDentro(v[i])))
                {
                    aux1.Cargar1X1(v[i]);
                    int contad = 1; 
                    for(int p= i+1;p<= rangoB; p++)// 2 1 1 1 1     1 4
                    {
                        if (v[i] == v[p])
                            contad++;
                    }
                    aux2.Cargar1X1(contad);
                }
            }
            men = aux2.PosicionMenor();
            v222.v[v222.n]=(aux1.v[men]); // 
            v333.v[v333.n]=(aux2.v[men]);
            
        }


        public int PosicionMenor()//2341
        {
            int aux = v[1],pos=1;

            for (int i = 1; i <= n; i++)
            {
                if (!(aux <= v[i]))
                {
                    aux = v[i];
                    pos = i;
                }
            }
            return pos;
        }
        public void Ejercicio6Pr2(int rangoA, int rangoB, ref Vector vtwo, ref Vector vthree)
        {
            vtwo.n = 0;
            vthree.n = 0;
            for (int i = rangoA; i <= rangoB; i++)
                if (!vtwo.ExisteDentro(v[i]))
                    vtwo.Cargar1X1(v[i]);
            vtwo.OrdAscdt();
            for (int i = 1; i <= vtwo.n; i++)
            {
                int contador = 0;
                for (int p = rangoA; p <= rangoB; p++)
                    if (vtwo.v[i] == v[p])
                        contador++;
                vthree.Cargar1X1(contador);
            }
        }
        public void Ejercicio7Pr2(ref Vector v2, ref Vector v3)
        {
            int anterior = -1,actual = 1,fibo=0,may,cont;
            v2.n = 0;v3.n = 0;
            may = GetMayor();

            while (fibo< may)
            {
                fibo = anterior + actual;   //-1 1 1 0 
                anterior = actual;
                actual = fibo;
                if (!(v2.ExisteDentro(fibo)) &&(ExisteDentro(fibo)))
                {
                    cont = 0;
                    for (int i = 1; i <= n; i++)
                    {
                        if (v[i] == fibo)
                            cont++;
                    }
                    v2.Cargar1X1(fibo);
                    v3.Cargar1X1(cont);
                }

            }

        }

        public int GetMayor() //2  1 2 5 8 
        {
            int aux=v[1];
            for (int i = 1; i <= n-1; i++)
                if (aux <= v[i+1])
                    aux = v[i+1];
            return aux;

        }
        public void Ejercicio8Pr2(int rangoA,int rangoB) 
        {
            int c = 0, c2=0;
            Vector vprim = new Vector();
            Vector vnoprim = new Vector();
            NEntero nc = new NEntero();
            for(int i=rangoA;i<=rangoB;i++)
            {
                nc.Cargar(v[i]);
                if (nc.VerifPrimo())
                    vprim.Cargar1X1(v[i]);
                else
                    vnoprim.Cargar1X1(v[i]);
            }
            vprim.OrdDescen();
            vnoprim.OrdDescen();
            for(int i= rangoA;i<= rangoB;i++)
            {
                c++;

                if (c<= vprim.n)
                {
                    v[i] = vprim.Getelemto(c);
                }
                else
                {
                    c2++;
                    v[i] = vnoprim.Getelemto(c2);
                }
            }





        }
        public  void OrdDescen()//1 3 2 5
        {
            int aux;
            for (int i = 1; i <= n-1; i++)
            {
                aux = v[i];
                for (int p = i + 1; p <= n; p++)
                    if (!(aux > v[p]))
                    {
                        aux = v[p];
                        SwapIntercambiar(i, p);
                    }
                
            }
        }


        public void SwapIntercambiar(int a, int b)
        {
            int aux = v[a];
            v[a] = v[b];
            v[b] = aux;
        }

        public void Ejercicio9Pr2()
        {
            int c = 0;
            NEntero nc = new NEntero();
            Vector vcapi = new Vector();
            Vector nocapi = new Vector();
            for (int i = 1; i <= n; i++)
            {
                nc.Cargar(v[i]);
                if (nc.Capicua())
                    vcapi.Cargar1X1(v[i]);
                else
                    nocapi.Cargar1X1(v[i]);         
            }
            vcapi.OrdAscdt();
            nocapi.OrdDescen();
            for(int i=1;i<= n; i++)
            {
                if (i <= vcapi.n)
                    v[i] = vcapi.Getelemto(i);
                else
                {
                    c++;
                    v[i] = nocapi.Getelemto(c);
                }
            }
        }





        public void OrdAscdt() // 2 1 5
        {
            int aux;
            for (int i = 1; i <= n - 1; i++)
            {
                aux = v[i];
                for (int p = i + 1; p <= n; p++)
                    if (!(aux < v[p]))
                    {
                        aux = v[p];
                        SwapIntercambiar(i, p);
                    }
            }
        }
        public void Ejercicio10Pr2(int rangoA,int rangoB)
        {
            Vector vprim = new Vector();
            Vector vnoprim = new Vector();
            NEntero nc = new NEntero();
            int c = 0,c1=0;
            Boolean bandera = true;
            for (int i = rangoA; i <= rangoB; i++)
            {
                nc.Cargar(v[i]);
                if (nc.VerifPrimo())
                    vprim.Cargar1X1(v[i]);
                else
                    vnoprim.Cargar1X1(v[i]);
            }
            vprim.OrdAscdt();
            vnoprim.OrdAscdt();
            bandera = (vprim.n > 0);
            for (int p = rangoA; p <= rangoB; p++)
            {

                if (bandera)   // 2222  8  10 
                {
                    c++;
                    v[p] = vprim.v[c];
                    bandera = (!(vnoprim.n > c1));    
                }
                else
                {
                    c1++;
                    v[p] = vnoprim.v[c1];
                    bandera = (vprim.n >c);

                }

            }
        }        

        
    }
}
