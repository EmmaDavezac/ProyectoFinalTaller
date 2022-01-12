
namespace Programa
{
    partial class RegistrarPrestamo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.labelNombreUsuario = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.dataGridViewLibros = new System.Windows.Forms.DataGridView();
            this.IdLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AñoPublicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadDisponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxTituloOISBNLibro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.textBoxAutor = new System.Windows.Forms.TextBox();
            this.TituloLabel = new System.Windows.Forms.Label();
            this.ISBNLabel = new System.Windows.Forms.Label();
            this.AutorLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxNomUsuario = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxNombreUsuario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewUsuarios = new System.Windows.Forms.DataGridView();
            this.NombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.botonVolver = new System.Windows.Forms.Button();
            this.buttonRegistrarPrestamo = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxIdLibro = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).BeginInit();
            this.SuspendLayout();
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
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(82, 60);
            this.panel4.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label5.Location = new System.Drawing.Point(12, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "E-Librery";
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
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.Black;
            this.labelTitulo.Location = new System.Drawing.Point(27, 72);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(112, 13);
            this.labelTitulo.TabIndex = 78;
            this.labelTitulo.Text = "Seleccion del libro";
            this.labelTitulo.Click += new System.EventHandler(this.labelTitulo_Click);
            // 
            // dataGridViewLibros
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewLibros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewLibros.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdLibro,
            this.ISBN,
            this.Titulo,
            this.Autor,
            this.AñoPublicacion,
            this.CantidadDisponible,
            this.Cantidad});
            this.dataGridViewLibros.Location = new System.Drawing.Point(-2, 116);
            this.dataGridViewLibros.Name = "dataGridViewLibros";
            this.dataGridViewLibros.Size = new System.Drawing.Size(591, 168);
            this.dataGridViewLibros.TabIndex = 79;
            this.dataGridViewLibros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLibros_CellContentClick);
            this.dataGridViewLibros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLibros_CellContentClick);
            // 
            // IdLibro
            // 
            this.IdLibro.HeaderText = "IdLibro";
            this.IdLibro.Name = "IdLibro";
            this.IdLibro.ReadOnly = true;
            // 
            // ISBN
            // 
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            this.ISBN.Width = 150;
            // 
            // Titulo
            // 
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            this.Titulo.Width = 150;
            // 
            // Autor
            // 
            this.Autor.HeaderText = "Autor";
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            this.Autor.Width = 150;
            // 
            // AñoPublicacion
            // 
            this.AñoPublicacion.HeaderText = "Año de publicacion";
            this.AñoPublicacion.Name = "AñoPublicacion";
            this.AñoPublicacion.ReadOnly = true;
            // 
            // CantidadDisponible
            // 
            this.CantidadDisponible.HeaderText = "Cantidad disponible";
            this.CantidadDisponible.Name = "CantidadDisponible";
            this.CantidadDisponible.Width = 60;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad total";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 60;
            // 
            // textBoxTituloOISBNLibro
            // 
            this.textBoxTituloOISBNLibro.Location = new System.Drawing.Point(218, 90);
            this.textBoxTituloOISBNLibro.Name = "textBoxTituloOISBNLibro";
            this.textBoxTituloOISBNLibro.Size = new System.Drawing.Size(300, 20);
            this.textBoxTituloOISBNLibro.TabIndex = 81;
            this.textBoxTituloOISBNLibro.TextChanged += new System.EventHandler(this.textBoxTituloOISBNLibro_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 80;
            this.label1.Text = "Buscar por titulo o ISBN del libro:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Location = new System.Drawing.Point(639, 211);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(134, 20);
            this.textBoxISBN.TabIndex = 82;
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(639, 173);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(134, 20);
            this.textBoxTitulo.TabIndex = 82;
            // 
            // textBoxAutor
            // 
            this.textBoxAutor.Location = new System.Drawing.Point(639, 251);
            this.textBoxAutor.Name = "textBoxAutor";
            this.textBoxAutor.Size = new System.Drawing.Size(134, 20);
            this.textBoxAutor.TabIndex = 83;
            // 
            // TituloLabel
            // 
            this.TituloLabel.AutoSize = true;
            this.TituloLabel.Location = new System.Drawing.Point(598, 176);
            this.TituloLabel.Name = "TituloLabel";
            this.TituloLabel.Size = new System.Drawing.Size(36, 13);
            this.TituloLabel.TabIndex = 85;
            this.TituloLabel.Text = "Titulo:";
            // 
            // ISBNLabel
            // 
            this.ISBNLabel.AutoSize = true;
            this.ISBNLabel.Location = new System.Drawing.Point(598, 214);
            this.ISBNLabel.Name = "ISBNLabel";
            this.ISBNLabel.Size = new System.Drawing.Size(35, 13);
            this.ISBNLabel.TabIndex = 86;
            this.ISBNLabel.Text = "ISBN:";
            // 
            // AutorLabel
            // 
            this.AutorLabel.AutoSize = true;
            this.AutorLabel.Location = new System.Drawing.Point(598, 254);
            this.AutorLabel.Name = "AutorLabel";
            this.AutorLabel.Size = new System.Drawing.Size(35, 13);
            this.AutorLabel.TabIndex = 87;
            this.AutorLabel.Text = "Autor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(27, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 88;
            this.label2.Text = "Seleccione el usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(595, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 95;
            this.label3.Text = "NombreUsuario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(597, 445);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 94;
            this.label4.Text = "Apellido:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(597, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 93;
            this.label6.Text = "Nombre:";
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(638, 461);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(134, 20);
            this.textBoxApellido.TabIndex = 92;
            // 
            // textBoxNomUsuario
            // 
            this.textBoxNomUsuario.Location = new System.Drawing.Point(639, 383);
            this.textBoxNomUsuario.Name = "textBoxNomUsuario";
            this.textBoxNomUsuario.Size = new System.Drawing.Size(134, 20);
            this.textBoxNomUsuario.TabIndex = 90;
            this.textBoxNomUsuario.TextChanged += new System.EventHandler(this.textBoxNomUsuario_TextChanged);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(638, 422);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(134, 20);
            this.textBoxNombre.TabIndex = 91;
            // 
            // textBoxNombreUsuario
            // 
            this.textBoxNombreUsuario.Location = new System.Drawing.Point(218, 310);
            this.textBoxNombreUsuario.Name = "textBoxNombreUsuario";
            this.textBoxNombreUsuario.Size = new System.Drawing.Size(300, 20);
            this.textBoxNombreUsuario.TabIndex = 97;
            this.textBoxNombreUsuario.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 13);
            this.label7.TabIndex = 96;
            this.label7.Text = "Buscar por nombre de usuario:";
            // 
            // dataGridViewUsuarios
            // 
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewUsuarios.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreUsuario,
            this.Nombre,
            this.Apellido,
            this.FechaNacimiento,
            this.Mail,
            this.Telefono});
            this.dataGridViewUsuarios.Location = new System.Drawing.Point(-2, 336);
            this.dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            this.dataGridViewUsuarios.Size = new System.Drawing.Size(593, 177);
            this.dataGridViewUsuarios.TabIndex = 98;
            this.dataGridViewUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsuarios_CellContentClick);
            this.dataGridViewUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsuarios_CellContentClick);
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.HeaderText = "NombreUsuario";
            this.NombreUsuario.Name = "NombreUsuario";
            this.NombreUsuario.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.HeaderText = "FechaNacimiento";
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.ReadOnly = true;
            // 
            // Mail
            // 
            this.Mail.HeaderText = "Mail";
            this.Mail.Name = "Mail";
            this.Mail.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // botonVolver
            // 
            this.botonVolver.BackColor = System.Drawing.SystemColors.Highlight;
            this.botonVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.botonVolver.FlatAppearance.BorderSize = 0;
            this.botonVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonVolver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.botonVolver.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.botonVolver.Location = new System.Drawing.Point(577, 526);
            this.botonVolver.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(89, 23);
            this.botonVolver.TabIndex = 99;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = false;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // buttonRegistrarPrestamo
            // 
            this.buttonRegistrarPrestamo.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonRegistrarPrestamo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonRegistrarPrestamo.FlatAppearance.BorderSize = 0;
            this.buttonRegistrarPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistrarPrestamo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonRegistrarPrestamo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonRegistrarPrestamo.Location = new System.Drawing.Point(670, 526);
            this.buttonRegistrarPrestamo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonRegistrarPrestamo.Name = "buttonRegistrarPrestamo";
            this.buttonRegistrarPrestamo.Size = new System.Drawing.Size(103, 23);
            this.buttonRegistrarPrestamo.TabIndex = 100;
            this.buttonRegistrarPrestamo.Text = "RegistrarPrestamo";
            this.buttonRegistrarPrestamo.UseVisualStyleBackColor = false;
            this.buttonRegistrarPrestamo.Click += new System.EventHandler(this.buttonRegistrarPrestamo_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(597, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 102;
            this.label8.Text = "Id:";
            // 
            // textBoxIdLibro
            // 
            this.textBoxIdLibro.Location = new System.Drawing.Point(638, 138);
            this.textBoxIdLibro.Name = "textBoxIdLibro";
            this.textBoxIdLibro.Size = new System.Drawing.Size(134, 20);
            this.textBoxIdLibro.TabIndex = 101;
            // 
            // RegistrarPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxIdLibro);
            this.Controls.Add(this.buttonRegistrarPrestamo);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.dataGridViewUsuarios);
            this.Controls.Add(this.textBoxNombreUsuario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.textBoxNomUsuario);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AutorLabel);
            this.Controls.Add(this.ISBNLabel);
            this.Controls.Add(this.TituloLabel);
            this.Controls.Add(this.textBoxAutor);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.textBoxISBN);
            this.Controls.Add(this.textBoxTituloOISBNLibro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewLibros);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RegistrarPrestamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Prestamo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegistrarPrestamo_FormClosed);
            this.Load += new System.EventHandler(this.RegistrarPrestamo_Load);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label labelNombreUsuario;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.DataGridView dataGridViewLibros;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn AñoPublicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadDisponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.TextBox textBoxTituloOISBNLibro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.TextBox textBoxAutor;
        private System.Windows.Forms.Label TituloLabel;
        private System.Windows.Forms.Label ISBNLabel;
        private System.Windows.Forms.Label AutorLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxNomUsuario;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxNombreUsuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridViewUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Button buttonRegistrarPrestamo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxIdLibro;
    }
}