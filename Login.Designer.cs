namespace JuegosCShark
{
    partial class Login
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
            lblLogin = new Label();
            btnIniciarSesion = new Button();
            txtUsuario = new TextBox();
            btnRegistrarse = new Button();
            btnTienda = new Button();
            lblUsuario = new Label();
            lblContrasena = new Label();
            txtContrasena = new TextBox();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(78, 9);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(113, 15);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "VideoJuegos CShark";
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.Location = new Point(12, 191);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(105, 23);
            btnIniciarSesion.TabIndex = 1;
            btnIniciarSesion.Text = "&Iniciar Sesion";
            btnIniciarSesion.UseVisualStyleBackColor = true;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(86, 64);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(100, 23);
            txtUsuario.TabIndex = 2;
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.Location = new Point(163, 191);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(105, 23);
            btnRegistrarse.TabIndex = 3;
            btnRegistrarse.Text = "&Registrarse";
            btnRegistrarse.UseVisualStyleBackColor = true;
            btnRegistrarse.Click += btnRegistrarse_Click;
            // 
            // btnTienda
            // 
            btnTienda.Location = new Point(86, 231);
            btnTienda.Name = "btnTienda";
            btnTienda.Size = new Size(105, 23);
            btnTienda.TabIndex = 4;
            btnTienda.Text = "&Tienda";
            btnTienda.UseVisualStyleBackColor = true;
            btnTienda.Click += btnTienda_Click_1;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(86, 46);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 5;
            lblUsuario.Text = "Usuario";
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Location = new Point(86, 111);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(67, 15);
            lblContrasena.TabIndex = 7;
            lblContrasena.Text = "Contraseña";
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(86, 129);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(100, 23);
            txtContrasena.TabIndex = 6;
            // 
            // Login
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSize = true;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(280, 285);
            Controls.Add(lblContrasena);
            Controls.Add(txtContrasena);
            Controls.Add(lblUsuario);
            Controls.Add(btnTienda);
            Controls.Add(btnRegistrarse);
            Controls.Add(txtUsuario);
            Controls.Add(btnIniciarSesion);
            Controls.Add(lblLogin);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogin;
        private Button btnIniciarSesion;
        private TextBox txtUsuario;
        private Button btnRegistrarse;
        private Button btnTienda;
        private Label lblUsuario;
        private Label lblContrasena;
        private TextBox txtContrasena;
    }
}