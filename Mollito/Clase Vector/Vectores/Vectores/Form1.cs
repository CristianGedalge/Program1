using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vectores
{
    public partial class Form1 : Form
    {
        Vector v1,v2,v3;
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

        private void cargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            v1.Cargar(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));

        }

        private void descargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox4.Text = v1.Descargar();
        }

        private void sumarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = (v1.suma()+"");
        }

        private void mediaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = (v1.media() + "");
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v2.Cargar(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
        }

    
    

        private void cargarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            v3.Cargar(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
        }

        private void descargarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            textBox4.Text = v3.Descargar() + "";
        }

        private void ordXConteoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v3.OrdCont(ref v2);
        }

        private void descargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = v2.Descargar(); 
        }

        private void maximoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = v1.maximo() + "";
        }

        private void minimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = v1.minimo() + "";
        }

        private void seleccionarPrimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.SelecPrimo(ref v2);
        }

        private void menuV1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void busquedaSecuencialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = v2.BusqSecuencial(int.Parse(textBox1.Text))+ "";
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox5.Text = v2.BusqSecuencial1(int.Parse(textBox1.Text)) + "";
        }

        private void busquedaSecuencial2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = v2.BusqSecuencial2(int.Parse(textBox1.Text)) + "";
        }

        private void busqDeUnPrimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = v2.BusqSecuencialPrim() + "";
        }

        private void verifOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = v2.VerifOrden() + "";
        }

        private void desvMediaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = v1.desvmedia() + "";
        }

        private void contPrimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = v1.contadorprimos() + "";
        }

        private void invertirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.Invertir();
        }

      

     

        private void ordXSeleccToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v3.OrdenaXselecc();
        }

        private void ordInterDescToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v3.OrdenaXInterc1();
        }

        private void nElemDifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = v3.NElem() + "";
        }

        private void purgarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v3.Purgar(ref v2);
        }

        private void frecuenciaDeDistribToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.FrecDistr(ref v2, ref v3);
        }

        private void ordInserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v3.OrdXInser(ref v2);

        }

        private void ordInser2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v3.OrdXInser2();
        }

        private void ordBurbujaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v3.OrdBurbuja();
        }

        private void segmentarParImparToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v3.ParImpar();
        }


        private void busquedaBinariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = v3.BusquedaBinaria(int.Parse(textBox1.Text)) + "";
        }

        private void segmentarPriNpriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v3.SegPrimYnoPrimos();
        }

        private void frecuenciaDeDistrib1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.FrecueDistri1(ref v2, ref v3,int.Parse(textBox3.Text));
        }

        private void mayNumenEnPosicionMultiploToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = v1.MayorElPosi(int.Parse(textBox6.Text))+ "";
        }

        private void ordInterAscToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v3.OrdenaXInterc();
        }
    }
}
