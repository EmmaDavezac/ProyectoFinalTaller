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
    public partial class ActualizarContraseña : Form
    {
        InterfazNucleo interfazNucleo = new InterfazNucleo();
        private string NombreUsuario { get; set; }
        public ActualizarContraseña(string nombreUsuario)
        {
            InitializeComponent();
            NombreUsuario = nombreUsuario;
            labelNombreUsuario.Text = "Usuario: " + NombreUsuario;
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text != null && (textBoxId.Text).All(char.IsDigit) && textBoxId.Text != "")
            {
                UsuarioAdministrador usuario = interfazNucleo.ObtenerAdministrador(Convert.ToInt32(textBoxId.Text));
                if (usuario != null)
                {
                    textBoxNombre.Text = usuario.Nombre;
                    textBoxApellido.Text = usuario.Apellido;
                    textBoxMail.Text = usuario.Mail;
                    buttonBuscar.Enabled = false;
                    buttonSeleccionar.Enabled = true;
                    textBoxContraseñaActual.Focus();
                }
                else { labelError.Text = "El Id ingresado no corresponde a un administrador registrado "; buttonBuscar.Enabled = false; textBoxId.Focus(); }
            }
            else { labelError.Text = "El Id ingresado es incorrecto "; buttonBuscar.Enabled = false; textBoxId.Focus(); }
        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {
            buttonBuscar.Enabled = true;
            buttonSeleccionar.Enabled = false;
        }

        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {
            buttonSeleccionar.Enabled = false;
            buttonSeleccionar.Text = "Seleccionado";
            textBoxContraseñaActual.Enabled = true;
            textBoxContraseñaNueva1.Enabled = true;
            textBoxContraseñaNueva2.Enabled = true;
        }

        private void textBoxContraseñaActual_TextChanged(object sender, EventArgs e)
        {
            buttonGuardar.Enabled = true;
        }

        private void textBoxContraseñaNueva1_TextChanged(object sender, EventArgs e)
        {
            buttonGuardar.Enabled = true;
        }

        private void textBoxContraseñaNueva2_TextChanged(object sender, EventArgs e)
        {
            buttonGuardar.Enabled = true;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxContraseñaActual.Text))
            {
                if (interfazNucleo.VerficarContraseña(Convert.ToInt32(textBoxId.Text), textBoxContraseñaActual.Text))
                {
                    if (!string.IsNullOrEmpty(textBoxContraseñaNueva1.Text))
                    {
                        if (textBoxContraseñaNueva1.Text == textBoxContraseñaNueva2.Text)
                        {
                            interfazNucleo.ActualizarContraseñaAdministrador(textBoxId.Text, textBoxContraseñaNueva1.Text);
                            MessageBox.Show("La contraseña del usuario Id:" + textBoxId.Text + " Ha sido actualizada!");
                            this.Hide();
                            MenuPrincipal ventana = new MenuPrincipal(NombreUsuario);
                            ventana.Show();
                        }
                        else { labelError.Text = "Las contraseñas no coinciden"; textBoxContraseñaNueva2.Focus();textBoxContraseñaNueva2.Clear(); buttonGuardar.Enabled = false; }
                    }
                    else { labelError.Text = "No ha ingresado la contraseña nueva"; textBoxContraseñaNueva1.Focus(); buttonGuardar.Enabled = false; }
                }
                else { labelError.Text = "La contraseña actual ingresada es incorrecta"; textBoxContraseñaActual.Clear(); textBoxContraseñaActual.Focus(); buttonGuardar.Enabled = false; }

            }
            else { labelError.Text = "No ha ingresado la contraseña actual"; textBoxContraseñaActual.Focus();buttonGuardar.Enabled = false; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal ventana = new MenuPrincipal(NombreUsuario);
            ventana.Show();
        }

        private void ActualizarContraseña_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
