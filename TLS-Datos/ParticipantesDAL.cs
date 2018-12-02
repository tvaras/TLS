using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TLS_Entidades;

namespace TLS_Datos
{
    public class ParticipantesDAL
    {
        public ResultadoDTO Crea(Participantes dto)
        {
            ResultadoDTO r = new ResultadoDTO();
            try
            {
                using (ATLSEntities dbo = new ATLSEntities())
                {
                    dbo.Participantes.Add(dto);
                    dbo.SaveChanges();
                    r.error = false;
                    r.id = dto.idParticipante;
                }
            }
            catch (Exception e)
            {
                r.error = true;
                r.mensaje = e.Message;
            }
            return r;
        }

        public bool eliminarParticipante(ParticipanteDTO dto) {
            Participantes entidad = new Participantes
            {
                idParticipante = dto.idParticipante,
                idProyecto = dto.idProyecto,
                idUsuario = dto.idUsuario,
                administrador = dto.administrador
            };

            using (ATLSEntities dbo = new ATLSEntities())
            {
                dbo.Participantes.Attach(entidad);
                entidad = dbo.Participantes.Remove(entidad);
                dbo.SaveChanges();
                return true;
            }
        }

        public bool asignarParticipante(ParticipanteDTO dto)
        {
            Participantes entidad = new Participantes
            {
                idProyecto = dto.idProyecto,
                idUsuario = dto.idUsuario,
                administrador = dto.administrador
            };

            using (ATLSEntities dbo = new ATLSEntities())
            {
                dbo.Participantes.Add(entidad);
                dbo.SaveChanges();
                return true;
            }
        }

        public ParticipanteDTO buscarParticipante(int idParticipante)
        {
            ParticipanteDTO entidad = new ParticipanteDTO();
            using (ATLSEntities dbo = new ATLSEntities())
            {
                entidad = (from par in dbo.Participantes
                         join pro in dbo.Proyecto on par.idProyecto equals pro.idProyecto
                         join usu in dbo.Usuario on par.idUsuario equals usu.idUsuario
                         where par.idParticipante == idParticipante
                         select
                          new ParticipanteDTO
                          {
                              idUsuario = usu.idUsuario,
                              nombreProyecto = pro.nombreProyecto,
                              alias = usu.alias,
                              idParticipante = par.idParticipante,
                              idProyecto = pro.idProyecto,
                              administrador = par.administrador
                          }).FirstOrDefault<ParticipanteDTO>();
            }
            return entidad;
        }

        public List<ParticipanteDTO> listarParticipantesAsignados(int idProyecto)
        {
            List<ParticipanteDTO> lista = new List<ParticipanteDTO>();
            using (ATLSEntities dbo = new ATLSEntities())
            {
                lista = (from par in dbo.Participantes
                         join pro in dbo.Proyecto on par.idProyecto equals pro.idProyecto
                         join usu in dbo.Usuario on par.idUsuario equals usu.idUsuario
                         where par.idProyecto == idProyecto
                         select
                          new ParticipanteDTO
                          {
                              idUsuario = usu.idUsuario,
                              nombreProyecto = pro.nombreProyecto,
                              alias = usu.alias,
                              idParticipante = par.idParticipante,
                              idProyecto = pro.idProyecto,
                              administrador = par.administrador
                          }).ToList();
            }
            return lista;
        }
    }
}
