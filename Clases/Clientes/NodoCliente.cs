using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Clientes
{
    public class NodoCliente
    {
        
        public cliente dato;
        public NodoCliente izq;
        public NodoCliente derecha;
       
        public NodoCliente(cliente cliente)
        {
            dato = cliente;
            izq = null;
            derecha = null;
        }
    }
}
