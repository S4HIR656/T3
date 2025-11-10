using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Comprobante
    {
        public string NumeroFactura;
        public string IdCliente;
        public string NombreCliente;
        public string ApellidoCliente;
        public string TelefonoCliente;
        public string Fecha;
        public string Productos; 
        public double Total;

        public Comprobante(string numero, string idCliente, string nombre, string apellido, string telefono, string fecha, string productos, double total)
        {
            NumeroFactura = numero;
            IdCliente = idCliente;
            NombreCliente = nombre;
            ApellidoCliente = apellido;
            TelefonoCliente = telefono;
            Fecha = fecha;
            Productos = productos;
            Total = total;
        }
    }
}
