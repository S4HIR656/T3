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

                // Validar que el ID sea un número
                if (!int.TryParse(txtid.Text, out id))
                {
                    MessageBox.Show("El ID debe ser un número válido.");
                    return;
                }

                string nombre = txtnombre.Text;
                string apellidos = txtapellidos.Text;
                string telefono = txttelefono.Text;

                cliente nuevo = new cliente(id, nombre, apellidos, telefono);

                // Insertar en el árbol (solo mostrará mensaje si existe ID)
                arbol.Insertar(nuevo);

                // Actualizar DataGridView
                dgvclientes.Rows.Clear();
                arbol.Llenar(arbol.raiz, dgvclientes);

                MessageBox.Show("Cliente agregado correctamente");

                txtid.Clear();
                txtnombre.Clear();
                txtapellidos.Clear();
                txttelefono.Clear();
                txtid.Focus();
            }
        
    }
}
