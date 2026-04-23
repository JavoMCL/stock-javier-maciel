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
        private readonly Image editarIcon = new Bitmap(SystemIcons.Information.ToBitmap(), new Size(16, 16));
        private readonly Image eliminarIcon = new Bitmap(SystemIcons.Error.ToBitmap(), new Size(16, 16));

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
                    Convert.ToString(proveedor.direcccion),
                    editarIcon,
                    eliminarIcon

                );
            }
        }

        private void dgvListarProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            var idValue = dgvListarProveedor[0, e.RowIndex].Value;
            if (idValue is null)
            {
                return;
            }

            int idProveedor = Convert.ToInt32(idValue);
            if (!DataBase.TABLA_PROVEEDOR.TryGetValue(idProveedor, out var proveedor))
            {
                MessageBox.Show("No se encontro el proveedor seleccionado.");
                return;
            }

            if (e.ColumnIndex == 5)
            {
                frmGestionProveedor frmSocio = new frmGestionProveedor(proveedor);
                frmSocio.ShowDialog();
                this.cargarTablaPro();
            }
            else if (e.ColumnIndex == 6)
            {
                try
                {
                    DataBase.eliminarProveedor(idProveedor);
                    this.cargarTablaPro();
                }
                catch (Exception)
                {
                    MessageBox.Show("No se puede eliminar el proveedor porque tiene registros relacionados.");
                }
            }
            
        }

        private void frmListarProveedor_Load(object sender, EventArgs e)
        {
            this.cargarTablaPro();
        }
    }
}
