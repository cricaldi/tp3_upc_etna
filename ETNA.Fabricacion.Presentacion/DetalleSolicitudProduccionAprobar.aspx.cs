using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessEntitiesLayer;
using BusinessLayer;

namespace PresentationLayer
{
    public partial class DetalleSolicitudProduccionAprobar : System.Web.UI.Page
    {
        SolicitudProduccionBL objSolicitudProduccionBL = new SolicitudProduccionBL();
        static string cod_Solicitud;
        bool erroresValidacion = false;
       

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                try
                {
                    cod_Solicitud = Request.QueryString["codigoSolicitud"].ToString();

                    SolicitudProduccionBE objSolicitPx = objSolicitudProduccionBL.getSolicitudProduccion(cod_Solicitud);

                    lblIdSolicitud.Text = objSolicitPx.IdSolicitud;
                    lblFechaSolicitud.Text = objSolicitPx.FechaSolicitud.ToShortDateString();
                    lblDescripcionSolicitud.Text = objSolicitPx.Descripcion;
                    lblNombreSolicitud.Text = objSolicitPx.Glosa;

                    cargarGrillas();



                }
                catch (Exception)
                {

                    throw;
                }
            }

        }



        protected void btnAprobar_Click(object sender, EventArgs e)
        {
            try
            {
               

                cargarGrillas();
               
                btnAprobar.Visible = false;
                   
                var cantidad =  objSolicitudProduccionBL.generarLoteOrdenTrabajo(cod_Solicitud);

                lblMensaje.InnerText = "Se ha generado el lote Numero " + cantidad.Trim();

                ScriptManager.RegisterStartupScript(this, this.GetType(), "", "alerta1_Aprobar();", true);
               
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        protected void gvInsumo_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            try
            {
               
                validarSolicitud(e);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        protected void gvMaquinaria_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            try
            {
                                validarSolicitud(e);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        protected void gvPersonal_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            try
            {
               

                validarSolicitud(e);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void cargarGrillas()
        {
            try
            {
                gvInsumo.DataSource = objSolicitudProduccionBL.getInsumos(cod_Solicitud);
                gvInsumo.DataBind();

                gvMaquinaria.DataSource = objSolicitudProduccionBL.getMaquinarias(cod_Solicitud);
                gvMaquinaria.DataBind();

                gvPersonal.DataSource = objSolicitudProduccionBL.getPersonal(cod_Solicitud);
                gvPersonal.DataBind();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void validarSolicitud(GridViewRowEventArgs e)
        {
            try
            {

                if (e.Row.RowType == DataControlRowType.DataRow)
                {

                    var cResultado = Convert.ToInt32(e.Row.Cells[6].Text);

                    var vImgCheck = (Image)e.Row.FindControl("imgCheck");
                    var vImgX = (Image)e.Row.FindControl("imgX");

                    if (cResultado != 0)
                        vImgCheck.Visible = true;
                    else
                    {
                        vImgX.Visible = true;
                        erroresValidacion = true;
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