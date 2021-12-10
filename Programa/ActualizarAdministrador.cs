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
        InterfazNucleo interfazNucleo = new InterfazNucleo();
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
                UsuarioAdministrador administrador = new InterfazNucleo().ObtenerAdministrador(Convert.ToInt32(textBoxId.Text));
                if (administrador != null)
                {
                    textBoxNombre.Text = administrador.Nombre;
                    textBoxApellido.Text = administrador.Apellido;
                    textBoxFecha.Text = Convert.ToString(administrador.FechaNacimiento.Date);
                    textBoxMail.Text = administrador.Mail;
                    textBoxTelefono.Text = administrador.Telefono;
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
            textBoxTelefono.Enabled = true;
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
            if (!string.IsNullOrEmpty(textBoxNombre.Text) && textBoxNombre.Text.All(Char.IsLetter))
            {
                if (!string.IsNullOrEmpty(textBoxApellido.Text) && textBoxApellido.Text.All(Char.IsLetter))
                {
                    
                        if (!string.IsNullOrEmpty(textBoxMail.Text) && interfazNucleo.EsUnEmailValido(textBoxMail.Text))
                        {
                            if (!string.IsNullOrEmpty(textBoxTelefono.Text) && textBoxTelefono.Text.All(Char.IsDigit) && textBoxTelefono.Text.Length >= 8 && textBoxTelefono.Text.Length <= 11)
                            {
                            interfazNucleo.ActualizarAdministrador(textBoxId.Text, textBoxNombre.Text, textBoxApellido.Text, textBoxMail.Text,textBoxTelefono.Text);
                            MessageBox.Show("Operacion Exitosa! se ha actualizado el Administrador ID:" + textBoxId.Text);
                            this.Hide();
                            MenuPrincipal ventanaMenu = new MenuPrincipal(NombreUsuario);
                            ventanaMenu.Show();
                        }
                            else
                            {
                                this.labelError.Text = "Error,telefono ingresado invalido.Ingrese el numero sin 0 ni 15";
                                buttonGuardar.Enabled = false;
                                textBoxTelefono.Focus(); ;
                            }
                        }
                        else
                        {
                            this.labelError.Text = "Error, el mail ingresado no es valido";
                        buttonGuardar.Enabled = false;
                            textBoxMail.Focus(); ;
                        }
                  

                }
                else
                {
                    this.labelError.Text = "Error, apellido invalido.No debe contener numeros, espacios ni simbolos";
                    buttonGuardar.Enabled = false;
                    textBoxApellido.Focus(); ;
                }
            }
            else
            {
                this.labelError.Text = "Error, nombre invalido.No debe contener numeros, espacios ni simbolos";
                buttonGuardar.Enabled = false;
                textBoxNombre.Focus(); ;
            }
        }





       
    }
}
