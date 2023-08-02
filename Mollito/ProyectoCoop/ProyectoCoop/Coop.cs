using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProyectoCoop
{
    class Coop
    {
        string Narch;
        FileStream stream;
        BinaryWriter writer1;
        BinaryReader reader1;

        int cod = 0;
        string nom = "";
        Char categoria = ' ';
        string tipo = "";
        double cantLotes = 0;
        double cantPollosxLote = 0;
        double costoLote = 0;
        bool est = false;
        public Coop()
        {
            Narch = "";
        }

 
        public void Abrir_Grab(string Narch1)
        {
            Narch = Narch1;
            stream = new FileStream(Narch, FileMode.CreateNew, FileAccess.Write);
            writer1 = new BinaryWriter(stream);
        }

 
        public void Abrir_Leer(string Narch1) 
        {
            Narch = Narch1;
            stream = new FileStream(Narch, FileMode.Open, FileAccess.Read);
            reader1 = new BinaryReader(stream);
        }

      
        public void Abrir_Bajas(string Narch1)
        {
            Narch = Narch1;
            stream = new FileStream(Narch, FileMode.Open, FileAccess.ReadWrite);
            reader1 = new BinaryReader(stream);
            writer1 = new BinaryWriter(stream);
        }
     


        public void Abrir_m(string Narch1)
        {
            Narch = Narch1;
            stream = new FileStream(Narch, FileMode.Open, FileAccess.ReadWrite);
            reader1 = new BinaryReader(stream);
            writer1 = new BinaryWriter(stream);
        }

  
        public void Abrir_Adicionar(string Narch1)
        {
            Narch = Narch1;
            stream = new FileStream(Narch, FileMode.Append, FileAccess.Write);
            writer1 = new BinaryWriter(stream);
        }

 
        public void Grabar(int cod, string nom, Char categoria, string tipo, double hectTierra,
            double hectProduccion, double hectDescanso, bool est)
        {
            nom = nom.PadRight(19, ' ').Substring(0, 19);
            tipo = tipo.PadRight(19, ' ').Substring(0, 19);
            writer1.Write(cod);
            writer1.Write(nom);
            writer1.Write(categoria);
            writer1.Write(tipo);
            writer1.Write(hectTierra);
            writer1.Write(hectProduccion);
            writer1.Write(hectDescanso);
            writer1.Write(est);
        }


        public void GrabarR(int cod, string nom, Char categoria, string tipo, double hectTierra,
             double hectProduccion, double hectDescanso, bool est, int nr)
        {
            
            nr = (nr - 1) * 61;
            stream.Seek(nr, SeekOrigin.Begin);
            nom = nom.PadRight(19, ' ').Substring(0, 19);
            tipo = tipo.PadRight(20, ' ').Substring(0, 20);
            writer1.Write(cod);
            writer1.Write(nom);
            writer1.Write(categoria);
            writer1.Write(tipo);
            writer1.Write(hectTierra);
            writer1.Write(hectProduccion);
            writer1.Write(hectDescanso);
            writer1.Write(est);
        }


        public void Cerrar_Grab()
        {
            writer1.Close();
            stream.Close();
        }        


         public void Leer(ref int cod, ref string nom, ref Char categoria,ref string tipo, ref double CantdLtes, 
            ref double CantPollxLOte, ref double CostXLote,  ref bool est)
        {
            cod = reader1.ReadInt32();
            nom = reader1.ReadString();
            categoria =  reader1.ReadChar();
            tipo = reader1.ReadString();
            CantdLtes = reader1.ReadDouble();
            CantPollxLOte = reader1.ReadDouble();
            CostXLote = reader1.ReadDouble();
            est = reader1.ReadBoolean();
        }



        public void LeerR(ref int cod, ref string nom, ref string categoria, ref char tipo, ref double hectTierra,
              ref double hectProduccion, ref double hectDescanso,  ref bool est, int nr)
        {
            nr = (nr - 1) * 61;
            stream.Seek(nr, SeekOrigin.Begin);
            cod = reader1.ReadInt32();
            nom = reader1.ReadString();
            categoria = reader1.ReadString();
            tipo = reader1.ReadChar();
            hectTierra = reader1.ReadDouble();
            hectProduccion = reader1.ReadDouble();
            hectDescanso = reader1.ReadDouble();
            est = reader1.ReadBoolean();
        }


        public void Cerrar_Leer()
        {
            reader1.Close();
            stream.Close();
        }
        public void Cerrar_Bajas()
        {
            stream.Position = stream.Length;
            reader1.Close();
            writer1.Close();
            stream.Close();
        }

        public bool Verif_Fin()
        {
            return stream.Position == stream.Length;
        }
        public int NRegs()
        {
            return (int)stream.Length / 61;
        }

        // Seleccionar registros por categoria
        public void SeleccionarRegistrosxCategoria(Char categoria1, string Narch1, string Narch2, Coop a2)
        {
            this.Abrir_Leer(Narch1);
            a2.Abrir_Grab(Narch2);

            while (!this.Verif_Fin())
            {
                this.Leer(ref cod, ref nom, ref categoria, ref tipo, ref cantLotes, ref cantPollosxLote, ref costoLote, ref est);
                //categoria = categoria.Trim();
                //categoria1 = categoria1.Trim();
                if (est == true && (categoria == categoria1))
                {
                    a2.Grabar(cod, nom, categoria, tipo, cantLotes, cantPollosxLote, costoLote, est);
                }
            }

            this.Cerrar_Leer();
            a2.Cerrar_Grab();
        }
        // Seleccionar registros por tipo
        public void SeleccionarRegistrosxTipo(string tipo1, string Narch1, string Narch2, Coop a2)
        {
            this.Abrir_Leer(Narch1);
            a2.Abrir_Grab(Narch2);

            while (!this.Verif_Fin())
            {
                this.Leer(ref cod, ref nom, ref categoria, ref tipo, ref cantLotes, ref cantPollosxLote, ref costoLote, ref est);
                tipo = tipo.Trim();
                tipo1 = tipo1.Trim();

                if (est == true && (tipo == tipo1))
                {
                    a2.Grabar(cod, nom, categoria, tipo, cantLotes, cantPollosxLote, costoLote, est);
                }
            }

            this.Cerrar_Leer();
            a2.Cerrar_Grab();
        }

        public void SeleccionarRegitNombreini(Char tipo1, string Narch1, string Narch2, Coop a2)
        {
            this.Abrir_Leer(Narch1);
            a2.Abrir_Grab(Narch2);

            while (!this.Verif_Fin())
            {
                this.Leer(ref cod, ref nom, ref categoria, ref tipo, ref cantLotes, ref cantPollosxLote, ref costoLote, ref est);
                char compa = nom[0];
                if (est == true && (compa ==tipo1))
                {
                    a2.Grabar(cod, nom, categoria, tipo, cantLotes, cantPollosxLote, costoLote, est);
                }
            }

            this.Cerrar_Leer();
            a2.Cerrar_Grab();
        }
        public void SeleccionarporcodigosPares( string Narch1,string Narch2,ref Coop a2)
        {
            this.Abrir_Leer(Narch1);
            a2.Abrir_Grab(Narch2);
            while (!this.Verif_Fin())
            {
                Leer(ref cod, ref nom, ref categoria, ref tipo, ref cantLotes, ref cantPollosxLote, ref costoLote, ref est);
                if (est && (cod % 2 == 0))
                {
                    a2.Grabar(cod, nom, categoria, tipo, cantLotes, cantPollosxLote, costoLote, est);
                }
            }
            this.Cerrar_Leer();
            a2.Cerrar_Grab();



        }
        
        public void SeleccXcodigPrimos(string Narch1,string Narch2,ref Coop a2)
        {
            
            this.Abrir_Leer(Narch1);
            a2.Abrir_Grab(Narch2);
            while (!this.Verif_Fin())
            {
                Leer(ref cod, ref nom, ref categoria, ref tipo, ref cantLotes, ref cantPollosxLote, ref costoLote, ref est);
                int cntdr = 0;
                for (int i = 1; i <= cod; i++)
                {
                    if (cod % i == 0)
                    {
                        cntdr++;
                    }
                }
                if (est && (cntdr==2))
                {
                    a2.Grabar(cod, nom, categoria, tipo, cantLotes, cantPollosxLote, costoLote, est);
                }
            }
            this.Cerrar_Leer();
            a2.Cerrar_Grab();

        }
        // Calcular el costo total de inventario -> cantidad de lotes * costo de lote
        public double CostoInventario(string Narch1)
        {

            double acum = 0;

            this.Abrir_Leer(Narch1);
            while (!this.Verif_Fin())
            {
                this.Leer(ref cod, ref nom, ref categoria, ref tipo, ref cantLotes, ref cantPollosxLote, ref costoLote, ref est);
                if (est == true)
                {
                    acum = acum + (cantLotes * costoLote);
                }
            }
            this.Cerrar_Leer();
            return acum;
        }

    }
}
