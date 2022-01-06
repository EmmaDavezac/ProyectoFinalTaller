
namespace Programa
{
    partial class GestionarPrestamos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.labelNombreUsuario = new System.Windows.Forms.Label();
            this.dataGridViewPrestamos = new System.Windows.Forms.DataGridView();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.textBoxUsuarioOTituloLibro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.botonVolver = new System.Windows.Forms.Button();
            this.checkBoxProximosAVencerse = new System.Windows.Forms.CheckBox();
            this.checkBoxRestrasados = new System.Windows.Forms.CheckBox();
            this.RegistrarDevolucion = new System.Windows.Forms.DataGridViewLinkColumn();
            this.IdPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TituloLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBNLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRealizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(784, 60);
            this.panel3.TabIndex = 72;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(82, 60);
            this.panel4.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "E-Librery";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Programa.Properties.Resources.libro_abierto;
            this.pictureBox2.Location = new System.Drawing.Point(16, 3);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel5.Controls.Add(this.pictureBox4);
            this.panel5.Controls.Add(this.labelNombreUsuario);
            this.panel5.Location = new System.Drawing.Point(566, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(207, 60);
            this.panel5.TabIndex = 9;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::Programa.Properties.Resources.perfil_del_usuario;
            this.pictureBox4.Location = new System.Drawing.Point(155, 12);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // labelNombreUsuario
            // 
            this.labelNombreUsuario.AutoSize = true;
            this.labelNombreUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNombreUsuario.Location = new System.Drawing.Point(8, 16);
            this.labelNombreUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 5, 0);
            this.labelNombreUsuario.Name = "labelNombreUsuario";
            this.labelNombreUsuario.Size = new System.Drawing.Size(84, 13);
            this.labelNombreUsuario.TabIndex = 0;
            this.labelNombreUsuario.Text = "Nombre Apellido";
            this.labelNombreUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridViewPrestamos
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewPrestamos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPrestamos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewPrestamos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrestamos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RegistrarDevolucion,
            this.IdPrestamo,
            this.NombreUsuario,
            this.TituloLibro,
            this.ISBNLibro,
            this.FechaRealizacion,
            this.FechaVencimiento,
            this.EstadoPrestamo,
            this.Edit});
            this.dataGridViewPrestamos.Location = new System.Drawing.Point(0, 132);
            this.dataGridViewPrestamos.Name = "dataGridViewPrestamos";
            this.dataGridViewPrestamos.Size = new System.Drawing.Size(784, 386);
            this.dataGridViewPrestamos.TabIndex = 77;
            this.dataGridViewPrestamos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPrestamos_CellContentClick);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.Black;
            this.labelTitulo.Location = new System.Drawing.Point(24, 66);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(165, 13);
            this.labelTitulo.TabIndex = 80;
            this.labelTitulo.Text = "Listar y gestionar prestamos";
            // 
            // textBoxUsuarioOTituloLibro
            // 
            this.textBoxUsuarioOTituloLibro.Location = new System.Drawing.Point(259, 94);
            this.textBoxUsuarioOTituloLibro.Name = "textBoxUsuarioOTituloLibro";
            this.textBoxUsuarioOTituloLibro.Size = new System.Drawing.Size(300, 20);
            this.textBoxUsuarioOTituloLibro.TabIndex = 79;
            this.textBoxUsuarioOTituloLibro.TextChanged += new System.EventHandler(this.textBoxUsuarioOTituloLibro_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 78;
            this.label1.Text = "Usuario o Titulo del libro:";
            // 
            // botonVolver
            // 
            this.botonVolver.BackColor = System.Drawing.SystemColors.Highlight;
            this.botonVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.botonVolver.FlatAppearance.BorderSize = 0;
            this.botonVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonVolver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.botonVolver.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.botonVolver.Location = new System.Drawing.Point(684, 526);
            this.botonVolver.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(89, 23);
            this.botonVolver.TabIndex = 81;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = false;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // checkBoxProximosAVencerse
            // 
            this.checkBoxProximosAVencerse.AutoSize = true;
            this.checkBoxProximosAVencerse.Location = new System.Drawing.Point(577, 97);
            this.checkBoxProximosAVencerse.Name = "checkBoxProximosAVencerse";
            this.checkBoxProximosAVencerse.Size = new System.Drawing.Size(80, 17);
            this.checkBoxProximosAVencerse.TabIndex = 82;
            this.checkBoxProximosAVencerse.Text = "A vencerse";
            this.checkBoxProximosAVencerse.UseVisualStyleBackColor = true;
            this.checkBoxProximosAVencerse.CheckedChanged += new System.EventHandler(this.checkBoxProximosAVencerse_CheckedChanged);
            // 
            // checkBoxRestrasados
            // 
            this.checkBoxRestrasados.AutoSize = true;
            this.checkBoxRestrasados.Location = new System.Drawing.Point(663, 97);
            this.checkBoxRestrasados.Name = "checkBoxRestrasados";
            this.checkBoxRestrasados.Size = new System.Drawing.Size(80, 17);
            this.checkBoxRestrasados.TabIndex = 83;
            this.checkBoxRestrasados.Text = "Retrasados";
            this.checkBoxRestrasados.UseVisualStyleBackColor = true;
            this.checkBoxRestrasados.CheckedChanged += new System.EventHandler(this.checkBoxRestrasados_CheckedChanged);
            // 
            // RegistrarDevolucion
            // 
            this.RegistrarDevolucion.HeaderText = "RegistrarDevolucion";
            this.RegistrarDevolucion.Name = "RegistrarDevolucion";
            this.RegistrarDevolucion.ReadOnly = true;
            this.RegistrarDevolucion.Text = "Devolucion";
            this.RegistrarDevolucion.UseColumnTextForLinkValue = true;
            this.RegistrarDevolucion.Width = 110;
            // 
            // IdPrestamo
            // 
            this.IdPrestamo.HeaderText = "IdPrestamo";
            this.IdPrestamo.Name = "IdPrestamo";
            this.IdPrestamo.ReadOnly = true;
            this.IdPrestamo.Width = 75;
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.HeaderText = "NombreUsuario";
            this.NombreUsuario.Name = "NombreUsuario";
            this.NombreUsuario.ReadOnly = true;
            // 
            // TituloLibro
            // 
            this.TituloLibro.HeaderText = "TituloLibro";
            this.TituloLibro.Name = "TituloLibro";
            this.TituloLibro.ReadOnly = true;
            this.TituloLibro.Width = 140;
            // 
            // ISBNLibro
            // 
            this.ISBNLibro.HeaderText = "ISBNLibro";
            this.ISBNLibro.Name = "ISBNLibro";
            this.ISBNLibro.ReadOnly = true;
            this.ISBNLibro.Width = 120;
            // 
            // FechaRealizacion
            // 
            this.FechaRealizacion.HeaderText = "FechaRealizacion";
            this.FechaRealizacion.Name = "FechaRealizacion";
            this.FechaRealizacion.ReadOnly = true;
            // 
            // FechaVencimiento
            // 
            this.FechaVencimiento.HeaderText = "FechaVencimiento";
            this.FechaVencimiento.Name = "FechaVencimiento";
            this.FechaVencimiento.ReadOnly = true;
            // 
            // EstadoPrestamo
            // 
            this.EstadoPrestamo.HeaderText = "EstadoPrestamo";
            this.EstadoPrestamo.Name = "EstadoPrestamo";
            this.EstadoPrestamo.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForLinkValue = true;
            // 
            // GestionarPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.checkBoxRestrasados);
            this.Controls.Add(this.checkBoxProximosAVencerse);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.textBoxUsuarioOTituloLibro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewPrestamos);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GestionarPrestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionarPrestamos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GestionarPrestamos_FormClosed);
            this.Load += new System.EventHandler(this.GestionarPrestamos_Load);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrestamos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label labelNombreUsuario;
        private System.Windows.Forms.DataGridView dataGridViewPrestamos;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.TextBox textBoxUsuarioOTituloLibro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.CheckBox checkBoxProximosAVencerse;
        private System.Windows.Forms.CheckBox checkBoxRestrasados;
        private System.Windows.Forms.DataGridViewLinkColumn RegistrarDevolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn TituloLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBNLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRealizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoPrestamo;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
    }
}