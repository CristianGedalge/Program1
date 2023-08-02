using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repechaje
{
    public partial class Form1 : Form
    {
        Matrix m1, m2;
        Vector v1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            m1 = new Matrix();
            m2 = new Matrix();
            v1 = new Vector();
        }

        private void descarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text=m1.desc();
        }

        private void p1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m1.p1(int.Parse(textBox4.Text));
        }

        private void p2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m1.p2(int.Parse(textBox7.Text), int.Parse(textBox8.Text), int.Parse(textBox9.Text), int.Parse(textBox10.Text));
        }

        private void cargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            v1.Cargar1x1(int.Parse(textBox1.Text));
        }

        private void descargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = v1.descargar();
        }

        private void mayfrecuenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.may_frec();
        }

        private void ordXfrecuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.OrdXfrecuencia();
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m1.Cargar(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text));
        }
    }
}
