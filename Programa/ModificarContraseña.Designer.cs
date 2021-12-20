
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
            this.buttonGuardar = new System.Windows.Forms.Button();
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
            this.textBoxContraseñaNueva.TextChanged += new System.EventHandler(this.textBoxContraseñaNueva_TextChanged);
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(404, 257);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(75, 23);
            this.buttonVolver.TabIndex = 4;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(485, 257);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 5;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.button2_Click);
            // 
            // ModificarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 292);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.textBoxContraseñaNueva);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxContraseñaAntigua);
            this.Controls.Add(this.label1);
            this.Name = "ModificarContraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarContraseña";
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
        private System.Windows.Forms.Button buttonGuardar;
    }
}