using Nucleo;
using System;
using System.Windows.Forms;

namespace Programa
{
    public partial class EditarPrestamo : Form
    /*Este formulario tiene la finalidad de permitir la edicion de un prestamo(estara disponible solo para versiones de prueba, 
    para demostrar el buen funcionamiento del programa)*/
    {
        private int idPrestamo;//Atributo que almacena el id de un prestamo
        private FachadaNucleo interfazNucleo = new FachadaNucleo();//Instancia del nucleo del programa,  nos permite usar las funciones del mismo
        public EditarPrestamo()//Constructor de la clase
        {
            
            InitializeComponent();
        }

        private void EditarPrestamo_Load(object sender, EventArgs e)//Este metodo se ejecuta antes de que se abra el formulario
        {
        }
        

        private void buttonModificarFechas_Click(object sender, EventArgs e)//Este evento se ejecuta cuando se presiona el boton buttonModificarFechas
        {
           try
           {
            interfazNucleo.ModificarFechasPrestamo(idPrestamo, textBoxFechaPrestamo.Text, textBoxFechaLimite.Text);//Se modifican las fechas del prestamo
            ((GestionarPrestamos)this.Owner).ObtenerPrestamos();//Se actualiza la lista de prestamos en el formulario padre
            this.Close();//Se cierra este formulario y se vuelve al formulario padre
           }
           catch (Exception ex)
            {
                string texto= "Error buttonModificarFechas_Click: "+ ex.Message + ex.StackTrace;
                interfazNucleo.RegistrarLog(texto);
                MessageBox.Show(texto, "Ha ocurrido un error");
            }
        }

        private void buttonVolver_Click(object sender, EventArgs e)//Este evento se ejecuta cuando se presiona el boton buttonVolver
        {
            this.Close();//Se cierra este formulario y se vuelve al formulario padre
        }

        internal void InicialiarEditarPrestamo(int pIdPrestamo, string pFechaPrestamo, string pFechaLimite)
        {
            try
            {
            textBoxFechaPrestamo.Text = pFechaPrestamo;
            textBoxFechaLimite.Text = pFechaLimite;
            idPrestamo = pIdPrestamo;
            }
            catch (Exception ex)
            {
                string texto= "Error InicialiarEditarPrestamo: "+ ex.Message + ex.StackTrace;
                interfazNucleo.RegistrarLog(texto);
                MessageBox.Show(texto, "Ha ocurrido un error");
            }
        }
    }
}
