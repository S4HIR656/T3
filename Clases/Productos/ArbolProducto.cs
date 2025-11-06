using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clases
{
    public class ArbolProducto
    {
        public NodoCliente raiz = null;
        private void InsertarRec(NodoCliente actual, NodoCliente nuevo)
        {
            if (nuevo.Dato.Id < actual.Dato.Id)
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
            else if (nuevo.Dato.Id > actual.Dato.Id)
            {
                if (actual.derecha == null)
                    actual.derecha = nuevo;
                else
                    InsertarRec(actual.derecha, nuevo);
            }
            else
            {
                MessageBox.Show($"El producto con ID {nuevo.Dato.Id} ya existe.",
                                "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void Insertar(Producto producto)
        {
            NodoCliente nuevo = new NodoCliente(producto);
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
                dgv.Rows.Add(nodo.Dato.Id, nodo.Dato.Nombre, nodo.Dato.Precio, nodo.Dato.Stock);
                Llenar(nodo.derecha, dgv);
            }
        }
        public void Modificar(int id, string nuevoNombre, double nuevoPrecio, int nuevoStock)
        {
            NodoCliente nodo = Buscar(raiz, id);
            if (nodo != null)
            {
                nodo.Dato.Nombre = nuevoNombre;
                nodo.Dato.Precio = nuevoPrecio;
                nodo.Dato.Stock = nuevoStock;
                MessageBox.Show("Producto modificado correctamente");
            }
            else
            {
                MessageBox.Show("No se encontró el producto con ese ID");
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
            if (id == actual.Dato.Id)
            {
                return actual;
            }
            if (id < actual.Dato.Id)
            {
                return Buscar(actual.izq, id);
            }
            else
            {
                return Buscar(actual.izq, id);
            }
        }
        public void eliminar(int id) 
        {
            raiz = eliminart(raiz, id);
        }
        private NodoCliente eliminart(NodoCliente nodo, int id) 
        {
            if (nodo == null)
            {
                MessageBox.Show("No se encontró el producto con ese ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            if (id < nodo.Dato.Id) 
            {
                nodo.izq = eliminart(nodo.izq, id);
            }
            else if (id > nodo.Dato.Id) 
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
                    NodoCliente min = encontrarmin(nodo.derecha);
                    nodo.Dato = min.Dato;
                    nodo.derecha = eliminart(nodo.derecha, min.Dato.Id);
                }
                MessageBox.Show("Producto eliminado correctamente", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return nodo;
        }
        public NodoCliente encontrarmin(NodoCliente nodo) 
        {
            while (nodo.izq != null)
                nodo = nodo.izq;
            return nodo;
        }
    }
}

