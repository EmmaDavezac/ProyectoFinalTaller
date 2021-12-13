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
        private string NombreUsuario { get; set; }
        private int idUsuario { get; set; }
        InterfazNucleo interfazNucleo = new InterfazNucleo();
        public VerPrestamos(string iD)
        {
            InitializeComponent();
            idUsuario = Convert.ToInt32(iD);
            NombreUsuario = interfazNucleo.ObtenerAdministrador(idUsuario).Nombre;
            labelNombreUsuario.Text = "Usuario: " + NombreUsuario;
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
                else
                {
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

                dataGridViewPrestamos.Rows[n].Cells[8].Value = interfazNucleo.ObtenerUsuarioDePrestamo(item.Id).Id;
                dataGridViewPrestamos.Rows[n].Cells[9].Value = interfazNucleo.ObtenerUsuarioDePrestamo(item.Id).Nombre + "-" + interfazNucleo.ObtenerUsuarioDePrestamo(item.Id).Apellido;
                dataGridViewPrestamos.Rows[n].Cells[10].Value = interfazNucleo.ObtenerUsuarioDePrestamo(item.Id).Mail;
                dataGridViewPrestamos.Rows[n].Cells[11].Value = interfazNucleo.ObtenerUsuarioDePrestamo(item.Id).Telefono;
                dataGridViewPrestamos.Rows[n].Cells[12].Value = interfazNucleo.ObtenerLibroDePrestamo(item.Id).Titulo;
                dataGridViewPrestamos.Rows[n].Cells[13].Value = interfazNucleo.ObtenerLibroDePrestamo(item.Id).Autor;
                dataGridViewPrestamos.Rows[n].Cells[14].Value = interfazNucleo.ObtenerLibroDePrestamo(item.Id).ISBN;
                dataGridViewPrestamos.Rows[n].Cells[15].Value = interfazNucleo.ObtenerEjemplarDePrestamo(item.Id).Id;
                dataGridViewPrestamos.Rows[n].Cells[16].Value = interfazNucleo.ObtenerEjemplarDePrestamo(item.Id).Estado;
                if (interfazNucleo.ObtenerEjemplarDePrestamo(item.Id).Disponible)
                {
                    dataGridViewPrestamos.Rows[n].Cells[17].Value = "Si";
                }
                else dataGridViewPrestamos.Rows[n].Cells[17].Value = "No";


            }
        }
       

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu2 ventanaMenu = new Menu2(idUsuario.ToString());
            ventanaMenu.Show();
        }

        private void dataGridViewPrestamos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VerPrestamos_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Menu2 ventanaMenu = new Menu2(idUsuario.ToString());
            ventanaMenu.Show();
        }

        private void labelNombreUsuario_Click(object sender, EventArgs e)
        {

        }

        private void VerPrestamos_Load(object sender, EventArgs e)
        {

        }
    }
}
