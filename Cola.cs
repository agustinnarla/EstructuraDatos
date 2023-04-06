using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuraDatos
{
    internal class Cola
    {

        public Nodo Primero;
        public Nodo Ultimo;
        public Nodo Auxiliar;
        public void cmdAgregar(Nodo Nuevo)
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
        public void cmdEliminar(Nodo Eliminar) 
        {
            if (Primero != null)
            {
                if (Primero == Ultimo)
                {
                    Primero = Eliminar;
                    Primero = null;
                    Ultimo = null;
                    
                   
                }
                else
                {
                    //Auxiliar = Primero = Ultimo.Siguiente;
                    //Elimianar (Primero)
                    Primero = Auxiliar;
                }
            }
            else
            {
                MessageBox.Show("Cola no existe");
            }
        }

        public void cmdRecorrer(Nodo Axuiliar) 
        {
            if (Primero != null)
            {
                Auxiliar = Primero;
                while (Auxiliar != null)
                {
                    MessageBox.Show(Auxiliar.Nombre);
                    Auxiliar = Auxiliar.Siguiente;
                }
            }
            else
            {
                MessageBox.Show("No hay elementos");
            }
        }
    }
}
