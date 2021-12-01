
namespace Programa
{
    partial class VerUsuarios
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
            this.buttonSalir = new System.Windows.Forms.Button();
            this.botonVolver = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSalir
            // 
            this.buttonSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonSalir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonSalir.Location = new System.Drawing.Point(524, 406);
            this.buttonSalir.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(89, 23);
            this.buttonSalir.TabIndex = 6;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // botonVolver
            // 
            this.botonVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.botonVolver.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.botonVolver.Location = new System.Drawing.Point(431, 406);
            this.botonVolver.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(89, 23);
            this.botonVolver.TabIndex = 7;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Apellido,
            this.FechaNacimiento,
            this.Email});
            this.dgvUsuarios.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvUsuarios.Location = new System.Drawing.Point(29, 36);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvUsuarios.Size = new System.Drawing.Size(544, 284);
            this.dgvUsuarios.TabIndex = 8;
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "IdUsuario";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.HeaderText = "Fecha de Nacimiento";
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.ReadOnly = true;
            this.FechaNacimiento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // VerUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.buttonSalir);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(640, 480);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "VerUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver Usuarios";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VerUsuarios_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}