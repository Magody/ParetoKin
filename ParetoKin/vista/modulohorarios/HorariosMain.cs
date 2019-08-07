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

namespace ParetoKin.vista.modulohorarios
{
    public partial class HorariosMain : Form
    {
        VistaPrincipal padre;
        bool fue_modificado, hay_eliminacion;
        int idHorario = -1;
        private List<int> filasEliminadas;
        bool esta_recalculando;
        Color colorPreferidoHorario = Color.Aqua;
        Color colorSecundarioHorario = Color.White;

        public Hora horaInicial = new Hora(5, 0, 0);

        public HorariosMain(VistaPrincipal padre)
        {
            InitializeComponent();

            this.padre = padre;



            this.horaInicio.HeaderText = Program.str.diccionario["horaInicio"];
            this.horaFin.HeaderText = Program.str.diccionario["horaFin"];
            this.minutos.HeaderText = Program.str.diccionario["minutos"];
            this.lunes.HeaderText = Program.str.diccionario["lunes"];
            this.martes.HeaderText = Program.str.diccionario["martes"];
            this.miercoles.HeaderText = Program.str.diccionario["miercoles"];
            this.jueves.HeaderText = Program.str.diccionario["jueves"];
            this.viernes.HeaderText = Program.str.diccionario["viernes"];
            this.sabado.HeaderText = Program.str.diccionario["sabado"];
            this.domingo.HeaderText = Program.str.diccionario["domingo"];

            consultarHorario();
            fue_modificado = false;
            esta_recalculando = false;
            filasEliminadas = new List<int>();

            
        }

        public void consultarHorario()
        {
            dataGridViewHorario.Rows.Clear();
            using (var conn = new SqlConnection(Program.CONECCION_STRING))
            {
                conn.Open();

                // 1.  create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("consultarHorario", conn);

                // 2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;


                // execute the command
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    int i = 0;
                    while (rdr.Read())
                    {
                        if(i == 0)
                        {
                            string[] hora_split = rdr["horaInicio"].ToString().Split(':');
                            horaInicial = new Hora(Convert.ToInt32(hora_split[0]), Convert.ToInt32(hora_split[1]), Convert.ToInt32(hora_split[2]));
                            this.numericUpDownHora.Value = horaInicial.HoraT;
                            this.numericUpDownMinutos.Value = horaInicial.Minutos;

                        }
                        dataGridViewHorario.Rows.Add(rdr["horaInicio"].ToString(),
                            rdr["horaFin"].ToString(), Convert.ToInt32(rdr["minutos"].ToString()),
                            rdr["lunes"].ToString(), rdr["martes"].ToString(),
                            rdr["miercoles"].ToString(), rdr["jueves"].ToString(),
                            rdr["viernes"].ToString(), rdr["sabado"].ToString(),
                            rdr["domingo"].ToString(), Convert.ToInt32(rdr["id"].ToString()));

                        pintarCeldas(i);

                        i++;
                    }
                }

                conn.Close();
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

            }
            else
            {
                this.Close();
            }
        }

        private void ButtonGuardarCambios_Click(object sender, EventArgs e)
        {
            guardarCambios();
        }

        public void eliminarPendientes()
        {
            using (var conn = new SqlConnection(Program.CONECCION_STRING))
            {


                for (int i = 0; i < filasEliminadas.Count; i++)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("eliminarHorario", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@id", filasEliminadas[i]));

                    cmd.ExecuteReader();
                    conn.Close();
                }
            }
            filasEliminadas.Clear();
        }

        private bool minutosValidos()
        {

            for (int i = 0; i < dataGridViewHorario.Rows.Count - 1; i++)
            {


                if ("" + dataGridViewHorario.Rows[i].Cells[2].Value == "")
                {
                    if(i + 1 != dataGridViewHorario.Rows.Count - 1)
                    {
                        dataGridViewHorario.Rows[i].Cells[2].Value = "1";
                        return false;
                    }
                    else
                    {
                        dataGridViewHorario.Rows[i].Cells[2].Value = "60";
                    }
                }

                int minutos = Convert.ToInt32("" + dataGridViewHorario.Rows[i].Cells[2].Value);

                if(minutos < 1)
                {
                    dataGridViewHorario.Rows[i].Cells[2].Value = "1";
                    return false;
                }
            }
            return true;
        }

        private void recalcularTiempos()
        {
            if (!esta_recalculando)
            {

                if (minutosValidos())
                {
                    esta_recalculando = true;
                    //hora inicial de referencia
                    Hora horaDinamica = new Hora(horaInicial.HoraT, horaInicial.Minutos, horaInicial.Segundos);

                    for (int i = 0; i < dataGridViewHorario.Rows.Count - 1; i++)
                    {


                        if ("" + dataGridViewHorario.Rows[i].Cells[2].Value == "")
                        {
                            this.dataGridViewHorario.Rows[i].Cells[2].Value = "60";
                        }

                        int minutos = Convert.ToInt32("" + dataGridViewHorario.Rows[i].Cells[2].Value);

                        dataGridViewHorario.Rows[i].Cells[0].Value = horaDinamica.ToString();
                        horaDinamica.adelantarMinutos(minutos);
                        dataGridViewHorario.Rows[i].Cells[1].Value = horaDinamica.ToString();

                        pintarCeldas(i);
                    }
                    esta_recalculando = false;
                }
                else
                {
                    MessageBox.Show(Program.str.diccionario["msgLosMinutosDebenSerMayoresA0"]);
                }

                
            }
            
        }

        public void pintarCeldas(int indice)
        {
            if (indice % 2 == 0)
            {

                for (int j = 0; j < dataGridViewHorario.Columns.Count - 1; j++)
                {
                    dataGridViewHorario.Rows[indice].Cells[j].Style.BackColor = colorPreferidoHorario;
                }

            }
            else
            {

                for (int j = 0; j < dataGridViewHorario.Columns.Count - 1; j++)
                {
                    dataGridViewHorario.Rows[indice].Cells[j].Style.BackColor = colorSecundarioHorario;
                }
            }
        }

        public void actualizarCrearHorarios()
        {

            using (var conn = new SqlConnection(Program.CONECCION_STRING))
            {


                for (int i = 0; i < dataGridViewHorario.Rows.Count - 1; i++)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("actualizarOCrearHorario", conn);
                    cmd.CommandType = CommandType.StoredProcedure;





                    string id = "" + dataGridViewHorario.Rows[i].Cells[10].Value;
                    if (id == "")
                    {
                        cmd.Parameters.Add(new SqlParameter("@id", -1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@id", Convert.ToInt32(id)));
                    }
                    cmd.Parameters.Add(new SqlParameter("@horaInicio", "" + dataGridViewHorario.Rows[i].Cells[0].Value));
                    cmd.Parameters.Add(new SqlParameter("@horaFin", "" + dataGridViewHorario.Rows[i].Cells[1].Value));
                    cmd.Parameters.Add(new SqlParameter("@minutos", Convert.ToInt32(""+dataGridViewHorario.Rows[i].Cells[2].Value)));
                    cmd.Parameters.Add(new SqlParameter("@lunes", "" + dataGridViewHorario.Rows[i].Cells[3].Value));
                    cmd.Parameters.Add(new SqlParameter("@martes", "" + dataGridViewHorario.Rows[i].Cells[4].Value));
                    cmd.Parameters.Add(new SqlParameter("@miercoles", "" + dataGridViewHorario.Rows[i].Cells[5].Value));
                    cmd.Parameters.Add(new SqlParameter("@jueves", "" + dataGridViewHorario.Rows[i].Cells[6].Value));
                    cmd.Parameters.Add(new SqlParameter("@viernes", "" + dataGridViewHorario.Rows[i].Cells[7].Value));
                    cmd.Parameters.Add(new SqlParameter("@sabado", "" + dataGridViewHorario.Rows[i].Cells[8].Value));
                    cmd.Parameters.Add(new SqlParameter("@domingo", "" + dataGridViewHorario.Rows[i].Cells[9].Value));



                    cmd.ExecuteReader();
                    conn.Close();
                }
            }


        }


        public void guardarCambios()
        {
            this.fue_modificado = false;
            actualizarCrearHorarios();

            if (hay_eliminacion)
            {
                eliminarPendientes();
            }


            this.hay_eliminacion = false;
            MessageBox.Show(Program.str.diccionario["msgCambiosGuardadosExitosamente"]);
        }

        private void celdaEditada(object sender, DataGridViewCellEventArgs e)
        {
            this.fue_modificado = true;
        }

        private void filaEliminada(object sender, DataGridViewRowEventArgs e)
        {

            if (idHorario > 0)
            {
                this.fue_modificado = true;
                this.hay_eliminacion = true;
                filasEliminadas.Add(idHorario);
                recalcularTiempos();
            }
        }

        private void filaAgregada(object sender, DataGridViewRowEventArgs e)
        {
            recalcularTiempos();
        }

        private void ButtonAjustar_Click(object sender, EventArgs e)
        {
            this.horaInicial.HoraT = Convert.ToInt32(this.numericUpDownHora.Value);
            this.horaInicial.Minutos = Convert.ToInt32(this.numericUpDownMinutos.Value);
            this.fue_modificado = true;
            recalcularTiempos();
        }

        private void celdaClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.idHorario = Convert.ToInt32(this.dataGridViewHorario.Rows[dataGridViewHorario.CurrentRow.Index].Cells[10].Value);
                recalcularTiempos();
                //MessageBox.Show(""+this.idHorario);
            }
        }
    }
}
