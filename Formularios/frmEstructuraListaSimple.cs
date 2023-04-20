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
    public partial class frmEstructuraListaSimple : Form
    {
        public frmEstructuraListaSimple()
        {
            InitializeComponent();
        }

        Clases.clsListaSimple objListaSimple = new Clases.clsListaSimple();
        private void cmdAgregar_Click(object sender, EventArgs e)
        {

            clsNodo objNodo = new clsNodo();
            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;

            objListaSimple.cmdAgregar(objNodo);
            objListaSimple.cmdRecorrer(grlDatos);
            objListaSimple.cmdRecorrer(lstDatos);
            txtTramite.Text = "";
            txtCodigo.Text = "";
            txtNombre.Text = "";

            lstCodigo.Items.Add(objNodo.Codigo);
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (objListaSimple != null)
            {

                Int32 varCod = Convert.ToInt32(lstCodigo.Text);

                lstCodigo.Text = objListaSimple.ToString();

                objListaSimple.cmdEliminar(varCod);
                objListaSimple.cmdRecorrer(grlDatos);
                objListaSimple.cmdRecorrer(lstDatos);
                objListaSimple.cmdRecorrer(lstCodigo);


            }
            //else
            //{
                
            //}
        }
    }
}
