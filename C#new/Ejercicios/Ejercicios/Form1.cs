using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios
{
    public partial class Form1 : Form
    {
        Matrices m1, m2;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m1.Cargar(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text));
        }

        private void descargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = m1.Descargar();
        }

        private void ordenamientoExamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m1.OrdenarRaro();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            m1 = new Matrices();
            m2 = new Matrices();


        }
    }
}
