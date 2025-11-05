namespace T3.Formularios
{
    partial class FormReportePorfechas
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
            this.lbl = new System.Windows.Forms.Label();
            this.dgvventas = new System.Windows.Forms.DataGridView();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.dtphasta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpdesde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvventas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbltotal);
            this.groupBox1.Controls.Add(this.lbl);
            this.groupBox1.Controls.Add(this.dgvventas);
            this.groupBox1.Controls.Add(this.btnbuscar);
            this.groupBox1.Controls.Add(this.dtphasta);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpdesde);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 346);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta de Ventas por Fecha";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(574, 286);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(22, 13);
            this.lbltotal.TabIndex = 7;
            this.lbltotal.Text = "-----";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(480, 286);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(88, 13);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "Ingresos Totales:";
            // 
            // dgvventas
            // 
            this.dgvventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvventas.Location = new System.Drawing.Point(6, 87);
            this.dgvventas.Name = "dgvventas";
            this.dgvventas.Size = new System.Drawing.Size(599, 196);
            this.dgvventas.TabIndex = 6;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(530, 63);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 5;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            // 
            // dtphasta
            // 
            this.dtphasta.Location = new System.Drawing.Point(336, 37);
            this.dtphasta.Name = "dtphasta";
            this.dtphasta.Size = new System.Drawing.Size(200, 20);
            this.dtphasta.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hasta:";
            // 
            // dtpdesde
            // 
            this.dtpdesde.Location = new System.Drawing.Point(59, 37);
            this.dtpdesde.Name = "dtpdesde";
            this.dtpdesde.Size = new System.Drawing.Size(200, 20);
            this.dtpdesde.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Desde:";
            // 
            // FormReportePorfechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormReportePorfechas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReportePorfechas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvventas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvventas;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.DateTimePicker dtphasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpdesde;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lbl;
    }
}