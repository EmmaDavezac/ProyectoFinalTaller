using Dominio;
using Nucleo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Programa
{
    public partial class GestionarAdministradores : Form
    {
        private string nombreUsuario { get; set; }
        private FachadaNucleo interfazNucleo = new FachadaNucleo();

        public GestionarAdministradores(string pNombreUsuario)
        {
            InitializeComponent();
            nombreUsuario = pNombreUsuario;
            labelNombreUsuario.Text = "Usuario: " + nombreUsuario;
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
            this.Owner.Show();
        }

        private void ConsultarAdministrador_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            this.Owner.Show();
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

        private void dataGridViewAdministradores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewCell cell = (DataGridViewCell)dataGridViewAdministradores.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value.ToString() == "Edit")
                {
                    ActualizarAdministrador ventana = new ActualizarAdministrador(nombreUsuario);
                    ventana.CargarAdministradorExistente(dataGridViewAdministradores.Rows[e.RowIndex].Cells[1].Value.ToString(), dataGridViewAdministradores.Rows[e.RowIndex].Cells[7].Value.ToString());
                    this.Hide();
                    ventana.Show(this);
                }
            }
        }

        public void ObtenerAdministradores()
        {
            IEnumerable<UsuarioAdministrador> administradores = interfazNucleo.ObtenerAdministradores();
            dataGridViewAdministradores.Rows.Clear();
            foreach (var item in administradores)
            {
                int n = dataGridViewAdministradores.Rows.Add();
                dataGridViewAdministradores.Rows[n].Cells[1].Value = item.NombreUsuario;
                dataGridViewAdministradores.Rows[n].Cells[2].Value = item.Nombre;
                dataGridViewAdministradores.Rows[n].Cells[3].Value = item.Apellido;
                dataGridViewAdministradores.Rows[n].Cells[4].Value = item.FechaNacimiento.ToShortDateString();
                dataGridViewAdministradores.Rows[n].Cells[5].Value = item.Mail;
                dataGridViewAdministradores.Rows[n].Cells[6].Value = item.Telefono;
                dataGridViewAdministradores.Rows[n].Cells[7].Value = item.Baja.ToString();
                if (item.Baja == true)
                {
                    dataGridViewAdministradores.Rows[n].DefaultCellStyle.BackColor = Color.Red;
                    dataGridViewAdministradores.Rows[n].DefaultCellStyle.ForeColor = Color.White;
                }
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

