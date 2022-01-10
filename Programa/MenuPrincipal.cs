using Nucleo;
using System;
using System.Windows.Forms;

namespace Programa
{
    public partial class MenuPrincipal : Form
    {
        private string NombreYApellido { get; set; }
        private string nombreUsuario { get; set; }
        InterfazNucleo interfazNucleo = new InterfazNucleo();
        public MenuPrincipal(string pNombreUsuario)
        {
            InitializeComponent();
            nombreUsuario = pNombreUsuario;
            NombreYApellido = interfazNucleo.ObtenerAdministrador(nombreUsuario).Nombre + " " + interfazNucleo.ObtenerAdministrador(nombreUsuario).Apellido;
            labelNombreUsuario.Text = "Nombre de Usuario: " + nombreUsuario;
            labelNombreYApellido.Text = "Nombre: " + NombreYApellido;
        }

        private void Menu2_Load(object sender, EventArgs e)
        {
            CustomizeDosing();
        }
        private void CustomizeDosing()
        {
            submenuusuario.Visible = false;
            submenuadministradores.Visible = false;
            submenuLibros.Visible = false;
            submenuPrestamos.Visible = false;
        }
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
        private void ShowSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                HideSubmenu();
                submenu.Visible = true;
            }
            else { submenu.Visible = false; }
        }










        private void button1_Click_1(object sender, EventArgs e)
        {
            ShowSubMenu(submenuusuario);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ShowSubMenu(submenuadministradores);
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            ShowSubMenu(submenuLibros);
        }

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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Login ventana = new Login();
            this.Hide();
            ventana.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Login ventana = new Login();
            this.Hide();
            ventana.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrarUsuario ventana = new RegistrarUsuario(nombreUsuario);
            ventana.Show(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GestionarUsuarios ventana = new GestionarUsuarios(nombreUsuario);
            this.Hide();
            ventana.Show(this);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrarAdministrador ventana = new RegistrarAdministrador(nombreUsuario);
            ventana.Show(this);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionarLibros ventana = new GestionarLibros(nombreUsuario);
            ventana.Show(this);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionarAdministradores ventana = new GestionarAdministradores(nombreUsuario);
            ventana.Show(this);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            RegistrarLibro ventana = new RegistrarLibro(nombreUsuario);
            this.Hide();
            ventana.Show(this);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            RegistrarPrestamo ventana = new RegistrarPrestamo(nombreUsuario);
            this.Hide();
            ventana.Show(this);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            GestionarPrestamos ventana = new GestionarPrestamos(nombreUsuario);
            this.Hide();
            ventana.Show(this);
        }
        private void Menu2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void labelId_Click(object sender, EventArgs e)
        {

        }
    }
}
