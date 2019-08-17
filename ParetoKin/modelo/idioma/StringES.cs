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
            diccionarioES.Add("buttonIngresar", "Ingresar");
            diccionarioES.Add("buttonCerrar", "Cerrar");
            diccionarioES.Add("buttonCerrarSesion", "Cerrar sesión");
            diccionarioES.Add("buttonTareas", "Tareas");
            diccionarioES.Add("buttonGuardarCambios", "Guardar cambios");
            diccionarioES.Add("buttonCancelar", "Cancelar");
            diccionarioES.Add("buttonHorarios", "Horarios");
            diccionarioES.Add("buttonMatriz", "Matriz de prioridades");



            // Etiquetas
            diccionarioES.Add("labelFiltrarPorNombre", "Filtrar por nombre");
            diccionarioES.Add("labelImportante", "Importante");
            diccionarioES.Add("labelNoImportante", "No importante");
            diccionarioES.Add("labelUrgente", "Urgente");
            diccionarioES.Add("labelNoUrgente", "No urgente");
            diccionarioES.Add("labelUser", "Usuario");
            diccionarioES.Add("labelPassword", "Contraseña");
            diccionarioES.Add("labelAprender", "Aprender");
            diccionarioES.Add("labelPracticar", "Practicar");
            diccionarioES.Add("labelAplicar", "Aplicar");
            diccionarioES.Add("labelAdvertenciaFechaExcedida", "Los valores de feha marcados en rojo, significan que se ha excedido de la fecha de finalización.");

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

            diccionarioES.Add("horaInicio", "Inicio");
            diccionarioES.Add("horaFin", "Fin");
            diccionarioES.Add("minutos", "Minutos");
            diccionarioES.Add("lunes", "Lunes");
            diccionarioES.Add("martes", "Martes");
            diccionarioES.Add("miercoles", "Miércoles");
            diccionarioES.Add("jueves", "Jueves");
            diccionarioES.Add("viernes", "Viernes");
            diccionarioES.Add("sabado", "Sábado");
            diccionarioES.Add("domingo", "Domingo");

            diccionarioES.Add("nombreTareaUrgenteImportante", "Tareas urgentes e importantes");
            diccionarioES.Add("tareasNoImportantesNoUrgentes", "Tareas sin urgencia ni importancia");
            diccionarioES.Add("tareasNoImportantesSiUrgentes", "Tareas urgentes pero no importantes");
            diccionarioES.Add("tareasNoUrgentesSiImportantes", "Tareas importantes pero no urgentes");

            diccionarioES.Add("actividadVacacion", "Actividad del día");



            // titulos y ventanas
            diccionarioES.Add("msgGuardarSalir", "¿Desea guardar los cambios realizados antes de salir?");
            diccionarioES.Add("tituloCambiosRealizados", "Cambios sin guardar");
            diccionarioES.Add("msgCambiosGuardadosExitosamente", "Cambios guardados exitosamente");
            diccionarioES.Add("msgLosMinutosDebenSerMayoresA0", "¡Los minutos deben ser mayores a 0!");
            diccionarioES.Add("msgFechaSinElFormatoValido", "Las fechas deben tener el formato dd/mm/aaaa hh:mm:ss(opcional)\nEjemplo: para el 4 de Mayo de 1990 en el medio día\n04/05/1990 12:00:00\nO también, 04/05/1990");
            diccionarioES.Add("msgContraseniaIncorrecta", "Contraseña incorrecta");
            diccionarioES.Add("msgUsuarioIncorrecto", "El usuario no existe");
            diccionarioES.Add("msgUsuarioBloqueado", "Ha ingresado demasiadas veces la contraseña");

            diccionarioES.Add("msgGuardarContinuar", "¿Desea guardar los cambios realizados antes de continuar?");
            diccionarioES.Add("msgGuardarObligatorio", "Para continuar debe guardar los cambios. \n¿Desea Guardar cambios?");

            diccionarioES.Add("msgEliminacionTareas", "Algunas tareas se van a eliminar, ¿Esta seguro de eliminarlas?");
            diccionarioES.Add("tituloEliminarTarea", "Tareas a eliminarse");

            diccionarioES.Add("tabPageHorarioGeneral", "Horario general");
            diccionarioES.Add("tabPageHorarioVacacion", "Horario vacación");



            // tooltips

            diccionarioES.Add("toolTipnombreTareaUrgenteImportante", "Estas tareas deben realizarse lo más pronto posible");
            diccionarioES.Add("toolTiptareasNoImportantesNoUrgentes", "Estas tareas son triviales por lo tanto no tienen una fecha límite");
            diccionarioES.Add("toolTiptareasNoImportantesSiUrgentes", "Estas tareas suelen ser interrupciones, no son importantes pero se requiere realizarlas tan pronto como se pueda");
            diccionarioES.Add("toolTiptareasNoUrgentesSiImportantes", "Estas tareas se refieren a 'planificación', es importante pero no se deben realizar instantáneamente");

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
            diccionarioES.Add("Hoy", "Hoy");


            
            //preposiciones

            diccionarioES.Add("de", "de");
            diccionarioES.Add("del", "del");



            // diccionarioES.Add("", "");
        }





    }
}
