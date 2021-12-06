﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Nucleo;

namespace Programa
{
    public partial class RegistrarEjemplar : Form
    {
        private string NombreUsuario { get; set; }
        public RegistrarEjemplar(string nombreUsuario)
        {
            InitializeComponent();
            NombreUsuario = nombreUsuario;
            labelNombreUsuario.Text = "Usuario: " + NombreUsuario;
        }

        private void RegistrarEjemplar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {
            buttonBuscarLibro.Enabled = true;
            buttonGuardarEjemplar.Enabled = true;
        }

        private void buttonBuscarLibro_Click(object sender, EventArgs e)
        {
            textBoxTitulo.Clear();
            textBoxAutor.Clear();
            textBoxAñoPublicacion.Clear();
            textBoxISBN.Clear();
            if (textBoxId.Text != null && (textBoxId.Text).All(char.IsDigit) && textBoxId.Text != "")
            {
                Libro libro = new Nucleo.InterfazNucleo().ObtenerLibro(Convert.ToInt32(textBoxId.Text));
                if (libro != null)
                {
                    textBoxTitulo.Text = libro.Titulo;
                    textBoxAutor.Text = libro.Autor;
                    textBoxAñoPublicacion.Text = libro.AñoPublicacion;
                    textBoxISBN.Text = libro.ISBN;
                    buttonBuscarLibro.Enabled = false;
                }
                else { labelError.Text = "El Id ingresado no corresponde a un libro registrado "; buttonBuscarLibro.Enabled = false; textBoxId.Clear(); textBoxId.Focus(); }
            }
            else { labelError.Text = "El Id ingresado es incorrecto "; buttonBuscarLibro.Enabled = false; textBoxId.Clear(); textBoxId.Focus(); }
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal ventana = new MenuPrincipal(NombreUsuario);
            ventana.Show();
        }

        private void buttonGuardarEjemplar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxId.Text) && !string.IsNullOrEmpty(textBoxTitulo.Text) && !string.IsNullOrEmpty(textBoxAutor.Text) && !string.IsNullOrEmpty(textBoxISBN.Text) && !string.IsNullOrEmpty(textBoxAñoPublicacion.Text) && !string.IsNullOrEmpty(comboBoxEstado.Text))
            {
                
                if (new InterfazNucleo().ObtenerLibro(Convert.ToInt32(textBoxId.Text))!=null)
                {
                    new InterfazNucleo().AñadirEjemplar(Convert.ToInt32(textBoxId.Text),comboBoxEstado.Text);
                    MessageBox.Show("Ejemplar registrado con exito, el Id del Ejemplar es: " + new InterfazNucleo().ObtenerUltimoIdEjemplar());
                    this.Hide();
                    MenuPrincipal ventanaMenu = new MenuPrincipal(NombreUsuario);
                    ventanaMenu.Show();
                }
                else
                {
                    MessageBox.Show("No hay un libro registrado con ese Id");
                    textBoxId.Focus();
                    buttonGuardarEjemplar.Enabled = false;
                }

            }
            else
            {
                MessageBox.Show("Debe completar la informacion");
                textBoxId.Focus();
                buttonGuardarEjemplar.Enabled = false;
            }
        }

        private void RegistrarEjemplar_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonGuardarEjemplar.Enabled = true;
        }
    }
}
