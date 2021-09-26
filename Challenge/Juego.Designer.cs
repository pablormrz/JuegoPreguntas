namespace Challenge
{
    partial class Juego
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Juego));
            this.lbCategoria = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbPregunta = new System.Windows.Forms.Label();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnRetiro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(28)))), ((int)(((byte)(138)))));
            this.lbCategoria.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold);
            this.lbCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(255)))), ((int)(((byte)(115)))));
            this.lbCategoria.Location = new System.Drawing.Point(372, 44);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(65, 60);
            this.lbCategoria.TabIndex = 0;
            this.lbCategoria.Text = "# ";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.BackColor = System.Drawing.Color.Transparent;
            this.lbNombre.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(217)))), ((int)(((byte)(201)))));
            this.lbNombre.Location = new System.Drawing.Point(544, 9);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(115, 17);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre Jugador";
            // 
            // lbPregunta
            // 
            this.lbPregunta.AutoSize = true;
            this.lbPregunta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(28)))), ((int)(((byte)(138)))));
            this.lbPregunta.Font = new System.Drawing.Font("Sitka Subheading", 14F, System.Drawing.FontStyle.Bold);
            this.lbPregunta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lbPregunta.Location = new System.Drawing.Point(15, 153);
            this.lbPregunta.Name = "lbPregunta";
            this.lbPregunta.Size = new System.Drawing.Size(620, 28);
            this.lbPregunta.TabIndex = 2;
            this.lbPregunta.Text = "Pregunta############################################";
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(28)))), ((int)(((byte)(138)))));
            this.rb1.Font = new System.Drawing.Font("Sitka Subheading", 10F, System.Drawing.FontStyle.Bold);
            this.rb1.ForeColor = System.Drawing.SystemColors.Control;
            this.rb1.Location = new System.Drawing.Point(45, 196);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(111, 24);
            this.rb1.TabIndex = 3;
            this.rb1.TabStop = true;
            this.rb1.Text = "radioButton1";
            this.rb1.UseVisualStyleBackColor = false;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(28)))), ((int)(((byte)(138)))));
            this.rb2.Font = new System.Drawing.Font("Sitka Subheading", 10F, System.Drawing.FontStyle.Bold);
            this.rb2.ForeColor = System.Drawing.SystemColors.Control;
            this.rb2.Location = new System.Drawing.Point(324, 196);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(113, 24);
            this.rb2.TabIndex = 5;
            this.rb2.TabStop = true;
            this.rb2.Text = "radioButton3";
            this.rb2.UseVisualStyleBackColor = false;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(28)))), ((int)(((byte)(138)))));
            this.rb3.Font = new System.Drawing.Font("Sitka Subheading", 10F, System.Drawing.FontStyle.Bold);
            this.rb3.ForeColor = System.Drawing.SystemColors.Control;
            this.rb3.Location = new System.Drawing.Point(45, 255);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(113, 24);
            this.rb3.TabIndex = 6;
            this.rb3.TabStop = true;
            this.rb3.Text = "radioButton4";
            this.rb3.UseVisualStyleBackColor = false;
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(28)))), ((int)(((byte)(138)))));
            this.rb4.Font = new System.Drawing.Font("Sitka Subheading", 10F, System.Drawing.FontStyle.Bold);
            this.rb4.ForeColor = System.Drawing.SystemColors.Control;
            this.rb4.Location = new System.Drawing.Point(324, 255);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(113, 24);
            this.rb4.TabIndex = 7;
            this.rb4.TabStop = true;
            this.rb4.Text = "radioButton5";
            this.rb4.UseVisualStyleBackColor = false;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(28)))), ((int)(((byte)(138)))));
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.btnSiguiente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(99)))), ((int)(((byte)(230)))));
            this.btnSiguiente.Location = new System.Drawing.Point(283, 309);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(140, 40);
            this.btnSiguiente.TabIndex = 8;
            this.btnSiguiente.Text = "SIGUIENTE";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnRetiro
            // 
            this.btnRetiro.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnRetiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetiro.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.btnRetiro.ForeColor = System.Drawing.Color.Red;
            this.btnRetiro.Location = new System.Drawing.Point(547, 44);
            this.btnRetiro.Name = "btnRetiro";
            this.btnRetiro.Size = new System.Drawing.Size(125, 40);
            this.btnRetiro.TabIndex = 9;
            this.btnRetiro.Text = "RETIRARME";
            this.btnRetiro.UseVisualStyleBackColor = false;
            this.btnRetiro.Click += new System.EventHandler(this.btnRetiro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(28)))), ((int)(((byte)(138)))));
            this.label1.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(255)))), ((int)(((byte)(115)))));
            this.label1.Location = new System.Drawing.Point(223, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 60);
            this.label1.TabIndex = 10;
            this.label1.Text = "NIVEL: ";
            // 
            // Juego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRetiro);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.rb4);
            this.Controls.Add(this.rb3);
            this.Controls.Add(this.rb2);
            this.Controls.Add(this.rb1);
            this.Controls.Add(this.lbPregunta);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbCategoria);
            this.Name = "Juego";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbPregunta;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnRetiro;
        private System.Windows.Forms.Label label1;
    }
}