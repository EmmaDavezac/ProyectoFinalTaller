using System;
using System.Windows.Forms;
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
                    Nucleo.InterfazNucleo fachada = new Nucleo.InterfazNucleo();
                    if (new Nucleo.InterfazNucleo().ObtenerAdministradorPorNombreOMail(textBoxNombreUsuario.Text) != null)
                    {
                        if (fachada.ObtenerAdministradorPorNombreOMail(textBoxNombreUsuario.Text).Baja == false)
                        {
                            if (textBoxContraseña.Text != null && fachada.VerficarContraseña(textBoxNombreUsuario.Text, textBoxContraseña.Text))
                            {

                                Menu2 ventanaMenu = new Menu2(textBoxNombreUsuario.Text);
                                ventanaMenu.Show();
                                this.Hide();
                            }
                            else { labelError.Text = "Error, la contraseña ingresada es incorrecta "; botonIniciarSesion.Enabled = false; textBoxContraseña.Focus(); }
                        }
                        else
                        {
                            labelError.Text = "Error, el usuario no existe"; botonIniciarSesion.Enabled = false; textBoxNombreUsuario.Focus();
                        }
                    }
                    else { labelError.Text = "Error, el usuario no existe"; botonIniciarSesion.Enabled = false; textBoxNombreUsuario.Focus(); }
                }
                else { labelError.Text = "Error, no ha ingresado contraseña"; botonIniciarSesion.Enabled = false; textBoxContraseña.Clear(); textBoxContraseña.Focus(); }
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
