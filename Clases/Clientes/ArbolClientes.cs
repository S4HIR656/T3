using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clases.Clientes
{
    public class ArbolClientes
    {
        public NodoCliente raiz = null;

        private void InsertarRec(NodoCliente actual, NodoCliente nuevo)
        {
            if (nuevo.dato.Id < actual.dato.Id)
            {
                if (actual.izq == null)
                {
                    actual.izq = nuevo;
                }
                else
                {
                    InsertarRec(actual.izq, nuevo);
                }
            }
            else if (nuevo.dato.Id > actual.dato.Id)
            {
                if (actual.derecha == null)
                    actual.derecha = nuevo;
                else
                    InsertarRec(actual.derecha, nuevo);
            }
            else
            {
                MessageBox.Show("El ID del cliente ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void Insertar(cliente cliente)
        {
            NodoCliente nuevo = new NodoCliente(cliente);
            if (raiz == null)
            { 
                raiz = nuevo;
            }
            else 
            { 
                InsertarRec(raiz, nuevo);
            }
        }
        public void Llenar(NodoCliente nodo, DataGridView dgv)
        {
            if (nodo != null)
            {
                Llenar(nodo.izq, dgv);
                dgv.Rows.Add(nodo.dato.Id, nodo.dato.Nombre, nodo.dato.Apellido, nodo.dato.Telefono);
                Llenar(nodo.derecha, dgv);
            }
        }
       
        public NodoCliente Buscando(int id)
        {
            return Buscar(raiz, id);
        }


        private NodoCliente Buscar(NodoCliente actual, int id)
        {
            if (actual == null)
            {
                return null;
            }
            if (id == actual.dato.Id)
            {
                return actual;
            }
            if (id < actual.dato.Id)
            {
                return Buscar(actual.izq, id);
            }
            else
            {
                return Buscar(actual.derecha, id);
            }
        }

        public void Eliminar(int id)
        {
            raiz = eliminart(raiz, id);
        }

        private NodoCliente eliminart(NodoCliente nodo, int id)
        {
            if (nodo == null)
            {
                return null;
            }

            if (id < nodo.dato.Id)
            { 
                nodo.izq = eliminart(nodo.izq, id); 
            }
            else if (id > nodo.dato.Id) 
            {
                nodo.derecha = eliminart(nodo.derecha, id);
        }
            else
            {
                if (nodo.izq == null && nodo.derecha == null)  
                {
                    nodo = null;
                }
                else if (nodo.izq == null) 
                {
                    nodo = nodo.derecha;
                }
                else if (nodo.derecha == null) 
                {
                    nodo = nodo.izq; 
                }
                else
                {
                    NodoCliente min = encontrarMin(nodo.derecha);
                    nodo.dato = min.dato;
                    nodo.derecha = eliminart(nodo.derecha, min.dato.Id);
                }

            }

            return nodo;
        }

        private NodoCliente encontrarMin(NodoCliente nodo)
        {
            while (nodo.izq != null) nodo = nodo.izq;
            return nodo;
        }
        public void Modificar(int id, string nuevoNombre, string nuevoTelefono)
        {
            NodoCliente nodo = Buscar(raiz, id);
            if (nodo != null)
            {

                nodo.dato.Nombre = nuevoNombre;
                nodo.dato.Telefono = nuevoTelefono;
                MessageBox.Show("Nombre y/o telefono modificado correctamente");
            }
            else
            {
                MessageBox.Show("No se encontró el cliente con ese ID");
            }
        } 

    }
}
