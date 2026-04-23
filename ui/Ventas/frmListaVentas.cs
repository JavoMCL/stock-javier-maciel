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
    public partial class frmListaVentas : Form
    {
        private readonly Image detalleIcon = new Bitmap(SystemIcons.Information.ToBitmap(), new Size(16, 16));

        public frmListaVentas()
        {
            InitializeComponent();
        }

        private void frmListaVentas_Load(object sender, EventArgs e)
        {
            cargarVentas();
        }

        private void cargarVentas()
        {
            dgvListaVentas.Rows.Clear();

            foreach (Ventas venta in Ventas.obtenerDatos())
            {
                dgvListaVentas.Rows.Add(
                    venta.idVenta,
                    venta.cliente?.nombreCliente ?? "Sin cliente",
                    venta.fechaVenta,
                    venta.total,
                    detalleIcon
                );
            }
        }

        private void dgvListaVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != 4)
            {
                return;
            }

            var idValue = dgvListaVentas[0, e.RowIndex].Value;
            if (idValue is null)
            {
                return;
            }

            int idVenta = Convert.ToInt32(idValue);
            var detalles = DataBase.ObtenerDetallesVentaPorVenta(idVenta).Cast<DetalleVenta>().ToList();

            if (detalles.Count == 0)
            {
                MessageBox.Show("La venta no tiene detalles cargados.");
                return;
            }

            var detalleTexto = string.Join(Environment.NewLine,
                detalles.Select(d => $"- {d.producto?.nombreProducto ?? "Producto"} | Cant: {d.cantidad} | Precio: {d.precioUnitario} | Subtotal: {d.subTotal}"));

            MessageBox.Show(detalleTexto, $"Detalle de venta #{idVenta}");
        }
    }
}
