using System;
using System.Windows.Forms;
using Clases;
using Clases.Clientes;

namespace T3.Formularios
{
    public partial class FormBuscarComprobante : Form
    {
        private ArbolProducto arbol;
        private ArbolClientes clientes;

        public FormBuscarComprobante()
        {
            InitializeComponent();
        }

        public FormBuscarComprobante(ArbolProducto arbolExistente, ArbolClientes arbolc)
        {
            InitializeComponent();
            arbol = arbolExistente;
            clientes = arbolc;
        }

        private void BtBuscar_Click(object sender, EventArgs e)
        {
            string idCliente = textBusc.Text.Trim();

            if (string.IsNullOrEmpty(idCliente))
            {
                MessageBox.Show("Ingrese un ID de cliente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Comprobante encontrado = FormVentas.listaComprobantes.BuscarPorCliente(idCliente);

            if (encontrado != null)
            {
                lblnumerofactura.Text = encontrado.NumeroFactura;
                lblfechaventa.Text = encontrado.Fecha;
                lblnombres.Text = encontrado.NombreCliente;
                lblappaterno.Text = encontrado.ApellidoCliente;
                lblTelefono.Text = encontrado.TelefonoCliente;

                listProductos.Items.Clear();
                string[] productos = encontrado.Productos.Split(';');
                foreach (string p in productos)
                {
                    if (!string.IsNullOrWhiteSpace(p))
                        listProductos.Items.Add(p);
                }
                lbltotal.Text = $"Total: S/{encontrado.Total:F2}";
            }
            else
            {
                MessageBox.Show("No se encontró ningún comprobante para este cliente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lblnumerofactura.Text = "";
                lblfechaventa.Text = "";
                lblnombres.Text = "";
                lblappaterno.Text = "";
                lblTelefono.Text = "";
                listProductos.Items.Clear();
                lbltotal.Text = "Total: S/0.00";
            }
        }

        
    }
}
