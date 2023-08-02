using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Vector v1, v2, v3;

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.cargar(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
        }

        private void descargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox4.Text = v1.Descargar();
        }

        private void pregunta1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.Pregunt1(int.Parse(textBox1.Text),v2, ref v3);
            textBox5.Text = v1.Descargar();
        }

        private void descargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox5.Text = v2.Descargar();
        }

        private void descargarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            textBox6.Text = v3.Descargar();
        }

        private void pregunta2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.Pregunta2(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), ref v2, ref v3);
        }

        private void descenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.Descendente();
        }

        private void paresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.Pares();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            v1 = new Vector();
            v2 = new Vector();
            v3 = new Vector();

        }
    }
}
