using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class NodoProducto
    {
        public Producto Dato;
        public NodoProducto izq;
        public NodoProducto derecha;
        public NodoProducto(Producto producto)
        {
            Dato = producto;
            izq= null;
            derecha = null;
        }
    }
}
