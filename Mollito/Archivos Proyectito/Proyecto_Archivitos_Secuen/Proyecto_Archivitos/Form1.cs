using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Archivitos
{
    public partial class Form1 : Form
    {
        Proyecto_Archivos.Vector v1, v2;
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cargarRdmcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.Cargar(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
        }

        private void descargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox4.Text = v1.Descargar();
        }

        private void cargar1x1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.Cargar1x1(int.Parse (textBox1.Text));
        }

        private void grabarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            v1.Grabar(saveFileDialog1.FileName);
        }

        private void accesarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            v1.Accesar(openFileDialog1.FileName);
            textBox4.Text = v1.Descargar();
        }

        private void ejercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            v1.Accesar(openFileDialog1.FileName);
            v1.Ejerc_1();
            saveFileDialog1.ShowDialog();
            v1.Grabar(saveFileDialog1.FileName);
        }

        private void ejercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            v1.Accesar(openFileDialog1.FileName);
            v1.Ejerc_2();
            saveFileDialog1.ShowDialog();
            v1.Grabar(saveFileDialog1.FileName);

        }

        private void ejercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            v1.Accesar(openFileDialog1.FileName);
            v1.Ejerc_3();
            saveFileDialog1.ShowDialog();
            v1.Grabar(saveFileDialog1.FileName);
        }

        private void ejercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            v1.Accesar(openFileDialog1.FileName);
            openFileDialog1.ShowDialog();
            v2.Accesar(openFileDialog1.FileName);
            v1.Ejerc_4(ref v2);
            saveFileDialog1.ShowDialog();
            v1.Grabar(saveFileDialog1.FileName);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            v1 = new Proyecto_Archivos.Vector();
            v2 = new Proyecto_Archivos.Vector();
        }
    }
}
