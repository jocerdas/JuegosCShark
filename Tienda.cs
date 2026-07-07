using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JuegosCShark
{
    public partial class Tienda : Form
    {
        public Tienda()
        {
            InitializeComponent();
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            MantenimientoArticulos Redireccion = new MantenimientoArticulos();
            Redireccion.Show();
            this.Hide();
        }

        /*
        
        Comentario de prueba para primer subida a GIT

         */


    }
}
