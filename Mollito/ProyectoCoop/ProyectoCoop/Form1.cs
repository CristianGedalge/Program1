using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ProyectoCoop
{
    public partial class Form1 : Form
    {
        Coop a1,a2;

        int codigo, nr=0;
        int cod = 0;
        string nom = "";
        char categoria;
        string tipo;
        double CantidLotes=0;
        double CantidPollxLote= 0;
        double CostoXlote=0;
        bool est = false;

        int nr1, cod1 = 0;
        string r1, r2 = "";

        
        public Form1(){
            InitializeComponent();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Form1_Load(object sender, EventArgs e){
            a1 = new Coop();
            a2 = new Coop();
        }
        public void limpiar(){
            dataGridView1.Rows.Clear();
        }

        // Limpiar
        private void button3_Click(object sender, EventArgs e)
        {
            limpiar();
        }



        //Creacion
        private void creacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            a1.Abrir_Grab(saveFileDialog1.FileName);
            do{
                codigo = int.Parse(Interaction.InputBox("Ingrese codigo multipolo de 1000"));
            }while (codigo % 1000 != 0);
            nr = 1;
            dataGridView1.Rows[0].Cells[0].Value = Convert.ToString(codigo + nr);
        }



        // Grabar
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                a1.Grabar(Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value), 
                            Convert.ToString(dataGridView1.Rows[0].Cells[1].Value), 
                            Convert.ToChar(dataGridView1.Rows[0].Cells[2].Value),
                            Convert.ToString(dataGridView1.Rows[0].Cells[3].Value), 
                            Convert.ToDouble(dataGridView1.Rows[0].Cells[4].Value), 
                            Convert.ToDouble(dataGridView1.Rows[0].Cells[5].Value), 
                            Convert.ToDouble(dataGridView1.Rows[0].Cells[6].Value),true);
                limpiar();
                nr++;
                dataGridView1.Rows[0].Cells[0].Value = Convert.ToString(codigo + nr);
                dataGridView1.Rows[0].Cells[0].ReadOnly = true;
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }



        // Terminar
        private void button2_Click(object sender, EventArgs e)
        {
            if (nr > 0)
                a1.Cerrar_Grab();
            else
                MessageBox.Show("Garbara al menos 1 registro");
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            saveFileDialog1.ShowDialog();
            a1.SeleccionarporcodigosPares(openFileDialog1.FileName, saveFileDialog1.FileName,ref a2);

        }

        private void operacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void seleccionarRegistrosXCodigosPrimosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            saveFileDialog1.ShowDialog();
            a1.SeleccXcodigPrimos(openFileDialog1.FileName, saveFileDialog1.FileName, ref a2);
        }

        private void seleeccionarRegistrosXInicialesDeLosNombresToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            Char tipo1 = ' ';
            openFileDialog1.ShowDialog();
            saveFileDialog1.ShowDialog();
            tipo1 = Convert.ToChar(Interaction.InputBox("Tipo de Pollo: "));
            a1.SeleccionarRegitNombreini(tipo1, openFileDialog1.FileName, saveFileDialog1.FileName, a2);
        }

        // Accesar
        private void accesarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            a1.Abrir_Leer(openFileDialog1.FileName);
            nr = -1;
            while (!a1.Verif_Fin())
            {
                a1.Leer(ref cod, ref nom, ref categoria, ref tipo, ref CantidLotes, ref CantidPollxLote, ref CostoXlote,  ref est);
                if (est == true)
                {
                    nr++;
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[nr].Cells[0].Value = Convert.ToString(cod);
                    dataGridView1.Rows[nr].Cells[1].Value = Convert.ToString(nom);
                    dataGridView1.Rows[nr].Cells[2].Value = Convert.ToString(categoria);
                    dataGridView1.Rows[nr].Cells[3].Value = Convert.ToString(tipo);
                    dataGridView1.Rows[nr].Cells[4].Value = Convert.ToString(CantidLotes);
                    dataGridView1.Rows[nr].Cells[5].Value = Convert.ToString(CantidPollxLote);
                    dataGridView1.Rows[nr].Cells[6].Value = Convert.ToString(CostoXlote);
                }
            }
            a1.Cerrar_Leer();
        }


        // Seleccionar registros por categoria
        private void seleccionarRegistrosPorCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Char categoria1 = ' ';
            //openFileDialog1.ShowDialog();
            saveFileDialog1.ShowDialog();
            categoria1 = Char.Parse(Interaction.InputBox("Categoria: "));
            a1.SeleccionarRegistrosxCategoria(categoria1, openFileDialog1.FileName, saveFileDialog1.FileName, a2);
        }
        // Seleccionar registros por tipo
        private void seleccionarRegistrosPorTipoDePolloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String tipo1 = "";
            openFileDialog1.ShowDialog();
            saveFileDialog1.ShowDialog();
            tipo1 =(Interaction.InputBox("Tipo de Pollo: "));
            a1.SeleccionarRegistrosxTipo(tipo1, openFileDialog1.FileName, saveFileDialog1.FileName, a2);
        }
        // Costo total de los Lotes de pollos -> sumatoria de (cantidad de lotes * costo de lote)
        private void costoTotalDelLosLotesDePolloToolStripMenuItem_Click(object sender, EventArgs e)
        {
        //    openFileDialog1.ShowDialog();
        //    label2.Text = "Costo total: " + Convert.ToString(a1.CostoInventario(openFileDialog1.FileName));
        }

    }
}
