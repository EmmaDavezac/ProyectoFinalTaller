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
    public partial class VerAdministradores : Form
    {
        private string NombreUsuario { get; set; }
        private int idUsuario { get; set; }
        InterfazNucleo interfazNucleo = new InterfazNucleo();
        public VerAdministradores(string iD)
        {
            InitializeComponent();
            idUsuario = Convert.ToInt32(iD);
            NombreUsuario = interfazNucleo.ObtenerAdministrador(idUsuario).Nombre;
            labelNombreUsuario.Text = "Usuario: " + NombreUsuario;
            foreach (var item in interfazNucleo.ObtenerAdministradores())
            {
                int n = dgvAdministradores.Rows.Add();
                dgvAdministradores.Rows[n].Cells[0].Value = item.Id;
                dgvAdministradores.Rows[n].Cells[1].Value = item.Nombre;
                dgvAdministradores.Rows[n].Cells[2].Value = item.Apellido;
                dgvAdministradores.Rows[n].Cells[3].Value = item.FechaNacimiento;
                dgvAdministradores.Rows[n].Cells[4].Value = item.Mail;
                dgvAdministradores.Rows[n].Cells[5].Value = item.Telefono;
            }
        }
        

        private void VerAdministradores_Load(object sender, EventArgs e)
        {

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu2 ventanaMenu = new Menu2(idUsuario.ToString());
            ventanaMenu.Show();
        }

        private void VerAdministradores_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Menu2 ventanaMenu = new Menu2(idUsuario.ToString());
            ventanaMenu.Show();
        }

        private void dgvAdministradores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelNombreUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
