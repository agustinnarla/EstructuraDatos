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
            objArbolBinario.cmdRecorrer(lstCodigo);

            txtTramite.Text = "";
            txtCodigo.Text = "";
            txtNombre.Text = "";
        }

        private void btnAscendente_CheckedChanged(object sender, EventArgs e)
        {
            objArbolBinario.cmdRecorrer(grlDatos);
            objArbolBinario.cmdRecorrer(lstDatos);
            objArbolBinario.cmdRecorrer(lstCodigo);
        }

        private void btnDescendente_CheckedChanged(object sender, EventArgs e)
        {
            objArbolBinario.cmdRecorrerDsc(grlDatos);
            objArbolBinario.cmdRecorrerDsc(lstDatos);
            objArbolBinario.cmdRecorrerDsc(lstCodigo);
        }

        private void btnPreOrden_CheckedChanged(object sender, EventArgs e)
        {
            objArbolBinario.cmdRecorrerPre(grlDatos);
            objArbolBinario.cmdRecorrerPre(lstDatos);
            objArbolBinario.cmdRecorrerPre(lstCodigo);
        }

        private void btnPost_CheckedChanged(object sender, EventArgs e)
        {
            objArbolBinario.cmdRecorrerPost(grlDatos);
            objArbolBinario.cmdRecorrerPost(lstDatos);
            objArbolBinario.cmdRecorrerPost(lstCodigo);
        }
    }
}
