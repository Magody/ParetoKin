using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParetoKin.modelo
{
    public class Hora
    {

        private int hora;
        private int minutos;
        private int segundos;


        public Hora(int hora, int minutos, int segundos)
        {
            this.hora = hora;
            this.minutos = minutos;
            this.segundos = segundos;

        }

        public void adelantarMinutos(int minutos)
        {
           
            int copia_minutos = minutos + this.minutos;
            while(copia_minutos >= 60)
            {
                this.hora += 1;
                if(this.hora == 25)
                {
                    this.hora = 1;
                }
                copia_minutos -= 60;
            }
            //la hora está ajustada
            this.minutos = copia_minutos;

        }


        public int HoraT { get { return hora; } set { this.hora = value; } }
        public int Minutos { get { return minutos; } set { this.minutos = value; } }
        public int Segundos { get { return segundos; } set { this.segundos = value; } }

        override
        public string ToString()
        {
            string hora_string = (this.hora < 10) ? "0" + this.hora : ""+this.hora;
            string minutos_string = (this.minutos < 10) ? "0" + this.minutos : "" + this.minutos;
            string segundos_string = (this.segundos < 10) ? "0" + this.segundos : "" + this.segundos;


            return hora_string  + ":" + minutos_string + ":" + segundos_string;
        }

    }
}
