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
    public partial class GestionarPrestamos : Form
    /*La finalidad de este formulario es permitir ver la informacion de todos los prestamos y poder modificarla*/
    {
        private string nombreUsuario { get; set; }//Aqui se almacena el nombre de usuario del administrador que esta usando el programa
        private FachadaNucleo interfazNucleo = new FachadaNucleo();//Instancia del nucleo del programa que nos permite acceder a las funciones del mismo
        private IBitacora bitacora = new Bitacora.ImplementacionBitacora();

        public GestionarPrestamos(string pNombreUsuario)//Constructor de la clase
        {
            InitializeComponent();
            nombreUsuario = pNombreUsuario;
            labelNombreUsuario.Text = "Usuario: " + nombreUsuario;
        }

        private void GestionarPrestamos_Load(object sender, EventArgs e)
        //carga los datos de la tabla de prestamos al iniciar el formulario
        {
            try
            {
                ObtenerPrestamos();
            }
            catch (Exception ex)
            {
                string texto = "Error GestionarPrestamos_Load: " + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(texto);
                MessageBox.Show(texto, "Ha ocurrido un error");
            }
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
            try
            {
                IEnumerable<Prestamo> prestamos = interfazNucleo.ObtenerPrestamos();//Obtenemos la lista de prestamos
                dataGridViewPrestamos.Rows.Clear();//Eliminamos todo el contenido de la tabla
                foreach (var item in prestamos)//Recorremos lcada elemento de la lista y lo agregamos a la tabla
                {

                    int n = dataGridViewPrestamos.Rows.Add();
                    dataGridViewPrestamos.Rows[n].Cells[1].Value = item.Id;
                    dataGridViewPrestamos.Rows[n].Cells[2].Value = item.nombreUsuario;
                    dataGridViewPrestamos.Rows[n].Cells[3].Value = interfazNucleo.ObtenerLibro(item.idLibro).Titulo;
                    dataGridViewPrestamos.Rows[n].Cells[4].Value = interfazNucleo.ObtenerLibro(item.idLibro).ISBN;
                    dataGridViewPrestamos.Rows[n].Cells[5].Value = item.FechaPrestamo;
                    dataGridViewPrestamos.Rows[n].Cells[6].Value = item.FechaLimite;
                    if (item.FechaDevolucion == null)
                    {
                        dataGridViewPrestamos.Rows[n].Cells[7].Value = item.ActualizarEstado().ToString();
                        if (dataGridViewPrestamos.Rows[n].Cells[7].Value.ToString() == "Retrasado")
                        {
                            dataGridViewPrestamos.Rows[n].DefaultCellStyle.BackColor = Color.Firebrick;
                            dataGridViewPrestamos.Rows[n].DefaultCellStyle.ForeColor = Color.White;
                        }
                        else if (dataGridViewPrestamos.Rows[n].Cells[7].Value.ToString() == "ProximoAVencer")
                        {
                            dataGridViewPrestamos.Rows[n].DefaultCellStyle.BackColor = Color.Yellow;
                            dataGridViewPrestamos.Rows[n].DefaultCellStyle.ForeColor = Color.Black;
                        }
                        else
                        {
                            dataGridViewPrestamos.Rows[n].DefaultCellStyle.BackColor = Color.YellowGreen;
                            dataGridViewPrestamos.Rows[n].DefaultCellStyle.ForeColor = Color.Black;
                        }
                    }
                    else
                    {
                        dataGridViewPrestamos.Rows[n].Cells[7].Value = "Devuelto";

                        dataGridViewPrestamos.Rows[n].Visible = false;
                    }

                }
            }
            catch (Exception ex)
            {
                string texto = "Error ObtenerPrestamos: " + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(texto);
                MessageBox.Show(texto, "Ha ocurrido un error");
            }
        }

        private void dataGridViewPrestamos_CellContentClick(object sender, DataGridViewCellEventArgs e)//Este evento se ejecuta si se hace click al contenido de una celda de la tabla
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewCell cell = (DataGridViewCell)dataGridViewPrestamos.Rows[e.RowIndex].Cells[e.ColumnIndex];

                    string estadoPrestamo = ((DataGridViewCell)dataGridViewPrestamos.Rows[e.RowIndex].Cells[7]).Value.ToString();
                    if (cell.Value.ToString() == "Devolucion" && estadoPrestamo != "Devuelto")//Si se presiona la celda con el texto Devolucion, se verifica que el prestamo no se haya devuelto y luego se abre una nueva ventana para registrar la devolucion del prestamo
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
            catch (Exception ex)
            {
                string texto = "Error dataGridViewPrestamos_CellContentClick: " + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(texto);
                MessageBox.Show(texto, "Ha ocurrido un error");
            }
        }

        private void checkBoxProximosAVencerse_CheckedChanged(object sender, EventArgs e)//Este metodo se ejecuara cuando se marque el checkBox heckBoxProximosAVencerse y permite que la tabla solo muestre los prestamos proximos a vencer
        {
            try
            {
                if (checkBoxProximosAVencerse.Checked == true && checkBoxRestrasados.Checked == false)
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
                else if (checkBoxProximosAVencerse.Checked == true && checkBoxRestrasados.Checked == true)
                {
                    for (int i = 0; i < dataGridViewPrestamos.Rows.Count - 1; i++)
                    {
                        if (dataGridViewPrestamos.Rows[i].Cells[7].Value.ToString() == "ProximoAVencer" || dataGridViewPrestamos.Rows[i].Cells[7].Value.ToString() == "Retrasado")
                        {
                            dataGridViewPrestamos.Rows[i].Visible = true;
                        }
                        else
                        {
                            dataGridViewPrestamos.Rows[i].Visible = false;
                        }
                    }
                }
                else if (checkBoxRestrasados.Checked == true)
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
                        if (dataGridViewPrestamos.Rows[i].Cells[7].Value.ToString() != "Devuelto")
                        {
                            dataGridViewPrestamos.Rows[i].Visible = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string texto = "Error checkBoxProximosAVencerse_CheckedChanged: " + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(texto);
                MessageBox.Show(texto, "Ha ocurrido un error");
            }
        }

        private void checkBoxRestrasados_CheckedChanged(object sender, EventArgs e)//Este metodo se ejecuara cuando se marque el checkBox chcheckBoxRestrasados_y permite que la tabla solo muestre los prestamos retrasados
        {
            try
            {
                if (checkBoxRestrasados.Checked == true && checkBoxProximosAVencerse.Checked == false)
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
                else if (checkBoxRestrasados.Checked == true && checkBoxProximosAVencerse.Checked == true)
                {
                    for (int i = 0; i < dataGridViewPrestamos.Rows.Count - 1; i++)
                    {
                        if (dataGridViewPrestamos.Rows[i].Cells[7].Value.ToString() == "Retrasado" || dataGridViewPrestamos.Rows[i].Cells[7].Value.ToString() == "ProximoAVencer")
                        {
                            dataGridViewPrestamos.Rows[i].Visible = true;
                        }
                        else
                        {
                            dataGridViewPrestamos.Rows[i].Visible = false;
                        }
                    }
                }
                else if (checkBoxProximosAVencerse.Checked == true)
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
                        if (dataGridViewPrestamos.Rows[i].Cells[7].Value.ToString() != "Devuelto")
                        {
                            dataGridViewPrestamos.Rows[i].Visible = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string texto = "Error checkBoxRestrasados_CheckedChanged: " + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(texto);
                MessageBox.Show(texto, "Ha ocurrido un error");
            }
        }

        private void textBoxUsuarioOTituloLibro_TextChanged(object sender, EventArgs e)//Se ejecutara cuando se modifique el texto del textbox textBoxUsuarioOTituloLibro
        {
            try
            {
                if (textBoxUsuarioOTituloLibro.Text != null)//se verifica que el textbox no este vacio
                {
                    for (int i = 0; i < dataGridViewPrestamos.Rows.Count - 1; i++)//recorremos las filas de la tabla
                    {
                        if (dataGridViewPrestamos.Rows[i].Cells[2].Value.ToString().ToLower().Contains(textBoxUsuarioOTituloLibro.Text.ToString().ToLower()))
                        {
                            dataGridViewPrestamos.Rows[i].Visible = true;//si 
                        }
                        else if (dataGridViewPrestamos.Rows[i].Cells[3].Value.ToString().ToLower().Contains(textBoxUsuarioOTituloLibro.Text.ToString().ToLower()) == false)
                        {
                            dataGridViewPrestamos.Rows[i].Visible = false;
                        }
                        else
                        {
                            dataGridViewPrestamos.Rows[i].Visible = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string texto = "Error textBoxUsuarioOTituloLibro_TextChanged: " + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(texto);
                MessageBox.Show(texto, "Ha ocurrido un error");
            }
        }

        private void checkDevueltos_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkDevueltos.Checked == true)
                {
                    checkBoxProximosAVencerse.Checked = false;
                    checkBoxRestrasados.Checked = false;
                    checkBoxProximosAVencerse.Visible = false;
                    checkBoxRestrasados.Visible = false;
                    labelFiltrar.Visible = false;
                    dataGridViewPrestamos.Columns[0].Visible = false;
                    for (int i = 0; i < dataGridViewPrestamos.Rows.Count - 1; i++)
                    {
                        if (dataGridViewPrestamos.Rows[i].Cells[7].Value.ToString() == "Devuelto")
                        {
                            dataGridViewPrestamos.Rows[i].Visible = true;
                        }
                        else
                        {
                            dataGridViewPrestamos.Rows[i].Visible = false;
                        }
                    }
                    labelNombreLista.Text = "Lista de prestamos devueltos";
                    checkDevueltos.Text = "Ver lista de prestamos activos";
                }
                else
                {

                    checkBoxProximosAVencerse.Visible = true;
                    checkBoxRestrasados.Visible = true;
                    dataGridViewPrestamos.Columns[0].Visible = true;
                    labelFiltrar.Visible = true;
                    labelNombreLista.Text = "Lista de prestamos activos";
                    for (int i = 0; i < dataGridViewPrestamos.Rows.Count - 1; i++)
                    {
                        if (dataGridViewPrestamos.Rows[i].Cells[7].Value.ToString() != "Devuelto")
                        {
                            dataGridViewPrestamos.Rows[i].Visible = true;
                        }
                        else
                        {
                            dataGridViewPrestamos.Rows[i].Visible = false;
                        }

                    }
                    checkDevueltos.Text = "Ver lista de prestamos devueltos";

                }
            }
            catch (Exception ex)
            {
                string texto = "Error checkDevueltos_CheckedChanged: " + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(texto);
                MessageBox.Show(texto, "Ha ocurrido un error");
            }
        }
    }
}
