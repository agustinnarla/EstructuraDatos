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
            try
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

                txtCodigo.Focus();
            }
            catch (Exception Mensajito)
            {
                MessageBox.Show(Mensajito.Message);
                txtTramite.Text = "";
                txtCodigo.Text = "";
                txtNombre.Text = "";

            }



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

        private void mrcListarDatos_Enter(object sender, EventArgs e)
        {

        }

        private void btnAscendente_CheckedChanged(object sender, EventArgs e)
        {
            objListaDoble.cmdRecorrer(grlDatos);
            objListaDoble.cmdRecorrer(lstDatos);
            objListaDoble.cmdRecorrer(lstCodigo);
        }
        private void Enabled()
        {
            if (txtCodigo.Text != "" & txtNombre.Text != "" & txtTramite.Text != "")
            {
                cmdAgregar.Enabled = true;
            }
            else
            {
                cmdAgregar.Enabled = false;
            }
        }
        private void EnabledEliminar()
        {
            if (lstCodigo.SelectedIndex >= 0)
            {
                cmdEliminar.Enabled = true;
            }
            else
            {
                cmdEliminar.Enabled = false;
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            Enabled();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            Enabled();
        }

        private void txtTramite_TextChanged(object sender, EventArgs e)
        {
            Enabled();
        }

        private void lstCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnabledEliminar();
        }

        private void btnDescendente_CheckedChanged(object sender, EventArgs e)
        {
            objListaDoble.cmdRecorrerDsc(grlDatos);
            objListaDoble.cmdRecorrerDsc(lstDatos);
            objListaDoble.cmdRecorrerDsc(lstCodigo);
        }
        private void KeyLetras(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyLetras(sender, e);
        }
    }
}
