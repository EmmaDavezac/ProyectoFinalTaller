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
        private string nombre { get; set; }
        private string nombreUsuario { get; set; }
        private InterfazNucleo interfazNucleo = new InterfazNucleo();

        public ConsultarAdministrador(string pNombreUsuario)
        {
            InitializeComponent();
            nombreUsuario = pNombreUsuario;
            nombre = interfazNucleo.ObtenerAdministradorPorNombreOMail(nombreUsuario).Nombre;
            labelNombreUsuario.Text = "Usuario: " + nombreUsuario;
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
                   
                    dataGridViewAdministradores.Rows.Clear();
                    dataGridViewAdministradores.Rows.Add();
                    dataGridViewAdministradores.Rows[0].Cells[1].Value = usuarioSimple.NombreUsuario;
                    dataGridViewAdministradores.Rows[0].Cells[2].Value = usuarioSimple.Nombre;
                    dataGridViewAdministradores.Rows[0].Cells[3].Value = usuarioSimple.Apellido;
                    dataGridViewAdministradores.Rows[0].Cells[4].Value = usuarioSimple.FechaNacimiento.ToShortDateString();
                    dataGridViewAdministradores.Rows[0].Cells[5].Value = usuarioSimple.Mail;
                    dataGridViewAdministradores.Rows[0].Cells[6].Value = usuarioSimple.Telefono;
                }
                else
                {
                    labelErro.Text = "Error, el administrador ingresado no existe, ingrese otro nombre de usuario";
                   
                    textBoxNombreUsuario.Focus();
                }
            }
            else
            {
               
                textBoxNombreUsuario.Focus();
            }


        }
        private void textBoxId_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNombreUsuario.Text != null)
            {
                for (int i = 0; i < dataGridViewAdministradores.Rows.Count - 1; i++)
                {
                    if (dataGridViewAdministradores.Rows[i].Cells[1].Value.ToString().Contains(textBoxNombreUsuario.Text.ToString()) == false)
                    {
                        dataGridViewAdministradores.Rows[i].Visible = false;
                    }
                    else
                    {
                        dataGridViewAdministradores.Rows[i].Visible = true;
                    }
                }
            }
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu2 ventana = new Menu2(nombreUsuario.ToString());
            ventana.Show();
        }

        private void ConsultarAdministrador_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Menu2 ventanaMenu = new Menu2(nombreUsuario);
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
            if (e.RowIndex >= 0)
            {
                DataGridViewCell cell = (DataGridViewCell)dataGridViewAdministradores.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value.ToString() == "Edit")
                {
                    ActualizarAdministrador ventana = new ActualizarAdministrador(nombreUsuario);
                    ventana.CargarUsuarioExistente(dataGridViewAdministradores.Rows[e.RowIndex].Cells[1].Value.ToString());
                    this.Hide();
                    ventana.Show();
                } 
            }
        }

        private void ObtenerAdministradores()
        {
            IEnumerable<UsuarioAdministrador> usuarios = interfazNucleo.ObtenerAdministradores();
            dataGridViewAdministradores.Rows.Clear();
            foreach (var item in usuarios)
            {
                int n = dataGridViewAdministradores.Rows.Add();
                dataGridViewAdministradores.Rows[n].Cells[1].Value = item.NombreUsuario;
                dataGridViewAdministradores.Rows[n].Cells[2].Value = item.Nombre;
                dataGridViewAdministradores.Rows[n].Cells[3].Value = item.Apellido;
                dataGridViewAdministradores.Rows[n].Cells[4].Value = item.FechaNacimiento.ToShortDateString();
                dataGridViewAdministradores.Rows[n].Cells[5].Value = item.Mail;
                dataGridViewAdministradores.Rows[n].Cells[6].Value = item.Telefono;
            }
        }

        private void buttonRefrescar_Click(object sender, EventArgs e)
        {
            ObtenerAdministradores();
        }

        private void labelErro_Click(object sender, EventArgs e)
        {

        }
    }
}

