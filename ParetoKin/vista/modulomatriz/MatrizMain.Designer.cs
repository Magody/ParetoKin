namespace ParetoKin.vista.modulomatriz
{
    partial class MatrizMain
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
            this.labelUrgente = new System.Windows.Forms.Label();
            this.labelNoUrgente = new System.Windows.Forms.Label();
            this.labelImportante = new System.Windows.Forms.Label();
            this.labelNoImportante = new System.Windows.Forms.Label();
            this.dataGridViewUrgenteImportante = new System.Windows.Forms.DataGridView();
            this.dataGridViewImportanteNoUrgente = new System.Windows.Forms.DataGridView();
            this.dataGridViewUrgenteNoImportante = new System.Windows.Forms.DataGridView();
            this.tareasNoImportantesSiUrgentes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroTarea3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicio3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewNoUrgenteNoImportante = new System.Windows.Forms.DataGridView();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.nombreTareaUrgenteImportante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroTarea1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicio1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFin1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tareasNoUrgentesSiImportantes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroTarea2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicio2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFin2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tareasNoImportantesNoUrgentes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroTarea4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicio4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFin4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUrgenteImportante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImportanteNoUrgente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUrgenteNoImportante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNoUrgenteNoImportante)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUrgente
            // 
            this.labelUrgente.AutoSize = true;
            this.labelUrgente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUrgente.Location = new System.Drawing.Point(247, 9);
            this.labelUrgente.Name = "labelUrgente";
            this.labelUrgente.Size = new System.Drawing.Size(81, 25);
            this.labelUrgente.TabIndex = 8;
            this.labelUrgente.Text = "Urgente";
            // 
            // labelNoUrgente
            // 
            this.labelNoUrgente.AutoSize = true;
            this.labelNoUrgente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoUrgente.Location = new System.Drawing.Point(543, 9);
            this.labelNoUrgente.Name = "labelNoUrgente";
            this.labelNoUrgente.Size = new System.Drawing.Size(108, 25);
            this.labelNoUrgente.TabIndex = 1;
            this.labelNoUrgente.Text = "No urgente";
            // 
            // labelImportante
            // 
            this.labelImportante.AutoSize = true;
            this.labelImportante.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImportante.Location = new System.Drawing.Point(30, 117);
            this.labelImportante.Name = "labelImportante";
            this.labelImportante.Size = new System.Drawing.Size(104, 25);
            this.labelImportante.TabIndex = 2;
            this.labelImportante.Text = "Importante";
            // 
            // labelNoImportante
            // 
            this.labelNoImportante.AutoSize = true;
            this.labelNoImportante.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoImportante.Location = new System.Drawing.Point(1, 268);
            this.labelNoImportante.Name = "labelNoImportante";
            this.labelNoImportante.Size = new System.Drawing.Size(133, 25);
            this.labelNoImportante.TabIndex = 3;
            this.labelNoImportante.Text = "No importante";
            // 
            // dataGridViewUrgenteImportante
            // 
            this.dataGridViewUrgenteImportante.AllowUserToAddRows = false;
            this.dataGridViewUrgenteImportante.AllowUserToDeleteRows = false;
            this.dataGridViewUrgenteImportante.AllowUserToResizeColumns = false;
            this.dataGridViewUrgenteImportante.AllowUserToResizeRows = false;
            this.dataGridViewUrgenteImportante.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewUrgenteImportante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUrgenteImportante.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreTareaUrgenteImportante,
            this.numeroTarea1,
            this.fechaInicio1,
            this.fechaFin1});
            this.dataGridViewUrgenteImportante.Location = new System.Drawing.Point(165, 51);
            this.dataGridViewUrgenteImportante.Name = "dataGridViewUrgenteImportante";
            this.dataGridViewUrgenteImportante.Size = new System.Drawing.Size(300, 165);
            this.dataGridViewUrgenteImportante.TabIndex = 4;
            this.dataGridViewUrgenteImportante.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.visualizarDetalleIyU);
            // 
            // dataGridViewImportanteNoUrgente
            // 
            this.dataGridViewImportanteNoUrgente.AllowUserToAddRows = false;
            this.dataGridViewImportanteNoUrgente.AllowUserToDeleteRows = false;
            this.dataGridViewImportanteNoUrgente.AllowUserToResizeColumns = false;
            this.dataGridViewImportanteNoUrgente.AllowUserToResizeRows = false;
            this.dataGridViewImportanteNoUrgente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewImportanteNoUrgente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewImportanteNoUrgente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tareasNoUrgentesSiImportantes,
            this.numeroTarea2,
            this.fechaInicio2,
            this.fechaFin2});
            this.dataGridViewImportanteNoUrgente.Location = new System.Drawing.Point(471, 51);
            this.dataGridViewImportanteNoUrgente.Name = "dataGridViewImportanteNoUrgente";
            this.dataGridViewImportanteNoUrgente.Size = new System.Drawing.Size(300, 165);
            this.dataGridViewImportanteNoUrgente.TabIndex = 5;
            this.dataGridViewImportanteNoUrgente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.celdaDobleClicIyNoU);
            // 
            // dataGridViewUrgenteNoImportante
            // 
            this.dataGridViewUrgenteNoImportante.AllowUserToAddRows = false;
            this.dataGridViewUrgenteNoImportante.AllowUserToDeleteRows = false;
            this.dataGridViewUrgenteNoImportante.AllowUserToResizeColumns = false;
            this.dataGridViewUrgenteNoImportante.AllowUserToResizeRows = false;
            this.dataGridViewUrgenteNoImportante.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewUrgenteNoImportante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUrgenteNoImportante.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tareasNoImportantesSiUrgentes,
            this.numeroTarea3,
            this.fechaInicio3});
            this.dataGridViewUrgenteNoImportante.Location = new System.Drawing.Point(165, 223);
            this.dataGridViewUrgenteNoImportante.Name = "dataGridViewUrgenteNoImportante";
            this.dataGridViewUrgenteNoImportante.Size = new System.Drawing.Size(300, 165);
            this.dataGridViewUrgenteNoImportante.TabIndex = 6;
            this.dataGridViewUrgenteNoImportante.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.celdaDobleClicUyNoI);
            // 
            // tareasNoImportantesSiUrgentes
            // 
            this.tareasNoImportantesSiUrgentes.HeaderText = "Tareas urgentes pero no importantes";
            this.tareasNoImportantesSiUrgentes.Name = "tareasNoImportantesSiUrgentes";
            this.tareasNoImportantesSiUrgentes.ReadOnly = true;
            this.tareasNoImportantesSiUrgentes.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tareasNoImportantesSiUrgentes.Width = 257;
            // 
            // numeroTarea3
            // 
            this.numeroTarea3.HeaderText = "numero";
            this.numeroTarea3.Name = "numeroTarea3";
            this.numeroTarea3.ReadOnly = true;
            this.numeroTarea3.Visible = false;
            // 
            // fechaInicio3
            // 
            this.fechaInicio3.HeaderText = "fechaInicio3";
            this.fechaInicio3.Name = "fechaInicio3";
            this.fechaInicio3.ReadOnly = true;
            this.fechaInicio3.Visible = false;
            // 
            // dataGridViewNoUrgenteNoImportante
            // 
            this.dataGridViewNoUrgenteNoImportante.AllowUserToAddRows = false;
            this.dataGridViewNoUrgenteNoImportante.AllowUserToDeleteRows = false;
            this.dataGridViewNoUrgenteNoImportante.AllowUserToResizeColumns = false;
            this.dataGridViewNoUrgenteNoImportante.AllowUserToResizeRows = false;
            this.dataGridViewNoUrgenteNoImportante.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewNoUrgenteNoImportante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNoUrgenteNoImportante.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tareasNoImportantesNoUrgentes,
            this.numeroTarea4,
            this.fechaInicio4,
            this.fechaFin4});
            this.dataGridViewNoUrgenteNoImportante.Location = new System.Drawing.Point(471, 222);
            this.dataGridViewNoUrgenteNoImportante.Name = "dataGridViewNoUrgenteNoImportante";
            this.dataGridViewNoUrgenteNoImportante.Size = new System.Drawing.Size(300, 165);
            this.dataGridViewNoUrgenteNoImportante.TabIndex = 7;
            this.dataGridViewNoUrgenteNoImportante.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.celdaDobleClicNoUyNoI);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Location = new System.Drawing.Point(431, 394);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(75, 23);
            this.buttonCerrar.TabIndex = 1;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.ButtonCerrar_Click);
            // 
            // nombreTareaUrgenteImportante
            // 
            this.nombreTareaUrgenteImportante.HeaderText = "Tareas urgentes e importantes";
            this.nombreTareaUrgenteImportante.Name = "nombreTareaUrgenteImportante";
            this.nombreTareaUrgenteImportante.ReadOnly = true;
            this.nombreTareaUrgenteImportante.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nombreTareaUrgenteImportante.ToolTipText = "Estas tareas...";
            this.nombreTareaUrgenteImportante.Width = 257;
            // 
            // numeroTarea1
            // 
            this.numeroTarea1.HeaderText = "numero";
            this.numeroTarea1.Name = "numeroTarea1";
            this.numeroTarea1.ReadOnly = true;
            this.numeroTarea1.Visible = false;
            // 
            // fechaInicio1
            // 
            this.fechaInicio1.HeaderText = "fechaInicio1";
            this.fechaInicio1.Name = "fechaInicio1";
            this.fechaInicio1.ReadOnly = true;
            this.fechaInicio1.Visible = false;
            // 
            // fechaFin1
            // 
            this.fechaFin1.HeaderText = "fechaFin1";
            this.fechaFin1.Name = "fechaFin1";
            this.fechaFin1.ReadOnly = true;
            this.fechaFin1.Visible = false;
            // 
            // tareasNoUrgentesSiImportantes
            // 
            this.tareasNoUrgentesSiImportantes.HeaderText = "Tareas importantes pero no urgentes";
            this.tareasNoUrgentesSiImportantes.Name = "tareasNoUrgentesSiImportantes";
            this.tareasNoUrgentesSiImportantes.ReadOnly = true;
            this.tareasNoUrgentesSiImportantes.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tareasNoUrgentesSiImportantes.Width = 257;
            // 
            // numeroTarea2
            // 
            this.numeroTarea2.HeaderText = "numero";
            this.numeroTarea2.Name = "numeroTarea2";
            this.numeroTarea2.ReadOnly = true;
            this.numeroTarea2.Visible = false;
            // 
            // fechaInicio2
            // 
            this.fechaInicio2.HeaderText = "fechaInicio2";
            this.fechaInicio2.Name = "fechaInicio2";
            this.fechaInicio2.ReadOnly = true;
            this.fechaInicio2.Visible = false;
            // 
            // fechaFin2
            // 
            this.fechaFin2.HeaderText = "fechaFin2";
            this.fechaFin2.Name = "fechaFin2";
            this.fechaFin2.ReadOnly = true;
            this.fechaFin2.Visible = false;
            // 
            // tareasNoImportantesNoUrgentes
            // 
            this.tareasNoImportantesNoUrgentes.HeaderText = "Tareas sin urgencia ni importancia";
            this.tareasNoImportantesNoUrgentes.Name = "tareasNoImportantesNoUrgentes";
            this.tareasNoImportantesNoUrgentes.ReadOnly = true;
            this.tareasNoImportantesNoUrgentes.Width = 257;
            // 
            // numeroTarea4
            // 
            this.numeroTarea4.HeaderText = "numeroTarea4";
            this.numeroTarea4.Name = "numeroTarea4";
            this.numeroTarea4.ReadOnly = true;
            this.numeroTarea4.Visible = false;
            // 
            // fechaInicio4
            // 
            this.fechaInicio4.HeaderText = "fechaInicio4";
            this.fechaInicio4.Name = "fechaInicio4";
            this.fechaInicio4.ReadOnly = true;
            this.fechaInicio4.Visible = false;
            // 
            // fechaFin4
            // 
            this.fechaFin4.HeaderText = "fechaFin4";
            this.fechaFin4.Name = "fechaFin4";
            this.fechaFin4.ReadOnly = true;
            this.fechaFin4.Visible = false;
            // 
            // MatrizMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 422);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.dataGridViewNoUrgenteNoImportante);
            this.Controls.Add(this.dataGridViewUrgenteNoImportante);
            this.Controls.Add(this.dataGridViewImportanteNoUrgente);
            this.Controls.Add(this.dataGridViewUrgenteImportante);
            this.Controls.Add(this.labelNoImportante);
            this.Controls.Add(this.labelImportante);
            this.Controls.Add(this.labelNoUrgente);
            this.Controls.Add(this.labelUrgente);
            this.Name = "MatrizMain";
            this.Text = "MatrizMain";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUrgenteImportante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImportanteNoUrgente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUrgenteNoImportante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNoUrgenteNoImportante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUrgente;
        private System.Windows.Forms.Label labelNoUrgente;
        private System.Windows.Forms.Label labelImportante;
        private System.Windows.Forms.Label labelNoImportante;
        private System.Windows.Forms.DataGridView dataGridViewUrgenteImportante;
        private System.Windows.Forms.DataGridView dataGridViewImportanteNoUrgente;
        private System.Windows.Forms.DataGridView dataGridViewUrgenteNoImportante;
        private System.Windows.Forms.DataGridView dataGridViewNoUrgenteNoImportante;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn tareasNoImportantesSiUrgentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroTarea3;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicio3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreTareaUrgenteImportante;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroTarea1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicio1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFin1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tareasNoUrgentesSiImportantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroTarea2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicio2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFin2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tareasNoImportantesNoUrgentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroTarea4;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicio4;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFin4;
    }
}