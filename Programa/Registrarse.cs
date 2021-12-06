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
    public partial class Registrarse : Form
    {
        public Registrarse()
        {
            InitializeComponent();
        }

        private void buttonRegistrarAdministrador_Click(object sender, EventArgs e)
        {
            if (textBoxApellido.Text != null && textBoxNombre.Text != null && textBoxMail.Text != null && dateTimePickerFechaNacimiento.Value.Date != new DateTime(2021, 12, 1) && textBoxContraseña.Text != null)
            {
                Nucleo.InterfazNucleo fachada = new Nucleo.InterfazNucleo();
                fachada.AñadirAdministrador(textBoxNombre.Text, textBoxApellido.Text, dateTimePickerFechaNacimiento.Value, textBoxMail.Text, textBoxContraseña.Text);
                MessageBox.Show("La cuenta de administrador ha sido creada, su id de accceso es: "+fachada.ObtenerUltimoIdAdministrador(), "Operacion Exitosa", MessageBoxButtons.OK);
                this.Hide();
                Login ventana = new Login();
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

        private void Registrarse_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Registrarse_Load(object sender, EventArgs e)
        {

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
