namespace ParetoKin.vista.modulohorarios
{
    partial class HorariosMain
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
            this.dataGridViewHorario = new System.Windows.Forms.DataGridView();
            this.horaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minutos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lunes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.martes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miercoles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jueves = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viernes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sabado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domingo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonGuardarCambios = new System.Windows.Forms.Button();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownHora = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMinutos = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAjustar = new System.Windows.Forms.Button();
            this.tabControlPestanas = new System.Windows.Forms.TabControl();
            this.tabPageHorarioGeneral = new System.Windows.Forms.TabPage();
            this.tabPageHorarioVacacion = new System.Windows.Forms.TabPage();
            this.dataGridViewHorarioVacacion = new System.Windows.Forms.DataGridView();
            this.inicioVacacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finVacacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoVacacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actividadVacacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVacacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHorario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutos)).BeginInit();
            this.tabControlPestanas.SuspendLayout();
            this.tabPageHorarioGeneral.SuspendLayout();
            this.tabPageHorarioVacacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHorarioVacacion)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewHorario
            // 
            this.dataGridViewHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHorario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.horaInicio,
            this.horaFin,
            this.minutos,
            this.lunes,
            this.martes,
            this.miercoles,
            this.jueves,
            this.viernes,
            this.sabado,
            this.domingo,
            this.id});
            this.dataGridViewHorario.Location = new System.Drawing.Point(3, 0);
            this.dataGridViewHorario.Name = "dataGridViewHorario";
            this.dataGridViewHorario.Size = new System.Drawing.Size(726, 287);
            this.dataGridViewHorario.TabIndex = 0;
            this.dataGridViewHorario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.celdaClick);
            this.dataGridViewHorario.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.celdaEditada);
            this.dataGridViewHorario.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.filaAgregada);
            this.dataGridViewHorario.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.filaEliminada);
            // 
            // horaInicio
            // 
            this.horaInicio.HeaderText = "Inicio";
            this.horaInicio.Name = "horaInicio";
            this.horaInicio.ReadOnly = true;
            this.horaInicio.Width = 50;
            // 
            // horaFin
            // 
            this.horaFin.HeaderText = "Fin";
            this.horaFin.Name = "horaFin";
            this.horaFin.ReadOnly = true;
            this.horaFin.Width = 50;
            // 
            // minutos
            // 
            this.minutos.HeaderText = "Tiempo (minutos)";
            this.minutos.Name = "minutos";
            this.minutos.Width = 57;
            // 
            // lunes
            // 
            this.lunes.HeaderText = "Lunes";
            this.lunes.Name = "lunes";
            this.lunes.Width = 75;
            // 
            // martes
            // 
            this.martes.HeaderText = "Martes";
            this.martes.Name = "martes";
            this.martes.Width = 75;
            // 
            // miercoles
            // 
            this.miercoles.HeaderText = "Miércoles";
            this.miercoles.Name = "miercoles";
            this.miercoles.Width = 75;
            // 
            // jueves
            // 
            this.jueves.HeaderText = "Jueves";
            this.jueves.Name = "jueves";
            this.jueves.Width = 75;
            // 
            // viernes
            // 
            this.viernes.HeaderText = "Viernes";
            this.viernes.Name = "viernes";
            this.viernes.Width = 75;
            // 
            // sabado
            // 
            this.sabado.HeaderText = "Sábado";
            this.sabado.Name = "sabado";
            this.sabado.Width = 75;
            // 
            // domingo
            // 
            this.domingo.HeaderText = "Domingo";
            this.domingo.Name = "domingo";
            this.domingo.Width = 75;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 5;
            // 
            // buttonGuardarCambios
            // 
            this.buttonGuardarCambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardarCambios.Location = new System.Drawing.Point(206, 354);
            this.buttonGuardarCambios.Name = "buttonGuardarCambios";
            this.buttonGuardarCambios.Size = new System.Drawing.Size(177, 43);
            this.buttonGuardarCambios.TabIndex = 10;
            this.buttonGuardarCambios.Text = "Guardar cambios";
            this.buttonGuardarCambios.UseVisualStyleBackColor = true;
            this.buttonGuardarCambios.Click += new System.EventHandler(this.ButtonGuardarCambios_Click);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCerrar.Location = new System.Drawing.Point(432, 354);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(117, 43);
            this.buttonCerrar.TabIndex = 9;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.ButtonCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Hora de inicio";
            // 
            // numericUpDownHora
            // 
            this.numericUpDownHora.Location = new System.Drawing.Point(379, 7);
            this.numericUpDownHora.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDownHora.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownHora.Name = "numericUpDownHora";
            this.numericUpDownHora.Size = new System.Drawing.Size(31, 20);
            this.numericUpDownHora.TabIndex = 12;
            this.numericUpDownHora.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownMinutos
            // 
            this.numericUpDownMinutos.Location = new System.Drawing.Point(432, 7);
            this.numericUpDownMinutos.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownMinutos.Name = "numericUpDownMinutos";
            this.numericUpDownMinutos.Size = new System.Drawing.Size(31, 20);
            this.numericUpDownMinutos.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = ":";
            // 
            // buttonAjustar
            // 
            this.buttonAjustar.Location = new System.Drawing.Point(481, 4);
            this.buttonAjustar.Name = "buttonAjustar";
            this.buttonAjustar.Size = new System.Drawing.Size(113, 23);
            this.buttonAjustar.TabIndex = 15;
            this.buttonAjustar.Text = "Ajustar Horas";
            this.buttonAjustar.UseVisualStyleBackColor = true;
            this.buttonAjustar.Click += new System.EventHandler(this.ButtonAjustar_Click);
            // 
            // tabControlPestanas
            // 
            this.tabControlPestanas.Controls.Add(this.tabPageHorarioGeneral);
            this.tabControlPestanas.Controls.Add(this.tabPageHorarioVacacion);
            this.tabControlPestanas.Location = new System.Drawing.Point(12, 33);
            this.tabControlPestanas.Name = "tabControlPestanas";
            this.tabControlPestanas.SelectedIndex = 0;
            this.tabControlPestanas.Size = new System.Drawing.Size(739, 321);
            this.tabControlPestanas.TabIndex = 16;
            // 
            // tabPageHorarioGeneral
            // 
            this.tabPageHorarioGeneral.Controls.Add(this.dataGridViewHorario);
            this.tabPageHorarioGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabPageHorarioGeneral.Name = "tabPageHorarioGeneral";
            this.tabPageHorarioGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHorarioGeneral.Size = new System.Drawing.Size(731, 295);
            this.tabPageHorarioGeneral.TabIndex = 0;
            this.tabPageHorarioGeneral.Text = "Horario normal";
            this.tabPageHorarioGeneral.UseVisualStyleBackColor = true;
            // 
            // tabPageHorarioVacacion
            // 
            this.tabPageHorarioVacacion.Controls.Add(this.dataGridViewHorarioVacacion);
            this.tabPageHorarioVacacion.Location = new System.Drawing.Point(4, 22);
            this.tabPageHorarioVacacion.Name = "tabPageHorarioVacacion";
            this.tabPageHorarioVacacion.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHorarioVacacion.Size = new System.Drawing.Size(731, 295);
            this.tabPageHorarioVacacion.TabIndex = 1;
            this.tabPageHorarioVacacion.Text = "Horario vacación";
            this.tabPageHorarioVacacion.UseVisualStyleBackColor = true;
            // 
            // dataGridViewHorarioVacacion
            // 
            this.dataGridViewHorarioVacacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHorarioVacacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inicioVacacion,
            this.finVacacion,
            this.tiempoVacacion,
            this.actividadVacacion,
            this.idVacacion});
            this.dataGridViewHorarioVacacion.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewHorarioVacacion.Name = "dataGridViewHorarioVacacion";
            this.dataGridViewHorarioVacacion.Size = new System.Drawing.Size(728, 287);
            this.dataGridViewHorarioVacacion.TabIndex = 17;
            this.dataGridViewHorarioVacacion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.celdaClickVacacion);
            this.dataGridViewHorarioVacacion.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.celdaEditadaVacacion);
            this.dataGridViewHorarioVacacion.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.filaAgregadaVacacion);
            this.dataGridViewHorarioVacacion.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.filaEliminadaVacacion);
            // 
            // inicioVacacion
            // 
            this.inicioVacacion.HeaderText = "Inicio";
            this.inicioVacacion.Name = "inicioVacacion";
            this.inicioVacacion.ReadOnly = true;
            this.inicioVacacion.Width = 50;
            // 
            // finVacacion
            // 
            this.finVacacion.HeaderText = "Fin";
            this.finVacacion.Name = "finVacacion";
            this.finVacacion.ReadOnly = true;
            this.finVacacion.Width = 50;
            // 
            // tiempoVacacion
            // 
            this.tiempoVacacion.HeaderText = "Tiempo (minutos)";
            this.tiempoVacacion.Name = "tiempoVacacion";
            this.tiempoVacacion.Width = 57;
            // 
            // actividadVacacion
            // 
            this.actividadVacacion.HeaderText = "Actividad del día";
            this.actividadVacacion.Name = "actividadVacacion";
            this.actividadVacacion.Width = 525;
            // 
            // idVacacion
            // 
            this.idVacacion.HeaderText = "id";
            this.idVacacion.Name = "idVacacion";
            this.idVacacion.ReadOnly = true;
            this.idVacacion.Visible = false;
            this.idVacacion.Width = 5;
            // 
            // HorariosMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 401);
            this.Controls.Add(this.tabControlPestanas);
            this.Controls.Add(this.buttonAjustar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownMinutos);
            this.Controls.Add(this.numericUpDownHora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGuardarCambios);
            this.Controls.Add(this.buttonCerrar);
            this.Name = "HorariosMain";
            this.Text = "HorariosMain";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHorario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutos)).EndInit();
            this.tabControlPestanas.ResumeLayout(false);
            this.tabPageHorarioGeneral.ResumeLayout(false);
            this.tabPageHorarioVacacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHorarioVacacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewHorario;
        private System.Windows.Forms.Button buttonGuardarCambios;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn minutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn lunes;
        private System.Windows.Forms.DataGridViewTextBoxColumn martes;
        private System.Windows.Forms.DataGridViewTextBoxColumn miercoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn jueves;
        private System.Windows.Forms.DataGridViewTextBoxColumn viernes;
        private System.Windows.Forms.DataGridViewTextBoxColumn sabado;
        private System.Windows.Forms.DataGridViewTextBoxColumn domingo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownHora;
        private System.Windows.Forms.NumericUpDown numericUpDownMinutos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAjustar;
        private System.Windows.Forms.TabControl tabControlPestanas;
        private System.Windows.Forms.TabPage tabPageHorarioGeneral;
        private System.Windows.Forms.TabPage tabPageHorarioVacacion;
        private System.Windows.Forms.DataGridView dataGridViewHorarioVacacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn inicioVacacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn finVacacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoVacacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn actividadVacacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVacacion;
    }
}