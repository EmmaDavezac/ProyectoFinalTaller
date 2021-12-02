using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiciosAPILibros;

namespace Programa
{
    public partial class BuscarLibrosAPI : Form
    {
        private string NombreUsuario { get; set; }
        public BuscarLibrosAPI(string nombreUsuario)
        {
            InitializeComponent();
            NombreUsuario = nombreUsuario;
            labelNombreUsuario.Text = NombreUsuario;
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void BuscarLibrosAPI_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxBusqueda.Text != null && textBoxBusqueda.Text != "")
            {
                int resultado = 0;
                dataGridView1.Rows.Clear();
                foreach (var item in new APILibros().ListaPorCoincidecia(textBoxBusqueda.Text))
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = item.Titulo;
                    dataGridView1.Rows[n].Cells[1].Value = item.Autor;
                    dataGridView1.Rows[n].Cells[2].Value = item.AñoPrimeraPublicacion;
                    resultado += 1;
                }

                if(resultado==0)labelResultados.Text = "No se encontraron resultados"; else labelResultados.Text = "";
                button1.Enabled = false;
            }
            else {
                labelResultados.Text = "No ingreso un termino de busqueda";
                button1.Enabled = false;
                textBoxBusqueda.Focus();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void label4_Click(object sender, EventArgs e)
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

        private void BuscarLibrosAPI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
