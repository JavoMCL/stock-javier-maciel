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

namespace ui
{
    public partial class frmListaClientes : Form
    {
        private readonly Image editarIcon = new Bitmap(SystemIcons.Information.ToBitmap(), new Size(16, 16));
        private readonly Image eliminarIcon = new Bitmap(SystemIcons.Error.ToBitmap(), new Size(16, 16));

        public frmListaClientes()
        {

            InitializeComponent();

        }

        private void frmListaClientes_Load(object sender, EventArgs e)
        {
            this.cargarTabla();

        }
        private void cargarTabla()
        {

            dgvClientes.Rows.Clear();

            foreach (Cliente cliente in Cliente.obtenerDatos())
            {
                dgvClientes.Rows.Add(
                 Convert.ToString(cliente.idCliente),
                     Convert.ToString(cliente.nombreCliente),
                     Convert.ToString(cliente.apellidoCliente),
                    Convert.ToString(cliente.numDocumento),
                     null == cliente.genero ? "" : Convert.ToString(cliente.genero.descripcion),
                     Convert.ToString(cliente.emailCliente),
                      cliente.tipoTelefono is null ? "" : Convert.ToString(cliente.tipoTelefono.descripcion),
                       Convert.ToString(cliente.telefonoCliente),
                        Convert.ToString(cliente.direccionCliente),
                        editarIcon,
                        eliminarIcon
                 );
            }
           
        }



        private void dgvClientes_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            var idValue = dgvClientes[0, e.RowIndex].Value;
            if (idValue is null)
            {
                return;
            }

            int clientID = Convert.ToInt32(idValue);
            if (!DataBase.TABLA_CLIENTE.TryGetValue(clientID, out var cliente))
            {
                MessageBox.Show("No se encontro el cliente seleccionado.");
                return;
            }

            if (e.ColumnIndex == 9)
            {
                frmGestionCliente frmSocio = new frmGestionCliente(cliente);
                frmSocio.ShowDialog();
                this.cargarTabla();
            }
            else if (e.ColumnIndex == 10)
            {
                var confirm = MessageBox.Show(
                    $"¿Seguro que deseas eliminar a '{cliente.nombreCliente} {cliente.apellidoCliente}'?",
                    "Confirmar eliminacion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm != DialogResult.Yes)
                {
                    return;
                }

                try
                {
                    DataBase.eliminarCliente(clientID);
                    this.cargarTabla();
                }
                catch (Exception)
                {
                    MessageBox.Show("No se puede eliminar el cliente porque tiene registros relacionados.");
                }
            }
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
