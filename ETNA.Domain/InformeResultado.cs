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
    
    public partial class InformeResultado
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string FechaElaboracion { get; set; }
        public string FechaTabIni { get; set; }
        public string FechaTabFin { get; set; }
        public string DetalleAnalisis { get; set; }
    
        public virtual Empleado ElaboradoPor { get; set; }
        public virtual Plantilla Plantilla { get; set; }
    }
}