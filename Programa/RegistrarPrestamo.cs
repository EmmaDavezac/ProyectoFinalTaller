using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa
{
    public partial class RegistrarPrestamo : Form
    {
        public RegistrarPrestamo()
        {
            InitializeComponent();
        }

        private void RegistrarPrestamo_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTituloOISBNLibro_TextChanged(object sender, EventArgs e)
        {
            if (textBoxTituloOISBNLibro.Text != null)
            {
                for (int i = 0; i < dataGridViewUsuarios.Rows.Count - 1; i++)
                {
                    if (dataGridViewLibros.Rows[i].Cells[1].Value.ToString().Contains(textBoxTituloOISBNLibro.Text.ToString()) == false)
                    {
                        dataGridViewLibros.Rows[i].Visible = false;
                    }
                    else
                    {
                        dataGridViewLibros.Rows[i].Visible = true;
                    }
                }
            }
        }

        private void labelTitulo_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
