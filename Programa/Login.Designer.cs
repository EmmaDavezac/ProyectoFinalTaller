
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
            this.components = new System.ComponentModel.Container();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.labelIdAdministrador = new System.Windows.Forms.Label();
            this.labelConstraseña = new System.Windows.Forms.Label();
            this.botonIniciarSesion = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.buttonMostrar = new System.Windows.Forms.Button();
            this.buttonRegistrarse = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxId
            // 
            this.textBoxId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxId.Location = new System.Drawing.Point(289, 311);
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
            this.textBoxContraseña.Location = new System.Drawing.Point(289, 377);
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
            this.labelIdAdministrador.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelIdAdministrador.Location = new System.Drawing.Point(286, 292);
            this.labelIdAdministrador.Name = "labelIdAdministrador";
            this.labelIdAdministrador.Size = new System.Drawing.Size(165, 16);
            this.labelIdAdministrador.TabIndex = 5;
            this.labelIdAdministrador.Text = "Nombre de Usuario o Mail";
            this.labelIdAdministrador.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelConstraseña
            // 
            this.labelConstraseña.AutoSize = true;
            this.labelConstraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConstraseña.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelConstraseña.Location = new System.Drawing.Point(286, 358);
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
            this.botonIniciarSesion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.botonIniciarSesion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.botonIniciarSesion.Location = new System.Drawing.Point(403, 448);
            this.botonIniciarSesion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.botonIniciarSesion.Name = "botonIniciarSesion";
            this.botonIniciarSesion.Size = new System.Drawing.Size(110, 30);
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
            this.labelError.Location = new System.Drawing.Point(286, 413);
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
            this.buttonMostrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonMostrar.Location = new System.Drawing.Point(519, 377);
            this.buttonMostrar.Name = "buttonMostrar";
            this.buttonMostrar.Size = new System.Drawing.Size(64, 22);
            this.buttonMostrar.TabIndex = 34;
            this.buttonMostrar.Text = "Mostrar";
            this.buttonMostrar.UseVisualStyleBackColor = false;
            this.buttonMostrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonRegistrarse
            // 
            this.buttonRegistrarse.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonRegistrarse.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonRegistrarse.FlatAppearance.BorderSize = 0;
            this.buttonRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistrarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrarse.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonRegistrarse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonRegistrarse.Location = new System.Drawing.Point(289, 448);
            this.buttonRegistrarse.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonRegistrarse.Name = "buttonRegistrarse";
            this.buttonRegistrarse.Size = new System.Drawing.Size(110, 30);
            this.buttonRegistrarse.TabIndex = 36;
            this.buttonRegistrarse.Text = "Registrarse";
            this.buttonRegistrarse.UseVisualStyleBackColor = false;
            this.buttonRegistrarse.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // timer1
            // 
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::Programa.Properties.Resources.pngegg;
            this.pictureBox1.Location = new System.Drawing.Point(307, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AcceptButton = this.botonIniciarSesion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonRegistrarse);
            this.Controls.Add(this.buttonMostrar);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.botonIniciarSesion);
            this.Controls.Add(this.labelConstraseña);
            this.Controls.Add(this.labelIdAdministrador);
            this.Controls.Add(this.textBoxContraseña);
            this.Controls.Add(this.textBoxId);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Login";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button buttonRegistrarse;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}