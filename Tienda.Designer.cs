namespace JuegosCShark
{
    partial class Tienda
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
            btnAgregar = new Button();
            lblTienda = new Label();
            lblCodigo = new Label();
            lblArtNombre = new Label();
            txt = new TextBox();
            lblCantidad = new Label();
            textBox3 = new TextBox();
            dataGridView1 = new DataGridView();
            cbxCodigo = new ComboBox();
            lblPrecioUnitario = new Label();
            textBox1 = new TextBox();
            lblPrecioTotal = new Label();
            textBox4 = new TextBox();
            btnEliminar = new Button();
            btnFacturar = new Button();
            grpMetodosPago = new GroupBox();
            rdbTransferencia = new RadioButton();
            rdbTarjeta = new RadioButton();
            rdbEfectivo = new RadioButton();
            lblTotal = new Label();
            txtTotal = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            grpMetodosPago.SuspendLayout();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 260);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // lblTienda
            // 
            lblTienda.AutoSize = true;
            lblTienda.Location = new Point(317, 9);
            lblTienda.Name = "lblTienda";
            lblTienda.Size = new Size(69, 15);
            lblTienda.TabIndex = 1;
            lblTienda.Text = "Facturación";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(12, 27);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 3;
            lblCodigo.Text = "Código";
            // 
            // lblArtNombre
            // 
            lblArtNombre.AutoSize = true;
            lblArtNombre.Location = new Point(148, 27);
            lblArtNombre.Name = "lblArtNombre";
            lblArtNombre.Size = new Size(96, 15);
            lblArtNombre.TabIndex = 5;
            lblArtNombre.Text = "Nombre Artículo";
            // 
            // txt
            // 
            txt.Location = new Point(148, 45);
            txt.Name = "txt";
            txt.Size = new Size(309, 23);
            txt.TabIndex = 4;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(474, 27);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(55, 15);
            lblCantidad.TabIndex = 7;
            lblCantidad.Text = "Cantidad";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(474, 45);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(57, 23);
            textBox3.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 86);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(734, 150);
            dataGridView1.TabIndex = 8;
            // 
            // cbxCodigo
            // 
            cbxCodigo.FormattingEnabled = true;
            cbxCodigo.Location = new Point(12, 45);
            cbxCodigo.Name = "cbxCodigo";
            cbxCodigo.Size = new Size(121, 23);
            cbxCodigo.TabIndex = 9;
            // 
            // lblPrecioUnitario
            // 
            lblPrecioUnitario.AutoSize = true;
            lblPrecioUnitario.Location = new Point(549, 27);
            lblPrecioUnitario.Name = "lblPrecioUnitario";
            lblPrecioUnitario.Size = new Size(85, 15);
            lblPrecioUnitario.TabIndex = 11;
            lblPrecioUnitario.Text = "Precio Unitario";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(549, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(90, 23);
            textBox1.TabIndex = 10;
            // 
            // lblPrecioTotal
            // 
            lblPrecioTotal.AutoSize = true;
            lblPrecioTotal.Location = new Point(656, 27);
            lblPrecioTotal.Name = "lblPrecioTotal";
            lblPrecioTotal.Size = new Size(69, 15);
            lblPrecioTotal.TabIndex = 13;
            lblPrecioTotal.Text = "Precio Total";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(656, 45);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(90, 23);
            textBox4.TabIndex = 12;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(103, 260);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnFacturar
            // 
            btnFacturar.Location = new Point(670, 260);
            btnFacturar.Name = "btnFacturar";
            btnFacturar.Size = new Size(75, 23);
            btnFacturar.TabIndex = 15;
            btnFacturar.Text = "Facturar";
            btnFacturar.UseVisualStyleBackColor = true;
            btnFacturar.Click += btnFacturar_Click;
            // 
            // grpMetodosPago
            // 
            grpMetodosPago.Controls.Add(rdbTransferencia);
            grpMetodosPago.Controls.Add(rdbTarjeta);
            grpMetodosPago.Controls.Add(rdbEfectivo);
            grpMetodosPago.Location = new Point(184, 242);
            grpMetodosPago.Name = "grpMetodosPago";
            grpMetodosPago.Size = new Size(377, 55);
            grpMetodosPago.TabIndex = 16;
            grpMetodosPago.TabStop = false;
            grpMetodosPago.Text = "Métodos de Pago";
            // 
            // rdbTransferencia
            // 
            rdbTransferencia.AutoSize = true;
            rdbTransferencia.Location = new Point(257, 22);
            rdbTransferencia.Name = "rdbTransferencia";
            rdbTransferencia.Size = new Size(95, 19);
            rdbTransferencia.TabIndex = 2;
            rdbTransferencia.TabStop = true;
            rdbTransferencia.Text = "Transferencia";
            rdbTransferencia.UseVisualStyleBackColor = true;
            // 
            // rdbTarjeta
            // 
            rdbTarjeta.AutoSize = true;
            rdbTarjeta.Location = new Point(131, 22);
            rdbTarjeta.Name = "rdbTarjeta";
            rdbTarjeta.Size = new Size(60, 19);
            rdbTarjeta.TabIndex = 1;
            rdbTarjeta.TabStop = true;
            rdbTarjeta.Text = "Tarjeta";
            rdbTarjeta.UseVisualStyleBackColor = true;
            // 
            // rdbEfectivo
            // 
            rdbEfectivo.AutoSize = true;
            rdbEfectivo.Location = new Point(6, 22);
            rdbEfectivo.Name = "rdbEfectivo";
            rdbEfectivo.Size = new Size(67, 19);
            rdbEfectivo.TabIndex = 0;
            rdbEfectivo.TabStop = true;
            rdbEfectivo.Text = "Efectivo";
            rdbEfectivo.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(567, 242);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(33, 15);
            lblTotal.TabIndex = 18;
            lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(567, 260);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(98, 23);
            txtTotal.TabIndex = 17;
            // 
            // Tienda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 303);
            Controls.Add(lblTotal);
            Controls.Add(txtTotal);
            Controls.Add(grpMetodosPago);
            Controls.Add(btnFacturar);
            Controls.Add(btnEliminar);
            Controls.Add(lblPrecioTotal);
            Controls.Add(textBox4);
            Controls.Add(lblPrecioUnitario);
            Controls.Add(textBox1);
            Controls.Add(cbxCodigo);
            Controls.Add(dataGridView1);
            Controls.Add(lblCantidad);
            Controls.Add(textBox3);
            Controls.Add(lblArtNombre);
            Controls.Add(txt);
            Controls.Add(lblCodigo);
            Controls.Add(lblTienda);
            Controls.Add(btnAgregar);
            Name = "Tienda";
            Text = "Tienda";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            grpMetodosPago.ResumeLayout(false);
            grpMetodosPago.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private Label lblTienda;
        private Label lblCodigo;
        private Label lblArtNombre;
        private TextBox txt;
        private Label lblCantidad;
        private TextBox textBox3;
        private DataGridView dataGridView1;
        private ComboBox cbxCodigo;
        private Label lblPrecioUnitario;
        private TextBox textBox1;
        private Label lblPrecioTotal;
        private TextBox textBox4;
        private Button btnEliminar;
        private Button btnFacturar;
        private GroupBox grpMetodosPago;
        private RadioButton rdbEfectivo;
        private RadioButton rdbTransferencia;
        private RadioButton rdbTarjeta;
        private Label lblTotal;
        private TextBox txtTotal;
    }
}