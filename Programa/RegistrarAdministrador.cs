using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Nucleo;

namespace Programa
{
    public partial class RegistrarAdministrador : Form
    {
        private string NombreUsuario { get; set; }
        public RegistrarAdministrador(string nombreUsuario)
        {
            NombreUsuario = nombreUsuario;
            InitializeComponent();
        }

        private void AgregarAdministrador_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAñadirUsuario_Click(object sender, EventArgs e)
        {
            if (textBoxApellido.Text != null && textBoxNombre.Text != null && textBoxMail.Text != null && dateTimePickerFechaNacimiento.Value.Date != DateTime.Now.Date&&textBoxContraseña.Text!=null)
            {
                Fachada fachada = new Fachada();
                fachada.AñadirAdministrador(textBoxNombre.Text, textBoxApellido.Text, dateTimePickerFechaNacimiento.Value, textBoxMail.Text,textBoxContraseña.Text);
                this.Hide();
                Login ventana= new Login();
                ventana.Show();
            }
            else
            {
                this.labelError.Text = "Error, ingrese todos los datos";
                buttonRegistrarAdministrador.Enabled = false;
                textBoxNombre.Focus(); ;
            }
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login ventanaMenu = new Login();
            ventanaMenu.Show();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegistrarAdministrador_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            buttonRegistrarAdministrador.Enabled = true;
        }

        private void textBoxApellido_TextChanged(object sender, EventArgs e)
        {
            buttonRegistrarAdministrador.Enabled = true;
        }

        private void dateTimePickerFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            buttonRegistrarAdministrador.Enabled = true;
        }

        private void textBoxMail_TextChanged(object sender, EventArgs e)
        {
            buttonRegistrarAdministrador.Enabled = true;
        }

        private void textBoxContraseña_TextChanged(object sender, EventArgs e)
        {
            buttonRegistrarAdministrador.Enabled = true;
        }
    }
}
