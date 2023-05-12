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
            try
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
                txtTramiteEliminar.Text = "";
                txtCodigoEliminar.Text = "";
                txtNombreEliminar.Text = "";
            }
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
            if (lstDatos.Items.Count > -1)
            {
                cmdEliminar.Enabled = true;
            }
            else
            {
                cmdEliminar.Enabled = false;
            }
        }
        private void EnabledElimnarTxt()
        {
            if (txtCodigoEliminar.Text != "" & txtNombreEliminar.Text != "" & txtTramiteEliminar.Text != "")
            {
                cmdEliminar.Enabled = true;
            }
            else
            {
                cmdEliminar.Enabled = false;
            }
        }

        private void frmEstructuraDinamicaLineal_Cola_Load(object sender, EventArgs e)
        {

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

        private void lstDatos_DataSourceChanged(object sender, EventArgs e)
        {
          
        }

        private void lstDatos_Enter(object sender, EventArgs e)
        {
            EnabledEliminar();
        }

        private void txtCodigoEliminar_TextChanged(object sender, EventArgs e)
        {
            EnabledElimnarTxt();
        }

        private void txtNombreEliminar_TextChanged(object sender, EventArgs e)
        {
            EnabledElimnarTxt();
        }

        private void txtTramiteEliminar_TextChanged(object sender, EventArgs e)
        {
            EnabledElimnarTxt();
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
