using Nucleo;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Programa
{
    public partial class DevolucionPrestamo : Form
    {
        private int scoringActual;
        private int scoringPorFecha;
        private int scoringDevolucion;
        private InterfazNucleo interfazNucleo = new InterfazNucleo();
        private int idPrestamo;
        private bool modificado;
        public DevolucionPrestamo()
        {
            scoringPorFecha = 0;
            scoringDevolucion = 0;
            modificado = false;
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void DevolucionPrestamo_Load(object sender, EventArgs e)
        {

        }

        public void InicializarDevolucion(string pNombreUsuario, string pTitulo, string pAutor, string pFechaVencimiento, string pEstado, string pScoringActual, int pIdPrestamo)
        {
            labelUsuario.Text = pNombreUsuario;
            labelLibro.Text = pTitulo + " - " + pAutor;
            if (pEstado == "Retrasado")
            {
                TimeSpan difFechas = Convert.ToDateTime(DateTime.Now) - Convert.ToDateTime(pFechaVencimiento);
                int dias = difFechas.Days;
                labelEstado.Text = pEstado;
                labelEstado.ForeColor = Color.Red;
                scoringPorFecha = -2 * dias;
            }
            else if (pEstado == "ProximoAVencer")
            {
                labelEstado.Text = pEstado;
                labelEstado.ForeColor = Color.Green;
                scoringPorFecha = 5;
            }
            else
            {
                labelEstado.Text = pEstado;
                labelEstado.ForeColor = Color.Yellow;
                scoringPorFecha = 5;
            }
            labelFechaVencimiento.Text = pFechaVencimiento;
            if (Convert.ToInt32(pScoringActual) >= 0)
            {
                labelScoring.Text = pScoringActual;
                labelScoring.ForeColor = Color.Yellow;
            }
            else
            {
                labelScoring.Text = pScoringActual;
                labelScoring.ForeColor = Color.Red;
            }
            scoringActual = Convert.ToInt32(pScoringActual);
            dateTimePickerFechaDevolucion.Value = DateTime.Now;
            idPrestamo = pIdPrestamo;
        }

        private void labelFechaVencimiento_Click(object sender, EventArgs e)
        {

        }

        private void labelLibro_Click(object sender, EventArgs e)
        {

        }

        private void labelUsuario_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxEstadoEjemplar_SelectedIndexChanged(object sender, EventArgs e)
        {
            modificado = true;
            if (comboBoxEstadoEjemplar.SelectedIndex == 0)
            {
                scoringDevolucion = scoringActual + scoringPorFecha;
                labelScoringDevolucion.Text = scoringDevolucion + "(" + scoringPorFecha + ")";
                labelScoringDevolucion.Visible = true;
            }
            else if (comboBoxEstadoEjemplar.SelectedIndex == 1)
            {
                scoringDevolucion = scoringActual + scoringPorFecha - 10;
                labelScoringDevolucion.Text = scoringDevolucion + "(" + (scoringPorFecha - 10) + ")";
                labelScoringDevolucion.Visible = true;
            }
        }

        private void botonRegistrarDevolucion_Click(object sender, EventArgs e)
        {
            if (modificado == true)
            {
                interfazNucleo.RegistrarDevolucion(idPrestamo, comboBoxEstadoEjemplar.Text);
                MessageBox.Show("La devolucion se registro correctamente");
                this.Hide();
                this.Owner.Show();
                ((GestionarPrestamos)this.Owner).ObtenerPrestamos();
            }
            else
            {
                MessageBox.Show("No selecciono el estado del ejemplar");
            }
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void DevolucionPrestamo_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
