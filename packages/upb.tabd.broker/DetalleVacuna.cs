﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace upb.tabd.broker
{
    using System;
    using System.Collections.Generic;

    public partial class DetalleVacuna
    {
        public int IdentDetalleVacuna { get; set; }
        public int IdentVacuna { get; set; }
        public double Orden { get; set; }
        public int IdentMascota { get; set; }
        public System.DateTime Fecha { get; set; }

        public virtual Mascota Mascota { get; set; }
        public virtual Vacuna Vacuna { get; set; }
    }
}
