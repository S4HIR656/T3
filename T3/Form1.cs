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

namespace T3
{
    public partial class Form1 : Form
    {
        ArbolProducto arbol = new ArbolProducto();
        public Form1()
        {
            InitializeComponent();
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Formularios.FormVentas objetoFormVentas= new Formularios.FormVentas();
            objetoFormVentas.ShowDialog();
        }
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Formularios.FormClientes objetoFormClientes= new Formularios.FormClientes();
            objetoFormClientes.ShowDialog();
        }
        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Formularios.FormProductos objetoFormProducto=new Formularios.FormProductos();
            objetoFormProducto.ShowDialog();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Formularios.FormBuscarComprobante objetoFormBuscarComprobante = new Formularios.FormBuscarComprobante();
            objetoFormBuscarComprobante.ShowDialog();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Formularios.FormReportePorfechas objetoFormReportePorfechas = new Formularios.FormReportePorfechas();
            objetoFormReportePorfechas.ShowDialog();
        }
    }
}
