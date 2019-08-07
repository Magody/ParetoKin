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
    public partial class TareasMain : Form
    {
        private bool fue_modificado;
        private int numTarea = -1;
        private bool hay_eliminacion;
        List<int> tareasPendientes;
        VistaPrincipal padre;

        public TareasMain(VistaPrincipal padre)
        {
            InitializeComponent();
            this.buttonGuardarCambios.Text = Program.str.diccionario["buttonGuardarCambios"];
            this.buttonCerrar.Text = Program.str.diccionario["buttonCerrar"];
            this.labelFiltrarPorNombre.Text = Program.str.diccionario["labelFiltrarPorNombre"];

            this.nombreTarea.HeaderText = Program.str.diccionario["nombreTarea"];
            this.descripcionTarea.HeaderText = Program.str.diccionario["descripcionTarea"];
            this.importanciaTarea.HeaderText = Program.str.diccionario["importanciaTarea"];
            this.urgenciaTarea.HeaderText = Program.str.diccionario["urgenciaTarea"];

            tareasPendientes = new List<int>();
            mostrarTareas(false);
            this.padre = padre;

            this.fue_modificado = false;
            this.hay_eliminacion = false;

        }


        public List<Tarea> buscarTareaLikeNombre()
        {
            List<Tarea> tareas = new List<Tarea>();
            using (var conn = new SqlConnection(Program.CONECCION_STRING))
            {
                conn.Open();

                // 1.  create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("buscarTareaLikeNombre", conn);

                // 2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@nombre", this.textBoxNombre.Text));


                // execute the command
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    // iterate through results, printing each to console
                    while (rdr.Read())
                    {

                        tareas.Add(new Tarea(Convert.ToInt32(rdr["numero"].ToString()), rdr["nombre"].ToString(), rdr["descripcion"].ToString(),
                            Convert.ToBoolean(rdr["importante"].ToString().ToLower()),
                            Convert.ToBoolean(rdr["urgente"].ToString().ToLower()),
                            Convert.ToDateTime(rdr["fechaInicio"].ToString())
                            ));


                        //Console.WriteLine("Product: {0,-35} Total: {1,2}", rdr["nombrePlato"], rdr["precioPlato"]);
                    }
                }

                conn.Close();
            }
            return tareas;
        }





        public List<Tarea> consultarTareas()
        {
            List<Tarea> tareas = new List<Tarea>();

            using (var conn = new SqlConnection(Program.CONECCION_STRING))
            {
                conn.Open();

                // 1.  create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("consultarTareas", conn);

                // 2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;


                // execute the command
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    // iterate through results, printing each to console
                    while (rdr.Read())
                    {

                        tareas.Add(new Tarea(Convert.ToInt32(rdr["numero"].ToString()), rdr["nombre"].ToString(), rdr["descripcion"].ToString(),
                            Convert.ToBoolean(rdr["importante"].ToString().ToLower()),
                            Convert.ToBoolean(rdr["urgente"].ToString().ToLower()),
                            Convert.ToDateTime(rdr["fechaInicio"].ToString())
                            ));


                        //Console.WriteLine("Product: {0,-35} Total: {1,2}", rdr["nombrePlato"], rdr["precioPlato"]);
                    }
                }

                conn.Close();
            }

            return tareas;

        }

        public void actualizarCrearTareas()
        {
            
            using (var conn = new SqlConnection(Program.CONECCION_STRING))
            {
                

                for (int i = 0; i < dataGridViewListaTareas.Rows.Count-1; i++)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("actualizarOCrearTarea", conn);
                    cmd.CommandType = CommandType.StoredProcedure;


                    string numero = ""+dataGridViewListaTareas.Rows[i].Cells[5].Value;
                    if (numero == "")
                    {
                        cmd.Parameters.Add(new SqlParameter("@numero", -1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@numero", Convert.ToInt32(numero)));
                    }
                    cmd.Parameters.Add(new SqlParameter("@nombre", "" + dataGridViewListaTareas.Rows[i].Cells[0].Value));
                    cmd.Parameters.Add(new SqlParameter("@descripcion", "" + dataGridViewListaTareas.Rows[i].Cells[1].Value));
                    cmd.Parameters.Add(new SqlParameter("@importante", (Convert.ToBoolean(dataGridViewListaTareas.Rows[i].Cells[2].Value))? 1:0));
                    cmd.Parameters.Add(new SqlParameter("@urgente", (Convert.ToBoolean(dataGridViewListaTareas.Rows[i].Cells[3].Value))? 1:0));
                    cmd.Parameters.Add(new SqlParameter("@fechaInicio", (Convert.ToBoolean(dataGridViewListaTareas.Rows[i].Cells[4].Value)) ? 1 : 0));

                    cmd.ExecuteReader();
                    conn.Close();
                }
            }


        }

        public void eliminarPendientes()
        {
            using (var conn = new SqlConnection(Program.CONECCION_STRING))
            {


                for (int i = 0; i < tareasPendientes.Count; i++)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("eliminarTarea", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@numero", tareasPendientes[i]));
                   
                    cmd.ExecuteReader();
                    conn.Close();
                }
            }
            tareasPendientes.Clear();
        }

        public void guardarCambios()
        {
            this.fue_modificado = false;
            actualizarCrearTareas();

            if (hay_eliminacion)
            {
                eliminarPendientes();
            }


            this.hay_eliminacion = false;
            MessageBox.Show("Cambios guardados exitosamente");
        }

        public void mostrarTareas(bool es_busqueda)
        {
            dataGridViewListaTareas.Rows.Clear();
            List<Tarea> lista_tareas;
            if (es_busqueda)
                lista_tareas = buscarTareaLikeNombre();
            else
                lista_tareas = consultarTareas();


            for (int i = 0; i < lista_tareas.Count; i++)
            {

                dataGridViewListaTareas.Rows.Add(lista_tareas[i].Nombre, lista_tareas[i].Descripcion, lista_tareas[i].Importante, lista_tareas[i].Urgente,  lista_tareas[i].FechaInicio, lista_tareas[i].Numero);

            }
        }


        private void ButtonCancelar_Click(object sender, EventArgs e)
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
       


        private void visualizarTareaDetalles(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                numTarea = Convert.ToInt32(this.dataGridViewListaTareas.Rows[dataGridViewListaTareas.CurrentRow.Index].Cells[5].Value);

                this.Hide();
                padre.form_generico = new TareaDetallada(this, numTarea, ""+ this.dataGridViewListaTareas.Rows[dataGridViewListaTareas.CurrentRow.Index].Cells[4].Value) { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
                padre.panelGenerico.Controls.Add(padre.form_generico);
                padre.form_generico.Show();
            }

        }

        private void celdaEditada(object sender, DataGridViewCellEventArgs e)
        {
            this.fue_modificado = true;
            
        }

        private void ButtonGuardarCambios_Click(object sender, EventArgs e)
        {
            guardarCambios();
        }

        private void busquedaTareas(object sender, KeyEventArgs e)
        {
            this.mostrarTareas(true);
        }

        private void celdaClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.numTarea = Convert.ToInt32(this.dataGridViewListaTareas.Rows[dataGridViewListaTareas.CurrentRow.Index].Cells[5].Value);

            }
        }

        private void filaEliminada(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if(numTarea != -1)
            {
                this.fue_modificado = true;
                this.hay_eliminacion = true;
                tareasPendientes.Add(numTarea);
            }
            
        }
    }
}
