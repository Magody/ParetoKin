using ParetoKin.modelo.idioma;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParetoKin
{
    public static class Program
    {

        public static StringMain str;
        public static string CONECCION_STRING = "Data Source=DESKTOP-U6QA500;Initial Catalog=Paretto;Integrated Security=True";


        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            modelo.Fecha test;


            using (var conn = new SqlConnection(Program.CONECCION_STRING))
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand("select diaInicio from EspecificacionTarea;", conn);
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    rdr.Read();
                    string f = rdr["diaInicio"].ToString();
                    string[] fecha = f.Split(' ')[0].Split('/'); //mm-dd-yy
                    test = new modelo.Fecha(Convert.ToInt32(fecha[1]), Convert.ToInt32(fecha[0]), Convert.ToInt32(fecha[2]));
                    //test = new modelo.Fecha(1, 1, Convert.ToInt32(fecha[2])+1);

                }
                conn.Close();
            }
            //MessageBox.Show(test.Dia + " - " + test.Mes + " - " + test.Anio);
            MessageBox.Show(test.adelantarFecha(365).ToString());



            //str = new StringMain(StringMain.IDIOMA_ESPANOL);
            //Application.Run(new VistaPrincipal());
        }
    }
}
