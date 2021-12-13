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
    public partial class ConsultarPrestamo : Form
    {
        private string NombreUsuario { get; set; }
        private int idUsuario { get; set; }
        InterfazNucleo interfazNucleo = new InterfazNucleo();
        public ConsultarPrestamo(string iD)
        {
            InitializeComponent();
            idUsuario = Convert.ToInt32(iD);
            NombreUsuario = interfazNucleo.ObtenerAdministrador(idUsuario).Nombre;
            labelNombreUsuario.Text = "Usuario: " + NombreUsuario;
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu2 ventanaMenu = new Menu2(idUsuario.ToString());
            ventanaMenu.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEstado_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxIdEjemplar_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text != null && (textBoxId.Text).All(char.IsDigit) && textBoxId.Text != "")
            {
                int id = Convert.ToInt32(textBoxId.Text);
                if (interfazNucleo.ObtenerPrestamo(id) != null)
                {
                    textBoxFecha.Text = interfazNucleo.ObtenerPrestamo(id).FechaPrestamo;
                    textBoxFechaLimite.Text = interfazNucleo.ObtenerPrestamo(id).FechaLimite;
                    textBoxFechaDevolucion.Text = interfazNucleo.ObtenerPrestamo(id).FechaDevolucion;

                    if (string.IsNullOrEmpty(interfazNucleo.ObtenerPrestamo(id).FechaDevolucion))
                    {
                        textBoxFechaDevolucion.Text = "No Devuelto";
                    }
                    if (interfazNucleo.ObtenerPrestamo(id).ProximoAVencerse())
                    {
                        textBoxFechaDevolucion.Text = interfazNucleo.ObtenerPrestamo(id).FechaDevolucion;
                    }
                    else textBoxProximoAVencer.Text = "No";
                    if (interfazNucleo.ObtenerPrestamo(id).Retrasado())
                    {
                        TextBoxRetrasado.Text = "Si";
                    }
                    else TextBoxRetrasado.Text = "No";

                    textBoxIdUsuario.Text = interfazNucleo.ObtenerUsuarioDePrestamo(id).Id.ToString();
                    textBoxNombre.Text = interfazNucleo.ObtenerUsuarioDePrestamo(id).Nombre;
                    textBoxApellido.Text= interfazNucleo.ObtenerUsuarioDePrestamo(id).Apellido; ;
                    textBoxIdLibro.Text = interfazNucleo.ObtenerLibroDePrestamo(id).Id.ToString();
                    textBoxTitulo.Text= interfazNucleo.ObtenerLibroDePrestamo(id).Titulo;
                    textBoxAutor.Text = interfazNucleo.ObtenerLibroDePrestamo(id).Autor;
                    textBoxISBN.Text= interfazNucleo.ObtenerLibroDePrestamo(id).ISBN;
                    textBoxIdEjemplar.Text = interfazNucleo.ObtenerEjemplarDePrestamo(id).Id.ToString();
                    textBoxEstado.Text = interfazNucleo.ObtenerEjemplarDePrestamo(id).Estado.ToString();
                    


                    buttonBuscar.Enabled = false;
                }
                else { labelError.Text = "El Id ingresado no corresponde a un Prestamo registrado "; buttonBuscar.Enabled = false; textBoxId.Clear(); textBoxId.Focus(); }
            }
            else { labelError.Text = "El Id ingresado es incorrecto "; buttonBuscar.Enabled = false; textBoxId.Clear(); textBoxId.Focus(); }
        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {
            buttonBuscar.Enabled = true;
        }

        private void ConsultarPrestamo_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Menu2 ventanaMenu = new Menu2(idUsuario.ToString());
            ventanaMenu.Show();
        }

        private void ConsultarPrestamo_Load(object sender, EventArgs e)
        {

        }
    }
}
