using Nucleo;
using System;
using System.Windows.Forms;

namespace Programa
{
    public partial class MenuPrincipal : Form
    //Este formulario es el menu principal de la aplicacion y permite acceder a las funciones del sistema
    {
        private string NombreYApellido { get; set; }//Se almacena el nombre completo del usuario que inicio sesion
        private string nombreUsuario { get; set; }//Se almacena el nombre de usuario del usuario que inicio sesion
        FachadaNucleo interfazNucleo = new FachadaNucleo();//instancia del nucleo del programa que nos permite acceder a las funciones del sistema
        public MenuPrincipal(string pNombreUsuario)//Constructor de la clase
        {
            InitializeComponent();
            nombreUsuario = pNombreUsuario;
            NombreYApellido = interfazNucleo.ObtenerAdministrador(nombreUsuario).Nombre + " " + interfazNucleo.ObtenerAdministrador(nombreUsuario).Apellido;
            labelNombreUsuario.Text = "Nombre de Usuario: " + nombreUsuario;
            labelNombreYApellido.Text = "Nombre: " + NombreYApellido;
        }

        private void Menu2_Load(object sender, EventArgs e)//se ejecuta cuando se crea formulario
        {
            CustomizeDosing();//oculta todos los submenus
        }
        private void CustomizeDosing()//oculta todos los submenus
        {
            submenuusuario.Visible = false;
            submenuadministradores.Visible = false;
            submenuLibros.Visible = false;
            submenuPrestamos.Visible = false;
        }
        private void HideSubmenu()//este metodo oculta los submenus abiertos
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
        private void ShowSubMenu(Panel submenu)//este metodo muestra un submenu si esta oculto o lo oculta si esta visible
        {
            if (submenu.Visible == false)
            {
                HideSubmenu();
                submenu.Visible = true;
            }
            else { submenu.Visible = false; }
        }


        private void button1_Click_1(object sender, EventArgs e)//este metodo muestra submenu de usuarios cuando se presiona el button1
        {
            ShowSubMenu(submenuusuario);
        }

        private void button10_Click(object sender, EventArgs e)//este metodo muestra pel submenu de administadores cuando se presiona el button10
        {
            ShowSubMenu(submenuadministradores);
        }

        private void button15_Click_1(object sender, EventArgs e)//este metodo muestra pel submenu de libros cuando se presiona el button15
        {
            ShowSubMenu(submenuLibros);
        }

        private void button25_Click_1(object sender, EventArgs e)//este metodo muestra pel submenu de prestamos cuando se presiona el button25
        {
            ShowSubMenu(submenuPrestamos);
        }
        private void submenuPrestamos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)//Cuando se presiona la imagen pictureBox3 se vuelve a la ventana de login
        {
            Login ventana = new Login();
            this.Hide();
            ventana.Show();
        }

        private void label1_Click(object sender, EventArgs e)//cuando se presiona la etiqueta  label1 se vuelve a la ventana de login
        {
            Login ventana = new Login();
            this.Hide();
            ventana.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)//cuando se presiona el button2 se abre la ventana RegistrarUsuario
        {
            this.Hide();
            RegistrarUsuario ventana = new RegistrarUsuario(nombreUsuario);
            ventana.Show(this);
        }

        private void button3_Click(object sender, EventArgs e)//cuando se presiona el button3 se abre la ventana GestionarUsuarios
        {
            this.Hide();
            GestionarUsuarios ventana = new GestionarUsuarios(nombreUsuario);
            ventana.Show(this);
        }

        private void button9_Click(object sender, EventArgs e)//cuando se presiona el button9 se abre la ventana RegistrarAdministradores
        {
            this.Hide();
            RegistrarAdministrador ventana = new RegistrarAdministrador(nombreUsuario);
            ventana.Show(this);
        }

        private void button13_Click(object sender, EventArgs e)//cuando se presiona el button13 se abre la ventana GestionarLibros
        {
            this.Hide();
            GestionarLibros ventana = new GestionarLibros(nombreUsuario);
            ventana.Show(this);
        }

        private void button8_Click(object sender, EventArgs e)//cuando se presiona el button8 se abre la ventana GestionarAdministradores
        {
            this.Hide();
            GestionarAdministradores ventana = new GestionarAdministradores(nombreUsuario);
            ventana.Show(this);
        }

        private void button14_Click(object sender, EventArgs e)//cuando se presiona el button14 se abre la ventana RegistrarLibro
        {
            RegistrarLibro ventana = new RegistrarLibro(nombreUsuario);
            this.Hide();
            ventana.Show(this);
        }

        private void button24_Click(object sender, EventArgs e)//cuando se presiona el button24 se abre la ventana RegistrarPrestamos
        {
            RegistrarPrestamo ventana = new RegistrarPrestamo(nombreUsuario);
            this.Hide();
            ventana.Show(this);
        }

        private void button23_Click(object sender, EventArgs e)//cuando se presiona el button23 se abre la ventana GestionarPrestamos
        {
            GestionarPrestamos ventana = new GestionarPrestamos(nombreUsuario);
            this.Hide();
            ventana.Show(this);
        }
        private void Menu2_FormClosed(object sender, FormClosedEventArgs e)//cuando se cierra el formulario se vuelve a la ventana de login
        {
            Login ventana = new Login();
            this.Hide();
            ventana.Show();
        }

        private void labelId_Click(object sender, EventArgs e)
        {

        }
    }
}
