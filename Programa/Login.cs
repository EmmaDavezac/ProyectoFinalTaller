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
                    else { MessageBox.Show("La contraseña ingresada es incorrecta ", "Error", MessageBoxButtons.OK);botonIniciarSesion.Enabled = false; }

                }
                else { MessageBox.Show("El usuario No existe", "Error", MessageBoxButtons.OK); botonIniciarSesion.Enabled = false; }
            }
            else { MessageBox.Show("El Id ingresado es incorrecto ", "Error", MessageBoxButtons.OK); botonIniciarSesion.Enabled = false; }

            
           
            
        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {
            botonIniciarSesion.Enabled = true;
        }

        private void textBoxContraseña_TextChanged(object sender, EventArgs e)
        {
            botonIniciarSesion.Enabled = true;
        }
    }
}
