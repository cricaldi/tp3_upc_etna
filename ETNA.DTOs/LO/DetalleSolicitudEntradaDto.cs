using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ETNA.DTOs.LO
{
    [DataContract]
    public class DetalleSolicitudEntradaDto
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string NombreProducto { get; set; }
        [DataMember]
        public int Cantidad { get; set; }
    }
}
