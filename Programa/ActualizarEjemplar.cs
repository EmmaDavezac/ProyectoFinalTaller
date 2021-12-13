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
    public partial class ActualizarEjemplar : Form
    {
        private InterfazNucleo interfazNucleo = new InterfazNucleo();
         
        private int idUsuario { get; set; }
        private string NombreUsuario { get; set; }
        public ActualizarEjemplar(string iD)
        {
            InitializeComponent();
            idUsuario = Convert.ToInt32(iD);
            NombreUsuario = interfazNucleo.ObtenerAdministrador(idUsuario).Nombre;
            labelNombreUsuario.Text = "Usuario: " + NombreUsuario;
            textBoxId.Focus();
        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {
            buttonBuscar.Enabled = true;
            buttonSeleccionar.Enabled = false;
        }

        private void textBoxIdLibro_TextChanged(object sender, EventArgs e)
        {

        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu2 ventana = new Menu2(idUsuario.ToString());
            ventana.Show();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            textBoxTitulo.Clear();
            textBoxAutor.Clear();
            textBoxAñoPublicacion.Clear();
            textBoxISBN.Clear();
            if (textBoxId.Text != null && (textBoxId.Text).All(char.IsDigit) && textBoxId.Text != "")
            {
                int id = Convert.ToInt32(textBoxId.Text);
                if (interfazNucleo.ObtenerEjemplar(id) != null)
                {
                    if (interfazNucleo.ObtenerEjemplar(id).Disponible)
                    {
                        comboBox1.Text = interfazNucleo.ObtenerEjemplar(id).Estado.ToString();
                        textBoxIdLibro.Text = interfazNucleo.ObtenerLibroDeEjemplar(id).Id.ToString();
                        textBoxTitulo.Text = interfazNucleo.ObtenerLibroDeEjemplar(id).Titulo;
                        textBoxAutor.Text = interfazNucleo.ObtenerLibroDeEjemplar(id).Autor;
                        textBoxAñoPublicacion.Text = interfazNucleo.ObtenerLibroDeEjemplar(id).AñoPublicacion;

                        textBoxISBN.Text = interfazNucleo.ObtenerLibroDeEjemplar(id).ISBN;
                        buttonBuscar.Enabled = false;
                        buttonSeleccionar.Enabled = true;
                    }
                    else { labelError.Text = "El id ingresado corresponde a un ejemplar prestado, por lo tanto no puede actualizarse "; buttonBuscar.Enabled = false; textBoxId.Clear(); textBoxId.Focus(); }
                }
                else { labelError.Text = "El Id ingresado no corresponde a un ejemplar registrado "; textBoxId.Clear(); textBoxId.Focus(); buttonBuscar.Enabled = false; }
            }
            else { labelError.Text = "El Id ingresado es incorrecto ";  textBoxId.Clear(); textBoxId.Focus(); buttonBuscar.Enabled = false; }
        }

        private void CEjemplar_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Menu2 ventanaMenu = new Menu2(idUsuario.ToString());
            ventanaMenu.Show();
        }

        private void labelNombreUsuario_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBox1.Text) && comboBox1.Text != interfazNucleo.ObtenerEjemplar(Convert.ToInt32(textBoxId.Text)).Estado.ToString())
            {
                buttonGuardar.Enabled = true;
            }
            else buttonGuardar.Enabled = false;
        }

        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {
            textBoxId.Enabled = false;
            comboBox1.Enabled = true;
            buttonSeleccionar.Enabled = false;
            buttonSeleccionar.Text = "Seleccionado";
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            interfazNucleo.ActualizarEjemplar(textBoxId.Text, comboBox1.Text);
            Menu2 ventana = new Menu2(idUsuario.ToString());
        }

        private void ActualizarEjemplar_Load(object sender, EventArgs e)
        {

        }
    }
}
