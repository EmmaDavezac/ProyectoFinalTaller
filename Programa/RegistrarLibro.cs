using Dominio;
using Nucleo;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UtilidadesPresentacion;
using Bitacora;
using Bitacora;


namespace Programa
{
    public partial class RegistrarLibro : Form//La finalidad de este formulario es la de permitir registrar un nuevo libro
    {
        private string NombreUsuario { get; set; }//Aqui se almacena el nombre de usuario del administrador que esta usando el programa
        private FachadaNucleo interfazNucleo = new FachadaNucleo();//Instancia del nucleo del programa que nos permite acceder a las funciones del mismo
        
        private BibliotecaUtilidadesPresentacion utilidades = new BibliotecaUtilidadesPresentacion();
        private IBitacora bitacora = new Bitacora.Bitacora();
        public RegistrarLibro(string pNombreUsuario)//Constructor de la clase
        {
            InitializeComponent();
            NombreUsuario = pNombreUsuario;
            labelNombreUsuario.Text = "Usuario: " + NombreUsuario;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)//se ejecuta cuando se pselecciona un libro  de la tabla de libros
        {
            if (e.RowIndex >= 0 && dataGridViewTituloYAutor.CurrentRow.Cells[0].Value != null)//se verifica que la fila seleccionada no este vacia
            {
                dataGridViewAños.Rows.Clear();//se eliminan las filas de la tabla de años
                dataGridViewISBN.Rows.Clear();//se eliminan las filas de la tabla de ISBNs
                textBoxTitulo.Text = dataGridViewTituloYAutor.CurrentRow.Cells[0].Value.ToString();//se muestra en pantalla el titulo del libro seleccionado
                textBoxAutor.Text = dataGridViewTituloYAutor.CurrentRow.Cells[1].Value.ToString();//se muestra en pantalla el nombre del autor del libro seleccionado
                buttonBorrarDatos.Enabled = true;//se activa el boton borrar datos
                List<string> isbns = utilidades.TransformarISBNsALista(dataGridViewTituloYAutor.CurrentRow.Cells[3].Value.ToString());
                foreach (var item in isbns)//se cargan los isbns del libro seleccionado en la tabla de isbns
                {
                    int n = dataGridViewISBN.Rows.Add();
                    dataGridViewISBN.Rows[n].Cells[0].Value = item;
                }
                List<string> años = utilidades.TransformarAñosALista(dataGridViewTituloYAutor.CurrentRow.Cells[2].Value.ToString());
                foreach (var item in años)//se cargan los años de publicacion del libro seleccionado en la tabla de años
                {
                    int n = dataGridViewAños.Rows.Add();
                    dataGridViewAños.Rows[n].Cells[0].Value = item;
                }
            }
        }

        private void BuscarLibrosAPI_Load(object sender, EventArgs e)
        {
            VerificarVentanaPadre();
        }

        private void button1_Click(object sender, EventArgs e)//este men todo se ejecutara cuando se presione button1, nos permite hacer una consulta a open library y obtener una lista de libros
        {
            if (textBoxBuscar.Text != null && textBoxBuscar.Text != "")//se verifica que el cuadro de busqueda no este vacio
            {
                int resultado = 0;
                dataGridViewTituloYAutor.Rows.Clear();//se limpia la tabla de libros
                List<Libro> resultados = interfazNucleo.ListarLibrosDeAPIPorCoincidencia(textBoxBuscar.Text);//se realiza la consulta a Open Library y se almacena la lista de libros
                foreach (var item in resultados)//se carga cada uno de los resultados en la tabla de libros
                {
                    int n = dataGridViewTituloYAutor.Rows.Add();
                    dataGridViewTituloYAutor.Rows[n].Cells[0].Value = item.Titulo;
                    dataGridViewTituloYAutor.Rows[n].Cells[1].Value = utilidades.SacarAutorDeLaLista(item.Autor);
                    dataGridViewTituloYAutor.Rows[n].Cells[2].Value = item.AñoPublicacion;
                    dataGridViewTituloYAutor.Rows[n].Cells[3].Value = item.ISBN;
                    resultado += 1;
                }

                if (resultado == 0) { labelResultados.Text = "Error, no se encontraron resultados"; }//en el caso de no encontrarse resultados , se muestra un mensaje en pantalla y se desabilita en boton buscar
                else
                {
                    labelResultados.Text = "";
                }  
            }
            else
            {
                labelResultados.Text = "No ingreso un termino de busqueda";
            }
            textBoxBuscar.Focus(); //enfocamos el cuadro de busqueda
            buttonBuscar.Enabled = false; //se desabilita el boton buscar
        }

        private void textBox1_TextChanged(object sender, EventArgs e)//activa el boton buscar cuando se modifica el texto de textBox1
        {
            buttonBuscar.Enabled = true;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonAñadirLibro_Click(object sender, EventArgs e)
            //se ejecuta cuando se presiona el boton añadir libro, registra el libro en el caso de que se haya ingresado toda la informacion del libro y posea el formato correcto
        {
           try
           {
                bool resultado;
            if (!string.IsNullOrEmpty(textBoxTitulo.Text) && !string.IsNullOrEmpty(textBoxAutor.Text) && !string.IsNullOrEmpty(textBoxISBN.Text) && !string.IsNullOrEmpty(textBoxAñoPublicacion.Text) && !string.IsNullOrEmpty(textBoxCantidadEjemplares.Text))
            //se verifica que se haya ingresado toda la informacion necesaria
            {
                resultado = interfazNucleo.AñadirLibro(textBoxISBN.Text, textBoxTitulo.Text, textBoxAutor.Text, textBoxAñoPublicacion.Text, Convert.ToInt32(textBoxCantidadEjemplares.Text));
                //se registra el libro en la base de datos
                if (resultado == true)
                {
                    MessageBox.Show("Libro registrado con exito, el Id del libro es: " + new FachadaNucleo().ObtenerUltimoIdLibro());//se muestra el mensaje en pantalla
                }
                else 
                {
                    MessageBox.Show("El libro: " + textBoxTitulo.Text + " .ISBN: " + textBoxISBN.Text + " ya esta registrado");//se muestra el mensaje en pantalla
                }

            }
            else
            {
                MessageBox.Show("Debe completar la informacion");//se muestra el mensaje en pantalla
                textBoxTitulo.Focus();
                //se  enfoca el cuadro de texto del titulo
            }
           }
           catch (Exception ex)
            {
                string texto= "Error buttonAñadirLibro_Click: "+ ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(texto);
                MessageBox.Show(texto, "Ha ocurrido un error");
            }
        }

        private void botonVolver_Click(object sender, EventArgs e)//se ejecuta cuando se presiona el boton volver
        {
            this.Hide();//la ventana se oculta
            this.Owner.Show();//se muestra la ventana padre
        }

        private void BuscarLibrosAPI_FormClosed(object sender, FormClosedEventArgs e)//se ejecuta cuando se cierra la ventana
        {
            this.Hide();//la ventana se oculta
            this.Owner.Show();//se muestra la ventana padre
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void buttonBorrarDatos_Click(object sender, EventArgs e)
            //borra el contenido de los textbox con la informacion del libro a registrar cuando se presiona el boton  borrar datos
        {
            textBoxAutor.Clear();
            textBoxAñoPublicacion.Clear();
            textBoxISBN.Clear();
            textBoxTitulo.Clear();
            //borra los datos de los textboxs
            
        }

        private void labelIngreseISBN_Click(object sender, EventArgs e)
        {

        }

        private void textBoxBuscarPorISBN_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonBuscarPorISBN_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewISBN_CellContentClick(object sender, DataGridViewCellEventArgs e)
            //se ejecuta cuando se presiona una fila de la lista de ISBNs del libro, carga el ISBN  seleccionado en el textboxISBN
        {
            try
            {
                if (e.RowIndex >= 0)
            {
                if (dataGridViewISBN.CurrentRow.Cells[0].Value!=null)//Se verifica que la fila seleccionada no este vacia
                {
                    textBoxISBN.Text = dataGridViewISBN.CurrentRow.Cells[0].Value.ToString(); 
                }
            }
            }
            catch (Exception ex)
            {
                string texto= "Error dataGridViewISBN_CellContentClick: "+ ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(texto);
                MessageBox.Show(texto, "Ha ocurrido un error");
            }
        }

        private void dataGridViewAños_CellContentClick(object sender, DataGridViewCellEventArgs e)
            //se ejecuta cuando se presiona una fila de la lista de años de publicacion del libro, carga el año seleccionado en el textboxAñoPublicacion
        {
            try
            {
                if (e.RowIndex >= 0)
            {
                if (dataGridViewAños.CurrentRow.Cells[0].Value != null)
                {
                    textBoxAñoPublicacion.Text = dataGridViewAños.CurrentRow.Cells[0].Value.ToString();//Se verifica que la fila seleccionada no este vacia
                }
            }
            }
            catch (Exception ex)
            {
                string texto= "Error dataGridViewAños_CellContentClick: "+ ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(texto);
                MessageBox.Show(texto,"Ha ocurrido un error");
            }
        }

        private void textBoxSeleccionarISBN_TextChanged(object sender, EventArgs e)//nos permite buscar un isbn en la tabla de isbns del libro
        {
            try
            {
                if (textBoxSeleccionarISBN.Text != null)
            {
                for (int i = 0; i < dataGridViewISBN.Rows.Count - 1; i++)
                {
                    if (dataGridViewISBN.Rows[i].Cells[0].Value.ToString().Contains(textBoxSeleccionarISBN.Text.ToString()) == false)
                    {
                        dataGridViewISBN.Rows[i].Visible = false;
                    }
                    else
                    {
                        dataGridViewISBN.Rows[i].Visible = true;
                    }
                }
            }
            }
            catch (Exception ex)
            {
                string texto= "Error textBoxSeleccionarISBN_TextChanged: "+ ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(texto);
                MessageBox.Show(texto, "Ha ocurrido un error");
            }
        }

        private void textBoxSelccionarAño_TextChanged(object sender, EventArgs e)//nos permite buscar un año en la tabla de años de publicacion
        {
            try
            {
                if (textBoxSelccionarAño.Text != null)
            {
                for (int i = 0; i < dataGridViewAños.Rows.Count - 1; i++)
                {
                    if (dataGridViewAños.Rows[i].Cells[0].Value.ToString().Contains(textBoxSelccionarAño.Text.ToString()) == false)
                    {
                        dataGridViewAños.Rows[i].Visible = false;
                    }
                    else
                    {
                        dataGridViewAños.Rows[i].Visible = true;
                    }
                }
            }
            }
            catch (Exception ex)
            {
                string texto= "Error textBoxSelccionarAño_TextChanged: "+ ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(texto);
                MessageBox.Show(texto, "Ha ocurrido un error");
            }
        }

        private void labelSeleccionarAño_Click(object sender, EventArgs e)
        {

        }

        public void VerificarVentanaPadre()//este metodo identifica la ventana padre y a partir de esto muestra u oculta funciones 
        {
            try
            {
                if (this.Owner.Name == "MenuPrincipal")
            {
                buttonAñadirLibro.Visible = true;
                buttonActualizar.Visible = false;
            }
            else if (this.Owner.Name == "ActualizarLibro")
            {
                buttonActualizar.Visible = true;
                buttonAñadirLibro.Visible = false;
                textBoxCantidadEjemplares.Visible = false;
                labelCantidadEjemplares.Visible = false;
            }
            }
            catch (Exception ex)
            {
                string texto= "Error VerificarVentanaPadre: "+ ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(texto);
                MessageBox.Show(texto, "Ha ocurrido un error");
            }
        }

        public void InicializarLibro(int idLibro)//carga los textbox con los datos del libro pasado como parametro
        {
           try
           {
            var libro = interfazNucleo.ObtenerLibro(idLibro);
            textBoxAutor.Text = libro.Autor;
            textBoxAñoPublicacion.Text = libro.AñoPublicacion;
            textBoxISBN.Text = libro.ISBN;
            textBoxTitulo.Text = libro.Titulo;
            textBoxBuscar.Text = libro.Titulo;
            button1_Click(this, null);
           }
           catch (Exception ex)
            {
                string texto= "Error InicializarLibro: "+ ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(texto);
                MessageBox.Show(texto, "Ha ocurrido un error");
            }
        }
        private void buttonActualizar_Click(object sender, EventArgs e)
            //se ejecuta cuando se presiona el boton actualizar
        {
            try
                {
                    if (!string.IsNullOrEmpty(textBoxTitulo.Text) && !string.IsNullOrEmpty(textBoxAutor.Text) && !string.IsNullOrEmpty(textBoxISBN.Text) && !string.IsNullOrEmpty(textBoxAñoPublicacion.Text))
                    {

                        ((ActualizarLibro)this.Owner).CargarDatosDeBusquedaAvanzada(textBoxTitulo.Text, textBoxAutor.Text, textBoxAñoPublicacion.Text, textBoxISBN.Text);
                        MessageBox.Show("Libro registrado con exito, el Id del libro es: " + new FachadaNucleo().ObtenerUltimoIdLibro());
                        this.Hide();
                        this.Owner.Show();
                    }
                    else
                    {
                        MessageBox.Show("Debe completar la informacion");
                        textBoxTitulo.Focus();
                    }
                }
            catch (Exception ex)
            {
                string texto= "Error buttonActualizar_Click: "+ ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(texto);
                MessageBox.Show(texto, "Ha ocurrido un error");
            }
        }

        private void textBoxCantidadEjemplares_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
