namespace JuegosCShark
{
    partial class MantenimientoUsuarios
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
            lblMantUsuarios = new Label();
            btnGuardar = new Button();
            txtUsuario = new TextBox();
            dgvUsuarios = new DataGridView();
            lblUsuario = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblApellidos = new Label();
            txtApellidos = new TextBox();
            lblContrasena = new Label();
            txtContrasena = new TextBox();
            lblEstado = new Label();
            cbxActivo = new CheckBox();
            lblCedula = new Label();
            mskCedula = new MaskedTextBox();
            gbxRoles = new GroupBox();
            rdbEjecutivo = new RadioButton();
            rdbAdministrador = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            gbxRoles.SuspendLayout();
            SuspendLayout();
            // 
            // lblMantUsuarios
            // 
            lblMantUsuarios.AutoSize = true;
            lblMantUsuarios.Location = new Point(158, 9);
            lblMantUsuarios.Name = "lblMantUsuarios";
            lblMantUsuarios.Size = new Size(193, 15);
            lblMantUsuarios.TabIndex = 0;
            lblMantUsuarios.Text = "Mantenimiento de Usuarios CShark";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(132, 312);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(232, 23);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "&Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(12, 102);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(100, 23);
            txtUsuario.TabIndex = 2;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(12, 147);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(471, 150);
            dgvUsuarios.TabIndex = 3;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(12, 84);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Usuario";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(118, 31);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(118, 49);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(146, 23);
            txtNombre.TabIndex = 5;
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Location = new Point(270, 31);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(56, 15);
            lblApellidos.TabIndex = 8;
            lblApellidos.Text = "Apellidos";
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(270, 49);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(213, 23);
            txtApellidos.TabIndex = 7;
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Location = new Point(118, 84);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(67, 15);
            lblContrasena.TabIndex = 10;
            lblContrasena.Text = "Contraseña";
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(118, 102);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(146, 23);
            txtContrasena.TabIndex = 9;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(270, 84);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(42, 15);
            lblEstado.TabIndex = 11;
            lblEstado.Text = "Estado";
            // 
            // cbxActivo
            // 
            cbxActivo.AutoSize = true;
            cbxActivo.Location = new Point(270, 104);
            cbxActivo.Name = "cbxActivo";
            cbxActivo.Size = new Size(60, 19);
            cbxActivo.TabIndex = 12;
            cbxActivo.Text = "Activo";
            cbxActivo.UseVisualStyleBackColor = true;
            // 
            // lblCedula
            // 
            lblCedula.AutoSize = true;
            lblCedula.Location = new Point(12, 27);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(44, 15);
            lblCedula.TabIndex = 13;
            lblCedula.Text = "Cédula";
            // 
            // mskCedula
            // 
            mskCedula.Location = new Point(12, 47);
            mskCedula.Name = "mskCedula";
            mskCedula.Size = new Size(100, 23);
            mskCedula.TabIndex = 14;
            // 
            // gbxRoles
            // 
            gbxRoles.Controls.Add(rdbEjecutivo);
            gbxRoles.Controls.Add(rdbAdministrador);
            gbxRoles.Location = new Point(358, 78);
            gbxRoles.Name = "gbxRoles";
            gbxRoles.Size = new Size(125, 63);
            gbxRoles.TabIndex = 15;
            gbxRoles.TabStop = false;
            gbxRoles.Text = "Roles";
            // 
            // rdbEjecutivo
            // 
            rdbEjecutivo.AutoSize = true;
            rdbEjecutivo.Location = new Point(8, 38);
            rdbEjecutivo.Name = "rdbEjecutivo";
            rdbEjecutivo.Size = new Size(73, 19);
            rdbEjecutivo.TabIndex = 1;
            rdbEjecutivo.TabStop = true;
            rdbEjecutivo.Text = "Ejecutivo";
            rdbEjecutivo.UseVisualStyleBackColor = true;
            // 
            // rdbAdministrador
            // 
            rdbAdministrador.AutoSize = true;
            rdbAdministrador.Location = new Point(8, 18);
            rdbAdministrador.Name = "rdbAdministrador";
            rdbAdministrador.Size = new Size(101, 19);
            rdbAdministrador.TabIndex = 0;
            rdbAdministrador.TabStop = true;
            rdbAdministrador.Text = "Administrador";
            rdbAdministrador.UseVisualStyleBackColor = true;
            // 
            // MantenimientoUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 351);
            Controls.Add(gbxRoles);
            Controls.Add(mskCedula);
            Controls.Add(lblCedula);
            Controls.Add(cbxActivo);
            Controls.Add(lblEstado);
            Controls.Add(lblContrasena);
            Controls.Add(txtContrasena);
            Controls.Add(lblApellidos);
            Controls.Add(txtApellidos);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(lblUsuario);
            Controls.Add(dgvUsuarios);
            Controls.Add(txtUsuario);
            Controls.Add(btnGuardar);
            Controls.Add(lblMantUsuarios);
            Name = "MantenimientoUsuarios";
            Text = "Mantenimiento de Usuarios";
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            gbxRoles.ResumeLayout(false);
            gbxRoles.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMantUsuarios;
        private Button btnGuardar;
        private TextBox txtUsuario;
        private DataGridView dgvUsuarios;
        private Label lblUsuario;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblApellidos;
        private TextBox txtApellidos;
        private Label lblContrasena;
        private TextBox txtContrasena;
        private Label lblEstado;
        private CheckBox cbxActivo;
        private Label lblCedula;
        private MaskedTextBox mskCedula;
        private GroupBox gbxRoles;
        private RadioButton rdbEjecutivo;
        private RadioButton rdbAdministrador;
    }
}