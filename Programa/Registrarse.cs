using Nucleo;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Programa
{
    public partial class Registrarse : Form
    {
        InterfazNucleo InterfazNucleo = new InterfazNucleo();
        public Registrarse()
        {
            InitializeComponent();
        }

        private void buttonRegistrarAdministrador_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxNombreUsuario.Text))
            {
                if (!string.IsNullOrEmpty(textBoxNombre.Text) && textBoxNombre.Text.All(Char.IsLetter))
                {
                    if (!string.IsNullOrEmpty(textBoxApellido.Text) && textBoxApellido.Text.All(Char.IsLetter))
                    {
                        if (dateTimePickerFechaNacimiento.Value.Date != new DateTime(1900, 1, 1))
                        {
                            if (!string.IsNullOrEmpty(textBoxMail.Text) && InterfazNucleo.EsUnEmailValido(textBoxMail.Text))
                            {
                                if (!string.IsNullOrEmpty(textBoxTelefono.Text) && textBoxTelefono.Text.All(Char.IsDigit) && textBoxTelefono.Text.Length >= 8 && textBoxTelefono.Text.Length <= 11)
                                {
                                    if (!string.IsNullOrEmpty(textBoxContraseña.Text) && textBoxContraseña.Text.Length >= 4)
                                    {
                                        bool resultado = InterfazNucleo.AñadirAdministrador(textBoxNombreUsuario.Text, textBoxNombre.Text, textBoxApellido.Text, dateTimePickerFechaNacimiento.Value, textBoxMail.Text, textBoxContraseña.Text, textBoxTelefono.Text);
                                        if (resultado == true)
                                        {
                                            MessageBox.Show("Usuario administrador guardado, el nombre de usuario es: " + textBoxNombreUsuario.Text, "Operacion Exitosa", MessageBoxButtons.OK);

                                            Login ventana = new Login();
                                            ventana.Show();
                                            this.Hide();
                                        }
                                        else
                                        {
                                            MessageBox.Show("El usuario: " + textBoxNombreUsuario.Text + " ya se encuentra registrado, pruebe con otro nombre de usuario", "Error", MessageBoxButtons.OK);
                                        }

                                    }
                                    else
                                    {
                                        this.labelError.Text = "Error,la contraseña debe tener al menos 4 digitos";
                                        buttonRegistrarAdministrador.Enabled = false;
                                        textBoxContraseña.Clear();
                                        textBoxTelefono.Focus();

                                    }
                                }
                                else
                                {
                                    this.labelError.Text = "Error,telefono ingresado invalido.Ingrese el numero sin 0 ni 15";
                                    buttonRegistrarAdministrador.Enabled = false;
                                    textBoxTelefono.Focus(); ;
                                }
                            }
                            else
                            {
                                this.labelError.Text = "Error, el mail ingresado no es valido";
                                buttonRegistrarAdministrador.Enabled = false;
                                textBoxMail.Focus(); ;
                            }
                        }
                        else
                        {
                            this.labelError.Text = "Error, no ha ingresado la fecha de nacimiento";
                            buttonRegistrarAdministrador.Enabled = false;
                            dateTimePickerFechaNacimiento.Focus(); ;
                        }

                    }
                    else
                    {
                        this.labelError.Text = "Error, apellido invalido.No debe contener numeros, espacios ni simbolos";
                        buttonRegistrarAdministrador.Enabled = false;
                        textBoxApellido.Focus(); ;
                    }
                }
                else
                {
                    this.labelError.Text = "Error, nombre invalido.No debe contener numeros, espacios ni simbolos";
                    buttonRegistrarAdministrador.Enabled = false;
                    textBoxNombre.Focus(); ;
                }
            }
            else
            {
                this.labelError.Text = "Error, nombre de usuario esta vacio";
                buttonRegistrarAdministrador.Enabled = false;
                textBoxNombre.Focus(); ;
            }
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login ventanaMenu = new Login();
            ventanaMenu.Show();

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Registrarse_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Registrarse_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            buttonRegistrarAdministrador.Enabled = true;
            labelError.Text = "";
        }

        private void textBoxApellido_TextChanged(object sender, EventArgs e)
        {
            buttonRegistrarAdministrador.Enabled = true;
            labelError.Text = "";
        }

        private void dateTimePickerFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            buttonRegistrarAdministrador.Enabled = true;
            labelError.Text = "";
        }

        private void textBoxMail_TextChanged(object sender, EventArgs e)
        {
            buttonRegistrarAdministrador.Enabled = true;
            labelError.Text = "";
        }

        private void textBoxContraseña_TextChanged(object sender, EventArgs e)
        {
            buttonRegistrarAdministrador.Enabled = true;
            labelError.Text = "";
        }

        private void textBoxTelefono_TextChanged(object sender, EventArgs e)
        {
            buttonRegistrarAdministrador.Enabled = true;
            labelError.Text = "";
        }

        private void labelContraseña_Click(object sender, EventArgs e)
        {
            buttonRegistrarAdministrador.Enabled = true;
            labelError.Text = "";
        }

        private void labelError_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelMail_Click(object sender, EventArgs e)
        {

        }

        private void labelFechaNacimiento_Click(object sender, EventArgs e)
        {

        }

        private void labelApellido_Click(object sender, EventArgs e)
        {

        }

        private void labelNombre_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += .05;
            if (this.Opacity == 1)
            {
                timer1.Stop();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNombreUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNombreUsuario_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
