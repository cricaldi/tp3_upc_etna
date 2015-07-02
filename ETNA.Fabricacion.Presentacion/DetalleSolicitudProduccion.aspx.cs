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
    public partial class DetalleSolicitudProduccion : System.Web.UI.Page
    {
        readonly SolicitudProduccionBL _objSolicitudProduccionBl = new SolicitudProduccionBL();
        static string _codSolicitud;
        bool _erroresValidacion =false;
        bool _validar = false;
        
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                try
                {
                    _codSolicitud = Request.QueryString["codigoSolicitud"].ToString();

                    SolicitudProduccionBE objSolicitPx =  _objSolicitudProduccionBl.getSolicitudProduccion(_codSolicitud);

                    lblIdSolicitud.Text = objSolicitPx.IdSolicitud;
                    lblFechaSolicitud.Text = objSolicitPx.FechaSolicitud.ToShortDateString();
                    lblDescripcionSolicitud.Text = objSolicitPx.Descripcion;
                    lblNombreSolicitud.Text = objSolicitPx.Glosa;

                    CargarGrillas();                               
                    
                    

                }
                catch (Exception)
                {

                    throw;
                }
            }
                      
        }

      

        protected void btnValidar_Click(object sender, EventArgs e)
        {
            try
            {
                _validar = true;

                CargarGrillas();

                if (_erroresValidacion)
                {
                    btnValidar.Visible = false;
                    btnForzarValidacion.Visible = true;
                    btnRechazar.Visible = true;

                    ScriptManager.RegisterStartupScript(this, this.GetType(), "", "alerta2();", true);
                }
                else 
                {

                    _objSolicitudProduccionBl.cambiarEstadoSolicitud(_codSolicitud, "3", "");

                    ScriptManager.RegisterStartupScript(this, this.GetType(), "", "alerta1();", true);
                }
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
                if (!_validar) return;

                ValidarSolicitud(e);

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
                if (!_validar) return;

                ValidarSolicitud(e);

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
                if (!_validar) return;

                ValidarSolicitud(e);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void CargarGrillas()
        {
            gvInsumo.DataSource = _objSolicitudProduccionBl.getInsumos(_codSolicitud);
            gvInsumo.DataBind();

            gvMaquinaria.DataSource = _objSolicitudProduccionBl.getMaquinarias(_codSolicitud);
            gvMaquinaria.DataBind();

            gvPersonal.DataSource = _objSolicitudProduccionBl.getPersonal(_codSolicitud);
            gvPersonal.DataBind();
        }

        private void ValidarSolicitud(GridViewRowEventArgs e)
        {
            try
            {
                if (e.Row.RowType != DataControlRowType.DataRow) return;
                var cResultado = Convert.ToInt32(e.Row.Cells[6].Text);

                var vImgCheck = (Image)e.Row.FindControl("imgCheck");
                var vImgX = (Image)e.Row.FindControl("imgX");

                if (cResultado != 0)
                    vImgCheck.Visible = true;
                else
                {
                    vImgX.Visible = true;
                    _erroresValidacion = true;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        protected void btnRechazar_Click(object sender, EventArgs e)
        {
            try
            {

                var sObservaciones = hdObservaciones.Value;

                _objSolicitudProduccionBl.cambiarEstadoSolicitud(_codSolicitud, "2", sObservaciones);

                ScriptManager.RegisterStartupScript(this, this.GetType(), "", "alerta3();", true);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        protected void btnForzarValidacion_Click(object sender, EventArgs e)
        {
            _objSolicitudProduccionBl.cambiarEstadoSolicitud(_codSolicitud, "3","");

            ScriptManager.RegisterStartupScript(this, this.GetType(), "", "alerta1();", true);
        }

      
    }
}