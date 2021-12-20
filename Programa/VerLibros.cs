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
    public partial class VerLibros : Form
    {
        private string NombreUsuario { get; set; }
        private int idUsuario { get; set; }
        InterfazNucleo interfazNucleo = new InterfazNucleo();
        public VerLibros(string iD)
        {
            InitializeComponent();
            idUsuario = Convert.ToInt32(iD);
            NombreUsuario = interfazNucleo.ObtenerAdministradorPorId(idUsuario).Nombre;
            labelNombreUsuario.Text = "Usuario: " + NombreUsuario;
            foreach (var item in interfazNucleo.ObtenerLibros())
            {
                int n = dgvLibros.Rows.Add();
                dgvLibros.Rows[n].Cells[0].Value = item.Id;
                dgvLibros.Rows[n].Cells[1].Value = item.Titulo;
                dgvLibros.Rows[n].Cells[2].Value = item.Autor;
                dgvLibros.Rows[n].Cells[3].Value = item.AñoPublicacion;
                dgvLibros.Rows[n].Cells[4].Value = item.ISBN;


            }
        }



        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu2 ventanaMenu = new Menu2(idUsuario.ToString());
            ventanaMenu.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLibros.CurrentRow.Cells[0].Value != null && dgvLibros.CurrentRow.Cells[1].Value != null && dgvLibros.CurrentRow.Cells[2].Value != null && dgvLibros.CurrentRow.Cells[3].Value != null && dgvLibros.CurrentRow.Cells[4].Value != null)
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
            this.Hide();
            Menu2 ventanaMenu = new Menu2(idUsuario.ToString());
            ventanaMenu.Show();
        }

        private void VerLibros_Load(object sender, EventArgs e)
        {

        }

        private void labelNombreUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
