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
using T3.Formularios;

namespace T3
{
    public partial class Form1 : Form
    {
        public static ArbolClientes arbolGlobalClientes = new ArbolClientes();
        public static ArbolProducto arbolGlobalProductos = new ArbolProducto();
        public Form1()
        {
            InitializeComponent();
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormVentas objetoFormVentas = new FormVentas(Form1.arbolGlobalClientes, Form1.arbolGlobalProductos);
            objetoFormVentas.ShowDialog();
        }
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            FormClientes fc = new FormClientes(Form1.arbolGlobalClientes);
            fc.ShowDialog(); 
        }
        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            FormProductos objetoFormProducto = new FormProductos(Form1.arbolGlobalProductos);
            objetoFormProducto.ShowDialog();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            FormBuscarComprobante objetoFormBuscarComprobante = new FormBuscarComprobante(arbolGlobalProductos);
            objetoFormBuscarComprobante.ShowDialog();
        }
    }
}
