using System;
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
            if (!string.IsNullOrEmpty(textBoxId.Text))
            {
                if ((textBoxId.Text).All(char.IsDigit) && textBoxId.Text != "")
                {
                    if (!string.IsNullOrEmpty(textBoxContraseña.Text))
                    {
                        Nucleo.InterfazNucleo fachada = new Nucleo.InterfazNucleo();
                        if (new Nucleo.InterfazNucleo().ObtenerAdministrador(Convert.ToInt32(textBoxId.Text)) != null)
                        {
                            if (textBoxContraseña.Text != null && fachada.VerficarContraseña(fachada.ObtenerAdministrador(Convert.ToInt32(textBoxId.Text)).Id, textBoxContraseña.Text))
                            {
                                
                                Menu2 ventanaMenu = new Menu2(textBoxId.Text);
                                ventanaMenu.Show();
                                this.Hide();
                            }
                            else { labelError.Text = "La contraseña ingresada es incorrecta "; botonIniciarSesion.Enabled = false; textBoxContraseña.Focus(); }

                        }
                        else { labelError.Text = "El usuario No existe"; botonIniciarSesion.Enabled = false; textBoxId.Focus(); }
                    }
                    else { labelError.Text = "Contraseña no ingresada"; botonIniciarSesion.Enabled = false; textBoxContraseña.Clear(); textBoxContraseña.Focus(); }
                }
                else { labelError.Text = "El Id ingresado tiene un formato incorrecto , los Id son numericos"; botonIniciarSesion.Enabled = false; textBoxId.Focus(); }
            }
            else { labelError.Text = "No ha ingresado el Id"; botonIniciarSesion.Enabled = false; textBoxId.Focus(); }




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
            if (textBoxContraseña.UseSystemPasswordChar==true)
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
