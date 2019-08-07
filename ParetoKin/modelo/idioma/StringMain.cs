using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParetoKin.modelo.idioma
{
    public class StringMain
    {
        public static string IDIOMA_ESPANOL = "Español";

        public Dictionary<string, string> diccionario;
        public StringMain(string idioma)
        {
            
            if (idioma == IDIOMA_ESPANOL)
            {
                diccionario = new StringES().diccionarioES;
            }
        }




    }
}
