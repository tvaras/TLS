using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TLS_Entidades;

namespace TLS_Datos
{
    public class UsuarioDAL
    {
        public ResultadoDTO Crear(Usuario dto) {
            ResultadoDTO r = new ResultadoDTO();
            try
            {
                using (ATLSEntities dbo = new ATLSEntities())
                {
                    dbo.Usuario.Add(dto);
                    dbo.SaveChanges();
                    r.error = false;
                    r.id = dto.idUsuario;
                }
            }
            catch (Exception e) {
                r.error = true;
                r.mensaje = e.Message;
            }
            return r;
        }

        public Usuario Buscar(Usuario user) {
            Usuario usuario = new Usuario();
            using (ATLSEntities dbo = new ATLSEntities()) {
                usuario = dbo.Usuario.FirstOrDefault(u => u.nombreUsuario == user.nombreUsuario
                    && u.clave == user.clave);
            }
            return usuario;

        }

        public Usuario Buscar(string user, string clave)
        {
            Usuario usuario = new Usuario();
            using (ATLSEntities dbo = new ATLSEntities())
            {
                usuario = dbo.Usuario.FirstOrDefault(u => u.nombreUsuario == user
                    && u.clave == clave);
            }
            return usuario;

        }

        public List<Lista> Listar() {
            List<Lista> lista = new List<Lista>();
            using (ATLSEntities dbo = new ATLSEntities())
            {
                lista = (from l in dbo.Usuario
                         select
                         new Lista {id = l.idUsuario, texto=l.nombreUsuario }).ToList();
            }
            return lista;
        }
    }
}
