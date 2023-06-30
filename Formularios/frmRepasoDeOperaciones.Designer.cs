namespace EstructuraDatos.Formularios
{
    partial class frmRepasoDeOperaciones
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
            this.lstOperaciones = new System.Windows.Forms.ComboBox();
            this.cmdListar = new System.Windows.Forms.Button();
            this.lblOperaciones = new System.Windows.Forms.Label();
            this.grlDatos = new System.Windows.Forms.DataGridView();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grlDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // lstOperaciones
            // 
            this.lstOperaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstOperaciones.FormattingEnabled = true;
            this.lstOperaciones.Items.AddRange(new object[] {
            "Diferencia",
            "Intersección",
            "Union",
            "Juntar",
            "Proyección Simple",
            "Proyección Multiatributo",
            "Selección Simple",
            "Selección Multiatributo con operador AND",
            "Selección Multiatributo con operador OR",
            "Selección Multiatributo con CONVOLUCION"});
            this.lstOperaciones.Location = new System.Drawing.Point(261, 18);
            this.lstOperaciones.Name = "lstOperaciones";
            this.lstOperaciones.Size = new System.Drawing.Size(319, 23);
            this.lstOperaciones.TabIndex = 0;
            this.lstOperaciones.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmdListar
            // 
            this.cmdListar.Enabled = false;
            this.cmdListar.Location = new System.Drawing.Point(586, 15);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(113, 29);
            this.cmdListar.TabIndex = 1;
            this.cmdListar.Text = "Listar";
            this.cmdListar.UseVisualStyleBackColor = true;
            this.cmdListar.Click += new System.EventHandler(this.cmdListar_Click);
            // 
            // lblOperaciones
            // 
            this.lblOperaciones.AutoSize = true;
            this.lblOperaciones.Location = new System.Drawing.Point(28, 21);
            this.lblOperaciones.Name = "lblOperaciones";
            this.lblOperaciones.Size = new System.Drawing.Size(227, 15);
            this.lblOperaciones.TabIndex = 2;
            this.lblOperaciones.Text = "Operaciónes a realizar en la base de datos:";
            // 
            // grlDatos
            // 
            this.grlDatos.AllowUserToAddRows = false;
            this.grlDatos.AllowUserToDeleteRows = false;
            this.grlDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grlDatos.Location = new System.Drawing.Point(31, 221);
            this.grlDatos.Name = "grlDatos";
            this.grlDatos.ReadOnly = true;
            this.grlDatos.Size = new System.Drawing.Size(668, 247);
            this.grlDatos.TabIndex = 3;
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInfo.Location = new System.Drawing.Point(31, 76);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(671, 129);
            this.lblInfo.TabIndex = 4;
            // 
            // frmRepasoDeOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(719, 480);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.grlDatos);
            this.Controls.Add(this.lblOperaciones);
            this.Controls.Add(this.cmdListar);
            this.Controls.Add(this.lstOperaciones);
            this.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F);
            this.Name = "frmRepasoDeOperaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repaso Operaciones";
            this.Load += new System.EventHandler(this.frmRepasoDeOperaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grlDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox lstOperaciones;
        private System.Windows.Forms.Button cmdListar;
        private System.Windows.Forms.Label lblOperaciones;
        private System.Windows.Forms.DataGridView grlDatos;
        private System.Windows.Forms.Label lblInfo;
    }
}