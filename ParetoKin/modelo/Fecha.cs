using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParetoKin.modelo
{
    public class Fecha
    {

        public static int DIAS_ENERO = 31;
        public static int DIAS_FEBRERO = 28;
        public static int DIAS_MARZO = 31;
        public static int DIAS_ABRIL = 30;
        public static int DIAS_MAYO = 31;
        public static int DIAS_JUNIO = 30;
        public static int DIAS_JULIO = 31;
        public static int DIAS_AGOSTO = 31;
        public static int DIAS_SEPTIEMBRE = 30;
        public static int DIAS_OCTUBRE = 31;
        public static int DIAS_NOVIEMBRE = 30;
        public static int DIAS_DICIEMBRE = 31;


        private int dia;
        private int mes;
        private int anio;

        public Fecha(int dia, int mes, int anio)
        {
            this.dia = dia;
            this.mes = mes;
            this.anio = anio;
        }

        public int Dia { get { return dia; } set { this.dia = value; } }
        public int Mes { get { return mes; } set { this.mes = value; } }
        public int Anio { get { return anio; } set { this.anio = value; } }


        public int calcularDiasCon(Fecha fechaSiguiente)
        {
            int dias_distancia = 0;
            int anio_carrera = this.anio;

            if (fechaActualEsMenor(fechaSiguiente))
            {
                bool iteracion_primera = true;
                while(anio_carrera < fechaSiguiente.anio)
                {
                    int dias_anio = Fecha.esAnioBisiesto(this.anio) ? 366 : 365;

                    if (iteracion_primera)
                        dias_distancia += (dias_anio - this.obtenerDiaNetoEnElAnio() + 1); // se suma uno porque queremos llegar a enero 1, Ejemplo 6/8/2019 = 218, entonces 365 - 218
                    else
                        dias_distancia += dias_anio;

                    anio_carrera += 1;
                    //se reinicia porque me adelante intrépidamente
                    iteracion_primera = false;
                }
                //ahora estamos en el mismo anio, si el mes es anterior entonces el anio siguiente era mayor
                //actualmente el mes es mayor al nuestro ya sea si fue el mismo anio desde un inicio o el anio siguiente

                dias_distancia += (fechaSiguiente.obtenerDiaNetoEnElAnio() - 1); //se compensa el restante de los dias de forma inmediata

            }
            else
            {
                return -1;
            }

            return dias_distancia;
        }

        public bool fechaActualEsMenor(Fecha fechaSiguiente)
        {

            if (this.anio < fechaSiguiente.anio)
            {
                return true;
            }else if (this.anio > fechaSiguiente.anio)
            {
                return false;
            }
            else if (this.anio == fechaSiguiente.anio)
            {
                if (this.mes < fechaSiguiente.mes)
                {
                    return true;
                }
                else if (this.mes > fechaSiguiente.mes)
                {
                    return false;
                }
                else if (this.mes == fechaSiguiente.mes)
                {
                    if (this.dia < fechaSiguiente.dia)
                    {
                        return true;
                    }
                    else if (this.dia > fechaSiguiente.dia)
                    {
                        return false;
                    }
                    else if (this.dia == fechaSiguiente.dia)
                    {
                        return false;
                    }
                }
            }




            return false;
        }

        public static bool esAnioBisiesto(int anio)
        {
            bool es_bisiesto = false;

            if(anio % 4 == 0)
            {
                
                if (anio % 100 == 0)
                {
                    if (anio % 400 == 0)
                        es_bisiesto = true;
                    else
                        es_bisiesto = false;
                }
                else 
                {
                    es_bisiesto = true;
                }
                
            }

            return es_bisiesto;
        }

        public static int obtenerDiasMes(int mes, int anio)
        {
            switch (mes)
            {
                case 1:
                    return 31;
                case 2:
                    return esAnioBisiesto(anio) ? 29:28;
                case 3:
                    return 31;
                case 4:
                    return 30;
                case 5:
                    return 31;
                case 6:
                    return 30;
                case 7:
                    return 31;
                case 8:
                    return 31;
                case 9:
                    return 30;
                case 10:
                    return 31;
                case 11:
                    return 30;
                case 12:
                    return 31;
                default:
                    return -1;
            }
        }

        public int obtenerDiaNetoEnElAnio()
        {
            int dia = 0;

            for (int i = 1; i < this.mes; i++)
            {
                dia += obtenerDiasMes(i, this.anio);
            }

            dia += this.dia;

            return dia;
        }


        public Fecha adelantarFecha(int dias)
        {
            int copia_dias = dias;
            Fecha nuevaFecha = new Fecha(this.dia, this.mes, this.anio);

            bool primera_iteracion = true;
            while(copia_dias >= 365)
            {
                int dias_anio = esAnioBisiesto(nuevaFecha.anio) ? 366 : 365;

                if(primera_iteracion)
                    copia_dias -= (dias_anio - this.obtenerDiaNetoEnElAnio() + 1);
                else
                    copia_dias -= dias_anio - this.obtenerDiaNetoEnElAnio();

                nuevaFecha.anio += 1;

                primera_iteracion = false;

                nuevaFecha.dia = 1;
                nuevaFecha.mes = 1;

            }
            //el año fue igualado al que se quiere llegar, solo falta los meses

            for (int i = 1; ; i++)
            {
                int dias_mes = obtenerDiasMes(i, nuevaFecha.anio);

                if(copia_dias < dias_mes)
                {
                    break;
                }

                nuevaFecha.mes = aumentarMes(nuevaFecha.mes, 1);  // el giro del reloj
                copia_dias -= dias_mes;
            }

            int dias_mes_actual = obtenerDiasMes(nuevaFecha.Mes, nuevaFecha.anio);
            if (nuevaFecha.dia + copia_dias > dias_mes_actual)
            {
                nuevaFecha.mes = aumentarMes(nuevaFecha.mes, 1);
            }


            nuevaFecha.dia = (nuevaFecha.dia+copia_dias)% dias_mes_actual;

            return nuevaFecha;

        }

        public int aumentarMes(int mes_actual, int cantidad)
        {
            int m = (mes_actual + cantidad) % 12;
            return (m == 0)? 12: m;
        }


        public Fecha retrocederFecha(int dias)
        {
            
            int copia_dias = dias;
            Fecha nuevaFecha = new Fecha(this.dia, this.mes, this.anio);


            
            while (copia_dias >= 365)
            {
                int dias_anio = esAnioBisiesto(nuevaFecha.anio) ? 366 : 365;

                copia_dias -= dias_anio;

                nuevaFecha.anio -= 1;

            }
            //el año aun no ha sido igualado del todo, hace falta revisar si el dia actual es mayor o menor


            int dia_neto_actual = this.obtenerDiaNetoEnElAnio();



            if (copia_dias >= dia_neto_actual)
            {
                
                copia_dias -= dia_neto_actual;

                nuevaFecha.anio -= 1;
                nuevaFecha.mes = 12;
                nuevaFecha.dia = 31;

            }


            for (int i = nuevaFecha.mes; ; i--)
            {
                int dias_mes = obtenerDiasMes(i, nuevaFecha.anio);

                if (copia_dias < dias_mes)
                {
                    break;
                }

                nuevaFecha.mes -= 1;

                copia_dias -= dias_mes;
            }


            nuevaFecha.dia -= copia_dias;

            return nuevaFecha;

        }


        public static Fecha convertirDateTimeAFecha(string dateTime)
        {
            string[] fecha_split = dateTime.Split(' ')[0].Split('/'); //mm-dd-yy
            return new Fecha(Convert.ToInt32(fecha_split[0]), Convert.ToInt32(fecha_split[1]), Convert.ToInt32(fecha_split[2]));
              
        }

        public static Fecha convertirDateTimeMMDDYYAFecha(string dateTime)
        {
            string[] fecha_split = dateTime.Split(' ')[0].Split('/'); //mm-dd-yy
            return new Fecha(Convert.ToInt32(fecha_split[1]), Convert.ToInt32(fecha_split[0]), Convert.ToInt32(fecha_split[2]));

        }
        public static string convertirNumeroAMes(int mes)
        {
            switch (mes)
            {
                case 1:
                    return Program.str.diccionario["Enero"];
                case 2:
                    return Program.str.diccionario["Febrero"];
                case 3:
                    return Program.str.diccionario["Marzo"];
                case 4:
                    return Program.str.diccionario["Abril"];
                case 5:
                    return Program.str.diccionario["Mayo"];
                case 6:
                    return Program.str.diccionario["Junio"];
                case 7:
                    return Program.str.diccionario["Julio"];
                case 8:
                    return Program.str.diccionario["Agosto"];
                case 9:
                    return Program.str.diccionario["Septiembre"];
                case 10:
                    return Program.str.diccionario["Octubre"];
                case 11:
                    return Program.str.diccionario["Noviembre"];
                case 12:
                    return Program.str.diccionario["Diciembre"];
                default:
                    return "";
            }
        }

        public static string day2dia(string day)
        {
            switch (day)
            {

                case "Monday":
                    return Program.str.diccionario["lunes"];
                case "Tuesday":
                    return Program.str.diccionario["martes"];
                case "Wednesday":
                    return Program.str.diccionario["miercoles"];
                case "Thursday":
                    return Program.str.diccionario["jueves"];
                case "Friday":
                    return Program.str.diccionario["viernes"];
                case "Saturday":
                    return Program.str.diccionario["sabado"];
                case "Sunday":
                    return Program.str.diccionario["domingo"];


                default:
                    return Program.str.diccionario["Hoy"];
            }

        }


        public static string month2mes(int mes)
        {
            switch (mes)
            {

                case 1:
                    return Program.str.diccionario["Enero"];
                case 2:
                    return Program.str.diccionario["Febrero"];
                case 3:
                    return Program.str.diccionario["Marzo"];
                case 4:
                    return Program.str.diccionario["Abril"];
                case 5:
                    return Program.str.diccionario["Mayo"];
                case 6:
                    return Program.str.diccionario["Junio"];
                case 7:
                    return Program.str.diccionario["Julio"];
                case 8:
                    return Program.str.diccionario["Agosto"];
                case 9:
                    return Program.str.diccionario["Septiembre"];
                case 10:
                    return Program.str.diccionario["Octubre"];
                case 11:
                    return Program.str.diccionario["Noviembre"];
                case 12:
                    return Program.str.diccionario["Diciembre"];
                default:
                    return Program.str.diccionario["Hoy"];
            }

        }

        public string ToStringMMDDYYYY()
        {
            return this.mes + "-" + this.dia + "-" + this.anio;
        }


        public string ToStringReves()
        {
            return this.anio + "-" + this.mes + "-" + this.dia;
        }


        override
        public string ToString()
        {
            return this.dia+"-"+this.mes+"-"+this.anio;
        }

    }
}
