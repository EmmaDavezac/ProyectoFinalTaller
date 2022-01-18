using Dominio;
using Nucleo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Programa
{
    public partial class GestionarPrestamos : Form
    {
        private string nombreUsuario { get; set; }
        private FachadaNucleo interfazNucleo = new FachadaNucleo();
        public GestionarPrestamos(string pNombreUsuario)
        {
            InitializeComponent();
            nombreUsuario = pNombreUsuario;
            labelNombreUsuario.Text = "Usuario: " + nombreUsuario;
        }

        private void GestionarPrestamos_Load(object sender, EventArgs e)
        {
            ObtenerPrestamos();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GestionarPrestamos_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        public void ObtenerPrestamos()
        {
            IEnumerable<Prestamo> prestamos = interfazNucleo.ObtenerPrestamos();
            dataGridViewPrestamos.Rows.Clear();
            foreach (var item in prestamos)
            {
                if (item.FechaDevolucion == null)
                {
                    int n = dataGridViewPrestamos.Rows.Add();
                    dataGridViewPrestamos.Rows[n].Cells[1].Value = item.Id;
                    dataGridViewPrestamos.Rows[n].Cells[2].Value = item.nombreUsuario;
                    dataGridViewPrestamos.Rows[n].Cells[3].Value = interfazNucleo.ObtenerLibro(item.idLibro).Titulo;
                    dataGridViewPrestamos.Rows[n].Cells[4].Value = interfazNucleo.ObtenerLibro(item.idLibro).ISBN;
                    dataGridViewPrestamos.Rows[n].Cells[5].Value = item.FechaPrestamo;
                    dataGridViewPrestamos.Rows[n].Cells[6].Value = item.FechaLimite;
                    dataGridViewPrestamos.Rows[n].Cells[7].Value = item.ActualizarEstado().ToString();
                    if (dataGridViewPrestamos.Rows[n].Cells[7].Value.ToString() == "Retrasado")
                    {
                        dataGridViewPrestamos.Rows[n].DefaultCellStyle.BackColor = Color.Red;
                        dataGridViewPrestamos.Rows[n].DefaultCellStyle.ForeColor = Color.White;
                    }
                    else if (dataGridViewPrestamos.Rows[n].Cells[7].Value.ToString() == "ProximoAVencer")
                    {
                        dataGridViewPrestamos.Rows[n].DefaultCellStyle.BackColor = Color.Green;
                    }
                }
            }
        }

        private void dataGridViewPrestamos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewCell cell = (DataGridViewCell)dataGridViewPrestamos.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value.ToString() == "Devolucion")
                {
                    Prestamo prestamo = interfazNucleo.ObtenerPrestamo(Convert.ToInt32(dataGridViewPrestamos.Rows[e.RowIndex].Cells[1].Value.ToString()));
                    Libro libro = interfazNucleo.ObtenerLibro(prestamo.idLibro);
                    string usuario = dataGridViewPrestamos.Rows[e.RowIndex].Cells[2].Value.ToString();
                    UsuarioSimple usuarioSimple = interfazNucleo.ObtenerUsuario(usuario);
                    string titulo = libro.Titulo;
                    string autor = libro.Autor;
                    string fechaVencimiento = dataGridViewPrestamos.Rows[e.RowIndex].Cells[6].Value.ToString();
                    string estado = dataGridViewPrestamos.Rows[e.RowIndex].Cells[7].Value.ToString();
                    string scoring = Convert.ToString(usuarioSimple.Scoring);
                   
                    int idPrestamo = Convert.ToInt32(dataGridViewPrestamos.Rows[e.RowIndex].Cells[1].Value.ToString());
                    DevolucionPrestamo ventana = new DevolucionPrestamo();
                    ventana.InicializarDevolucion(usuario, titulo, autor, fechaVencimiento, estado, scoring, idPrestamo);
                    ventana.ShowDialog(this);
                }
                else if (cell.Value.ToString() == "Edit")
                {
                    int idPrestamo = Convert.ToInt32(dataGridViewPrestamos.CurrentRow.Cells[1].Value.ToString());
                    string fechaPrestamo = dataGridViewPrestamos.CurrentRow.Cells[5].Value.ToString();
                    string fechaLimite = dataGridViewPrestamos.CurrentRow.Cells[6].Value.ToString();
                    EditarPrestamo ventana = new EditarPrestamo();
                    ventana.InicialiarEditarPrestamo(idPrestamo, fechaPrestamo, fechaLimite);
                    ventana.ShowDialog(this);
                }
            }
        }

        private void checkBoxProximosAVencerse_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxProximosAVencerse.Checked == true)
            {
                for (int i = 0; i < dataGridViewPrestamos.Rows.Count - 1; i++)
                {
                    if (dataGridViewPrestamos.Rows[i].Cells[7].Value.ToString() == "ProximoAVencer")
                    {
                        dataGridViewPrestamos.Rows[i].Visible = true;
                    }
                    else
                    {
                        dataGridViewPrestamos.Rows[i].Visible = false;
                    }
                }
            }
            else
            {
                for (int i = 0; i < dataGridViewPrestamos.Rows.Count - 1; i++)
                {
                    dataGridViewPrestamos.Rows[i].Visible = true;
                }
            }
        }

        private void checkBoxRestrasados_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRestrasados.Checked == true)
            {
                for (int i = 0; i < dataGridViewPrestamos.Rows.Count - 1; i++)
                {
                    if (dataGridViewPrestamos.Rows[i].Cells[7].Value.ToString() == "Retrasado")
                    {
                        dataGridViewPrestamos.Rows[i].Visible = true;
                    }
                    else
                    {
                        dataGridViewPrestamos.Rows[i].Visible = false;
                    }
                }
            }
            else
            {
                for (int i = 0; i < dataGridViewPrestamos.Rows.Count - 1; i++)
                {
                    dataGridViewPrestamos.Rows[i].Visible = true;
                }
            }
        }

        private void textBoxUsuarioOTituloLibro_TextChanged(object sender, EventArgs e)
        {
            if (textBoxUsuarioOTituloLibro.Text != null)
            {
                for (int i = 0; i < dataGridViewPrestamos.Rows.Count - 1; i++)
                {
                    if (dataGridViewPrestamos.Text.All(Char.IsDigit) && dataGridViewPrestamos.Rows[i].Cells[2].Value.ToString().ToLower().Contains(textBoxUsuarioOTituloLibro.Text.ToString().ToLower()))
                    {
                        dataGridViewPrestamos.Rows[i].Visible = true;
                    }
                    else if (dataGridViewPrestamos.Rows[i].Cells[3].Value.ToString().ToLower().Contains(textBoxUsuarioOTituloLibro.Text.ToString().ToLower()) == false)
                    {
                        dataGridViewPrestamos.Rows[i].Visible = false;
                    }
                    else
                    {
                        dataGridViewPrestamos.Rows[i].Visible = true;
                    }
                }
            }
        }
    }
}
