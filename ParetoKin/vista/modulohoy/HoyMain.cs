using ParetoKin.modelo;
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

namespace ParetoKin.vista.modulohoy
{
    public partial class HoyMain : Form
    {

        Color colorTareasHoy = Color.LightGreen;
        Color colorTareasAtrasadas = Color.Pink;
        VistaPrincipal padre;


        bool carga_completa;
        public HoyMain(VistaPrincipal padre)
        {
            InitializeComponent();
            this.buttonCerrar.Text = Program.str.diccionario["buttonCerrar"];
            this.padre = padre;

            this.nombreTarea.HeaderText = Program.str.diccionario["nombreTarea"];
            this.importanciaTarea.HeaderText = Program.str.diccionario["importanciaTarea"];
            this.urgenciaTarea.HeaderText = Program.str.diccionario["urgenciaTarea"];
            this.especificacionTarea.HeaderText = Program.str.diccionario["especificacion"];
            this.cumplidoEspecificacion.HeaderText = Program.str.diccionario["cumplido"];


            mostrarTareas();

            establecerColoresDeColumnasEditables();

            carga_completa = true;

        }

        private void establecerColoresDeColumnasEditables()
        {
            for (int i = 0; i < dataGridViewListaTareas.Columns.Count; i++)
            {
                if (!dataGridViewListaTareas.Columns[i].ReadOnly)
                {
                    dataGridViewListaTareas.Columns[i].DefaultCellStyle.SelectionBackColor = Program.colorEdicionPermitidaSeleccion;
                    dataGridViewListaTareas.Columns[i].DefaultCellStyle.ForeColor = Program.colorEdicionPermitidaTexto;
                    dataGridViewListaTareas.Columns[i].DefaultCellStyle.SelectionForeColor = Program.colorEdicionPermitidaTexto;

                }

            }
        }


        public void mostrarTareas()
        {
            dataGridViewListaTareas.Rows.Clear();
            consultarTareasHoy();
            consultarTareasAtrasadas();

        }


        public void consultarTareasHoy()
        {
            

            using (var conn = new SqlConnection(Program.CONECCION_STRING))
            {
                conn.Open();

                // 1.  create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("consultarTareasHoy", conn);

                // 2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;


                DateTime hoy = DateTime.Now;
                Fecha fecha_hoy = new Fecha(hoy.Day, hoy.Month, hoy.Year);

                cmd.Parameters.Add(new SqlParameter("@fechaHoy", fecha_hoy.ToStringMMDDYYYY()));
                

                // execute the command
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    // iterate through results, printing each to console
                    
                    while (rdr.Read())
                    {

                        dataGridViewListaTareas.Rows.Add(rdr["nombre"].ToString(), Convert.ToBoolean(rdr["importante"].ToString().ToLower()),
                            Convert.ToBoolean(rdr["urgente"].ToString().ToLower()),
                            rdr["especificacion"].ToString(),
                            Convert.ToBoolean(rdr["cumplido"].ToString().ToLower()),
                            Convert.ToInt32(rdr["tnumero"].ToString()),
                            Convert.ToInt32(rdr["id"].ToString()),
                            Convert.ToInt32(rdr["enumero"].ToString()));

                        for (int j = 0; j < dataGridViewListaTareas.Columns.Count - 1; j++)
                        {
                            dataGridViewListaTareas.Rows[dataGridViewListaTareas.Rows.Count - 1].Cells[j].Style.BackColor = colorTareasHoy;
                        }
                    }
                }

                conn.Close();
            }

        }

        public void consultarTareasAtrasadas()
        {
            

            using (var conn = new SqlConnection(Program.CONECCION_STRING))
            {
                conn.Open();

                // 1.  create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("consultarTareasAtrasadas", conn);

                // 2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;
                DateTime hoy = DateTime.Now;
                Fecha fecha_hoy = new Fecha(hoy.Day, hoy.Month, hoy.Year);
                cmd.Parameters.Add(new SqlParameter("@fechaHoy", fecha_hoy.ToStringReves()));


                // execute the command
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {

                    while (rdr.Read())
                    {

                        dataGridViewListaTareas.Rows.Add(rdr["nombre"].ToString(), Convert.ToBoolean(rdr["importante"].ToString().ToLower()),
                            Convert.ToBoolean(rdr["urgente"].ToString().ToLower()),
                            rdr["especificacion"].ToString(),
                            Convert.ToBoolean(rdr["cumplido"].ToString().ToLower()),
                            Convert.ToInt32(rdr["tnumero"].ToString()),
                            Convert.ToInt32(rdr["id"].ToString()),
                            Convert.ToInt32(rdr["enumero"].ToString()));

                        for (int j = 0; j < dataGridViewListaTareas.Columns.Count - 1; j++)
                        {
                            dataGridViewListaTareas.Rows[dataGridViewListaTareas.Rows.Count - 1].Cells[j].Style.BackColor = colorTareasAtrasadas;
                        }

                    }
                }

                conn.Close();
            }

        }

        private void ButtonCerrar_Click(object sender, EventArgs e)
        {
            dataGridViewListaTareas.Rows.Clear();
            this.Close();

            padre.mostrarInicio();
        }

        private void cambio(object sender, DataGridViewCellEventArgs e)
        {
            if (carga_completa)
            {
                //MessageBox.Show(dataGridViewListaTareas.Rows[dataGridViewListaTareas.CurrentRow.Index].Cells[0].Value + "");
                using (var conn = new SqlConnection(Program.CONECCION_STRING))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("actualizarEspecificacionCumplida", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@id", Convert.ToInt32("" + dataGridViewListaTareas.Rows[dataGridViewListaTareas.CurrentRow.Index].Cells[6].Value)));
                    cmd.Parameters.Add(new SqlParameter("@cumplido", (Convert.ToBoolean("" + dataGridViewListaTareas.Rows[dataGridViewListaTareas.CurrentRow.Index].Cells[4].Value)) ? 1 : 0));


                    cmd.ExecuteReader();
                    conn.Close();
                }
            }

        }
    }
}
