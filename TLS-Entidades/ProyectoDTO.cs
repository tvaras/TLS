using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TLS_Entidades
{
    public class ProyectoDTO
    {
        public int idProyecto { get; set; }
        public string nombreProyecto { get; set; }
        public System.DateTime fechaCreacion { get; set; }
        public bool activo { get; set; }
        public int creadoPor { get; set; }
        public string aliasCreador { get; set; }
    }
}
