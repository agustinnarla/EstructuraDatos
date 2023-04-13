using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuraDatos
{
    internal class clsCola
    {

        public clsNodo Primero;
        public clsNodo Ultimo;
        
        public void cmdAgregar(clsNodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;
                Ultimo = Nuevo;
            }
            else
            {
                Ultimo.Siguiente = Nuevo;
                Ultimo = Nuevo;
            }

        }
        public void cmdEliminar() 
        {
            if (Primero != null)
            {
                if (Primero == Ultimo)
                {

                    Primero = null;
                    Ultimo = null;

                }
                else
                {
                    Primero = Primero.Siguiente;

                }
            }
            else
            {
                MessageBox.Show("Cola no existe");
            }
        }

        public void cmdRecorrer(DataGridView Grilla) 
        {
            clsNodo aux = Primero;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;

            }
        }
        public void cmdRecorrer(ListBox Lista)
        {
            clsNodo aux = Primero;
            Lista.Items.Clear();
            while (aux != null)
            {
                Lista.Items.Add(aux.Codigo + " " + aux.Nombre + " " + aux.Tramite);
                aux = aux.Siguiente;
            }
        }
        public void cmdRecorrer(ComboBox Combo)
        {
            clsNodo aux = Primero;
            Combo.Items.Clear();
            while (aux != null)
            {
                Combo.Items.Add(aux.Nombre);
                aux = aux.Siguiente;
            }
        }
        
    }

}

