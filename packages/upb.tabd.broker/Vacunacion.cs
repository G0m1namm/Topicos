//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace upb.tabd.broker
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vacunacion
    {
        public decimal NroVacunacion { get; set; }
        public Nullable<long> IdVacuna { get; set; }
        public Nullable<long> IdMascota { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<int> Orden { get; set; }
    
        public virtual Mascota Mascota { get; set; }
        public virtual Vacuna Vacuna { get; set; }
    }
}