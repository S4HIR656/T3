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
    public partial class FormBuscarComprobante : Form
    {
        private ArbolProducto arbol;
        public FormBuscarComprobante(ArbolProducto arbolExistente)
        {
            InitializeComponent();
            arbol = arbolExistente;
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
            }
        }
    }
}
