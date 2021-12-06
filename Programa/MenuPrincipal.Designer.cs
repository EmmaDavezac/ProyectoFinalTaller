
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
            this.buttonVerUsuarios = new System.Windows.Forms.Button();
            this.buttonBuscarPrestamo = new System.Windows.Forms.Button();
            this.buttonRegistrarPrestamo = new System.Windows.Forms.Button();
            this.buttonRegistrarDevolucion = new System.Windows.Forms.Button();
            this.groupBoxPrestamos = new System.Windows.Forms.GroupBox();
            this.buttonVerAdministradores = new System.Windows.Forms.Button();
            this.buttonBuscarAdministrador = new System.Windows.Forms.Button();
            this.buttonRegistrarAdministrador = new System.Windows.Forms.Button();
            this.buttonModificarAdministrador = new System.Windows.Forms.Button();
            this.groupBoxAdministradores = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonRegistrarEjemplar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxEjemplares = new System.Windows.Forms.GroupBox();
            this.groupBoxUsuarios.SuspendLayout();
            this.groupBoxLibros.SuspendLayout();
            this.groupBoxPrestamos.SuspendLayout();
            this.groupBoxAdministradores.SuspendLayout();
            this.groupBoxEjemplares.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonVolver
            // 
            this.botonVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.botonVolver, "botonVolver");
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // labelNombreUsuario
            // 
            this.labelNombreUsuario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelNombreUsuario.ForeColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.labelNombreUsuario, "labelNombreUsuario");
            this.labelNombreUsuario.Name = "labelNombreUsuario";
            this.labelNombreUsuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // botonVerUsuarios
            // 
            resources.ApplyResources(this.botonVerUsuarios, "botonVerUsuarios");
            this.botonVerUsuarios.Name = "botonVerUsuarios";
            this.botonVerUsuarios.UseVisualStyleBackColor = true;
            this.botonVerUsuarios.Click += new System.EventHandler(this.botonVerUsuarios_Click);
            // 
            // botonBuscarUsuario
            // 
            resources.ApplyResources(this.botonBuscarUsuario, "botonBuscarUsuario");
            this.botonBuscarUsuario.Name = "botonBuscarUsuario";
            this.botonBuscarUsuario.UseVisualStyleBackColor = true;
            this.botonBuscarUsuario.Click += new System.EventHandler(this.botonBuscarUsuario_Click);
            // 
            // botonRegistrarUsuario
            // 
            resources.ApplyResources(this.botonRegistrarUsuario, "botonRegistrarUsuario");
            this.botonRegistrarUsuario.Name = "botonRegistrarUsuario";
            this.botonRegistrarUsuario.TabStop = false;
            this.botonRegistrarUsuario.UseVisualStyleBackColor = true;
            this.botonRegistrarUsuario.Click += new System.EventHandler(this.botonAñadirUsuario_Click);
            // 
            // buttonActualizarUsuario
            // 
            resources.ApplyResources(this.buttonActualizarUsuario, "buttonActualizarUsuario");
            this.buttonActualizarUsuario.Name = "buttonActualizarUsuario";
            this.buttonActualizarUsuario.UseVisualStyleBackColor = true;
            // 
            // groupBoxUsuarios
            // 
            this.groupBoxUsuarios.Controls.Add(this.buttonActualizarUsuario);
            this.groupBoxUsuarios.Controls.Add(this.botonRegistrarUsuario);
            this.groupBoxUsuarios.Controls.Add(this.botonBuscarUsuario);
            this.groupBoxUsuarios.Controls.Add(this.botonVerUsuarios);
            resources.ApplyResources(this.groupBoxUsuarios, "groupBoxUsuarios");
            this.groupBoxUsuarios.Name = "groupBoxUsuarios";
            this.groupBoxUsuarios.TabStop = false;
            this.groupBoxUsuarios.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonVerLibros
            // 
            resources.ApplyResources(this.buttonVerLibros, "buttonVerLibros");
            this.buttonVerLibros.Name = "buttonVerLibros";
            this.buttonVerLibros.UseVisualStyleBackColor = true;
            this.buttonVerLibros.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonBuscarLibro
            // 
            resources.ApplyResources(this.buttonBuscarLibro, "buttonBuscarLibro");
            this.buttonBuscarLibro.Name = "buttonBuscarLibro";
            this.buttonBuscarLibro.UseVisualStyleBackColor = true;
            this.buttonBuscarLibro.Click += new System.EventHandler(this.buttonBuscarLibro_Click);
            // 
            // buttonAñadirLibro
            // 
            resources.ApplyResources(this.buttonAñadirLibro, "buttonAñadirLibro");
            this.buttonAñadirLibro.Name = "buttonAñadirLibro";
            this.buttonAñadirLibro.TabStop = false;
            this.buttonAñadirLibro.UseVisualStyleBackColor = true;
            this.buttonAñadirLibro.Click += new System.EventHandler(this.buttonAñadirLibro_Click);
            // 
            // buttonActualizarLibro
            // 
            resources.ApplyResources(this.buttonActualizarLibro, "buttonActualizarLibro");
            this.buttonActualizarLibro.Name = "buttonActualizarLibro";
            this.buttonActualizarLibro.UseVisualStyleBackColor = true;
            // 
            // groupBoxLibros
            // 
            this.groupBoxLibros.Controls.Add(this.buttonActualizarLibro);
            this.groupBoxLibros.Controls.Add(this.buttonAñadirLibro);
            this.groupBoxLibros.Controls.Add(this.buttonBuscarLibro);
            this.groupBoxLibros.Controls.Add(this.buttonVerLibros);
            resources.ApplyResources(this.groupBoxLibros, "groupBoxLibros");
            this.groupBoxLibros.Name = "groupBoxLibros";
            this.groupBoxLibros.TabStop = false;
            // 
            // buttonVerUsuarios
            // 
            resources.ApplyResources(this.buttonVerUsuarios, "buttonVerUsuarios");
            this.buttonVerUsuarios.Name = "buttonVerUsuarios";
            this.buttonVerUsuarios.UseVisualStyleBackColor = true;
            // 
            // buttonBuscarPrestamo
            // 
            resources.ApplyResources(this.buttonBuscarPrestamo, "buttonBuscarPrestamo");
            this.buttonBuscarPrestamo.Name = "buttonBuscarPrestamo";
            this.buttonBuscarPrestamo.UseVisualStyleBackColor = true;
            // 
            // buttonRegistrarPrestamo
            // 
            resources.ApplyResources(this.buttonRegistrarPrestamo, "buttonRegistrarPrestamo");
            this.buttonRegistrarPrestamo.Name = "buttonRegistrarPrestamo";
            this.buttonRegistrarPrestamo.TabStop = false;
            this.buttonRegistrarPrestamo.UseVisualStyleBackColor = true;
            this.buttonRegistrarPrestamo.Click += new System.EventHandler(this.buttonRegistrarPrestamo_Click);
            // 
            // buttonRegistrarDevolucion
            // 
            resources.ApplyResources(this.buttonRegistrarDevolucion, "buttonRegistrarDevolucion");
            this.buttonRegistrarDevolucion.Name = "buttonRegistrarDevolucion";
            this.buttonRegistrarDevolucion.UseVisualStyleBackColor = true;
            // 
            // groupBoxPrestamos
            // 
            this.groupBoxPrestamos.Controls.Add(this.buttonRegistrarDevolucion);
            this.groupBoxPrestamos.Controls.Add(this.buttonRegistrarPrestamo);
            this.groupBoxPrestamos.Controls.Add(this.buttonBuscarPrestamo);
            this.groupBoxPrestamos.Controls.Add(this.buttonVerUsuarios);
            resources.ApplyResources(this.groupBoxPrestamos, "groupBoxPrestamos");
            this.groupBoxPrestamos.Name = "groupBoxPrestamos";
            this.groupBoxPrestamos.TabStop = false;
            this.groupBoxPrestamos.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // buttonVerAdministradores
            // 
            resources.ApplyResources(this.buttonVerAdministradores, "buttonVerAdministradores");
            this.buttonVerAdministradores.Name = "buttonVerAdministradores";
            this.buttonVerAdministradores.UseVisualStyleBackColor = true;
            this.buttonVerAdministradores.Click += new System.EventHandler(this.buttonVerAdministradores_Click);
            // 
            // buttonBuscarAdministrador
            // 
            resources.ApplyResources(this.buttonBuscarAdministrador, "buttonBuscarAdministrador");
            this.buttonBuscarAdministrador.Name = "buttonBuscarAdministrador";
            this.buttonBuscarAdministrador.UseVisualStyleBackColor = true;
            this.buttonBuscarAdministrador.Click += new System.EventHandler(this.buttonBuscarAdministrador_Click);
            // 
            // buttonRegistrarAdministrador
            // 
            resources.ApplyResources(this.buttonRegistrarAdministrador, "buttonRegistrarAdministrador");
            this.buttonRegistrarAdministrador.Name = "buttonRegistrarAdministrador";
            this.buttonRegistrarAdministrador.TabStop = false;
            this.buttonRegistrarAdministrador.UseVisualStyleBackColor = true;
            this.buttonRegistrarAdministrador.Click += new System.EventHandler(this.buttonRegistrarAdministrador_Click);
            // 
            // buttonModificarAdministrador
            // 
            resources.ApplyResources(this.buttonModificarAdministrador, "buttonModificarAdministrador");
            this.buttonModificarAdministrador.Name = "buttonModificarAdministrador";
            this.buttonModificarAdministrador.UseVisualStyleBackColor = true;
            // 
            // groupBoxAdministradores
            // 
            this.groupBoxAdministradores.Controls.Add(this.buttonModificarAdministrador);
            this.groupBoxAdministradores.Controls.Add(this.buttonRegistrarAdministrador);
            this.groupBoxAdministradores.Controls.Add(this.buttonBuscarAdministrador);
            this.groupBoxAdministradores.Controls.Add(this.buttonVerAdministradores);
            resources.ApplyResources(this.groupBoxAdministradores, "groupBoxAdministradores");
            this.groupBoxAdministradores.Name = "groupBoxAdministradores";
            this.groupBoxAdministradores.TabStop = false;
            this.groupBoxAdministradores.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // buttonRegistrarEjemplar
            // 
            resources.ApplyResources(this.buttonRegistrarEjemplar, "buttonRegistrarEjemplar");
            this.buttonRegistrarEjemplar.Name = "buttonRegistrarEjemplar";
            this.buttonRegistrarEjemplar.TabStop = false;
            this.buttonRegistrarEjemplar.UseVisualStyleBackColor = true;
            this.buttonRegistrarEjemplar.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBoxEjemplares
            // 
            this.groupBoxEjemplares.Controls.Add(this.button1);
            this.groupBoxEjemplares.Controls.Add(this.buttonRegistrarEjemplar);
            this.groupBoxEjemplares.Controls.Add(this.button3);
            this.groupBoxEjemplares.Controls.Add(this.button4);
            resources.ApplyResources(this.groupBoxEjemplares, "groupBoxEjemplares");
            this.groupBoxEjemplares.Name = "groupBoxEjemplares";
            this.groupBoxEjemplares.TabStop = false;
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
        private System.Windows.Forms.Button buttonVerUsuarios;
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
    }
}

