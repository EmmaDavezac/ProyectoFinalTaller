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
    public partial class Menu2 : Form
    {
        private string NombreUsuario { get; set; }
        private string NombreYApellido { get; set; }
        private string idUsuario { get; set; }
        InterfazNucleo interfazNucleo = new InterfazNucleo();
        public Menu2(string iD)
        {
            InitializeComponent();
            idUsuario = iD;
            NombreYApellido = interfazNucleo.ObtenerAdministradorPorNombreOMail(idUsuario).Nombre + " " + interfazNucleo.ObtenerAdministradorPorNombreOMail(idUsuario).Apellido;
            NombreUsuario = interfazNucleo.ObtenerAdministradorPorNombreOMail(idUsuario).NombreUsuario;
            labelNombreUsuario.Text = "Nombre de Usuario: " + NombreUsuario;
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
            submenuEjemplares.Visible = false;
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
            if (submenuEjemplares.Visible == true)
            {
                submenuEjemplares.Visible = false;
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

        private void button20_Click(object sender, EventArgs e)
        {
            ShowSubMenu(submenuEjemplares);
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
            RegistrarUsuario ventanaAgregarCliente = new RegistrarUsuario(idUsuario.ToString());
            ventanaAgregarCliente.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConsultarUsuario ventana = new ConsultarUsuario(idUsuario.ToString());
            this.Hide();
            ventana.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ActualizarUsuario ventana = new ActualizarUsuario(idUsuario.ToString());
            this.Hide();
            ventana.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            VerUsuarios ventana = new VerUsuarios(idUsuario.ToString());
            this.Hide();
            ventana.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrarAdministrador ventana = new RegistrarAdministrador(idUsuario.ToString());
            ventana.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ConsultarLibro ventana = new ConsultarLibro(idUsuario.ToString());
            this.Hide();
            ventana.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultarAdministrador ventana = new ConsultarAdministrador(idUsuario.ToString());
            ventana.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ActualizarAdministrador ventana = new ActualizarAdministrador(idUsuario.ToString());
            this.Hide();
            ventana.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            VerAdministradores ventana = new VerAdministradores(idUsuario.ToString());
            this.Hide();
            ventana.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            RegistrarEjemplar ventana = new RegistrarEjemplar(idUsuario.ToString());
            this.Hide();
            ventana.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            RegistrarLibro ventana = new RegistrarLibro(idUsuario.ToString());
            this.Hide();
            ventana.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            VerLibros ventana = new VerLibros(idUsuario.ToString());
            this.Hide();
            ventana.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ActualizarLibro ventana = new ActualizarLibro(idUsuario.ToString());
            this.Hide();
            ventana.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            ConsultarEjemplara ventana = new ConsultarEjemplara(idUsuario.ToString());
            this.Hide();
            ventana.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            ActualizarEjemplar ventana = new ActualizarEjemplar(idUsuario.ToString());
            this.Hide();
            ventana.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            VerEjemplares ventana = new VerEjemplares(idUsuario.ToString());
            this.Hide();
            ventana.Show();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            RegistrarPrestamo ventana = new RegistrarPrestamo(idUsuario.ToString());
            this.Hide();
            ventana.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            ConsultarPrestamo ventana = new ConsultarPrestamo(idUsuario.ToString());
            this.Hide();
            ventana.Show();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            RegistrarDevolucion ventana = new RegistrarDevolucion(idUsuario.ToString());
            this.Hide();
            ventana.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            VerPrestamos ventana = new VerPrestamos(idUsuario.ToString());
            this.Hide();
            ventana.Show();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            VerPrestamosProximosAVencer ventana = new VerPrestamosProximosAVencer(idUsuario.ToString());
            this.Hide();
            ventana.Show();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            VerPrestamosRetrasados ventana = new VerPrestamosRetrasados(idUsuario.ToString());
            this.Hide();
            ventana.Show();
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
