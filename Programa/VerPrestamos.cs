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
    public partial class VerPrestamos : Form
    {
        private  InterfazNucleo interfazNucleo = new InterfazNucleo();
        private string NombreUsuario { get; set; }
        public VerPrestamos(string nombreUsuario)
        {
            InitializeComponent();
            NombreUsuario = nombreUsuario;
            labelNombreUsuario.Text = NombreUsuario;
            foreach (var item in interfazNucleo.ObtenerPrestamos())
            {
                int n = dataGridViewPrestamos.Rows.Add();
                dataGridViewPrestamos.Rows[n].Cells[0].Value = item.Id;
                dataGridViewPrestamos.Rows[n].Cells[1].Value = item.FechaPrestamo;
                dataGridViewPrestamos.Rows[n].Cells[2].Value = item.FechaLimite;
                if (string.IsNullOrEmpty(item.FechaDevolucion))
                {
                    dataGridViewPrestamos.Rows[n].Cells[3].Value = "No devuelto";
                    dataGridViewPrestamos.Rows[n].Cells[5].Value = "No devuelto";
                }
                else {
                    dataGridViewPrestamos.Rows[n].Cells[3].Value = item.FechaDevolucion;
                    dataGridViewPrestamos.Rows[n].Cells[5].Value = item.EstadoDevolucion;
                }
                dataGridViewPrestamos.Rows[n].Cells[4].Value = item.EstadoInicial;
                if (item.ProximoAVencerse())
                {
                    dataGridViewPrestamos.Rows[n].Cells[6].Value = "Si";
                }
                else dataGridViewPrestamos.Rows[n].Cells[6].Value = "No";
                if (item.Retrasado())
                {
                    dataGridViewPrestamos.Rows[n].Cells[7].Value = "Si";
                }
                else dataGridViewPrestamos.Rows[n].Cells[7].Value = "No";

                dataGridViewPrestamos.Rows[n].Cells[8].Value = interfazNucleo.ObtenerUsarioDePrestamo(item.Id).Id;
                dataGridViewPrestamos.Rows[n].Cells[9].Value = interfazNucleo.ObtenerUsarioDePrestamo(item.Id).Nombre+"-"+ interfazNucleo.ObtenerUsarioDePrestamo(item.Id).Apellido;
                dataGridViewPrestamos.Rows[n].Cells[10].Value = interfazNucleo.ObtenerUsarioDePrestamo(item.Id).Mail;
                dataGridViewPrestamos.Rows[n].Cells[11].Value = interfazNucleo.ObtenerUsarioDePrestamo(item.Id).Telefono;
                dataGridViewPrestamos.Rows[n].Cells[12].Value = interfazNucleo.ObtenerLibroDePrestamo(item.Id).Titulo;
                dataGridViewPrestamos.Rows[n].Cells[13].Value = interfazNucleo.ObtenerLibroDePrestamo(item.Id).Autor;
                dataGridViewPrestamos.Rows[n].Cells[14].Value = interfazNucleo.ObtenerLibroDePrestamo(item.Id).ISBN;
                dataGridViewPrestamos.Rows[n].Cells[15].Value = interfazNucleo.ObtenerEjemplarDePrestamo(item.Id).Id;
                dataGridViewPrestamos.Rows[n].Cells[16].Value = interfazNucleo.ObtenerEjemplarDePrestamo(item.Id).Estado;
                if (interfazNucleo.ObtenerEjemplarDePrestamo(item.Id).Disponible)
                {
                    dataGridViewPrestamos.Rows[n].Cells[17].Value = "Si";
                } else dataGridViewPrestamos.Rows[n].Cells[17].Value = "No";


            }



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

        private void VerPrestamos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void labelNombreUsuario_Click(object sender, EventArgs e)
        {

        }

        private void VerPrestamos_Load(object sender, EventArgs e)
        {

        }
    }
}
