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
    public partial class GestionarLibros : Form
    {
        private string nombre { get; set; }
        private string nombreUsuario { get; set; }
        private InterfazNucleo interfazNucleo = new InterfazNucleo();
        public GestionarLibros(string pNombreUsuario)
        {
            InitializeComponent();
            nombreUsuario = pNombreUsuario;
            nombre = interfazNucleo.ObtenerAdministradorPorNombreOMail(nombreUsuario).Nombre;
            labelNombreUsuario.Text = "Usuario: " + nombreUsuario;
        }

        private void GestionarLibros_Load(object sender, EventArgs e)
        {
            ObtenerLibros();
        }

        private void dataGridViewLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (e.RowIndex >= 0)
            {
                DataGridViewCell cell = (DataGridViewCell)dataGridViewLibros.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value.ToString() == "Edit")
                {
                    ActualizarUsuario ventana = new ActualizarUsuario(nombreUsuario);
                    ventana.CargarUsuarioExistente(dataGridViewLibros.Rows[e.RowIndex].Cells[1].Value.ToString());
                    this.Hide();
                    ventana.Show();
                }
            }*/
        }

        private void textBoxTituloOISBNlibro_TextChanged(object sender, EventArgs e)
        {
            if (textBoxTituloOISBNLibro.Text != null)
            {
                for (int i = 0; i < dataGridViewLibros.Rows.Count - 1; i++)
                {
                    if (textBoxTituloOISBNLibro.Text.All(Char.IsDigit) == true && dataGridViewLibros.Rows[i].Cells[2].Value.ToString().Contains(textBoxTituloOISBNLibro.Text.ToString()) == false)
                    {
                        dataGridViewLibros.Rows[i].Visible = false;
                    }
                    else if (dataGridViewLibros.Rows[i].Cells[3].Value.ToString().ToLower().Contains(textBoxTituloOISBNLibro.Text.ToString().ToLower()) == false)
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

        private void ObtenerLibros()
        {
            IEnumerable<Libro> libros = interfazNucleo.ObtenerLibros();
            dataGridViewLibros.Rows.Clear();
            foreach (var item in libros)
            {
                int n = dataGridViewLibros.Rows.Add();
                dataGridViewLibros.Rows[n].Cells[1].Value = item.Id;
                dataGridViewLibros.Rows[n].Cells[2].Value = item.ISBN;
                dataGridViewLibros.Rows[n].Cells[3].Value = item.Titulo;
                dataGridViewLibros.Rows[n].Cells[4].Value = item.Autor;
                dataGridViewLibros.Rows[n].Cells[5].Value = item.AñoPublicacion;
            }
        }
    }
}
