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

namespace EstructuraDatos
{
    public partial class frmEstructuraPila : Form
    {
        clsPila objPila = new clsPila();
        public frmEstructuraPila()
        {
            InitializeComponent();
        }
        
        private void frmEstructuraPila_Load(object sender, EventArgs e)
        {
            
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            clsNodo objNodo = new clsNodo();
            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;

            objPila.cmdAgregar(objNodo);
            objPila.cmdRecorrer(grlDatos);
            objPila.cmdRecorrer(lstDatos);
            txtTramite.Text = "";
            txtCodigo.Text = "";
            txtNombre.Text = "";
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (objPila.Primero != null)
            {
                txtCodigoEliminar.Text = objPila.Primero.Codigo.ToString();
                txtNombreEliminar.Text = objPila.Primero.Nombre;
                txtTramiteEliminar.Text = objPila.Primero.Tramite;

                objPila.cmdEliminar();
                objPila.cmdRecorrer(grlDatos);
                objPila.cmdRecorrer(lstDatos);

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
