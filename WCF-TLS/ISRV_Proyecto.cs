using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TLS_Entidades;

namespace WCF_TLS
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ISRV_Proyecto" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ISRV_Proyecto
    {
        [OperationContract]
        ResultadoDTO CrearProyecto(string nombreP, DateTime fechaC, bool activo, int idUsuario);

        [OperationContract]
        ResultadoDTO CrearNuevoProyecto(string nombreP, DateTime fechaC, bool activo, int idUsuario);

        [OperationContract]
        List<ProyectoDTO> listarProyectos();

        [OperationContract]
        List<UsuarioDTO> listarUsuariosNoAsignados(int idProyecto);
        
        [OperationContract]
        bool asignarParticipante(ParticipanteDTO dto);

        [OperationContract]
        List<ParticipanteDTO> listarParticipantesAsignados(int idProyecto);

        [OperationContract]
        bool eliminarParticipante(int idParticipante);

    }
}
