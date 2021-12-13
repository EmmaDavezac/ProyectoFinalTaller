
namespace Programa
{
    partial class VerLibros
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
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.botonVolver = new System.Windows.Forms.Button();
            this.labelNombreUsuario = new System.Windows.Forms.Label();
            this.textBoxAñoPublicacion = new System.Windows.Forms.TextBox();
            this.textBoxAutor = new System.Windows.Forms.TextBox();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AñoPublicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxISBN.Enabled = false;
            this.textBoxISBN.Location = new System.Drawing.Point(144, 152);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.ReadOnly = true;
            this.textBoxISBN.Size = new System.Drawing.Size(300, 20);
            this.textBoxISBN.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "ISBN";
            // 
            // botonVolver
            // 
            this.botonVolver.BackColor = System.Drawing.SystemColors.Highlight;
            this.botonVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.botonVolver.FlatAppearance.BorderSize = 0;
            this.botonVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonVolver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.botonVolver.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.botonVolver.Location = new System.Drawing.Point(744, 565);
            this.botonVolver.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(89, 23);
            this.botonVolver.TabIndex = 35;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = false;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // labelNombreUsuario
            // 
            this.labelNombreUsuario.BackColor = System.Drawing.SystemColors.Highlight;
            this.labelNombreUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNombreUsuario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelNombreUsuario.Location = new System.Drawing.Point(651, 9);
            this.labelNombreUsuario.Name = "labelNombreUsuario";
            this.labelNombreUsuario.Size = new System.Drawing.Size(182, 31);
            this.labelNombreUsuario.TabIndex = 33;
            this.labelNombreUsuario.Text = "Nombre de Usuario";
            this.labelNombreUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNombreUsuario.Click += new System.EventHandler(this.labelNombreUsuario_Click);
            // 
            // textBoxAñoPublicacion
            // 
            this.textBoxAñoPublicacion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxAñoPublicacion.Enabled = false;
            this.textBoxAñoPublicacion.Location = new System.Drawing.Point(144, 126);
            this.textBoxAñoPublicacion.Name = "textBoxAñoPublicacion";
            this.textBoxAñoPublicacion.ReadOnly = true;
            this.textBoxAñoPublicacion.Size = new System.Drawing.Size(300, 20);
            this.textBoxAñoPublicacion.TabIndex = 31;
            // 
            // textBoxAutor
            // 
            this.textBoxAutor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxAutor.Enabled = false;
            this.textBoxAutor.Location = new System.Drawing.Point(144, 100);
            this.textBoxAutor.Name = "textBoxAutor";
            this.textBoxAutor.ReadOnly = true;
            this.textBoxAutor.Size = new System.Drawing.Size(300, 20);
            this.textBoxAutor.TabIndex = 30;
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxTitulo.Enabled = false;
            this.textBoxTitulo.Location = new System.Drawing.Point(144, 74);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.ReadOnly = true;
            this.textBoxTitulo.Size = new System.Drawing.Size(300, 20);
            this.textBoxTitulo.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Autor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Titulo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Año publicacion";
            // 
            // dgvLibros
            // 
            this.dgvLibros.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvLibros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLibros.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvLibros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Titulo,
            this.Autor,
            this.AñoPublicacion,
            this.ISBN});
            this.dgvLibros.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvLibros.Location = new System.Drawing.Point(1, 188);
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvLibros.Size = new System.Drawing.Size(841, 371);
            this.dgvLibros.TabIndex = 23;
            this.dgvLibros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvLibros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Titulo
            // 
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            this.Titulo.Width = 300;
            // 
            // Autor
            // 
            this.Autor.HeaderText = "Autor";
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            this.Autor.Width = 300;
            // 
            // AñoPublicacion
            // 
            this.AñoPublicacion.HeaderText = "Año Publicacion";
            this.AñoPublicacion.Name = "AñoPublicacion";
            this.AñoPublicacion.ReadOnly = true;
            this.AñoPublicacion.Width = 125;
            // 
            // ISBN
            // 
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            // 
            // textBoxId
            // 
            this.textBoxId.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(144, 48);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(300, 20);
            this.textBoxId.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Id";
            // 
            // VerLibros
            // 
            this.AcceptButton = this.botonVolver;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(844, 600);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.textBoxISBN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.labelNombreUsuario);
            this.Controls.Add(this.textBoxAñoPublicacion);
            this.Controls.Add(this.textBoxAutor);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvLibros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "VerLibros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VerLibros";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VerLibros_FormClosed);
            this.Load += new System.EventHandler(this.VerLibros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Label labelNombreUsuario;
        private System.Windows.Forms.TextBox textBoxAñoPublicacion;
        private System.Windows.Forms.TextBox textBoxAutor;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvLibros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn AñoPublicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label4;
    }
}