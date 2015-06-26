using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETNA.DAL;
using ETNA.Domain;

namespace ETNA.BL.LO
{
    public class GestorSolicitudesSalida
    {

        public List<SolicitudSalida> ObtenerSolicitudesSalida(int idSolicitud, int estadoSolicitud,
            DateTime fechaInicio, DateTime fechaFin, int idEmpleado, string tipoSalida, string direccionEntrega, 
            string razonSocialDestinatario)
        {
            var context = new ETNADbModelContainer();
            return context.SolicitudSalidaConjunto.Where(s =>
                (idSolicitud == 0 || s.Id == idSolicitud) &&
                (estadoSolicitud == 0 || s.Estado == estadoSolicitud) &&
                (fechaInicio == DateTime.MinValue || s.FechaElaboracion >= fechaInicio) &&
                (fechaFin == DateTime.MinValue || s.FechaElaboracion <= fechaInicio) &&
                (tipoSalida.Equals("") || s.TipoSalida.Equals(tipoSalida)) &&
                (direccionEntrega.Equals("") || s.DireccionEntrega.Equals(direccionEntrega)) &&
                (razonSocialDestinatario.Equals("") || s.RazonSocialDestinatario.Equals(razonSocialDestinatario)) &&
                (idEmpleado == 0 || s.Empleado.Id == idEmpleado)
                ).ToList();
        }

        public SolicitudSalida ObtenerSolicitudSalida(int idSolicitud)
        {
            var context = new ETNADbModelContainer();
            return context.SolicitudSalidaConjunto.Find(idSolicitud);
        }
    }
}
