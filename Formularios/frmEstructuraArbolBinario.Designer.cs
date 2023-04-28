namespace EstructuraDatos.Formularios
{
    partial class frmEstructuraArbolBinario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstructuraArbolBinario));
            this.mrcListado = new System.Windows.Forms.GroupBox();
            this.grlDatos = new System.Windows.Forms.DataGridView();
            this.Còdigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tràmite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstDatos = new System.Windows.Forms.ListBox();
            this.mrcElementoEliminados = new System.Windows.Forms.GroupBox();
            this.lstCodigo = new System.Windows.Forms.ComboBox();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.lblCodigoEliminar = new System.Windows.Forms.Label();
            this.mrcNuevoElemento = new System.Windows.Forms.GroupBox();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCòdigo = new System.Windows.Forms.Label();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.mrcListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grlDatos)).BeginInit();
            this.mrcElementoEliminados.SuspendLayout();
            this.mrcNuevoElemento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // mrcListado
            // 
            this.mrcListado.Controls.Add(this.grlDatos);
            this.mrcListado.Controls.Add(this.lstDatos);
            this.mrcListado.Location = new System.Drawing.Point(12, 214);
            this.mrcListado.Name = "mrcListado";
            this.mrcListado.Size = new System.Drawing.Size(559, 170);
            this.mrcListado.TabIndex = 16;
            this.mrcListado.TabStop = false;
            this.mrcListado.Text = "Listado en una Lista y una Grilla ";
            // 
            // grlDatos
            // 
            this.grlDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grlDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Còdigo,
            this.Nombre,
            this.Tràmite});
            this.grlDatos.Location = new System.Drawing.Point(195, 19);
            this.grlDatos.Name = "grlDatos";
            this.grlDatos.Size = new System.Drawing.Size(348, 134);
            this.grlDatos.TabIndex = 1;
            // 
            // Còdigo
            // 
            this.Còdigo.HeaderText = "Còdigo";
            this.Còdigo.Name = "Còdigo";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Tràmite
            // 
            this.Tràmite.HeaderText = "Tràmite";
            this.Tràmite.Name = "Tràmite";
            // 
            // lstDatos
            // 
            this.lstDatos.FormattingEnabled = true;
            this.lstDatos.Location = new System.Drawing.Point(6, 19);
            this.lstDatos.Name = "lstDatos";
            this.lstDatos.Size = new System.Drawing.Size(174, 134);
            this.lstDatos.TabIndex = 0;
            // 
            // mrcElementoEliminados
            // 
            this.mrcElementoEliminados.Controls.Add(this.lstCodigo);
            this.mrcElementoEliminados.Controls.Add(this.cmdEliminar);
            this.mrcElementoEliminados.Controls.Add(this.lblCodigoEliminar);
            this.mrcElementoEliminados.Location = new System.Drawing.Point(379, 12);
            this.mrcElementoEliminados.Name = "mrcElementoEliminados";
            this.mrcElementoEliminados.Size = new System.Drawing.Size(192, 110);
            this.mrcElementoEliminados.TabIndex = 14;
            this.mrcElementoEliminados.TabStop = false;
            this.mrcElementoEliminados.Text = "Elemento Eliminado";
            // 
            // lstCodigo
            // 
            this.lstCodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstCodigo.FormattingEnabled = true;
            this.lstCodigo.Location = new System.Drawing.Point(76, 36);
            this.lstCodigo.Name = "lstCodigo";
            this.lstCodigo.Size = new System.Drawing.Size(100, 21);
            this.lstCodigo.TabIndex = 8;
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Location = new System.Drawing.Point(76, 68);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(100, 34);
            this.cmdEliminar.TabIndex = 7;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            // 
            // lblCodigoEliminar
            // 
            this.lblCodigoEliminar.AutoSize = true;
            this.lblCodigoEliminar.Location = new System.Drawing.Point(15, 37);
            this.lblCodigoEliminar.Name = "lblCodigoEliminar";
            this.lblCodigoEliminar.Size = new System.Drawing.Size(43, 13);
            this.lblCodigoEliminar.TabIndex = 6;
            this.lblCodigoEliminar.Text = "Còdigo:";
            // 
            // mrcNuevoElemento
            // 
            this.mrcNuevoElemento.Controls.Add(this.cmdAgregar);
            this.mrcNuevoElemento.Controls.Add(this.txtTramite);
            this.mrcNuevoElemento.Controls.Add(this.txtNombre);
            this.mrcNuevoElemento.Controls.Add(this.txtCodigo);
            this.mrcNuevoElemento.Controls.Add(this.lblTramite);
            this.mrcNuevoElemento.Controls.Add(this.lblNombre);
            this.mrcNuevoElemento.Controls.Add(this.lblCòdigo);
            this.mrcNuevoElemento.Location = new System.Drawing.Point(198, 12);
            this.mrcNuevoElemento.Name = "mrcNuevoElemento";
            this.mrcNuevoElemento.Size = new System.Drawing.Size(175, 184);
            this.mrcNuevoElemento.TabIndex = 13;
            this.mrcNuevoElemento.TabStop = false;
            this.mrcNuevoElemento.Text = "Nuevo Elemento";
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Location = new System.Drawing.Point(65, 132);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(100, 34);
            this.cmdAgregar.TabIndex = 6;
            this.cmdAgregar.Text = "Agregar";
            this.cmdAgregar.UseVisualStyleBackColor = true;
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(65, 97);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(100, 20);
            this.txtTramite.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(65, 68);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(65, 37);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 3;
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Location = new System.Drawing.Point(6, 97);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(45, 13);
            this.lblTramite.TabIndex = 2;
            this.lblTramite.Text = "Tràmite:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 68);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCòdigo
            // 
            this.lblCòdigo.AutoSize = true;
            this.lblCòdigo.Location = new System.Drawing.Point(6, 37);
            this.lblCòdigo.Name = "lblCòdigo";
            this.lblCòdigo.Size = new System.Drawing.Size(43, 13);
            this.lblCòdigo.TabIndex = 0;
            this.lblCòdigo.Text = "Còdigo:";
            // 
            // picFoto
            // 
            this.picFoto.Image = ((System.Drawing.Image)(resources.GetObject("picFoto.Image")));
            this.picFoto.Location = new System.Drawing.Point(12, 12);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(180, 184);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFoto.TabIndex = 12;
            this.picFoto.TabStop = false;
            // 
            // frmEstructuraArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 399);
            this.Controls.Add(this.mrcListado);
            this.Controls.Add(this.mrcElementoEliminados);
            this.Controls.Add(this.mrcNuevoElemento);
            this.Controls.Add(this.picFoto);
            this.Name = "frmEstructuraArbolBinario";
            this.Text = "Estructura Dinamica No Lineal - Arbol Binario";
            this.mrcListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grlDatos)).EndInit();
            this.mrcElementoEliminados.ResumeLayout(false);
            this.mrcElementoEliminados.PerformLayout();
            this.mrcNuevoElemento.ResumeLayout(false);
            this.mrcNuevoElemento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcListado;
        private System.Windows.Forms.DataGridView grlDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Còdigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tràmite;
        private System.Windows.Forms.ListBox lstDatos;
        private System.Windows.Forms.GroupBox mrcElementoEliminados;
        private System.Windows.Forms.ComboBox lstCodigo;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Label lblCodigoEliminar;
        private System.Windows.Forms.GroupBox mrcNuevoElemento;
        private System.Windows.Forms.Button cmdAgregar;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCòdigo;
        private System.Windows.Forms.PictureBox picFoto;
    }
}