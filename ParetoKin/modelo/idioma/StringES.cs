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


            // titulos ventanas
            diccionarioES.Add("msgGuardarSalir", "¿Desea guardar los cambios realizados antes de salir?");
            diccionarioES.Add("tituloCambiosRealizados", "Cambios sin guardar");


            // diccionarioES.Add("", "");
    }





    }
}
