﻿
namespace Programa
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.botonVolver = new System.Windows.Forms.Button();
            this.labelNombreUsuario = new System.Windows.Forms.Label();
            this.botonVerUsuarios = new System.Windows.Forms.Button();
            this.botonBuscarUsuario = new System.Windows.Forms.Button();
            this.botonRegistrarUsuario = new System.Windows.Forms.Button();
            this.buttonActualizarUsuario = new System.Windows.Forms.Button();
            this.groupBoxUsuarios = new System.Windows.Forms.GroupBox();
            this.buttonVerLibros = new System.Windows.Forms.Button();
            this.buttonBuscarLibro = new System.Windows.Forms.Button();
            this.buttonAñadirLibro = new System.Windows.Forms.Button();
            this.buttonActualizarLibro = new System.Windows.Forms.Button();
            this.groupBoxLibros = new System.Windows.Forms.GroupBox();
            this.buttonVerPrestamos = new System.Windows.Forms.Button();
            this.buttonBuscarPrestamo = new System.Windows.Forms.Button();
            this.buttonRegistrarPrestamo = new System.Windows.Forms.Button();
            this.buttonRegistrarDevolucion = new System.Windows.Forms.Button();
            this.groupBoxPrestamos = new System.Windows.Forms.GroupBox();
            this.buttonPrestamosRetrasados = new System.Windows.Forms.Button();
            this.buttonVerProximosAVencer = new System.Windows.Forms.Button();
            this.buttonVerAdministradores = new System.Windows.Forms.Button();
            this.buttonBuscarAdministrador = new System.Windows.Forms.Button();
            this.buttonRegistrarAdministrador = new System.Windows.Forms.Button();
            this.buttonModificarAdministrador = new System.Windows.Forms.Button();
            this.groupBoxAdministradores = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonRegistrarEjemplar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxEjemplares = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBoxUsuarios.SuspendLayout();
            this.groupBoxLibros.SuspendLayout();
            this.groupBoxPrestamos.SuspendLayout();
            this.groupBoxAdministradores.SuspendLayout();
            this.groupBoxEjemplares.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonVolver
            // 
            this.botonVolver.BackColor = System.Drawing.SystemColors.Highlight;
            this.botonVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.botonVolver.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.botonVolver, "botonVolver");
            this.botonVolver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.UseVisualStyleBackColor = false;
            this.botonVolver.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // labelNombreUsuario
            // 
            this.labelNombreUsuario.BackColor = System.Drawing.SystemColors.Highlight;
            this.labelNombreUsuario.ForeColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.labelNombreUsuario, "labelNombreUsuario");
            this.labelNombreUsuario.Name = "labelNombreUsuario";
            this.labelNombreUsuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // botonVerUsuarios
            // 
            this.botonVerUsuarios.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.botonVerUsuarios, "botonVerUsuarios");
            this.botonVerUsuarios.Name = "botonVerUsuarios";
            this.botonVerUsuarios.UseVisualStyleBackColor = true;
            this.botonVerUsuarios.Click += new System.EventHandler(this.botonVerUsuarios_Click);
            // 
            // botonBuscarUsuario
            // 
            this.botonBuscarUsuario.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.botonBuscarUsuario, "botonBuscarUsuario");
            this.botonBuscarUsuario.Name = "botonBuscarUsuario";
            this.botonBuscarUsuario.UseVisualStyleBackColor = true;
            this.botonBuscarUsuario.Click += new System.EventHandler(this.botonBuscarUsuario_Click);
            // 
            // botonRegistrarUsuario
            // 
            this.botonRegistrarUsuario.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.botonRegistrarUsuario, "botonRegistrarUsuario");
            this.botonRegistrarUsuario.Name = "botonRegistrarUsuario";
            this.botonRegistrarUsuario.TabStop = false;
            this.botonRegistrarUsuario.UseVisualStyleBackColor = true;
            this.botonRegistrarUsuario.Click += new System.EventHandler(this.botonAñadirUsuario_Click);
            // 
            // buttonActualizarUsuario
            // 
            this.buttonActualizarUsuario.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.buttonActualizarUsuario, "buttonActualizarUsuario");
            this.buttonActualizarUsuario.Name = "buttonActualizarUsuario";
            this.buttonActualizarUsuario.UseVisualStyleBackColor = true;
            this.buttonActualizarUsuario.Click += new System.EventHandler(this.buttonActualizarUsuario_Click);
            // 
            // groupBoxUsuarios
            // 
            this.groupBoxUsuarios.Controls.Add(this.buttonActualizarUsuario);
            this.groupBoxUsuarios.Controls.Add(this.botonRegistrarUsuario);
            this.groupBoxUsuarios.Controls.Add(this.botonBuscarUsuario);
            this.groupBoxUsuarios.Controls.Add(this.botonVerUsuarios);
            this.groupBoxUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.groupBoxUsuarios, "groupBoxUsuarios");
            this.groupBoxUsuarios.Name = "groupBoxUsuarios";
            this.groupBoxUsuarios.TabStop = false;
            this.groupBoxUsuarios.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonVerLibros
            // 
            this.buttonVerLibros.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.buttonVerLibros, "buttonVerLibros");
            this.buttonVerLibros.Name = "buttonVerLibros";
            this.buttonVerLibros.UseVisualStyleBackColor = true;
            this.buttonVerLibros.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonBuscarLibro
            // 
            this.buttonBuscarLibro.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.buttonBuscarLibro, "buttonBuscarLibro");
            this.buttonBuscarLibro.Name = "buttonBuscarLibro";
            this.buttonBuscarLibro.UseVisualStyleBackColor = true;
            this.buttonBuscarLibro.Click += new System.EventHandler(this.buttonBuscarLibro_Click);
            // 
            // buttonAñadirLibro
            // 
            this.buttonAñadirLibro.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.buttonAñadirLibro, "buttonAñadirLibro");
            this.buttonAñadirLibro.Name = "buttonAñadirLibro";
            this.buttonAñadirLibro.TabStop = false;
            this.buttonAñadirLibro.UseVisualStyleBackColor = true;
            this.buttonAñadirLibro.Click += new System.EventHandler(this.buttonAñadirLibro_Click);
            // 
            // buttonActualizarLibro
            // 
            this.buttonActualizarLibro.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.buttonActualizarLibro, "buttonActualizarLibro");
            this.buttonActualizarLibro.Name = "buttonActualizarLibro";
            this.buttonActualizarLibro.UseVisualStyleBackColor = true;
            this.buttonActualizarLibro.Click += new System.EventHandler(this.buttonActualizarLibro_Click);
            // 
            // groupBoxLibros
            // 
            this.groupBoxLibros.Controls.Add(this.buttonActualizarLibro);
            this.groupBoxLibros.Controls.Add(this.buttonAñadirLibro);
            this.groupBoxLibros.Controls.Add(this.buttonBuscarLibro);
            this.groupBoxLibros.Controls.Add(this.buttonVerLibros);
            this.groupBoxLibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.groupBoxLibros, "groupBoxLibros");
            this.groupBoxLibros.Name = "groupBoxLibros";
            this.groupBoxLibros.TabStop = false;
            // 
            // buttonVerPrestamos
            // 
            this.buttonVerPrestamos.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.buttonVerPrestamos, "buttonVerPrestamos");
            this.buttonVerPrestamos.Name = "buttonVerPrestamos";
            this.buttonVerPrestamos.UseVisualStyleBackColor = true;
            this.buttonVerPrestamos.Click += new System.EventHandler(this.buttonVerPrestamos_Click);
            // 
            // buttonBuscarPrestamo
            // 
            this.buttonBuscarPrestamo.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.buttonBuscarPrestamo, "buttonBuscarPrestamo");
            this.buttonBuscarPrestamo.Name = "buttonBuscarPrestamo";
            this.buttonBuscarPrestamo.UseVisualStyleBackColor = true;
            this.buttonBuscarPrestamo.Click += new System.EventHandler(this.buttonBuscarPrestamo_Click);
            // 
            // buttonRegistrarPrestamo
            // 
            this.buttonRegistrarPrestamo.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.buttonRegistrarPrestamo, "buttonRegistrarPrestamo");
            this.buttonRegistrarPrestamo.Name = "buttonRegistrarPrestamo";
            this.buttonRegistrarPrestamo.TabStop = false;
            this.buttonRegistrarPrestamo.UseVisualStyleBackColor = true;
            this.buttonRegistrarPrestamo.Click += new System.EventHandler(this.buttonRegistrarPrestamo_Click);
            // 
            // buttonRegistrarDevolucion
            // 
            this.buttonRegistrarDevolucion.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.buttonRegistrarDevolucion, "buttonRegistrarDevolucion");
            this.buttonRegistrarDevolucion.Name = "buttonRegistrarDevolucion";
            this.buttonRegistrarDevolucion.UseVisualStyleBackColor = true;
            this.buttonRegistrarDevolucion.Click += new System.EventHandler(this.buttonRegistrarDevolucion_Click);
            // 
            // groupBoxPrestamos
            // 
            this.groupBoxPrestamos.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxPrestamos.Controls.Add(this.buttonPrestamosRetrasados);
            this.groupBoxPrestamos.Controls.Add(this.buttonVerProximosAVencer);
            this.groupBoxPrestamos.Controls.Add(this.buttonRegistrarDevolucion);
            this.groupBoxPrestamos.Controls.Add(this.buttonRegistrarPrestamo);
            this.groupBoxPrestamos.Controls.Add(this.buttonBuscarPrestamo);
            this.groupBoxPrestamos.Controls.Add(this.buttonVerPrestamos);
            this.groupBoxPrestamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.groupBoxPrestamos, "groupBoxPrestamos");
            this.groupBoxPrestamos.Name = "groupBoxPrestamos";
            this.groupBoxPrestamos.TabStop = false;
            this.groupBoxPrestamos.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // buttonPrestamosRetrasados
            // 
            this.buttonPrestamosRetrasados.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.buttonPrestamosRetrasados, "buttonPrestamosRetrasados");
            this.buttonPrestamosRetrasados.Name = "buttonPrestamosRetrasados";
            this.buttonPrestamosRetrasados.TabStop = false;
            this.buttonPrestamosRetrasados.UseVisualStyleBackColor = true;
            this.buttonPrestamosRetrasados.Click += new System.EventHandler(this.buttonPrestamosRetrasados_Click);
            // 
            // buttonVerProximosAVencer
            // 
            this.buttonVerProximosAVencer.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.buttonVerProximosAVencer, "buttonVerProximosAVencer");
            this.buttonVerProximosAVencer.Name = "buttonVerProximosAVencer";
            this.buttonVerProximosAVencer.UseVisualStyleBackColor = true;
            this.buttonVerProximosAVencer.Click += new System.EventHandler(this.buttonVerProximosAVencer_Click);
            // 
            // buttonVerAdministradores
            // 
            this.buttonVerAdministradores.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.buttonVerAdministradores, "buttonVerAdministradores");
            this.buttonVerAdministradores.Name = "buttonVerAdministradores";
            this.buttonVerAdministradores.UseVisualStyleBackColor = true;
            this.buttonVerAdministradores.Click += new System.EventHandler(this.buttonVerAdministradores_Click);
            // 
            // buttonBuscarAdministrador
            // 
            this.buttonBuscarAdministrador.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.buttonBuscarAdministrador, "buttonBuscarAdministrador");
            this.buttonBuscarAdministrador.Name = "buttonBuscarAdministrador";
            this.buttonBuscarAdministrador.UseVisualStyleBackColor = true;
            this.buttonBuscarAdministrador.Click += new System.EventHandler(this.buttonBuscarAdministrador_Click);
            // 
            // buttonRegistrarAdministrador
            // 
            this.buttonRegistrarAdministrador.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.buttonRegistrarAdministrador, "buttonRegistrarAdministrador");
            this.buttonRegistrarAdministrador.Name = "buttonRegistrarAdministrador";
            this.buttonRegistrarAdministrador.TabStop = false;
            this.buttonRegistrarAdministrador.UseVisualStyleBackColor = true;
            this.buttonRegistrarAdministrador.Click += new System.EventHandler(this.buttonRegistrarAdministrador_Click);
            // 
            // buttonModificarAdministrador
            // 
            this.buttonModificarAdministrador.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.buttonModificarAdministrador, "buttonModificarAdministrador");
            this.buttonModificarAdministrador.Name = "buttonModificarAdministrador";
            this.buttonModificarAdministrador.UseVisualStyleBackColor = true;
            this.buttonModificarAdministrador.Click += new System.EventHandler(this.buttonModificarAdministrador_Click);
            // 
            // groupBoxAdministradores
            // 
            this.groupBoxAdministradores.Controls.Add(this.button2);
            this.groupBoxAdministradores.Controls.Add(this.buttonModificarAdministrador);
            this.groupBoxAdministradores.Controls.Add(this.buttonRegistrarAdministrador);
            this.groupBoxAdministradores.Controls.Add(this.buttonBuscarAdministrador);
            this.groupBoxAdministradores.Controls.Add(this.buttonVerAdministradores);
            this.groupBoxAdministradores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.groupBoxAdministradores, "groupBoxAdministradores");
            this.groupBoxAdministradores.Name = "groupBoxAdministradores";
            this.groupBoxAdministradores.TabStop = false;
            this.groupBoxAdministradores.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.TabStop = false;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // buttonRegistrarEjemplar
            // 
            this.buttonRegistrarEjemplar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.buttonRegistrarEjemplar, "buttonRegistrarEjemplar");
            this.buttonRegistrarEjemplar.Name = "buttonRegistrarEjemplar";
            this.buttonRegistrarEjemplar.TabStop = false;
            this.buttonRegistrarEjemplar.UseVisualStyleBackColor = true;
            this.buttonRegistrarEjemplar.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBoxEjemplares
            // 
            this.groupBoxEjemplares.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxEjemplares.Controls.Add(this.button1);
            this.groupBoxEjemplares.Controls.Add(this.buttonRegistrarEjemplar);
            this.groupBoxEjemplares.Controls.Add(this.button3);
            this.groupBoxEjemplares.Controls.Add(this.button4);
            this.groupBoxEjemplares.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.groupBoxEjemplares, "groupBoxEjemplares");
            this.groupBoxEjemplares.Name = "groupBoxEjemplares";
            this.groupBoxEjemplares.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MenuPrincipal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.labelNombreUsuario);
            this.Controls.Add(this.groupBoxEjemplares);
            this.Controls.Add(this.groupBoxAdministradores);
            this.Controls.Add(this.groupBoxPrestamos);
            this.Controls.Add(this.groupBoxLibros);
            this.Controls.Add(this.groupBoxUsuarios);
            this.Controls.Add(this.botonVolver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuPrincipal";
            this.Opacity = 0D;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.groupBoxUsuarios.ResumeLayout(false);
            this.groupBoxLibros.ResumeLayout(false);
            this.groupBoxPrestamos.ResumeLayout(false);
            this.groupBoxAdministradores.ResumeLayout(false);
            this.groupBoxEjemplares.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Label labelNombreUsuario;
        private System.Windows.Forms.Button botonVerUsuarios;
        private System.Windows.Forms.Button botonBuscarUsuario;
        private System.Windows.Forms.Button botonRegistrarUsuario;
        private System.Windows.Forms.Button buttonActualizarUsuario;
        private System.Windows.Forms.GroupBox groupBoxUsuarios;
        private System.Windows.Forms.Button buttonVerLibros;
        private System.Windows.Forms.Button buttonBuscarLibro;
        private System.Windows.Forms.Button buttonAñadirLibro;
        private System.Windows.Forms.Button buttonActualizarLibro;
        private System.Windows.Forms.GroupBox groupBoxLibros;
        private System.Windows.Forms.Button buttonVerPrestamos;
        private System.Windows.Forms.Button buttonBuscarPrestamo;
        private System.Windows.Forms.Button buttonRegistrarPrestamo;
        private System.Windows.Forms.Button buttonRegistrarDevolucion;
        private System.Windows.Forms.GroupBox groupBoxPrestamos;
        private System.Windows.Forms.Button buttonVerAdministradores;
        private System.Windows.Forms.Button buttonBuscarAdministrador;
        private System.Windows.Forms.Button buttonRegistrarAdministrador;
        private System.Windows.Forms.Button buttonModificarAdministrador;
        private System.Windows.Forms.GroupBox groupBoxAdministradores;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonRegistrarEjemplar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBoxEjemplares;
        private System.Windows.Forms.Button buttonPrestamosRetrasados;
        private System.Windows.Forms.Button buttonVerProximosAVencer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
    }
}
