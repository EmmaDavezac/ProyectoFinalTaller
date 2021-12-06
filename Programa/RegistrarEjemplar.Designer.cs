
namespace Programa
{
    partial class RegistrarEjemplar
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
            this.labelError = new System.Windows.Forms.Label();
            this.buttonBuscarLibro = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            this.labelNombreUsuario = new System.Windows.Forms.Label();
            this.labelISBN = new System.Windows.Forms.Label();
            this.labelAñoPublicacion = new System.Windows.Forms.Label();
            this.labelAutor = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.textBoxAñoPublicacion = new System.Windows.Forms.TextBox();
            this.textBoxAutor = new System.Windows.Forms.TextBox();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.buttonGuardarEjemplar = new System.Windows.Forms.Button();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(256, 282);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 50;
            // 
            // buttonBuscarLibro
            // 
            this.buttonBuscarLibro.Location = new System.Drawing.Point(470, 310);
            this.buttonBuscarLibro.Name = "buttonBuscarLibro";
            this.buttonBuscarLibro.Size = new System.Drawing.Size(89, 23);
            this.buttonBuscarLibro.TabIndex = 49;
            this.buttonBuscarLibro.Text = "Buscar Libro";
            this.buttonBuscarLibro.UseVisualStyleBackColor = true;
            this.buttonBuscarLibro.Click += new System.EventHandler(this.buttonBuscarLibro_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(152, 131);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(16, 13);
            this.labelId.TabIndex = 48;
            this.labelId.Text = "Id";
            // 
            // labelNombreUsuario
            // 
            this.labelNombreUsuario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelNombreUsuario.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelNombreUsuario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelNombreUsuario.Location = new System.Drawing.Point(606, 9);
            this.labelNombreUsuario.Name = "labelNombreUsuario";
            this.labelNombreUsuario.Size = new System.Drawing.Size(182, 31);
            this.labelNombreUsuario.TabIndex = 46;
            this.labelNombreUsuario.Text = "Nombre de Usuario";
            this.labelNombreUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelISBN
            // 
            this.labelISBN.AutoSize = true;
            this.labelISBN.Location = new System.Drawing.Point(150, 262);
            this.labelISBN.Name = "labelISBN";
            this.labelISBN.Size = new System.Drawing.Size(32, 13);
            this.labelISBN.TabIndex = 45;
            this.labelISBN.Text = "ISBN";
            // 
            // labelAñoPublicacion
            // 
            this.labelAñoPublicacion.AutoSize = true;
            this.labelAñoPublicacion.Location = new System.Drawing.Point(150, 236);
            this.labelAñoPublicacion.Name = "labelAñoPublicacion";
            this.labelAñoPublicacion.Size = new System.Drawing.Size(83, 13);
            this.labelAñoPublicacion.TabIndex = 44;
            this.labelAñoPublicacion.Text = "Año publicacion";
            // 
            // labelAutor
            // 
            this.labelAutor.AutoSize = true;
            this.labelAutor.Location = new System.Drawing.Point(150, 210);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(35, 13);
            this.labelAutor.TabIndex = 43;
            this.labelAutor.Text = "Autor:";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(150, 184);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(33, 13);
            this.labelTitulo.TabIndex = 42;
            this.labelTitulo.Text = "Titulo";
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Location = new System.Drawing.Point(259, 259);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.ReadOnly = true;
            this.textBoxISBN.Size = new System.Drawing.Size(300, 20);
            this.textBoxISBN.TabIndex = 41;
            // 
            // textBoxAñoPublicacion
            // 
            this.textBoxAñoPublicacion.Location = new System.Drawing.Point(259, 233);
            this.textBoxAñoPublicacion.Name = "textBoxAñoPublicacion";
            this.textBoxAñoPublicacion.ReadOnly = true;
            this.textBoxAñoPublicacion.Size = new System.Drawing.Size(300, 20);
            this.textBoxAñoPublicacion.TabIndex = 40;
            // 
            // textBoxAutor
            // 
            this.textBoxAutor.Location = new System.Drawing.Point(259, 207);
            this.textBoxAutor.Name = "textBoxAutor";
            this.textBoxAutor.ReadOnly = true;
            this.textBoxAutor.Size = new System.Drawing.Size(300, 20);
            this.textBoxAutor.TabIndex = 39;
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(259, 181);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.ReadOnly = true;
            this.textBoxTitulo.Size = new System.Drawing.Size(300, 20);
            this.textBoxTitulo.TabIndex = 38;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(259, 128);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(300, 20);
            this.textBoxId.TabIndex = 37;
            this.textBoxId.TextChanged += new System.EventHandler(this.textBoxId_TextChanged);
            // 
            // buttonVolver
            // 
            this.buttonVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonVolver.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonVolver.Location = new System.Drawing.Point(605, 565);
            this.buttonVolver.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(89, 23);
            this.buttonVolver.TabIndex = 51;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // buttonGuardarEjemplar
            // 
            this.buttonGuardarEjemplar.Location = new System.Drawing.Point(699, 565);
            this.buttonGuardarEjemplar.Name = "buttonGuardarEjemplar";
            this.buttonGuardarEjemplar.Size = new System.Drawing.Size(89, 23);
            this.buttonGuardarEjemplar.TabIndex = 52;
            this.buttonGuardarEjemplar.Text = "Guardar";
            this.buttonGuardarEjemplar.UseVisualStyleBackColor = true;
            this.buttonGuardarEjemplar.Click += new System.EventHandler(this.buttonGuardarEjemplar_Click);
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Items.AddRange(new object[] {
            "Malo",
            "Bueno"});
            this.comboBoxEstado.Location = new System.Drawing.Point(259, 154);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(300, 21);
            this.comboBoxEstado.TabIndex = 53;
            this.comboBoxEstado.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // RegistrarEjemplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.comboBoxEstado);
            this.Controls.Add(this.buttonGuardarEjemplar);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonBuscarLibro);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.labelNombreUsuario);
            this.Controls.Add(this.labelISBN);
            this.Controls.Add(this.labelAñoPublicacion);
            this.Controls.Add(this.labelAutor);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.textBoxISBN);
            this.Controls.Add(this.textBoxAñoPublicacion);
            this.Controls.Add(this.textBoxAutor);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.textBoxId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "RegistrarEjemplar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrarEjemplar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegistrarEjemplar_FormClosed);
            this.Load += new System.EventHandler(this.RegistrarEjemplar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button buttonBuscarLibro;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelNombreUsuario;
        private System.Windows.Forms.Label labelISBN;
        private System.Windows.Forms.Label labelAñoPublicacion;
        private System.Windows.Forms.Label labelAutor;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.TextBox textBoxAñoPublicacion;
        private System.Windows.Forms.TextBox textBoxAutor;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.Button buttonGuardarEjemplar;
        private System.Windows.Forms.ComboBox comboBoxEstado;
    }
}