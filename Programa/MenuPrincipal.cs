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
        public MenuPrincipal(string nombreUsuario)
        {
            InitializeComponent();
            label1.Text = "Usuario: "+nombreUsuario;
        }
        public MenuPrincipal()
        {
            InitializeComponent();
            
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void botonAñadirUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            AgregarUsuario ventanaAgregarCliente = new AgregarUsuario();
            ventanaAgregarCliente.Show();
        }

        private void botonSalir_Click(object sender, EventArgs e)
        { this.Hide();
            Login ventanaLogin = new Login();
            ventanaLogin.Show();
        }

        private void botonVerUsuarios_Click(object sender, EventArgs e)
        {
            VerUsuarios ventana=new VerUsuarios();
            this.Hide();
            ventana.Show();
        }

        private void botonBuscarUsuario_Click(object sender, EventArgs e)
        {
            ConsultarUsuario ventana = new ConsultarUsuario();
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
    }
}
