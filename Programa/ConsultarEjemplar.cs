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
using Dominio;

namespace Programa
{
    public partial class ConsultarEjemplar : Form
    {
        
            private string NombreUsuario { get; set; }
            public ConsultarEjemplar(string nombreUsuario)
            {
                InitializeComponent();
                NombreUsuario = nombreUsuario;
                labelNombreUsuario.Text = "Usuario: " + NombreUsuario;
                textBoxId.Focus();
            }

            private void textBoxId_TextChanged(object sender, EventArgs e)
        {
            buttonBuscar.Enabled = true;
        }

        private void textBoxIdLibro_TextChanged(object sender, EventArgs e)
        {

        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal ventana = new MenuPrincipal(NombreUsuario);
            ventana.Show();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            textBoxEstado.Clear();
            textBoxTitulo.Clear();
            textBoxAutor.Clear();
            textBoxAñoPublicacion.Clear();
            textBoxISBN.Clear();
            textBoxDisponibilidad.Clear();
            if (textBoxId.Text != null && (textBoxId.Text).All(char.IsDigit) && textBoxId.Text != "")
            {
                int id = Convert.ToInt32(textBoxId.Text);
                if (new InterfazNucleo().ObtenerEjemplar(id) != null)
                {
                    textBoxEstado.Text = new InterfazNucleo().ObtenerEjemplar(id).Estado.ToString();
                    textBoxIdLibro.Text= new InterfazNucleo().ObtenerLibroDeEjemplar(id).Id.ToString();
                    textBoxTitulo.Text = new InterfazNucleo().ObtenerLibroDeEjemplar(id).Titulo;
                    textBoxAutor.Text = new InterfazNucleo().ObtenerLibroDeEjemplar(id).Autor;
                    textBoxAñoPublicacion.Text = new InterfazNucleo().ObtenerLibroDeEjemplar(id).AñoPublicacion;
                    if (new InterfazNucleo().ObtenerEjemplar(id).Disponible) textBoxDisponibilidad.Text = "Disponible"; else textBoxDisponibilidad.Text = "Prestado";
                    textBoxISBN.Text = new InterfazNucleo().ObtenerLibroDeEjemplar(id).ISBN;
                    buttonBuscar.Enabled = false;
                }
                else { labelError.Text = "El Id ingresado no corresponde a un ejemplar registrado "; buttonBuscar.Enabled = false; textBoxId.Clear(); textBoxId.Focus(); }
            }
            else { labelError.Text = "El Id ingresado es incorrecto "; buttonBuscar.Enabled = false; textBoxId.Clear(); textBoxId.Focus(); }
        }

        private void CEjemplar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
