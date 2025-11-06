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
    public partial class FormClientes : Form
    {
        public ArbolClientes arbol = new ArbolClientes();
        public FormClientes()
        {
            InitializeComponent();
        }
        private void FormClientes_Load(object sender, EventArgs e)
        {
            if (dgvclientes.Columns.Count == 0)
            {
                dgvclientes.Columns.Add("Id", "ID");
                dgvclientes.Columns.Add("Nombre", "Nombre");
                dgvclientes.Columns.Add("Apellido", "Apellido");
                dgvclientes.Columns.Add("Telefono", "Telefono");
            }

            dgvclientes.AutoGenerateColumns = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
                int id;

                if (!int.TryParse(txtid.Text, out id))
                {
                    MessageBox.Show("El ID debe ser un número válido.");
                    return;
                }

                string nombre = txtnombre.Text;
                string apellidos = txtapellidos.Text;
                string telefono = txttelefono.Text;

                cliente nuevo = new cliente(id, nombre, apellidos, telefono);

                arbol.Insertar(nuevo);

                dgvclientes.Rows.Clear();
                arbol.Llenar(arbol.raiz, dgvclientes);

                MessageBox.Show("Cliente agregado correctamente");

                txtid.Clear();
                txtnombre.Clear();
                txtapellidos.Clear();
                txttelefono.Clear();
                txtid.Focus();
            }
        private void dgvproducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvproducto.Rows[e.RowIndex];
                txtid.Text = fila.Cells["Id"].Value.ToString();
                txtnombreproducto.Text = fila.Cells["Nombre"].Value.ToString();
                txtprecio.Text = fila.Cells["Precio"].Value.ToString();
                txtstock.Text = fila.Cells["Stock"].Value.ToString();
            }
        }
    }
}
