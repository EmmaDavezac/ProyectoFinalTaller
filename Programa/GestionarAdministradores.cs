using Dominio;
using Nucleo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Bitacora;

namespace Programa
{
    public partial class GestionarAdministradores : Form
    /*La finalidad de este formulario es permitir ver la informacion de todos los administradores y poder modificarla*/
    {
        private string nombreUsuario { get; set; }//Aqui se almacena el nombre de usuario del administrador que esta usando el programa
        private FachadaNucleo interfazNucleo = new FachadaNucleo();//Instancia del nucleo del programa que nos permite acceder a las funciones del mismo
        private IBitacora bitacora = new Bitacora.Bitacora();

        public GestionarAdministradores(string pNombreUsuario)//Constructor de la clase
        {
            InitializeComponent();
            nombreUsuario = pNombreUsuario;
            labelNombreUsuario.Text = "Usuario: " + nombreUsuario;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBoxId_TextChanged(object sender, EventArgs e)//Este evento se ejecuta cuando se modifica el texto del textbox textBoxId
        {
            try
            {
                if (textBoxNombreUsuario.Text != null)//Se verifica que el textbox tenga algun texto para ejecutar la busqueda
            {
                for (int i = 0; i < dataGridViewAdministradores.Rows.Count - 1; i++)//Recorremos todos los elementos de la tabla dataGridViewAdministradores
                {
                    if (dataGridViewAdministradores.Rows[i].Cells[1].Value.ToString().Contains(textBoxNombreUsuario.Text.ToString()) == false)
                    {
                        dataGridViewAdministradores.Rows[i].Visible = false;//Si el termino de busqueda eno es subcadena del nombre de usuario del elemento, se oculta el elemento en la tabla
                    }
                    else
                    {
                        dataGridViewAdministradores.Rows[i].Visible = true;//Si el termino de busqueda es subcadena del nombre de usuario del elemento, se muestra el elemento en la tabla
                    }
                }
            }
            }
            catch (Exception ex)
            {
                string texto= "Error textBoxId_TextChanged: "+ ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(texto);
                MessageBox.Show(texto, "Ha ocurrido un error");
            }
        }

        private void botonVolver_Click(object sender, EventArgs e)//Este evento se ejecuta cuando se presiona el boton botonVolver
        {
            this.Hide();//Se oculta el formulario 
            this.Owner.Show();//Se muestra el formulario padre
        }

        private void ConsultarAdministrador_FormClosed(object sender, FormClosedEventArgs e)//Este evento se ejecuta cuando se cierra el formulario
        {
            this.Hide();//Se oculta el formulario 
            this.Owner.Show();//Se muestra el formulario padre
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

        private void ConsultarAdministrador_Load(object sender, EventArgs e)
        {
            ObtenerAdministradores();
        }

        private void textBoxApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridViewAdministradores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
            {
                DataGridViewCell cell = (DataGridViewCell)dataGridViewAdministradores.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value.ToString() == "Edit")
                {
                    ActualizarAdministrador ventana = new ActualizarAdministrador(nombreUsuario);
                    ventana.CargarAdministradorExistente(dataGridViewAdministradores.Rows[e.RowIndex].Cells[1].Value.ToString(), dataGridViewAdministradores.Rows[e.RowIndex].Cells[7].Value.ToString());
                    this.Hide();
                    ventana.Show(this);
                }
            }
            }
            catch (Exception ex)
            {
                string texto= "Error dataGridViewAdministradores_CellContentClick: "+ ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(texto);
                MessageBox.Show(texto, "Ha ocurrido un error");
            }
        }

        public void ObtenerAdministradores()//Este metodo carga la lista de administradores en la tabla dataGridViewAdministradores
        {
            try
            {
                IEnumerable<UsuarioAdministrador> administradores = interfazNucleo.ObtenerAdministradores();
            dataGridViewAdministradores.Rows.Clear();
            foreach (var item in administradores)
            {
                int n = dataGridViewAdministradores.Rows.Add();
                dataGridViewAdministradores.Rows[n].Cells[1].Value = item.NombreUsuario;
                dataGridViewAdministradores.Rows[n].Cells[2].Value = item.Nombre;
                dataGridViewAdministradores.Rows[n].Cells[3].Value = item.Apellido;
                dataGridViewAdministradores.Rows[n].Cells[4].Value = item.FechaNacimiento.ToShortDateString();
                dataGridViewAdministradores.Rows[n].Cells[5].Value = item.Mail;
                dataGridViewAdministradores.Rows[n].Cells[6].Value = item.Telefono;
                dataGridViewAdministradores.Rows[n].Cells[7].Value = item.Baja.ToString();
                if (item.Baja == true)
                {
                    dataGridViewAdministradores.Rows[n].DefaultCellStyle.BackColor = Color.Firebrick;
                    dataGridViewAdministradores.Rows[n].DefaultCellStyle.ForeColor = Color.White;
                }
            }
            }
            catch (Exception ex)
            {
                string texto= "Error ObtenerAdministradores: "+ ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(texto);
                MessageBox.Show(texto, "Ha ocurrido un error");
            }
        }

        private void buttonRefrescar_Click(object sender, EventArgs e)//Este evento se ejecuta cuando se presiona el boton buttonRefrescar
        {   try
                {
                ObtenerAdministradores();//Se actualiza la tabla deadministradores 
                }
            catch (Exception ex)
                {
                    string texto= "Error buttonRefrescar_Click: "+ ex.Message + ex.StackTrace;
                    bitacora.RegistrarLog(texto);
                    MessageBox.Show(texto, "Ha ocurrido un error");
                } 
        }

        private void labelErro_Click(object sender, EventArgs e)
        {

        }
    }
}

