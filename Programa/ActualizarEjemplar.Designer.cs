
namespace Programa
{
    partial class ActualizarEjemplar
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
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxIdLibro = new System.Windows.Forms.TextBox();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.textBoxAutor = new System.Windows.Forms.TextBox();
            this.textBoxAñoPublicacion = new System.Windows.Forms.TextBox();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.labelIDEjemplar = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.labelIdLibro = new System.Windows.Forms.Label();
            this.labelISBN = new System.Windows.Forms.Label();
            this.labelAñoPublicacion = new System.Windows.Forms.Label();
            this.labelAutor = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.botonVolver = new System.Windows.Forms.Button();
            this.labelNombreUsuario = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonSeleccionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(275, 156);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(300, 20);
            this.textBoxId.TabIndex = 53;
            this.textBoxId.TextChanged += new System.EventHandler(this.textBoxId_TextChanged);
            // 
            // textBoxIdLibro
            // 
            this.textBoxIdLibro.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxIdLibro.Enabled = false;
            this.textBoxIdLibro.Location = new System.Drawing.Point(275, 208);
            this.textBoxIdLibro.Name = "textBoxIdLibro";
            this.textBoxIdLibro.ReadOnly = true;
            this.textBoxIdLibro.Size = new System.Drawing.Size(300, 20);
            this.textBoxIdLibro.TabIndex = 55;
            this.textBoxIdLibro.TextChanged += new System.EventHandler(this.textBoxIdLibro_TextChanged);
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxTitulo.Enabled = false;
            this.textBoxTitulo.Location = new System.Drawing.Point(275, 234);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.ReadOnly = true;
            this.textBoxTitulo.Size = new System.Drawing.Size(300, 20);
            this.textBoxTitulo.TabIndex = 56;
            // 
            // textBoxAutor
            // 
            this.textBoxAutor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxAutor.Enabled = false;
            this.textBoxAutor.Location = new System.Drawing.Point(275, 260);
            this.textBoxAutor.Name = "textBoxAutor";
            this.textBoxAutor.ReadOnly = true;
            this.textBoxAutor.Size = new System.Drawing.Size(300, 20);
            this.textBoxAutor.TabIndex = 57;
            // 
            // textBoxAñoPublicacion
            // 
            this.textBoxAñoPublicacion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxAñoPublicacion.Enabled = false;
            this.textBoxAñoPublicacion.Location = new System.Drawing.Point(275, 286);
            this.textBoxAñoPublicacion.Name = "textBoxAñoPublicacion";
            this.textBoxAñoPublicacion.ReadOnly = true;
            this.textBoxAñoPublicacion.Size = new System.Drawing.Size(300, 20);
            this.textBoxAñoPublicacion.TabIndex = 58;
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxISBN.Enabled = false;
            this.textBoxISBN.Location = new System.Drawing.Point(275, 312);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.ReadOnly = true;
            this.textBoxISBN.Size = new System.Drawing.Size(300, 20);
            this.textBoxISBN.TabIndex = 59;
            // 
            // labelIDEjemplar
            // 
            this.labelIDEjemplar.AutoSize = true;
            this.labelIDEjemplar.Location = new System.Drawing.Point(178, 159);
            this.labelIDEjemplar.Name = "labelIDEjemplar";
            this.labelIDEjemplar.Size = new System.Drawing.Size(59, 13);
            this.labelIDEjemplar.TabIndex = 66;
            this.labelIDEjemplar.Text = "Id Ejemplar";
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(178, 185);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(40, 13);
            this.labelEstado.TabIndex = 65;
            this.labelEstado.Text = "Estado";
            // 
            // labelIdLibro
            // 
            this.labelIdLibro.AutoSize = true;
            this.labelIdLibro.Location = new System.Drawing.Point(178, 211);
            this.labelIdLibro.Name = "labelIdLibro";
            this.labelIdLibro.Size = new System.Drawing.Size(42, 13);
            this.labelIdLibro.TabIndex = 64;
            this.labelIdLibro.Text = "Id Libro";
            // 
            // labelISBN
            // 
            this.labelISBN.AutoSize = true;
            this.labelISBN.Location = new System.Drawing.Point(176, 315);
            this.labelISBN.Name = "labelISBN";
            this.labelISBN.Size = new System.Drawing.Size(32, 13);
            this.labelISBN.TabIndex = 63;
            this.labelISBN.Text = "ISBN";
            // 
            // labelAñoPublicacion
            // 
            this.labelAñoPublicacion.AutoSize = true;
            this.labelAñoPublicacion.Location = new System.Drawing.Point(176, 289);
            this.labelAñoPublicacion.Name = "labelAñoPublicacion";
            this.labelAñoPublicacion.Size = new System.Drawing.Size(83, 13);
            this.labelAñoPublicacion.TabIndex = 62;
            this.labelAñoPublicacion.Text = "Año publicacion";
            // 
            // labelAutor
            // 
            this.labelAutor.AutoSize = true;
            this.labelAutor.Location = new System.Drawing.Point(176, 263);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(35, 13);
            this.labelAutor.TabIndex = 61;
            this.labelAutor.Text = "Autor:";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(176, 237);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(33, 13);
            this.labelTitulo.TabIndex = 60;
            this.labelTitulo.Text = "Titulo";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonBuscar.Enabled = false;
            this.buttonBuscar.FlatAppearance.BorderSize = 0;
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBuscar.Location = new System.Drawing.Point(581, 153);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(81, 23);
            this.buttonBuscar.TabIndex = 67;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(272, 335);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 68;
            // 
            // botonVolver
            // 
            this.botonVolver.BackColor = System.Drawing.SystemColors.Highlight;
            this.botonVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.botonVolver.FlatAppearance.BorderSize = 0;
            this.botonVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonVolver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.botonVolver.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.botonVolver.Location = new System.Drawing.Point(591, 526);
            this.botonVolver.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(89, 23);
            this.botonVolver.TabIndex = 69;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = false;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // labelNombreUsuario
            // 
            this.labelNombreUsuario.BackColor = System.Drawing.SystemColors.Highlight;
            this.labelNombreUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNombreUsuario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelNombreUsuario.Location = new System.Drawing.Point(606, 9);
            this.labelNombreUsuario.Name = "labelNombreUsuario";
            this.labelNombreUsuario.Size = new System.Drawing.Size(182, 31);
            this.labelNombreUsuario.TabIndex = 70;
            this.labelNombreUsuario.Text = "Nombre de Usuario";
            this.labelNombreUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNombreUsuario.Click += new System.EventHandler(this.labelNombreUsuario_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Enabled = false;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bueno",
            "Malo"});
            this.comboBox1.Location = new System.Drawing.Point(275, 181);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(300, 21);
            this.comboBox1.TabIndex = 71;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            this.buttonGuardar.Location = new System.Drawing.Point(684, 526);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(89, 23);
            this.buttonGuardar.TabIndex = 72;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonSeleccionar
            // 
            this.buttonSeleccionar.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonSeleccionar.Enabled = false;
            this.buttonSeleccionar.FlatAppearance.BorderSize = 0;
            this.buttonSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSeleccionar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSeleccionar.Location = new System.Drawing.Point(581, 181);
            this.buttonSeleccionar.Name = "buttonSeleccionar";
            this.buttonSeleccionar.Size = new System.Drawing.Size(81, 23);
            this.buttonSeleccionar.TabIndex = 73;
            this.buttonSeleccionar.Text = "Seleccionar";
            this.buttonSeleccionar.UseVisualStyleBackColor = false;
            this.buttonSeleccionar.Click += new System.EventHandler(this.buttonSeleccionar_Click);
            // 
            // ActualizarEjemplar
            // 
            this.AcceptButton = this.buttonBuscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.buttonSeleccionar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelNombreUsuario);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonBuscar);
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
            this.Controls.Add(this.textBoxId);
            this.Enabled = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "ActualizarEjemplar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CEjemplar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CEjemplar_FormClosed);
            this.Load += new System.EventHandler(this.ActualizarEjemplar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxIdLibro;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.TextBox textBoxAutor;
        private System.Windows.Forms.TextBox textBoxAñoPublicacion;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.Label labelIDEjemplar;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label labelIdLibro;
        private System.Windows.Forms.Label labelISBN;
        private System.Windows.Forms.Label labelAñoPublicacion;
        private System.Windows.Forms.Label labelAutor;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Label labelNombreUsuario;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonSeleccionar;
    }
}