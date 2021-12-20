
using System;

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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelError = new System.Windows.Forms.Label();
            this.buttonBuscarUsuario = new System.Windows.Forms.Button();
            this.botonVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNombreUsuario = new System.Windows.Forms.TextBox();
            this.labelNombreUsuario = new System.Windows.Forms.Label();
            this.dataGridViewUsuarios = new System.Windows.Forms.DataGridView();
            this.usuarioSimpleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.NombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Scoring = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonRefrescar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioSimpleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
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
            this.buttonBuscarUsuario.Location = new System.Drawing.Point(456, 109);
            this.buttonBuscarUsuario.Name = "buttonBuscarUsuario";
            this.buttonBuscarUsuario.Size = new System.Drawing.Size(89, 23);
            this.buttonBuscarUsuario.TabIndex = 31;
            this.buttonBuscarUsuario.Text = "Buscar Usuario";
            this.buttonBuscarUsuario.UseVisualStyleBackColor = false;
            this.buttonBuscarUsuario.Click += new System.EventHandler(this.buttonBuscarUsuario_Click);
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
            this.label1.Location = new System.Drawing.Point(54, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "NombreUsuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxNombreUsuario
            // 
            this.textBoxNombreUsuario.Location = new System.Drawing.Point(140, 111);
            this.textBoxNombreUsuario.Name = "textBoxNombreUsuario";
            this.textBoxNombreUsuario.Size = new System.Drawing.Size(300, 20);
            this.textBoxNombreUsuario.TabIndex = 34;
            this.textBoxNombreUsuario.TextChanged += new System.EventHandler(this.textBoxId_TextChanged);
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
            // dataGridViewUsuarios
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewUsuarios.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.NombreUsuario,
            this.Scoring,
            this.Nombre,
            this.Apellido,
            this.FechaNacimiento,
            this.Mail,
            this.Telefono});
            this.dataGridViewUsuarios.Location = new System.Drawing.Point(1, 138);
            this.dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            this.dataGridViewUsuarios.Size = new System.Drawing.Size(787, 387);
            this.dataGridViewUsuarios.TabIndex = 40;
            this.dataGridViewUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsuarios_CellContentClick);
            // 
            // usuarioSimpleBindingSource
            // 
            this.usuarioSimpleBindingSource.DataSource = typeof(Dominio.UsuarioSimple);
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(Dominio.Usuario);
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForLinkValue = true;
            this.Edit.Width = 50;
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.HeaderText = "NombreUsuario";
            this.NombreUsuario.Name = "NombreUsuario";
            this.NombreUsuario.ReadOnly = true;
            // 
            // Scoring
            // 
            this.Scoring.HeaderText = "Scoring";
            this.Scoring.Name = "Scoring";
            this.Scoring.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.HeaderText = "FechaNacimiento";
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.ReadOnly = true;
            // 
            // Mail
            // 
            this.Mail.HeaderText = "Mail";
            this.Mail.Name = "Mail";
            this.Mail.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // buttonRefrescar
            // 
            this.buttonRefrescar.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonRefrescar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonRefrescar.FlatAppearance.BorderSize = 0;
            this.buttonRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefrescar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonRefrescar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonRefrescar.Location = new System.Drawing.Point(561, 109);
            this.buttonRefrescar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonRefrescar.Name = "buttonRefrescar";
            this.buttonRefrescar.Size = new System.Drawing.Size(89, 23);
            this.buttonRefrescar.TabIndex = 41;
            this.buttonRefrescar.Text = "Refrescar";
            this.buttonRefrescar.UseVisualStyleBackColor = false;
            this.buttonRefrescar.Click += new System.EventHandler(this.buttonRefrescar_Click);
            // 
            // ConsultarUsuario
            // 
            this.AcceptButton = this.buttonBuscarUsuario;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.buttonRefrescar);
            this.Controls.Add(this.dataGridViewUsuarios);
            this.Controls.Add(this.labelNombreUsuario);
            this.Controls.Add(this.textBoxNombreUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonBuscarUsuario);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioSimpleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button buttonBuscarUsuario;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNombreUsuario;
        private System.Windows.Forms.Label labelNombreUsuario;
        private System.Windows.Forms.BindingSource usuarioSimpleBindingSource;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.DataGridView dataGridViewUsuarios;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Scoring;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.Button buttonRefrescar;
    }
}