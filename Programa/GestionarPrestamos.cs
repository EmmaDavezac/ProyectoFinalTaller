using Dominio;
using Nucleo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Programa
{
    public partial class GestionarPrestamos : Form
     /*La finalidad de este formulario es permitir ver la informacion de todos los prestamos y poder modificarla*/
    {
        private string nombreUsuario { get; set; }//Aqui se almacena el nombre de usuario del administrador que esta usando el programa
        private FachadaNucleo interfazNucleo = new FachadaNucleo();//Instancia del nucleo del programa que nos permite acceder a las funciones del mismo
        
        public GestionarPrestamos(string pNombreUsuario)//Constructor de la clase
        {
            InitializeComponent();
            nombreUsuario = pNombreUsuario;
            labelNombreUsuario.Text = "Usuario: " + nombreUsuario;
            ObtenerPrestamos();
        }

        private void GestionarPrestamos_Load(object sender, EventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GestionarPrestamos_FormClosed(object sender, FormClosedEventArgs e)//Este metodo se ejecuta cuando se cierra el formulario
        {
            this.Hide();
            this.Owner.Show();
        }

        private void botonVolver_Click(object sender, EventArgs e)//Este evento se ejecuta cuando se presiona el boton botonVolver
        {
            this.Hide();
            this.Owner.Show();
        }

        public void ObtenerPrestamos()//Este metodo carga la tabla de libros en la tabla de prestamos
        {
            IEnumerable<Prestamo> prestamos = interfazNucleo.ObtenerPrestamos();//Obtenemos la lista de prestamos
            dataGridViewPrestamos.Rows.Clear();//Eliminamos todo el contenido de la tabla
            foreach (var item in prestamos)//Recorremos lcada elemento de la lista y lo agregamos a la tabla
            {
                if (item.FechaDevolucion == null)
                {
                    int n = dataGridViewPrestamos.Rows.Add();
                    dataGridViewPrestamos.Rows[n].Cells[1].Value = item.Id;
                    dataGridViewPrestamos.Rows[n].Cells[2].Value = item.nombreUsuario;
                    dataGridViewPrestamos.Rows[n].Cells[3].Value = interfazNucleo.ObtenerLibro(item.idLibro).Titulo;
                    dataGridViewPrestamos.Rows[n].Cells[4].Value = interfazNucleo.ObtenerLibro(item.idLibro).ISBN;
                    dataGridViewPrestamos.Rows[n].Cells[5].Value = item.FechaPrestamo;
                    dataGridViewPrestamos.Rows[n].Cells[6].Value = item.FechaLimite;
                    dataGridViewPrestamos.Rows[n].Cells[7].Value = item.ActualizarEstado().ToString();
                    if (dataGridViewPrestamos.Rows[n].Cells[7].Value.ToString() == "Retrasado")
                    {
                        dataGridViewPrestamos.Rows[n].DefaultCellStyle.BackColor = Color.Red;
                        dataGridViewPrestamos.Rows[n].DefaultCellStyle.ForeColor = Color.White;
                    }
                    else if (dataGridViewPrestamos.Rows[n].Cells[7].Value.ToString() == "ProximoAVencer")
                    {
                        dataGridViewPrestamos.Rows[n].DefaultCellStyle.BackColor = Color.Green;
                    }
                }
            }
        }

        private void dataGridViewPrestamos_CellContentClick(object sender, DataGridViewCellEventArgs e)//Este evento se ejecuta si se hace click al contenido de una celda de la tabla
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewCell cell = (DataGridViewCell)dataGridViewPrestamos.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value.ToString() == "Devolucion")//Si se presiona la celda con el texto Devolucion, se abre una nueva ventana para registrar la devolucion del prestamo
                {
                    Prestamo prestamo = interfazNucleo.ObtenerPrestamo(Convert.ToInt32(dataGridViewPrestamos.Rows[e.RowIndex].Cells[1].Value.ToString()));
                    Libro libro = interfazNucleo.ObtenerLibro(prestamo.idLibro);
                    string usuario = dataGridViewPrestamos.Rows[e.RowIndex].Cells[2].Value.ToString();
                    UsuarioSimple usuarioSimple = interfazNucleo.ObtenerUsuario(usuario);
                    string titulo = libro.Titulo;
                    string autor = libro.Autor;
                    string fechaVencimiento = dataGridViewPrestamos.Rows[e.RowIndex].Cells[6].Value.ToString();
                    string estado = dataGridViewPrestamos.Rows[e.RowIndex].Cells[7].Value.ToString();
                    string scoring = Convert.ToString(usuarioSimple.Scoring);
                   
                    int idPrestamo = Convert.ToInt32(dataGridViewPrestamos.Rows[e.RowIndex].Cells[1].Value.ToString());
                    DevolucionPrestamo ventana = new DevolucionPrestamo();
                    ventana.InicializarDevolucion(usuario, titulo, autor, fechaVencimiento, estado, scoring, idPrestamo);
                    ventana.ShowDialog(this);
                }
                else if (cell.Value.ToString() == "Edit")//Si se presiona la celda con el texto Devolucion, se abre una nueva ventana para editar las fechas de un libro(solo para probar el programa)
                {
                    int idPrestamo = Convert.ToInt32(dataGridViewPrestamos.CurrentRow.Cells[1].Value.ToString());
                    string fechaPrestamo = dataGridViewPrestamos.CurrentRow.Cells[5].Value.ToString();
                    string fechaLimite = dataGridViewPrestamos.CurrentRow.Cells[6].Value.ToString();
                    EditarPrestamo ventana = new EditarPrestamo();
                    ventana.InicialiarEditarPrestamo(idPrestamo, fechaPrestamo, fechaLimite);
                    ventana.ShowDialog(this);
                }
            }
        }

        private void checkBoxProximosAVencerse_CheckedChanged(object sender, EventArgs e)//Este metodo se ejecuara cuando se marque el checkBox heckBoxProximosAVencerse y permite que la tabla solo muestre los prestamos proximos a vencer
        {
            if (checkBoxProximosAVencerse.Checked == true)
            {
                for (int i = 0; i < dataGridViewPrestamos.Rows.Count - 1; i++)
                {
                    if (dataGridViewPrestamos.Rows[i].Cells[7].Value.ToString() == "ProximoAVencer")
                    {
                        dataGridViewPrestamos.Rows[i].Visible = true;
                    }
                    else
                    {
                        dataGridViewPrestamos.Rows[i].Visible = false;
                    }
                }
            }
            else
            {
                for (int i = 0; i < dataGridViewPrestamos.Rows.Count - 1; i++)
                {
                    dataGridViewPrestamos.Rows[i].Visible = true;
                }
            }
        }

        private void checkBoxRestrasados_CheckedChanged(object sender, EventArgs e)//Este metodo se ejecuara cuando se marque el checkBox chcheckBoxRestrasados_y permite que la tabla solo muestre los prestamos retrasados
        {
            if (checkBoxRestrasados.Checked == true)
            {
                for (int i = 0; i < dataGridViewPrestamos.Rows.Count - 1; i++)
                {
                    if (dataGridViewPrestamos.Rows[i].Cells[7].Value.ToString() == "Retrasado")
                    {
                        dataGridViewPrestamos.Rows[i].Visible = true;
                    }
                    else
                    {
                        dataGridViewPrestamos.Rows[i].Visible = false;
                    }
                }
            }
            else
            {
                for (int i = 0; i < dataGridViewPrestamos.Rows.Count - 1; i++)
                {
                    dataGridViewPrestamos.Rows[i].Visible = true;
                }
            }
        }

        private void textBoxUsuarioOTituloLibro_TextChanged(object sender, EventArgs e)//Se ejecutara cuando se modifique el texto del textbox textBoxUsuarioOTituloLibro
        {
            if (textBoxUsuarioOTituloLibro.Text != null)//se verifica que el textbox no este vacio
            {
                for (int i = 0; i < dataGridViewPrestamos.Rows.Count - 1; i++)//recorremos las filas de la tabla 
                //este metodo nos permite filtrar los prestamos escribiendo el nombre de usuario o el titulo del libro
                {
                    if (dataGridViewPrestamos.Rows[i].Cells[2].Value.ToString().ToLower().Contains(textBoxUsuarioOTituloLibro.Text.ToString().ToLower()))
                    {
                        dataGridViewPrestamos.Rows[i].Visible = true;//si el termino buscado es subcadena del nombre de usuario del prestamo, la fila sera visible
                    }
                    else if (dataGridViewPrestamos.Rows[i].Cells[3].Value.ToString().ToLower().Contains(textBoxUsuarioOTituloLibro.Text.ToString().ToLower()) == false)
                    {
                        dataGridViewPrestamos.Rows[i].Visible = false;//si el termino buscado no es subcadena del titulo del libro del prestamo, la fila se ocultara
                    }
                    else
                    {
                        dataGridViewPrestamos.Rows[i].Visible = true;//si el termino de busqueda es subcadena del titulo del libro del prestamo, la fila sera visible
                    }
                }
            }
        }
    }
}
