namespace JuegosCShark
{
    partial class MantenimientoArticulos
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
            btnGuardar = new Button();
            cbxActivo = new CheckBox();
            dgvArticulos = new DataGridView();
            txtCodigo = new TextBox();
            lblMantenimientoArticulos = new Label();
            lblCodigo = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblPrecio = new Label();
            txtPrecio = new TextBox();
            lblStock = new Label();
            txtCantidad = new TextBox();
            lblEstado = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvArticulos).BeginInit();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(206, 265);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(246, 23);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "&Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // cbxActivo
            // 
            cbxActivo.AutoSize = true;
            cbxActivo.Location = new Point(581, 57);
            cbxActivo.Name = "cbxActivo";
            cbxActivo.Size = new Size(60, 19);
            cbxActivo.TabIndex = 1;
            cbxActivo.Text = "Activo";
            cbxActivo.UseVisualStyleBackColor = true;
            // 
            // dgvArticulos
            // 
            dgvArticulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArticulos.Location = new Point(12, 100);
            dgvArticulos.Name = "dgvArticulos";
            dgvArticulos.Size = new Size(651, 150);
            dgvArticulos.TabIndex = 2;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(12, 55);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 3;
            // 
            // lblMantenimientoArticulos
            // 
            lblMantenimientoArticulos.AutoSize = true;
            lblMantenimientoArticulos.Location = new Point(227, 9);
            lblMantenimientoArticulos.Name = "lblMantenimientoArticulos";
            lblMantenimientoArticulos.Size = new Size(195, 15);
            lblMantenimientoArticulos.TabIndex = 4;
            lblMantenimientoArticulos.Text = "Mantenimiento de Artículos CShark";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(12, 37);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 5;
            lblCodigo.Text = "Código";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(118, 37);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 7;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(118, 55);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(280, 23);
            txtNombre.TabIndex = 6;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(404, 35);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 9;
            lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(404, 53);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 8;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(510, 37);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(36, 15);
            lblStock.TabIndex = 11;
            lblStock.Text = "Stock";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(510, 55);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(65, 23);
            txtCantidad.TabIndex = 10;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(581, 39);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(42, 15);
            lblEstado.TabIndex = 12;
            lblEstado.Text = "Estado";
            // 
            // MantenimientoArticulos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 300);
            Controls.Add(lblEstado);
            Controls.Add(lblStock);
            Controls.Add(txtCantidad);
            Controls.Add(lblPrecio);
            Controls.Add(txtPrecio);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(lblCodigo);
            Controls.Add(lblMantenimientoArticulos);
            Controls.Add(txtCodigo);
            Controls.Add(dgvArticulos);
            Controls.Add(cbxActivo);
            Controls.Add(btnGuardar);
            Name = "MantenimientoArticulos";
            Text = "Mantenimiento de Articulos";
            ((System.ComponentModel.ISupportInitialize)dgvArticulos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private CheckBox cbxActivo;
        private DataGridView dgvArticulos;
        private TextBox txtCodigo;
        private Label lblMantenimientoArticulos;
        private Label lblCodigo;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblPrecio;
        private TextBox txtPrecio;
        private Label lblStock;
        private TextBox txtCantidad;
        private Label lblEstado;
    }
}