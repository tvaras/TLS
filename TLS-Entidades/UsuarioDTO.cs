using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TLS_Entidades
{
    public class UsuarioDTO
    {
        public int idUsuario { get; set; }
        public string nombreUsuario { get; set; }
        public string alias { get; set; }
        public string clave { get; set; }
    }
}
