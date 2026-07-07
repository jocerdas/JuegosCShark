using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JuegosCShark
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            MantenimientoUsuarios Redireccion = new MantenimientoUsuarios();
            Redireccion.Show();
            this.Hide();
        }
        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Registro Redireccion = new Registro();
            Redireccion.Show();
            this.Hide();
        }

        private void btnTienda_Click_1(object sender, EventArgs e)
        {
            Tienda Redireccion = new Tienda();
            Redireccion.Show();
            this.Hide();
        }
    }
}
