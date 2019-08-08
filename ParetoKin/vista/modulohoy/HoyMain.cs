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

        public HoyMain(VistaPrincipal padre)
        {
            InitializeComponent();
            this.buttonCerrar.Text = Program.str.diccionario["buttonCerrar"];
            this.padre = padre;

            this.nombreTarea.HeaderText = Program.str.diccionario["nombreTarea"];
            this.descripcionTarea.HeaderText = Program.str.diccionario["descripcionTarea"];
            this.importanciaTarea.HeaderText = Program.str.diccionario["importanciaTarea"];
            this.urgenciaTarea.HeaderText = Program.str.diccionario["urgenciaTarea"];
            this.fechaFin.HeaderText = Program.str.diccionario["fechaFin"];


            
            mostrarTareas();
        }


        public void mostrarTareas()
        {
            dataGridViewListaTareas.Rows.Clear();
            List<Tarea> lista_tareas_hoy = consultarTareasHoy();


            for (int i = 0; i < lista_tareas_hoy.Count; i++)
            {

                dataGridViewListaTareas.Rows.Add(lista_tareas_hoy[i].Nombre, lista_tareas_hoy[i].Descripcion, lista_tareas_hoy[i].Importante, lista_tareas_hoy[i].Urgente, lista_tareas_hoy[i].FechaFin, lista_tareas_hoy[i].FechaInicio, lista_tareas_hoy[i].Numero);
                for (int j = 0; j < dataGridViewListaTareas.Columns.Count - 1; j++)
                {
                    dataGridViewListaTareas.Rows[i].Cells[j].Style.BackColor = colorTareasHoy;
                }
            }

            List<Tarea> lista_tareas_atrasadas = consultarTareasAtrasadas();


            for (int i = 0; i < lista_tareas_atrasadas.Count; i++)
            {

                dataGridViewListaTareas.Rows.Add(lista_tareas_atrasadas[i].Nombre, lista_tareas_atrasadas[i].Descripcion, lista_tareas_atrasadas[i].Importante, lista_tareas_atrasadas[i].Urgente, lista_tareas_atrasadas[i].FechaFin, lista_tareas_atrasadas[i].FechaInicio, lista_tareas_atrasadas[i].Numero);
                for (int j = 0; j < dataGridViewListaTareas.Columns.Count - 1; j++)
                {
                    dataGridViewListaTareas.Rows[dataGridViewListaTareas.Rows.Count-2].Cells[j].Style.BackColor = colorTareasAtrasadas;
                }
            }


        }


        public List<Tarea> consultarTareasHoy()
        {
            List<Tarea> tareas = new List<Tarea>();

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

                        tareas.Add(new Tarea(Convert.ToInt32(rdr["numero"].ToString()), rdr["nombre"].ToString(), rdr["descripcion"].ToString(),
                            Convert.ToBoolean(rdr["importante"].ToString().ToLower()),
                            Convert.ToBoolean(rdr["urgente"].ToString().ToLower()),
                            Convert.ToDateTime(rdr["fechaInicio"].ToString()),
                            Convert.ToDateTime(rdr["fechaFin"].ToString())
                            ));


                        //Console.WriteLine("Product: {0,-35} Total: {1,2}", rdr["nombrePlato"], rdr["precioPlato"]);
                    }
                }

                conn.Close();
            }

            return tareas;

        }

        public List<Tarea> consultarTareasAtrasadas()
        {
            List<Tarea> tareas = new List<Tarea>();

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
                    // iterate through results, printing each to console
                    while (rdr.Read())
                    {

                        tareas.Add(new Tarea(Convert.ToInt32(rdr["numero"].ToString()), rdr["nombre"].ToString(), rdr["descripcion"].ToString(),
                            Convert.ToBoolean(rdr["importante"].ToString().ToLower()),
                            Convert.ToBoolean(rdr["urgente"].ToString().ToLower()),
                            Convert.ToDateTime(rdr["fechaInicio"].ToString()),
                            Convert.ToDateTime(rdr["fechaFin"].ToString())
                            ));


                        //Console.WriteLine("Product: {0,-35} Total: {1,2}", rdr["nombrePlato"], rdr["precioPlato"]);
                    }
                }

                conn.Close();
            }

            return tareas;

        }

        private void ButtonCerrar_Click(object sender, EventArgs e)
        {
            dataGridViewListaTareas.Rows.Clear();
            this.Close();

            padre.mostrarInicio();
        }
    }
}
