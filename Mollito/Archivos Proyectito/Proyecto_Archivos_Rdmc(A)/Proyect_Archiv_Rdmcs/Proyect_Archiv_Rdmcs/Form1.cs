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

namespace Proyect_Archiv_Rdmcs
{
    public partial class Form1 : Form
    {
        Cooperativa c1,c2;
        int codigo,nr;
        int cod;
        string name, categ, tipoPollo;
        double cantlotesdepollo, cantPollXlote, CostoXlote;
        Boolean estado;
        string catggg, cate1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void seleccionarXCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            catggg = Microsoft.VisualBasic.Interaction.InputBox("Categoria");
            c1.Leer(ref cod, ref name, ref categ, ref tipoPollo, ref cantlotesdepollo, ref cantPollXlote, ref CostoXlote, ref estado);
            c2.SeleccXCategoria(catggg, ref c2,ref categ);

            //openFileDialog1.ShowDialog();
            //c1.Abrir_Leer(openFileDialog1.FileName);
            //nr = -1;
            //while (!c1.Verif_Posicion())
            //{
            //    c1.Leer(ref cod, ref name, ref categ, ref tipoPollo, ref cantlotesdepollo, ref cantPollXlote, ref CostoXlote, ref estado);
            //    if (estado == true)
            //    {

            //        nr++;
            //        dataGridView1.Rows.Add();
            //        dataGridView1.Rows[nr].Cells[0].Value = Convert.ToString(cod);
            //        dataGridView1.Rows[nr].Cells[1].Value = Convert.ToString(name);
            //        dataGridView1.Rows[nr].Cells[2].Value = Convert.ToString(categ);
            //        dataGridView1.Rows[nr].Cells[3].Value = Convert.ToString(tipoPollo);
            //        dataGridView1.Rows[nr].Cells[4].Value = Convert.ToString(cantlotesdepollo);
            //        dataGridView1.Rows[nr].Cells[5].Value = Convert.ToString(cantPollXlote);
            //        dataGridView1.Rows[nr].Cells[6].Value = Convert.ToString(CostoXlote);
            //    }
            //    catgggg = categ;
            //    cate1 = Microsoft.VisualBasic.Interaction.InputBox("Introduzca Codigo multiplo de 1000");
            //    c2.SeleccXCategoria(cate1, ref c2, ref catgggg);
            //}

        }

        private void button1_Click(object sender, EventArgs e)
        {
            c1.Grabar(Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value), Convert.ToString(dataGridView1.Rows[0].Cells[1].Value), Convert.ToString(dataGridView1.Rows[0].Cells[2].Value), Convert.ToString(dataGridView1.Rows[0].Cells[3].Value), Convert.ToDouble(dataGridView1.Rows[0].Cells[4].Value), Convert.ToDouble(dataGridView1.Rows[0].Cells[5].Value), Convert.ToDouble(dataGridView1.Rows[0].Cells[6].Value),true);
            dataGridView1.Rows.Clear();
            nr++;
            dataGridView1.Rows[0].Cells[0].Value = Convert.ToString(codigo + nr);
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (nr > 0)
                c1.Cerrar_Grabar();
            else
                MessageBox.Show("Grabar al menos 1 registro ");
               
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            c1 = new Cooperativa();
            c2 = new Cooperativa();
        }

        private void accesarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            c1.Abrir_Leer(openFileDialog1.FileName);
            nr = -1;
            while (!c1.Verif_Posicion())
            {
                c1.Leer(ref cod,ref name, ref categ, ref tipoPollo, ref cantlotesdepollo, ref cantPollXlote, ref CostoXlote,ref estado);
                if (estado == true)
                {

                    nr++;
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[nr].Cells[0].Value = Convert.ToString(cod);
                    dataGridView1.Rows[nr].Cells[1].Value = Convert.ToString(name);
                    dataGridView1.Rows[nr].Cells[2].Value = Convert.ToString(categ);
                    dataGridView1.Rows[nr].Cells[3].Value = Convert.ToString(tipoPollo);
                    dataGridView1.Rows[nr].Cells[4].Value = Convert.ToString(cantlotesdepollo);
                    dataGridView1.Rows[nr].Cells[5].Value = Convert.ToString(cantPollXlote);
                    dataGridView1.Rows[nr].Cells[6].Value = Convert.ToString(CostoXlote);
                }
            }
            c1.Cerrar_Leer();
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            c1.Abrir_Grabar(saveFileDialog1.FileName);
            do
            {
                codigo = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Introduzca Codigo multiplo de 1000"));
            }
            while (codigo % 1000 != 0);
            {
                nr = 1;
            }
            dataGridView1.Rows[0].Cells[0].Value = Convert.ToString(codigo + nr);
        }
    }
}
