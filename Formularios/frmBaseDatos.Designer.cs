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
            this.mrcOperacionesSeleccion = new System.Windows.Forms.GroupBox();
            this.cmdPrroyeccionMultiatributo = new System.Windows.Forms.Button();
            this.mrcOperacionesAlgebraicas = new System.Windows.Forms.GroupBox();
            this.cmdJuntar = new System.Windows.Forms.Button();
            this.cmdSeleccionSimple = new System.Windows.Forms.Button();
            this.cmdSeleccionMultiples = new System.Windows.Forms.Button();
            this.cmdSeleccionConvolucion = new System.Windows.Forms.Button();
            this.cmdUnion = new System.Windows.Forms.Button();
            this.cmdInterseccion = new System.Windows.Forms.Button();
            this.cmdDiferencia = new System.Windows.Forms.Button();
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
            this.grlDatos.Location = new System.Drawing.Point(18, 22);
            this.grlDatos.Name = "grlDatos";
            this.grlDatos.ReadOnly = true;
            this.grlDatos.Size = new System.Drawing.Size(770, 283);
            this.grlDatos.TabIndex = 0;
            // 
            // cmdProyeccionSimple
            // 
            this.cmdProyeccionSimple.Location = new System.Drawing.Point(24, 29);
            this.cmdProyeccionSimple.Name = "cmdProyeccionSimple";
            this.cmdProyeccionSimple.Size = new System.Drawing.Size(146, 23);
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
            this.mrcOperacionesProyeccion.Location = new System.Drawing.Point(33, 316);
            this.mrcOperacionesProyeccion.Name = "mrcOperacionesProyeccion";
            this.mrcOperacionesProyeccion.Size = new System.Drawing.Size(196, 122);
            this.mrcOperacionesProyeccion.TabIndex = 2;
            this.mrcOperacionesProyeccion.TabStop = false;
            this.mrcOperacionesProyeccion.Text = "Operaciones de Proyecciòn";
            // 
            // mrcOperacionesSeleccion
            // 
            this.mrcOperacionesSeleccion.Controls.Add(this.cmdSeleccionConvolucion);
            this.mrcOperacionesSeleccion.Controls.Add(this.cmdSeleccionMultiples);
            this.mrcOperacionesSeleccion.Controls.Add(this.cmdSeleccionSimple);
            this.mrcOperacionesSeleccion.Location = new System.Drawing.Point(314, 316);
            this.mrcOperacionesSeleccion.Name = "mrcOperacionesSeleccion";
            this.mrcOperacionesSeleccion.Size = new System.Drawing.Size(196, 122);
            this.mrcOperacionesSeleccion.TabIndex = 3;
            this.mrcOperacionesSeleccion.TabStop = false;
            this.mrcOperacionesSeleccion.Text = "Operaciones de Selecciòn";
            // 
            // cmdPrroyeccionMultiatributo
            // 
            this.cmdPrroyeccionMultiatributo.Location = new System.Drawing.Point(24, 58);
            this.cmdPrroyeccionMultiatributo.Name = "cmdPrroyeccionMultiatributo";
            this.cmdPrroyeccionMultiatributo.Size = new System.Drawing.Size(146, 23);
            this.cmdPrroyeccionMultiatributo.TabIndex = 1;
            this.cmdPrroyeccionMultiatributo.Text = "Proyecciòn Multiatributo";
            this.cmdPrroyeccionMultiatributo.UseVisualStyleBackColor = true;
            this.cmdPrroyeccionMultiatributo.Click += new System.EventHandler(this.cmdPrroyeccionMultiatributo_Click);
            // 
            // mrcOperacionesAlgebraicas
            // 
            this.mrcOperacionesAlgebraicas.Controls.Add(this.cmdDiferencia);
            this.mrcOperacionesAlgebraicas.Controls.Add(this.cmdInterseccion);
            this.mrcOperacionesAlgebraicas.Controls.Add(this.cmdUnion);
            this.mrcOperacionesAlgebraicas.Location = new System.Drawing.Point(570, 316);
            this.mrcOperacionesAlgebraicas.Name = "mrcOperacionesAlgebraicas";
            this.mrcOperacionesAlgebraicas.Size = new System.Drawing.Size(196, 122);
            this.mrcOperacionesAlgebraicas.TabIndex = 3;
            this.mrcOperacionesAlgebraicas.TabStop = false;
            this.mrcOperacionesAlgebraicas.Text = "Operaciones Algebraicas";
            // 
            // cmdJuntar
            // 
            this.cmdJuntar.Location = new System.Drawing.Point(24, 86);
            this.cmdJuntar.Name = "cmdJuntar";
            this.cmdJuntar.Size = new System.Drawing.Size(146, 23);
            this.cmdJuntar.TabIndex = 1;
            this.cmdJuntar.Text = "Juntar";
            this.cmdJuntar.UseVisualStyleBackColor = true;
            this.cmdJuntar.Click += new System.EventHandler(this.cmdJuntar_Click);
            // 
            // cmdSeleccionSimple
            // 
            this.cmdSeleccionSimple.Location = new System.Drawing.Point(6, 28);
            this.cmdSeleccionSimple.Name = "cmdSeleccionSimple";
            this.cmdSeleccionSimple.Size = new System.Drawing.Size(173, 23);
            this.cmdSeleccionSimple.TabIndex = 2;
            this.cmdSeleccionSimple.Text = "Selecciòn Simple";
            this.cmdSeleccionSimple.UseVisualStyleBackColor = true;
            this.cmdSeleccionSimple.Click += new System.EventHandler(this.cmdSeleccionSimple_Click);
            // 
            // cmdSeleccionMultiples
            // 
            this.cmdSeleccionMultiples.Location = new System.Drawing.Point(6, 57);
            this.cmdSeleccionMultiples.Name = "cmdSeleccionMultiples";
            this.cmdSeleccionMultiples.Size = new System.Drawing.Size(173, 23);
            this.cmdSeleccionMultiples.TabIndex = 3;
            this.cmdSeleccionMultiples.Text = "Selecciòn Multiatributo";
            this.cmdSeleccionMultiples.UseVisualStyleBackColor = true;
            this.cmdSeleccionMultiples.Click += new System.EventHandler(this.cmdSeleccionMultiples_Click);
            // 
            // cmdSeleccionConvolucion
            // 
            this.cmdSeleccionConvolucion.Location = new System.Drawing.Point(6, 86);
            this.cmdSeleccionConvolucion.Name = "cmdSeleccionConvolucion";
            this.cmdSeleccionConvolucion.Size = new System.Drawing.Size(173, 23);
            this.cmdSeleccionConvolucion.TabIndex = 4;
            this.cmdSeleccionConvolucion.Text = "Selecciòn por Convoluciòn";
            this.cmdSeleccionConvolucion.UseVisualStyleBackColor = true;
            this.cmdSeleccionConvolucion.Click += new System.EventHandler(this.cmdSeleccionConvolucion_Click);
            // 
            // cmdUnion
            // 
            this.cmdUnion.Location = new System.Drawing.Point(6, 29);
            this.cmdUnion.Name = "cmdUnion";
            this.cmdUnion.Size = new System.Drawing.Size(164, 23);
            this.cmdUnion.TabIndex = 5;
            this.cmdUnion.Text = "Uniòn";
            this.cmdUnion.UseVisualStyleBackColor = true;
            this.cmdUnion.Click += new System.EventHandler(this.cmdUnion_Click);
            // 
            // cmdInterseccion
            // 
            this.cmdInterseccion.Location = new System.Drawing.Point(6, 58);
            this.cmdInterseccion.Name = "cmdInterseccion";
            this.cmdInterseccion.Size = new System.Drawing.Size(164, 23);
            this.cmdInterseccion.TabIndex = 6;
            this.cmdInterseccion.Text = "Intersecciòn";
            this.cmdInterseccion.UseVisualStyleBackColor = true;
            this.cmdInterseccion.Click += new System.EventHandler(this.cmdInterseccion_Click);
            // 
            // cmdDiferencia
            // 
            this.cmdDiferencia.Location = new System.Drawing.Point(6, 86);
            this.cmdDiferencia.Name = "cmdDiferencia";
            this.cmdDiferencia.Size = new System.Drawing.Size(164, 23);
            this.cmdDiferencia.TabIndex = 7;
            this.cmdDiferencia.Text = "Diferencia";
            this.cmdDiferencia.UseVisualStyleBackColor = true;
            this.cmdDiferencia.Click += new System.EventHandler(this.cmdDiferencia_Click);
            // 
            // frmBaseDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mrcOperacionesAlgebraicas);
            this.Controls.Add(this.mrcOperacionesSeleccion);
            this.Controls.Add(this.mrcOperacionesProyeccion);
            this.Controls.Add(this.grlDatos);
            this.Name = "frmBaseDatos";
            this.Text = "Base de Datos";
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