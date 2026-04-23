namespace ui.Proveedores
{
    partial class frmListarProveedor
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
            dgvListarProveedor = new DataGridView();
            idProveedor = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)dgvListarProveedor).BeginInit();
            SuspendLayout();
            // 
            // dgvListarProveedor
            // 
            dgvListarProveedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListarProveedor.Columns.AddRange(new DataGridViewColumn[] { idProveedor, Nombre, Email, Telefono, Direccion, edit, Delete });
            dgvListarProveedor.Location = new Point(12, 12);
            dgvListarProveedor.Name = "dgvListarProveedor";
            dgvListarProveedor.Size = new Size(745, 150);
            dgvListarProveedor.TabIndex = 0;
            dgvListarProveedor.CellClick += dgvListarProveedor_CellClick;
            // 
            // idProveedor
            // 
            idProveedor.HeaderText = "Id_Proveedor";
            idProveedor.Name = "idProveedor";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.Name = "Email";
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.Name = "Telefono";
            // 
            // Direccion
            // 
            Direccion.HeaderText = "Direccion";
            Direccion.Name = "Direccion";
            // 
            // edit
            // 
            edit.HeaderText = "";
            edit.Name = "edit";
            // 
            // Delete
            // 
            Delete.HeaderText = "Eliminar";
            Delete.Name = "Delete";
            Delete.Resizable = DataGridViewTriState.True;
            Delete.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // frmListarProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 302);
            Controls.Add(dgvListarProveedor);
            Name = "frmListarProveedor";
            Text = "frmListarProveedor";
            Load += frmListarProveedor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListarProveedor).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvListarProveedor;
        private DataGridViewTextBoxColumn idProveedor;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewImageColumn edit;
        private DataGridViewImageColumn Delete;
    }
}