using EstructuraDatos.Clases;
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
    public partial class frmEstructuraArbolBinario : Form
    {
        public frmEstructuraArbolBinario()
        {
            InitializeComponent();
        }

        Clases.clsArbolBinario objArbolBinario = new Clases.clsArbolBinario();

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            clsNodo objNodo = new clsNodo();

            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;

            objArbolBinario.cmdAgregar(objNodo);

            objArbolBinario.cmdRecorrer(grlDatos);

            objArbolBinario.cmdRecorrer(lstDatos);

            txtTramite.Text = "";
            txtCodigo.Text = "";
            txtNombre.Text = "";
        }
    }
}
