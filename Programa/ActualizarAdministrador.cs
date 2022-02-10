using Nucleo;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Programa
{
    public partial class ActualizarAdministrador : Form
    {
        FachadaNucleo interfazNucleo = new FachadaNucleo();//Instancia de la fachada del nucleo para realizar operaciones dentro del dominio
        public string contraseñaNueva;//Variable para guardar la contraseña nueva
        private string nombreUsuario { get; set; }
        public ActualizarAdministrador(string pNombreUsuario)//Inicializamos los datos del administrador actual que se van a mostrar en la interfaz
        {
            InitializeComponent();
            nombreUsuario = pNombreUsuario;
            labelNombreUsuario.Text = "Usuario: " + nombreUsuario;
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {try
        {
            if (!string.IsNullOrEmpty(textBoxNombre.Text) && textBoxNombre.Text.All(Char.IsLetter))//Verifica si el nombre de usuario no es nulo y que solo contenga letras.
            {
                if (!string.IsNullOrEmpty(textBoxApellido.Text) && textBoxApellido.Text.All(Char.IsLetter))//Verifica si el apellido de usuario no es nulo y que solo contenga letras.
                {
                    if (dateTimePickerFechaNacimiento.Value != new DateTime(1900, 1, 1))//Verifica que la fecha sea distinta de 1900/1/1.
                    {
                        if (DateTime.Now.Year - dateTimePickerFechaNacimiento.Value.Date.Year >= 18 && DateTime.Now.Year - dateTimePickerFechaNacimiento.Value.Date.Year <= 120)//Verifica que la edad del administrador este entre los 18 y 120 años
                        {
                            if (!string.IsNullOrEmpty(textBoxMail.Text) && interfazNucleo.EsUnEmailValido(textBoxMail.Text))//Verifica que el mail no este vacio y que sea un mail en un formato valido.
                            {
                                if (!string.IsNullOrEmpty(textBoxTelefono.Text) && textBoxTelefono.Text.All(Char.IsDigit) && textBoxTelefono.Text.Length >= 8 && textBoxTelefono.Text.Length <= 11)//Verifica que el numero de telefono no este vacio, que todos sus valores sean digitos, y que su longitud este entre 8 y 11 digitos.
                                {
                                    if (interfazNucleo.ObtenerAdministrador(textBoxNombreUsuario.Text).Baja == false && checkBoxBaja.Checked == true)//Verifica si el administrador esta dado de baja y si el checkbox baja esta checkeado
                                    {
                                        interfazNucleo.ActualizarAdministrador(textBoxNombreUsuario.Text, textBoxNombre.Text, textBoxApellido.Text, dateTimePickerFechaNacimiento.Value.Date.ToString(), textBoxMail.Text, textBoxTelefono.Text);//De ser asi permite actualizar los camops
                                        interfazNucleo.DarDeBajaAdministrador(textBoxNombreUsuario.Text);// Y da de baja al administrador.
                                        MessageBox.Show("Administrador ha sido dado de baja, el nombre de usuario es: " + textBoxNombreUsuario.Text, "Operacion Exitosa", MessageBoxButtons.OK);//Mensaje informativo al administrador
                                    }
                                    else if (interfazNucleo.ObtenerAdministrador(textBoxNombreUsuario.Text).Baja == true && checkBoxBaja.Checked == true)//Otra situacion es que el administrador esta dado de baja y ademas el checbox este checkeado
                                    {
                                        interfazNucleo.ActualizarAdministrador(textBoxNombreUsuario.Text, textBoxNombre.Text, textBoxApellido.Text, dateTimePickerFechaNacimiento.Value.Date.ToString(), textBoxMail.Text, textBoxTelefono.Text);//En este caso solo actualiza los datos del administrador
                                        MessageBox.Show("Administrador ha sido dado de baja, el nombre de usuario es: " + textBoxNombreUsuario.Text, "Operacion Exitosa", MessageBoxButtons.OK);//Mensaje informativo al administrador
                                    }
                                    else if (interfazNucleo.ObtenerAdministrador(textBoxNombreUsuario.Text).Baja == false && checkBoxBaja.Checked == false)//Otra situacion es que el administrador no este dado de baja y que ademas el checkbox no este checkeado.
                                    {
                                        interfazNucleo.ActualizarAdministrador(textBoxNombreUsuario.Text, textBoxNombre.Text, textBoxApellido.Text, dateTimePickerFechaNacimiento.Value.Date.ToString(), textBoxMail.Text, textBoxTelefono.Text);//En este caso solo actualiza los datos del administrador
                                        MessageBox.Show("Administrador ha sido guardado correctamente, el nombre de usuario es: " + textBoxNombreUsuario.Text, "Operacion Exitosa", MessageBoxButtons.OK);//Mensaje informativo al administrador
                                    }
                                    else if (interfazNucleo.ObtenerAdministrador(textBoxNombreUsuario.Text).Baja == true && checkBoxBaja.Checked == false)//Otra situacion es que el administrador este dado de baja y que no este checkeado el checkbox de baja es decir que se de de alta nuevamente.
                                    {
                                        interfazNucleo.ActualizarAdministrador(textBoxNombreUsuario.Text, textBoxNombre.Text, textBoxApellido.Text, dateTimePickerFechaNacimiento.Value.Date.ToString(), textBoxMail.Text, textBoxTelefono.Text);//En este caso se actualiza el administrador.
                                        interfazNucleo.DarDeAltaAdministrador(textBoxNombreUsuario.Text);//Y se da de alta nuevamente al administrador.
                                        MessageBox.Show("Administrador ha sido dado de alta y guardado correctamente, el nombre de usuario es: " + textBoxNombreUsuario.Text, "Operacion Exitosa", MessageBoxButtons.OK);//Mensaje informativo al administrador
                                    }
                                    if (contraseñaNueva != null)//Si la contraseña pasada al construtor de la interfaz no es vacio entonces procede a actualizar la contraseña del administrador,
                                    {
                                        interfazNucleo.ActualizarContraseñaAdministrador(textBoxNombreUsuario.Text, contraseñaNueva);
                                    }
                                    this.Hide();//Oculta la ventana actual
                                    ((GestionarAdministradores)Owner).ObtenerAdministradores();//Actualiza el listado de administradores de su owner
                                    this.Owner.Show();//Muestra a su owner(GestionarAdministradores);
                                }
                                else//A continuacion todos los else con su correspondiente mensaje de error.
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
                            if (DateTime.Now.Year - dateTimePickerFechaNacimiento.Value.Date.Year < 18)
                            {
                                this.labelError.Text = "Error, el usuario debe ser mayor de 18 años";
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
                        dateTimePickerFechaNacimiento.Focus();
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
        string texto= "Error al actualizar el usuario: "+ ex.Message + ex.StackTrace;
        interfazNucleo.RegistrarLog(texto);
        MessageBox.Show(texto, "Ha ocurrido un error");
         
        }
        }

        private void ActualizarAdministrador_Load(object sender, EventArgs e)
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

        private void ActualizarAdministrador_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBoxId_TextChanged(object sender, EventArgs e)
        {
            buttonGuardar.Enabled = true;
        }

        public void CargarAdministradorExistente(string pNombreUsuario,string pBaja)//Se encarga de inicializar los datos del adminsitrador en la ventana.
        {
            try
            {
            var usuario = interfazNucleo.ObtenerAdministrador(pNombreUsuario);//Obtiene el administrador.
            textBoxNombreUsuario.Text = usuario.NombreUsuario;//Carga los textbox con sus datos correspondientes del administrador.
            textBoxNombre.Text = usuario.Nombre;
            textBoxApellido.Text = usuario.Apellido;
            dateTimePickerFechaNacimiento.Value = usuario.FechaNacimiento;
            textBoxMail.Text = usuario.Mail;
            textBoxTelefono.Text = usuario.Telefono;
            if (pBaja == "True")//Verifica si el administrador esta dado de baja.
            {
                checkBoxBaja.Checked = true;//Si es asi checkea el checkbox de baja.
            }
            }
            catch (Exception ex)
                {
                string texto= "Error al Cargar Administrador Existente: "+ ex.Message + ex.StackTrace;
                interfazNucleo.RegistrarLog(texto);
                MessageBox.Show(texto, "Ha ocurrido un error");
                }
        }

        private void buttonModificarContraseña_Click(object sender, EventArgs e)
        {
            try
            {
                ModificarContraseña ventana = new ModificarContraseña(textBoxNombreUsuario.Text);
            ventana.ShowDialog(this);
            }
            catch (Exception ex)
                {
                string texto= "Error button Modificar Contraseña(: "+ ex.Message + ex.StackTrace;
                interfazNucleo.RegistrarLog(texto);
                MessageBox.Show(texto, "Ha ocurrido un error");
                }
        }

        public void CargarContraseña(string contraseña)
        {
            contraseñaNueva = contraseña;
        }

        private void dateTimePickerFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            buttonGuardar.Enabled = true;
        }

        private void checkBoxBaja_CheckedChanged(object sender, EventArgs e)//Checkbox que nos permite dar de baja o alta a un administrador
        {
            try
            {
                if (checkBoxBaja.Checked == true)//Si esta checkeado se fija que el administrador pueda darse de baja
            {
                if (interfazNucleo.DarDeBajaAdministrador(textBoxNombreUsuario.Text) == false)//Si devuelve falso quiere decir que se trata del adminsitrador principal por lo tanto no puede darse de baja.
                {
                    checkBoxBaja.Checked = false;
                    MessageBox.Show("No puede darse de baja al administrador principal!");
                }
                else//Caso contrario procede bloquear las opciones que brinda la ventana
                {
                    textBoxNombre.Enabled = false;
                    textBoxApellido.Enabled = false;
                    dateTimePickerFechaNacimiento.Enabled = false;
                    textBoxTelefono.Enabled = false;
                    textBoxMail.Enabled = false;
                }           
            }

            else if (checkBoxBaja.Checked == false)//En el caso de que no este checekado permite utilizar las opciones de la ventana.
            {
                    textBoxNombre.Enabled = true;
                    textBoxApellido.Enabled = true;
                    dateTimePickerFechaNacimiento.Enabled = true;
                    textBoxTelefono.Enabled = true;
                    textBoxMail.Enabled = true;
            }
            }
            catch (Exception ex)
            
             {
                string texto= "Error checkBoxBaja_CheckedChanged: "+ ex.Message + ex.StackTrace;
                interfazNucleo.RegistrarLog(texto);
                MessageBox.Show(texto, "Ha ocurrido un error");
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }
    }
}
