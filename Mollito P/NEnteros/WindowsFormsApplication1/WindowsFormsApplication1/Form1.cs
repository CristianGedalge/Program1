using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        NEnt n1, n2,n3,n4;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            n1 = new NEnt();
            n2 = new NEnt();
            n3 = new NEnt();
            n4 = new NEnt();
        }

        private void descargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = n1.Descargar()+"";
        }

        private void verifCapicuaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = n1.VerifCapic() + "";
        }

        private void perteneceFiboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = n1.VerifPerteFibo() + "";
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox5.Text = n1.factorial() + "";
        }

        private void verifTodIgualesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = n1.VerifEveryIguales() + "";
        }

        private void verifTodosParesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = n1.TodosPares() + "";
        }

        private void ordenarDigitosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n1.Ordenar();
        }

        public void Limpiar()
        {
            n1.Cargar(0);
            n2.Cargar(0);
            n3.Cargar(0);
            n4.Cargar(0);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

        }

        private void verifMultiploToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = n1.EsMultiplo(int.Parse(textBox2.Text))+"";
        }

        private void verifSubmultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = n1.VerificarSubMultiplo(int.Parse(textBox2.Text)) + "";
        }

        private void unirMenMayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n1.UnirMEnMAy(n2, n3);
        }

        private void menu2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cArgarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            n2.Cargar(int.Parse(textBox2.Text));
        }

        private void descargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox2.Text = n2.Descargar() + "";
        }

        private void descargarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            textBox3.Text = n3.Descargar() + "";
        }

        private void cargarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            
        }

        private void descargarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            textBox4.Text = n4.Descargar() + "";
        }

        private void cargarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            n3.Cargar(int.Parse(textBox3.Text));
        }

        private void numObjetMayorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n1.MAyorObjeto(n2, n3,ref n4);
        }

        private void selecParesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n1.Pares(n2);
        }

        private void selecPrimosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n1.Primos_Ordenados(ref n2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Limpiar(); 
        }

        private void unirMenInterMayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n1.UnirMenMEdMayor( ref n2, ref n3,ref n4);
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n1.Cargar(int.Parse(textBox1.Text));
        }
    }
}
