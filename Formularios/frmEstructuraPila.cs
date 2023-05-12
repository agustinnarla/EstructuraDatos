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
            try
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

                txtNombre.Focus();
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

        private void grlDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void mrcElementoEliminados_Enter(object sender, EventArgs e)
        {

        }

        private void lstDatos_SelectedIndexChanged(object sender, EventArgs e)
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

        private void mrcNuevoElemento_Enter(object sender, EventArgs e)
        {
            
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
