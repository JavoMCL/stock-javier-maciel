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
                    Convert.ToString(producto.proveedor.nombre)
                 );
            }

        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int productID = Convert.ToInt32(dgvProductos[0, e.RowIndex].Value);
            Producto producto = DataBase.TABLA_PRODUCTOS[productID];
            if (e.ColumnIndex == 5)
            {
                frmAgregarProducto frmSocio = new frmAgregarProducto(producto);
                frmSocio.ShowDialog();
                this.cargarTabla();
            }
            else if (e.ColumnIndex == 6)
            {
                DataBase.eliminarProducto(productID);
            }
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
