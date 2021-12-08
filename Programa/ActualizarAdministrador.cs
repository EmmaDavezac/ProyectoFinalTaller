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
    public partial class ActualizarAdministrador : Form
    {
        private string NombreUsuario { get; set; }
        public ActualizarAdministrador(string nombreUsuario)
        {
            InitializeComponent();
            NombreUsuario = nombreUsuario;
            labelNombreUsuario.Text = "Usuario: " + NombreUsuario;
        }

        private void buttonBuscarUsuario_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text != null && (textBoxId.Text).All(char.IsDigit) && textBoxId.Text != "")
            {
                UsuarioAdministrador Administrador = new InterfazNucleo().ObtenerAdministrador(Convert.ToInt32(textBoxId.Text));
                if (Administrador != null)
                {
                    textBoxNombre.Text = Administrador.Nombre;
                    textBoxApellido.Text = Administrador.Apellido;
                    textBoxFecha.Text = Convert.ToString(Administrador.FechaNacimiento.Date);
                    textBoxMail.Text = Administrador.Mail;
               
                    buttonBuscarAdministrador.Enabled = false;
                    buttonSeleccionar.Enabled = true;
                }
                else { labelError.Text = "El Id ingresado no corresponde a un Administrador registrado "; buttonBuscarAdministrador.Enabled = false; textBoxId.Focus(); }
            }
            else { labelError.Text = "El Id ingresado es incorrecto "; buttonBuscarAdministrador.Enabled = false; textBoxId.Focus(); }
        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {
            buttonBuscarAdministrador.Enabled = true;
            buttonSeleccionar.Enabled = false;
        }

        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {
            textBoxId.Enabled = false;
            textBoxNombre.Enabled = true;
            textBoxApellido.Enabled = true;
            textBoxMail.Enabled = true;
            buttonGuardar.Enabled = true;
            buttonSeleccionar.Enabled = false;
            buttonSeleccionar.Text = "Seleccionado";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal ventana = new MenuPrincipal(NombreUsuario);
            ventana.Show();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (textBoxApellido.Text != null && textBoxNombre.Text != null && textBoxMail.Text != null )
            {
                InterfazNucleo InterfazNucleo = new InterfazNucleo();
                InterfazNucleo.ActualizarAdministrador(textBoxId.Text,textBoxNombre.Text, textBoxApellido.Text, textBoxMail.Text);
                MessageBox.Show("Operacion Exitosa! se ha actualizado el Administrador ID:"+textBoxId.Text);
                this.Hide();
                MenuPrincipal ventanaMenu = new MenuPrincipal(NombreUsuario);
                ventanaMenu.Show();
            }
            else
            {
                this.labelError.Text = "Error, ingrese todos los datos";
                textBoxNombre.Focus(); ;
            }
        }
    }
}
