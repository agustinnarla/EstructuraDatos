﻿namespace EstructuraDatos
{
    partial class frmDatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatos));
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.cmdVolver = new System.Windows.Forms.Button();
            this.pickFoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pickFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(215, 120);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(215, 87);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(28, 15);
            this.lblDni.TabIndex = 2;
            this.lblDni.Text = "Dni:";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(215, 153);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(49, 15);
            this.lblMateria.TabIndex = 3;
            this.lblMateria.Text = "Materia:";
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Location = new System.Drawing.Point(215, 187);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(47, 15);
            this.lblCarrera.TabIndex = 4;
            this.lblCarrera.Text = "Carrera:";
            // 
            // txtDni
            // 
            this.txtDni.Enabled = false;
            this.txtDni.Location = new System.Drawing.Point(268, 87);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(114, 22);
            this.txtDni.TabIndex = 5;
            this.txtDni.Text = "45086990";
            this.txtDni.TextChanged += new System.EventHandler(this.txtDni_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(268, 120);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(114, 22);
            this.txtNombre.TabIndex = 6;
            this.txtNombre.Text = "Agustín Arla";
            // 
            // txtCarrera
            // 
            this.txtCarrera.Enabled = false;
            this.txtCarrera.Location = new System.Drawing.Point(268, 183);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(114, 22);
            this.txtCarrera.TabIndex = 7;
            this.txtCarrera.Text = "Analista de Sistema";
            // 
            // txtMateria
            // 
            this.txtMateria.Enabled = false;
            this.txtMateria.Location = new System.Drawing.Point(268, 153);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(114, 22);
            this.txtMateria.TabIndex = 8;
            this.txtMateria.Text = "Estructura de Datos";
            // 
            // cmdVolver
            // 
            this.cmdVolver.Location = new System.Drawing.Point(316, 275);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(66, 24);
            this.cmdVolver.TabIndex = 9;
            this.cmdVolver.Text = "Volver";
            this.cmdVolver.UseVisualStyleBackColor = true;
            this.cmdVolver.Click += new System.EventHandler(this.cmdVolver_Click);
            // 
            // pickFoto
            // 
            this.pickFoto.Image = ((System.Drawing.Image)(resources.GetObject("pickFoto.Image")));
            this.pickFoto.Location = new System.Drawing.Point(28, 12);
            this.pickFoto.Name = "pickFoto";
            this.pickFoto.Size = new System.Drawing.Size(165, 270);
            this.pickFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pickFoto.TabIndex = 10;
            this.pickFoto.TabStop = false;
            // 
            // frmDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(412, 313);
            this.Controls.Add(this.pickFoto);
            this.Controls.Add(this.cmdVolver);
            this.Controls.Add(this.txtMateria);
            this.Controls.Add(this.txtCarrera);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblNombre);
            this.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F);
            this.Name = "frmDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos del Programador";
            ((System.ComponentModel.ISupportInitialize)(this.pickFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.Button cmdVolver;
        private System.Windows.Forms.PictureBox pickFoto;
    }
}