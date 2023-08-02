using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrices
{
    public partial class Form1 : Form
    {
        Matriz m1,m2,m3;
        Vector v1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            m1 = new Matriz();
            m2 = new Matriz();
            m3 = new Matriz();
            v1 = new Vector();



        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m1.Cargar(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text));
        }

        private void descargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = m1.Descargar();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            m1.CargarxColums(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text));

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            m1.CargarXFilas(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text));
        }

        private void cargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            m2.Cargar(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text));
        }

        private void cargarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            m3.Cargar(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text));
        }

        private void descargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox6.Text = m2.Descargar();
        }

        private void descargarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            textBox7.Text = m3.Descargar();
        }

        private void cargarXColumsRevezToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m1.CargarXcolumnadeReves(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text));
        }

        private void ordeXColumnasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m2.OrdenarXColumnas();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            m2.OrdeXFilas();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            m2.OrdFilasXEledeNumpares();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            m2.OrdenarParImpar();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            m2.OrdXfilasParsImprs(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text));
        }

        private void intercalarParImparToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m2.Intercalar_Par_Impar();
        }

        private void ordeXfrecuenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m2.OrdXFrecuenciadeMayAMenor();
        }

        private void cargar1x1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.Cargar1x1(int.Parse(textBox1.Text));
        }

        private void descaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text=v1.Descar();
        }

        private void ordeXFrecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.OrdxFrec();
        }

        private void frecuenciaofElemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text=m2.fre(int.Parse(textBox1.Text))+"";
        }

        private void fEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m2.OrdFilXEleCol(int.Parse(textBox1.Text));
        }

        private void sumarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int f1= 0, c1=0, f2=0, c2=0;
 
            m1.RetDim(ref f1, ref c1);
            m2.RetDim(ref f2, ref c2);
            if ((f1==f2) && (c1==c2))         
                m1.Sumar(ref m2, ref m3);
            else
                textBox7.Text="GAME OVER!!!!!";
            
        }

        private void multiplicarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int f1 = 0, c1 = 0, f2 = 0, c2 = 0;

            m1.RetDim(ref f1, ref c1);
            m2.RetDim(ref f2, ref c2);
            if  (c1 == f2)
                m1.Multiplicar(ref m2, ref m3);
            else
                textBox7.Text = "GAME OVER!!!!";
        }
    }
}
