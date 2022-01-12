
namespace Programa
{
    partial class ModificarContraseña
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxContraseñaAntigua = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxContraseñaNueva = new System.Windows.Forms.TextBox();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.labelErro = new System.Windows.Forms.Label();
            this.buttonMostrarContraseñaVieja = new System.Windows.Forms.Button();
            this.buttonMostrarContraseñaNueva = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese contraseña antigua:";
            // 
            // textBoxContraseñaAntigua
            // 
            this.textBoxContraseñaAntigua.Location = new System.Drawing.Point(175, 94);
            this.textBoxContraseñaAntigua.Name = "textBoxContraseñaAntigua";
            this.textBoxContraseñaAntigua.Size = new System.Drawing.Size(247, 20);
            this.textBoxContraseñaAntigua.TabIndex = 1;
            this.textBoxContraseñaAntigua.UseSystemPasswordChar = true;
            this.textBoxContraseñaAntigua.TextChanged += new System.EventHandler(this.textBoxContraseñaAntigua_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese contraseña nueva:";
            // 
            // textBoxContraseñaNueva
            // 
            this.textBoxContraseñaNueva.Location = new System.Drawing.Point(175, 132);
            this.textBoxContraseñaNueva.Name = "textBoxContraseñaNueva";
            this.textBoxContraseñaNueva.Size = new System.Drawing.Size(247, 20);
            this.textBoxContraseñaNueva.TabIndex = 3;
            this.textBoxContraseñaNueva.UseSystemPasswordChar = true;
            this.textBoxContraseñaNueva.TextChanged += new System.EventHandler(this.textBoxContraseñaNueva_TextChanged);
            // 
            // buttonVolver
            // 
            this.buttonVolver.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonVolver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonVolver.Location = new System.Drawing.Point(404, 257);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(75, 23);
            this.buttonVolver.TabIndex = 4;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = false;
            this.buttonVolver.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonAceptar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAceptar.Location = new System.Drawing.Point(485, 257);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 5;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = false;
            this.buttonAceptar.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelErro
            // 
            this.labelErro.AutoSize = true;
            this.labelErro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelErro.Location = new System.Drawing.Point(172, 196);
            this.labelErro.Name = "labelErro";
            this.labelErro.Size = new System.Drawing.Size(0, 13);
            this.labelErro.TabIndex = 6;
            // 
            // buttonMostrarContraseñaVieja
            // 
            this.buttonMostrarContraseñaVieja.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonMostrarContraseñaVieja.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonMostrarContraseñaVieja.Location = new System.Drawing.Point(439, 92);
            this.buttonMostrarContraseñaVieja.Name = "buttonMostrarContraseñaVieja";
            this.buttonMostrarContraseñaVieja.Size = new System.Drawing.Size(75, 23);
            this.buttonMostrarContraseñaVieja.TabIndex = 7;
            this.buttonMostrarContraseñaVieja.Text = "Mostrar";
            this.buttonMostrarContraseñaVieja.UseVisualStyleBackColor = false;
            this.buttonMostrarContraseñaVieja.Click += new System.EventHandler(this.buttonMostrarContraseñaVieja_Click);
            // 
            // buttonMostrarContraseñaNueva
            // 
            this.buttonMostrarContraseñaNueva.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonMostrarContraseñaNueva.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonMostrarContraseñaNueva.Location = new System.Drawing.Point(439, 129);
            this.buttonMostrarContraseñaNueva.Name = "buttonMostrarContraseñaNueva";
            this.buttonMostrarContraseñaNueva.Size = new System.Drawing.Size(75, 23);
            this.buttonMostrarContraseñaNueva.TabIndex = 8;
            this.buttonMostrarContraseñaNueva.Text = "Mostrar";
            this.buttonMostrarContraseñaNueva.UseVisualStyleBackColor = false;
            this.buttonMostrarContraseñaNueva.Click += new System.EventHandler(this.buttonMostrarContraseñaNueva_Click);
            // 
            // ModificarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(604, 291);
            this.Controls.Add(this.buttonMostrarContraseñaNueva);
            this.Controls.Add(this.buttonMostrarContraseñaVieja);
            this.Controls.Add(this.labelErro);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.textBoxContraseñaNueva);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxContraseñaAntigua);
            this.Controls.Add(this.label1);
            this.Name = "ModificarContraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Contraseña";
            this.Load += new System.EventHandler(this.ModificarContraseña_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxContraseñaAntigua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxContraseñaNueva;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Label labelErro;
        private System.Windows.Forms.Button buttonMostrarContraseñaVieja;
        private System.Windows.Forms.Button buttonMostrarContraseñaNueva;
    }
}