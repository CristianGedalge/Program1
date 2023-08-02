namespace ProyectoCoop
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accesarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seleccionarRegistrosPorCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seleccionarRegistrosPorTipoDePolloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HectDescan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HectNoProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seleccionarRegistrosXCodigosPrimosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seleeccionarRegistrosXInicialesDeLosNombresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button3.Location = new System.Drawing.Point(545, 348);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 31);
            this.button3.TabIndex = 9;
            this.button3.Text = "LIMPIAR CUADRO";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(346, 348);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 31);
            this.button2.TabIndex = 8;
            this.button2.Text = "TERMINAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(182, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "GRABAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.HectDescan,
            this.HectNoProduct});
            this.dataGridView1.Location = new System.Drawing.Point(69, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(896, 209);
            this.dataGridView1.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saToolStripMenuItem,
            this.operacionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1004, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saToolStripMenuItem
            // 
            this.saToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creacionToolStripMenuItem,
            this.accesarToolStripMenuItem});
            this.saToolStripMenuItem.Name = "saToolStripMenuItem";
            this.saToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.saToolStripMenuItem.Text = "Menu A1";
            // 
            // creacionToolStripMenuItem
            // 
            this.creacionToolStripMenuItem.Name = "creacionToolStripMenuItem";
            this.creacionToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.creacionToolStripMenuItem.Text = "CREAR";
            this.creacionToolStripMenuItem.Click += new System.EventHandler(this.creacionToolStripMenuItem_Click);
            // 
            // accesarToolStripMenuItem
            // 
            this.accesarToolStripMenuItem.Name = "accesarToolStripMenuItem";
            this.accesarToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.accesarToolStripMenuItem.Text = "Accesar";
            this.accesarToolStripMenuItem.Click += new System.EventHandler(this.accesarToolStripMenuItem_Click);
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seleccionarRegistrosPorCategoriaToolStripMenuItem,
            this.seleccionarRegistrosPorTipoDePolloToolStripMenuItem,
            this.toolStripMenuItem1,
            this.seleccionarRegistrosXCodigosPrimosToolStripMenuItem,
            this.seleeccionarRegistrosXInicialesDeLosNombresToolStripMenuItem});
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.operacionesToolStripMenuItem.Text = "OPERACIONES";
            this.operacionesToolStripMenuItem.Click += new System.EventHandler(this.operacionesToolStripMenuItem_Click);
            // 
            // seleccionarRegistrosPorCategoriaToolStripMenuItem
            // 
            this.seleccionarRegistrosPorCategoriaToolStripMenuItem.Name = "seleccionarRegistrosPorCategoriaToolStripMenuItem";
            this.seleccionarRegistrosPorCategoriaToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.seleccionarRegistrosPorCategoriaToolStripMenuItem.Text = "Seleccionar Registros X Categoria";
            this.seleccionarRegistrosPorCategoriaToolStripMenuItem.Click += new System.EventHandler(this.seleccionarRegistrosPorCategoriaToolStripMenuItem_Click);
            // 
            // seleccionarRegistrosPorTipoDePolloToolStripMenuItem
            // 
            this.seleccionarRegistrosPorTipoDePolloToolStripMenuItem.Name = "seleccionarRegistrosPorTipoDePolloToolStripMenuItem";
            this.seleccionarRegistrosPorTipoDePolloToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.seleccionarRegistrosPorTipoDePolloToolStripMenuItem.Text = "Seleccionar Registros X Tipo de Pollo";
            this.seleccionarRegistrosPorTipoDePolloToolStripMenuItem.Click += new System.EventHandler(this.seleccionarRegistrosPorTipoDePolloToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(267, 22);
            this.toolStripMenuItem1.Text = "Seleccionar Registros Codigos Pares ";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(693, 349);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 32);
            this.button5.TabIndex = 12;
            this.button5.Text = "SALIR";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "PROYECTO COOPERATIVA POLLOS";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Categoria";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tipo de Pollo";
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "CantidadLotes";
            this.Column5.Name = "Column5";
            // 
            // HectDescan
            // 
            this.HectDescan.HeaderText = "Cantidad Pollos por Lote";
            this.HectDescan.Name = "HectDescan";
            this.HectDescan.Width = 200;
            // 
            // HectNoProduct
            // 
            this.HectNoProduct.HeaderText = "Costo Lote";
            this.HectNoProduct.Name = "HectNoProduct";
            // 
            // seleccionarRegistrosXCodigosPrimosToolStripMenuItem
            // 
            this.seleccionarRegistrosXCodigosPrimosToolStripMenuItem.Name = "seleccionarRegistrosXCodigosPrimosToolStripMenuItem";
            this.seleccionarRegistrosXCodigosPrimosToolStripMenuItem.Size = new System.Drawing.Size(282, 22);
            this.seleccionarRegistrosXCodigosPrimosToolStripMenuItem.Text = "Seleccionar Registros X Codigos Primos";
            this.seleccionarRegistrosXCodigosPrimosToolStripMenuItem.Click += new System.EventHandler(this.seleccionarRegistrosXCodigosPrimosToolStripMenuItem_Click);
            // 
            // seleeccionarRegistrosXInicialesDeLosNombresToolStripMenuItem
            // 
            this.seleeccionarRegistrosXInicialesDeLosNombresToolStripMenuItem.Name = "seleeccionarRegistrosXInicialesDeLosNombresToolStripMenuItem";
            this.seleeccionarRegistrosXInicialesDeLosNombresToolStripMenuItem.Size = new System.Drawing.Size(330, 22);
            this.seleeccionarRegistrosXInicialesDeLosNombresToolStripMenuItem.Text = "Seleeccionar Registros X Iniciales de los nombres";
            this.seleeccionarRegistrosXInicialesDeLosNombresToolStripMenuItem.Click += new System.EventHandler(this.seleeccionarRegistrosXInicialesDeLosNombresToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1004, 431);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accesarToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seleccionarRegistrosPorCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seleccionarRegistrosPorTipoDePolloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn HectDescan;
        private System.Windows.Forms.DataGridViewTextBoxColumn HectNoProduct;
        private System.Windows.Forms.ToolStripMenuItem seleccionarRegistrosXCodigosPrimosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seleeccionarRegistrosXInicialesDeLosNombresToolStripMenuItem;
    }
}

