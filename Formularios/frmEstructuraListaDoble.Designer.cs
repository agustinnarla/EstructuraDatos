namespace EstructuraDatos.Formularios
{
    partial class frmEstructuraListaDoble
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstructuraListaDoble));
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
            this.mrcListarDatos = new System.Windows.Forms.GroupBox();
            this.btnDescendente = new System.Windows.Forms.RadioButton();
            this.btnAscendente = new System.Windows.Forms.RadioButton();
            this.mrcListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grlDatos)).BeginInit();
            this.mrcElementoEliminados.SuspendLayout();
            this.mrcNuevoElemento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.mrcListarDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcListado
            // 
            this.mrcListado.Controls.Add(this.grlDatos);
            this.mrcListado.Controls.Add(this.lstDatos);
            this.mrcListado.Location = new System.Drawing.Point(12, 247);
            this.mrcListado.Name = "mrcListado";
            this.mrcListado.Size = new System.Drawing.Size(559, 196);
            this.mrcListado.TabIndex = 11;
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
            this.grlDatos.Location = new System.Drawing.Point(195, 22);
            this.grlDatos.Name = "grlDatos";
            this.grlDatos.Size = new System.Drawing.Size(348, 155);
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
            this.lstDatos.ItemHeight = 15;
            this.lstDatos.Location = new System.Drawing.Point(6, 22);
            this.lstDatos.Name = "lstDatos";
            this.lstDatos.Size = new System.Drawing.Size(174, 154);
            this.lstDatos.TabIndex = 0;
            // 
            // mrcElementoEliminados
            // 
            this.mrcElementoEliminados.Controls.Add(this.lstCodigo);
            this.mrcElementoEliminados.Controls.Add(this.cmdEliminar);
            this.mrcElementoEliminados.Controls.Add(this.lblCodigoEliminar);
            this.mrcElementoEliminados.Location = new System.Drawing.Point(379, 14);
            this.mrcElementoEliminados.Name = "mrcElementoEliminados";
            this.mrcElementoEliminados.Size = new System.Drawing.Size(192, 127);
            this.mrcElementoEliminados.TabIndex = 10;
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
            this.cmdEliminar.Location = new System.Drawing.Point(76, 78);
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
            this.mrcNuevoElemento.Controls.Add(this.cmdAgregar);
            this.mrcNuevoElemento.Controls.Add(this.txtTramite);
            this.mrcNuevoElemento.Controls.Add(this.txtNombre);
            this.mrcNuevoElemento.Controls.Add(this.txtCodigo);
            this.mrcNuevoElemento.Controls.Add(this.lblTramite);
            this.mrcNuevoElemento.Controls.Add(this.lblNombre);
            this.mrcNuevoElemento.Controls.Add(this.lblCòdigo);
            this.mrcNuevoElemento.Location = new System.Drawing.Point(198, 14);
            this.mrcNuevoElemento.Name = "mrcNuevoElemento";
            this.mrcNuevoElemento.Size = new System.Drawing.Size(175, 212);
            this.mrcNuevoElemento.TabIndex = 9;
            this.mrcNuevoElemento.TabStop = false;
            this.mrcNuevoElemento.Text = "Nuevo Elemento";
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Enabled = false;
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
            this.picFoto.Size = new System.Drawing.Size(180, 212);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFoto.TabIndex = 8;
            this.picFoto.TabStop = false;
            // 
            // mrcListarDatos
            // 
            this.mrcListarDatos.Controls.Add(this.btnDescendente);
            this.mrcListarDatos.Controls.Add(this.btnAscendente);
            this.mrcListarDatos.Location = new System.Drawing.Point(379, 148);
            this.mrcListarDatos.Name = "mrcListarDatos";
            this.mrcListarDatos.Size = new System.Drawing.Size(192, 78);
            this.mrcListarDatos.TabIndex = 11;
            this.mrcListarDatos.TabStop = false;
            this.mrcListarDatos.Text = "Listar Datos";
            this.mrcListarDatos.Enter += new System.EventHandler(this.mrcListarDatos_Enter);
            // 
            // btnDescendente
            // 
            this.btnDescendente.AutoSize = true;
            this.btnDescendente.Location = new System.Drawing.Point(6, 52);
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
            this.btnAscendente.Location = new System.Drawing.Point(6, 25);
            this.btnAscendente.Name = "btnAscendente";
            this.btnAscendente.Size = new System.Drawing.Size(85, 19);
            this.btnAscendente.TabIndex = 0;
            this.btnAscendente.TabStop = true;
            this.btnAscendente.Text = "Ascendente";
            this.btnAscendente.UseVisualStyleBackColor = true;
            this.btnAscendente.CheckedChanged += new System.EventHandler(this.btnAscendente_CheckedChanged);
            // 
            // frmEstructuraListaDoble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(594, 460);
            this.Controls.Add(this.mrcListarDatos);
            this.Controls.Add(this.mrcListado);
            this.Controls.Add(this.mrcElementoEliminados);
            this.Controls.Add(this.mrcNuevoElemento);
            this.Controls.Add(this.picFoto);
            this.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F);
            this.Name = "frmEstructuraListaDoble";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura Dinàmica Lineal - Lista Doble ";
            this.mrcListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grlDatos)).EndInit();
            this.mrcElementoEliminados.ResumeLayout(false);
            this.mrcElementoEliminados.PerformLayout();
            this.mrcNuevoElemento.ResumeLayout(false);
            this.mrcNuevoElemento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.mrcListarDatos.ResumeLayout(false);
            this.mrcListarDatos.PerformLayout();
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
        private System.Windows.Forms.GroupBox mrcListarDatos;
        private System.Windows.Forms.RadioButton btnDescendente;
        private System.Windows.Forms.RadioButton btnAscendente;
    }
}