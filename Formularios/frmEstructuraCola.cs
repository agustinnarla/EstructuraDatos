using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuraDatos
{
    public partial class frmEstructuraDinamicaLineal_Cola : Form
    {
        public frmEstructuraDinamicaLineal_Cola()
        {
            InitializeComponent();
        }
        clsCola objCola = new clsCola();
        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            clsNodo objNodo = new clsNodo();
            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;

            objCola.cmdAgregar(objNodo);
            objCola.cmdRecorrer(grlDatos);
            objCola.cmdRecorrer(lstDatos);
            txtTramite.Text = "";
            txtCodigo.Text = "";
            txtNombre.Text = "";
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (objCola.Primero != null)
            {
                txtCodigoEliminar.Text = objCola.Primero.Codigo.ToString();
                txtNombreEliminar.Text = objCola.Primero.Nombre;
                txtTramiteEliminar.Text = objCola.Primero.Tramite;

                objCola.cmdEliminar();
                objCola.cmdRecorrer(grlDatos);
                objCola.cmdRecorrer(lstDatos);
                
            }
            else
            {
                txtTramite.Text = "";
                txtCodigo.Text = "";
                txtNombre.Text = "";
            }
        }
    }
}
