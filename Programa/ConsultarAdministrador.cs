using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Nucleo;

namespace Programa
{
    public partial class ConsultarAdministrador : Form
    {
        private string pNombreUsuario { get; set; }
        private string idUsuario { get; set; }
        private InterfazNucleo interfazNucleo = new InterfazNucleo();

        public ConsultarAdministrador(string iD)
        {
            InitializeComponent();
            idUsuario = iD;
            pNombreUsuario = interfazNucleo.ObtenerAdministradorPorNombreOMail(idUsuario).Nombre;
            labelNombreUsuario.Text = "Usuario: " + pNombreUsuario;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonBuscarUsuario_Click(object sender, EventArgs e)
        {
            if (textBoxNombreUsuario.Text != null && textBoxNombreUsuario.Text != "")
            {
                UsuarioAdministrador usuarioSimple = interfazNucleo.ObtenerAdministradorPorNombreOMail(textBoxNombreUsuario.Text);
                if (usuarioSimple != null)
                {
                    buttonBuscarAdministrador.Enabled = false; textBoxNombreUsuario.Focus();
                    dataGridView1.Rows.Clear();
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[0].Cells[1].Value = usuarioSimple.NombreUsuario;
                    dataGridView1.Rows[0].Cells[2].Value = usuarioSimple.Nombre;
                    dataGridView1.Rows[0].Cells[3].Value = usuarioSimple.Apellido;
                    dataGridView1.Rows[0].Cells[4].Value = usuarioSimple.FechaNacimiento.ToShortDateString();
                    dataGridView1.Rows[0].Cells[5].Value = usuarioSimple.Mail;
                    dataGridView1.Rows[0].Cells[6].Value = usuarioSimple.Telefono;
                }
                else
                {
                    buttonBuscarAdministrador.Enabled = false;
                    textBoxNombreUsuario.Focus();
                }
            }
            else
            {
                buttonBuscarAdministrador.Enabled = false;
                textBoxNombreUsuario.Focus();
            }


        }
        private void textBoxId_TextChanged(object sender, EventArgs e)
        {
            buttonBuscarAdministrador.Enabled = true;
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu2 ventana = new Menu2(idUsuario.ToString());
            ventana.Show();
        }

        private void ConsultarAdministrador_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Menu2 ventanaMenu = new Menu2(idUsuario.ToString());
            ventanaMenu.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ConsultarAdministrador_Load(object sender, EventArgs e)
        {
            ObtenerAdministradores();
        }

        private void textBoxApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = (DataGridViewCell)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell.Value.ToString() == "Edit")
            {
                ActualizarAdministrador ventana = new ActualizarAdministrador(idUsuario);
                ventana.CargarUsuarioExistente(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                this.Hide();
                ventana.Show();
            }
        }

        private void ObtenerAdministradores()
        {
            IEnumerable<UsuarioAdministrador> usuarios = interfazNucleo.ObtenerAdministradores();
            dataGridView1.Rows.Clear();
            foreach (var item in usuarios)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[1].Value = item.NombreUsuario;
                dataGridView1.Rows[n].Cells[2].Value = item.Nombre;
                dataGridView1.Rows[n].Cells[3].Value = item.Apellido;
                dataGridView1.Rows[n].Cells[4].Value = item.FechaNacimiento.ToShortDateString();
                dataGridView1.Rows[n].Cells[5].Value = item.Mail;
                dataGridView1.Rows[n].Cells[6].Value = item.Telefono;
            }
        }

        private void buttonRefrescar_Click(object sender, EventArgs e)
        {
            ObtenerAdministradores();
        }
    }
}

