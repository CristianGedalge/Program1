 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Proyecto_Archivos
{
    class ArchSecuen
    {
        string s;
        FileStream streamcito;
        BinaryReader reader;
        BinaryWriter write;
        public ArchSecuen()
        {
            s = "";
        }
        public void Abrir_Grabar(string s1)
        {
            s = s1;
            streamcito = new FileStream(s, FileMode.CreateNew, FileAccess.Write);
            write = new BinaryWriter(streamcito);
        }
        public void Cerrar_Grabar()
        {

            write.Close();
            streamcito.Close();
        }
        public void Grabar(int ele)
        {
            write.Write(ele);
        }
        public void Abrir_Leer(string s1)
        {
            s = s1;
            streamcito = new FileStream(s, FileMode.Open, FileAccess.Read);
            reader = new BinaryReader(streamcito);
        }
        public void Cerrar_Leer()
        {
            reader.Close();
            streamcito.Close();
        }
        public int Leer()
        {
            int num = reader.ReadInt32();
            return num;
        }
        public bool Verif_fin()
        {
            return streamcito.Position == streamcito.Length;
        }










































        //    string Narch;
        //    FileStream Stream;
        //    BinaryWriter Writer1;
        //    BinaryReader Reader1;
        //    public ArchSecuen()
        //    {
        //        Narch = "";
        //    }

        //    public void Abrir_Grabar(string Narch1)
        //    {
        //        Narch = Narch1;
        //        Stream = new FileStream(Narch, FileMode.CreateNew, FileAccess.Write);
        //        Writer1 = new BinaryWriter(Stream);
        //    }
        //    public void Grabar(int n)
        //    {
        //        Writer1.Write(n);
        //    }

        //    public void Cerrar_Grabar()
        //    {
        //        Writer1.Close();
        //        Stream.Close();
        //    }
        //    public void Abrir_Leer(string Narch1)
        //    {
        //        Narch = Narch1;
        //        Stream = new FileStream(Narch, FileMode.Open, FileAccess.Read);
        //        Reader1 = new BinaryReader(Stream);
        //    }
        //    public int Leer()
        //    {
        //        int n = Reader1.ReadInt32();
        //        return n;
        //    }
        //    public void Cerrar_Leer()
        //    {
        //        Reader1.Close();
        //        Stream.Close();
        //    }
        //    public Boolean Verif_fin()
        //    {
        //        return (Stream.Position == Stream.Length);
        //    }
    }
}
