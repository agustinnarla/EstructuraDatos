namespace EstructuraDatos.Formularios
{
    partial class frmBaseDatosConsulta
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
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.cmdConsulta = new System.Windows.Forms.Button();
            this.grlDatos = new System.Windows.Forms.DataGridView();
            this.lblConsulta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grlDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtConsulta
            // 
            this.txtConsulta.Font = new System.Drawing.Font("Engravers MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsulta.Location = new System.Drawing.Point(20, 22);
            this.txtConsulta.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtConsulta.Multiline = true;
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(1012, 121);
            this.txtConsulta.TabIndex = 0;
            // 
            // cmdConsulta
            // 
            this.cmdConsulta.Location = new System.Drawing.Point(877, 149);
            this.cmdConsulta.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cmdConsulta.Name = "cmdConsulta";
            this.cmdConsulta.Size = new System.Drawing.Size(155, 30);
            this.cmdConsulta.TabIndex = 1;
            this.cmdConsulta.Text = "Consultar";
            this.cmdConsulta.UseVisualStyleBackColor = true;
            this.cmdConsulta.Click += new System.EventHandler(this.cmdConsulta_Click);
            // 
            // grlDatos
            // 
            this.grlDatos.AllowUserToAddRows = false;
            this.grlDatos.AllowUserToDeleteRows = false;
            this.grlDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grlDatos.Location = new System.Drawing.Point(20, 184);
            this.grlDatos.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.grlDatos.Name = "grlDatos";
            this.grlDatos.ReadOnly = true;
            this.grlDatos.Size = new System.Drawing.Size(1012, 214);
            this.grlDatos.TabIndex = 2;
            // 
            // lblConsulta
            // 
            this.lblConsulta.AutoSize = true;
            this.lblConsulta.Location = new System.Drawing.Point(18, 7);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(142, 12);
            this.lblConsulta.TabIndex = 3;
            this.lblConsulta.Text = "Consulta en SQL";
            // 
            // frmBaseDatosConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 415);
            this.Controls.Add(this.lblConsulta);
            this.Controls.Add(this.grlDatos);
            this.Controls.Add(this.cmdConsulta);
            this.Controls.Add(this.txtConsulta);
            this.Font = new System.Drawing.Font("Engravers MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "frmBaseDatosConsulta";
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.frmBaseDatosConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grlDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Button cmdConsulta;
        private System.Windows.Forms.DataGridView grlDatos;
        private System.Windows.Forms.Label lblConsulta;
    }
}