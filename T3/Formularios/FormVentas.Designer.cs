namespace T3.Formularios
{
    partial class FormVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvcliente = new System.Windows.Forms.DataGridView();
            this.txtbuscarclientes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvproductos = new System.Windows.Forms.DataGridView();
            this.buscarproducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnGcomprobante = new System.Windows.Forms.Button();
            this.lbltventa = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.list_Productos = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnAgreproducto = new System.Windows.Forms.Button();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.txtidproducto = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtnombreproducto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.btnseleccliente = new System.Windows.Forms.Button();
            this.txtidcliente = new System.Windows.Forms.TextBox();
            this.txtappaterno = new System.Windows.Forms.TextBox();
            this.txtnombrecliente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcliente)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductos)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dgvcliente);
            this.groupBox1.Controls.Add(this.txtbuscarclientes);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(635, 211);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clientes Disponibles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(484, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Click para seleccionar";
            // 
            // dgvcliente
            // 
            this.dgvcliente.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvcliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcliente.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvcliente.Location = new System.Drawing.Point(11, 67);
            this.dgvcliente.Margin = new System.Windows.Forms.Padding(4);
            this.dgvcliente.Name = "dgvcliente";
            this.dgvcliente.RowHeadersWidth = 51;
            this.dgvcliente.Size = new System.Drawing.Size(616, 137);
            this.dgvcliente.TabIndex = 2;
            this.dgvcliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcliente_CellClick);
            // 
            // txtbuscarclientes
            // 
            this.txtbuscarclientes.Location = new System.Drawing.Point(81, 34);
            this.txtbuscarclientes.Margin = new System.Windows.Forms.Padding(4);
            this.txtbuscarclientes.Name = "txtbuscarclientes";
            this.txtbuscarclientes.Size = new System.Drawing.Size(393, 22);
            this.txtbuscarclientes.TabIndex = 1;
            this.txtbuscarclientes.TextChanged += new System.EventHandler(this.txtbuscarclientes_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dgvproductos);
            this.groupBox2.Controls.Add(this.buscarproducto);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(727, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(645, 216);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Productos Disponibles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(489, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Click para seleccionar";
            // 
            // dgvproductos
            // 
            this.dgvproductos.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproductos.Location = new System.Drawing.Point(8, 64);
            this.dgvproductos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvproductos.Name = "dgvproductos";
            this.dgvproductos.RowHeadersWidth = 51;
            this.dgvproductos.Size = new System.Drawing.Size(621, 144);
            this.dgvproductos.TabIndex = 2;
            this.dgvproductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproductos_CellClick);
            // 
            // buscarproducto
            // 
            this.buscarproducto.Location = new System.Drawing.Point(81, 34);
            this.buscarproducto.Margin = new System.Windows.Forms.Padding(4);
            this.buscarproducto.Name = "buscarproducto";
            this.buscarproducto.Size = new System.Drawing.Size(399, 22);
            this.buscarproducto.TabIndex = 1;
            this.buscarproducto.TextChanged += new System.EventHandler(this.buscarproducto_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Buscar:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(16, 244);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1354, 453);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resumen de seleccion";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox6.Controls.Add(this.btnGcomprobante);
            this.groupBox6.Controls.Add(this.lbltventa);
            this.groupBox6.Controls.Add(this.btnEliminar);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.lblCliente);
            this.groupBox6.Controls.Add(this.list_Productos);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Location = new System.Drawing.Point(588, 0);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(760, 453);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Resumen Cliente";
            // 
            // btnGcomprobante
            // 
            this.btnGcomprobante.BackColor = System.Drawing.Color.IndianRed;
            this.btnGcomprobante.Location = new System.Drawing.Point(566, 418);
            this.btnGcomprobante.Margin = new System.Windows.Forms.Padding(4);
            this.btnGcomprobante.Name = "btnGcomprobante";
            this.btnGcomprobante.Size = new System.Drawing.Size(165, 27);
            this.btnGcomprobante.TabIndex = 16;
            this.btnGcomprobante.Text = "Generar comprobante";
            this.btnGcomprobante.UseVisualStyleBackColor = false;
            this.btnGcomprobante.Click += new System.EventHandler(this.btnGcomprobante_Click);
            // 
            // lbltventa
            // 
            this.lbltventa.AutoSize = true;
            this.lbltventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltventa.Location = new System.Drawing.Point(566, 392);
            this.lbltventa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltventa.Name = "lbltventa";
            this.lbltventa.Size = new System.Drawing.Size(56, 20);
            this.lbltventa.TabIndex = 15;
            this.lbltventa.Text = "Total: ";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminar.Location = new System.Drawing.Point(695, 48);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(36, 28);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "X";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(339, 23);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 20);
            this.label14.TabIndex = 13;
            this.label14.Text = "Productos:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(96, 76);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(63, 20);
            this.lblCliente.TabIndex = 12;
            this.lblCliente.Text = "---------";
            // 
            // list_Productos
            // 
            this.list_Productos.BackColor = System.Drawing.Color.Gainsboro;
            this.list_Productos.FormattingEnabled = true;
            this.list_Productos.ItemHeight = 16;
            this.list_Productos.Location = new System.Drawing.Point(343, 48);
            this.list_Productos.Margin = new System.Windows.Forms.Padding(4);
            this.list_Productos.Name = "list_Productos";
            this.list_Productos.Size = new System.Drawing.Size(344, 340);
            this.list_Productos.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(96, 23);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 20);
            this.label13.TabIndex = 10;
            this.label13.Text = "Cliente:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnAgreproducto);
            this.groupBox5.Controls.Add(this.txtstock);
            this.groupBox5.Controls.Add(this.txtidproducto);
            this.groupBox5.Controls.Add(this.txtprecio);
            this.groupBox5.Controls.Add(this.txtnombreproducto);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Location = new System.Drawing.Point(8, 219);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(324, 191);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Datos del Producto";
            // 
            // btnAgreproducto
            // 
            this.btnAgreproducto.BackColor = System.Drawing.Color.IndianRed;
            this.btnAgreproducto.Location = new System.Drawing.Point(124, 151);
            this.btnAgreproducto.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgreproducto.Name = "btnAgreproducto";
            this.btnAgreproducto.Size = new System.Drawing.Size(132, 32);
            this.btnAgreproducto.TabIndex = 12;
            this.btnAgreproducto.Text = "Agregar";
            this.btnAgreproducto.UseVisualStyleBackColor = false;
            this.btnAgreproducto.Click += new System.EventHandler(this.btnAgreproducto_Click);
            // 
            // txtstock
            // 
            this.txtstock.Location = new System.Drawing.Point(124, 119);
            this.txtstock.Margin = new System.Windows.Forms.Padding(4);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(171, 22);
            this.txtstock.TabIndex = 6;
            // 
            // txtidproducto
            // 
            this.txtidproducto.Location = new System.Drawing.Point(124, 21);
            this.txtidproducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtidproducto.Name = "txtidproducto";
            this.txtidproducto.Size = new System.Drawing.Size(171, 22);
            this.txtidproducto.TabIndex = 5;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(124, 87);
            this.txtprecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(171, 22);
            this.txtprecio.TabIndex = 7;
            // 
            // txtnombreproducto
            // 
            this.txtnombreproducto.Location = new System.Drawing.Point(124, 53);
            this.txtnombreproducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombreproducto.Name = "txtnombreproducto";
            this.txtnombreproducto.Size = new System.Drawing.Size(171, 22);
            this.txtnombreproducto.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(13, 125);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "Stock:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(8, 91);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Precio:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(8, 62);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Nombre:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(8, 30);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Id Productos:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txttelefono);
            this.groupBox4.Controls.Add(this.btnseleccliente);
            this.groupBox4.Controls.Add(this.txtidcliente);
            this.groupBox4.Controls.Add(this.txtappaterno);
            this.groupBox4.Controls.Add(this.txtnombrecliente);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(8, 23);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(324, 188);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos del Cliente";
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(124, 119);
            this.txttelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(172, 22);
            this.txttelefono.TabIndex = 6;
            // 
            // btnseleccliente
            // 
            this.btnseleccliente.BackColor = System.Drawing.Color.IndianRed;
            this.btnseleccliente.Location = new System.Drawing.Point(124, 149);
            this.btnseleccliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnseleccliente.Name = "btnseleccliente";
            this.btnseleccliente.Size = new System.Drawing.Size(132, 32);
            this.btnseleccliente.TabIndex = 11;
            this.btnseleccliente.Text = "Seleccionar";
            this.btnseleccliente.UseVisualStyleBackColor = false;
            this.btnseleccliente.Click += new System.EventHandler(this.btnseleccliente_Click);
            // 
            // txtidcliente
            // 
            this.txtidcliente.Location = new System.Drawing.Point(124, 21);
            this.txtidcliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtidcliente.Name = "txtidcliente";
            this.txtidcliente.Size = new System.Drawing.Size(172, 22);
            this.txtidcliente.TabIndex = 5;
            // 
            // txtappaterno
            // 
            this.txtappaterno.Location = new System.Drawing.Point(124, 87);
            this.txtappaterno.Margin = new System.Windows.Forms.Padding(4);
            this.txtappaterno.Name = "txtappaterno";
            this.txtappaterno.Size = new System.Drawing.Size(172, 22);
            this.txtappaterno.TabIndex = 7;
            // 
            // txtnombrecliente
            // 
            this.txtnombrecliente.Location = new System.Drawing.Point(124, 53);
            this.txtnombrecliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombrecliente.Name = "txtnombrecliente";
            this.txtnombrecliente.Size = new System.Drawing.Size(172, 22);
            this.txtnombrecliente.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(0, 125);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Teléfono :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 91);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Apellido Paterno:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(0, 57);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nombres:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "DNI Cliente:";
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1383, 711);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVentas";
            this.Load += new System.EventHandler(this.FormVentas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcliente)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvcliente;
        private System.Windows.Forms.TextBox txtbuscarclientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvproductos;
        private System.Windows.Forms.TextBox buscarproducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.TextBox txtidproducto;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtnombreproducto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtidcliente;
        private System.Windows.Forms.TextBox txtappaterno;
        private System.Windows.Forms.TextBox txtnombrecliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAgreproducto;
        private System.Windows.Forms.Button btnseleccliente;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label13;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ListBox list_Productos;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lbltventa;
        private System.Windows.Forms.Button btnGcomprobante;
    }
}