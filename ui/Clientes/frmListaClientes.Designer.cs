namespace ui
{
    partial class frmListaClientes
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
            dgvClientes = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            FIRSTNAME = new DataGridViewTextBoxColumn();
            LASTNAME = new DataGridViewTextBoxColumn();
            DOCUMENTS = new DataGridViewTextBoxColumn();
            GENDER = new DataGridViewTextBoxColumn();
            EMAIL = new DataGridViewTextBoxColumn();
            TYPE = new DataGridViewTextBoxColumn();
            CELLPHONE = new DataGridViewTextBoxColumn();
            DIRECTION = new DataGridViewTextBoxColumn();
            UPDATE = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { ID, FIRSTNAME, LASTNAME, DOCUMENTS, GENDER, EMAIL, TYPE, CELLPHONE, DIRECTION, UPDATE });
            dgvClientes.Location = new Point(34, 12);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(1029, 193);
            dgvClientes.TabIndex = 0;
            dgvClientes.CellClick += dgvClientes_CellClick_1;
            dgvClientes.CellContentClick += dgvClientes_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "Id";
            ID.Name = "ID";
            // 
            // FIRSTNAME
            // 
            FIRSTNAME.HeaderText = "Nombre";
            FIRSTNAME.Name = "FIRSTNAME";
            // 
            // LASTNAME
            // 
            LASTNAME.HeaderText = "Apellido";
            LASTNAME.Name = "LASTNAME";
            // 
            // DOCUMENTS
            // 
            DOCUMENTS.HeaderText = "Documento";
            DOCUMENTS.Name = "DOCUMENTS";
            // 
            // GENDER
            // 
            GENDER.HeaderText = "Genero";
            GENDER.Name = "GENDER";
            // 
            // EMAIL
            // 
            EMAIL.HeaderText = "E-Mail";
            EMAIL.Name = "EMAIL";
            // 
            // TYPE
            // 
            TYPE.HeaderText = "Tipo Telefono";
            TYPE.Name = "TYPE";
            // 
            // CELLPHONE
            // 
            CELLPHONE.HeaderText = "Telefono";
            CELLPHONE.Name = "CELLPHONE";
            // 
            // DIRECTION
            // 
            DIRECTION.HeaderText = "Direccion";
            DIRECTION.Name = "DIRECTION";
            // 
            // UPDATE
            // 
            UPDATE.HeaderText = "";
            UPDATE.Name = "UPDATE";
            // 
            // frmListaClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 450);
            Controls.Add(dgvClientes);
            Name = "frmListaClientes";
            Text = "frmListaClientes";
            Load += frmListaClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvClientes;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn FIRSTNAME;
        private DataGridViewTextBoxColumn LASTNAME;
        private DataGridViewTextBoxColumn DOCUMENTS;
        private DataGridViewTextBoxColumn GENDER;
        private DataGridViewTextBoxColumn EMAIL;
        private DataGridViewTextBoxColumn TYPE;
        private DataGridViewTextBoxColumn CELLPHONE;
        private DataGridViewTextBoxColumn DIRECTION;
        private DataGridViewImageColumn UPDATE;
    }
}