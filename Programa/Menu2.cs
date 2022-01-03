﻿using System;
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
    public partial class Menu2 : Form
    {
        private string NombreYApellido { get; set; }
        private string nombreUsuario { get; set; }
        InterfazNucleo interfazNucleo = new InterfazNucleo();
        public Menu2(string pNombreUsuario)
        {
            InitializeComponent();
            nombreUsuario = pNombreUsuario;
            NombreYApellido = interfazNucleo.ObtenerAdministradorPorNombreOMail(nombreUsuario).Nombre + " " + interfazNucleo.ObtenerAdministradorPorNombreOMail(nombreUsuario).Apellido;
            labelNombreUsuario.Text = "Nombre de Usuario: " + nombreUsuario;
            labelNombreYApellido.Text = "Nombre: " + NombreYApellido;
           
        }

        private void Menu2_Load(object sender, EventArgs e)
        {
            CustomizeDosing();
        }
        private void CustomizeDosing()
        {
            submenuusuario.Visible = false;
            submenuadministradores.Visible = false;
            submenuLibros.Visible = false;
            submenuPrestamos.Visible = false;
        }
        private void HideSubmenu()
        {
            if (submenuadministradores.Visible == true)
            {
                submenuadministradores.Visible = false;
            }
            if (submenuusuario.Visible == true)
            {
                submenuusuario.Visible = false;
            }
            if (submenuLibros.Visible == true)
            {
                submenuLibros.Visible = false;
            }
            if (submenuPrestamos.Visible == true)
            {
                submenuPrestamos.Visible = false;
            }
        }
        private void ShowSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                HideSubmenu();
                submenu.Visible = true;
            }
            else { submenu.Visible = false; }
        }










        private void button1_Click_1(object sender, EventArgs e)
        {
            ShowSubMenu(submenuusuario);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ShowSubMenu(submenuadministradores);
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            ShowSubMenu(submenuLibros);
        }

        private void button25_Click_1(object sender, EventArgs e)
        {
            ShowSubMenu(submenuPrestamos);
        }
        private void submenuPrestamos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Login ventana = new Login();
            this.Hide();
            ventana.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Login ventana = new Login();
            this.Hide();
            ventana.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrarUsuario ventanaAgregarCliente = new RegistrarUsuario(nombreUsuario);
            ventanaAgregarCliente.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConsultarUsuario ventana = new ConsultarUsuario(nombreUsuario);
            this.Hide();
            ventana.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ActualizarUsuario ventana = new ActualizarUsuario(nombreUsuario);
            this.Hide();
            ventana.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            VerUsuarios ventana = new VerUsuarios(nombreUsuario);
            this.Hide();
            ventana.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrarAdministrador ventana = new RegistrarAdministrador(nombreUsuario);
            ventana.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            GestionarLibros ventana = new GestionarLibros(nombreUsuario);
            this.Hide();
            ventana.ShowDialog(this);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultarAdministrador ventana = new ConsultarAdministrador(nombreUsuario);
            ventana.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ActualizarAdministrador ventana = new ActualizarAdministrador(nombreUsuario);
            this.Hide();
            ventana.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            VerAdministradores ventana = new VerAdministradores(nombreUsuario);
            this.Hide();
            ventana.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            RegistrarEjemplar ventana = new RegistrarEjemplar(nombreUsuario);
            this.Hide();
            ventana.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            RegistrarLibro ventana = new RegistrarLibro(nombreUsuario);
            this.Hide();
            ventana.ShowDialog(this);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            VerLibros ventana = new VerLibros(nombreUsuario);
            this.Hide();
            ventana.Show();
        }

       

        private void button18_Click(object sender, EventArgs e)
        {
            ConsultarEjemplara ventana = new ConsultarEjemplara(nombreUsuario);
            this.Hide();
            ventana.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            ActualizarEjemplar ventana = new ActualizarEjemplar(nombreUsuario);
            this.Hide();
            ventana.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            VerEjemplares ventana = new VerEjemplares(nombreUsuario);
            this.Hide();
            ventana.Show();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            RegistrarPrestamo ventana = new RegistrarPrestamo(nombreUsuario);
            this.Hide();
            ventana.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            ConsultarPrestamo ventana = new ConsultarPrestamo(nombreUsuario);
            this.Hide();
            ventana.Show();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            RegistrarDevolucion ventana = new RegistrarDevolucion(nombreUsuario);
            this.Hide();
            ventana.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            VerPrestamos ventana = new VerPrestamos(nombreUsuario);
            this.Hide();
            ventana.Show();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            VerPrestamosProximosAVencer ventana = new VerPrestamosProximosAVencer(nombreUsuario);
            this.Hide();
            ventana.Show();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            VerPrestamosRetrasados ventana = new VerPrestamosRetrasados(nombreUsuario);
            this.Hide();
            ventana.Show();
        }

        private void Menu2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void labelId_Click(object sender, EventArgs e)
        {

        }
    }
}
