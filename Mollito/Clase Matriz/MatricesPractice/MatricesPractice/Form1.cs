using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatricesPractice
{
    public partial class Form1 : Form
    {
        Matrix m1, m2, m3;
        public Form1()
        {
            InitializeComponent();
        }

        private void descargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = m1.Descargar();
        }

        private void ejercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox7.Text = m1.Pract1_Ejrc1();
        }

        private void ejercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox7.Text = m1.Pract1_Ejrc2(int.Parse(textBox8.Text)) + "";
        }

        private void ejercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox7.Text = m1.Pract1_Ejrc3() + "";
        }

        private void ejercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m1.Pract1_Ejerc4();
        }

        private void ejercicio5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox7.Text = m1.Pract1_Ejerc5()+"";
        }

        private void ejercicio6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m1.Pract1_Ejerc6();
        }

        private void ejercicio7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox7.Text = m1.Pract1_Ejerc7()+"";
        }

        private void ejercicio8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox7.Text = m1.Pract1_Ejerc8(ref m3)+"";
        }

        private void m2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            m3.Cargar(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text));
        }

        private void descargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox6.Text= m3.Descargar();
        }

        private void ejercicio9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m1.Pract1_Ejerc9();
        }

        private void ejercicio10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m1.Pract1_Ejerc10();
        }

        private void cargarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            m2.Cargar(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text));
        }

        private void descargarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            textBox6.Text = m2.Descargar();
        }

        private void ejercicio1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            m2.Pract2_Ejerc1();
        }

        private void ejercicio3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            m2.Pract2_Ejerc3();
        }

        private void ejercicio2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            m2.Pract2_Ejerc2();
        }

        private void ejercicio4ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox9.Text) <= int.Parse(textBox1.Text))
                m2.Pract2_Ejerc4(int.Parse(textBox9.Text));
            else
                MessageBox.Show("El número de filas excede al numero de filas de la Matriz");
        }

        private void ejercicio6ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            m2.Pract2_Ejerc6();
        }

        private void ejercicio7ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            m2.Pract2_Ejerc7();
        }

        private void ejercicio5ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox7.Text = m2.Pract2_Ejerc5() + "";
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m1.Cargar(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text));

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            m1 = new Matrix();
            m2 = new Matrix();
            m3 = new Matrix();

        }
    }
}
