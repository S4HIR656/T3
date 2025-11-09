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

        private void FormBuscarComprobante_Load(object sender, EventArgs e)
        {
            dgbproductos.Columns.Add("Id", "ID");         
            dgbproductos.Columns.Add("Nombre", "Nombre"); 
            dgbproductos.Columns.Add("Precio", "Precio");
            dgbproductos.Columns.Add("Stock", "Stock");   
        }

        public void BtBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBusc.Text);

                NodoProducto nodo = arbol.Buscando(id);

                dgbproductos.Rows.Clear();

                if (nodo != null)
                {
                    dgbproductos.Rows.Add(
                        nodo.Dato.Id,      
                        nodo.Dato.Nombre,  
                        nodo.Dato.Precio,  
                        nodo.Dato.Stock    
                    );

                    lblnumerofactura.Text = nodo.Dato.Id.ToString();
                    lblnombres.Text = nodo.Dato.Nombre;
                    lblappaterno.Text = nodo.Dato.Nombre.ToString();
                    lblapmaterno.Text = nodo.Dato.Nombre.ToString();


                    MessageBox.Show("Producto encontrado");
                }
                else
                {
                    MessageBox.Show("Producto no encontrado");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Error: el número ingresado no es válido. Debe ser un valor numérico.");
            }
           
        }

    }
}
