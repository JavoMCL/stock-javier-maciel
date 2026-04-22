namespace ui.Productos
{
    partial class frmAgregarProducto
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
            components = new System.ComponentModel.Container();
            lblNombreProducto = new Label();
            label1 = new Label();
            label2 = new Label();
            txtNombreProducto = new TextBox();
            txtDescripcionProducto = new TextBox();
            btnAgregar = new Button();
            btnCancelar = new Button();
            nmrPrecio = new NumericUpDown();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)nmrPrecio).BeginInit();
            SuspendLayout();
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.Location = new Point(26, 21);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(51, 15);
            lblNombreProducto.TabIndex = 0;
            lblNombreProducto.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 54);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 1;
            label1.Text = "Descripcion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 87);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "Precio";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(111, 18);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(167, 23);
            txtNombreProducto.TabIndex = 5;
            txtNombreProducto.Leave += txtNombreProducto_Leave;
            // 
            // txtDescripcionProducto
            // 
            txtDescripcionProducto.Location = new Point(111, 54);
            txtDescripcionProducto.Name = "txtDescripcionProducto";
            txtDescripcionProducto.Size = new Size(167, 23);
            txtDescripcionProducto.TabIndex = 6;
            txtDescripcionProducto.Leave += txtDescripcionProducto_Leave;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(28, 125);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Guardar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(203, 125);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // nmrPrecio
            // 
            nmrPrecio.Location = new Point(111, 87);
            nmrPrecio.Name = "nmrPrecio";
            nmrPrecio.Size = new Size(167, 23);
            nmrPrecio.TabIndex = 11;
            nmrPrecio.Leave += nmrPrecio_Leave;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(181, 26);
            // 
            // frmAgregarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(311, 180);
            Controls.Add(nmrPrecio);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(txtDescripcionProducto);
            Controls.Add(txtNombreProducto);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblNombreProducto);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAgregarProducto";
            Text = "frmAgregarProducto";
            Load += frmAgregarProducto_Load;
            ((System.ComponentModel.ISupportInitialize)nmrPrecio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombreProducto;
        private Label label1;
        private Label label2;
        private TextBox txtNombreProducto;
        private TextBox txtDescripcionProducto;
        private Button btnAgregar;
        private Button btnCancelar;
        private NumericUpDown nmrPrecio;
        private ContextMenuStrip contextMenuStrip1;
    }
}