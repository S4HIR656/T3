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

        private cliente clienteSeleccionado = null;
        private Producto productoSeleccionado = null;
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
                dgvcliente.Columns.Add("Id", "ID");
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
                int idCliente = int.Parse(fila.Cells["Id"].Value.ToString());

                
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
              
                list_Productos.Items.Add($"{productoSeleccionado.Nombre} | Precio: S/{productoSeleccionado.Precio:F2}");

               
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (list_Productos.SelectedIndex >= 0)
            {
                list_Productos.Items.RemoveAt(list_Productos.SelectedIndex);

                // Recalcular total
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
    }

}
