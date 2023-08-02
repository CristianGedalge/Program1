using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vectores_Practico_1
{
    public partial class Form1 : Form
    {
        Vector objv1, objv2,objv3,objv4;
        public Form1()
        {
            InitializeComponent();
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objv1.Cargar(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
        }

        private void descargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox4.Text = objv1.Descargar();
        }

        private void ejercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objv1.Ejercicio1Pr1(int.Parse(textBox7.Text), int.Parse(textBox8.Text));
        }

        private void ejercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = objv1.Ejercicio2Pr1() + "";
        }

        private void ejercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = objv1.Ejercicio3Pr1() + "";
        }

        private void ejercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = objv1.ejer4(int.Parse(textBox9.Text), int.Parse(textBox10.Text)) + "";
        }

        private void ejercicio5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objv1.Ejercicio5Pr1(ref objv3,ref objv4);
            label10.Text = "Primo";
            textBox5.Text = objv3.Descargar();
            label11.Text = "No Primo";
            textBox6.Text = objv4.Descargar();
        }

        private void cargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            objv2.Cargar(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
        }

        private void cargarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            objv3.Cargar(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
        }

        private void descargarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            textBox5.Text = objv3.Descargar();
        }

        private void ejercicio6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objv1.Ejercicio6Pr1(int.Parse(textBox11.Text), int.Parse(textBox12.Text));
            textBox5.Text = objv1.Descargar();
            label10.Text = "";
            label11.Text = "";
            textBox6.Text = "";
        }

        private void ejercicio7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = objv1.Ejercicio7Pr1() + "";
        }

        private void ejercicio8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objv1.Ejercicio8Pr1(ref objv3, ref objv4);
            label11.Text = "Intersec";
            textBox6.Text = objv4.Descargar();

        }

        private void ejercicio10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = objv1.Ejercicio10Pr1(int.Parse(textBox11.Text),int.Parse(textBox12.Text))+"";
            label11.Text = "";
            textBox6.Text = "";
        }

        private void ejercicio9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objv1.Ejercicio9Pr1(objv3, ref objv4);
            label11.Text = "Union";
            textBox6.Text = objv4.Descargar();
        }

        private void ejercicio2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            objv2.Ejercicio2Pr2(int.Parse(textBox13.Text));
            textBox5.Text = objv2.Descargar();
        }
        

        private void ejercicio3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //objv2.OrdAscdt();
            //textBox6.Text = objv2.Descargar();
            objv2.Ejercicio3Pr2();
            textBox5.Text = objv2.Descargar();
        }

        private void ejercicio4ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox5.Text = objv2.Ejercicio4Pr2(int.Parse(textBox11.Text),int.Parse(textBox12.Text) )+ "";
        }

        private void ejercicio5ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            objv2.Ejercicio5Pr2(int.Parse(textBox11.Text), int.Parse(textBox12.Text), objv3, ref objv4);
            label10.Text = "Elem";
            label11.Text = "Frec";
            textBox5.Text = objv3.Descargar();
            textBox6.Text = objv4.Descargar();

        }

        private void ejercicio7ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            objv2.Ejercicio7Pr2(ref objv3, ref objv4);
            label10.Text = "Elem Fibo";
            label11.Text = "Frec";

            textBox5.Text = objv3.Descargar();
            textBox6.Text = objv4.Descargar();
        }

        private void descargarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            textBox6.Text = objv4.Descargar();
        }

        private void vector2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ejercicio8ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            objv2.Ejercicio8Pr2(int.Parse(textBox11.Text), int.Parse(textBox12.Text));
            textBox5.Text = objv2.Descargar();
            label10.Text = "";
            label11.Text = "";
            textBox6.Text = "";
        }

        private void ejercicio9ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            objv2.Ejercicio9Pr2();
            textBox5.Text = objv2.Descargar();
           
        }

        private void ejercicio1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            objv2.Ejercicio1Pr2();
            textBox5.Text = objv2.Descargar(); 
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void ejercicio6ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            objv2.Ejercicio6Pr2(int.Parse(textBox11.Text), int.Parse(textBox12.Text), ref objv3, ref objv4);
            label10.Text = "Elem";
            label11.Text = "Frec";
            textBox5.Text = objv3.Descargar();
            textBox6.Text = objv4.Descargar();
        }

        private void ejercicio10ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            objv2.Ejercicio10Pr2(int.Parse(textBox11.Text), int.Parse(textBox12.Text));
            textBox5.Text = objv2.Descargar();
        }

        private void cargarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            objv4.Cargar(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
        }

        private void descargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox4.Text = objv2.Descargar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            objv1 = new Vector();
            objv2 = new Vector();
            objv3 = new Vector();
            objv4 = new Vector();

        }
    }
}
