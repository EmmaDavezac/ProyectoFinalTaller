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
    {   private  InterfazNucleo interfaz=new InterfazNucleo();
        private string NombreUsuario { get; set; }
        public VerAdministradores(string nombreUsuario)
        {
           
            InitializeComponent();
            NombreUsuario = nombreUsuario;
            labelNombreUsuario.Text = "Usuario: " + NombreUsuario;
            foreach (var item in interfaz.ObtenerAdministradores())
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
            MenuPrincipal ventanaMenu = new MenuPrincipal(NombreUsuario);
            ventanaMenu.Show();
        }

        private void VerAdministradores_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dgvAdministradores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelNombreUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
