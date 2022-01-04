using Dominio;
using Nucleo;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Programa
{
    public partial class ActualizarLibro : Form
    {
        InterfazNucleo interfazNucleo = new InterfazNucleo();

        private int sumatoriaDeEjemplares { get; set; }
        private int idLibro { get; set; }
        private string NombreUsuario { get; set; }
        public ActualizarLibro(string nombreUsuario, int pIdLibro)
        {
            InitializeComponent();
            NombreUsuario = nombreUsuario;
            labelNombreUsuario.Text = "Usuario: " + NombreUsuario;
            idLibro = pIdLibro;
            sumatoriaDeEjemplares = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void buttonBorrarCambios_Click(object sender, EventArgs e)
        {
            Libro libro = interfazNucleo.ObtenerLibro(Convert.ToInt32(idLibro));

            textBoxTitulo.Text = libro.Titulo;
            textBoxAutor.Text = libro.Autor;
            textBoxAñoPublicacion.Text = libro.AñoPublicacion;
            textBoxISBN.Text = libro.ISBN;
            buttonDeshacerCambios.Enabled = false;
            buttonGuardar.Enabled = false;
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
            if (interfazNucleo.ObtenerLibro(idLibro).Baja == false && checkBoxBaja.Checked == true)
            {
                if (!string.IsNullOrEmpty(textBoxTitulo.Text) && !string.IsNullOrEmpty(textBoxAutor.Text) && !string.IsNullOrEmpty(textBoxISBN.Text) && !string.IsNullOrEmpty(textBoxAñoPublicacion.Text))
                {
                    interfazNucleo.ActualizarLibro(idLibro, textBoxISBN.Text, textBoxTitulo.Text, textBoxAutor.Text, textBoxAñoPublicacion.Text);
                    interfazNucleo.DarDeBajaUnLibro(idLibro);
                    MessageBox.Show("El libro Id:" + idLibro + " ha sido dado de baja exitosamente!");
                }
                else
                {
                    MessageBox.Show("Debe completar la informacion");
                    textBoxTitulo.Focus();
                }
            }
            else if (interfazNucleo.ObtenerLibro(idLibro).Baja == true && checkBoxBaja.Checked == false)
            {
                if (!string.IsNullOrEmpty(textBoxTitulo.Text) && !string.IsNullOrEmpty(textBoxAutor.Text) && !string.IsNullOrEmpty(textBoxISBN.Text) && !string.IsNullOrEmpty(textBoxAñoPublicacion.Text))
                {
                    interfazNucleo.DarDeAltaUnLibro(idLibro);
                    interfazNucleo.ActualizarLibro(idLibro, textBoxISBN.Text, textBoxTitulo.Text, textBoxAutor.Text, textBoxAñoPublicacion.Text);
                    if (sumatoriaDeEjemplares < 0)
                    {
                        interfazNucleo.EliminarEjemplaresDeUnLibro(idLibro, sumatoriaDeEjemplares);
                    }
                    if (sumatoriaDeEjemplares > 0)
                    {
                        interfazNucleo.AñadirEjemplares(idLibro, sumatoriaDeEjemplares);
                    }
                    MessageBox.Show("El libro Id:" + idLibro + " a sido dado de alta y se ha actualizado exitosamente!");
                }
                else
                {
                    MessageBox.Show("Debe completar la informacion");
                    textBoxTitulo.Focus();
                }
            }
            else if (interfazNucleo.ObtenerLibro(idLibro).Baja == false && checkBoxBaja.Checked == false)
            {
                if (!string.IsNullOrEmpty(textBoxTitulo.Text) && !string.IsNullOrEmpty(textBoxAutor.Text) && !string.IsNullOrEmpty(textBoxISBN.Text) && !string.IsNullOrEmpty(textBoxAñoPublicacion.Text))
                {
                    interfazNucleo.ActualizarLibro(idLibro, textBoxISBN.Text, textBoxTitulo.Text, textBoxAutor.Text, textBoxAñoPublicacion.Text);
                    if (sumatoriaDeEjemplares < 0)
                    {
                        interfazNucleo.EliminarEjemplaresDeUnLibro(idLibro, sumatoriaDeEjemplares);
                    }
                    if (sumatoriaDeEjemplares > 0)
                    {
                        interfazNucleo.AñadirEjemplares(idLibro, sumatoriaDeEjemplares);
                    }
                    MessageBox.Show("El libro Id:" + idLibro + " se ha actualizado exitosamente!");
                }
                else
                {
                    MessageBox.Show("Debe completar la informacion");
                    textBoxTitulo.Focus();
                }
            }
            else if (interfazNucleo.ObtenerLibro(idLibro).Baja == true && checkBoxBaja.Checked == true)
            {
                if (!string.IsNullOrEmpty(textBoxTitulo.Text) && !string.IsNullOrEmpty(textBoxAutor.Text) && !string.IsNullOrEmpty(textBoxISBN.Text) && !string.IsNullOrEmpty(textBoxAñoPublicacion.Text))
                {
                    interfazNucleo.ActualizarLibro(idLibro, textBoxISBN.Text, textBoxTitulo.Text, textBoxAutor.Text, textBoxAñoPublicacion.Text);
                    interfazNucleo.DarDeBajaUnLibro(idLibro);
                    MessageBox.Show("El libro Id:" + idLibro + " ha sido dado de baja exitosamente!");
                }
                else
                {
                    MessageBox.Show("Debe completar la informacion");
                    textBoxTitulo.Focus();
                }
            }
            this.Hide();
            ((GestionarLibros)this.Owner).ObtenerLibros();
            this.Owner.Show();
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

        private void buttonEnAPI_Click(object sender, EventArgs e)
        {
            RegistrarLibro ventana = new RegistrarLibro(NombreUsuario);
            this.Hide();
            ventana.InicializarLibro(idLibro);
            ventana.Show(this);
        }

        public void CargarDatosDeBusquedaAvanzada(string pTitulo, string pAutor, string pAñoPublicacion, string pISBN)
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

        public void InicializarLibro(string pISBN, string pTitulo, string pAutor, string pAñoPublicacion, string pDisponible)
        {
            textBoxTitulo.Text = pTitulo;
            textBoxISBN.Text = pISBN;
            textBoxAutor.Text = pAutor;
            textBoxAñoPublicacion.Text = pAñoPublicacion;
            labelCantidadActual.Text = "Cantidad Actual: " + interfazNucleo.ObtenerEjemplaresTotales(idLibro).Count().ToString();
            if (pDisponible == "True")
            {
                checkBoxBaja.Checked = true;
            }
        }

        private void buttonAñadirEjemplares_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxAñadirEjemplares.Text))
            {
                sumatoriaDeEjemplares = sumatoriaDeEjemplares + Convert.ToInt32(textBoxAñadirEjemplares.Text);
                labelCantidadActual.Text = "Cantidad Actual: " + Convert.ToString(interfazNucleo.ObtenerEjemplaresEnBuenEstadoLibro(idLibro).Count() + sumatoriaDeEjemplares);
                textBoxAñadirEjemplares.Text = "";
            }
            else
            {
                labelErrorAñadirEjemplares.Text = "Error,campo vacio";
                labelErrorAñadirEjemplares.Visible = true;
            }
        }

        private void buttonEliminarEjemplares_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxEliminarEjemplares.Text))
            {
                sumatoriaDeEjemplares = sumatoriaDeEjemplares - Convert.ToInt32(textBoxEliminarEjemplares.Text);
                labelCantidadActual.Text = "Cantidad Actual: " + Convert.ToString(interfazNucleo.ObtenerEjemplaresEnBuenEstadoLibro(idLibro).Count() + sumatoriaDeEjemplares);
                textBoxEliminarEjemplares.Text = "";
            }
            else
            {
                labelErrorEliminarEjemplares.Text = "Error,campo vacio";
                labelErrorEliminarEjemplares.Visible = true;
            }
        }

        private void checkBoxBaja_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBaja.Checked == true)
            {
                if (interfazNucleo.ObtenerEjemplaresDisponibles(idLibro).Count() != interfazNucleo.ObtenerEjemplaresTotales(idLibro).Count() && interfazNucleo.ObtenerEjemplaresDisponibles(idLibro).Count() != 0 && interfazNucleo.ObtenerEjemplaresDisponibles(idLibro).Count() != 0)
                {
                    checkBoxBaja.Checked = false;
                    MessageBox.Show("El libro Id:" + idLibro + " no puede darse de baja ya que tiene prestamos pendientes!, intentelo mas tarde");
                }
                else
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
                    buttonBusquedaEnAPI.Enabled = false;
                    labelCantidadActual.Text = "Cantidad Actual: 0";
                }
            }

            else if (checkBoxBaja.Checked == false)
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
                    buttonBusquedaEnAPI.Enabled = true;
                    labelCantidadActual.Text = "Cantidad Actual: " + Convert.ToString(interfazNucleo.ObtenerEjemplaresEnBuenEstadoLibro(idLibro).Count());
                }
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
    }
}

