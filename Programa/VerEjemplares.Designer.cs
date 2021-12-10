
namespace Programa
{
    partial class VerEjemplares
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDisponibilidad = new System.Windows.Forms.TextBox();
            this.labelNombreUsuario = new System.Windows.Forms.Label();
            this.botonVolver = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.labelIDEjemplar = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.labelIdLibro = new System.Windows.Forms.Label();
            this.labelISBN = new System.Windows.Forms.Label();
            this.labelAñoPublicacion = new System.Windows.Forms.Label();
            this.labelAutor = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.textBoxAñoPublicacion = new System.Windows.Forms.TextBox();
            this.textBoxAutor = new System.Windows.Forms.TextBox();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.textBoxIdLibro = new System.Windows.Forms.TextBox();
            this.textBoxEstado = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.dgvEjemplares = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AñoPublicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEjemplares)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 92;
            this.label1.Text = "Disponibilidad";
            // 
            // textBoxDisponibilidad
            // 
            this.textBoxDisponibilidad.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxDisponibilidad.Enabled = false;
            this.textBoxDisponibilidad.Location = new System.Drawing.Point(111, 64);
            this.textBoxDisponibilidad.Name = "textBoxDisponibilidad";
            this.textBoxDisponibilidad.ReadOnly = true;
            this.textBoxDisponibilidad.Size = new System.Drawing.Size(300, 20);
            this.textBoxDisponibilidad.TabIndex = 91;
            // 
            // labelNombreUsuario
            // 
            this.labelNombreUsuario.BackColor = System.Drawing.SystemColors.Highlight;
            this.labelNombreUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNombreUsuario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelNombreUsuario.Location = new System.Drawing.Point(607, 9);
            this.labelNombreUsuario.Name = "labelNombreUsuario";
            this.labelNombreUsuario.Size = new System.Drawing.Size(182, 31);
            this.labelNombreUsuario.TabIndex = 90;
            this.labelNombreUsuario.Text = "Nombre de Usuario";
            this.labelNombreUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNombreUsuario.Click += new System.EventHandler(this.labelNombreUsuario_Click);
            // 
            // botonVolver
            // 
            this.botonVolver.BackColor = System.Drawing.SystemColors.Highlight;
            this.botonVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.botonVolver.FlatAppearance.BorderSize = 0;
            this.botonVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonVolver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.botonVolver.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.botonVolver.Location = new System.Drawing.Point(700, 565);
            this.botonVolver.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(89, 23);
            this.botonVolver.TabIndex = 89;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = false;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(108, 217);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 88;
            // 
            // labelIDEjemplar
            // 
            this.labelIDEjemplar.AutoSize = true;
            this.labelIDEjemplar.Location = new System.Drawing.Point(14, 15);
            this.labelIDEjemplar.Name = "labelIDEjemplar";
            this.labelIDEjemplar.Size = new System.Drawing.Size(59, 13);
            this.labelIDEjemplar.TabIndex = 86;
            this.labelIDEjemplar.Text = "Id Ejemplar";
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(14, 41);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(40, 13);
            this.labelEstado.TabIndex = 85;
            this.labelEstado.Text = "Estado";
            // 
            // labelIdLibro
            // 
            this.labelIdLibro.AutoSize = true;
            this.labelIdLibro.Location = new System.Drawing.Point(14, 93);
            this.labelIdLibro.Name = "labelIdLibro";
            this.labelIdLibro.Size = new System.Drawing.Size(42, 13);
            this.labelIdLibro.TabIndex = 84;
            this.labelIdLibro.Text = "Id Libro";
            // 
            // labelISBN
            // 
            this.labelISBN.AutoSize = true;
            this.labelISBN.Location = new System.Drawing.Point(12, 197);
            this.labelISBN.Name = "labelISBN";
            this.labelISBN.Size = new System.Drawing.Size(32, 13);
            this.labelISBN.TabIndex = 83;
            this.labelISBN.Text = "ISBN";
            // 
            // labelAñoPublicacion
            // 
            this.labelAñoPublicacion.AutoSize = true;
            this.labelAñoPublicacion.Location = new System.Drawing.Point(12, 171);
            this.labelAñoPublicacion.Name = "labelAñoPublicacion";
            this.labelAñoPublicacion.Size = new System.Drawing.Size(83, 13);
            this.labelAñoPublicacion.TabIndex = 82;
            this.labelAñoPublicacion.Text = "Año publicacion";
            // 
            // labelAutor
            // 
            this.labelAutor.AutoSize = true;
            this.labelAutor.Location = new System.Drawing.Point(12, 145);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(35, 13);
            this.labelAutor.TabIndex = 81;
            this.labelAutor.Text = "Autor:";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(12, 119);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(33, 13);
            this.labelTitulo.TabIndex = 80;
            this.labelTitulo.Text = "Titulo";
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxISBN.Enabled = false;
            this.textBoxISBN.Location = new System.Drawing.Point(111, 194);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.ReadOnly = true;
            this.textBoxISBN.Size = new System.Drawing.Size(300, 20);
            this.textBoxISBN.TabIndex = 79;
            // 
            // textBoxAñoPublicacion
            // 
            this.textBoxAñoPublicacion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxAñoPublicacion.Enabled = false;
            this.textBoxAñoPublicacion.Location = new System.Drawing.Point(111, 168);
            this.textBoxAñoPublicacion.Name = "textBoxAñoPublicacion";
            this.textBoxAñoPublicacion.ReadOnly = true;
            this.textBoxAñoPublicacion.Size = new System.Drawing.Size(300, 20);
            this.textBoxAñoPublicacion.TabIndex = 78;
            // 
            // textBoxAutor
            // 
            this.textBoxAutor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxAutor.Enabled = false;
            this.textBoxAutor.Location = new System.Drawing.Point(111, 142);
            this.textBoxAutor.Name = "textBoxAutor";
            this.textBoxAutor.ReadOnly = true;
            this.textBoxAutor.Size = new System.Drawing.Size(300, 20);
            this.textBoxAutor.TabIndex = 77;
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxTitulo.Enabled = false;
            this.textBoxTitulo.Location = new System.Drawing.Point(111, 116);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.ReadOnly = true;
            this.textBoxTitulo.Size = new System.Drawing.Size(300, 20);
            this.textBoxTitulo.TabIndex = 76;
            // 
            // textBoxIdLibro
            // 
            this.textBoxIdLibro.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxIdLibro.Enabled = false;
            this.textBoxIdLibro.Location = new System.Drawing.Point(111, 90);
            this.textBoxIdLibro.Name = "textBoxIdLibro";
            this.textBoxIdLibro.ReadOnly = true;
            this.textBoxIdLibro.Size = new System.Drawing.Size(300, 20);
            this.textBoxIdLibro.TabIndex = 75;
            // 
            // textBoxEstado
            // 
            this.textBoxEstado.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxEstado.Enabled = false;
            this.textBoxEstado.Location = new System.Drawing.Point(111, 38);
            this.textBoxEstado.Name = "textBoxEstado";
            this.textBoxEstado.ReadOnly = true;
            this.textBoxEstado.Size = new System.Drawing.Size(300, 20);
            this.textBoxEstado.TabIndex = 74;
            this.textBoxEstado.TextChanged += new System.EventHandler(this.textBoxEstado_TextChanged);
            // 
            // textBoxId
            // 
            this.textBoxId.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(111, 12);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(300, 20);
            this.textBoxId.TabIndex = 73;
            this.textBoxId.TextChanged += new System.EventHandler(this.textBoxId_TextChanged);
            // 
            // dgvEjemplares
            // 
            this.dgvEjemplares.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvEjemplares.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEjemplares.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEjemplares.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEjemplares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEjemplares.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Estado,
            this.Disponible,
            this.IdLibro,
            this.Titulo,
            this.Autor,
            this.AñoPublicacion,
            this.ISBN});
            this.dgvEjemplares.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvEjemplares.Location = new System.Drawing.Point(1, 233);
            this.dgvEjemplares.Name = "dgvEjemplares";
            this.dgvEjemplares.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEjemplares.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEjemplares.Size = new System.Drawing.Size(798, 291);
            this.dgvEjemplares.TabIndex = 93;
            this.dgvEjemplares.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLibros_CellContentClick);
            this.dgvEjemplares.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLibros_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 80;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 70;
            // 
            // Disponible
            // 
            this.Disponible.HeaderText = "Disponible";
            this.Disponible.Name = "Disponible";
            this.Disponible.ReadOnly = true;
            this.Disponible.Width = 60;
            // 
            // IdLibro
            // 
            this.IdLibro.HeaderText = "IdLibro";
            this.IdLibro.Name = "IdLibro";
            this.IdLibro.ReadOnly = true;
            this.IdLibro.Width = 80;
            // 
            // Titulo
            // 
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            this.Titulo.Width = 300;
            // 
            // Autor
            // 
            this.Autor.HeaderText = "Autor";
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            this.Autor.Width = 300;
            // 
            // AñoPublicacion
            // 
            this.AñoPublicacion.HeaderText = "Año Publicacion";
            this.AñoPublicacion.Name = "AñoPublicacion";
            this.AñoPublicacion.ReadOnly = true;
            this.AñoPublicacion.Width = 125;
            // 
            // ISBN
            // 
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            // 
            // VerEjemplares
            // 
            this.AcceptButton = this.botonVolver;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.dgvEjemplares);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDisponibilidad);
            this.Controls.Add(this.labelNombreUsuario);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.labelIDEjemplar);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.labelIdLibro);
            this.Controls.Add(this.labelISBN);
            this.Controls.Add(this.labelAñoPublicacion);
            this.Controls.Add(this.labelAutor);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.textBoxISBN);
            this.Controls.Add(this.textBoxAñoPublicacion);
            this.Controls.Add(this.textBoxAutor);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.textBoxIdLibro);
            this.Controls.Add(this.textBoxEstado);
            this.Controls.Add(this.textBoxId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "VerEjemplares";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VerEjemplares";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VerEjemplares_FormClosed);
            this.Load += new System.EventHandler(this.VerEjemplares_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEjemplares)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDisponibilidad;
        private System.Windows.Forms.Label labelNombreUsuario;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelIDEjemplar;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label labelIdLibro;
        private System.Windows.Forms.Label labelISBN;
        private System.Windows.Forms.Label labelAñoPublicacion;
        private System.Windows.Forms.Label labelAutor;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.TextBox textBoxAñoPublicacion;
        private System.Windows.Forms.TextBox textBoxAutor;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.TextBox textBoxIdLibro;
        private System.Windows.Forms.TextBox textBoxEstado;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.DataGridView dgvEjemplares;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn AñoPublicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
    }
}