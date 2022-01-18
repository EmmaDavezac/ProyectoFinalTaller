using Nucleo;
using System;
using System.Windows.Forms;

namespace Programa
{
    public partial class EditarPrestamo : Form
    {
        private int idPrestamo;
        private FachadaNucleo interfazNucleo = new FachadaNucleo();
        public EditarPrestamo()
        {
            idPrestamo = 0;
            InitializeComponent();
        }

        private void EditarPrestamo_Load(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }
        public void InicialiarEditarPrestamo(int pIdPrestamo, string pFechaPrestamo, string pFechaLimite)
        {
            textBoxFechaPrestamo.Text = pFechaPrestamo;
            textBoxFechaLimite.Text = pFechaLimite;
            idPrestamo = pIdPrestamo;
        }

        private void buttonModificarFechas_Click(object sender, EventArgs e)
        {
            interfazNucleo.ModificarFechasPrestamo(idPrestamo, textBoxFechaPrestamo.Text, textBoxFechaLimite.Text);
            ((GestionarPrestamos)this.Owner).ObtenerPrestamos();
            this.Close();
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
