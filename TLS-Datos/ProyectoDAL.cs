using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TLS_Entidades;

namespace TLS_Datos
{
    public class ProyectoDAL
    {

        public ResultadoDTO Crear(Proyecto dto)
        {
            ResultadoDTO r = new ResultadoDTO();
            try
            {
                using (ATLSEntities dbo = new ATLSEntities())
                {
                    dbo.Proyecto.Add(dto);
                    dbo.SaveChanges();
                    r.error = false;
                    r.id = dto.idProyecto;
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
