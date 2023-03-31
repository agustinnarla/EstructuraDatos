using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDatos
{
    internal class Cola
    {

        public Nodo Primero;
        public Nodo Ultimo;
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
            
        }

        public void cmdRecorrer() 
        {

        }
    }
}
