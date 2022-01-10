using System;
using System.Linq;
using System.Windows.Forms;
using Nucleo;

namespace Programa
{
    public partial class ActualizarUsuario : Form
    {
        private string nombre { get; set; }
        InterfazNucleo interfazNucleo = new InterfazNucleo();
        private string nombreUsuario { get; set; }
        public ActualizarUsuario(string pNombreUsuario)
        {
            InitializeComponent();
            nombreUsuario = pNombreUsuario;
            nombre = interfazNucleo.ObtenerAdministrador(nombreUsuario).Nombre;
            labelNombreUsuario.Text = "Usuario: " + nombreUsuario;
        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {
            buttonGuardar.Enabled = true;
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
                                if (interfazNucleo.ObtenerUsuario(textBoxNombreUsuario.Text).Baja == false && checkBoxBaja.Checked == true)
                                {
                                    interfazNucleo.ActualizarUsuario(textBoxNombreUsuario.Text, textBoxNombre.Text, textBoxApellido.Text, dateTimePickerFechaNacimiento.Value.Date.ToString(), textBoxMail.Text, textBoxTelefono.Text);
                                    interfazNucleo.DarDeBajaUsuario(textBoxNombreUsuario.Text);
                                    MessageBox.Show("Usuario ha sido dado de baja, el nombre de usuario es: " + textBoxNombreUsuario.Text, "Operacion Exitosa", MessageBoxButtons.OK);
                                }
                                else if (interfazNucleo.ObtenerUsuario(textBoxNombreUsuario.Text).Baja == true && checkBoxBaja.Checked == true)
                                {
                                    interfazNucleo.ActualizarUsuario(textBoxNombreUsuario.Text, textBoxNombre.Text, textBoxApellido.Text, dateTimePickerFechaNacimiento.Value.Date.ToString(), textBoxMail.Text, textBoxTelefono.Text);
                                    MessageBox.Show("Usuario ha sido dado de baja, el nombre de usuario es: " + textBoxNombreUsuario.Text, "Operacion Exitosa", MessageBoxButtons.OK);
                                }
                                else if (interfazNucleo.ObtenerUsuario(textBoxNombreUsuario.Text).Baja == false && checkBoxBaja.Checked == false)
                                {
                                    interfazNucleo.ActualizarUsuario(textBoxNombreUsuario.Text, textBoxNombre.Text, textBoxApellido.Text, dateTimePickerFechaNacimiento.Value.Date.ToString(), textBoxMail.Text, textBoxTelefono.Text);
                                    MessageBox.Show("Usuario ha sido guardado correctamente, el nombre de usuario es: " + textBoxNombreUsuario.Text, "Operacion Exitosa", MessageBoxButtons.OK);
                                }
                                else if (interfazNucleo.ObtenerUsuario(textBoxNombreUsuario.Text).Baja == true && checkBoxBaja.Checked == false)
                                {
                                    interfazNucleo.ActualizarUsuario(textBoxNombreUsuario.Text, textBoxNombre.Text, textBoxApellido.Text, dateTimePickerFechaNacimiento.Value.Date.ToString(), textBoxMail.Text, textBoxTelefono.Text);
                                    interfazNucleo.DarDeAltaUsuario(textBoxNombreUsuario.Text);
                                    MessageBox.Show("Usuario ha sido dado de alta y guardado correctamente, el nombre de usuario es: " + textBoxNombreUsuario.Text, "Operacion Exitosa", MessageBoxButtons.OK);
                                }
                                this.Hide();
                                ((GestionarUsuarios)Owner).ObtenerUsuarios();
                                this.Owner.Show();
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

        private void ActualizarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void labelNombre_Click(object sender, EventArgs e)
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

        private void ActualizarUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }
        public void CargarUsuarioExistente(string pNombreUsuario,string pBaja)
        {
            var usuario = interfazNucleo.ObtenerUsuario(pNombreUsuario);
            //VaciarCampos();
            textBoxNombreUsuario.Text = usuario.NombreUsuario;
            textBoxNombre.Text = usuario.Nombre;
            textBoxApellido.Text = usuario.Apellido;
            dateTimePickerFechaNacimiento.Value = usuario.FechaNacimiento;
            textBoxMail.Text = usuario.Mail;
            textBoxTelefono.Text = usuario.Telefono;
            if (pBaja == "True")
            {
                checkBoxBaja.Checked = true;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void botonVolver_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void dateTimePickerFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxBaja_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBaja.Checked == true)
            {
                if (interfazNucleo.DarDeBajaUsuario(textBoxNombreUsuario.Text) == false)
                {
                    checkBoxBaja.Checked = false;
                    MessageBox.Show("El Usuario " + textBoxNombreUsuario.Text + " no puede darse de baja ya que tiene prestamos pendientes!, intentelo mas tarde");
                }
                else
                {
                    textBoxNombre.Enabled = false;
                    textBoxApellido.Enabled = false;
                    dateTimePickerFechaNacimiento.Enabled = false;
                    textBoxTelefono.Enabled = false;
                    textBoxMail.Enabled = false;
                }
            }

            else if (checkBoxBaja.Checked == false)
            {
                {
                    textBoxNombre.Enabled = true;
                    textBoxApellido.Enabled = true;
                    dateTimePickerFechaNacimiento.Enabled = true;
                    textBoxTelefono.Enabled = true;
                    textBoxMail.Enabled = true;
                }
            }
        }
    }
}
