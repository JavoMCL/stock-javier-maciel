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
                      Convert.ToString(cliente.tipoTelefono.descripcion),
                       Convert.ToString(cliente.telefonoCliente),
                        Convert.ToString(cliente.direccionCliente)
                 );
            }
           
        }



        private void dgvClientes_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            int clientID = Convert.ToInt32(dgvClientes[0, e.RowIndex].Value);
            Cliente cliente = DataBase.TABLA_CLIENTE[clientID];
            if (e.ColumnIndex == 9)
            {
                frmGestionCliente frmSocio = new frmGestionCliente(cliente);
                frmSocio.ShowDialog();
                this.cargarTabla();
            }
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
