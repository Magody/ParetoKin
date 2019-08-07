namespace ParetoKin.vista.modulohoy
{
    partial class HoyMain
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
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.nombreTarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionTarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importanciaTarea = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.urgenciaTarea = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.fechaFin,
            this.fechaInicio,
            this.numeroTarea});
            this.dataGridViewListaTareas.Location = new System.Drawing.Point(2, 27);
            this.dataGridViewListaTareas.Name = "dataGridViewListaTareas";
            this.dataGridViewListaTareas.Size = new System.Drawing.Size(783, 312);
            this.dataGridViewListaTareas.TabIndex = 1;
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCerrar.Location = new System.Drawing.Point(339, 346);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(117, 43);
            this.buttonCerrar.TabIndex = 8;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.ButtonCerrar_Click);
            // 
            // nombreTarea
            // 
            this.nombreTarea.HeaderText = "Nombre";
            this.nombreTarea.Name = "nombreTarea";
            this.nombreTarea.ReadOnly = true;
            this.nombreTarea.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nombreTarea.Width = 200;
            // 
            // descripcionTarea
            // 
            this.descripcionTarea.HeaderText = "Descripción";
            this.descripcionTarea.Name = "descripcionTarea";
            this.descripcionTarea.ReadOnly = true;
            this.descripcionTarea.Width = 300;
            // 
            // importanciaTarea
            // 
            this.importanciaTarea.HeaderText = "Importante";
            this.importanciaTarea.Name = "importanciaTarea";
            this.importanciaTarea.ReadOnly = true;
            this.importanciaTarea.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.importanciaTarea.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.importanciaTarea.Width = 70;
            // 
            // urgenciaTarea
            // 
            this.urgenciaTarea.HeaderText = "Urgencia";
            this.urgenciaTarea.Name = "urgenciaTarea";
            this.urgenciaTarea.ReadOnly = true;
            this.urgenciaTarea.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.urgenciaTarea.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.urgenciaTarea.Width = 70;
            // 
            // fechaFin
            // 
            this.fechaFin.HeaderText = "FechaFin";
            this.fechaFin.Name = "fechaFin";
            this.fechaFin.ReadOnly = true;
            // 
            // fechaInicio
            // 
            this.fechaInicio.HeaderText = "fechaInicio";
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.ReadOnly = true;
            this.fechaInicio.Visible = false;
            // 
            // numeroTarea
            // 
            this.numeroTarea.HeaderText = "Numero";
            this.numeroTarea.Name = "numeroTarea";
            this.numeroTarea.ReadOnly = true;
            this.numeroTarea.Visible = false;
            // 
            // HoyMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 401);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.dataGridViewListaTareas);
            this.Name = "HoyMain";
            this.Text = "HoyMain";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaTareas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListaTareas;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreTarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionTarea;
        private System.Windows.Forms.DataGridViewCheckBoxColumn importanciaTarea;
        private System.Windows.Forms.DataGridViewCheckBoxColumn urgenciaTarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroTarea;
    }
}