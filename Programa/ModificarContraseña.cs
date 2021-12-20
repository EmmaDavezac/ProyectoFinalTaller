using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nucleo;

namespace Programa
{
    public partial class ModificarContraseña : Form
    {
        private InterfazNucleo interfazNucleo = new InterfazNucleo();
        private string idUsuario;
        string contraseñaNueva;
        public ModificarContraseña(string iD)
        {
            InitializeComponent();
            idUsuario = iD;
        }

        private void textBoxContraseñaAntigua_TextChanged(object sender, EventArgs e)
        {
            buttonGuardar.Enabled = true;
        }

        private void textBoxContraseñaNueva_TextChanged(object sender, EventArgs e)
        {
            buttonGuardar.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBoxContraseñaAntigua.Text != null)
            {
                if (textBoxContraseñaNueva.Text != null)
                {
                    if (textBoxContraseñaAntigua.Text == interfazNucleo.ObtenerAdministradorPorNombreOMail(idUsuario).Pass)
                    {
                        MessageBox.Show("La contraseña a sido modificada correctamente", "Message", MessageBoxButtons.OK);
                        contraseñaNueva = textBoxContraseñaNueva.Text;
                        this.Close();
                        ((ActualizarAdministrador)this.Owner).CargarContraseña(contraseñaNueva);
                    }
                    else
                    {
                        MessageBox.Show("La contraseña antigua es incorrecta", "Error", MessageBoxButtons.OK);
                    }
                }
                else
                {

                }
            }
            else
            {
                
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModificarContraseña_Load(object sender, EventArgs e)
        {

        }
    }
}
