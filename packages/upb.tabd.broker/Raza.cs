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

    public partial class Raza
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Raza()
        {
            this.Mascotas = new HashSet<Mascota>();
        }

        public int IdentRaza { get; set; }

        public Nullable<int> IdEspecie { get; set; }

        public string NombreRaza { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mascota> Mascotas { get; set; }
    }
}
