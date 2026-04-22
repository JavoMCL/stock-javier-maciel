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

namespace ui.Proveedores
{
    public partial class frmGestionProveedor : Form
    {
        private Proveedor proveedor;
        public frmGestionProveedor(Proveedor proveedor)
        {
            InitializeComponent();
            this.proveedor = proveedor;
        }


        private void frmGestionProveedor_Load(object sender, EventArgs e)
        {
            initform(proveedor);
        }

        public void initform(Proveedor proveedor)
        {
            txtNombre.Text = proveedor.nombre;
            txtEmail.Text = proveedor.email;
            txtTelefono.Text = proveedor.telefono;
            txtDireccion.Text = proveedor.direcccion;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            proveedor.guardar();
            this.Close();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            proveedor.nombre = txtNombre.Text;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            proveedor.email = txtEmail.Text;
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            proveedor.telefono = txtTelefono.Text;
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            proveedor.direcccion = txtDireccion.Text;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

