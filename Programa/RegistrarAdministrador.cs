using Nucleo;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Programa
{
    public partial class RegistrarAdministrador : Form
    //La finalidad de este formulario es la de permitir registrar un nuevo administrador
    {
        private string nombreUsuario { get; set; }//Aqui se almacena el nombre de usuario del administrador que esta usando el programa
        private FachadaNucleo interfazNucleo = new FachadaNucleo();//Instancia del nucleo del programa que nos permite acceder a las funciones del mismo
        public RegistrarAdministrador(string pNombreUsuario)//Constructor 
        {
            InitializeComponent();
            nombreUsuario = pNombreUsuario;
            n
            labelNombreUsuario.Text = "Usuario: " + nombreUsuario;
        }

        private void AgregarAdministrador_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void botonVolver_Click(object sender, EventArgs e)//Se ejecutara cuando se presione el boton volver
        {

            this.Hide();//la ventana se oculta
            this.Owner.Show();//se muestra la ventana padre
        }

        

        private void RegistrarAdministrador_FormClosed(object sender, FormClosedEventArgs e)//se ejecutara cuando se cierre el formulario
        {
           this.Hide();//la ventana se oculta
            this.Owner.Show();//se muestra la ventana padre
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)//se ejecutara cuando se modifique el texto de textBoxNombre
        {
            buttonRegistrarAdministrador.Enabled = true;//se activa el boton registrar administrador
        }

        private void textBoxApellido_TextChanged(object sender, EventArgs e)//se ejecutara cuando se modifique el texto de textBoxApellido
        {
            buttonRegistrarAdministrador.Enabled = true;//se activa el boton registrar administrador
        }

        private void dateTimePickerFechaNacimiento_ValueChanged(object sender, EventArgs e)//se ejecutara cuando se modifique la fecha de ateTimePickerFechaNacimiento
        {
            buttonRegistrarAdministrador.Enabled = true;//se activa el boton registrar administrador
        }

        private void textBoxMail_TextChanged(object sender, EventArgs e)//se ejecutara cuando se modifique el texto de textBoxMail
        {
            buttonRegistrarAdministrador.Enabled = true;//se activa el boton registrar administrador
        }

        private void textBoxContraseña_TextChanged(object sender, EventArgs e)//se ejecutara cuando se modifique el texto de textBoxContraseña
        {
            buttonRegistrarAdministrador.Enabled = true;//se activa el boton registrar administrador
        }

        private void buttonRegistrarAdministrador_Click(object sender, EventArgs e)
        //se activara cuando se presiona el boton registrar administrador y en el caso de que todos los datos requeridos esten ingresados y sean correctos, se registrara el nuevo administrador
        {
            if (!string.IsNullOrEmpty(textBoxNombreUsuario.Text)&&textBoxNombreUsuario.Text.All(Char.IsLetter)))//se verifica que se haya ingresado el nombre de usuario y tenga el formato correcto
            {
                if (!string.IsNullOrEmpty(textBoxNombre.Text) && textBoxNombre.Text.All(Char.IsLetter))//se verifica que se haya ingresado el nombre y tenga el formato correcto
                {
                    if (!string.IsNullOrEmpty(textBoxApellido.Text) && textBoxApellido.Text.All(Char.IsLetter))//se verifica que se haya ingresado el apellido y tenga el formato correcto
                    {
                        if (dateTimePickerFechaNacimiento.Value.Date != new DateTime(1900, 1, 1))//se verifica que se haya ingresado la fecha de nacimiento
                        {
                            if (!string.IsNullOrEmpty(textBoxMail.Text) && interfazNucleo.EsUnEmailValido(textBoxMail.Text))//se verifica que se haya ingresado el mail y tenga el formato correcto
                            {
                                if (!string.IsNullOrEmpty(textBoxTelefono.Text) && textBoxTelefono.Text.All(Char.IsDigit) && textBoxTelefono.Text.Length >= 8 && textBoxTelefono.Text.Length <= 11)
                                //se verifica que se haya ingresado numero de telefono y tenga el formato correcto
                                {
                                    if (!string.IsNullOrEmpty(textBoxContraseña.Text) && textBoxContraseña.Text.Length >= 4)
                                    //se verifica que se haya ingresado la contraseña y tenga el formato correcto
                                    {
                                        bool resultado = interfazNucleo.AñadirAdministrador(textBoxNombreUsuario.Text, textBoxNombre.Text, textBoxApellido.Text, dateTimePickerFechaNacimiento.Value, textBoxMail.Text, textBoxContraseña.Text, textBoxTelefono.Text);
                                        //se intenta registrar el nuevo administrador y notifica en pantalla si la operacion fue exitosa o no
                                        if (resultado == true)
                                        {
                                            MessageBox.Show("Usuario administrador guardado, el nombre de usuario es: " + textBoxNombreUsuario.Text, "Operacion Exitosa", MessageBoxButtons.OK);

                                            this.Hide();//se oculta la ventana actual
                                            this.Owner.Show();// se vuelve a la ventana padre
                                        }
                                        else
                                        {
                                            MessageBox.Show("El usuario: " + textBoxNombreUsuario.Text + " ya se encuentra registrado, pruebe con otro nombre de usuario", "Error", MessageBoxButtons.OK);
                                        }

                                    }
                                    else
                                    {
                                        this.labelError.Text = "Error,la contraseña debe tener al menos 4 digitos";
                                        buttonRegistrarAdministrador.Enabled = false;
                                        textBoxContraseña.Clear();
                                        textBoxTelefono.Focus();

                                    }
                                }
                                else
                                {
                                    this.labelError.Text = "Error,telefono ingresado invalido.Ingrese el numero sin 0 ni 15";
                                    buttonRegistrarAdministrador.Enabled = false;
                                    textBoxTelefono.Focus(); ;
                                }
                            }
                            else
                            {
                                this.labelError.Text = "Error, el mail ingresado no es valido";
                                buttonRegistrarAdministrador.Enabled = false;
                                textBoxMail.Focus(); ;
                            }
                        }
                        else
                        {
                            this.labelError.Text = "Error, no ha ingresado la fecha de nacimiento";
                            buttonRegistrarAdministrador.Enabled = false;
                            dateTimePickerFechaNacimiento.Focus(); ;
                        }

                    }
                    else
                    {
                        this.labelError.Text = "Error, apellido invalido.No debe contener numeros, espacios ni simbolos";
                        buttonRegistrarAdministrador.Enabled = false;
                        textBoxApellido.Focus(); ;
                    }
                }
                else
                {
                    this.labelError.Text = "Error, nombre invalido.No debe contener numeros, espacios ni simbolos";
                    buttonRegistrarAdministrador.Enabled = false;
                    textBoxNombre.Focus(); ;
                }
            }
            else
            {
                this.labelError.Text = "Error, nombre de usuario esta vacio";
                buttonRegistrarAdministrador.Enabled = false;
                textBoxNombreUsuario.Focus();
            }
        }

        private void dateTimePickerFechaNacimiento_ValueChanged_1(object sender, EventArgs e)// se ejecutara cuando se cambie la fecha de dateTimePickerFechaNacimiento
        {
            buttonRegistrarAdministrador.Enabled = true;//se activa el boton registrar administrador
            labelError.Text = "";
        }

        private void textBoxNombre_TextChanged_1(object sender, EventArgs e)//se ejecutara cuando se modifique el texto de textBoxNombre
        {
            buttonRegistrarAdministrador.Enabled = true;//se activa el boton registrar administrador
            labelError.Text = "";
        }

        private void textBoxApellido_TextChanged_1(object sender, EventArgs e)//se ejecutara cuando se modifique el texto de textBoxApellido
        {
            buttonRegistrarAdministrador.Enabled = true;//se activa el boton registrar administrador
            labelError.Text = "";
        }

        private void textBoxMail_TextChanged_1(object sender, EventArgs e)//se ejecutara cuando se modifique el texto de textBoxMail
        {
            buttonRegistrarAdministrador.Enabled = true;//se activa el boton registrar administrador
            labelError.Text = "";
        }

        private void textBoxTelefono_TextChanged(object sender, EventArgs e)//se ejecutara cuando se modifique el texto de textBoxTelefono
        {
            buttonRegistrarAdministrador.Enabled = true;//se activa el boton registrar administrador
            labelError.Text = "";
        }

        private void textBoxContraseña_TextChanged_1(object sender, EventArgs e)//se ejecutara cuando se modifique el texto de textBoxContraseña
        {
            buttonRegistrarAdministrador.Enabled = true;//se activa el boton registrar administrador
            labelError.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNombreUsuario_TextChanged(object sender, EventArgs e)//se ejecutara cuando se modifique el texto de textBoxNombreUsuario
        {
        buttonRegistrarAdministrador.Enabled = true;//se activa el boton registrar administrador
            labelError.Text = "";
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBoxNombreUsuario_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void labelMail_Click(object sender, EventArgs e)
        {

        }

        private void labelContraseña_Click(object sender, EventArgs e)
        {

        }

        private void labelFechaNacimiento_Click(object sender, EventArgs e)
        {

        }

        private void buttonMostrar_Click(object sender, EventArgs e)//Se ejecutara cuando se presione el boton para mostrar u ocultar la contraseña
        {
            if (textBoxContraseña.UseSystemPasswordChar == true)
            {
                textBoxContraseña.UseSystemPasswordChar = false;
                buttonMostrar.Text = "Ocultar";
                textBoxContraseña.Focus();
            }
            else
            {
                textBoxContraseña.UseSystemPasswordChar = true;
                buttonMostrar.Text = "Mostrar";
                textBoxContraseña.Focus();
            }
        }
    }
}
