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
    public partial class frmEstructuraListaDoble : Form
    {
        public frmEstructuraListaDoble()
        {
            InitializeComponent();
        }
        Clases.clsListaDoble objListaDoble = new Clases.clsListaDoble();

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            clsNodo objNodo = new clsNodo();
            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;

            objListaDoble.cmdAgregar(objNodo);
            objListaDoble.cmdRecorrer(grlDatos);
            objListaDoble.cmdRecorrer(lstDatos);
            objListaDoble.cmdRecorrer(lstCodigo);
            txtTramite.Text = "";
            txtCodigo.Text = "";
            txtNombre.Text = "";

           
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (objListaDoble != null)
            {

                Int32 varCod = Convert.ToInt32(lstCodigo.Text);

                lstCodigo.Text = objListaDoble.ToString();

                objListaDoble.cmdEliminar(varCod);
                objListaDoble.cmdRecorrer(grlDatos);
                objListaDoble.cmdRecorrer(lstDatos);
                objListaDoble.cmdRecorrer(lstCodigo);


            }
        }
    }
}
