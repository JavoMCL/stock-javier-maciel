namespace ui.Venta
{
    partial class frmVentas
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
            rdbCredito = new RadioButton();
            rdbContado = new RadioButton();
            cmbProducto = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            cmbCliente = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            nmrCantidad = new NumericUpDown();
            btnAgregarVenta = new Button();
            btnGuardarVenta = new Button();
            dvgVenta = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)nmrCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvgVenta).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 37);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "Fecha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(326, 29);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 2;
            label2.Text = "Tipo";
            // 
            // rdbCredito
            // 
            rdbCredito.AutoSize = true;
            rdbCredito.Location = new Point(385, 29);
            rdbCredito.Name = "rdbCredito";
            rdbCredito.Size = new Size(64, 19);
            rdbCredito.TabIndex = 3;
            rdbCredito.TabStop = true;
            rdbCredito.Text = "Credito";
            rdbCredito.UseVisualStyleBackColor = true;
            // 
            // rdbContado
            // 
            rdbContado.AutoSize = true;
            rdbContado.Location = new Point(467, 29);
            rdbContado.Name = "rdbContado";
            rdbContado.Size = new Size(71, 19);
            rdbContado.TabIndex = 4;
            rdbContado.TabStop = true;
            rdbContado.Text = "Contado";
            rdbContado.UseVisualStyleBackColor = true;
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(271, 69);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(64, 23);
            cmbProducto.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(209, 75);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 6;
            label3.Text = "Producto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 75);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 7;
            label4.Text = "Cliente";
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(94, 69);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(109, 23);
            cmbCliente.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(94, 31);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(109, 23);
            dateTimePicker1.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(341, 73);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 10;
            label5.Text = "Cantidad";
            // 
            // nmrCantidad
            // 
            nmrCantidad.Location = new Point(402, 67);
            nmrCantidad.Name = "nmrCantidad";
            nmrCantidad.Size = new Size(84, 23);
            nmrCantidad.TabIndex = 11;
            // 
            // btnAgregarVenta
            // 
            btnAgregarVenta.Location = new Point(492, 65);
            btnAgregarVenta.Name = "btnAgregarVenta";
            btnAgregarVenta.Size = new Size(75, 23);
            btnAgregarVenta.TabIndex = 13;
            btnAgregarVenta.Text = "Agregar";
            btnAgregarVenta.UseVisualStyleBackColor = true;
            btnAgregarVenta.Click += btnAgregarVenta_Click;
            // 
            // btnGuardarVenta
            // 
            btnGuardarVenta.Location = new Point(492, 319);
            btnGuardarVenta.Name = "btnGuardarVenta";
            btnGuardarVenta.Size = new Size(75, 23);
            btnGuardarVenta.TabIndex = 14;
            btnGuardarVenta.Text = "Guardar";
            btnGuardarVenta.UseVisualStyleBackColor = true;
            btnGuardarVenta.Click += btnGuardarVenta_Click;
            // 
            // dvgVenta
            // 
            dvgVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgVenta.Columns.AddRange(new DataGridViewColumn[] { id, Producto, Cantidad, Precio, SubTotal });
            dvgVenta.Location = new Point(21, 122);
            dvgVenta.Name = "dvgVenta";
            dvgVenta.Size = new Size(546, 150);
            dvgVenta.TabIndex = 15;
            // 
            // id
            // 
            id.HeaderText = "Id Venta";
            id.Name = "id";
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "SubTotal";
            SubTotal.Name = "SubTotal";
            // 
            // frmVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 450);
            Controls.Add(dvgVenta);
            Controls.Add(btnGuardarVenta);
            Controls.Add(btnAgregarVenta);
            Controls.Add(nmrCantidad);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(cmbCliente);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cmbProducto);
            Controls.Add(rdbContado);
            Controls.Add(rdbCredito);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmVentas";
            Text = "Ventas";
            Load += frmVentas_Load;
            ((System.ComponentModel.ISupportInitialize)nmrCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvgVenta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFecha;
        private Label label2;
        private RadioButton rdbCredito;
        private RadioButton rdbContado;
        private ComboBox cmbProducto;
        private Label label3;
        private Label label4;
        private ComboBox cmbCliente;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private NumericUpDown nmrCantidad;
        private Button btnAgregarVenta;
        private Button btnGuardarVenta;
        private DataGridView dvgVenta;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn SubTotal;
    }
}