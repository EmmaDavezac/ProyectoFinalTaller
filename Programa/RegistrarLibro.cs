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
    public partial class RegistrarLibro : Form
    {
        private string NombreUsuario { get; set; }
        private string idUsuario { get; set; }
        InterfazNucleo interfazNucleo = new InterfazNucleo();
        public RegistrarLibro(string iD)
        {
            InitializeComponent();
            idUsuario = iD;
            NombreUsuario = interfazNucleo.ObtenerAdministradorPorNombreOMail(idUsuario).Nombre;
            labelNombreUsuario.Text = "Usuario: " + NombreUsuario;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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

        private void BuscarLibrosAPI_Load(object sender, EventArgs e)
        {
            
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            buttonBuscar.Enabled = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxTitulo.Text) && !string.IsNullOrEmpty(textBoxAutor.Text) && !string.IsNullOrEmpty(textBoxISBN.Text) && !string.IsNullOrEmpty(textBoxAñoPublicacion.Text))
            {

                new InterfazNucleo().AñadirLibro(textBoxISBN.Text, textBoxTitulo.Text, textBoxAutor.Text, textBoxAñoPublicacion.Text);
                MessageBox.Show("Libro registrado con exito, el Id del libro es: " + new InterfazNucleo().ObtenerUltimoIdLibro());
                this.Hide();
                Menu2 ventanaMenu = new Menu2(idUsuario.ToString());
                ventanaMenu.Show();

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
            Menu2 ventanaMenu = new Menu2(idUsuario.ToString());
            ventanaMenu.Show();
        }

        private void BuscarLibrosAPI_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Menu2 ventanaMenu = new Menu2(idUsuario.ToString());
            ventanaMenu.Show();
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
            textBoxISBN.Text = dataGridViewISBN.CurrentRow.Cells[0].Value.ToString();
        }

        private void dataGridViewAños_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxAñoPublicacion.Text = dataGridViewAños.CurrentRow.Cells[0].Value.ToString();
        }

        private void textBoxSeleccionarISBN_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSeleccionarISBN.Text != null)
            {
                foreach (DataGridViewRow row in dataGridViewISBN.Rows)
                {
                    if (row.Cells[0].Value.ToString().Contains(textBoxSeleccionarISBN.Text.ToString()) == false)
                    {
                        row.Visible = false;
                    }
                    else
                    {
                        row.Visible = true;
                    }
                }
            }
        }
    }
}
