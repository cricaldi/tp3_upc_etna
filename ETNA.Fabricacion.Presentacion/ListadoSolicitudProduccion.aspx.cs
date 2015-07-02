using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

namespace PresentationLayer
{
    public partial class ListadoSolicitudProduccion : Page
    {
        SolicitudProduccionBL objSolicitudProduccionBL = new SolicitudProduccionBL();
        static string cod_Estado;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                try
                {
                    cod_Estado = Request.QueryString["codigoEstado"].ToString();

                    switch (cod_Estado)
                    {
                        case "1": lblTitulo.InnerText = "Listado de Solicitudes de Produccion Pendientes de Validación";
                            break;
                        case "2":
                            break;
                        case "3": lblTitulo.InnerText = "Listado de Solicitudes de Produccion Pendientes de Aprobación";
                            break;
                        default:
                            break;
                    }


                gvSolicitudesProduccion.DataSource = objSolicitudProduccionBL.getSolicitudesProduccion(cod_Estado);
                gvSolicitudesProduccion.AllowPaging = true;
                gvSolicitudesProduccion.PageSize = 10;
                gvSolicitudesProduccion.DataBind();

                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        protected void gvProveedores_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            try
            {
                gvSolicitudesProduccion.PageIndex = e.NewPageIndex;
                gvSolicitudesProduccion.DataSource = objSolicitudProduccionBL.getSolicitudesProduccion(cod_Estado);
                gvSolicitudesProduccion.DataBind();
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
           
        }

        protected void gvSolicitudesProduccion_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == "Select") 
                {
                    var num = Convert.ToInt16(e.CommandArgument);

                   var cod_Solicitud = gvSolicitudesProduccion.Rows[num].Cells[1].Text;

                   switch (cod_Estado)
                   {
                       case "1": Response.Redirect("DetalleSolicitudProduccion.aspx?codigoSolicitud=" + cod_Solicitud, false); ;
                           break;
                       case "2":
                           break;
                       case "3": Response.Redirect("DetalleSolicitudProduccionAprobar.aspx?codigoSolicitud=" + cod_Solicitud, false);
                           break;
                       default:
                           break;
                   }

                   
                
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

       

       


    }
}