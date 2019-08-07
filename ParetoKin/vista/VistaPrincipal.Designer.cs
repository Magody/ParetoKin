namespace ParetoKin
{
    partial class VistaPrincipal
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelGenerico = new System.Windows.Forms.Panel();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonTareas = new System.Windows.Forms.Button();
            this.buttonHorarios = new System.Windows.Forms.Button();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelHora = new System.Windows.Forms.Label();
            this.buttonHoy = new System.Windows.Forms.Button();
            this.buttonMatriz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 451);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelGenerico
            // 
            this.panelGenerico.Location = new System.Drawing.Point(180, 5);
            this.panelGenerico.Name = "panelGenerico";
            this.panelGenerico.Size = new System.Drawing.Size(802, 440);
            this.panelGenerico.TabIndex = 1;
            // 
            // buttonSalir
            // 
            this.buttonSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.Location = new System.Drawing.Point(33, 391);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(102, 49);
            this.buttonSalir.TabIndex = 2;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.ButtonSalir_Click);
            // 
            // buttonTareas
            // 
            this.buttonTareas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTareas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonTareas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonTareas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTareas.Location = new System.Drawing.Point(0, 233);
            this.buttonTareas.Name = "buttonTareas";
            this.buttonTareas.Size = new System.Drawing.Size(174, 34);
            this.buttonTareas.TabIndex = 3;
            this.buttonTareas.Text = "Tareas";
            this.buttonTareas.UseVisualStyleBackColor = true;
            this.buttonTareas.Click += new System.EventHandler(this.ButtonTareas_Click);
            // 
            // buttonHorarios
            // 
            this.buttonHorarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHorarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonHorarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonHorarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHorarios.Location = new System.Drawing.Point(0, 273);
            this.buttonHorarios.Name = "buttonHorarios";
            this.buttonHorarios.Size = new System.Drawing.Size(174, 31);
            this.buttonHorarios.TabIndex = 4;
            this.buttonHorarios.Text = "Horarios";
            this.buttonHorarios.UseVisualStyleBackColor = true;
            this.buttonHorarios.Click += new System.EventHandler(this.ButtonHorarios_Click);
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelFecha.Location = new System.Drawing.Point(12, 365);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(157, 13);
            this.labelFecha.TabIndex = 5;
            this.labelFecha.Text = "XX de YYYYYYYYYY del ZZZZ";
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.Location = new System.Drawing.Point(12, 316);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(149, 39);
            this.labelHora.TabIndex = 6;
            this.labelHora.Text = "88:88:88";
            // 
            // buttonHoy
            // 
            this.buttonHoy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHoy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonHoy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonHoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHoy.Location = new System.Drawing.Point(0, 123);
            this.buttonHoy.Name = "buttonHoy";
            this.buttonHoy.Size = new System.Drawing.Size(174, 38);
            this.buttonHoy.TabIndex = 7;
            this.buttonHoy.Text = "Hoy";
            this.buttonHoy.UseVisualStyleBackColor = true;
            this.buttonHoy.Click += new System.EventHandler(this.ButtonHoy_Click);
            // 
            // buttonMatriz
            // 
            this.buttonMatriz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMatriz.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonMatriz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonMatriz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMatriz.Location = new System.Drawing.Point(0, 167);
            this.buttonMatriz.Name = "buttonMatriz";
            this.buttonMatriz.Size = new System.Drawing.Size(174, 60);
            this.buttonMatriz.TabIndex = 8;
            this.buttonMatriz.Text = "Matriz de prioridades";
            this.buttonMatriz.UseVisualStyleBackColor = true;
            this.buttonMatriz.Click += new System.EventHandler(this.ButtonMatriz_Click);
            // 
            // VistaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(989, 452);
            this.Controls.Add(this.buttonMatriz);
            this.Controls.Add(this.buttonHoy);
            this.Controls.Add(this.labelHora);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.buttonHorarios);
            this.Controls.Add(this.buttonTareas);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.panelGenerico);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(1005, 491);
            this.Name = "VistaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema ParetoKin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.cierreSeguro);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button buttonTareas;
        public System.Windows.Forms.Panel panelGenerico;
        private System.Windows.Forms.Button buttonHorarios;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Button buttonHoy;
        private System.Windows.Forms.Button buttonMatriz;
    }
}

