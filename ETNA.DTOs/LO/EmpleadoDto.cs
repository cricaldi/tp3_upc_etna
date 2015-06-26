using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ETNA.DTOs.LO
{
    [DataContract]
    public class EmpleadoDto
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Nombres { get; set; }
        [DataMember]
        public string Apellidos { get; set; }
    }
}
