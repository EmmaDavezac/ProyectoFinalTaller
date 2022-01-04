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
    public partial class EditarPrestamo : Form
    {
        private int idPrestamo;
        private InterfazNucleo interfazNucleo = new InterfazNucleo();
        public EditarPrestamo()
        {
            idPrestamo = 0;
            InitializeComponent();
        }

        private void EditarPrestamo_Load(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }
        public void InicialiarEditarPrestamo(int pIdPrestamo, string pFechaPrestamo, string pFechaLimite)
        {
            textBoxFechaPrestamo.Text = pFechaPrestamo;
            textBoxFechaLimite.Text = pFechaLimite;
            idPrestamo = pIdPrestamo;
        }

        private void buttonModificarFechas_Click(object sender, EventArgs e)
        {
            interfazNucleo.ModificarFechasPrestamo(idPrestamo, textBoxFechaPrestamo.Text, textBoxFechaLimite.Text);
            this.Hide();
            this.Owner.Show();
            ((GestionarPrestamos)this.Owner).ObtenerPrestamos();
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }
    }
}