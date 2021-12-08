
namespace Programa
{
    partial class ConsultarLibro
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
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.textBoxAutor = new System.Windows.Forms.TextBox();
            this.textBoxAñoPublicacion = new System.Windows.Forms.TextBox();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelAutor = new System.Windows.Forms.Label();
            this.labelAñoPublicacion = new System.Windows.Forms.Label();
            this.labelISBN = new System.Windows.Forms.Label();
            this.labelNombreUsuario = new System.Windows.Forms.Label();
            this.botonVolver = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            this.buttonBuscarLibro = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(265, 173);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(300, 20);
            this.textBoxId.TabIndex = 7;
            this.textBoxId.TextChanged += new System.EventHandler(this.textBoxId_TextChanged);
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxTitulo.Enabled = false;
            this.textBoxTitulo.Location = new System.Drawing.Point(265, 199);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.ReadOnly = true;
            this.textBoxTitulo.Size = new System.Drawing.Size(300, 20);
            this.textBoxTitulo.TabIndex = 8;
            this.textBoxTitulo.TextChanged += new System.EventHandler(this.textTitulo_TextChanged);
            // 
            // textBoxAutor
            // 
            this.textBoxAutor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxAutor.Enabled = false;
            this.textBoxAutor.Location = new System.Drawing.Point(265, 225);
            this.textBoxAutor.Name = "textBoxAutor";
            this.textBoxAutor.ReadOnly = true;
            this.textBoxAutor.Size = new System.Drawing.Size(300, 20);
            this.textBoxAutor.TabIndex = 9;
            // 
            // textBoxAñoPublicacion
            // 
            this.textBoxAñoPublicacion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxAñoPublicacion.Enabled = false;
            this.textBoxAñoPublicacion.Location = new System.Drawing.Point(265, 251);
            this.textBoxAñoPublicacion.Name = "textBoxAñoPublicacion";
            this.textBoxAñoPublicacion.ReadOnly = true;
            this.textBoxAñoPublicacion.Size = new System.Drawing.Size(300, 20);
            this.textBoxAñoPublicacion.TabIndex = 10;
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxISBN.Enabled = false;
            this.textBoxISBN.Location = new System.Drawing.Point(265, 277);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.ReadOnly = true;
            this.textBoxISBN.Size = new System.Drawing.Size(300, 20);
            this.textBoxISBN.TabIndex = 11;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(156, 202);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(33, 13);
            this.labelTitulo.TabIndex = 12;
            this.labelTitulo.Text = "Titulo";
            // 
            // labelAutor
            // 
            this.labelAutor.AutoSize = true;
            this.labelAutor.Location = new System.Drawing.Point(156, 228);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(35, 13);
            this.labelAutor.TabIndex = 13;
            this.labelAutor.Text = "Autor:";
            // 
            // labelAñoPublicacion
            // 
            this.labelAñoPublicacion.AutoSize = true;
            this.labelAñoPublicacion.Location = new System.Drawing.Point(156, 254);
            this.labelAñoPublicacion.Name = "labelAñoPublicacion";
            this.labelAñoPublicacion.Size = new System.Drawing.Size(83, 13);
            this.labelAñoPublicacion.TabIndex = 14;
            this.labelAñoPublicacion.Text = "Año publicacion";
            // 
            // labelISBN
            // 
            this.labelISBN.AutoSize = true;
            this.labelISBN.Location = new System.Drawing.Point(156, 280);
            this.labelISBN.Name = "labelISBN";
            this.labelISBN.Size = new System.Drawing.Size(32, 13);
            this.labelISBN.TabIndex = 16;
            this.labelISBN.Text = "ISBN";
            // 
            // labelNombreUsuario
            // 
            this.labelNombreUsuario.BackColor = System.Drawing.SystemColors.Highlight;
            this.labelNombreUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelNombreUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNombreUsuario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelNombreUsuario.Location = new System.Drawing.Point(606, 9);
            this.labelNombreUsuario.Name = "labelNombreUsuario";
            this.labelNombreUsuario.Size = new System.Drawing.Size(182, 31);
            this.labelNombreUsuario.TabIndex = 18;
            this.labelNombreUsuario.Text = "Nombre de Usuario";
            this.labelNombreUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.botonVolver.TabIndex = 19;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = false;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(158, 176);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(16, 13);
            this.labelId.TabIndex = 34;
            this.labelId.Text = "Id";
            // 
            // buttonBuscarLibro
            // 
            this.buttonBuscarLibro.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonBuscarLibro.Enabled = false;
            this.buttonBuscarLibro.FlatAppearance.BorderSize = 0;
            this.buttonBuscarLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarLibro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBuscarLibro.Location = new System.Drawing.Point(476, 328);
            this.buttonBuscarLibro.Name = "buttonBuscarLibro";
            this.buttonBuscarLibro.Size = new System.Drawing.Size(89, 23);
            this.buttonBuscarLibro.TabIndex = 35;
            this.buttonBuscarLibro.Text = "Buscar Libro";
            this.buttonBuscarLibro.UseVisualStyleBackColor = false;
            this.buttonBuscarLibro.Click += new System.EventHandler(this.buttonBuscarUsuario_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(262, 300);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 36;
            // 
            // ConsultarLibro
            // 
            this.AcceptButton = this.buttonBuscarLibro;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonBuscarLibro);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.botonVolver);
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
            this.Name = "ConsultarLibro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultarLibro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConsultarLibro_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.TextBox textBoxAutor;
        private System.Windows.Forms.TextBox textBoxAñoPublicacion;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelAutor;
        private System.Windows.Forms.Label labelAñoPublicacion;
        private System.Windows.Forms.Label labelISBN;
        private System.Windows.Forms.Label labelNombreUsuario;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Button buttonBuscarLibro;
        private System.Windows.Forms.Label labelError;
    }
}