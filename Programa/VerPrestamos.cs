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
    public partial class VerPrestamos : Form
    {
        private string NombreUsuario { get; set; }
        public VerPrestamos(string nombreUsuario)
        {
            InitializeComponent();
            NombreUsuario = nombreUsuario;
            labelNombreUsuario.Text = NombreUsuario;


        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal ventanaMenu = new MenuPrincipal(NombreUsuario);
            ventanaMenu.Show();
        }

        private void dataGridViewPrestamos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
