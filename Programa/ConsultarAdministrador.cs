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
    public partial class ConsultarAdministrador : Form
    {
        private string NombreUsuario { get; set; }
        public ConsultarAdministrador(string nombreUsuario)
        {
            InitializeComponent();
            NombreUsuario = nombreUsuario;
            labelNombreUsuario.Text = "Usuario: " + NombreUsuario;
        }

        private void buttonBuscarUsuario_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text != null && (textBoxId.Text).All(char.IsDigit) && textBoxId.Text != "")
            {
                UsuarioAdministrador usuario = new Nucleo.InterfazNucleo().ObtenerAdministrador(Convert.ToInt32(textBoxId.Text));
                if (usuario != null)
                {
                    textBoxNombre.Text = usuario.Nombre;
                    textBoxApellido.Text = usuario.Apellido;
                    textBoxFecha.Text = Convert.ToString(usuario.FechaNacimiento.Date);
                    textBoxMail.Text = usuario.Mail;
                    buttonBuscarAdministrador.Enabled = false;
                }
                else { labelError.Text = "El Id ingresado no corresponde a un usuario registrado "; buttonBuscarAdministrador.Enabled = false;textBoxId.Focus(); }
            }
            else { labelError.Text = "El Id ingresado es incorrecto "; buttonBuscarAdministrador.Enabled = false;  textBoxId.Focus(); }
        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {
            buttonBuscarAdministrador.Enabled = true;
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal ventana = new MenuPrincipal(NombreUsuario);
            ventana.Show();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ConsultarAdministrador_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
