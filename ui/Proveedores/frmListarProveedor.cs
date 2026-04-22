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

namespace ui.Proveedores
{
    public partial class frmListarProveedor : Form
    {
        public frmListarProveedor()
        {
            InitializeComponent();
        }


        private void cargarTablaPro()
        {

            dgvListarProveedor.Rows.Clear();

            foreach (Proveedor proveedor in Proveedor.obtenerDatos())
            {
                dgvListarProveedor.Rows.Add(
                Convert.ToString(proveedor.idProveedor),
                    Convert.ToString(proveedor.nombre),
                    Convert.ToString(proveedor.email),
                   Convert.ToString(proveedor.telefono),
                    Convert.ToString(proveedor.direcccion)

                );
            }
        }

        private void dgvListarProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idProveedor = Convert.ToInt32(dgvListarProveedor[0, e.RowIndex].Value);
            Proveedor proveedor = DataBase.TABLA_PROVEEDOR[idProveedor];
            if (e.ColumnIndex == 5)
            {
                frmGestionProveedor frmSocio = new frmGestionProveedor(proveedor);
                frmSocio.ShowDialog();
                this.cargarTablaPro();
            }
            
        }

        private void frmListarProveedor_Load(object sender, EventArgs e)
        {
            this.cargarTablaPro();
        }
    }
}
