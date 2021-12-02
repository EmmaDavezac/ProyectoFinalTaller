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
using Dominio;
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

        private void botonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void botonIniciarSesion_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text != null && (textBoxId.Text).All(char.IsDigit)&&textBoxId.Text != "")
            {
                Usuario usuario = new Fachada().ObtenerAdministrador(Convert.ToInt32(textBoxId.Text));
                if (usuario != null)
                {
                    if (textBoxContraseña.Text!=null &&new Fachada().VerficarContraseña(usuario.Id,textBoxContraseña.Text))
                    {
                        this.Hide();
                        MenuPrincipal ventanaMenu = new MenuPrincipal(usuario.Nombre+" "+usuario.Apellido);
                        ventanaMenu.Show();
                    }
                    else { labelError.Text = "La contraseña ingresada es incorrecta ";botonIniciarSesion.Enabled = false; textBoxContraseña.Focus(); }

                }
                else { labelError.Text = "El usuario No existe"; botonIniciarSesion.Enabled = false; textBoxId.Focus(); }
            }
            else { labelError.Text = "El Id ingresado es incorrecto "; botonIniciarSesion.Enabled = false; textBoxId.Focus(); }

            
           
            
        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {
            botonIniciarSesion.Enabled = true;
        }

        private void textBoxContraseña_TextChanged(object sender, EventArgs e)
        {
            botonIniciarSesion.Enabled = true;
        }

        private void buttonRegistrarse_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registrarse ventana = new Registrarse();
            ventana.Show();
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
    }
}
