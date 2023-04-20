using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuraDatos.Clases
{
    internal class clsListaSimple
    {
       
        public clsNodo primero;
       

        public void cmdAgregar(clsNodo nuevo)
        {
            if (primero == null)
            {
                primero = nuevo;
            }
            else
            {
                if (nuevo.Codigo <= primero.Codigo)
                {
                    nuevo.Siguiente = primero;
                    primero = nuevo;

                }
                else
                {
                    clsNodo auxiliar = primero;
                    clsNodo anterior = primero;
                    while (nuevo.Codigo > auxiliar.Codigo)
                    {

                        anterior = auxiliar;
                        auxiliar = auxiliar.Siguiente;

                        if (auxiliar == null)
                        {
                            break;
                        }
                    }
                    nuevo.Siguiente = auxiliar;
                    anterior.Siguiente = nuevo;

                }
            }
        }
        public void cmdEliminar(Int32 parCodigo)
        {
            if (primero.Codigo == parCodigo )
            {
                primero = primero.Siguiente;
            }
            else
            {
                clsNodo auxiliar = primero;
                clsNodo anterior = primero;
                while (auxiliar.Codigo != parCodigo)
                {
                    anterior = auxiliar;
                    auxiliar = auxiliar.Siguiente;
                }
                anterior.Siguiente = auxiliar.Siguiente;
            }
        }
        public void cmdRecorrer(DataGridView Grilla)
        {
            clsNodo aux = primero;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;

            }
        }
        public void cmdRecorrer(ListBox Lista)
        {
            clsNodo aux = primero;
            Lista.Items.Clear();
            while (aux != null)
            {
                Lista.Items.Add(aux.Codigo + " " + aux.Nombre + " " + aux.Tramite);
                aux = aux.Siguiente;
            }
        }
        public void cmdRecorrer(ComboBox Combo)
        {
            clsNodo aux = primero;
            Combo.Items.Clear();
            while (aux != null)
            {
                Combo.Items.Add(aux.Codigo);
                aux = aux.Siguiente;
            }
        }
    }
}
