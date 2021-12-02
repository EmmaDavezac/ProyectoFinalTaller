
namespace Programa
{
    partial class Login
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
            this.botonSalir = new System.Windows.Forms.Button();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.labelIdAdministrador = new System.Windows.Forms.Label();
            this.labelConstraseña = new System.Windows.Forms.Label();
            this.botonIniciarSesion = new System.Windows.Forms.Button();
            this.buttonRegistrarse = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.buttonMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxId
            // 
            this.textBoxId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxId.Location = new System.Drawing.Point(222, 142);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(182, 20);
            this.textBoxId.TabIndex = 0;
            this.textBoxId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxId.TextChanged += new System.EventHandler(this.textBoxUsuario_TextChanged);
            // 
            // botonSalir
            // 
            this.botonSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.botonSalir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.botonSalir.Location = new System.Drawing.Point(524, 406);
            this.botonSalir.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(89, 23);
            this.botonSalir.TabIndex = 3;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxContraseña.Location = new System.Drawing.Point(222, 208);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.Size = new System.Drawing.Size(182, 20);
            this.textBoxContraseña.TabIndex = 4;
            this.textBoxContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxContraseña.UseSystemPasswordChar = true;
            this.textBoxContraseña.TextChanged += new System.EventHandler(this.textBoxContraseña_TextChanged);
            // 
            // labelIdAdministrador
            // 
            this.labelIdAdministrador.AutoSize = true;
            this.labelIdAdministrador.Location = new System.Drawing.Point(99, 144);
            this.labelIdAdministrador.Name = "labelIdAdministrador";
            this.labelIdAdministrador.Size = new System.Drawing.Size(82, 13);
            this.labelIdAdministrador.TabIndex = 5;
            this.labelIdAdministrador.Text = "Id Administrador";
            this.labelIdAdministrador.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelConstraseña
            // 
            this.labelConstraseña.AutoSize = true;
            this.labelConstraseña.Location = new System.Drawing.Point(99, 210);
            this.labelConstraseña.Name = "labelConstraseña";
            this.labelConstraseña.Size = new System.Drawing.Size(61, 13);
            this.labelConstraseña.TabIndex = 6;
            this.labelConstraseña.Text = "Contraseña";
            this.labelConstraseña.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // botonIniciarSesion
            // 
            this.botonIniciarSesion.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.botonIniciarSesion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.botonIniciarSesion.Location = new System.Drawing.Point(315, 263);
            this.botonIniciarSesion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.botonIniciarSesion.Name = "botonIniciarSesion";
            this.botonIniciarSesion.Size = new System.Drawing.Size(89, 23);
            this.botonIniciarSesion.TabIndex = 7;
            this.botonIniciarSesion.Text = "Iniciar Sesion";
            this.botonIniciarSesion.UseVisualStyleBackColor = true;
            this.botonIniciarSesion.Click += new System.EventHandler(this.botonIniciarSesion_Click);
            // 
            // buttonRegistrarse
            // 
            this.buttonRegistrarse.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonRegistrarse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonRegistrarse.Location = new System.Drawing.Point(222, 263);
            this.buttonRegistrarse.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonRegistrarse.Name = "buttonRegistrarse";
            this.buttonRegistrarse.Size = new System.Drawing.Size(89, 23);
            this.buttonRegistrarse.TabIndex = 8;
            this.buttonRegistrarse.Text = "Registrarse";
            this.buttonRegistrarse.UseVisualStyleBackColor = true;
            this.buttonRegistrarse.Click += new System.EventHandler(this.buttonRegistrarse_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(219, 243);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 33;
            // 
            // buttonMostrar
            // 
            this.buttonMostrar.Location = new System.Drawing.Point(410, 208);
            this.buttonMostrar.Name = "buttonMostrar";
            this.buttonMostrar.Size = new System.Drawing.Size(53, 23);
            this.buttonMostrar.TabIndex = 34;
            this.buttonMostrar.Text = "Mostrar";
            this.buttonMostrar.UseVisualStyleBackColor = true;
            this.buttonMostrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.botonIniciarSesion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.buttonMostrar);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonRegistrarse);
            this.Controls.Add(this.botonIniciarSesion);
            this.Controls.Add(this.labelConstraseña);
            this.Controls.Add(this.labelIdAdministrador);
            this.Controls.Add(this.textBoxContraseña);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.textBoxId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(640, 480);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Button botonSalir;
        internal System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.Label labelIdAdministrador;
        private System.Windows.Forms.Label labelConstraseña;
        private System.Windows.Forms.Button botonIniciarSesion;
        private System.Windows.Forms.Button buttonRegistrarse;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button buttonMostrar;
    }
}