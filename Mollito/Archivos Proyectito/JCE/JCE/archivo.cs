using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace JCE
{
    class archivo
    {

        string narchjce;
        FileStream stream;
        BinaryWriter writer1;
        BinaryReader reader1;

        public archivo()
        {
            narchjce = "";
        }
        public void ag(string x)
        {
            narchjce = x;
            stream = new FileStream(narchjce, FileMode.CreateNew, FileAccess.Write);
            writer1 = new BinaryWriter(stream);
        }
        public void Record(int n)
        {
            writer1.Write(n);
        }
        public void close_record()
        {
            writer1.Close();
            stream.Close();
        }


        public void al(string narch1)
        {
            narchjce = narch1;
            stream = new FileStream(narchjce, FileMode.Open, FileAccess.Read);
            reader1 = new BinaryReader(stream);
        }
        public int read_a()
        {
            int n;
            n = reader1.ReadInt32();
            return n;
        }
        public void cl()
        {
            reader1.Close();
            stream.Close();
        }
        public bool check_end()
        {
            return stream.Position == stream.Length;
        }

        public void Ejer1(string x, string y, archivo a2)
        {
            nent na = new nent();
            al(x);
            a2.ag(y);
            while (!check_end())
            {
                na.load(read_a());
                if (na.verifDigIgual())
                    a2.Record(na.descargar());
            }
            cl();
            a2.close_record();
        }
        public void Ejer2(string x, string y, archivo a2)
        {
            nent na = new nent();
            al(x);
            a2.ag(y);
            while (!check_end())
            {
                na.load(read_a());
                if (na.DigDif())
                    a2.Record(na.descargar());
            }
            cl();
            a2.close_record();
        }
        public void Ejer3(string x, string y, archivo a2)
        {
            nent na = new nent();
            al(x);
            a2.ag(y);
            while (!check_end())
            {
                na.load(read_a());
                if (na.DigRig() ||
                    na.DigMay())
                {
                    a2.Record(na.descargar());
                }
            }
            cl();
            a2.close_record();
        }
        public void Ejer4(string x, string y, string z, archivo a2, archivo a3)
        {
            al(x);
            a2.al(y);
            a3.ag(z);
            nent na1 = new nent();
            nent na2 = new nent();
            int i, j;
            var b1jce = true;
            var b2 = true;
            j = 0;
            i = 0;
            if (!check_end())
            {
                na1.load(read_a());
                i = na1.descargar();
            }

            if (!a2.check_end())
            {
                na2.load(a2.read_a());
                j = na2.descargar();
            }

            while (b1jce || b2)
            {
                if (b1jce & i < j)
                {
                    a3.Record(na1.descargar());
                    if (!check_end())
                    {
                        na1.load(read_a());
                        i = na1.descargar();
                    }
                    else
                    {
                        b1jce = false;
                    }
                }
                else if ((b2))
                {
                    a3.Record(na2.descargar());
                    if (!a2.check_end())
                    {
                        na2.load(a2.read_a());
                        j = na2.descargar();
                    }
                    else
                    {
                        b2 = false;
                    }
                }
            }
            cl();
            a2.cl();
            a3.close_record();
        }

    }
}
