using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backend.Models;
using Backend.Models.Entidades;
using Backend.Utils;

namespace ui
{
    public partial class frmGestionCliente : Form
    {

        private Cliente cliente;


        public frmGestionCliente(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;

        }



        private void frmGestionCliente_Load(object sender, EventArgs e)
        {


            cmbTipoTelefono.DataSource = DataBase.obtenerTipoTelefono();
            cmbTipoTelefono.DisplayMember = "descripcion";
            cmbTipoTelefono.ValueMember = "id";
            cmbTipoTelefono.SelectedIndex = -1;


            Genero masculino = new Genero();
            masculino.id = 1;
            masculino.descripcion = "Masculino";
            masculino.guardar();

            Genero femenino = new Genero();
            femenino.id = 2;
            femenino.descripcion = "Femenino";
            femenino.guardar();


            initForm(cliente);

        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void txtApellidoCliente_Leave(object sender, EventArgs e)
        {
            cliente.apellidoCliente = txtApellidoCliente.Text;
        }

        private void txtDocumento_Leave(object sender, EventArgs e)
        {
            cliente.numDocumento = txtDocumento.Text;
        }

        private void txtEmal_Leave(object sender, EventArgs e)
        {
            cliente.emailCliente = txtEmal.Text;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cliente.guardar();
            this.Close();
        }

        private void txtDireccion_Leave(object sender, EventArgs e)
        {
            cliente.direccionCliente = txtDireccion.Text;
        }



        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            cliente.telefonoCliente = txtTelefono.Text;
        }

        private void txtNombreCliente_Leave(object sender, EventArgs e)
        {
            cliente.nombreCliente = txtNombreCliente.Text;
        }

        private void rbGenMasc_CheckedChanged(object sender, EventArgs e)
        {
            cliente.genero = DataBase.TABLA_GENEROS[1];
        }

        private void rbGenFem_CheckedChanged(object sender, EventArgs e)
        {
            cliente.genero = DataBase.TABLA_GENEROS[2];
        }

        public void initForm(Cliente cliente)
        {

            txtNombreCliente.Text = cliente.nombreCliente;
            txtApellidoCliente.Text = cliente.apellidoCliente;
            txtDocumento.Text = cliente.numDocumento;
            txtEmal.Text = cliente.emailCliente;
            txtTelefono.Text = cliente.telefonoCliente;
            txtDireccion.Text = cliente.direccionCliente;
            if (cliente.genero == DataBase.TABLA_GENEROS[1])
            {
                rbGenMasc.Checked = true;
            }
            else if (cliente.genero == DataBase.TABLA_GENEROS[2])
            {
                rbGenFem.Checked = true;
            }
            if(cliente.tipoTelefono != null)
            {
                cmbTipoTelefono.SelectedValue = cliente.tipoTelefono.id;
            }
        }

        private void txtNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {

            ControlEventos.soloLetras(e);

        }

        private void cmbTipoTelefono_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cliente.tipoTelefono = (TipoTelefono)cmbTipoTelefono.SelectedItem;
        }
    }


}
