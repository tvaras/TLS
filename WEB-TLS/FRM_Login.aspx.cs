using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEB_TLS
{
    public partial class FRM_Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            string usu = txtUsuario.Text;
            string cla = txtClave.Text;

            SVR_Login.UsuarioLogin usLogin = new SVR_Login.UsuarioLogin();
            SVR_Login.SVR_LoginClient svCli = new SVR_Login.SVR_LoginClient();

            usLogin = svCli.Login(usu, cla);
            


        }
    }
}