using Nucleo;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Programa
{
    public partial class RegistrarUsuario : Form
    {
        private string nombre { get; set; }

        private string nombreUsuario { get; set; }
        FachadaNucleo interfazNucleo = new FachadaNucleo();
        public RegistrarUsuario(string pNombreUsuario)
        {
            InitializeComponent();
            nombreUsuario = pNombreUsuario;
            nombre = interfazNucleo.ObtenerAdministrador(nombreUsuario).Nombre;
            labelNombreUsuario.Text = "Usuario: " + nombreUsuario;
        }
        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void AgregarCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AgregarCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAñadirUsuario_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxNombreUsuario.Text))
            {
                if (!string.IsNullOrEmpty(textBoxNombre.Text) && textBoxNombre.Text.All(Char.IsLetter))
                {
                    if (!string.IsNullOrEmpty(textBoxApellido.Text) && textBoxApellido.Text.All(Char.IsLetter))
                    {
                        if (dateTimePickerFechaNacimiento.Value.Date != new DateTime(1900, 1, 1))
                        {
                            if (!string.IsNullOrEmpty(textBoxMail.Text) && interfazNucleo.EsUnEmailValido(textBoxMail.Text))
                            {
                                if (!string.IsNullOrEmpty(textBoxTelefono.Text) && textBoxTelefono.Text.All(Char.IsDigit) && textBoxTelefono.Text.Length >= 8 && textBoxTelefono.Text.Length <= 11)
                                {
                                    bool resultado = interfazNucleo.AñadirUsuario(textBoxNombreUsuario.Text, textBoxNombre.Text, textBoxApellido.Text, dateTimePickerFechaNacimiento.Value, textBoxMail.Text, textBoxTelefono.Text);
                                    if (resultado == true)
                                    {
                                        MessageBox.Show("Usuario guardado, el nombre de usuario es: " + textBoxNombreUsuario.Text, "Operacion Exitosa", MessageBoxButtons.OK);
                                        this.Hide();
                                        this.Owner.Show();
                                    }
                                    else
                                    {
                                        MessageBox.Show("El usuario: " + textBoxNombreUsuario.Text + " ya se encuentra registrado, pruebe con otro nombre de usuario", "Error", MessageBoxButtons.OK);
                                    }

                                }
                                else
                                {
                                    this.labelError.Text = "Error,telefono ingresado invalido.Ingrese el numero sin 0 ni 15";
                                    buttonAñadirUsuario.Enabled = false;
                                    textBoxTelefono.Focus(); ;
                                }
                            }
                            else
                            {
                                this.labelError.Text = "Error, el mail ingresado no es valido";
                                buttonAñadirUsuario.Enabled = false;
                                textBoxMail.Focus(); ;
                            }
                        }
                        else
                        {
                            this.labelError.Text = "Error, no ha ingresado la fecha de nacimiento";
                            buttonAñadirUsuario.Enabled = false;
                            dateTimePickerFechaNacimiento.Focus(); ;
                        }

                    }
                    else
                    {
                        this.labelError.Text = "Error, apellido invalido.No debe contener numeros, espacios ni simbolos";
                        buttonAñadirUsuario.Enabled = false;
                        textBoxApellido.Focus(); ;
                    }
                }
                else
                {
                    this.labelError.Text = "Error, nombre invalido.No debe contener numeros, espacios ni simbolos";
                    buttonAñadirUsuario.Enabled = false;
                    textBoxNombre.Focus(); ;
                }
            }
            else
            {
                this.labelError.Text = "Error, nombre de usuario esta vacio";
                buttonAñadirUsuario.Enabled = false;
                textBoxNombreUsuario.Focus();
            }
        }


        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            buttonAñadirUsuario.Enabled = true;
        }

        private void AgregarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void textBoxMail_TextChanged(object sender, EventArgs e)
        {
            buttonAñadirUsuario.Enabled = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            buttonAñadirUsuario.Enabled = true;
        }

        private void textBoxApellido_TextChanged(object sender, EventArgs e)
        {
            buttonAñadirUsuario.Enabled = true;
        }

        private void labelApellido_Click(object sender, EventArgs e)
        {

        }

        private void labelError_Click(object sender, EventArgs e)
        {

        }

        private void labelNombreUsuario_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTelefono_TextChanged(object sender, EventArgs e)
        {
            buttonAñadirUsuario.Enabled = true;
        }

        private void textBoxNombreUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
