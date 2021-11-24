﻿
namespace Presentation
{
    partial class FrmPrestamo
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
            this.lblPrestamos = new System.Windows.Forms.Label();
            this.lblInteres = new System.Windows.Forms.Label();
            this.lblTerminos = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBusquedaporEstado = new System.Windows.Forms.Button();
            this.btnBusquedaporTotalPrincipal = new System.Windows.Forms.Button();
            this.btnBusquedaporTotaldeInteres = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAños = new System.Windows.Forms.Label();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.nudTerminos = new System.Windows.Forms.NumericUpDown();
            this.nudTasas = new System.Windows.Forms.NumericUpDown();
            this.nudPrestamos = new System.Windows.Forms.NumericUpDown();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.dtpFechaDePago = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDePago = new System.Windows.Forms.Label();
            this.lblCuota = new System.Windows.Forms.Label();
            this.nudCuota = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTerminos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTasas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrestamos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCuota)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrestamos
            // 
            this.lblPrestamos.AutoSize = true;
            this.lblPrestamos.Location = new System.Drawing.Point(0, 19);
            this.lblPrestamos.Name = "lblPrestamos";
            this.lblPrestamos.Size = new System.Drawing.Size(65, 15);
            this.lblPrestamos.TabIndex = 0;
            this.lblPrestamos.Text = "Prestamos:";
            // 
            // lblInteres
            // 
            this.lblInteres.AutoSize = true;
            this.lblInteres.Location = new System.Drawing.Point(0, 48);
            this.lblInteres.Name = "lblInteres";
            this.lblInteres.Size = new System.Drawing.Size(37, 15);
            this.lblInteres.TabIndex = 1;
            this.lblInteres.Text = "Tasas:";
            // 
            // lblTerminos
            // 
            this.lblTerminos.AutoSize = true;
            this.lblTerminos.Location = new System.Drawing.Point(0, 77);
            this.lblTerminos.Name = "lblTerminos";
            this.lblTerminos.Size = new System.Drawing.Size(58, 15);
            this.lblTerminos.TabIndex = 2;
            this.lblTerminos.Text = "Terminos:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(644, 107);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBusquedaporEstado
            // 
            this.btnBusquedaporEstado.Location = new System.Drawing.Point(3, 3);
            this.btnBusquedaporEstado.Name = "btnBusquedaporEstado";
            this.btnBusquedaporEstado.Size = new System.Drawing.Size(120, 67);
            this.btnBusquedaporEstado.TabIndex = 7;
            this.btnBusquedaporEstado.Text = "Busqueda por Estado";
            this.btnBusquedaporEstado.UseVisualStyleBackColor = true;
            // 
            // btnBusquedaporTotalPrincipal
            // 
            this.btnBusquedaporTotalPrincipal.Location = new System.Drawing.Point(248, 3);
            this.btnBusquedaporTotalPrincipal.Name = "btnBusquedaporTotalPrincipal";
            this.btnBusquedaporTotalPrincipal.Size = new System.Drawing.Size(118, 67);
            this.btnBusquedaporTotalPrincipal.TabIndex = 8;
            this.btnBusquedaporTotalPrincipal.Text = "Busqueda por Total Principal";
            this.btnBusquedaporTotalPrincipal.UseVisualStyleBackColor = true;
            // 
            // btnBusquedaporTotaldeInteres
            // 
            this.btnBusquedaporTotaldeInteres.Location = new System.Drawing.Point(129, 3);
            this.btnBusquedaporTotaldeInteres.Name = "btnBusquedaporTotaldeInteres";
            this.btnBusquedaporTotaldeInteres.Size = new System.Drawing.Size(113, 67);
            this.btnBusquedaporTotaldeInteres.TabIndex = 9;
            this.btnBusquedaporTotaldeInteres.Text = "Busqueda por Total de Interes";
            this.btnBusquedaporTotaldeInteres.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnBusquedaporEstado);
            this.flowLayoutPanel1.Controls.Add(this.btnBusquedaporTotaldeInteres);
            this.flowLayoutPanel1.Controls.Add(this.btnBusquedaporTotalPrincipal);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(27, 305);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(377, 78);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudCuota);
            this.groupBox1.Controls.Add(this.lblCuota);
            this.groupBox1.Controls.Add(this.lblFechaDePago);
            this.groupBox1.Controls.Add(this.dtpFechaDePago);
            this.groupBox1.Controls.Add(this.lblAños);
            this.groupBox1.Controls.Add(this.lblPorcentaje);
            this.groupBox1.Controls.Add(this.nudTerminos);
            this.groupBox1.Controls.Add(this.nudTasas);
            this.groupBox1.Controls.Add(this.nudPrestamos);
            this.groupBox1.Controls.Add(this.lblPrestamos);
            this.groupBox1.Controls.Add(this.lblInteres);
            this.groupBox1.Controls.Add(this.lblTerminos);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 118);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lblAños
            // 
            this.lblAños.AutoSize = true;
            this.lblAños.Location = new System.Drawing.Point(191, 77);
            this.lblAños.Name = "lblAños";
            this.lblAños.Size = new System.Drawing.Size(42, 15);
            this.lblAños.TabIndex = 14;
            this.lblAños.Text = "(Años)";
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Location = new System.Drawing.Point(197, 48);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(17, 15);
            this.lblPorcentaje.TabIndex = 13;
            this.lblPorcentaje.Text = "%";
            // 
            // nudTerminos
            // 
            this.nudTerminos.Location = new System.Drawing.Point(71, 75);
            this.nudTerminos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTerminos.Name = "nudTerminos";
            this.nudTerminos.Size = new System.Drawing.Size(120, 23);
            this.nudTerminos.TabIndex = 13;
            this.nudTerminos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudTasas
            // 
            this.nudTasas.Location = new System.Drawing.Point(71, 46);
            this.nudTasas.Name = "nudTasas";
            this.nudTasas.Size = new System.Drawing.Size(120, 23);
            this.nudTasas.TabIndex = 2;
            // 
            // nudPrestamos
            // 
            this.nudPrestamos.Location = new System.Drawing.Point(71, 17);
            this.nudPrestamos.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudPrestamos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPrestamos.Name = "nudPrestamos";
            this.nudPrestamos.Size = new System.Drawing.Size(120, 23);
            this.nudPrestamos.TabIndex = 1;
            this.nudPrestamos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(12, 136);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowTemplate.Height = 25;
            this.dgvDatos.Size = new System.Drawing.Size(757, 150);
            this.dgvDatos.TabIndex = 13;
            // 
            // dtpFechaDePago
            // 
            this.dtpFechaDePago.Location = new System.Drawing.Point(371, 13);
            this.dtpFechaDePago.Name = "dtpFechaDePago";
            this.dtpFechaDePago.Size = new System.Drawing.Size(200, 23);
            this.dtpFechaDePago.TabIndex = 15;
            // 
            // lblFechaDePago
            // 
            this.lblFechaDePago.AutoSize = true;
            this.lblFechaDePago.Location = new System.Drawing.Point(280, 19);
            this.lblFechaDePago.Name = "lblFechaDePago";
            this.lblFechaDePago.Size = new System.Drawing.Size(88, 15);
            this.lblFechaDePago.TabIndex = 16;
            this.lblFechaDePago.Text = "Fecha De Pago:";
            // 
            // lblCuota
            // 
            this.lblCuota.AutoSize = true;
            this.lblCuota.Location = new System.Drawing.Point(280, 48);
            this.lblCuota.Name = "lblCuota";
            this.lblCuota.Size = new System.Drawing.Size(42, 15);
            this.lblCuota.TabIndex = 17;
            this.lblCuota.Text = "Cuota:";
            // 
            // nudCuota
            // 
            this.nudCuota.Location = new System.Drawing.Point(371, 46);
            this.nudCuota.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudCuota.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCuota.Name = "nudCuota";
            this.nudCuota.Size = new System.Drawing.Size(120, 23);
            this.nudCuota.TabIndex = 18;
            this.nudCuota.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FrmPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnAgregar);
            this.Name = "FrmPrestamo";
            this.Text = "FrmPrestamo";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTerminos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTasas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrestamos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCuota)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPrestamos;
        private System.Windows.Forms.Label lblInteres;
        private System.Windows.Forms.Label lblTerminos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBusquedaporEstado;
        private System.Windows.Forms.Button btnBusquedaporTotalPrincipal;
        private System.Windows.Forms.Button btnBusquedaporTotaldeInteres;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAños;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.NumericUpDown nudTerminos;
        private System.Windows.Forms.NumericUpDown nudTasas;
        private System.Windows.Forms.NumericUpDown nudPrestamos;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.NumericUpDown nudCuota;
        private System.Windows.Forms.Label lblCuota;
        private System.Windows.Forms.Label lblFechaDePago;
        private System.Windows.Forms.DateTimePicker dtpFechaDePago;
    }
}