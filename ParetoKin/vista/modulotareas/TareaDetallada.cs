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

        Fecha fechaInicial;

        List<Fecha> fechas;

        bool esta_recalculando;

        public TareaDetallada(TareasMain padre, int numTarea, string fechaInicial)
        {
            InitializeComponent();
            this.padre = padre;
            this.numTarea = numTarea;
            this.buttonGuardarCambios.Text = Program.str.diccionario["buttonGuardarCambios"];
            this.buttonCerrar.Text = Program.str.diccionario["buttonCerrar"];
            this.mostrarEspecificaciones();

            this.numeroEspecificacion.HeaderText = Program.str.diccionario["numeroEspecificacion"];
            this.especificacion.HeaderText = Program.str.diccionario["especificacion"];
            this.fechaInicio.HeaderText = Program.str.diccionario["fechaInicio"];
            this.fechaFin.HeaderText = Program.str.diccionario["fechaFin"];
            this.dias.HeaderText = Program.str.diccionario["dias"];
            this.cumplido.HeaderText = Program.str.diccionario["cumplido"];



            int valor_anterior = Convert.ToInt32(dataGridViewEspecificaciones.Rows[dataGridViewEspecificaciones.Rows.Count - 2].Cells[0].Value);

            this.dataGridViewEspecificaciones.Rows[dataGridViewEspecificaciones.Rows.Count - 1].Cells[0].Value = valor_anterior + 1;
            this.dataGridViewEspecificaciones.Rows[dataGridViewEspecificaciones.Rows.Count - 1].Cells[4].Value = "1";
            this.dataGridViewEspecificaciones.Rows[dataGridViewEspecificaciones.Rows.Count - 1].Cells[5].Value = false;

            fue_modificado = false;

            this.fechaInicial = Fecha.convertirDateTimeAFecha(fechaInicial);
            fechas = new List<Fecha>();
            reCalcularFechas();
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
                            ));


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
                Fecha inicio = Fecha.convertirDateTimeAFecha(lista_tareas[i].DiaInicio);
                Fecha fin = Fecha.convertirDateTimeAFecha(lista_tareas[i].DiaFin);


                dataGridViewEspecificaciones.Rows.Add(lista_tareas[i].Numero, lista_tareas[i].Especificacion,
                    inicio.Dia + " " + Program.str.diccionario["de"] + " " + Fecha.convertirNumeroAMes(inicio.Mes),
                    fin.Dia + " " + Program.str.diccionario["de"] + " " + Fecha.convertirNumeroAMes(fin.Mes),
                    lista_tareas[i].Dias + "", lista_tareas[i].Cumplido,
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
                this.fue_modificado = false;
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
            this.dataGridViewEspecificaciones.Rows[dataGridViewEspecificaciones.Rows.Count - 1].Cells[4].Value = "1";
            this.dataGridViewEspecificaciones.Rows[dataGridViewEspecificaciones.Rows.Count - 1].Cells[5].Value = false;


            this.reCalcularFechas();
        }

        private void filaEditada(object sender, DataGridViewCellEventArgs e)
        {
            this.fue_modificado = true;
            this.reCalcularFechas();
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
                    cmd.Parameters.Add(new SqlParameter("@diaInicio", Convert.ToDateTime(fechas[i*2].ToString())));
                    cmd.Parameters.Add(new SqlParameter("@diaFin", Convert.ToDateTime(fechas[i*2+1].ToString())));
                    cmd.Parameters.Add(new SqlParameter("@dias", Convert.ToInt32("" + dataGridViewEspecificaciones.Rows[i].Cells[4].Value)));
                    cmd.Parameters.Add(new SqlParameter("@cumplido", (Convert.ToBoolean("" + dataGridViewEspecificaciones.Rows[i].Cells[5].Value)) ? 1 : 0));


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


        private void reCalcularFechas()
        {

            if(fechaInicial != null && !esta_recalculando)
            {
                esta_recalculando = true;
                fechas.Clear();
                Fecha fechaDinamica = new Fecha(fechaInicial.Dia, fechaInicial.Mes, fechaInicial.Anio);


                for (int i = 0; i < dataGridViewEspecificaciones.Rows.Count - 1; i++)
                {
                    //MessageBox.Show(""+dataGridViewEspecificaciones.Rows[i].Cells[4].Value);
                    fechas.Add(fechaDinamica);

                    int dias = Convert.ToInt32(""+dataGridViewEspecificaciones.Rows[i].Cells[4].Value);
                    dataGridViewEspecificaciones.Rows[i].Cells[2].Value = fechaDinamica.Dia + " " + Program.str.diccionario["de"] + " " + Fecha.convertirNumeroAMes(fechaDinamica.Mes);
                    fechaDinamica = fechaDinamica.adelantarFecha(dias);
                    dataGridViewEspecificaciones.Rows[i].Cells[3].Value = fechaDinamica.Dia + " " + Program.str.diccionario["de"] + " " + Fecha.convertirNumeroAMes(fechaDinamica.Mes);

                    fechas.Add(fechaDinamica);
                }
                //Console.WriteLine("+");
                /*
                foreach (var item in fechas)
                {
                    Console.WriteLine(item.ToString());
                }*/
                esta_recalculando = false;
            }
            

        }

        private void celdaClick(object sender, DataGridViewCellEventArgs e)
        {

            this.reCalcularFechas();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.reCalcularFechas();
        }
    }
}
