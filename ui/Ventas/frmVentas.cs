using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backend.Models.Entidades;
using Backend.Utils;

namespace ui.Venta
{

    public partial class frmVentas : Form
    {
        public Ventas venta;
        private List<DetalleVenta> listaDetalles = new List<DetalleVenta>();
        public frmVentas(Ventas venta)
        {
            InitializeComponent();
            this.venta = venta;
        }


        private void frmVentas_Load(object sender, EventArgs e)
        {
            cargarClientes();
            cargarProductos();
        }

        private void cargarTablaVenta()
        {

            dvgVenta.Rows.Clear();

            foreach (DetalleVenta detalle in listaDetalles)
            {
                dvgVenta.Rows.Add(
                    detalle.producto.idProducto,
                    detalle.producto.nombreProducto,
                    detalle.cantidad,
                    detalle.precioUnitario,
                    detalle.subTotal
                );
            }


            var total = listaDetalles.Sum(d => (decimal)d.subTotal);
            Text = "Ventas - Total: " + total.ToString("C");
        }
        private void cargarClientes()
        {
            cmbCliente.DataSource = Cliente.obtenerDatos();
            cmbCliente.DisplayMember = "nombreCliente";
            cmbCliente.ValueMember = "idCliente";
            cmbCliente.SelectedIndex = -1;
        }

        private void cargarProductos()
        {
            cmbProducto.DataSource = Backend.Models.Entidades.Producto.obtenerDatos();
            cmbProducto.DisplayMember = "nombreProducto";
            cmbProducto.ValueMember = "idProducto";
            cmbProducto.SelectedIndex = -1;
        }

        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un producto.");
                return;
            }

            int cantidad = (int)nmrCantidad.Value;
            if (cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a cero.");
                return;
            }

            Producto producto = (Producto)cmbProducto.SelectedItem;

            if (producto.stock < cantidad)
            {
                MessageBox.Show("No hay suficiente stock del producto: " + producto.nombreProducto);
                return;
            }

            decimal precio = (decimal)producto.precio;
            decimal subtotal = cantidad * precio;

            DetalleVenta detalle = new DetalleVenta
            {
                producto = producto,
                cantidad = cantidad,
                precioUnitario = (float)precio,
                subTotal = (float)subtotal
            };

            listaDetalles.Add(detalle);
            cargarTablaVenta();
            nmrCantidad.Value = 0;
        }

        private void btnGuardarVenta_Click(object sender, EventArgs e)
        {
            if (rdbContado.Checked)
            {
                venta.formaPago = "Contado";
            }
            else if (rdbCredito.Checked)
            {
                venta.formaPago = "Crédito";
            }



            if (cmbCliente.SelectedItem == null || listaDetalles.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un cliente y al menos un producto.");
                return;
            }

            venta.cliente = (Cliente)cmbCliente.SelectedItem;
            venta.fechaVenta = DateTime.Now;
            venta.total = listaDetalles.Sum(d => d.subTotal);
            venta.idCliente = venta.cliente.idCliente;

            // Primero se guarda la cabecera para obtener idVenta y usarlo en cada detalle.
            venta.guardar();

            foreach (var detalle in listaDetalles)
            {
                detalle.venta = venta;
                detalle.idVenta = venta.idVenta;
                Backend.Utils.DataBase.guardarDetalleVenta(detalle);
            }

            actualizarStockDespuesDeVenta(listaDetalles);
            this.Close();

        }

        private void actualizarStockDespuesDeVenta(List<DetalleVenta> listaDetalles)
        {
            foreach (DetalleVenta detalle in listaDetalles)
            {
                Producto producto = detalle.producto;
                producto.stock -= detalle.cantidad;
                DataBase.agregarProducto(producto);
            }
        }

        private void btnCancelarVenta_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
