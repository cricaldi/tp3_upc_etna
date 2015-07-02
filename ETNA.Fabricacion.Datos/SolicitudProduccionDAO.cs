using System;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
    public class SolicitudProduccionDAO
    {
        static readonly ConexionDAO Cn = new ConexionDAO();

        readonly SqlConnection _objCn = Cn.Conecta();

        public DataTable GetSolicitudesProduccion(string codEstado)
        {
            try
            {
                var da = new SqlDataAdapter();
                var tabla = new DataTable();

                _objCn.Open();

                var cmd = new SqlCommand("usp_getSolicitudes", _objCn);
                cmd.Parameters.Add(new SqlParameter("@cod_estado", codEstado));
                cmd.CommandType = CommandType.StoredProcedure;
                da.SelectCommand = cmd;
                da.Fill(tabla);


                return tabla;


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                _objCn.Close();
            }

        }

        public DataTable GetSolicitudProduccion(string codSolicit)
        {
            try
            {
                var da = new SqlDataAdapter();
                var tabla = new DataTable();

                _objCn.Open();

                var cmd = new SqlCommand("usp_getSolicitud", _objCn);
                cmd.Parameters.Add(new SqlParameter("@cod_sol", codSolicit));
                cmd.CommandType = CommandType.StoredProcedure;
                da.SelectCommand = cmd;
                da.Fill(tabla);


                return tabla;
            }
            finally 
            {
                _objCn.Close();
            }
        }

        public DataTable GetPersonal(string codSolicitud)
        {
            try
            {
                var da = new SqlDataAdapter();
                var tabla = new DataTable();

                _objCn.Open();

                var cmd = new SqlCommand("usp_getPersonal", _objCn);
                cmd.Parameters.Add(new SqlParameter("@cod_sol", codSolicitud));
                cmd.CommandType = CommandType.StoredProcedure;
                da.SelectCommand = cmd;
                da.Fill(tabla);


                return tabla;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                _objCn.Close();
            }
        }

        public DataTable GetInsumos(string codSolicitud)
        {
            try
            {
                var da = new SqlDataAdapter();
                var tabla = new DataTable();

                _objCn.Open();

                var cmd = new SqlCommand("usp_getInsumos", _objCn);
                cmd.Parameters.Add(new SqlParameter("@cod_sol", codSolicitud));
                cmd.CommandType = CommandType.StoredProcedure;
                da.SelectCommand = cmd;
                da.Fill(tabla);


                return tabla;
            }
            finally
            {
                _objCn.Close();
            }
        }

        public DataTable GetMaquinarias(string codSolicitud)
        {
            try
            {
                var da = new SqlDataAdapter();
                var tabla = new DataTable();

                _objCn.Open();

                var cmd = new SqlCommand("usp_getMaquinarias", _objCn);
                cmd.Parameters.Add(new SqlParameter("@cod_sol", codSolicitud));
                cmd.CommandType = CommandType.StoredProcedure;
                da.SelectCommand = cmd;
                da.Fill(tabla);


                return tabla;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                _objCn.Close();
            }
        }

        public void CambiarEstadoSolicitud(string codSolicitud, string codEstado, string sObservaciones)
        {
            var cmd = new SqlCommand("usp_updateEstadoSolicitudProduccion", _objCn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.Add("@cod_sol", SqlDbType.Char, 3).Value = codSolicitud;
            cmd.Parameters.Add("@estado_sol", SqlDbType.Char, 1).Value = codEstado;
            cmd.Parameters.Add("@observaciones_sol", SqlDbType.Char, 1).Value = sObservaciones;


            _objCn.Open();

            try
            {
                var i = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // ignored
            }
            finally
            {
                _objCn.Close();
            }

           
        }



        public string GenerarLoteOrdenTrabajo(string codSolicitud)
        {

            var sResultado = "";

            var cmd = new SqlCommand("generar_lote_ordenes_Trabajo", _objCn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.Add("@cod_sol", SqlDbType.Char, 3).Value = codSolicitud;
            cmd.Parameters.Add("@resultado", SqlDbType.Int).Direction = ParameterDirection.Output;

            _objCn.Open();

            try
            {
                var i = cmd.ExecuteNonQuery();

                sResultado = Convert.ToString(cmd.Parameters["@resultado"].Value);

               // mensaje = i == 0 ? "Error al registrar al cambiar el estado de la solicitud proveedor" : "Solicitud actualizada con exito";

            }
            catch (Exception ex)
            {
                // ignored
            }
            finally
            {
                _objCn.Close();
            }

            return sResultado;

        }
    }
}
