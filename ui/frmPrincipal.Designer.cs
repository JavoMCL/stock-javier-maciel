namespace ui
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            menuStrip2 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            mnCliente = new ToolStripMenuItem();
            sbmnAgregarCliente = new ToolStripMenuItem();
            sbmnListarCliente = new ToolStripMenuItem();
            proveedorToolStripMenuItem = new ToolStripMenuItem();
            sbmAgregarProveedor = new ToolStripMenuItem();
            listarToolStripMenuItem = new ToolStripMenuItem();
            productoToolStripMenuItem = new ToolStripMenuItem();
            sbmAgregarProducto = new ToolStripMenuItem();
            sbmListaProductos = new ToolStripMenuItem();
            comprasToolStripMenuItem = new ToolStripMenuItem();
            sbmAgregarCompra = new ToolStripMenuItem();
            sbmListaCompras = new ToolStripMenuItem();
            ventaToolStripMenuItem = new ToolStripMenuItem();
            sbmnAgregarVenta = new ToolStripMenuItem();
            sbmnListaVentas = new ToolStripMenuItem();
            btnSalir = new Button();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 24);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(404, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            menuStrip2.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(404, 24);
            menuStrip2.TabIndex = 2;
            menuStrip2.Text = "menuStrip2";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnCliente, proveedorToolStripMenuItem, productoToolStripMenuItem, comprasToolStripMenuItem, ventaToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 20);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // mnCliente
            // 
            mnCliente.DropDownItems.AddRange(new ToolStripItem[] { sbmnAgregarCliente, sbmnListarCliente });
            mnCliente.Name = "mnCliente";
            mnCliente.Size = new Size(180, 22);
            mnCliente.Text = "Cliente";
            // 
            // sbmnAgregarCliente
            // 
            sbmnAgregarCliente.Name = "sbmnAgregarCliente";
            sbmnAgregarCliente.ShortcutKeys = Keys.Control | Keys.A;
            sbmnAgregarCliente.Size = new Size(158, 22);
            sbmnAgregarCliente.Text = "Agregar";
            sbmnAgregarCliente.Click += sbmnAgregarCliente_Click;
            // 
            // sbmnListarCliente
            // 
            sbmnListarCliente.Name = "sbmnListarCliente";
            sbmnListarCliente.ShortcutKeys = Keys.Control | Keys.L;
            sbmnListarCliente.Size = new Size(158, 22);
            sbmnListarCliente.Text = "Listar";
            sbmnListarCliente.Click += sbmnListarCliente_Click_1;
            // 
            // proveedorToolStripMenuItem
            // 
            proveedorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sbmAgregarProveedor, listarToolStripMenuItem });
            proveedorToolStripMenuItem.Name = "proveedorToolStripMenuItem";
            proveedorToolStripMenuItem.Size = new Size(180, 22);
            proveedorToolStripMenuItem.Text = "Proveedor";
            // 
            // sbmAgregarProveedor
            // 
            sbmAgregarProveedor.Name = "sbmAgregarProveedor";
            sbmAgregarProveedor.Size = new Size(116, 22);
            sbmAgregarProveedor.Text = "Agregar";
            sbmAgregarProveedor.Click += sbmAgregarProveedor_Click;
            // 
            // listarToolStripMenuItem
            // 
            listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            listarToolStripMenuItem.Size = new Size(116, 22);
            listarToolStripMenuItem.Text = "Listar";
            listarToolStripMenuItem.Click += listarToolStripMenuItem_Click;
            // 
            // productoToolStripMenuItem
            // 
            productoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sbmAgregarProducto, sbmListaProductos });
            productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            productoToolStripMenuItem.Size = new Size(180, 22);
            productoToolStripMenuItem.Text = "Producto";
            // 
            // sbmAgregarProducto
            // 
            sbmAgregarProducto.Name = "sbmAgregarProducto";
            sbmAgregarProducto.Size = new Size(116, 22);
            sbmAgregarProducto.Text = "Agregar";
            sbmAgregarProducto.Click += sbmAgregarProducto_Click;
            // 
            // sbmListaProductos
            // 
            sbmListaProductos.Name = "sbmListaProductos";
            sbmListaProductos.Size = new Size(116, 22);
            sbmListaProductos.Text = "Listar";
            sbmListaProductos.Click += sbmListaProductos_Click;
            // 
            // comprasToolStripMenuItem
            // 
            comprasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sbmAgregarCompra, sbmListaCompras });
            comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            comprasToolStripMenuItem.Size = new Size(180, 22);
            comprasToolStripMenuItem.Text = "Compra";
            comprasToolStripMenuItem.Click += comprasToolStripMenuItem_Click;
            // 
            // sbmAgregarCompra
            // 
            sbmAgregarCompra.Name = "sbmAgregarCompra";
            sbmAgregarCompra.Size = new Size(165, 22);
            sbmAgregarCompra.Text = "Nueva Compra";
            sbmAgregarCompra.Click += sbmAgregarCompra_Click;
            // 
            // sbmListaCompras
            // 
            sbmListaCompras.Name = "sbmListaCompras";
            sbmListaCompras.Size = new Size(165, 22);
            sbmListaCompras.Text = "Lista de Compras";
            sbmListaCompras.Click += sbmListaCompras_Click;
            // 
            // ventaToolStripMenuItem
            // 
            ventaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sbmnAgregarVenta, sbmnListaVentas });
            ventaToolStripMenuItem.Name = "ventaToolStripMenuItem";
            ventaToolStripMenuItem.Size = new Size(180, 22);
            ventaToolStripMenuItem.Text = "Venta";
            // 
            // sbmnAgregarVenta
            // 
            sbmnAgregarVenta.Name = "sbmnAgregarVenta";
            sbmnAgregarVenta.Size = new Size(180, 22);
            sbmnAgregarVenta.Text = "Nueva Venta";
            sbmnAgregarVenta.Click += sbmnAgregarVenta_Click;
            // 
            // sbmnListaVentas
            // 
            sbmnListaVentas.Name = "sbmnListaVentas";
            sbmnListaVentas.Size = new Size(180, 22);
            sbmnListaVentas.Text = "Lista de Ventas";
            sbmnListaVentas.Click += sbmnListaVentas_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(12, 257);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 295);
            Controls.Add(btnSalir);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema Stock - Javier Maciel - 2025";
            Load += frmPrincipal_Load;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem proveedorToolStripMenuItem;
        private ToolStripMenuItem sbmAgregarProveedor;
        private ToolStripMenuItem listarToolStripMenuItem;
        private ToolStripMenuItem mnCliente;
        private ToolStripMenuItem sbmnAgregarCliente;
        private ToolStripMenuItem sbmnListarCliente;
        private ToolStripMenuItem productoToolStripMenuItem;
        private ToolStripMenuItem sbmAgregarProducto;
        private ToolStripMenuItem sbmListaProductos;
        private Button btnSalir;
        private ToolStripMenuItem comprasToolStripMenuItem;
        private ToolStripMenuItem sbmAgregarCompra;
        private ToolStripMenuItem sbmListaCompras;
        private ToolStripMenuItem ventaToolStripMenuItem;
        private ToolStripMenuItem sbmnAgregarVenta;
        private ToolStripMenuItem sbmnListaVentas;
    }
}
