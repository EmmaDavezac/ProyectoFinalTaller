using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Nucleo;

namespace Programa
{
    public partial class ConsultarUsuario : Form
    {
        public ConsultarUsuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonBuscarUsuario_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text!=null&&(textBoxId.Text).All(char.IsDigit))
            {
                Usuario usuario = new Fachada().ObtenerUsuario(Convert.ToInt32(textBoxId.Text));
                if (usuario!=null)
                {
                    textBoxNombre.Text = usuario.Nombre;
                    textBoxApellido.Text = usuario.Apellido;
                    textBoxFecha.Text = Convert.ToString(usuario.FechaNacimiento);
                    textBoxMail.Text = usuario.Mail;
                    buttonBuscarUsuario.Enabled = false; 
                } else { MessageBox.Show("El usuario No existe", "Error", MessageBoxButtons.OK); }
            }
            else { MessageBox.Show("El Id ingresado es incorrecto ", "Error", MessageBoxButtons.OK); }
        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {
            buttonBuscarUsuario.Enabled = true;
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal ventana = new MenuPrincipal();
            ventana.Show();
        }

        private void ConsultarUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
