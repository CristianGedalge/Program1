using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;//agragamos por referancia el framework Visual Basic(solo debes hacer click en referencia ,y agregar el framework Visualbasic ),recien llamamos al framework

namespace Proy_Arch_Rdmc
{
    public partial class Form1 : Form
    {
        Prodcts pr1, pr2;
        int mult,nr;
        int codig;
        string descr;
        Double cantd, precio;
        Boolean esta;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pr1.Grabar(Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value),Convert.ToString(dataGridView1.Rows[0].Cells[1].Value),
                Convert.ToDouble(dataGridView1.Rows[0].Cells[2].Value),Convert.ToDouble(dataGridView1.Rows[0].Cells[3].Value),true);
        }

        private void accesarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pr1.Abrir_Leer(openFileDialog1.FileName);
            nr = -1;
            while (!pr1.Verif_fin())
            {
                pr1.Leer(ref codig, ref descr, ref cantd, ref precio,ref esta);
                if (esta == true)
                {
                    nr++;
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[0].Cells[0].Value = Convert.ToString(codig);
                    dataGridView1.Rows[0].Cells[1].Value = Convert.ToString(descr);
                    dataGridView1.Rows[0].Cells[2].Value = Convert.ToString(cantd);
                    dataGridView1.Rows[0].Cells[3].Value = Convert.ToString(precio);
                }
            }
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            pr1.Abrir_Grabar(saveFileDialog1.FileName);
            do
            {
                mult = int.Parse(Microsoft.VisualBasic.Interaction.InputBox(" Introduzca codigo multiplo de 1000 :"));
            }
            while(mult%1000==0);
            {
                nr = 1;
            }
            dataGridView1.Rows[0].Cells[0].Value = Convert.ToString(mult + nr);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pr1 = new Prodcts();
            pr2 = new Prodcts();
        }
    }
}
