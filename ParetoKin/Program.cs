using ParetoKin.modelo;
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
            //MessageBox.Show(new Fecha(6,6,2019).adelantarFecha(1).ToString());
            
            str = new StringMain(StringMain.IDIOMA_ESPANOL);
            Application.Run(new VistaPrincipal());
        }
    }
}
