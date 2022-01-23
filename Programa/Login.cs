using System;
using System.Windows.Forms;
namespace Programa
{
    public partial class Login : Form
    //esta ventana tiene la funcion de controlar el inicio de sesion del programa ,validando los datos del usuario que pretende usarlo
    {

        public Login//constructor de la clase
        {

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }




        private void botonIniciarSesion_Click(object sender, EventArgs e)//se ejecuta cuando se presiona el boton iniciar sesion, este metodo valida que los datos ingresados sean correctos
        {
            if (!string.IsNullOrEmpty(textBoxNombreUsuario.Text))
            {
                if (!string.IsNullOrEmpty(textBoxContraseña.Text))
                {
                    Nucleo.FachadaNucleo fachada = new Nucleo.FachadaNucleo();
                    if (new Nucleo.FachadaNucleo().ObtenerAdministrador(textBoxNombreUsuario.Text) != null)
                    {
                        if (fachada.ObtenerAdministrador(textBoxNombreUsuario.Text).Baja == false)
                        {
                            if (textBoxContraseña.Text != null && fachada.VerficarContraseña(textBoxNombreUsuario.Text, textBoxContraseña.Text))
                            {
                                MenuPrincipal ventanaMenu = new MenuPrincipal(textBoxNombreUsuario.Text);
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

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)//Este metodo habilita el boton iniciar sesion , cuando se modifique el texto de textBoxUsuario
        {
            botonIniciarSesion.Enabled = true;
        }

        private void textBoxContraseña_TextChanged(object sender, EventArgs e)//Este metodo habilita el boton iniciar sesion , cuando se modifique el texto de textBoxContraseña
        {
            botonIniciarSesion.Enabled = true;

        }





        private void button1_Click(object sender, EventArgs e)//este metodo se ejecuta cuando se presiona el boton para mostrar u ocultar la contraseña
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

        private void Login_FormClosed(object sender, FormClosedEventArgs e)//se ejecuta cuando se cierra el formulario
        {
            Application.Exit();//Cierra el programa
        }

        private void Login_Load(object sender, EventArgs e)//se ejecuta cuando se inicia el formulario
        {
            timer1.Start();//inicia el timer
        }

        private void buttonCerrar_Click(object sender, EventArgs e)//se ejecuta cuando se presiona el boton cerrar
        {
            Application.Exit();//cierra el programa
        }

        private void timer1_Tick(object sender, EventArgs e)//accion que ejecuta el timmer
        {
            this.Opacity += .05;
            if (this.Opacity == 1)
            {
                timer1.Stop();
            }
        }
    }
}
