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
    public partial class frmEstructuraDatos : Form
    {
        public frmEstructuraDatos()
        {
            InitializeComponent();
        }

        private void datosProgramadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatos objDatosProgramador = new frmDatos();
            objDatosProgramador.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstructuraDinamicaLineal_Cola objEstructuraDatosCola = new frmEstructuraDinamicaLineal_Cola();
            objEstructuraDatosCola.Show();
        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstructuraPila objEstructuraPila = new frmEstructuraPila();
            objEstructuraPila.Show();
            
        }

        private void simpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.frmEstructuraListaSimple objEstructuraListaSimple = new Formularios.frmEstructuraListaSimple();
            objEstructuraListaSimple.Show();
        }

        private void dobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.frmEstructuraListaDoble objEstructuraListaDoble = new Formularios.frmEstructuraListaDoble();
            objEstructuraListaDoble.Show();
        }

        private void arbolBinarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.frmEstructuraArbolBinario objEstructuraArbolBinario = new Formularios.frmEstructuraArbolBinario();
            objEstructuraArbolBinario.Show();
        }

        private void operacionesDeBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.frmBaseDatos objBaseDatos = new Formularios.frmBaseDatos();
            objBaseDatos.Show();
        }
    }
}
