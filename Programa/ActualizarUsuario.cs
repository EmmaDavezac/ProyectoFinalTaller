using Bitacora;
using System;
using System.Linq;
using System.Windows.Forms;
using UtilidadesPresentacion;

namespace Programa
{
    /// <summary>
    /// Resumen: Formulario que permite modificar los datos de un Usuario
    /// </summary>
    public partial class ActualizarUsuario : Form
    {
        Nucleo.Nucleo interfazNucleo = new Nucleo.Nucleo();
        private string nombreUsuario { get; set; }

        private BibliotecaUtilidadesPresentacion utilidades = new BibliotecaUtilidadesPresentacion();
        private IBitacora bitacora = new Bitacora.ImplementacionBitacora();
        /// <summary>
        /// Resumen:Constructor de la clase
        /// </summary>
        /// <param name="pNombreUsuario"></param>
        public ActualizarUsuario(string pNombreUsuario)
        {
            InitializeComponent();
            nombreUsuario = pNombreUsuario;

        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {
            buttonGuardar.Enabled = true;
        }

        /// <summary>
        /// Resumen:Accion que se ejecuta cuando se presiona el buttonGuardar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBoxNombre.Text) && textBoxNombre.Text.All(Char.IsLetter))
                {
                    if (!string.IsNullOrEmpty(textBoxApellido.Text) && textBoxApellido.Text.All(Char.IsLetter))
                    {
                        if (dateTimePickerFechaNacimiento.Value != new DateTime(1900, 1, 1))
                        {
                            if (DateTime.Now.Year - dateTimePickerFechaNacimiento.Value.Date.Year >= 12 && DateTime.Now.Year - dateTimePickerFechaNacimiento.Value.Date.Year <= 120)
                            {
                                if (!string.IsNullOrEmpty(textBoxMail.Text) && utilidades.EsUnEmailValido(textBoxMail.Text))
                                {
                                    if (!string.IsNullOrEmpty(textBoxTelefono.Text) && textBoxTelefono.Text.All(Char.IsDigit) && textBoxTelefono.Text.Length >= 8 && textBoxTelefono.Text.Length <= 11)
                                    {
                                        if (interfazNucleo.ObtenerUsuario(textBoxNombreUsuario.Text).Baja == false && checkBoxBaja.Checked == true)
                                        {
                                            interfazNucleo.ActualizarUsuario(textBoxNombreUsuario.Text, textBoxNombre.Text, textBoxApellido.Text, dateTimePickerFechaNacimiento.Value.Date.ToString(), textBoxMail.Text, textBoxTelefono.Text);
                                            interfazNucleo.DarDeBajaUsuario(textBoxNombreUsuario.Text);
                                            MessageBox.Show("Usuario ha sido dado de baja", "Operacion Exitosa", MessageBoxButtons.OK);
                                        }
                                        else if (interfazNucleo.ObtenerUsuario(textBoxNombreUsuario.Text).Baja == true && checkBoxBaja.Checked == true)
                                        {
                                            interfazNucleo.ActualizarUsuario(textBoxNombreUsuario.Text, textBoxNombre.Text, textBoxApellido.Text, dateTimePickerFechaNacimiento.Value.Date.ToString(), textBoxMail.Text, textBoxTelefono.Text);
                                            MessageBox.Show("Usuario ha sido dado de baja y los cambios han sido guardados correctamente", "Operacion Exitosa", MessageBoxButtons.OK);
                                        }
                                        else if (interfazNucleo.ObtenerUsuario(textBoxNombreUsuario.Text).Baja == false && checkBoxBaja.Checked == false)
                                        {
                                            interfazNucleo.ActualizarUsuario(textBoxNombreUsuario.Text, textBoxNombre.Text, textBoxApellido.Text, dateTimePickerFechaNacimiento.Value.Date.ToString(), textBoxMail.Text, textBoxTelefono.Text);
                                            MessageBox.Show("Los cambios han sido guardados correctamente", "Operacion Exitosa", MessageBoxButtons.OK);
                                        }
                                        else if (interfazNucleo.ObtenerUsuario(textBoxNombreUsuario.Text).Baja == true && checkBoxBaja.Checked == false)
                                        {
                                            interfazNucleo.ActualizarUsuario(textBoxNombreUsuario.Text, textBoxNombre.Text, textBoxApellido.Text, dateTimePickerFechaNacimiento.Value.Date.ToString(), textBoxMail.Text, textBoxTelefono.Text);
                                            interfazNucleo.DarDeAltaUsuario(textBoxNombreUsuario.Text);
                                            MessageBox.Show("Usuario ha sido dado de alta y los cambios han sido guardados correctamente", "Operacion Exitosa", MessageBoxButtons.OK);
                                        }
                                        this.Hide();
                                        ((GestionDeUsuarios)Owner).ObtenerUsuarios();
                                        this.Owner.Show();
                                    }
                                    else
                                    {
                                        this.labelError.Text = "Error,telefono ingresado invalido.Ingrese el numero sin 0 ni 15";
                                        buttonGuardar.Enabled = false;
                                        textBoxTelefono.Focus(); ;
                                    }
                                }
                                else
                                {
                                    this.labelError.Text = "Error, el mail ingresado no es valido";
                                    buttonGuardar.Enabled = false;
                                    textBoxMail.Focus(); ;
                                }
                            }
                            else
                            {
                                if (DateTime.Now.Year - dateTimePickerFechaNacimiento.Value.Date.Year < 12)
                                {
                                    this.labelError.Text = "Error, el usuario debe ser mayor de 12 años";
                                }
                                else
                                {
                                    this.labelError.Text = "Error, el usuario debe ser menor de 120 años";
                                }
                                buttonGuardar.Enabled = false;
                                textBoxMail.Focus();
                            }
                        }
                        else
                        {
                            this.labelError.Text = "Error, no ha ingresado la fecha de nacimiento";
                            buttonGuardar.Enabled = false;
                            dateTimePickerFechaNacimiento.Focus(); ;
                        }

                    }
                    else
                    {
                        this.labelError.Text = "Error, apellido invalido.No debe contener numeros, espacios ni simbolos";
                        buttonGuardar.Enabled = false;
                        textBoxApellido.Focus(); ;
                    }
                }
                else
                {
                    this.labelError.Text = "Error, nombre invalido.No debe contener numeros, espacios ni simbolos";
                    buttonGuardar.Enabled = false;
                    textBoxNombre.Focus(); ;
                }
            }
            catch (Exception ex)
            {
                string texto = "Error buttonGuardar_Click: " + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(texto);
                MessageBox.Show(texto, "Ha ocurrido un error");
            }
        }

        private void ActualizarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void labelNombre_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            buttonGuardar.Enabled = true;
        }

        private void textBoxApellido_TextChanged(object sender, EventArgs e)
        {
            buttonGuardar.Enabled = true;
        }

        private void textBoxFecha_TextChanged(object sender, EventArgs e)
        {
            buttonGuardar.Enabled = true;
        }

        private void textBoxTelefono_TextChanged(object sender, EventArgs e)
        {
            buttonGuardar.Enabled = true;
        }

        private void textBoxMail_TextChanged(object sender, EventArgs e)
        {
            buttonGuardar.Enabled = true;
        }

        /// <summary>
        /// Resumen:Accion que se ejecuta cuando se cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ActualizarUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        /// <summary>
        /// Resumen: Carga los datos del usuario en el formulario
        /// </summary>
        /// <param name="pNombreUsuario"></param>
        /// <param name="pBaja"></param>
        public void CargarUsuarioExistente(string pNombreUsuario, string pBaja)
        {
            try
            {
                var usuario = interfazNucleo.ObtenerUsuario(pNombreUsuario);
                textBoxNombreUsuario.Text = usuario.NombreUsuario;
                textBoxNombre.Text = usuario.Nombre;
                textBoxApellido.Text = usuario.Apellido;
                dateTimePickerFechaNacimiento.Value = usuario.FechaNacimiento;
                textBoxMail.Text = usuario.Mail;
                textBoxTelefono.Text = usuario.Telefono;
                if (pBaja == "True")
                {
                    checkBoxBaja.Checked = true;
                }
            }
            catch (Exception ex)
            {
                string texto = "Error CargarUsuarioExistente: " + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(texto);
                MessageBox.Show(texto, "Ha ocurrido un error");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Resumen: Accion que se ejecuta cuando se presiona el buttonVolver
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonVolver_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        /// <summary>
        /// Resumen:Accion que se ejecuta cuando se modifica la fecha de nacimimiento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePickerFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            buttonGuardar.Enabled = true;
        }

        /// <summary>
        /// Resumen: Accion que se ejecuta cuando se modifica el contenido  del checkBoxBaja
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxBaja_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBoxBaja.Checked == true)
                {
                    if (interfazNucleo.DarDeBajaUsuario(textBoxNombreUsuario.Text) == false)
                    {
                        checkBoxBaja.Checked = false;
                        MessageBox.Show("El Usuario " + textBoxNombreUsuario.Text + " no puede darse de baja ya que tiene prestamos pendientes!, intentelo mas tarde");
                    }
                    else
                    {
                        textBoxNombre.Enabled = false;
                        textBoxApellido.Enabled = false;
                        dateTimePickerFechaNacimiento.Enabled = false;
                        textBoxTelefono.Enabled = false;
                        textBoxMail.Enabled = false;
                    }
                }

                else if (checkBoxBaja.Checked == false)
                {
                    {
                        textBoxNombre.Enabled = true;
                        textBoxApellido.Enabled = true;
                        dateTimePickerFechaNacimiento.Enabled = true;
                        textBoxTelefono.Enabled = true;
                        textBoxMail.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                string texto = "Error checkBoxBaja_CheckedChanged: " + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(texto);
                MessageBox.Show(texto, "Ha ocurrido un error");
            }
        }
    }
}
