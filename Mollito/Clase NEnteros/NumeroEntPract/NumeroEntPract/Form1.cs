using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumeroEntPract
{
    public partial class Form1 : Form
    {
        NEnt n1;

        public Form1()
        {
           

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            n1 = new NEnt();

        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n1.Cargar(int.Parse(EntrdaN1.Text));
        }

        private void descargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox3.Text = string.Concat("" + n1.Descargar());
        }

        private void EntradaN2_TextChanged(object sender, EventArgs e)
        {

        }

        private void verificarParToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox3.Text = string.Concat("" + n1.VerifPar());
        }

        private void verificarMultiploToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox3.Text = string.Concat(""+n1.EsMultiplo(int.Parse(EntradaN2.Text)));
         
        }

        private void verificarPrimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox3.Text = string.Concat("" + n1.VerifPrimo());
        }

        private void verifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox3.Text = string.Concat("" + n1.VerificarCapicua());
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox3.Text = string.Concat(n1.VerificarSubMultiplo(int.Parse(EntradaN2.Text)));
        }

        private void verificarFiboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox3.Text =(n1.VerificarFibo()+"");
        }

        private void factorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox3.Text = string.Concat("" + n1.Factorial());
        }

        private void verificarOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox3.Text = string.Concat("" + n1.verificarorden());
        }
    }
}
