using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TLS_Entidades;
using TLS_Datos;

namespace TLS_Negocio
{
    public class ProyectoNegocio
    {
        /// <summary>
        /// en este método creo el proyecto y el participante en una solo instrucción de guardado
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public ResultadoDTO CrearProyecto(Proyecto dto)
        {
            ResultadoDTO r = new ResultadoDTO();

            ProyectoDAL pDAL = new ProyectoDAL();
            Participantes participantes = new Participantes();
            participantes.idUsuario = dto.creadoPor;
            participantes.administrador = 1;
            dto.Participantes.Add(participantes);
            r = pDAL.Crear(dto);
            return r;

        }

        /// <summary>
        /// en este método creo el proyecto y el participante por separado
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public ResultadoDTO CrearNuevoProyecto(Proyecto dto)
        {
            ResultadoDTO r = new ResultadoDTO();
            ResultadoDTO rProyecto = new ResultadoDTO();
            ResultadoDTO rParticipante = new ResultadoDTO();

            ProyectoDAL proyectoDAL = new ProyectoDAL();
            ParticipantesDAL participantesDAL = new ParticipantesDAL(); 

            //creo el proyecto y rescato su id de creación           
            rProyecto = proyectoDAL.Crear(dto);
            
            //Instancio el participante y le paso sus datos
            Participantes participantes = new Participantes();
            participantes.idUsuario = dto.creadoPor;
            participantes.administrador = 1;

            //le asigno al participante el id del pryecto que se acba de crear
            participantes.idProyecto = rProyecto.id??0;
            //guardo el participante en la BDD
            rParticipante = participantesDAL.Crea(participantes);

            //si ninguna de las inserciones da error,  indico que no hay error
            if(!rProyecto.error  && !rParticipante.error)
            { r.error = false; }
            else
            {
                r.error = true;
                r.mensaje = "se ha producido un error al insertar";
            }
           
            return r;

        }


    }
}
