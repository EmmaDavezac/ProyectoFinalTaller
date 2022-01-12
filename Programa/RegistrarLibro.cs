using Dominio;
using Nucleo;
using System;
using System.Collections.Generic;
using System.Windows.Forms;



namespace Programa
{
    public partial class RegistrarLibro : Form
    {
        private string NombreUsuario { get; set; }
        FachadaNucleo interfazNucleo = new FachadaNucleo();
        public RegistrarLibro(string pNombreUsuario)
        {
            InitializeComponent();
            NombreUsuario = pNombreUsuario;

            labelNombreUsuario.Text = "Usuario: " + NombreUsuario;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridViewTituloYAutor.CurrentRow.Cells[0].Value != null)
            {
                dataGridViewAños.Rows.Clear();
                dataGridViewISBN.Rows.Clear();
                textBoxTitulo.Text = dataGridViewTituloYAutor.CurrentRow.Cells[0].Value.ToString();
                textBoxAutor.Text = dataGridViewTituloYAutor.CurrentRow.Cells[1].Value.ToString();
                buttonBorrarDatos.Enabled = true;
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
            }
        }

        private void BuscarLibrosAPI_Load(object sender, EventArgs e)
        {
            VerificarVentanaPadre();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            buttonBuscar.Enabled = true;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonAñadirLibro_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxTitulo.Text) && !string.IsNullOrEmpty(textBoxAutor.Text) && !string.IsNullOrEmpty(textBoxISBN.Text) && !string.IsNullOrEmpty(textBoxAñoPublicacion.Text) && !string.IsNullOrEmpty(textBoxCantidadEjemplares.Text))
            {

                new FachadaNucleo().AñadirLibro(textBoxISBN.Text, textBoxTitulo.Text, textBoxAutor.Text, textBoxAñoPublicacion.Text, Convert.ToInt32(textBoxCantidadEjemplares.Text));
                MessageBox.Show("Libro registrado con exito, el Id del libro es: " + new FachadaNucleo().ObtenerUltimoIdLibro());

            }
            else
            {
                MessageBox.Show("Debe completar la informacion");
                textBoxTitulo.Focus();
            }
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void BuscarLibrosAPI_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void buttonBorrarDatos_Click(object sender, EventArgs e)
        {
            textBoxAutor.Clear();
            textBoxAñoPublicacion.Clear();
            textBoxISBN.Clear();
            textBoxTitulo.Clear();
            buttonBorrarDatos.Enabled = false;
        }

        private void labelIngreseISBN_Click(object sender, EventArgs e)
        {

        }

        private void textBoxBuscarPorISBN_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonBuscarPorISBN_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewISBN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dataGridViewISBN.CurrentRow.Cells[0].Value!=null)
                {
                    textBoxISBN.Text = dataGridViewISBN.CurrentRow.Cells[0].Value.ToString(); 
                }
            }
        }

        private void dataGridViewAños_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dataGridViewISBN.CurrentRow.Cells[0].Value != null)
                {
                    textBoxAñoPublicacion.Text = dataGridViewAños.CurrentRow.Cells[0].Value.ToString();
                }
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

        private void buttonGestionarLibros_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionarLibros ventana = new GestionarLibros(NombreUsuario);
            ventana.ShowDialog(this);
        }

        private void labelSeleccionarAño_Click(object sender, EventArgs e)
        {

        }

        public void VerificarVentanaPadre()
        {
            if (this.Owner.Name == "Menu2")
            {
                buttonAñadirLibro.Visible = true;
                buttonActualizar.Visible = false;
            }
            else if (this.Owner.Name == "ActualizarLibro")
            {
                buttonActualizar.Visible = true;
                buttonAñadirLibro.Visible = false;
                buttonGestionarLibros.Visible = false;
                textBoxCantidadEjemplares.Visible = false;
                labelCantidadEjemplares.Visible = false;
            }
        }

        public void InicializarLibro(int idLibro)
        {
            var libro = interfazNucleo.ObtenerLibro(idLibro);
            textBoxAutor.Text = libro.Autor;
            textBoxAñoPublicacion.Text = libro.AñoPublicacion;
            textBoxISBN.Text = libro.ISBN;
            textBoxTitulo.Text = libro.Titulo;
            textBoxBuscar.Text = libro.Titulo;
            button1_Click(this, null);
        }
        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxTitulo.Text) && !string.IsNullOrEmpty(textBoxAutor.Text) && !string.IsNullOrEmpty(textBoxISBN.Text) && !string.IsNullOrEmpty(textBoxAñoPublicacion.Text))
            {

                ((ActualizarLibro)this.Owner).CargarDatosDeBusquedaAvanzada(textBoxTitulo.Text, textBoxAutor.Text, textBoxAñoPublicacion.Text, textBoxISBN.Text);
                MessageBox.Show("Libro registrado con exito, el Id del libro es: " + new FachadaNucleo().ObtenerUltimoIdLibro());
                this.Hide();
                this.Owner.Show();
            }
            else
            {
                MessageBox.Show("Debe completar la informacion");
                textBoxTitulo.Focus();
            }
        }

        private void textBoxCantidadEjemplares_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
