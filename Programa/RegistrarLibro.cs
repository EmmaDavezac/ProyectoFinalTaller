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
using Dominio;



namespace Programa
{
    public partial class RegistrarLibro : Form
    {
        private string nombre { get; set; }
        private string NombreUsuario { get; set; }
        InterfazNucleo interfazNucleo = new InterfazNucleo();
        public RegistrarLibro(string pNombreUsuario)
        {
            InitializeComponent();
            NombreUsuario = pNombreUsuario;
            nombre = interfazNucleo.ObtenerAdministradorPorNombreOMail(NombreUsuario).Nombre;
            labelNombreUsuario.Text = "Usuario: " + nombre;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0&& dataGridViewTituloYAutor.CurrentRow.Cells[0].Value!=null)
            {   
                dataGridViewAños.Rows.Clear();
                dataGridViewISBN.Rows.Clear();
                textBoxTitulo.Text = dataGridViewTituloYAutor.CurrentRow.Cells[0].Value.ToString();
                textBoxAutor.Text = dataGridViewTituloYAutor.CurrentRow.Cells[1].Value.ToString();
                buttonBorrarDatos.Enabled = true;
                List<string> isbns = interfazNucleo.TransformarISBNsALista(dataGridViewTituloYAutor.CurrentRow.Cells[3].Value.ToString());
                foreach (var item in isbns)
                {
                    int n = dataGridViewISBN.Rows.Add();
                    dataGridViewISBN.Rows[n].Cells[0].Value = item;
                }
                List<string> años = interfazNucleo.TransformarAñosALista(dataGridViewTituloYAutor.CurrentRow.Cells[2].Value.ToString());
                foreach (var item in años)
                {
                    int n = dataGridViewAños.Rows.Add();
                    dataGridViewAños.Rows[n].Cells[0].Value = item;
                }
                /*List<string> resultados = textBoxISBN.Text.ToList();
                foreach (var item in resultados)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView2.Rows[n].Cells[0].Value = ;
                }*/ 
            }
        }

        private void BuscarLibrosAPI_Load(object sender, EventArgs e)
        {
            VerificarVentanaPadre();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxBuscar.Text != null && textBoxBuscar.Text != "")
            {
                int resultado = 0;
                dataGridViewTituloYAutor.Rows.Clear();
                List<Libro> resultados = interfazNucleo.ListarLibrosDeAPIPorCoincidencia(textBoxBuscar.Text);
                foreach (var item in resultados)
                {
                    int n = dataGridViewTituloYAutor.Rows.Add();
                    dataGridViewTituloYAutor.Rows[n].Cells[0].Value = item.Titulo;
                    dataGridViewTituloYAutor.Rows[n].Cells[1].Value = interfazNucleo.SacarAutorDeLaLista(item.Autor);
                    dataGridViewTituloYAutor.Rows[n].Cells[2].Value = item.AñoPublicacion;
                    dataGridViewTituloYAutor.Rows[n].Cells[3].Value = item.ISBN;
                    resultado += 1;
                }

                if (resultado == 0) { labelResultados.Text = "Error, no se encontraron resultados"; buttonBuscar.Enabled = false; textBoxBuscar.Focus(); }
                else
                {
                    labelResultados.Text = "";
                    buttonBuscar.Enabled = false;
                    textBoxBuscar.Focus();
                }
            }
            else
            {
                labelResultados.Text = "No ingreso un termino de busqueda";
                buttonBuscar.Enabled = false;
                textBoxBuscar.Focus();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            buttonBuscar.Enabled = true;
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxTitulo.Text) && !string.IsNullOrEmpty(textBoxAutor.Text) && !string.IsNullOrEmpty(textBoxISBN.Text) && !string.IsNullOrEmpty(textBoxAñoPublicacion.Text) && !string.IsNullOrEmpty(textBoxCantidadEjemplares.Text))
            {

                new InterfazNucleo().AñadirLibro(textBoxISBN.Text, textBoxTitulo.Text, textBoxAutor.Text, textBoxAñoPublicacion.Text,Convert.ToInt32(textBoxCantidadEjemplares.Text));
                MessageBox.Show("Libro registrado con exito, el Id del libro es: " + new InterfazNucleo().ObtenerUltimoIdLibro());
                /*buttonBorrarDatos_Click(sender,e);  No es necesario ya que podria querer seguir cargando libros con el mismo titulo, incluso si me equivoque en la cantidad de ejemplares podria agregarlos sin volver a cargar todo.
                dataGridViewAños.Rows.Clear();         
                dataGridViewISBN.Rows.Clear();
                dataGridViewTituloYAutor.Rows.Clear();
                textBoxCantidadEjemplares.Clear();
                textBoxBuscar.Clear();*/

            }
            else
            {
                MessageBox.Show("Debe completar la informacion");
                textBoxTitulo.Focus();
            }
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Owner.Show();
        }

        private void BuscarLibrosAPI_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            this.Owner.Show();
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
        {
            textBoxAutor.Clear();
            textBoxAñoPublicacion.Clear();
            textBoxISBN.Clear();
            textBoxTitulo.Clear();
            buttonBorrarDatos.Enabled = false;
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
        {
            if (e.RowIndex >= 0)
            {
                textBoxISBN.Text = dataGridViewISBN.CurrentRow.Cells[0].Value.ToString(); 
            }
        }

        private void dataGridViewAños_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textBoxAñoPublicacion.Text = dataGridViewAños.CurrentRow.Cells[0].Value.ToString();
            }
        }

        private void textBoxSeleccionarISBN_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSeleccionarISBN.Text != null)
            {
                for (int i = 0; i < dataGridViewISBN.Rows.Count-1; i++)
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

        private void textBoxSelccionarAño_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSelccionarAño.Text != null)
            {
                for (int i = 0; i < dataGridViewAños.Rows.Count-1; i++)
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

        private void buttonGestionarLibros_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionarLibros ventana = new GestionarLibros(NombreUsuario);
            ventana.ShowDialog(this);
        }

        private void labelSeleccionarAño_Click(object sender, EventArgs e)
        {

        }

        public void VerificarVentanaPadre()
        {
            if (this.Owner.Name == "Menu2")
            {
                buttonAñadirLibro.Visible = true;
                buttonActualizar.Visible = false;
            }
            else if (this.Owner.Name == "ActualizarLibro")
            {
                buttonActualizar.Visible = true;
                buttonAñadirLibro.Visible = false;
                buttonGestionarLibros.Visible = false;
                textBoxCantidadEjemplares.Visible = false;
                labelCantidadEjemplares.Visible = false;
            }
        }

        public void InicializarLibro(int idLibro)
        {
            var libro = interfazNucleo.ObtenerLibro(idLibro);
            textBoxAutor.Text = libro.Autor;
            textBoxAñoPublicacion.Text = libro.AñoPublicacion;
            textBoxISBN.Text = libro.ISBN;
            textBoxTitulo.Text = libro.Titulo;
            textBoxBuscar.Text = libro.Titulo;
            button1_Click(this, null);
            /*SeleccionarFilaDeTablaTituloYAutor(libro.Titulo,libro.Autor);
            SeleccionarFilaDeTablaISBN(libro.ISBN);
            SeleccionarFilaDeTablaAñoPublicacion(libro.AñoPublicacion);*/
        }

        private DataGridViewRow SeleccionarFilaDeTablaTituloYAutor(string pTitulo,string pAutor)
        {
            DataGridViewRow dataGridViewRow = null;
            int n = 0;
            do
            {
                if (dataGridViewTituloYAutor.Rows[n].Cells[0].Value.ToString() == pTitulo && dataGridViewTituloYAutor.Rows[n].Cells[1].Value.ToString() == pAutor)
                {
                    dataGridViewTituloYAutor.Rows[n].Selected = true;
                    dataGridViewRow = dataGridViewTituloYAutor.Rows[n];
                }
                n = n + 1;
            } while (dataGridViewRow == null);
            return dataGridViewRow;
        }

        private DataGridViewRow SeleccionarFilaDeTablaISBN(string pISBN)
        {
            DataGridViewRow dataGridViewRow = null;
            int n = 0;
            do
            {
                if (dataGridViewISBN.Rows[n].Cells[0].Value.ToString() == pISBN)
                {
                    dataGridViewRow = dataGridViewTituloYAutor.Rows[n];
                }
                n++;
            } while (dataGridViewRow == null);
            return dataGridViewRow;
        }

        private DataGridViewRow SeleccionarFilaDeTablaAñoPublicacion(string pAñoPublicacion)
        {
            DataGridViewRow dataGridViewRow = null;
            int n = 0;
            do
            {
                if (dataGridViewAños.Rows[n].Cells[0].Value.ToString() == pAñoPublicacion)
                {
                    dataGridViewRow = dataGridViewTituloYAutor.Rows[n];
                }
                n++;
            } while (dataGridViewRow == null);
            return dataGridViewRow;
        }
        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxTitulo.Text) && !string.IsNullOrEmpty(textBoxAutor.Text) && !string.IsNullOrEmpty(textBoxISBN.Text) && !string.IsNullOrEmpty(textBoxAñoPublicacion.Text))
            {
                
                    ((ActualizarLibro)this.Owner).CargarDatosDeBusquedaAvanzada(textBoxTitulo.Text,textBoxAutor.Text,textBoxAñoPublicacion.Text,textBoxISBN.Text);
                    MessageBox.Show("Libro registrado con exito, el Id del libro es: " + new InterfazNucleo().ObtenerUltimoIdLibro());
                this.Hide();
                this.Owner.Show();
                    /*buttonBorrarDatos_Click(sender,e);  No es necesario ya que podria querer seguir cargando libros con el mismo titulo, incluso si me equivoque en la cantidad de ejemplares podria agregarlos sin volver a cargar todo.
                    dataGridViewAños.Rows.Clear();         
                    dataGridViewISBN.Rows.Clear();
                    dataGridViewTituloYAutor.Rows.Clear();
                    textBoxCantidadEjemplares.Clear();
                    textBoxBuscar.Clear();*/         
            }
            else
            {
                MessageBox.Show("Debe completar la informacion");
                textBoxTitulo.Focus();
            }
        }
    }
}
