﻿using Nucleo;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Programa
{
    public partial class RegistrarAdministrador : Form
    {
        private string nombre { get; set; }
        private string nombreUsuario { get; set; }
        InterfazNucleo interfazNucleo = new InterfazNucleo();
        public RegistrarAdministrador(string pNombreUsuario)
        {
            InitializeComponent();
            nombreUsuario = pNombreUsuario;
            nombre = interfazNucleo.ObtenerAdministrador(nombreUsuario).Nombre;
            labelNombreUsuario.Text = "Usuario: " + nombreUsuario;
        }

        private void AgregarAdministrador_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void botonVolver_Click(object sender, EventArgs e)
        {

            this.Hide();
            this.Owner.Show();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegistrarAdministrador_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            buttonRegistrarAdministrador.Enabled = true;
        }

        private void textBoxApellido_TextChanged(object sender, EventArgs e)
        {
            buttonRegistrarAdministrador.Enabled = true;
        }

        private void dateTimePickerFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            buttonRegistrarAdministrador.Enabled = true;
        }

        private void textBoxMail_TextChanged(object sender, EventArgs e)
        {
            buttonRegistrarAdministrador.Enabled = true;
        }

        private void textBoxContraseña_TextChanged(object sender, EventArgs e)
        {
            buttonRegistrarAdministrador.Enabled = true;
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
                            if (!string.IsNullOrEmpty(textBoxMail.Text) && interfazNucleo.EsUnEmailValido(textBoxMail.Text))
                            {
                                if (!string.IsNullOrEmpty(textBoxTelefono.Text) && textBoxTelefono.Text.All(Char.IsDigit) && textBoxTelefono.Text.Length >= 8 && textBoxTelefono.Text.Length <= 11)
                                {
                                    if (!string.IsNullOrEmpty(textBoxContraseña.Text) && textBoxContraseña.Text.Length >= 4)
                                    {
                                        bool resultado = interfazNucleo.AñadirAdministrador(textBoxNombreUsuario.Text, textBoxNombre.Text, textBoxApellido.Text, dateTimePickerFechaNacimiento.Value, textBoxMail.Text, textBoxContraseña.Text, textBoxTelefono.Text);
                                        if (resultado == true)
                                        {
                                            MessageBox.Show("Usuario administrador guardado, el nombre de usuario es: " + textBoxNombreUsuario.Text, "Operacion Exitosa", MessageBoxButtons.OK);

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
                textBoxNombreUsuario.Focus();
            }
        }

        private void dateTimePickerFechaNacimiento_ValueChanged_1(object sender, EventArgs e)
        {
            buttonRegistrarAdministrador.Enabled = true;
            labelError.Text = "";
        }

        private void textBoxNombre_TextChanged_1(object sender, EventArgs e)
        {
            buttonRegistrarAdministrador.Enabled = true;
            labelError.Text = "";
        }

        private void textBoxApellido_TextChanged_1(object sender, EventArgs e)
        {
            buttonRegistrarAdministrador.Enabled = true;
            labelError.Text = "";
        }

        private void textBoxMail_TextChanged_1(object sender, EventArgs e)
        {
            buttonRegistrarAdministrador.Enabled = true;
            labelError.Text = "";
        }

        private void textBoxTelefono_TextChanged(object sender, EventArgs e)
        {
            buttonRegistrarAdministrador.Enabled = true;
            labelError.Text = "";
        }

        private void textBoxContraseña_TextChanged_1(object sender, EventArgs e)
        {
            buttonRegistrarAdministrador.Enabled = true;
            labelError.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNombreUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBoxNombreUsuario_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void labelMail_Click(object sender, EventArgs e)
        {

        }

        private void labelContraseña_Click(object sender, EventArgs e)
        {

        }

        private void labelFechaNacimiento_Click(object sender, EventArgs e)
        {

        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            if (textBoxContraseña.UseSystemPasswordChar == true)
            {
                textBoxContraseña.UseSystemPasswordChar = false;
                buttonMostrar.Text = "Ocultar";
                textBoxContraseña.Focus();
            }
            else
            {
                textBoxContraseña.UseSystemPasswordChar = true;
                buttonMostrar.Text = "Mostrar";
                textBoxContraseña.Focus();
            }
        }
    }
}
