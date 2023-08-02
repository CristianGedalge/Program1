namespace Proyecto_Archivitos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cargarRandomicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarRdmcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargar1x1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descargarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grabarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accesarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejercicio1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejercicio2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejercicio3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejercicio4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(57, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(205, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(345, 54);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(25, 93);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(456, 39);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(25, 152);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(456, 47);
            this.textBox5.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarRandomicoToolStripMenuItem,
            this.vectorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(514, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // cargarRandomicoToolStripMenuItem
            // 
            this.cargarRandomicoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarRdmcToolStripMenuItem,
            this.cargar1x1ToolStripMenuItem,
            this.descargarToolStripMenuItem,
            this.grabarToolStripMenuItem,
            this.accesarToolStripMenuItem});
            this.cargarRandomicoToolStripMenuItem.Name = "cargarRandomicoToolStripMenuItem";
            this.cargarRandomicoToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.cargarRandomicoToolStripMenuItem.Text = "Menu";
            // 
            // cargarRdmcToolStripMenuItem
            // 
            this.cargarRdmcToolStripMenuItem.Name = "cargarRdmcToolStripMenuItem";
            this.cargarRdmcToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cargarRdmcToolStripMenuItem.Text = "CargarRdmc";
            this.cargarRdmcToolStripMenuItem.Click += new System.EventHandler(this.cargarRdmcToolStripMenuItem_Click);
            // 
            // cargar1x1ToolStripMenuItem
            // 
            this.cargar1x1ToolStripMenuItem.Name = "cargar1x1ToolStripMenuItem";
            this.cargar1x1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cargar1x1ToolStripMenuItem.Text = "Cargar1x1";
            this.cargar1x1ToolStripMenuItem.Click += new System.EventHandler(this.cargar1x1ToolStripMenuItem_Click);
            // 
            // descargarToolStripMenuItem
            // 
            this.descargarToolStripMenuItem.Name = "descargarToolStripMenuItem";
            this.descargarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.descargarToolStripMenuItem.Text = "Descargar";
            this.descargarToolStripMenuItem.Click += new System.EventHandler(this.descargarToolStripMenuItem_Click);
            // 
            // grabarToolStripMenuItem
            // 
            this.grabarToolStripMenuItem.Name = "grabarToolStripMenuItem";
            this.grabarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.grabarToolStripMenuItem.Text = "Grabar";
            this.grabarToolStripMenuItem.Click += new System.EventHandler(this.grabarToolStripMenuItem_Click);
            // 
            // accesarToolStripMenuItem
            // 
            this.accesarToolStripMenuItem.Name = "accesarToolStripMenuItem";
            this.accesarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.accesarToolStripMenuItem.Text = "Accesar";
            this.accesarToolStripMenuItem.Click += new System.EventHandler(this.accesarToolStripMenuItem_Click);
            // 
            // vectorToolStripMenuItem
            // 
            this.vectorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejercicio1ToolStripMenuItem,
            this.ejercicio2ToolStripMenuItem,
            this.ejercicio3ToolStripMenuItem,
            this.ejercicio4ToolStripMenuItem});
            this.vectorToolStripMenuItem.Name = "vectorToolStripMenuItem";
            this.vectorToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.vectorToolStripMenuItem.Text = "Vector";
            // 
            // ejercicio1ToolStripMenuItem
            // 
            this.ejercicio1ToolStripMenuItem.Name = "ejercicio1ToolStripMenuItem";
            this.ejercicio1ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.ejercicio1ToolStripMenuItem.Text = "Ejercicio1";
            this.ejercicio1ToolStripMenuItem.Click += new System.EventHandler(this.ejercicio1ToolStripMenuItem_Click);
            // 
            // ejercicio2ToolStripMenuItem
            // 
            this.ejercicio2ToolStripMenuItem.Name = "ejercicio2ToolStripMenuItem";
            this.ejercicio2ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.ejercicio2ToolStripMenuItem.Text = "Ejercicio2";
            this.ejercicio2ToolStripMenuItem.Click += new System.EventHandler(this.ejercicio2ToolStripMenuItem_Click);
            // 
            // ejercicio3ToolStripMenuItem
            // 
            this.ejercicio3ToolStripMenuItem.Name = "ejercicio3ToolStripMenuItem";
            this.ejercicio3ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.ejercicio3ToolStripMenuItem.Text = "Ejercicio3";
            this.ejercicio3ToolStripMenuItem.Click += new System.EventHandler(this.ejercicio3ToolStripMenuItem_Click);
            // 
            // ejercicio4ToolStripMenuItem
            // 
            this.ejercicio4ToolStripMenuItem.Name = "ejercicio4ToolStripMenuItem";
            this.ejercicio4ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.ejercicio4ToolStripMenuItem.Text = "Ejercicio4";
            this.ejercicio4ToolStripMenuItem.Click += new System.EventHandler(this.ejercicio4ToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(25, 218);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(456, 45);
            this.textBox6.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Longitud";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(221, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Rango A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(367, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Rango B";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 270);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem cargarRandomicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarRdmcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargar1x1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descargarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grabarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accesarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejercicio1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejercicio2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejercicio3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejercicio4ToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

