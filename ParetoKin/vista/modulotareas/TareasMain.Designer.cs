namespace ParetoKin.vista.modulotareas
{
    partial class TareasMain
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
            this.dataGridViewListaTareas = new System.Windows.Forms.DataGridView();
            this.labelFiltrarPorNombre = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.buttonGuardarCambios = new System.Windows.Forms.Button();
            this.nombreTarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionTarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importanciaTarea = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.urgenciaTarea = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroTarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaTareas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListaTareas
            // 
            this.dataGridViewListaTareas.AllowUserToOrderColumns = true;
            this.dataGridViewListaTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaTareas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreTarea,
            this.descripcionTarea,
            this.importanciaTarea,
            this.urgenciaTarea,
            this.fechaInicio,
            this.numeroTarea});
            this.dataGridViewListaTareas.Location = new System.Drawing.Point(2, 38);
            this.dataGridViewListaTareas.Name = "dataGridViewListaTareas";
            this.dataGridViewListaTareas.Size = new System.Drawing.Size(783, 312);
            this.dataGridViewListaTareas.TabIndex = 0;
            this.dataGridViewListaTareas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.celdaClick);
            this.dataGridViewListaTareas.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.visualizarTareaDetalles);
            this.dataGridViewListaTareas.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.celdaEditada);
            this.dataGridViewListaTareas.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.filaEliminada);
            // 
            // labelFiltrarPorNombre
            // 
            this.labelFiltrarPorNombre.AutoSize = true;
            this.labelFiltrarPorNombre.Location = new System.Drawing.Point(267, 15);
            this.labelFiltrarPorNombre.Name = "labelFiltrarPorNombre";
            this.labelFiltrarPorNombre.Size = new System.Drawing.Size(115, 13);
            this.labelFiltrarPorNombre.TabIndex = 1;
            this.labelFiltrarPorNombre.Text = "Filtrar tarea por nombre";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(404, 12);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(159, 20);
            this.textBoxNombre.TabIndex = 2;
            this.textBoxNombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.busquedaTareas);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCerrar.Location = new System.Drawing.Point(420, 356);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(117, 43);
            this.buttonCerrar.TabIndex = 7;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.ButtonCancelar_Click);
            // 
            // buttonGuardarCambios
            // 
            this.buttonGuardarCambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardarCambios.Location = new System.Drawing.Point(187, 356);
            this.buttonGuardarCambios.Name = "buttonGuardarCambios";
            this.buttonGuardarCambios.Size = new System.Drawing.Size(177, 43);
            this.buttonGuardarCambios.TabIndex = 8;
            this.buttonGuardarCambios.Text = "Guardar cambios";
            this.buttonGuardarCambios.UseVisualStyleBackColor = true;
            this.buttonGuardarCambios.Click += new System.EventHandler(this.ButtonGuardarCambios_Click);
            // 
            // nombreTarea
            // 
            this.nombreTarea.HeaderText = "Nombre";
            this.nombreTarea.Name = "nombreTarea";
            this.nombreTarea.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nombreTarea.Width = 200;
            // 
            // descripcionTarea
            // 
            this.descripcionTarea.HeaderText = "Descripción";
            this.descripcionTarea.Name = "descripcionTarea";
            this.descripcionTarea.Width = 300;
            // 
            // importanciaTarea
            // 
            this.importanciaTarea.HeaderText = "Importante";
            this.importanciaTarea.Name = "importanciaTarea";
            this.importanciaTarea.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.importanciaTarea.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.importanciaTarea.Width = 70;
            // 
            // urgenciaTarea
            // 
            this.urgenciaTarea.HeaderText = "Urgencia";
            this.urgenciaTarea.Name = "urgenciaTarea";
            this.urgenciaTarea.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.urgenciaTarea.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.urgenciaTarea.Width = 70;
            // 
            // fechaInicio
            // 
            this.fechaInicio.HeaderText = "FechaInicio";
            this.fechaInicio.Name = "fechaInicio";
            // 
            // numeroTarea
            // 
            this.numeroTarea.HeaderText = "Numero";
            this.numeroTarea.Name = "numeroTarea";
            this.numeroTarea.ReadOnly = true;
            this.numeroTarea.Visible = false;
            // 
            // TareasMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 401);
            this.Controls.Add(this.buttonGuardarCambios);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelFiltrarPorNombre);
            this.Controls.Add(this.dataGridViewListaTareas);
            this.Name = "TareasMain";
            this.Text = "TareasMain";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaTareas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListaTareas;
        private System.Windows.Forms.Label labelFiltrarPorNombre;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Button buttonGuardarCambios;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreTarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionTarea;
        private System.Windows.Forms.DataGridViewCheckBoxColumn importanciaTarea;
        private System.Windows.Forms.DataGridViewCheckBoxColumn urgenciaTarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroTarea;
    }
}