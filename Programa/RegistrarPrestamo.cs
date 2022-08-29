using Dominio;
using Nucleo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bitacora;

namespace Programa
{
    public partial class RegistrarPrestamo : Form
    //La finalidad de este formulario es la de permitir registrar un nuevo prestamo
    {
        private string nombreUsuario { get; set; }//Aqui se almacena el nombre de usuario del administrador que esta usando el programa
        private FachadaNucleo interfazNucleo = new FachadaNucleo();//Instancia del nucleo del programa que nos permite acceder a las funciones del mismo
        private IBitacora bitacora = new Bitacora.ImplementacionBitacora();
        public RegistrarPrestamo(string pNombreUsuario)//Constructor de la clase
        {
            InitializeComponent();
            nombreUsuario = pNombreUsuario;
            
            labelNombreUsuario.Text = "Usuario: " + nombreUsuario;
        }

        private void RegistrarPrestamo_Load(object sender, EventArgs e)
        //cargas las tablas del formulario al iniciar
        {
            try
            {
             ObtenerLibros();//cargamos la lista de libros en la tabla de libros
            ObtenerUsuarios();//cargamos la lista de usuarios simples en la tabla de usuarios simples   
            }
            catch (Exception ex)
            {
                string texto= "Error RegistrarPrestamo_Load: "+ ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(texto);
                MessageBox.Show(texto, "Ha ocurrido un error");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTituloOISBNLibro_TextChanged(object sender, EventArgs e)//permite buscar un libro por titulo o isbn, se ejecuta cuando se modifica el texto de textBoxTituloOISBNLibro
        {
            try
            {
                if (textBoxTituloOISBNLibro.Text != null)
            {
                for (int i = 0; i < dataGridViewLibros.Rows.Count - 1; i++)
                {
                    if (dataGridViewLibros.Rows[i].Cells[1].Value.ToString().Contains(textBoxTituloOISBNLibro.Text.ToString()))
                    {
                        dataGridViewLibros.Rows[i].Visible = true;
                    }
                    else if (dataGridViewLibros.Rows[i].Cells[2].Value.ToString().ToLower().Contains(textBoxTituloOISBNLibro.Text.ToString().ToLower()) == false)
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
            catch (Exception ex)
            {
                string texto= "Error textBoxTituloOISBNLibro_TextChanged: "+ ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(texto);
                MessageBox.Show(texto, "Ha ocurrido un error");
            }
        }

        private void labelTitulo_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)//permite buscar un libro por nombreUsuario, se ejecuta cuando se modifica el texto de textBoxTituloOISBNLibro
        {
            try
            {
                if (textBoxNombreUsuario.Text != null)
            {
                for (int i = 0; i < dataGridViewUsuarios.Rows.Count - 1; i++)
                {
                    
                        if (dataGridViewUsuarios.Rows[i].Cells[0].Value.ToString().ToLower().Contains(textBoxNombreUsuario.Text.ToString().ToLower()) == false)
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
            catch (Exception ex)
            {
                string texto= "Error textBoxTituloOISBNLibro_TextChanged: "+ ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(texto);
                MessageBox.Show(texto, "Ha ocurrido un error");
            }
        }

        private void dataGridViewLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)//se ejecuta cuando se presiona una celda de la tabla de libros
        {
            try
            {
                if (e.RowIndex >= 0)
            {
                if (dataGridViewLibros.CurrentRow.Cells[5].Value != null)
                {
                    if (dataGridViewLibros.CurrentRow.Cells[5].Value.ToString() != "0")//si el libro tiene ejemplares disponibles se muestra en pantalla los datos del libro
                    {
                        textBoxIdLibro.Text = dataGridViewLibros.CurrentRow.Cells[0].Value.ToString();
                        textBoxTitulo.Text = dataGridViewLibros.CurrentRow.Cells[1].Value.ToString();
                        textBoxISBN.Text = dataGridViewLibros.CurrentRow.Cells[2].Value.ToString();
                        textBoxAutor.Text = dataGridViewLibros.CurrentRow.Cells[3].Value.ToString();
                    }
                }
            }
            }
            catch (Exception ex)
            {
                string texto= "Error dataGridViewLibros_CellContentClick: "+ ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(texto);
                MessageBox.Show(texto, "Ha ocurrido un error");
            }
        }

        private void ObtenerLibros()//carga la lista de libros en la tabla de libros
        {
            try
            {
                IEnumerable<Libro> libros = interfazNucleo.ObtenerLibros();
            dataGridViewLibros.Rows.Clear();
            foreach (var item in libros)
            {
                if (item.Baja == false)
                {
                    int n = dataGridViewLibros.Rows.Add();
                    dataGridViewLibros.Rows[n].Cells[0].Value = item.Id;
                    dataGridViewLibros.Rows[n].Cells[1].Value = item.ISBN;
                    dataGridViewLibros.Rows[n].Cells[2].Value = item.Titulo;
                    dataGridViewLibros.Rows[n].Cells[3].Value = item.Autor;
                    dataGridViewLibros.Rows[n].Cells[4].Value = item.AñoPublicacion;
                    dataGridViewLibros.Rows[n].Cells[5].Value = interfazNucleo.ObtenerEjemplaresDisponibles(item.Id).Count().ToString();
                    dataGridViewLibros.Rows[n].Cells[6].Value = interfazNucleo.ObtenerEjemplaresTotales(item.Id).Count().ToString();
                    if (dataGridViewLibros.Rows[n].Cells[5].Value.ToString() == "0")
                    {
                        dataGridViewLibros.Rows[n].DefaultCellStyle.BackColor = Color.Yellow;
                    }
                }

            }
            }
            catch (Exception ex)
            {
                string texto= "Error ObtenerLibros: "+ ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(texto);
                MessageBox.Show(texto, "Ha ocurrido un error");
            }
        }

        private void ObtenerUsuarios()//carga la lista de usuarios simples en la tabla de usuarios simples
        {
            try
            {
                IEnumerable<UsuarioSimple> usuarios = interfazNucleo.ObtenerUsuarios();
            dataGridViewUsuarios.Rows.Clear();
            foreach (var item in usuarios)
            {
                if (item.Baja == false)
                {
                    int n = dataGridViewUsuarios.Rows.Add();
                    dataGridViewUsuarios.Rows[n].Cells[0].Value = item.NombreUsuario;
                    dataGridViewUsuarios.Rows[n].Cells[1].Value = item.Nombre;
                    dataGridViewUsuarios.Rows[n].Cells[2].Value = item.Apellido;
                    dataGridViewUsuarios.Rows[n].Cells[3].Value = item.FechaNacimiento.ToShortDateString();
                    dataGridViewUsuarios.Rows[n].Cells[4].Value = item.Mail;
                    dataGridViewUsuarios.Rows[n].Cells[5].Value = item.Telefono;
                }      
            }
            }
            catch (Exception ex)
            {
                string texto= "Error ObtenerUsuarios: "+ ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(texto);
                MessageBox.Show(texto, "Ha ocurrido un error");
            }
        }

        private void dataGridViewUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)//se ejecuta cuando se presiona una celda de la tabla de usuarios y se muestran los datos del usuario en pantalla
        {
            try
            {
                if (dataGridViewUsuarios.CurrentRow.Cells[0].Value != null)
            {
                textBoxNomUsuario.Text = dataGridViewUsuarios.CurrentRow.Cells[0].Value.ToString();
                textBoxNombre.Text = dataGridViewUsuarios.CurrentRow.Cells[1].Value.ToString();
                textBoxApellido.Text = dataGridViewUsuarios.CurrentRow.Cells[2].Value.ToString();
            }
            }
            catch (Exception ex)
            {
                string texto= "Error dataGridViewUsuarios_CellContentClick: "+ ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(texto);
                MessageBox.Show(texto, "Ha ocurrido un error");
            }
        }

        private void textBoxNomUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonRegistrarPrestamo_Click(object sender, EventArgs e)//se ejecuta cuando se presiona el boton registrar prestamo, registra el prestamo y muestra un mensaje en pantalla
        {
            try
            {
                if (!string.IsNullOrEmpty(textBoxNomUsuario.Text))//Los primeros tres if verifican que el usuario este seleccionado
            {
                if (!string.IsNullOrEmpty(textBoxNombre.Text))
                {
                    if (!string.IsNullOrEmpty(textBoxApellido.Text))
                    {
                        if (!string.IsNullOrEmpty(textBoxIdLibro.Text))//Los ultimos if verifican que el libro este seleccionado
                        {
                            if (!string.IsNullOrEmpty(textBoxAutor.Text))
                            {
                                if (!string.IsNullOrEmpty(textBoxTitulo.Text))
                                {
                                    if (!string.IsNullOrEmpty(textBoxISBN.Text))
                                    {
                                        int idEjemplar = interfazNucleo.ObtenerEjemplaresDisponibles(Convert.ToInt32(textBoxIdLibro.Text.ToString())).First().Id;
                                        interfazNucleo.RegistrarPrestamo(textBoxNomUsuario.Text, idEjemplar, Convert.ToInt32(textBoxIdLibro.Text));
                                        string FechaLimite = Convert.ToDateTime(new FachadaNucleo().ObtenerPrestamo(interfazNucleo.ObtenerPrestamos().Last().Id).FechaLimite).Date.ToShortDateString();
                                        ObtenerLibros();//cargamos la lista de libros en la tabla de libros nuevamente para que se actualice
                                        MessageBox.Show("El prestamo ha sido registrado correctamente" + "\nFecha limite: " + FechaLimite);

                                    }
                                    else
                                    {
                                        MessageBox.Show("Seleccione un libro!");
                                    }
                                }
                                else 
                                {
                                    MessageBox.Show("Seleccione un libro!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Seleccione un libro!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Seleccione un libro!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un usuario!");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un usuario!");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un usuario!");
            }
            }
            catch (Exception ex)
            {
                string texto= "Error buttonRegistrarPrestamo_Click: "+ ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(texto);
                MessageBox.Show(texto, "Ha ocurrido un error");
            }
        }

        private void botonVolver_Click(object sender, EventArgs e)//se ejecuta cuando se presiona el boton volver
        {
            this.Hide();//la ventana se oculta
            this.Owner.Show();//se muestra la ventana padre
        }

        private void RegistrarPrestamo_FormClosed(object sender, FormClosedEventArgs e)//este evento se ejecutara cuando se cierre el formulario
        {
           this.Hide();//la ventana se oculta
            this.Owner.Show();//se muestra la ventana padre
        }
    }
}
