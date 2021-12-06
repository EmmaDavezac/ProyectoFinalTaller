
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonBuscarUsuario = new System.Windows.Forms.Button();
            this.buttonBuscarLibro = new System.Windows.Forms.Button();
            this.textBoxIdUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelErrorUsuario = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelScoring = new System.Windows.Forms.Label();
            this.textBoxScoring = new System.Windows.Forms.TextBox();
            this.labelErrorLibro = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.labelISBN = new System.Windows.Forms.Label();
            this.labelAutor = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.textBoxAutor = new System.Windows.Forms.TextBox();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.textBoxIdLibro = new System.Windows.Forms.TextBox();
            this.labelNombreUsuario = new System.Windows.Forms.Label();
            this.dgvEjemplares = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.botonVolver = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelIDEjemplar = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.textBoxEstado = new System.Windows.Forms.TextBox();
            this.textBoxIdEjemplar = new System.Windows.Forms.TextBox();
            this.buttonConfirmarEjemplar = new System.Windows.Forms.Button();
            this.buttonConfirmarUsuario = new System.Windows.Forms.Button();
            this.buttonConfirmarLibro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEjemplares)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBuscarUsuario
            // 
            this.buttonBuscarUsuario.Enabled = false;
            this.buttonBuscarUsuario.Location = new System.Drawing.Point(227, 109);
            this.buttonBuscarUsuario.Name = "buttonBuscarUsuario";
            this.buttonBuscarUsuario.Size = new System.Drawing.Size(75, 20);
            this.buttonBuscarUsuario.TabIndex = 0;
            this.buttonBuscarUsuario.Text = "Buscar";
            this.buttonBuscarUsuario.UseVisualStyleBackColor = true;
            this.buttonBuscarUsuario.Click += new System.EventHandler(this.buttonBuscarUsuario_Click);
            // 
            // buttonBuscarLibro
            // 
            this.buttonBuscarLibro.Enabled = false;
            this.buttonBuscarLibro.Location = new System.Drawing.Point(596, 108);
            this.buttonBuscarLibro.Name = "buttonBuscarLibro";
            this.buttonBuscarLibro.Size = new System.Drawing.Size(75, 20);
            this.buttonBuscarLibro.TabIndex = 1;
            this.buttonBuscarLibro.Text = "Buscar";
            this.buttonBuscarLibro.UseVisualStyleBackColor = true;
            this.buttonBuscarLibro.Click += new System.EventHandler(this.buttonBuscarLibro_Click);
            // 
            // textBoxIdUsuario
            // 
            this.textBoxIdUsuario.Location = new System.Drawing.Point(71, 109);
            this.textBoxIdUsuario.Name = "textBoxIdUsuario";
            this.textBoxIdUsuario.Size = new System.Drawing.Size(150, 20);
            this.textBoxIdUsuario.TabIndex = 38;
            this.textBoxIdUsuario.TextChanged += new System.EventHandler(this.textBoxId_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Id";
            // 
            // labelErrorUsuario
            // 
            this.labelErrorUsuario.AutoSize = true;
            this.labelErrorUsuario.ForeColor = System.Drawing.Color.Black;
            this.labelErrorUsuario.Location = new System.Drawing.Point(68, 221);
            this.labelErrorUsuario.Name = "labelErrorUsuario";
            this.labelErrorUsuario.Size = new System.Drawing.Size(0, 13);
            this.labelErrorUsuario.TabIndex = 46;
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(22, 168);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(44, 13);
            this.labelApellido.TabIndex = 43;
            this.labelApellido.Text = "Apellido";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(22, 142);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 42;
            this.labelNombre.Text = "Nombre";
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Enabled = false;
            this.textBoxApellido.Location = new System.Drawing.Point(71, 161);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.ReadOnly = true;
            this.textBoxApellido.Size = new System.Drawing.Size(150, 20);
            this.textBoxApellido.TabIndex = 40;
            this.textBoxApellido.TabStop = false;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Enabled = false;
            this.textBoxNombre.Location = new System.Drawing.Point(71, 135);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.ReadOnly = true;
            this.textBoxNombre.Size = new System.Drawing.Size(150, 20);
            this.textBoxNombre.TabIndex = 39;
            this.textBoxNombre.TabStop = false;
            // 
            // labelScoring
            // 
            this.labelScoring.AutoSize = true;
            this.labelScoring.Location = new System.Drawing.Point(22, 194);
            this.labelScoring.Name = "labelScoring";
            this.labelScoring.Size = new System.Drawing.Size(43, 13);
            this.labelScoring.TabIndex = 51;
            this.labelScoring.Text = "Scoring";
            // 
            // textBoxScoring
            // 
            this.textBoxScoring.Enabled = false;
            this.textBoxScoring.Location = new System.Drawing.Point(71, 187);
            this.textBoxScoring.Name = "textBoxScoring";
            this.textBoxScoring.ReadOnly = true;
            this.textBoxScoring.Size = new System.Drawing.Size(150, 20);
            this.textBoxScoring.TabIndex = 50;
            this.textBoxScoring.TabStop = false;
            // 
            // labelErrorLibro
            // 
            this.labelErrorLibro.AutoSize = true;
            this.labelErrorLibro.ForeColor = System.Drawing.Color.Black;
            this.labelErrorLibro.Location = new System.Drawing.Point(437, 221);
            this.labelErrorLibro.Name = "labelErrorLibro";
            this.labelErrorLibro.Size = new System.Drawing.Size(0, 13);
            this.labelErrorLibro.TabIndex = 63;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(378, 114);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(16, 13);
            this.labelId.TabIndex = 61;
            this.labelId.Text = "Id";
            // 
            // labelISBN
            // 
            this.labelISBN.AutoSize = true;
            this.labelISBN.Location = new System.Drawing.Point(378, 193);
            this.labelISBN.Name = "labelISBN";
            this.labelISBN.Size = new System.Drawing.Size(32, 13);
            this.labelISBN.TabIndex = 60;
            this.labelISBN.Text = "ISBN";
            // 
            // labelAutor
            // 
            this.labelAutor.AutoSize = true;
            this.labelAutor.Location = new System.Drawing.Point(378, 167);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(35, 13);
            this.labelAutor.TabIndex = 58;
            this.labelAutor.Text = "Autor:";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(378, 141);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(33, 13);
            this.labelTitulo.TabIndex = 57;
            this.labelTitulo.Text = "Titulo";
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Enabled = false;
            this.textBoxISBN.Location = new System.Drawing.Point(440, 186);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.ReadOnly = true;
            this.textBoxISBN.Size = new System.Drawing.Size(150, 20);
            this.textBoxISBN.TabIndex = 56;
            this.textBoxISBN.TabStop = false;
            // 
            // textBoxAutor
            // 
            this.textBoxAutor.Enabled = false;
            this.textBoxAutor.Location = new System.Drawing.Point(440, 160);
            this.textBoxAutor.Name = "textBoxAutor";
            this.textBoxAutor.ReadOnly = true;
            this.textBoxAutor.Size = new System.Drawing.Size(150, 20);
            this.textBoxAutor.TabIndex = 54;
            this.textBoxAutor.TabStop = false;
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Enabled = false;
            this.textBoxTitulo.Location = new System.Drawing.Point(440, 134);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.ReadOnly = true;
            this.textBoxTitulo.Size = new System.Drawing.Size(150, 20);
            this.textBoxTitulo.TabIndex = 53;
            this.textBoxTitulo.TabStop = false;
            // 
            // textBoxIdLibro
            // 
            this.textBoxIdLibro.Enabled = false;
            this.textBoxIdLibro.Location = new System.Drawing.Point(440, 108);
            this.textBoxIdLibro.Name = "textBoxIdLibro";
            this.textBoxIdLibro.Size = new System.Drawing.Size(150, 20);
            this.textBoxIdLibro.TabIndex = 52;
            this.textBoxIdLibro.TextChanged += new System.EventHandler(this.textBoxIdLibro_TextChanged);
            // 
            // labelNombreUsuario
            // 
            this.labelNombreUsuario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelNombreUsuario.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelNombreUsuario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelNombreUsuario.Location = new System.Drawing.Point(606, 9);
            this.labelNombreUsuario.Name = "labelNombreUsuario";
            this.labelNombreUsuario.Size = new System.Drawing.Size(182, 31);
            this.labelNombreUsuario.TabIndex = 64;
            this.labelNombreUsuario.Text = "Nombre de Usuario";
            this.labelNombreUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNombreUsuario.Click += new System.EventHandler(this.labelNombreUsuario_Click);
            // 
            // dgvEjemplares
            // 
            this.dgvEjemplares.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvEjemplares.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvEjemplares.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEjemplares.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEjemplares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEjemplares.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Estado});
            this.dgvEjemplares.Enabled = false;
            this.dgvEjemplares.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvEjemplares.Location = new System.Drawing.Point(71, 285);
            this.dgvEjemplares.Name = "dgvEjemplares";
            this.dgvEjemplares.ReadOnly = true;
            this.dgvEjemplares.Size = new System.Drawing.Size(231, 209);
            this.dgvEjemplares.TabIndex = 94;
            this.dgvEjemplares.TabStop = false;
            this.dgvEjemplares.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEjemplares_CellContentClick);
            this.dgvEjemplares.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEjemplares_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Id.Width = 84;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 103;
            // 
            // botonVolver
            // 
            this.botonVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.botonVolver.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.botonVolver.Location = new System.Drawing.Point(607, 565);
            this.botonVolver.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(89, 23);
            this.botonVolver.TabIndex = 96;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonGuardar.Enabled = false;
            this.buttonGuardar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonGuardar.Location = new System.Drawing.Point(700, 565);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(89, 23);
            this.buttonGuardar.TabIndex = 95;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 97;
            this.label3.Text = "Seleccione un usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(437, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 98;
            this.label4.Text = "Seleccione un Libro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 13);
            this.label5.TabIndex = 99;
            this.label5.Text = "Seleccione un ejemplar de la lista";
            // 
            // labelIDEjemplar
            // 
            this.labelIDEjemplar.AutoSize = true;
            this.labelIDEjemplar.Location = new System.Drawing.Point(373, 288);
            this.labelIDEjemplar.Name = "labelIDEjemplar";
            this.labelIDEjemplar.Size = new System.Drawing.Size(59, 13);
            this.labelIDEjemplar.TabIndex = 103;
            this.labelIDEjemplar.Text = "Id Ejemplar";
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(373, 314);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(40, 13);
            this.labelEstado.TabIndex = 102;
            this.labelEstado.Text = "Estado";
            // 
            // textBoxEstado
            // 
            this.textBoxEstado.Enabled = false;
            this.textBoxEstado.Location = new System.Drawing.Point(440, 311);
            this.textBoxEstado.Name = "textBoxEstado";
            this.textBoxEstado.ReadOnly = true;
            this.textBoxEstado.Size = new System.Drawing.Size(150, 20);
            this.textBoxEstado.TabIndex = 101;
            // 
            // textBoxIdEjemplar
            // 
            this.textBoxIdEjemplar.Enabled = false;
            this.textBoxIdEjemplar.Location = new System.Drawing.Point(440, 285);
            this.textBoxIdEjemplar.Name = "textBoxIdEjemplar";
            this.textBoxIdEjemplar.ReadOnly = true;
            this.textBoxIdEjemplar.Size = new System.Drawing.Size(150, 20);
            this.textBoxIdEjemplar.TabIndex = 100;
            this.textBoxIdEjemplar.TextChanged += new System.EventHandler(this.textBoxIdEjemplar_TextChanged);
            // 
            // buttonConfirmarEjemplar
            // 
            this.buttonConfirmarEjemplar.Enabled = false;
            this.buttonConfirmarEjemplar.Location = new System.Drawing.Point(596, 285);
            this.buttonConfirmarEjemplar.Name = "buttonConfirmarEjemplar";
            this.buttonConfirmarEjemplar.Size = new System.Drawing.Size(75, 20);
            this.buttonConfirmarEjemplar.TabIndex = 104;
            this.buttonConfirmarEjemplar.Text = "Confirmar";
            this.buttonConfirmarEjemplar.UseVisualStyleBackColor = true;
            this.buttonConfirmarEjemplar.Click += new System.EventHandler(this.buttonConfirmarEjemplar_Click);
            // 
            // buttonConfirmarUsuario
            // 
            this.buttonConfirmarUsuario.Enabled = false;
            this.buttonConfirmarUsuario.Location = new System.Drawing.Point(227, 135);
            this.buttonConfirmarUsuario.Name = "buttonConfirmarUsuario";
            this.buttonConfirmarUsuario.Size = new System.Drawing.Size(75, 20);
            this.buttonConfirmarUsuario.TabIndex = 105;
            this.buttonConfirmarUsuario.Text = "Confirmar";
            this.buttonConfirmarUsuario.UseVisualStyleBackColor = true;
            this.buttonConfirmarUsuario.Click += new System.EventHandler(this.buttonConfirmarUsuario_Click);
            // 
            // buttonConfirmarLibro
            // 
            this.buttonConfirmarLibro.Enabled = false;
            this.buttonConfirmarLibro.Location = new System.Drawing.Point(596, 134);
            this.buttonConfirmarLibro.Name = "buttonConfirmarLibro";
            this.buttonConfirmarLibro.Size = new System.Drawing.Size(75, 20);
            this.buttonConfirmarLibro.TabIndex = 106;
            this.buttonConfirmarLibro.Text = "Confirmar";
            this.buttonConfirmarLibro.UseVisualStyleBackColor = true;
            this.buttonConfirmarLibro.Click += new System.EventHandler(this.buttonConfirmarLibro_Click);
            // 
            // RegistrarPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.buttonConfirmarLibro);
            this.Controls.Add(this.buttonConfirmarUsuario);
            this.Controls.Add(this.buttonConfirmarEjemplar);
            this.Controls.Add(this.labelIDEjemplar);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.textBoxEstado);
            this.Controls.Add(this.textBoxIdEjemplar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.dgvEjemplares);
            this.Controls.Add(this.labelNombreUsuario);
            this.Controls.Add(this.labelErrorLibro);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.labelISBN);
            this.Controls.Add(this.labelAutor);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.textBoxISBN);
            this.Controls.Add(this.textBoxAutor);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.textBoxIdLibro);
            this.Controls.Add(this.labelScoring);
            this.Controls.Add(this.textBoxScoring);
            this.Controls.Add(this.textBoxIdUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelErrorUsuario);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.buttonBuscarLibro);
            this.Controls.Add(this.buttonBuscarUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "RegistrarPrestamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Prestamo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegistrarPrestamo_FormClosed);
            this.Load += new System.EventHandler(this.RegistrarPrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEjemplares)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBuscarUsuario;
        private System.Windows.Forms.Button buttonBuscarLibro;
        private System.Windows.Forms.TextBox textBoxIdUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelErrorUsuario;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelScoring;
        private System.Windows.Forms.TextBox textBoxScoring;
        private System.Windows.Forms.Label labelErrorLibro;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelISBN;
        private System.Windows.Forms.Label labelAutor;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.TextBox textBoxAutor;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.TextBox textBoxIdLibro;
        private System.Windows.Forms.Label labelNombreUsuario;
        private System.Windows.Forms.DataGridView dgvEjemplares;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelIDEjemplar;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.TextBox textBoxEstado;
        private System.Windows.Forms.TextBox textBoxIdEjemplar;
        private System.Windows.Forms.Button buttonConfirmarEjemplar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Button buttonConfirmarUsuario;
        private System.Windows.Forms.Button buttonConfirmarLibro;
    }
}