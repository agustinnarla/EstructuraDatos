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
            try
            {
                clsNodo objNodo = new clsNodo();

                objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
                objNodo.Nombre = txtNombre.Text;
                objNodo.Tramite = txtTramite.Text;

                objArbolBinario.cmdAgregar(objNodo);

                objArbolBinario.cmdRecorrer(grlDatos);
                objArbolBinario.cmdRecorrer(lstDatos);
                objArbolBinario.cmdRecorrer(lstCodigo);
                objArbolBinario.cmdRecorrer(lstCodigoInfo);
                objArbolBinario.cmdRecorrerTreeView(tvArbolito);

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

        private void btnAscendente_CheckedChanged(object sender, EventArgs e)
        {

                if (btnAscendente.Checked == true)
                {
                    btnAscendentePost.Checked = false;
                    btnAscendentePre.Checked = false;
                    btnDescendentePost.Checked = false;
                    btnDescendentePre.Checked = false;

                    objArbolBinario.cmdRecorrer(grlDatos);
                    objArbolBinario.cmdRecorrer(lstDatos);
                    objArbolBinario.cmdRecorrer(lstCodigo);
                    objArbolBinario.cmdRecorrerTreeView(tvArbolito);
                }
            
           
            
        }

        private void btnDescendente_CheckedChanged(object sender, EventArgs e)
        {
            if (btnDescendente.Checked == true)
            {
                btnAscendentePost.Checked = false;
                btnAscendentePre.Checked = false;
                btnDescendentePost.Checked = false;
                btnDescendentePre.Checked = false;

                objArbolBinario.cmdRecorrerDsc(grlDatos);
                objArbolBinario.cmdRecorrerDsc(lstDatos);
                objArbolBinario.cmdRecorrerDsc(lstCodigo);
            }
          
        }

        private void btnPreOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (btnAscendentePre.Checked == true)
            {
                btnAscendente.Checked = false;
                btnDescendente.Checked = false;
                btnDescendentePost.Checked = false;
                btnAscendentePost.Checked = false;

                objArbolBinario.cmdRecorrerPre(grlDatos);
                objArbolBinario.cmdRecorrerPre(lstDatos);
                objArbolBinario.cmdRecorrerPre(lstCodigo);
            }
           
        }

        private void btnPost_CheckedChanged(object sender, EventArgs e)
        {
            if (btnAscendentePost.Checked == true)
            {
                btnAscendente.Checked = false;
                btnDescendente.Checked = false;
                btnDescendentePre.Checked = false;
                btnAscendentePre.Checked = false;

                objArbolBinario.cmdRecorrerPost(grlDatos);
                objArbolBinario.cmdRecorrerPost(lstDatos);
                objArbolBinario.cmdRecorrerPost(lstCodigo);
            }
       
        }

        private void btnDescendentePre_CheckedChanged(object sender, EventArgs e)
        {
            if (btnDescendentePre.Checked == true)
            {
                btnAscendente.Checked = false;
                btnDescendente.Checked = false;
                btnDescendentePost.Checked = false;
                btnAscendentePost.Checked = false;

                objArbolBinario.cmdRecorrerPreDsc(grlDatos);
                objArbolBinario.cmdRecorrerPreDsc(lstDatos);
                objArbolBinario.cmdRecorrerPreDsc(lstCodigo);
            }
            
        }

        private void btnDescendentePost_CheckedChanged(object sender, EventArgs e)
        {
            if (btnDescendentePost.Checked == true)
            {
                btnAscendente.Checked = false;
                btnDescendente.Checked = false;
                btnDescendentePre.Checked = false;
                btnAscendentePre.Checked = false;

                objArbolBinario.cmdRecorrerPostDsc(grlDatos);
                objArbolBinario.cmdRecorrerPostDsc(lstDatos);
                objArbolBinario.cmdRecorrerPostDsc(lstCodigo);
            }
            
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            int varCodigo = Convert.ToInt32(lstCodigo.Text);
            objArbolBinario.cmdEliminar(varCodigo);
            //error 
            if (objArbolBinario.Raiz != null)
            {
                objArbolBinario.cmdRecorrer(grlDatos);
                objArbolBinario.cmdRecorrer(lstDatos);
                objArbolBinario.cmdRecorrer(lstCodigo);
                objArbolBinario.cmdRecorrer(lstCodigoInfo);
                objArbolBinario.cmdRecorrerTreeView(tvArbolito);
                tvArbolito.ExpandAll();

                if (objArbolBinario.Raiz != null)
                {
                    objArbolBinario.cmdEquilibrar();
                }
               
                txtNombreInfo.Text = "";
                txtTramiteInfo.Text = "";
                lstCodigoInfo.SelectedIndex = -1;

            }
            else 
            {
              
                grlDatos.Rows.Clear();
                lstCodigo.Items.Clear();
                lstDatos.Items.Clear();
                tvArbolito.Nodes.Clear();

            }
            
            lstCodigo.Focus();
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
            if (lstCodigo.SelectedIndex != -1)
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

        private void lstDatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnabledButton();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {

            try
            {
                if (objArbolBinario != null)
                {
                    Int32 varCodigo = Convert.ToInt32(lstCodigoInfo.Text);
                    clsNodo x = objArbolBinario.cmdBuscar(varCodigo);
                    txtNombreInfo.Text = x.Nombre;
                    txtTramiteInfo.Text = x.Tramite;
                }
                lstCodigoInfo.Focus();
            }
            catch (Exception Mensajito)
            {

                MessageBox.Show(Mensajito.Message);
            }
            


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lstCodigoInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
                if (lstCodigoInfo.SelectedIndex > -1)
                {
                    cmdBuscar.Enabled = true;

                }
                else
                {
                    cmdBuscar.Enabled = false;
                }
            
        }

        private void mrcListarDatos_Enter(object sender, EventArgs e)
        {
            EnabledButton();
        }
        public void EnabledButton()
        {
            if (lstDatos.Items.Count > 0)
            {
                mrcPre.Enabled = true;
                mrcPro.Enabled = true;
                mrcListarDatos.Enabled = true;

            }
            else
            {
                mrcPre.Enabled = false;
                mrcPro.Enabled = false;
                mrcListarDatos.Enabled = false;
            }
        }

        private void mrcPro_Enter(object sender, EventArgs e)
        {
            EnabledButton();
        }

        private void mrcPre_Enter(object sender, EventArgs e)
        {
            EnabledButton();
        }
       
        private void frmEstructuraArbolBinario_Load(object sender, EventArgs e)
        {
           
        }

        private void lblAyuda_MouseCaptureChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Para habilitar los otros recorridos, primero cargue los datos y luego haga click en la lista de datos :)");
        }

        private void lblAyuda_Click(object sender, EventArgs e)
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
