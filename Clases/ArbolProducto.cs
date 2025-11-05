using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class ArbolProducto
    {
       public NodoProducto raiz = null;
        private void InsertarRec(NodoProducto actual, NodoProducto nuevo)
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
            else
            {
                if (actual.derecha == null)
                    actual.derecha = nuevo;
                else
                    InsertarRec(actual.derecha, nuevo);
            }
        }
        public void Insertar(Producto producto)
        {
            NodoProducto nuevo = new NodoProducto(producto);
            if (raiz == null) 
            { 
                raiz = nuevo;
            }
            else 
            { 
                InsertarRec(raiz, nuevo);
            }   
        }
        public NodoProducto Buscando(int id)
        {
            return Buscar(raiz, id);
        }

        private NodoProducto Buscar(NodoProducto actual, int id)
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
        public void MostrarInOrden()
        {
            Ordenar(raiz);
        }

        private void Ordenar(NodoProducto nodo)
        {
            if (nodo != null)
            {
                Ordenar(nodo.izq);
                Console.WriteLine($"ID: {nodo.Dato.Id}, Nombre: {nodo.Dato.Nombre}, Precio: {nodo.Dato.Precio}, Stock: {nodo.Dato.Stock}");
                Ordenar(nodo.derecha);
            }
        }

    }
}
