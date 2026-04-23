using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backend.Models.Entidades;
using Backend.Utils;

namespace ui.Compra
{
    public partial class frmNuevaCompra : Form
    {
        private Compras compras;
        private List<DetalleCompra> listaDetalles = new List<DetalleCompra>();
        public frmNuevaCompra(Compras compra)
        {
            InitializeComponent();
            this.compras = compra;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmNuevaCompra_Load(object sender, EventArgs e)
        {
            cargarProveedores();
            cargarProductos();

        }
        private void cargarProveedores()
        {
            cmbProveedor.DataSource = Proveedor.obtenerDatos();
            cmbProveedor.DisplayMember = "nombre";
            cmbProveedor.ValueMember = "idProveedor";
            cmbProveedor.SelectedIndex = -1;
        }

        private void cargarProductos()
        {
            cmbProducto.DataSource = Backend.Models.Entidades.Producto.obtenerDatos();
            cmbProducto.DisplayMember = "nombreProducto";
            cmbProducto.ValueMember = "idProducto";
            cmbProducto.SelectedIndex = -1;
        }

        private void cmbProveedor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            compras.proveedor = (Proveedor)cmbProveedor.SelectedItem;
        }

        private void cmbProducto_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbProveedor.SelectedItem == null)
            {
                MessageBox.Show("Por favor selecciona un proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbProducto.SelectedItem == null)
            {
                MessageBox.Show("Por favor selecciona un producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Backend.Models.Entidades.Producto producto = (Backend.Models.Entidades.Producto)cmbProducto.SelectedItem;
            int cantidad = (int)nmrCantidad.Value;

            if (cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DetalleCompra detalle = new DetalleCompra
            {
                idProducto = producto.idProducto,
                producto = producto,
                cantidad = cantidad,
                precioUnitario = producto.precio,
                subTotal = producto.precio * cantidad
            };

            listaDetalles.Add(detalle);
            producto.stock += cantidad;
            DataBase.agregarProducto(producto);

            cargarTablaCompra();
            nmrCantidad.Value = 0;
            cmbProducto.SelectedIndex = -1;
        }

        private void cargarTablaCompra()
        {
            dataGridView1.Rows.Clear();
            decimal total = 0;

            foreach (DetalleCompra detalle in listaDetalles)
            {
                dataGridView1.Rows.Add(
                    detalle.idProducto,
                    detalle.cantidad,
                    detalle.producto.nombreProducto,
                    detalle.precioUnitario,
                    detalle.subTotal
                );
                total += (decimal)detalle.subTotal;
            }

            Text = $"Nueva Compra - Total: {total:C}";
        }

        private void btnGuardarCompra_Click(object sender, EventArgs e)
        {
            if (cmbProveedor.SelectedItem == null)
            {
                MessageBox.Show("Por favor selecciona un proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (listaDetalles.Count == 0)
            {
                MessageBox.Show("Por favor agrega al menos un producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            compras.fechaCompra = dtpFechaCompra.Value;
            compras.proveedor = (Proveedor)cmbProveedor.SelectedItem;
            compras.idProveedor = compras.proveedor?.idProveedor;
            compras.total = listaDetalles.Sum(d => (float)d.subTotal);

            DataBase.agregarCompra(compras);

            foreach (var detalle in listaDetalles)
            {
                detalle.idCompra = compras.idCompra;
                DataBase.guardarDetalleCompra(detalle);
            }

            MessageBox.Show("Compra guardada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancelarCompra_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
