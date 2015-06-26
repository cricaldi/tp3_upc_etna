using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ETNA.DTOs.LO
{
    [DataContract]
    public class ListaSolicitudSalidaDto
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public DateTime FechaElaboracion { get; set; }

        [DataMember]
        public string TipoSalida { get; set; }

        [DataMember]
        public string NombreEmpleado { get; set; }

        [DataMember]
        public string DireccionEntrega { get; set; }

        [DataMember]
        public string RazonSocialDestinatario { get; set; }
            
    }
}
