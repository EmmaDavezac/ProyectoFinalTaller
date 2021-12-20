
using System;

namespace Programa
{
    partial class ActualizarUsuario
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
            this.labelNombreUsuario = new System.Windows.Forms.Label();
            this.textBoxFecha = new System.Windows.Forms.TextBox();
            this.labelError = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNombreUsuario = new System.Windows.Forms.TextBox();
            this.botonVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNombreUsuario
            // 
            this.labelNombreUsuario.BackColor = System.Drawing.SystemColors.Highlight;
            this.labelNombreUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNombreUsuario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelNombreUsuario.Location = new System.Drawing.Point(606, 9);
            this.labelNombreUsuario.Name = "labelNombreUsuario";
            this.labelNombreUsuario.Size = new System.Drawing.Size(182, 31);
            this.labelNombreUsuario.TabIndex = 54;
            this.labelNombreUsuario.Text = "Nombre de Usuario";
            this.labelNombreUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxFecha
            // 
            this.textBoxFecha.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxFecha.Location = new System.Drawing.Point(272, 252);
            this.textBoxFecha.Name = "textBoxFecha";
            this.textBoxFecha.Size = new System.Drawing.Size(300, 20);
            this.textBoxFecha.TabIndex = 51;
            this.textBoxFecha.TextChanged += new System.EventHandler(this.textBoxFecha_TextChanged);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(269, 370);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(150, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(150, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "FechaNacimiento";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelApellido.Location = new System.Drawing.Point(150, 233);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(44, 13);
            this.labelApellido.TabIndex = 44;
            this.labelApellido.Text = "Apellido";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelNombre.Location = new System.Drawing.Point(150, 207);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 43;
            this.labelNombre.Text = "Nombre";
            this.labelNombre.Click += new System.EventHandler(this.labelNombre_Click);
            // 
            // textBoxMail
            // 
            this.textBoxMail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxMail.Location = new System.Drawing.Point(272, 305);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(300, 20);
            this.textBoxMail.TabIndex = 6;
            this.textBoxMail.TextChanged += new System.EventHandler(this.textBoxMail_TextChanged);
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxApellido.Location = new System.Drawing.Point(272, 226);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(300, 20);
            this.textBoxApellido.TabIndex = 5;
            this.textBoxApellido.TextChanged += new System.EventHandler(this.textBoxApellido_TextChanged);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxNombre.Location = new System.Drawing.Point(272, 200);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(300, 20);
            this.textBoxNombre.TabIndex = 4;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonGuardar.FlatAppearance.BorderSize = 0;
            this.buttonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonGuardar.Location = new System.Drawing.Point(680, 530);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(89, 23);
            this.buttonGuardar.TabIndex = 7;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(150, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Telefono";
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxTelefono.Location = new System.Drawing.Point(272, 279);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(300, 20);
            this.textBoxTelefono.TabIndex = 55;
            this.textBoxTelefono.TextChanged += new System.EventHandler(this.textBoxTelefono_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(150, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "NombreUsuario";
            // 
            // textBoxNombreUsuario
            // 
            this.textBoxNombreUsuario.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxNombreUsuario.Enabled = false;
            this.textBoxNombreUsuario.Location = new System.Drawing.Point(272, 174);
            this.textBoxNombreUsuario.Name = "textBoxNombreUsuario";
            this.textBoxNombreUsuario.Size = new System.Drawing.Size(300, 20);
            this.textBoxNombreUsuario.TabIndex = 58;
            // 
            // botonVolver
            // 
            this.botonVolver.BackColor = System.Drawing.SystemColors.Highlight;
            this.botonVolver.FlatAppearance.BorderSize = 0;
            this.botonVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonVolver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.botonVolver.Location = new System.Drawing.Point(585, 530);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(89, 23);
            this.botonVolver.TabIndex = 59;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = false;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click_1);
            // 
            // ActualizarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.textBoxNombreUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.labelNombreUsuario);
            this.Controls.Add(this.textBoxFecha);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.textBoxNombre);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "ActualizarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ActualizarUsuario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ActualizarUsuario_FormClosed);
            this.Load += new System.EventHandler(this.ActualizarUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        #endregion

        private System.Windows.Forms.Label labelNombreUsuario;
        private System.Windows.Forms.TextBox textBoxFecha;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNombreUsuario;
        private System.Windows.Forms.Button botonVolver;
    }
}