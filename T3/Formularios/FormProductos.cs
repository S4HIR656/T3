using Clases;
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
    public partial class FormProductos : Form
    {
        ArbolProducto arbol = new ArbolProducto();
        public FormProductos()
        {
            InitializeComponent();
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

    }
}
