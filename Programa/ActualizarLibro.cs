using Dominio;
using Nucleo;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Programa
{
    public partial class ActualizarLibro : Form
    {
        FachadaNucleo interfazNucleo = new FachadaNucleo();//Instancia de la fachada del nucleo para realizar operaciones dentro del dominio

        private int sumatoriaDeEjemplares { get; set; }//Varible que nos permite guardar las sumatoria de ejemplares que se esta agregando o restando.
        private int idLibro { get; set; }
        private string NombreUsuario { get; set; }
        public ActualizarLibro(string nombreUsuario, int pIdLibro)//Inicializamos los datos del administrador actual que se van a mostrar en la interfaz
        {
            InitializeComponent();
            NombreUsuario = nombreUsuario;
            labelNombreUsuario.Text = "Usuario: " + NombreUsuario;
            idLibro = pIdLibro;
            sumatoriaDeEjemplares = 0;//Inicializamos en 0.
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void buttonDeshacerCambios_Click(object sender, EventArgs e)
        {
            try
            {
            Libro libro = interfazNucleo.ObtenerLibro(Convert.ToInt32(idLibro));
            textBoxTitulo.Text = libro.Titulo;
            textBoxAutor.Text = libro.Autor;
            textBoxAñoPublicacion.Text = libro.AñoPublicacion;
            textBoxISBN.Text = libro.ISBN;
            buttonDeshacerCambios.Enabled = false;
            buttonGuardar.Enabled = false;
            }
            catch (Exception ex)
            {
                string texto= "Error buttonDeshacerCambios_Click: "+ ex.Message + ex.StackTrace;
                interfazNucleo.RegistrarLog(texto,"Ha ocurrido un error");
                MessageBox.Show();
            }
        }

        private void textBoxAutor_TextChanged(object sender, EventArgs e)
        {
            buttonDeshacerCambios.Enabled = true;
            buttonGuardar.Enabled = true;
        }

        private void textBoxTitulo_TextChanged(object sender, EventArgs e)
        {
            buttonDeshacerCambios.Enabled = true;
            buttonGuardar.Enabled = true;
        }

        private void textBoxISBN_TextChanged(object sender, EventArgs e)
        {
            buttonDeshacerCambios.Enabled = true;
            buttonGuardar.Enabled = true;
        }

        private void textBoxAñoPublicacion_TextChanged(object sender, EventArgs e)
        {
            buttonDeshacerCambios.Enabled = true;
            buttonGuardar.Enabled = true;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (interfazNucleo.ObtenerLibro(idLibro).Baja == false && checkBoxBaja.Checked == true)//En el caso de que el libro no este dado de baja y el checkbox este tildado hace lo siguiente.
            {
                if (!string.IsNullOrEmpty(textBoxTitulo.Text) && !string.IsNullOrEmpty(textBoxAutor.Text) && !string.IsNullOrEmpty(textBoxISBN.Text) && !string.IsNullOrEmpty(textBoxAñoPublicacion.Text))//Si no hay compos vacios
                {
                    interfazNucleo.ActualizarLibro(idLibro, textBoxISBN.Text, textBoxTitulo.Text, textBoxAutor.Text, textBoxAñoPublicacion.Text);//Actualiza el libro
                    interfazNucleo.DarDeBajaUnLibro(idLibro);//Da de baja el libro.
                    MessageBox.Show("El libro Id:" + idLibro + " ha sido dado de baja exitosamente!");//Mensaje informativo al administrador
                }
                else//En el caso que falte completar algun dato.
                {
                    MessageBox.Show("Debe completar la informacion");//Mensaje informativo al administrador
                    textBoxTitulo.Focus();
                }
            }
            else if (interfazNucleo.ObtenerLibro(idLibro).Baja == true && checkBoxBaja.Checked == false)//En el caso que este dado de baja pero este deschekeado el textbox hace lo siguiente.
            {
                if (!string.IsNullOrEmpty(textBoxTitulo.Text) && !string.IsNullOrEmpty(textBoxAutor.Text) && !string.IsNullOrEmpty(textBoxISBN.Text) && !string.IsNullOrEmpty(textBoxAñoPublicacion.Text))//Verifica que ningun campo este vacio.
                {
                    interfazNucleo.DarDeAltaUnLibro(idLibro);//Da de alta al libro.
                    interfazNucleo.ActualizarLibro(idLibro, textBoxISBN.Text, textBoxTitulo.Text, textBoxAutor.Text, textBoxAñoPublicacion.Text);//Actualiza el libro
                    if (sumatoriaDeEjemplares < 0)//Si el valor de la sumatoria de ejemplares da negativo elimina los ejemplares tomando su valor absoluto.
                    {
                        interfazNucleo.EliminarEjemplaresDeUnLibro(idLibro, Math.Abs(sumatoriaDeEjemplares));
                    }
                    if (sumatoriaDeEjemplares >= 0)//Si el valor de la sumatoria de ejemplares da positivo agrega los ejemplares.
                    {
                        interfazNucleo.AñadirEjemplares(idLibro, sumatoriaDeEjemplares);
                    }
                    MessageBox.Show("El libro Id:" + idLibro + " a sido dado de alta y se ha actualizado exitosamente!");//Mensaje informativo al administrador
                }
                else//En el caso que falte completar algun dato.
                {
                    MessageBox.Show("Debe completar la informacion");//Mensaje informativo al administrador
                    textBoxTitulo.Focus();
                }
            }
            else if (interfazNucleo.ObtenerLibro(idLibro).Baja == false && checkBoxBaja.Checked == false)//En el caso en que no este dado de baja y este checkeado hace lo siguiente.
            {
                if (!string.IsNullOrEmpty(textBoxTitulo.Text) && !string.IsNullOrEmpty(textBoxAutor.Text) && !string.IsNullOrEmpty(textBoxISBN.Text) && !string.IsNullOrEmpty(textBoxAñoPublicacion.Text))//Verifica que ningun campo este vacio.
                {
                    interfazNucleo.ActualizarLibro(idLibro, textBoxISBN.Text, textBoxTitulo.Text, textBoxAutor.Text, textBoxAñoPublicacion.Text);//Actualiza el libro
                    if (sumatoriaDeEjemplares < 0)//Si el valor de la sumatoria de ejemplares da negativo elimina los ejemplares tomando su valor absoluto.
                    {
                        interfazNucleo.EliminarEjemplaresDeUnLibro(idLibro, Math.Abs(sumatoriaDeEjemplares));
                    }
                    else if (sumatoriaDeEjemplares >= 0)//Si el valor de la sumatoria de ejemplares da positivo agrega los ejemplares.
                    {
                        interfazNucleo.AñadirEjemplares(idLibro, sumatoriaDeEjemplares);
                    }
                    MessageBox.Show("El libro Id:" + idLibro + " se ha actualizado exitosamente!");//Mensaje informativo al administrador
                }
                else//En el caso que falte completar algun dato.
                {
                    MessageBox.Show("Debe completar la informacion");//Mensaje informativo al administrador
                    textBoxTitulo.Focus();
                }
            }
            else if (interfazNucleo.ObtenerLibro(idLibro).Baja == true && checkBoxBaja.Checked == true)//Si el liro esta dado de baja el checkbox esta tildado hace lo siguiente.
            {
                if (!string.IsNullOrEmpty(textBoxTitulo.Text) && !string.IsNullOrEmpty(textBoxAutor.Text) && !string.IsNullOrEmpty(textBoxISBN.Text) && !string.IsNullOrEmpty(textBoxAñoPublicacion.Text))//Verifica que ningun campo este vacio.
                {
                    interfazNucleo.ActualizarLibro(idLibro, textBoxISBN.Text, textBoxTitulo.Text, textBoxAutor.Text, textBoxAñoPublicacion.Text);//Actualiza el libro
                    MessageBox.Show("El libro Id:" + idLibro + " ha sido actualizado correctamente!");//Mensaje informativo al administrador
                }
                else
                {
                    MessageBox.Show("Debe completar la informacion");//Mensaje informativo al administrador
                    textBoxTitulo.Focus();
                }
            }
            this.Hide();//Esta ventana se oculta y se muestra el owner(GestionarLibros).
            ((GestionarLibros)this.Owner).ObtenerLibros();
            this.Owner.Show();
            }
            catch (Exception ex)
                {
                string texto= "Error al actualizar libro: "+ ex.Message + ex.StackTrace;
                interfazNucleo.RegistrarLog(texto,"Ha ocurrido un error");
                MessageBox.Show();
                }
        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void ActualizarLibro_Load(object sender, EventArgs e)
        {
        }

        private void labelNombreUsuario_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ActualizarLibro_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonBusquedaAvanzada_Click(object sender, EventArgs e)//Botton que nos permite ir al buscador por medio de la api libros, permitiendonos modificar de manera mas rapida el libro.
        {
            try
            {
            RegistrarLibro ventana = new RegistrarLibro(NombreUsuario);
            this.Hide();
            ventana.InicializarLibro(idLibro);//Carga los datos del libro en la nueva ventana.
            ventana.Show(this);
            }
            catch (Exception ex)
                {
                string texto= "Error buttonBusquedaAvanzada_Click: "+ ex.Message + ex.StackTrace;
                interfazNucleo.RegistrarLog(texto,"Ha ocurrido un error");
                MessageBox.Show();
                }
        }

        public void CargarDatosDeBusquedaAvanzada(string pTitulo, string pAutor, string pAñoPublicacion, string pISBN)//Se encarga traer los datos actualizados de la ventana del metodo anterior.
        {
            textBoxAutor.Text = pAutor;
            textBoxAñoPublicacion.Text = pAñoPublicacion;
            textBoxISBN.Text = pISBN;
            textBoxTitulo.Text = pTitulo;
        }

        private void textBoxCantEjemplares_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        public void InicializarLibro(string pISBN, string pTitulo, string pAutor, string pAñoPublicacion, string pBaja)//Se encarga de cargar los datos del libro en la ventana actual.
        {
            try
            {
            textBoxTitulo.Text = pTitulo;
            textBoxISBN.Text = pISBN;
            textBoxAutor.Text = pAutor;
            textBoxAñoPublicacion.Text = pAñoPublicacion;
            labelCantidadActual.Text = "Cantidad Actual: " + interfazNucleo.ObtenerEjemplaresDisponibles(idLibro).Count().ToString();//Para mostrar la cantidad actual cuenta la cantidad de ejemplares que estan diponibles.(Aquellos en un prestamo no pueden ser eliminados)
            if (pBaja == "True")//Si esta dado de baja se tilda el checkbox
            {
                checkBoxBaja.Checked = true;
            }
            }
            catch (Exception ex)
                {
                string texto= "Error InicializarLibro: "+ ex.Message + ex.StackTrace;
                interfazNucleo.RegistrarLog(texto,"Ha ocurrido un error");
                MessageBox.Show();
                }
        }

        private void buttonAñadirEjemplares_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBoxAñadirEjemplares.Text))//Si el textbox relacionado a añadir ejemplares no esta vacio entonces:
            {
                sumatoriaDeEjemplares += Convert.ToInt32(textBoxAñadirEjemplares.Text);//Agrega a la sumatoria la cantidad cargada.
                labelCantidadActual.Text = "Cantidad Actual: " + Convert.ToString(interfazNucleo.ObtenerEjemplaresDisponibles(idLibro).Count() + sumatoriaDeEjemplares);//Actualiza la cantidad actual(Explicado en el metodo InicializarLibro)
                textBoxAñadirEjemplares.Text = "";
            }
            else
            {
                labelErrorAñadirEjemplares.Text = "Error,campo vacio";//Label informativo para el administrador.
                labelErrorAñadirEjemplares.Visible = true;
            }
            }
            catch (Exception ex)
                {
                string texto= "Error buttonAñadirEjemplares_Click: "+ ex.Message + ex.StackTrace;
                interfazNucleo.RegistrarLog(texto,"Ha ocurrido un error");
                MessageBox.Show();
                }
        }

        private void buttonEliminarEjemplares_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBoxEliminarEjemplares.Text))
            {
                if (interfazNucleo.ObtenerEjemplaresDisponibles(idLibro).Count() + sumatoriaDeEjemplares >= Convert.ToInt32(textBoxEliminarEjemplares.Text))//Si la cantidad de ejemplares a eliminar es menor o igual ala cantidad actual entonces hace lo siguiente:
                {
                    sumatoriaDeEjemplares = sumatoriaDeEjemplares - Convert.ToInt32(textBoxEliminarEjemplares.Text);//Se resta a la sumatoria la cantidad a eliminar.
                    labelCantidadActual.Text = "Cantidad Actual: " + Convert.ToString(interfazNucleo.ObtenerEjemplaresDisponibles(idLibro).Count() + sumatoriaDeEjemplares);//Actualiza la cantidad actual(Explicado en el metodo InicializarLibro)
                    textBoxEliminarEjemplares.Text = "";
                }
                else
                {
                    sumatoriaDeEjemplares = -interfazNucleo.ObtenerEjemplaresDisponibles(idLibro).Count();//En caso contrario asigna a la sumatoria el valor negativo maximo posible que es la cantidad disponible de ejemplares (No puede ser un numero negativo menor a este).
                    MessageBox.Show("El valor ingresado es mayor a la cantidad total actual, se establecera el valor cero por defecto.");//Mensaje informativo para el administrador.
                    labelCantidadActual.Text = "Cantidad Actual: 0";//Se le da el valor 0 a la cantidad actual (Por defecto).
                    textBoxEliminarEjemplares.Text = "";
                }
            }
            else
            {
                labelErrorEliminarEjemplares.Text = "Error,campo vacio";//Label informativo para el administrador.
                labelErrorEliminarEjemplares.Visible = true;
            }
            }
            catch (Exception ex)
                {
                string texto= "Error buttonEliminarEjemplares_Click: "+ ex.Message + ex.StackTrace;
                interfazNucleo.RegistrarLog(texto,"Ha ocurrido un error");
                MessageBox.Show();
                }
        }

        private void checkBoxBaja_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBoxBaja.Checked == true)//Si el checkbox esta tildado entonces hace lo siguiente:
            {
                if (interfazNucleo.ObtenerEjemplaresDisponibles(idLibro).Count() != interfazNucleo.ObtenerEjemplaresTotales(idLibro).Count() && interfazNucleo.ObtenerEjemplaresDisponibles(idLibro).Count() != 0 && interfazNucleo.ObtenerEjemplaresDisponibles(idLibro).Count() != 0)//En el caso en que la cantidad disponible sea menor a la cantidad total, no puede darse de baja ya que esto nos quiere decir que hay un prestamo activo.
                {
                    checkBoxBaja.Checked = false;
                    MessageBox.Show("El libro Id:" + idLibro + " no puede darse de baja ya que tiene prestamos pendientes!, intentelo mas tarde");//Mensaje informativo para el administrador.
                }
                else//En caso contrario descativa todas las opciones de la ventana.
                {
                    textBoxAutor.Enabled = false;
                    textBoxTitulo.Enabled = false;
                    textBoxISBN.Enabled = false;
                    textBoxAutor.Enabled = false;
                    textBoxAñoPublicacion.Enabled = false;
                    textBoxAñadirEjemplares.Enabled = false;
                    textBoxEliminarEjemplares.Enabled = false;
                    buttonAñadirEjemplares.Enabled = false;
                    buttonDeshacerCambios.Enabled = false;
                    buttonEliminarEjemplares.Enabled = false;
                    buttonBusquedaAvanzada.Enabled = false;
                    labelCantidadActual.Text = "Cantidad Actual: 0";//Coloca la cantidad actual en 0.
                }
            }

            else if (checkBoxBaja.Checked == false)//En caso contrario permite acceder a todas las opciones de la ventana.
            {
                {
                    textBoxAutor.Enabled = true;
                    textBoxTitulo.Enabled = true;
                    textBoxISBN.Enabled = true;
                    textBoxAutor.Enabled = true;
                    textBoxAñoPublicacion.Enabled = true;
                    textBoxAñadirEjemplares.Enabled = true;
                    textBoxEliminarEjemplares.Enabled = true;
                    buttonAñadirEjemplares.Enabled = true;
                    buttonDeshacerCambios.Enabled = true;
                    buttonEliminarEjemplares.Enabled = true;
                    buttonBusquedaAvanzada.Enabled = true;
                    labelCantidadActual.Text = "Cantidad Actual: " + Convert.ToString(interfazNucleo.ObtenerEjemplaresDisponibles(idLibro).Count());
                }
            }
            }
            catch (Exception ex)
                {
                string texto= "Error checkBoxBaja_CheckedChanged: "+ ex.Message + ex.StackTrace;
                interfazNucleo.RegistrarLog(texto,"Ha ocurrido un error");
                MessageBox.Show();
                }
        }

        private void textBoxEliminarEjemplares_TextChanged(object sender, EventArgs e)
        {
            labelErrorEliminarEjemplares.Visible = false;
        }

        private void textBoxAñadirEjemplares_TextChanged(object sender, EventArgs e)
        {
            labelErrorAñadirEjemplares.Visible = false;
        }

        private void labelCantidadActual_Click(object sender, EventArgs e)
        {

        }
    }
}

