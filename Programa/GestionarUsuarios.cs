using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Dominio;
using Nucleo;

namespace Programa
{
    public partial class GestionarUsuarios : Form
     /*La finalidad de este formulario es permitir ver la informacion de todos los usuarios simples y poder modificarla*/
    {
         private string nombreUsuario { get; set; }//Aqui se almacena el nombre de usuario del administrador que esta usando el programa
        private FachadaNucleo interfazNucleo = new FachadaNucleo();//Instancia del nucleo del programa que nos permite acceder a las funciones del mismo
       
        public GestionarUsuarios(string pNombreUsuario)//Constructor de la clase
        {
            InitializeComponent();
            nombreUsuario = pNombreUsuario;
            labelNombreUsuario.Text = "Usuario: " + nombreUsuario;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxId_TextChanged(object sender, EventArgs e)//este evento se ejecuta cuando se modifica el texto de textBoxId y nos permite buscar un usuario escribiendo su nombre de usuario
        {
            if (textBoxNombreUsuario.Text != null)
            {
                for (int i = 0; i < dataGridViewUsuarios.Rows.Count - 1; i++)
                {
                    if (dataGridViewUsuarios.Rows[i].Cells[1].Value.ToString().Contains(textBoxNombreUsuario.Text.ToString()) == false)
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

        private void botonVolver_Click(object sender, EventArgs e)//este evento se ejecutara cuando se presione el boton botonVolver
        {
            this.Hide();//la ventana se oculta
            this.Owner.Show();//se muestra la ventana padre
        }

        private void ConsultarUsuario_FormClosed(object sender, FormClosedEventArgs e)//este evento se ejecutara cuando se cierre el formulario
        {
             this.Hide();//la ventana se oculta
            this.Owner.Show();//se muestra la ventana padre
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void ConsultarUsuario_Load(object sender, EventArgs e)
        {
            ObtenerUsuarios();
        }

        private void textBoxApellido_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void ObtenerUsuarios()//Este metodo carga la lista de usuario en la tabla
        {
            IEnumerable<UsuarioSimple> usuarios = interfazNucleo.ObtenerUsuarios();//se le solicita la lista de usuarios al Nucleo del programa y se la almacena
            dataGridViewUsuarios.Rows.Clear();//limpiamos el contenido de la tabla
            foreach (var item in usuarios)//recorremos cada item de la lista y lo agregamos a la tabla
            {
                int n = dataGridViewUsuarios.Rows.Add();
                dataGridViewUsuarios.Rows[n].Cells[1].Value = item.NombreUsuario;
                dataGridViewUsuarios.Rows[n].Cells[2].Value = item.Scoring;
                dataGridViewUsuarios.Rows[n].Cells[2].Style.Font = new Font(dataGridViewUsuarios.Font, FontStyle.Bold); 
                if (item.Scoring >= 0)
                {
                    dataGridViewUsuarios.Rows[n].Cells[2].Style.ForeColor = Color.GreenYellow;
                }
                else
                {
                    dataGridViewUsuarios.Rows[n].Cells[2].Style.ForeColor = Color.Red;
                }
                dataGridViewUsuarios.Rows[n].Cells[3].Value = item.Nombre;
                dataGridViewUsuarios.Rows[n].Cells[4].Value = item.Apellido;
                dataGridViewUsuarios.Rows[n].Cells[5].Value = item.FechaNacimiento.ToShortDateString(); 
                dataGridViewUsuarios.Rows[n].Cells[6].Value = item.Mail;
                dataGridViewUsuarios.Rows[n].Cells[7].Value = item.Telefono;
                dataGridViewUsuarios.Rows[n].Cells[8].Value = item.Baja.ToString();
                if (item.Baja == true)
                {
                    dataGridViewUsuarios.Rows[n].DefaultCellStyle.BackColor = Color.Red;
                    dataGridViewUsuarios.Rows[n].DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }

        private void dataGridViewUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)//este metodo se ejecuta cuando se hace click a una celda de la tabla
        {
            if (e.RowIndex>=0)
            {

                DataGridViewCell cell = (DataGridViewCell)dataGridViewUsuarios.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value.ToString() == "Edit")//si le presiona la celda de la fila con el texto edit, se abre una ventana para modificar la informacion de ese usuario
                {
                    ActualizarUsuario ventana = new ActualizarUsuario(nombreUsuario);
                    ventana.CargarUsuarioExistente(dataGridViewUsuarios.Rows[e.RowIndex].Cells[1].Value.ToString(), dataGridViewUsuarios.Rows[e.RowIndex].Cells[8].Value.ToString());
                    this.Hide();
                    ventana.Show(this);
                } 
            }
        }

        private void labelErro_Click(object sender, EventArgs e)
        {

        }

        private void labelNombreUsuario_Click(object sender, EventArgs e)
        {

        }

        private void usuarioSimpleBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
