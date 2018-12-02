using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TLS_Entidades;

namespace WEB_TLS
{
    public partial class Participantes : System.Web.UI.Page
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

        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            lista = service.listarProyectos();
            int idProyecto = lista[e.NewSelectedIndex].idProyecto;
            lblIdProyecto.Text = "" + idProyecto;

            listarUsuarios(idProyecto);

            Panel1.Visible = true;
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            //int idUsuario = ((SVR_Login.UsuarioLogin)Session["CURRENT_USER"]).idUsuario;
            //ResultadoDTO resultado = service.CrearNuevoProyecto(txtNombreProyecto.Text, DateTime.Now, true, idUsuario);
            ParticipanteDTO dto = new ParticipanteDTO {
                idProyecto = int.Parse(lblIdProyecto.Text),
                idUsuario = int.Parse(cbParticipantes.SelectedValue),
                administrador = (chkAdmin.Checked ? 1 : 0)
            };
            bool resultado = service.asignarParticipante(dto);
            listarProyectos();
            listarUsuarios(int.Parse(lblIdProyecto.Text));
        }

        void listarProyectos()
        {

            List<ProyectoDTO> lista = service.listarProyectos();
            GridView1.DataSource = Utils.ToDataTable<ProyectoDTO>(lista);
            GridView1.DataBind();
        }

        void listarUsuarios(int idProyecto)
        {

            List<UsuarioDTO> listaParticipantes = service.listarUsuariosNoAsignados(idProyecto);
            cbParticipantes.DataSource = Utils.ToDataTable<UsuarioDTO>(listaParticipantes);
            cbParticipantes.DataValueField = "idUsuario";
            cbParticipantes.DataTextField = "alias";
            cbParticipantes.DataBind();
        }
    }
}