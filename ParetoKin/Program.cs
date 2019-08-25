using ParetoKin.modelo;
using ParetoKin.modelo.idioma;
using ParetoKin.vista;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParetoKin
{
    public static class Program
    {

        public static StringMain str;
        public static string CONECCION_STRING = "Data Source=USER-PC\\SQLEXPRESS;Initial Catalog=Paretto;Integrated Security=True";
        public static Color colorEdicionPermitidaTexto = Color.FromArgb(15, 17, 97);
        public static Color colorEdicionPermitidaSeleccion = Color.FromArgb(243, 245, 230);
        public static Color colorBotonGenerico = Color.FromArgb(224, 224, 224);
        public static Color colorBotonSeleccionado = Color.LightGreen;




        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //MessageBox.Show(new Fecha(6,6,2019).adelantarFecha(1).ToString());
            //MessageBox.Show(new Fecha(7, 8, 2019).retrocederFecha(31).ToString());

            




            str = new StringMain(StringMain.IDIOMA_ESPANOL);
            //Application.Run(new Loggin());
            Application.Run(new VistaPrincipal(new Loggin()));
        }
    }
}
