using Clases;
using System;
using System.Collections;
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
    public partial class FormProductos : Form
    {
        private ArbolProducto arbol; // variable privada

        public FormProductos(ArbolProducto arbolExistente)
        {
            InitializeComponent();
            arbol = arbolExistente; // asignamos el árbol global
        }
        private void FormProductos_Load(object sender, EventArgs e)
        {
            if (dgvproducto.Columns.Count == 0)
            {
                dgvproducto.Columns.Add("Id", "ID");
                dgvproducto.Columns.Add("Nombre", "Nombre");
                dgvproducto.Columns.Add("Precio", "Precio");
                dgvproducto.Columns.Add("Cantidad", "Cantidad");
            }

            dgvproducto.Rows.Clear();
            arbol.Llenar(arbol.raiz, dgvproducto); 
        }
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                int id = int.Parse(txtid.Text);
                string nombre = txtnombreproducto.Text;
                double precio = double.Parse(txtprecio.Text);
                int stock = int.Parse(txtstock.Text);

                Producto nuevo = new Producto(id, nombre, precio, stock);
                arbol.Insertar(nuevo);


                dgvproducto.Rows.Clear();
                arbol.Llenar(arbol.raiz, dgvproducto);

                MessageBox.Show("Producto agregado correctamente");

                txtid.Clear();
                txtnombreproducto.Clear();
                txtprecio.Clear();
                txtstock.Clear();
                txtid.Focus();
            }
            catch
            {
                MessageBox.Show("Error: verifica que todos los datos sean correctos.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try 
            {
                int id = int.Parse (txtid.Text);
                string nombre = txtnombreproducto.Text;
                double precio = double.Parse (txtprecio.Text);
                int stock = int.Parse(txtstock.Text);

                arbol.Modificar(id, nombre, precio, stock);
                dgvproducto.Rows.Clear();
                arbol.Llenar(arbol.raiz, dgvproducto);
            }
            catch 
            {
                MessageBox.Show("Error: verifica que todos los datos sean correctos.");
            }
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

        private void button3_Click(object sender, EventArgs e)
        {
            try 
            {
                int id = int.Parse (txtid.Text);
                arbol.eliminar(id);
                dgvproducto.Rows.Clear ();
                arbol.Llenar(arbol.raiz, dgvproducto);

                txtid.Clear();
                txtnombreproducto.Clear();
                txtprecio.Clear();
                txtstock.Clear();
                txtid.Focus();
            }
            catch 
            {
                MessageBox.Show("Error: verifica que el ID no existe.");
            }
        }
    }
}

