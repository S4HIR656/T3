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
        public FormVentas()
        {
            InitializeComponent();
            txtidcliente.ReadOnly = true;
            txtnombrecliente.ReadOnly = true;
            txtappaterno.ReadOnly = true;
            txtapmaterno.ReadOnly = true;

            txtidproducto.ReadOnly = true;
            txtnombreproducto.ReadOnly = true;
            txtprecio.ReadOnly = true;
            txtstock.ReadOnly = true;
            txtprecio.ReadOnly = true;

           
        }
        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtidcliente.Text = dgvcliente.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtnombrecliente.Text = dgvcliente.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtappaterno.Text = dgvcliente.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtapmaterno.Text = dgvcliente.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtidproducto.Text = dgvproductos.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtnombreproducto.Text = dgvproductos.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtprecio.Text = dgvproductos.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtstock.Text = dgvproductos.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtidproducto.Text == "" || txtcantidadventa.Text == "")
            {
                MessageBox.Show("Seleccione un producto e ingrese cantidad");
                return;
            }

            int cantidad = int.Parse(txtcantidadventa.Text);
            double precio = double.Parse(txtprecio.Text);
            string nombre = txtnombreproducto.Text;
        }
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (txtidproducto.Text == "" || txtcantidadventa.Text == "")
            {
                MessageBox.Show("Seleccione un producto e ingrese cantidad");
                return;
            }

            int cantidad = int.Parse(txtcantidadventa.Text);
            double precio = double.Parse(txtprecio.Text);
            string nombre = txtnombreproducto.Text;

            
        }




        private void txtbuscarcliente_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
