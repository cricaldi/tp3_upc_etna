using System;
using System.Data;
using BusinessEntitiesLayer;
using DataLayer;

namespace BusinessLayer
{
    public class SolicitudProduccionBL
    {

        SolicitudProduccionDAO objSolicitudProduccion = new SolicitudProduccionDAO();

        public DataTable getSolicitudesProduccion(string cod_Estado)
        {
            return objSolicitudProduccion.GetSolicitudesProduccion(cod_Estado);
        }



        public SolicitudProduccionBE getSolicitudProduccion(string cod_Solicitud)
        {
            try
            {
                DataTable dtSolicitudProduccion = objSolicitudProduccion.GetSolicitudProduccion(cod_Solicitud);
                DataRow dr = dtSolicitudProduccion.Rows[0];


                var objSolicitudProduccionBE = new SolicitudProduccionBE();
                objSolicitudProduccionBE.IdSolicitud = dr["COD_SOL"].ToString().Trim();
                objSolicitudProduccionBE.Descripcion = dr["DESCRIPCION"].ToString().Trim();
                objSolicitudProduccionBE.FechaSolicitud = DateTime.Parse(dr["FEC_SOL"].ToString().Trim());
                objSolicitudProduccionBE.Glosa = dr["GLOSA"].ToString().Trim();

                return objSolicitudProduccionBE;

            }
            catch (Exception)
            {
                
                throw;
            }

           
        }

        public DataTable getPersonal(string cod_Solicitud)
        {
            try
            {
                return objSolicitudProduccion.GetPersonal(cod_Solicitud);
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable getInsumos(string cod_Solicitud)
        {
            try
            {
                return objSolicitudProduccion.GetInsumos(cod_Solicitud);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable getMaquinarias(string cod_Solicitud)
        {
            try
            {
                return objSolicitudProduccion.GetMaquinarias(cod_Solicitud);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void cambiarEstadoSolicitud(string cod_Solicitud, string cod_Estado, string sObservaciones)
        {
            try
            {
                objSolicitudProduccion.CambiarEstadoSolicitud(cod_Solicitud, cod_Estado, sObservaciones);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public string generarLoteOrdenTrabajo(string cod_Solicitud)
        {
            try
            {
                return objSolicitudProduccion.GenerarLoteOrdenTrabajo(cod_Solicitud);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
