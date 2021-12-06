
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
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.labelIdAdministrador = new System.Windows.Forms.Label();
            this.labelConstraseña = new System.Windows.Forms.Label();
            this.botonIniciarSesion = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.buttonMostrar = new System.Windows.Forms.Button();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.buttonRegistrarse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxId
            // 
            this.textBoxId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxId.Location = new System.Drawing.Point(293, 208);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(224, 22);
            this.textBoxId.TabIndex = 0;
            this.textBoxId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxId.TextChanged += new System.EventHandler(this.textBoxUsuario_TextChanged);
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContraseña.Location = new System.Drawing.Point(293, 274);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.Size = new System.Drawing.Size(224, 22);
            this.textBoxContraseña.TabIndex = 4;
            this.textBoxContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxContraseña.UseSystemPasswordChar = true;
            this.textBoxContraseña.TextChanged += new System.EventHandler(this.textBoxContraseña_TextChanged);
            // 
            // labelIdAdministrador
            // 
            this.labelIdAdministrador.AutoSize = true;
            this.labelIdAdministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdAdministrador.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelIdAdministrador.Location = new System.Drawing.Point(170, 210);
            this.labelIdAdministrador.Name = "labelIdAdministrador";
            this.labelIdAdministrador.Size = new System.Drawing.Size(105, 16);
            this.labelIdAdministrador.TabIndex = 5;
            this.labelIdAdministrador.Text = "Id Administrador";
            this.labelIdAdministrador.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelConstraseña
            // 
            this.labelConstraseña.AutoSize = true;
            this.labelConstraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConstraseña.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelConstraseña.Location = new System.Drawing.Point(170, 276);
            this.labelConstraseña.Name = "labelConstraseña";
            this.labelConstraseña.Size = new System.Drawing.Size(77, 16);
            this.labelConstraseña.TabIndex = 6;
            this.labelConstraseña.Text = "Contraseña";
            this.labelConstraseña.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // botonIniciarSesion
            // 
            this.botonIniciarSesion.BackColor = System.Drawing.SystemColors.Highlight;
            this.botonIniciarSesion.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.botonIniciarSesion.Enabled = false;
            this.botonIniciarSesion.FlatAppearance.BorderSize = 0;
            this.botonIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.botonIniciarSesion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.botonIniciarSesion.Location = new System.Drawing.Point(407, 345);
            this.botonIniciarSesion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.botonIniciarSesion.Name = "botonIniciarSesion";
            this.botonIniciarSesion.Size = new System.Drawing.Size(110, 25);
            this.botonIniciarSesion.TabIndex = 7;
            this.botonIniciarSesion.Text = "Iniciar Sesion";
            this.botonIniciarSesion.UseVisualStyleBackColor = false;
            this.botonIniciarSesion.Click += new System.EventHandler(this.botonIniciarSesion_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Black;
            this.labelError.Location = new System.Drawing.Point(290, 310);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 16);
            this.labelError.TabIndex = 33;
            // 
            // buttonMostrar
            // 
            this.buttonMostrar.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonMostrar.FlatAppearance.BorderSize = 0;
            this.buttonMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMostrar.ForeColor = System.Drawing.Color.White;
            this.buttonMostrar.Location = new System.Drawing.Point(523, 276);
            this.buttonMostrar.Name = "buttonMostrar";
            this.buttonMostrar.Size = new System.Drawing.Size(64, 22);
            this.buttonMostrar.TabIndex = 34;
            this.buttonMostrar.Text = "Mostrar";
            this.buttonMostrar.UseVisualStyleBackColor = false;
            this.buttonMostrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCerrar.FlatAppearance.BorderSize = 0;
            this.buttonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCerrar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonCerrar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonCerrar.Location = new System.Drawing.Point(739, 12);
            this.buttonCerrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(50, 50);
            this.buttonCerrar.TabIndex = 35;
            this.buttonCerrar.Text = "X";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // buttonRegistrarse
            // 
            this.buttonRegistrarse.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonRegistrarse.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonRegistrarse.FlatAppearance.BorderSize = 0;
            this.buttonRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistrarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrarse.ForeColor = System.Drawing.Color.White;
            this.buttonRegistrarse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonRegistrarse.Location = new System.Drawing.Point(293, 345);
            this.buttonRegistrarse.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonRegistrarse.Name = "buttonRegistrarse";
            this.buttonRegistrarse.Size = new System.Drawing.Size(110, 25);
            this.buttonRegistrarse.TabIndex = 36;
            this.buttonRegistrarse.Text = "Registrarse";
            this.buttonRegistrarse.UseVisualStyleBackColor = false;
            this.buttonRegistrarse.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Login
            // 
            this.AcceptButton = this.botonIniciarSesion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.buttonRegistrarse);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.buttonMostrar);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.botonIniciarSesion);
            this.Controls.Add(this.labelConstraseña);
            this.Controls.Add(this.labelIdAdministrador);
            this.Controls.Add(this.textBoxContraseña);
            this.Controls.Add(this.textBoxId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
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
        internal System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.Label labelIdAdministrador;
        private System.Windows.Forms.Label labelConstraseña;
        private System.Windows.Forms.Button botonIniciarSesion;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button buttonMostrar;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Button buttonRegistrarse;
    }
}