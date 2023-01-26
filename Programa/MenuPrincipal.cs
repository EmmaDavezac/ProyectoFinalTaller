using System;
using System.Windows.Forms;

namespace Presentacion
{   /// <summary>
/// RESUMEN:Este formulario es el menu principal de la aplicacion y permite acceder a las funciones del sistema
/// </summary>
    public partial class MenuPrincipal : Form

    {/// <summary>
     /// RESUMEN:Se almacena el nombre completo del usuario que inicio sesion
     /// </summary>
        private string NombreYApellido { get; set; }
        /// <summary>
        /// RESUMEN:Se almacena el nombre de usuario del usuario que inicio sesion
        /// </summary>
        private string nombreUsuario { get; set; }
        /// <summary>
        /// RESUMEN:instancia del nucleo del programa que nos permite acceder a las funciones del sistema
        /// </summary>
        Nucleo.Nucleo interfazNucleo = new Nucleo.Nucleo();
        /// <summary>
        /// RESUMEN:Constructor de la clase
        /// </summary>
        /// <param name="pNombreUsuario"></param>
        public MenuPrincipal(string pNombreUsuario)
        {
            InitializeComponent();
            nombreUsuario = pNombreUsuario;
            NombreYApellido = interfazNucleo.ObtenerAdministrador(nombreUsuario).Nombre + " " + interfazNucleo.ObtenerAdministrador(nombreUsuario).Apellido;
            labelNombreYApellido.Text = "Nombre: " + NombreYApellido;
        }
        /// <summary>
        /// RESUMEN:se ejecuta cuando se crea formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Menu2_Load(object sender, EventArgs e)
        {
            CustomizeDosing();//oculta todos los submenus
        }
        /// <summary>
        /// RESUMEN:oculta todos los submenus
        /// </summary>
        private void CustomizeDosing()
        {
            submenuusuario.Visible = false;
            submenuadministradores.Visible = false;
            submenuLibros.Visible = false;
            submenuPrestamos.Visible = false;
        }
        /// <summary>
        /// RESUMEN:este metodo oculta los submenus abiertos
        /// </summary>
        private void HideSubmenu()
        {
            if (submenuadministradores.Visible == true)
            {
                submenuadministradores.Visible = false;
            }
            if (submenuusuario.Visible == true)
            {
                submenuusuario.Visible = false;
            }
            if (submenuLibros.Visible == true)
            {
                submenuLibros.Visible = false;
            }
            if (submenuPrestamos.Visible == true)
            {
                submenuPrestamos.Visible = false;
            }
        }
        /// <summary>
        /// RESUMEN:este metodo muestra un submenu si esta oculto o lo oculta si esta visible
        /// </summary>
        /// <param name="submenu"></param>
        private void ShowSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                HideSubmenu();
                submenu.Visible = true;
            }
            else { submenu.Visible = false; }
        }

        /// <summary>
        /// RESUMEN:este metodo muestra submenu de usuarios cuando se presiona el button1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            ShowSubMenu(submenuusuario);
        }
        /// <summary>
        /// RESUMEN:este metodo muestra pel submenu de administadores cuando se presiona el button10
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button10_Click(object sender, EventArgs e)
        {
            ShowSubMenu(submenuadministradores);
        }
        /// <summary>
        /// RESUMEN:este metodo muestra pel submenu de libros cuando se presiona el button15
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button15_Click_1(object sender, EventArgs e)
        {
            ShowSubMenu(submenuLibros);
        }
        /// <summary>
        /// RESUMNE:este metodo muestra pel submenu de prestamos cuando se presiona el button25
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button25_Click_1(object sender, EventArgs e)
        {
            ShowSubMenu(submenuPrestamos);
        }
        private void submenuPrestamos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// RESUMEN:se ejecuta Cuando se presiona la imagen pictureBox3 se vuelve a la ventana de login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Login ventana = new Login();
            this.Hide();
            ventana.Show();
        }
        /// <summary>
        /// RESUMEN:se ejecuta cuando se presiona la etiqueta  label1 se vuelve a la ventana de login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label1_Click(object sender, EventArgs e)
        {
            Login ventana = new Login();
            this.Hide();
            ventana.Show();
        }
        ///
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        /// <summary>
        /// RESUMEN:se ejecuta cuando se presiona el button2 se abre la ventana RegistrarUsuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistroDeUsuario ventana = new RegistroDeUsuario(nombreUsuario);
            ventana.Show(this);
        }
        /// <summary>
        /// RESUMEN:se ejecuta cuando se presiona el button3 se abre la ventana GestionarUsuarios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionDeUsuarios ventana = new GestionDeUsuarios(nombreUsuario);
            ventana.Show(this);
        }
        /// <summary>
        /// RESUMEN:se ejecuta cuando se presiona el button9 se abre la ventana RegistrarAdministradores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistroDeAdministrador ventana = new RegistroDeAdministrador(nombreUsuario);
            ventana.Show(this);
        }
        /// <summary>
        /// RESUMEN:se ejecuta cuando se presiona el button13 se abre la ventana GestionarLibros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionDeLibros ventana = new GestionDeLibros(nombreUsuario);
            ventana.Show(this);
        }
        /// <summary>
        /// RESUMEN:se ejecuta cuando se presiona el button8 se abre la ventana GestionarAdministradores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionDeAdministradores ventana = new GestionDeAdministradores(nombreUsuario);
            ventana.Show(this);
        }
        /// <summary>
        /// RESUMEN.se ejecuta cuando se presiona el button14 se abre la ventana RegistrarLibro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button14_Click(object sender, EventArgs e)
        {
            RegistroDeLibro ventana = new RegistroDeLibro(nombreUsuario);
            this.Hide();
            ventana.Show(this);
        }
        /// <summary>
        /// RESUMEN:se ejecuta cuando se presiona el button24 se abre la ventana RegistrarPrestamos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button24_Click(object sender, EventArgs e)
        {
            RegistroDePrestamo ventana = new RegistroDePrestamo(nombreUsuario);
            this.Hide();
            ventana.Show(this);
        }
        /// <summary>
        /// RESUMEN:se ejecuta cuando se presiona el button23 se abre la ventana GestionarPrestamos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button23_Click(object sender, EventArgs e)
        {
            GestionDePrestamos ventana = new GestionDePrestamos(nombreUsuario);
            this.Hide();
            ventana.Show(this);
        }
        /// <summary>
        /// RESUMEN:se ejecuta cuando se cierra el formulario se vuelve a la ventana de login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Menu2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login ventana = new Login();
            this.Hide();
            ventana.Show();
        }

        private void labelId_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
