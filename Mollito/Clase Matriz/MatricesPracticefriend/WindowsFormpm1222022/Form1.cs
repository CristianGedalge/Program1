using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormpm1222022
{
    public partial class Form1 : Form
    {//
        matriz m1, m2;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            m1 = new matriz();
            m2 = new matriz();
        }


        private void cARGARRANDOMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m1.cargar(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text));
            textBox5.Text = m1.descargar();
        }

        private void dESCARGARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = m1.descargar();
        }

        private void cARGARRANDOMToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            m2.cargar(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text));
            textBox6.Text = m2.descargar();
        }

        private void dESCARGARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox6.Text = m2.descargar();
        }


        //practico

        private void ejercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox6.Text = string.Concat(m1.ejercicio1());
        }

        private void ejercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox6.Text = string.Concat(m1.ejercicio2(int.Parse(textBox8.Text)));
        }

        private void ejercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox6.Text = string.Concat(m1.ejercicio3());
        }

        private void ejercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m1.ejercicio4(m2);
            textBox6.Text = m2.descargar();
        }

        private void ejercicio5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox8.Text = string.Concat(m1.ejercicio5());
        }

        private void ejercicio6ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            m1.ejercicio6();

        }

        private void ejercicio7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox6.Text = string.Concat(m1.ejercicio7());
        }

        private void ejercicio8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox6.Text = string.Concat(m1.ejercicio8(m2));
        }

        private void ejercicio9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m1.ejercicio9();
        }


        private void ejercicio10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m1.ejercicio10();
            textBox6.Text = m1.descargar();
        }



        //PRACTICO 2




        private void ejercicio1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            m1.ejercicio1_P2();
        }

        private void ejercicio2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            m1.ElemMayor_frec_filas();
        }

        private void ejercicio3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            m1.seg_par_impar_ordenado_todas_filas();
        
    }

        private void ejercicio4ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.m1.OrdenaFilaEnFuncAlElemLosRestSeMuevan(int.Parse(this.textBox8.Text));
        }

        private void ejercicio5ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox6.Text = string.Concat(m1.ejercicio5_P2());
  //          textBox8.Text = string.Concat(m1.ejercicio5());

        }

        private void ejercicio6ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            m1.Ejercicio1p2();
        }

        private void ejercicio7ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            m1.ejercicio2p2();
        }

        private void ejercicio8ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void ejercicio9ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ejercicio10ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }




    }//
}
