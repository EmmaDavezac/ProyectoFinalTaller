
namespace Programa
{
    partial class EditarPrestamo
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
            this.buttonModificarFechas = new System.Windows.Forms.Button();
            this.labelFechaPrestamo = new System.Windows.Forms.Label();
            this.textBoxFechaPrestamo = new System.Windows.Forms.TextBox();
            this.labelFechaLimite = new System.Windows.Forms.Label();
            this.textBoxFechaLimite = new System.Windows.Forms.TextBox();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonModificarFechas
            // 
            this.buttonModificarFechas.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonModificarFechas.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonModificarFechas.FlatAppearance.BorderSize = 0;
            this.buttonModificarFechas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModificarFechas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonModificarFechas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonModificarFechas.Location = new System.Drawing.Point(125, 138);
            this.buttonModificarFechas.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonModificarFechas.Name = "buttonModificarFechas";
            this.buttonModificarFechas.Size = new System.Drawing.Size(142, 23);
            this.buttonModificarFechas.TabIndex = 58;
            this.buttonModificarFechas.Text = "Modificar Fechas";
            this.buttonModificarFechas.UseVisualStyleBackColor = false;
            this.buttonModificarFechas.Click += new System.EventHandler(this.buttonModificarFechas_Click);
            // 
            // labelFechaPrestamo
            // 
            this.labelFechaPrestamo.AutoSize = true;
            this.labelFechaPrestamo.Location = new System.Drawing.Point(58, 48);
            this.labelFechaPrestamo.Name = "labelFechaPrestamo";
            this.labelFechaPrestamo.Size = new System.Drawing.Size(84, 13);
            this.labelFechaPrestamo.TabIndex = 63;
            this.labelFechaPrestamo.Text = "FechaPrestamo:";
            // 
            // textBoxFechaPrestamo
            // 
            this.textBoxFechaPrestamo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxFechaPrestamo.Location = new System.Drawing.Point(145, 45);
            this.textBoxFechaPrestamo.Name = "textBoxFechaPrestamo";
            this.textBoxFechaPrestamo.Size = new System.Drawing.Size(177, 20);
            this.textBoxFechaPrestamo.TabIndex = 62;
            // 
            // labelFechaLimite
            // 
            this.labelFechaLimite.AutoSize = true;
            this.labelFechaLimite.Location = new System.Drawing.Point(58, 84);
            this.labelFechaLimite.Name = "labelFechaLimite";
            this.labelFechaLimite.Size = new System.Drawing.Size(67, 13);
            this.labelFechaLimite.TabIndex = 65;
            this.labelFechaLimite.Text = "FechaLimite:";
            // 
            // textBoxFechaLimite
            // 
            this.textBoxFechaLimite.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxFechaLimite.Location = new System.Drawing.Point(145, 81);
            this.textBoxFechaLimite.Name = "textBoxFechaLimite";
            this.textBoxFechaLimite.Size = new System.Drawing.Size(177, 20);
            this.textBoxFechaLimite.TabIndex = 64;
            // 
            // buttonVolver
            // 
            this.buttonVolver.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonVolver.FlatAppearance.BorderSize = 0;
            this.buttonVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVolver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonVolver.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonVolver.Location = new System.Drawing.Point(297, 155);
            this.buttonVolver.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(92, 23);
            this.buttonVolver.TabIndex = 66;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = false;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // EditarPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 190);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.labelFechaLimite);
            this.Controls.Add(this.textBoxFechaLimite);
            this.Controls.Add(this.labelFechaPrestamo);
            this.Controls.Add(this.textBoxFechaPrestamo);
            this.Controls.Add(this.buttonModificarFechas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditarPrestamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarPrestamo";
            this.Load += new System.EventHandler(this.EditarPrestamo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonModificarFechas;
        private System.Windows.Forms.Label labelFechaPrestamo;
        private System.Windows.Forms.TextBox textBoxFechaPrestamo;
        private System.Windows.Forms.Label labelFechaLimite;
        private System.Windows.Forms.TextBox textBoxFechaLimite;
        private System.Windows.Forms.Button buttonVolver;
    }
}