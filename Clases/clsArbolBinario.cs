using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuraDatos.Clases
{
    
    internal class clsArbolBinario
    {
        private clsNodo Inicio;


        public clsNodo Raiz
        {
            get { return Inicio; }
            set { Inicio = value;}

        }

        public void cmdAgregar(clsNodo Nvo)
        {
            Nvo.Izquierdo = null;
            Nvo.Derecho = null;
            if (Raiz == null)
            {
                Raiz = Nvo;
            }
            else
            {
                clsNodo NodoPadre = Raiz; //ant
                clsNodo Aux = Raiz;
                while (Aux != null)
                {
                    NodoPadre = Aux;
                    if (Nvo.Codigo < Aux.Codigo)
                    {
                        Aux = Aux.Izquierdo;
                    }
                    else
                    {
                        Aux = Aux.Derecho;
                    }
                }
                if (Nvo.Codigo < NodoPadre.Codigo)
                {
                    NodoPadre.Izquierdo = Nvo;
                }
                else
                {
                    NodoPadre.Derecho = Nvo;
                }

            }
        }
        public void cmdRecorrer(ListBox Lista)
        {
            Lista.Items.Clear();
            InOrdenAsc(Lista, Raiz);
        }
        public void InOrdenAsc(ListBox Lst, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(Lst, R.Izquierdo);
            Lst.Items.Add(R.Codigo);
            if(R.Derecho != null) InOrdenAsc(Lst, R.Derecho);
        }
        public void InOrdenAsc(DataGridView Grl, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(Grl, R.Izquierdo);
            Grl.Rows.Add(R.Codigo);
            if (R.Derecho != null) InOrdenAsc(Grl, R.Derecho);
        }
    }
}
