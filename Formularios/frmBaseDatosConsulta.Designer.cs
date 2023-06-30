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
            this.txtConsulta.Location = new System.Drawing.Point(12, 28);
            this.txtConsulta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConsulta.Multiline = true;
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(710, 150);
            this.txtConsulta.TabIndex = 0;
            this.txtConsulta.TextChanged += new System.EventHandler(this.txtConsulta_TextChanged);
            // 
            // cmdConsulta
            // 
            this.cmdConsulta.Enabled = false;
            this.cmdConsulta.Location = new System.Drawing.Point(629, 186);
            this.cmdConsulta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdConsulta.Name = "cmdConsulta";
            this.cmdConsulta.Size = new System.Drawing.Size(93, 38);
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
            this.grlDatos.Location = new System.Drawing.Point(12, 230);
            this.grlDatos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grlDatos.Name = "grlDatos";
            this.grlDatos.ReadOnly = true;
            this.grlDatos.Size = new System.Drawing.Size(710, 268);
            this.grlDatos.TabIndex = 2;
            // 
            // lblConsulta
            // 
            this.lblConsulta.AutoSize = true;
            this.lblConsulta.Location = new System.Drawing.Point(11, 9);
            this.lblConsulta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(92, 15);
            this.lblConsulta.TabIndex = 3;
            this.lblConsulta.Text = "Consulta en SQL";
            // 
            // frmBaseDatosConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(734, 519);
            this.Controls.Add(this.lblConsulta);
            this.Controls.Add(this.grlDatos);
            this.Controls.Add(this.cmdConsulta);
            this.Controls.Add(this.txtConsulta);
            this.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmBaseDatosConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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