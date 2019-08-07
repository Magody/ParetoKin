using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParetoKin.modelo
{
    public class Tarea
    {
        private int numero;
        private string nombre;
        private string descripcion;
        private bool importante;
        private bool urgente;
        private DateTime fechaInicio;

        public Tarea(int numero, string nombre, string descripcion, bool importante, bool urgente, DateTime fechaInicio)
        {
            this.numero = numero;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.importante = importante;
            this.urgente = urgente;
            this.fechaInicio = fechaInicio;
        }
        public int Numero { get { return numero; } set { this.numero = value; } }

        public string Nombre {get{ return nombre; } set { this.nombre = value; } }
        public string Descripcion { get { return descripcion; } set { this.descripcion = value; } }
        public bool Importante { get { return importante; } set { this.importante = value; } }
        public bool Urgente { get { return urgente; } set { this.urgente = value; } }
        public DateTime FechaInicio { get { return fechaInicio; } set { this.fechaInicio = value; } }





    }
}
