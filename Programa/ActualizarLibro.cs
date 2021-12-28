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
    public partial class ActualizarLibro : Form
    {
        InterfazNucleo interfazNucleo = new InterfazNucleo();
       
        private string NombreUsuario { get; set; }
        public ActualizarLibro(string nombreUsuario,int id)
        {
            InitializeComponent();
            NombreUsuario = nombreUsuario;
            labelNombreUsuario.Text = "Usuario: " + NombreUsuario;
            textBoxId.Text = id.ToString(); 
            textBoxTitulo.Text= interfazNucleo.ObtenerLibro(id).Titulo;
            textBoxISBN.Text = interfazNucleo.ObtenerLibro(id).ISBN;
            textBoxAutor.Text = interfazNucleo.ObtenerLibro(id).Autor;
            textBoxAñoPublicacion.Text = interfazNucleo.ObtenerLibro(id).AñoPublicacion;
            textBoxCantEjemplares.Text = interfazNucleo.ObtenerCantidadEjemplaresLibro(id).ToString() ;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void buttonBorrarCambios_Click(object sender, EventArgs e)
        {
            Libro libro = interfazNucleo.ObtenerLibro(Convert.ToInt32(textBoxId.Text));

            textBoxTitulo.Text = libro.Titulo;
            textBoxAutor.Text = libro.Autor;
            textBoxAñoPublicacion.Text = libro.AñoPublicacion;
            textBoxISBN.Text = libro.ISBN;
            buttonDeshacerCambios.Enabled = false;
            buttonGuardar.Enabled = false;
        }

        private void textBoxAutor_TextChanged(object sender, EventArgs e)
        {
            buttonDeshacerCambios.Enabled = true;
            buttonGuardar.Enabled = true;
        }

        private void textBoxTitulo_TextChanged(object sender, EventArgs e)
        {
            buttonDeshacerCambios.Enabled = true;
            buttonGuardar.Enabled = true;
        }

        private void textBoxISBN_TextChanged(object sender, EventArgs e)
        {
            buttonDeshacerCambios.Enabled = true;
            buttonGuardar.Enabled = true;
        }

        private void textBoxAñoPublicacion_TextChanged(object sender, EventArgs e)
        {
            buttonDeshacerCambios.Enabled = true;
            buttonGuardar.Enabled = true;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxTitulo.Text) && !string.IsNullOrEmpty(textBoxAutor.Text) && !string.IsNullOrEmpty(textBoxISBN.Text) && !string.IsNullOrEmpty(textBoxAñoPublicacion.Text))
            {

                new InterfazNucleo().ActualizarLibro(Convert.ToInt32(textBoxId.Text), textBoxISBN.Text, textBoxTitulo.Text, textBoxAutor.Text, textBoxAñoPublicacion.Text);
                MessageBox.Show("El libro Id:" + textBoxId.Text + " se ha actualizado exitosamente!");
                this.Hide();
                this.Owner.Show();
            }
            else
            {
                MessageBox.Show("Debe completar la informacion");
                textBoxTitulo.Focus();
            }
        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void ActualizarLibro_Load(object sender, EventArgs e)
        {

        }

        private void labelNombreUsuario_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ActualizarLibro_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonEnAPI_Click(object sender, EventArgs e)
        {
            RegistrarLibro ventana = new RegistrarLibro(NombreUsuario);
            this.Hide();
            ventana.InicializarLibro(Convert.ToInt32(textBoxId.Text));
            ventana.ShowDialog(this);
        }

        public void CargarDatosDeBusquedaAvanzada(string pTitulo, string pAutor, string pAñoPublicacion, string pISBN)
        {
            textBoxAutor.Text = pAutor;
            textBoxAñoPublicacion.Text = pAñoPublicacion;
            textBoxISBN.Text = pISBN;
            textBoxTitulo.Text = pTitulo;
        }

        private void textBoxCantEjemplares_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

