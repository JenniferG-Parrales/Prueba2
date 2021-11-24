
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.columnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMontodelPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInteres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFechadePago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFechadeVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMontodePagar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudPrestamos = new System.Windows.Forms.NumericUpDown();
            this.nudTasas = new System.Windows.Forms.NumericUpDown();
            this.nudTerminos = new System.Windows.Forms.NumericUpDown();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.lblAños = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrestamos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTasas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTerminos)).BeginInit();
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
            this.btnAgregar.Location = new System.Drawing.Point(296, 107);
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnId,
            this.ColumnEstado,
            this.ColumnMontodelPrestamo,
            this.ColumnInteres,
            this.ColumnFechadePago,
            this.ColumnFechadeVencimiento,
            this.ColumnMontodePagar});
            this.dataGridView1.Location = new System.Drawing.Point(12, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(776, 150);
            this.dataGridView1.TabIndex = 10;
            // 
            // columnId
            // 
            this.columnId.HeaderText = "Id";
            this.columnId.Name = "columnId";
            // 
            // ColumnEstado
            // 
            this.ColumnEstado.HeaderText = "Estado";
            this.ColumnEstado.Name = "ColumnEstado";
            // 
            // ColumnMontodelPrestamo
            // 
            this.ColumnMontodelPrestamo.HeaderText = "Monto del Prestamo";
            this.ColumnMontodelPrestamo.Name = "ColumnMontodelPrestamo";
            // 
            // ColumnInteres
            // 
            this.ColumnInteres.HeaderText = "Interes";
            this.ColumnInteres.Name = "ColumnInteres";
            // 
            // ColumnFechadePago
            // 
            this.ColumnFechadePago.HeaderText = "Fecha de Pago";
            this.ColumnFechadePago.Name = "ColumnFechadePago";
            // 
            // ColumnFechadeVencimiento
            // 
            this.ColumnFechadeVencimiento.HeaderText = "Fecha de Vencimiento";
            this.ColumnFechadeVencimiento.Name = "ColumnFechadeVencimiento";
            // 
            // ColumnMontodePagar
            // 
            this.ColumnMontodePagar.HeaderText = "Monto de Pagar";
            this.ColumnMontodePagar.Name = "ColumnMontodePagar";
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
            this.groupBox1.Size = new System.Drawing.Size(233, 118);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
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
            // nudTasas
            // 
            this.nudTasas.Location = new System.Drawing.Point(71, 46);
            this.nudTasas.Name = "nudTasas";
            this.nudTasas.Size = new System.Drawing.Size(120, 23);
            this.nudTasas.TabIndex = 2;
            // 
            // nudTerminos
            // 
            this.nudTerminos.Location = new System.Drawing.Point(71, 75);
            this.nudTerminos.Name = "nudTerminos";
            this.nudTerminos.Size = new System.Drawing.Size(120, 23);
            this.nudTerminos.TabIndex = 13;
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
            // lblAños
            // 
            this.lblAños.AutoSize = true;
            this.lblAños.Location = new System.Drawing.Point(191, 77);
            this.lblAños.Name = "lblAños";
            this.lblAños.Size = new System.Drawing.Size(42, 15);
            this.lblAños.TabIndex = 14;
            this.lblAños.Text = "(Años)";
            // 
            // FrmPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAgregar);
            this.Name = "FrmPrestamo";
            this.Text = "FrmPrestamo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrestamos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTasas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTerminos)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMontodelPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInteres;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFechadePago;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFechadeVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMontodePagar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAños;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.NumericUpDown nudTerminos;
        private System.Windows.Forms.NumericUpDown nudTasas;
        private System.Windows.Forms.NumericUpDown nudPrestamos;
    }
}