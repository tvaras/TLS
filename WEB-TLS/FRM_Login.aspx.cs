using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TLS_Entidades;

namespace WEB_TLS
{
    public partial class FRM_Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Clear();
            if (Request.Params.Get("msg") != null)
            {

                if (Request.Params.Get("msg").Equals("401"))
                {
                    lblMsg.Text = Constantes.ERROR_CREDENCIALES;
                    lblMsg.ForeColor = System.Drawing.Color.Red;
                }
                else if (Request.Params.Get("msg").Equals("412"))
                {
                    lblMsg.Text = Constantes.LOGIN_REQUIRIDO;
                    lblMsg.ForeColor = System.Drawing.Color.Red;
                }
                else if (Request.Params.Get("msg").Equals("200"))
                {
                    lblMsg.Text = Constantes.SESSION_FINALIZADA;
                    lblMsg.ForeColor = System.Drawing.Color.Green;
                }
            }
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            string usu = txtUsuario.Text;
            string cla = txtClave.Text;

            SVR_Login.UsuarioLogin usLogin = new SVR_Login.UsuarioLogin();
            SVR_Login.SVR_LoginClient svCli = new SVR_Login.SVR_LoginClient();


            string path = "";
            try
            {

                usLogin = svCli.Login(usu, cla);

                if (usLogin != null) {

                    Session["CURRENT_USER"] = usLogin;
                    path = "~/";

                }
                else
                {

                    path = "~/FRM_Login?msg=401";
                }
            }
            catch (Exception e1)
            {
                path = "~/FRM_Login?msg=412";
            }

            Response.Redirect(path);

        }
    }
}