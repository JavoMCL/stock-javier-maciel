using System;
using System.Security.Cryptography.X509Certificates;
using Backend.Models;
using Backend.Models.Entidades;
using ui.Compra;
using ui.Productos;
using ui.Proveedores;
using ui.Venta;

namespace ui
{
    public partial class frmPrincipal : Form
    {

        private readonly AppDbContext _context;

        public frmPrincipal(AppDbContext context)
        {
            _context = context;
            InitializeComponent();

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.Text = this.Text + " - CyT ";

        }

        private void sbmnAgregarCliente_Click(object sender, EventArgs e)
        {
            frmGestionCliente agregarCliente = new frmGestionCliente(new Cliente());

            agregarCliente.ShowDialog();
        }

        private void sbmnListarCliente_Click_1(object sender, EventArgs e)
        {
            frmListaClientes frmListaClientes = new frmListaClientes();

            frmListaClientes.ShowDialog();
        }

        private void sbmAgregarProducto_Click(object sender, EventArgs e)
        {
            frmAgregarProducto frmAgregarProducto = new frmAgregarProducto(new Producto());
            frmAgregarProducto.ShowDialog();
        }

        private void sbmListaProductos_Click(object sender, EventArgs e)
        {
            frmListaDeProductos frmListaDeProductos = new frmListaDeProductos();
            frmListaDeProductos.ShowDialog();
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sbmAgregarProveedor_Click(object sender, EventArgs e)
        {
            frmGestionProveedor frmGestionProveedor = new frmGestionProveedor(new Proveedor());
            frmGestionProveedor.ShowDialog();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarProveedor frmListarProveedor = new frmListarProveedor();
            frmListarProveedor.ShowDialog();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sbmAgregarCompra_Click(object sender, EventArgs e)
        {
            frmNuevaCompra frmNuevaCompra = new frmNuevaCompra(new Compras());
            frmNuevaCompra.ShowDialog();
        }

        private void sbmListaCompras_Click(object sender, EventArgs e)
        {
            frmListaCompras frmListaCompras = new frmListaCompras();
            frmListaCompras.ShowDialog();
        }

        private void sbmnAgregarVenta_Click(object sender, EventArgs e)
        {
            frmVentas frmVentas = new frmVentas(new Ventas());
            frmVentas.ShowDialog();
        }

        private void sbmnListaVentas_Click(object sender, EventArgs e)
        {
            frmListaVentas frmListaVentas = new frmListaVentas();
            frmListaVentas.ShowDialog();
        }
    }
}
