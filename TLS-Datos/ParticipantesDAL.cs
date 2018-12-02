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
    }
}
