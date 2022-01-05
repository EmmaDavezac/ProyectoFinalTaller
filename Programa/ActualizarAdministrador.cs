using Nucleo;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Programa
{
    public partial class ActualizarAdministrador : Form
    {
        private string nombre { get; set; }
        InterfazNucleo interfazNucleo = new InterfazNucleo();
        public string contraseñaNueva;
        private string nombreUsuario { get; set; }
        public ActualizarAdministrador(string pNombreUsuario)
        {
            InitializeComponent();
            nombreUsuario = pNombreUsuario;
            nombre = interfazNucleo.ObtenerAdministradorPorNombreOMail(nombreUsuario).Nombre;
            labelNombreUsuario.Text = "Usuario: " + nombreUsuario;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultarAdministrador ventana = new ConsultarAdministrador(nombreUsuario.ToString());
            ventana.Show();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxNombre.Text) && textBoxNombre.Text.All(Char.IsLetter))
            {
                if (!string.IsNullOrEmpty(textBoxApellido.Text) && textBoxApellido.Text.All(Char.IsLetter))
                {
                    if (dateTimePickerFechaNacimiento.Value != new DateTime(1900, 1, 1))
                    {
                        if (!string.IsNullOrEmpty(textBoxMail.Text) && interfazNucleo.EsUnEmailValido(textBoxMail.Text))
                        {
                            if (!string.IsNullOrEmpty(textBoxTelefono.Text) && textBoxTelefono.Text.All(Char.IsDigit) && textBoxTelefono.Text.Length >= 8 && textBoxTelefono.Text.Length <= 11)
                            {
                                interfazNucleo.ActualizarAdministrador(textBoxNombreUsuario.Text, textBoxNombre.Text, textBoxApellido.Text, dateTimePickerFechaNacimiento.Value.Date.ToString(), textBoxMail.Text, textBoxTelefono.Text);
                                if (contraseñaNueva != null)
                                {
                                    interfazNucleo.ActualizarContraseñaAdministrador(textBoxNombreUsuario.Text, contraseñaNueva);
                                }
                                MessageBox.Show("Usuario guardado, el nombre de usuario es: " + textBoxNombreUsuario.Text, "Operacion Exitosa", MessageBoxButtons.OK);
                                this.Hide();
                                ConsultarAdministrador ventanaMenu = new ConsultarAdministrador(nombreUsuario);
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
                        this.labelError.Text = "Error, no ha ingresado la fecha de nacimiento";
                        buttonGuardar.Enabled = false;
                        dateTimePickerFechaNacimiento.Focus(); ;
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

        private void ActualizarAdministrador_Load(object sender, EventArgs e)
        {

        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            buttonGuardar.Enabled = true;
        }

        private void textBoxApellido_TextChanged(object sender, EventArgs e)
        {
            buttonGuardar.Enabled = true;
        }

        private void textBoxFecha_TextChanged(object sender, EventArgs e)
        {
            buttonGuardar.Enabled = true;
        }

        private void textBoxTelefono_TextChanged(object sender, EventArgs e)
        {
            buttonGuardar.Enabled = true;
        }

        private void textBoxMail_TextChanged(object sender, EventArgs e)
        {
            buttonGuardar.Enabled = true;
        }

        private void ActualizarAdministrador_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            ConsultarAdministrador ventanaMenu = new ConsultarAdministrador(nombreUsuario);
            ventanaMenu.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBoxId_TextChanged(object sender, EventArgs e)
        {
            buttonGuardar.Enabled = true;
        }

        public void CargarUsuarioExistente(string pNombreUsuario)
        {
            var usuario = interfazNucleo.ObtenerAdministradorPorNombreOMail(pNombreUsuario);
            //VaciarCampos();
            textBoxNombreUsuario.Text = usuario.NombreUsuario;
            textBoxNombre.Text = usuario.Nombre;
            textBoxApellido.Text = usuario.Apellido;
            dateTimePickerFechaNacimiento.Value = usuario.FechaNacimiento;
            textBoxMail.Text = usuario.Mail;
            textBoxTelefono.Text = usuario.Telefono;

        }

        private void VaciarCampos()
        {
            textBoxNombreUsuario.Text = string.Empty;
            textBoxNombre.Text = string.Empty;
            textBoxApellido.Text = string.Empty;
            dateTimePickerFechaNacimiento.Value = new DateTime(1900, 1, 1);
            textBoxMail.Text = string.Empty;
            textBoxTelefono.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModificarContraseña ventana = new ModificarContraseña(textBoxNombreUsuario.Text);
            ventana.ShowDialog(this);
        }

        public void CargarContraseña(string contraseña)
        {
            contraseñaNueva = contraseña;
        }

        private void dateTimePickerFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
