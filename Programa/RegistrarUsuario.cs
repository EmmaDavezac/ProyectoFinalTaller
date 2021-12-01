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
    public partial class RegistrarUsuario : Form
    {
        private string NombreUsuario { get; set; }
        public RegistrarUsuario(string nombreUsuario)
        {
            NombreUsuario = nombreUsuario;
            InitializeComponent();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal ventanaMenu = new MenuPrincipal(NombreUsuario);
            ventanaMenu.Show();
        }

        private void AgregarCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AgregarCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAñadirUsuario_Click(object sender, EventArgs e)
        {

            if (textBoxApellido.Text != null && textBoxNombre.Text != null && textBoxMail.Text != null && dateTimePickerFechaNacimiento.Value.Date != DateTime.Now.Date)
            {
                Fachada fachada = new Fachada();
                fachada.AñadirUsuario(textBoxNombre.Text, textBoxApellido.Text, dateTimePickerFechaNacimiento.Value, textBoxMail.Text);
                this.Hide();
                MenuPrincipal ventanaMenu = new MenuPrincipal(NombreUsuario);
                ventanaMenu.Show();
            }
            else
            {
                this.labelError.Text = "Error, ingrese todos los datos";
                textBoxNombre.Focus();   ;
            }
            

        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void AgregarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void textBoxMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelApellido_Click(object sender, EventArgs e)
        {

        }

        private void labelError_Click(object sender, EventArgs e)
        {

        }
    }
}
