using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class nodoComprobante
    {
        public Comprobante date;
        public nodoComprobante Siguiente;

        public nodoComprobante(Comprobante c)
        {
            date = c;
            Siguiente = null;
        }
    }
    public class ListaComprobantes
    {
        public nodoComprobante cabeza = null;

        public void Agregar(Comprobante c)
        {
            nodoComprobante nuevo = new nodoComprobante(c);
            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                nodoComprobante actual = cabeza;
                while (actual.Siguiente != null)
                    actual = actual.Siguiente;
                actual.Siguiente = nuevo;
            }
        }

        // Nuevo método para buscar por IdCliente
        public Comprobante BuscarPorCliente(string idCliente)
        {
            nodoComprobante actual = cabeza;
            while (actual != null)
            {
                if (actual.date.IdCliente == idCliente)
                    return actual.date;
                actual = actual.Siguiente;
            }
            return null;
        }
    }

}
