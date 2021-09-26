namespace Challenge
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnCofiguracion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(28)))), ((int)(((byte)(138)))));
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(99)))), ((int)(((byte)(230)))));
            this.btnIniciar.Location = new System.Drawing.Point(200, 133);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(195, 40);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "INICIAR EL JUEGO";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnCofiguracion
            // 
            this.btnCofiguracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(28)))), ((int)(((byte)(138)))));
            this.btnCofiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCofiguracion.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCofiguracion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(99)))), ((int)(((byte)(230)))));
            this.btnCofiguracion.Location = new System.Drawing.Point(200, 192);
            this.btnCofiguracion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCofiguracion.Name = "btnCofiguracion";
            this.btnCofiguracion.Size = new System.Drawing.Size(195, 40);
            this.btnCofiguracion.TabIndex = 1;
            this.btnCofiguracion.Text = "CONFIGURACIÓN";
            this.btnCofiguracion.UseVisualStyleBackColor = false;
            this.btnCofiguracion.Click += new System.EventHandler(this.btnCofiguracion_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 360);
            this.Controls.Add(this.btnCofiguracion);
            this.Controls.Add(this.btnIniciar);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Inicio";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnCofiguracion;
    }
}

