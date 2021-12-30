
namespace Programa
{
    partial class ActualizarLibro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.botonVolver = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.textBoxAñoPublicacion = new System.Windows.Forms.TextBox();
            this.textBoxAutor = new System.Windows.Forms.TextBox();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.buttonDeshacerCambios = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.labelNombreUsuario = new System.Windows.Forms.Label();
            this.labelResultados = new System.Windows.Forms.Label();
            this.buttonBusquedaEnAPI = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonAñadirEjemplares = new System.Windows.Forms.Button();
            this.textBoxAñadirEjemplares = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxEliminarEjemplares = new System.Windows.Forms.TextBox();
            this.buttonEliminarEjemplares = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.checkBoxBaja = new System.Windows.Forms.CheckBox();
            this.labelCantidadActual = new System.Windows.Forms.Label();
            this.labelErrorEliminarEjemplares = new System.Windows.Forms.Label();
            this.labelErrorAñadirEjemplares = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Location = new System.Drawing.Point(286, 217);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(300, 20);
            this.textBoxISBN.TabIndex = 38;
            this.textBoxISBN.TextChanged += new System.EventHandler(this.textBoxISBN_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "ISBN";
            // 
            // botonVolver
            // 
            this.botonVolver.BackColor = System.Drawing.SystemColors.Highlight;
            this.botonVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.botonVolver.FlatAppearance.BorderSize = 0;
            this.botonVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonVolver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.botonVolver.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.botonVolver.Location = new System.Drawing.Point(592, 526);
            this.botonVolver.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(89, 23);
            this.botonVolver.TabIndex = 35;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = false;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonGuardar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonGuardar.Enabled = false;
            this.buttonGuardar.FlatAppearance.BorderSize = 0;
            this.buttonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonGuardar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonGuardar.Location = new System.Drawing.Point(686, 526);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(89, 23);
            this.buttonGuardar.TabIndex = 34;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // textBoxAñoPublicacion
            // 
            this.textBoxAñoPublicacion.Location = new System.Drawing.Point(286, 191);
            this.textBoxAñoPublicacion.Name = "textBoxAñoPublicacion";
            this.textBoxAñoPublicacion.Size = new System.Drawing.Size(300, 20);
            this.textBoxAñoPublicacion.TabIndex = 31;
            this.textBoxAñoPublicacion.TextChanged += new System.EventHandler(this.textBoxAñoPublicacion_TextChanged);
            // 
            // textBoxAutor
            // 
            this.textBoxAutor.Location = new System.Drawing.Point(286, 165);
            this.textBoxAutor.Name = "textBoxAutor";
            this.textBoxAutor.Size = new System.Drawing.Size(300, 20);
            this.textBoxAutor.TabIndex = 30;
            this.textBoxAutor.TextChanged += new System.EventHandler(this.textBoxAutor_TextChanged);
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(286, 139);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(300, 20);
            this.textBoxTitulo.TabIndex = 29;
            this.textBoxTitulo.TextChanged += new System.EventHandler(this.textBoxTitulo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Autor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Titulo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Año publicacion";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(137, 240);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 45;
            // 
            // buttonDeshacerCambios
            // 
            this.buttonDeshacerCambios.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonDeshacerCambios.Enabled = false;
            this.buttonDeshacerCambios.FlatAppearance.BorderSize = 0;
            this.buttonDeshacerCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeshacerCambios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDeshacerCambios.Location = new System.Drawing.Point(350, 243);
            this.buttonDeshacerCambios.Name = "buttonDeshacerCambios";
            this.buttonDeshacerCambios.Size = new System.Drawing.Size(107, 23);
            this.buttonDeshacerCambios.TabIndex = 46;
            this.buttonDeshacerCambios.Text = "Deshacer cambios";
            this.buttonDeshacerCambios.UseVisualStyleBackColor = false;
            this.buttonDeshacerCambios.Click += new System.EventHandler(this.buttonBorrarCambios_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(784, 60);
            this.panel3.TabIndex = 72;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(82, 60);
            this.panel4.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label7.Location = new System.Drawing.Point(12, 44);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "E-Librery";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Programa.Properties.Resources.libro_abierto;
            this.pictureBox2.Location = new System.Drawing.Point(16, 3);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel5.Controls.Add(this.pictureBox4);
            this.panel5.Controls.Add(this.labelNombreUsuario);
            this.panel5.Location = new System.Drawing.Point(566, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(207, 60);
            this.panel5.TabIndex = 9;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::Programa.Properties.Resources.perfil_del_usuario;
            this.pictureBox4.Location = new System.Drawing.Point(155, 12);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // labelNombreUsuario
            // 
            this.labelNombreUsuario.AutoSize = true;
            this.labelNombreUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNombreUsuario.Location = new System.Drawing.Point(8, 16);
            this.labelNombreUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 5, 0);
            this.labelNombreUsuario.Name = "labelNombreUsuario";
            this.labelNombreUsuario.Size = new System.Drawing.Size(84, 13);
            this.labelNombreUsuario.TabIndex = 0;
            this.labelNombreUsuario.Text = "Nombre Apellido";
            this.labelNombreUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelResultados
            // 
            this.labelResultados.AutoSize = true;
            this.labelResultados.ForeColor = System.Drawing.Color.Red;
            this.labelResultados.Location = new System.Drawing.Point(31, 282);
            this.labelResultados.Name = "labelResultados";
            this.labelResultados.Size = new System.Drawing.Size(0, 13);
            this.labelResultados.TabIndex = 84;
            // 
            // buttonBusquedaEnAPI
            // 
            this.buttonBusquedaEnAPI.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonBusquedaEnAPI.FlatAppearance.BorderSize = 0;
            this.buttonBusquedaEnAPI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBusquedaEnAPI.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBusquedaEnAPI.Location = new System.Drawing.Point(463, 243);
            this.buttonBusquedaEnAPI.Name = "buttonBusquedaEnAPI";
            this.buttonBusquedaEnAPI.Size = new System.Drawing.Size(123, 23);
            this.buttonBusquedaEnAPI.TabIndex = 87;
            this.buttonBusquedaEnAPI.Text = "Busqueda avanzada";
            this.buttonBusquedaEnAPI.UseVisualStyleBackColor = false;
            this.buttonBusquedaEnAPI.Click += new System.EventHandler(this.buttonEnAPI_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 88;
            this.label4.Text = "Modificar datos:";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 13);
            this.label8.TabIndex = 89;
            this.label8.Text = "Añadir o Eliminar Ejemplares:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // buttonAñadirEjemplares
            // 
            this.buttonAñadirEjemplares.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonAñadirEjemplares.FlatAppearance.BorderSize = 0;
            this.buttonAñadirEjemplares.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAñadirEjemplares.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAñadirEjemplares.Location = new System.Drawing.Point(236, 384);
            this.buttonAñadirEjemplares.Name = "buttonAñadirEjemplares";
            this.buttonAñadirEjemplares.Size = new System.Drawing.Size(107, 23);
            this.buttonAñadirEjemplares.TabIndex = 90;
            this.buttonAñadirEjemplares.Text = "Añadir Ejemplares";
            this.buttonAñadirEjemplares.UseVisualStyleBackColor = false;
            this.buttonAñadirEjemplares.Click += new System.EventHandler(this.buttonAñadirEjemplares_Click);
            // 
            // textBoxAñadirEjemplares
            // 
            this.textBoxAñadirEjemplares.Location = new System.Drawing.Point(236, 358);
            this.textBoxAñadirEjemplares.Name = "textBoxAñadirEjemplares";
            this.textBoxAñadirEjemplares.Size = new System.Drawing.Size(117, 20);
            this.textBoxAñadirEjemplares.TabIndex = 91;
            this.textBoxAñadirEjemplares.TextChanged += new System.EventHandler(this.textBoxAñadirEjemplares_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(62, 361);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 13);
            this.label9.TabIndex = 92;
            this.label9.Text = "Ingrese la cantidad de ejemplares:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(369, 361);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(168, 13);
            this.label10.TabIndex = 95;
            this.label10.Text = "Ingrese la cantidad de ejemplares:";
            // 
            // textBoxEliminarEjemplares
            // 
            this.textBoxEliminarEjemplares.Location = new System.Drawing.Point(543, 358);
            this.textBoxEliminarEjemplares.Name = "textBoxEliminarEjemplares";
            this.textBoxEliminarEjemplares.Size = new System.Drawing.Size(117, 20);
            this.textBoxEliminarEjemplares.TabIndex = 94;
            this.textBoxEliminarEjemplares.TextChanged += new System.EventHandler(this.textBoxEliminarEjemplares_TextChanged);
            // 
            // buttonEliminarEjemplares
            // 
            this.buttonEliminarEjemplares.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonEliminarEjemplares.FlatAppearance.BorderSize = 0;
            this.buttonEliminarEjemplares.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminarEjemplares.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEliminarEjemplares.Location = new System.Drawing.Point(543, 384);
            this.buttonEliminarEjemplares.Name = "buttonEliminarEjemplares";
            this.buttonEliminarEjemplares.Size = new System.Drawing.Size(107, 23);
            this.buttonEliminarEjemplares.TabIndex = 93;
            this.buttonEliminarEjemplares.Text = "Eliminar Ejemplares";
            this.buttonEliminarEjemplares.UseVisualStyleBackColor = false;
            this.buttonEliminarEjemplares.Click += new System.EventHandler(this.buttonEliminarEjemplares_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(31, 448);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 13);
            this.label11.TabIndex = 96;
            this.label11.Text = "Dar de baja el libro:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // checkBoxBaja
            // 
            this.checkBoxBaja.AutoSize = true;
            this.checkBoxBaja.Location = new System.Drawing.Point(154, 448);
            this.checkBoxBaja.Name = "checkBoxBaja";
            this.checkBoxBaja.Size = new System.Drawing.Size(47, 17);
            this.checkBoxBaja.TabIndex = 97;
            this.checkBoxBaja.Text = "Baja";
            this.checkBoxBaja.UseVisualStyleBackColor = true;
            this.checkBoxBaja.CheckedChanged += new System.EventHandler(this.checkBoxBaja_CheckedChanged);
            // 
            // labelCantidadActual
            // 
            this.labelCantidadActual.AutoSize = true;
            this.labelCantidadActual.Location = new System.Drawing.Point(207, 312);
            this.labelCantidadActual.Name = "labelCantidadActual";
            this.labelCantidadActual.Size = new System.Drawing.Size(85, 13);
            this.labelCantidadActual.TabIndex = 98;
            this.labelCantidadActual.Text = "Cantidad Actual:";
            // 
            // labelErrorEliminarEjemplares
            // 
            this.labelErrorEliminarEjemplares.AutoSize = true;
            this.labelErrorEliminarEjemplares.ForeColor = System.Drawing.Color.Red;
            this.labelErrorEliminarEjemplares.Location = new System.Drawing.Point(540, 342);
            this.labelErrorEliminarEjemplares.Name = "labelErrorEliminarEjemplares";
            this.labelErrorEliminarEjemplares.Size = new System.Drawing.Size(28, 13);
            this.labelErrorEliminarEjemplares.TabIndex = 99;
            this.labelErrorEliminarEjemplares.Text = "error";
            this.labelErrorEliminarEjemplares.Visible = false;
            // 
            // labelErrorAñadirEjemplares
            // 
            this.labelErrorAñadirEjemplares.AutoSize = true;
            this.labelErrorAñadirEjemplares.ForeColor = System.Drawing.Color.Red;
            this.labelErrorAñadirEjemplares.Location = new System.Drawing.Point(233, 342);
            this.labelErrorAñadirEjemplares.Name = "labelErrorAñadirEjemplares";
            this.labelErrorAñadirEjemplares.Size = new System.Drawing.Size(28, 13);
            this.labelErrorAñadirEjemplares.TabIndex = 100;
            this.labelErrorAñadirEjemplares.Text = "error";
            this.labelErrorAñadirEjemplares.Visible = false;
            // 
            // ActualizarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.labelErrorAñadirEjemplares);
            this.Controls.Add(this.labelErrorEliminarEjemplares);
            this.Controls.Add(this.labelCantidadActual);
            this.Controls.Add(this.checkBoxBaja);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxEliminarEjemplares);
            this.Controls.Add(this.buttonEliminarEjemplares);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxAñadirEjemplares);
            this.Controls.Add(this.buttonAñadirEjemplares);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonBusquedaEnAPI);
            this.Controls.Add(this.labelResultados);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.buttonDeshacerCambios);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.textBoxISBN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.textBoxAñoPublicacion);
            this.Controls.Add(this.textBoxAutor);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "ActualizarLibro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ActualizarLibro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ActualizarLibro_FormClosed);
            this.Load += new System.EventHandler(this.ActualizarLibro_Load);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.TextBox textBoxAñoPublicacion;
        private System.Windows.Forms.TextBox textBoxAutor;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn AñoPublicacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button buttonDeshacerCambios;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label labelNombreUsuario;
        private System.Windows.Forms.Label labelResultados;
        private System.Windows.Forms.Button buttonBusquedaEnAPI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonAñadirEjemplares;
        private System.Windows.Forms.TextBox textBoxAñadirEjemplares;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxEliminarEjemplares;
        private System.Windows.Forms.Button buttonEliminarEjemplares;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkBoxBaja;
        private System.Windows.Forms.Label labelCantidadActual;
        private System.Windows.Forms.Label labelErrorEliminarEjemplares;
        private System.Windows.Forms.Label labelErrorAñadirEjemplares;
    }
}