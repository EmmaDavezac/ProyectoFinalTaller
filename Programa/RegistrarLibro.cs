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
    public partial class RegistrarLibro : Form
    {
        private string NombreUsuario { get; set; }
        private int idUsuario { get; set; }
        InterfazNucleo interfazNucleo = new InterfazNucleo();
        public RegistrarLibro(string iD)
        {
            InitializeComponent();
            idUsuario = Convert.ToInt32(iD);
            NombreUsuario = interfazNucleo.ObtenerAdministrador(idUsuario).Nombre;
            labelNombreUsuario.Text = "Usuario: " + NombreUsuario;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxTitulo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxAutor.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxAñoPublicacion.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxISBN.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void BuscarLibrosAPI_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxBuscar.Text != null && textBoxBuscar.Text != "")
            {
                int resultado = 0;
                dataGridView1.Rows.Clear();
                foreach (var item in new Nucleo.InterfazNucleo().ListarLibrosDeAPIPorCoincidencia(textBoxBuscar.Text))
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
            else {
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
            if (!string.IsNullOrEmpty(textBoxTitulo.Text)&& !string.IsNullOrEmpty(textBoxAutor.Text)&&! string.IsNullOrEmpty(textBoxISBN.Text)&& !string.IsNullOrEmpty(textBoxAñoPublicacion.Text))
            {

                new InterfazNucleo().AñadirLibro(textBoxISBN.Text, textBoxTitulo.Text, textBoxAutor.Text, textBoxAñoPublicacion.Text);
                MessageBox.Show("Libro registrado con exito, el Id del libro es: "+new InterfazNucleo().ObtenerUltimoIdLibro());
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
            Application.Exit();
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
    }
}
