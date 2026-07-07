namespace JuegosCShark
{
    partial class Registro
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
            btnRegistrar = new Button();
            lblRegistro = new Label();
            textBox1 = new TextBox();
            lblCedula = new Label();
            lblNombre = new Label();
            textBox2 = new TextBox();
            lblApellidos = new Label();
            textBox3 = new TextBox();
            lblUsuario = new Label();
            textBox4 = new TextBox();
            lblContrasena = new Label();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(370, 141);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 0;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // lblRegistro
            // 
            lblRegistro.AutoSize = true;
            lblRegistro.Location = new Point(12, 9);
            lblRegistro.Name = "lblRegistro";
            lblRegistro.Size = new Size(109, 15);
            lblRegistro.TabIndex = 1;
            lblRegistro.Text = "Registro de Usuario";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // lblCedula
            // 
            lblCedula.AutoSize = true;
            lblCedula.Location = new Point(12, 51);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(44, 15);
            lblCedula.TabIndex = 3;
            lblCedula.Text = "Cédula";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(196, 51);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "Nombre";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(196, 69);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Location = new Point(370, 51);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(56, 15);
            lblApellidos.TabIndex = 7;
            lblApellidos.Text = "Apellidos";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(370, 69);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 6;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(12, 124);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 9;
            lblUsuario.Text = "Usuario";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 142);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 8;
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Location = new Point(196, 124);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(67, 15);
            lblContrasena.TabIndex = 11;
            lblContrasena.Text = "Contrasena";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(196, 142);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 10;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(497, 225);
            Controls.Add(lblContrasena);
            Controls.Add(textBox5);
            Controls.Add(lblUsuario);
            Controls.Add(textBox4);
            Controls.Add(lblApellidos);
            Controls.Add(textBox3);
            Controls.Add(lblNombre);
            Controls.Add(textBox2);
            Controls.Add(lblCedula);
            Controls.Add(textBox1);
            Controls.Add(lblRegistro);
            Controls.Add(btnRegistrar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Registro";
            Text = "Registro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrar;
        private Label lblRegistro;
        private TextBox textBox1;
        private Label lblCedula;
        private Label lblNombre;
        private TextBox textBox2;
        private Label lblApellidos;
        private TextBox textBox3;
        private Label lblUsuario;
        private TextBox textBox4;
        private Label lblContrasena;
        private TextBox textBox5;
    }
}