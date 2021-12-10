using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa
{
    public partial class VerLibros : Form
    {
        private string NombreUsuario { get; set; }
        public VerLibros(string nombreUsuario)
        {

            InitializeComponent();
            foreach (var item in new Nucleo.InterfazNucleo().ObtenerLibros())
            {
                int n = dgvLibros.Rows.Add();
                dgvLibros.Rows[n].Cells[0].Value = item.Id;
                dgvLibros.Rows[n].Cells[1].Value = item.Titulo;
                dgvLibros.Rows[n].Cells[2].Value = item.Autor;
                dgvLibros.Rows[n].Cells[3].Value = item.AñoPublicacion;
                dgvLibros.Rows[n].Cells[4].Value = item.ISBN;
               
            }
            NombreUsuario = nombreUsuario;
            labelNombreUsuario.Text = "Usuario: " + NombreUsuario;
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal ventanaMenu = new MenuPrincipal(NombreUsuario);
            ventanaMenu.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLibros.CurrentRow.Cells[0].Value!=null&& dgvLibros.CurrentRow.Cells[1].Value != null&& dgvLibros.CurrentRow.Cells[2].Value !=null&& dgvLibros.CurrentRow.Cells[3].Value != null&& dgvLibros.CurrentRow.Cells[4].Value != null)
            {
                textBoxId.Text = dgvLibros.CurrentRow.Cells[0].Value.ToString();
                textBoxTitulo.Text = dgvLibros.CurrentRow.Cells[1].Value.ToString();
                textBoxAutor.Text = dgvLibros.CurrentRow.Cells[2].Value.ToString();
                textBoxAñoPublicacion.Text = dgvLibros.CurrentRow.Cells[3].Value.ToString();
                textBoxISBN.Text = dgvLibros.CurrentRow.Cells[4].Value.ToString(); 
            }
        }

        private void VerLibros_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void VerLibros_Load(object sender, EventArgs e)
        {

        }

        private void labelNombreUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
