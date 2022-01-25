using Nucleo;
using System;
using System.Windows.Forms;

namespace Programa
{
    public partial class ModificarContraseña : Form
    //este formulario tiene la finalidad de permitir modificar la contraseña de un administrador
    {
        private string nombreUsuario { get; set; }//Aqui se almacena el nombre de usuario del administrador que esta usando el programa
        private FachadaNucleo interfazNucleo = new FachadaNucleo();//Instancia del nucleo del programa que nos permite acceder a las funciones del mismo
        private string contraseñaNueva;
        public ModificarContraseña(string pNombreUsuario)//contructor de la clase
        {
            InitializeComponent();
            nombreUsuario = pNombreUsuario;
        }

        private void textBoxContraseñaAntigua_TextChanged(object sender, EventArgs e)//se ejecutara cuando se modifique el texto de textBoxContraseñaAntigua
        {
            buttonAceptar.Enabled = true;//se habilita el boton aceptar
        }

        private void textBoxContraseñaNueva_TextChanged(object sender, EventArgs e)//se ejecutara cuando se modifique el texto de textBoxContraseñaNueva
        {
            buttonAceptar.Enabled = true;//se habilita el boton aceptar
        }

        private void button2_Click(object sender, EventArgs e)
        //se ejecutara cuando se presione el boton button2, en el caso de que se hayan ingresado los datos y sean correctos, se actualizara la contraseña del administrador
        {

            if (textBoxContraseñaAntigua.Text != null)//se verifica que se haya ingresado la contraseña antigua
            {
                if (textBoxContraseñaNueva.Text != null&&textBoxContraseñaNueva.Text.Length>=4)
                // se verifica que se haya ingresado la contraseña nueva y que cumpla con la longitud minima
                {
                    if (interfazNucleo.VerficarContraseña(nombreUsuario, textBoxContraseñaAntigua.Text))//se verifica que la contraseña antigua sea correcta
                    {
                        MessageBox.Show("La contraseña a sido modificada, guarde los cambios de la ventana anterior para que esto tenga efecto", "Message", MessageBoxButtons.OK);
                        contraseñaNueva = textBoxContraseñaNueva.Text;
                        this.Close();
                        ((ActualizarAdministrador)this.Owner).CargarContraseña(contraseñaNueva);
                    }
                    else
                    {
                        this.labelErro.Text = "Error, la contraseña antigua es incorrecta";
                        buttonAceptar.Enabled = false;
                        textBoxContraseñaAntigua.Focus(); ;
                    }
                }
                else
                {
                    this.labelErro.Text = "Error, contraseña nueva demasiado corta";
                    buttonAceptar.Enabled = false;
                    textBoxContraseñaNueva.Focus(); ;
                }
            }
            else
            {
                this.labelErro.Text = "Error,contraseña antigua no ingresada";
                buttonAceptar.Enabled = false;
                textBoxContraseñaAntigua.Focus(); ;
            }

        }

        private void button1_Click(object sender, EventArgs e)//se ejecutara si se presiona el boton button1
        {
            this.Close();//se cierra la ventana
        }

        private void ModificarContraseña_Load(object sender, EventArgs e)
        {

        }

        private void buttonMostrarContraseñaVieja_Click(object sender, EventArgs e)//oculta o muestra la contraseña ingresada en textBoxContraseñaAntigua
        {
            if (textBoxContraseñaAntigua.UseSystemPasswordChar == true)
            {
                textBoxContraseñaAntigua.UseSystemPasswordChar = false;
                buttonMostrarContraseñaVieja.Text = "Ocultar";
            }
            else
            {
                textBoxContraseñaAntigua.UseSystemPasswordChar = true;
                buttonMostrarContraseñaVieja.Text = "Mostrar";
            }
        }

        private void buttonMostrarContraseñaNueva_Click(object sender, EventArgs e)//oculta o muestra la contraseña ingresada en textBoxContraseñaNueva
        {
            if (textBoxContraseñaNueva.UseSystemPasswordChar == true)
            {
                textBoxContraseñaNueva.UseSystemPasswordChar = false;
                buttonMostrarContraseñaNueva.Text = "Ocultar";
            }
            else
            {
                textBoxContraseñaNueva.UseSystemPasswordChar = true;
                buttonMostrarContraseñaNueva.Text = "Mostrar";
            }
        }
    }
}
