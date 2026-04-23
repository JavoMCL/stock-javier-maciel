namespace ui.Compra
{
    partial class frmNuevaCompra
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dtpFechaCompra = new DateTimePicker();
            cmbProveedor = new ComboBox();
            cmbProducto = new ComboBox();
            rdbCredito = new RadioButton();
            radioButton2 = new RadioButton();
            label5 = new Label();
            nmrCantidad = new NumericUpDown();
            btnAgregar = new Button();
            btnGuardarCompra = new Button();
            btnCancelarCompra = new Button();
            grbTipo = new GroupBox();
            dataGridView1 = new DataGridView();
            idCompra = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)nmrCantidad).BeginInit();
            grbTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 25);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "Fecha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 67);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 1;
            label2.Text = "Proveedor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(462, 29);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 2;
            label3.Text = "Tipo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(249, 62);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 3;
            label4.Text = "Producto";
            // 
            // dtpFechaCompra
            // 
            dtpFechaCompra.Location = new Point(88, 19);
            dtpFechaCompra.Name = "dtpFechaCompra";
            dtpFechaCompra.Size = new Size(217, 23);
            dtpFechaCompra.TabIndex = 4;
            // 
            // cmbProveedor
            // 
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.Location = new Point(88, 59);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(95, 23);
            cmbProveedor.TabIndex = 5;
            cmbProveedor.SelectionChangeCommitted += cmbProveedor_SelectionChangeCommitted;
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(317, 59);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(121, 23);
            cmbProducto.TabIndex = 6;
            cmbProducto.SelectionChangeCommitted += cmbProducto_SelectionChangeCommitted;
            // 
            // rdbCredito
            // 
            rdbCredito.AutoSize = true;
            rdbCredito.Location = new Point(0, 15);
            rdbCredito.Name = "rdbCredito";
            rdbCredito.Size = new Size(64, 19);
            rdbCredito.TabIndex = 7;
            rdbCredito.TabStop = true;
            rdbCredito.Text = "Credito";
            rdbCredito.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(85, 17);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(71, 19);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "Contado";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(462, 62);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 9;
            label5.Text = "Cantidad";
            label5.Click += label5_Click;
            // 
            // nmrCantidad
            // 
            nmrCantidad.Location = new Point(523, 60);
            nmrCantidad.Name = "nmrCantidad";
            nmrCantidad.Size = new Size(57, 23);
            nmrCantidad.TabIndex = 10;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(608, 60);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnGuardarCompra
            // 
            btnGuardarCompra.Location = new Point(523, 280);
            btnGuardarCompra.Name = "btnGuardarCompra";
            btnGuardarCompra.Size = new Size(75, 23);
            btnGuardarCompra.TabIndex = 14;
            btnGuardarCompra.Text = "Guardar";
            btnGuardarCompra.UseVisualStyleBackColor = true;
            btnGuardarCompra.Click += btnGuardarCompra_Click;
            // 
            // btnCancelarCompra
            // 
            btnCancelarCompra.Location = new Point(604, 280);
            btnCancelarCompra.Name = "btnCancelarCompra";
            btnCancelarCompra.Size = new Size(75, 23);
            btnCancelarCompra.TabIndex = 15;
            btnCancelarCompra.Text = "Cancelar";
            btnCancelarCompra.UseVisualStyleBackColor = true;
            btnCancelarCompra.Click += btnCancelarCompra_Click;
            // 
            // grbTipo
            // 
            grbTipo.Controls.Add(rdbCredito);
            grbTipo.Controls.Add(radioButton2);
            grbTipo.Location = new Point(523, 12);
            grbTipo.Name = "grbTipo";
            grbTipo.Size = new Size(160, 42);
            grbTipo.TabIndex = 12;
            grbTipo.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idCompra, Cantidad, Producto, Precio, Subtotal });
            dataGridView1.Location = new Point(21, 112);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(658, 150);
            dataGridView1.TabIndex = 13;
            // 
            // idCompra
            // 
            idCompra.HeaderText = "idCompra";
            idCompra.Name = "idCompra";
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "Subtotal";
            Subtotal.Name = "Subtotal";
            // 
            // frmNuevaCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelarCompra);
            Controls.Add(btnGuardarCompra);
            Controls.Add(dataGridView1);
            Controls.Add(grbTipo);
            Controls.Add(btnAgregar);
            Controls.Add(nmrCantidad);
            Controls.Add(label5);
            Controls.Add(cmbProducto);
            Controls.Add(cmbProveedor);
            Controls.Add(dtpFechaCompra);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmNuevaCompra";
            Text = "Nueva Compra";
            Load += frmNuevaCompra_Load;
            ((System.ComponentModel.ISupportInitialize)nmrCantidad).EndInit();
            grbTipo.ResumeLayout(false);
            grbTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpFechaCompra;
        private ComboBox cmbProveedor;
        private ComboBox cmbProducto;
        private RadioButton rdbCredito;
        private RadioButton radioButton2;
        private Label label5;
        private NumericUpDown nmrCantidad;
        private Button btnAgregar;
        private Button btnGuardarCompra;
        private Button btnCancelarCompra;
        private GroupBox grbTipo;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idCompra;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Subtotal;
    }
}