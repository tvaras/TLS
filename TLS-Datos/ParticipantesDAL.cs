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
    }
}
