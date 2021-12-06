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
    public partial class VerUsuarios : Form
    {
        private string NombreUsuario { get; set; }
        public VerUsuarios(string nombreUsuario)
        {
            
            InitializeComponent();
            foreach (var item in new Nucleo.InterfazNucleo().ObtenerUsuarios() )
            {
                int n= dgvUsuarios.Rows.Add();
                dgvUsuarios.Rows[n].Cells[0].Value = item.Id;
                dgvUsuarios.Rows[n].Cells[1].Value = item.Nombre;
                dgvUsuarios.Rows[n].Cells[2].Value = item.Apellido;
                dgvUsuarios.Rows[n].Cells[3].Value = item.FechaNacimiento;
                dgvUsuarios.Rows[n].Cells[4].Value = item.Mail;
                dgvUsuarios.Rows[n].Cells[5].Value = item.Scoring;
            }
            NombreUsuario = nombreUsuario;
            labelNombreUsuario.Text = "Usuario: " + NombreUsuario;
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal ventanaMenu = new MenuPrincipal(NombreUsuario);
            ventanaMenu.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VerUsuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void VerUsuarios_Load(object sender, EventArgs e)
        {

        }
    }
}
