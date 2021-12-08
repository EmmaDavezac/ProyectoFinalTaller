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
        public ActualizarLibro(string nombreUsuario)
        {
            InitializeComponent();
            NombreUsuario = nombreUsuario;
            labelNombreUsuario.Text = NombreUsuario;
        }

            private void textBox1_TextChanged(object sender, EventArgs e)
        {
            buttonBuscar.Enabled = true;
            buttonSeleccionar.Enabled = false;
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            {
                textBoxTitulo.Clear();
                textBoxAutor.Clear();
                textBoxAñoPublicacion.Clear();
                textBoxISBN.Clear();
                if (textBoxId.Text != null && (textBoxId.Text).All(char.IsDigit) && textBoxId.Text != "")
                {
                    Libro libro = interfazNucleo.ObtenerLibro(Convert.ToInt32(textBoxId.Text));
                    if (libro != null)
                    {
                        textBoxTitulo.Text = libro.Titulo;
                        textBoxAutor.Text = libro.Autor;
                        textBoxAñoPublicacion.Text = libro.AñoPublicacion;
                        textBoxISBN.Text = libro.ISBN;
                        buttonBuscar.Enabled = false;
                        buttonSeleccionar.Enabled = true;
                        buttonGuardar.Enabled = false;
                    }
                    else { labelError.Text = "El Id ingresado no corresponde a un libro registrado "; buttonBuscar.Enabled = false; textBoxId.Clear(); textBoxId.Focus(); }
                }
                else { labelError.Text = "El Id ingresado es incorrecto "; buttonBuscar.Enabled = false; textBoxId.Clear(); textBoxId.Focus(); }
            }
        }

        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {
            textBoxId.Enabled = false;
            buttonSeleccionar.Text = "Seleccionado";
            buttonSeleccionar.Enabled = false;
            textBoxTitulo.Enabled = true;
            textBoxAutor.Enabled = true;
            textBoxAñoPublicacion.Enabled = true;
            textBoxISBN.Enabled = true;
            textBoxBuscar.Enabled = true;
            buttonBuscarEnPagina.Enabled = true;
            dataGridView1.Enabled = true;
            buttonGuardar.Enabled = false;
        }

        private void buttonBuscarEnPagina_Click(object sender, EventArgs e)
        {
            if (textBoxBuscar.Text != null && textBoxBuscar.Text != "")
            {
                int resultado = 0;
                dataGridView1.Rows.Clear();
                foreach (var item in  interfazNucleo.ListarLibrosDeAPIPorCoincidencia(textBoxBuscar.Text))
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = item.Titulo;
                    dataGridView1.Rows[n].Cells[1].Value = item.Autor;
                    dataGridView1.Rows[n].Cells[2].Value = item.AñoPublicacion;
                    dataGridView1.Rows[n].Cells[3].Value = item.ISBN;
                    resultado += 1;
                }

                if (resultado == 0) { labelResultados.Text = "No se encontraron resultados"; buttonBuscar.Enabled = false; textBoxBuscar.Focus(); }
                else
                {
                    labelResultados.Text = "";
                    buttonBuscar.Enabled = false;
                    textBoxBuscar.Focus();
                }
            }
            else
            {
                labelResultados.Text = "No ingreso un termino de busqueda";
                buttonBuscar.Enabled = false;
                textBoxBuscar.Focus();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                textBoxTitulo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBoxAutor.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBoxAñoPublicacion.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBoxISBN.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                buttonDeshacerCambios.Enabled = true;
            }
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal ventanaMenu = new MenuPrincipal(NombreUsuario);
            ventanaMenu.Show();
        }

        private void buttonBorrarCambios_Click(object sender, EventArgs e)
        {
            Libro libro = interfazNucleo.ObtenerLibro(Convert.ToInt32(textBoxId.Text));
           
                textBoxTitulo.Text = libro.Titulo;
                textBoxAutor.Text = libro.Autor;
                textBoxAñoPublicacion.Text = libro.AñoPublicacion;
                textBoxISBN.Text = libro.ISBN;
                buttonBuscar.Enabled = false;
                buttonSeleccionar.Enabled = true;
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

                new InterfazNucleo().ActualizarLibro(Convert.ToInt32(textBoxId.Text),textBoxISBN.Text, textBoxTitulo.Text, textBoxAutor.Text, textBoxAñoPublicacion.Text);
                MessageBox.Show("El libro Id:"+textBoxId.Text+" se ha actualizado exitosamente!");
                this.Hide();
                MenuPrincipal ventanaMenu = new MenuPrincipal(NombreUsuario);
                ventanaMenu.Show();

            }
            else
            {
                MessageBox.Show("Debe completar la informacion");
                textBoxTitulo.Focus();
            }
        }
    }
    }

