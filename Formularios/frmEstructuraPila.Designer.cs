namespace EstructuraDatos
{
    partial class frmEstructuraPila
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstructuraPila));
            this.mrcListado = new System.Windows.Forms.GroupBox();
            this.grlDatos = new System.Windows.Forms.DataGridView();
            this.Còdigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tràmite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstDatos = new System.Windows.Forms.ListBox();
            this.mrcElementoEliminados = new System.Windows.Forms.GroupBox();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.txtTramiteEliminar = new System.Windows.Forms.TextBox();
            this.txtNombreEliminar = new System.Windows.Forms.TextBox();
            this.lblCodigoEliminar = new System.Windows.Forms.Label();
            this.txtCodigoEliminar = new System.Windows.Forms.TextBox();
            this.lblNombreEliminar = new System.Windows.Forms.Label();
            this.lblTramiteEliminar = new System.Windows.Forms.Label();
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
            this.mrcListado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mrcListado.Controls.Add(this.grlDatos);
            this.mrcListado.Controls.Add(this.lstDatos);
            this.mrcListado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mrcListado.Location = new System.Drawing.Point(16, 247);
            this.mrcListado.Name = "mrcListado";
            this.mrcListado.Size = new System.Drawing.Size(559, 196);
            this.mrcListado.TabIndex = 7;
            this.mrcListado.TabStop = false;
            this.mrcListado.Text = "Listado en una Lista y una Grilla ";
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
            this.grlDatos.Location = new System.Drawing.Point(195, 22);
            this.grlDatos.Name = "grlDatos";
            this.grlDatos.ReadOnly = true;
            this.grlDatos.Size = new System.Drawing.Size(348, 155);
            this.grlDatos.TabIndex = 1;
            this.grlDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grlDatos_CellContentClick);
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
            this.lstDatos.Location = new System.Drawing.Point(6, 22);
            this.lstDatos.Name = "lstDatos";
            this.lstDatos.Size = new System.Drawing.Size(174, 154);
            this.lstDatos.TabIndex = 0;
            this.lstDatos.SelectedIndexChanged += new System.EventHandler(this.lstDatos_SelectedIndexChanged);
            this.lstDatos.Enter += new System.EventHandler(this.lstDatos_Enter);
            // 
            // mrcElementoEliminados
            // 
            this.mrcElementoEliminados.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mrcElementoEliminados.Controls.Add(this.cmdEliminar);
            this.mrcElementoEliminados.Controls.Add(this.txtTramiteEliminar);
            this.mrcElementoEliminados.Controls.Add(this.txtNombreEliminar);
            this.mrcElementoEliminados.Controls.Add(this.lblCodigoEliminar);
            this.mrcElementoEliminados.Controls.Add(this.txtCodigoEliminar);
            this.mrcElementoEliminados.Controls.Add(this.lblNombreEliminar);
            this.mrcElementoEliminados.Controls.Add(this.lblTramiteEliminar);
            this.mrcElementoEliminados.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F);
            this.mrcElementoEliminados.Location = new System.Drawing.Point(383, 14);
            this.mrcElementoEliminados.Name = "mrcElementoEliminados";
            this.mrcElementoEliminados.Size = new System.Drawing.Size(192, 212);
            this.mrcElementoEliminados.TabIndex = 6;
            this.mrcElementoEliminados.TabStop = false;
            this.mrcElementoEliminados.Text = "Elemento Eliminado";
            this.mrcElementoEliminados.Enter += new System.EventHandler(this.mrcElementoEliminados_Enter);
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Enabled = false;
            this.cmdEliminar.Location = new System.Drawing.Point(76, 152);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(100, 39);
            this.cmdEliminar.TabIndex = 7;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // txtTramiteEliminar
            // 
            this.txtTramiteEliminar.Enabled = false;
            this.txtTramiteEliminar.Location = new System.Drawing.Point(76, 112);
            this.txtTramiteEliminar.Name = "txtTramiteEliminar";
            this.txtTramiteEliminar.Size = new System.Drawing.Size(100, 22);
            this.txtTramiteEliminar.TabIndex = 11;
            this.txtTramiteEliminar.TextChanged += new System.EventHandler(this.txtTramiteEliminar_TextChanged);
            // 
            // txtNombreEliminar
            // 
            this.txtNombreEliminar.Enabled = false;
            this.txtNombreEliminar.Location = new System.Drawing.Point(76, 78);
            this.txtNombreEliminar.Name = "txtNombreEliminar";
            this.txtNombreEliminar.Size = new System.Drawing.Size(100, 22);
            this.txtNombreEliminar.TabIndex = 10;
            this.txtNombreEliminar.TextChanged += new System.EventHandler(this.txtNombreEliminar_TextChanged);
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
            // txtCodigoEliminar
            // 
            this.txtCodigoEliminar.Enabled = false;
            this.txtCodigoEliminar.Location = new System.Drawing.Point(76, 43);
            this.txtCodigoEliminar.Name = "txtCodigoEliminar";
            this.txtCodigoEliminar.Size = new System.Drawing.Size(100, 22);
            this.txtCodigoEliminar.TabIndex = 9;
            this.txtCodigoEliminar.TextChanged += new System.EventHandler(this.txtCodigoEliminar_TextChanged);
            // 
            // lblNombreEliminar
            // 
            this.lblNombreEliminar.AutoSize = true;
            this.lblNombreEliminar.Location = new System.Drawing.Point(15, 78);
            this.lblNombreEliminar.Name = "lblNombreEliminar";
            this.lblNombreEliminar.Size = new System.Drawing.Size(51, 15);
            this.lblNombreEliminar.TabIndex = 7;
            this.lblNombreEliminar.Text = "Nombre:";
            // 
            // lblTramiteEliminar
            // 
            this.lblTramiteEliminar.AutoSize = true;
            this.lblTramiteEliminar.Location = new System.Drawing.Point(15, 112);
            this.lblTramiteEliminar.Name = "lblTramiteEliminar";
            this.lblTramiteEliminar.Size = new System.Drawing.Size(47, 15);
            this.lblTramiteEliminar.TabIndex = 8;
            this.lblTramiteEliminar.Text = "Tràmite:";
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
            this.mrcNuevoElemento.Location = new System.Drawing.Point(202, 14);
            this.mrcNuevoElemento.Name = "mrcNuevoElemento";
            this.mrcNuevoElemento.Size = new System.Drawing.Size(175, 212);
            this.mrcNuevoElemento.TabIndex = 5;
            this.mrcNuevoElemento.TabStop = false;
            this.mrcNuevoElemento.Text = "Nuevo Elemento";
            this.mrcNuevoElemento.Enter += new System.EventHandler(this.mrcNuevoElemento_Enter);
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Enabled = false;
            this.cmdAgregar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.cmdAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.cmdAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
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
            this.picFoto.Location = new System.Drawing.Point(16, 14);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(180, 212);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFoto.TabIndex = 4;
            this.picFoto.TabStop = false;
            // 
            // frmEstructuraPila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(604, 459);
            this.Controls.Add(this.mrcListado);
            this.Controls.Add(this.mrcElementoEliminados);
            this.Controls.Add(this.mrcNuevoElemento);
            this.Controls.Add(this.picFoto);
            this.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F);
            this.Name = "frmEstructuraPila";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura Dinàmica Lineal - Pila";
            this.Load += new System.EventHandler(this.frmEstructuraPila_Load);
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
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.TextBox txtTramiteEliminar;
        private System.Windows.Forms.TextBox txtNombreEliminar;
        private System.Windows.Forms.Label lblCodigoEliminar;
        private System.Windows.Forms.TextBox txtCodigoEliminar;
        private System.Windows.Forms.Label lblNombreEliminar;
        private System.Windows.Forms.Label lblTramiteEliminar;
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