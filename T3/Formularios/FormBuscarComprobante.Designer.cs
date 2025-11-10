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
            this.lbltotal = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblIVA = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgbproductos = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblapmaterno = new System.Windows.Forms.Label();
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
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbproductos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbltotal);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.lblIVA);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lblfechaventa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblnumerofactura);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtBuscar);
            this.groupBox1.Controls.Add(this.textBusc);
            this.groupBox1.Location = new System.Drawing.Point(103, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 368);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar Número de factura:";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(568, 343);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(22, 13);
            this.lbltotal.TabIndex = 14;
            this.lbltotal.Text = "-----";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(528, 343);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Total:";
            // 
            // lblIVA
            // 
            this.lblIVA.AutoSize = true;
            this.lblIVA.Location = new System.Drawing.Point(568, 330);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(22, 13);
            this.lblIVA.TabIndex = 12;
            this.lblIVA.Text = "-----";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgbproductos);
            this.groupBox3.Location = new System.Drawing.Point(9, 177);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(575, 150);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Productos";
            // 
            // dgbproductos
            // 
            this.dgbproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbproductos.Location = new System.Drawing.Point(-3, 16);
            this.dgbproductos.Name = "dgbproductos";
            this.dgbproductos.RowHeadersWidth = 51;
            this.dgbproductos.Size = new System.Drawing.Size(578, 134);
            this.dgbproductos.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(528, 330);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "IVA:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblapmaterno);
            this.groupBox2.Controls.Add(this.lblappaterno);
            this.groupBox2.Controls.Add(this.lblnombres);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(9, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(575, 78);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Cliente";
            // 
            // lblapmaterno
            // 
            this.lblapmaterno.AutoSize = true;
            this.lblapmaterno.Location = new System.Drawing.Point(492, 38);
            this.lblapmaterno.Name = "lblapmaterno";
            this.lblapmaterno.Size = new System.Drawing.Size(22, 13);
            this.lblapmaterno.TabIndex = 10;
            this.lblapmaterno.Text = "-----";
            // 
            // lblappaterno
            // 
            this.lblappaterno.AutoSize = true;
            this.lblappaterno.Location = new System.Drawing.Point(276, 38);
            this.lblappaterno.Name = "lblappaterno";
            this.lblappaterno.Size = new System.Drawing.Size(22, 13);
            this.lblappaterno.TabIndex = 9;
            this.lblappaterno.Text = "-----";
            // 
            // lblnombres
            // 
            this.lblnombres.AutoSize = true;
            this.lblnombres.Location = new System.Drawing.Point(61, 38);
            this.lblnombres.Name = "lblnombres";
            this.lblnombres.Size = new System.Drawing.Size(22, 13);
            this.lblnombres.TabIndex = 8;
            this.lblnombres.Text = "-----";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(397, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Telefono: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(193, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Apellidos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Nombres:";
            // 
            // lblfechaventa
            // 
            this.lblfechaventa.AutoSize = true;
            this.lblfechaventa.Location = new System.Drawing.Point(473, 61);
            this.lblfechaventa.Name = "lblfechaventa";
            this.lblfechaventa.Size = new System.Drawing.Size(22, 13);
            this.lblfechaventa.TabIndex = 5;
            this.lblfechaventa.Text = "-----";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha de Venta:";
            // 
            // lblnumerofactura
            // 
            this.lblnumerofactura.AutoSize = true;
            this.lblnumerofactura.Location = new System.Drawing.Point(138, 60);
            this.lblnumerofactura.Name = "lblnumerofactura";
            this.lblnumerofactura.Size = new System.Drawing.Size(22, 13);
            this.lblnumerofactura.TabIndex = 3;
            this.lblnumerofactura.Text = "-----";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Factura N°:";
            // 
            // BtBuscar
            // 
            this.BtBuscar.Location = new System.Drawing.Point(509, 19);
            this.BtBuscar.Name = "BtBuscar";
            this.BtBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtBuscar.TabIndex = 1;
            this.BtBuscar.Text = "Buscar";
            this.BtBuscar.UseVisualStyleBackColor = true;
            this.BtBuscar.Click += new System.EventHandler(this.BtBuscar_Click);
            // 
            // textBusc
            // 
            this.textBusc.Location = new System.Drawing.Point(6, 19);
            this.textBusc.Name = "textBusc";
            this.textBusc.Size = new System.Drawing.Size(489, 20);
            this.textBusc.TabIndex = 0;
            // 
            // FormBuscarComprobante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormBuscarComprobante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBuscarComprobante";
            this.Load += new System.EventHandler(this.FormBuscarComprobante_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgbproductos)).EndInit();
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
        private System.Windows.Forms.Label lblIVA;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgbproductos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblapmaterno;
        private System.Windows.Forms.Label lblappaterno;
        private System.Windows.Forms.Label lblnombres;
    }
}