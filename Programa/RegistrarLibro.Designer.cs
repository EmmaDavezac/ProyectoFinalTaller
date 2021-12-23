
namespace Programa
{
    partial class RegistrarLibro
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
            this.dataGridViewTituloYAutor = new System.Windows.Forms.DataGridView();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBNs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.textBoxAutor = new System.Windows.Forms.TextBox();
            this.textBoxAñoPublicacion = new System.Windows.Forms.TextBox();
            this.labelIngreseTitulo = new System.Windows.Forms.Label();
            this.botonVolver = new System.Windows.Forms.Button();
            this.labelResultados = new System.Windows.Forms.Label();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAñadirLibro = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonBorrarDatos = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewISBN = new System.Windows.Forms.DataGridView();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewAños = new System.Windows.Forms.DataGridView();
            this.AñoPublicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelSelccionarISBN = new System.Windows.Forms.Label();
            this.textBoxSeleccionarISBN = new System.Windows.Forms.TextBox();
            this.labelSeleccionarAño = new System.Windows.Forms.Label();
            this.textBoxSelccionarAño = new System.Windows.Forms.TextBox();
            this.labelError = new System.Windows.Forms.Label();
            this.labelCantidadEjemplares = new System.Windows.Forms.Label();
            this.textBoxCantidadEjemplares = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.labelNombreUsuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTituloYAutor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewISBN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAños)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTituloYAutor
            // 
            this.dataGridViewTituloYAutor.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewTituloYAutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTituloYAutor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titulo,
            this.Autor,
            this.Año,
            this.ISBNs});
            this.dataGridViewTituloYAutor.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewTituloYAutor.Location = new System.Drawing.Point(0, 121);
            this.dataGridViewTituloYAutor.Name = "dataGridViewTituloYAutor";
            this.dataGridViewTituloYAutor.Size = new System.Drawing.Size(363, 232);
            this.dataGridViewTituloYAutor.TabIndex = 0;
            this.dataGridViewTituloYAutor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridViewTituloYAutor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Titulo
            // 
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            this.Titulo.Width = 160;
            // 
            // Autor
            // 
            this.Autor.HeaderText = "Autor";
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            this.Autor.Width = 160;
            // 
            // Año
            // 
            this.Año.HeaderText = "Año";
            this.Año.Name = "Año";
            this.Año.ReadOnly = true;
            this.Año.Visible = false;
            // 
            // ISBNs
            // 
            this.ISBNs.HeaderText = "ISBNs";
            this.ISBNs.Name = "ISBNs";
            this.ISBNs.ReadOnly = true;
            this.ISBNs.Visible = false;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(142, 95);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(100, 20);
            this.textBoxBuscar.TabIndex = 1;
            this.textBoxBuscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonBuscar.FlatAppearance.BorderSize = 0;
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBuscar.Location = new System.Drawing.Point(248, 93);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(61, 23);
            this.buttonBuscar.TabIndex = 2;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Titulo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 427);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Autor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 482);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Año publicacion:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(182, 401);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(300, 20);
            this.textBoxTitulo.TabIndex = 6;
            // 
            // textBoxAutor
            // 
            this.textBoxAutor.Location = new System.Drawing.Point(182, 427);
            this.textBoxAutor.Name = "textBoxAutor";
            this.textBoxAutor.Size = new System.Drawing.Size(300, 20);
            this.textBoxAutor.TabIndex = 7;
            // 
            // textBoxAñoPublicacion
            // 
            this.textBoxAñoPublicacion.Location = new System.Drawing.Point(182, 479);
            this.textBoxAñoPublicacion.Name = "textBoxAñoPublicacion";
            this.textBoxAñoPublicacion.Size = new System.Drawing.Size(300, 20);
            this.textBoxAñoPublicacion.TabIndex = 8;
            this.textBoxAñoPublicacion.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // labelIngreseTitulo
            // 
            this.labelIngreseTitulo.AutoSize = true;
            this.labelIngreseTitulo.Location = new System.Drawing.Point(22, 98);
            this.labelIngreseTitulo.Name = "labelIngreseTitulo";
            this.labelIngreseTitulo.Size = new System.Drawing.Size(114, 13);
            this.labelIngreseTitulo.TabIndex = 9;
            this.labelIngreseTitulo.Text = "Ingrese el titulo o autor";
            this.labelIngreseTitulo.Click += new System.EventHandler(this.label4_Click);
            // 
            // botonVolver
            // 
            this.botonVolver.BackColor = System.Drawing.SystemColors.Highlight;
            this.botonVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.botonVolver.FlatAppearance.BorderSize = 0;
            this.botonVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonVolver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.botonVolver.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.botonVolver.Location = new System.Drawing.Point(683, 526);
            this.botonVolver.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(89, 23);
            this.botonVolver.TabIndex = 13;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = false;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // labelResultados
            // 
            this.labelResultados.AutoSize = true;
            this.labelResultados.Location = new System.Drawing.Point(139, 79);
            this.labelResultados.Name = "labelResultados";
            this.labelResultados.Size = new System.Drawing.Size(0, 13);
            this.labelResultados.TabIndex = 14;
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Location = new System.Drawing.Point(182, 453);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(300, 20);
            this.textBoxISBN.TabIndex = 16;
            this.textBoxISBN.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 456);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "ISBN:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // buttonAñadirLibro
            // 
            this.buttonAñadirLibro.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonAñadirLibro.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAñadirLibro.FlatAppearance.BorderSize = 0;
            this.buttonAñadirLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAñadirLibro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAñadirLibro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonAñadirLibro.Location = new System.Drawing.Point(260, 509);
            this.buttonAñadirLibro.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonAñadirLibro.Name = "buttonAñadirLibro";
            this.buttonAñadirLibro.Size = new System.Drawing.Size(89, 23);
            this.buttonAñadirLibro.TabIndex = 12;
            this.buttonAñadirLibro.Text = "AñadirLibro";
            this.buttonAñadirLibro.UseVisualStyleBackColor = false;
            this.buttonAñadirLibro.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Consultar en pagina de libros:";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // buttonBorrarDatos
            // 
            this.buttonBorrarDatos.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonBorrarDatos.FlatAppearance.BorderSize = 0;
            this.buttonBorrarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBorrarDatos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBorrarDatos.Location = new System.Drawing.Point(177, 509);
            this.buttonBorrarDatos.Name = "buttonBorrarDatos";
            this.buttonBorrarDatos.Size = new System.Drawing.Size(78, 23);
            this.buttonBorrarDatos.TabIndex = 21;
            this.buttonBorrarDatos.Text = "Borrar datos";
            this.buttonBorrarDatos.UseVisualStyleBackColor = false;
            this.buttonBorrarDatos.Click += new System.EventHandler(this.buttonBorrarDatos_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(110, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Cargar datos manualmente:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // dataGridViewISBN
            // 
            this.dataGridViewISBN.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewISBN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewISBN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ISBN});
            this.dataGridViewISBN.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewISBN.Location = new System.Drawing.Point(369, 121);
            this.dataGridViewISBN.Name = "dataGridViewISBN";
            this.dataGridViewISBN.Size = new System.Drawing.Size(205, 232);
            this.dataGridViewISBN.TabIndex = 24;
            this.dataGridViewISBN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewISBN_CellContentClick);
            // 
            // ISBN
            // 
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.Width = 160;
            // 
            // dataGridViewAños
            // 
            this.dataGridViewAños.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewAños.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAños.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AñoPublicacion});
            this.dataGridViewAños.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewAños.Location = new System.Drawing.Point(580, 121);
            this.dataGridViewAños.Name = "dataGridViewAños";
            this.dataGridViewAños.Size = new System.Drawing.Size(204, 232);
            this.dataGridViewAños.TabIndex = 25;
            this.dataGridViewAños.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAños_CellContentClick);
            // 
            // AñoPublicacion
            // 
            this.AñoPublicacion.HeaderText = "AñoPublicacion";
            this.AñoPublicacion.Name = "AñoPublicacion";
            this.AñoPublicacion.Width = 160;
            // 
            // labelSelccionarISBN
            // 
            this.labelSelccionarISBN.AutoSize = true;
            this.labelSelccionarISBN.Location = new System.Drawing.Point(366, 99);
            this.labelSelccionarISBN.Name = "labelSelccionarISBN";
            this.labelSelccionarISBN.Size = new System.Drawing.Size(88, 13);
            this.labelSelccionarISBN.TabIndex = 27;
            this.labelSelccionarISBN.Text = "Seleccione ISBN";
            // 
            // textBoxSeleccionarISBN
            // 
            this.textBoxSeleccionarISBN.Location = new System.Drawing.Point(460, 95);
            this.textBoxSeleccionarISBN.Name = "textBoxSeleccionarISBN";
            this.textBoxSeleccionarISBN.Size = new System.Drawing.Size(100, 20);
            this.textBoxSeleccionarISBN.TabIndex = 26;
            this.textBoxSeleccionarISBN.TextChanged += new System.EventHandler(this.textBoxSeleccionarISBN_TextChanged);
            // 
            // labelSeleccionarAño
            // 
            this.labelSeleccionarAño.AutoSize = true;
            this.labelSeleccionarAño.Location = new System.Drawing.Point(586, 98);
            this.labelSeleccionarAño.Name = "labelSeleccionarAño";
            this.labelSeleccionarAño.Size = new System.Drawing.Size(84, 13);
            this.labelSeleccionarAño.TabIndex = 29;
            this.labelSeleccionarAño.Text = "Seleccione año:";
            // 
            // textBoxSelccionarAño
            // 
            this.textBoxSelccionarAño.Location = new System.Drawing.Point(672, 95);
            this.textBoxSelccionarAño.Name = "textBoxSelccionarAño";
            this.textBoxSelccionarAño.Size = new System.Drawing.Size(100, 20);
            this.textBoxSelccionarAño.TabIndex = 28;
            this.textBoxSelccionarAño.TextChanged += new System.EventHandler(this.textBoxSelccionarAño_TextChanged);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(271, 382);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 30;
            // 
            // labelCantidadEjemplares
            // 
            this.labelCantidadEjemplares.AutoSize = true;
            this.labelCantidadEjemplares.Location = new System.Drawing.Point(354, 514);
            this.labelCantidadEjemplares.Name = "labelCantidadEjemplares";
            this.labelCantidadEjemplares.Size = new System.Drawing.Size(52, 13);
            this.labelCantidadEjemplares.TabIndex = 32;
            this.labelCantidadEjemplares.Text = "Cantidad:";
            // 
            // textBoxCantidadEjemplares
            // 
            this.textBoxCantidadEjemplares.Location = new System.Drawing.Point(403, 509);
            this.textBoxCantidadEjemplares.Name = "textBoxCantidadEjemplares";
            this.textBoxCantidadEjemplares.Size = new System.Drawing.Size(79, 20);
            this.textBoxCantidadEjemplares.TabIndex = 33;
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
            this.panel3.TabIndex = 71;
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
            // RegistrarLibro
            // 
            this.AcceptButton = this.buttonBuscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.textBoxCantidadEjemplares);
            this.Controls.Add(this.labelCantidadEjemplares);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.labelSeleccionarAño);
            this.Controls.Add(this.textBoxSelccionarAño);
            this.Controls.Add(this.labelSelccionarISBN);
            this.Controls.Add(this.textBoxSeleccionarISBN);
            this.Controls.Add(this.dataGridViewAños);
            this.Controls.Add(this.dataGridViewISBN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonBorrarDatos);
            this.Controls.Add(this.textBoxISBN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelResultados);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.buttonAñadirLibro);
            this.Controls.Add(this.labelIngreseTitulo);
            this.Controls.Add(this.textBoxAñoPublicacion);
            this.Controls.Add(this.textBoxAutor);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.dataGridViewTituloYAutor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "RegistrarLibro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Libro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BuscarLibrosAPI_FormClosed);
            this.Load += new System.EventHandler(this.BuscarLibrosAPI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTituloYAutor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewISBN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAños)).EndInit();
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

        private System.Windows.Forms.DataGridView dataGridViewTituloYAutor;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.TextBox textBoxAutor;
        private System.Windows.Forms.TextBox textBoxAñoPublicacion;
        private System.Windows.Forms.Label labelIngreseTitulo;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Label labelResultados;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAñadirLibro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonBorrarDatos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridView dataGridViewAños;
        private System.Windows.Forms.DataGridViewTextBoxColumn AñoPublicacion;
        private System.Windows.Forms.Label labelSelccionarISBN;
        private System.Windows.Forms.TextBox textBoxSeleccionarISBN;
        private System.Windows.Forms.Label labelSeleccionarAño;
        private System.Windows.Forms.TextBox textBoxSelccionarAño;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Año;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBNs;
        private System.Windows.Forms.Label labelCantidadEjemplares;
        private System.Windows.Forms.TextBox textBoxCantidadEjemplares;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label labelNombreUsuario;
    }
}