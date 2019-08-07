using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParetoKin.modelo
{
    public class EspecificacionTarea
    {
        private int id;
        private int numero;
        private string especificacion;
        private string diaInicio;
        private string diaFin;
        private int dias;
        private bool cumplido;

        public EspecificacionTarea(int id, int numero, string especificacion, string diaInicio, string diaFin, int dias, bool cumplido)
        {
            this.id = id;
            this.numero = numero;
            this.especificacion = especificacion;
            this.diaInicio = diaInicio;
            this.diaFin = diaFin;
            this.dias = dias;
            this.cumplido = cumplido;
        }
        public int Numero { get { return numero; } set { this.numero = value; } }

        public int Id { get { return id; } set { this.id = value; } }
        public string Especificacion { get { return especificacion; } set { this.especificacion = value; } }
        public string DiaInicio { get { return diaInicio; } set { this.diaInicio = value; } }
        public string DiaFin { get { return diaFin; } set { this.diaFin = value; } }
        public int Dias { get { return dias; } set { this.dias = value; } }
        public bool Cumplido { get { return cumplido; } set { this.cumplido = value; } }


    }
}
