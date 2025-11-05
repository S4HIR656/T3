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

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Formularios.FormProductos objetoFormProducto=new Formularios.FormProductos();
            objetoFormProducto.ShowDialog();
        }
    }
}
