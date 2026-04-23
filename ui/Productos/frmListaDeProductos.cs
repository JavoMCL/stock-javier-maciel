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

namespace ui.Productos
{
    public partial class frmListaDeProductos : Form
    {
        private readonly Image editarIcon = new Bitmap(SystemIcons.Information.ToBitmap(), new Size(16, 16));
        private readonly Image eliminarIcon = new Bitmap(SystemIcons.Error.ToBitmap(), new Size(16, 16));

        public frmListaDeProductos()
        {
            InitializeComponent();
        }

        private void frmListaDeProductos_Load(object sender, EventArgs e)
        {
            this.cargarTabla();
        }

        private void cargarTabla()
        {

            dgvProductos.Rows.Clear();

            foreach (Producto producto in Producto.obtenerDatos())
            {
                dgvProductos.Rows.Add(
                 Convert.ToString(producto.idProducto),
                     Convert.ToString(producto.nombreProducto),
                     Convert.ToString(producto.descripcionProducto),
                    Convert.ToString(producto.precio),
                    editarIcon,
                    eliminarIcon
                 );
            }

        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            var idValue = dgvProductos[0, e.RowIndex].Value;
            if (idValue is null)
            {
                return;
            }

            int productID = Convert.ToInt32(dgvProductos[0, e.RowIndex].Value);
            if (!DataBase.TABLA_PRODUCTOS.TryGetValue(productID, out var producto))
            {
                MessageBox.Show("No se encontro el producto seleccionado.");
                return;
            }

            if (e.ColumnIndex == 4)
            {
                frmAgregarProducto frmSocio = new frmAgregarProducto(producto);
                frmSocio.ShowDialog();
                this.cargarTabla();
            }
            else if (e.ColumnIndex == 5)
            {
                DataBase.eliminarProducto(productID);
                this.cargarTabla();
            }
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
