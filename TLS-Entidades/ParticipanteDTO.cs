using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TLS_Entidades
{
    public class ParticipanteDTO
    {
        public int idParticipante { get; set; }
        public int idProyecto { get; set; }
        public int idUsuario { get; set; }
        public int administrador { get; set; }
    }
}
