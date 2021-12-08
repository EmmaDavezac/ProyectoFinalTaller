
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
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelResultados = new System.Windows.Forms.Label();
            this.botonVolver = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.labelNombreUsuario = new System.Windows.Forms.Label();
            this.labelIngreseTitulo = new System.Windows.Forms.Label();
            this.textBoxAñoPublicacion = new System.Windows.Forms.TextBox();
            this.textBoxAutor = new System.Windows.Forms.TextBox();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBuscarEnPagina = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AñoPublicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonSeleccionar = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.buttonDeshacerCambios = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(619, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "ConsultarEn Pagina de Libros";
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Enabled = false;
            this.textBoxISBN.Location = new System.Drawing.Point(136, 191);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(300, 20);
            this.textBoxISBN.TabIndex = 38;
            this.textBoxISBN.TextChanged += new System.EventHandler(this.textBoxISBN_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "ISBN";
            // 
            // labelResultados
            // 
            this.labelResultados.AutoSize = true;
            this.labelResultados.Location = new System.Drawing.Point(619, 220);
            this.labelResultados.Name = "labelResultados";
            this.labelResultados.Size = new System.Drawing.Size(0, 13);
            this.labelResultados.TabIndex = 36;
            // 
            // botonVolver
            // 
            this.botonVolver.BackColor = System.Drawing.SystemColors.Highlight;
            this.botonVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.botonVolver.FlatAppearance.BorderSize = 0;
            this.botonVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonVolver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.botonVolver.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.botonVolver.Location = new System.Drawing.Point(604, 565);
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
            this.buttonGuardar.Location = new System.Drawing.Point(700, 565);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(89, 23);
            this.buttonGuardar.TabIndex = 34;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // labelNombreUsuario
            // 
            this.labelNombreUsuario.BackColor = System.Drawing.SystemColors.Highlight;
            this.labelNombreUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNombreUsuario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelNombreUsuario.Location = new System.Drawing.Point(607, 9);
            this.labelNombreUsuario.Name = "labelNombreUsuario";
            this.labelNombreUsuario.Size = new System.Drawing.Size(182, 31);
            this.labelNombreUsuario.TabIndex = 33;
            this.labelNombreUsuario.Text = "Nombre de Usuario";
            this.labelNombreUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelIngreseTitulo
            // 
            this.labelIngreseTitulo.AutoSize = true;
            this.labelIngreseTitulo.Location = new System.Drawing.Point(502, 198);
            this.labelIngreseTitulo.Name = "labelIngreseTitulo";
            this.labelIngreseTitulo.Size = new System.Drawing.Size(114, 13);
            this.labelIngreseTitulo.TabIndex = 32;
            this.labelIngreseTitulo.Text = "Ingrese el titulo o autor";
            // 
            // textBoxAñoPublicacion
            // 
            this.textBoxAñoPublicacion.Enabled = false;
            this.textBoxAñoPublicacion.Location = new System.Drawing.Point(136, 165);
            this.textBoxAñoPublicacion.Name = "textBoxAñoPublicacion";
            this.textBoxAñoPublicacion.Size = new System.Drawing.Size(300, 20);
            this.textBoxAñoPublicacion.TabIndex = 31;
            this.textBoxAñoPublicacion.TextChanged += new System.EventHandler(this.textBoxAñoPublicacion_TextChanged);
            // 
            // textBoxAutor
            // 
            this.textBoxAutor.Enabled = false;
            this.textBoxAutor.Location = new System.Drawing.Point(136, 139);
            this.textBoxAutor.Name = "textBoxAutor";
            this.textBoxAutor.Size = new System.Drawing.Size(300, 20);
            this.textBoxAutor.TabIndex = 30;
            this.textBoxAutor.TextChanged += new System.EventHandler(this.textBoxAutor_TextChanged);
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Enabled = false;
            this.textBoxTitulo.Location = new System.Drawing.Point(136, 113);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(300, 20);
            this.textBoxTitulo.TabIndex = 29;
            this.textBoxTitulo.TextChanged += new System.EventHandler(this.textBoxTitulo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Autor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Titulo";
            // 
            // buttonBuscarEnPagina
            // 
            this.buttonBuscarEnPagina.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonBuscarEnPagina.Enabled = false;
            this.buttonBuscarEnPagina.FlatAppearance.BorderSize = 0;
            this.buttonBuscarEnPagina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarEnPagina.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBuscarEnPagina.Location = new System.Drawing.Point(728, 193);
            this.buttonBuscarEnPagina.Name = "buttonBuscarEnPagina";
            this.buttonBuscarEnPagina.Size = new System.Drawing.Size(61, 23);
            this.buttonBuscarEnPagina.TabIndex = 25;
            this.buttonBuscarEnPagina.Text = "Buscar";
            this.buttonBuscarEnPagina.UseVisualStyleBackColor = false;
            this.buttonBuscarEnPagina.Click += new System.EventHandler(this.buttonBuscarEnPagina_Click);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Enabled = false;
            this.textBoxBuscar.Location = new System.Drawing.Point(622, 193);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(100, 20);
            this.textBoxBuscar.TabIndex = 24;
            // 
            // ISBN
            // 
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            // 
            // AñoPublicacion
            // 
            this.AñoPublicacion.HeaderText = "Año Publicacion";
            this.AñoPublicacion.Name = "AñoPublicacion";
            this.AñoPublicacion.ReadOnly = true;
            this.AñoPublicacion.Width = 125;
            // 
            // Autor
            // 
            this.Autor.HeaderText = "Autor";
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            this.Autor.Width = 300;
            // 
            // Titulo
            // 
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            this.Titulo.Width = 300;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Año publicacion";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titulo,
            this.Autor,
            this.AñoPublicacion,
            this.ISBN});
            this.dataGridView1.Enabled = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(0, 268);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(801, 282);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(136, 87);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(300, 20);
            this.textBoxId.TabIndex = 42;
            this.textBoxId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Id";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonBuscar.Enabled = false;
            this.buttonBuscar.FlatAppearance.BorderSize = 0;
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBuscar.Location = new System.Drawing.Point(442, 87);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(84, 23);
            this.buttonBuscar.TabIndex = 43;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonSeleccionar
            // 
            this.buttonSeleccionar.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonSeleccionar.Enabled = false;
            this.buttonSeleccionar.FlatAppearance.BorderSize = 0;
            this.buttonSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSeleccionar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSeleccionar.Location = new System.Drawing.Point(442, 113);
            this.buttonSeleccionar.Name = "buttonSeleccionar";
            this.buttonSeleccionar.Size = new System.Drawing.Size(84, 23);
            this.buttonSeleccionar.TabIndex = 44;
            this.buttonSeleccionar.Text = "Seleccionar";
            this.buttonSeleccionar.UseVisualStyleBackColor = false;
            this.buttonSeleccionar.Click += new System.EventHandler(this.buttonSeleccionar_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(133, 220);
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
            this.buttonDeshacerCambios.Location = new System.Drawing.Point(329, 239);
            this.buttonDeshacerCambios.Name = "buttonDeshacerCambios";
            this.buttonDeshacerCambios.Size = new System.Drawing.Size(107, 23);
            this.buttonDeshacerCambios.TabIndex = 46;
            this.buttonDeshacerCambios.Text = "Deshacer cambios";
            this.buttonDeshacerCambios.UseVisualStyleBackColor = false;
            this.buttonDeshacerCambios.Click += new System.EventHandler(this.buttonBorrarCambios_Click);
            // 
            // ActualizarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.buttonDeshacerCambios);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonSeleccionar);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxISBN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelResultados);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.labelNombreUsuario);
            this.Controls.Add(this.labelIngreseTitulo);
            this.Controls.Add(this.textBoxAñoPublicacion);
            this.Controls.Add(this.textBoxAutor);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBuscarEnPagina);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "ActualizarLibro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ActualizarLibro";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelResultados;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Label labelNombreUsuario;
        private System.Windows.Forms.Label labelIngreseTitulo;
        private System.Windows.Forms.TextBox textBoxAñoPublicacion;
        private System.Windows.Forms.TextBox textBoxAutor;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBuscarEnPagina;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn AñoPublicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonSeleccionar;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button buttonDeshacerCambios;
    }
}