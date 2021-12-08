
namespace Programa
{
    partial class VerPrestamosRetrasados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelNombreUsuario = new System.Windows.Forms.Label();
            this.botonVolver = new System.Windows.Forms.Button();
            this.dataGridViewPrestamos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaLimite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDevolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoInicialEjemplar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProximoAVencerser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Retrasado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDEjemplar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNombreUsuario
            // 
            this.labelNombreUsuario.BackColor = System.Drawing.SystemColors.Highlight;
            this.labelNombreUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNombreUsuario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelNombreUsuario.Location = new System.Drawing.Point(607, 9);
            this.labelNombreUsuario.Name = "labelNombreUsuario";
            this.labelNombreUsuario.Size = new System.Drawing.Size(182, 31);
            this.labelNombreUsuario.TabIndex = 65;
            this.labelNombreUsuario.Text = "Nombre de Usuario";
            this.labelNombreUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNombreUsuario.Click += new System.EventHandler(this.labelNombreUsuario_Click);
            // 
            // botonVolver
            // 
            this.botonVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.botonVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonVolver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.botonVolver.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.botonVolver.Location = new System.Drawing.Point(700, 565);
            this.botonVolver.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(89, 23);
            this.botonVolver.TabIndex = 97;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // dataGridViewPrestamos
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewPrestamos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewPrestamos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewPrestamos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPrestamos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewPrestamos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPrestamos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrestamos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FechaPrestamo,
            this.FechaLimite,
            this.FechaDevolucion,
            this.EstadoInicialEjemplar,
            this.EstadoFinal,
            this.ProximoAVencerser,
            this.Retrasado,
            this.IdUsuario,
            this.Nombre,
            this.Mail,
            this.IdLibro,
            this.Titulo,
            this.ISBN,
            this.IDEjemplar,
            this.Estado,
            this.Disponible});
            this.dataGridViewPrestamos.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewPrestamos.Location = new System.Drawing.Point(3, 136);
            this.dataGridViewPrestamos.Name = "dataGridViewPrestamos";
            this.dataGridViewPrestamos.ReadOnly = true;
            this.dataGridViewPrestamos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewPrestamos.Size = new System.Drawing.Size(793, 403);
            this.dataGridViewPrestamos.TabIndex = 98;
            this.dataGridViewPrestamos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPrestamos_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // FechaPrestamo
            // 
            this.FechaPrestamo.HeaderText = "Fecha";
            this.FechaPrestamo.Name = "FechaPrestamo";
            this.FechaPrestamo.ReadOnly = true;
            // 
            // FechaLimite
            // 
            this.FechaLimite.HeaderText = "Fecha Limite";
            this.FechaLimite.Name = "FechaLimite";
            this.FechaLimite.ReadOnly = true;
            // 
            // FechaDevolucion
            // 
            this.FechaDevolucion.HeaderText = "FechaDevolucion";
            this.FechaDevolucion.Name = "FechaDevolucion";
            this.FechaDevolucion.ReadOnly = true;
            // 
            // EstadoInicialEjemplar
            // 
            this.EstadoInicialEjemplar.HeaderText = "EstadoInicial";
            this.EstadoInicialEjemplar.Name = "EstadoInicialEjemplar";
            this.EstadoInicialEjemplar.ReadOnly = true;
            // 
            // EstadoFinal
            // 
            this.EstadoFinal.HeaderText = "Estado Final";
            this.EstadoFinal.Name = "EstadoFinal";
            this.EstadoFinal.ReadOnly = true;
            // 
            // ProximoAVencerser
            // 
            this.ProximoAVencerser.HeaderText = "Proximo a vencer";
            this.ProximoAVencerser.Name = "ProximoAVencerser";
            this.ProximoAVencerser.ReadOnly = true;
            // 
            // Retrasado
            // 
            this.Retrasado.HeaderText = "Retrasado";
            this.Retrasado.Name = "Retrasado";
            this.Retrasado.ReadOnly = true;
            // 
            // IdUsuario
            // 
            this.IdUsuario.HeaderText = "Id Usuario";
            this.IdUsuario.Name = "IdUsuario";
            this.IdUsuario.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Mail
            // 
            this.Mail.HeaderText = "Mail";
            this.Mail.Name = "Mail";
            this.Mail.ReadOnly = true;
            // 
            // IdLibro
            // 
            this.IdLibro.HeaderText = "IdLibro";
            this.IdLibro.Name = "IdLibro";
            this.IdLibro.ReadOnly = true;
            // 
            // Titulo
            // 
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            // 
            // ISBN
            // 
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            // 
            // IDEjemplar
            // 
            this.IDEjemplar.HeaderText = "IDEjemplar";
            this.IDEjemplar.Name = "IDEjemplar";
            this.IDEjemplar.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Disponible
            // 
            this.Disponible.HeaderText = "Disponible";
            this.Disponible.Name = "Disponible";
            this.Disponible.ReadOnly = true;
            // 
            // VerPrestamosRetrasados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.dataGridViewPrestamos);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.labelNombreUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "VerPrestamosRetrasados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VerPrestamos_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrestamos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelNombreUsuario;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.DataGridView dataGridViewPrestamos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaLimite;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDevolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoInicialEjemplar;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProximoAVencerser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Retrasado;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDEjemplar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disponible;
    }
}