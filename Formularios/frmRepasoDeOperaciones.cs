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
    public partial class frmRepasoDeOperaciones : Form
    {
        public frmRepasoDeOperaciones()
        {
            InitializeComponent();
        }

        private void frmRepasoDeOperaciones_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enabled();
        }

        Clases.clsBaseDeDatos objBaseDatos = new Clases.clsBaseDeDatos();
        private void cmdListar_Click(object sender, EventArgs e)
        {
            string varSql = "";

            switch (lstOperaciones.SelectedIndex)
            {
                case 0:
                    lblInfo.Text = lstOperaciones.Text + ": Diferencia entre los campos";
                    varSql = "SELECT * FROM Libro "+
                " where IdIdioma=2 and IdLibro not in " +
                " (SELECT IdLibro FROM Libro where IdPais =3 )" +
                " order by 1 asc";
                    break;
                case 1:
                    lblInfo.Text = lstOperaciones.Text + ": Conjunto de elementos pertenecientes";
                    varSql = "SELECT * FROM Libro " +
                " where IdIdioma=2 and IdLibro not in " +
                " (SELECT IdLibro FROM Libro where IdPais =3 )" +
                " order by 1 asc";
                    break;
                case 2:
                    lblInfo.Text = lstOperaciones.Text + ": Union de conjuntos sin repeticion";
                    varSql = "SELECT * FROM Libro where IdIdioma = 2" +
                    " union " +
                    "SELECT * FROM Libro where IdIdioma = 3";
                    break ;
                case 3:
                    lblInfo.Text = lstOperaciones.Text + ": Juntar elementos";
                    varSql = "SELECT TITULO,NOMBRE " +
                " FROM Libro inner join PAIS " +
                " on Libro.IDPAIS = PAIS.IDPAIS ";
                    break;
                case 4:
                    lblInfo.Text = lstOperaciones.Text + ": Se proyecta solo un atributo";
                    varSql = "SELECT TITULO FROM Libro";
                    break;
                case 5:
                    lblInfo.Text = lstOperaciones.Text + ": Se proyecta solo más de un atributo";
                    varSql = "SELECT TITULO,AÑO FROM Libro";
                    break;
                case 6:
                    lblInfo.Text = lstOperaciones.Text + ": Se selecciona un atributo que cumpla con cierta condicion";
                    varSql = "SELECT TITULO FROM Libro where IdIdioma = 2";
                    break;
                case 7:
                    lblInfo.Text = lstOperaciones.Text + ": Se seleccionan los atributos que cumpla con ambas condicion";
                    varSql = "SELECT * FROM Libro where IdIdioma = 1 AND IdLibro > 30";
                    break;
                case 8:
                    lblInfo.Text = lstOperaciones.Text + ": Se seleccionan los atributos que cumpla con una o otra de las condicion";
                    varSql = "SELECT * FROM Libro where IdIdioma = 1 OR IdLibro > 30";
                    break;
                case 9:
                    lblInfo.Text = lstOperaciones.Text + ": Se seleccionan los atributos que cumpla las condiciones";
                    varSql = "SELECT * " +
                " FROM  (select * from Libro where idIdioma > 1) as X " +
                " WHERE IdPais =  2 ";
                    break;
            }
            objBaseDatos.cmdListar(grlDatos, varSql);
        }
        private void Enabled()
        {
            if (lstOperaciones.SelectedIndex != -1)
            {
                cmdListar.Enabled = true;

            }
            else
            {
                cmdListar.Enabled = false;
            }
        }
    }
}
