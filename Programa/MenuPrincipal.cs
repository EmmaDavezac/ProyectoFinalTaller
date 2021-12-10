using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa
{
    public partial class MenuPrincipal : Form
    {
        private string NombreUsuario { get; set; }
        public MenuPrincipal(string nombreUsuario)
        {
            InitializeComponent();
            NombreUsuario = nombreUsuario;
            labelNombreUsuario.Text = "Usuario: "+NombreUsuario;
        }
        

        private void Menu_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void botonAñadirUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrarUsuario ventanaAgregarCliente = new RegistrarUsuario(NombreUsuario);
            ventanaAgregarCliente.Show();
        }

        private void botonSalir_Click(object sender, EventArgs e)
        { this.Hide();
            Login ventanaLogin = new Login();
            ventanaLogin.Show();
        }

        private void botonVerUsuarios_Click(object sender, EventArgs e)
        {
            VerUsuarios ventana=new VerUsuarios(NombreUsuario);
            this.Hide();
            ventana.Show();
        }

        private void botonBuscarUsuario_Click(object sender, EventArgs e)
        {
            ConsultarUsuario ventana = new ConsultarUsuario(NombreUsuario);
            this.Hide();
            ventana.Show();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            VerLibros ventana = new VerLibros(NombreUsuario);
            this.Hide();
            ventana.Show();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonRegistrarAdministrador_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrarAdministrador ventana = new RegistrarAdministrador(NombreUsuario);
            ventana.Show();
        }

        private void buttonBuscarAdministrador_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultarAdministrador ventana = new ConsultarAdministrador(NombreUsuario);
            ventana.Show();
        }

        private void buttonVerAdministradores_Click(object sender, EventArgs e)
        {
            VerAdministradores ventana = new VerAdministradores(NombreUsuario);
            this.Hide();
            ventana.Show();
        }

        private void buttonAñadirLibro_Click(object sender, EventArgs e)
        {
            RegistrarLibro ventana = new RegistrarLibro(NombreUsuario);
            this.Hide();
            ventana.Show();
        }

        private void buttonBuscarLibro_Click(object sender, EventArgs e)
        {
            ConsultarLibro ventana = new ConsultarLibro(NombreUsuario);
            this.Hide();
            ventana.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistrarEjemplar ventana = new RegistrarEjemplar(NombreUsuario);
            this.Hide();
            ventana.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            // ConsultarEjemplar ventana = new ConsultarEjemplar(NombreUsuario);
            ConsultarEjemplara ventana = new ConsultarEjemplara(NombreUsuario);
            this.Hide();
            ventana.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VerEjemplares ventana = new VerEjemplares(NombreUsuario);
            this.Hide();
            ventana.Show();
        }

        private void buttonRegistrarPrestamo_Click(object sender, EventArgs e)
        {
            RegistrarPrestamo ventana = new RegistrarPrestamo(NombreUsuario);
            this.Hide();
            ventana.Show();
        }

        private void buttonVerPrestamos_Click(object sender, EventArgs e)
        {
            VerPrestamos ventana = new VerPrestamos(NombreUsuario);
            this.Hide();
            ventana.Show();
        }

        private void buttonBuscarPrestamo_Click(object sender, EventArgs e)
        {
            ConsultarPrestamo ventana = new ConsultarPrestamo(NombreUsuario);
            this.Hide();
            ventana.Show();
        }

        private void buttonRegistrarDevolucion_Click(object sender, EventArgs e)
        {
            RegistrarDevolucion ventana = new RegistrarDevolucion(NombreUsuario);
            this.Hide();
            ventana.Show();
        }

        private void buttonActualizarUsuario_Click(object sender, EventArgs e)
        {
            ActualizarUsuario ventana = new ActualizarUsuario(NombreUsuario);
            this.Hide();
            ventana.Show();
        }

        private void buttonModificarAdministrador_Click(object sender, EventArgs e)
        {
            ActualizarAdministrador ventana = new ActualizarAdministrador(NombreUsuario);
            this.Hide();
            ventana.Show();
        }

        private void buttonPrestamosRetrasados_Click(object sender, EventArgs e)
        {
            VerPrestamosRetrasados ventana = new VerPrestamosRetrasados(NombreUsuario);
            this.Hide();
            ventana.Show();
        }

        private void buttonVerProximosAVencer_Click(object sender, EventArgs e)
        {
            VerPrestamosProximosAVencer ventana = new VerPrestamosProximosAVencer(NombreUsuario);
            this.Hide();
            ventana.Show();
        }

        private void buttonActualizarLibro_Click(object sender, EventArgs e)
        {
            ActualizarLibro ventana = new ActualizarLibro(NombreUsuario);
            this.Hide();
            ventana.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActualizarEjemplar ventana = new ActualizarEjemplar(NombreUsuario);
            this.Hide();
            ventana.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ActualizarContraseña ventana = new ActualizarContraseña(NombreUsuario);
            this.Hide();
            ventana.Show();
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

