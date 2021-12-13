
namespace Programa
{
    partial class ConsultarUsuario
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
            this.buttonBuscarUsuario = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.botonVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxFecha = new System.Windows.Forms.TextBox();
            this.labelScoring = new System.Windows.Forms.Label();
            this.textBoxScoring = new System.Windows.Forms.TextBox();
            this.labelNombreUsuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(256, 312);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 32;
            // 
            // buttonBuscarUsuario
            // 
            this.buttonBuscarUsuario.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonBuscarUsuario.Enabled = false;
            this.buttonBuscarUsuario.FlatAppearance.BorderSize = 0;
            this.buttonBuscarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBuscarUsuario.Location = new System.Drawing.Point(470, 328);
            this.buttonBuscarUsuario.Name = "buttonBuscarUsuario";
            this.buttonBuscarUsuario.Size = new System.Drawing.Size(89, 23);
            this.buttonBuscarUsuario.TabIndex = 31;
            this.buttonBuscarUsuario.Text = "Buscar Usuario";
            this.buttonBuscarUsuario.UseVisualStyleBackColor = false;
            this.buttonBuscarUsuario.Click += new System.EventHandler(this.buttonBuscarUsuario_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "FechaNacimiento";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(149, 188);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(44, 13);
            this.labelApellido.TabIndex = 28;
            this.labelApellido.Text = "Apellido";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(149, 162);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 27;
            this.labelNombre.Text = "Nombre";
            // 
            // textBoxMail
            // 
            this.textBoxMail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxMail.Location = new System.Drawing.Point(259, 237);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.ReadOnly = true;
            this.textBoxMail.Size = new System.Drawing.Size(300, 20);
            this.textBoxMail.TabIndex = 25;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxApellido.Location = new System.Drawing.Point(259, 185);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.ReadOnly = true;
            this.textBoxApellido.Size = new System.Drawing.Size(300, 20);
            this.textBoxApellido.TabIndex = 24;
            this.textBoxApellido.TextChanged += new System.EventHandler(this.textBoxApellido_TextChanged);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxNombre.Location = new System.Drawing.Point(259, 159);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.ReadOnly = true;
            this.textBoxNombre.Size = new System.Drawing.Size(300, 20);
            this.textBoxNombre.TabIndex = 23;
            // 
            // botonVolver
            // 
            this.botonVolver.BackColor = System.Drawing.SystemColors.Highlight;
            this.botonVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.botonVolver.FlatAppearance.BorderSize = 0;
            this.botonVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonVolver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.botonVolver.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.botonVolver.Location = new System.Drawing.Point(686, 531);
            this.botonVolver.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(89, 23);
            this.botonVolver.TabIndex = 22;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = false;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(259, 133);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(300, 20);
            this.textBoxId.TabIndex = 34;
            this.textBoxId.TextChanged += new System.EventHandler(this.textBoxId_TextChanged);
            // 
            // textBoxFecha
            // 
            this.textBoxFecha.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxFecha.Location = new System.Drawing.Point(259, 211);
            this.textBoxFecha.Name = "textBoxFecha";
            this.textBoxFecha.ReadOnly = true;
            this.textBoxFecha.Size = new System.Drawing.Size(300, 20);
            this.textBoxFecha.TabIndex = 35;
            // 
            // labelScoring
            // 
            this.labelScoring.AutoSize = true;
            this.labelScoring.Location = new System.Drawing.Point(149, 292);
            this.labelScoring.Name = "labelScoring";
            this.labelScoring.Size = new System.Drawing.Size(43, 13);
            this.labelScoring.TabIndex = 38;
            this.labelScoring.Text = "Scoring";
            this.labelScoring.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxScoring
            // 
            this.textBoxScoring.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxScoring.Location = new System.Drawing.Point(259, 289);
            this.textBoxScoring.Name = "textBoxScoring";
            this.textBoxScoring.ReadOnly = true;
            this.textBoxScoring.Size = new System.Drawing.Size(300, 20);
            this.textBoxScoring.TabIndex = 37;
            this.textBoxScoring.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelNombreUsuario
            // 
            this.labelNombreUsuario.BackColor = System.Drawing.SystemColors.Highlight;
            this.labelNombreUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNombreUsuario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelNombreUsuario.Location = new System.Drawing.Point(606, 9);
            this.labelNombreUsuario.Name = "labelNombreUsuario";
            this.labelNombreUsuario.Size = new System.Drawing.Size(182, 31);
            this.labelNombreUsuario.TabIndex = 39;
            this.labelNombreUsuario.Text = "Nombre de Usuario";
            this.labelNombreUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Telefono";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxTelefono.Location = new System.Drawing.Point(259, 263);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.ReadOnly = true;
            this.textBoxTelefono.Size = new System.Drawing.Size(300, 20);
            this.textBoxTelefono.TabIndex = 40;
            this.textBoxTelefono.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // ConsultarUsuario
            // 
            this.AcceptButton = this.buttonBuscarUsuario;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.labelNombreUsuario);
            this.Controls.Add(this.labelScoring);
            this.Controls.Add(this.textBoxScoring);
            this.Controls.Add(this.textBoxFecha);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonBuscarUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.botonVolver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "ConsultarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Usuario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConsultarUsuario_FormClosed);
            this.Load += new System.EventHandler(this.ConsultarUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button buttonBuscarUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxFecha;
        private System.Windows.Forms.Label labelScoring;
        private System.Windows.Forms.TextBox textBoxScoring;
        private System.Windows.Forms.Label labelNombreUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTelefono;
    }
}