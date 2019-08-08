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
            this.panelGenerico = new System.Windows.Forms.Panel();
            this.labelSystema = new System.Windows.Forms.Label();
            this.pictureBoxLogoSystema = new System.Windows.Forms.PictureBox();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonTareas = new System.Windows.Forms.Button();
            this.buttonHorarios = new System.Windows.Forms.Button();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelHora = new System.Windows.Forms.Label();
            this.buttonHoy = new System.Windows.Forms.Button();
            this.buttonMatriz = new System.Windows.Forms.Button();
            this.pictureBoxLogoEmpresa = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonCerrarSesion = new System.Windows.Forms.Button();
            this.labelAprender = new System.Windows.Forms.Label();
            this.labelPracticar = new System.Windows.Forms.Label();
            this.labelAplicar = new System.Windows.Forms.Label();
            this.labelMagia = new System.Windows.Forms.Label();
            this.labelAyudar = new System.Windows.Forms.Label();
            this.labelSuNombre = new System.Windows.Forms.Label();
            this.panelGenerico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoSystema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGenerico
            // 
            this.panelGenerico.Controls.Add(this.labelSuNombre);
            this.panelGenerico.Controls.Add(this.labelAyudar);
            this.panelGenerico.Controls.Add(this.labelMagia);
            this.panelGenerico.Controls.Add(this.labelAplicar);
            this.panelGenerico.Controls.Add(this.labelPracticar);
            this.panelGenerico.Controls.Add(this.labelAprender);
            this.panelGenerico.Controls.Add(this.labelSystema);
            this.panelGenerico.Controls.Add(this.pictureBoxLogoSystema);
            this.panelGenerico.Location = new System.Drawing.Point(180, 5);
            this.panelGenerico.Name = "panelGenerico";
            this.panelGenerico.Size = new System.Drawing.Size(802, 440);
            this.panelGenerico.TabIndex = 1;
            // 
            // labelSystema
            // 
            this.labelSystema.AutoSize = true;
            this.labelSystema.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelSystema.Font = new System.Drawing.Font("Gabriola", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSystema.Location = new System.Drawing.Point(193, 311);
            this.labelSystema.Name = "labelSystema";
            this.labelSystema.Size = new System.Drawing.Size(161, 74);
            this.labelSystema.TabIndex = 1;
            this.labelSystema.Text = "ParettoKin";
            // 
            // pictureBoxLogoSystema
            // 
            this.pictureBoxLogoSystema.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBoxLogoSystema.BackgroundImage = global::ParetoKin.Properties.Resources.LaGranFuerza1;
            this.pictureBoxLogoSystema.Location = new System.Drawing.Point(156, 73);
            this.pictureBoxLogoSystema.Name = "pictureBoxLogoSystema";
            this.pictureBoxLogoSystema.Size = new System.Drawing.Size(234, 226);
            this.pictureBoxLogoSystema.TabIndex = 0;
            this.pictureBoxLogoSystema.TabStop = false;
            // 
            // buttonSalir
            // 
            this.buttonSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.Location = new System.Drawing.Point(107, 386);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(62, 59);
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
            // pictureBoxLogoEmpresa
            // 
            this.pictureBoxLogoEmpresa.Image = global::ParetoKin.Properties.Resources.elCaminoDelDragon;
            this.pictureBoxLogoEmpresa.Location = new System.Drawing.Point(22, 12);
            this.pictureBoxLogoEmpresa.Name = "pictureBoxLogoEmpresa";
            this.pictureBoxLogoEmpresa.Size = new System.Drawing.Size(113, 91);
            this.pictureBoxLogoEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogoEmpresa.TabIndex = 9;
            this.pictureBoxLogoEmpresa.TabStop = false;
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
            // buttonCerrarSesion
            // 
            this.buttonCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCerrarSesion.Location = new System.Drawing.Point(12, 386);
            this.buttonCerrarSesion.Name = "buttonCerrarSesion";
            this.buttonCerrarSesion.Size = new System.Drawing.Size(81, 61);
            this.buttonCerrarSesion.TabIndex = 10;
            this.buttonCerrarSesion.Text = "Cerrar Sesión";
            this.buttonCerrarSesion.UseVisualStyleBackColor = true;
            this.buttonCerrarSesion.Click += new System.EventHandler(this.ButtonCerrarSesion_Click);
            // 
            // labelAprender
            // 
            this.labelAprender.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelAprender.Font = new System.Drawing.Font("Gabriola", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAprender.Location = new System.Drawing.Point(470, 73);
            this.labelAprender.Name = "labelAprender";
            this.labelAprender.Size = new System.Drawing.Size(204, 74);
            this.labelAprender.TabIndex = 2;
            this.labelAprender.Text = "Aprender";
            this.labelAprender.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelPracticar
            // 
            this.labelPracticar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPracticar.Font = new System.Drawing.Font("Gabriola", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPracticar.Location = new System.Drawing.Point(470, 171);
            this.labelPracticar.Name = "labelPracticar";
            this.labelPracticar.Size = new System.Drawing.Size(204, 74);
            this.labelPracticar.TabIndex = 3;
            this.labelPracticar.Text = "Practicar";
            this.labelPracticar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelAplicar
            // 
            this.labelAplicar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelAplicar.Font = new System.Drawing.Font("Gabriola", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAplicar.Location = new System.Drawing.Point(470, 268);
            this.labelAplicar.Name = "labelAplicar";
            this.labelAplicar.Size = new System.Drawing.Size(204, 74);
            this.labelAplicar.TabIndex = 4;
            this.labelAplicar.Text = "Aplicar";
            this.labelAplicar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelMagia
            // 
            this.labelMagia.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelMagia.Font = new System.Drawing.Font("Gabriola", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMagia.Location = new System.Drawing.Point(230, 118);
            this.labelMagia.Name = "labelMagia";
            this.labelMagia.Size = new System.Drawing.Size(91, 50);
            this.labelMagia.TabIndex = 5;
            this.labelMagia.Text = "Magia";
            this.labelMagia.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelAyudar
            // 
            this.labelAyudar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelAyudar.Font = new System.Drawing.Font("Gabriola", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAyudar.Location = new System.Drawing.Point(166, 228);
            this.labelAyudar.Name = "labelAyudar";
            this.labelAyudar.Size = new System.Drawing.Size(91, 50);
            this.labelAyudar.TabIndex = 6;
            this.labelAyudar.Text = "Ayudar";
            this.labelAyudar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelSuNombre
            // 
            this.labelSuNombre.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelSuNombre.Font = new System.Drawing.Font("Gabriola", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSuNombre.Location = new System.Drawing.Point(275, 228);
            this.labelSuNombre.Name = "labelSuNombre";
            this.labelSuNombre.Size = new System.Drawing.Size(115, 50);
            this.labelSuNombre.TabIndex = 7;
            this.labelSuNombre.Text = "Su nombre";
            this.labelSuNombre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // VistaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(989, 452);
            this.Controls.Add(this.buttonCerrarSesion);
            this.Controls.Add(this.pictureBoxLogoEmpresa);
            this.Controls.Add(this.buttonMatriz);
            this.Controls.Add(this.buttonHoy);
            this.Controls.Add(this.labelHora);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.buttonHorarios);
            this.Controls.Add(this.buttonTareas);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.panelGenerico);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimumSize = new System.Drawing.Size(1005, 491);
            this.Name = "VistaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema ParetoKin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.cierreSeguro);
            this.panelGenerico.ResumeLayout(false);
            this.panelGenerico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoSystema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoEmpresa)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBoxLogoEmpresa;
        public System.Windows.Forms.PictureBox pictureBoxLogoSystema;
        public System.Windows.Forms.Label labelSystema;
        private System.Windows.Forms.Button buttonCerrarSesion;
        public System.Windows.Forms.Label labelAplicar;
        public System.Windows.Forms.Label labelPracticar;
        public System.Windows.Forms.Label labelAprender;
        public System.Windows.Forms.Label labelSuNombre;
        public System.Windows.Forms.Label labelAyudar;
        public System.Windows.Forms.Label labelMagia;
    }
}

