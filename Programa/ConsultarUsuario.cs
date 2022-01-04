using Dominio;
using Nucleo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Programa
{
    public partial class ConsultarUsuario : Form
    {
        
        private string nombreUsuario { get; set; }
        private InterfazNucleo interfazNucleo = new InterfazNucleo();

        public ConsultarUsuario(string pNombreUsuario)
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
                for (int i = 0; i < dataGridViewUsuarios.Rows.Count - 1; i++)
                {
                    if (dataGridViewUsuarios.Rows[i].Cells[1].Value.ToString().Contains(textBoxNombreUsuario.Text.ToString()) == false)
                    {
                        dataGridViewUsuarios.Rows[i].Visible = false;
                    }
                    else
                    {
                        dataGridViewUsuarios.Rows[i].Visible = true;
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

        private void ConsultarUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Menu2 ventanaMenu = new Menu2(nombreUsuario);
            ventanaMenu.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ConsultarUsuario_Load(object sender, EventArgs e)
        {
            ObtenerUsuarios();
        }

        private void textBoxApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ObtenerUsuarios()
        {
            IEnumerable<UsuarioSimple> usuarios = interfazNucleo.ObtenerUsuarios();
            dataGridViewUsuarios.Rows.Clear();
            foreach (var item in usuarios)
            {
                int n = dataGridViewUsuarios.Rows.Add();
                dataGridViewUsuarios.Rows[n].Cells[1].Value = item.NombreUsuario;
                dataGridViewUsuarios.Rows[n].Cells[2].Value = item.Scoring;
                dataGridViewUsuarios.Rows[n].Cells[2].Style.Font = new Font(dataGridViewUsuarios.Font, FontStyle.Bold);
                if (item.Scoring >= 0)
                {
                    dataGridViewUsuarios.Rows[n].Cells[2].Style.ForeColor = Color.Green;
                }
                else
                {
                    dataGridViewUsuarios.Rows[n].Cells[2].Style.ForeColor = Color.Red;
                }
                dataGridViewUsuarios.Rows[n].Cells[3].Value = item.Nombre;
                dataGridViewUsuarios.Rows[n].Cells[4].Value = item.Apellido;
                dataGridViewUsuarios.Rows[n].Cells[5].Value = item.FechaNacimiento.ToShortDateString();
                dataGridViewUsuarios.Rows[n].Cells[6].Value = item.Mail;
                dataGridViewUsuarios.Rows[n].Cells[7].Value = item.Telefono;
            }
        }

        private void dataGridViewUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewCell cell = (DataGridViewCell)dataGridViewUsuarios.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value.ToString() == "Edit")
                {
                    ActualizarUsuario ventana = new ActualizarUsuario(nombreUsuario);
                    ventana.CargarUsuarioExistente(dataGridViewUsuarios.Rows[e.RowIndex].Cells[1].Value.ToString());
                    this.Hide();
                    ventana.Show();
                }
            }
        }

        private void labelErro_Click(object sender, EventArgs e)
        {

        }

        private void labelNombreUsuario_Click(object sender, EventArgs e)
        {

        }

        private void usuarioSimpleBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
