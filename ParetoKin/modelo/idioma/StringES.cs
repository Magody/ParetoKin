using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParetoKin.modelo.idioma
{
    public class StringES
    {
        public Dictionary<string, string> diccionarioES;


        public StringES()
        {
            diccionarioES = new Dictionary<string, string>();
            // Botones
            diccionarioES.Add("buttonSalir", "Salir");
            diccionarioES.Add("buttonCerrar", "Cerrar");
            diccionarioES.Add("buttonTareas", "Tareas");
            diccionarioES.Add("buttonGuardarCambios", "Guardar cambios");
            diccionarioES.Add("buttonCancelar", "Cancelar");

            // Etiquetas
            diccionarioES.Add("labelFiltrarPorNombre", "Filtrar por nombre");


            // headers Text
            diccionarioES.Add("nombreTarea", "Nombre de la tarea");
            diccionarioES.Add("descripcionTarea", "Descripción");
            diccionarioES.Add("importanciaTarea", "Importante");
            diccionarioES.Add("urgenciaTarea", "Urgente");

            diccionarioES.Add("numeroEspecificacion", "Número");
            diccionarioES.Add("especificacion", "Acción");
            diccionarioES.Add("fechaInicio", "Desde");
            diccionarioES.Add("fechaFin", "Hasta");
            diccionarioES.Add("dias", "Días");
            diccionarioES.Add("cumplido", "Cumplido");



            // titulos ventanas
            diccionarioES.Add("msgGuardarSalir", "¿Desea guardar los cambios realizados antes de salir?");
            diccionarioES.Add("tituloCambiosRealizados", "Cambios sin guardar");


            //meses
            diccionarioES.Add("Enero", "Enero");
            diccionarioES.Add("Febrero", "Febrero");
            diccionarioES.Add("Marzo", "Marzo");
            diccionarioES.Add("Abril", "Abril");
            diccionarioES.Add("Mayo", "Mayo");
            diccionarioES.Add("Junio", "Junio");
            diccionarioES.Add("Julio", "Julio");
            diccionarioES.Add("Agosto", "Agosto");
            diccionarioES.Add("Septiembre", "Septiembre");
            diccionarioES.Add("Octubre", "Octubre");
            diccionarioES.Add("Noviembre", "Noviembre");
            diccionarioES.Add("Diciembre", "Diciembre");

            //preposiciones

            diccionarioES.Add("de", "de");


            // diccionarioES.Add("", "");
        }





    }
}
