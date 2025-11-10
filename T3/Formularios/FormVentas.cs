using Clases;
using Clases.Clientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T3.Formularios
{
    public partial class FormVentas : Form
    {
        private ArbolClientes arbolClientes;
        private ArbolProducto arbolProductos;
        public static ListaComprobantes listaComprobantes = new ListaComprobantes();
        private cliente clienteSeleccionado = null;
        private Producto productoSeleccionado = null;
        private int numeroFacturaSecuencial = 1; 
        private Random rnd = new Random();
        public FormVentas(ArbolClientes clientes, ArbolProducto productos)
        {
            InitializeComponent();
            arbolClientes = clientes;    
            arbolProductos = productos;
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {
            
            if (dgvcliente.Columns.Count == 0)
            {
                dgvcliente.Columns.Add("DNI", "DNI");
                dgvcliente.Columns.Add("Nombre", "Nombre");
                dgvcliente.Columns.Add("Apellido", "Apellido");
                dgvcliente.Columns.Add("Telefono", "Teléfono");
            }

          
            if (dgvproductos.Columns.Count == 0)
            {
                dgvproductos.Columns.Add("Id", "ID");
                dgvproductos.Columns.Add("Nombre", "Nombre");
                dgvproductos.Columns.Add("Precio", "Precio");
                dgvproductos.Columns.Add("Stock", "Stock");
            }

           
           

          
            dgvcliente.Rows.Clear();
            dgvproductos.Rows.Clear();

           
            arbolClientes.Llenar(arbolClientes.raiz, dgvcliente);
            arbolProductos.Llenar(arbolProductos.raiz, dgvproductos);
        }

        private void dgvcliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvcliente.Rows[e.RowIndex];
                int idCliente = int.Parse(fila.Cells["DNI"].Value.ToString());

                
                clienteSeleccionado = arbolClientes.Buscando(idCliente)?.dato;

                if (clienteSeleccionado != null)
                {
                    txtidcliente.Text = clienteSeleccionado.Id.ToString();
                    txtnombrecliente.Text = clienteSeleccionado.Nombre;
                    txtappaterno.Text = clienteSeleccionado.Apellido;
                    txttelefono.Text = clienteSeleccionado.Telefono;
                }
            }
        }

        
        private void dgvproductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvproductos.Rows[e.RowIndex];
                int idProducto = int.Parse(fila.Cells["Id"].Value.ToString());

               
                productoSeleccionado = arbolProductos.Buscar(idProducto)?.Dato;

                if (productoSeleccionado != null)
                {
                    txtidproducto.Text = productoSeleccionado.Id.ToString();
                    txtnombreproducto.Text = productoSeleccionado.Nombre;
                    txtprecio.Text = productoSeleccionado.Precio.ToString("F2");
                    txtstock.Text = productoSeleccionado.Stock.ToString();
                }
            }
        }

        
        private void btnProductos_Click(object sender, EventArgs e)
        {
            if (clienteSeleccionado == null || productoSeleccionado == null)
            {
                MessageBox.Show("Seleccione un cliente y un producto antes de agregar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            try
            {
              
                double precio = double.Parse(txtprecio.Text);
                string nombre = txtnombreproducto.Text;
                
                CalcularTotalPagar();
            }
            catch
            {
                MessageBox.Show("Error al agregar el producto. Verifique los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void CalcularTotalPagar()
        {
            double total = 0;


        }

       

        private void dgvresumendeventa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            double total = 0;

            int numeroFactura = new Random().Next(1000, 9999);
          

            MessageBox.Show($"Factura {numeroFactura} generada. Total: {total:C2}", "Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);

           
          
            clienteSeleccionado = null;
            productoSeleccionado = null;
            txtidcliente.Clear();
            txtnombrecliente.Clear();
            txtappaterno.Clear();
            txtidproducto.Clear();
            txtnombreproducto.Clear();
            txtprecio.Clear();
            txtstock.Clear();
           
        }

        private void btnseleccliente_Click(object sender, EventArgs e)
        {
            if (clienteSeleccionado != null)
            {
                lblCliente.Text = $"{clienteSeleccionado.Nombre} {clienteSeleccionado.Apellido}";

                // NO limpiar txtidcliente ni deseleccionar el cliente aún
                // Se hará después de generar el comprobante
            }
            else
            {
                MessageBox.Show("No ha seleccionado ningún cliente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAgreproducto_Click(object sender, EventArgs e)
        {
            if (productoSeleccionado != null)
            {
                // Agrega el producto al ListBox
                list_Productos.Items.Add($"{productoSeleccionado.Nombre} | Precio: S/{productoSeleccionado.Precio:F2}");

                // Calcula el total
                double total = 0;
                foreach (var item in list_Productos.Items)
                {
                    string texto = item.ToString();
                    int indicePrecio = texto.IndexOf("S/") + 2;
                    string precioStr = texto.Substring(indicePrecio);
                    total += double.Parse(precioStr);
                }
                lbltventa.Text = $"Total: S/{total:F2}";

                // Limpia los TextBox del producto
                txtidproducto.Clear();
                txtnombreproducto.Clear();
                txtprecio.Clear();
                txtstock.Clear();

                // Opcional: deseleccionar el producto
                productoSeleccionado = null;
            }
            else
            {
                MessageBox.Show("No ha seleccionado ningún producto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (list_Productos.SelectedIndex >= 0)
            {
                list_Productos.Items.RemoveAt(list_Productos.SelectedIndex);

               
                double total = 0;
                foreach (var item in list_Productos.Items)
                {
                    string texto = item.ToString();
                    int indicePrecio = texto.IndexOf("S/") + 2;
                    string precioStr = texto.Substring(indicePrecio);
                    total += double.Parse(precioStr);
                }

                lbltventa.Text = $"Total: S/{total:F2}";
            }
        }

        private void btnGcomprobante_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"ID Cliente: {txtidcliente.Text}");

            if (string.IsNullOrEmpty(lblCliente.Text))
            {
                MessageBox.Show("Seleccione un cliente antes de generar el comprobante.");
                return;
            }

            if (list_Productos.Items.Count == 0)
            {
                MessageBox.Show("No ha agregado ningún producto.");
                return;
            }

            // Número de factura aleatorio de 15 dígitos
            Random rnd = new Random();
            string numeroFactura = "";
            for (int i = 0; i < 15; i++)
                numeroFactura += rnd.Next(0, 10).ToString();

            // Datos del cliente
            string[] cliente = lblCliente.Text.Split(' ');
            string nombre = cliente[0];
            string apellido = cliente.Length > 1 ? cliente[1] : "";
            string telefono = txttelefono.Text;
            string idCliente = txtidcliente.Text;

            // Productos
            string productos = "";
            foreach (var item in list_Productos.Items)
            {
                productos += item.ToString() + ";"; // separador ;
            }

            // Total
            double total = 0;
            foreach (var item in list_Productos.Items)
            {
                string texto = item.ToString();
                int indicePrecio = texto.IndexOf("S/") + 2;
                double precio = double.Parse(texto.Substring(indicePrecio));
                total += precio;
            }

            // Fecha
            string fecha = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            // Crear comprobante
            Comprobante c = new Comprobante(numeroFactura, idCliente, nombre, apellido, telefono, fecha, productos, total);

            // Guardar **solo un comprobante por cliente** (sobrescribe si ya existe)
            FormVentas.listaComprobantes.Agregar(c); // Si quieres sobrescribir, primero limpia la lista

            // Mensaje
            MessageBox.Show(
                $"Comprobante generado!\nFactura: {numeroFactura}\nCliente: {nombre} {apellido}\nProdcutos: \n {productos}\nTotal: S/{total:F2}",
                "Comprobante",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            // Limpiar UI
            lblCliente.Text = "";
            txtidcliente.Clear();
            txttelefono.Clear();
            list_Productos.Items.Clear();
            lbltventa.Text = "Total: S/0.00";
            clienteSeleccionado = null;
        }

        private void txtbuscarclientes_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtbuscarclientes.Text.Trim(); // Texto ingresado

            dgvcliente.Rows.Clear(); // Limpiamos el grid para mostrar solo coincidencias

            if (string.IsNullOrEmpty(filtro))
            {
                // Si no hay texto, mostramos todos
                arbolClientes.Llenar(arbolClientes.raiz, dgvcliente);
                return;
            }

            // Recorremos todos los clientes y agregamos los que coincidan
            FiltrarClientes(arbolClientes.raiz, filtro);
        }

        private void FiltrarClientes(NodoCliente nodo, string filtro)
        {
            if (nodo != null)
            {
                FiltrarClientes(nodo.izq, filtro);

                // Comprobamos si el Id o Nombre contiene el filtro
                string idStr = nodo.dato.Id.ToString();
                string nombre = nodo.dato.Nombre.ToLower();
                string apellido = nodo.dato.Apellido.ToLower();
                string filtroLower = filtro.ToLower();

                if (idStr.Contains(filtro) || nombre.Contains(filtroLower) || apellido.Contains(filtroLower))
                {
                    dgvcliente.Rows.Add(nodo.dato.Id, nodo.dato.Nombre, nodo.dato.Apellido, nodo.dato.Telefono);
                }

                FiltrarClientes(nodo.derecha, filtro);
            }
        }

        private void buscarproducto_TextChanged(object sender, EventArgs e)
        {
            string filtro = buscarproducto.Text.Trim();
            dgvproductos.Rows.Clear();

            if (string.IsNullOrEmpty(filtro))
            {
                arbolProductos.Llenar(arbolProductos.raiz, dgvproductos);
                return;
            }

            FiltrarProductos(arbolProductos.raiz, filtro);
        }
        private void FiltrarProductos(NodoProducto nodo, string filtro)
        {
            if (nodo != null)
            {
                FiltrarProductos(nodo.izq, filtro);

                string idStr = nodo.Dato.Id.ToString();
                string nombre = nodo.Dato.Nombre.ToLower();
                string filtroLower = filtro.ToLower();

                if (idStr.Contains(filtro) || nombre.Contains(filtroLower))
                {
                    dgvproductos.Rows.Add(nodo.Dato.Id, nodo.Dato.Nombre, nodo.Dato.Precio, nodo.Dato.Stock);
                }

                FiltrarProductos(nodo.derecha, filtro);
            }
        }

        private void txtidcliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvcliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
