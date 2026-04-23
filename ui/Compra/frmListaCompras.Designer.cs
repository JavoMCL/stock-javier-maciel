namespace ui.Compra
{
    partial class frmListaCompras
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
            dgvListaCompras = new DataGridView();
            IDCompra = new DataGridViewTextBoxColumn();
            Proveedor = new DataGridViewTextBoxColumn();
            FechaDeCompra = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            Detalle = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)dgvListaCompras).BeginInit();
            SuspendLayout();
            // 
            // dgvListaCompras
            // 
            dgvListaCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaCompras.Columns.AddRange(new DataGridViewColumn[] { IDCompra, Proveedor, FechaDeCompra, Total, Detalle });
            dgvListaCompras.Location = new Point(12, 12);
            dgvListaCompras.Name = "dgvListaCompras";
            dgvListaCompras.Size = new Size(544, 150);
            dgvListaCompras.TabIndex = 0;
            dgvListaCompras.CellClick += dgvListaCompras_CellClick;
            // 
            // IDCompra
            // 
            IDCompra.HeaderText = "Id Compra";
            IDCompra.Name = "IDCompra";
            // 
            // Proveedor
            // 
            Proveedor.HeaderText = "Proveedor";
            Proveedor.Name = "Proveedor";
            // 
            // FechaDeCompra
            // 
            FechaDeCompra.HeaderText = "Fecha de compra";
            FechaDeCompra.Name = "FechaDeCompra";
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            // 
            // Detalle
            // 
            Detalle.HeaderText = "Detalle";
            Detalle.Name = "Detalle";
            Detalle.Resizable = DataGridViewTriState.True;
            Detalle.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // frmListaCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvListaCompras);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmListaCompras";
            Text = "Compras";
            Load += frmListaCompras_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListaCompras).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvListaCompras;
        private DataGridViewTextBoxColumn IDCompra;
        private DataGridViewTextBoxColumn Proveedor;
        private DataGridViewTextBoxColumn FechaDeCompra;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewImageColumn Detalle;
    }
}