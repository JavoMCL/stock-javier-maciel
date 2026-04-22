namespace ui
{
    partial class frmGestionCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNombre = new Label();
            txtNombreCliente = new TextBox();
            lblApellido = new Label();
            txtApellidoCliente = new TextBox();
            lblDocumento = new Label();
            lblEMail = new Label();
            txtEmal = new TextBox();
            lblTelefono = new Label();
            cmbTipoTelefono = new ComboBox();
            txtTelefono = new TextBox();
            lblGenero = new Label();
            lblDireccion = new Label();
            rbGenMasc = new RadioButton();
            rbGenFem = new RadioButton();
            txtDireccion = new TextBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            txtDocumento = new TextBox();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(25, 14);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(111, 6);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(195, 23);
            txtNombreCliente.TabIndex = 1;
            txtNombreCliente.KeyPress += txtNombreCliente_KeyPress;
            txtNombreCliente.Leave += txtNombreCliente_Leave;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(25, 45);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(54, 15);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido:";
            // 
            // txtApellidoCliente
            // 
            txtApellidoCliente.Location = new Point(109, 42);
            txtApellidoCliente.Name = "txtApellidoCliente";
            txtApellidoCliente.Size = new Size(197, 23);
            txtApellidoCliente.TabIndex = 3;
            txtApellidoCliente.Leave += txtApellidoCliente_Leave;
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Location = new Point(25, 79);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(73, 15);
            lblDocumento.TabIndex = 5;
            lblDocumento.Text = "Documento:";
            // 
            // lblEMail
            // 
            lblEMail.AutoSize = true;
            lblEMail.Location = new Point(25, 112);
            lblEMail.Name = "lblEMail";
            lblEMail.Size = new Size(44, 15);
            lblEMail.TabIndex = 7;
            lblEMail.Text = "E-Mail:";
            // 
            // txtEmal
            // 
            txtEmal.Location = new Point(109, 109);
            txtEmal.Name = "txtEmal";
            txtEmal.Size = new Size(197, 23);
            txtEmal.TabIndex = 8;
            txtEmal.Leave += txtEmal_Leave;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(25, 148);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(55, 15);
            lblTelefono.TabIndex = 9;
            lblTelefono.Text = "Telefono:";
            // 
            // cmbTipoTelefono
            // 
            cmbTipoTelefono.FormattingEnabled = true;
            cmbTipoTelefono.Location = new Point(109, 145);
            cmbTipoTelefono.Name = "cmbTipoTelefono";
            cmbTipoTelefono.Size = new Size(58, 23);
            cmbTipoTelefono.TabIndex = 10;
            cmbTipoTelefono.SelectionChangeCommitted += cmbTipoTelefono_SelectionChangeCommitted;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(173, 145);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(133, 23);
            txtTelefono.TabIndex = 11;
            txtTelefono.Leave += txtTelefono_Leave;
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Location = new Point(25, 179);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(48, 15);
            lblGenero.TabIndex = 12;
            lblGenero.Text = "Genero:";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(25, 208);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(60, 15);
            lblDireccion.TabIndex = 13;
            lblDireccion.Text = "Direccion:";
            // 
            // rbGenMasc
            // 
            rbGenMasc.AutoSize = true;
            rbGenMasc.Location = new Point(119, 179);
            rbGenMasc.Name = "rbGenMasc";
            rbGenMasc.Size = new Size(80, 19);
            rbGenMasc.TabIndex = 14;
            rbGenMasc.TabStop = true;
            rbGenMasc.Text = "Masculino";
            rbGenMasc.UseVisualStyleBackColor = true;
            rbGenMasc.CheckedChanged += rbGenMasc_CheckedChanged;
            // 
            // rbGenFem
            // 
            rbGenFem.AutoSize = true;
            rbGenFem.Location = new Point(205, 179);
            rbGenFem.Name = "rbGenFem";
            rbGenFem.Size = new Size(78, 19);
            rbGenFem.TabIndex = 15;
            rbGenFem.TabStop = true;
            rbGenFem.Text = "Femenino";
            rbGenFem.UseVisualStyleBackColor = true;
            rbGenFem.CheckedChanged += rbGenFem_CheckedChanged;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(107, 208);
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(199, 49);
            txtDireccion.TabIndex = 16;
            txtDireccion.Leave += txtDireccion_Leave;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(38, 284);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 17;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(205, 284);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(109, 76);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(197, 23);
            txtDocumento.TabIndex = 19;
            txtDocumento.Leave += txtDocumento_Leave;
            // 
            // frmGestionCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 349);
            Controls.Add(txtDocumento);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtDireccion);
            Controls.Add(rbGenFem);
            Controls.Add(rbGenMasc);
            Controls.Add(lblDireccion);
            Controls.Add(lblGenero);
            Controls.Add(txtTelefono);
            Controls.Add(cmbTipoTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(txtEmal);
            Controls.Add(lblEMail);
            Controls.Add(lblDocumento);
            Controls.Add(txtApellidoCliente);
            Controls.Add(lblApellido);
            Controls.Add(txtNombreCliente);
            Controls.Add(lblNombre);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmGestionCliente";
            Text = "Gestion Cliente";
            Load += frmGestionCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombreCliente;
        private Label lblApellido;
        private TextBox txtApellidoCliente;
        private Label lblDocumento;
        private Label lblEMail;
        private TextBox txtEmal;
        private Label lblTelefono;
        private ComboBox cmbTipoTelefono;
        private TextBox txtTelefono;
        private Label lblGenero;
        private Label lblDireccion;
        private RadioButton rbGenMasc;
        private RadioButton rbGenFem;
        private TextBox txtDireccion;
        private Button btnGuardar;
        private Button btnCancelar;
        private TextBox txtDocumento;
    }
}