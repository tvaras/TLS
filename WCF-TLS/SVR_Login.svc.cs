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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "SVR_Login" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione SVR_Login.svc o SVR_Login.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class SVR_Login : ISVR_Login
    {
        public UsuarioLogin Login(string usuario, string clave)
        {
            UsuarioLogin uLogin = new UsuarioLogin();
            Usuario uUser = new Usuario();
            UsuarioNegocio uNegocio = new UsuarioNegocio();

            uUser = uNegocio.Buscar(usuario, clave);
            if (uUser != null) {
                uLogin.idUsuario = uUser.idUsuario;
                uLogin.alias = uUser.alias;
            }
            return uLogin;
        }

    }
}
