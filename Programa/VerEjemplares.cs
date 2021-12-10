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
    public partial class VerEjemplares : Form
    {
        private string NombreUsuario { get; set; }
        public VerEjemplares(string nombreUsuario)
        {

            InitializeComponent();
            foreach (var item in new InterfazNucleo().ObtenerEjemplares())
            {
                int n = dgvEjemplares.Rows.Add();
                dgvEjemplares.Rows[n].Cells[0].Value = item.Id;
                dgvEjemplares.Rows[n].Cells[1].Value = item.Estado;
                if (item.Disponible)
                {
                    dgvEjemplares.Rows[n].Cells[2].Value = "Si";
                }
                else dgvEjemplares.Rows[n].Cells[2].Value = "No";
                dgvEjemplares.Rows[n].Cells[3].Value = new InterfazNucleo().ObtenerLibroDeEjemplar(Convert.ToInt32(item.Id)).Id;
                dgvEjemplares.Rows[n].Cells[4].Value = new InterfazNucleo().ObtenerLibroDeEjemplar(Convert.ToInt32(item.Id)).Titulo;
                dgvEjemplares.Rows[n].Cells[5].Value = new InterfazNucleo().ObtenerLibroDeEjemplar(Convert.ToInt32(item.Id)).Autor;
                dgvEjemplares.Rows[n].Cells[6].Value = new InterfazNucleo().ObtenerLibroDeEjemplar(Convert.ToInt32(item.Id)).AñoPublicacion;
                dgvEjemplares.Rows[n].Cells[7].Value = new InterfazNucleo().ObtenerLibroDeEjemplar(Convert.ToInt32(item.Id)).ISBN;


            }
            NombreUsuario = nombreUsuario;
            labelNombreUsuario.Text = "Usuario: " + NombreUsuario;
        }

        private void VerEjemplares_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dgvLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEjemplares.CurrentRow.Cells[0].Value != null && dgvEjemplares.CurrentRow.Cells[1].Value != null && dgvEjemplares.CurrentRow.Cells[2].Value != null && dgvEjemplares.CurrentRow.Cells[3].Value != null && dgvEjemplares.CurrentRow.Cells[4].Value != null)
            {   
                textBoxId.Text = dgvEjemplares.CurrentRow.Cells[0].Value.ToString();
                textBoxEstado.Text = dgvEjemplares.CurrentRow.Cells[1].Value.ToString();
                textBoxDisponibilidad.Text= dgvEjemplares.CurrentRow.Cells[2].Value.ToString();
                textBoxIdLibro.Text= dgvEjemplares.CurrentRow.Cells[3].Value.ToString();
                textBoxTitulo.Text = dgvEjemplares.CurrentRow.Cells[4].Value.ToString();
                textBoxAutor.Text = dgvEjemplares.CurrentRow.Cells[5].Value.ToString();
                textBoxAñoPublicacion.Text = dgvEjemplares.CurrentRow.Cells[6].Value.ToString();
                textBoxISBN.Text = dgvEjemplares.CurrentRow.Cells[7].Value.ToString();
            }
        }

        private void textBoxEstado_TextChanged(object sender, EventArgs e)
        {

        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal ventanaMenu = new MenuPrincipal(NombreUsuario);
            ventanaMenu.Show();
        }

        private void VerEjemplares_Load(object sender, EventArgs e)
        {

        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelNombreUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
