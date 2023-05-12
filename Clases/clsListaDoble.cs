using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuraDatos.Clases
{
    internal class clsListaDoble
    {
        private clsNodo pri;
        private clsNodo ult;

        public clsNodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }
        public clsNodo Ultimo
        {
            get { return ult; }
            set { ult = value; }
        }

        public void cmdAgregar(clsNodo nuevo)
        {
            if (Primero == null)
            {
                Primero = nuevo;
                Ultimo = nuevo; 
            }
            else
            {
                if (nuevo.Codigo <= Primero.Codigo)
                {
                    nuevo.Siguiente = Primero;
                    Primero.Anterior = Ultimo;
                    Primero = nuevo;
                }
                else
                {
                    if (nuevo.Codigo >= Ultimo.Codigo)
                    {
                        Ultimo.Siguiente = nuevo;
                        nuevo.Anterior = Ultimo;
                        Ultimo = nuevo;
                    }
                    else
                    {
                        clsNodo Aux = Primero;
                        clsNodo Ant = Primero;
                        while (Aux.Codigo < nuevo.Codigo)
                        {
                            Ant = Aux;
                            Aux = Aux.Siguiente;
                        }
                        Ant.Siguiente = nuevo;
                        nuevo.Siguiente = Aux;
                        Aux.Anterior = nuevo;
                        nuevo.Anterior = Ant;
                    }
                 
                }
            }
        }
        public void cmdEliminar(Int32 parCodigo)
        {
            //Si el dato que borro es el ùnico de la lista 
            if (Primero.Codigo == parCodigo && Ultimo == Primero)
            {
                Primero = null;
                Ultimo = null;

            }
            else
            {
                //si el codigo que quiero borrar es el primero
                if (Primero.Codigo == parCodigo)
                {
                    Primero = Primero.Siguiente;
                    Primero.Anterior = null;
                }
                else
                {
                    //si el que borro es el ultimo de la lst
                    if (Ultimo.Codigo == parCodigo)
                    {
                        Ultimo = Ultimo.Anterior;
                        Ultimo.Siguiente = null;
                    }
                    else
                    {
                        //intermedio    
                        clsNodo Aux = Primero;
                        clsNodo Ant = Primero;
                        while (Aux.Codigo < parCodigo)
                        {
                            Ant = Aux;
                            Aux = Aux.Siguiente;
                        }

                        Aux = Aux.Siguiente;
                        Ant.Siguiente = Aux;
                        Aux.Anterior = Ant;
                        //Ant.Siguiente = Aux.Siguiente;
                        //Aux = Aux.Siguiente;
                        //Aux.Anterior = Ant;
                    }
                    
                }
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
                Combo.Items.Add(aux.Codigo);
                aux = aux.Siguiente;
            }
        }
        public void cmdRecorrerDsc(DataGridView Grilla)
        {
            clsNodo aux = Ultimo;
            Grilla.Rows.Clear();

            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Anterior;
            }
        }
        public void cmdRecorrerDsc(ListBox Lista)
        {
            clsNodo aux = Ultimo;
            Lista.Items.Clear();
            while (aux != null)
            {
                Lista.Items.Add(aux.Codigo + " " + aux.Nombre + " " + aux.Tramite);
                aux = aux.Anterior;
            }
        }
        public void cmdRecorrerDsc(ComboBox Combo)
        {
            clsNodo aux = Ultimo;
            Combo.Items.Clear();
            while (aux != null)
            {
                Combo.Items.Add(aux.Nombre);
                aux = aux.Anterior;
            }
        }
    }
}
