using System.Runtime.Serialization;
using ETNA.Domain;

namespace ETNA.DTOs.PV
{
    [DataContract]
    public class ReclamoDto
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string CodigoReclamo { get; set; }
        [DataMember]
        public System.DateTime FechaHoraReclamo { get; set; }
        [DataMember]
        public string Motivo { get; set; }
        [DataMember]
        public string Detalle { get; set; }
        [DataMember]
        public string Observaciones { get; set; }
        [DataMember]
        public System.DateTime FechaRespuesta { get; set; }
        [DataMember]
        public int IdFacturaDetalle { get; set; }
        [DataMember]
        public string Estado { get; set; }
        [DataMember] 
        public string NombreRegistrador { get; set; }
        [DataMember]
        public string DescripcionEstado { get; set; }
        [DataMember] 
        public string NumeroFactura { get; set; }
        [DataMember]
        public string NombreProducto { get; set; }
        [DataMember] 
        public string NombreCliente { get; set; }
       
    }
    }
    
