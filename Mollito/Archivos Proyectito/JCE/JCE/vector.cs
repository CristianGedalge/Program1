# region
using System;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
#endregion
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace JCE
{
    class vector
    {
        const int MAX = 50;
        private int[] v;
        private int n;

        public vector()
        {
            n = 0;
            v = new int[MAX];
        }
        public void cargar(int nu, int a, int b)
        {
            n = nu;
            Random r = new Random();
            int i;
            for (i = 1; i <= n; i++)
            {
                v[i] = r.Next(a, b);
            }
        }

        # region
        public void uploadmanualjce(int n1)
        {
            int i;
            n = n1;
            for (i = 1; i <= n; i++)
            {
                v[i] = Conversions.ToInteger(Interaction.InputBox("", ""));
            }

        }
        #endregion

        public string descargar()
        {
            string s = "";
            int i;
            for (i = 1; i <= n; i++)
            {
                s = s + v[i] + " | ";
            }
            return s;
        }
        public void inter(int a, int b)
        {
            int aux = v[a];
            v[a] = v[b];
            v[b] = aux;
        }
        public void tidy()
        {
            int p, d;
            for (p = 1; p <= n - 1; p++)
            {
                for (d = p + 1; d <= n; d++)
                {
                    if (v[p] >= v[d])
                        inter(p, d);
                }
            }
        }
        public void rec_a(string narch1)
        {
            archivo a1 = new archivo();
            int i;
            a1.ag(narch1);
            for (i = 1; i <= n; i++)
                a1.Record(v[i]);
            a1.close_record();
        }
        public void acc_a(string narch1)
        {
            archivo a1 = new archivo();
            int i = 0;
            a1.al(narch1);
            while (!a1.check_end())
            {
                i++;
                v[i] = a1.read_a();
            }
            n = i;
            a1.cl();
        }

        public void bubble()
        {
            for (int i = 1; i < n; i++)
            {
                for (int j = i + 1; i <= n; i++)
                {
                    if (v[i] > v[j])
                    {
                        int aux = v[i];
                        v[i] = v[j];
                        v[j] = aux;
                    }
                }
            }
        }



    }
}
