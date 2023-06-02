using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;

namespace EstructuraDatos.Clases
{
    internal class clsBaseDeDatos
    {
        //Crea una coneccion
        private OleDbConnection conexion = new OleDbConnection();
        //Da ordenes
        private OleDbCommand comando = new OleDbCommand();
        //Adapta informacion para que lo entienda c#
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private string varCadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Libreria.mdb";
        //private string varCadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Libreria.mdb";

        public void cmdListar(DataGridView Grilla)
        {
            try
            {
                conexion.ConnectionString = varCadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = "Libro";

                adaptador = new OleDbDataAdapter(comando);
                DataSet ds = new DataSet();
                adaptador.Fill(ds, "Libro");

                Grilla.DataSource = null;
                Grilla.DataSource = ds.Tables["Libro"];


                conexion.Close();
            }
            catch (Exception Mensajito)
            {
                MessageBox.Show(Mensajito.Message);
            }
        }
        public void cmdListar(DataGridView Grilla, string varIntruccionSQL)
        {
            try
            {
                conexion.ConnectionString = varCadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = varIntruccionSQL;

                adaptador = new OleDbDataAdapter(comando);
                DataSet ds = new DataSet();
                adaptador.Fill(ds, "Resultado");

                Grilla.DataSource = null;
                Grilla.DataSource = ds.Tables["Resultado"];


                conexion.Close();
            }
            catch (Exception Mensajito)
            {
                MessageBox.Show(Mensajito.Message);
                conexion.Close();
            }
        }

    }
}
