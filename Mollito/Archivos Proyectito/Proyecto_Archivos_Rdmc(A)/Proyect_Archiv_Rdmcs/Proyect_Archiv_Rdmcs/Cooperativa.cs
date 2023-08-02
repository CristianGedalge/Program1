using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Proyect_Archiv_Rdmcs
{
    class Cooperativa
    {
        string arch;
        FileStream stream;
        BinaryReader reader1;
        BinaryWriter writer1;
        private string Categ;
        public Cooperativa()
        {

            arch = "";
        }

        public void Abrir_Grabar(String cadena)
        {
            arch = cadena;
            stream = new FileStream(arch, FileMode.CreateNew, FileAccess.Write);
            writer1 = new BinaryWriter(stream);
        }

        public  void Grabar( int codigo, String nombre, String categoria, String tipo_pollo, Double cantlotesdePoll, double cantPolloXlote, Double costodeLote,Boolean band)
        {
            
            writer1.Write(codigo);
            writer1.Write(nombre);
            writer1.Write(categoria);
            writer1.Write(tipo_pollo);
            writer1.Write(cantlotesdePoll);
            writer1.Write(cantPolloXlote);
            writer1.Write(costodeLote);
            writer1.Write(band);
        }

        public void GrabarRdmc(int codigo, String nombre, String categoria, String tipo_pollo, Double cantlotesdePoll, double cantPolloXlote, Double costodeLote, Boolean band,int nr)
        {
            nr = (nr - 1) * 50;
            stream.Seek(nr, SeekOrigin.Begin);
            writer1.Write(codigo);
            writer1.Write(nombre);
            writer1.Write(categoria);
            writer1.Write(tipo_pollo);
            writer1.Write(cantlotesdePoll);
            writer1.Write(cantPolloXlote);
            writer1.Write(costodeLote);
            writer1.Write(band);
        }
        public void Cerrar_Grabar()
        {
            writer1.Close();
            stream.Close();
        }
        public void Abrir_Leer(String cad)
        {
            arch = cad;
            stream = new FileStream(arch, FileMode.Open, FileAccess.Read);
            reader1 = new BinaryReader(stream);
            
           
        }
        public void Leer(ref int codig, ref string nombre, ref string categoria, ref string tipo_pollo, ref Double cantlotesdePoll, ref Double cantPolloXlote, ref double costodeLote,ref Boolean bandera)
        {

            codig = reader1.ReadInt32();
            nombre = reader1.ReadString();
            categoria = reader1.ReadString();
            tipo_pollo = reader1.ReadString();
            cantlotesdePoll = reader1.ReadDouble();
            cantPolloXlote = reader1.ReadDouble();
            costodeLote = reader1.ReadDouble();
            bandera = reader1.ReadBoolean();
        }

        public void Cerrar_Leer()
        {
            reader1.Close();
            stream.Close();
        }

        public Boolean Verif_Posicion()
        {
            return stream.Position == stream.Length;  
        }

        public void Leer_Rdmc(ref int codigo, ref string nombre, ref string categoria, ref string tipo_pollo, ref Double cantlotesdePoll, ref Double cantPolloXlote, ref double costodeLote, ref Boolean bandera,int nr)
        {
            nr = (nr - 1) * 50;
            stream.Seek(nr, SeekOrigin.Begin);
            codigo = reader1.ReadInt32();
            nombre = reader1.ReadString();
            categoria = reader1.ReadString();
            tipo_pollo = reader1.ReadString();
            cantlotesdePoll = reader1.ReadDouble();
            cantPolloXlote = reader1.ReadDouble();
            costodeLote = reader1.ReadDouble();
            bandera = reader1.ReadBoolean(); 
        }
        public void SeleccXCategoria(string cattt,ref Cooperativa c2,ref string catego)
        {




        }
    }
}