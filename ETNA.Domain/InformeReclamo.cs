//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ETNA.Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class InformeReclamo
    {
        public int Id { get; set; }
        public string CodigoInforme { get; set; }
        public string Descripcion { get; set; }
        public string DetalleInforme { get; set; }
        public System.DateTime FechaAprobacion { get; set; }
        public System.DateTime FechaElaboracion { get; set; }
        public string ObservacionAprobador { get; set; }
        public string Estado { get; set; }
    
        public virtual Reclamo Reclamo { get; set; }
        public virtual Empleado ElaboradoPor { get; set; }
        public virtual Empleado AprobadoPor { get; set; }
    }
}