﻿using System;
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
    public partial class frmBaseDatos : Form
    {
        public frmBaseDatos()
        {
            InitializeComponent();
        }
        Clases.clsBaseDeDatos objBaseDatos = new Clases.clsBaseDeDatos();
        private void cmdProyeccionSimple_Click(object sender, EventArgs e)
        {
            String varSql = "SELECT TITULO FROM Libro";
            objBaseDatos.cmdListar(grlDatos, varSql);
        }

        private void cmdPrroyeccionMultiatributo_Click(object sender, EventArgs e)
        {
            String varSql = "SELECT TITULO,AÑO FROM Libro";
            objBaseDatos.cmdListar(grlDatos, varSql);
        }

        private void cmdJuntar_Click(object sender, EventArgs e)
        {
           
        }

        private void cmdSeleccionSimple_Click(object sender, EventArgs e)
        {
            //Seleccion 
            String varSql = "SELECT TITULO FROM Libro where IdIdioma = 2";
            objBaseDatos.cmdListar(grlDatos, varSql);
        }

        private void cmdSeleccionMultiples_Click(object sender, EventArgs e)
        {
            String varSql = "SELECT * FROM Libro where IdIdioma = 1 AND IdLibro > 30";
            objBaseDatos.cmdListar(grlDatos, varSql);
        }
        private void cmdUnion_Click(object sender, EventArgs e)
        {
            String varSql = "SELECT * FROM Libro where IdIdioma = 2" +
                " union " +
                "SELECT * FROM Libro where IdIdioma = 3";
            objBaseDatos.cmdListar(grlDatos, varSql);
        }

        private void cmdSeleccionConvolucion_Click(object sender, EventArgs e)
        {

        }

        private void cmdInterseccion_Click(object sender, EventArgs e)
        {
            String varSql = "SELECT * FROM Libro " +
                " where IdAutor=5 and exists " +
                " (SELECT * FROM Libro where IdIdioma = 3 )";
            objBaseDatos.cmdListar(grlDatos, varSql);
        }

        private void cmdDiferencia_Click(object sender, EventArgs e)
        {
            String varSql = "SELECT * FROM Libro " +
                " where IdIdioma=2 and IdLibro not in " +
                " (SELECT IdLibro FROM Libro where IdPais =3 )" +
                " order by 1 asc";
            objBaseDatos.cmdListar(grlDatos, varSql);
        }
    }
}
