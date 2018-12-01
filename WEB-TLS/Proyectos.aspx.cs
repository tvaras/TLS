using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TLS_Entidades;

namespace WEB_TLS
{
    public partial class Proyectos : System.Web.UI.Page
    {
        ProyectosServiceReference.ISRV_Proyecto service = new ProyectosServiceReference.SRV_ProyectoClient();
        List<ProyectoDTO> lista = new List<ProyectoDTO>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Session["CURRENT_USER"] == null)
                {

                    Response.Redirect("~/FRM_Login");
                }
                else
                {

                    listarProyectos();
                    //listarModelos();
                }
            }

        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            int idUsuario = ((SVR_Login.UsuarioLogin) Session["CURRENT_USER"]).idUsuario;
            ResultadoDTO resultado = service.CrearNuevoProyecto(txtNombreProyecto.Text, DateTime.Now, true, idUsuario);
            listarProyectos();
        }

        void listarProyectos() {

            List<ProyectoDTO> lista = service.listarProyectos();
            GridView1.DataSource = Utils.ToDataTable<ProyectoDTO>(lista);
            GridView1.DataBind();
        }
    }
}