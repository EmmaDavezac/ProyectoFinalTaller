using System;
using System.Windows.Forms;
namespace Programa
{
    public partial class Login : Form
    //esta ventana tiene la funcion de controlar el inicio de sesion del programa ,validando los datos del usuario que pretende usarlo
    {
        Nucleo.FachadaNucleo interfazNucleo = new Nucleo.FachadaNucleo();//instancia del nucleo que nos permite utilizar las funcionalidades del mismo
        public Login()//constructor de la clase
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
        //se ejecuta cuando se presiona el boton iniciar sesion, este metodo valida que los datos ingresados sean correctos
        {
            try
            {
                if (!string.IsNullOrEmpty(textBoxNombreUsuario.Text))//verifica que se haya ingresado el nombre de usuario
            {
                if (!string.IsNullOrEmpty(textBoxContraseña.Text))//verifica que se haya ingresado la contraseña
                {
                    
                    if (new Nucleo.FachadaNucleo().ObtenerAdministrador(textBoxNombreUsuario.Text) != null)//verificamos que el usuario exista
                    {
                        if (interfazNucleo.ObtenerAdministrador(textBoxNombreUsuario.Text).Baja == false)//verificamos que el usuario no este dado de baja
                        {
                            if (textBoxContraseña.Text != null && interfazNucleo.VerficarContraseña(textBoxNombreUsuario.Text, textBoxContraseña.Text))
                            //verificamos que la contraseña ingresada corresponda con la del usuario ingresado
                            {
                                MenuPrincipal ventanaMenu = new MenuPrincipal(textBoxNombreUsuario.Text);//creamos una instancia de menuprincipal
                                ventanaMenu.Show();//abrimos el formulario
                                interfazNucleo.RegistrarLog("Sesion iniciada (Usuario: "+textBoxNombreUsuario.Text+")");//registramos el inicio de sesion en la bitacora
                                this.Hide();//ocultamos esta ventana
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
            catch (Exception ex)
            {
                string texto= "Error botonIniciarSesion_Click: "+ ex.Message + ex.StackTrace;
                interfazNucleo.RegistrarLog(texto);
                MessageBox.Show(texto, "Ha ocurrido un error");
            }
        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)//Este metodo habilita el boton iniciar sesion , cuando se modifique el texto de textBoxUsuario
        {
            botonIniciarSesion.Enabled = true;//habilitamos el boton iniciar sesion
        }

        private void textBoxContraseña_TextChanged(object sender, EventArgs e)//Este metodo habilita el boton iniciar sesion , cuando se modifique el texto de textBoxContraseña
        {
            botonIniciarSesion.Enabled = true;//habilitamos el boton iniciar sesion

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

        private void timer1_Tick(object sender, EventArgs e)
        //accion que ejecuta el timmer, animacion de cuando se abre la ventana
        {
            this.Opacity += .05;
            if (this.Opacity == 1)
            {
                timer1.Stop();
            }
        }
    }
}
