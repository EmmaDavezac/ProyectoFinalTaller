using Nucleo;
using System;
using System.Windows.Forms;

namespace Programa
{
    public partial class ModificarContraseña : Form
    {
        private FachadaNucleo interfazNucleo = new FachadaNucleo();
        private string idUsuario;
        string contraseñaNueva;
        public ModificarContraseña(string iD)
        {
            InitializeComponent();
            idUsuario = iD;
        }

        private void textBoxContraseñaAntigua_TextChanged(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = true;
        }

        private void textBoxContraseñaNueva_TextChanged(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBoxContraseñaAntigua.Text != null)
            {
                if (textBoxContraseñaNueva.Text != null)
                {
                    if (textBoxContraseñaAntigua.Text == interfazNucleo.ObtenerAdministrador(idUsuario).Pass)
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
                    this.labelErro.Text = "Error, la contraseña nueva es vacia";
                    buttonAceptar.Enabled = false;
                    textBoxContraseñaNueva.Focus(); ;
                }
            }
            else
            {
                this.labelErro.Text = "Error,la contraseña vieja es vacia";
                buttonAceptar.Enabled = false;
                textBoxContraseñaAntigua.Focus(); ;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModificarContraseña_Load(object sender, EventArgs e)
        {

        }

        private void buttonMostrarContraseñaVieja_Click(object sender, EventArgs e)
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

        private void buttonMostrarContraseñaNueva_Click(object sender, EventArgs e)
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
