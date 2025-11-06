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
                dgvclientes.Columns.Add("Id", "ID");
                dgvclientes.Columns.Add("Nombres", "Nombres");
                dgvclientes.Columns.Add("Apellido", "Apellido");
                dgvclientes.Columns.Add("Telefono", "Teléfono");
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtid.Text);
                string nombre = txtnombre.Text;
                string apellido = txtapellidos.Text;
                string telefono = txttelefono.Text;

                cliente nuevo = new cliente(id, nombre, apellido, telefono);

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
            catch (Exception ex)
            {
                MessageBox.Show("Error: Verifique que todos los datos sean correctos.");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtid.Text);
                string nombre = txtnombre.Text;
                string telefono = txttelefono.Text;

                arbol.Modificar(id, nombre, telefono);
                dgvclientes.Rows.Clear();
                arbol.Llenar(arbol.raiz, dgvclientes);
            }
            catch
            {
                MessageBox.Show("Error: verifica que todos los datos sean correctos.");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtid == null)
                {
                    MessageBox.Show("Ingrese el ID del cliente que desea eliminar.");
                    return;
                }

                int id = int.Parse(txtid.Text);

                NodoCliente nodo = arbol.Buscando(id);
                if (nodo == null)
                {
                    MessageBox.Show("No se encontró un cliente con ese ID.");
                    return;
                }

                DialogResult r = MessageBox.Show("¿Desea eliminar al cliente con ID " + id + "?", "Confirmar eliminación", MessageBoxButtons.YesNo);

                if (r == DialogResult.Yes)
                {
                    arbol.Eliminar(id);

                    dgvclientes.Rows.Clear();
                    arbol.Llenar(arbol.raiz, dgvclientes);

                    MessageBox.Show("Cliente eliminado correctamente.");
                }

                txtid.Clear();
                txtnombre.Clear();
                txtapellidos.Clear();
                txttelefono.Clear();
            }
            catch (Exception ex)
            {   
                MessageBox.Show("Error al eliminar cliente: Verifique el ID");
            }
        }
        private void dgvclientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvclientes.Rows[e.RowIndex];
                txtid.Text = fila.Cells["Id"].Value.ToString();
                txtnombre.Text = fila.Cells["Nombres"].Value.ToString();
                txtapellidos.Text = fila.Cells["Apellido"].Value.ToString();
                txttelefono.Text = fila.Cells["Telefono"].Value.ToString();
            }
        }
    }
}
