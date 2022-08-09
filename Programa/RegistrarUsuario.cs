using Nucleo;
using System;
using System.Linq;
using System.Windows.Forms;
using UtilidadesPresentacion;
using Bitacora;

namespace Programa
{
    public partial class RegistrarUsuario : Form
    //La finalidad de este formulario es la de permitir registrar un nuevo usuario simple
    {
        

        private string nombreUsuario { get; set; }//Aqui se almacena el nombre de usuario del administrador que esta usando el programa
        private FachadaNucleo interfazNucleo = new FachadaNucleo();//Instancia del nucleo del programa que nos permite acceder a las funciones del mismo
        private BibliotecaUtilidadesPresentacion utilidades = new BibliotecaUtilidadesPresentacion();
        private IBitacora bitacora = new Bitacora.Bitacora();
        public RegistrarUsuario(string pNombreUsuario)//Constructor de la clase 
        {
            InitializeComponent();
            nombreUsuario = pNombreUsuario;
            
            labelNombreUsuario.Text = "Usuario: " + nombreUsuario;
        }


        private void botonVolver_Click(object sender, EventArgs e)//este evento se ejecutara cuando se presione el boton botonVolver
        {
            this.Hide();//la ventana se oculta
            this.Owner.Show();//se muestra la ventana padre
        }
        private void AgregarCliente_FormClosing(object sender, FormClosingEventArgs e)//este evento se ejecutara cuando se cierre el formulario
        {
            this.Hide();//la ventana se oculta
            this.Owner.Show();//se muestra la ventana padre
        }

        private void AgregarCliente_FormClosed(object sender, FormClosedEventArgs e)//este evento se ejecutara cuando se cierre el formulario
        {
            this.Hide();//la ventana se oculta
            this.Owner.Show();//se muestra la ventana padre
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAñadirUsuario_Click(object sender, EventArgs e)
        //se ejecutara cuando se presione el boton añadir usuario, en el caso de que toda la informacion necesaria haya sido  ingresada y sea correcta, se registrara el nuevo usuario
        {
            try
            {
                if (!string.IsNullOrEmpty(textBoxNombreUsuario.Text))//se verifica que se haya ingresado el nombre de usuario
            {
                if (!string.IsNullOrEmpty(textBoxNombre.Text) && textBoxNombre.Text.All(Char.IsLetter))//se verifica que el nombre se haya ingresado correctamente(formato)
                {
                    if (!string.IsNullOrEmpty(textBoxApellido.Text) && textBoxApellido.Text.All(Char.IsLetter))//se verifica que el apellido se haya ingresado correctamente (formato)
                    {
                        if (dateTimePickerFechaNacimiento.Value.Date != new DateTime(1900, 1, 1))//se verifica que la fecha de nacimiento se haya ingresado 
                        {
                            if (DateTime.Now.Year - dateTimePickerFechaNacimiento.Value.Date.Year >= 12 && DateTime.Now.Year - dateTimePickerFechaNacimiento.Value.Date.Year <= 120)//Verifica que la edad del usuario este entre los 12 y 120 años
                            {
                                if (!string.IsNullOrEmpty(textBoxMail.Text) && utilidades.EsUnEmailValido(textBoxMail.Text))//se verifica que el mail se haya ingresado correctamente (formato)
                                {
                                    if (!string.IsNullOrEmpty(textBoxTelefono.Text) && textBoxTelefono.Text.All(Char.IsDigit) && textBoxTelefono.Text.Length >= 8 && textBoxTelefono.Text.Length <= 11)//se verifica que el telefono se haya ingresado correctamente (formato)
                                    {
                                        bool resultado = interfazNucleo.AñadirUsuario(textBoxNombreUsuario.Text, textBoxNombre.Text, textBoxApellido.Text, dateTimePickerFechaNacimiento.Value, textBoxMail.Text, textBoxTelefono.Text);//se añade el usuario a la base de datos
                                        if (resultado == true)//verificamos si la operacion fue exitosa y mostramos un mensaje en pantalla
                                        {
                                            MessageBox.Show("Usuario guardado, el nombre de usuario es: " + textBoxNombreUsuario.Text, "Operacion Exitosa", MessageBoxButtons.OK);
                                            this.Hide();
                                            this.Owner.Show();
                                        }
                                        else
                                        {
                                            MessageBox.Show("El usuario: " + textBoxNombreUsuario.Text + " ya se encuentra registrado, pruebe con otro nombre de usuario", "Error", MessageBoxButtons.OK);
                                        }

                                    }
                                    else
                                    {
                                        this.labelError.Text = "Error,telefono ingresado invalido.Ingrese el numero sin 0 ni 15";
                                        buttonAñadirUsuario.Enabled = false;
                                        textBoxTelefono.Focus(); ;
                                    }
                                }
                                else
                                {
                                    this.labelError.Text = "Error, el mail ingresado no es valido";
                                    buttonAñadirUsuario.Enabled = false;
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
                                buttonAñadirUsuario.Enabled = false;
                                textBoxMail.Focus();
                            }
                               
                        }
                        else
                        {
                            this.labelError.Text = "Error, no ha ingresado la fecha de nacimiento";
                            buttonAñadirUsuario.Enabled = false;
                            dateTimePickerFechaNacimiento.Focus(); ;
                        }

                    }
                    else
                    {
                        this.labelError.Text = "Error, apellido invalido.No debe contener numeros, espacios ni simbolos";
                        buttonAñadirUsuario.Enabled = false;
                        textBoxApellido.Focus(); ;
                    }
                }
                else
                {   
                    this.labelError.Text = "Error, nombre invalido.No debe contener numeros, espacios ni simbolos";
                    buttonAñadirUsuario.Enabled = false;
                    textBoxNombre.Focus(); 
                }
            }
            else
            {
                this.labelError.Text = "Error, nombre de usuario esta vacio";
                buttonAñadirUsuario.Enabled = false;
                textBoxNombreUsuario.Focus();
            }
            }
            catch (Exception ex)
            {
                string texto= "Error buttonAñadirUsuario_Click: "+ ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(texto);
                MessageBox.Show(texto, "Ha ocurrido un error");
            }
        }


        private void textBoxNombre_TextChanged(object sender, EventArgs e)// se ejecura cuando se modifique el texto de textBoxNombre
        {
            buttonAñadirUsuario.Enabled = true;//se habilita el boton buttonAñadirUsuario
        }

        private void AgregarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void textBoxMail_TextChanged(object sender, EventArgs e)// se ejecura cuando se modifique el texto de textBoxMail
        {
            buttonAñadirUsuario.Enabled = true;//se habilita el boton buttonAñadirUsuario
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerFechaNacimiento_ValueChanged(object sender, EventArgs e)// se ejecura cuando se modifique la fecha de dateTimePickerFechaNacimiento
        {
            buttonAñadirUsuario.Enabled = true;//se habilita el boton buttonAñadirUsuario
        }

        private void textBoxApellido_TextChanged(object sender, EventArgs e)// se ejecura cuando se modifique el texto de textBoxApellido
        {
            buttonAñadirUsuario.Enabled = true;//se habilita el boton buttonAñadirUsuario
        }

        private void labelApellido_Click(object sender, EventArgs e)
        {

        }

        private void labelError_Click(object sender, EventArgs e)
        {

        }

        private void labelNombreUsuario_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTelefono_TextChanged(object sender, EventArgs e)// se ejecura cuando se modifique el texto de textBoxTelefono
        {
            buttonAñadirUsuario.Enabled = true;//se habilita el boton buttonAñadirUsuario
        }

        private void textBoxNombreUsuario_TextChanged(object sender, EventArgs e)// se ejecura cuando se modifique el texto de textBoxNombreUsuario 
        {
        buttonAñadirUsuario.Enabled = true;//se habilita el boton buttonAñadirUsuario
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
