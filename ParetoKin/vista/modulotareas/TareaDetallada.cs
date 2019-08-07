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

namespace ParetoKin.vista.modulotareas
{

    
    public partial class TareaDetallada : Form
    {
        TareasMain padre;
        int numTarea;
        bool fue_modificado;


        public TareaDetallada(TareasMain padre, int numTarea)
        {
            InitializeComponent();
            this.padre = padre;
            this.numTarea = numTarea;
            this.buttonGuardarCambios.Text = Program.str.diccionario["buttonGuardarCambios"];
            this.buttonCerrar.Text = Program.str.diccionario["buttonCerrar"];
            this.mostrarEspecificaciones();

            int valor_anterior = Convert.ToInt32(dataGridViewEspecificaciones.Rows[dataGridViewEspecificaciones.Rows.Count - 2].Cells[0].Value);
            
            this.dataGridViewEspecificaciones.Rows[dataGridViewEspecificaciones.Rows.Count - 1].Cells[0].Value = valor_anterior + 1;


            fue_modificado = false;
        }


        public List<EspecificacionTarea> consultarEspecificaciones()
        {
            List<EspecificacionTarea> especificaciones = new List<EspecificacionTarea>();

            using (var conn = new SqlConnection(Program.CONECCION_STRING))
            {
                conn.Open();

                // 1.  create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("consultarEspecificacionesDeTareas", conn);

                // 2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@numeroTarea", numTarea));



                // execute the command
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    // iterate through results, printing each to console
                    while (rdr.Read())
                    {
                        
                        especificaciones.Add(new EspecificacionTarea(Convert.ToInt32(rdr["id"].ToString()),
                            Convert.ToInt32(rdr["numero"].ToString()),
                            rdr["especificacion"].ToString(),
                            rdr["diaInicio"].ToString(),
                            rdr["diaFin"].ToString(),
                            Convert.ToInt32(rdr["dias"].ToString()),
                            Convert.ToBoolean(rdr["cumplido"].ToString())
                            )) ;


                        //Console.WriteLine("Product: {0,-35} Total: {1,2}", rdr["nombrePlato"], rdr["precioPlato"]);
                    }
                }

                conn.Close();
            }

            return especificaciones;

        }

        public void mostrarEspecificaciones()
        {
            dataGridViewEspecificaciones.Rows.Clear();
            List<EspecificacionTarea> lista_tareas = consultarEspecificaciones();


            for (int i = 0; i < lista_tareas.Count; i++)
            {



                dataGridViewEspecificaciones.Rows.Add(lista_tareas[i].Numero, lista_tareas[i].Especificacion,
                    lista_tareas[i].DiaInicio, lista_tareas[i].DiaFin
                    , lista_tareas[i].Dias + "",lista_tareas[i].Cumplido,
                    lista_tareas[i].Id);
                
            }
        }


        private void ButtonCerrar_Click(object sender, EventArgs e)
        {
            if (fue_modificado)
            {
                DialogResult dialogResult = MessageBox.Show(Program.str.diccionario["msgGuardarSalir"],
                    Program.str.diccionario["tituloCambiosRealizados"], MessageBoxButtons.YesNoCancel);

                if (dialogResult == DialogResult.Yes)
                {
                    guardarCambios();
                }
                else if (dialogResult == DialogResult.Cancel)
                {
                    return;
                }

                this.Close();
                padre.Show();
            }
            else
            {
                this.Close();
                padre.Show();
            }
            
        }


        private void nuevaFila(object sender, DataGridViewRowEventArgs e)
        {
            int valor_anterior = Convert.ToInt32(this.dataGridViewEspecificaciones.Rows[dataGridViewEspecificaciones.Rows.Count - 2].Cells[0].Value.ToString());
            
            this.dataGridViewEspecificaciones.Rows[dataGridViewEspecificaciones.Rows.Count - 1].Cells[0].Value = valor_anterior + 1;

        }

        private void filaEditada(object sender, DataGridViewCellEventArgs e)
        {
            this.fue_modificado = true;

        }

        private void ButtonGuardarCambios_Click(object sender, EventArgs e)
        {
            guardarCambios();
        }


        public void actualizarCrearEspecificaciones()
        {

            using (var conn = new SqlConnection(Program.CONECCION_STRING))
            {
                


                for (int i = 0; i < dataGridViewEspecificaciones.Rows.Count - 1; i++)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("actualizarOCrearEspecificacion", conn);
                    cmd.CommandType = CommandType.StoredProcedure;


                    string id = "" + dataGridViewEspecificaciones.Rows[i].Cells[6].Value;
                    if (id == "")
                    {
                        cmd.Parameters.Add(new SqlParameter("@id", -1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@id", Convert.ToInt32(id)));
                    }
                    cmd.Parameters.Add(new SqlParameter("@numero", Convert.ToInt32(dataGridViewEspecificaciones.Rows[i].Cells[0].Value)));
                    cmd.Parameters.Add(new SqlParameter("@numeroTarea", numTarea));
                    cmd.Parameters.Add(new SqlParameter("@especificacion", "" + dataGridViewEspecificaciones.Rows[i].Cells[1].Value));
                    cmd.Parameters.Add(new SqlParameter("@diaInicio", Convert.ToDateTime("" + dataGridViewEspecificaciones.Rows[i].Cells[2].Value)));
                    cmd.Parameters.Add(new SqlParameter("@diaFin", Convert.ToDateTime("" + dataGridViewEspecificaciones.Rows[i].Cells[3].Value)));
                    cmd.Parameters.Add(new SqlParameter("@dias", Convert.ToInt32("" + dataGridViewEspecificaciones.Rows[i].Cells[4].Value)));
                    cmd.Parameters.Add(new SqlParameter("@cumplido", (Convert.ToBoolean(""+dataGridViewEspecificaciones.Rows[i].Cells[5].Value)) ? 1 : 0));


                    cmd.ExecuteReader();
                    conn.Close();
                }
            }


        }

        public void guardarCambios()
        {
            this.fue_modificado = false;
            actualizarCrearEspecificaciones();

            MessageBox.Show("Cambios guardados exitosamente");
        }
    }
}
