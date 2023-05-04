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
            this.mrcListarDatos = new System.Windows.Forms.GroupBox();
            this.btnAscendentePost = new System.Windows.Forms.RadioButton();
            this.btnAscendentePre = new System.Windows.Forms.RadioButton();
            this.btnDescendente = new System.Windows.Forms.RadioButton();
            this.btnAscendente = new System.Windows.Forms.RadioButton();
            this.tvArbol = new System.Windows.Forms.TreeView();
            this.mrcPre = new System.Windows.Forms.GroupBox();
            this.btnDescendentePre = new System.Windows.Forms.RadioButton();
            this.mrcPro = new System.Windows.Forms.GroupBox();
            this.btnDescendentePost = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.grlDatos)).BeginInit();
            this.mrcElementoEliminados.SuspendLayout();
            this.mrcNuevoElemento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.mrcListarDatos.SuspendLayout();
            this.mrcPre.SuspendLayout();
            this.mrcPro.SuspendLayout();
            this.SuspendLayout();
            // 
            // grlDatos
            // 
            this.grlDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grlDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Còdigo,
            this.Nombre,
            this.Tràmite});
            this.grlDatos.Location = new System.Drawing.Point(198, 345);
            this.grlDatos.Name = "grlDatos";
            this.grlDatos.Size = new System.Drawing.Size(385, 134);
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
            this.lstDatos.Location = new System.Drawing.Point(12, 241);
            this.lstDatos.Name = "lstDatos";
            this.lstDatos.Size = new System.Drawing.Size(174, 238);
            this.lstDatos.TabIndex = 0;
            // 
            // mrcElementoEliminados
            // 
            this.mrcElementoEliminados.Controls.Add(this.lstCodigo);
            this.mrcElementoEliminados.Controls.Add(this.cmdEliminar);
            this.mrcElementoEliminados.Controls.Add(this.lblCodigoEliminar);
            this.mrcElementoEliminados.Location = new System.Drawing.Point(198, 237);
            this.mrcElementoEliminados.Name = "mrcElementoEliminados";
            this.mrcElementoEliminados.Size = new System.Drawing.Size(385, 84);
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
            this.cmdEliminar.Location = new System.Drawing.Point(216, 31);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(100, 34);
            this.cmdEliminar.TabIndex = 7;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
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
            this.mrcNuevoElemento.Size = new System.Drawing.Size(175, 219);
            this.mrcNuevoElemento.TabIndex = 13;
            this.mrcNuevoElemento.TabStop = false;
            this.mrcNuevoElemento.Text = "Nuevo Elemento";
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Location = new System.Drawing.Point(65, 150);
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
            this.picFoto.Size = new System.Drawing.Size(180, 219);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFoto.TabIndex = 12;
            this.picFoto.TabStop = false;
            // 
            // mrcListarDatos
            // 
            this.mrcListarDatos.Controls.Add(this.btnDescendente);
            this.mrcListarDatos.Controls.Add(this.btnAscendente);
            this.mrcListarDatos.Location = new System.Drawing.Point(379, 12);
            this.mrcListarDatos.Name = "mrcListarDatos";
            this.mrcListarDatos.Size = new System.Drawing.Size(201, 68);
            this.mrcListarDatos.TabIndex = 17;
            this.mrcListarDatos.TabStop = false;
            this.mrcListarDatos.Text = "In orden";
            // 
            // btnAscendentePost
            // 
            this.btnAscendentePost.AutoSize = true;
            this.btnAscendentePost.Location = new System.Drawing.Point(6, 33);
            this.btnAscendentePost.Name = "btnAscendentePost";
            this.btnAscendentePost.Size = new System.Drawing.Size(82, 17);
            this.btnAscendentePost.TabIndex = 3;
            this.btnAscendentePost.TabStop = true;
            this.btnAscendentePost.Text = "Ascendente";
            this.btnAscendentePost.UseVisualStyleBackColor = true;
            this.btnAscendentePost.CheckedChanged += new System.EventHandler(this.btnPost_CheckedChanged);
            // 
            // btnAscendentePre
            // 
            this.btnAscendentePre.AutoSize = true;
            this.btnAscendentePre.Location = new System.Drawing.Point(6, 33);
            this.btnAscendentePre.Name = "btnAscendentePre";
            this.btnAscendentePre.Size = new System.Drawing.Size(82, 17);
            this.btnAscendentePre.TabIndex = 2;
            this.btnAscendentePre.TabStop = true;
            this.btnAscendentePre.Text = "Ascendente";
            this.btnAscendentePre.UseVisualStyleBackColor = true;
            this.btnAscendentePre.CheckedChanged += new System.EventHandler(this.btnPreOrden_CheckedChanged);
            // 
            // btnDescendente
            // 
            this.btnDescendente.AutoSize = true;
            this.btnDescendente.Location = new System.Drawing.Point(106, 33);
            this.btnDescendente.Name = "btnDescendente";
            this.btnDescendente.Size = new System.Drawing.Size(89, 17);
            this.btnDescendente.TabIndex = 1;
            this.btnDescendente.TabStop = true;
            this.btnDescendente.Text = "Descendente";
            this.btnDescendente.UseVisualStyleBackColor = true;
            this.btnDescendente.CheckedChanged += new System.EventHandler(this.btnDescendente_CheckedChanged);
            // 
            // btnAscendente
            // 
            this.btnAscendente.AutoSize = true;
            this.btnAscendente.Location = new System.Drawing.Point(6, 33);
            this.btnAscendente.Name = "btnAscendente";
            this.btnAscendente.Size = new System.Drawing.Size(82, 17);
            this.btnAscendente.TabIndex = 0;
            this.btnAscendente.TabStop = true;
            this.btnAscendente.Text = "Ascendente";
            this.btnAscendente.UseVisualStyleBackColor = true;
            this.btnAscendente.CheckedChanged += new System.EventHandler(this.btnAscendente_CheckedChanged);
            // 
            // tvArbol
            // 
            this.tvArbol.Location = new System.Drawing.Point(589, 21);
            this.tvArbol.Name = "tvArbol";
            this.tvArbol.Size = new System.Drawing.Size(292, 458);
            this.tvArbol.TabIndex = 18;
            // 
            // mrcPre
            // 
            this.mrcPre.Controls.Add(this.btnDescendentePre);
            this.mrcPre.Controls.Add(this.btnAscendentePre);
            this.mrcPre.Location = new System.Drawing.Point(379, 89);
            this.mrcPre.Name = "mrcPre";
            this.mrcPre.Size = new System.Drawing.Size(201, 68);
            this.mrcPre.TabIndex = 18;
            this.mrcPre.TabStop = false;
            this.mrcPre.Text = "Pre Orden";
            // 
            // btnDescendentePre
            // 
            this.btnDescendentePre.AutoSize = true;
            this.btnDescendentePre.Location = new System.Drawing.Point(106, 33);
            this.btnDescendentePre.Name = "btnDescendentePre";
            this.btnDescendentePre.Size = new System.Drawing.Size(89, 17);
            this.btnDescendentePre.TabIndex = 1;
            this.btnDescendentePre.TabStop = true;
            this.btnDescendentePre.Text = "Descendente";
            this.btnDescendentePre.UseVisualStyleBackColor = true;
            this.btnDescendentePre.CheckedChanged += new System.EventHandler(this.btnDescendentePre_CheckedChanged);
            // 
            // mrcPro
            // 
            this.mrcPro.Controls.Add(this.btnDescendentePost);
            this.mrcPro.Controls.Add(this.btnAscendentePost);
            this.mrcPro.Location = new System.Drawing.Point(379, 163);
            this.mrcPro.Name = "mrcPro";
            this.mrcPro.Size = new System.Drawing.Size(201, 68);
            this.mrcPro.TabIndex = 19;
            this.mrcPro.TabStop = false;
            this.mrcPro.Text = "Post Orden";
            // 
            // btnDescendentePost
            // 
            this.btnDescendentePost.AutoSize = true;
            this.btnDescendentePost.Location = new System.Drawing.Point(106, 33);
            this.btnDescendentePost.Name = "btnDescendentePost";
            this.btnDescendentePost.Size = new System.Drawing.Size(89, 17);
            this.btnDescendentePost.TabIndex = 1;
            this.btnDescendentePost.TabStop = true;
            this.btnDescendentePost.Text = "Descendente";
            this.btnDescendentePost.UseVisualStyleBackColor = true;
            this.btnDescendentePost.CheckedChanged += new System.EventHandler(this.btnDescendentePost_CheckedChanged);
            // 
            // frmEstructuraArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 489);
            this.Controls.Add(this.grlDatos);
            this.Controls.Add(this.mrcPro);
            this.Controls.Add(this.lstDatos);
            this.Controls.Add(this.mrcPre);
            this.Controls.Add(this.tvArbol);
            this.Controls.Add(this.mrcListarDatos);
            this.Controls.Add(this.mrcElementoEliminados);
            this.Controls.Add(this.mrcNuevoElemento);
            this.Controls.Add(this.picFoto);
            this.Name = "frmEstructuraArbolBinario";
            this.Text = "Estructura Dinamica No Lineal - Arbol Binario";
            ((System.ComponentModel.ISupportInitialize)(this.grlDatos)).EndInit();
            this.mrcElementoEliminados.ResumeLayout(false);
            this.mrcElementoEliminados.PerformLayout();
            this.mrcNuevoElemento.ResumeLayout(false);
            this.mrcNuevoElemento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.mrcListarDatos.ResumeLayout(false);
            this.mrcListarDatos.PerformLayout();
            this.mrcPre.ResumeLayout(false);
            this.mrcPre.PerformLayout();
            this.mrcPro.ResumeLayout(false);
            this.mrcPro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.GroupBox mrcListarDatos;
        private System.Windows.Forms.RadioButton btnDescendente;
        private System.Windows.Forms.RadioButton btnAscendente;
        private System.Windows.Forms.RadioButton btnAscendentePost;
        private System.Windows.Forms.RadioButton btnAscendentePre;
        private System.Windows.Forms.TreeView tvArbol;
        private System.Windows.Forms.GroupBox mrcPre;
        private System.Windows.Forms.RadioButton btnDescendentePre;
        private System.Windows.Forms.GroupBox mrcPro;
        private System.Windows.Forms.RadioButton btnDescendentePost;
    }
}