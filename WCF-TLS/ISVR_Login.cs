using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TLS_Entidades;

namespace WCF_TLS
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ISVR_Login" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ISVR_Login
    {
        [OperationContract]
        UsuarioLogin Login(string usuario, string clave);

    }
    [DataContract]
    public class UsuarioLogin {
        [DataMember]
        public int idUsuario { get; set; }
        [DataMember]
        public string alias { get; set; }
        [DataMember]
        public string clave { get; set; }
    }

}
