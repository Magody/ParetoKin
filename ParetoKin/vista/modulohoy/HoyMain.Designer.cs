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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewListaTareas = new System.Windows.Forms.DataGridView();
            this.nombreTarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importanciaTarea = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.urgenciaTarea = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.especificacionTarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cumplidoEspecificacion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.numeroTarea1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEspecificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroEspecificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaTareas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListaTareas
            // 
            this.dataGridViewListaTareas.AllowUserToAddRows = false;
            this.dataGridViewListaTareas.AllowUserToDeleteRows = false;
            this.dataGridViewListaTareas.AllowUserToOrderColumns = true;
            this.dataGridViewListaTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaTareas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreTarea,
            this.importanciaTarea,
            this.urgenciaTarea,
            this.especificacionTarea,
            this.cumplidoEspecificacion,
            this.numeroTarea1,
            this.idEspecificacion,
            this.numeroEspecificacion});
            this.dataGridViewListaTareas.Location = new System.Drawing.Point(18, 28);
            this.dataGridViewListaTareas.Name = "dataGridViewListaTareas";
            this.dataGridViewListaTareas.Size = new System.Drawing.Size(754, 312);
            this.dataGridViewListaTareas.TabIndex = 1;
            this.dataGridViewListaTareas.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.cambio);
            // 
            // nombreTarea
            // 
            this.nombreTarea.HeaderText = "Tarea asociada";
            this.nombreTarea.Name = "nombreTarea";
            this.nombreTarea.ReadOnly = true;
            this.nombreTarea.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            // especificacionTarea
            // 
            this.especificacionTarea.HeaderText = "Acción";
            this.especificacionTarea.Name = "especificacionTarea";
            this.especificacionTarea.ReadOnly = true;
            this.especificacionTarea.Width = 400;
            // 
            // cumplidoEspecificacion
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.NullValue = false;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cumplidoEspecificacion.DefaultCellStyle = dataGridViewCellStyle4;
            this.cumplidoEspecificacion.HeaderText = "Cumplido";
            this.cumplidoEspecificacion.Name = "cumplidoEspecificacion";
            this.cumplidoEspecificacion.Width = 70;
            // 
            // numeroTarea1
            // 
            this.numeroTarea1.HeaderText = "numeroTarea";
            this.numeroTarea1.Name = "numeroTarea1";
            this.numeroTarea1.ReadOnly = true;
            this.numeroTarea1.Visible = false;
            // 
            // idEspecificacion
            // 
            this.idEspecificacion.HeaderText = "idEspecificacion";
            this.idEspecificacion.Name = "idEspecificacion";
            this.idEspecificacion.ReadOnly = true;
            this.idEspecificacion.Visible = false;
            // 
            // numeroEspecificacion
            // 
            this.numeroEspecificacion.HeaderText = "numeroEspecificacion";
            this.numeroEspecificacion.Name = "numeroEspecificacion";
            this.numeroEspecificacion.ReadOnly = true;
            this.numeroEspecificacion.Visible = false;
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
        private System.Windows.Forms.DataGridViewCheckBoxColumn importanciaTarea;
        private System.Windows.Forms.DataGridViewCheckBoxColumn urgenciaTarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn especificacionTarea;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cumplidoEspecificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroTarea1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEspecificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroEspecificacion;
    }
}