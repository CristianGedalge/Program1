using System;//BYJCE
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JCE
{
    public partial class Form1 : Form
    {
        nent n1;
        vector v1;
        archivo a1, a2, a3;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            n1 = new nent();
            v1 = new vector();
            a1 = new archivo();
            a2 = new archivo();
            a3 = new archivo();
        }

       
 

        private void cARGARRNDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.cargar(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
        }
        private void cARGARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.uploadmanualjce(int.Parse(textBox1.Text));
        }
        private void dESCARGARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox4.Text = v1.descargar();
        }  
        private void gRABARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            v1.rec_a(saveFileDialog1.FileName);
        }
        private void aCCESARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            v1.acc_a(openFileDialog1.FileName);
        }
        private void eJERCICIO1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            saveFileDialog1.ShowDialog();
            a1.Ejer1(openFileDialog1.FileName, saveFileDialog1.FileName, a2);
        }
        private void eJERCICIO2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            saveFileDialog1.ShowDialog();
            a1.Ejer2(openFileDialog1.FileName, saveFileDialog1.FileName, a2);
        }
        private void eJERCICIO3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            saveFileDialog1.ShowDialog();
            a1.Ejer3(openFileDialog1.FileName, saveFileDialog1.FileName, a2);
        }
        private void eJERCICIO4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                openFileDialog2.ShowDialog();
                saveFileDialog1.ShowDialog();
                a1.Ejer4(openFileDialog1.FileName, openFileDialog2.FileName, saveFileDialog1.FileName, a2, a3);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
