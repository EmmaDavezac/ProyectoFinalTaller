
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActualizarLibro));
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
            this.labelResultados = new System.Windows.Forms.Label();
            this.buttonBusquedaAvanzada = new System.Windows.Forms.Button();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Location = new System.Drawing.Point(214, 156);
            this.textBoxISBN.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(399, 22);
            this.textBoxISBN.TabIndex = 38;
            this.textBoxISBN.TextChanged += new System.EventHandler(this.textBoxISBN_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 165);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
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
            this.botonVolver.Location = new System.Drawing.Point(750, 640);
            this.botonVolver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(119, 28);
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
            this.buttonGuardar.Location = new System.Drawing.Point(875, 640);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(119, 28);
            this.buttonGuardar.TabIndex = 34;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // textBoxAñoPublicacion
            // 
            this.textBoxAñoPublicacion.Location = new System.Drawing.Point(214, 124);
            this.textBoxAñoPublicacion.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAñoPublicacion.Name = "textBoxAñoPublicacion";
            this.textBoxAñoPublicacion.Size = new System.Drawing.Size(399, 22);
            this.textBoxAñoPublicacion.TabIndex = 31;
            this.textBoxAñoPublicacion.TextChanged += new System.EventHandler(this.textBoxAñoPublicacion_TextChanged);
            // 
            // textBoxAutor
            // 
            this.textBoxAutor.Location = new System.Drawing.Point(214, 92);
            this.textBoxAutor.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAutor.Name = "textBoxAutor";
            this.textBoxAutor.Size = new System.Drawing.Size(399, 22);
            this.textBoxAutor.TabIndex = 30;
            this.textBoxAutor.TextChanged += new System.EventHandler(this.textBoxAutor_TextChanged);
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(214, 60);
            this.textBoxTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(399, 22);
            this.textBoxTitulo.TabIndex = 29;
            this.textBoxTitulo.TextChanged += new System.EventHandler(this.textBoxTitulo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Autor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Titulo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Año publicacion";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(17, 152);
            this.labelError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 16);
            this.labelError.TabIndex = 45;
            // 
            // buttonDeshacerCambios
            // 
            this.buttonDeshacerCambios.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonDeshacerCambios.Enabled = false;
            this.buttonDeshacerCambios.FlatAppearance.BorderSize = 0;
            this.buttonDeshacerCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeshacerCambios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDeshacerCambios.Location = new System.Drawing.Point(300, 188);
            this.buttonDeshacerCambios.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDeshacerCambios.Name = "buttonDeshacerCambios";
            this.buttonDeshacerCambios.Size = new System.Drawing.Size(143, 28);
            this.buttonDeshacerCambios.TabIndex = 46;
            this.buttonDeshacerCambios.Text = "Deshacer cambios";
            this.buttonDeshacerCambios.UseVisualStyleBackColor = false;
            this.buttonDeshacerCambios.Click += new System.EventHandler(this.buttonDeshacerCambios_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1006, 74);
            this.panel3.TabIndex = 72;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(109, 74);
            this.panel4.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label7.Location = new System.Drawing.Point(16, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "E-Librery";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Programa.Properties.Resources.libro_abierto;
            this.pictureBox2.Location = new System.Drawing.Point(21, 4);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // labelResultados
            // 
            this.labelResultados.AutoSize = true;
            this.labelResultados.ForeColor = System.Drawing.Color.Red;
            this.labelResultados.Location = new System.Drawing.Point(48, 200);
            this.labelResultados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResultados.Name = "labelResultados";
            this.labelResultados.Size = new System.Drawing.Size(0, 16);
            this.labelResultados.TabIndex = 84;
            // 
            // buttonBusquedaAvanzada
            // 
            this.buttonBusquedaAvanzada.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonBusquedaAvanzada.FlatAppearance.BorderSize = 0;
            this.buttonBusquedaAvanzada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBusquedaAvanzada.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBusquedaAvanzada.Location = new System.Drawing.Point(450, 188);
            this.buttonBusquedaAvanzada.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBusquedaAvanzada.Name = "buttonBusquedaAvanzada";
            this.buttonBusquedaAvanzada.Size = new System.Drawing.Size(164, 28);
            this.buttonBusquedaAvanzada.TabIndex = 87;
            this.buttonBusquedaAvanzada.Text = "Busqueda avanzada";
            this.buttonBusquedaAvanzada.UseVisualStyleBackColor = false;
            this.buttonBusquedaAvanzada.Click += new System.EventHandler(this.buttonBusquedaAvanzada_Click);
            // 
            // buttonAñadirEjemplares
            // 
            this.buttonAñadirEjemplares.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonAñadirEjemplares.FlatAppearance.BorderSize = 0;
            this.buttonAñadirEjemplares.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAñadirEjemplares.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAñadirEjemplares.Location = new System.Drawing.Point(424, 60);
            this.buttonAñadirEjemplares.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAñadirEjemplares.Name = "buttonAñadirEjemplares";
            this.buttonAñadirEjemplares.Size = new System.Drawing.Size(143, 28);
            this.buttonAñadirEjemplares.TabIndex = 90;
            this.buttonAñadirEjemplares.Text = "Añadir Ejemplares";
            this.buttonAñadirEjemplares.UseVisualStyleBackColor = false;
            this.buttonAñadirEjemplares.Click += new System.EventHandler(this.buttonAñadirEjemplares_Click);
            // 
            // textBoxAñadirEjemplares
            // 
            this.textBoxAñadirEjemplares.Location = new System.Drawing.Point(261, 63);
            this.textBoxAñadirEjemplares.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAñadirEjemplares.Name = "textBoxAñadirEjemplares";
            this.textBoxAñadirEjemplares.Size = new System.Drawing.Size(155, 22);
            this.textBoxAñadirEjemplares.TabIndex = 91;
            this.textBoxAñadirEjemplares.TextChanged += new System.EventHandler(this.textBoxAñadirEjemplares_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 66);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(214, 16);
            this.label9.TabIndex = 92;
            this.label9.Text = "Ingrese la cantidad de ejemplares:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 130);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(214, 16);
            this.label10.TabIndex = 95;
            this.label10.Text = "Ingrese la cantidad de ejemplares:";
            // 
            // textBoxEliminarEjemplares
            // 
            this.textBoxEliminarEjemplares.Location = new System.Drawing.Point(261, 127);
            this.textBoxEliminarEjemplares.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEliminarEjemplares.Name = "textBoxEliminarEjemplares";
            this.textBoxEliminarEjemplares.Size = new System.Drawing.Size(155, 22);
            this.textBoxEliminarEjemplares.TabIndex = 94;
            this.textBoxEliminarEjemplares.TextChanged += new System.EventHandler(this.textBoxEliminarEjemplares_TextChanged);
            // 
            // buttonEliminarEjemplares
            // 
            this.buttonEliminarEjemplares.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonEliminarEjemplares.FlatAppearance.BorderSize = 0;
            this.buttonEliminarEjemplares.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminarEjemplares.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEliminarEjemplares.Location = new System.Drawing.Point(424, 127);
            this.buttonEliminarEjemplares.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEliminarEjemplares.Name = "buttonEliminarEjemplares";
            this.buttonEliminarEjemplares.Size = new System.Drawing.Size(143, 28);
            this.buttonEliminarEjemplares.TabIndex = 93;
            this.buttonEliminarEjemplares.Text = "Eliminar Ejemplares";
            this.buttonEliminarEjemplares.UseVisualStyleBackColor = false;
            this.buttonEliminarEjemplares.Click += new System.EventHandler(this.buttonEliminarEjemplares_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(41, 551);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 17);
            this.label11.TabIndex = 96;
            this.label11.Text = "Dar de baja el libro:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // checkBoxBaja
            // 
            this.checkBoxBaja.AutoSize = true;
            this.checkBoxBaja.Location = new System.Drawing.Point(205, 551);
            this.checkBoxBaja.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxBaja.Name = "checkBoxBaja";
            this.checkBoxBaja.Size = new System.Drawing.Size(57, 20);
            this.checkBoxBaja.TabIndex = 97;
            this.checkBoxBaja.Text = "Baja";
            this.checkBoxBaja.UseVisualStyleBackColor = true;
            this.checkBoxBaja.CheckedChanged += new System.EventHandler(this.checkBoxBaja_CheckedChanged);
            // 
            // labelCantidadActual
            // 
            this.labelCantidadActual.AutoSize = true;
            this.labelCantidadActual.Location = new System.Drawing.Point(29, 27);
            this.labelCantidadActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCantidadActual.Name = "labelCantidadActual";
            this.labelCantidadActual.Size = new System.Drawing.Size(104, 16);
            this.labelCantidadActual.TabIndex = 98;
            this.labelCantidadActual.Text = "Cantidad Actual:";
            this.labelCantidadActual.Click += new System.EventHandler(this.labelCantidadActual_Click);
            // 
            // labelErrorEliminarEjemplares
            // 
            this.labelErrorEliminarEjemplares.AutoSize = true;
            this.labelErrorEliminarEjemplares.ForeColor = System.Drawing.Color.Red;
            this.labelErrorEliminarEjemplares.Location = new System.Drawing.Point(261, 107);
            this.labelErrorEliminarEjemplares.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelErrorEliminarEjemplares.Name = "labelErrorEliminarEjemplares";
            this.labelErrorEliminarEjemplares.Size = new System.Drawing.Size(35, 16);
            this.labelErrorEliminarEjemplares.TabIndex = 99;
            this.labelErrorEliminarEjemplares.Text = "error";
            this.labelErrorEliminarEjemplares.Visible = false;
            // 
            // labelErrorAñadirEjemplares
            // 
            this.labelErrorAñadirEjemplares.AutoSize = true;
            this.labelErrorAñadirEjemplares.ForeColor = System.Drawing.Color.Red;
            this.labelErrorAñadirEjemplares.Location = new System.Drawing.Point(261, 43);
            this.labelErrorAñadirEjemplares.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelErrorAñadirEjemplares.Name = "labelErrorAñadirEjemplares";
            this.labelErrorAñadirEjemplares.Size = new System.Drawing.Size(35, 16);
            this.labelErrorAñadirEjemplares.TabIndex = 100;
            this.labelErrorAñadirEjemplares.Text = "error";
            this.labelErrorAñadirEjemplares.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxTitulo);
            this.groupBox1.Controls.Add(this.textBoxAutor);
            this.groupBox1.Controls.Add(this.textBoxAñoPublicacion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxISBN);
            this.groupBox1.Controls.Add(this.labelError);
            this.groupBox1.Controls.Add(this.buttonDeshacerCambios);
            this.groupBox1.Controls.Add(this.buttonBusquedaAvanzada);
            this.groupBox1.Controls.Add(this.labelResultados);
            this.groupBox1.Location = new System.Drawing.Point(12, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(981, 303);
            this.groupBox1.TabIndex = 101;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actualizar Datos del Libro";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelCantidadActual);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.labelErrorEliminarEjemplares);
            this.groupBox2.Controls.Add(this.labelErrorAñadirEjemplares);
            this.groupBox2.Controls.Add(this.buttonEliminarEjemplares);
            this.groupBox2.Controls.Add(this.buttonAñadirEjemplares);
            this.groupBox2.Controls.Add(this.textBoxAñadirEjemplares);
            this.groupBox2.Controls.Add(this.textBoxEliminarEjemplares);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(12, 419);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(982, 214);
            this.groupBox2.TabIndex = 102;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actualizar Cantidad de Ejemplares";
            // 
            // ActualizarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1006, 681);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBoxBaja);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.buttonGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 728);
            this.Name = "ActualizarLibro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Libro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ActualizarLibro_FormClosed);
            this.Load += new System.EventHandler(this.ActualizarLibro_Load);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        //private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
       // private System.Windows.Forms.DataGridViewTextBoxColumn AñoPublicacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button buttonDeshacerCambios;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelResultados;
        private System.Windows.Forms.Button buttonBusquedaAvanzada;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}