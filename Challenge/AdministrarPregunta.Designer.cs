namespace Challenge
{
    partial class AdministrarPregunta
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
            this.txtPregunta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gvOpcionesRespuesta = new System.Windows.Forms.DataGridView();
            this.OpcionRespuesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpcionCorrecta = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvOpcionesRespuesta)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPregunta
            // 
            this.txtPregunta.Location = new System.Drawing.Point(37, 72);
            this.txtPregunta.Name = "txtPregunta";
            this.txtPregunta.Size = new System.Drawing.Size(430, 20);
            this.txtPregunta.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "INGRESE PREGUNTA";
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(535, 71);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(149, 21);
            this.cbCategoria.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(532, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "SELECCIONA CATEGORÍA";
            // 
            // gvOpcionesRespuesta
            // 
            this.gvOpcionesRespuesta.AllowUserToAddRows = false;
            this.gvOpcionesRespuesta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvOpcionesRespuesta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OpcionRespuesta,
            this.OpcionCorrecta});
            this.gvOpcionesRespuesta.Location = new System.Drawing.Point(37, 134);
            this.gvOpcionesRespuesta.Name = "gvOpcionesRespuesta";
            this.gvOpcionesRespuesta.Size = new System.Drawing.Size(701, 205);
            this.gvOpcionesRespuesta.TabIndex = 16;
            // 
            // OpcionRespuesta
            // 
            this.OpcionRespuesta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OpcionRespuesta.HeaderText = "Opcion respuesta";
            this.OpcionRespuesta.Name = "OpcionRespuesta";
            // 
            // OpcionCorrecta
            // 
            this.OpcionCorrecta.HeaderText = "Opciòn correcta";
            this.OpcionCorrecta.Name = "OpcionCorrecta";
            this.OpcionCorrecta.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.OpcionCorrecta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(663, 375);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(582, 375);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // AdministrarPregunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gvOpcionesRespuesta);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPregunta);
            this.Controls.Add(this.label2);
            this.Name = "AdministrarPregunta";
            this.Text = "AdministrarPregunta";
            ((System.ComponentModel.ISupportInitialize)(this.gvOpcionesRespuesta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPregunta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView gvOpcionesRespuesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpcionRespuesta;
        private System.Windows.Forms.DataGridViewCheckBoxColumn OpcionCorrecta;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
    }
}