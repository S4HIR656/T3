using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class NodoCliente
    {
        public Producto Dato;
        public NodoCliente izq;
        public NodoCliente derecha;
        public NodoCliente(Producto producto)
        {
            Dato = producto;
            izq= null;
            derecha = null;
        }
    }
}
