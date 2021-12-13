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
    public partial class ConsultarLibro : Form
    {
        private string NombreUsuario { get; set; }
        private int idUsuario { get; set; }
        InterfazNucleo interfazNucleo = new InterfazNucleo();
        public ConsultarLibro(string iD)
        {
            InitializeComponent();
            idUsuario = Convert.ToInt32(iD);
            NombreUsuario = interfazNucleo.ObtenerAdministrador(idUsuario).Nombre;
            labelNombreUsuario.Text = "Usuario: " + NombreUsuario;
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu2 ventana = new Menu2(idUsuario.ToString());
            ventana.Show();
        }

        private void buttonBuscarUsuario_Click(object sender, EventArgs e)
        {
            textBoxTitulo.Clear();
            textBoxAutor.Clear();
            textBoxAñoPublicacion.Clear();
            textBoxISBN.Clear();
            if (textBoxId.Text != null && (textBoxId.Text).All(char.IsDigit) && textBoxId.Text != "")
            {
                Libro libro = new InterfazNucleo().ObtenerLibro(Convert.ToInt32(textBoxId.Text));
                if (libro != null)
                {
                    textBoxTitulo.Text = libro.Titulo;
                    textBoxAutor.Text = libro.Autor;
                    textBoxAñoPublicacion.Text = libro.AñoPublicacion;
                    textBoxISBN.Text = libro.ISBN;
                    buttonBuscarLibro.Enabled = false;
                }
                else { labelError.Text = "El Id ingresado no corresponde a un libro registrado "; buttonBuscarLibro.Enabled = false; textBoxId.Clear(); textBoxId.Focus(); }
            }
            else { labelError.Text = "El Id ingresado es incorrecto "; buttonBuscarLibro.Enabled = false; textBoxId.Clear(); textBoxId.Focus(); }
        }

        private void textTitulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConsultarLibro_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Menu2 ventanaMenu = new Menu2(idUsuario.ToString());
            ventanaMenu.Show();
        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {
            buttonBuscarLibro.Enabled = true;
        }

        private void ConsultarLibro_Load(object sender, EventArgs e)
        {

        }
    }
}
