using ParetoKin.vista.modulotareas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParetoKin.vista.modulomatriz
{
    public partial class MatrizMain : Form
    {

        VistaPrincipal padre;
        int numTarea = -1;

        Color colorImportanteUrgente = Color.FromArgb(100, 50, 100);
        Color colorImportanteNoUrgente = Color.FromArgb(10, 200, 100);
        Color colorNoImportanteUrgente = Color.FromArgb(50, 100, 200);
        Color colorNoImportanteNoUrgente = Color.FromArgb(0, 100, 100);

        public MatrizMain(VistaPrincipal padre)
        {
            InitializeComponent();
            this.labelImportante.Text = Program.str.diccionario["labelImportante"];
            this.labelNoImportante.Text = Program.str.diccionario["labelNoImportante"];
            this.labelUrgente.Text = Program.str.diccionario["labelUrgente"];
            this.labelNoUrgente.Text = Program.str.diccionario["labelNoUrgente"];

            this.buttonCerrar.Text = Program.str.diccionario["buttonCerrar"];

            this.nombreTareaUrgenteImportante.HeaderText = Program.str.diccionario["nombreTareaUrgenteImportante"];
            this.tareasNoImportantesNoUrgentes.HeaderText = Program.str.diccionario["tareasNoImportantesNoUrgentes"];
            this.tareasNoImportantesSiUrgentes.HeaderText = Program.str.diccionario["tareasNoImportantesSiUrgentes"];
            this.tareasNoUrgentesSiImportantes.HeaderText = Program.str.diccionario["tareasNoUrgentesSiImportantes"];

            this.nombreTareaUrgenteImportante.ToolTipText = Program.str.diccionario["toolTipnombreTareaUrgenteImportante"];
            this.tareasNoImportantesNoUrgentes.ToolTipText = Program.str.diccionario["toolTiptareasNoImportantesNoUrgentes"];
            this.tareasNoImportantesSiUrgentes.ToolTipText = Program.str.diccionario["toolTiptareasNoImportantesSiUrgentes"];
            this.tareasNoUrgentesSiImportantes.ToolTipText = Program.str.diccionario["toolTiptareasNoUrgentesSiImportantes"];


            this.buttonCerrar.Focus();
            this.padre = padre;
            consultarTareasImportantesYUrgentes();
            consultarTareasNoImportantesYUrgentes();
            consultarTareasImportantesYNoUrgentes();
            consultarTareasNoImportantesYNoUrgentes();
        }

        public void consultarTareasImportantesYUrgentes()
        {
            dataGridViewUrgenteImportante.Rows.Clear();
            using (var conn = new SqlConnection(Program.CONECCION_STRING))
            {
                conn.Open();

                // 1.  create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("consultarTareasImportantesYUrgentes", conn);

                // 2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;


                // execute the command
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    int i = 0;
                    while (rdr.Read())
                    {

                        dataGridViewUrgenteImportante.Rows.Add(rdr["nombre"].ToString(),
                            Convert.ToInt32(rdr["numero"].ToString()), rdr["fechaInicio"].ToString()
                            , rdr["fechaFin"].ToString());

                        for (int j = 0; j < dataGridViewUrgenteImportante.Columns.Count - 1; j++)
                        {
                            dataGridViewUrgenteImportante.Rows[i].Cells[j].Style.BackColor = colorImportanteUrgente;
                        }


                        i++;
                    }
                }

                conn.Close();
            }

        }


        public void consultarTareasImportantesYNoUrgentes()
        {
            dataGridViewImportanteNoUrgente.Rows.Clear();
            using (var conn = new SqlConnection(Program.CONECCION_STRING))
            {
                conn.Open();

                // 1.  create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("consultarTareasImportantesYNoUrgentes", conn);

                // 2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;


                // execute the command
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    int i = 0;
                    while (rdr.Read())
                    {

                        dataGridViewImportanteNoUrgente.Rows.Add(rdr["nombre"].ToString(),
                            Convert.ToInt32(rdr["numero"].ToString()), rdr["fechaInicio"].ToString()
                            , rdr["fechaFin"].ToString());

                        for (int j = 0; j < dataGridViewUrgenteImportante.Columns.Count - 1; j++)
                        {
                            dataGridViewImportanteNoUrgente.Rows[i].Cells[j].Style.BackColor = colorImportanteNoUrgente;
                        }


                        i++;
                    }
                }

                conn.Close();
            }

        }

        public void consultarTareasNoImportantesYUrgentes()
        {
            dataGridViewUrgenteNoImportante.Rows.Clear();
            using (var conn = new SqlConnection(Program.CONECCION_STRING))
            {
                conn.Open();

                // 1.  create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("consultarTareasNoImportantesYUrgentes", conn);

                // 2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;


                // execute the command
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    int i = 0;
                    while (rdr.Read())
                    {

                        dataGridViewUrgenteNoImportante.Rows.Add(rdr["nombre"].ToString(),
                            Convert.ToInt32(rdr["numero"].ToString()), rdr["fechaInicio"].ToString()
                            , rdr["fechaFin"].ToString());

                        for (int j = 0; j < dataGridViewUrgenteImportante.Columns.Count - 1; j++)
                        {
                            dataGridViewUrgenteNoImportante.Rows[i].Cells[j].Style.BackColor = colorNoImportanteUrgente;
                        }


                        i++;
                    }
                }

                conn.Close();
            }

        }

        public void consultarTareasNoImportantesYNoUrgentes()
        {
            dataGridViewNoUrgenteNoImportante.Rows.Clear();
            using (var conn = new SqlConnection(Program.CONECCION_STRING))
            {
                conn.Open();

                // 1.  create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("consultarTareasNoImportantesYNoUrgentes", conn);

                // 2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;


                // execute the command
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    int i = 0;
                    while (rdr.Read())
                    {

                        dataGridViewNoUrgenteNoImportante.Rows.Add(rdr["nombre"].ToString(),
                            Convert.ToInt32(rdr["numero"].ToString()), rdr["fechaInicio"].ToString()
                            , rdr["fechaFin"].ToString());

                        for (int j = 0; j < dataGridViewUrgenteImportante.Columns.Count - 1; j++)
                        {
                            dataGridViewNoUrgenteNoImportante.Rows[i].Cells[j].Style.BackColor = colorNoImportanteNoUrgente;
                        }


                        i++;
                    }
                }

                conn.Close();
            }

        }


        private void ButtonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();

            padre.mostrarInicio();
        }

        private void visualizarDetalleIyU(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {


                this.numTarea = Convert.ToInt32(this.dataGridViewUrgenteImportante.Rows[dataGridViewUrgenteImportante.CurrentRow.Index].Cells[1].Value);

                this.Hide();

                padre.form_generico = new TareaDetallada(null,this, numTarea, "" + this.dataGridViewUrgenteImportante.Rows[dataGridViewUrgenteImportante.CurrentRow.Index].Cells[2].Value, "" + this.dataGridViewUrgenteImportante.Rows[dataGridViewUrgenteImportante.CurrentRow.Index].Cells[3].Value) { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
                padre.panelGenerico.Controls.Add(padre.form_generico);
                padre.form_generico.Show();
            }
        }

        private void celdaDobleClicIyNoU(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {


                this.numTarea = Convert.ToInt32(this.dataGridViewImportanteNoUrgente.Rows[dataGridViewImportanteNoUrgente.CurrentRow.Index].Cells[1].Value);

                this.Hide();

                padre.form_generico = new TareaDetallada(null, this, numTarea, "" + this.dataGridViewImportanteNoUrgente.Rows[dataGridViewImportanteNoUrgente.CurrentRow.Index].Cells[2].Value, "" + this.dataGridViewImportanteNoUrgente.Rows[dataGridViewImportanteNoUrgente.CurrentRow.Index].Cells[3].Value) { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
                padre.panelGenerico.Controls.Add(padre.form_generico);
                padre.form_generico.Show();
            }
        }

        private void celdaDobleClicUyNoI(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {


                this.numTarea = Convert.ToInt32(this.dataGridViewUrgenteNoImportante.Rows[dataGridViewUrgenteNoImportante.CurrentRow.Index].Cells[1].Value);

                this.Hide();

                padre.form_generico = new TareaDetallada(null, this, numTarea, "" + this.dataGridViewUrgenteNoImportante.Rows[dataGridViewUrgenteNoImportante.CurrentRow.Index].Cells[2].Value, "" + this.dataGridViewUrgenteNoImportante.Rows[dataGridViewUrgenteNoImportante.CurrentRow.Index].Cells[3].Value) { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
                padre.panelGenerico.Controls.Add(padre.form_generico);
                padre.form_generico.Show();
            }
        }

        private void celdaDobleClicNoUyNoI(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {


                this.numTarea = Convert.ToInt32(this.dataGridViewNoUrgenteNoImportante.Rows[dataGridViewNoUrgenteNoImportante.CurrentRow.Index].Cells[1].Value);

                this.Hide();

                padre.form_generico = new TareaDetallada(null, this, numTarea, "" + this.dataGridViewNoUrgenteNoImportante.Rows[dataGridViewNoUrgenteNoImportante.CurrentRow.Index].Cells[2].Value, "" + this.dataGridViewNoUrgenteNoImportante.Rows[dataGridViewNoUrgenteNoImportante.CurrentRow.Index].Cells[3].Value) { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
                padre.panelGenerico.Controls.Add(padre.form_generico);
                padre.form_generico.Show();
            }
        }
    }
}
