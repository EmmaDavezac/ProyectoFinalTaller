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

       

     

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                textBoxTitulo.Text = dataGridViewTituloYAutor.CurrentRow.Cells[0].Value.ToString();
                textBoxAutor.Text = dataGridViewTituloYAutor.CurrentRow.Cells[1].Value.ToString();
                textBoxAñoPublicacion.Text = dataGridViewTituloYAutor.CurrentRow.Cells[2].Value.ToString();
                textBoxISBN.Text = dataGridViewTituloYAutor.CurrentRow.Cells[3].Value.ToString();
                buttonDeshacerCambios.Enabled = true;
            }
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionarLibros ventana = new GestionarLibros(NombreUsuario);
            ventana.Show();
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
                GestionarLibros ventana = new GestionarLibros(NombreUsuario);
                ventana.Show();

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
            GestionarLibros ventana = new GestionarLibros(NombreUsuario);
            ventana.Show();
        }

        private void textBoxBuscar_TextChanged_1(object sender, EventArgs e)
        {
            buttonBuscar.Enabled = true;
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (textBoxBuscar.Text != null && textBoxBuscar.Text != "")
            {
                int resultado = 0;
                dataGridViewTituloYAutor.Rows.Clear();
                List<Libro> resultados = interfazNucleo.ListarLibrosDeAPIPorCoincidencia(textBoxBuscar.Text);
                foreach (var item in resultados)
                {
                    int n = dataGridViewTituloYAutor.Rows.Add();
                    dataGridViewTituloYAutor.Rows[n].Cells[0].Value = item.Titulo;
                    dataGridViewTituloYAutor.Rows[n].Cells[1].Value = interfazNucleo.SacarAutorDeLaLista(item.Autor);
                    dataGridViewTituloYAutor.Rows[n].Cells[2].Value = item.AñoPublicacion;
                    dataGridViewTituloYAutor.Rows[n].Cells[3].Value = item.ISBN;
                    resultado += 1;
                }

                if (resultado == 0) { labelResultados.Text = "Error, no se encontraron resultados"; buttonBuscar.Enabled = false; textBoxBuscar.Focus(); }
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

        private void textBoxSeleccionarISBN_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSeleccionarISBN.Text != null)
            {
                for (int i = 0; i < dataGridViewISBN.Rows.Count - 1; i++)
                {
                    if (dataGridViewISBN.Rows[i].Cells[0].Value.ToString().Contains(textBoxSeleccionarISBN.Text.ToString()) == false)
                    {
                        dataGridViewISBN.Rows[i].Visible = false;
                    }
                    else
                    {
                        dataGridViewISBN.Rows[i].Visible = true;
                    }
                }
            }
        }

        private void textBoxSelccionarAño_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSelccionarAño.Text != null)
            {
                for (int i = 0; i < dataGridViewAños.Rows.Count - 1; i++)
                {
                    if (dataGridViewAños.Rows[i].Cells[0].Value.ToString().Contains(textBoxSelccionarAño.Text.ToString()) == false)
                    {
                        dataGridViewAños.Rows[i].Visible = false;
                    }
                    else
                    {
                        dataGridViewAños.Rows[i].Visible = true;
                    }
                }
            }
        }

        private void dataGridViewTituloYAutor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridViewTituloYAutor.CurrentRow.Cells[0].Value != null)
            {
                dataGridViewAños.Rows.Clear();
                dataGridViewISBN.Rows.Clear();
                textBoxTitulo.Text = dataGridViewTituloYAutor.CurrentRow.Cells[0].Value.ToString();
                textBoxAutor.Text = dataGridViewTituloYAutor.CurrentRow.Cells[1].Value.ToString();
                List<string> isbns = interfazNucleo.TransformarISBNsALista(dataGridViewTituloYAutor.CurrentRow.Cells[3].Value.ToString());
                foreach (var item in isbns)
                {
                    int n = dataGridViewISBN.Rows.Add();
                    dataGridViewISBN.Rows[n].Cells[0].Value = item;
                }
                List<string> años = interfazNucleo.TransformarAñosALista(dataGridViewTituloYAutor.CurrentRow.Cells[2].Value.ToString());
                foreach (var item in años)
                {
                    int n = dataGridViewAños.Rows.Add();
                    dataGridViewAños.Rows[n].Cells[0].Value = item;
                }
                /*List<string> resultados = textBoxISBN.Text.ToList();
                foreach (var item in resultados)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView2.Rows[n].Cells[0].Value = ;
                }*/
            }
        }

        private void dataGridViewISBN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textBoxISBN.Text = dataGridViewISBN.CurrentRow.Cells[0].Value.ToString();
            }
        }

        private void dataGridViewAños_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textBoxAñoPublicacion.Text = dataGridViewAños.CurrentRow.Cells[0].Value.ToString();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

