﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nucleo;
namespace Programa
{
    public partial class Login : Form
    {

        public Login()
        {

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }




        private void botonIniciarSesion_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxNombreUsuario.Text))
            {
                    if (!string.IsNullOrEmpty(textBoxContraseña.Text))
                    {
                        Nucleo.FachadaNucleo fachada = new Nucleo.FachadaNucleo();
                        if (new Nucleo.FachadaNucleo().ObtenerAdministradorPorNombreOMail(textBoxNombreUsuario.Text) != null)
                        {
                            if (textBoxContraseña.Text != null && fachada.VerficarContraseña(textBoxNombreUsuario.Text, textBoxContraseña.Text))
                            {

                                Menu2 ventanaMenu = new Menu2(textBoxNombreUsuario.Text);
                                ventanaMenu.Show();
                                this.Hide();
                            }
                            else { labelError.Text = "Error, la contraseña ingresada es incorrecta "; botonIniciarSesion.Enabled = false; textBoxContraseña.Focus(); }

                        }
                        else { labelError.Text = "Error,el usuario no existe"; botonIniciarSesion.Enabled = false; textBoxNombreUsuario.Focus(); }
                    }
                    else { labelError.Text = "Error,no ha ingresado contraseña"; botonIniciarSesion.Enabled = false; textBoxContraseña.Clear(); textBoxContraseña.Focus(); }
            }
            else { labelError.Text = "Error, no ha ingresado el nombre de usuario"; botonIniciarSesion.Enabled = false; textBoxNombreUsuario.Focus(); }




        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {
            botonIniciarSesion.Enabled = true;
        }

        private void textBoxContraseña_TextChanged(object sender, EventArgs e)
        {
            botonIniciarSesion.Enabled = true;

        }





        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxContraseña.UseSystemPasswordChar == true)
            {
                textBoxContraseña.UseSystemPasswordChar = false;
                buttonMostrar.Text = "Ocultar";
            }
            else
            {
                textBoxContraseña.UseSystemPasswordChar = true;
                buttonMostrar.Text = "Mostrar";
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Registrarse ventana = new Registrarse();
            ventana.Show();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += .05;
            if (this.Opacity == 1)
            {
                timer1.Stop();
            }
        }
    }
}
