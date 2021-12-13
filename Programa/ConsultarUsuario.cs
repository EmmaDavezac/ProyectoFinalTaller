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
    public partial class ConsultarUsuario : Form
    {
        private string NombreUsuario { get; set; }
        private int idUsuario { get; set; }
        InterfazNucleo interfazNucleo = new InterfazNucleo();
        public ConsultarUsuario(string iD)
        {
            InitializeComponent();
            idUsuario = Convert.ToInt32(iD);
            NombreUsuario = interfazNucleo.ObtenerAdministrador(idUsuario).Nombre;
            labelNombreUsuario.Text = "Usuario: " + NombreUsuario;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonBuscarUsuario_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text!=null&&(textBoxId.Text).All(char.IsDigit)&& textBoxId.Text !="")
            {
                UsuarioSimple usuario = new Nucleo.InterfazNucleo().ObtenerUsuario(Convert.ToInt32(textBoxId.Text));
                if (usuario!=null)
                {
                    textBoxNombre.Text = usuario.Nombre;
                    textBoxApellido.Text = usuario.Apellido;
                    textBoxFecha.Text = Convert.ToString(usuario.FechaNacimiento.Date);
                    textBoxMail.Text = usuario.Mail;
                    textBoxScoring.Text = Convert.ToString(usuario.Scoring);
                    textBoxTelefono.Text = usuario.Telefono;
                    buttonBuscarUsuario.Enabled = false; 
                } else { labelError.Text = "El Id ingresado no corresponde a un usuario registrado "; buttonBuscarUsuario.Enabled = false; textBoxId.Focus(); }
            }
            else { labelError.Text="El Id ingresado es incorrecto ";buttonBuscarUsuario.Enabled = false; textBoxId.Focus(); }
        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {
            buttonBuscarUsuario.Enabled = true;
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu2 ventana = new Menu2(idUsuario.ToString());
            ventana.Show();
        }

        private void ConsultarUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Menu2 ventanaMenu = new Menu2(idUsuario.ToString());
            ventanaMenu.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ConsultarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void textBoxApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
