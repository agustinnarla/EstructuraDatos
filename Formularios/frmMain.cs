﻿using System;
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
    }
}