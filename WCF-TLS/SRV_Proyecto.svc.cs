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
        public ResultadoDTO CrearProyecto(string nombreP, DateTime fechaC, bool activo, int idUsuario)
        {
            Proyecto proyecto = new Proyecto()
            { nombreProyecto = nombreP,
                fechaCreacion = fechaC,
                activo = activo,
                creadoPor = idUsuario};

            ProyectoNegocio pNeg = new ProyectoNegocio();
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

            ProyectoNegocio pNeg = new ProyectoNegocio();
            ResultadoDTO r = new ResultadoDTO();

            r = pNeg.CrearNuevoProyecto(proyecto);

            return r;
        }
    }
}
