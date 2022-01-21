using Dominio;
using Nucleo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Programa
{
    public partial class GestionarLibros : Form
    /*La finalidad de este formulario es permitir ver la informacion de todos los alibros y poder modificarla*/
    {
        private string nombreUsuario { get; set; }//Aqui se almacena el nombre de usuario del administrador que esta usando el programa
        private FachadaNucleo interfazNucleo = new FachadaNucleo();//Instancia del nucleo del programa que nos permite acceder a las funciones del mismo
        
        public GestionarLibros(string pNombreUsuario)//Constructor de la clase
        {
            InitializeComponent();
            nombreUsuario = pNombreUsuario;
            labelNombreUsuario.Text = "Usuario: " + nombreUsuario;
            ObtenerLibros();
        }

        private void GestionarLibros_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)//Este evento se ejecuta si se hace click al contenido de una celda
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewCell cell = (DataGridViewCell)dataGridViewLibros.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value.ToString() == "Gestionar")//Si se presiona la celda con el texto Gestionar, se abre una nueva ventana para actuaizar la informacion del libro
                {
                    int id = Convert.ToInt32(dataGridViewLibros.Rows[e.RowIndex].Cells[1].Value);
                    string ISBN = dataGridViewLibros.Rows[e.RowIndex].Cells[2].Value.ToString();
                    string titulo = dataGridViewLibros.Rows[e.RowIndex].Cells[3].Value.ToString();
                    string autor = dataGridViewLibros.Rows[e.RowIndex].Cells[4].Value.ToString();
                    string añoPublicacion = dataGridViewLibros.Rows[e.RowIndex].Cells[5].Value.ToString();
                    string baja = dataGridViewLibros.Rows[e.RowIndex].Cells[8].Value.ToString();
                    ActualizarLibro ventana = new ActualizarLibro(nombreUsuario, id);//Intanciamos lel formulario ActualizarLibro
                    this.Hide();//Ocultamos esta ventana
                    ventana.InicializarLibro(ISBN, titulo, autor, añoPublicacion, baja);//Le pasamos los datos del libro a la nueva ventana
                    ventana.Show(this);//mostramos la ventana nueva
                }
            }
        }

        private void textBoxTituloOISBNlibro_TextChanged(object sender, EventArgs e)//Este evento se ejecuta cuando se modifica el texto dentro del textBoxTituloOISBNlibro
        {
            if (textBoxTituloOISBNLibro.Text != null)//Se verifica qu haya texto en el textbox
            {
                for (int i = 0; i < dataGridViewLibros.Rows.Count - 1; i++)//Recorremos los elementos de la tabla de libros
                {
                    if (textBoxTituloOISBNLibro.Text.All(Char.IsDigit) && dataGridViewLibros.Rows[i].Cells[2].Value.ToString().Contains(textBoxTituloOISBNLibro.Text.ToString()))
                    {
                        dataGridViewLibros.Rows[i].Visible = true;//Si el termino buscado es un numero y es subcadena del isbn del libro, el elemento sera visible
                    }
                    else if (dataGridViewLibros.Rows[i].Cells[3].Value.ToString().ToLower().Contains(textBoxTituloOISBNLibro.Text.ToString().ToLower()) == false)
                    {
                        dataGridViewLibros.Rows[i].Visible = false;//Si el termino buscado es subcadena del titulo del libro, el elemento estara oculto
                    }
                    else
                    {
                        dataGridViewLibros.Rows[i].Visible = true;//Si el termino buscado es subcadena del titulo del libro, el elemento sera visible
                    }
                }
            }
        }

        public void ObtenerLibros()//Este metodo carga la tabla de libros en la tabla de libros
        {
            IEnumerable<Libro> libros = interfazNucleo.ObtenerLibros();//Obtenemos la lista de libros
            dataGridViewLibros.Rows.Clear();//Eliminamos todo el contenido de la tabla
            foreach (var item in libros)//Recorremos lcada elemento de la lista de libros y lo agregamos a la tabla
            {
                int n = dataGridViewLibros.Rows.Add();
                dataGridViewLibros.Rows[n].Cells[1].Value = item.Id;
                dataGridViewLibros.Rows[n].Cells[2].Value = item.ISBN;
                dataGridViewLibros.Rows[n].Cells[3].Value = item.Titulo;
                dataGridViewLibros.Rows[n].Cells[4].Value = item.Autor;
                dataGridViewLibros.Rows[n].Cells[5].Value = item.AñoPublicacion;
                dataGridViewLibros.Rows[n].Cells[6].Value = interfazNucleo.ObtenerEjemplaresDisponibles(item.Id).Count().ToString();
                dataGridViewLibros.Rows[n].Cells[7].Value = interfazNucleo.ObtenerEjemplaresTotales(item.Id).Count().ToString();
                dataGridViewLibros.Rows[n].Cells[8].Value = item.Baja.ToString();
                if (dataGridViewLibros.Rows[n].Cells[8].Value.ToString() == "True")
                {
                    dataGridViewLibros.Rows[n].DefaultCellStyle.BackColor = Color.Red;
                    dataGridViewLibros.Rows[n].DefaultCellStyle.ForeColor = Color.White;
                }
                else if (dataGridViewLibros.Rows[n].Cells[6].Value.ToString() == "0")
                {
                    dataGridViewLibros.Rows[n].DefaultCellStyle.BackColor = Color.Yellow;
                }
            }
        }

        private void GestionarLibros_FormClosed(object sender, FormClosedEventArgs e)//este evento se ejecutara cuando se cierre el formulario
        {
            this.Hide();
            this.Owner.Show();
        }

        private void botonVolver_Click(object sender, EventArgs e)//este evento se ejecutara cuando se presione el boton botonVolver
        {
            this.Hide();
            this.Owner.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
