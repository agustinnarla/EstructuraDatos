using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuraDatos.Formularios
{
    public partial class frmBaseDatosConsulta : Form
    {
        Clases.clsBaseDeDatos objBaseDatos;
        public frmBaseDatosConsulta()
        {
            InitializeComponent();
        }

        private void frmBaseDatosConsulta_Load(object sender, EventArgs e)
        {
            objBaseDatos = new Clases.clsBaseDeDatos();
        }

        private void cmdConsulta_Click(object sender, EventArgs e)
        {
            String varSql = txtConsulta.Text;
            objBaseDatos.cmdListar(grlDatos, varSql);
        }
        private void Enabled()
        {
            if (txtConsulta.Text != "")
            {
                cmdConsulta.Enabled = true;

            }
            else
            {
                cmdConsulta.Enabled = false;
            }
        }

        private void txtConsulta_TextChanged(object sender, EventArgs e)
        {
            Enabled();
        }
    }
}
