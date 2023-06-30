namespace EstructuraDatos.Formularios
{
    partial class frmBaseDatos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grlDatos = new System.Windows.Forms.DataGridView();
            this.cmdProyeccionSimple = new System.Windows.Forms.Button();
            this.mrcOperacionesProyeccion = new System.Windows.Forms.GroupBox();
            this.cmdJuntar = new System.Windows.Forms.Button();
            this.cmdPrroyeccionMultiatributo = new System.Windows.Forms.Button();
            this.mrcOperacionesSeleccion = new System.Windows.Forms.GroupBox();
            this.cmdSeleccionConvolucion = new System.Windows.Forms.Button();
            this.cmdSeleccionMultiples = new System.Windows.Forms.Button();
            this.cmdSeleccionSimple = new System.Windows.Forms.Button();
            this.mrcOperacionesAlgebraicas = new System.Windows.Forms.GroupBox();
            this.cmdDiferencia = new System.Windows.Forms.Button();
            this.cmdInterseccion = new System.Windows.Forms.Button();
            this.cmdUnion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grlDatos)).BeginInit();
            this.mrcOperacionesProyeccion.SuspendLayout();
            this.mrcOperacionesSeleccion.SuspendLayout();
            this.mrcOperacionesAlgebraicas.SuspendLayout();
            this.SuspendLayout();
            // 
            // grlDatos
            // 
            this.grlDatos.AllowUserToAddRows = false;
            this.grlDatos.AllowUserToDeleteRows = false;
            this.grlDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grlDatos.Location = new System.Drawing.Point(18, 25);
            this.grlDatos.Name = "grlDatos";
            this.grlDatos.ReadOnly = true;
            this.grlDatos.Size = new System.Drawing.Size(770, 327);
            this.grlDatos.TabIndex = 0;
            // 
            // cmdProyeccionSimple
            // 
            this.cmdProyeccionSimple.Location = new System.Drawing.Point(24, 33);
            this.cmdProyeccionSimple.Name = "cmdProyeccionSimple";
            this.cmdProyeccionSimple.Size = new System.Drawing.Size(146, 27);
            this.cmdProyeccionSimple.TabIndex = 1;
            this.cmdProyeccionSimple.Text = "Proyecciòn Simple";
            this.cmdProyeccionSimple.UseVisualStyleBackColor = true;
            this.cmdProyeccionSimple.Click += new System.EventHandler(this.cmdProyeccionSimple_Click);
            // 
            // mrcOperacionesProyeccion
            // 
            this.mrcOperacionesProyeccion.Controls.Add(this.cmdJuntar);
            this.mrcOperacionesProyeccion.Controls.Add(this.cmdPrroyeccionMultiatributo);
            this.mrcOperacionesProyeccion.Controls.Add(this.cmdProyeccionSimple);
            this.mrcOperacionesProyeccion.Location = new System.Drawing.Point(33, 365);
            this.mrcOperacionesProyeccion.Name = "mrcOperacionesProyeccion";
            this.mrcOperacionesProyeccion.Size = new System.Drawing.Size(196, 141);
            this.mrcOperacionesProyeccion.TabIndex = 2;
            this.mrcOperacionesProyeccion.TabStop = false;
            this.mrcOperacionesProyeccion.Text = "Operaciones de Proyecciòn";
            // 
            // cmdJuntar
            // 
            this.cmdJuntar.Location = new System.Drawing.Point(24, 99);
            this.cmdJuntar.Name = "cmdJuntar";
            this.cmdJuntar.Size = new System.Drawing.Size(146, 27);
            this.cmdJuntar.TabIndex = 1;
            this.cmdJuntar.Text = "Juntar";
            this.cmdJuntar.UseVisualStyleBackColor = true;
            this.cmdJuntar.Click += new System.EventHandler(this.cmdJuntar_Click);
            // 
            // cmdPrroyeccionMultiatributo
            // 
            this.cmdPrroyeccionMultiatributo.Location = new System.Drawing.Point(24, 67);
            this.cmdPrroyeccionMultiatributo.Name = "cmdPrroyeccionMultiatributo";
            this.cmdPrroyeccionMultiatributo.Size = new System.Drawing.Size(146, 27);
            this.cmdPrroyeccionMultiatributo.TabIndex = 1;
            this.cmdPrroyeccionMultiatributo.Text = "Proyecciòn Multiatributo";
            this.cmdPrroyeccionMultiatributo.UseVisualStyleBackColor = true;
            this.cmdPrroyeccionMultiatributo.Click += new System.EventHandler(this.cmdPrroyeccionMultiatributo_Click);
            // 
            // mrcOperacionesSeleccion
            // 
            this.mrcOperacionesSeleccion.Controls.Add(this.cmdSeleccionConvolucion);
            this.mrcOperacionesSeleccion.Controls.Add(this.cmdSeleccionMultiples);
            this.mrcOperacionesSeleccion.Controls.Add(this.cmdSeleccionSimple);
            this.mrcOperacionesSeleccion.Location = new System.Drawing.Point(297, 365);
            this.mrcOperacionesSeleccion.Name = "mrcOperacionesSeleccion";
            this.mrcOperacionesSeleccion.Size = new System.Drawing.Size(205, 141);
            this.mrcOperacionesSeleccion.TabIndex = 3;
            this.mrcOperacionesSeleccion.TabStop = false;
            this.mrcOperacionesSeleccion.Text = "Operaciones de Selecciòn";
            // 
            // cmdSeleccionConvolucion
            // 
            this.cmdSeleccionConvolucion.Location = new System.Drawing.Point(17, 100);
            this.cmdSeleccionConvolucion.Name = "cmdSeleccionConvolucion";
            this.cmdSeleccionConvolucion.Size = new System.Drawing.Size(173, 27);
            this.cmdSeleccionConvolucion.TabIndex = 4;
            this.cmdSeleccionConvolucion.Text = "Selecciòn por Convoluciòn";
            this.cmdSeleccionConvolucion.UseVisualStyleBackColor = true;
            this.cmdSeleccionConvolucion.Click += new System.EventHandler(this.cmdSeleccionConvolucion_Click);
            // 
            // cmdSeleccionMultiples
            // 
            this.cmdSeleccionMultiples.Location = new System.Drawing.Point(17, 67);
            this.cmdSeleccionMultiples.Name = "cmdSeleccionMultiples";
            this.cmdSeleccionMultiples.Size = new System.Drawing.Size(173, 27);
            this.cmdSeleccionMultiples.TabIndex = 3;
            this.cmdSeleccionMultiples.Text = "Selecciòn Multiatributo";
            this.cmdSeleccionMultiples.UseVisualStyleBackColor = true;
            this.cmdSeleccionMultiples.Click += new System.EventHandler(this.cmdSeleccionMultiples_Click);
            // 
            // cmdSeleccionSimple
            // 
            this.cmdSeleccionSimple.Location = new System.Drawing.Point(17, 34);
            this.cmdSeleccionSimple.Name = "cmdSeleccionSimple";
            this.cmdSeleccionSimple.Size = new System.Drawing.Size(173, 27);
            this.cmdSeleccionSimple.TabIndex = 2;
            this.cmdSeleccionSimple.Text = "Selecciòn Simple";
            this.cmdSeleccionSimple.UseVisualStyleBackColor = true;
            this.cmdSeleccionSimple.Click += new System.EventHandler(this.cmdSeleccionSimple_Click);
            // 
            // mrcOperacionesAlgebraicas
            // 
            this.mrcOperacionesAlgebraicas.Controls.Add(this.cmdDiferencia);
            this.mrcOperacionesAlgebraicas.Controls.Add(this.cmdInterseccion);
            this.mrcOperacionesAlgebraicas.Controls.Add(this.cmdUnion);
            this.mrcOperacionesAlgebraicas.Location = new System.Drawing.Point(570, 365);
            this.mrcOperacionesAlgebraicas.Name = "mrcOperacionesAlgebraicas";
            this.mrcOperacionesAlgebraicas.Size = new System.Drawing.Size(196, 141);
            this.mrcOperacionesAlgebraicas.TabIndex = 3;
            this.mrcOperacionesAlgebraicas.TabStop = false;
            this.mrcOperacionesAlgebraicas.Text = "Operaciones Algebraicas";
            // 
            // cmdDiferencia
            // 
            this.cmdDiferencia.Location = new System.Drawing.Point(17, 99);
            this.cmdDiferencia.Name = "cmdDiferencia";
            this.cmdDiferencia.Size = new System.Drawing.Size(164, 27);
            this.cmdDiferencia.TabIndex = 7;
            this.cmdDiferencia.Text = "Diferencia";
            this.cmdDiferencia.UseVisualStyleBackColor = true;
            this.cmdDiferencia.Click += new System.EventHandler(this.cmdDiferencia_Click);
            // 
            // cmdInterseccion
            // 
            this.cmdInterseccion.Location = new System.Drawing.Point(17, 67);
            this.cmdInterseccion.Name = "cmdInterseccion";
            this.cmdInterseccion.Size = new System.Drawing.Size(164, 27);
            this.cmdInterseccion.TabIndex = 6;
            this.cmdInterseccion.Text = "Intersecciòn";
            this.cmdInterseccion.UseVisualStyleBackColor = true;
            this.cmdInterseccion.Click += new System.EventHandler(this.cmdInterseccion_Click);
            // 
            // cmdUnion
            // 
            this.cmdUnion.Location = new System.Drawing.Point(17, 33);
            this.cmdUnion.Name = "cmdUnion";
            this.cmdUnion.Size = new System.Drawing.Size(164, 27);
            this.cmdUnion.TabIndex = 5;
            this.cmdUnion.Text = "Uniòn";
            this.cmdUnion.UseVisualStyleBackColor = true;
            this.cmdUnion.Click += new System.EventHandler(this.cmdUnion_Click);
            // 
            // frmBaseDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.mrcOperacionesAlgebraicas);
            this.Controls.Add(this.mrcOperacionesSeleccion);
            this.Controls.Add(this.mrcOperacionesProyeccion);
            this.Controls.Add(this.grlDatos);
            this.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F);
            this.Name = "frmBaseDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base de Datos";
            this.Load += new System.EventHandler(this.frmBaseDatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grlDatos)).EndInit();
            this.mrcOperacionesProyeccion.ResumeLayout(false);
            this.mrcOperacionesSeleccion.ResumeLayout(false);
            this.mrcOperacionesAlgebraicas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grlDatos;
        private System.Windows.Forms.Button cmdProyeccionSimple;
        private System.Windows.Forms.GroupBox mrcOperacionesProyeccion;
        private System.Windows.Forms.Button cmdJuntar;
        private System.Windows.Forms.Button cmdPrroyeccionMultiatributo;
        private System.Windows.Forms.GroupBox mrcOperacionesSeleccion;
        private System.Windows.Forms.Button cmdSeleccionMultiples;
        private System.Windows.Forms.Button cmdSeleccionSimple;
        private System.Windows.Forms.GroupBox mrcOperacionesAlgebraicas;
        private System.Windows.Forms.Button cmdSeleccionConvolucion;
        private System.Windows.Forms.Button cmdDiferencia;
        private System.Windows.Forms.Button cmdInterseccion;
        private System.Windows.Forms.Button cmdUnion;
    }
}