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

namespace ui.Compra
{
    public partial class frmListaCompras : Form
    {
        private readonly Image detalleIcon = new Bitmap(SystemIcons.Information.ToBitmap(), new Size(16, 16));

        public frmListaCompras()
        {
            InitializeComponent();
        }

        private void frmListaCompras_Load(object sender, EventArgs e)
        {
            cargarCompras();
        }

        private void cargarCompras()
        {
            dgvListaCompras.Rows.Clear();

            foreach (Compras compra in Compras.obtenerDatos())
            {
                dgvListaCompras.Rows.Add(
                    compra.idCompra,
                    compra.proveedor?.nombre ?? "Sin proveedor",
                    compra.fechaCompra,
                    compra.total,
                    detalleIcon
                );
            }
        }

        private void dgvListaCompras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != 4)
            {
                return;
            }

            var idValue = dgvListaCompras[0, e.RowIndex].Value;
            if (idValue is null)
            {
                return;
            }

            int idCompra = Convert.ToInt32(idValue);
            var detalles = DataBase.ObtenerDetallesCompraPorCompra(idCompra).Cast<DetalleCompra>().ToList();

            if (detalles.Count == 0)
            {
                MessageBox.Show("La compra no tiene detalles cargados.");
                return;
            }

            var detalleTexto = string.Join(Environment.NewLine,
                detalles.Select(d => $"- {d.producto?.nombreProducto ?? "Producto"} | Cant: {d.cantidad} | Precio: {d.precioUnitario} | Subtotal: {d.subTotal}"));

            MessageBox.Show(detalleTexto, $"Detalle de compra #{idCompra}");
        }
    }
}
