namespace T3.Formularios
{
    partial class FormBuscarComprobante
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
            this.listProductos = new System.Windows.Forms.ListBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblappaterno = new System.Windows.Forms.Label();
            this.lblnombres = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblfechaventa = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblnumerofactura = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtBuscar = new System.Windows.Forms.Button();
            this.textBusc = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox1.Controls.Add(this.listProductos);
            this.groupBox1.Controls.Add(this.lbltotal);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lblfechaventa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblnumerofactura);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtBuscar);
            this.groupBox1.Controls.Add(this.textBusc);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(137, 64);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(816, 453);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar DNI del cliente:";
            // 
            // listProductos
            // 
            this.listProductos.BackColor = System.Drawing.Color.MistyRose;
            this.listProductos.FormattingEnabled = true;
            this.listProductos.ItemHeight = 18;
            this.listProductos.Location = new System.Drawing.Point(12, 231);
            this.listProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listProductos.Name = "listProductos";
            this.listProductos.Size = new System.Drawing.Size(795, 148);
            this.listProductos.TabIndex = 15;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(697, 422);
            this.lbltotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(33, 18);
            this.lbltotal.TabIndex = 14;
            this.lbltotal.Text = "-----";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(644, 422);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 18);
            this.label14.TabIndex = 13;
            this.label14.Text = "Total:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox2.Controls.Add(this.lblTelefono);
            this.groupBox2.Controls.Add(this.lblappaterno);
            this.groupBox2.Controls.Add(this.lblnombres);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 114);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(767, 96);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Cliente";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(619, 47);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(33, 18);
            this.lblTelefono.TabIndex = 10;
            this.lblTelefono.Text = "-----";
            // 
            // lblappaterno
            // 
            this.lblappaterno.AutoSize = true;
            this.lblappaterno.Location = new System.Drawing.Point(328, 47);
            this.lblappaterno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblappaterno.Name = "lblappaterno";
            this.lblappaterno.Size = new System.Drawing.Size(33, 18);
            this.lblappaterno.TabIndex = 9;
            this.lblappaterno.Text = "-----";
            // 
            // lblnombres
            // 
            this.lblnombres.AutoSize = true;
            this.lblnombres.Location = new System.Drawing.Point(81, 47);
            this.lblnombres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnombres.Name = "lblnombres";
            this.lblnombres.Size = new System.Drawing.Size(33, 18);
            this.lblnombres.TabIndex = 8;
            this.lblnombres.Text = "-----";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(529, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Teléfono:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Snow;
            this.label7.Location = new System.Drawing.Point(257, 47);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Apellido:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(8, 47);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Nombres:";
            // 
            // lblfechaventa
            // 
            this.lblfechaventa.AutoSize = true;
            this.lblfechaventa.Location = new System.Drawing.Point(631, 75);
            this.lblfechaventa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfechaventa.Name = "lblfechaventa";
            this.lblfechaventa.Size = new System.Drawing.Size(63, 18);
            this.lblfechaventa.TabIndex = 5;
            this.lblfechaventa.Text = "-----------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(508, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha de Venta:";
            // 
            // lblnumerofactura
            // 
            this.lblnumerofactura.AutoSize = true;
            this.lblnumerofactura.Location = new System.Drawing.Point(184, 75);
            this.lblnumerofactura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnumerofactura.Name = "lblnumerofactura";
            this.lblnumerofactura.Size = new System.Drawing.Size(58, 18);
            this.lblnumerofactura.TabIndex = 3;
            this.lblnumerofactura.Text = "----------";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(93, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Factura N°:";
            // 
            // BtBuscar
            // 
            this.BtBuscar.BackColor = System.Drawing.Color.MistyRose;
            this.BtBuscar.Location = new System.Drawing.Point(679, 23);
            this.BtBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtBuscar.Name = "BtBuscar";
            this.BtBuscar.Size = new System.Drawing.Size(100, 28);
            this.BtBuscar.TabIndex = 1;
            this.BtBuscar.Text = "Buscar";
            this.BtBuscar.UseVisualStyleBackColor = false;
            this.BtBuscar.Click += new System.EventHandler(this.BtBuscar_Click);
            // 
            // textBusc
            // 
            this.textBusc.Location = new System.Drawing.Point(8, 23);
            this.textBusc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBusc.Name = "textBusc";
            this.textBusc.Size = new System.Drawing.Size(651, 24);
            this.textBusc.TabIndex = 0;
            // 
            // FormBuscarComprobante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormBuscarComprobante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Comprobante";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtBuscar;
        private System.Windows.Forms.TextBox textBusc;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblnumerofactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblfechaventa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblappaterno;
        private System.Windows.Forms.Label lblnombres;
        private System.Windows.Forms.ListBox listProductos;
         }
    }