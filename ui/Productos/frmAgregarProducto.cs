using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backend.Models;
using Backend.Models.Entidades;
using Backend.Utils;

namespace ui.Productos
{
    public partial class frmAgregarProducto : Form
    {
        private Producto producto;
        public frmAgregarProducto(Producto producto)
        {
            InitializeComponent();
            this.producto = producto;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombreProducto_Leave(object sender, EventArgs e)
        {
            producto.nombreProducto = txtNombreProducto.Text;
        }

        private void txtDescripcionProducto_Leave(object sender, EventArgs e)
        {
            producto.descripcionProducto = txtDescripcionProducto.Text;
        }

        private void nmrPrecio_Leave(object sender, EventArgs e)
        {
            producto.precio = (float)nmrPrecio.Value;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            producto.guardar();
            this.Close();
        }

        private void frmAgregarProducto_Load(object sender, EventArgs e)
        {
            initForm(producto);
        }

        public void initForm(Producto producto)
        {
            txtNombreProducto.Text = producto.nombreProducto;
            txtDescripcionProducto.Text = producto.descripcionProducto;
            nmrPrecio.Value = (decimal)producto.precio;
        }
    }
}
