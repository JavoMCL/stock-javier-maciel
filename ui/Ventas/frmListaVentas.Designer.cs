namespace ui.Venta
{
    partial class frmListaVentas
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
            dgvListaVentas = new DataGridView();
            idVenta = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            Detalle = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)dgvListaVentas).BeginInit();
            SuspendLayout();
            // 
            // dgvListaVentas
            // 
            dgvListaVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaVentas.Columns.AddRange(new DataGridViewColumn[] { idVenta, Cliente, Fecha, Total, Detalle });
            dgvListaVentas.Location = new Point(32, 26);
            dgvListaVentas.Name = "dgvListaVentas";
            dgvListaVentas.Size = new Size(543, 150);
            dgvListaVentas.TabIndex = 0;
            // 
            // idVenta
            // 
            idVenta.HeaderText = "Id Venta";
            idVenta.Name = "idVenta";
            // 
            // Cliente
            // 
            Cliente.HeaderText = "Cliente";
            Cliente.Name = "Cliente";
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            // 
            // Detalle
            // 
            Detalle.HeaderText = "Detalles de Compra";
            Detalle.Name = "Detalle";
            Detalle.Resizable = DataGridViewTriState.True;
            Detalle.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // frmListaVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 450);
            Controls.Add(dgvListaVentas);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmListaVentas";
            Text = "Lista de Ventas";
            Load += frmListaVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListaVentas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvListaVentas;
        private DataGridViewTextBoxColumn idVenta;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewImageColumn Detalle;
    }
}