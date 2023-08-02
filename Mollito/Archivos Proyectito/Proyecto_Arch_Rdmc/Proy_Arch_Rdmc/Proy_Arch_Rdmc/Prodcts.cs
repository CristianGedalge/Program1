using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//llamamos a esta libreria

namespace Proy_Arch_Rdmc
{
    class Prodcts
    {
        string cadena;
        FileStream stream;
        BinaryReader read;
        BinaryWriter write;


        public Prodcts()
        {
            cadena = "";
        }

        public void Abrir_Grabar(string s)
        {
            cadena = s;
            stream = new FileStream(cadena, FileMode.CreateNew, FileAccess.Write);
            write = new BinaryWriter(stream);
        }

        public void Grabar(int codigo,string descrip,double cantd,Double precio,bool estado)
        {
            write.Write(codigo);
            write.Write(descrip);
            write.Write(cantd);
            write.Write(precio);
        }
        public void Cerrar_Grabar()
        {
            write.Close();
            stream.Close();
        }


        public void Abrir_Leer(string s)
        {
            cadena = s;
            stream = new FileStream(cadena, FileMode.Open, FileAccess.Read);
            read = new BinaryReader(stream);
        }

        public void Leer(ref int cod,ref string desc,ref double cant,ref double prec,ref bool esta)
        {
            cod = read.ReadInt32();
            desc = read.ReadString();
            cant = read.ReadDouble();
            prec = read.ReadDouble();
            esta = read.ReadBoolean();
        }

        public void Cerrar_Leer()
        {
            read.Close();
            stream.Close(); 
        }

        public Boolean Verif_fin()
        {
            return stream.Length == stream.Position;
                
        }




    }
}
