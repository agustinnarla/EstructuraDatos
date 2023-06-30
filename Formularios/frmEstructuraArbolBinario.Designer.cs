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
            this.lblAyuda = new System.Windows.Forms.Label();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCòdigo = new System.Windows.Forms.Label();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.mrcListarDatos = new System.Windows.Forms.GroupBox();
            this.btnDescendente = new System.Windows.Forms.RadioButton();
            this.btnAscendente = new System.Windows.Forms.RadioButton();
            this.btnAscendentePost = new System.Windows.Forms.RadioButton();
            this.btnAscendentePre = new System.Windows.Forms.RadioButton();
            this.mrcPre = new System.Windows.Forms.GroupBox();
            this.btnDescendentePre = new System.Windows.Forms.RadioButton();
            this.mrcPro = new System.Windows.Forms.GroupBox();
            this.btnDescendentePost = new System.Windows.Forms.RadioButton();
            this.tvArbolito = new System.Windows.Forms.TreeView();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.mrcBusqueda = new System.Windows.Forms.GroupBox();
            this.lstCodigoInfo = new System.Windows.Forms.ComboBox();
            this.txtTramiteInfo = new System.Windows.Forms.TextBox();
            this.txtNombreInfo = new System.Windows.Forms.TextBox();
            this.lblCodigoInfo = new System.Windows.Forms.Label();
            this.lblTramiteInfo = new System.Windows.Forms.Label();
            this.lblNombreInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grlDatos)).BeginInit();
            this.mrcElementoEliminados.SuspendLayout();
            this.mrcNuevoElemento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.mrcListarDatos.SuspendLayout();
            this.mrcPre.SuspendLayout();
            this.mrcPro.SuspendLayout();
            this.mrcBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // grlDatos
            // 
            this.grlDatos.AllowUserToAddRows = false;
            this.grlDatos.AllowUserToDeleteRows = false;
            this.grlDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grlDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Còdigo,
            this.Nombre,
            this.Tràmite});
            this.grlDatos.Location = new System.Drawing.Point(198, 492);
            this.grlDatos.Name = "grlDatos";
            this.grlDatos.ReadOnly = true;
            this.grlDatos.Size = new System.Drawing.Size(385, 155);
            this.grlDatos.TabIndex = 1;
            // 
            // Còdigo
            // 
            this.Còdigo.HeaderText = "Còdigo";
            this.Còdigo.Name = "Còdigo";
            this.Còdigo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Tràmite
            // 
            this.Tràmite.HeaderText = "Tràmite";
            this.Tràmite.Name = "Tràmite";
            this.Tràmite.ReadOnly = true;
            // 
            // lstDatos
            // 
            this.lstDatos.FormattingEnabled = true;
            this.lstDatos.ItemHeight = 15;
            this.lstDatos.Location = new System.Drawing.Point(12, 270);
            this.lstDatos.Name = "lstDatos";
            this.lstDatos.Size = new System.Drawing.Size(174, 379);
            this.lstDatos.TabIndex = 0;
            this.lstDatos.SelectedIndexChanged += new System.EventHandler(this.lstDatos_SelectedIndexChanged);
            // 
            // mrcElementoEliminados
            // 
            this.mrcElementoEliminados.Controls.Add(this.lstCodigo);
            this.mrcElementoEliminados.Controls.Add(this.cmdEliminar);
            this.mrcElementoEliminados.Controls.Add(this.lblCodigoEliminar);
            this.mrcElementoEliminados.Location = new System.Drawing.Point(198, 251);
            this.mrcElementoEliminados.Name = "mrcElementoEliminados";
            this.mrcElementoEliminados.Size = new System.Drawing.Size(385, 97);
            this.mrcElementoEliminados.TabIndex = 14;
            this.mrcElementoEliminados.TabStop = false;
            this.mrcElementoEliminados.Text = "Elemento Eliminado";
            // 
            // lstCodigo
            // 
            this.lstCodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstCodigo.FormattingEnabled = true;
            this.lstCodigo.Location = new System.Drawing.Point(76, 42);
            this.lstCodigo.Name = "lstCodigo";
            this.lstCodigo.Size = new System.Drawing.Size(100, 23);
            this.lstCodigo.TabIndex = 8;
            this.lstCodigo.SelectedIndexChanged += new System.EventHandler(this.lstCodigo_SelectedIndexChanged);
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Enabled = false;
            this.cmdEliminar.Location = new System.Drawing.Point(216, 36);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(100, 39);
            this.cmdEliminar.TabIndex = 7;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // lblCodigoEliminar
            // 
            this.lblCodigoEliminar.AutoSize = true;
            this.lblCodigoEliminar.Location = new System.Drawing.Point(15, 43);
            this.lblCodigoEliminar.Name = "lblCodigoEliminar";
            this.lblCodigoEliminar.Size = new System.Drawing.Size(48, 15);
            this.lblCodigoEliminar.TabIndex = 6;
            this.lblCodigoEliminar.Text = "Còdigo:";
            // 
            // mrcNuevoElemento
            // 
            this.mrcNuevoElemento.Controls.Add(this.lblAyuda);
            this.mrcNuevoElemento.Controls.Add(this.cmdAgregar);
            this.mrcNuevoElemento.Controls.Add(this.txtTramite);
            this.mrcNuevoElemento.Controls.Add(this.txtNombre);
            this.mrcNuevoElemento.Controls.Add(this.txtCodigo);
            this.mrcNuevoElemento.Controls.Add(this.lblTramite);
            this.mrcNuevoElemento.Controls.Add(this.lblNombre);
            this.mrcNuevoElemento.Controls.Add(this.lblCòdigo);
            this.mrcNuevoElemento.Location = new System.Drawing.Point(198, 14);
            this.mrcNuevoElemento.Name = "mrcNuevoElemento";
            this.mrcNuevoElemento.Size = new System.Drawing.Size(175, 231);
            this.mrcNuevoElemento.TabIndex = 13;
            this.mrcNuevoElemento.TabStop = false;
            this.mrcNuevoElemento.Text = "Nuevo Elemento";
            // 
            // lblAyuda
            // 
            this.lblAyuda.AutoSize = true;
            this.lblAyuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAyuda.Location = new System.Drawing.Point(59, 200);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(110, 13);
            this.lblAyuda.TabIndex = 7;
            this.lblAyuda.Text = "¡Click para ayuda!";
            this.lblAyuda.Click += new System.EventHandler(this.lblAyuda_Click);
            this.lblAyuda.MouseCaptureChanged += new System.EventHandler(this.lblAyuda_MouseCaptureChanged);
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Location = new System.Drawing.Point(65, 152);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(100, 39);
            this.cmdAgregar.TabIndex = 6;
            this.cmdAgregar.Text = "Agregar";
            this.cmdAgregar.UseVisualStyleBackColor = true;
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(65, 112);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(100, 22);
            this.txtTramite.TabIndex = 5;
            this.txtTramite.TextChanged += new System.EventHandler(this.txtTramite_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(65, 78);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(65, 43);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 22);
            this.txtCodigo.TabIndex = 3;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Location = new System.Drawing.Point(6, 112);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(47, 15);
            this.lblTramite.TabIndex = 2;
            this.lblTramite.Text = "Tràmite:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 78);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCòdigo
            // 
            this.lblCòdigo.AutoSize = true;
            this.lblCòdigo.Location = new System.Drawing.Point(6, 43);
            this.lblCòdigo.Name = "lblCòdigo";
            this.lblCòdigo.Size = new System.Drawing.Size(48, 15);
            this.lblCòdigo.TabIndex = 0;
            this.lblCòdigo.Text = "Còdigo:";
            // 
            // picFoto
            // 
            this.picFoto.Image = ((System.Drawing.Image)(resources.GetObject("picFoto.Image")));
            this.picFoto.Location = new System.Drawing.Point(12, 14);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(174, 253);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFoto.TabIndex = 12;
            this.picFoto.TabStop = false;
            // 
            // mrcListarDatos
            // 
            this.mrcListarDatos.Controls.Add(this.btnDescendente);
            this.mrcListarDatos.Controls.Add(this.btnAscendente);
            this.mrcListarDatos.Enabled = false;
            this.mrcListarDatos.Location = new System.Drawing.Point(379, 14);
            this.mrcListarDatos.Name = "mrcListarDatos";
            this.mrcListarDatos.Size = new System.Drawing.Size(201, 65);
            this.mrcListarDatos.TabIndex = 17;
            this.mrcListarDatos.TabStop = false;
            this.mrcListarDatos.Text = "In orden";
            this.mrcListarDatos.Enter += new System.EventHandler(this.mrcListarDatos_Enter);
            // 
            // btnDescendente
            // 
            this.btnDescendente.AutoSize = true;
            this.btnDescendente.Location = new System.Drawing.Point(106, 30);
            this.btnDescendente.Name = "btnDescendente";
            this.btnDescendente.Size = new System.Drawing.Size(92, 19);
            this.btnDescendente.TabIndex = 1;
            this.btnDescendente.TabStop = true;
            this.btnDescendente.Text = "Descendente";
            this.btnDescendente.UseVisualStyleBackColor = true;
            this.btnDescendente.CheckedChanged += new System.EventHandler(this.btnDescendente_CheckedChanged);
            // 
            // btnAscendente
            // 
            this.btnAscendente.AutoSize = true;
            this.btnAscendente.Location = new System.Drawing.Point(6, 30);
            this.btnAscendente.Name = "btnAscendente";
            this.btnAscendente.Size = new System.Drawing.Size(85, 19);
            this.btnAscendente.TabIndex = 0;
            this.btnAscendente.TabStop = true;
            this.btnAscendente.Text = "Ascendente";
            this.btnAscendente.UseVisualStyleBackColor = true;
            this.btnAscendente.CheckedChanged += new System.EventHandler(this.btnAscendente_CheckedChanged);
            // 
            // btnAscendentePost
            // 
            this.btnAscendentePost.AutoSize = true;
            this.btnAscendentePost.Location = new System.Drawing.Point(6, 28);
            this.btnAscendentePost.Name = "btnAscendentePost";
            this.btnAscendentePost.Size = new System.Drawing.Size(85, 19);
            this.btnAscendentePost.TabIndex = 3;
            this.btnAscendentePost.TabStop = true;
            this.btnAscendentePost.Text = "Ascendente";
            this.btnAscendentePost.UseVisualStyleBackColor = true;
            this.btnAscendentePost.CheckedChanged += new System.EventHandler(this.btnPost_CheckedChanged);
            // 
            // btnAscendentePre
            // 
            this.btnAscendentePre.AutoSize = true;
            this.btnAscendentePre.Location = new System.Drawing.Point(6, 28);
            this.btnAscendentePre.Name = "btnAscendentePre";
            this.btnAscendentePre.Size = new System.Drawing.Size(85, 19);
            this.btnAscendentePre.TabIndex = 2;
            this.btnAscendentePre.TabStop = true;
            this.btnAscendentePre.Text = "Ascendente";
            this.btnAscendentePre.UseVisualStyleBackColor = true;
            this.btnAscendentePre.CheckedChanged += new System.EventHandler(this.btnPreOrden_CheckedChanged);
            // 
            // mrcPre
            // 
            this.mrcPre.Controls.Add(this.btnDescendentePre);
            this.mrcPre.Controls.Add(this.btnAscendentePre);
            this.mrcPre.Enabled = false;
            this.mrcPre.Location = new System.Drawing.Point(379, 101);
            this.mrcPre.Name = "mrcPre";
            this.mrcPre.Size = new System.Drawing.Size(201, 63);
            this.mrcPre.TabIndex = 18;
            this.mrcPre.TabStop = false;
            this.mrcPre.Text = "Pre Orden";
            this.mrcPre.Enter += new System.EventHandler(this.mrcPre_Enter);
            // 
            // btnDescendentePre
            // 
            this.btnDescendentePre.AutoSize = true;
            this.btnDescendentePre.Location = new System.Drawing.Point(106, 28);
            this.btnDescendentePre.Name = "btnDescendentePre";
            this.btnDescendentePre.Size = new System.Drawing.Size(92, 19);
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
            this.mrcPro.Enabled = false;
            this.mrcPro.Location = new System.Drawing.Point(379, 180);
            this.mrcPro.Name = "mrcPro";
            this.mrcPro.Size = new System.Drawing.Size(201, 64);
            this.mrcPro.TabIndex = 19;
            this.mrcPro.TabStop = false;
            this.mrcPro.Text = "Post Orden";
            this.mrcPro.Enter += new System.EventHandler(this.mrcPro_Enter);
            // 
            // btnDescendentePost
            // 
            this.btnDescendentePost.AutoSize = true;
            this.btnDescendentePost.Location = new System.Drawing.Point(106, 28);
            this.btnDescendentePost.Name = "btnDescendentePost";
            this.btnDescendentePost.Size = new System.Drawing.Size(92, 19);
            this.btnDescendentePost.TabIndex = 1;
            this.btnDescendentePost.TabStop = true;
            this.btnDescendentePost.Text = "Descendente";
            this.btnDescendentePost.UseVisualStyleBackColor = true;
            this.btnDescendentePost.CheckedChanged += new System.EventHandler(this.btnDescendentePost_CheckedChanged);
            // 
            // tvArbolito
            // 
            this.tvArbolito.Location = new System.Drawing.Point(601, 14);
            this.tvArbolito.Name = "tvArbolito";
            this.tvArbolito.Size = new System.Drawing.Size(313, 638);
            this.tvArbolito.TabIndex = 20;
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Enabled = false;
            this.cmdBuscar.Location = new System.Drawing.Point(216, 32);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(100, 39);
            this.cmdBuscar.TabIndex = 21;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // mrcBusqueda
            // 
            this.mrcBusqueda.Controls.Add(this.lstCodigoInfo);
            this.mrcBusqueda.Controls.Add(this.txtTramiteInfo);
            this.mrcBusqueda.Controls.Add(this.txtNombreInfo);
            this.mrcBusqueda.Controls.Add(this.lblCodigoInfo);
            this.mrcBusqueda.Controls.Add(this.lblTramiteInfo);
            this.mrcBusqueda.Controls.Add(this.cmdBuscar);
            this.mrcBusqueda.Controls.Add(this.lblNombreInfo);
            this.mrcBusqueda.Location = new System.Drawing.Point(198, 354);
            this.mrcBusqueda.Name = "mrcBusqueda";
            this.mrcBusqueda.Size = new System.Drawing.Size(385, 132);
            this.mrcBusqueda.TabIndex = 15;
            this.mrcBusqueda.TabStop = false;
            this.mrcBusqueda.Text = "Busqueda";
            // 
            // lstCodigoInfo
            // 
            this.lstCodigoInfo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstCodigoInfo.FormattingEnabled = true;
            this.lstCodigoInfo.Location = new System.Drawing.Point(75, 32);
            this.lstCodigoInfo.Name = "lstCodigoInfo";
            this.lstCodigoInfo.Size = new System.Drawing.Size(105, 23);
            this.lstCodigoInfo.TabIndex = 9;
            this.lstCodigoInfo.SelectedIndexChanged += new System.EventHandler(this.lstCodigoInfo_SelectedIndexChanged);
            // 
            // txtTramiteInfo
            // 
            this.txtTramiteInfo.Enabled = false;
            this.txtTramiteInfo.Location = new System.Drawing.Point(76, 98);
            this.txtTramiteInfo.Name = "txtTramiteInfo";
            this.txtTramiteInfo.Size = new System.Drawing.Size(104, 22);
            this.txtTramiteInfo.TabIndex = 8;
            // 
            // txtNombreInfo
            // 
            this.txtNombreInfo.Enabled = false;
            this.txtNombreInfo.Location = new System.Drawing.Point(76, 66);
            this.txtNombreInfo.Name = "txtNombreInfo";
            this.txtNombreInfo.Size = new System.Drawing.Size(104, 22);
            this.txtNombreInfo.TabIndex = 7;
            // 
            // lblCodigoInfo
            // 
            this.lblCodigoInfo.AutoSize = true;
            this.lblCodigoInfo.Location = new System.Drawing.Point(15, 38);
            this.lblCodigoInfo.Name = "lblCodigoInfo";
            this.lblCodigoInfo.Size = new System.Drawing.Size(48, 15);
            this.lblCodigoInfo.TabIndex = 25;
            this.lblCodigoInfo.Text = "Còdigo:";
            // 
            // lblTramiteInfo
            // 
            this.lblTramiteInfo.AutoSize = true;
            this.lblTramiteInfo.Location = new System.Drawing.Point(13, 103);
            this.lblTramiteInfo.Name = "lblTramiteInfo";
            this.lblTramiteInfo.Size = new System.Drawing.Size(47, 15);
            this.lblTramiteInfo.TabIndex = 23;
            this.lblTramiteInfo.Text = "Trámite:";
            // 
            // lblNombreInfo
            // 
            this.lblNombreInfo.AutoSize = true;
            this.lblNombreInfo.Location = new System.Drawing.Point(13, 70);
            this.lblNombreInfo.Name = "lblNombreInfo";
            this.lblNombreInfo.Size = new System.Drawing.Size(51, 15);
            this.lblNombreInfo.TabIndex = 6;
            this.lblNombreInfo.Text = "Nombre:";
            // 
            // frmEstructuraArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(923, 653);
            this.Controls.Add(this.mrcBusqueda);
            this.Controls.Add(this.tvArbolito);
            this.Controls.Add(this.grlDatos);
            this.Controls.Add(this.mrcPro);
            this.Controls.Add(this.lstDatos);
            this.Controls.Add(this.mrcPre);
            this.Controls.Add(this.mrcListarDatos);
            this.Controls.Add(this.mrcElementoEliminados);
            this.Controls.Add(this.mrcNuevoElemento);
            this.Controls.Add(this.picFoto);
            this.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F);
            this.Name = "frmEstructuraArbolBinario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura Dinamica No Lineal - Arbol Binario";
            this.Load += new System.EventHandler(this.frmEstructuraArbolBinario_Load);
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
            this.mrcBusqueda.ResumeLayout(false);
            this.mrcBusqueda.PerformLayout();
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
        private System.Windows.Forms.GroupBox mrcPre;
        private System.Windows.Forms.RadioButton btnDescendentePre;
        private System.Windows.Forms.GroupBox mrcPro;
        private System.Windows.Forms.RadioButton btnDescendentePost;
        private System.Windows.Forms.TreeView tvArbolito;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.GroupBox mrcBusqueda;
        private System.Windows.Forms.Label lblNombreInfo;
        private System.Windows.Forms.Label lblTramiteInfo;
        private System.Windows.Forms.Label lblCodigoInfo;
        private System.Windows.Forms.TextBox txtTramiteInfo;
        private System.Windows.Forms.TextBox txtNombreInfo;
        private System.Windows.Forms.ComboBox lstCodigoInfo;
        private System.Windows.Forms.Label lblAyuda;
    }
}