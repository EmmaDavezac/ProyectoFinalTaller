using Dominio;
using Nucleo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Programa
{
    public partial class RegistrarPrestamo : Form
    {
        private string nombre { get; set; }
        private string nombreUsuario { get; set; }
        private InterfazNucleo interfazNucleo = new InterfazNucleo();
        public RegistrarPrestamo(string pNombreUsuario)
        {
            InitializeComponent();
            nombreUsuario = pNombreUsuario;
            nombre = interfazNucleo.ObtenerAdministrador(nombreUsuario).Nombre;
            labelNombreUsuario.Text = "Usuario: " + nombreUsuario;
            ObtenerLibros();
            ObtenerUsuarios();
        }

        private void RegistrarPrestamo_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTituloOISBNLibro_TextChanged(object sender, EventArgs e)
        {
            if (textBoxTituloOISBNLibro.Text != null)
            {
                for (int i = 0; i < dataGridViewUsuarios.Rows.Count - 1; i++)
                {
                    if (dataGridViewLibros.Rows[i].Cells[1].Value.ToString().Contains(textBoxTituloOISBNLibro.Text.ToString()) == false)
                    {
                        dataGridViewLibros.Rows[i].Visible = false;
                    }
                    else
                    {
                        dataGridViewLibros.Rows[i].Visible = true;
                    }
                }
            }
        }

        private void labelTitulo_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNombreUsuario.Text != null)
            {
                for (int i = 0; i < dataGridViewUsuarios.Rows.Count - 1; i++)
                {
                    if (dataGridViewUsuarios.Rows[i].Cells[1].Value.ToString().Contains(textBoxNombreUsuario.Text.ToString()) == false)
                    {
                        dataGridViewUsuarios.Rows[i].Visible = false;
                    }
                    else
                    {
                        dataGridViewUsuarios.Rows[i].Visible = true;
                    }
                }
            }
        }

        private void dataGridViewLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dataGridViewLibros.CurrentRow.Cells[5].Value != null)
                {
                    if (dataGridViewLibros.CurrentRow.Cells[5].Value.ToString() != "0")
                    {
                        textBoxIdLibro.Text = dataGridViewLibros.CurrentRow.Cells[0].Value.ToString();
                        textBoxTitulo.Text = dataGridViewLibros.CurrentRow.Cells[1].Value.ToString();
                        textBoxISBN.Text = dataGridViewLibros.CurrentRow.Cells[2].Value.ToString();
                        textBoxAutor.Text = dataGridViewLibros.CurrentRow.Cells[3].Value.ToString();
                    }
                }
            }
        }

        private void ObtenerLibros()
        {
            IEnumerable<Libro> libros = interfazNucleo.ObtenerLibros();
            dataGridViewLibros.Rows.Clear();
            foreach (var item in libros)
            {
                if (item.Baja == false)
                {
                    int n = dataGridViewLibros.Rows.Add();
                    dataGridViewLibros.Rows[n].Cells[0].Value = item.Id;
                    dataGridViewLibros.Rows[n].Cells[1].Value = item.ISBN;
                    dataGridViewLibros.Rows[n].Cells[2].Value = item.Titulo;
                    dataGridViewLibros.Rows[n].Cells[3].Value = item.Autor;
                    dataGridViewLibros.Rows[n].Cells[4].Value = item.AñoPublicacion;
                    dataGridViewLibros.Rows[n].Cells[5].Value = interfazNucleo.ObtenerEjemplaresDisponibles(item.Id).Count().ToString();
                    dataGridViewLibros.Rows[n].Cells[6].Value = interfazNucleo.ObtenerEjemplaresTotales(item.Id).Count().ToString();
                    if (dataGridViewLibros.Rows[n].Cells[5].Value.ToString() == "0")
                    {
                        dataGridViewLibros.Rows[n].DefaultCellStyle.BackColor = Color.Yellow;
                    }
                }

            }
        }

        private void ObtenerUsuarios()
        {
            IEnumerable<UsuarioSimple> usuarios = interfazNucleo.ObtenerUsuarios();
            dataGridViewUsuarios.Rows.Clear();
            foreach (var item in usuarios)
            {
                int n = dataGridViewUsuarios.Rows.Add();
                dataGridViewUsuarios.Rows[n].Cells[0].Value = item.NombreUsuario;
                dataGridViewUsuarios.Rows[n].Cells[1].Value = item.Nombre;
                dataGridViewUsuarios.Rows[n].Cells[2].Value = item.Apellido;
                dataGridViewUsuarios.Rows[n].Cells[3].Value = item.FechaNacimiento.ToShortDateString();
                dataGridViewUsuarios.Rows[n].Cells[4].Value = item.Mail;
                dataGridViewUsuarios.Rows[n].Cells[5].Value = item.Telefono;
            }
        }

        private void dataGridViewUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewUsuarios.CurrentRow.Cells[0].Value != null)
            {
                textBoxNomUsuario.Text = dataGridViewUsuarios.CurrentRow.Cells[0].Value.ToString();
                textBoxNombre.Text = dataGridViewUsuarios.CurrentRow.Cells[1].Value.ToString();
                textBoxApellido.Text = dataGridViewUsuarios.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void textBoxNomUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonRegistrarPrestamo_Click(object sender, EventArgs e)
        {
            int idEjemplar = interfazNucleo.ObtenerEjemplaresDisponibles(Convert.ToInt32(textBoxIdLibro.Text.ToString())).First().Id;
            interfazNucleo.RegistrarPrestamo(textBoxNomUsuario.Text, idEjemplar, Convert.ToInt32(textBoxIdLibro.Text));
            string FechaLimite = Convert.ToDateTime(new InterfazNucleo().ObtenerPrestamo(interfazNucleo.ObtenerUltimoIdPrestamo()).FechaLimite).Date.ToShortDateString();
            MessageBox.Show("El prestamo ha sido registrado correctamente" + "\nFecha limite: " + FechaLimite);
            RegistrarPrestamo_Load(sender, e);
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void RegistrarPrestamo_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }
    }
}
