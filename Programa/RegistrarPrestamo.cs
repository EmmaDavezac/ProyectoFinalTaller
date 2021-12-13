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
    public partial class RegistrarPrestamo : Form
    {
        private string NombreUsuario { get; set; }
        private int idUsuario { get; set; }
        InterfazNucleo interfazNucleo = new InterfazNucleo();
        public RegistrarPrestamo(string iD)
        {
            InitializeComponent();
            idUsuario = Convert.ToInt32(iD);
            NombreUsuario = interfazNucleo.ObtenerAdministrador(idUsuario).Nombre;
            labelNombreUsuario.Text = "Usuario: " + NombreUsuario;
        }

        private void RegistrarPrestamo_Load(object sender, EventArgs e)
        {

        }

        private void labelNombreUsuario_Click(object sender, EventArgs e)
        {

        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu2 ventanaMenu = new Menu2(idUsuario.ToString());
            ventanaMenu.Show();
        }

        private void buttonBuscarUsuario_Click(object sender, EventArgs e)
        {
            {
                if (textBoxIdUsuario.Text != null && (textBoxIdUsuario.Text).All(char.IsDigit) && textBoxIdUsuario.Text != "")
                {
                    UsuarioSimple usuario = new Nucleo.InterfazNucleo().ObtenerUsuario(Convert.ToInt32(textBoxIdUsuario.Text));
                    if (usuario != null)
                    {
                        textBoxNombre.Text = usuario.Nombre;
                        textBoxApellido.Text = usuario.Apellido;
                        textBoxScoring.Text = Convert.ToString(usuario.Scoring);
                        textBoxTelefono.Text = usuario.Telefono;
                        buttonBuscarUsuario.Enabled = false;
                        buttonConfirmarUsuario.Enabled = true;
                        buttonBuscarUsuario.Focus();
                    }
                    else { labelErrorUsuario.Text = "El Id ingresado no corresponde a un usuario registrado "; buttonBuscarUsuario.Enabled = false; textBoxIdUsuario.Focus(); buttonConfirmarUsuario.Enabled = false; }
                }
                else { labelErrorUsuario.Text = "El Id ingresado es incorrecto "; buttonBuscarUsuario.Enabled = false; textBoxIdUsuario.Focus(); buttonConfirmarUsuario.Enabled = false; }
            }

        }

        private void buttonBuscarLibro_Click(object sender, EventArgs e)
        {
            {   
                textBoxTitulo.Clear();
                textBoxAutor.Clear();
                textBoxISBN.Clear();
                if (textBoxIdLibro.Text != null && (textBoxIdUsuario.Text).All(char.IsDigit) && textBoxIdLibro.Text != "")
                {
                    Libro libro = new Nucleo.InterfazNucleo().ObtenerLibro(Convert.ToInt32(textBoxIdLibro.Text));
                    if (libro != null)
                    {
                        textBoxTitulo.Text = libro.Titulo;
                        textBoxAutor.Text = libro.Autor;
                        textBoxISBN.Text = libro.ISBN;
                        buttonBuscarLibro.Enabled = false;
                        
                        buttonConfirmarLibro.Enabled = true;
                        buttonConfirmarLibro.Focus();
                        
                    }
                    else { labelErrorLibro.Text = "El Id ingresado no corresponde a un libro registrado ";  textBoxIdLibro.Clear(); textBoxIdLibro.Focus(); buttonBuscarLibro.Enabled = false; buttonConfirmarLibro.Enabled = false; }
                }
                else { labelErrorLibro.Text = "El Id ingresado es incorrecto ";  textBoxIdLibro.Clear(); textBoxIdLibro.Focus(); buttonConfirmarLibro.Enabled = false; buttonBuscarLibro.Enabled = false; }
            }
        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {
            buttonBuscarUsuario.Enabled = true;
            buttonConfirmarUsuario.Enabled = false;
        }

        private void textBoxIdLibro_TextChanged(object sender, EventArgs e)
        {
            buttonBuscarLibro.Enabled = true;
            buttonConfirmarLibro.Enabled = false;
            dgvEjemplares.Enabled = false;
        }

        private void RegistrarPrestamo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dgvEjemplares_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ( dgvEjemplares.CurrentRow.Cells[0].Value!=null)
            {
                textBoxIdEjemplar.Text = dgvEjemplares.CurrentRow.Cells[0].Value.ToString();
                textBoxEstado.Text = dgvEjemplares.CurrentRow.Cells[1].Value.ToString();
                buttonConfirmarEjemplar.Enabled = true;
                buttonConfirmarEjemplar.Focus();
            }
        
        }

        private void buttonConfirmarUsuario_Click(object sender, EventArgs e)
        {
            if (buttonConfirmarUsuario.Text=="Confirmar")
            {
                textBoxIdUsuario.Enabled = false;
                buttonConfirmarUsuario.Text = "Modificar";
                textBoxIdLibro.Enabled = true;
                textBoxIdLibro.Focus();
            }
            else
            {   
                textBoxIdUsuario.Enabled = true;
                buttonConfirmarUsuario.Text = "Confirmar";
                buttonConfirmarLibro.Enabled = false;
                dgvEjemplares.Enabled = false;
                buttonConfirmarEjemplar.Enabled = false;
            }
        }

        private void buttonConfirmarLibro_Click(object sender, EventArgs e)
        {
            if (buttonConfirmarLibro.Text == "Confirmar")
            {
                textBoxIdLibro.Enabled = false;
                buttonConfirmarUsuario.Enabled = false;
                buttonConfirmarLibro.Text = "Modificar";
                dgvEjemplares.Enabled = true;
                dgvEjemplares.Rows.Clear();
                foreach (var item in new InterfazNucleo().ObtenerEjemplaresDisponibles(Convert.ToInt32(textBoxIdLibro.Text))) 
                {
                    int n = dgvEjemplares.Rows.Add();
                    dgvEjemplares.Rows[n].Cells[0].Value = item.Id;
                    dgvEjemplares.Rows[n].Cells[1].Value = item.Estado;
                }
                dgvEjemplares.Focus();
            }
            else
            {
                textBoxIdLibro.Enabled = true;
                buttonConfirmarUsuario.Enabled = true;
                buttonConfirmarLibro.Text = "Confirmar";
                buttonConfirmarEjemplar.Enabled = false;
                dgvEjemplares.Rows.Clear();
                dgvEjemplares.Enabled = false;
                textBoxIdEjemplar.Clear();
                textBoxEstado.Clear();
            }
        }

        private void buttonConfirmarEjemplar_Click(object sender, EventArgs e)
        {
            if (buttonConfirmarEjemplar.Text == "Confirmar")
            {
                buttonConfirmarEjemplar.Text = "Modificar";
                dgvEjemplares.Enabled = false;
                buttonConfirmarLibro.Enabled = false;
                buttonGuardar.Enabled = true;

                
                buttonGuardar.Focus();
            }
            else
            {
                buttonGuardar.Enabled = false;
                dgvEjemplares.Enabled = true;
                buttonConfirmarLibro.Enabled = true;
                dgvEjemplares.Focus();
                buttonConfirmarEjemplar.Text = "Confirmar";
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (textBoxEstado.Text == "Bueno")
            {
                new InterfazNucleo().RegistrarPrestamo(Convert.ToInt32(textBoxIdUsuario.Text), Convert.ToInt32(textBoxIdEjemplar.Text));
                int id = new InterfazNucleo().ObtenerUltimoIdPrestamo();
                string FechaLimite = Convert.ToDateTime(new InterfazNucleo().ObtenerPrestamo(id).FechaLimite).Date.ToString();
                MessageBox.Show("El prestamo ha sido registrado, Id:" + id + "\nFecha limite: " + FechaLimite);
                this.Hide();
                Menu2 ventanaMenu = new Menu2(idUsuario.ToString());
                ventanaMenu.Show();
            }
            else 
            {
                DialogResult result = MessageBox.Show("El libro se encuentra en mal estado \n¿Desea continuar la operacion?","Advertencia",  MessageBoxButtons.YesNo);
                if (result==DialogResult.Yes)
                {
                    new InterfazNucleo().RegistrarPrestamo(Convert.ToInt32(textBoxIdUsuario.Text), Convert.ToInt32(textBoxIdEjemplar.Text));
                    int id = new InterfazNucleo().ObtenerUltimoIdPrestamo();
                    string FechaLimite = Convert.ToDateTime(new InterfazNucleo().ObtenerPrestamo(id).FechaLimite).Date.ToString();
                    MessageBox.Show("El prestamo ha sido registrado, Id:" + id + "\nFecha limite: " + FechaLimite);
                    this.Hide();
                    MenuPrincipal ventanaMenu = new MenuPrincipal(idUsuario.ToString());
                    ventanaMenu.Show();
                }
            }
        }

        private void textBoxIdEjemplar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
