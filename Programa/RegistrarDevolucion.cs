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
    public partial class RegistrarDevolucion : Form
    {
        private InterfazNucleo interfazNucleo = new InterfazNucleo();
        private string NombreUsuario { get; set; }
        public RegistrarDevolucion(string nombreUsuario)
        {
            InitializeComponent();
            NombreUsuario = nombreUsuario;
            labelNombreUsuario.Text = NombreUsuario;
        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {
            buttonBuscar.Enabled = true;
            buttonGuardar.Enabled = false;
            comboBox1.Enabled = false;
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text != null && (textBoxId.Text).All(char.IsDigit) && textBoxId.Text != "")
            {
                int id = Convert.ToInt32(textBoxId.Text);
                if (interfazNucleo.ObtenerPrestamo(id) != null)
                {
                    if (string.IsNullOrEmpty(interfazNucleo.ObtenerPrestamo(id).FechaDevolucion))
                    {
                        textBoxFecha.Text = interfazNucleo.ObtenerPrestamo(id).FechaPrestamo;
                        textBoxFechaLimite.Text = interfazNucleo.ObtenerPrestamo(id).FechaLimite;
                        if (interfazNucleo.ObtenerPrestamo(id).Retrasado())
                        {
                            TextBoxRetrasado.Text = "Si";
                        }
                        else TextBoxRetrasado.Text = "No";

                        textBoxIdUsuario.Text = interfazNucleo.ObtenerUsarioDePrestamo(id).Id.ToString();
                        textBoxNombre.Text = interfazNucleo.ObtenerUsarioDePrestamo(id).Nombre;
                        textBoxApellido.Text = interfazNucleo.ObtenerUsarioDePrestamo(id).Apellido; ;
                        textBoxIdLibro.Text = interfazNucleo.ObtenerLibroDePrestamo(id).Id.ToString();
                        textBoxTitulo.Text = interfazNucleo.ObtenerLibroDePrestamo(id).Titulo;
                        textBoxAutor.Text = interfazNucleo.ObtenerLibroDePrestamo(id).Autor;
                        textBoxISBN.Text = interfazNucleo.ObtenerLibroDePrestamo(id).ISBN;
                        textBoxIdEjemplar.Text = interfazNucleo.ObtenerEjemplarDePrestamo(id).Id.ToString();
                        comboBox1.Text = interfazNucleo.ObtenerEjemplarDePrestamo(id).Estado.ToString();
                        buttonBuscar.Enabled = false;
                        if (comboBox1.Text == "Malo")
                        {
                            buttonGuardar.Enabled = true;
                        }
                        else comboBox1.Enabled = true;


                    }
                    else { labelError.Text = "El Id ingresado no corresponde a un Prestamo ya devuelto "; buttonBuscar.Enabled = false; textBoxId.Clear(); textBoxId.Focus(); }
                }
                else { labelError.Text = "El Id ingresado no corresponde a un Prestamo registrado "; buttonBuscar.Enabled = false; textBoxId.Clear(); textBoxId.Focus(); }
            }
            else { labelError.Text = "El Id ingresado es incorrecto "; buttonBuscar.Enabled = false; textBoxId.Clear(); textBoxId.Focus(); }
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal ventanaMenu = new MenuPrincipal(NombreUsuario);
            ventanaMenu.Show();
        }

        private void textBoxIdLibro_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            interfazNucleo.RegistrarDevolucion(Convert.ToInt32(textBoxId.Text), comboBox1.Text);
            MessageBox.Show("La devolucion se ha registrado con exito");
            this.Hide();
            MenuPrincipal ventanaMenu = new MenuPrincipal(NombreUsuario);
            ventanaMenu.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonGuardar.Enabled = true;
        }

        private void RegistrarDevolucion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void labelNombreUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
