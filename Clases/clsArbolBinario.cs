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
        private clsNodo[] vecNodo = new clsNodo[100];
       
        private Int32 varIndice= 0;

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
        public void cmdRecorrer(DataGridView Grilla) 
        {
            Grilla.Rows.Clear();
            InOrdenAsc(Grilla, Raiz);
        }
        public void cmdRecorrer(ComboBox Combo)
        {
            Combo.Items.Clear();
            InOrdenAsc(Combo, Raiz);
        }

        public void cmdRecorrerDsc(ListBox Lista)
        {
            Lista.Items.Clear();
            InOrdenDsc(Lista, Raiz);
        }
        public void cmdRecorrerDsc(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenDsc(Grilla, Raiz);
        }
        public void cmdRecorrerDsc(ComboBox Combo)
        {
            Combo.Items.Clear();
            InOrdenDsc(Combo, Raiz);
        }

        public void cmdRecorrerPre(ListBox Lista)
        {
            Lista.Items.Clear();
            PreOrden(Lista, Raiz);
        }
        public void cmdRecorrerPre(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PreOrden(Grilla, Raiz);
        }
        public void cmdRecorrerPre(ComboBox Combo)
        {
            Combo.Items.Clear();
            PreOrden(Combo, Raiz);
        }

        public void cmdRecorrerPreDsc(ListBox Lista)
        {
            Lista.Items.Clear();
            PreOrdenDsc(Lista, Raiz);
        }
        public void cmdRecorrerPreDsc(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PreOrdenDsc(Grilla, Raiz);
        }
        public void cmdRecorrerPreDsc(ComboBox Combo)
        {
            Combo.Items.Clear();
            PreOrden(Combo, Raiz);
        }

        public void cmdRecorrerPost(ListBox Lista)
        {
            Lista.Items.Clear();
            PostOrden(Lista, Raiz);
        }
        public void cmdRecorrerPost(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PostOrden(Grilla, Raiz);
        }
        public void cmdRecorrerPost(ComboBox Combo)
        {
            Combo.Items.Clear();
            PostOrden(Combo, Raiz);
        }

        public void cmdRecorrerPostDsc(ListBox Lista)
        {

            Lista.Items.Clear();
            PostOrdenDsc(Lista, Raiz);
        }
        public void cmdRecorrerPostDsc(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PostOrdenDsc(Grilla, Raiz);
        }
        public void cmdRecorrerPostDsc(ComboBox Combo)
        {
            Combo.Items.Clear();
            PostOrdenDsc(Combo, Raiz);
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
            //DataGridView row = new DataGridView();
            //row.CreateCell(Grl, R.Codigo, R.Nombre, R.Tramite);
            Grl.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Derecho != null) InOrdenAsc(Grl, R.Derecho);
        }
        public void InOrdenAsc(ComboBox Combo, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(Combo, R.Izquierdo);
            Combo.Items.Add(R.Codigo);
            if (R.Derecho != null) InOrdenAsc(Combo, R.Derecho);
        }

        public void InOrdenDsc(ListBox Lst, clsNodo R)
        {
            if (R.Derecho != null) InOrdenDsc(Lst, R.Derecho);
            Lst.Items.Add(R.Codigo);
            if (R.Izquierdo != null) InOrdenDsc(Lst, R.Izquierdo);
        }
        public void InOrdenDsc(DataGridView Grl, clsNodo R)
        {
            if (R.Derecho != null) InOrdenDsc(Grl, R.Derecho);
            Grl.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Izquierdo != null) InOrdenDsc(Grl, R.Izquierdo);
        }
        public void InOrdenDsc(ComboBox Combo, clsNodo R)
        {
            if (R.Derecho != null) InOrdenDsc(Combo, R.Derecho);
            Combo.Items.Add(R.Codigo);
            if (R.Izquierdo != null) InOrdenDsc(Combo, R.Izquierdo);

        }

        public void PreOrden(ListBox Lst, clsNodo R)
        {
            Lst.Items.Add(R.Codigo);
            if (R.Izquierdo != null) PreOrden(Lst, R.Izquierdo);
            if (R.Derecho != null) PreOrden(Lst, R.Derecho);
        }
        public void PreOrden(DataGridView Grl, clsNodo R)
        {
            Grl.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Izquierdo != null) PreOrden(Grl, R.Izquierdo);
            if (R.Derecho != null) PreOrden(Grl, R.Derecho);
        }
        public void PreOrden(ComboBox Combo, clsNodo R)
        {
            Combo.Items.Add(R.Codigo);
            if (R.Izquierdo != null) PreOrden(Combo, R.Izquierdo);
            if (R.Derecho != null) PreOrden(Combo, R.Derecho);
        }

        public void PreOrdenDsc(ListBox Lst, clsNodo R) 
        {
            Lst.Items.Add(R.Codigo);
            if (R.Derecho != null) PreOrdenDsc(Lst, R.Derecho);
            if (R.Izquierdo != null) PreOrdenDsc(Lst, R.Izquierdo);
        }
        public void PreOrdenDsc(DataGridView Grl, clsNodo R)
        {
            Grl.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Derecho != null) PreOrdenDsc(Grl, R.Derecho);
            if (R.Izquierdo != null) PreOrdenDsc(Grl, R.Izquierdo);
        }
        public void PreOrdenDsc(ComboBox Combo, clsNodo R)
        {
            Combo.Items.Add(R.Codigo);
            if (R.Derecho != null) PreOrden(Combo, R.Derecho);
            if (R.Izquierdo != null) PreOrden(Combo, R.Izquierdo);
        }


        public void PostOrden(ListBox Lst, clsNodo R)
        {
            if (R.Izquierdo != null) PostOrden(Lst, R.Izquierdo);
            if (R.Derecho != null) PostOrden(Lst, R.Derecho);
            Lst.Items.Add(R.Codigo);
        }
        public void PostOrden(DataGridView Grl, clsNodo R)
        {
            if (R.Izquierdo != null) PostOrden(Grl, R.Izquierdo);
            if (R.Derecho != null) PostOrden(Grl, R.Derecho);
            Grl.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
        }
        public  void PostOrden(ComboBox Combo, clsNodo R)
        {
            if (R.Izquierdo != null) PostOrden(Combo, R.Izquierdo);
            if (R.Derecho != null) PostOrden(Combo, R.Derecho);
            Combo.Items.Add(R.Codigo);
        }

        public void PostOrdenDsc(ListBox Lst, clsNodo R)
        {
            if (R.Derecho != null) PostOrdenDsc(Lst, R.Derecho);
            if (R.Izquierdo != null) PostOrdenDsc(Lst, R.Izquierdo);
            Lst.Items.Add(R.Codigo);
        }
        public void PostOrdenDsc(DataGridView Grl, clsNodo R)
        {
            if (R.Derecho != null) PostOrdenDsc(Grl, R.Derecho);
            if (R.Izquierdo != null) PostOrdenDsc(Grl, R.Izquierdo);
            Grl.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
        }
        public void PostOrdenDsc(ComboBox Combo, clsNodo R)
        {
            if (R.Derecho != null) PostOrdenDsc(Combo, R.Derecho);
            if (R.Izquierdo != null) PostOrdenDsc(Combo, R.Izquierdo);
            Combo.Items.Add(R.Codigo);
        }

        public void cmdCargarVecotrInOrden(clsNodo NodoPadre)
        {
            if (NodoPadre.Izquierdo != null)
            {
                cmdCargarVecotrInOrden(NodoPadre.Izquierdo);
            }
            vecNodo[varIndice] = NodoPadre;
            varIndice ++;
            if (NodoPadre.Derecho != null)
            {
                cmdCargarVecotrInOrden(NodoPadre.Derecho);
            }
        }
        public void cmdEquilibrar()
        {
            varIndice = 0;
            cmdCargarVecotrInOrden(Raiz);
            Raiz = null;
            cmdEquilibrarArbol(0, varIndice - 1);

        }
        public void cmdEquilibrarArbol(Int32 parInicio, Int32 parFinal)
        {
            Int32 varMed = (parInicio + parFinal) / 2;

            if (parInicio <= parFinal)
            {
                cmdAgregar(vecNodo[varMed]);
                cmdEquilibrarArbol(parInicio, varMed - 1);
                cmdEquilibrarArbol(varMed + 1, parFinal);
            }
        }

        public void cmdEliminar(Int32 parCodigo)
        {
            
        }
    }
}
