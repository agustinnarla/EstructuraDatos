namespace EstructuraDatos
{
    partial class frmEstructuraDatos
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
            this.Menú = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosProgramadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estructuraLinealToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estructuraNoLinealToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menú.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menú
            // 
            this.Menú.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.estructuraLinealToolStripMenuItem,
            this.estructuraNoLinealToolStripMenuItem});
            this.Menú.Location = new System.Drawing.Point(0, 0);
            this.Menú.Name = "Menú";
            this.Menú.Size = new System.Drawing.Size(800, 24);
            this.Menú.TabIndex = 0;
            this.Menú.Text = "msMenu";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosProgramadorToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // datosProgramadorToolStripMenuItem
            // 
            this.datosProgramadorToolStripMenuItem.Name = "datosProgramadorToolStripMenuItem";
            this.datosProgramadorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.datosProgramadorToolStripMenuItem.Text = "Datos Programador ";
            this.datosProgramadorToolStripMenuItem.Click += new System.EventHandler(this.datosProgramadorToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir ";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // estructuraLinealToolStripMenuItem
            // 
            this.estructuraLinealToolStripMenuItem.Name = "estructuraLinealToolStripMenuItem";
            this.estructuraLinealToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.estructuraLinealToolStripMenuItem.Text = "Estructura Lineal";
            // 
            // estructuraNoLinealToolStripMenuItem
            // 
            this.estructuraNoLinealToolStripMenuItem.Name = "estructuraNoLinealToolStripMenuItem";
            this.estructuraNoLinealToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.estructuraNoLinealToolStripMenuItem.Text = "Estructura No Lineal";
            // 
            // frmEstructuraDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Menú);
            this.MainMenuStrip = this.Menú;
            this.Name = "frmEstructuraDatos";
            this.Text = "Estructura de Datos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Menú.ResumeLayout(false);
            this.Menú.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menú;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosProgramadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem estructuraLinealToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estructuraNoLinealToolStripMenuItem;
    }
}

