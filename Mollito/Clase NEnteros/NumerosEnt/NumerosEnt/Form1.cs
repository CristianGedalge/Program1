using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumerosEnt
{
    public partial class Form1 : Form
    {
        NEnt n1 ,n2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            n1 = new NEnt();
            n2 = new NEnt();
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n1.Cargar(int.Parse(textBox1.Text));
        }

        private void descargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Concat("" + n1.Descargar());
        }

        private void verificaParToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Concat(""+n1.VerifPar());
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            n1.Cargar(int.Parse(textBox1.Text), int.Parse(textBox3.Text));
        }

        private void verificarPrimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Concat("" + n1.VerifPrimo());
        }

        private void cargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            n2.Cargar(int.Parse(textBox3.Text));
        }

        private void descargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox2.Text = (n2.Descargar() + "");
        }

        private void acumuDigitosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.Text = (n2.AcumulDigitos() + "");
        }

        private void verificarMultiploToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.Text = (n1.multiplo(n2)+"");
        }
    }
}
