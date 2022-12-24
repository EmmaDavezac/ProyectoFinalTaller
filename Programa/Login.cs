using Bitacora;
using System;
using System.Windows.Forms;
namespace Programa
{/// <summary>
/// RESUMEN:este formulario tiene la funcion de controlar el inicio de sesion del programa ,validando los datos del usuario que pretende usarlo
/// </summary>
    public partial class Login : Form

    {/// <summary>
     /// RESUMEN:instancia del nucleo que nos permite utilizar las funcionalidades del mismo
     /// </summary>
        Nucleo.Nucleo interfazNucleo = new Nucleo.Nucleo();
        private IBitacora bitacora = new Bitacora.ImplementacionBitacoraConLog4Net();
        /// <summary>
        /// RESUMEN:constructor de la clase
        /// </summary>
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



        /// <summary>
        /// RESUMEN:se ejecuta cuando se presiona el boton iniciar sesion, este metodo valida que los datos ingresados sean correctos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonIniciarSesion_Click(object sender, EventArgs e)

        {
            try
            {
                if (!string.IsNullOrEmpty(textBoxNombreUsuario.Text))//verifica que se haya ingresado el nombre de usuario
                {
                    if (!string.IsNullOrEmpty(textBoxContraseña.Text))//verifica que se haya ingresado la contraseña
                    {

                        if (new Nucleo.Nucleo().ObtenerAdministrador(textBoxNombreUsuario.Text) != null)//verificamos que el usuario exista
                        {
                            if (interfazNucleo.ObtenerAdministrador(textBoxNombreUsuario.Text).Baja == false)//verificamos que el usuario no este dado de baja
                            {
                                if (textBoxContraseña.Text != null && interfazNucleo.VerficarContraseña(textBoxNombreUsuario.Text, textBoxContraseña.Text))
                                //verificamos que la contraseña ingresada corresponda con la del usuario ingresado
                                {
                                    MenuPrincipal ventanaMenu = new MenuPrincipal(textBoxNombreUsuario.Text);//creamos una instancia de menuprincipal
                                    ventanaMenu.Show();//abrimos el formulario
                                    bitacora.RegistrarLog("Sesion iniciada (Usuario: " + textBoxNombreUsuario.Text + ")");//registramos el inicio de sesion en la bitacora
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
                string texto = "Error botonIniciarSesion_Click: " + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(texto);
                MessageBox.Show(texto, "Ha ocurrido un error");
            }
        }
        /// <summary>
        /// RESUMEN:Este metodo habilita el boton iniciar sesion , cuando se modifique el texto de textBoxUsuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {
            botonIniciarSesion.Enabled = true;//habilitamos el boton iniciar sesion
        }
        /// <summary>
        /// RESUMEN:Este metodo habilita el boton iniciar sesion , cuando se modifique el texto de textBoxContraseña
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxContraseña_TextChanged(object sender, EventArgs e)//
        {
            botonIniciarSesion.Enabled = true;//habilitamos el boton iniciar sesion

        }




        /// <summary>
        /// RESUMEN:este metodo se ejecuta cuando se presiona el boton para mostrar u ocultar la contraseña
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// RESUMEN:se ejecuta cuando se cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();//Cierra el programa
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// RESUMEN:se ejecuta cuando se presiona el boton cerrar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCerrar_Click(object sender, EventArgs e)//
        {
            Application.Exit();//cierra el programa
        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
