namespace ParetoKin.vista.modulotareas
{
    partial class TareaDetallada
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.dataGridViewEspecificaciones = new System.Windows.Forms.DataGridView();
            this.numeroEspecificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dias = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cumplido = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idEspecificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonGuardarCambios = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEspecificaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCerrar.Location = new System.Drawing.Point(460, 320);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(117, 43);
            this.buttonCerrar.TabIndex = 8;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.ButtonCerrar_Click);
            // 
            // dataGridViewEspecificaciones
            // 
            this.dataGridViewEspecificaciones.AllowUserToDeleteRows = false;
            this.dataGridViewEspecificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEspecificaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroEspecificacion,
            this.especificacion,
            this.fechaInicio,
            this.fechaFin,
            this.dias,
            this.cumplido,
            this.idEspecificacion});
            this.dataGridViewEspecificaciones.Location = new System.Drawing.Point(24, 27);
            this.dataGridViewEspecificaciones.Name = "dataGridViewEspecificaciones";
            this.dataGridViewEspecificaciones.Size = new System.Drawing.Size(748, 257);
            this.dataGridViewEspecificaciones.TabIndex = 9;
            this.dataGridViewEspecificaciones.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.filaEditada);
            this.dataGridViewEspecificaciones.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.nuevaFila);
            // 
            // numeroEspecificacion
            // 
            dataGridViewCellStyle1.NullValue = "1";
            this.numeroEspecificacion.DefaultCellStyle = dataGridViewCellStyle1;
            this.numeroEspecificacion.HeaderText = "Número";
            this.numeroEspecificacion.Name = "numeroEspecificacion";
            this.numeroEspecificacion.ReadOnly = true;
            this.numeroEspecificacion.Width = 50;
            // 
            // especificacion
            // 
            this.especificacion.HeaderText = "Acción";
            this.especificacion.Name = "especificacion";
            this.especificacion.Width = 300;
            // 
            // fechaInicio
            // 
            this.fechaInicio.HeaderText = "Inicio";
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.ReadOnly = true;
            // 
            // fechaFin
            // 
            this.fechaFin.HeaderText = "Fin";
            this.fechaFin.Name = "fechaFin";
            this.fechaFin.ReadOnly = true;
            // 
            // dias
            // 
            this.dias.DataPropertyName = "dato";
            dataGridViewCellStyle2.NullValue = "1";
            this.dias.DefaultCellStyle = dataGridViewCellStyle2;
            this.dias.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dias.HeaderText = "Días";
            this.dias.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.dias.Name = "dias";
            // 
            // cumplido
            // 
            this.cumplido.HeaderText = "Cumplido";
            this.cumplido.Name = "cumplido";
            this.cumplido.Width = 55;
            // 
            // idEspecificacion
            // 
            this.idEspecificacion.HeaderText = "ID";
            this.idEspecificacion.Name = "idEspecificacion";
            this.idEspecificacion.ReadOnly = true;
            this.idEspecificacion.Visible = false;
            // 
            // buttonGuardarCambios
            // 
            this.buttonGuardarCambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardarCambios.Location = new System.Drawing.Point(193, 320);
            this.buttonGuardarCambios.Name = "buttonGuardarCambios";
            this.buttonGuardarCambios.Size = new System.Drawing.Size(177, 43);
            this.buttonGuardarCambios.TabIndex = 10;
            this.buttonGuardarCambios.Text = "Guardar cambios";
            this.buttonGuardarCambios.UseVisualStyleBackColor = true;
            this.buttonGuardarCambios.Click += new System.EventHandler(this.ButtonGuardarCambios_Click);
            // 
            // TareaDetallada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 401);
            this.Controls.Add(this.buttonGuardarCambios);
            this.Controls.Add(this.dataGridViewEspecificaciones);
            this.Controls.Add(this.buttonCerrar);
            this.Name = "TareaDetallada";
            this.Text = "TareaDetallada";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEspecificaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.DataGridView dataGridViewEspecificaciones;
        private System.Windows.Forms.Button buttonGuardarCambios;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroEspecificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn especificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFin;
        private System.Windows.Forms.DataGridViewComboBoxColumn dias;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cumplido;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEspecificacion;
    }
}