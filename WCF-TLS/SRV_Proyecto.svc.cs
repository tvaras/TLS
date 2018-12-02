using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TLS_Entidades;
using TLS_Negocio;


namespace WCF_TLS
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "SRV_Proyecto" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione SRV_Proyecto.svc o SRV_Proyecto.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class SRV_Proyecto : ISRV_Proyecto
    {
        ProyectoNegocio pNeg = new ProyectoNegocio();
        UsuarioNegocio uNeg = new UsuarioNegocio();

        public ResultadoDTO CrearProyecto(string nombreP, DateTime fechaC, bool activo, int idUsuario)
        {
            Proyecto proyecto = new Proyecto()
            { nombreProyecto = nombreP,
                fechaCreacion = fechaC,
                activo = activo,
                creadoPor = idUsuario};
            
            ResultadoDTO r = new ResultadoDTO();

            r = pNeg.CrearProyecto(proyecto);

            return r;
        }

        public ResultadoDTO CrearNuevoProyecto(string nombreP, DateTime fechaC, bool activo, int idUsuario)
        {
            Proyecto proyecto = new Proyecto()
            {
                nombreProyecto = nombreP,
                fechaCreacion = fechaC,
                activo = activo,
                creadoPor = idUsuario
            };
            
            ResultadoDTO r = new ResultadoDTO();

            r = pNeg.CrearNuevoProyecto(proyecto);

            return r;
        }

        public List<ProyectoDTO> listarProyectos()
        {
            return pNeg.listarProyectos();
        }

        public List<UsuarioDTO> listarUsuariosNoAsignados(int idProyecto) {

            return uNeg.listarUsuariosNoAsignados(idProyecto);
        }

        public bool asignarParticipante(ParticipanteDTO dto) {

            return pNeg.asignarParticipante(dto);
        }

        public List<ParticipanteDTO> listarParticipantesAsignados(int idProyecto)
        {

            return pNeg.listarParticipantesAsignados(idProyecto);
        }

        public bool eliminarParticipante(int idParticipante)
        {
            return pNeg.eliminarParticipante(idParticipante);
        }

    }
}
